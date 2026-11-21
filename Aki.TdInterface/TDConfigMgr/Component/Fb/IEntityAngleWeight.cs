using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C03 RID: 3075
	public class IEntityAngleWeight
	{
		// Token: 0x06004695 RID: 18069 RVA: 0x000B3AF2 File Offset: 0x000B1CF2
		public static IEntityAngleWeight Create(IEntityAngleWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityAngleWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x000B3B11 File Offset: 0x000B1D11
		public virtual int Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x000B3B1E File Offset: 0x000B1D1E
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x040027A0 RID: 10144
		private IEntityAngleWeight Instance;
	}
}
