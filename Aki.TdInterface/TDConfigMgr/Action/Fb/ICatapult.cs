using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DC RID: 10204
	[NullableContext(1)]
	[Nullable(0)]
	public class ICatapult : ILeisureInteractType
	{
		// Token: 0x0600E2D4 RID: 58068 RVA: 0x00217ADC File Offset: 0x00215CDC
		public static ICatapult Create(ICatapult? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICatapult
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x0600E2D5 RID: 58069 RVA: 0x00217AFB File Offset: 0x00215CFB
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x0600E2D6 RID: 58070 RVA: 0x00217B08 File Offset: 0x00215D08
		public virtual ICatapultParam Param
		{
			get
			{
				if (this._ParamInited)
				{
					return this._ParamCache;
				}
				this._ParamInited = true;
				this._ParamCache = ICatapultParam.Create(this.Instance.Param);
				return this._ParamCache;
			}
		}

		// Token: 0x04007DBA RID: 32186
		private ICatapult Instance;

		// Token: 0x04007DBB RID: 32187
		[Nullable(2)]
		private ICatapultParam _ParamCache;

		// Token: 0x04007DBC RID: 32188
		private bool _ParamInited;
	}
}
