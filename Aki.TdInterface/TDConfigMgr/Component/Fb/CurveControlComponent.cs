using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9E RID: 3486
	[NullableContext(2)]
	[Nullable(0)]
	public class CurveControlComponent : IComponentBase
	{
		// Token: 0x06004F3E RID: 20286 RVA: 0x000C46C0 File Offset: 0x000C28C0
		[NullableContext(1)]
		public static CurveControlComponent Create(ICurveControlComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CurveControlComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x000C46E0 File Offset: 0x000C28E0
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06004F40 RID: 20288 RVA: 0x000C4718 File Offset: 0x000C2918
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06004F41 RID: 20289 RVA: 0x000C472E File Offset: 0x000C292E
		public virtual IChargeSlashControl CurveControlConfig
		{
			get
			{
				if (this._CurveControlConfigInited)
				{
					return this._CurveControlConfigCache;
				}
				this._CurveControlConfigInited = true;
				this._CurveControlConfigCache = IChargeSlashControl.Create(this.Instance.CurveControlConfig);
				return this._CurveControlConfigCache;
			}
		}

		// Token: 0x04002D7F RID: 11647
		private ICurveControlComponent Instance;

		// Token: 0x04002D80 RID: 11648
		private IChargeSlashControl _CurveControlConfigCache;

		// Token: 0x04002D81 RID: 11649
		private bool _CurveControlConfigInited;
	}
}
