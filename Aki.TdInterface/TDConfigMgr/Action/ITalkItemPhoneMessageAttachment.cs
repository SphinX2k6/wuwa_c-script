using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002183 RID: 8579
	public class ITalkItemPhoneMessageAttachment : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600B916 RID: 47382 RVA: 0x001A7728 File Offset: 0x001A5928
		private ITalkItemPhoneMessageAttachment_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageAttachment 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageAttachment_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageAttachment_SetValue());
			}
			return result;
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x001A7760 File Offset: 0x001A5960
		public static ITalkItemPhoneMessageAttachment Create([Nullable(2)] ITalkItemPhoneMessageAttachment instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageAttachment
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x001A7773 File Offset: 0x001A5973
		public static ITalkItemPhoneMessageAttachment CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageAttachment_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageAttachment
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x001A7786 File Offset: 0x001A5986
		public new ITalkItemPhoneMessageAttachment_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageAttachment_SetValue
			{
				Type = this.Type,
				AttachmentId = this.AttachmentId
			};
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600B91A RID: 47386 RVA: 0x001A77A5 File Offset: 0x001A59A5
		// (set) Token: 0x0600B91B RID: 47387 RVA: 0x001A77D0 File Offset: 0x001A59D0
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

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600B91C RID: 47388 RVA: 0x001A77DE File Offset: 0x001A59DE
		// (set) Token: 0x0600B91D RID: 47389 RVA: 0x001A7809 File Offset: 0x001A5A09
		public virtual int AttachmentId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AttachmentId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AttachmentId;
			}
			set
			{
				this.GetOrCreatePoco().AttachmentId = value;
			}
		}

		// Token: 0x04006EB6 RID: 28342
		[Nullable(2)]
		protected new ITalkItemPhoneMessageAttachment FbInstance;

		// Token: 0x04006EB7 RID: 28343
		[Nullable(2)]
		protected new ITalkItemPhoneMessageAttachment_SetValue PocoInterface;
	}
}
