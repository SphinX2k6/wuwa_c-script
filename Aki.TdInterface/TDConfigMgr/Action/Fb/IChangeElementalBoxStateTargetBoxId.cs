using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0D RID: 11021
	public class IChangeElementalBoxStateTargetBoxId : IChangeElementalBoxStateTarget
	{
		// Token: 0x0600F14B RID: 61771 RVA: 0x0022FDF6 File Offset: 0x0022DFF6
		[NullableContext(1)]
		public static IChangeElementalBoxStateTargetBoxId Create(IChangeElementalBoxStateTargetBoxId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTargetBoxId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x0600F14C RID: 61772 RVA: 0x0022FE15 File Offset: 0x0022E015
		public override EChangeElementalBoxStateTargetType Type
		{
			get
			{
				return (EChangeElementalBoxStateTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x0600F14D RID: 61773 RVA: 0x0022FE22 File Offset: 0x0022E022
		public virtual int TargetBoxId
		{
			get
			{
				return this.Instance.TargetBoxId;
			}
		}

		// Token: 0x040084B3 RID: 33971
		private IChangeElementalBoxStateTargetBoxId Instance;
	}
}
