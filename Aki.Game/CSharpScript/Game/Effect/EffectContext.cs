using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063E4 RID: 25572
	[NullableContext(2)]
	[Nullable(0)]
	public class EffectContext
	{
		// Token: 0x0603DFA0 RID: 253856 RVA: 0x011FCAA2 File Offset: 0x011FACA2
		public EffectContext(int? entityId, UObject sourceObject = null, bool disablePostProcess = false)
		{
			this.EntityId = entityId;
			this.SourceObject = sourceObject;
			this.DisablePostProcess = disablePostProcess;
		}

		// Token: 0x0603DFA1 RID: 253857 RVA: 0x011FCAC0 File Offset: 0x011FACC0
		public EffectContext()
		{
			this.EntityId = null;
			this.SourceObject = null;
			this.DisablePostProcess = false;
		}

		// Token: 0x170075D4 RID: 30164
		// (get) Token: 0x0603DFA2 RID: 253858 RVA: 0x011FCAF0 File Offset: 0x011FACF0
		// (set) Token: 0x0603DFA3 RID: 253859 RVA: 0x011FCAF8 File Offset: 0x011FACF8
		public int? EntityId { get; set; }

		// Token: 0x170075D5 RID: 30165
		// (get) Token: 0x0603DFA4 RID: 253860 RVA: 0x011FCB01 File Offset: 0x011FAD01
		// (set) Token: 0x0603DFA5 RID: 253861 RVA: 0x011FCB09 File Offset: 0x011FAD09
		public UObject SourceObject { get; set; }

		// Token: 0x170075D6 RID: 30166
		// (get) Token: 0x0603DFA6 RID: 253862 RVA: 0x011FCB12 File Offset: 0x011FAD12
		// (set) Token: 0x0603DFA7 RID: 253863 RVA: 0x011FCB1A File Offset: 0x011FAD1A
		public bool DisablePostProcess { get; set; }

		// Token: 0x170075D7 RID: 30167
		// (get) Token: 0x0603DFA8 RID: 253864 RVA: 0x011FCB23 File Offset: 0x011FAD23
		// (set) Token: 0x0603DFA9 RID: 253865 RVA: 0x011FCB2B File Offset: 0x011FAD2B
		public EEffectCreateFromType CreateFromType { get; set; }

		// Token: 0x170075D8 RID: 30168
		// (get) Token: 0x0603DFAA RID: 253866 RVA: 0x011FCB34 File Offset: 0x011FAD34
		// (set) Token: 0x0603DFAB RID: 253867 RVA: 0x011FCB3C File Offset: 0x011FAD3C
		public EEffectPlayFlag PlayFlag { get; set; }

		// Token: 0x170075D9 RID: 30169
		// (get) Token: 0x0603DFAC RID: 253868 RVA: 0x011FCB45 File Offset: 0x011FAD45
		// (set) Token: 0x0603DFAD RID: 253869 RVA: 0x011FCB4D File Offset: 0x011FAD4D
		public bool EndInnerAnimNotifyStatesOnStop { get; set; }

		// Token: 0x170075DA RID: 30170
		// (get) Token: 0x0603DFAE RID: 253870 RVA: 0x011FCB56 File Offset: 0x011FAD56
		// (set) Token: 0x0603DFAF RID: 253871 RVA: 0x011FCB5E File Offset: 0x011FAD5E
		public EHitEffectType HitEffectType { get; set; }

		// Token: 0x170075DB RID: 30171
		// (get) Token: 0x0603DFB0 RID: 253872 RVA: 0x011FCB67 File Offset: 0x011FAD67
		// (set) Token: 0x0603DFB1 RID: 253873 RVA: 0x011FCB6F File Offset: 0x011FAD6F
		public FName? AnsSlotName
		{
			get
			{
				return this.AnsSlotNameInternal;
			}
			set
			{
				if (this.CreateFromType != EEffectCreateFromType.An)
				{
					return;
				}
				this.AnsSlotNameInternal = value;
			}
		}

		// Token: 0x0603DFB2 RID: 253874 RVA: 0x011FCB84 File Offset: 0x011FAD84
		[NullableContext(1)]
		public virtual void ToKuroEffectContext(FKuroEffectContext context)
		{
			context.EntityId = this.EntityId.GetValueOrDefault();
			context.SourceObject = this.SourceObject;
			context.DisablePostProcess = this.DisablePostProcess;
			context.CreateFromType = (int)((byte)this.CreateFromType);
			context.PlayFlag = (int)((byte)this.PlayFlag);
			context.EndInnerAnimNotifyStatesOnStop = this.EndInnerAnimNotifyStatesOnStop;
			context.CreateFromBpEffectActor = (this.SourceObject is BP_EffectActor_C);
			context.HitEffectType = (int)((byte)this.HitEffectType);
			context.AnsSlotName = (this.AnsSlotName ?? FName.NAME_None);
		}

		// Token: 0x04020E5A RID: 134746
		private FName? AnsSlotNameInternal;
	}
}
