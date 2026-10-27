using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F4A RID: 8010
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemPhoneMessageAttachment : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600AE44 RID: 44612 RVA: 0x00191730 File Offset: 0x0018F930
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

		// Token: 0x0600AE45 RID: 44613 RVA: 0x00191768 File Offset: 0x0018F968
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

		// Token: 0x0600AE46 RID: 44614 RVA: 0x0019177B File Offset: 0x0018F97B
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

		// Token: 0x0600AE47 RID: 44615 RVA: 0x0019178E File Offset: 0x0018F98E
		public new ITalkItemPhoneMessageAttachment_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageAttachment_SetValue
			{
				Type = this.Type,
				AttachmentId = this.AttachmentId
			};
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600AE48 RID: 44616 RVA: 0x001917AD File Offset: 0x0018F9AD
		// (set) Token: 0x0600AE49 RID: 44617 RVA: 0x001917D8 File Offset: 0x0018F9D8
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

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x001917E6 File Offset: 0x0018F9E6
		// (set) Token: 0x0600AE4B RID: 44619 RVA: 0x00191811 File Offset: 0x0018FA11
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

		// Token: 0x040068C7 RID: 26823
		[Nullable(2)]
		protected new ITalkItemPhoneMessageAttachment FbInstance;

		// Token: 0x040068C8 RID: 26824
		[Nullable(2)]
		protected new ITalkItemPhoneMessageAttachment_SetValue PocoInterface;
	}
}
