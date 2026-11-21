using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288E RID: 10382
	public class IPlotModeUiStyleLevelD : IPlotModeUiStyleBase
	{
		// Token: 0x0600E757 RID: 59223 RVA: 0x002237F5 File Offset: 0x002219F5
		public static IPlotModeUiStyleLevelD Create(IPlotModeUiStyleLevelD? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotModeUiStyleLevelD
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x0600E758 RID: 59224 RVA: 0x00223814 File Offset: 0x00221A14
		public override EPlotModeUiStyleType Type
		{
			get
			{
				return (EPlotModeUiStyleType)this.Instance.Type;
			}
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x0600E759 RID: 59225 RVA: 0x00223821 File Offset: 0x00221A21
		public virtual IUiStyleBaseOfLevelD UiStyle
		{
			get
			{
				if (this._UiStyleInited)
				{
					return this._UiStyleCache;
				}
				this._UiStyleInited = true;
				this._UiStyleCache = ActionReadHelper.ReadIPlotModeUiStyleLevelD_UiStyle(this.Instance);
				return this._UiStyleCache;
			}
		}

		// Token: 0x04007F64 RID: 32612
		private IPlotModeUiStyleLevelD Instance;

		// Token: 0x04007F65 RID: 32613
		private IUiStyleBaseOfLevelD _UiStyleCache;

		// Token: 0x04007F66 RID: 32614
		private bool _UiStyleInited;
	}
}
