using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005563 RID: 21859
	public class FishingPointMarkCreateInfo : DynamicMarkCreateInfo
	{
		// Token: 0x170085E8 RID: 34280
		// (get) Token: 0x06037BC9 RID: 228297 RVA: 0x00D38DE6 File Offset: 0x00D36FE6
		public EFishPointDetectSourceType FishPointDetectSourceType
		{
			get
			{
				return ((FishingPointMarkCreateParam)this.CreateParams).FishPointDetectSourceType;
			}
		}

		// Token: 0x06037BCA RID: 228298 RVA: 0x00D38DF8 File Offset: 0x00D36FF8
		[NullableContext(1)]
		public FishingPointMarkCreateInfo(FishingPointMarkCreateParam param) : base(param)
		{
		}
	}
}
