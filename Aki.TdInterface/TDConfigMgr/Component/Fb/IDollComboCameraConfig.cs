using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF7 RID: 3831
	public class IDollComboCameraConfig
	{
		// Token: 0x06005639 RID: 22073 RVA: 0x000D3A62 File Offset: 0x000D1C62
		public static IDollComboCameraConfig Create(IDollComboCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollComboCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x000D3A81 File Offset: 0x000D1C81
		public virtual int ComboId
		{
			get
			{
				return this.Instance.ComboId;
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600563B RID: 22075 RVA: 0x000D3A8E File Offset: 0x000D1C8E
		public virtual PosAndRot PosAndRot
		{
			get
			{
				if (this._PosAndRotInited)
				{
					return this._PosAndRotCache;
				}
				this._PosAndRotInited = true;
				this._PosAndRotCache = PosAndRot.Create(this.Instance.PosAndRot);
				return this._PosAndRotCache;
			}
		}

		// Token: 0x04003164 RID: 12644
		private IDollComboCameraConfig Instance;

		// Token: 0x04003165 RID: 12645
		[Nullable(2)]
		private PosAndRot _PosAndRotCache;

		// Token: 0x04003166 RID: 12646
		private bool _PosAndRotInited;
	}
}
