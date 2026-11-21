using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002820 RID: 10272
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceModifyRole : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E4AC RID: 58540 RVA: 0x0021CD22 File Offset: 0x0021AF22
		[NullableContext(0)]
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

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x0600E4AD RID: 58541 RVA: 0x0021CD41 File Offset: 0x0021AF41
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x0600E4AE RID: 58542 RVA: 0x0021CD50 File Offset: 0x0021AF50
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

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x0600E4AF RID: 58543 RVA: 0x0021CD86 File Offset: 0x0021AF86
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x0600E4B0 RID: 58544 RVA: 0x0021CD93 File Offset: 0x0021AF93
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

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x0021CDC7 File Offset: 0x0021AFC7
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

		// Token: 0x04007D82 RID: 32130
		private IVisualNovelPerformanceModifyRole Instance;

		// Token: 0x04007D83 RID: 32131
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04007D84 RID: 32132
		private bool _TransformInited;

		// Token: 0x04007D85 RID: 32133
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04007D86 RID: 32134
		private bool _RoleConfigInited;
	}
}
