using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561D RID: 22045
	public class IDragActorPlayConfigT
	{
		// Token: 0x17009E2E RID: 40494
		// (get) Token: 0x060232C9 RID: 144073 RVA: 0x004D7762 File Offset: 0x004D5962
		// (set) Token: 0x060232CA RID: 144074 RVA: 0x004D776A File Offset: 0x004D596A
		public IActorRefT DraggableActor { get; set; }

		// Token: 0x17009E2F RID: 40495
		// (get) Token: 0x060232CB RID: 144075 RVA: 0x004D7773 File Offset: 0x004D5973
		// (set) Token: 0x060232CC RID: 144076 RVA: 0x004D777B File Offset: 0x004D597B
		public string DragAkEvent { get; set; }

		// Token: 0x17009E30 RID: 40496
		// (get) Token: 0x060232CD RID: 144077 RVA: 0x004D7784 File Offset: 0x004D5984
		// (set) Token: 0x060232CE RID: 144078 RVA: 0x004D778C File Offset: 0x004D598C
		public int EffectSplineEntityId { get; set; }

		// Token: 0x17009E31 RID: 40497
		// (get) Token: 0x060232CF RID: 144079 RVA: 0x004D7795 File Offset: 0x004D5995
		// (set) Token: 0x060232D0 RID: 144080 RVA: 0x004D779D File Offset: 0x004D599D
		public int SplineEntityId { get; set; }

		// Token: 0x17009E32 RID: 40498
		// (get) Token: 0x060232D1 RID: 144081 RVA: 0x004D77A6 File Offset: 0x004D59A6
		// (set) Token: 0x060232D2 RID: 144082 RVA: 0x004D77AE File Offset: 0x004D59AE
		public string Sequence { get; set; }

		// Token: 0x17009E33 RID: 40499
		// (get) Token: 0x060232D3 RID: 144083 RVA: 0x004D77B7 File Offset: 0x004D59B7
		// (set) Token: 0x060232D4 RID: 144084 RVA: 0x004D77BF File Offset: 0x004D59BF
		public float MaxPlaySpeed { get; set; }

		// Token: 0x17009E34 RID: 40500
		// (get) Token: 0x060232D5 RID: 144085 RVA: 0x004D77C8 File Offset: 0x004D59C8
		// (set) Token: 0x060232D6 RID: 144086 RVA: 0x004D77D0 File Offset: 0x004D59D0
		public float Stiffness { get; set; }

		// Token: 0x17009E35 RID: 40501
		// (get) Token: 0x060232D7 RID: 144087 RVA: 0x004D77D9 File Offset: 0x004D59D9
		// (set) Token: 0x060232D8 RID: 144088 RVA: 0x004D77E1 File Offset: 0x004D59E1
		public float Damping { get; set; }

		// Token: 0x17009E36 RID: 40502
		// (get) Token: 0x060232D9 RID: 144089 RVA: 0x004D77EA File Offset: 0x004D59EA
		// (set) Token: 0x060232DA RID: 144090 RVA: 0x004D77F2 File Offset: 0x004D59F2
		public List<IDragActorPlayKeyPointConfigT> KeyPoints { get; set; }

		// Token: 0x17009E37 RID: 40503
		// (get) Token: 0x060232DB RID: 144091 RVA: 0x004D77FB File Offset: 0x004D59FB
		// (set) Token: 0x060232DC RID: 144092 RVA: 0x004D7803 File Offset: 0x004D5A03
		public string DraggableActorEffectDa { get; set; }

		// Token: 0x17009E38 RID: 40504
		// (get) Token: 0x060232DD RID: 144093 RVA: 0x004D780C File Offset: 0x004D5A0C
		// (set) Token: 0x060232DE RID: 144094 RVA: 0x004D7814 File Offset: 0x004D5A14
		public bool IgnoreRotation { get; set; }

		// Token: 0x17009E39 RID: 40505
		// (get) Token: 0x060232DF RID: 144095 RVA: 0x004D781D File Offset: 0x004D5A1D
		// (set) Token: 0x060232E0 RID: 144096 RVA: 0x004D7825 File Offset: 0x004D5A25
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009E3A RID: 40506
		// (get) Token: 0x060232E1 RID: 144097 RVA: 0x004D782E File Offset: 0x004D5A2E
		// (set) Token: 0x060232E2 RID: 144098 RVA: 0x004D7836 File Offset: 0x004D5A36
		public EDragHintType DragHintType { get; set; }

		// Token: 0x17009E3B RID: 40507
		// (get) Token: 0x060232E3 RID: 144099 RVA: 0x004D783F File Offset: 0x004D5A3F
		// (set) Token: 0x060232E4 RID: 144100 RVA: 0x004D7847 File Offset: 0x004D5A47
		public byte NullMask { get; set; }

		// Token: 0x060232E5 RID: 144101 RVA: 0x004D7850 File Offset: 0x004D5A50
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
