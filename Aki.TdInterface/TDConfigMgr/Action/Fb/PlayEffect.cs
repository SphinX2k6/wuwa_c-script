using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025E4 RID: 9700
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayEffect : ActionParams
	{
		// Token: 0x0600DA01 RID: 55809 RVA: 0x00208077 File Offset: 0x00206277
		public static PlayEffect Create(IPlayEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x0600DA02 RID: 55810 RVA: 0x00208096 File Offset: 0x00206296
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x0600DA03 RID: 55811 RVA: 0x002080A3 File Offset: 0x002062A3
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this._Pos2Inited)
				{
					return this._Pos2Cache;
				}
				this._Pos2Inited = true;
				this._Pos2Cache = ActionReadHelper.ReadPlayEffect_Pos2(this.Instance);
				return this._Pos2Cache;
			}
		}

		// Token: 0x04007914 RID: 30996
		private IPlayEffect Instance;

		// Token: 0x04007915 RID: 30997
		private IBasePos2 _Pos2Cache;

		// Token: 0x04007916 RID: 30998
		private bool _Pos2Inited;
	}
}
