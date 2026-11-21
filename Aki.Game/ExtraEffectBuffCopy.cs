using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002478 RID: 9336
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectBuffCopy : BuffEffect
{
	// Token: 0x06017485 RID: 95365 RVA: 0x006D848F File Offset: 0x006D668F
	public ExtraEffectBuffCopy(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017486 RID: 95366 RVA: 0x006D84B4 File Offset: 0x006D66B4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.BuffIds[i] = long.Parse(array[i]);
		}
		this.BulletId = long.Parse(extraEffectParameters_[1]);
	}

	// Token: 0x06017487 RID: 95367 RVA: 0x006D8510 File Offset: 0x006D6710
	protected void AddEvent()
	{
		Entity ownerEntity = base.OwnerEntity;
		if (ownerEntity == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "buff监听实体不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BuffId", this.BuffId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (!EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal)))
		{
			EventSystem.Instance.AddWithTarget<HitInformation, HitContext>(ownerEntity, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal));
		}
		if (!EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote)))
		{
			EventSystem.Instance.AddWithTarget<HitContext>(ownerEntity, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote));
		}
	}

	// Token: 0x06017488 RID: 95368 RVA: 0x006D85C2 File Offset: 0x006D67C2
	public override void OnCreated()
	{
		this.EntityIds.Clear();
		this.AddEvent();
	}

	// Token: 0x06017489 RID: 95369 RVA: 0x006D85D5 File Offset: 0x006D67D5
	protected void OnHitLocal(HitInformation hitData, HitContext hitContext)
	{
		this.RecordHit(hitContext);
	}

	// Token: 0x0601748A RID: 95370 RVA: 0x006D85DE File Offset: 0x006D67DE
	protected void OnHitRemote(HitContext hitContext)
	{
		this.RecordHit(hitContext);
	}

	// Token: 0x0601748B RID: 95371 RVA: 0x006D85E7 File Offset: 0x006D67E7
	protected void RecordHit(HitContext hitContext)
	{
		if (hitContext.BulletId == this.BulletId)
		{
			this.EntityIds.Add(hitContext.Target.Id);
		}
	}

	// Token: 0x0601748C RID: 95372 RVA: 0x006D8610 File Offset: 0x006D6810
	protected void CopyBuff(long buffId, BaseBuffComponent[] buffCompList, int[] buffStack)
	{
		int num = 0;
		for (int i = 0; i < buffCompList.Length; i++)
		{
			int buffTotalStackById = buffCompList[i].GetBuffTotalStackById(buffId, false);
			buffStack[i] = buffTotalStackById;
			num = Math.Max(buffTotalStackById, num);
		}
		if (num == 0)
		{
			return;
		}
		for (int j = 0; j < buffCompList.Length; j++)
		{
			int num2 = num - buffStack[j];
			if (num2 > 0)
			{
				buffCompList[j].AddIterativeBuff(buffId, base.PendingBuff, new int?(num2), true, "buff的额外效果:复制buff", null, null);
			}
		}
	}

	// Token: 0x0601748D RID: 95373 RVA: 0x006D868C File Offset: 0x006D688C
	protected void RemoveEvent()
	{
		Entity ownerEntity = base.OwnerEntity;
		if (ownerEntity != null)
		{
			if (EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal)))
			{
				EventSystem.Instance.RemoveWithTarget(ownerEntity, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal));
			}
			if (EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote)))
			{
				EventSystem.Instance.RemoveWithTarget(ownerEntity, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote));
			}
		}
	}

	// Token: 0x0601748E RID: 95374 RVA: 0x006D8710 File Offset: 0x006D6910
	public override void OnRemoved(bool bPremature)
	{
		this.RemoveEvent();
		List<BaseBuffComponent> list = new List<BaseBuffComponent>();
		foreach (int id in this.EntityIds)
		{
			Entity entity = EntitySystem.Instance.Get(id);
			BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
			if (baseBuffComponent != null)
			{
				list.Add(baseBuffComponent);
			}
		}
		int[] buffStack = new int[list.Count];
		foreach (long buffId in this.BuffIds)
		{
			this.CopyBuff(buffId, list.ToArray(), buffStack);
		}
	}

	// Token: 0x0601748F RID: 95375 RVA: 0x006D87CC File Offset: 0x006D69CC
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017490 RID: 95376 RVA: 0x006D87CF File Offset: 0x006D69CF
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C567 RID: 50535
	protected long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C568 RID: 50536
	protected long BulletId;

	// Token: 0x0400C569 RID: 50537
	protected HashSet<int> EntityIds = new HashSet<int>();
}
