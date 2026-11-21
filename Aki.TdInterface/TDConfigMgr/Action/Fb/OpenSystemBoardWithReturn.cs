using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C97 RID: 11415
	public class OpenSystemBoardWithReturn : ActionParams
	{
		// Token: 0x0600FA9C RID: 64156 RVA: 0x0024569F File Offset: 0x0024389F
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

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x0600FA9D RID: 64157 RVA: 0x002456BE File Offset: 0x002438BE
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

		// Token: 0x040088E9 RID: 35049
		private IOpenSystemBoardWithReturn Instance;

		// Token: 0x040088EA RID: 35050
		private IOpenSystemBoardWithReturnType _SystemTypeCache;

		// Token: 0x040088EB RID: 35051
		private bool _SystemTypeInited;
	}
}
