using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020034B9 RID: 13497
[NullableContext(1)]
[Nullable(0)]
public abstract class Filter<[Nullable(2)] T>
{
	// Token: 0x170028BF RID: 10431
	// (get) Token: 0x0601D647 RID: 120391 RVA: 0x0083327F File Offset: 0x0083147F
	// (set) Token: 0x0601D648 RID: 120392 RVA: 0x00833287 File Offset: 0x00831487
	protected virtual Func<T, bool> TargetCriteriaInternal { get; set; }

	// Token: 0x170028C0 RID: 10432
	// (get) Token: 0x0601D649 RID: 120393
	public abstract string DebugName { get; }

	// Token: 0x170028C1 RID: 10433
	// (get) Token: 0x0601D64A RID: 120394 RVA: 0x00833290 File Offset: 0x00831490
	// (set) Token: 0x0601D64B RID: 120395 RVA: 0x00833298 File Offset: 0x00831498
	public virtual EFilterType FilterType { get; set; }

	// Token: 0x170028C2 RID: 10434
	// (get) Token: 0x0601D64C RID: 120396 RVA: 0x008332A1 File Offset: 0x008314A1
	// (set) Token: 0x0601D64D RID: 120397 RVA: 0x008332A9 File Offset: 0x008314A9
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

	// Token: 0x0601D64E RID: 120398 RVA: 0x008332C3 File Offset: 0x008314C3
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

	// Token: 0x0601D64F RID: 120399 RVA: 0x008332F3 File Offset: 0x008314F3
	public virtual void Init()
	{
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnInit), "[Filter] OnInit执行出错", base.GetType().Name);
	}

	// Token: 0x0601D650 RID: 120400 RVA: 0x00833318 File Offset: 0x00831518
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x0601D651 RID: 120401 RVA: 0x0083331B File Offset: 0x0083151B
	public virtual void Cleanup()
	{
		FilterTypeHelper.TryCatchWrapper<bool>(new Func<bool>(this.OnCleanup), "[Filter] OnCleanup执行出错", base.GetType().Name);
	}

	// Token: 0x0601D652 RID: 120402 RVA: 0x00833340 File Offset: 0x00831540
	protected virtual bool OnCleanup()
	{
		return true;
	}

	// Token: 0x0601D653 RID: 120403 RVA: 0x00833344 File Offset: 0x00831544
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

	// Token: 0x0200986D RID: 39021
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030926 RID: 198950
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<T, bool> <0>__AlwaysTrueCriteria;
	}
}
