using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025CF RID: 9679
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotModeUiStyleLevelD : IPlotModeUiStyleBase
	{
		// Token: 0x0600D98F RID: 55695 RVA: 0x0020713E File Offset: 0x0020533E
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

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x0600D990 RID: 55696 RVA: 0x0020715D File Offset: 0x0020535D
		public override EPlotModeUiStyleType Type
		{
			get
			{
				return (EPlotModeUiStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0600D991 RID: 55697 RVA: 0x0020716A File Offset: 0x0020536A
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

		// Token: 0x040078CD RID: 30925
		private IPlotModeUiStyleLevelD Instance;

		// Token: 0x040078CE RID: 30926
		private IUiStyleBaseOfLevelD _UiStyleCache;

		// Token: 0x040078CF RID: 30927
		private bool _UiStyleInited;
	}
}
