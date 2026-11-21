using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000419 RID: 1049
	public class IFrequencyPaintEncloseLine : IFrequencyPaintLineBase
	{
		// Token: 0x060014E1 RID: 5345 RVA: 0x00042BB0 File Offset: 0x00040DB0
		private IFrequencyPaintEncloseLine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaintEncloseLine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaintEncloseLine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaintEncloseLine_SetValue());
			}
			return result;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00042BE8 File Offset: 0x00040DE8
		public static IFrequencyPaintEncloseLine Create([Nullable(2)] IFrequencyPaintEncloseLine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintEncloseLine
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00042BFB File Offset: 0x00040DFB
		public static IFrequencyPaintEncloseLine CreateFromSetValue([Nullable(2)] IFrequencyPaintEncloseLine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaintEncloseLine
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00042C0E File Offset: 0x00040E0E
		public new IFrequencyPaintEncloseLine_SetValue ToSetValue()
		{
			return new IFrequencyPaintEncloseLine_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00042C21 File Offset: 0x00040E21
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x00042C4C File Offset: 0x00040E4C
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

		// Token: 0x0400108C RID: 4236
		[Nullable(2)]
		protected new IFrequencyPaintEncloseLine FbInstance;

		// Token: 0x0400108D RID: 4237
		[Nullable(2)]
		protected new IFrequencyPaintEncloseLine_SetValue PocoInterface;
	}
}
