using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE7 RID: 11495
	public class IModifyAlertValue : IAlertSystemOption
	{
		// Token: 0x0600FBC6 RID: 64454 RVA: 0x00247220 File Offset: 0x00245420
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

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x0600FBC7 RID: 64455 RVA: 0x0024723F File Offset: 0x0024543F
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x0600FBC8 RID: 64456 RVA: 0x0024724C File Offset: 0x0024544C
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x0600FBC9 RID: 64457 RVA: 0x00247259 File Offset: 0x00245459
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

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x0600FBCA RID: 64458 RVA: 0x00247288 File Offset: 0x00245488
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

		// Token: 0x04008985 RID: 35205
		private IModifyAlertValue Instance;

		// Token: 0x04008986 RID: 35206
		private ISetAlertValueType _SetTypeCache;

		// Token: 0x04008987 RID: 35207
		private bool _SetTypeInited;

		// Token: 0x04008988 RID: 35208
		private IAlertValueSpeedChangeType _ChangeSpeedCache;

		// Token: 0x04008989 RID: 35209
		private bool _ChangeSpeedInited;
	}
}
