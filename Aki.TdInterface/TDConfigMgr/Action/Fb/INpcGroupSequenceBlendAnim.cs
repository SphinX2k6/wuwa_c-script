using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D54 RID: 11604
	public class INpcGroupSequenceBlendAnim
	{
		// Token: 0x0600FD54 RID: 64852 RVA: 0x00249541 File Offset: 0x00247741
		public static INpcGroupSequenceBlendAnim Create(INpcGroupSequenceBlendAnim? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnim
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x0600FD55 RID: 64853 RVA: 0x00249560 File Offset: 0x00247760
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x0600FD56 RID: 64854 RVA: 0x0024956D File Offset: 0x0024776D
		public virtual INpcGroupSequenceMontageBlendAnimType BlendType
		{
			get
			{
				if (this._BlendTypeInited)
				{
					return this._BlendTypeCache;
				}
				this._BlendTypeInited = true;
				this._BlendTypeCache = INpcGroupSequenceMontageBlendAnimType.Create(this.Instance.BlendType);
				return this._BlendTypeCache;
			}
		}

		// Token: 0x04008A44 RID: 35396
		private INpcGroupSequenceBlendAnim Instance;

		// Token: 0x04008A45 RID: 35397
		[Nullable(2)]
		private INpcGroupSequenceMontageBlendAnimType _BlendTypeCache;

		// Token: 0x04008A46 RID: 35398
		private bool _BlendTypeInited;
	}
}
