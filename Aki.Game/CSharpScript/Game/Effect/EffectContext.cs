using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007265 RID: 29285
	[NullableContext(2)]
	[Nullable(0)]
	public class EffectContext
	{
		// Token: 0x06047BE8 RID: 293864 RVA: 0x0125C19E File Offset: 0x0125A39E
		public EffectContext(int? entityId, UObject sourceObject = null, bool disablePostProcess = false)
		{
			this.EntityId = entityId;
			this.SourceObject = sourceObject;
			this.DisablePostProcess = disablePostProcess;
		}

		// Token: 0x06047BE9 RID: 293865 RVA: 0x0125C1BC File Offset: 0x0125A3BC
		public EffectContext()
		{
			this.EntityId = null;
			this.SourceObject = null;
			this.DisablePostProcess = false;
		}

		// Token: 0x17009E7C RID: 40572
		// (get) Token: 0x06047BEA RID: 293866 RVA: 0x0125C1EC File Offset: 0x0125A3EC
		// (set) Token: 0x06047BEB RID: 293867 RVA: 0x0125C1F4 File Offset: 0x0125A3F4
		public int? EntityId { get; set; }

		// Token: 0x17009E7D RID: 40573
		// (get) Token: 0x06047BEC RID: 293868 RVA: 0x0125C1FD File Offset: 0x0125A3FD
		// (set) Token: 0x06047BED RID: 293869 RVA: 0x0125C205 File Offset: 0x0125A405
		public UObject SourceObject { get; set; }

		// Token: 0x17009E7E RID: 40574
		// (get) Token: 0x06047BEE RID: 293870 RVA: 0x0125C20E File Offset: 0x0125A40E
		// (set) Token: 0x06047BEF RID: 293871 RVA: 0x0125C216 File Offset: 0x0125A416
		public bool DisablePostProcess { get; set; }

		// Token: 0x17009E7F RID: 40575
		// (get) Token: 0x06047BF0 RID: 293872 RVA: 0x0125C21F File Offset: 0x0125A41F
		// (set) Token: 0x06047BF1 RID: 293873 RVA: 0x0125C227 File Offset: 0x0125A427
		public EEffectCreateFromType CreateFromType { get; set; }

		// Token: 0x17009E80 RID: 40576
		// (get) Token: 0x06047BF2 RID: 293874 RVA: 0x0125C230 File Offset: 0x0125A430
		// (set) Token: 0x06047BF3 RID: 293875 RVA: 0x0125C238 File Offset: 0x0125A438
		public EEffectPlayFlag PlayFlag { get; set; }

		// Token: 0x17009E81 RID: 40577
		// (get) Token: 0x06047BF4 RID: 293876 RVA: 0x0125C241 File Offset: 0x0125A441
		// (set) Token: 0x06047BF5 RID: 293877 RVA: 0x0125C249 File Offset: 0x0125A449
		public EHitEffectType HitEffectType { get; set; }

		// Token: 0x17009E82 RID: 40578
		// (get) Token: 0x06047BF6 RID: 293878 RVA: 0x0125C252 File Offset: 0x0125A452
		// (set) Token: 0x06047BF7 RID: 293879 RVA: 0x0125C25A File Offset: 0x0125A45A
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

		// Token: 0x06047BF8 RID: 293880 RVA: 0x0125C270 File Offset: 0x0125A470
		[NullableContext(1)]
		public virtual void ToKuroEffectContext(FKuroEffectContext context)
		{
			context.EntityId = this.EntityId.GetValueOrDefault();
			context.SourceObject = this.SourceObject;
			context.DisablePostProcess = this.DisablePostProcess;
			context.CreateFromType = (int)((byte)this.CreateFromType);
			context.PlayFlag = (int)((byte)this.PlayFlag);
			context.CreateFromBpEffectActor = (this.SourceObject is BP_EffectActor_C);
			context.HitEffectType = (int)((byte)this.HitEffectType);
			context.AnsSlotName = (this.AnsSlotName ?? FName.NAME_None);
		}

		// Token: 0x04025B9B RID: 154523
		private FName? AnsSlotNameInternal;
	}
}
