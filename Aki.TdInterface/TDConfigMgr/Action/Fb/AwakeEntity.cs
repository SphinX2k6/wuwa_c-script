using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002902 RID: 10498
	public class AwakeEntity : ActionParams
	{
		// Token: 0x0600E98A RID: 59786 RVA: 0x00227B62 File Offset: 0x00225D62
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

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x0600E98B RID: 59787 RVA: 0x00227B81 File Offset: 0x00225D81
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

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x0600E98C RID: 59788 RVA: 0x00227BB8 File Offset: 0x00225DB8
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

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x00227BF0 File Offset: 0x00225DF0
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

		// Token: 0x040080B4 RID: 32948
		private IAwakeEntity Instance;

		// Token: 0x040080B5 RID: 32949
		[Nullable(2)]
		private IAwakeWithTransformVar _PositionCache;

		// Token: 0x040080B6 RID: 32950
		private bool _PositionInited;

		// Token: 0x040080B7 RID: 32951
		private List<int> _EntityIdsCache;

		// Token: 0x040080B8 RID: 32952
		private bool _EntityIdsInited;
	}
}
