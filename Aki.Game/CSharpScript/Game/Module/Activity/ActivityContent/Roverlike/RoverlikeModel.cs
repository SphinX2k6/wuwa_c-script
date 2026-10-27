using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F2 RID: 24818
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RoverlikeModel : ModelBase
	{
		// Token: 0x1700914F RID: 37199
		// (get) Token: 0x0603EC1E RID: 257054 RVA: 0x00F28F6A File Offset: 0x00F2716A
		// (set) Token: 0x0603EC1F RID: 257055 RVA: 0x00F28F77 File Offset: 0x00F27177
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

		// Token: 0x0603EC20 RID: 257056 RVA: 0x00F28F8E File Offset: 0x00F2718E
		public void CreateInstanceData()
		{
			this.ClearInstanceData();
			this.InstanceData = RoverlikeInstanceData.Create();
		}

		// Token: 0x0603EC21 RID: 257057 RVA: 0x00F28FA1 File Offset: 0x00F271A1
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

		// Token: 0x0603EC22 RID: 257058 RVA: 0x00F28FC9 File Offset: 0x00F271C9
		public int GetMainRoleId()
		{
			if (WorldLevelModel.Instance.Sex != 1)
			{
				return 5053001;
			}
			return 5053002;
		}

		// Token: 0x0603EC23 RID: 257059 RVA: 0x00F28FE4 File Offset: 0x00F271E4
		public int GetCurrency(int configId)
		{
			int result;
			if (!this.CurrencyCountMap.TryGetValue(configId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x17009150 RID: 37200
		// (get) Token: 0x0603EC24 RID: 257060 RVA: 0x00F29004 File Offset: 0x00F27204
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

		// Token: 0x17009151 RID: 37201
		// (get) Token: 0x0603EC25 RID: 257061 RVA: 0x00F2904C File Offset: 0x00F2724C
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

		// Token: 0x0603EC26 RID: 257062 RVA: 0x00F2908C File Offset: 0x00F2728C
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

		// Token: 0x0603EC27 RID: 257063 RVA: 0x00F290E8 File Offset: 0x00F272E8
		public void UpdateCurrencyByItemId(int itemId, int count)
		{
			this.CurrencyCountMap[itemId] = count;
			EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, itemId);
		}

		// Token: 0x0603EC28 RID: 257064 RVA: 0x00F29108 File Offset: 0x00F27308
		public void SetCurrentRunRoleTypeId(int roleTypeId)
		{
			this.CurrentRunRoleTypeId = roleTypeId;
		}

		// Token: 0x0603EC29 RID: 257065 RVA: 0x00F29111 File Offset: 0x00F27311
		public void SaveLastPassRoleTypeId()
		{
			if (this.CurrentRunRoleTypeId <= 0)
			{
				return;
			}
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RoverRogueLastPassRoleType, this.CurrentRunRoleTypeId);
		}

		// Token: 0x0603EC2A RID: 257066 RVA: 0x00F2912E File Offset: 0x00F2732E
		public int GetLastPassRoleTypeId()
		{
			return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RoverRogueLastPassRoleType, 0);
		}

		// Token: 0x0603EC2B RID: 257067 RVA: 0x00F2913B File Offset: 0x00F2733B
		public void CreateActionData()
		{
			this.ClearActionData();
			this.ActionData = new RoverlikeActionData();
			this.ActionSubViewManager = new RoverlikeActionSubViewManager();
			this.ActionStack = new RoverlikeActionStack();
		}

		// Token: 0x0603EC2C RID: 257068 RVA: 0x00F29164 File Offset: 0x00F27364
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

		// Token: 0x17009152 RID: 37202
		// (get) Token: 0x0603EC2D RID: 257069 RVA: 0x00F291BF File Offset: 0x00F273BF
		public bool NeedOpenMainView
		{
			get
			{
				bool hasNewSettle = this.HasNewSettle;
				this.HasNewSettle = false;
				return hasNewSettle;
			}
		}

		// Token: 0x0603EC2E RID: 257070 RVA: 0x00F291CE File Offset: 0x00F273CE
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603EC2F RID: 257071 RVA: 0x00F291D1 File Offset: 0x00F273D1
		protected override bool OnClear()
		{
			this.ClearInstanceData();
			return true;
		}

		// Token: 0x0603EC30 RID: 257072 RVA: 0x00F291DC File Offset: 0x00F273DC
		public void EnqueueFloatText(List<IRoverlikeFloatTextData> list)
		{
			foreach (IRoverlikeFloatTextData item in list)
			{
				this.FloatTextQueue.Add(item);
			}
		}

		// Token: 0x17009153 RID: 37203
		// (get) Token: 0x0603EC31 RID: 257073 RVA: 0x00F29230 File Offset: 0x00F27430
		public bool IsFloatTextEmpty
		{
			get
			{
				return this.FloatTextQueue.Count <= 0;
			}
		}

		// Token: 0x0603EC32 RID: 257074 RVA: 0x00F29243 File Offset: 0x00F27443
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

		// Token: 0x0603EC33 RID: 257075 RVA: 0x00F2926D File Offset: 0x00F2746D
		public void ClearFloatText()
		{
			this.FloatTextQueue.Clear();
		}

		// Token: 0x0603EC34 RID: 257076 RVA: 0x00F2927A File Offset: 0x00F2747A
		public void UpdateReviveTimes(int reviveTimes, int reviveTimesMax)
		{
			this.ReviveTimes = reviveTimes;
			this.ReviveTimesMax = reviveTimesMax;
		}

		// Token: 0x0603EC35 RID: 257077 RVA: 0x00F2928A File Offset: 0x00F2748A
		public bool ConsumeReviveTimes()
		{
			if (this.ReviveTimes > 0)
			{
				this.ReviveTimes--;
				return true;
			}
			return false;
		}

		// Token: 0x0603EC36 RID: 257078 RVA: 0x00F292A6 File Offset: 0x00F274A6
		public bool HasReviveTimes()
		{
			return this.ReviveTimes > 0;
		}

		// Token: 0x0603EC37 RID: 257079 RVA: 0x00F292B1 File Offset: 0x00F274B1
		public int GetReviveTimes()
		{
			return this.ReviveTimes;
		}

		// Token: 0x0603EC38 RID: 257080 RVA: 0x00F292B9 File Offset: 0x00F274B9
		public int GetReviveTimesMax()
		{
			return this.ReviveTimesMax;
		}

		// Token: 0x17009154 RID: 37204
		// (get) Token: 0x0603EC39 RID: 257081 RVA: 0x00F292C1 File Offset: 0x00F274C1
		public static RoverlikeModel Instance
		{
			get
			{
				return RoverlikeModel._Instance;
			}
		}

		// Token: 0x0603EC3A RID: 257082 RVA: 0x00F292C8 File Offset: 0x00F274C8
		public static RoverlikeModel GetOrCreateInstance()
		{
			if (RoverlikeModel._Instance == null)
			{
				RoverlikeModel.CreateInstance();
			}
			return RoverlikeModel._Instance;
		}

		// Token: 0x0603EC3B RID: 257083 RVA: 0x00F292DC File Offset: 0x00F274DC
		public static bool CreateInstance()
		{
			if (RoverlikeModel._Instance != null)
			{
				return true;
			}
			RoverlikeModel._Instance = new RoverlikeModel();
			return true;
		}

		// Token: 0x0603EC3C RID: 257084 RVA: 0x00F292F2 File Offset: 0x00F274F2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603EC3D RID: 257085 RVA: 0x00F292F4 File Offset: 0x00F274F4
		public static void ResetStaticDefaultValue()
		{
			RoverlikeModel._Instance = null;
		}

		// Token: 0x0603EC3E RID: 257086 RVA: 0x00F292FC File Offset: 0x00F274FC
		static RoverlikeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeModel.CreateStaticDefaultValue), new Action(RoverlikeModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020CBC RID: 134332
		private readonly StateRef CurRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

		// Token: 0x04020CBD RID: 134333
		[Nullable(2)]
		public RoverlikeInstanceData InstanceData;

		// Token: 0x04020CBE RID: 134334
		private readonly Dictionary<int, int> CurrencyCountMap = new Dictionary<int, int>();

		// Token: 0x04020CBF RID: 134335
		private int CurrentRunRoleTypeId;

		// Token: 0x04020CC0 RID: 134336
		[Nullable(2)]
		public RoverlikeActionData ActionData;

		// Token: 0x04020CC1 RID: 134337
		[Nullable(2)]
		public RoverlikeActionStack ActionStack;

		// Token: 0x04020CC2 RID: 134338
		[Nullable(2)]
		public RoverlikeActionSubViewManager ActionSubViewManager;

		// Token: 0x04020CC3 RID: 134339
		public bool HasNewSettle;

		// Token: 0x04020CC4 RID: 134340
		private readonly List<IRoverlikeFloatTextData> FloatTextQueue = new List<IRoverlikeFloatTextData>();

		// Token: 0x04020CC5 RID: 134341
		private int ReviveTimes;

		// Token: 0x04020CC6 RID: 134342
		private int ReviveTimesMax;

		// Token: 0x04020CC7 RID: 134343
		[Nullable(2)]
		private static RoverlikeModel _Instance;
	}
}
