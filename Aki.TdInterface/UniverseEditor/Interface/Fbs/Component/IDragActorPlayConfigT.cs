using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B8 RID: 20664
	public class IDragActorPlayConfigT
	{
		// Token: 0x17009641 RID: 38465
		// (get) Token: 0x06021375 RID: 136053 RVA: 0x0049D7D6 File Offset: 0x0049B9D6
		// (set) Token: 0x06021376 RID: 136054 RVA: 0x0049D7DE File Offset: 0x0049B9DE
		public IActorRefT DraggableActor { get; set; }

		// Token: 0x17009642 RID: 38466
		// (get) Token: 0x06021377 RID: 136055 RVA: 0x0049D7E7 File Offset: 0x0049B9E7
		// (set) Token: 0x06021378 RID: 136056 RVA: 0x0049D7EF File Offset: 0x0049B9EF
		public string DragAkEvent { get; set; }

		// Token: 0x17009643 RID: 38467
		// (get) Token: 0x06021379 RID: 136057 RVA: 0x0049D7F8 File Offset: 0x0049B9F8
		// (set) Token: 0x0602137A RID: 136058 RVA: 0x0049D800 File Offset: 0x0049BA00
		public int EffectSplineEntityId { get; set; }

		// Token: 0x17009644 RID: 38468
		// (get) Token: 0x0602137B RID: 136059 RVA: 0x0049D809 File Offset: 0x0049BA09
		// (set) Token: 0x0602137C RID: 136060 RVA: 0x0049D811 File Offset: 0x0049BA11
		public int SplineEntityId { get; set; }

		// Token: 0x17009645 RID: 38469
		// (get) Token: 0x0602137D RID: 136061 RVA: 0x0049D81A File Offset: 0x0049BA1A
		// (set) Token: 0x0602137E RID: 136062 RVA: 0x0049D822 File Offset: 0x0049BA22
		public string Sequence { get; set; }

		// Token: 0x17009646 RID: 38470
		// (get) Token: 0x0602137F RID: 136063 RVA: 0x0049D82B File Offset: 0x0049BA2B
		// (set) Token: 0x06021380 RID: 136064 RVA: 0x0049D833 File Offset: 0x0049BA33
		public float MaxPlaySpeed { get; set; }

		// Token: 0x17009647 RID: 38471
		// (get) Token: 0x06021381 RID: 136065 RVA: 0x0049D83C File Offset: 0x0049BA3C
		// (set) Token: 0x06021382 RID: 136066 RVA: 0x0049D844 File Offset: 0x0049BA44
		public float Stiffness { get; set; }

		// Token: 0x17009648 RID: 38472
		// (get) Token: 0x06021383 RID: 136067 RVA: 0x0049D84D File Offset: 0x0049BA4D
		// (set) Token: 0x06021384 RID: 136068 RVA: 0x0049D855 File Offset: 0x0049BA55
		public float Damping { get; set; }

		// Token: 0x17009649 RID: 38473
		// (get) Token: 0x06021385 RID: 136069 RVA: 0x0049D85E File Offset: 0x0049BA5E
		// (set) Token: 0x06021386 RID: 136070 RVA: 0x0049D866 File Offset: 0x0049BA66
		public List<IDragActorPlayKeyPointConfigT> KeyPoints { get; set; }

		// Token: 0x1700964A RID: 38474
		// (get) Token: 0x06021387 RID: 136071 RVA: 0x0049D86F File Offset: 0x0049BA6F
		// (set) Token: 0x06021388 RID: 136072 RVA: 0x0049D877 File Offset: 0x0049BA77
		public string DraggableActorEffectDa { get; set; }

		// Token: 0x1700964B RID: 38475
		// (get) Token: 0x06021389 RID: 136073 RVA: 0x0049D880 File Offset: 0x0049BA80
		// (set) Token: 0x0602138A RID: 136074 RVA: 0x0049D888 File Offset: 0x0049BA88
		public bool IgnoreRotation { get; set; }

		// Token: 0x1700964C RID: 38476
		// (get) Token: 0x0602138B RID: 136075 RVA: 0x0049D891 File Offset: 0x0049BA91
		// (set) Token: 0x0602138C RID: 136076 RVA: 0x0049D899 File Offset: 0x0049BA99
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700964D RID: 38477
		// (get) Token: 0x0602138D RID: 136077 RVA: 0x0049D8A2 File Offset: 0x0049BAA2
		// (set) Token: 0x0602138E RID: 136078 RVA: 0x0049D8AA File Offset: 0x0049BAAA
		public EDragHintType DragHintType { get; set; }

		// Token: 0x1700964E RID: 38478
		// (get) Token: 0x0602138F RID: 136079 RVA: 0x0049D8B3 File Offset: 0x0049BAB3
		// (set) Token: 0x06021390 RID: 136080 RVA: 0x0049D8BB File Offset: 0x0049BABB
		public byte NullMask { get; set; }

		// Token: 0x06021391 RID: 136081 RVA: 0x0049D8C4 File Offset: 0x0049BAC4
		public IDragActorPlayConfigT()
		{
			this.DraggableActor = null;
			this.DragAkEvent = null;
			this.EffectSplineEntityId = 0;
			this.SplineEntityId = 0;
			this.Sequence = null;
			this.MaxPlaySpeed = 0f;
			this.Stiffness = 0f;
			this.Damping = 0f;
			this.KeyPoints = null;
			this.DraggableActorEffectDa = null;
			this.IgnoreRotation = false;
			this.Condition = null;
			this.DragHintType = EDragHintType.Horizontal;
			this.NullMask = 0;
		}
	}
}
