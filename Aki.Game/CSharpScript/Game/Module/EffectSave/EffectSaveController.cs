using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.EffectSave
{
	// Token: 0x02005A8E RID: 23182
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class EffectSaveController : ControllerBase
	{
		// Token: 0x0603AB73 RID: 240499 RVA: 0x00DFC534 File Offset: 0x00DFA734
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.DecalAddNotify, new Action<IMessage, Net.CallbackStatus>(this.EffectAddNotify));
			Net.Instance.Register(ENotifyMessageId.DecalRemoveNotify, new Action<IMessage, Net.CallbackStatus>(this.EffectRemoveNotify));
			EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.RemoveEffectOnOnlineModeChange));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.RemoveEffectOnOnlineModeChange));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
			return true;
		}

		// Token: 0x0603AB74 RID: 240500 RVA: 0x00DFC5D0 File Offset: 0x00DFA7D0
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.DecalAddNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DecalRemoveNotify);
			EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.RemoveEffectOnOnlineModeChange));
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.RemoveEffectOnOnlineModeChange));
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
			this.RemoveAllEffect("[EffectSaveController] Remove By Controller Clear");
			return true;
		}

		// Token: 0x0603AB75 RID: 240501 RVA: 0x00DFC660 File Offset: 0x00DFA860
		public unsafe void MarkEffectSave(string effectPath, IVector effectLocation, IRotator effectRotation)
		{
			EffectSave? config = ConfigEffectSaveByEffectPath.GetConfig(effectPath, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[EffectSaveController] 特效路径在t.特效保留.xlsx中未配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("effectPath", effectPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			AddDecalRequest addDecalRequest = AddDecalRequest.Create();
			addDecalRequest.SceneId = GameModeModel.Instance.InstanceDungeon.Value.Id;
			addDecalRequest.Position = new Aki.Protocol.Vector
			{
				X = (float)effectLocation.X,
				Y = (float)effectLocation.Y,
				Z = (float)effectLocation.Z
			};
			addDecalRequest.EffectId = config.Value.EffectId;
			addDecalRequest.Rotation = new Aki.Protocol.Vector
			{
				X = effectRotation.Pitch,
				Y = effectRotation.Roll,
				Z = effectRotation.Yaw
			};
			Net.Instance.Call(ERequestMessageId.AddDecalRequest, addDecalRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				AddDecalResponse addDecalResponse = (AddDecalResponse)msg;
				if (addDecalResponse == null || addDecalResponse.ErrCode > Aki.Protocol.ErrorCode.Success)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.LevelPlay;
					ELogAuthor author2 = ELogAuthor.FJH;
					string message2 = "[EffectSaveController] 转发特效信息至服务器失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("effectPath", effectPath);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("errorCode", (addDecalResponse != null) ? new Aki.Protocol.ErrorCode?(addDecalResponse.ErrCode) : null);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}, 0);
		}

		// Token: 0x0603AB76 RID: 240502 RVA: 0x00DFC77C File Offset: 0x00DFA97C
		[NullableContext(2)]
		public void EffectAddNotify(IMessage msg, Net.CallbackStatus _)
		{
			DecalAddNotify decalAddNotify = (DecalAddNotify)msg;
			int id = GameModeModel.Instance.InstanceDungeon.Value.Id;
			foreach (DecalInfo decalInfo in decalAddNotify.Info)
			{
				if (decalInfo.Position != null && decalInfo.Rotation != null && decalInfo.SceneId == id)
				{
					EffectSave? config = ConfigEffectSaveByEffectId.GetConfig(decalInfo.EffectId, true);
					if (config == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.LevelPlay;
						ELogAuthor author = ELogAuthor.FJH;
						string message = "[EffectSaveController] 特效Id在t.特效保留.xlsx中未配置";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("effectId", decalInfo.EffectId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						EffectSaveModel.Instance.TempPosition.X = (double)decalInfo.Position.X;
						EffectSaveModel.Instance.TempPosition.Y = (double)decalInfo.Position.Y;
						EffectSaveModel.Instance.TempPosition.Z = (double)decalInfo.Position.Z;
						EffectSaveModel.Instance.TempRotation.Pitch = decalInfo.Rotation.X;
						EffectSaveModel.Instance.TempRotation.Roll = decalInfo.Rotation.Y;
						EffectSaveModel.Instance.TempRotation.Yaw = decalInfo.Rotation.Z;
						EffectSaveModel.Instance.TempTransform.SetLocation(EffectSaveModel.Instance.TempPosition);
						EffectSaveModel instance2 = EffectSaveModel.Instance;
						FQuat fquat = EffectSaveModel.Instance.TempRotation.Quaternion();
						instance2.TempTransform.SetRotation(fquat);
						EffectSystem instance3 = EffectSystem.Instance;
						UObject world = GlobalData.World;
						FTransformDouble? ftransformDouble = new FTransformDouble?(EffectSaveModel.Instance.TempTransform);
						int value = instance3.SpawnEffect(world, ftransformDouble, config.Value.EffectPath, "[EffectSaveController] Add By Proto_DecalAddNotify", null, EEffectType.Scene, null, null, null, false, false);
						EffectSaveModel.Instance.EffectSaveMap[MathUtils.Instance.LongToBigInt(decalInfo.DecalId)] = value;
					}
				}
			}
		}

		// Token: 0x0603AB77 RID: 240503 RVA: 0x00DFC9B0 File Offset: 0x00DFABB0
		[NullableContext(2)]
		public void EffectRemoveNotify(IMessage msg, Net.CallbackStatus _)
		{
			foreach (DecalInfo decalInfo in ((DecalRemoveNotify)msg).Info)
			{
				long key = MathUtils.Instance.LongToBigInt(decalInfo.DecalId);
				int num;
				EffectSaveModel.Instance.EffectSaveMap.TryGetValue(key, out num);
				if (num != 0)
				{
					if (EffectSystem.Instance.IsValid(num))
					{
						EffectSystem.Instance.StopEffectById(num, "[EffectSaveController] Remove By Proto_DecalRemoveNotify", true, null);
					}
					EffectSaveModel.Instance.EffectSaveMap.Remove(key);
				}
			}
		}

		// Token: 0x0603AB78 RID: 240504 RVA: 0x00DFCA5C File Offset: 0x00DFAC5C
		public void RemoveEffectOnOnlineModeChange()
		{
			this.RemoveAllEffect("[EffectSaveController] Remove By Online Mode Change");
		}

		// Token: 0x0603AB79 RID: 240505 RVA: 0x00DFCA69 File Offset: 0x00DFAC69
		public void OnLeaveInstanceDungeon()
		{
			this.RemoveAllEffect("[EffectSaveController] Remove By Leave Instance Dungeon");
		}

		// Token: 0x0603AB7A RID: 240506 RVA: 0x00DFCA78 File Offset: 0x00DFAC78
		private void RemoveAllEffect(string reason)
		{
			foreach (int num in EffectSaveModel.Instance.EffectSaveMap.Values)
			{
				if (EffectSystem.Instance.IsValid(num))
				{
					EffectSystem.Instance.StopEffectById(num, reason, true, null);
				}
			}
			EffectSaveModel.Instance.EffectSaveMap.Clear();
		}

		// Token: 0x17008BFE RID: 35838
		// (get) Token: 0x0603AB7B RID: 240507 RVA: 0x00DFCB00 File Offset: 0x00DFAD00
		public static EffectSaveController Instance
		{
			get
			{
				return EffectSaveController._Instance;
			}
		}

		// Token: 0x0603AB7C RID: 240508 RVA: 0x00DFCB07 File Offset: 0x00DFAD07
		public static EffectSaveController GetOrCreateInstance()
		{
			if (EffectSaveController._Instance == null)
			{
				EffectSaveController.CreateInstance();
			}
			return EffectSaveController._Instance;
		}

		// Token: 0x0603AB7D RID: 240509 RVA: 0x00DFCB1B File Offset: 0x00DFAD1B
		public static bool CreateInstance()
		{
			if (EffectSaveController._Instance != null)
			{
				return true;
			}
			EffectSaveController._Instance = new EffectSaveController();
			return true;
		}

		// Token: 0x0603AB7E RID: 240510 RVA: 0x00DFCB31 File Offset: 0x00DFAD31
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AB7F RID: 240511 RVA: 0x00DFCB33 File Offset: 0x00DFAD33
		public static void ResetStaticDefaultValue()
		{
			EffectSaveController._Instance = null;
		}

		// Token: 0x0603AB80 RID: 240512 RVA: 0x00DFCB3B File Offset: 0x00DFAD3B
		static EffectSaveController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectSaveController.CreateStaticDefaultValue), new Action(EffectSaveController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA61 RID: 125537
		[Nullable(2)]
		private static EffectSaveController _Instance;
	}
}
