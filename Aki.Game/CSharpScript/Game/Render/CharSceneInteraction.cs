using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034D2 RID: 13522
	[NullableContext(2)]
	[Nullable(0)]
	public class CharSceneInteraction : CharRenderBase
	{
		// Token: 0x060226AA RID: 140970 RVA: 0x009C0250 File Offset: 0x009BE450
		public override void Start()
		{
			base.Start();
			this.OwnerCharacter = (this.RenderComponent.GetOwner() as TsBaseCharacter);
			this.CharacterInteraction = null;
			this.PossCharacter(this.RenderComponent.InteractionConfig, 1f);
			base.OnInitSuccess();
		}

		// Token: 0x060226AB RID: 140971 RVA: 0x009C029C File Offset: 0x009BE49C
		public override void Update()
		{
			if (this.CharacterInteraction != null)
			{
				this.CharacterInteraction.Update(base.GetDeltaTime());
			}
		}

		// Token: 0x060226AC RID: 140972 RVA: 0x009C02B7 File Offset: 0x009BE4B7
		public override void Destroy()
		{
			this.UnpossCharacter();
			base.Destroy();
		}

		// Token: 0x060226AD RID: 140973 RVA: 0x009C02C5 File Offset: 0x009BE4C5
		public bool GetIsPossed()
		{
			return this.CharacterInteraction != null;
		}

		// Token: 0x060226AE RID: 140974 RVA: 0x009C02D0 File Offset: 0x009BE4D0
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

		// Token: 0x060226AF RID: 140975 RVA: 0x009C02FC File Offset: 0x009BE4FC
		public void UnpossCharacter()
		{
			if (this.CharacterInteraction != null)
			{
				this.CharacterInteraction.Destroy();
				this.CharacterInteraction = null;
			}
		}

		// Token: 0x060226B0 RID: 140976 RVA: 0x009C0318 File Offset: 0x009BE518
		public override int GetComponentId()
		{
			return 5;
		}

		// Token: 0x060226B1 RID: 140977 RVA: 0x009C031B File Offset: 0x009BE51B
		[NullableContext(1)]
		public override string GetStatName()
		{
			return "CharSceneInteraction";
		}

		// Token: 0x060226B2 RID: 140978 RVA: 0x009C0322 File Offset: 0x009BE522
		public bool GetInWater(float depthThreshold)
		{
			return this.CharacterInteraction != null && this.CharacterInteraction.GetInWater() && this.CharacterInteraction.GetWaterDepth() > (double)depthThreshold;
		}

		// Token: 0x060226B3 RID: 140979 RVA: 0x009C034C File Offset: 0x009BE54C
		public double GetWaterHitLocationZ()
		{
			if (this.CharacterInteraction != null)
			{
				return this.CharacterInteraction.GetWaterHitLocationZ();
			}
			return 0.0;
		}

		// Token: 0x060226B4 RID: 140980 RVA: 0x009C036B File Offset: 0x009BE56B
		public bool GetInAudioShr()
		{
			return this.CharacterInteraction != null && this.CharacterInteraction.GetInAudioShr();
		}

		// Token: 0x060226B5 RID: 140981 RVA: 0x009C0382 File Offset: 0x009BE582
		public FName GetAudioShrTag()
		{
			if (this.CharacterInteraction != null)
			{
				return this.CharacterInteraction.GetAudioShrTag();
			}
			return FNameUtil.NONE;
		}

		// Token: 0x04012F07 RID: 77575
		protected TsBaseCharacter OwnerCharacter;

		// Token: 0x04012F08 RID: 77576
		protected SceneCharacterInteraction CharacterInteraction;
	}
}
