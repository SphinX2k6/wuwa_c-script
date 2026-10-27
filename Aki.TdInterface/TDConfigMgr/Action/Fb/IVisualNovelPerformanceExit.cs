using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002575 RID: 9589
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceExit : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D72F RID: 55087 RVA: 0x00200E7A File Offset: 0x001FF07A
		[NullableContext(1)]
		public static IVisualNovelPerformanceExit Create(IVisualNovelPerformanceExit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceExit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600D730 RID: 55088 RVA: 0x00200E99 File Offset: 0x001FF099
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600D731 RID: 55089 RVA: 0x00200EA8 File Offset: 0x001FF0A8
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

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600D732 RID: 55090 RVA: 0x00200EDE File Offset: 0x001FF0DE
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x0600D733 RID: 55091 RVA: 0x00200EEC File Offset: 0x001FF0EC
		public virtual bool? AllExit
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AllExit);
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600D734 RID: 55092 RVA: 0x00200F24 File Offset: 0x001FF124
		public virtual float? FadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeOutTime);
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600D735 RID: 55093 RVA: 0x00200F5A File Offset: 0x001FF15A
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

		// Token: 0x0400771B RID: 30491
		private IVisualNovelPerformanceExit Instance;

		// Token: 0x0400771C RID: 30492
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x0400771D RID: 30493
		private bool _RoleConfigInited;
	}
}
