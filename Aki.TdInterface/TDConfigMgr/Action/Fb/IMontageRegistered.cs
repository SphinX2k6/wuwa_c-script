using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288A RID: 10378
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageRegistered : IMontageConfig
	{
		// Token: 0x0600E5E7 RID: 58855 RVA: 0x0021CB44 File Offset: 0x0021AD44
		public static IMontageRegistered Create(IMontageRegistered? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageRegistered
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x0021CB63 File Offset: 0x0021AD63
		public override EMontageConfigType Type
		{
			get
			{
				return (EMontageConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x0600E5E9 RID: 58857 RVA: 0x0021CB70 File Offset: 0x0021AD70
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

		// Token: 0x04007F1A RID: 32538
		private IMontageRegistered Instance;

		// Token: 0x04007F1B RID: 32539
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x04007F1C RID: 32540
		private bool _MontageIdInited;
	}
}
