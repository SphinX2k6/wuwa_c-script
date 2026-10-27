using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D4 RID: 4820
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationBoardConfig
	{
		// Token: 0x06006E34 RID: 28212 RVA: 0x0010A87B File Offset: 0x00108A7B
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

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0010A89A File Offset: 0x00108A9A
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

		// Token: 0x04003F28 RID: 16168
		private IInformationBoardConfig Instance;

		// Token: 0x04003F29 RID: 16169
		[Nullable(2)]
		private IDangoAbyssInformationBoard _InformationBoardCache;

		// Token: 0x04003F2A RID: 16170
		private bool _InformationBoardInited;
	}
}
