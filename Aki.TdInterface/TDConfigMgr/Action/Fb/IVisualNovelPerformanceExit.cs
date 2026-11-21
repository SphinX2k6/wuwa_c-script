using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281E RID: 10270
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceExit : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E49B RID: 58523 RVA: 0x0021CABE File Offset: 0x0021ACBE
		[NullableContext(0)]
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

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x0600E49C RID: 58524 RVA: 0x0021CADD File Offset: 0x0021ACDD
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x0600E49D RID: 58525 RVA: 0x0021CAEC File Offset: 0x0021ACEC
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

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x0021CB22 File Offset: 0x0021AD22
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x0600E49F RID: 58527 RVA: 0x0021CB30 File Offset: 0x0021AD30
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

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x0021CB68 File Offset: 0x0021AD68
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

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x0600E4A1 RID: 58529 RVA: 0x0021CB9E File Offset: 0x0021AD9E
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

		// Token: 0x04007D78 RID: 32120
		private IVisualNovelPerformanceExit Instance;

		// Token: 0x04007D79 RID: 32121
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04007D7A RID: 32122
		private bool _RoleConfigInited;
	}
}
