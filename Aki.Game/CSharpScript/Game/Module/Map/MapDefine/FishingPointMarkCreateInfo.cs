using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004535 RID: 17717
	public class FishingPointMarkCreateInfo : DynamicMarkCreateInfo
	{
		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x0602CA99 RID: 182937 RVA: 0x00C868BA File Offset: 0x00C84ABA
		public EFishPointDetectSourceType FishPointDetectSourceType
		{
			get
			{
				return ((FishingPointMarkCreateParam)this.CreateParams).FishPointDetectSourceType;
			}
		}

		// Token: 0x0602CA9A RID: 182938 RVA: 0x00C868CC File Offset: 0x00C84ACC
		[NullableContext(1)]
		public FishingPointMarkCreateInfo(FishingPointMarkCreateParam param) : base(param)
		{
		}
	}
}
