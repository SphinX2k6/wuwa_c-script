using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using UnrealEngine;

// Token: 0x02002300 RID: 8960
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class PanelQteModel : ModelBase
{
	// Token: 0x06011AC9 RID: 72393 RVA: 0x00457D66 File Offset: 0x00455F66
	protected override bool OnInit()
	{
		this.IsInQte = new bool?(false);
		this.HandleId = new int?(0);
		this.TimeDilation.Init();
		this.ResultHandler = new PanelQteResultHandler();
		return true;
	}

	// Token: 0x06011ACA RID: 72394 RVA: 0x00457D97 File Offset: 0x00455F97
	protected override bool OnLeaveLevel()
	{
		this.CommonDt = null;
		return true;
	}

	// Token: 0x06011ACB RID: 72395 RVA: 0x00457DA1 File Offset: 0x00455FA1
	protected override bool OnClear()
	{
		this.IsInQte = null;
		this.HandleId = null;
		this.TimeDilation.Clear();
		this.ResultHandler = null;
		return true;
	}

	// Token: 0x06011ACC RID: 72396 RVA: 0x00457DD0 File Offset: 0x00455FD0
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

	// Token: 0x06011ACD RID: 72397 RVA: 0x00457EC0 File Offset: 0x004560C0
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

	// Token: 0x06011ACE RID: 72398 RVA: 0x00457F11 File Offset: 0x00456111
	public void ForceStopQte()
	{
		if (this.HandleId != null)
		{
			this.StopQte(this.HandleId.Value);
		}
	}

	// Token: 0x06011ACF RID: 72399 RVA: 0x00457F32 File Offset: 0x00456132
	public PanelQteContext GetContext()
	{
		return this.Context;
	}

	// Token: 0x06011AD0 RID: 72400 RVA: 0x00457F3A File Offset: 0x0045613A
	public Number GetWorldTimeDilation()
	{
		return this.TimeDilation.GetWorldTimeDilation();
	}

	// Token: 0x06011AD1 RID: 72401 RVA: 0x00457F47 File Offset: 0x00456147
	public Number GetLeftTime()
	{
		return this.LeftTime;
	}

	// Token: 0x06011AD2 RID: 72402 RVA: 0x00457F50 File Offset: 0x00456150
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

	// Token: 0x06011AD3 RID: 72403 RVA: 0x00457FB8 File Offset: 0x004561B8
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

	// Token: 0x06011AD4 RID: 72404 RVA: 0x00458044 File Offset: 0x00456244
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

	// Token: 0x06011AD5 RID: 72405 RVA: 0x004580FC File Offset: 0x004562FC
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

	// Token: 0x06011AD6 RID: 72406 RVA: 0x00458170 File Offset: 0x00456370
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

	// Token: 0x06011AD7 RID: 72407 RVA: 0x004581A9 File Offset: 0x004563A9
	public void HandleResult()
	{
		this.ResultHandler.Handle(this.Context);
	}

	// Token: 0x06011AD8 RID: 72408 RVA: 0x004581BC File Offset: 0x004563BC
	public bool IsQteSuccess()
	{
		PanelQteContext context = this.Context;
		return context != null && context.Success;
	}

	// Token: 0x170016AA RID: 5802
	// (get) Token: 0x06011AD9 RID: 72409 RVA: 0x004581CF File Offset: 0x004563CF
	[Nullable(1)]
	public static PanelQteModel Instance
	{
		[NullableContext(1)]
		get
		{
			return PanelQteModel._Instance;
		}
	}

	// Token: 0x06011ADA RID: 72410 RVA: 0x004581D6 File Offset: 0x004563D6
	[NullableContext(1)]
	public static PanelQteModel GetOrCreateInstance()
	{
		if (PanelQteModel._Instance == null)
		{
			PanelQteModel.CreateInstance();
		}
		return PanelQteModel._Instance;
	}

	// Token: 0x06011ADB RID: 72411 RVA: 0x004581EA File Offset: 0x004563EA
	public static bool CreateInstance()
	{
		if (PanelQteModel._Instance != null)
		{
			return true;
		}
		PanelQteModel._Instance = new PanelQteModel();
		return true;
	}

	// Token: 0x06011ADC RID: 72412 RVA: 0x00458200 File Offset: 0x00456400
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011ADD RID: 72413 RVA: 0x00458202 File Offset: 0x00456402
	public static void ResetStaticDefaultValue()
	{
		PanelQteModel._Instance = null;
	}

	// Token: 0x06011ADE RID: 72414 RVA: 0x0045820A File Offset: 0x0045640A
	static PanelQteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PanelQteModel.CreateStaticDefaultValue), new Action(PanelQteModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008617 RID: 34327
	[Nullable(1)]
	private readonly PanelQteTimeDilation TimeDilation = new PanelQteTimeDilation();

	// Token: 0x04008618 RID: 34328
	public bool? IsInQte;

	// Token: 0x04008619 RID: 34329
	private int? HandleId;

	// Token: 0x0400861A RID: 34330
	private Number LeftTime = 0;

	// Token: 0x0400861B RID: 34331
	private Number EndWorldTime = 0;

	// Token: 0x0400861C RID: 34332
	private UDataTable CommonDt;

	// Token: 0x0400861D RID: 34333
	private PanelQteContext Context;

	// Token: 0x0400861E RID: 34334
	private PanelQteResultHandler ResultHandler;

	// Token: 0x0400861F RID: 34335
	public bool IsHideAllBattleUi;

	// Token: 0x04008620 RID: 34336
	public int[] HideBattleUiChildren;

	// Token: 0x04008621 RID: 34337
	public bool DisableFightInput;

	// Token: 0x04008622 RID: 34338
	public EntityHandle CurRoleEntity;

	// Token: 0x04008623 RID: 34339
	private static PanelQteModel _Instance;
}
