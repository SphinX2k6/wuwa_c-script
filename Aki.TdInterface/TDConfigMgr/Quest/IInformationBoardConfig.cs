using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E3 RID: 4323
	public class IInformationBoardConfig
	{
		// Token: 0x06005F92 RID: 24466 RVA: 0x000E72D4 File Offset: 0x000E54D4
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

		// Token: 0x06005F93 RID: 24467 RVA: 0x000E730C File Offset: 0x000E550C
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

		// Token: 0x06005F94 RID: 24468 RVA: 0x000E731F File Offset: 0x000E551F
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

		// Token: 0x06005F95 RID: 24469 RVA: 0x000E7332 File Offset: 0x000E5532
		public IInformationBoardConfig_SetValue ToSetValue()
		{
			return new IInformationBoardConfig_SetValue
			{
				InformationBoard = this.InformationBoard
			};
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x000E7348 File Offset: 0x000E5548
		// (set) Token: 0x06005F97 RID: 24471 RVA: 0x000E73A9 File Offset: 0x000E55A9
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

		// Token: 0x04003957 RID: 14679
		[Nullable(2)]
		protected IInformationBoardConfig FbInstance;

		// Token: 0x04003958 RID: 14680
		[Nullable(2)]
		protected IInformationBoardConfig_SetValue PocoInterface;

		// Token: 0x04003959 RID: 14681
		private IDangoAbyssInformationBoard _InformationBoardCache;

		// Token: 0x0400395A RID: 14682
		private bool _InformationBoardInited;
	}
}
