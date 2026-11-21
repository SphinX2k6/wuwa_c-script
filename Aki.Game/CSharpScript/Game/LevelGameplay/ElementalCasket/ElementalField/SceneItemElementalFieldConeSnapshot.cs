using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x0200601D RID: 24605
	[RequiredMember]
	public class SceneItemElementalFieldConeSnapshot : SceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldConeSnapshot, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17006F9F RID: 28575
		// (get) Token: 0x0603B1AC RID: 242092 RVA: 0x010B7ADF File Offset: 0x010B5CDF
		// (set) Token: 0x0603B1AD RID: 242093 RVA: 0x010B7AE7 File Offset: 0x010B5CE7
		[RequiredMember]
		public FVector ConeAxis { get; set; }

		// Token: 0x17006FA0 RID: 28576
		// (get) Token: 0x0603B1AE RID: 242094 RVA: 0x010B7AF0 File Offset: 0x010B5CF0
		// (set) Token: 0x0603B1AF RID: 242095 RVA: 0x010B7AF8 File Offset: 0x010B5CF8
		[RequiredMember]
		public double ConeHalfAngle { get; set; }

		// Token: 0x17006FA1 RID: 28577
		// (get) Token: 0x0603B1B0 RID: 242096 RVA: 0x010B7B01 File Offset: 0x010B5D01
		// (set) Token: 0x0603B1B1 RID: 242097 RVA: 0x010B7B09 File Offset: 0x010B5D09
		[RequiredMember]
		public double ConeHeight { get; set; }

		// Token: 0x0603B1B2 RID: 242098 RVA: 0x010B7B12 File Offset: 0x010B5D12
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldConeSnapshot()
		{
		}
	}
}
