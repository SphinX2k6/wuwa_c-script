using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002FC4 RID: 12228
public class GameplayCueHitEffect : GameplayCueBase
{
	// Token: 0x06019EC4 RID: 106180 RVA: 0x006C7FA4 File Offset: 0x006C61A4
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

	// Token: 0x06019EC5 RID: 106181 RVA: 0x006C7FF2 File Offset: 0x006C61F2
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

	// Token: 0x06019EC6 RID: 106182 RVA: 0x006C8028 File Offset: 0x006C6228
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

	// Token: 0x06019EC7 RID: 106183 RVA: 0x006C8068 File Offset: 0x006C6268
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

	// Token: 0x0400C42C RID: 50220
	private int HandleId;

	// Token: 0x0400C42D RID: 50221
	private bool IsReplaced;
}
