using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFB RID: 3579
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollComboCameraConfig
	{
		// Token: 0x06005112 RID: 20754 RVA: 0x000C819A File Offset: 0x000C639A
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

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06005113 RID: 20755 RVA: 0x000C81B9 File Offset: 0x000C63B9
		public virtual int ComboId
		{
			get
			{
				return this.Instance.ComboId;
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x000C81C6 File Offset: 0x000C63C6
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

		// Token: 0x04002E9C RID: 11932
		private IDollComboCameraConfig Instance;

		// Token: 0x04002E9D RID: 11933
		[Nullable(2)]
		private PosAndRot _PosAndRotCache;

		// Token: 0x04002E9E RID: 11934
		private bool _PosAndRotInited;
	}
}
