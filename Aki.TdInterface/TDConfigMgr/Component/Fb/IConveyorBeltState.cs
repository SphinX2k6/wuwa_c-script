using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDE RID: 3038
	[NullableContext(1)]
	[Nullable(0)]
	public class IConveyorBeltState
	{
		// Token: 0x060045D0 RID: 17872 RVA: 0x000B09A8 File Offset: 0x000AEBA8
		public static IConveyorBeltState Create(IConveyorBeltState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x000B09C7 File Offset: 0x000AEBC7
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x000B09D4 File Offset: 0x000AEBD4
		public virtual IConveyorBeltField FieldType
		{
			get
			{
				if (this._FieldTypeInited)
				{
					return this._FieldTypeCache;
				}
				this._FieldTypeInited = true;
				this._FieldTypeCache = ComponentReadHelper.ReadIConveyorBeltState_FieldType(this.Instance);
				return this._FieldTypeCache;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x000B0A03 File Offset: 0x000AEC03
		public virtual IFixSpeed MoveType
		{
			get
			{
				if (this._MoveTypeInited)
				{
					return this._MoveTypeCache;
				}
				this._MoveTypeInited = true;
				this._MoveTypeCache = IFixSpeed.Create(this.Instance.MoveType);
				return this._MoveTypeCache;
			}
		}

		// Token: 0x040027BF RID: 10175
		private IConveyorBeltState Instance;

		// Token: 0x040027C0 RID: 10176
		private IConveyorBeltField _FieldTypeCache;

		// Token: 0x040027C1 RID: 10177
		private bool _FieldTypeInited;

		// Token: 0x040027C2 RID: 10178
		[Nullable(2)]
		private IFixSpeed _MoveTypeCache;

		// Token: 0x040027C3 RID: 10179
		private bool _MoveTypeInited;
	}
}
