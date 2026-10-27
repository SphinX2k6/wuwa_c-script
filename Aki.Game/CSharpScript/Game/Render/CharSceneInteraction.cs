using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045AA RID: 17834
	[NullableContext(2)]
	[Nullable(0)]
	public class CharSceneInteraction : CharRenderBase
	{
		// Token: 0x0602DFC0 RID: 188352 RVA: 0x00A94030 File Offset: 0x00A92230
		public override void Start()
		{
			base.Start();
			this.OwnerCharacter = (this.RenderComponent.GetOwner() as TsBaseCharacter);
			this.CharacterInteraction = null;
			this.PossCharacter(this.RenderComponent.InteractionConfig, 1f);
			base.OnInitSuccess();
		}

		// Token: 0x0602DFC1 RID: 188353 RVA: 0x00A9407C File Offset: 0x00A9227C
		public override void Update()
		{
			if (this.CharacterInteraction != null)
			{
				this.CharacterInteraction.Update(base.GetDeltaTime());
			}
		}

		// Token: 0x0602DFC2 RID: 188354 RVA: 0x00A94097 File Offset: 0x00A92297
		public override void Destroy()
		{
			this.UnpossCharacter();
			base.Destroy();
		}

		// Token: 0x0602DFC3 RID: 188355 RVA: 0x00A940A5 File Offset: 0x00A922A5
		public bool GetIsPossed()
		{
			return this.CharacterInteraction != null;
		}

		// Token: 0x0602DFC4 RID: 188356 RVA: 0x00A940B0 File Offset: 0x00A922B0
		public void PossCharacter(PDA_InteractionPlayerConfig_C config, float updateInternalScale = 1f)
		{
			if (config == null)
			{
				return;
			}
			if (this.OwnerCharacter != null)
			{
				this.CharacterInteraction = new SceneCharacterInteraction();
				this.CharacterInteraction.Start(this.OwnerCharacter, config, updateInternalScale);
			}
		}

		// Token: 0x0602DFC5 RID: 188357 RVA: 0x00A940DC File Offset: 0x00A922DC
		public void UnpossCharacter()
		{
			if (this.CharacterInteraction != null)
			{
				this.CharacterInteraction.Destroy();
				this.CharacterInteraction = null;
			}
		}

		// Token: 0x0602DFC6 RID: 188358 RVA: 0x00A940F8 File Offset: 0x00A922F8
		public override int GetComponentId()
		{
			return 5;
		}

		// Token: 0x0602DFC7 RID: 188359 RVA: 0x00A940FB File Offset: 0x00A922FB
		[NullableContext(1)]
		public override string GetStatName()
		{
			return "CharSceneInteraction";
		}

		// Token: 0x0602DFC8 RID: 188360 RVA: 0x00A94102 File Offset: 0x00A92302
		public bool GetInWater(float depthThreshold)
		{
			return this.CharacterInteraction != null && this.CharacterInteraction.GetInWater() && this.CharacterInteraction.GetWaterDepth() > (double)depthThreshold;
		}

		// Token: 0x0602DFC9 RID: 188361 RVA: 0x00A9412C File Offset: 0x00A9232C
		public double GetWaterHitLocationZ()
		{
			if (this.CharacterInteraction != null)
			{
				return this.CharacterInteraction.GetWaterHitLocationZ();
			}
			return 0.0;
		}

		// Token: 0x0602DFCA RID: 188362 RVA: 0x00A9414B File Offset: 0x00A9234B
		public bool GetInAudioShr()
		{
			return this.CharacterInteraction != null && this.CharacterInteraction.GetInAudioShr();
		}

		// Token: 0x0602DFCB RID: 188363 RVA: 0x00A94162 File Offset: 0x00A92362
		public FName GetAudioShrTag()
		{
			if (this.CharacterInteraction != null)
			{
				return this.CharacterInteraction.GetAudioShrTag();
			}
			return FNameUtil.NONE;
		}

		// Token: 0x040188CC RID: 100556
		protected TsBaseCharacter OwnerCharacter;

		// Token: 0x040188CD RID: 100557
		protected SceneCharacterInteraction CharacterInteraction;
	}
}
