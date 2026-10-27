using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025EF RID: 9711
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayMpcEffect : PlayEffect2
	{
		// Token: 0x0600DA39 RID: 55865 RVA: 0x0020860B File Offset: 0x0020680B
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

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x0600DA3A RID: 55866 RVA: 0x0020862A File Offset: 0x0020682A
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x0600DA3B RID: 55867 RVA: 0x00208637 File Offset: 0x00206837
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x0600DA3C RID: 55868 RVA: 0x00208644 File Offset: 0x00206844
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

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x0600DA3D RID: 55869 RVA: 0x00208674 File Offset: 0x00206874
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

		// Token: 0x0400792B RID: 31019
		private IPlayMpcEffect Instance;

		// Token: 0x0400792C RID: 31020
		private IBasePos2 _Pos2Cache;

		// Token: 0x0400792D RID: 31021
		private bool _Pos2Inited;

		// Token: 0x0400792E RID: 31022
		private List<IPostProcessVolumeCenterPosition> _ParamsCache;

		// Token: 0x0400792F RID: 31023
		private bool _ParamsInited;
	}
}
