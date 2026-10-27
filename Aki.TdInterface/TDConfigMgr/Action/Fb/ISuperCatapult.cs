using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DD RID: 10205
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuperCatapult : ILeisureInteractType
	{
		// Token: 0x0600E2D8 RID: 58072 RVA: 0x00217B44 File Offset: 0x00215D44
		public static ISuperCatapult Create(ISuperCatapult? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuperCatapult
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x0600E2D9 RID: 58073 RVA: 0x00217B63 File Offset: 0x00215D63
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x0600E2DA RID: 58074 RVA: 0x00217B70 File Offset: 0x00215D70
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

		// Token: 0x04007DBD RID: 32189
		private ISuperCatapult Instance;

		// Token: 0x04007DBE RID: 32190
		[Nullable(2)]
		private ICatapultParam _ParamCache;

		// Token: 0x04007DBF RID: 32191
		private bool _ParamInited;
	}
}
