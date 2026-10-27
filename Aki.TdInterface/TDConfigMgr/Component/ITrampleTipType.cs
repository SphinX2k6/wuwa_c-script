using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200079E RID: 1950
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrampleTipType
	{
		// Token: 0x06002A48 RID: 10824 RVA: 0x0006F014 File Offset: 0x0006D214
		private ITrampleTipType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrampleTipType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrampleTipType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrampleTipType_SetValue());
			}
			return result;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x0006F04C File Offset: 0x0006D24C
		public static ITrampleTipType Create([Nullable(2)] ITrampleTipType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrampleTipType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x0006F05F File Offset: 0x0006D25F
		public static ITrampleTipType CreateFromSetValue([Nullable(2)] ITrampleTipType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrampleTipType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x0006F072 File Offset: 0x0006D272
		public ITrampleTipType_SetValue ToSetValue()
		{
			return new ITrampleTipType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x0006F085 File Offset: 0x0006D285
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x0006F0B0 File Offset: 0x0006D2B0
		public virtual ETrampleTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001C41 RID: 7233
		[Nullable(2)]
		protected ITrampleTipType FbInstance;

		// Token: 0x04001C42 RID: 7234
		[Nullable(2)]
		protected ITrampleTipType_SetValue PocoInterface;
	}
}
