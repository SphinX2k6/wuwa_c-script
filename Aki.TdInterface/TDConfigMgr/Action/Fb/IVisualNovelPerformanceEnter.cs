using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281D RID: 10269
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceEnter : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E493 RID: 58515 RVA: 0x0021C9A6 File Offset: 0x0021ABA6
		[NullableContext(0)]
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

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x0600E494 RID: 58516 RVA: 0x0021C9C5 File Offset: 0x0021ABC5
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x0600E495 RID: 58517 RVA: 0x0021C9D4 File Offset: 0x0021ABD4
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

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x0600E496 RID: 58518 RVA: 0x0021CA0A File Offset: 0x0021AC0A
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x0600E497 RID: 58519 RVA: 0x0021CA17 File Offset: 0x0021AC17
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

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x0600E498 RID: 58520 RVA: 0x0021CA4C File Offset: 0x0021AC4C
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

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x0600E499 RID: 58521 RVA: 0x0021CA82 File Offset: 0x0021AC82
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

		// Token: 0x04007D73 RID: 32115
		private IVisualNovelPerformanceEnter Instance;

		// Token: 0x04007D74 RID: 32116
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04007D75 RID: 32117
		private bool _TransformInited;

		// Token: 0x04007D76 RID: 32118
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04007D77 RID: 32119
		private bool _RoleConfigInited;
	}
}
