using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

// Token: 0x020028A2 RID: 10402
[NullableContext(1)]
[Nullable(0)]
public class RedDotSystem : Singleton, ITickable
{
	// Token: 0x0601A618 RID: 108056 RVA: 0x00829EDC File Offset: 0x008280DC
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

	// Token: 0x0601A619 RID: 108057 RVA: 0x00829F98 File Offset: 0x00828198
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

	// Token: 0x0601A61A RID: 108058 RVA: 0x0082A064 File Offset: 0x00828264
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

	// Token: 0x0601A61B RID: 108059 RVA: 0x0082A0D8 File Offset: 0x008282D8
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

	// Token: 0x0601A61C RID: 108060 RVA: 0x0082A18C File Offset: 0x0082838C
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

	// Token: 0x17002B41 RID: 11073
	// (get) Token: 0x0601A61D RID: 108061 RVA: 0x0082A1F0 File Offset: 0x008283F0
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

	// Token: 0x0601A61E RID: 108062 RVA: 0x0082A213 File Offset: 0x00828413
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601A61F RID: 108063 RVA: 0x0082A215 File Offset: 0x00828415
	public static void ResetStaticDefaultValue()
	{
		RedDotSystem instance = RedDotSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		RedDotSystem._instance = null;
	}

	// Token: 0x0601A620 RID: 108064 RVA: 0x0082A22E File Offset: 0x0082842E
	static RedDotSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotSystem.CreateStaticDefaultValue), new Action(RedDotSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400E8B7 RID: 59575
	private readonly global::LinkedList<RedDotEventData> RedDotEventLinkedList = new global::LinkedList<RedDotEventData>(new RedDotEventData(delegate(int uId)
	{
	}, 0, ""));

	// Token: 0x0400E8B8 RID: 59576
	private readonly List<RedDotEventData> RedDotEventRecycleList = new List<RedDotEventData>();

	// Token: 0x0400E8B9 RID: 59577
	private readonly Dictionary<string, LinkedNode<RedDotEventData>> RedDotRepeatMap = new Dictionary<string, LinkedNode<RedDotEventData>>();

	// Token: 0x0400E8BA RID: 59578
	[Nullable(2)]
	private RedDotEventData CurrentEventData;

	// Token: 0x0400E8BB RID: 59579
	private float TICK_TOTAL_TIME = 500f;

	// Token: 0x0400E8BC RID: 59580
	private double TickRemainingTime = 500.0;

	// Token: 0x0400E8BD RID: 59581
	public bool IsOpenLogCallTime;

	// Token: 0x0400E8BE RID: 59582
	[Nullable(2)]
	private static RedDotSystem _instance;
}
