using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A91 RID: 2705
	public class IStateRepPerfSkillId : IStateRepPerfBase
	{
		// Token: 0x06003E3A RID: 15930 RVA: 0x0009F5C2 File Offset: 0x0009D7C2
		[NullableContext(1)]
		public static IStateRepPerfSkillId Create(IStateRepPerfSkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfSkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06003E3B RID: 15931 RVA: 0x0009F5E1 File Offset: 0x0009D7E1
		public override EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x0009F5EE File Offset: 0x0009D7EE
		public virtual long SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x040022AA RID: 8874
		private IStateRepPerfSkillId Instance;
	}
}
