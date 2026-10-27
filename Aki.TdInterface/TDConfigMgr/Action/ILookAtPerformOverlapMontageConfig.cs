using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB2 RID: 7090
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtPerformOverlapMontageConfig
	{
		// Token: 0x060097D1 RID: 38865 RVA: 0x0015E168 File Offset: 0x0015C368
		private ILookAtPerformOverlapMontageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtPerformOverlapMontageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtPerformOverlapMontageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtPerformOverlapMontageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x0015E1A0 File Offset: 0x0015C3A0
		public static ILookAtPerformOverlapMontageConfig Create([Nullable(2)] ILookAtPerformOverlapMontageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtPerformOverlapMontageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x0015E1B3 File Offset: 0x0015C3B3
		public static ILookAtPerformOverlapMontageConfig CreateFromSetValue([Nullable(2)] ILookAtPerformOverlapMontageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtPerformOverlapMontageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x0015E1C6 File Offset: 0x0015C3C6
		public ILookAtPerformOverlapMontageConfig_SetValue ToSetValue()
		{
			return new ILookAtPerformOverlapMontageConfig_SetValue
			{
				OverlapMontageLoopDuration = this.OverlapMontageLoopDuration,
				OverlapMontageRepeatTimes = this.OverlapMontageRepeatTimes
			};
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x060097D5 RID: 38869 RVA: 0x0015E1E8 File Offset: 0x0015C3E8
		// (set) Token: 0x060097D6 RID: 38870 RVA: 0x0015E222 File Offset: 0x0015C422
		public virtual float? OverlapMontageLoopDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverlapMontageLoopDuration;
				}
				ILookAtPerformOverlapMontageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OverlapMontageLoopDuration;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageLoopDuration = value;
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x060097D7 RID: 38871 RVA: 0x0015E230 File Offset: 0x0015C430
		// (set) Token: 0x060097D8 RID: 38872 RVA: 0x0015E26A File Offset: 0x0015C46A
		public virtual int? OverlapMontageRepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverlapMontageRepeatTimes;
				}
				ILookAtPerformOverlapMontageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OverlapMontageRepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageRepeatTimes = value;
			}
		}

		// Token: 0x04005CA5 RID: 23717
		[Nullable(2)]
		protected ILookAtPerformOverlapMontageConfig FbInstance;

		// Token: 0x04005CA6 RID: 23718
		[Nullable(2)]
		protected ILookAtPerformOverlapMontageConfig_SetValue PocoInterface;
	}
}
