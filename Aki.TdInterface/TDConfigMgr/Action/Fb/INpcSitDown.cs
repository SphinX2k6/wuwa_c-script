using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002817 RID: 10263
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSitDown : INpcLeisureInteractType
	{
		// Token: 0x0600E3AA RID: 58282 RVA: 0x00218B8A File Offset: 0x00216D8A
		public static INpcSitDown Create(INpcSitDown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSitDown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x0600E3AB RID: 58283 RVA: 0x00218BA9 File Offset: 0x00216DA9
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x0600E3AC RID: 58284 RVA: 0x00218BB8 File Offset: 0x00216DB8
		public override bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x0600E3AD RID: 58285 RVA: 0x00218BEE File Offset: 0x00216DEE
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				this._MontageIdCache = IMontageId.Create(this.Instance.MontageId);
				return this._MontageIdCache;
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x00218C22 File Offset: 0x00216E22
		public virtual int PosEntityId
		{
			get
			{
				return this.Instance.PosEntityId;
			}
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x0600E3AF RID: 58287 RVA: 0x00218C2F File Offset: 0x00216E2F
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04007E0B RID: 32267
		private INpcSitDown Instance;

		// Token: 0x04007E0C RID: 32268
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x04007E0D RID: 32269
		private bool _MontageIdInited;
	}
}
