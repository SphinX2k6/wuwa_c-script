using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.MailBind
{
	// Token: 0x020056A4 RID: 22180
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MailBindModel : ModelBase
	{
		// Token: 0x06038701 RID: 231169 RVA: 0x00D6643F File Offset: 0x00D6463F
		public void UpdateByProtoMailBindInfo(MailBindInfo mainBindInfo)
		{
			this.IsBind = mainBindInfo.IsBind;
			this.IsReward = mainBindInfo.IsReward;
			this.CloseTime = (float)mainBindInfo.CloseTime / 1000f;
		}

		// Token: 0x06038702 RID: 231170 RVA: 0x00D6646C File Offset: 0x00D6466C
		public bool GetIsBind()
		{
			return this.IsBind;
		}

		// Token: 0x06038703 RID: 231171 RVA: 0x00D66474 File Offset: 0x00D64674
		public bool GetIsReward()
		{
			return this.IsReward;
		}

		// Token: 0x06038704 RID: 231172 RVA: 0x00D6647C File Offset: 0x00D6467C
		public double GetCloseTime()
		{
			return (double)this.CloseTime;
		}

		// Token: 0x06038705 RID: 231173 RVA: 0x00D66485 File Offset: 0x00D64685
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

		// Token: 0x06038706 RID: 231174 RVA: 0x00D6649C File Offset: 0x00D6469C
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

		// Token: 0x06038707 RID: 231175 RVA: 0x00D66545 File Offset: 0x00D64745
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

		// Token: 0x06038708 RID: 231176 RVA: 0x00D66584 File Offset: 0x00D64784
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

		// Token: 0x06038709 RID: 231177 RVA: 0x00D665CE File Offset: 0x00D647CE
		public bool CheckGlobalMailBindOpen()
		{
			return KuroSdkController.Instance.GetIfGlobalSdk() && !FeatureRestrictionTemplate.TemplateForPioneerClient.Check() && (!this.GetIsReward() || TimeUtil.Instance.GetServerTime() <= this.GetCloseTime());
		}

		// Token: 0x0603870A RID: 231178 RVA: 0x00D66609 File Offset: 0x00D64809
		public void SetNextShowRedDotTime(long nextTime)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MailBindNextShowRedDotTime) as ServerStorageLong).Set(new long?(nextTime));
		}

		// Token: 0x0603870B RID: 231179 RVA: 0x00D66627 File Offset: 0x00D64827
		public long? GetNextShowRedDotTime()
		{
			ServerStorageUtil.OverrideLocalNumberToServerLong(ELocalStoragePlayerKey.MailBindNextShowRedDotTime, EClientStorageSystemIdType.MailBindNextShowRedDotTime);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MailBindNextShowRedDotTime) as ServerStorageLong).Get();
		}

		// Token: 0x1700878D RID: 34701
		// (get) Token: 0x0603870C RID: 231180 RVA: 0x00D66649 File Offset: 0x00D64849
		public static MailBindModel Instance
		{
			get
			{
				return MailBindModel._Instance;
			}
		}

		// Token: 0x0603870D RID: 231181 RVA: 0x00D66650 File Offset: 0x00D64850
		public static MailBindModel GetOrCreateInstance()
		{
			if (MailBindModel._Instance == null)
			{
				MailBindModel.CreateInstance();
			}
			return MailBindModel._Instance;
		}

		// Token: 0x0603870E RID: 231182 RVA: 0x00D66664 File Offset: 0x00D64864
		public static bool CreateInstance()
		{
			if (MailBindModel._Instance != null)
			{
				return true;
			}
			MailBindModel._Instance = new MailBindModel();
			return true;
		}

		// Token: 0x0603870F RID: 231183 RVA: 0x00D6667A File Offset: 0x00D6487A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038710 RID: 231184 RVA: 0x00D6667C File Offset: 0x00D6487C
		public static void ResetStaticDefaultValue()
		{
			MailBindModel._Instance = null;
		}

		// Token: 0x06038711 RID: 231185 RVA: 0x00D66684 File Offset: 0x00D64884
		static MailBindModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MailBindModel.CreateStaticDefaultValue), new Action(MailBindModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DA35 RID: 121397
		private bool IsBind;

		// Token: 0x0401DA36 RID: 121398
		private bool IsReward;

		// Token: 0x0401DA37 RID: 121399
		private float CloseTime;

		// Token: 0x0401DA38 RID: 121400
		[Nullable(2)]
		private static MailBindModel _Instance;
	}
}
