using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7F RID: 3199
	public class INpcStandbyShowFinitely : INpcStandbyShowMode
	{
		// Token: 0x060048FD RID: 18685 RVA: 0x000B8537 File Offset: 0x000B6737
		public static INpcStandbyShowFinitely Create(INpcStandbyShowFinitely? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitely
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060048FE RID: 18686 RVA: 0x000B8556 File Offset: 0x000B6756
		public override ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x000B8564 File Offset: 0x000B6764
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int lookAtConfigsLength = this.Instance.LookAtConfigsLength;
				this._LookAtConfigsCache = new List<INpcLookAtConfig>(lookAtConfigsLength);
				for (int i = 0; i < lookAtConfigsLength; i++)
				{
					this._LookAtConfigsCache.Add(INpcLookAtConfig.Create(this.Instance.LookAtConfigs(i)));
				}
				return this._LookAtConfigsCache;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06004900 RID: 18688 RVA: 0x000B85DE File Offset: 0x000B67DE
		public virtual ENpcStandbyShowFinitelyPlayMode PlayMode
		{
			get
			{
				return (ENpcStandbyShowFinitelyPlayMode)this.Instance.PlayMode;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x000B85EC File Offset: 0x000B67EC
		public virtual List<INpcStandbyShowFinitelyInfo> Montages
		{
			get
			{
				if (this._MontagesInited)
				{
					return this._MontagesCache;
				}
				this._MontagesInited = true;
				int montagesLength = this.Instance.MontagesLength;
				this._MontagesCache = new List<INpcStandbyShowFinitelyInfo>(montagesLength);
				for (int i = 0; i < montagesLength; i++)
				{
					this._MontagesCache.Add(INpcStandbyShowFinitelyInfo.Create(this.Instance.Montages(i)));
				}
				return this._MontagesCache;
			}
		}

		// Token: 0x04002916 RID: 10518
		private INpcStandbyShowFinitely Instance;

		// Token: 0x04002917 RID: 10519
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04002918 RID: 10520
		private bool _LookAtConfigsInited;

		// Token: 0x04002919 RID: 10521
		private List<INpcStandbyShowFinitelyInfo> _MontagesCache;

		// Token: 0x0400291A RID: 10522
		private bool _MontagesInited;
	}
}
