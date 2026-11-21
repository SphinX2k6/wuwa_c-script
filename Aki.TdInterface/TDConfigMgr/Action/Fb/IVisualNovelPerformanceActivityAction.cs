using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283E RID: 10302
	public class IVisualNovelPerformanceActivityAction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E53D RID: 58685 RVA: 0x0021DCAB File Offset: 0x0021BEAB
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

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x0600E53E RID: 58686 RVA: 0x0021DCCA File Offset: 0x0021BECA
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x0600E53F RID: 58687 RVA: 0x0021DCD8 File Offset: 0x0021BED8
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

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x0021DD0E File Offset: 0x0021BF0E
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

		// Token: 0x04007DC4 RID: 32196
		private IVisualNovelPerformanceActivityAction Instance;

		// Token: 0x04007DC5 RID: 32197
		[Nullable(2)]
		private IVisualNovelActivityActionSolarSchool _ActivityActionConfigCache;

		// Token: 0x04007DC6 RID: 32198
		private bool _ActivityActionConfigInited;
	}
}
