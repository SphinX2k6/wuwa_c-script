using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB1 RID: 2993
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcStandbyShowFinitely : INpcStandbyShowMode
	{
		// Token: 0x060044A4 RID: 17572 RVA: 0x000AE473 File Offset: 0x000AC673
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x000AE492 File Offset: 0x000AC692
		public override ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x000AE4A0 File Offset: 0x000AC6A0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x000AE51A File Offset: 0x000AC71A
		public virtual ENpcStandbyShowFinitelyPlayMode PlayMode
		{
			get
			{
				return (ENpcStandbyShowFinitelyPlayMode)this.Instance.PlayMode;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x000AE528 File Offset: 0x000AC728
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

		// Token: 0x040026CE RID: 9934
		private INpcStandbyShowFinitely Instance;

		// Token: 0x040026CF RID: 9935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040026D0 RID: 9936
		private bool _LookAtConfigsInited;

		// Token: 0x040026D1 RID: 9937
		private List<INpcStandbyShowFinitelyInfo> _MontagesCache;

		// Token: 0x040026D2 RID: 9938
		private bool _MontagesInited;
	}
}
