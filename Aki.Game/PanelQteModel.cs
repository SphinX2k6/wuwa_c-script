using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using UnrealEngine;

// Token: 0x020017E4 RID: 6116
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class PanelQteModel : ModelBase
{
	// Token: 0x0600EF61 RID: 61281 RVA: 0x00464A46 File Offset: 0x00462C46
	protected override bool OnInit()
	{
		this.IsInQte = new bool?(false);
		this.HandleId = new int?(0);
		this.TimeDilation.Init();
		this.ResultHandler = new PanelQteResultHandler();
		return true;
	}

	// Token: 0x0600EF62 RID: 61282 RVA: 0x00464A77 File Offset: 0x00462C77
	protected override bool OnLeaveLevel()
	{
		this.CommonDt = null;
		return true;
	}

	// Token: 0x0600EF63 RID: 61283 RVA: 0x00464A81 File Offset: 0x00462C81
	protected override bool OnClear()
	{
		this.IsInQte = null;
		this.HandleId = null;
		this.TimeDilation.Clear();
		this.ResultHandler = null;
		return true;
	}

	// Token: 0x0600EF64 RID: 61284 RVA: 0x00464AB0 File Offset: 0x00462CB0
	[NullableContext(1)]
	public int StartQte(PanelQteContext context)
	{
		this.HandleId = new int?(this.HandleId.GetValueOrDefault() + 1);
		this.IsInQte = new bool?(true);
		this.Context = context;
		context.QteHandleId = this.HandleId.Value;
		this.TimeDilation.Start(context);
		if (context.Config.Duration > 0f)
		{
			this.LeftTime = context.Config.Duration * (float)TimeUtil.Instance.InverseMillisecond;
			Number worldTimeDilation = this.TimeDilation.GetWorldTimeDilation();
			if (worldTimeDilation != 0)
			{
				this.EndWorldTime = Time.Instance.WorldTime + this.LeftTime * worldTimeDilation;
			}
		}
		else
		{
			this.LeftTime = 0;
			this.EndWorldTime = 0;
		}
		return this.HandleId.Value;
	}

	// Token: 0x0600EF65 RID: 61285 RVA: 0x00464BA0 File Offset: 0x00462DA0
	public bool StopQte(int handleId)
	{
		if (this.IsInQte.GetValueOrDefault())
		{
			int? handleId2 = this.HandleId;
			if (handleId2.GetValueOrDefault() == handleId & handleId2 != null)
			{
				this.IsInQte = new bool?(false);
				this.TimeDilation.Stop();
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600EF66 RID: 61286 RVA: 0x00464BF1 File Offset: 0x00462DF1
	public void ForceStopQte()
	{
		if (this.HandleId != null)
		{
			this.StopQte(this.HandleId.Value);
		}
	}

	// Token: 0x0600EF67 RID: 61287 RVA: 0x00464C12 File Offset: 0x00462E12
	public PanelQteContext GetContext()
	{
		return this.Context;
	}

	// Token: 0x0600EF68 RID: 61288 RVA: 0x00464C1A File Offset: 0x00462E1A
	public Number GetWorldTimeDilation()
	{
		return this.TimeDilation.GetWorldTimeDilation();
	}

	// Token: 0x0600EF69 RID: 61289 RVA: 0x00464C27 File Offset: 0x00462E27
	public Number GetLeftTime()
	{
		return this.LeftTime;
	}

	// Token: 0x0600EF6A RID: 61290 RVA: 0x00464C30 File Offset: 0x00462E30
	public Number GetLeftTimeNoScale()
	{
		if (this.LeftTime <= 0)
		{
			return 0;
		}
		if (!this.IsInQte.GetValueOrDefault())
		{
			return 0;
		}
		Number worldTimeDilation = this.TimeDilation.GetWorldTimeDilation();
		if (worldTimeDilation == 0)
		{
			return this.LeftTime;
		}
		return this.LeftTime / worldTimeDilation;
	}

	// Token: 0x0600EF6B RID: 61291 RVA: 0x00464C98 File Offset: 0x00462E98
	public void ResetLeftTime(int handleId)
	{
		int? handleId2 = this.HandleId;
		if (!(handleId2.GetValueOrDefault() == handleId & handleId2 != null))
		{
			return;
		}
		if (this.LeftTime > 0)
		{
			Number worldTimeDilation = this.TimeDilation.GetWorldTimeDilation();
			if (worldTimeDilation != 0)
			{
				this.EndWorldTime = Time.Instance.WorldTime + this.LeftTime * worldTimeDilation;
				return;
			}
		}
		else
		{
			this.EndWorldTime = 0;
		}
	}

	// Token: 0x0600EF6C RID: 61292 RVA: 0x00464D24 File Offset: 0x00462F24
	public void UpdateTime(float delta)
	{
		if (this.LeftTime <= 0)
		{
			return;
		}
		if (!this.IsInQte.GetValueOrDefault())
		{
			return;
		}
		if (this.TimeDilation.GetWorldTimeDilation() == 0)
		{
			this.LeftTime -= delta;
		}
		else
		{
			this.LeftTime = this.EndWorldTime - Time.Instance.WorldTime;
		}
		if (this.LeftTime <= 0 && this.HandleId != null)
		{
			PanelQteController.Instance.StopQte(this.HandleId.Value, false);
		}
	}

	// Token: 0x0600EF6D RID: 61293 RVA: 0x00464DDC File Offset: 0x00462FDC
	public SPanelQte GetPanelQteConfig(int qteId)
	{
		if (this.CommonDt == null)
		{
			this.CommonDt = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/UI/DT_PanelQte.DT_PanelQte");
		}
		SPanelQte dataTableRow = DataTableUtil.GetDataTableRow<SPanelQte>(this.CommonDt, qteId.ToString());
		if (dataTableRow == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PanelQte;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "找不到界面QTE配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("qteId", qteId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return dataTableRow;
	}

	// Token: 0x0600EF6E RID: 61294 RVA: 0x00464E50 File Offset: 0x00463050
	public bool SetQteResult(int handleId, bool success)
	{
		int? handleId2 = this.HandleId;
		if (!(handleId2.GetValueOrDefault() == handleId & handleId2 != null))
		{
			return false;
		}
		this.Context.Success = success;
		return true;
	}

	// Token: 0x0600EF6F RID: 61295 RVA: 0x00464E89 File Offset: 0x00463089
	public void HandleResult()
	{
		this.ResultHandler.Handle(this.Context);
	}

	// Token: 0x0600EF70 RID: 61296 RVA: 0x00464E9C File Offset: 0x0046309C
	public bool IsQteSuccess()
	{
		PanelQteContext context = this.Context;
		return context != null && context.Success;
	}

	// Token: 0x170016E1 RID: 5857
	// (get) Token: 0x0600EF71 RID: 61297 RVA: 0x00464EAF File Offset: 0x004630AF
	[Nullable(1)]
	public static PanelQteModel Instance
	{
		[NullableContext(1)]
		get
		{
			return PanelQteModel._Instance;
		}
	}

	// Token: 0x0600EF72 RID: 61298 RVA: 0x00464EB6 File Offset: 0x004630B6
	[NullableContext(1)]
	public static PanelQteModel GetOrCreateInstance()
	{
		if (PanelQteModel._Instance == null)
		{
			PanelQteModel.CreateInstance();
		}
		return PanelQteModel._Instance;
	}

	// Token: 0x0600EF73 RID: 61299 RVA: 0x00464ECA File Offset: 0x004630CA
	public static bool CreateInstance()
	{
		if (PanelQteModel._Instance != null)
		{
			return true;
		}
		PanelQteModel._Instance = new PanelQteModel();
		return true;
	}

	// Token: 0x0600EF74 RID: 61300 RVA: 0x00464EE0 File Offset: 0x004630E0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EF75 RID: 61301 RVA: 0x00464EE2 File Offset: 0x004630E2
	public static void ResetStaticDefaultValue()
	{
		PanelQteModel._Instance = null;
	}

	// Token: 0x0600EF76 RID: 61302 RVA: 0x00464EEA File Offset: 0x004630EA
	static PanelQteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PanelQteModel.CreateStaticDefaultValue), new Action(PanelQteModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008755 RID: 34645
	[Nullable(1)]
	private readonly PanelQteTimeDilation TimeDilation = new PanelQteTimeDilation();

	// Token: 0x04008756 RID: 34646
	public bool? IsInQte;

	// Token: 0x04008757 RID: 34647
	private int? HandleId;

	// Token: 0x04008758 RID: 34648
	private Number LeftTime = 0;

	// Token: 0x04008759 RID: 34649
	private Number EndWorldTime = 0;

	// Token: 0x0400875A RID: 34650
	private UDataTable CommonDt;

	// Token: 0x0400875B RID: 34651
	private PanelQteContext Context;

	// Token: 0x0400875C RID: 34652
	private PanelQteResultHandler ResultHandler;

	// Token: 0x0400875D RID: 34653
	public bool IsHideAllBattleUi;

	// Token: 0x0400875E RID: 34654
	public int[] HideBattleUiChildren;

	// Token: 0x0400875F RID: 34655
	public bool DisableFightInput;

	// Token: 0x04008760 RID: 34656
	public EntityHandle CurRoleEntity;

	// Token: 0x04008761 RID: 34657
	private static PanelQteModel _Instance;
}
