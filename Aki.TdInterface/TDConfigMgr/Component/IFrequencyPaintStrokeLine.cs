using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041F RID: 1055
	public class IFrequencyPaintStrokeLine : IFrequencyPaintLineBase
	{
		// Token: 0x060014F9 RID: 5369 RVA: 0x00042DE4 File Offset: 0x00040FE4
		private IFrequencyPaintStrokeLine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaintStrokeLine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaintStrokeLine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaintStrokeLine_SetValue());
			}
			return result;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00042E1C File Offset: 0x0004101C
		public static IFrequencyPaintStrokeLine Create([Nullable(2)] IFrequencyPaintStrokeLine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintStrokeLine
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00042E2F File Offset: 0x0004102F
		public static IFrequencyPaintStrokeLine CreateFromSetValue([Nullable(2)] IFrequencyPaintStrokeLine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaintStrokeLine
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00042E42 File Offset: 0x00041042
		public new IFrequencyPaintStrokeLine_SetValue ToSetValue()
		{
			return new IFrequencyPaintStrokeLine_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00042E55 File Offset: 0x00041055
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x00042E80 File Offset: 0x00041080
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

		// Token: 0x04001095 RID: 4245
		[Nullable(2)]
		protected new IFrequencyPaintStrokeLine FbInstance;

		// Token: 0x04001096 RID: 4246
		[Nullable(2)]
		protected new IFrequencyPaintStrokeLine_SetValue PocoInterface;
	}
}
