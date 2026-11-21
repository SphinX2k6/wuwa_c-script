using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.ActorFxEmote
{
	// Token: 0x02004ED3 RID: 20179
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActorFxEmoteController : ControllerBase
	{
		// Token: 0x06032B93 RID: 207763 RVA: 0x00E3EFE3 File Offset: 0x00E3D1E3
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			return true;
		}

		// Token: 0x06032B94 RID: 207764 RVA: 0x00E3F002 File Offset: 0x00E3D202
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			this.StopAll();
			return true;
		}

		// Token: 0x06032B95 RID: 207765 RVA: 0x00E3F028 File Offset: 0x00E3D228
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

		// Token: 0x06032B96 RID: 207766 RVA: 0x00E3F20C File Offset: 0x00E3D40C
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

		// Token: 0x06032B97 RID: 207767 RVA: 0x00E3F248 File Offset: 0x00E3D448
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

		// Token: 0x06032B98 RID: 207768 RVA: 0x00E3F2D4 File Offset: 0x00E3D4D4
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

		// Token: 0x06032B99 RID: 207769 RVA: 0x00E3F2EC File Offset: 0x00E3D4EC
		private void RemoveSocketHandle(ActorFxEmoteData entityData, BaseGameplayCueComponent queComp, string socketKey)
		{
			int num;
			if (entityData.SocketHandles.TryGetValue(socketKey, out num) && num != 0)
			{
				queComp.RemoveCueByHandle((long)num);
			}
			entityData.SocketHandles.Remove(socketKey);
		}

		// Token: 0x06032B9A RID: 207770 RVA: 0x00E3F324 File Offset: 0x00E3D524
		private void RemoveHandlesByCueId(ActorFxEmoteData entityData, BaseGameplayCueComponent queComp, long cueId)
		{
			foreach (KeyValuePair<string, int> keyValuePair in new List<KeyValuePair<string, int>>(entityData.SocketHandles))
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

		// Token: 0x06032B9B RID: 207771 RVA: 0x00E3F3BC File Offset: 0x00E3D5BC
		[NullableContext(2)]
		private BaseGameplayCueComponent GetCueComp(int entityId)
		{
			return EntitySystem.Instance.GetComponent<BaseGameplayCueComponent>(entityId);
		}

		// Token: 0x06032B9C RID: 207772 RVA: 0x00E3F3C9 File Offset: 0x00E3D5C9
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (handle == null)
			{
				return;
			}
			this.StopEntity(handle.Id);
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x06032B9D RID: 207773 RVA: 0x00E3F3DB File Offset: 0x00E3D5DB
		public static ActorFxEmoteController Instance
		{
			get
			{
				return ActorFxEmoteController._Instance;
			}
		}

		// Token: 0x06032B9E RID: 207774 RVA: 0x00E3F3E2 File Offset: 0x00E3D5E2
		public static ActorFxEmoteController GetOrCreateInstance()
		{
			if (ActorFxEmoteController._Instance == null)
			{
				ActorFxEmoteController.CreateInstance();
			}
			return ActorFxEmoteController._Instance;
		}

		// Token: 0x06032B9F RID: 207775 RVA: 0x00E3F3F6 File Offset: 0x00E3D5F6
		public static bool CreateInstance()
		{
			if (ActorFxEmoteController._Instance != null)
			{
				return true;
			}
			ActorFxEmoteController._Instance = new ActorFxEmoteController();
			return true;
		}

		// Token: 0x06032BA0 RID: 207776 RVA: 0x00E3F40C File Offset: 0x00E3D60C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032BA1 RID: 207777 RVA: 0x00E3F40E File Offset: 0x00E3D60E
		public static void ResetStaticDefaultValue()
		{
			ActorFxEmoteController._Instance = null;
		}

		// Token: 0x06032BA2 RID: 207778 RVA: 0x00E3F416 File Offset: 0x00E3D616
		static ActorFxEmoteController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActorFxEmoteController.CreateStaticDefaultValue), new Action(ActorFxEmoteController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AF22 RID: 110370
		[Nullable(2)]
		private static ActorFxEmoteController _Instance;

		// Token: 0x0200AC34 RID: 44084
		[NullableContext(2)]
		[Nullable(0)]
		private class GameplayCueEffectOverrideImpl : IGameplayCueEffectOverride
		{
			// Token: 0x17007A14 RID: 31252
			// (get) Token: 0x06046AEA RID: 289514 RVA: 0x01555C0A File Offset: 0x01553E0A
			// (set) Token: 0x06046AEB RID: 289515 RVA: 0x01555C12 File Offset: 0x01553E12
			public string SocketName { get; set; }

			// Token: 0x17007A15 RID: 31253
			// (get) Token: 0x06046AEC RID: 289516 RVA: 0x01555C1B File Offset: 0x01553E1B
			// (set) Token: 0x06046AED RID: 289517 RVA: 0x01555C23 File Offset: 0x01553E23
			public FVector? RelativePosition { get; set; }

			// Token: 0x17007A16 RID: 31254
			// (get) Token: 0x06046AEE RID: 289518 RVA: 0x01555C2C File Offset: 0x01553E2C
			// (set) Token: 0x06046AEF RID: 289519 RVA: 0x01555C34 File Offset: 0x01553E34
			public FVector? RelativeRotation { get; set; }

			// Token: 0x17007A17 RID: 31255
			// (get) Token: 0x06046AF0 RID: 289520 RVA: 0x01555C3D File Offset: 0x01553E3D
			// (set) Token: 0x06046AF1 RID: 289521 RVA: 0x01555C45 File Offset: 0x01553E45
			public FVector? Scale { get; set; }
		}
	}
}
