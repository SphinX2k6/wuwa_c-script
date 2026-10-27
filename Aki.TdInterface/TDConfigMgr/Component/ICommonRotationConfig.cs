using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000251 RID: 593
	[NullableContext(2)]
	[Nullable(0)]
	public class ICommonRotationConfig
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		[NullableContext(1)]
		private ICommonRotationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonRotationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonRotationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonRotationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002BFE4 File Offset: 0x0002A1E4
		[NullableContext(1)]
		public static ICommonRotationConfig Create([Nullable(2)] ICommonRotationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonRotationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0002BFF7 File Offset: 0x0002A1F7
		[NullableContext(1)]
		public static ICommonRotationConfig CreateFromSetValue([Nullable(2)] ICommonRotationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonRotationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0002C00A File Offset: 0x0002A20A
		[NullableContext(1)]
		public ICommonRotationConfig_SetValue ToSetValue()
		{
			return new ICommonRotationConfig_SetValue
			{
				Type = this.Type,
				Time = this.Time,
				Cd = this.Cd,
				Curve = this.Curve
			};
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002C041 File Offset: 0x0002A241
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0002C06C File Offset: 0x0002A26C
		public virtual ERotationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERotationType.Relative;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002C07A File Offset: 0x0002A27A
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x0002C0A9 File Offset: 0x0002A2A9
		public virtual float Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x0002C0F2 File Offset: 0x0002A2F2
		public virtual float? Cd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Cd;
				}
				ICommonRotationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Cd;
			}
			set
			{
				this.GetOrCreatePoco().Cd = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002C100 File Offset: 0x0002A300
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0002C127 File Offset: 0x0002A327
		public virtual string Curve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Curve;
				}
				ICommonRotationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Curve;
			}
			set
			{
				this.GetOrCreatePoco().Curve = value;
			}
		}

		// Token: 0x04000A8C RID: 2700
		protected ICommonRotationConfig FbInstance;

		// Token: 0x04000A8D RID: 2701
		protected ICommonRotationConfig_SetValue PocoInterface;
	}
}
