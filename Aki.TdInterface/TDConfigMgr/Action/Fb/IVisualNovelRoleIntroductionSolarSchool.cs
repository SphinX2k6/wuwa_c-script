using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200258C RID: 9612
	public class IVisualNovelRoleIntroductionSolarSchool : IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600D7B2 RID: 55218 RVA: 0x00201DEA File Offset: 0x001FFFEA
		[NullableContext(1)]
		public static IVisualNovelRoleIntroductionSolarSchool Create(IVisualNovelRoleIntroductionSolarSchool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionSolarSchool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600D7B3 RID: 55219 RVA: 0x00201E09 File Offset: 0x00200009
		public override EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0600D7B4 RID: 55220 RVA: 0x00201E16 File Offset: 0x00200016
		public virtual int IntroductionId
		{
			get
			{
				return this.Instance.IntroductionId;
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600D7B5 RID: 55221 RVA: 0x00201E24 File Offset: 0x00200024
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x04007758 RID: 30552
		private IVisualNovelRoleIntroductionSolarSchool Instance;
	}
}
