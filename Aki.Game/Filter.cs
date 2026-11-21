using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A2D RID: 10797
[NullableContext(1)]
[Nullable(0)]
public abstract class Filter<[Nullable(2)] T>
{
	// Token: 0x17002C57 RID: 11351
	// (get) Token: 0x0601B346 RID: 111430 RVA: 0x0085A69F File Offset: 0x0085889F
	// (set) Token: 0x0601B347 RID: 111431 RVA: 0x0085A6A7 File Offset: 0x008588A7
	protected virtual Func<T, bool> TargetCriteriaInternal { get; set; }

	// Token: 0x17002C58 RID: 11352
	// (get) Token: 0x0601B348 RID: 111432
	public abstract string DebugName { get; }

	// Token: 0x17002C59 RID: 11353
	// (get) Token: 0x0601B349 RID: 111433 RVA: 0x0085A6B0 File Offset: 0x008588B0
	// (set) Token: 0x0601B34A RID: 111434 RVA: 0x0085A6B8 File Offset: 0x008588B8
	public virtual EFilterType FilterType { get; set; }

	// Token: 0x17002C5A RID: 11354
	// (get) Token: 0x0601B34B RID: 111435 RVA: 0x0085A6C1 File Offset: 0x008588C1
	// (set) Token: 0x0601B34C RID: 111436 RVA: 0x0085A6C9 File Offset: 0x008588C9
	public Func<T, bool> Criteria
	{
		get
		{
			return this.TargetCriteriaInternal;
		}
		set
		{
			this.TargetCriteriaInternal = value;
			EventSystem.Instance.Emit<object>(EEventName.FilterCriteriaChanged, this);
		}
	}

	// Token: 0x0601B34D RID: 111437 RVA: 0x0085A6E3 File Offset: 0x008588E3
	protected Filter()
	{
		Func<T, bool> targetCriteriaInternal;
		if ((targetCriteriaInternal = Filter<T>.<>O.<0>__AlwaysTrueCriteria) == null)
		{
			targetCriteriaInternal = (Filter<T>.<>O.<0>__AlwaysTrueCriteria = new Func<T, bool>(CriteriaDefine.AlwaysTrueCriteria<T>));
		}
		this.TargetCriteriaInternal = targetCriteriaInternal;
		this.FilterType = EFilterType.Black;
		base..ctor();
	}

	// Token: 0x0601B34E RID: 111438 RVA: 0x0085A713 File Offset: 0x00858913
	public virtual void Init()
	{
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnInit), "[Filter] OnInit执行出错", base.GetType().Name);
	}

	// Token: 0x0601B34F RID: 111439 RVA: 0x0085A738 File Offset: 0x00858938
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x0601B350 RID: 111440 RVA: 0x0085A73B File Offset: 0x0085893B
	public virtual void Cleanup()
	{
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnCleanup), "[Filter] OnCleanup执行出错", base.GetType().Name);
	}

	// Token: 0x0601B351 RID: 111441 RVA: 0x0085A760 File Offset: 0x00858960
	protected virtual bool OnCleanup()
	{
		return true;
	}

	// Token: 0x0601B352 RID: 111442 RVA: 0x0085A764 File Offset: 0x00858964
	public unsafe bool ExecuteCriteria(T target)
	{
		try
		{
			return this.TargetCriteriaInternal(target);
		}
		catch (Exception ex)
		{
			if (ex != null)
			{
				Exception ex2 = ex;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FilterWithState;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "业务层执行过滤器的判定标准的时候异常";
				Exception error = ex2;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("target", target);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex2);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.FilterWithState;
				ELogAuthor author2 = ELogAuthor.XDW;
				string message2 = "业务层执行过滤器的判定标准的时候异常, 并且捕获的不是Error";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("target", target);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return false;
	}

	// Token: 0x02008A88 RID: 35464
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BFAB RID: 180139
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<T, bool> <0>__AlwaysTrueCriteria;
	}
}
