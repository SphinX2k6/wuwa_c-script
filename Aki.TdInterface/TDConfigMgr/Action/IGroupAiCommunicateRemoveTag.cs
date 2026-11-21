using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8A RID: 7306
	public class IGroupAiCommunicateRemoveTag : IGroupAiCommunicateMode
	{
		// Token: 0x06009B3E RID: 39742 RVA: 0x00166C48 File Offset: 0x00164E48
		private IGroupAiCommunicateRemoveTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiCommunicateRemoveTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiCommunicateRemoveTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiCommunicateRemoveTag_SetValue());
			}
			return result;
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x00166C80 File Offset: 0x00164E80
		public static IGroupAiCommunicateRemoveTag Create([Nullable(2)] IGroupAiCommunicateRemoveTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateRemoveTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x00166C93 File Offset: 0x00164E93
		public static IGroupAiCommunicateRemoveTag CreateFromSetValue([Nullable(2)] IGroupAiCommunicateRemoveTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiCommunicateRemoveTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x00166CA6 File Offset: 0x00164EA6
		public new IGroupAiCommunicateRemoveTag_SetValue ToSetValue()
		{
			return new IGroupAiCommunicateRemoveTag_SetValue
			{
				Type = this.Type,
				Tags = this.Tags
			};
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06009B42 RID: 39746 RVA: 0x00166CC5 File Offset: 0x00164EC5
		// (set) Token: 0x06009B43 RID: 39747 RVA: 0x00166CF0 File Offset: 0x00164EF0
		public override EGroupAiCommunicateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiCommunicateType.AddTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06009B44 RID: 39748 RVA: 0x00166CFE File Offset: 0x00164EFE
		// (set) Token: 0x06009B45 RID: 39749 RVA: 0x00166D25 File Offset: 0x00164F25
		public virtual List<string> Tags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tags;
				}
				IGroupAiCommunicateRemoveTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Tags;
			}
			set
			{
				this.GetOrCreatePoco().Tags = value;
			}
		}

		// Token: 0x04005F2C RID: 24364
		[Nullable(2)]
		protected new IGroupAiCommunicateRemoveTag FbInstance;

		// Token: 0x04005F2D RID: 24365
		[Nullable(2)]
		protected new IGroupAiCommunicateRemoveTag_SetValue PocoInterface;
	}
}
