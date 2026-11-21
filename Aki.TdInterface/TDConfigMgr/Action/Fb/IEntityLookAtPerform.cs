using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D59 RID: 11609
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerform
	{
		// Token: 0x0600FD6B RID: 64875 RVA: 0x0024986E File Offset: 0x00247A6E
		[NullableContext(0)]
		public static IEntityLookAtPerform Create(IEntityLookAtPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityLookAtPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x0600FD6C RID: 64876 RVA: 0x0024988D File Offset: 0x00247A8D
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x0600FD6D RID: 64877 RVA: 0x0024989C File Offset: 0x00247A9C
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x0600FD6E RID: 64878 RVA: 0x002498D4 File Offset: 0x00247AD4
		public virtual int? OverlapMontageId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OverlapMontageId);
			}
		}

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x0600FD6F RID: 64879 RVA: 0x0024990A File Offset: 0x00247B0A
		public virtual ILookAtPerformOverlapMontageConfig OverlapMontageConfig
		{
			get
			{
				if (this._OverlapMontageConfigInited)
				{
					return this._OverlapMontageConfigCache;
				}
				this._OverlapMontageConfigInited = true;
				this._OverlapMontageConfigCache = ILookAtPerformOverlapMontageConfig.Create(this.Instance.OverlapMontageConfig);
				return this._OverlapMontageConfigCache;
			}
		}

		// Token: 0x04008A53 RID: 35411
		private IEntityLookAtPerform Instance;

		// Token: 0x04008A54 RID: 35412
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04008A55 RID: 35413
		private bool _OverlapMontageConfigInited;
	}
}
