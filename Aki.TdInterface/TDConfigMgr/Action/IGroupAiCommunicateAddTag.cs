using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADF RID: 6879
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiCommunicateAddTag : IGroupAiCommunicateMode
	{
		// Token: 0x0600936E RID: 37742 RVA: 0x00156270 File Offset: 0x00154470
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

		// Token: 0x0600936F RID: 37743 RVA: 0x001562A8 File Offset: 0x001544A8
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

		// Token: 0x06009370 RID: 37744 RVA: 0x001562BB File Offset: 0x001544BB
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

		// Token: 0x06009371 RID: 37745 RVA: 0x001562CE File Offset: 0x001544CE
		public new IGroupAiCommunicateAddTag_SetValue ToSetValue()
		{
			return new IGroupAiCommunicateAddTag_SetValue
			{
				Type = this.Type,
				Tags = this.Tags
			};
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x06009372 RID: 37746 RVA: 0x001562ED File Offset: 0x001544ED
		// (set) Token: 0x06009373 RID: 37747 RVA: 0x00156318 File Offset: 0x00154518
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

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x00156326 File Offset: 0x00154526
		// (set) Token: 0x06009375 RID: 37749 RVA: 0x0015634D File Offset: 0x0015454D
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

		// Token: 0x04005A9B RID: 23195
		[Nullable(2)]
		protected new IGroupAiCommunicateAddTag FbInstance;

		// Token: 0x04005A9C RID: 23196
		[Nullable(2)]
		protected new IGroupAiCommunicateAddTag_SetValue PocoInterface;
	}
}
