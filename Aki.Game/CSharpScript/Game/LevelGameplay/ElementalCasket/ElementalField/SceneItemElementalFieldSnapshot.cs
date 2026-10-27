using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E99 RID: 28313
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SceneItemElementalFieldSnapshot<[Nullable(2)] T> : ISceneItemElementalFieldSnapshot<T>
	{
		// Token: 0x17009A60 RID: 39520
		// (get) Token: 0x06044FF9 RID: 282617 RVA: 0x0110D9AF File Offset: 0x0110BBAF
		// (set) Token: 0x06044FFA RID: 282618 RVA: 0x0110D9B7 File Offset: 0x0110BBB7
		[RequiredMember]
		public T ShapeType { get; set; }

		// Token: 0x17009A61 RID: 39521
		// (get) Token: 0x06044FFB RID: 282619 RVA: 0x0110D9C0 File Offset: 0x0110BBC0
		// (set) Token: 0x06044FFC RID: 282620 RVA: 0x0110D9C8 File Offset: 0x0110BBC8
		[RequiredMember]
		public bool Enabled { get; set; }

		// Token: 0x17009A62 RID: 39522
		// (get) Token: 0x06044FFD RID: 282621 RVA: 0x0110D9D1 File Offset: 0x0110BBD1
		// (set) Token: 0x06044FFE RID: 282622 RVA: 0x0110D9D9 File Offset: 0x0110BBD9
		[RequiredMember]
		public FVectorDouble Center { get; set; }

		// Token: 0x06044FFF RID: 282623 RVA: 0x0110D9E2 File Offset: 0x0110BBE2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemElementalFieldSnapshot()
		{
		}
	}
}
