using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283B RID: 10299
	public class IVisualNovelPerformanceRoleIntroduction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E531 RID: 58673 RVA: 0x0021DB96 File Offset: 0x0021BD96
		public static IVisualNovelPerformanceRoleIntroduction Create(IVisualNovelPerformanceRoleIntroduction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceRoleIntroduction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x0600E532 RID: 58674 RVA: 0x0021DBB5 File Offset: 0x0021BDB5
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x0021DBC4 File Offset: 0x0021BDC4
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

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x0600E534 RID: 58676 RVA: 0x0021DBFA File Offset: 0x0021BDFA
		public virtual IVisualNovelRoleIntroductionSolarSchool RoleIntroductionConfig
		{
			get
			{
				if (this._RoleIntroductionConfigInited)
				{
					return this._RoleIntroductionConfigCache;
				}
				this._RoleIntroductionConfigInited = true;
				this._RoleIntroductionConfigCache = IVisualNovelRoleIntroductionSolarSchool.Create(this.Instance.RoleIntroductionConfig);
				return this._RoleIntroductionConfigCache;
			}
		}

		// Token: 0x04007DBF RID: 32191
		private IVisualNovelPerformanceRoleIntroduction Instance;

		// Token: 0x04007DC0 RID: 32192
		[Nullable(2)]
		private IVisualNovelRoleIntroductionSolarSchool _RoleIntroductionConfigCache;

		// Token: 0x04007DC1 RID: 32193
		private bool _RoleIntroductionConfigInited;
	}
}
