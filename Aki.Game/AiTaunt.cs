using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020000F8 RID: 248
[NullableContext(1)]
[Nullable(0)]
public class AiTaunt
{
	// Token: 0x06000E07 RID: 3591 RVA: 0x0004FED4 File Offset: 0x0004E0D4
	public AiTaunt(AiController AiController)
	{
		this.AiController = AiController;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x0004FEE4 File Offset: 0x0004E0E4
	private unsafe void OnAiTauntAddOrRemoveHandler(bool addOrRemove, int instigatorEntityId, int handleId)
	{
		if (addOrRemove)
		{
			if (this.CurrentInstigatorEntityId.GetValueOrDefault() != -1)
			{
				this.HateList.RemoveHateListForTaunt(this.CurrentInstigatorEntityId.Value);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[AiTaunt]设置新的嘲讽对象：";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("被嘲讽者", this.AiController.CharAiDesignComp.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("嘲讽者", instigatorEntityId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.HateList.AddNewHateListForTaunt(instigatorEntityId, 1E+09f);
			this.CurrentInstigatorEntityId = new int?(instigatorEntityId);
			this.ActiveHandleId = new int?(handleId);
			return;
		}
		int? activeHandleId = this.ActiveHandleId;
		if (!(handleId == activeHandleId.GetValueOrDefault() & activeHandleId != null))
		{
			return;
		}
		this.ClearCurrentTaunt();
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.AI;
		ELogAuthor author2 = ELogAuthor.LJM;
		string message2 = "[AiTaunt]嘲讽时效结束：";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("被嘲讽者", this.AiController.CharAiDesignComp.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("嘲讽者", instigatorEntityId);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x0005004C File Offset: 0x0004E24C
	private void OnAiHateTargetChangedHandler(int? newId, int? preId)
	{
		if (this.CurrentInstigatorEntityId.GetValueOrDefault() != -1)
		{
			int? num = newId;
			int? currentInstigatorEntityId = this.CurrentInstigatorEntityId;
			if (!(num.GetValueOrDefault() == currentInstigatorEntityId.GetValueOrDefault() & num != null == (currentInstigatorEntityId != null)))
			{
				this.ClearCurrentTauntAndGe();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[AiTaunt]更高机制使之仇恨目标更改，嘲讽结束：";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("被嘲讽者", this.AiController.CharAiDesignComp.Entity.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x000500D9 File Offset: 0x0004E2D9
	public void Init(AiHateList hateList)
	{
		this.HateList = hateList;
		this.CurrentInstigatorEntityId = new int?(-1);
		this.ActiveHandleId = null;
		this.BindEvent();
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00050100 File Offset: 0x0004E300
	public unsafe void Tick()
	{
		if (this.CurrentInstigatorEntityId == null || this.CurrentInstigatorEntityId.GetValueOrDefault() == -1)
		{
			return;
		}
		bool flag = true;
		Entity entity = EntitySystem.Instance.Get<Entity>(this.CurrentInstigatorEntityId.Value);
		if (entity != null && entity.Active)
		{
			CharacterUnifiedStateComponent component = entity.GetComponent<CharacterUnifiedStateComponent>();
			if (component != null && component.Valid && !component.IsInGame.GetValueOrDefault())
			{
				flag = false;
			}
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			if (component2 == null || !component2.Valid)
			{
				flag = false;
			}
			if (component2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				flag = false;
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[AiTaunt]嘲讽施加者目前失效或者死亡，导致嘲讽结束：";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("被嘲讽者", this.AiController.CharAiDesignComp.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("嘲讽者", this.CurrentInstigatorEntityId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.ClearCurrentTauntAndGe();
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00050227 File Offset: 0x0004E427
	public void Clear()
	{
		this.ClearCurrentTauntAndGe();
		this.HateList = null;
		this.CurrentInstigatorEntityId = null;
		this.ActiveHandleId = null;
		this.UnBindEvent();
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00050254 File Offset: 0x0004E454
	private void ClearCurrentTaunt()
	{
		if (this.CurrentInstigatorEntityId != null && this.HateList != null)
		{
			this.HateList.RemoveHateListForTaunt(this.CurrentInstigatorEntityId.Value);
		}
		this.CurrentInstigatorEntityId = new int?(-1);
		this.ActiveHandleId = null;
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x000502A4 File Offset: 0x0004E4A4
	public void Reset(AiHateList hateList)
	{
		this.Clear();
		this.Init(hateList);
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x000502B4 File Offset: 0x0004E4B4
	public void ClearCurrentTauntAndGe()
	{
		if (this.ActiveHandleId != null)
		{
			CharacterBuffComponent component = this.AiController.CharAiDesignComp.Entity.GetComponent<CharacterBuffComponent>();
			if (component != null)
			{
				component.RemoveBuffByHandle(this.ActiveHandleId.Value, -1, null, null, null, null);
			}
		}
		this.ClearCurrentTaunt();
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00050320 File Offset: 0x0004E520
	public void BindEvent()
	{
		if (!this.AiController.CharAiDesignComp.Valid)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget(this.AiController.CharAiDesignComp.Entity, EEventName.AiTauntAddOrRemove, new Action<bool, int, int>(this.OnAiTauntAddOrRemoveHandler));
		EventSystem.Instance.AddWithTarget(this.AiController.CharAiDesignComp.Entity, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChangedHandler));
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00050398 File Offset: 0x0004E598
	public void UnBindEvent()
	{
		CharacterAiComponent charAiDesignComp = this.AiController.CharAiDesignComp;
		Entity entity = (charAiDesignComp != null) ? charAiDesignComp.Entity : null;
		if (entity == null)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.AiTauntAddOrRemove, new Action<bool, int, int>(this.OnAiTauntAddOrRemoveHandler)))
		{
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.AiTauntAddOrRemove, new Action<bool, int, int>(this.OnAiTauntAddOrRemoveHandler));
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChangedHandler)))
		{
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChangedHandler));
		}
	}

	// Token: 0x04000B6C RID: 2924
	private const long TAUNT_VALUE = 1000000000L;

	// Token: 0x04000B6D RID: 2925
	[Nullable(2)]
	private AiHateList HateList;

	// Token: 0x04000B6E RID: 2926
	private int? CurrentInstigatorEntityId;

	// Token: 0x04000B6F RID: 2927
	private int? ActiveHandleId;

	// Token: 0x04000B70 RID: 2928
	private readonly AiController AiController;
}
