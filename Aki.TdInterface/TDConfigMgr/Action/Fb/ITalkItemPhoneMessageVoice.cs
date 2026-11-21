using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FD RID: 10237
	public class ITalkItemPhoneMessageVoice : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600E32C RID: 58156 RVA: 0x00217C99 File Offset: 0x00215E99
		public static ITalkItemPhoneMessageVoice Create(ITalkItemPhoneMessageVoice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageVoice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x0600E32D RID: 58157 RVA: 0x00217CB8 File Offset: 0x00215EB8
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x0600E32E RID: 58158 RVA: 0x00217CC8 File Offset: 0x00215EC8
		public virtual EPhoneMessageVoicePushCondition? PushCondition
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPhoneMessageVoicePushCondition?((EPhoneMessageVoicePushCondition)this.Instance.PushCondition);
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x0600E32F RID: 58159 RVA: 0x00217D00 File Offset: 0x00215F00
		public virtual bool? AutoPlay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AutoPlay);
			}
		}

		// Token: 0x04007C1F RID: 31775
		private ITalkItemPhoneMessageVoice Instance;
	}
}
