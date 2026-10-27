using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

// Token: 0x02003330 RID: 13104
[NullableContext(1)]
[Nullable(0)]
public class RedDotSystem : Singleton, ITickable
{
	// Token: 0x0601C920 RID: 117024 RVA: 0x00803918 File Offset: 0x00801B18
	public void PushToEventQueue(TRedDotCheckEvent @event, int id, ERedDotName redDotName)
	{
		string key = redDotName.ToEnumString() + id.ToString();
		if (this.RedDotRepeatMap.ContainsKey(key))
		{
			return;
		}
		RedDotEventData currentEventData = this.CurrentEventData;
		if (((currentEventData != null) ? currentEventData.RedDotName : null) == redDotName.ToEnumString())
		{
			RedDotEventData currentEventData2 = this.CurrentEventData;
			if (currentEventData2 != null && currentEventData2.Id == id)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RedDot;
				ELogAuthor author = ELogAuthor.CX;
				string message = "红点处理存在循环调用, 详情见堆栈";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("红点名", redDotName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
		}
		RedDotEventData redDotEventData = this.GetRedDotEventData(@event, id, redDotName.ToEnumString());
		LinkedNode<RedDotEventData> value = this.RedDotEventLinkedList.AddTail(redDotEventData);
		this.RedDotRepeatMap[key] = value;
	}

	// Token: 0x0601C921 RID: 117025 RVA: 0x008039D4 File Offset: 0x00801BD4
	public void PopRedDotEventData(int id, ERedDotName redDotName)
	{
		string key = redDotName.ToEnumString() + id.ToString();
		if (!this.RedDotRepeatMap.ContainsKey(key))
		{
			return;
		}
		RedDotEventData currentEventData = this.CurrentEventData;
		if (((currentEventData != null) ? currentEventData.RedDotName : null) == redDotName.ToEnumString())
		{
			RedDotEventData currentEventData2 = this.CurrentEventData;
			if (currentEventData2 != null && currentEventData2.Id == id)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RedDot;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "红点处理存在在当前事件中移除自身";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("红点名", redDotName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
		}
		LinkedNode<RedDotEventData> linkedNode;
		if (this.RedDotRepeatMap.TryGetValue(key, out linkedNode))
		{
			this.RedDotEventLinkedList.RemoveNode(linkedNode);
			this.RedDotRepeatMap.Remove(key);
			this.RedDotEventRecycleList.Add(linkedNode.Element);
		}
	}

	// Token: 0x0601C922 RID: 117026 RVA: 0x00803AA0 File Offset: 0x00801CA0
	private void HandleRedDotData()
	{
		LinkedNode<RedDotEventData> headNextNode = this.RedDotEventLinkedList.GetHeadNextNode();
		RedDotEventData element = headNextNode.Element;
		this.CurrentEventData = element;
		this.RedDotEventLinkedList.RemoveNode(headNextNode);
		this.RedDotRepeatMap.Remove(element.RedDotName + element.Id.ToString());
		element.HandleEvent();
		this.CurrentEventData = null;
		this.RedDotEventRecycleList.Add(element);
	}

	// Token: 0x0601C923 RID: 117027 RVA: 0x00803B14 File Offset: 0x00801D14
	public void Tick(float deltaTime)
	{
		GameModeModel instance = GameModeModel.Instance;
		if (instance == null || instance.LoadingPhase != ELoadingPhase.Finished)
		{
			return;
		}
		int count = this.RedDotEventLinkedList.Count;
		if (count <= 0)
		{
			return;
		}
		int num = count;
		while (this.TickRemainingTime > 0.0 && num > 0)
		{
			double microseconds = KuroTime.GetMicroseconds64();
			this.HandleRedDotData();
			double num2 = KuroTime.GetMicroseconds64() - microseconds;
			this.TickRemainingTime -= num2;
			num--;
		}
		FKuroPerfSightHelper.PostValueFloat1("RedDot", "RedDotCostPerFrame", (float)((long)(((double)this.TICK_TOTAL_TIME - this.TickRemainingTime) / 1000.0)));
		this.TickRemainingTime = (double)this.TICK_TOTAL_TIME;
	}

	// Token: 0x0601C924 RID: 117028 RVA: 0x00803BC8 File Offset: 0x00801DC8
	public RedDotEventData GetRedDotEventData(TRedDotCheckEvent @event, int id, string redDotName)
	{
		if (this.RedDotEventRecycleList.Count > 0)
		{
			List<RedDotEventData> redDotEventRecycleList = this.RedDotEventRecycleList;
			RedDotEventData redDotEventData = redDotEventRecycleList[redDotEventRecycleList.Count - 1];
			this.RedDotEventRecycleList.RemoveAt(this.RedDotEventRecycleList.Count - 1);
			redDotEventData.Event = @event;
			redDotEventData.Id = id;
			redDotEventData.RedDotName = redDotName;
			return redDotEventData;
		}
		return new RedDotEventData(@event, id, redDotName);
	}

	// Token: 0x170027A5 RID: 10149
	// (get) Token: 0x0601C925 RID: 117029 RVA: 0x00803C2C File Offset: 0x00801E2C
	public static RedDotSystem Instance
	{
		get
		{
			if (RedDotSystem._instance == null)
			{
				RedDotSystem._instance = new RedDotSystem();
				RedDotSystem._instance.OnInit();
			}
			return RedDotSystem._instance;
		}
	}

	// Token: 0x0601C926 RID: 117030 RVA: 0x00803C4F File Offset: 0x00801E4F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C927 RID: 117031 RVA: 0x00803C51 File Offset: 0x00801E51
	public static void ResetStaticDefaultValue()
	{
		RedDotSystem instance = RedDotSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		RedDotSystem._instance = null;
	}

	// Token: 0x0601C928 RID: 117032 RVA: 0x00803C6A File Offset: 0x00801E6A
	static RedDotSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotSystem.CreateStaticDefaultValue), new Action(RedDotSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400E405 RID: 58373
	private readonly global::LinkedList<RedDotEventData> RedDotEventLinkedList = new global::LinkedList<RedDotEventData>(new RedDotEventData(delegate(int uId)
	{
	}, 0, ""));

	// Token: 0x0400E406 RID: 58374
	private readonly List<RedDotEventData> RedDotEventRecycleList = new List<RedDotEventData>();

	// Token: 0x0400E407 RID: 58375
	private readonly Dictionary<string, LinkedNode<RedDotEventData>> RedDotRepeatMap = new Dictionary<string, LinkedNode<RedDotEventData>>();

	// Token: 0x0400E408 RID: 58376
	[Nullable(2)]
	private RedDotEventData CurrentEventData;

	// Token: 0x0400E409 RID: 58377
	private float TICK_TOTAL_TIME = 500f;

	// Token: 0x0400E40A RID: 58378
	private double TickRemainingTime = 500.0;

	// Token: 0x0400E40B RID: 58379
	public bool IsOpenLogCallTime;

	// Token: 0x0400E40C RID: 58380
	[Nullable(2)]
	private static RedDotSystem _instance;
}
