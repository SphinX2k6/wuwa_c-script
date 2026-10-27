using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE3 RID: 6883
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiCommunicateRemoveTag : IGroupAiCommunicateMode
	{
		// Token: 0x06009380 RID: 37760 RVA: 0x00156428 File Offset: 0x00154628
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

		// Token: 0x06009381 RID: 37761 RVA: 0x00156460 File Offset: 0x00154660
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

		// Token: 0x06009382 RID: 37762 RVA: 0x00156473 File Offset: 0x00154673
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

		// Token: 0x06009383 RID: 37763 RVA: 0x00156486 File Offset: 0x00154686
		public new IGroupAiCommunicateRemoveTag_SetValue ToSetValue()
		{
			return new IGroupAiCommunicateRemoveTag_SetValue
			{
				Type = this.Type,
				Tags = this.Tags
			};
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x06009384 RID: 37764 RVA: 0x001564A5 File Offset: 0x001546A5
		// (set) Token: 0x06009385 RID: 37765 RVA: 0x001564D0 File Offset: 0x001546D0
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

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x06009386 RID: 37766 RVA: 0x001564DE File Offset: 0x001546DE
		// (set) Token: 0x06009387 RID: 37767 RVA: 0x00156505 File Offset: 0x00154705
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

		// Token: 0x04005AA2 RID: 23202
		[Nullable(2)]
		protected new IGroupAiCommunicateRemoveTag FbInstance;

		// Token: 0x04005AA3 RID: 23203
		[Nullable(2)]
		protected new IGroupAiCommunicateRemoveTag_SetValue PocoInterface;
	}
}
