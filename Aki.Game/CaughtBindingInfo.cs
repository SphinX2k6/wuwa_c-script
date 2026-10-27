using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003051 RID: 12369
[NullableContext(2)]
[Nullable(0)]
public class CaughtBindingInfo
{
	// Token: 0x1700242F RID: 9263
	// (get) Token: 0x0601A496 RID: 107670 RVA: 0x006F3DF1 File Offset: 0x006F1FF1
	public BulletEntity BulletEntity
	{
		get
		{
			if (this.BulletEntityId != null)
			{
				return EntitySystem.Instance.Get(this.BulletEntityId.Value) as BulletEntity;
			}
			return null;
		}
	}

	// Token: 0x0601A497 RID: 107671 RVA: 0x006F3E1C File Offset: 0x006F201C
	[NullableContext(1)]
	public CaughtBindingInfo(string id, SCaughtInfo info, CharacterActorComponent entityActorComp, CharacterCaughtNewComponent caughtComp, int skillId)
	{
		this.CaughtId = id;
		this.CaughtInfo = info;
		this.BindingInfo = this.CaughtInfo.BindingInfo;
		SCaughtBindingInfo bindingInfo = this.BindingInfo;
		if (!string.IsNullOrEmpty((bindingInfo != null) ? bindingInfo.BulletId : null))
		{
			this.BulletEntityId = new int?(BulletUtil.CreateBulletFromAN(entityActorComp.Actor, this.BindingInfo.BulletId, new FTransformDouble?(entityActorComp.ActorTransform), skillId, false, caughtComp.CaughtBindingAnsMessageId, null, null, null));
		}
		BulletEntity bulletEntity = this.BulletEntity;
		this.BulletActorComponent = ((bulletEntity != null) ? bulletEntity.GetComponent<BulletActorComponent>() : null);
	}

	// Token: 0x0601A498 RID: 107672 RVA: 0x006F3EDB File Offset: 0x006F20DB
	public void Clear()
	{
		this.CaughtId = "";
		this.BindingInfo = null;
		this.CaughtInfo = null;
		this.BulletEntityId = null;
		this.BulletActorComponent = null;
	}

	// Token: 0x0400C867 RID: 51303
	[Nullable(1)]
	public string CaughtId;

	// Token: 0x0400C868 RID: 51304
	private SCaughtInfo CaughtInfo;

	// Token: 0x0400C869 RID: 51305
	public SCaughtBindingInfo BindingInfo;

	// Token: 0x0400C86A RID: 51306
	public int? BulletEntityId;

	// Token: 0x0400C86B RID: 51307
	public BulletActorComponent BulletActorComponent;

	// Token: 0x0400C86C RID: 51308
	[Nullable(1)]
	public List<Entity> Targets = new List<Entity>();
}
