using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AF RID: 10415
	public class IPlayMpcEffect : PlayEffect2
	{
		// Token: 0x0600E806 RID: 59398 RVA: 0x00224D5F File Offset: 0x00222F5F
		public static IPlayMpcEffect Create(IPlayMpcEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayMpcEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x0600E807 RID: 59399 RVA: 0x00224D7E File Offset: 0x00222F7E
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x0600E808 RID: 59400 RVA: 0x00224D8B File Offset: 0x00222F8B
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x0600E809 RID: 59401 RVA: 0x00224D98 File Offset: 0x00222F98
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this._Pos2Inited)
				{
					return this._Pos2Cache;
				}
				this._Pos2Inited = true;
				this._Pos2Cache = ActionReadHelper.ReadIPlayMpcEffect_Pos2(this.Instance);
				return this._Pos2Cache;
			}
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x0600E80A RID: 59402 RVA: 0x00224DC8 File Offset: 0x00222FC8
		public virtual List<IPostProcessVolumeCenterPosition> Params
		{
			get
			{
				if (this._ParamsInited)
				{
					return this._ParamsCache;
				}
				this._ParamsInited = true;
				int paramsLength = this.Instance.ParamsLength;
				this._ParamsCache = new List<IPostProcessVolumeCenterPosition>(paramsLength);
				for (int i = 0; i < paramsLength; i++)
				{
					this._ParamsCache.Add(IPostProcessVolumeCenterPosition.Create(this.Instance.Params(i)));
				}
				return this._ParamsCache;
			}
		}

		// Token: 0x04007FC5 RID: 32709
		private IPlayMpcEffect Instance;

		// Token: 0x04007FC6 RID: 32710
		private IBasePos2 _Pos2Cache;

		// Token: 0x04007FC7 RID: 32711
		private bool _Pos2Inited;

		// Token: 0x04007FC8 RID: 32712
		private List<IPostProcessVolumeCenterPosition> _ParamsCache;

		// Token: 0x04007FC9 RID: 32713
		private bool _ParamsInited;
	}
}
