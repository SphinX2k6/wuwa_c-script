using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FA RID: 10746
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyAlertValue : IAlertSystemOption
	{
		// Token: 0x0600ED2F RID: 60719 RVA: 0x0022989C File Offset: 0x00227A9C
		public static IModifyAlertValue Create(IModifyAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x0600ED30 RID: 60720 RVA: 0x002298BB File Offset: 0x00227ABB
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x0600ED31 RID: 60721 RVA: 0x002298C8 File Offset: 0x00227AC8
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x0600ED32 RID: 60722 RVA: 0x002298D5 File Offset: 0x00227AD5
		public virtual ISetAlertValueType SetType
		{
			get
			{
				if (this._SetTypeInited)
				{
					return this._SetTypeCache;
				}
				this._SetTypeInited = true;
				this._SetTypeCache = ActionReadHelper.ReadIModifyAlertValue_SetType(this.Instance);
				return this._SetTypeCache;
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x0600ED33 RID: 60723 RVA: 0x00229904 File Offset: 0x00227B04
		public virtual IAlertValueSpeedChangeType ChangeSpeed
		{
			get
			{
				if (this._ChangeSpeedInited)
				{
					return this._ChangeSpeedCache;
				}
				this._ChangeSpeedInited = true;
				this._ChangeSpeedCache = ActionReadHelper.ReadIModifyAlertValue_ChangeSpeed(this.Instance);
				return this._ChangeSpeedCache;
			}
		}

		// Token: 0x04008294 RID: 33428
		private IModifyAlertValue Instance;

		// Token: 0x04008295 RID: 33429
		private ISetAlertValueType _SetTypeCache;

		// Token: 0x04008296 RID: 33430
		private bool _SetTypeInited;

		// Token: 0x04008297 RID: 33431
		private IAlertValueSpeedChangeType _ChangeSpeedCache;

		// Token: 0x04008298 RID: 33432
		private bool _ChangeSpeedInited;
	}
}
