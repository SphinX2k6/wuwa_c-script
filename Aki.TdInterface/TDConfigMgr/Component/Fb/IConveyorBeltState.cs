using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAD RID: 3245
	public class IConveyorBeltState
	{
		// Token: 0x06004A2E RID: 18990 RVA: 0x000BAB24 File Offset: 0x000B8D24
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

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x000BAB43 File Offset: 0x000B8D43
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06004A30 RID: 18992 RVA: 0x000BAB50 File Offset: 0x000B8D50
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

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x000BAB7F File Offset: 0x000B8D7F
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

		// Token: 0x04002A0A RID: 10762
		private IConveyorBeltState Instance;

		// Token: 0x04002A0B RID: 10763
		private IConveyorBeltField _FieldTypeCache;

		// Token: 0x04002A0C RID: 10764
		private bool _FieldTypeInited;

		// Token: 0x04002A0D RID: 10765
		[Nullable(2)]
		private IFixSpeed _MoveTypeCache;

		// Token: 0x04002A0E RID: 10766
		private bool _MoveTypeInited;
	}
}
