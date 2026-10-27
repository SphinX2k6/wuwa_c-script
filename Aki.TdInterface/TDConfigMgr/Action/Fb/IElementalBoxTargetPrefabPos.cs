using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B08 RID: 11016
	[NullableContext(1)]
	[Nullable(0)]
	public class IElementalBoxTargetPrefabPos : IElementalBoxTargetPosTypeBase
	{
		// Token: 0x0600F138 RID: 61752 RVA: 0x0022FC53 File Offset: 0x0022DE53
		public static IElementalBoxTargetPrefabPos Create(IElementalBoxTargetPrefabPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalBoxTargetPrefabPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x0600F139 RID: 61753 RVA: 0x0022FC72 File Offset: 0x0022DE72
		public override EElementalBoxTargetPosType Type
		{
			get
			{
				return (EElementalBoxTargetPosType)this.Instance.Type;
			}
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x0600F13A RID: 61754 RVA: 0x0022FC7F File Offset: 0x0022DE7F
		public virtual string TargetKey
		{
			get
			{
				return this.Instance.TargetKey;
			}
		}

		// Token: 0x040084A8 RID: 33960
		private IElementalBoxTargetPrefabPos Instance;
	}
}
