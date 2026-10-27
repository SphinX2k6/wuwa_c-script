using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F25 RID: 12069
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectBuffCopy : BuffEffect
{
	// Token: 0x06019B7A RID: 105338 RVA: 0x006B2177 File Offset: 0x006B0377
	public ExtraEffectBuffCopy(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019B7B RID: 105339 RVA: 0x006B219C File Offset: 0x006B039C
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

	// Token: 0x06019B7C RID: 105340 RVA: 0x006B21F8 File Offset: 0x006B03F8
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

	// Token: 0x06019B7D RID: 105341 RVA: 0x006B22AA File Offset: 0x006B04AA
	public override void OnCreated()
	{
		this.EntityIds.Clear();
		this.AddEvent();
	}

	// Token: 0x06019B7E RID: 105342 RVA: 0x006B22BD File Offset: 0x006B04BD
	protected void OnHitLocal(HitInformation hitData, HitContext hitContext)
	{
		this.RecordHit(hitContext);
	}

	// Token: 0x06019B7F RID: 105343 RVA: 0x006B22C6 File Offset: 0x006B04C6
	protected void OnHitRemote(HitContext hitContext)
	{
		this.RecordHit(hitContext);
	}

	// Token: 0x06019B80 RID: 105344 RVA: 0x006B22CF File Offset: 0x006B04CF
	protected void RecordHit(HitContext hitContext)
	{
		if (hitContext.BulletId == this.BulletId)
		{
			this.EntityIds.Add(hitContext.Target.Id);
		}
	}

	// Token: 0x06019B81 RID: 105345 RVA: 0x006B22F8 File Offset: 0x006B04F8
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

	// Token: 0x06019B82 RID: 105346 RVA: 0x006B2374 File Offset: 0x006B0574
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

	// Token: 0x06019B83 RID: 105347 RVA: 0x006B23F8 File Offset: 0x006B05F8
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

	// Token: 0x06019B84 RID: 105348 RVA: 0x006B24B4 File Offset: 0x006B06B4
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019B85 RID: 105349 RVA: 0x006B24B7 File Offset: 0x006B06B7
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C1C5 RID: 49605
	protected long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C1C6 RID: 49606
	protected long BulletId;

	// Token: 0x0400C1C7 RID: 49607
	protected HashSet<int> EntityIds = new HashSet<int>();
}
