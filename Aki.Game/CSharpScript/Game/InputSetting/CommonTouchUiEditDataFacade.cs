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
	// Token: 0x0200618F RID: 24975
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTouchUiEditDataFacade : ITouchUiEditDataFacade
	{
		// Token: 0x170070DC RID: 28892
		// (get) Token: 0x0603BE92 RID: 245394 RVA: 0x01105E95 File Offset: 0x01104095
		// (set) Token: 0x0603BE93 RID: 245395 RVA: 0x01105E9D File Offset: 0x0110409D
		public int MinTouchMoveDifference { get; set; }

		// Token: 0x170070DD RID: 28893
		// (get) Token: 0x0603BE94 RID: 245396 RVA: 0x01105EA6 File Offset: 0x011040A6
		// (set) Token: 0x0603BE95 RID: 245397 RVA: 0x01105EAE File Offset: 0x011040AE
		public int MaxTouchMoveDifference { get; set; }

		// Token: 0x170070DE RID: 28894
		// (get) Token: 0x0603BE96 RID: 245398 RVA: 0x01105EB7 File Offset: 0x011040B7
		// (set) Token: 0x0603BE97 RID: 245399 RVA: 0x01105EBF File Offset: 0x011040BF
		public float MaxTouchMoveValue { get; set; }

		// Token: 0x170070DF RID: 28895
		// (get) Token: 0x0603BE98 RID: 245400 RVA: 0x01105EC8 File Offset: 0x011040C8
		// (set) Token: 0x0603BE99 RID: 245401 RVA: 0x01105ED0 File Offset: 0x011040D0
		public float MinTouchMoveValue { get; set; }

		// Token: 0x170070E0 RID: 28896
		// (get) Token: 0x0603BE9A RID: 245402 RVA: 0x01105ED9 File Offset: 0x011040D9
		// (set) Token: 0x0603BE9B RID: 245403 RVA: 0x01105EE1 File Offset: 0x011040E1
		public float ControlScaleRate { get; set; }

		// Token: 0x0603BE9C RID: 245404 RVA: 0x01105EEC File Offset: 0x011040EC
		public void Init()
		{
			this.MinTouchMoveDifference = ConfigCommonParamById.GetIntConfig("MinTouchMoveDifference").Value;
			this.MaxTouchMoveDifference = ConfigCommonParamById.GetIntConfig("MaxTouchMoveDifference").Value;
			this.MaxTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MaxTouchMoveValue").Value;
			this.MinTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MinTouchMoveValue").Value;
			this.ControlScaleRate = ConfigCommonParamById.GetFloatConfig("ControlScaleRate").Value;
			Net.Instance.Register(ENotifyMessageId.CommonUiSettingNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSettingUpdate));
		}

		// Token: 0x0603BE9D RID: 245405 RVA: 0x01105F8D File Offset: 0x0110418D
		public void Clear()
		{
			this.DataMap.Clear();
			this.DataMapFromNotify.Clear();
			this.ConfigList = null;
			Net.Instance.UnRegister(ENotifyMessageId.CommonUiSettingNotify);
		}

		// Token: 0x0603BE9E RID: 245406 RVA: 0x01105FBC File Offset: 0x011041BC
		public void SetGroup(int group)
		{
			this.Group = group;
			this.ConfigList = CommonTouchUiEditConfig.Instance.GetConfigListByEditGroup(this.Group);
			this.GroupConfig = CommonTouchUiEditConfig.Instance.GetGroupConfigById(this.Group);
		}

		// Token: 0x0603BE9F RID: 245407 RVA: 0x01105FF1 File Offset: 0x011041F1
		public CommonTouchUiEditGroup? GetGroupConfig()
		{
			return this.GroupConfig;
		}

		// Token: 0x0603BEA0 RID: 245408 RVA: 0x01105FFC File Offset: 0x011041FC
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

		// Token: 0x0603BEA1 RID: 245409 RVA: 0x011060A4 File Offset: 0x011042A4
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

		// Token: 0x0603BEA2 RID: 245410 RVA: 0x01106100 File Offset: 0x01104300
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

		// Token: 0x0603BEA3 RID: 245411 RVA: 0x01106154 File Offset: 0x01104354
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

		// Token: 0x0603BEA4 RID: 245412 RVA: 0x0110623C File Offset: 0x0110443C
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

		// Token: 0x0603BEA5 RID: 245413 RVA: 0x0110636C File Offset: 0x0110456C
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

		// Token: 0x0603BEA6 RID: 245414 RVA: 0x0110639C File Offset: 0x0110459C
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

		// Token: 0x0603BEA7 RID: 245415 RVA: 0x01106484 File Offset: 0x01104684
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

		// Token: 0x0401FABC RID: 129724
		private int Group;

		// Token: 0x0401FABD RID: 129725
		private readonly Dictionary<int, ITouchUiEditData> DataMap = new Dictionary<int, ITouchUiEditData>();

		// Token: 0x0401FABE RID: 129726
		private readonly Dictionary<string, ITouchUiEditData> DataMapFromNotify = new Dictionary<string, ITouchUiEditData>();

		// Token: 0x0401FABF RID: 129727
		[Nullable(2)]
		private IReadOnlyList<CommonTouchUiEdit> ConfigList;

		// Token: 0x0401FAC0 RID: 129728
		private CommonTouchUiEditGroup? GroupConfig;
	}
}
