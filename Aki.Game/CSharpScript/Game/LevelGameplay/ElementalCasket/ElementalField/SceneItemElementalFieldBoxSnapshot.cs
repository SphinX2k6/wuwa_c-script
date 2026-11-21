using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x0200601F RID: 24607
	[RequiredMember]
	public class SceneItemElementalFieldBoxSnapshot : SceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldBoxSnapshot, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17006FA4 RID: 28580
		// (get) Token: 0x0603B1B7 RID: 242103 RVA: 0x010B7B1A File Offset: 0x010B5D1A
		// (set) Token: 0x0603B1B8 RID: 242104 RVA: 0x010B7B22 File Offset: 0x010B5D22
		[RequiredMember]
		public FVectorDouble BoxSize { get; set; }

		// Token: 0x17006FA5 RID: 28581
		// (get) Token: 0x0603B1B9 RID: 242105 RVA: 0x010B7B2B File Offset: 0x010B5D2B
		// (set) Token: 0x0603B1BA RID: 242106 RVA: 0x010B7B33 File Offset: 0x010B5D33
		public FRotator? BoxRotation { get; set; }

		// Token: 0x0603B1BB RID: 242107 RVA: 0x010B7B3C File Offset: 0x010B5D3C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldBoxSnapshot()
		{
		}
	}
}
