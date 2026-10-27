using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002642 RID: 9794
	[NullableContext(1)]
	[Nullable(0)]
	public class AwakeEntity : ActionParams
	{
		// Token: 0x0600DBBC RID: 56252 RVA: 0x0020B396 File Offset: 0x00209596
		public static AwakeEntity Create(IAwakeEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AwakeEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x0600DBBD RID: 56253 RVA: 0x0020B3B5 File Offset: 0x002095B5
		[Nullable(2)]
		public virtual IAwakeWithTransformVar Position
		{
			[NullableContext(2)]
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = IAwakeWithTransformVar.Create(this.Instance.Position);
				return this._PositionCache;
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x0600DBBE RID: 56254 RVA: 0x0020B3EC File Offset: 0x002095EC
		public virtual bool? IsSnap
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSnap);
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x0600DBBF RID: 56255 RVA: 0x0020B424 File Offset: 0x00209624
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x04007A18 RID: 31256
		private IAwakeEntity Instance;

		// Token: 0x04007A19 RID: 31257
		[Nullable(2)]
		private IAwakeWithTransformVar _PositionCache;

		// Token: 0x04007A1A RID: 31258
		private bool _PositionInited;

		// Token: 0x04007A1B RID: 31259
		private List<int> _EntityIdsCache;

		// Token: 0x04007A1C RID: 31260
		private bool _EntityIdsInited;
	}
}
