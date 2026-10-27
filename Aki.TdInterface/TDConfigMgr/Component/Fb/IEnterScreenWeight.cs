using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC6 RID: 3270
	public class IEnterScreenWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06004AC1 RID: 19137 RVA: 0x000BB04D File Offset: 0x000B924D
		[NullableContext(1)]
		public static IEnterScreenWeight Create(IEnterScreenWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterScreenWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x000BB06C File Offset: 0x000B926C
		public override EExploreSkillSearchTargetCfg Type
		{
			get
			{
				return (EExploreSkillSearchTargetCfg)this.Instance.Type;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x000BB079 File Offset: 0x000B9279
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002ABD RID: 10941
		private IEnterScreenWeight Instance;
	}
}
