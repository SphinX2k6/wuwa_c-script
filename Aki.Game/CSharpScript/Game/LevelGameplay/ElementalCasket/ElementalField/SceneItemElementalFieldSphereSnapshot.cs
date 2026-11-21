using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x0200601B RID: 24603
	[RequiredMember]
	public class SceneItemElementalFieldSphereSnapshot : SceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldSphereSnapshot, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17006F9B RID: 28571
		// (get) Token: 0x0603B1A3 RID: 242083 RVA: 0x010B7AC6 File Offset: 0x010B5CC6
		// (set) Token: 0x0603B1A4 RID: 242084 RVA: 0x010B7ACE File Offset: 0x010B5CCE
		[RequiredMember]
		public double SphereRadius { get; set; }

		// Token: 0x0603B1A5 RID: 242085 RVA: 0x010B7AD7 File Offset: 0x010B5CD7
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldSphereSnapshot()
		{
		}
	}
}
