using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041B RID: 1051
	public class IFrequencyPaintLineBase
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x00042C6C File Offset: 0x00040E6C
		private IFrequencyPaintLineBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaintLineBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaintLineBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaintLineBase_SetValue());
			}
			return result;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00042CA4 File Offset: 0x00040EA4
		public static IFrequencyPaintLineBase Create([Nullable(2)] IFrequencyPaintLineBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintLineBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00042CB7 File Offset: 0x00040EB7
		public static IFrequencyPaintLineBase CreateFromSetValue([Nullable(2)] IFrequencyPaintLineBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaintLineBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00042CCA File Offset: 0x00040ECA
		public IFrequencyPaintLineBase_SetValue ToSetValue()
		{
			return new IFrequencyPaintLineBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00042CDD File Offset: 0x00040EDD
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x00042D08 File Offset: 0x00040F08
		public virtual EFrequencyPaintLineType Type
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

		// Token: 0x0400108F RID: 4239
		[Nullable(2)]
		protected IFrequencyPaintLineBase FbInstance;

		// Token: 0x04001090 RID: 4240
		[Nullable(2)]
		protected IFrequencyPaintLineBase_SetValue PocoInterface;
	}
}
