using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F52 RID: 8018
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemPhoneMessageVoice : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600AE68 RID: 44648 RVA: 0x00191AA8 File Offset: 0x0018FCA8
		private ITalkItemPhoneMessageVoice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageVoice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageVoice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageVoice_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE69 RID: 44649 RVA: 0x00191AE0 File Offset: 0x0018FCE0
		public static ITalkItemPhoneMessageVoice Create([Nullable(2)] ITalkItemPhoneMessageVoice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageVoice
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x00191AF3 File Offset: 0x0018FCF3
		public static ITalkItemPhoneMessageVoice CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageVoice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageVoice
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE6B RID: 44651 RVA: 0x00191B06 File Offset: 0x0018FD06
		public new ITalkItemPhoneMessageVoice_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageVoice_SetValue
			{
				Type = this.Type,
				PushCondition = this.PushCondition,
				AutoPlay = this.AutoPlay
			};
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600AE6C RID: 44652 RVA: 0x00191B31 File Offset: 0x0018FD31
		// (set) Token: 0x0600AE6D RID: 44653 RVA: 0x00191B5C File Offset: 0x0018FD5C
		public override EPhoneMessageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageType.Voice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600AE6E RID: 44654 RVA: 0x00191B6C File Offset: 0x0018FD6C
		// (set) Token: 0x0600AE6F RID: 44655 RVA: 0x00191BA6 File Offset: 0x0018FDA6
		public virtual EPhoneMessageVoicePushCondition? PushCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PushCondition;
				}
				ITalkItemPhoneMessageVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PushCondition;
			}
			set
			{
				this.GetOrCreatePoco().PushCondition = value;
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600AE70 RID: 44656 RVA: 0x00191BB4 File Offset: 0x0018FDB4
		// (set) Token: 0x0600AE71 RID: 44657 RVA: 0x00191BEE File Offset: 0x0018FDEE
		public virtual bool? AutoPlay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoPlay;
				}
				ITalkItemPhoneMessageVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoPlay;
			}
			set
			{
				this.GetOrCreatePoco().AutoPlay = value;
			}
		}

		// Token: 0x040068D5 RID: 26837
		[Nullable(2)]
		protected new ITalkItemPhoneMessageVoice FbInstance;

		// Token: 0x040068D6 RID: 26838
		[Nullable(2)]
		protected new ITalkItemPhoneMessageVoice_SetValue PocoInterface;
	}
}
