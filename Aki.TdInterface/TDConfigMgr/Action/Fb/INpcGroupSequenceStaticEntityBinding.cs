using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D51 RID: 11601
	public class INpcGroupSequenceStaticEntityBinding : INpcGroupSequenceBindingBase
	{
		// Token: 0x0600FD49 RID: 64841 RVA: 0x00249431 File Offset: 0x00247631
		public static INpcGroupSequenceStaticEntityBinding Create(INpcGroupSequenceStaticEntityBinding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceStaticEntityBinding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x0600FD4A RID: 64842 RVA: 0x00249450 File Offset: 0x00247650
		public override ENpcGroupSequenceBindingType Type
		{
			get
			{
				return (ENpcGroupSequenceBindingType)this.Instance.Type;
			}
		}

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x0600FD4B RID: 64843 RVA: 0x00249460 File Offset: 0x00247660
		public virtual List<int> Actors
		{
			get
			{
				if (this._ActorsInited)
				{
					return this._ActorsCache;
				}
				this._ActorsInited = true;
				int actorsLength = this.Instance.ActorsLength;
				this._ActorsCache = new List<int>(actorsLength);
				for (int i = 0; i < actorsLength; i++)
				{
					this._ActorsCache.Add(this.Instance.Actors(i));
				}
				return this._ActorsCache;
			}
		}

		// Token: 0x04008A3F RID: 35391
		private INpcGroupSequenceStaticEntityBinding Instance;

		// Token: 0x04008A40 RID: 35392
		private List<int> _ActorsCache;

		// Token: 0x04008A41 RID: 35393
		private bool _ActorsInited;
	}
}
