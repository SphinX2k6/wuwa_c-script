using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AE4 RID: 10980
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandQueue
{
	// Token: 0x17001E71 RID: 7793
	// (get) Token: 0x06016D93 RID: 93587 RVA: 0x005CC7FC File Offset: 0x005CA9FC
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

	// Token: 0x06016D94 RID: 93588 RVA: 0x005CC824 File Offset: 0x005CAA24
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

	// Token: 0x06016D95 RID: 93589 RVA: 0x005CC86B File Offset: 0x005CAA6B
	public void Clear()
	{
		this.Commands.Clear();
		this.CommandsMap.Clear();
	}

	// Token: 0x06016D96 RID: 93590 RVA: 0x005CC884 File Offset: 0x005CAA84
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

	// Token: 0x06016D97 RID: 93591 RVA: 0x005CC97C File Offset: 0x005CAB7C
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

	// Token: 0x06016D98 RID: 93592 RVA: 0x005CCA60 File Offset: 0x005CAC60
	public void UpdateCommand(SurvivorsOpData data)
	{
		SurvivorsRogueCommandBase survivorsRogueCommandBase;
		if (!this.CommandsMap.TryGetValue(data.IncId, out survivorsRogueCommandBase))
		{
			return;
		}
		survivorsRogueCommandBase.Update(data);
	}

	// Token: 0x06016D99 RID: 93593 RVA: 0x005CCA8C File Offset: 0x005CAC8C
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

	// Token: 0x06016D9A RID: 93594 RVA: 0x005CCB60 File Offset: 0x005CAD60
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

	// Token: 0x06016D9B RID: 93595 RVA: 0x005CCBDA File Offset: 0x005CADDA
	public void StartForegroundCommand()
	{
		if (this.ForegroundCommand != null)
		{
			this.ForegroundCommand.TryStartExecute();
		}
	}

	// Token: 0x06016D9C RID: 93596 RVA: 0x005CCBF0 File Offset: 0x005CADF0
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

	// Token: 0x06016D9D RID: 93597 RVA: 0x005CCC10 File Offset: 0x005CAE10
	public IReadOnlyList<SurvivorsRogueCommandBase> GetCommands()
	{
		return this.Commands;
	}

	// Token: 0x0400A9BB RID: 43451
	private readonly List<SurvivorsRogueCommandBase> Commands = new List<SurvivorsRogueCommandBase>();

	// Token: 0x0400A9BC RID: 43452
	private readonly Dictionary<int, SurvivorsRogueCommandBase> CommandsMap = new Dictionary<int, SurvivorsRogueCommandBase>();

	// Token: 0x0400A9BD RID: 43453
	public int ForegroundCommandIncId = -1;
}
