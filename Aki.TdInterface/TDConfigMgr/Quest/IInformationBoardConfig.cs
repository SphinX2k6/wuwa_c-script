using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FB7 RID: 4023
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationBoardConfig
	{
		// Token: 0x060059B4 RID: 22964 RVA: 0x000DA748 File Offset: 0x000D8948
		private IInformationBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x000DA780 File Offset: 0x000D8980
		public static IInformationBoardConfig Create([Nullable(2)] IInformationBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x000DA793 File Offset: 0x000D8993
		public static IInformationBoardConfig CreateFromSetValue([Nullable(2)] IInformationBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x000DA7A6 File Offset: 0x000D89A6
		public IInformationBoardConfig_SetValue ToSetValue()
		{
			return new IInformationBoardConfig_SetValue
			{
				InformationBoard = this.InformationBoard
			};
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060059B8 RID: 22968 RVA: 0x000DA7BC File Offset: 0x000D89BC
		// (set) Token: 0x060059B9 RID: 22969 RVA: 0x000DA81D File Offset: 0x000D8A1D
		public virtual IDangoAbyssInformationBoard InformationBoard
		{
			get
			{
				if (this._InformationBoardInited)
				{
					return this._InformationBoardCache;
				}
				this._InformationBoardInited = true;
				if (this.FbInstance != null)
				{
					this._InformationBoardCache = IDangoAbyssInformationBoard.Create(this.FbInstance.InformationBoard);
				}
				else
				{
					IInformationBoardConfig_SetValue pocoInterface = this.PocoInterface;
					this._InformationBoardCache = ((pocoInterface != null) ? pocoInterface.InformationBoard : null);
				}
				return this._InformationBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().InformationBoard = value;
				this._InformationBoardInited = false;
			}
		}

		// Token: 0x04003622 RID: 13858
		[Nullable(2)]
		protected IInformationBoardConfig FbInstance;

		// Token: 0x04003623 RID: 13859
		[Nullable(2)]
		protected IInformationBoardConfig_SetValue PocoInterface;

		// Token: 0x04003624 RID: 13860
		private IDangoAbyssInformationBoard _InformationBoardCache;

		// Token: 0x04003625 RID: 13861
		private bool _InformationBoardInited;
	}
}
