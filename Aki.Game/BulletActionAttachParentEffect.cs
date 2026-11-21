using System;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020022DA RID: 8922
public class BulletActionAttachParentEffect : BulletActionBase
{
	// Token: 0x0601605C RID: 90204 RVA: 0x006612B0 File Offset: 0x0065F4B0
	public BulletActionAttachParentEffect(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601605D RID: 90205 RVA: 0x006612BC File Offset: 0x0065F4BC
	protected override void OnTick(float delta)
	{
		BulletInfo bulletInfo = this.BulletInfo;
		if (bulletInfo.NeedDestroy)
		{
			return;
		}
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(bulletInfo.ParentEffect);
		if (sureEffectActor != null)
		{
			BulletUtil.AttachParentEffectSkeleton(bulletInfo, sureEffectActor, bulletInfo.ParentEffect);
			this.IsFinish = true;
		}
	}
}
