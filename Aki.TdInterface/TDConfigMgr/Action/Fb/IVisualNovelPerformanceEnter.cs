using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002574 RID: 9588
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceEnter : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D727 RID: 55079 RVA: 0x00200D62 File Offset: 0x001FEF62
		[NullableContext(1)]
		public static IVisualNovelPerformanceEnter Create(IVisualNovelPerformanceEnter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceEnter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600D728 RID: 55080 RVA: 0x00200D81 File Offset: 0x001FEF81
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600D729 RID: 55081 RVA: 0x00200D90 File Offset: 0x001FEF90
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

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600D72A RID: 55082 RVA: 0x00200DC6 File Offset: 0x001FEFC6
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600D72B RID: 55083 RVA: 0x00200DD3 File Offset: 0x001FEFD3
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

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600D72C RID: 55084 RVA: 0x00200E08 File Offset: 0x001FF008
		public virtual float? FadeInTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeInTime);
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600D72D RID: 55085 RVA: 0x00200E3E File Offset: 0x001FF03E
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

		// Token: 0x04007716 RID: 30486
		private IVisualNovelPerformanceEnter Instance;

		// Token: 0x04007717 RID: 30487
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04007718 RID: 30488
		private bool _TransformInited;

		// Token: 0x04007719 RID: 30489
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x0400771A RID: 30490
		private bool _RoleConfigInited;
	}
}
