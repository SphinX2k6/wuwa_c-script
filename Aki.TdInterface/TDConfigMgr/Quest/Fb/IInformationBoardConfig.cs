using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141A RID: 5146
	public class IInformationBoardConfig
	{
		// Token: 0x060074B2 RID: 29874 RVA: 0x00118B0B File Offset: 0x00116D0B
		public static IInformationBoardConfig Create(IInformationBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x060074B3 RID: 29875 RVA: 0x00118B2A File Offset: 0x00116D2A
		public virtual IDangoAbyssInformationBoard InformationBoard
		{
			get
			{
				if (this._InformationBoardInited)
				{
					return this._InformationBoardCache;
				}
				this._InformationBoardInited = true;
				this._InformationBoardCache = IDangoAbyssInformationBoard.Create(this.Instance.InformationBoard);
				return this._InformationBoardCache;
			}
		}

		// Token: 0x04004296 RID: 17046
		private IInformationBoardConfig Instance;

		// Token: 0x04004297 RID: 17047
		[Nullable(2)]
		private IDangoAbyssInformationBoard _InformationBoardCache;

		// Token: 0x04004298 RID: 17048
		private bool _InformationBoardInited;
	}
}
