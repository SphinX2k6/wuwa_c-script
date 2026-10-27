using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.ActorFxEmote
{
	// Token: 0x02005EEC RID: 24300
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActorFxEmoteController : ControllerBase
	{
		// Token: 0x0603DBF8 RID: 252920 RVA: 0x00EED343 File Offset: 0x00EEB543
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			return true;
		}

		// Token: 0x0603DBF9 RID: 252921 RVA: 0x00EED362 File Offset: 0x00EEB562
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			this.StopAll();
			return true;
		}

		// Token: 0x0603DBFA RID: 252922 RVA: 0x00EED388 File Offset: 0x00EEB588
		public int Play(int entityId, long fxEmoteId, string socketName, global::Vector relativePosition, global::Rotator relativeRotation, global::Vector scale)
		{
			BaseGameplayCueComponent cueComp = this.GetCueComp(entityId);
			if (cueComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[ActorFxEmote] 播放失败：找不到 GameplayCue 组件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			string text = socketName ?? "__default";
			ActorFxEmoteData orCreateEntityData = ActorFxEmoteModel.Instance.GetOrCreateEntityData(entityId);
			this.RemoveSocketHandle(orCreateEntityData, cueComp, text);
			if (cueComp.GetCueByCueId(fxEmoteId) != null)
			{
				this.RemoveHandlesByCueId(orCreateEntityData, cueComp, fxEmoteId);
			}
			GameplayCueBase cueByCueId = cueComp.GetCueByCueId(fxEmoteId);
			GameplayCueParam value = new GameplayCueParam
			{
				RelativePositionOverride = new FVector?(new FVector((float)relativePosition.X, (float)relativePosition.Y, (float)relativePosition.Z)),
				RelativeRotationOverride = new FVector?(new FVector(relativeRotation.Pitch, relativeRotation.Yaw, relativeRotation.Roll)),
				ScaleOverride = new FVector?(new FVector((float)scale.X, (float)scale.Y, (float)scale.Z))
			};
			if (!string.IsNullOrEmpty(socketName))
			{
				value.SocketNameOverride = socketName;
			}
			int num = cueComp.AddCue(fxEmoteId, new GameplayCueParam?(value));
			if (num == 0 || num == -1)
			{
				return 0;
			}
			if (cueByCueId != null)
			{
				GameplayCueBase cueByHandle = cueComp.GetCueByHandle((long)num);
				if (cueByHandle != null)
				{
					ActorFxEmoteController.GameplayCueEffectOverrideImpl @override = new ActorFxEmoteController.GameplayCueEffectOverrideImpl
					{
						SocketName = socketName,
						RelativePosition = new FVector?(new FVector((float)relativePosition.X, (float)relativePosition.Y, (float)relativePosition.Z)),
						RelativeRotation = new FVector?(new FVector(relativeRotation.Pitch, relativeRotation.Yaw, relativeRotation.Roll)),
						Scale = new FVector?(new FVector((float)scale.X, (float)scale.Y, (float)scale.Z))
					};
					cueByHandle.OnGameplayCueEffectOverride(@override);
				}
			}
			orCreateEntityData.SocketHandles[text] = num;
			return num;
		}

		// Token: 0x0603DBFB RID: 252923 RVA: 0x00EED56C File Offset: 0x00EEB76C
		public void StopSocket(int entityId, string socketName)
		{
			ActorFxEmoteData entityData = ActorFxEmoteModel.Instance.GetEntityData(entityId);
			if (entityData == null)
			{
				return;
			}
			BaseGameplayCueComponent cueComp = this.GetCueComp(entityId);
			if (cueComp == null)
			{
				return;
			}
			this.RemoveSocketHandle(entityData, cueComp, socketName ?? "__default");
		}

		// Token: 0x0603DBFC RID: 252924 RVA: 0x00EED5A8 File Offset: 0x00EEB7A8
		public void StopEntity(int entityId)
		{
			ActorFxEmoteData entityData = ActorFxEmoteModel.Instance.GetEntityData(entityId);
			if (entityData == null)
			{
				return;
			}
			BaseGameplayCueComponent cueComp = this.GetCueComp(entityId);
			if (cueComp != null)
			{
				foreach (int num in entityData.SocketHandles.Values)
				{
					cueComp.RemoveCueByHandle((long)num);
				}
			}
			entityData.SocketHandles.Clear();
			ActorFxEmoteModel.Instance.RemoveEntityData(entityId);
		}

		// Token: 0x0603DBFD RID: 252925 RVA: 0x00EED634 File Offset: 0x00EEB834
		public void StopAll()
		{
			ActorFxEmoteModel.Instance.ForEachEntityData(delegate(int entityId, ActorFxEmoteData entityData)
			{
				BaseGameplayCueComponent cueComp = this.GetCueComp(entityId);
				if (cueComp != null)
				{
					foreach (int num in entityData.SocketHandles.Values)
					{
						cueComp.RemoveCueByHandle((long)num);
					}
				}
				entityData.SocketHandles.Clear();
			});
		}

		// Token: 0x0603DBFE RID: 252926 RVA: 0x00EED64C File Offset: 0x00EEB84C
		private void RemoveSocketHandle(ActorFxEmoteData entityData, BaseGameplayCueComponent queComp, string socketKey)
		{
			int num;
			if (entityData.SocketHandles.TryGetValue(socketKey, out num) && num != 0)
			{
				queComp.RemoveCueByHandle((long)num);
			}
			entityData.SocketHandles.Remove(socketKey);
		}

		// Token: 0x0603DBFF RID: 252927 RVA: 0x00EED684 File Offset: 0x00EEB884
		private void RemoveHandlesByCueId(ActorFxEmoteData entityData, BaseGameplayCueComponent queComp, long cueId)
		{
			foreach (KeyValuePair<string, int> keyValuePair in entityData.SocketHandles.ToArray<KeyValuePair<string, int>>())
			{
				string text;
				int num;
				keyValuePair.Deconstruct(out text, out num);
				string key = text;
				int num2 = num;
				GameplayCueBase cueByHandle = queComp.GetCueByHandle((long)num2);
				if (cueByHandle != null && cueByHandle.CueConfig.Id == cueId)
				{
					queComp.RemoveCueByHandle((long)num2);
					entityData.SocketHandles.Remove(key);
				}
			}
		}

		// Token: 0x0603DC00 RID: 252928 RVA: 0x00EED6F8 File Offset: 0x00EEB8F8
		[NullableContext(2)]
		private BaseGameplayCueComponent GetCueComp(int entityId)
		{
			return EntitySystem.Instance.GetComponent<BaseGameplayCueComponent>(entityId);
		}

		// Token: 0x0603DC01 RID: 252929 RVA: 0x00EED705 File Offset: 0x00EEB905
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (handle == null)
			{
				return;
			}
			this.StopEntity(handle.Id);
		}

		// Token: 0x17008EE8 RID: 36584
		// (get) Token: 0x0603DC02 RID: 252930 RVA: 0x00EED717 File Offset: 0x00EEB917
		public static ActorFxEmoteController Instance
		{
			get
			{
				return ActorFxEmoteController._Instance;
			}
		}

		// Token: 0x0603DC03 RID: 252931 RVA: 0x00EED71E File Offset: 0x00EEB91E
		public static ActorFxEmoteController GetOrCreateInstance()
		{
			if (ActorFxEmoteController._Instance == null)
			{
				ActorFxEmoteController.CreateInstance();
			}
			return ActorFxEmoteController._Instance;
		}

		// Token: 0x0603DC04 RID: 252932 RVA: 0x00EED732 File Offset: 0x00EEB932
		public static bool CreateInstance()
		{
			if (ActorFxEmoteController._Instance != null)
			{
				return true;
			}
			ActorFxEmoteController._Instance = new ActorFxEmoteController();
			return true;
		}

		// Token: 0x0603DC05 RID: 252933 RVA: 0x00EED748 File Offset: 0x00EEB948
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DC06 RID: 252934 RVA: 0x00EED74A File Offset: 0x00EEB94A
		public static void ResetStaticDefaultValue()
		{
			ActorFxEmoteController._Instance = null;
		}

		// Token: 0x0603DC07 RID: 252935 RVA: 0x00EED752 File Offset: 0x00EEB952
		static ActorFxEmoteController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActorFxEmoteController.CreateStaticDefaultValue), new Action(ActorFxEmoteController.ResetStaticDefaultValue));
		}

		// Token: 0x04020450 RID: 132176
		[Nullable(2)]
		private static ActorFxEmoteController _Instance;

		// Token: 0x0200C226 RID: 49702
		[NullableContext(2)]
		[Nullable(0)]
		private class GameplayCueEffectOverrideImpl : IGameplayCueEffectOverride
		{
			// Token: 0x1700A277 RID: 41591
			// (get) Token: 0x060505A0 RID: 329120 RVA: 0x0159C23E File Offset: 0x0159A43E
			// (set) Token: 0x060505A1 RID: 329121 RVA: 0x0159C246 File Offset: 0x0159A446
			public string SocketName { get; set; }

			// Token: 0x1700A278 RID: 41592
			// (get) Token: 0x060505A2 RID: 329122 RVA: 0x0159C24F File Offset: 0x0159A44F
			// (set) Token: 0x060505A3 RID: 329123 RVA: 0x0159C257 File Offset: 0x0159A457
			public FVector? RelativePosition { get; set; }

			// Token: 0x1700A279 RID: 41593
			// (get) Token: 0x060505A4 RID: 329124 RVA: 0x0159C260 File Offset: 0x0159A460
			// (set) Token: 0x060505A5 RID: 329125 RVA: 0x0159C268 File Offset: 0x0159A468
			public FVector? RelativeRotation { get; set; }

			// Token: 0x1700A27A RID: 41594
			// (get) Token: 0x060505A6 RID: 329126 RVA: 0x0159C271 File Offset: 0x0159A471
			// (set) Token: 0x060505A7 RID: 329127 RVA: 0x0159C279 File Offset: 0x0159A479
			public FVector? Scale { get; set; }
		}
	}
}
