using System;
using System.Runtime.CompilerServices;

// Token: 0x02003264 RID: 12900
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SimpleNpcLoadController : ControllerBase
{
	// Token: 0x0601BE09 RID: 114185 RVA: 0x007B6160 File Offset: 0x007B4360
	protected override bool OnInit()
	{
		int capacity = 256;
		this.SimpleNpcLoadList = new Queue<TsSimpleNpc>(capacity);
		return true;
	}

	// Token: 0x0601BE0A RID: 114186 RVA: 0x007B6180 File Offset: 0x007B4380
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x0601BE0B RID: 114187 RVA: 0x007B6184 File Offset: 0x007B4384
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

	// Token: 0x0601BE0C RID: 114188 RVA: 0x007B61E6 File Offset: 0x007B43E6
	public void AddSimpleNpc(TsSimpleNpc npc)
	{
		if (this.SimpleNpcLoadList == null)
		{
			return;
		}
		this.SimpleNpcLoadList.Push(npc);
	}

	// Token: 0x17002660 RID: 9824
	// (get) Token: 0x0601BE0D RID: 114189 RVA: 0x007B61FD File Offset: 0x007B43FD
	public static SimpleNpcLoadController Instance
	{
		get
		{
			return SimpleNpcLoadController._Instance;
		}
	}

	// Token: 0x0601BE0E RID: 114190 RVA: 0x007B6204 File Offset: 0x007B4404
	public static SimpleNpcLoadController GetOrCreateInstance()
	{
		if (SimpleNpcLoadController._Instance == null)
		{
			SimpleNpcLoadController.CreateInstance();
		}
		return SimpleNpcLoadController._Instance;
	}

	// Token: 0x0601BE0F RID: 114191 RVA: 0x007B6218 File Offset: 0x007B4418
	public static bool CreateInstance()
	{
		if (SimpleNpcLoadController._Instance != null)
		{
			return true;
		}
		SimpleNpcLoadController._Instance = new SimpleNpcLoadController();
		return true;
	}

	// Token: 0x0601BE10 RID: 114192 RVA: 0x007B622E File Offset: 0x007B442E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BE11 RID: 114193 RVA: 0x007B6230 File Offset: 0x007B4430
	public static void ResetStaticDefaultValue()
	{
		SimpleNpcLoadController._Instance = null;
	}

	// Token: 0x0601BE12 RID: 114194 RVA: 0x007B6238 File Offset: 0x007B4438
	static SimpleNpcLoadController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SimpleNpcLoadController.CreateStaticDefaultValue), new Action(SimpleNpcLoadController.ResetStaticDefaultValue));
	}

	// Token: 0x0400DBF3 RID: 56307
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Queue<TsSimpleNpc> SimpleNpcLoadList;

	// Token: 0x0400DBF4 RID: 56308
	[Nullable(2)]
	private static SimpleNpcLoadController _Instance;
}
