using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005434 RID: 21556
	public class IBeamCastComponentT
	{
		// Token: 0x17009915 RID: 39189
		// (get) Token: 0x06021CD6 RID: 138454 RVA: 0x004A9238 File Offset: 0x004A7438
		// (set) Token: 0x06021CD7 RID: 138455 RVA: 0x004A9240 File Offset: 0x004A7440
		public bool Disabled { get; set; }

		// Token: 0x17009916 RID: 39190
		// (get) Token: 0x06021CD8 RID: 138456 RVA: 0x004A9249 File Offset: 0x004A7449
		// (set) Token: 0x06021CD9 RID: 138457 RVA: 0x004A9251 File Offset: 0x004A7451
		public string EffectPath { get; set; }

		// Token: 0x17009917 RID: 39191
		// (get) Token: 0x06021CDA RID: 138458 RVA: 0x004A925A File Offset: 0x004A745A
		// (set) Token: 0x06021CDB RID: 138459 RVA: 0x004A9262 File Offset: 0x004A7462
		public bool DelayDestroyEffect { get; set; }

		// Token: 0x17009918 RID: 39192
		// (get) Token: 0x06021CDC RID: 138460 RVA: 0x004A926B File Offset: 0x004A746B
		// (set) Token: 0x06021CDD RID: 138461 RVA: 0x004A9273 File Offset: 0x004A7473
		public string StartEffectPath { get; set; }

		// Token: 0x17009919 RID: 39193
		// (get) Token: 0x06021CDE RID: 138462 RVA: 0x004A927C File Offset: 0x004A747C
		// (set) Token: 0x06021CDF RID: 138463 RVA: 0x004A9284 File Offset: 0x004A7484
		public string HitEffectPath { get; set; }

		// Token: 0x1700991A RID: 39194
		// (get) Token: 0x06021CE0 RID: 138464 RVA: 0x004A928D File Offset: 0x004A748D
		// (set) Token: 0x06021CE1 RID: 138465 RVA: 0x004A9295 File Offset: 0x004A7495
		public ICylinderTriggerShapeT Range { get; set; }

		// Token: 0x1700991B RID: 39195
		// (get) Token: 0x06021CE2 RID: 138466 RVA: 0x004A929E File Offset: 0x004A749E
		// (set) Token: 0x06021CE3 RID: 138467 RVA: 0x004A92A6 File Offset: 0x004A74A6
		public IBeamReflectionConfigT Reflection { get; set; }

		// Token: 0x1700991C RID: 39196
		// (get) Token: 0x06021CE4 RID: 138468 RVA: 0x004A92AF File Offset: 0x004A74AF
		// (set) Token: 0x06021CE5 RID: 138469 RVA: 0x004A92B7 File Offset: 0x004A74B7
		public string TargetState { get; set; }

		// Token: 0x1700991D RID: 39197
		// (get) Token: 0x06021CE6 RID: 138470 RVA: 0x004A92C0 File Offset: 0x004A74C0
		// (set) Token: 0x06021CE7 RID: 138471 RVA: 0x004A92C8 File Offset: 0x004A74C8
		public bool IgnoreMonsterCollision { get; set; }

		// Token: 0x1700991E RID: 39198
		// (get) Token: 0x06021CE8 RID: 138472 RVA: 0x004A92D1 File Offset: 0x004A74D1
		// (set) Token: 0x06021CE9 RID: 138473 RVA: 0x004A92D9 File Offset: 0x004A74D9
		public IBeamLayoutConfigWallT BeamLayout { get; set; }

		// Token: 0x1700991F RID: 39199
		// (get) Token: 0x06021CEA RID: 138474 RVA: 0x004A92E2 File Offset: 0x004A74E2
		// (set) Token: 0x06021CEB RID: 138475 RVA: 0x004A92EA File Offset: 0x004A74EA
		public List<IActionInfoT> TriggerActions { get; set; }

		// Token: 0x17009920 RID: 39200
		// (get) Token: 0x06021CEC RID: 138476 RVA: 0x004A92F3 File Offset: 0x004A74F3
		// (set) Token: 0x06021CED RID: 138477 RVA: 0x004A92FB File Offset: 0x004A74FB
		public bool DisableDynamicRange { get; set; }

		// Token: 0x17009921 RID: 39201
		// (get) Token: 0x06021CEE RID: 138478 RVA: 0x004A9304 File Offset: 0x004A7504
		// (set) Token: 0x06021CEF RID: 138479 RVA: 0x004A930C File Offset: 0x004A750C
		public byte NullMask { get; set; }

		// Token: 0x06021CF0 RID: 138480 RVA: 0x004A9318 File Offset: 0x004A7518
		public IBeamCastComponentT()
		{
			this.Disabled = false;
			this.EffectPath = null;
			this.DelayDestroyEffect = false;
			this.StartEffectPath = null;
			this.HitEffectPath = null;
			this.Range = null;
			this.Reflection = null;
			this.TargetState = null;
			this.IgnoreMonsterCollision = false;
			this.BeamLayout = null;
			this.TriggerActions = null;
			this.DisableDynamicRange = false;
			this.NullMask = 0;
		}
	}
}
