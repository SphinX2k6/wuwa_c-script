using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013DC RID: 5084
	public class ICheckTrapDefenseBdBuffQualityUp : ICheckTrapDefenseEventBase
	{
		// Token: 0x060073F7 RID: 29687 RVA: 0x00115E63 File Offset: 0x00114063
		[NullableContext(1)]
		public static ICheckTrapDefenseBdBuffQualityUp Create(ICheckTrapDefenseBdBuffQualityUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseBdBuffQualityUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x00115E82 File Offset: 0x00114082
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				return (ECheckTrapDefenseEvent)this.Instance.Type;
			}
		}

		// Token: 0x04004320 RID: 17184
		private ICheckTrapDefenseBdBuffQualityUp Instance;
	}
}
