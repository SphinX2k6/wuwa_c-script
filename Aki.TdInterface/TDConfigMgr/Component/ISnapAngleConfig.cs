using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E0 RID: 1760
	[NullableContext(1)]
	[Nullable(0)]
	public class ISnapAngleConfig
	{
		// Token: 0x060025EE RID: 9710 RVA: 0x00065EC8 File Offset: 0x000640C8
		private ISnapAngleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISnapAngleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISnapAngleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISnapAngleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00065F00 File Offset: 0x00064100
		public static ISnapAngleConfig Create([Nullable(2)] ISnapAngleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISnapAngleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00065F13 File Offset: 0x00064113
		public static ISnapAngleConfig CreateFromSetValue([Nullable(2)] ISnapAngleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISnapAngleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00065F26 File Offset: 0x00064126
		public ISnapAngleConfig_SetValue ToSetValue()
		{
			return new ISnapAngleConfig_SetValue
			{
				Angle = this.Angle,
				Range = this.Range
			};
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00065F45 File Offset: 0x00064145
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x00065F74 File Offset: 0x00064174
		public virtual float Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x00065F82 File Offset: 0x00064182
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x00065FB1 File Offset: 0x000641B1
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x040019D8 RID: 6616
		[Nullable(2)]
		protected ISnapAngleConfig FbInstance;

		// Token: 0x040019D9 RID: 6617
		[Nullable(2)]
		protected ISnapAngleConfig_SetValue PocoInterface;
	}
}
