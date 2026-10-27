using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028BF RID: 10431
	[NullableContext(1)]
	[Nullable(0)]
	public class AdjustPlayerCamera : ActionParams
	{
		// Token: 0x0600E7CA RID: 59338 RVA: 0x002208DB File Offset: 0x0021EADB
		public static AdjustPlayerCamera Create(IAdjustPlayerCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustPlayerCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x0600E7CB RID: 59339 RVA: 0x002208FA File Offset: 0x0021EAFA
		public virtual IAdjustPlayerCameraType Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadAdjustPlayerCamera_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x04008021 RID: 32801
		private IAdjustPlayerCamera Instance;

		// Token: 0x04008022 RID: 32802
		private IAdjustPlayerCameraType _OptionCache;

		// Token: 0x04008023 RID: 32803
		private bool _OptionInited;
	}
}
