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
	// Token: 0x02004A6A RID: 19050
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class EffectSaveController : ControllerBase
	{
		// Token: 0x0602FABC RID: 195260 RVA: 0x00D4CAC8 File Offset: 0x00D4ACC8
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.DecalAddNotify, new Action<IMessage, Net.CallbackStatus>(this.EffectAddNotify));
			Net.Instance.Register(ENotifyMessageId.DecalRemoveNotify, new Action<IMessage, Net.CallbackStatus>(this.EffectRemoveNotify));
			EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.RemoveEffectOnOnlineModeChange));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.RemoveEffectOnOnlineModeChange));
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
			return true;
		}

		// Token: 0x0602FABD RID: 195261 RVA: 0x00D4CB64 File Offset: 0x00D4AD64
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

		// Token: 0x0602FABE RID: 195262 RVA: 0x00D4CBF4 File Offset: 0x00D4ADF4
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

		// Token: 0x0602FABF RID: 195263 RVA: 0x00D4CD10 File Offset: 0x00D4AF10
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

		// Token: 0x0602FAC0 RID: 195264 RVA: 0x00D4CF44 File Offset: 0x00D4B144
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

		// Token: 0x0602FAC1 RID: 195265 RVA: 0x00D4CFF0 File Offset: 0x00D4B1F0
		public void RemoveEffectOnOnlineModeChange()
		{
			this.RemoveAllEffect("[EffectSaveController] Remove By Online Mode Change");
		}

		// Token: 0x0602FAC2 RID: 195266 RVA: 0x00D4CFFD File Offset: 0x00D4B1FD
		public void OnLeaveInstanceDungeon()
		{
			this.RemoveAllEffect("[EffectSaveController] Remove By Leave Instance Dungeon");
		}

		// Token: 0x0602FAC3 RID: 195267 RVA: 0x00D4D00C File Offset: 0x00D4B20C
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

		// Token: 0x17005FCC RID: 24524
		// (get) Token: 0x0602FAC4 RID: 195268 RVA: 0x00D4D094 File Offset: 0x00D4B294
		public static EffectSaveController Instance
		{
			get
			{
				return EffectSaveController._Instance;
			}
		}

		// Token: 0x0602FAC5 RID: 195269 RVA: 0x00D4D09B File Offset: 0x00D4B29B
		public static EffectSaveController GetOrCreateInstance()
		{
			if (EffectSaveController._Instance == null)
			{
				EffectSaveController.CreateInstance();
			}
			return EffectSaveController._Instance;
		}

		// Token: 0x0602FAC6 RID: 195270 RVA: 0x00D4D0AF File Offset: 0x00D4B2AF
		public static bool CreateInstance()
		{
			if (EffectSaveController._Instance != null)
			{
				return true;
			}
			EffectSaveController._Instance = new EffectSaveController();
			return true;
		}

		// Token: 0x0602FAC7 RID: 195271 RVA: 0x00D4D0C5 File Offset: 0x00D4B2C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FAC8 RID: 195272 RVA: 0x00D4D0C7 File Offset: 0x00D4B2C7
		public static void ResetStaticDefaultValue()
		{
			EffectSaveController._Instance = null;
		}

		// Token: 0x0602FAC9 RID: 195273 RVA: 0x00D4D0CF File Offset: 0x00D4B2CF
		static EffectSaveController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectSaveController.CreateStaticDefaultValue), new Action(EffectSaveController.ResetStaticDefaultValue));
		}

		// Token: 0x04019508 RID: 103688
		[Nullable(2)]
		private static EffectSaveController _Instance;
	}
}
