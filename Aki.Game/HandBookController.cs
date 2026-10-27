using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001DED RID: 7661
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class HandBookController : UiControllerBase
{
	// Token: 0x0600E96E RID: 59758 RVA: 0x00373B5F File Offset: 0x00371D5F
	public void SetPhantomMeshShow(int id, SkeletalObserverHandle skeletalObserverHandle)
	{
	}

	// Token: 0x0600E96F RID: 59759 RVA: 0x00373B61 File Offset: 0x00371D61
	public void SetWeaponMeshShow(int id, SkeletalObserverHandle observerHandle)
	{
	}

	// Token: 0x0600E970 RID: 59760 RVA: 0x00373B63 File Offset: 0x00371D63
	public void SetMonsterMeshShow(int id, SkeletalObserverHandle skeletalObserverHandle)
	{
	}

	// Token: 0x0600E971 RID: 59761 RVA: 0x00373B65 File Offset: 0x00371D65
	public void SetAnimalMeshShow(int id, SkeletalObserverHandle skeletalObserverHandle)
	{
	}

	// Token: 0x0600E972 RID: 59762 RVA: 0x00373B68 File Offset: 0x00371D68
	public void ClearEffect()
	{
		if (this.CommonEffect != 0)
		{
			EffectSystem.Instance.StopEffectById(this.CommonEffect, "[HandBookController.ClearEffect] StopEffect", false, null);
			this.CommonEffect = 0;
		}
	}

	// Token: 0x0600E973 RID: 59763 RVA: 0x00373BA4 File Offset: 0x00371DA4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.IllustratedUnlockNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			IllustratedUnlockNotify illustratedUnlockNotify = (IllustratedUnlockNotify)msg;
			HandBookModel.Instance.UpdateHandBookActiveStateMap(illustratedUnlockNotify.Type, illustratedUnlockNotify.Entry);
			if (illustratedUnlockNotify.IsNew)
			{
				this.ShowUnlockTips(illustratedUnlockNotify.Type, illustratedUnlockNotify.Entry);
				if (illustratedUnlockNotify.Type == HandBookModel.Instance.GetServerHandBookType(EHandBookTabType.Geography))
				{
					GeographyHandBook? geographyHandBookConfig = HandBookConfig.Instance.GetGeographyHandBookConfig(illustratedUnlockNotify.Entry.Id);
					if (geographyHandBookConfig != null && geographyHandBookConfig.GetValueOrDefault().GeographyTabType == 2)
					{
						this.ShowPanoramicPointUnlockTips(geographyHandBookConfig.Value);
						return;
					}
					this.ShowGeographyPhoto(geographyHandBookConfig.Value);
				}
			}
		});
	}

	// Token: 0x0600E974 RID: 59764 RVA: 0x00373BC4 File Offset: 0x00371DC4
	private void ShowUnlockTips(IllustratedType type, IllustratedEntry entry)
	{
		string text = "";
		if (type == IllustratedType.Photograph)
		{
			text = (ConfigMultiTextLang.GetLocalTextNew(HandBookConfig.Instance.GetPlotHandBookConfig(entry.Id).Value.Name, null) ?? "");
		}
		int length = text.Length;
	}

	// Token: 0x0600E975 RID: 59765 RVA: 0x00373C14 File Offset: 0x00371E14
	private void ShowGeographyPhoto(GeographyHandBook config)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		list.Add(config.Texture);
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Geography, config.Id);
		list5.Add(handBookInfo.CreateTime);
		list2.Add(ConfigMultiTextLang.GetLocalTextNew(config.Descrtption, null));
		list3.Add(ConfigMultiTextLang.GetLocalTextNew(config.Name, null));
		list4.Add(ConfigMultiTextLang.GetLocalTextNew(HandBookConfig.Instance.GetGeographyTypeConfig(config.Type).Value.TypeDescription, null));
		HandBookPhotoData handBookPhotoData = new HandBookPhotoData();
		handBookPhotoData.DescrtptionText = list2;
		handBookPhotoData.TypeText = list4;
		handBookPhotoData.NameText = list3;
		handBookPhotoData.HandBookType = EHandBookTabType.Geography;
		handBookPhotoData.Index = 0;
		handBookPhotoData.TextureList = list;
		handBookPhotoData.DateText = list5;
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = false,
			IsHiddenBattleView = false,
			HandBookPhotoData = handBookPhotoData,
			GachaData = null,
			ShareId = 2
		};
		UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
	}

	// Token: 0x0600E976 RID: 59766 RVA: 0x00373D44 File Offset: 0x00371F44
	public UniTask SendIllustratedRedDotRequest()
	{
		HandBookController.<SendIllustratedRedDotRequest>d__10 <SendIllustratedRedDotRequest>d__;
		<SendIllustratedRedDotRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendIllustratedRedDotRequest>d__.<>1__state = -1;
		<SendIllustratedRedDotRequest>d__.<>t__builder.Start<HandBookController.<SendIllustratedRedDotRequest>d__10>(ref <SendIllustratedRedDotRequest>d__);
		return <SendIllustratedRedDotRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600E977 RID: 59767 RVA: 0x00373D80 File Offset: 0x00371F80
	public UniTask SendIllustratedInfoRequestAsync(List<EHandBookTabType> typeList)
	{
		HandBookController.<SendIllustratedInfoRequestAsync>d__11 <SendIllustratedInfoRequestAsync>d__;
		<SendIllustratedInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendIllustratedInfoRequestAsync>d__.typeList = typeList;
		<SendIllustratedInfoRequestAsync>d__.<>1__state = -1;
		<SendIllustratedInfoRequestAsync>d__.<>t__builder.Start<HandBookController.<SendIllustratedInfoRequestAsync>d__11>(ref <SendIllustratedInfoRequestAsync>d__);
		return <SendIllustratedInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E978 RID: 59768 RVA: 0x00373DC4 File Offset: 0x00371FC4
	public UniTask SendIllustratedInfoRequest(List<EHandBookTabType> typeList)
	{
		HandBookController.<SendIllustratedInfoRequest>d__12 <SendIllustratedInfoRequest>d__;
		<SendIllustratedInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendIllustratedInfoRequest>d__.typeList = typeList;
		<SendIllustratedInfoRequest>d__.<>1__state = -1;
		<SendIllustratedInfoRequest>d__.<>t__builder.Start<HandBookController.<SendIllustratedInfoRequest>d__12>(ref <SendIllustratedInfoRequest>d__);
		return <SendIllustratedInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600E979 RID: 59769 RVA: 0x00373E08 File Offset: 0x00372008
	public void SendIllustratedReadRequest(EHandBookTabType type, int id)
	{
		IllustratedReadRequest request = IllustratedReadRequest.Create();
		request.Type = HandBookModel.Instance.GetServerHandBookType(type);
		request.Id = id;
		Net.Instance.Call(ERequestMessageId.IllustratedReadRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
		{
			IllustratedReadResponse illustratedReadResponse = (IllustratedReadResponse)msg;
			if (illustratedReadResponse == null)
			{
				return;
			}
			if (illustratedReadResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(illustratedReadResponse.ErrorCode, 20958, illustratedReadResponse.ErrorParams.ToArray<string>(), true, true);
				return;
			}
			HandBookModel.Instance.UpdateRedDot(type, request.Id);
		}, 0);
	}

	// Token: 0x0600E97A RID: 59770 RVA: 0x00373E78 File Offset: 0x00372078
	public void SendIllustratedUnlockRequest(EHandBookTabType type, int id)
	{
		IllustratedUnlockRequest illustratedUnlockRequest = IllustratedUnlockRequest.Create();
		illustratedUnlockRequest.Type = HandBookModel.Instance.GetServerHandBookType(type);
		illustratedUnlockRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.IllustratedUnlockRequest, illustratedUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			IllustratedUnlockResponse illustratedUnlockResponse = (IllustratedUnlockResponse)msg;
			if (illustratedUnlockResponse == null)
			{
				return;
			}
			if (illustratedUnlockResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(illustratedUnlockResponse.ErrorCode, 18471, illustratedUnlockResponse.ErrorParams.ToArray<string>(), true, true);
			}
		}, 0);
	}

	// Token: 0x0600E97B RID: 59771 RVA: 0x00373ED4 File Offset: 0x003720D4
	public int[] GetCollectProgress(EHandBookTabType type)
	{
		if (type == EHandBookTabType.Quest)
		{
			return HandBookModel.Instance.GetQuestCount();
		}
		if (type == EHandBookTabType.Role)
		{
			return HandBookModel.Instance.GetRoleHandBookCount();
		}
		if (type == EHandBookTabType.Monster)
		{
			return HandBookModel.Instance.GetMonsterCount();
		}
		if (type == EHandBookTabType.Weapon)
		{
			int num = HandBookModel.Instance.GetAllHandBookWeaponIdList().Length + HandBookModel.Instance.GetAllHandBookWeaponSkinIdList().Length;
			return new int[]
			{
				num,
				num
			};
		}
		int collectCount = HandBookModel.Instance.GetCollectCount(type);
		int collectProgressMax = this.GetCollectProgressMax(type);
		return new int[]
		{
			collectCount,
			collectProgressMax
		};
	}

	// Token: 0x0600E97C RID: 59772 RVA: 0x00373F60 File Offset: 0x00372160
	public int GetCollectProgressMax(EHandBookTabType type)
	{
		int num;
		if (this.CollectProgressMaxMap.TryGetValue(type, out num) && num != 0)
		{
			return num;
		}
		switch (type)
		{
		case EHandBookTabType.Monster:
		{
			IEnumerable<MonsterHandBook> enumerable = HandBookConfig.Instance.GetMonsterHandBookConfigList() ?? new List<MonsterHandBook>();
			num = 0;
			using (IEnumerator<MonsterHandBook> enumerator = enumerable.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MonsterHandBook monsterHandBook = enumerator.Current;
					if (!monsterHandBook.IsSkin && monsterHandBook.OriginalFormInfoId <= 0)
					{
						num++;
					}
				}
				goto IL_10D;
			}
			break;
		}
		case EHandBookTabType.Phantom:
			break;
		case EHandBookTabType.Geography:
			num = HandBookConfig.Instance.GetAllGeographyHandBookConfig().Count;
			goto IL_10D;
		case EHandBookTabType.Weapon:
		case EHandBookTabType.Quest:
		case EHandBookTabType.RoleQuest:
		case EHandBookTabType.MainQuest:
		case EHandBookTabType.Role:
			return 0;
		case EHandBookTabType.Animal:
			num = HandBookConfig.Instance.GetAnimalHandBookConfigList().Count;
			goto IL_10D;
		case EHandBookTabType.Item:
			num = HandBookConfig.Instance.GetItemHandBookConfigList().Count;
			goto IL_10D;
		case EHandBookTabType.Chip:
			num = HandBookConfig.Instance.GetAllChipHandBookConfig().Count;
			goto IL_10D;
		case EHandBookTabType.Noun:
			num = HandBookConfig.Instance.GetNounTypeConfigAll().Count;
			goto IL_10D;
		default:
			return 0;
		}
		num = HandBookConfig.Instance.GetPhantomHandBookConfig().Count;
		IL_10D:
		this.CollectProgressMaxMap[type] = num;
		return num;
	}

	// Token: 0x0600E97D RID: 59773 RVA: 0x00374098 File Offset: 0x00372298
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.PlayerSenseTargetEnter, new Action<int>(this.EnterLogicRange));
	}

	// Token: 0x0600E97E RID: 59774 RVA: 0x003740B6 File Offset: 0x003722B6
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.PlayerSenseTargetEnter, new Action<int>(this.EnterLogicRange));
	}

	// Token: 0x0600E97F RID: 59775 RVA: 0x003740D4 File Offset: 0x003722D4
	private void EnterLogicRange(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		if (component.GetEntityType() != EEntityType.Animal)
		{
			return;
		}
		int modelId = component.GetModelId();
		if (!this.IsAnimalLock(modelId))
		{
			return;
		}
		this.SendIllustratedUnlockRequest(EHandBookTabType.Animal, modelId);
	}

	// Token: 0x0600E980 RID: 59776 RVA: 0x00374120 File Offset: 0x00372320
	private bool IsAnimalLock(int modelId)
	{
		AnimalHandBook? animalHandBookConfigByMeshId = HandBookConfig.Instance.GetAnimalHandBookConfigByMeshId(modelId);
		return animalHandBookConfigByMeshId != null && HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Animal, animalHandBookConfigByMeshId.Value.Id) == null;
	}

	// Token: 0x0600E981 RID: 59777 RVA: 0x00374164 File Offset: 0x00372364
	public UniTask RoleIllustratedInfoRequest()
	{
		HandBookController.<RoleIllustratedInfoRequest>d__21 <RoleIllustratedInfoRequest>d__;
		<RoleIllustratedInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RoleIllustratedInfoRequest>d__.<>1__state = -1;
		<RoleIllustratedInfoRequest>d__.<>t__builder.Start<HandBookController.<RoleIllustratedInfoRequest>d__21>(ref <RoleIllustratedInfoRequest>d__);
		return <RoleIllustratedInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600E982 RID: 59778 RVA: 0x003741A0 File Offset: 0x003723A0
	public void ShowPanoramicPointUnlockTips(GeographyHandBook config)
	{
		PanoramicPointUnlockTipsParam param = new PanoramicPointUnlockTipsParam
		{
			ConfigId = config.Id
		};
		UiManager.Instance.OpenView(EUiViewName.PanoramicPointUnlockTipsView, param, null);
	}

	// Token: 0x17001281 RID: 4737
	// (get) Token: 0x0600E983 RID: 59779 RVA: 0x003741D1 File Offset: 0x003723D1
	public static HandBookController Instance
	{
		get
		{
			return HandBookController._Instance;
		}
	}

	// Token: 0x0600E984 RID: 59780 RVA: 0x003741D8 File Offset: 0x003723D8
	public static HandBookController GetOrCreateInstance()
	{
		if (HandBookController._Instance == null)
		{
			HandBookController.CreateInstance();
		}
		return HandBookController._Instance;
	}

	// Token: 0x0600E985 RID: 59781 RVA: 0x003741EC File Offset: 0x003723EC
	public static bool CreateInstance()
	{
		if (HandBookController._Instance != null)
		{
			return true;
		}
		HandBookController._Instance = new HandBookController();
		return true;
	}

	// Token: 0x0600E986 RID: 59782 RVA: 0x00374202 File Offset: 0x00372402
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E987 RID: 59783 RVA: 0x00374204 File Offset: 0x00372404
	public static void ResetStaticDefaultValue()
	{
		HandBookController._Instance = null;
	}

	// Token: 0x0600E988 RID: 59784 RVA: 0x0037420C File Offset: 0x0037240C
	static HandBookController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookController.CreateStaticDefaultValue), new Action(HandBookController.ResetStaticDefaultValue));
	}

	// Token: 0x04006C17 RID: 27671
	private int CommonEffect;

	// Token: 0x04006C18 RID: 27672
	private readonly Dictionary<EHandBookTabType, int> CollectProgressMaxMap = new Dictionary<EHandBookTabType, int>();

	// Token: 0x04006C19 RID: 27673
	[Nullable(2)]
	private static HandBookController _Instance;
}
