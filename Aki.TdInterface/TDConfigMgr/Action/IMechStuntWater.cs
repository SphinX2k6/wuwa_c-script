using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC3 RID: 7619
	public class IMechStuntWater : IMechStuntConfigType
	{
		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00172954 File Offset: 0x00170B54
		private IMechStuntWater_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntWater 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntWater_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntWater_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x0017298C File Offset: 0x00170B8C
		public static IMechStuntWater Create([Nullable(2)] IMechStuntWater instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntWater
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x0017299F File Offset: 0x00170B9F
		public static IMechStuntWater CreateFromSetValue([Nullable(2)] IMechStuntWater_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntWater
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x001729B2 File Offset: 0x00170BB2
		public new IMechStuntWater_SetValue ToSetValue()
		{
			return new IMechStuntWater_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A1CB RID: 41419 RVA: 0x001729C5 File Offset: 0x00170BC5
		// (set) Token: 0x0600A1CC RID: 41420 RVA: 0x001729F0 File Offset: 0x00170BF0
		public override EMechStuntType Type
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

		// Token: 0x04006232 RID: 25138
		[Nullable(2)]
		protected new IMechStuntWater FbInstance;

		// Token: 0x04006233 RID: 25139
		[Nullable(2)]
		protected new IMechStuntWater_SetValue PocoInterface;
	}
}
