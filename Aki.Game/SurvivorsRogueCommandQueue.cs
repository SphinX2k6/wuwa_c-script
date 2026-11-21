using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002060 RID: 8288
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandQueue
{
	// Token: 0x17001EC9 RID: 7881
	// (get) Token: 0x060147C4 RID: 83908 RVA: 0x005F934C File Offset: 0x005F754C
	[Nullable(2)]
	public SurvivorsRogueCommandBase ForegroundCommand
	{
		[NullableContext(2)]
		get
		{
			SurvivorsRogueCommandBase result;
			if (!this.CommandsMap.TryGetValue(this.ForegroundCommandIncId, out result))
			{
				return null;
			}
			return result;
		}
	}

	// Token: 0x060147C5 RID: 83909 RVA: 0x005F9374 File Offset: 0x005F7574
	public void InitCommands(IList<SurvivorsOpData> dataList)
	{
		this.Commands.Clear();
		this.CommandsMap.Clear();
		for (int i = 0; i < dataList.Count; i++)
		{
			this.AddCommand(dataList[i]);
		}
		this.PrintCommands();
	}

	// Token: 0x060147C6 RID: 83910 RVA: 0x005F93BB File Offset: 0x005F75BB
	public void Clear()
	{
		this.Commands.Clear();
		this.CommandsMap.Clear();
	}

	// Token: 0x060147C7 RID: 83911 RVA: 0x005F93D4 File Offset: 0x005F75D4
	public unsafe void PrintCommands()
	{
		Log.Instance.Info(ELogModule.SurvivorsRogue, ELogAuthor.YYZ, "[SurvivorsRogue] 指令队列打印开始", default(ReadOnlySpan<ValueTuple<string, object>>));
		for (int i = 0; i < this.Commands.Count; i++)
		{
			SurvivorsRogueCommandBase survivorsRogueCommandBase = this.Commands[i];
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SurvivorsRogue] 指令";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", i);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IncId", survivorsRogueCommandBase.IncId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Data", survivorsRogueCommandBase.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		Log.Instance.Info(ELogModule.SurvivorsRogue, ELogAuthor.YYZ, "[SurvivorsRogue] 指令队列打印结束", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060147C8 RID: 83912 RVA: 0x005F94CC File Offset: 0x005F76CC
	public unsafe void AddCommand(SurvivorsOpData data)
	{
		SurvivorsRogueCommandBase survivorsRogueCommandBase = SurvivorsRogueCommandFactory.Create(data);
		if (survivorsRogueCommandBase == null)
		{
			return;
		}
		survivorsRogueCommandBase.Update(data);
		bool foregroundStatus = survivorsRogueCommandBase.IncId == this.ForegroundCommandIncId;
		survivorsRogueCommandBase.SetForegroundStatus(foregroundStatus);
		this.Commands.Add(survivorsRogueCommandBase);
		this.CommandsMap[data.IncId] = survivorsRogueCommandBase;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[SurvivorsRogue] 新增指令";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", this.Commands.Count - 1);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IncId", survivorsRogueCommandBase.IncId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Data", survivorsRogueCommandBase.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x060147C9 RID: 83913 RVA: 0x005F95B0 File Offset: 0x005F77B0
	public void UpdateCommand(SurvivorsOpData data)
	{
		SurvivorsRogueCommandBase survivorsRogueCommandBase;
		if (!this.CommandsMap.TryGetValue(data.IncId, out survivorsRogueCommandBase))
		{
			return;
		}
		survivorsRogueCommandBase.Update(data);
	}

	// Token: 0x060147CA RID: 83914 RVA: 0x005F95DC File Offset: 0x005F77DC
	public unsafe void RemoveCommand(int incId)
	{
		SurvivorsRogueCommandBase survivorsRogueCommandBase;
		if (!this.CommandsMap.TryGetValue(incId, out survivorsRogueCommandBase))
		{
			return;
		}
		survivorsRogueCommandBase.Delete();
		int num = -1;
		for (int i = 0; i < this.Commands.Count; i++)
		{
			if (this.Commands[i].IncId == incId)
			{
				num = i;
				break;
			}
		}
		if (num != -1)
		{
			this.Commands.RemoveAt(num);
		}
		this.CommandsMap.Remove(incId);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[SurvivorsRogue] 删除指令";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IncId", incId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060147CB RID: 83915 RVA: 0x005F96B0 File Offset: 0x005F78B0
	public void SetForegroundIncId(int incId)
	{
		this.ForegroundCommandIncId = incId;
		for (int i = 0; i < this.Commands.Count; i++)
		{
			SurvivorsRogueCommandBase survivorsRogueCommandBase = this.Commands[i];
			bool foregroundStatus = survivorsRogueCommandBase.IncId == this.ForegroundCommandIncId;
			survivorsRogueCommandBase.SetForegroundStatus(foregroundStatus);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[SurvivorsRogue] 前台指令变更";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ForegroundIncId", incId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060147CC RID: 83916 RVA: 0x005F972A File Offset: 0x005F792A
	public void StartForegroundCommand()
	{
		if (this.ForegroundCommand != null)
		{
			this.ForegroundCommand.TryStartExecute();
		}
	}

	// Token: 0x060147CD RID: 83917 RVA: 0x005F9740 File Offset: 0x005F7940
	[NullableContext(2)]
	public SurvivorsRogueCommandBase GetCommandByIncId(int incId)
	{
		SurvivorsRogueCommandBase result;
		if (!this.CommandsMap.TryGetValue(incId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060147CE RID: 83918 RVA: 0x005F9760 File Offset: 0x005F7960
	public IReadOnlyList<SurvivorsRogueCommandBase> GetCommands()
	{
		return this.Commands;
	}

	// Token: 0x0400ADC1 RID: 44481
	private readonly List<SurvivorsRogueCommandBase> Commands = new List<SurvivorsRogueCommandBase>();

	// Token: 0x0400ADC2 RID: 44482
	private readonly Dictionary<int, SurvivorsRogueCommandBase> CommandsMap = new Dictionary<int, SurvivorsRogueCommandBase>();

	// Token: 0x0400ADC3 RID: 44483
	public int ForegroundCommandIncId = -1;
}
