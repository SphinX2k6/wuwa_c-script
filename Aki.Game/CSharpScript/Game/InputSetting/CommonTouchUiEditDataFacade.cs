using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.GenericPrompt;
using Google.Protobuf;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200700E RID: 28686
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTouchUiEditDataFacade : ITouchUiEditDataFacade
	{
		// Token: 0x17009B9C RID: 39836
		// (get) Token: 0x06045CDC RID: 285916 RVA: 0x0115BA89 File Offset: 0x01159C89
		// (set) Token: 0x06045CDD RID: 285917 RVA: 0x0115BA91 File Offset: 0x01159C91
		public int MinTouchMoveDifference { get; set; }

		// Token: 0x17009B9D RID: 39837
		// (get) Token: 0x06045CDE RID: 285918 RVA: 0x0115BA9A File Offset: 0x01159C9A
		// (set) Token: 0x06045CDF RID: 285919 RVA: 0x0115BAA2 File Offset: 0x01159CA2
		public int MaxTouchMoveDifference { get; set; }

		// Token: 0x17009B9E RID: 39838
		// (get) Token: 0x06045CE0 RID: 285920 RVA: 0x0115BAAB File Offset: 0x01159CAB
		// (set) Token: 0x06045CE1 RID: 285921 RVA: 0x0115BAB3 File Offset: 0x01159CB3
		public float MaxTouchMoveValue { get; set; }

		// Token: 0x17009B9F RID: 39839
		// (get) Token: 0x06045CE2 RID: 285922 RVA: 0x0115BABC File Offset: 0x01159CBC
		// (set) Token: 0x06045CE3 RID: 285923 RVA: 0x0115BAC4 File Offset: 0x01159CC4
		public float MinTouchMoveValue { get; set; }

		// Token: 0x17009BA0 RID: 39840
		// (get) Token: 0x06045CE4 RID: 285924 RVA: 0x0115BACD File Offset: 0x01159CCD
		// (set) Token: 0x06045CE5 RID: 285925 RVA: 0x0115BAD5 File Offset: 0x01159CD5
		public float ControlScaleRate { get; set; }

		// Token: 0x06045CE6 RID: 285926 RVA: 0x0115BAE0 File Offset: 0x01159CE0
		public void Init()
		{
			this.MinTouchMoveDifference = ConfigCommonParamById.GetIntConfig("MinTouchMoveDifference").Value;
			this.MaxTouchMoveDifference = ConfigCommonParamById.GetIntConfig("MaxTouchMoveDifference").Value;
			this.MaxTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MaxTouchMoveValue").Value;
			this.MinTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MinTouchMoveValue").Value;
			this.ControlScaleRate = ConfigCommonParamById.GetFloatConfig("ControlScaleRate").Value;
			Net.Instance.Register(ENotifyMessageId.CommonUiSettingNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSettingUpdate));
		}

		// Token: 0x06045CE7 RID: 285927 RVA: 0x0115BB81 File Offset: 0x01159D81
		public void Clear()
		{
			this.DataMap.Clear();
			this.DataMapFromNotify.Clear();
			this.ConfigList = null;
			Net.Instance.UnRegister(ENotifyMessageId.CommonUiSettingNotify);
		}

		// Token: 0x06045CE8 RID: 285928 RVA: 0x0115BBB0 File Offset: 0x01159DB0
		public void SetGroup(int group)
		{
			this.Group = group;
			this.ConfigList = CommonTouchUiEditConfig.Instance.GetConfigListByEditGroup(this.Group);
			this.GroupConfig = CommonTouchUiEditConfig.Instance.GetGroupConfigById(this.Group);
		}

		// Token: 0x06045CE9 RID: 285929 RVA: 0x0115BBE5 File Offset: 0x01159DE5
		public CommonTouchUiEditGroup? GetGroupConfig()
		{
			return this.GroupConfig;
		}

		// Token: 0x06045CEA RID: 285930 RVA: 0x0115BBF0 File Offset: 0x01159DF0
		public string[] GetResIdList()
		{
			HashSet<string> hashSet = new HashSet<string>();
			if (this.ConfigList == null)
			{
				return new string[0];
			}
			for (int i = 0; i < this.ConfigList.Count; i++)
			{
				hashSet.Add(this.ConfigList[i].PanelResId);
			}
			string[] array = new string[hashSet.Count];
			int num = 0;
			foreach (string text in hashSet)
			{
				array[num] = text;
				num++;
			}
			return array;
		}

		// Token: 0x06045CEB RID: 285931 RVA: 0x0115BC98 File Offset: 0x01159E98
		public int GetStorageId(string resId, int index)
		{
			if (this.ConfigList == null)
			{
				return 0;
			}
			for (int i = 0; i < this.ConfigList.Count; i++)
			{
				CommonTouchUiEdit commonTouchUiEdit = this.ConfigList[i];
				if (commonTouchUiEdit.PanelResId == resId && commonTouchUiEdit.ItemIndex == index)
				{
					return commonTouchUiEdit.Id;
				}
			}
			return 0;
		}

		// Token: 0x06045CEC RID: 285932 RVA: 0x0115BCF4 File Offset: 0x01159EF4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<string, int>? GetResPair(int storageId)
		{
			CommonTouchUiEdit? configById = CommonTouchUiEditConfig.Instance.GetConfigById(storageId);
			if (configById == null)
			{
				return null;
			}
			return new ValueTuple<string, int>?(new ValueTuple<string, int>(configById.Value.PanelResId, configById.Value.ItemIndex));
		}

		// Token: 0x06045CED RID: 285933 RVA: 0x0115BD48 File Offset: 0x01159F48
		[return: Nullable(2)]
		public ITouchUiEditData GetDefaultData(string resId, int index)
		{
			int storageId = this.GetStorageId(resId, index);
			if (storageId == 0)
			{
				return null;
			}
			CommonTouchUiEdit? configById = CommonTouchUiEditConfig.Instance.GetConfigById(storageId);
			if (configById == null)
			{
				return null;
			}
			return new TouchUiEditDataImpl
			{
				StorageId = storageId,
				OffsetX = configById.Value.SourceOffsetX,
				OffsetY = configById.Value.SourceOffsetY,
				Scale = configById.Value.SourceSize,
				Alpha = configById.Value.SourceAlpha,
				HierarchyIndex = configById.Value.SourceHierarchyIndex,
				Editable = configById.Value.Editable,
				DefaultSelect = configById.Value.IsDefaultSelected,
				ShouldCheckOverlap = configById.Value.IsCheckOverlap
			};
		}

		// Token: 0x06045CEE RID: 285934 RVA: 0x0115BE30 File Offset: 0x0115A030
		public void SaveData(ITouchUiEditData[] dataList)
		{
			List<MobileButtonSetting> list = new List<MobileButtonSetting>();
			foreach (ITouchUiEditData touchUiEditData in dataList)
			{
				if (touchUiEditData.StorageId != 0)
				{
					this.DataMap[touchUiEditData.StorageId] = touchUiEditData;
					list.Add(new MobileButtonSetting
					{
						Id = touchUiEditData.StorageId,
						Size = touchUiEditData.Scale,
						ScreenX = touchUiEditData.OffsetX,
						ScreenY = touchUiEditData.OffsetY,
						Transparency = touchUiEditData.Alpha,
						PanelLevel = touchUiEditData.HierarchyIndex,
						ButtonLevel = touchUiEditData.HierarchyIndex
					});
				}
			}
			CommonTouchUiSettingUpdateRequest commonTouchUiSettingUpdateRequest = CommonTouchUiSettingUpdateRequest.Create();
			MobileButtonSetting[] array = new MobileButtonSetting[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				array[j] = list[j];
			}
			commonTouchUiSettingUpdateRequest.MobileButtonSettings.AddRange(array);
			Net.Instance.Call(ERequestMessageId.CommonTouchUiSettingUpdateRequest, commonTouchUiSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				CommonTouchUiSettingUpdateResponse commonTouchUiSettingUpdateResponse = (CommonTouchUiSettingUpdateResponse)msg;
				if (ErrorCodeController.Instance.CheckErrorCode((commonTouchUiSettingUpdateResponse != null) ? new Aki.Protocol.ErrorCode?(commonTouchUiSettingUpdateResponse.ErrorCode) : null, EResponseMessageId.CommonTouchUiSettingUpdateResponse, true))
				{
					return;
				}
				this.DataMapFromNotify.Clear();
				foreach (ITouchUiEditData touchUiEditData2 in dataList)
				{
					TouchUiEditDataImpl value = new TouchUiEditDataImpl
					{
						StorageId = touchUiEditData2.StorageId,
						OffsetX = touchUiEditData2.OffsetX,
						OffsetY = touchUiEditData2.OffsetY,
						Scale = touchUiEditData2.Scale,
						Alpha = touchUiEditData2.Alpha,
						HierarchyIndex = touchUiEditData2.HierarchyIndex,
						Editable = touchUiEditData2.Editable,
						DefaultSelect = touchUiEditData2.DefaultSelect,
						ShouldCheckOverlap = touchUiEditData2.ShouldCheckOverlap
					};
					this.DataMapFromNotify[touchUiEditData2.StorageId.ToString()] = value;
				}
				BattleUiModel instance = BattleUiModel.Instance;
				bool flag;
				if (instance == null)
				{
					flag = false;
				}
				else
				{
					BattleUiPureModeData pureModeData = instance.PureModeData;
					flag = ((pureModeData != null) ? new bool?(pureModeData.IsOpen) : null).GetValueOrDefault();
				}
				if (flag)
				{
					GenericPromptController.Instance.ShowPromptByCode("SaveButtonPureMode", Array.Empty<object>());
					return;
				}
				GenericPromptController.Instance.ShowPromptByCode("SaveButton", Array.Empty<object>());
			}, 0);
		}

		// Token: 0x06045CEF RID: 285935 RVA: 0x0115BF60 File Offset: 0x0115A160
		[return: Nullable(2)]
		public ITouchUiEditData GetData(string resId, int index)
		{
			int storageId = this.GetStorageId(resId, index);
			ITouchUiEditData result;
			if (this.DataMap.TryGetValue(storageId, out result))
			{
				return result;
			}
			return this.GetDefaultData(resId, index);
		}

		// Token: 0x06045CF0 RID: 285936 RVA: 0x0115BF90 File Offset: 0x0115A190
		public void ResetEditData()
		{
			this.DataMap.Clear();
			foreach (ITouchUiEditData touchUiEditData in this.DataMapFromNotify.Values)
			{
				TouchUiEditDataImpl touchUiEditDataImpl = new TouchUiEditDataImpl();
				touchUiEditDataImpl.StorageId = touchUiEditData.StorageId;
				touchUiEditDataImpl.OffsetX = touchUiEditData.OffsetX;
				touchUiEditDataImpl.OffsetY = touchUiEditData.OffsetY;
				touchUiEditDataImpl.Scale = touchUiEditData.Scale;
				touchUiEditDataImpl.Alpha = touchUiEditData.Alpha;
				touchUiEditDataImpl.HierarchyIndex = touchUiEditData.HierarchyIndex;
				touchUiEditDataImpl.Editable = touchUiEditData.Editable;
				touchUiEditDataImpl.DefaultSelect = touchUiEditData.DefaultSelect;
				touchUiEditDataImpl.ShouldCheckOverlap = touchUiEditData.ShouldCheckOverlap;
				this.DataMap[touchUiEditData.StorageId] = touchUiEditDataImpl;
			}
		}

		// Token: 0x06045CF1 RID: 285937 RVA: 0x0115C078 File Offset: 0x0115A278
		[NullableContext(2)]
		private void OnSettingUpdate(IMessage msg, Net.CallbackStatus _)
		{
			CommonUiSettingNotify commonUiSettingNotify = (CommonUiSettingNotify)msg;
			if (commonUiSettingNotify.CommonUiButtonSetting == null)
			{
				return;
			}
			this.DataMap.Clear();
			this.DataMapFromNotify.Clear();
			for (int i = 0; i < commonUiSettingNotify.CommonUiButtonSetting.Count; i++)
			{
				MobileButtonSetting mobileButtonSetting = commonUiSettingNotify.CommonUiButtonSetting[i];
				int id = mobileButtonSetting.Id;
				CommonTouchUiEdit? configById = CommonTouchUiEditConfig.Instance.GetConfigById(id);
				ITouchUiEditData value = new TouchUiEditDataImpl
				{
					StorageId = id,
					OffsetX = mobileButtonSetting.ScreenX,
					OffsetY = mobileButtonSetting.ScreenY,
					Scale = mobileButtonSetting.Size,
					Alpha = mobileButtonSetting.Transparency,
					HierarchyIndex = mobileButtonSetting.ButtonLevel,
					Editable = configById.Value.Editable,
					DefaultSelect = configById.Value.IsDefaultSelected,
					ShouldCheckOverlap = configById.Value.IsCheckOverlap
				};
				this.DataMap[id] = value;
				this.DataMapFromNotify[mobileButtonSetting.Id.ToString()] = value;
			}
		}

		// Token: 0x04024806 RID: 149510
		private int Group;

		// Token: 0x04024807 RID: 149511
		private readonly Dictionary<int, ITouchUiEditData> DataMap = new Dictionary<int, ITouchUiEditData>();

		// Token: 0x04024808 RID: 149512
		private readonly Dictionary<string, ITouchUiEditData> DataMapFromNotify = new Dictionary<string, ITouchUiEditData>();

		// Token: 0x04024809 RID: 149513
		[Nullable(2)]
		private IReadOnlyList<CommonTouchUiEdit> ConfigList;

		// Token: 0x0402480A RID: 149514
		private CommonTouchUiEditGroup? GroupConfig;
	}
}
