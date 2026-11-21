using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005794 RID: 22420
	public class IFanComponentT
	{
		// Token: 0x1700A217 RID: 41495
		// (get) Token: 0x060242EB RID: 148203 RVA: 0x004F9BB3 File Offset: 0x004F7DB3
		// (set) Token: 0x060242EC RID: 148204 RVA: 0x004F9BBB File Offset: 0x004F7DBB
		public bool Disabled { get; set; }

		// Token: 0x1700A218 RID: 41496
		// (get) Token: 0x060242ED RID: 148205 RVA: 0x004F9BC4 File Offset: 0x004F7DC4
		// (set) Token: 0x060242EE RID: 148206 RVA: 0x004F9BCC File Offset: 0x004F7DCC
		public EFanGearType GearType { get; set; }

		// Token: 0x1700A219 RID: 41497
		// (get) Token: 0x060242EF RID: 148207 RVA: 0x004F9BD5 File Offset: 0x004F7DD5
		// (set) Token: 0x060242F0 RID: 148208 RVA: 0x004F9BDD File Offset: 0x004F7DDD
		public TFanInteractOptionUnion InteractType { get; set; }

		// Token: 0x1700A21A RID: 41498
		// (get) Token: 0x060242F1 RID: 148209 RVA: 0x004F9BE6 File Offset: 0x004F7DE6
		// (set) Token: 0x060242F2 RID: 148210 RVA: 0x004F9BEE File Offset: 0x004F7DEE
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A21B RID: 41499
		// (get) Token: 0x060242F3 RID: 148211 RVA: 0x004F9BF7 File Offset: 0x004F7DF7
		// (set) Token: 0x060242F4 RID: 148212 RVA: 0x004F9BFF File Offset: 0x004F7DFF
		public string RotateActor { get; set; }

		// Token: 0x1700A21C RID: 41500
		// (get) Token: 0x060242F5 RID: 148213 RVA: 0x004F9C08 File Offset: 0x004F7E08
		// (set) Token: 0x060242F6 RID: 148214 RVA: 0x004F9C10 File Offset: 0x004F7E10
		public string OffsetActor { get; set; }

		// Token: 0x1700A21D RID: 41501
		// (get) Token: 0x060242F7 RID: 148215 RVA: 0x004F9C19 File Offset: 0x004F7E19
		// (set) Token: 0x060242F8 RID: 148216 RVA: 0x004F9C21 File Offset: 0x004F7E21
		public int CirclePerRound { get; set; }

		// Token: 0x1700A21E RID: 41502
		// (get) Token: 0x060242F9 RID: 148217 RVA: 0x004F9C2A File Offset: 0x004F7E2A
		// (set) Token: 0x060242FA RID: 148218 RVA: 0x004F9C32 File Offset: 0x004F7E32
		public int InitCircle { get; set; }

		// Token: 0x1700A21F RID: 41503
		// (get) Token: 0x060242FB RID: 148219 RVA: 0x004F9C3B File Offset: 0x004F7E3B
		// (set) Token: 0x060242FC RID: 148220 RVA: 0x004F9C43 File Offset: 0x004F7E43
		public int TargetEntityId { get; set; }

		// Token: 0x1700A220 RID: 41504
		// (get) Token: 0x060242FD RID: 148221 RVA: 0x004F9C4C File Offset: 0x004F7E4C
		// (set) Token: 0x060242FE RID: 148222 RVA: 0x004F9C54 File Offset: 0x004F7E54
		public IFanEffectConfigT EffectConfig { get; set; }

		// Token: 0x1700A221 RID: 41505
		// (get) Token: 0x060242FF RID: 148223 RVA: 0x004F9C5D File Offset: 0x004F7E5D
		// (set) Token: 0x06024300 RID: 148224 RVA: 0x004F9C65 File Offset: 0x004F7E65
		public List<IFanStateEffectT> EffectByState { get; set; }

		// Token: 0x1700A222 RID: 41506
		// (get) Token: 0x06024301 RID: 148225 RVA: 0x004F9C6E File Offset: 0x004F7E6E
		// (set) Token: 0x06024302 RID: 148226 RVA: 0x004F9C76 File Offset: 0x004F7E76
		public byte NullMask { get; set; }

		// Token: 0x06024303 RID: 148227 RVA: 0x004F9C80 File Offset: 0x004F7E80
		public IFanComponentT()
		{
			this.Disabled = false;
			this.GearType = EFanGearType.ReboundPlateGear;
			this.InteractType = null;
			this.Condition = null;
			this.RotateActor = null;
			this.OffsetActor = null;
			this.CirclePerRound = 0;
			this.InitCircle = 0;
			this.TargetEntityId = 0;
			this.EffectConfig = null;
			this.EffectByState = null;
			this.NullMask = 0;
		}
	}
}
