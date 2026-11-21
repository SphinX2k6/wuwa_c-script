using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020012AF RID: 4783
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class HandBookController : UiControllerBase
{
	// Token: 0x0600BD8D RID: 48525 RVA: 0x0037F867 File Offset: 0x0037DA67
	public void SetPhantomMeshShow(int id, SkeletalObserverHandle skeletalObserverHandle)
	{
	}

	// Token: 0x0600BD8E RID: 48526 RVA: 0x0037F869 File Offset: 0x0037DA69
	public void SetWeaponMeshShow(int id, SkeletalObserverHandle observerHandle)
	{
	}

	// Token: 0x0600BD8F RID: 48527 RVA: 0x0037F86B File Offset: 0x0037DA6B
	public void SetMonsterMeshShow(int id, SkeletalObserverHandle skeletalObserverHandle)
	{
	}

	// Token: 0x0600BD90 RID: 48528 RVA: 0x0037F86D File Offset: 0x0037DA6D
	public void SetAnimalMeshShow(int id, SkeletalObserverHandle skeletalObserverHandle)
	{
	}

	// Token: 0x0600BD91 RID: 48529 RVA: 0x0037F870 File Offset: 0x0037DA70
	public void ClearEffect()
	{
		if (this.CommonEffect != 0)
		{
			EffectSystem.Instance.StopEffectById(this.CommonEffect, "[HandBookController.ClearEffect] StopEffect", false, null);
			this.CommonEffect = 0;
		}
	}

	// Token: 0x0600BD92 RID: 48530 RVA: 0x0037F8AC File Offset: 0x0037DAAC
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

	// Token: 0x0600BD93 RID: 48531 RVA: 0x0037F8CC File Offset: 0x0037DACC
	private void ShowUnlockTips(IllustratedType type, IllustratedEntry entry)
	{
		string text = "";
		if (type == IllustratedType.Photograph)
		{
			text = (ConfigMultiTextLang.GetLocalTextNew(HandBookConfig.Instance.GetPlotHandBookConfig(entry.Id).Value.Name, null) ?? "");
		}
		int length = text.Length;
	}

	// Token: 0x0600BD94 RID: 48532 RVA: 0x0037F91C File Offset: 0x0037DB1C
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

	// Token: 0x0600BD95 RID: 48533 RVA: 0x0037FA4C File Offset: 0x0037DC4C
	public UniTask SendIllustratedRedDotRequest()
	{
		HandBookController.<SendIllustratedRedDotRequest>d__10 <SendIllustratedRedDotRequest>d__;
		<SendIllustratedRedDotRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendIllustratedRedDotRequest>d__.<>1__state = -1;
		<SendIllustratedRedDotRequest>d__.<>t__builder.Start<HandBookController.<SendIllustratedRedDotRequest>d__10>(ref <SendIllustratedRedDotRequest>d__);
		return <SendIllustratedRedDotRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600BD96 RID: 48534 RVA: 0x0037FA88 File Offset: 0x0037DC88
	public UniTask SendIllustratedInfoRequestAsync(List<EHandBookTabType> typeList)
	{
		HandBookController.<SendIllustratedInfoRequestAsync>d__11 <SendIllustratedInfoRequestAsync>d__;
		<SendIllustratedInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendIllustratedInfoRequestAsync>d__.typeList = typeList;
		<SendIllustratedInfoRequestAsync>d__.<>1__state = -1;
		<SendIllustratedInfoRequestAsync>d__.<>t__builder.Start<HandBookController.<SendIllustratedInfoRequestAsync>d__11>(ref <SendIllustratedInfoRequestAsync>d__);
		return <SendIllustratedInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BD97 RID: 48535 RVA: 0x0037FACC File Offset: 0x0037DCCC
	public UniTask SendIllustratedInfoRequest(List<EHandBookTabType> typeList)
	{
		HandBookController.<SendIllustratedInfoRequest>d__12 <SendIllustratedInfoRequest>d__;
		<SendIllustratedInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendIllustratedInfoRequest>d__.typeList = typeList;
		<SendIllustratedInfoRequest>d__.<>1__state = -1;
		<SendIllustratedInfoRequest>d__.<>t__builder.Start<HandBookController.<SendIllustratedInfoRequest>d__12>(ref <SendIllustratedInfoRequest>d__);
		return <SendIllustratedInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600BD98 RID: 48536 RVA: 0x0037FB10 File Offset: 0x0037DD10
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(illustratedReadResponse.ErrorCode, 27163, illustratedReadResponse.ErrorParams, true, true);
				return;
			}
			HandBookModel.Instance.UpdateRedDot(type, request.Id);
		}, 0);
	}

	// Token: 0x0600BD99 RID: 48537 RVA: 0x0037FB80 File Offset: 0x0037DD80
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(illustratedUnlockResponse.ErrorCode, 20078, illustratedUnlockResponse.ErrorParams, true, true);
			}
		}, 0);
	}

	// Token: 0x0600BD9A RID: 48538 RVA: 0x0037FBDC File Offset: 0x0037DDDC
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

	// Token: 0x0600BD9B RID: 48539 RVA: 0x0037FC68 File Offset: 0x0037DE68
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

	// Token: 0x0600BD9C RID: 48540 RVA: 0x0037FDA0 File Offset: 0x0037DFA0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.PlayerSenseTargetEnter, new Action<int>(this.EnterLogicRange));
	}

	// Token: 0x0600BD9D RID: 48541 RVA: 0x0037FDBE File Offset: 0x0037DFBE
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.PlayerSenseTargetEnter, new Action<int>(this.EnterLogicRange));
	}

	// Token: 0x0600BD9E RID: 48542 RVA: 0x0037FDDC File Offset: 0x0037DFDC
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

	// Token: 0x0600BD9F RID: 48543 RVA: 0x0037FE28 File Offset: 0x0037E028
	private bool IsAnimalLock(int modelId)
	{
		AnimalHandBook? animalHandBookConfigByMeshId = HandBookConfig.Instance.GetAnimalHandBookConfigByMeshId(modelId);
		return animalHandBookConfigByMeshId != null && HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Animal, animalHandBookConfigByMeshId.Value.Id) == null;
	}

	// Token: 0x0600BDA0 RID: 48544 RVA: 0x0037FE6C File Offset: 0x0037E06C
	public UniTask RoleIllustratedInfoRequest()
	{
		HandBookController.<RoleIllustratedInfoRequest>d__21 <RoleIllustratedInfoRequest>d__;
		<RoleIllustratedInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RoleIllustratedInfoRequest>d__.<>1__state = -1;
		<RoleIllustratedInfoRequest>d__.<>t__builder.Start<HandBookController.<RoleIllustratedInfoRequest>d__21>(ref <RoleIllustratedInfoRequest>d__);
		return <RoleIllustratedInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600BDA1 RID: 48545 RVA: 0x0037FEA8 File Offset: 0x0037E0A8
	public void ShowPanoramicPointUnlockTips(GeographyHandBook config)
	{
		PanoramicPointUnlockTipsParam param = new PanoramicPointUnlockTipsParam
		{
			ConfigId = config.Id
		};
		UiManager.Instance.OpenView(EUiViewName.PanoramicPointUnlockTipsView, param, null);
	}

	// Token: 0x170012AB RID: 4779
	// (get) Token: 0x0600BDA2 RID: 48546 RVA: 0x0037FED9 File Offset: 0x0037E0D9
	public static HandBookController Instance
	{
		get
		{
			return HandBookController._Instance;
		}
	}

	// Token: 0x0600BDA3 RID: 48547 RVA: 0x0037FEE0 File Offset: 0x0037E0E0
	public static HandBookController GetOrCreateInstance()
	{
		if (HandBookController._Instance == null)
		{
			HandBookController.CreateInstance();
		}
		return HandBookController._Instance;
	}

	// Token: 0x0600BDA4 RID: 48548 RVA: 0x0037FEF4 File Offset: 0x0037E0F4
	public static bool CreateInstance()
	{
		if (HandBookController._Instance != null)
		{
			return true;
		}
		HandBookController._Instance = new HandBookController();
		return true;
	}

	// Token: 0x0600BDA5 RID: 48549 RVA: 0x0037FF0A File Offset: 0x0037E10A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BDA6 RID: 48550 RVA: 0x0037FF0C File Offset: 0x0037E10C
	public static void ResetStaticDefaultValue()
	{
		HandBookController._Instance = null;
	}

	// Token: 0x0600BDA7 RID: 48551 RVA: 0x0037FF14 File Offset: 0x0037E114
	static HandBookController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookController.CreateStaticDefaultValue), new Action(HandBookController.ResetStaticDefaultValue));
	}

	// Token: 0x04006CF8 RID: 27896
	private int CommonEffect;

	// Token: 0x04006CF9 RID: 27897
	private readonly Dictionary<EHandBookTabType, int> CollectProgressMaxMap = new Dictionary<EHandBookTabType, int>();

	// Token: 0x04006CFA RID: 27898
	[Nullable(2)]
	private static HandBookController _Instance;
}
