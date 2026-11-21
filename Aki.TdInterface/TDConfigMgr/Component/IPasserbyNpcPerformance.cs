using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064B RID: 1611
	public class IPasserbyNpcPerformance
	{
		// Token: 0x060021D6 RID: 8662 RVA: 0x0005DD48 File Offset: 0x0005BF48
		private IPasserbyNpcPerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcPerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcPerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcPerformance_SetValue());
			}
			return result;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0005DD80 File Offset: 0x0005BF80
		public static IPasserbyNpcPerformance Create([Nullable(2)] IPasserbyNpcPerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcPerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0005DD93 File Offset: 0x0005BF93
		public static IPasserbyNpcPerformance CreateFromSetValue([Nullable(2)] IPasserbyNpcPerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcPerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0005DDA6 File Offset: 0x0005BFA6
		public IPasserbyNpcPerformance_SetValue ToSetValue()
		{
			return new IPasserbyNpcPerformance_SetValue
			{
				EffectGroupDa = this.EffectGroupDa
			};
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x0005DDB9 File Offset: 0x0005BFB9
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x0005DDE0 File Offset: 0x0005BFE0
		[Nullable(2)]
		public virtual string EffectGroupDa
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectGroupDa;
				}
				IPasserbyNpcPerformance_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectGroupDa;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EffectGroupDa = value;
			}
		}

		// Token: 0x040017D8 RID: 6104
		[Nullable(2)]
		protected IPasserbyNpcPerformance FbInstance;

		// Token: 0x040017D9 RID: 6105
		[Nullable(2)]
		protected IPasserbyNpcPerformance_SetValue PocoInterface;
	}
}
