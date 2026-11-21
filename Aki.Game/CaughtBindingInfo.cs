using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020025A7 RID: 9639
[NullableContext(2)]
[Nullable(0)]
public class CaughtBindingInfo
{
	// Token: 0x17002541 RID: 9537
	// (get) Token: 0x06017E28 RID: 97832 RVA: 0x0071B045 File Offset: 0x00719245
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

	// Token: 0x06017E29 RID: 97833 RVA: 0x0071B070 File Offset: 0x00719270
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

	// Token: 0x06017E2A RID: 97834 RVA: 0x0071B12F File Offset: 0x0071932F
	public void Clear()
	{
		this.CaughtId = "";
		this.BindingInfo = null;
		this.CaughtInfo = null;
		this.BulletEntityId = null;
		this.BulletActorComponent = null;
	}

	// Token: 0x0400CC40 RID: 52288
	[Nullable(1)]
	public string CaughtId;

	// Token: 0x0400CC41 RID: 52289
	private SCaughtInfo CaughtInfo;

	// Token: 0x0400CC42 RID: 52290
	public SCaughtBindingInfo BindingInfo;

	// Token: 0x0400CC43 RID: 52291
	public int? BulletEntityId;

	// Token: 0x0400CC44 RID: 52292
	public BulletActorComponent BulletActorComponent;

	// Token: 0x0400CC45 RID: 52293
	[Nullable(1)]
	public List<Entity> Targets = new List<Entity>();
}
