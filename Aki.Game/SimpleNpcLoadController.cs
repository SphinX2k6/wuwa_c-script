using System;
using System.Runtime.CompilerServices;

// Token: 0x020027D3 RID: 10195
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SimpleNpcLoadController : ControllerBase
{
	// Token: 0x060199E0 RID: 104928 RVA: 0x007DE2D4 File Offset: 0x007DC4D4
	protected override bool OnInit()
	{
		int capacity = 256;
		this.SimpleNpcLoadList = new Queue<TsSimpleNpc>(capacity);
		return true;
	}

	// Token: 0x060199E1 RID: 104929 RVA: 0x007DE2F4 File Offset: 0x007DC4F4
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x060199E2 RID: 104930 RVA: 0x007DE2F8 File Offset: 0x007DC4F8
	protected override void OnTick(float deltaTime)
	{
		if (!GameModeModel.Instance.WorldDone)
		{
			return;
		}
		if (this.SimpleNpcLoadList == null || this.SimpleNpcLoadList.Size == 0)
		{
			return;
		}
		TsSimpleNpc tsSimpleNpc = this.SimpleNpcLoadList.Pop();
		if (!ObjectUtils.IsValid(tsSimpleNpc))
		{
			return;
		}
		if (tsSimpleNpc.Mesh == null)
		{
			return;
		}
		if (tsSimpleNpc.LoadModelByDA())
		{
			tsSimpleNpc.SetDefaultCollision();
		}
		tsSimpleNpc.StartFlowLogic();
	}

	// Token: 0x060199E3 RID: 104931 RVA: 0x007DE35A File Offset: 0x007DC55A
	public void AddSimpleNpc(TsSimpleNpc npc)
	{
		if (this.SimpleNpcLoadList == null)
		{
			return;
		}
		this.SimpleNpcLoadList.Push(npc);
	}

	// Token: 0x170028F3 RID: 10483
	// (get) Token: 0x060199E4 RID: 104932 RVA: 0x007DE371 File Offset: 0x007DC571
	public static SimpleNpcLoadController Instance
	{
		get
		{
			return SimpleNpcLoadController._Instance;
		}
	}

	// Token: 0x060199E5 RID: 104933 RVA: 0x007DE378 File Offset: 0x007DC578
	public static SimpleNpcLoadController GetOrCreateInstance()
	{
		if (SimpleNpcLoadController._Instance == null)
		{
			SimpleNpcLoadController.CreateInstance();
		}
		return SimpleNpcLoadController._Instance;
	}

	// Token: 0x060199E6 RID: 104934 RVA: 0x007DE38C File Offset: 0x007DC58C
	public static bool CreateInstance()
	{
		if (SimpleNpcLoadController._Instance != null)
		{
			return true;
		}
		SimpleNpcLoadController._Instance = new SimpleNpcLoadController();
		return true;
	}

	// Token: 0x060199E7 RID: 104935 RVA: 0x007DE3A2 File Offset: 0x007DC5A2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060199E8 RID: 104936 RVA: 0x007DE3A4 File Offset: 0x007DC5A4
	public static void ResetStaticDefaultValue()
	{
		SimpleNpcLoadController._Instance = null;
	}

	// Token: 0x060199E9 RID: 104937 RVA: 0x007DE3AC File Offset: 0x007DC5AC
	static SimpleNpcLoadController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SimpleNpcLoadController.CreateStaticDefaultValue), new Action(SimpleNpcLoadController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E092 RID: 57490
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Queue<TsSimpleNpc> SimpleNpcLoadList;

	// Token: 0x0400E093 RID: 57491
	[Nullable(2)]
	private static SimpleNpcLoadController _Instance;
}
