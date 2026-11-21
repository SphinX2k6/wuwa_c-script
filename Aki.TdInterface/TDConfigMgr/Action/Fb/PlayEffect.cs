using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A3 RID: 10403
	public class PlayEffect : ActionParams
	{
		// Token: 0x0600E7CA RID: 59338 RVA: 0x00224763 File Offset: 0x00222963
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

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x0600E7CB RID: 59339 RVA: 0x00224782 File Offset: 0x00222982
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0600E7CC RID: 59340 RVA: 0x0022478F File Offset: 0x0022298F
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

		// Token: 0x04007FAB RID: 32683
		private IPlayEffect Instance;

		// Token: 0x04007FAC RID: 32684
		private IBasePos2 _Pos2Cache;

		// Token: 0x04007FAD RID: 32685
		private bool _Pos2Inited;
	}
}
