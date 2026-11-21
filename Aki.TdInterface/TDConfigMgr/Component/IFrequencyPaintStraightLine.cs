using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041D RID: 1053
	public class IFrequencyPaintStraightLine : IFrequencyPaintLineBase
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x00042D28 File Offset: 0x00040F28
		private IFrequencyPaintStraightLine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaintStraightLine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaintStraightLine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaintStraightLine_SetValue());
			}
			return result;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00042D60 File Offset: 0x00040F60
		public static IFrequencyPaintStraightLine Create([Nullable(2)] IFrequencyPaintStraightLine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintStraightLine
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00042D73 File Offset: 0x00040F73
		public static IFrequencyPaintStraightLine CreateFromSetValue([Nullable(2)] IFrequencyPaintStraightLine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaintStraightLine
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00042D86 File Offset: 0x00040F86
		public new IFrequencyPaintStraightLine_SetValue ToSetValue()
		{
			return new IFrequencyPaintStraightLine_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00042D99 File Offset: 0x00040F99
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00042DC4 File Offset: 0x00040FC4
		public override EFrequencyPaintLineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFrequencyPaintLineType.Straight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001092 RID: 4242
		[Nullable(2)]
		protected new IFrequencyPaintStraightLine FbInstance;

		// Token: 0x04001093 RID: 4243
		[Nullable(2)]
		protected new IFrequencyPaintStraightLine_SetValue PocoInterface;
	}
}
