using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200028D RID: 653
	[NullableContext(1)]
	[Nullable(0)]
	public class ICountDownTextTip : ITrampleTipType
	{
		// Token: 0x06000C2D RID: 3117 RVA: 0x0002FB54 File Offset: 0x0002DD54
		private ICountDownTextTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICountDownTextTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICountDownTextTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICountDownTextTip_SetValue());
			}
			return result;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0002FB8C File Offset: 0x0002DD8C
		public static ICountDownTextTip Create([Nullable(2)] ICountDownTextTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICountDownTextTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0002FB9F File Offset: 0x0002DD9F
		public static ICountDownTextTip CreateFromSetValue([Nullable(2)] ICountDownTextTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICountDownTextTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0002FBB2 File Offset: 0x0002DDB2
		public new ICountDownTextTip_SetValue ToSetValue()
		{
			return new ICountDownTextTip_SetValue
			{
				Type = this.Type,
				TidCountDownTip = this.TidCountDownTip,
				EdTidCountDownTip = this.EdTidCountDownTip
			};
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0002FBDD File Offset: 0x0002DDDD
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0002FC08 File Offset: 0x0002DE08
		public override ETrampleTipType Type
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0002FC16 File Offset: 0x0002DE16
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0002FC41 File Offset: 0x0002DE41
		public virtual string TidCountDownTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCountDownTip;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidCountDownTip;
			}
			set
			{
				this.GetOrCreatePoco().TidCountDownTip = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0002FC4F File Offset: 0x0002DE4F
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0002FC66 File Offset: 0x0002DE66
		[Nullable(2)]
		public virtual string EdTidCountDownTip
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidCountDownTip;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidCountDownTip = value;
			}
		}

		// Token: 0x04000B8D RID: 2957
		[Nullable(2)]
		protected new ICountDownTextTip FbInstance;

		// Token: 0x04000B8E RID: 2958
		[Nullable(2)]
		protected new ICountDownTextTip_SetValue PocoInterface;
	}
}
