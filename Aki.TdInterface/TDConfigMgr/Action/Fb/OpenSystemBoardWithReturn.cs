using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AA RID: 10666
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemBoardWithReturn : ActionParams
	{
		// Token: 0x0600EC05 RID: 60421 RVA: 0x00227D1A File Offset: 0x00225F1A
		public static OpenSystemBoardWithReturn Create(IOpenSystemBoardWithReturn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSystemBoardWithReturn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x0600EC06 RID: 60422 RVA: 0x00227D39 File Offset: 0x00225F39
		public virtual IOpenSystemBoardWithReturnType SystemType
		{
			get
			{
				if (this._SystemTypeInited)
				{
					return this._SystemTypeCache;
				}
				this._SystemTypeInited = true;
				this._SystemTypeCache = ActionReadHelper.ReadOpenSystemBoardWithReturn_SystemType(this.Instance);
				return this._SystemTypeCache;
			}
		}

		// Token: 0x040081F8 RID: 33272
		private IOpenSystemBoardWithReturn Instance;

		// Token: 0x040081F9 RID: 33273
		private IOpenSystemBoardWithReturnType _SystemTypeCache;

		// Token: 0x040081FA RID: 33274
		private bool _SystemTypeInited;
	}
}
