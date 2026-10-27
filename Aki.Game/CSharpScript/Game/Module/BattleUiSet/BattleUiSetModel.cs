using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02005E61 RID: 24161
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BattleUiSetModel : ModelBase
	{
		// Token: 0x0603D6BD RID: 251581 RVA: 0x00ED0B94 File Offset: 0x00ECED94
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

		// Token: 0x0603D6BE RID: 251582 RVA: 0x00ED0CBC File Offset: 0x00ECEEBC
		protected override bool OnClear()
		{
			this.PanelDataMap.Clear();
			this.PanelItemDataMap.Clear();
			this.SelectedPanelItemData = null;
			return true;
		}

		// Token: 0x0603D6BF RID: 251583 RVA: 0x00ED0CDC File Offset: 0x00ECEEDC
		public IReadOnlyDictionary<int, BattleUiSetPanelData> GetPanelDataMap()
		{
			return this.PanelDataMap;
		}

		// Token: 0x0603D6C0 RID: 251584 RVA: 0x00ED0CE4 File Offset: 0x00ECEEE4
		public IReadOnlyDictionary<int, BattleUiSetPanelItemData> GetPanelItemDataMap()
		{
			return this.PanelItemDataMap;
		}

		// Token: 0x0603D6C1 RID: 251585 RVA: 0x00ED0CEC File Offset: 0x00ECEEEC
		[NullableContext(2)]
		public BattleUiSetPanelItemData GetPanelItemDataByConfigId(int configId)
		{
			return this.PanelItemDataMap.GetValueOrDefault(configId);
		}

		// Token: 0x0603D6C2 RID: 251586 RVA: 0x00ED0CFA File Offset: 0x00ECEEFA
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

		// Token: 0x0603D6C3 RID: 251587 RVA: 0x00ED0D28 File Offset: 0x00ECEF28
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

		// Token: 0x0603D6C4 RID: 251588 RVA: 0x00ED0DB0 File Offset: 0x00ECEFB0
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

		// Token: 0x0603D6C5 RID: 251589 RVA: 0x00ED0EA4 File Offset: 0x00ECF0A4
		public void ReInitSettings()
		{
			foreach (BattleUiSetPanelItemData battleUiSetPanelItemData in this.GetPanelItemDataMap().Values)
			{
				battleUiSetPanelItemData.ReInit();
			}
		}

		// Token: 0x0603D6C6 RID: 251590 RVA: 0x00ED0EF4 File Offset: 0x00ECF0F4
		public void AddTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			this.TouchFingerDataMap[fingerIndex] = touchFingerData;
		}

		// Token: 0x0603D6C7 RID: 251591 RVA: 0x00ED0F18 File Offset: 0x00ECF118
		public void RemoveTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			this.TouchFingerDataMap.Remove(fingerIndex);
		}

		// Token: 0x0603D6C8 RID: 251592 RVA: 0x00ED0F39 File Offset: 0x00ECF139
		public int GetTouchFingerDataCount()
		{
			return this.TouchFingerDataMap.Count;
		}

		// Token: 0x0603D6C9 RID: 251593 RVA: 0x00ED0F46 File Offset: 0x00ECF146
		[NullableContext(2)]
		public TouchFingerData GetTouchFingerData(EFingerIndex fingerIndex)
		{
			return this.TouchFingerDataMap.GetValueOrDefault(fingerIndex);
		}

		// Token: 0x17008E76 RID: 36470
		// (get) Token: 0x0603D6CA RID: 251594 RVA: 0x00ED0F54 File Offset: 0x00ECF154
		public static BattleUiSetModel Instance
		{
			get
			{
				return BattleUiSetModel._Instance;
			}
		}

		// Token: 0x0603D6CB RID: 251595 RVA: 0x00ED0F5B File Offset: 0x00ECF15B
		public static BattleUiSetModel GetOrCreateInstance()
		{
			if (BattleUiSetModel._Instance == null)
			{
				BattleUiSetModel.CreateInstance();
			}
			return BattleUiSetModel._Instance;
		}

		// Token: 0x0603D6CC RID: 251596 RVA: 0x00ED0F6F File Offset: 0x00ECF16F
		public static bool CreateInstance()
		{
			if (BattleUiSetModel._Instance != null)
			{
				return true;
			}
			BattleUiSetModel._Instance = new BattleUiSetModel();
			return true;
		}

		// Token: 0x0603D6CD RID: 251597 RVA: 0x00ED0F85 File Offset: 0x00ECF185
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D6CE RID: 251598 RVA: 0x00ED0F87 File Offset: 0x00ECF187
		public static void ResetStaticDefaultValue()
		{
			BattleUiSetModel._Instance = null;
		}

		// Token: 0x0603D6CF RID: 251599 RVA: 0x00ED0F8F File Offset: 0x00ECF18F
		static BattleUiSetModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiSetModel.CreateStaticDefaultValue), new Action(BattleUiSetModel.ResetStaticDefaultValue));
		}

		// Token: 0x040200D0 RID: 131280
		private readonly Dictionary<int, BattleUiSetPanelData> PanelDataMap = new Dictionary<int, BattleUiSetPanelData>();

		// Token: 0x040200D1 RID: 131281
		private readonly Dictionary<int, BattleUiSetPanelItemData> PanelItemDataMap = new Dictionary<int, BattleUiSetPanelItemData>();

		// Token: 0x040200D2 RID: 131282
		[Nullable(2)]
		public BattleUiSetPanelItemData SelectedPanelItemData;

		// Token: 0x040200D3 RID: 131283
		private readonly Dictionary<EFingerIndex, TouchFingerData> TouchFingerDataMap = new Dictionary<EFingerIndex, TouchFingerData>();

		// Token: 0x040200D4 RID: 131284
		public float MinTouchMoveDifference;

		// Token: 0x040200D5 RID: 131285
		public float MaxTouchMoveDifference;

		// Token: 0x040200D6 RID: 131286
		public float MaxTouchMoveValue;

		// Token: 0x040200D7 RID: 131287
		public float MinTouchMoveValue;

		// Token: 0x040200D8 RID: 131288
		public float ControlScaleRate;

		// Token: 0x040200D9 RID: 131289
		[Nullable(2)]
		private static BattleUiSetModel _Instance;
	}
}
