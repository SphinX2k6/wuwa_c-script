using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006019 RID: 24601
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SceneItemElementalFieldSnapshot<[Nullable(2)] T> : ISceneItemElementalFieldSnapshot<T>
	{
		// Token: 0x17006F97 RID: 28567
		// (get) Token: 0x0603B19A RID: 242074 RVA: 0x010B7A8B File Offset: 0x010B5C8B
		// (set) Token: 0x0603B19B RID: 242075 RVA: 0x010B7A93 File Offset: 0x010B5C93
		[RequiredMember]
		public T ShapeType { get; set; }

		// Token: 0x17006F98 RID: 28568
		// (get) Token: 0x0603B19C RID: 242076 RVA: 0x010B7A9C File Offset: 0x010B5C9C
		// (set) Token: 0x0603B19D RID: 242077 RVA: 0x010B7AA4 File Offset: 0x010B5CA4
		[RequiredMember]
		public bool Enabled { get; set; }

		// Token: 0x17006F99 RID: 28569
		// (get) Token: 0x0603B19E RID: 242078 RVA: 0x010B7AAD File Offset: 0x010B5CAD
		// (set) Token: 0x0603B19F RID: 242079 RVA: 0x010B7AB5 File Offset: 0x010B5CB5
		[RequiredMember]
		public FVectorDouble Center { get; set; }

		// Token: 0x0603B1A0 RID: 242080 RVA: 0x010B7ABE File Offset: 0x010B5CBE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldSnapshot()
		{
		}
	}
}
