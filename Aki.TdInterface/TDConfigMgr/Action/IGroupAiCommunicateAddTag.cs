using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C86 RID: 7302
	public class IGroupAiCommunicateAddTag : IGroupAiCommunicateMode
	{
		// Token: 0x06009B2C RID: 39724 RVA: 0x00166A90 File Offset: 0x00164C90
		private IGroupAiCommunicateAddTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiCommunicateAddTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiCommunicateAddTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiCommunicateAddTag_SetValue());
			}
			return result;
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x00166AC8 File Offset: 0x00164CC8
		public static IGroupAiCommunicateAddTag Create([Nullable(2)] IGroupAiCommunicateAddTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateAddTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x00166ADB File Offset: 0x00164CDB
		public static IGroupAiCommunicateAddTag CreateFromSetValue([Nullable(2)] IGroupAiCommunicateAddTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiCommunicateAddTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x00166AEE File Offset: 0x00164CEE
		public new IGroupAiCommunicateAddTag_SetValue ToSetValue()
		{
			return new IGroupAiCommunicateAddTag_SetValue
			{
				Type = this.Type,
				Tags = this.Tags
			};
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06009B30 RID: 39728 RVA: 0x00166B0D File Offset: 0x00164D0D
		// (set) Token: 0x06009B31 RID: 39729 RVA: 0x00166B38 File Offset: 0x00164D38
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

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x00166B46 File Offset: 0x00164D46
		// (set) Token: 0x06009B33 RID: 39731 RVA: 0x00166B6D File Offset: 0x00164D6D
		public virtual List<string> Tags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tags;
				}
				IGroupAiCommunicateAddTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005F25 RID: 24357
		[Nullable(2)]
		protected new IGroupAiCommunicateAddTag FbInstance;

		// Token: 0x04005F26 RID: 24358
		[Nullable(2)]
		protected new IGroupAiCommunicateAddTag_SetValue PocoInterface;
	}
}
