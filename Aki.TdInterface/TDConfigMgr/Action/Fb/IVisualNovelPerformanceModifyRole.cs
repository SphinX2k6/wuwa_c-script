using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002577 RID: 9591
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceModifyRole : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D740 RID: 55104 RVA: 0x002010DE File Offset: 0x001FF2DE
		[NullableContext(1)]
		public static IVisualNovelPerformanceModifyRole Create(IVisualNovelPerformanceModifyRole? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceModifyRole
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600D741 RID: 55105 RVA: 0x002010FD File Offset: 0x001FF2FD
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600D742 RID: 55106 RVA: 0x0020110C File Offset: 0x001FF30C
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

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600D743 RID: 55107 RVA: 0x00201142 File Offset: 0x001FF342
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600D744 RID: 55108 RVA: 0x0020114F File Offset: 0x001FF34F
		public virtual IVisualNovelPortraitTransform Transform
		{
			get
			{
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				this._TransformCache = IVisualNovelPortraitTransform.Create(this.Instance.Transform);
				return this._TransformCache;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600D745 RID: 55109 RVA: 0x00201183 File Offset: 0x001FF383
		public virtual IVisualNovelRoleConfig RoleConfig
		{
			get
			{
				if (this._RoleConfigInited)
				{
					return this._RoleConfigCache;
				}
				this._RoleConfigInited = true;
				this._RoleConfigCache = IVisualNovelRoleConfig.Create(this.Instance.RoleConfig);
				return this._RoleConfigCache;
			}
		}

		// Token: 0x04007725 RID: 30501
		private IVisualNovelPerformanceModifyRole Instance;

		// Token: 0x04007726 RID: 30502
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04007727 RID: 30503
		private bool _TransformInited;

		// Token: 0x04007728 RID: 30504
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04007729 RID: 30505
		private bool _RoleConfigInited;
	}
}
