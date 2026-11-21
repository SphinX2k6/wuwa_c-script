using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.EffectSave;
using UnrealEngine;

// Token: 0x0200232A RID: 9002
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicEffectSave : BulletLogicController<LogicDataEffectSave, object>
{
	// Token: 0x060162C0 RID: 90816 RVA: 0x00672999 File Offset: 0x00670B99
	public BulletLogicEffectSave(LogicDataEffectSave logicController, Entity bullet) : base(logicController, bullet)
	{
	}

	// Token: 0x060162C1 RID: 90817 RVA: 0x006729A4 File Offset: 0x00670BA4
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		if (ObjectUtils.SoftObjectReferenceValid<UEffectModelBase>(this.LogicController.Effect))
		{
			EffectSaveController.Instance.MarkEffectSave(this.LogicController.Effect.ToAssetPathName(), this.Bullet.GetBulletInfo().GetActorLocation(), this.Bullet.GetBulletInfo().GetActorRotation());
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Bullet;
		ELogAuthor author = ELogAuthor.HCW;
		string message = "配置路径错了";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("子弹ID", this.Bullet.GetBulletInfo().BulletRowName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}
}
