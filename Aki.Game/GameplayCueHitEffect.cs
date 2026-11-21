using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002518 RID: 9496
public class GameplayCueHitEffect : GameplayCueBase
{
	// Token: 0x060177D6 RID: 96214 RVA: 0x006EE878 File Offset: 0x006ECA78
	protected override void OnCreate()
	{
		if (string.IsNullOrEmpty(this.CueConfig.Path))
		{
			return;
		}
		this.HandleId = ResourceSystem.Instance.LoadAsync<BP_ReplaceHitEffect_C>(this.CueConfig.Path, delegate([Nullable(2)] BP_ReplaceHitEffect_C res, string _)
		{
			this.HandleId = 0;
			if (this.ReplaceHitEffect(res))
			{
				this.IsReplaced = true;
			}
		}, 100, "js_undefined");
	}

	// Token: 0x060177D7 RID: 96215 RVA: 0x006EE8C6 File Offset: 0x006ECAC6
	protected override void OnDestroy()
	{
		if (this.HandleId != 0)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = 0;
		}
		if (this.IsReplaced)
		{
			this.IsReplaced = false;
			this.RemoveHitEffectReplaced();
		}
	}

	// Token: 0x060177D8 RID: 96216 RVA: 0x006EE8FC File Offset: 0x006ECAFC
	[NullableContext(2)]
	private bool ReplaceHitEffect(BP_ReplaceHitEffect_C dataAsset)
	{
		if (dataAsset == null)
		{
			return false;
		}
		if (!this.EntityHandle.Valid)
		{
			return false;
		}
		CharacterHitComponent component = this.EntityHandle.Entity.GetComponent<CharacterHitComponent>();
		return component != null && component.ReplaceHitEffect(dataAsset);
	}

	// Token: 0x060177D9 RID: 96217 RVA: 0x006EE93C File Offset: 0x006ECB3C
	private void RemoveHitEffectReplaced()
	{
		if (!this.EntityHandle.Valid)
		{
			return;
		}
		CharacterHitComponent component = this.EntityHandle.Entity.GetComponent<CharacterHitComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveHitEffectReplaced();
	}

	// Token: 0x0400C7D5 RID: 51157
	private int HandleId;

	// Token: 0x0400C7D6 RID: 51158
	private bool IsReplaced;
}
