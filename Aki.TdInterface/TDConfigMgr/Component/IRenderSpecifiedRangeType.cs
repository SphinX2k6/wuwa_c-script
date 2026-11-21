using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200071F RID: 1823
	public class IRenderSpecifiedRangeType
	{
		// Token: 0x060026B4 RID: 9908 RVA: 0x000681A4 File Offset: 0x000663A4
		private IRenderSpecifiedRangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderSpecifiedRangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderSpecifiedRangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderSpecifiedRangeType_SetValue());
			}
			return result;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000681DC File Offset: 0x000663DC
		public static IRenderSpecifiedRangeType Create([Nullable(2)] IRenderSpecifiedRangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderSpecifiedRangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000681EF File Offset: 0x000663EF
		public static IRenderSpecifiedRangeType CreateFromSetValue([Nullable(2)] IRenderSpecifiedRangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderSpecifiedRangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00068202 File Offset: 0x00066402
		public IRenderSpecifiedRangeType_SetValue ToSetValue()
		{
			return new IRenderSpecifiedRangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x00068215 File Offset: 0x00066415
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x00068240 File Offset: 0x00066440
		public virtual ERenderSpecifiedRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A93 RID: 6803
		[Nullable(2)]
		protected IRenderSpecifiedRangeType FbInstance;

		// Token: 0x04001A94 RID: 6804
		[Nullable(2)]
		protected IRenderSpecifiedRangeType_SetValue PocoInterface;
	}
}
