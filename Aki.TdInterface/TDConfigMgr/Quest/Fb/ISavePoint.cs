using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A3 RID: 5539
	[NullableContext(2)]
	[Nullable(0)]
	public class ISavePoint : ISaveConfigType
	{
		// Token: 0x06007CE6 RID: 31974 RVA: 0x00128CED File Offset: 0x00126EED
		[NullableContext(0)]
		public static ISavePoint Create(ISavePoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISavePoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x06007CE7 RID: 31975 RVA: 0x00128D0C File Offset: 0x00126F0C
		public override ESaveConfig Type
		{
			get
			{
				return (ESaveConfig)this.Instance.Type;
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x00128D1C File Offset: 0x00126F1C
		public virtual bool? RelinkRollback
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RelinkRollback);
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x06007CE9 RID: 31977 RVA: 0x00128D52 File Offset: 0x00126F52
		public virtual IPositionRollbackConfig PosRollbackCfg
		{
			get
			{
				if (this._PosRollbackCfgInited)
				{
					return this._PosRollbackCfgCache;
				}
				this._PosRollbackCfgInited = true;
				this._PosRollbackCfgCache = IPositionRollbackConfig.Create(this.Instance.PosRollbackCfg);
				return this._PosRollbackCfgCache;
			}
		}

		// Token: 0x04004829 RID: 18473
		private ISavePoint Instance;

		// Token: 0x0400482A RID: 18474
		private IPositionRollbackConfig _PosRollbackCfgCache;

		// Token: 0x0400482B RID: 18475
		private bool _PosRollbackCfgInited;
	}
}
