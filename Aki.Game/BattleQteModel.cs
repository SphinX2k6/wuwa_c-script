using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001AEC RID: 6892
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BattleQteModel : ModelBase
{
	// Token: 0x060111AF RID: 70063 RVA: 0x00506455 File Offset: 0x00504655
	protected override bool OnInit()
	{
		if (!EventSystem.Instance.Has<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd)))
		{
			EventSystem.Instance.Add<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
		}
		return true;
	}

	// Token: 0x060111B0 RID: 70064 RVA: 0x00506491 File Offset: 0x00504691
	protected override bool OnClear()
	{
		if (EventSystem.Instance.Has<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd)))
		{
			EventSystem.Instance.Remove<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
		}
		return true;
	}

	// Token: 0x060111B1 RID: 70065 RVA: 0x005064D0 File Offset: 0x005046D0
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

	// Token: 0x060111B2 RID: 70066 RVA: 0x00506528 File Offset: 0x00504728
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

	// Token: 0x060111B3 RID: 70067 RVA: 0x00506544 File Offset: 0x00504744
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

	// Token: 0x060111B4 RID: 70068 RVA: 0x005065B4 File Offset: 0x005047B4
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

	// Token: 0x060111B5 RID: 70069 RVA: 0x00506628 File Offset: 0x00504828
	public void SetCurrentBattleQte(BattleQteContext context)
	{
		this.BattleHandleId = context.BattleQteHandleId;
		if (this.BattleContexts == null)
		{
			this.BattleContexts = new Dictionary<int, BattleQteContext>();
		}
		this.BattleContexts[context.BattleQteHandleId] = context;
	}

	// Token: 0x060111B6 RID: 70070 RVA: 0x0050665B File Offset: 0x0050485B
	public int GetBattleQteHandleId()
	{
		return this.BattleHandleId;
	}

	// Token: 0x060111B7 RID: 70071 RVA: 0x00506663 File Offset: 0x00504863
	public void ClearBattleQteHandleId()
	{
		this.BattleHandleId = -1;
	}

	// Token: 0x060111B8 RID: 70072 RVA: 0x0050666C File Offset: 0x0050486C
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

	// Token: 0x17001994 RID: 6548
	// (get) Token: 0x060111B9 RID: 70073 RVA: 0x00506694 File Offset: 0x00504894
	public static BattleQteModel Instance
	{
		get
		{
			return BattleQteModel._Instance;
		}
	}

	// Token: 0x060111BA RID: 70074 RVA: 0x0050669B File Offset: 0x0050489B
	public static BattleQteModel GetOrCreateInstance()
	{
		if (BattleQteModel._Instance == null)
		{
			BattleQteModel.CreateInstance();
		}
		return BattleQteModel._Instance;
	}

	// Token: 0x060111BB RID: 70075 RVA: 0x005066AF File Offset: 0x005048AF
	public static bool CreateInstance()
	{
		if (BattleQteModel._Instance != null)
		{
			return true;
		}
		BattleQteModel._Instance = new BattleQteModel();
		return true;
	}

	// Token: 0x060111BC RID: 70076 RVA: 0x005066C5 File Offset: 0x005048C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060111BD RID: 70077 RVA: 0x005066C7 File Offset: 0x005048C7
	public static void ResetStaticDefaultValue()
	{
		BattleQteModel._Instance = null;
	}

	// Token: 0x060111BE RID: 70078 RVA: 0x005066CF File Offset: 0x005048CF
	static BattleQteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleQteModel.CreateStaticDefaultValue), new Action(BattleQteModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009687 RID: 38535
	private const string DT_BATTLE_QTE_PATH = "/Game/Aki/Data/Qte/DT_BattleQte.DT_BattleQte";

	// Token: 0x04009688 RID: 38536
	private int BattleHandleIdCounter;

	// Token: 0x04009689 RID: 38537
	private int BattleHandleId;

	// Token: 0x0400968A RID: 38538
	[Nullable(2)]
	private UDataTable BattleQteDt;

	// Token: 0x0400968B RID: 38539
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, BattleQteContext> BattleContexts;

	// Token: 0x0400968C RID: 38540
	[Nullable(2)]
	private static BattleQteModel _Instance;
}
