using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D99 RID: 7577
	public class ILookAtPerformOverlapMontageConfig
	{
		// Token: 0x0600A0D5 RID: 41173 RVA: 0x00170C28 File Offset: 0x0016EE28
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

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x00170C60 File Offset: 0x0016EE60
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

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x00170C73 File Offset: 0x0016EE73
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

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x00170C86 File Offset: 0x0016EE86
		public ILookAtPerformOverlapMontageConfig_SetValue ToSetValue()
		{
			return new ILookAtPerformOverlapMontageConfig_SetValue
			{
				OverlapMontageLoopDuration = this.OverlapMontageLoopDuration,
				OverlapMontageRepeatTimes = this.OverlapMontageRepeatTimes
			};
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600A0D9 RID: 41177 RVA: 0x00170CA8 File Offset: 0x0016EEA8
		// (set) Token: 0x0600A0DA RID: 41178 RVA: 0x00170CE2 File Offset: 0x0016EEE2
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

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600A0DB RID: 41179 RVA: 0x00170CF0 File Offset: 0x0016EEF0
		// (set) Token: 0x0600A0DC RID: 41180 RVA: 0x00170D2A File Offset: 0x0016EF2A
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

		// Token: 0x040061BA RID: 25018
		[Nullable(2)]
		protected ILookAtPerformOverlapMontageConfig FbInstance;

		// Token: 0x040061BB RID: 25019
		[Nullable(2)]
		protected ILookAtPerformOverlapMontageConfig_SetValue PocoInterface;
	}
}
