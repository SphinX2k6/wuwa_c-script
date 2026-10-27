using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E9D RID: 28317
	[RequiredMember]
	public class SceneItemElementalFieldConeSnapshot : SceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldConeSnapshot, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17009A68 RID: 39528
		// (get) Token: 0x0604500B RID: 282635 RVA: 0x0110DA03 File Offset: 0x0110BC03
		// (set) Token: 0x0604500C RID: 282636 RVA: 0x0110DA0B File Offset: 0x0110BC0B
		[RequiredMember]
		public FVector ConeAxis { get; set; }

		// Token: 0x17009A69 RID: 39529
		// (get) Token: 0x0604500D RID: 282637 RVA: 0x0110DA14 File Offset: 0x0110BC14
		// (set) Token: 0x0604500E RID: 282638 RVA: 0x0110DA1C File Offset: 0x0110BC1C
		[RequiredMember]
		public double ConeHalfAngle { get; set; }

		// Token: 0x17009A6A RID: 39530
		// (get) Token: 0x0604500F RID: 282639 RVA: 0x0110DA25 File Offset: 0x0110BC25
		// (set) Token: 0x06045010 RID: 282640 RVA: 0x0110DA2D File Offset: 0x0110BC2D
		[RequiredMember]
		public double ConeHeight { get; set; }

		// Token: 0x06045011 RID: 282641 RVA: 0x0110DA36 File Offset: 0x0110BC36
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldConeSnapshot()
		{
		}
	}
}
