using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02004E46 RID: 20038
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BattleUiSetModel : ModelBase
	{
		// Token: 0x0603264D RID: 206413 RVA: 0x00E22104 File Offset: 0x00E20304
		protected override bool OnInit()
		{
			for (int i = 0; i < 9; i++)
			{
				IEnumerable<MobileBattleUiSet> mobileBattleUiSetConfigList = BattleUiSetConfig.GetMobileBattleUiSetConfigList(i);
				List<BattleUiSetPanelItemData> list = new List<BattleUiSetPanelItemData>();
				foreach (MobileBattleUiSet mobileBattleUiSet in mobileBattleUiSetConfigList)
				{
					int id = mobileBattleUiSet.Id;
					BattleUiSetPanelItemData battleUiSetPanelItemData = new BattleUiSetPanelItemData(mobileBattleUiSet.ItemIndex, ref mobileBattleUiSet);
					list.Add(battleUiSetPanelItemData);
					this.PanelItemDataMap[id] = battleUiSetPanelItemData;
				}
				BattleUiSetPanelData value = new BattleUiSetPanelData(i, list.ToArray());
				this.PanelDataMap[i] = value;
			}
			this.MinTouchMoveDifference = (float)ConfigCommonParamById.GetIntConfig("MinTouchMoveDifference").Value;
			this.MaxTouchMoveDifference = (float)ConfigCommonParamById.GetIntConfig("MaxTouchMoveDifference").Value;
			this.MaxTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MaxTouchMoveValue").Value;
			this.MinTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MinTouchMoveValue").Value;
			this.ControlScaleRate = ConfigCommonParamById.GetFloatConfig("ControlScaleRate").Value;
			return true;
		}

		// Token: 0x0603264E RID: 206414 RVA: 0x00E2222C File Offset: 0x00E2042C
		protected override bool OnClear()
		{
			this.PanelDataMap.Clear();
			this.PanelItemDataMap.Clear();
			this.SelectedPanelItemData = null;
			return true;
		}

		// Token: 0x0603264F RID: 206415 RVA: 0x00E2224C File Offset: 0x00E2044C
		public IReadOnlyDictionary<int, BattleUiSetPanelData> GetPanelDataMap()
		{
			return this.PanelDataMap;
		}

		// Token: 0x06032650 RID: 206416 RVA: 0x00E22254 File Offset: 0x00E20454
		public IReadOnlyDictionary<int, BattleUiSetPanelItemData> GetPanelItemDataMap()
		{
			return this.PanelItemDataMap;
		}

		// Token: 0x06032651 RID: 206417 RVA: 0x00E2225C File Offset: 0x00E2045C
		[NullableContext(2)]
		public BattleUiSetPanelItemData GetPanelItemDataByConfigId(int configId)
		{
			return this.PanelItemDataMap.GetValueOrDefault(configId);
		}

		// Token: 0x06032652 RID: 206418 RVA: 0x00E2226A File Offset: 0x00E2046A
		[NullableContext(2)]
		public void SetPanelItemSelected(BattleUiSetPanelItemData panelItemData)
		{
			if (panelItemData == null)
			{
				return;
			}
			if (!panelItemData.CanEdit)
			{
				return;
			}
			this.SelectedPanelItemData = panelItemData;
			EventSystem.Instance.Emit<BattleUiSetPanelItemData>(EEventName.OnSelectedEditPanelItem, this.SelectedPanelItemData);
		}

		// Token: 0x06032653 RID: 206419 RVA: 0x00E22298 File Offset: 0x00E20498
		public void ResetSettings()
		{
			foreach (BattleUiSetPanelItemData battleUiSetPanelItemData in this.GetPanelItemDataMap().Values)
			{
				battleUiSetPanelItemData.EditSize = battleUiSetPanelItemData.SourceSize;
				battleUiSetPanelItemData.EditAlpha = battleUiSetPanelItemData.SourceAlpha;
				battleUiSetPanelItemData.EditOffsetX = battleUiSetPanelItemData.SourceOffsetX;
				battleUiSetPanelItemData.EditOffsetY = battleUiSetPanelItemData.SourceOffsetY;
				battleUiSetPanelItemData.EditorHierarchyIndex = battleUiSetPanelItemData.SourceHierarchyIndex;
			}
		}

		// Token: 0x06032654 RID: 206420 RVA: 0x00E22320 File Offset: 0x00E20520
		public void SaveSettings()
		{
			IReadOnlyDictionary<int, BattleUiSetPanelItemData> panelItemDataMap = this.GetPanelItemDataMap();
			List<MobileButtonSetting> list = new List<MobileButtonSetting>();
			foreach (BattleUiSetPanelItemData battleUiSetPanelItemData in panelItemDataMap.Values)
			{
				float editSize = battleUiSetPanelItemData.EditSize;
				float editAlpha = battleUiSetPanelItemData.EditAlpha;
				float editOffsetX = battleUiSetPanelItemData.EditOffsetX;
				float editOffsetY = battleUiSetPanelItemData.EditOffsetY;
				int editorHierarchyIndex = battleUiSetPanelItemData.EditorHierarchyIndex;
				MobileButtonSetting item = new MobileButtonSetting
				{
					Id = battleUiSetPanelItemData.ConfigId,
					Size = editSize,
					Transparency = editAlpha,
					ScreenX = editOffsetX,
					ScreenY = editOffsetY,
					ButtonLevel = editorHierarchyIndex,
					PanelLevel = 0
				};
				battleUiSetPanelItemData.Size = editSize;
				battleUiSetPanelItemData.Alpha = editAlpha;
				battleUiSetPanelItemData.OffsetX = editOffsetX;
				battleUiSetPanelItemData.OffsetY = editOffsetY;
				battleUiSetPanelItemData.HierarchyIndex = editorHierarchyIndex;
				list.Add(item);
			}
			BattleUiSetController.MobileButtonSettingUpdateRequest(list);
		}

		// Token: 0x06032655 RID: 206421 RVA: 0x00E22414 File Offset: 0x00E20614
		public void ReInitSettings()
		{
			foreach (BattleUiSetPanelItemData battleUiSetPanelItemData in this.GetPanelItemDataMap().Values)
			{
				battleUiSetPanelItemData.ReInit();
			}
		}

		// Token: 0x06032656 RID: 206422 RVA: 0x00E22464 File Offset: 0x00E20664
		public void AddTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			this.TouchFingerDataMap[fingerIndex] = touchFingerData;
		}

		// Token: 0x06032657 RID: 206423 RVA: 0x00E22488 File Offset: 0x00E20688
		public void RemoveTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			this.TouchFingerDataMap.Remove(fingerIndex);
		}

		// Token: 0x06032658 RID: 206424 RVA: 0x00E224A9 File Offset: 0x00E206A9
		public int GetTouchFingerDataCount()
		{
			return this.TouchFingerDataMap.Count;
		}

		// Token: 0x06032659 RID: 206425 RVA: 0x00E224B6 File Offset: 0x00E206B6
		[NullableContext(2)]
		public TouchFingerData GetTouchFingerData(EFingerIndex fingerIndex)
		{
			return this.TouchFingerDataMap.GetValueOrDefault(fingerIndex);
		}

		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x0603265A RID: 206426 RVA: 0x00E224C4 File Offset: 0x00E206C4
		public static BattleUiSetModel Instance
		{
			get
			{
				return BattleUiSetModel._Instance;
			}
		}

		// Token: 0x0603265B RID: 206427 RVA: 0x00E224CB File Offset: 0x00E206CB
		public static BattleUiSetModel GetOrCreateInstance()
		{
			if (BattleUiSetModel._Instance == null)
			{
				BattleUiSetModel.CreateInstance();
			}
			return BattleUiSetModel._Instance;
		}

		// Token: 0x0603265C RID: 206428 RVA: 0x00E224DF File Offset: 0x00E206DF
		public static bool CreateInstance()
		{
			if (BattleUiSetModel._Instance != null)
			{
				return true;
			}
			BattleUiSetModel._Instance = new BattleUiSetModel();
			return true;
		}

		// Token: 0x0603265D RID: 206429 RVA: 0x00E224F5 File Offset: 0x00E206F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603265E RID: 206430 RVA: 0x00E224F7 File Offset: 0x00E206F7
		public static void ResetStaticDefaultValue()
		{
			BattleUiSetModel._Instance = null;
		}

		// Token: 0x0603265F RID: 206431 RVA: 0x00E224FF File Offset: 0x00E206FF
		static BattleUiSetModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiSetModel.CreateStaticDefaultValue), new Action(BattleUiSetModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB97 RID: 109463
		private readonly Dictionary<int, BattleUiSetPanelData> PanelDataMap = new Dictionary<int, BattleUiSetPanelData>();

		// Token: 0x0401AB98 RID: 109464
		private readonly Dictionary<int, BattleUiSetPanelItemData> PanelItemDataMap = new Dictionary<int, BattleUiSetPanelItemData>();

		// Token: 0x0401AB99 RID: 109465
		[Nullable(2)]
		public BattleUiSetPanelItemData SelectedPanelItemData;

		// Token: 0x0401AB9A RID: 109466
		private readonly Dictionary<EFingerIndex, TouchFingerData> TouchFingerDataMap = new Dictionary<EFingerIndex, TouchFingerData>();

		// Token: 0x0401AB9B RID: 109467
		public float MinTouchMoveDifference;

		// Token: 0x0401AB9C RID: 109468
		public float MaxTouchMoveDifference;

		// Token: 0x0401AB9D RID: 109469
		public float MaxTouchMoveValue;

		// Token: 0x0401AB9E RID: 109470
		public float MinTouchMoveValue;

		// Token: 0x0401AB9F RID: 109471
		public float ControlScaleRate;

		// Token: 0x0401ABA0 RID: 109472
		[Nullable(2)]
		private static BattleUiSetModel _Instance;
	}
}
