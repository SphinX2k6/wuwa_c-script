using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.MailBind
{
	// Token: 0x0200467A RID: 18042
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MailBindModel : ModelBase
	{
		// Token: 0x0602D5FE RID: 185854 RVA: 0x00CB458F File Offset: 0x00CB278F
		public void UpdateByProtoMailBindInfo(MailBindInfo mainBindInfo)
		{
			this.IsBind = mainBindInfo.IsBind;
			this.IsReward = mainBindInfo.IsReward;
			this.CloseTime = (float)mainBindInfo.CloseTime / 1000f;
		}

		// Token: 0x0602D5FF RID: 185855 RVA: 0x00CB45BC File Offset: 0x00CB27BC
		public bool GetIsBind()
		{
			return this.IsBind;
		}

		// Token: 0x0602D600 RID: 185856 RVA: 0x00CB45C4 File Offset: 0x00CB27C4
		public bool GetIsReward()
		{
			return this.IsReward;
		}

		// Token: 0x0602D601 RID: 185857 RVA: 0x00CB45CC File Offset: 0x00CB27CC
		public double GetCloseTime()
		{
			return (double)this.CloseTime;
		}

		// Token: 0x0602D602 RID: 185858 RVA: 0x00CB45D5 File Offset: 0x00CB27D5
		public EMailBindState GetState()
		{
			if (this.IsReward)
			{
				return EMailBindState.HasReward;
			}
			if (this.IsBind)
			{
				return EMailBindState.CanReward;
			}
			return EMailBindState.NotBind;
		}

		// Token: 0x0602D603 RID: 185859 RVA: 0x00CB45EC File Offset: 0x00CB27EC
		[NullableContext(2)]
		public string GetRemainTimeText(double endTime)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = Math.Max(endTime - serverTime, 1.0);
			ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> timeTypeData = this.GetTimeTypeData(num);
			if (timeTypeData.Item1 == CommonDefine.ETimeType.Second)
			{
				return TextConfig.Instance.GetTextById("NotEnoughOneHour");
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			if (localTextNew == null)
			{
				return null;
			}
			CommonDefine.ICountDown countDownDataFormat = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(timeTypeData.Item1), new CommonDefine.ETimeType?(timeTypeData.Item2));
			string text = ((countDownDataFormat != null) ? countDownDataFormat.CountDownText : null) ?? "";
			return StringUtils.Format(localTextNew, new string[]
			{
				text
			});
		}

		// Token: 0x0602D604 RID: 185860 RVA: 0x00CB4695 File Offset: 0x00CB2895
		[NullableContext(0)]
		public ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetTimeTypeData(Number remainTime)
		{
			if (remainTime > 86400)
			{
				return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
			}
			if (remainTime > 3600)
			{
				return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Hour);
			}
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
		}

		// Token: 0x0602D605 RID: 185861 RVA: 0x00CB46D4 File Offset: 0x00CB28D4
		public bool CheckMailBindRedDot()
		{
			if (this.GetIsReward())
			{
				return false;
			}
			if (this.GetIsBind())
			{
				return true;
			}
			long? nextShowRedDotTime = this.GetNextShowRedDotTime();
			return nextShowRedDotTime == null || TimeUtil.Instance.GetServerTimeStamp() >= (double)nextShowRedDotTime.Value;
		}

		// Token: 0x0602D606 RID: 185862 RVA: 0x00CB471E File Offset: 0x00CB291E
		public bool CheckGlobalMailBindOpen()
		{
			return KuroSdkController.Instance.GetIfGlobalSdk() && !FeatureRestrictionTemplate.TemplateForPioneerClient.Check() && (!this.GetIsReward() || TimeUtil.Instance.GetServerTime() <= this.GetCloseTime());
		}

		// Token: 0x0602D607 RID: 185863 RVA: 0x00CB4759 File Offset: 0x00CB2959
		public void SetNextShowRedDotTime(long nextTime)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MailBindNextShowRedDotTime) as ServerStorageLong).Set(new long?(nextTime));
		}

		// Token: 0x0602D608 RID: 185864 RVA: 0x00CB4777 File Offset: 0x00CB2977
		public long? GetNextShowRedDotTime()
		{
			ServerStorageUtil.OverrideLocalNumberToServerLong(ELocalStoragePlayerKey.MailBindNextShowRedDotTime, EClientStorageSystemIdType.MailBindNextShowRedDotTime, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MailBindNextShowRedDotTime) as ServerStorageLong).Get();
		}

		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x0602D609 RID: 185865 RVA: 0x00CB479A File Offset: 0x00CB299A
		public static MailBindModel Instance
		{
			get
			{
				return MailBindModel._Instance;
			}
		}

		// Token: 0x0602D60A RID: 185866 RVA: 0x00CB47A1 File Offset: 0x00CB29A1
		public static MailBindModel GetOrCreateInstance()
		{
			if (MailBindModel._Instance == null)
			{
				MailBindModel.CreateInstance();
			}
			return MailBindModel._Instance;
		}

		// Token: 0x0602D60B RID: 185867 RVA: 0x00CB47B5 File Offset: 0x00CB29B5
		public static bool CreateInstance()
		{
			if (MailBindModel._Instance != null)
			{
				return true;
			}
			MailBindModel._Instance = new MailBindModel();
			return true;
		}

		// Token: 0x0602D60C RID: 185868 RVA: 0x00CB47CB File Offset: 0x00CB29CB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D60D RID: 185869 RVA: 0x00CB47CD File Offset: 0x00CB29CD
		public static void ResetStaticDefaultValue()
		{
			MailBindModel._Instance = null;
		}

		// Token: 0x0602D60E RID: 185870 RVA: 0x00CB47D5 File Offset: 0x00CB29D5
		static MailBindModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MailBindModel.CreateStaticDefaultValue), new Action(MailBindModel.ResetStaticDefaultValue));
		}

		// Token: 0x040184C0 RID: 99520
		private bool IsBind;

		// Token: 0x040184C1 RID: 99521
		private bool IsReward;

		// Token: 0x040184C2 RID: 99522
		private float CloseTime;

		// Token: 0x040184C3 RID: 99523
		[Nullable(2)]
		private static MailBindModel _Instance;
	}
}
