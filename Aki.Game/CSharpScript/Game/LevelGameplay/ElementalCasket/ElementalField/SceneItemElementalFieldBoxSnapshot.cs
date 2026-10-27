using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E9F RID: 28319
	[RequiredMember]
	public class SceneItemElementalFieldBoxSnapshot : SceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldBoxSnapshot, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17009A6D RID: 39533
		// (get) Token: 0x06045016 RID: 282646 RVA: 0x0110DA3E File Offset: 0x0110BC3E
		// (set) Token: 0x06045017 RID: 282647 RVA: 0x0110DA46 File Offset: 0x0110BC46
		[RequiredMember]
		public FVectorDouble BoxSize { get; set; }

		// Token: 0x17009A6E RID: 39534
		// (get) Token: 0x06045018 RID: 282648 RVA: 0x0110DA4F File Offset: 0x0110BC4F
		// (set) Token: 0x06045019 RID: 282649 RVA: 0x0110DA57 File Offset: 0x0110BC57
		public FRotator? BoxRotation { get; set; }

		// Token: 0x0604501A RID: 282650 RVA: 0x0110DA60 File Offset: 0x0110BC60
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldBoxSnapshot()
		{
		}
	}
}
