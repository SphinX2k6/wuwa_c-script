using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E9A RID: 3738
	[NullableContext(2)]
	[Nullable(0)]
	public class CurveControlComponent : IComponentBase
	{
		// Token: 0x06005463 RID: 21603 RVA: 0x000CFF10 File Offset: 0x000CE110
		[NullableContext(0)]
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

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06005464 RID: 21604 RVA: 0x000CFF30 File Offset: 0x000CE130
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

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x000CFF68 File Offset: 0x000CE168
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x000CFF7E File Offset: 0x000CE17E
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

		// Token: 0x04003045 RID: 12357
		private ICurveControlComponent Instance;

		// Token: 0x04003046 RID: 12358
		private IChargeSlashControl _CurveControlConfigCache;

		// Token: 0x04003047 RID: 12359
		private bool _CurveControlConfigInited;
	}
}
