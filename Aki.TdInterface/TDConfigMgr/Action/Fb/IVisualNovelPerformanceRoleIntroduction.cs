using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200258D RID: 9613
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceRoleIntroduction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D7B7 RID: 55223 RVA: 0x00201E62 File Offset: 0x00200062
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

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600D7B8 RID: 55224 RVA: 0x00201E81 File Offset: 0x00200081
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600D7B9 RID: 55225 RVA: 0x00201E90 File Offset: 0x00200090
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

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600D7BA RID: 55226 RVA: 0x00201EC6 File Offset: 0x002000C6
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

		// Token: 0x04007759 RID: 30553
		private IVisualNovelPerformanceRoleIntroduction Instance;

		// Token: 0x0400775A RID: 30554
		[Nullable(2)]
		private IVisualNovelRoleIntroductionSolarSchool _RoleIntroductionConfigCache;

		// Token: 0x0400775B RID: 30555
		private bool _RoleIntroductionConfigInited;
	}
}
