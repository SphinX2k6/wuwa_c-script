using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5A RID: 8026
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemStylePhoneSendError : ITalkItemStyle
	{
		// Token: 0x0600AECE RID: 44750 RVA: 0x001933F8 File Offset: 0x001915F8
		private ITalkItemStylePhoneSendError_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemStylePhoneSendError 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemStylePhoneSendError_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemStylePhoneSendError_SetValue());
			}
			return result;
		}

		// Token: 0x0600AECF RID: 44751 RVA: 0x00193430 File Offset: 0x00191630
		public static ITalkItemStylePhoneSendError Create([Nullable(2)] ITalkItemStylePhoneSendError instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStylePhoneSendError
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x00193443 File Offset: 0x00191643
		public static ITalkItemStylePhoneSendError CreateFromSetValue([Nullable(2)] ITalkItemStylePhoneSendError_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemStylePhoneSendError
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x00193456 File Offset: 0x00191656
		public new ITalkItemStylePhoneSendError_SetValue ToSetValue()
		{
			return new ITalkItemStylePhoneSendError_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600AED2 RID: 44754 RVA: 0x00193469 File Offset: 0x00191669
		// (set) Token: 0x0600AED3 RID: 44755 RVA: 0x00193494 File Offset: 0x00191694
		public override ETalkItemStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006927 RID: 26919
		[Nullable(2)]
		protected new ITalkItemStylePhoneSendError FbInstance;

		// Token: 0x04006928 RID: 26920
		[Nullable(2)]
		protected new ITalkItemStylePhoneSendError_SetValue PocoInterface;
	}
}
