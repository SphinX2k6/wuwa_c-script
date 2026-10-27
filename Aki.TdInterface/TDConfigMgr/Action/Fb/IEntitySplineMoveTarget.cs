using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200271F RID: 10015
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntitySplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x0600DF5C RID: 57180 RVA: 0x002119C6 File Offset: 0x0020FBC6
		public static IEntitySplineMoveTarget Create(IEntitySplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntitySplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x0600DF5D RID: 57181 RVA: 0x002119E5 File Offset: 0x0020FBE5
		public override ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x0600DF5E RID: 57182 RVA: 0x002119F2 File Offset: 0x0020FBF2
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x0600DF5F RID: 57183 RVA: 0x002119FF File Offset: 0x0020FBFF
		public virtual ISplineMoveDriveMode MoveDriveMode
		{
			get
			{
				if (this._MoveDriveModeInited)
				{
					return this._MoveDriveModeCache;
				}
				this._MoveDriveModeInited = true;
				this._MoveDriveModeCache = ActionReadHelper.ReadIEntitySplineMoveTarget_MoveDriveMode(this.Instance);
				return this._MoveDriveModeCache;
			}
		}

		// Token: 0x04007BF3 RID: 31731
		private IEntitySplineMoveTarget Instance;

		// Token: 0x04007BF4 RID: 31732
		private ISplineMoveDriveMode _MoveDriveModeCache;

		// Token: 0x04007BF5 RID: 31733
		private bool _MoveDriveModeInited;
	}
}
