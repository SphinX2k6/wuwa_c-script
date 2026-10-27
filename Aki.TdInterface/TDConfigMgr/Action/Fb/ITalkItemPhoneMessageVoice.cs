using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002554 RID: 9556
	public class ITalkItemPhoneMessageVoice : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600D5C2 RID: 54722 RVA: 0x001FC09D File Offset: 0x001FA29D
		[NullableContext(1)]
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

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600D5C3 RID: 54723 RVA: 0x001FC0BC File Offset: 0x001FA2BC
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x001FC0CC File Offset: 0x001FA2CC
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

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600D5C5 RID: 54725 RVA: 0x001FC104 File Offset: 0x001FA304
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

		// Token: 0x040075C2 RID: 30146
		private ITalkItemPhoneMessageVoice Instance;
	}
}
