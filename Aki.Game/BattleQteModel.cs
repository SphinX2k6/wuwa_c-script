using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002601 RID: 9729
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BattleQteModel : ModelBase
{
	// Token: 0x06013CCD RID: 81101 RVA: 0x004F7679 File Offset: 0x004F5879
	protected override bool OnInit()
	{
		if (!EventSystem.Instance.Has<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd)))
		{
			EventSystem.Instance.Add<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
		}
		return true;
	}

	// Token: 0x06013CCE RID: 81102 RVA: 0x004F76B5 File Offset: 0x004F58B5
	protected override bool OnClear()
	{
		if (EventSystem.Instance.Has<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd)))
		{
			EventSystem.Instance.Remove<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
		}
		return true;
	}

	// Token: 0x06013CCF RID: 81103 RVA: 0x004F76F4 File Offset: 0x004F58F4
	private void OnCommonQteEnd(int? commonQteHandleId)
	{
		BattleQteContext battleQteContext = this.GetBattleQteContext(this.GetBattleQteHandleId());
		if (battleQteContext != null)
		{
			int? num = commonQteHandleId;
			int commonQteHandleId2 = battleQteContext.CommonQteHandleId;
			if (num.GetValueOrDefault() == commonQteHandleId2 & num != null)
			{
				Dictionary<int, BattleQteContext> battleContexts = this.BattleContexts;
				if (battleContexts != null)
				{
					battleContexts.Remove(battleQteContext.BattleQteHandleId);
				}
				this.ClearBattleQteHandleId();
			}
		}
	}

	// Token: 0x06013CD0 RID: 81104 RVA: 0x004F774C File Offset: 0x004F594C
	protected override bool OnLeaveLevel()
	{
		Dictionary<int, BattleQteContext> battleContexts = this.BattleContexts;
		if (battleContexts != null)
		{
			battleContexts.Clear();
		}
		this.BattleQteDt = null;
		return true;
	}

	// Token: 0x06013CD1 RID: 81105 RVA: 0x004F7768 File Offset: 0x004F5968
	[return: Nullable(2)]
	public BattleQteContext CreateBattleQteContext(int battleQteId, long messageId, EntityHandle entityHandle, EBattleQteSource source)
	{
		SBattleQte battleQteConfig = this.GetBattleQteConfig(battleQteId);
		if (battleQteConfig == null)
		{
			return null;
		}
		BattleQteContext battleQteContext = new BattleQteContext();
		int battleHandleIdCounter = this.BattleHandleIdCounter;
		this.BattleHandleIdCounter = battleHandleIdCounter + 1;
		battleQteContext.BattleQteHandleId = battleHandleIdCounter;
		battleQteContext.CommonQteId = battleQteConfig.QteId;
		battleQteContext.BattleQteId = battleQteId;
		battleQteContext.MessageId = new long?(messageId);
		battleQteContext.EntityHandle = entityHandle;
		battleQteContext.BattleQteSource = new EBattleQteSource?(source);
		return battleQteContext;
	}

	// Token: 0x06013CD2 RID: 81106 RVA: 0x004F77D8 File Offset: 0x004F59D8
	[NullableContext(2)]
	public SBattleQte GetBattleQteConfig(int battleQteId)
	{
		if (this.BattleQteDt == null)
		{
			this.BattleQteDt = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Qte/DT_BattleQte.DT_BattleQte");
		}
		SBattleQte dataTableRow = DataTableUtil.GetDataTableRow<SBattleQte>(this.BattleQteDt, battleQteId.ToString());
		if (dataTableRow == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "找不到战斗QTE配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BattleQteId", battleQteId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return dataTableRow;
	}

	// Token: 0x06013CD3 RID: 81107 RVA: 0x004F784C File Offset: 0x004F5A4C
	public void SetCurrentBattleQte(BattleQteContext context)
	{
		this.BattleHandleId = context.BattleQteHandleId;
		if (this.BattleContexts == null)
		{
			this.BattleContexts = new Dictionary<int, BattleQteContext>();
		}
		this.BattleContexts[context.BattleQteHandleId] = context;
	}

	// Token: 0x06013CD4 RID: 81108 RVA: 0x004F787F File Offset: 0x004F5A7F
	public int GetBattleQteHandleId()
	{
		return this.BattleHandleId;
	}

	// Token: 0x06013CD5 RID: 81109 RVA: 0x004F7887 File Offset: 0x004F5A87
	public void ClearBattleQteHandleId()
	{
		this.BattleHandleId = -1;
	}

	// Token: 0x06013CD6 RID: 81110 RVA: 0x004F7890 File Offset: 0x004F5A90
	[NullableContext(2)]
	public BattleQteContext GetBattleQteContext(int qteHandleId)
	{
		BattleQteContext result;
		if (this.BattleContexts != null && this.BattleContexts.TryGetValue(qteHandleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x1700195C RID: 6492
	// (get) Token: 0x06013CD7 RID: 81111 RVA: 0x004F78B8 File Offset: 0x004F5AB8
	public static BattleQteModel Instance
	{
		get
		{
			return BattleQteModel._Instance;
		}
	}

	// Token: 0x06013CD8 RID: 81112 RVA: 0x004F78BF File Offset: 0x004F5ABF
	public static BattleQteModel GetOrCreateInstance()
	{
		if (BattleQteModel._Instance == null)
		{
			BattleQteModel.CreateInstance();
		}
		return BattleQteModel._Instance;
	}

	// Token: 0x06013CD9 RID: 81113 RVA: 0x004F78D3 File Offset: 0x004F5AD3
	public static bool CreateInstance()
	{
		if (BattleQteModel._Instance != null)
		{
			return true;
		}
		BattleQteModel._Instance = new BattleQteModel();
		return true;
	}

	// Token: 0x06013CDA RID: 81114 RVA: 0x004F78E9 File Offset: 0x004F5AE9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013CDB RID: 81115 RVA: 0x004F78EB File Offset: 0x004F5AEB
	public static void ResetStaticDefaultValue()
	{
		BattleQteModel._Instance = null;
	}

	// Token: 0x06013CDC RID: 81116 RVA: 0x004F78F3 File Offset: 0x004F5AF3
	static BattleQteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleQteModel.CreateStaticDefaultValue), new Action(BattleQteModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009530 RID: 38192
	private const string DT_BATTLE_QTE_PATH = "/Game/Aki/Data/Qte/DT_BattleQte.DT_BattleQte";

	// Token: 0x04009531 RID: 38193
	private int BattleHandleIdCounter;

	// Token: 0x04009532 RID: 38194
	private int BattleHandleId;

	// Token: 0x04009533 RID: 38195
	[Nullable(2)]
	private UDataTable BattleQteDt;

	// Token: 0x04009534 RID: 38196
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, BattleQteContext> BattleContexts;

	// Token: 0x04009535 RID: 38197
	[Nullable(2)]
	private static BattleQteModel _Instance;
}
