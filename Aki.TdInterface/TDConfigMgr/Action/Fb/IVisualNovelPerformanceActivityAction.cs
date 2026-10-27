using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002590 RID: 9616
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceActivityAction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D7C3 RID: 55235 RVA: 0x00201F77 File Offset: 0x00200177
		public static IVisualNovelPerformanceActivityAction Create(IVisualNovelPerformanceActivityAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceActivityAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x00201F96 File Offset: 0x00200196
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600D7C5 RID: 55237 RVA: 0x00201FA4 File Offset: 0x002001A4
		public override float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0600D7C6 RID: 55238 RVA: 0x00201FDA File Offset: 0x002001DA
		public virtual IVisualNovelActivityActionSolarSchool ActivityActionConfig
		{
			get
			{
				if (this._ActivityActionConfigInited)
				{
					return this._ActivityActionConfigCache;
				}
				this._ActivityActionConfigInited = true;
				this._ActivityActionConfigCache = IVisualNovelActivityActionSolarSchool.Create(this.Instance.ActivityActionConfig);
				return this._ActivityActionConfigCache;
			}
		}

		// Token: 0x0400775E RID: 30558
		private IVisualNovelPerformanceActivityAction Instance;

		// Token: 0x0400775F RID: 30559
		[Nullable(2)]
		private IVisualNovelActivityActionSolarSchool _ActivityActionConfigCache;

		// Token: 0x04007760 RID: 30560
		private bool _ActivityActionConfigInited;
	}
}
