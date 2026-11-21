using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005070 RID: 20592
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RoverlikeModel : ModelBase
	{
		// Token: 0x170064B1 RID: 25777
		// (get) Token: 0x060338E0 RID: 211168 RVA: 0x00E6FD7E File Offset: 0x00E6DF7E
		// (set) Token: 0x060338E1 RID: 211169 RVA: 0x00E6FD8B File Offset: 0x00E6DF8B
		public string CurRoomMusicState
		{
			get
			{
				return this.CurRoomMusicStateInternal.State;
			}
			set
			{
				this.CurRoomMusicStateInternal.State = (value ?? "none");
			}
		}

		// Token: 0x060338E2 RID: 211170 RVA: 0x00E6FDA2 File Offset: 0x00E6DFA2
		public void CreateInstanceData()
		{
			this.ClearInstanceData();
			this.InstanceData = RoverlikeInstanceData.Create();
		}

		// Token: 0x060338E3 RID: 211171 RVA: 0x00E6FDB5 File Offset: 0x00E6DFB5
		public void ClearInstanceData()
		{
			if (this.InstanceData != null)
			{
				this.InstanceData.Clear();
				this.InstanceData = null;
			}
			this.ClearActionData();
			this.ClearFloatText();
		}

		// Token: 0x060338E4 RID: 211172 RVA: 0x00E6FDDD File Offset: 0x00E6DFDD
		public int GetMainRoleId()
		{
			if (WorldLevelModel.Instance.Sex != 1)
			{
				return 5053001;
			}
			return 5053002;
		}

		// Token: 0x060338E5 RID: 211173 RVA: 0x00E6FDF8 File Offset: 0x00E6DFF8
		public int GetCurrency(int configId)
		{
			int result;
			if (!this.CurrencyCountMap.TryGetValue(configId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x170064B2 RID: 25778
		// (get) Token: 0x060338E6 RID: 211174 RVA: 0x00E6FE18 File Offset: 0x00E6E018
		public int? GoldItemId
		{
			get
			{
				RoverlikeActivityController instance = RoverlikeActivityController.Instance;
				RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
				if (roverlikeActivityData == null)
				{
					return null;
				}
				return new int?(roverlikeActivityData.GetParamConfig().Value.InsideCurrencyItemId);
			}
		}

		// Token: 0x170064B3 RID: 25779
		// (get) Token: 0x060338E7 RID: 211175 RVA: 0x00E6FE60 File Offset: 0x00E6E060
		public int Gold
		{
			get
			{
				if (this.GoldItemId == null)
				{
					return 0;
				}
				int result;
				if (!this.CurrencyCountMap.TryGetValue(this.GoldItemId.Value, out result))
				{
					return 0;
				}
				return result;
			}
		}

		// Token: 0x060338E8 RID: 211176 RVA: 0x00E6FEA0 File Offset: 0x00E6E0A0
		public void UpdateCurrency([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<RoverRogueItemCurrencyData> itemData)
		{
			foreach (RoverRogueItemCurrencyData roverRogueItemCurrencyData in (itemData ?? new List<RoverRogueItemCurrencyData>()))
			{
				this.UpdateCurrencyByItemId(roverRogueItemCurrencyData.ItemId, roverRogueItemCurrencyData.Count);
			}
		}

		// Token: 0x060338E9 RID: 211177 RVA: 0x00E6FEFC File Offset: 0x00E6E0FC
		public void UpdateCurrencyByItemId(int itemId, int count)
		{
			this.CurrencyCountMap[itemId] = count;
			EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, itemId);
		}

		// Token: 0x060338EA RID: 211178 RVA: 0x00E6FF1C File Offset: 0x00E6E11C
		public void SetCurrentRunRoleTypeId(int roleTypeId)
		{
			this.CurrentRunRoleTypeId = roleTypeId;
		}

		// Token: 0x060338EB RID: 211179 RVA: 0x00E6FF25 File Offset: 0x00E6E125
		public void SaveLastPassRoleTypeId()
		{
			if (this.CurrentRunRoleTypeId <= 0)
			{
				return;
			}
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RoverRogueLastPassRoleType, this.CurrentRunRoleTypeId);
		}

		// Token: 0x060338EC RID: 211180 RVA: 0x00E6FF42 File Offset: 0x00E6E142
		public int GetLastPassRoleTypeId()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RoverRogueLastPassRoleType, 0);
		}

		// Token: 0x060338ED RID: 211181 RVA: 0x00E6FF4F File Offset: 0x00E6E14F
		public void CreateActionData()
		{
			this.ClearActionData();
			this.ActionData = new RoverlikeActionData();
			this.ActionSubViewManager = new RoverlikeActionSubViewManager();
			this.ActionStack = new RoverlikeActionStack();
		}

		// Token: 0x060338EE RID: 211182 RVA: 0x00E6FF78 File Offset: 0x00E6E178
		public void ClearActionData()
		{
			if (this.ActionData != null)
			{
				this.ActionData.Clear();
				this.ActionData = null;
			}
			if (this.ActionSubViewManager != null)
			{
				this.ActionSubViewManager.Dispose();
				this.ActionSubViewManager = null;
			}
			if (this.ActionStack != null)
			{
				this.ActionStack.Clear();
				this.ActionStack = null;
			}
		}

		// Token: 0x170064B4 RID: 25780
		// (get) Token: 0x060338EF RID: 211183 RVA: 0x00E6FFD3 File Offset: 0x00E6E1D3
		public bool NeedOpenMainView
		{
			get
			{
				bool hasNewSettle = this.HasNewSettle;
				this.HasNewSettle = false;
				return hasNewSettle;
			}
		}

		// Token: 0x060338F0 RID: 211184 RVA: 0x00E6FFE2 File Offset: 0x00E6E1E2
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060338F1 RID: 211185 RVA: 0x00E6FFE5 File Offset: 0x00E6E1E5
		protected override bool OnClear()
		{
			this.ClearInstanceData();
			return true;
		}

		// Token: 0x060338F2 RID: 211186 RVA: 0x00E6FFF0 File Offset: 0x00E6E1F0
		public void EnqueueFloatText(List<IRoverlikeFloatTextData> list)
		{
			foreach (IRoverlikeFloatTextData item in list)
			{
				this.FloatTextQueue.Add(item);
			}
		}

		// Token: 0x170064B5 RID: 25781
		// (get) Token: 0x060338F3 RID: 211187 RVA: 0x00E70044 File Offset: 0x00E6E244
		public bool IsFloatTextEmpty
		{
			get
			{
				return this.FloatTextQueue.Count <= 0;
			}
		}

		// Token: 0x060338F4 RID: 211188 RVA: 0x00E70057 File Offset: 0x00E6E257
		[NullableContext(2)]
		public IRoverlikeFloatTextData ShiftFloatText()
		{
			if (this.FloatTextQueue.Count <= 0)
			{
				return null;
			}
			IRoverlikeFloatTextData result = this.FloatTextQueue[0];
			this.FloatTextQueue.RemoveAt(0);
			return result;
		}

		// Token: 0x060338F5 RID: 211189 RVA: 0x00E70081 File Offset: 0x00E6E281
		public void ClearFloatText()
		{
			this.FloatTextQueue.Clear();
		}

		// Token: 0x060338F6 RID: 211190 RVA: 0x00E7008E File Offset: 0x00E6E28E
		public void UpdateReviveTimes(int reviveTimes, int reviveTimesMax)
		{
			this.ReviveTimes = reviveTimes;
			this.ReviveTimesMax = reviveTimesMax;
		}

		// Token: 0x060338F7 RID: 211191 RVA: 0x00E7009E File Offset: 0x00E6E29E
		public bool ConsumeReviveTimes()
		{
			if (this.ReviveTimes > 0)
			{
				this.ReviveTimes--;
				return true;
			}
			return false;
		}

		// Token: 0x060338F8 RID: 211192 RVA: 0x00E700BA File Offset: 0x00E6E2BA
		public bool HasReviveTimes()
		{
			return this.ReviveTimes > 0;
		}

		// Token: 0x060338F9 RID: 211193 RVA: 0x00E700C5 File Offset: 0x00E6E2C5
		public int GetReviveTimes()
		{
			return this.ReviveTimes;
		}

		// Token: 0x060338FA RID: 211194 RVA: 0x00E700CD File Offset: 0x00E6E2CD
		public int GetReviveTimesMax()
		{
			return this.ReviveTimesMax;
		}

		// Token: 0x170064B6 RID: 25782
		// (get) Token: 0x060338FB RID: 211195 RVA: 0x00E700D5 File Offset: 0x00E6E2D5
		public static RoverlikeModel Instance
		{
			get
			{
				return RoverlikeModel._Instance;
			}
		}

		// Token: 0x060338FC RID: 211196 RVA: 0x00E700DC File Offset: 0x00E6E2DC
		public static RoverlikeModel GetOrCreateInstance()
		{
			if (RoverlikeModel._Instance == null)
			{
				RoverlikeModel.CreateInstance();
			}
			return RoverlikeModel._Instance;
		}

		// Token: 0x060338FD RID: 211197 RVA: 0x00E700F0 File Offset: 0x00E6E2F0
		public static bool CreateInstance()
		{
			if (RoverlikeModel._Instance != null)
			{
				return true;
			}
			RoverlikeModel._Instance = new RoverlikeModel();
			return true;
		}

		// Token: 0x060338FE RID: 211198 RVA: 0x00E70106 File Offset: 0x00E6E306
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060338FF RID: 211199 RVA: 0x00E70108 File Offset: 0x00E6E308
		public static void ResetStaticDefaultValue()
		{
			RoverlikeModel._Instance = null;
		}

		// Token: 0x06033900 RID: 211200 RVA: 0x00E70110 File Offset: 0x00E6E310
		static RoverlikeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeModel.CreateStaticDefaultValue), new Action(RoverlikeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B5E9 RID: 112105
		private readonly StateRef CurRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

		// Token: 0x0401B5EA RID: 112106
		[Nullable(2)]
		public RoverlikeInstanceData InstanceData;

		// Token: 0x0401B5EB RID: 112107
		private readonly Dictionary<int, int> CurrencyCountMap = new Dictionary<int, int>();

		// Token: 0x0401B5EC RID: 112108
		private int CurrentRunRoleTypeId;

		// Token: 0x0401B5ED RID: 112109
		[Nullable(2)]
		public RoverlikeActionData ActionData;

		// Token: 0x0401B5EE RID: 112110
		[Nullable(2)]
		public RoverlikeActionStack ActionStack;

		// Token: 0x0401B5EF RID: 112111
		[Nullable(2)]
		public RoverlikeActionSubViewManager ActionSubViewManager;

		// Token: 0x0401B5F0 RID: 112112
		public bool HasNewSettle;

		// Token: 0x0401B5F1 RID: 112113
		private readonly List<IRoverlikeFloatTextData> FloatTextQueue = new List<IRoverlikeFloatTextData>();

		// Token: 0x0401B5F2 RID: 112114
		private int ReviveTimes;

		// Token: 0x0401B5F3 RID: 112115
		private int ReviveTimesMax;

		// Token: 0x0401B5F4 RID: 112116
		[Nullable(2)]
		private static RoverlikeModel _Instance;
	}
}
