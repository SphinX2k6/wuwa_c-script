using System;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002D80 RID: 11648
public class BulletActionAttachParentEffect : BulletActionBase
{
	// Token: 0x060187BA RID: 100282 RVA: 0x0063B2A0 File Offset: 0x006394A0
	public BulletActionAttachParentEffect(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187BB RID: 100283 RVA: 0x0063B2AC File Offset: 0x006394AC
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
