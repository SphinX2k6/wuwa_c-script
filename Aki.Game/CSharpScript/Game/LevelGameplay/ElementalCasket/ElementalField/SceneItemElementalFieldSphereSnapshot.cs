using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E9B RID: 28315
	[RequiredMember]
	public class SceneItemElementalFieldSphereSnapshot : SceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldSphereSnapshot, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17009A64 RID: 39524
		// (get) Token: 0x06045002 RID: 282626 RVA: 0x0110D9EA File Offset: 0x0110BBEA
		// (set) Token: 0x06045003 RID: 282627 RVA: 0x0110D9F2 File Offset: 0x0110BBF2
		[RequiredMember]
		public double SphereRadius { get; set; }

		// Token: 0x06045004 RID: 282628 RVA: 0x0110D9FB File Offset: 0x0110BBFB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldSphereSnapshot()
		{
		}
	}
}
