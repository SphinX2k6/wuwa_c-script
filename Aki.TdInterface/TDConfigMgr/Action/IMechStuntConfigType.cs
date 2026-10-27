using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD2 RID: 7122
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntConfigType
	{
		// Token: 0x06009899 RID: 39065 RVA: 0x0015FAA4 File Offset: 0x0015DCA4
		private IMechStuntConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x0015FADC File Offset: 0x0015DCDC
		public static IMechStuntConfigType Create([Nullable(2)] IMechStuntConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x0015FAEF File Offset: 0x0015DCEF
		public static IMechStuntConfigType CreateFromSetValue([Nullable(2)] IMechStuntConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x0015FB02 File Offset: 0x0015DD02
		public IMechStuntConfigType_SetValue ToSetValue()
		{
			return new IMechStuntConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600989D RID: 39069 RVA: 0x0015FB15 File Offset: 0x0015DD15
		// (set) Token: 0x0600989E RID: 39070 RVA: 0x0015FB40 File Offset: 0x0015DD40
		public virtual EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D0D RID: 23821
		[Nullable(2)]
		protected IMechStuntConfigType FbInstance;

		// Token: 0x04005D0E RID: 23822
		[Nullable(2)]
		protected IMechStuntConfigType_SetValue PocoInterface;
	}
}
