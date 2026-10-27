using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F0 RID: 10480
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseSkiConfig : ISkiConfigType
	{
		// Token: 0x0600E8CE RID: 59598 RVA: 0x0022289C File Offset: 0x00220A9C
		public static ICloseSkiConfig Create(ICloseSkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x0600E8CF RID: 59599 RVA: 0x002228BB File Offset: 0x00220ABB
		public override ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x0600E8D0 RID: 59600 RVA: 0x002228C8 File Offset: 0x00220AC8
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadICloseSkiConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008086 RID: 32902
		private ICloseSkiConfig Instance;

		// Token: 0x04008087 RID: 32903
		private ITargetEntityType _TargetCache;

		// Token: 0x04008088 RID: 32904
		private bool _TargetInited;
	}
}
