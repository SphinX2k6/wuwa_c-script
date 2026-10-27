using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C91 RID: 7313
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GachaModel : ModelBase
{
	// Token: 0x0600DCB2 RID: 56498 RVA: 0x0033801C File Offset: 0x0033621C
	public bool IsLimit(ProtoGachaInfo gachaInfo)
	{
		return gachaInfo.BeginTime != 0.0 || gachaInfo.EndTime != 0.0;
	}

	// Token: 0x0600DCB3 RID: 56499 RVA: 0x00338048 File Offset: 0x00336248
	public bool IsValid(ProtoGachaInfo gachaInfo)
	{
		if (!this.IsLimit(gachaInfo))
		{
			return true;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= gachaInfo.BeginTime && (serverTime < gachaInfo.EndTime || gachaInfo.EndTime == 0.0);
	}

	// Token: 0x0600DCB4 RID: 56500 RVA: 0x00338094 File Offset: 0x00336294
	[NullableContext(2)]
	public ICommonShowRoleInfo GetCachedGachaInfo()
	{
		if (this.CachedGachaInfo != null && this.CachedGachaInfo.Length != 0)
		{
			ICommonShowRoleInfo result = this.CachedGachaInfo[0];
			ICommonShowRoleInfo[] array = new ICommonShowRoleInfo[this.CachedGachaInfo.Length - 1];
			for (int i = 1; i < this.CachedGachaInfo.Length; i++)
			{
				array[i - 1] = this.CachedGachaInfo[i];
			}
			this.CachedGachaInfo = array;
			return result;
		}
		return null;
	}

	// Token: 0x0600DCB5 RID: 56501 RVA: 0x003380F8 File Offset: 0x003362F8
	public void CacheGachaInfo(ICommonShowRoleInfo info)
	{
		if (this.CachedGachaInfo == null)
		{
			this.CachedGachaInfo = new ICommonShowRoleInfo[]
			{
				info
			};
			return;
		}
		ICommonShowRoleInfo[] array = new ICommonShowRoleInfo[this.CachedGachaInfo.Length + 1];
		for (int i = 0; i < this.CachedGachaInfo.Length; i++)
		{
			array[i] = this.CachedGachaInfo[i];
		}
		array[this.CachedGachaInfo.Length] = info;
		this.CachedGachaInfo = array;
	}

	// Token: 0x170011EE RID: 4590
	// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x0033815E File Offset: 0x0033635E
	// (set) Token: 0x0600DCB7 RID: 56503 RVA: 0x00338166 File Offset: 0x00336366
	public string RecordId
	{
		get
		{
			return this.RecordIdInternal;
		}
		set
		{
			this.RecordIdInternal = value;
		}
	}

	// Token: 0x170011EF RID: 4591
	// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x0033816F File Offset: 0x0033636F
	// (set) Token: 0x0600DCB9 RID: 56505 RVA: 0x00338177 File Offset: 0x00336377
	public bool CanCloseView
	{
		get
		{
			return this.CanCloseViewInternal;
		}
		set
		{
			this.CanCloseViewInternal = value;
		}
	}

	// Token: 0x170011F0 RID: 4592
	// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x00338180 File Offset: 0x00336380
	// (set) Token: 0x0600DCBB RID: 56507 RVA: 0x00338188 File Offset: 0x00336388
	public int TodayResultCount
	{
		get
		{
			return this.TodayResultCountInternal;
		}
		set
		{
			this.TodayResultCountInternal = value;
		}
	}

	// Token: 0x170011F1 RID: 4593
	// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x00338191 File Offset: 0x00336391
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ProtoGachaInfo[] GachaInfoArray
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.GachaInfoArrayInternal;
		}
	}

	// Token: 0x170011F2 RID: 4594
	// (get) Token: 0x0600DCBD RID: 56509 RVA: 0x00338199 File Offset: 0x00336399
	// (set) Token: 0x0600DCBE RID: 56510 RVA: 0x003381A1 File Offset: 0x003363A1
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public global::GachaResult[] CurGachaResult
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.CurGachaResultInternal;
		}
		[param: Nullable(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.SetCurGachaResult(value);
		}
	}

	// Token: 0x0600DCBF RID: 56511 RVA: 0x003381AC File Offset: 0x003363AC
	public void SetCurGachaResult([Nullable(new byte[]
	{
		2,
		1
	})] global::GachaResult[] result)
	{
		this.CurGachaResultInternal = result;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		if (this.CurGachaResultInternal != null)
		{
			foreach (global::GachaResult gachaResult in this.CurGachaResultInternal)
			{
				int? num;
				if (gachaResult == null)
				{
					num = null;
				}
				else
				{
					GachaReward proto_GachaReward = gachaResult.Proto_GachaReward;
					num = ((proto_GachaReward != null) ? new int?(proto_GachaReward.ItemId) : null);
				}
				int? num2 = num;
				int? num3;
				if (gachaResult == null)
				{
					num3 = null;
				}
				else
				{
					GachaReward proto_GachaReward2 = gachaResult.Proto_GachaReward;
					num3 = ((proto_GachaReward2 != null) ? new int?(proto_GachaReward2.ItemCount) : null);
				}
				int? num4 = num3;
				if (num2 != null && num4 != null)
				{
					dictionary[num2.Value] = (dictionary.ContainsKey(num2.Value) ? dictionary[num2.Value] : 0) + num4.Value;
				}
			}
			foreach (global::GachaResult gachaResult2 in this.CurGachaResultInternal)
			{
				int? num5;
				if (gachaResult2 == null)
				{
					num5 = null;
				}
				else
				{
					GachaReward proto_GachaReward3 = gachaResult2.Proto_GachaReward;
					num5 = ((proto_GachaReward3 != null) ? new int?(proto_GachaReward3.ItemId) : null);
				}
				int? num6 = num5;
				if (num6 != null)
				{
					RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(num6.Value);
					if (roleInfoById != null)
					{
						gachaResult2.IsNew = GachaController.Instance.IsNewRole(roleInfoById.Value.Id);
					}
					else
					{
						int[] array = LocalStorage.GetPlayer<int[]>(ELocalStoragePlayerKey.GachaWeaponRecord, null) ?? new int[0];
						bool flag = false;
						int[] array2 = array;
						for (int j = 0; j < array2.Length; j++)
						{
							if (array2[j] == num6.Value)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							gachaResult2.IsNew = true;
							int[] array3 = new int[array.Length + 1];
							for (int k = 0; k < array.Length; k++)
							{
								array3[k] = array[k];
							}
							array3[array.Length] = num6.Value;
							LocalStorage.SetPlayer<int[]>(ELocalStoragePlayerKey.GachaWeaponRecord, array3);
						}
						else
						{
							gachaResult2.IsNew = false;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600DCC0 RID: 56512 RVA: 0x003383D4 File Offset: 0x003365D4
	[return: Nullable(2)]
	public ProtoGachaInfo GetGachaInfoByResourceId(string resourceId)
	{
		if (this.GachaInfoArrayInternal != null)
		{
			foreach (ProtoGachaInfo protoGachaInfo in this.GachaInfoArrayInternal)
			{
				if (protoGachaInfo.ResourcesId == resourceId)
				{
					return protoGachaInfo;
				}
			}
		}
		return null;
	}

	// Token: 0x0600DCC1 RID: 56513 RVA: 0x00338414 File Offset: 0x00336614
	public bool IsAllDiscountUsedUp(ProtoGachaInfo info)
	{
		if (info.GachaDiscountInfos.Length == 0)
		{
			return true;
		}
		foreach (GachaDiscountInfo gachaDiscountInfo in info.GachaDiscountInfos)
		{
			if (gachaDiscountInfo.UsedTimes < gachaDiscountInfo.LimitTimes)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600DCC2 RID: 56514 RVA: 0x00338458 File Offset: 0x00336658
	public EffectiveGachaButtonInfo[] GetEffectiveGachaButtons(ProtoGachaInfo info)
	{
		List<EffectiveGachaButtonInfo> list = new List<EffectiveGachaButtonInfo>();
		bool flag = this.IsAllDiscountUsedUp(info);
		if (info.GachaConsumes == null)
		{
			return list.ToArray();
		}
		foreach (GachaConsume gachaConsume in info.GachaConsumes)
		{
			int times = gachaConsume.Times;
			int consume = gachaConsume.Consume;
			GachaDiscountInfo gachaDiscountInfo = null;
			foreach (GachaDiscountInfo gachaDiscountInfo2 in info.GachaDiscountInfos)
			{
				if (gachaDiscountInfo2.Times == times)
				{
					gachaDiscountInfo = gachaDiscountInfo2;
					break;
				}
			}
			bool flag2 = gachaDiscountInfo != null && gachaDiscountInfo.UsedTimes < gachaDiscountInfo.LimitTimes;
			string tagCustomText;
			info.DiscountTagDetails.TryGetValue(times, out tagCustomText);
			if (flag2)
			{
				list.Add(EffectiveGachaButtonInfo.MakeDiscount(times, gachaDiscountInfo.DiscountConsume, consume, tagCustomText));
			}
			else if (!info.OnlyViewDiscount || flag)
			{
				list.Add(EffectiveGachaButtonInfo.MakePlain(times, consume, null));
			}
		}
		list.Any((EffectiveGachaButtonInfo button) => button.IsDiscount);
		return list.ToArray();
	}

	// Token: 0x0600DCC3 RID: 56515 RVA: 0x00338570 File Offset: 0x00336770
	[return: Nullable(2)]
	public GachaTagInfo GetSelectPoolButtonTag(ProtoGachaInfo info)
	{
		EffectiveGachaButtonInfo[] effectiveGachaButtons = this.GetEffectiveGachaButtons(info);
		EffectiveGachaButtonInfo effectiveGachaButtonInfo = null;
		EffectiveGachaButtonInfo effectiveGachaButtonInfo2 = null;
		foreach (EffectiveGachaButtonInfo effectiveGachaButtonInfo3 in effectiveGachaButtons)
		{
			if (effectiveGachaButtonInfo3.Times == 10)
			{
				effectiveGachaButtonInfo = effectiveGachaButtonInfo3;
			}
			else if (effectiveGachaButtonInfo3.Times == 1)
			{
				effectiveGachaButtonInfo2 = effectiveGachaButtonInfo3;
			}
		}
		GachaTagInfo result;
		if ((result = ((effectiveGachaButtonInfo != null) ? effectiveGachaButtonInfo.GetCustomTag() : null)) == null && (result = ((effectiveGachaButtonInfo2 != null) ? effectiveGachaButtonInfo2.GetCustomTag() : null)) == null && (result = ((effectiveGachaButtonInfo != null) ? effectiveGachaButtonInfo.GetDiscountTag() : null)) == null)
		{
			if (effectiveGachaButtonInfo2 == null)
			{
				return null;
			}
			result = effectiveGachaButtonInfo2.GetDiscountTag();
		}
		return result;
	}

	// Token: 0x0600DCC4 RID: 56516 RVA: 0x003385F4 File Offset: 0x003367F4
	protected override bool OnInit()
	{
		this.CachedGachaInfo = new ICommonShowRoleInfo[0];
		return true;
	}

	// Token: 0x0600DCC5 RID: 56517 RVA: 0x00338604 File Offset: 0x00336804
	protected override bool OnClear()
	{
		this.CanCloseView = true;
		this.GachaInfoArrayInternal = null;
		this.CurGachaResultInternal = null;
		this.GachaPoolOpenRecord = null;
		this.GachaPoolSet = null;
		if (this.CachedGachaInfo != null)
		{
			this.CachedGachaInfo = new ICommonShowRoleInfo[0];
		}
		this.CachedGachaInfo = null;
		return true;
	}

	// Token: 0x0600DCC6 RID: 56518 RVA: 0x00338650 File Offset: 0x00336850
	public void InitGachaInfoMap(GachaInfo[] gachaInfoArray)
	{
		this.GachaInfoArrayInternal = new ProtoGachaInfo[gachaInfoArray.Length];
		for (int i = 0; i < gachaInfoArray.Length; i++)
		{
			this.GachaInfoArrayInternal[i] = new ProtoGachaInfo(gachaInfoArray[i]);
		}
		for (int j = 0; j < this.GachaInfoArrayInternal.Length - 1; j++)
		{
			for (int k = 0; k < this.GachaInfoArrayInternal.Length - 1 - j; k++)
			{
				if (this.GachaInfoArrayInternal[k].Sort > this.GachaInfoArrayInternal[k + 1].Sort)
				{
					ProtoGachaInfo protoGachaInfo = this.GachaInfoArrayInternal[k];
					this.GachaInfoArrayInternal[k] = this.GachaInfoArrayInternal[k + 1];
					this.GachaInfoArrayInternal[k + 1] = protoGachaInfo;
				}
			}
		}
	}

	// Token: 0x0600DCC7 RID: 56519 RVA: 0x003386F9 File Offset: 0x003368F9
	public bool CheckGachaValid(ProtoGachaInfo gachaInfo)
	{
		return this.IsValid(gachaInfo);
	}

	// Token: 0x0600DCC8 RID: 56520 RVA: 0x00338704 File Offset: 0x00336904
	public bool CheckGachaValidByGachaId(int gachaId)
	{
		ProtoGachaInfo gachaInfo = this.GetGachaInfo(gachaId);
		return gachaInfo != null && this.CheckGachaValid(gachaInfo);
	}

	// Token: 0x0600DCC9 RID: 56521 RVA: 0x00338728 File Offset: 0x00336928
	public GachaPoolData[] GetValidGachaList()
	{
		List<GachaPoolData> list = new List<GachaPoolData>();
		if (GachaModel.Instance.GachaInfoArray != null)
		{
			foreach (ProtoGachaInfo protoGachaInfo in GachaModel.Instance.GachaInfoArray)
			{
				if (GachaModel.Instance.CheckGachaValid(protoGachaInfo))
				{
					int usePoolId = protoGachaInfo.UsePoolId;
					ProtoGachaPoolInfo protoGachaPoolInfo = (usePoolId > 0) ? protoGachaInfo.GetPoolInfo(usePoolId) : protoGachaInfo.GetFirstValidPool();
					if (protoGachaPoolInfo != null)
					{
						list.Add(new GachaPoolData(protoGachaInfo, protoGachaPoolInfo));
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600DCCA RID: 56522 RVA: 0x003387A8 File Offset: 0x003369A8
	[NullableContext(0)]
	public ValueTuple<bool, EConfirmBoxConfigId?> CheckCountIsEnough([Nullable(1)] ProtoGachaInfo gachaInfo, int count)
	{
		if (gachaInfo.DailyLimitTimes > 0 && gachaInfo.TodayTimes + count > gachaInfo.DailyLimitTimes)
		{
			return new ValueTuple<bool, EConfirmBoxConfigId?>(false, new EConfirmBoxConfigId?(EConfirmBoxConfigId.GachaTimeIsMax));
		}
		if (gachaInfo.TotalLimitTimes > 0 && gachaInfo.TotalTimes + count > gachaInfo.TotalLimitTimes)
		{
			return new ValueTuple<bool, EConfirmBoxConfigId?>(false, new EConfirmBoxConfigId?(EConfirmBoxConfigId.TotalLimitTimes));
		}
		if (this.TodayResultCountInternal >= 0 && count > this.TodayResultCountInternal)
		{
			return new ValueTuple<bool, EConfirmBoxConfigId?>(false, new EConfirmBoxConfigId?(EConfirmBoxConfigId.TodayResult));
		}
		return new ValueTuple<bool, EConfirmBoxConfigId?>(true, null);
	}

	// Token: 0x0600DCCB RID: 56523 RVA: 0x00338838 File Offset: 0x00336A38
	public bool IsTotalTimesZero(ProtoGachaInfo gachaInfo)
	{
		return gachaInfo.TotalLimitTimes > 0 && gachaInfo.TotalTimes >= gachaInfo.TotalLimitTimes;
	}

	// Token: 0x0600DCCC RID: 56524 RVA: 0x00338858 File Offset: 0x00336A58
	[NullableContext(2)]
	public ProtoGachaInfo GetGachaInfo(int gachaId)
	{
		if (this.GachaInfoArray != null)
		{
			foreach (ProtoGachaInfo protoGachaInfo in this.GachaInfoArray)
			{
				if (protoGachaInfo.Id == gachaId)
				{
					return protoGachaInfo;
				}
			}
		}
		return null;
	}

	// Token: 0x0600DCCD RID: 56525 RVA: 0x00338894 File Offset: 0x00336A94
	public bool RecordGachaInfo(ProtoGachaInfo gachaInfo)
	{
		if (this.GachaPoolSet != null && !this.GachaPoolSet.Contains(gachaInfo.Id))
		{
			this.GachaPoolSet.Add(gachaInfo.Id);
			if (this.GachaPoolOpenRecord != null)
			{
				int[] array = new int[this.GachaPoolOpenRecord.Length + 1];
				for (int i = 0; i < this.GachaPoolOpenRecord.Length; i++)
				{
					array[i] = this.GachaPoolOpenRecord[i];
				}
				array[this.GachaPoolOpenRecord.Length] = gachaInfo.Id;
				this.GachaPoolOpenRecord = array;
			}
			LocalStorage.SetPlayer<int[]>(ELocalStoragePlayerKey.GachaPoolOpenRecord, this.GachaPoolOpenRecord);
			EventSystem.Instance.Emit(EEventName.OnOpenGachaChanged);
			return true;
		}
		return false;
	}

	// Token: 0x0600DCCE RID: 56526 RVA: 0x00338940 File Offset: 0x00336B40
	public void InitGachaPoolOpenRecord()
	{
		this.GachaPoolOpenRecord = (LocalStorage.GetPlayer<int[]>(ELocalStoragePlayerKey.GachaPoolOpenRecord, null) ?? Array.Empty<int>());
		this.GachaPoolSet = new HashSet<int>();
		foreach (int item in this.GachaPoolOpenRecord)
		{
			this.GachaPoolSet.Add(item);
		}
	}

	// Token: 0x0600DCCF RID: 56527 RVA: 0x00338994 File Offset: 0x00336B94
	public void UpdateCount(int gachaId, int count, int poolId)
	{
		this.CurGachaPoolId = poolId;
		this.TodayResultCountInternal -= count;
		if (this.GachaInfoArray != null)
		{
			foreach (ProtoGachaInfo protoGachaInfo in this.GachaInfoArray)
			{
				if (protoGachaInfo.Id == gachaId)
				{
					protoGachaInfo.TodayTimes += count;
					protoGachaInfo.TotalTimes += count;
					return;
				}
			}
		}
	}

	// Token: 0x0600DCD0 RID: 56528 RVA: 0x00338A00 File Offset: 0x00336C00
	public bool CheckNewGachaPool()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Gacha;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "当前打开过的卡池";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GachaPoolOpenRecord", this.GachaPoolOpenRecord);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.GachaInfoArray == null)
		{
			return false;
		}
		foreach (ProtoGachaInfo protoGachaInfo in this.GachaInfoArray)
		{
			if (this.GachaPoolSet != null && !this.GachaPoolSet.Contains(protoGachaInfo.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600DCD1 RID: 56529 RVA: 0x00338A7C File Offset: 0x00336C7C
	public bool CheckNewGachaPoolById(int id)
	{
		return this.GachaPoolSet != null && !this.GachaPoolSet.Contains(id);
	}

	// Token: 0x0600DCD2 RID: 56530 RVA: 0x00338A98 File Offset: 0x00336C98
	public UniTask PreloadGachaSequence(int[] itemIds)
	{
		GachaModel.<PreloadGachaSequence>d__51 <PreloadGachaSequence>d__;
		<PreloadGachaSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadGachaSequence>d__.<>4__this = this;
		<PreloadGachaSequence>d__.itemIds = itemIds;
		<PreloadGachaSequence>d__.<>1__state = -1;
		<PreloadGachaSequence>d__.<>t__builder.Start<GachaModel.<PreloadGachaSequence>d__51>(ref <PreloadGachaSequence>d__);
		return <PreloadGachaSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600DCD3 RID: 56531 RVA: 0x00338AE3 File Offset: 0x00336CE3
	[return: Nullable(2)]
	public ULevelSequence GetLoadedSequence(string path)
	{
		if (!this.SequenceCache.ContainsKey(path))
		{
			return null;
		}
		return this.SequenceCache[path];
	}

	// Token: 0x0600DCD4 RID: 56532 RVA: 0x00338B04 File Offset: 0x00336D04
	public UniTask PreloadGachaSequenceOne(int itemId)
	{
		GachaModel.<PreloadGachaSequenceOne>d__53 <PreloadGachaSequenceOne>d__;
		<PreloadGachaSequenceOne>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadGachaSequenceOne>d__.<>4__this = this;
		<PreloadGachaSequenceOne>d__.itemId = itemId;
		<PreloadGachaSequenceOne>d__.<>1__state = -1;
		<PreloadGachaSequenceOne>d__.<>t__builder.Start<GachaModel.<PreloadGachaSequenceOne>d__53>(ref <PreloadGachaSequenceOne>d__);
		return <PreloadGachaSequenceOne>d__.<>t__builder.Task;
	}

	// Token: 0x0600DCD5 RID: 56533 RVA: 0x00338B50 File Offset: 0x00336D50
	public bool ShouldUseWeaponGachaAnim()
	{
		GachaDefine.EGachaViewType? gachaViewType = GachaConfig.Instance.GetGachaViewType(this.CurGachaPoolId);
		if (gachaViewType == null)
		{
			return true;
		}
		GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig((int)gachaViewType.Value);
		return gachaViewTypeConfig == null || gachaViewTypeConfig.Value.WeaponUseGachaAnim;
	}

	// Token: 0x0600DCD6 RID: 56534 RVA: 0x00338BA8 File Offset: 0x00336DA8
	public string GetGachaSequencePath(int itemId)
	{
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(itemId);
		if (GachaConfig.Instance.GetItemIdType(itemId) == InventoryDefine.EItemDataType.WeaponItem)
		{
			int id = this.ShouldUseWeaponGachaAnim() ? gachaTextureInfo.Value.ShowSequence : 3;
			GachaWeaponSeqConfig? gachaWeaponSeqConfigById = GachaConfig.Instance.GetGachaWeaponSeqConfigById(id);
			if (gachaWeaponSeqConfigById != null)
			{
				return gachaWeaponSeqConfigById.Value.SequencePath;
			}
		}
		return GachaConfig.Instance.GetGachaSequenceConfigById(gachaTextureInfo.Value.ShowSequence).Value.SequencePath;
	}

	// Token: 0x0600DCD7 RID: 56535 RVA: 0x00338C3C File Offset: 0x00336E3C
	public int GetGachaSequenceEndFrame(int itemId)
	{
		if (GachaConfig.Instance.GetItemIdType(itemId) != InventoryDefine.EItemDataType.WeaponItem)
		{
			return 190;
		}
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(itemId);
		int id = this.ShouldUseWeaponGachaAnim() ? gachaTextureInfo.Value.ShowSequence : 3;
		return GachaConfig.Instance.GetGachaWeaponSeqConfigById(id).Value.BeforeEndFrame;
	}

	// Token: 0x0600DCD8 RID: 56536 RVA: 0x00338CA0 File Offset: 0x00336EA0
	public void ReleaseLoadGachaSequence()
	{
		bool isApplicationLowMemoryDevice = Info.Instance.IsApplicationLowMemoryDevice;
		foreach (int id in this.LoadHandlers)
		{
			ResourceSystem.Instance.CancelAsyncLoad(id);
		}
		foreach (int handleId in this.UiModelLoadHandlers)
		{
			UiModelResourcesManager.Instance.CancelUiModelResourceLoad(handleId);
		}
		foreach (ULevelSequence ulevelSequence in this.SequenceCache.Values)
		{
			UKuroSequenceRuntimeFunctionLibrary.HandleSeqTexStreaming(ulevelSequence, false, true);
			if (isApplicationLowMemoryDevice && ulevelSequence.IsValid())
			{
				UKuroStaticLibrary.DestroyObject(ulevelSequence);
			}
		}
		this.LoadHandlers.Clear();
		this.UiModelLoadHandlers.Clear();
		this.SequenceCache.Clear();
		if (isApplicationLowMemoryDevice)
		{
			WorldController.Instance.ForceGarbageCollection(true);
		}
	}

	// Token: 0x0600DCD9 RID: 56537 RVA: 0x00338DD8 File Offset: 0x00336FD8
	public bool IsRolePool(GachaDefine.EGachaViewType type)
	{
		return type == GachaDefine.EGachaViewType.NewPlayer || type == GachaDefine.EGachaViewType.RoleCommon || type == GachaDefine.EGachaViewType.RoleUp || type == GachaDefine.EGachaViewType.AnniversaryRole || type == GachaDefine.EGachaViewType.NewPlayerCustom || type == GachaDefine.EGachaViewType.CarnivalRole || type == GachaDefine.EGachaViewType.CyberRole || type == GachaDefine.EGachaViewType.OldCarnivalRole;
	}

	// Token: 0x0600DCDA RID: 56538 RVA: 0x00338E00 File Offset: 0x00337000
	public GachaDefine.EItemQuality GetGachaQuality(int itemId)
	{
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(itemId);
		int result = 0;
		if (itemIdType != InventoryDefine.EItemDataType.RoleItem)
		{
			if (itemIdType != InventoryDefine.EItemDataType.WeaponItem)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Gacha;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "抽卡获得物品的类型错误，必须是角色或武器";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				result = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.QualityId;
			}
		}
		else
		{
			RoleInfo? roleInfo;
			result = ((GachaConfig.Instance.GetRoleInfoById(itemId) != null) ? roleInfo.GetValueOrDefault().QualityId : 0);
		}
		return (GachaDefine.EItemQuality)result;
	}

	// Token: 0x0600DCDB RID: 56539 RVA: 0x00338EA0 File Offset: 0x003370A0
	public string GetGachaRecordUrlPrefix()
	{
		return BaseConfigController.Instance.GetGachaUrl().GachaRecord;
	}

	// Token: 0x0600DCDC RID: 56540 RVA: 0x00338EB1 File Offset: 0x003370B1
	public string GetServerArea()
	{
		if (!KuroSdkController.Instance.GetIfGlobalSdk())
		{
			return "cn";
		}
		return "global";
	}

	// Token: 0x170011F3 RID: 4595
	// (get) Token: 0x0600DCDD RID: 56541 RVA: 0x00338ECA File Offset: 0x003370CA
	public static GachaModel Instance
	{
		get
		{
			return GachaModel._Instance;
		}
	}

	// Token: 0x0600DCDE RID: 56542 RVA: 0x00338ED1 File Offset: 0x003370D1
	public static GachaModel GetOrCreateInstance()
	{
		if (GachaModel._Instance == null)
		{
			GachaModel.CreateInstance();
		}
		return GachaModel._Instance;
	}

	// Token: 0x0600DCDF RID: 56543 RVA: 0x00338EE5 File Offset: 0x003370E5
	public static bool CreateInstance()
	{
		if (GachaModel._Instance != null)
		{
			return true;
		}
		GachaModel._Instance = new GachaModel();
		return true;
	}

	// Token: 0x0600DCE0 RID: 56544 RVA: 0x00338EFB File Offset: 0x003370FB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DCE1 RID: 56545 RVA: 0x00338EFD File Offset: 0x003370FD
	public static void ResetStaticDefaultValue()
	{
		GachaModel._Instance = null;
	}

	// Token: 0x0600DCE2 RID: 56546 RVA: 0x00338F05 File Offset: 0x00337105
	static GachaModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaModel.CreateStaticDefaultValue), new Action(GachaModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006535 RID: 25909
	public bool IsCacheShowNewNotify;

	// Token: 0x04006536 RID: 25910
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ProtoGachaInfo[] GachaInfoArrayInternal;

	// Token: 0x04006537 RID: 25911
	private int TodayResultCountInternal;

	// Token: 0x04006538 RID: 25912
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private global::GachaResult[] CurGachaResultInternal;

	// Token: 0x04006539 RID: 25913
	[Nullable(2)]
	private int[] GachaPoolOpenRecord;

	// Token: 0x0400653A RID: 25914
	[Nullable(2)]
	private HashSet<int> GachaPoolSet;

	// Token: 0x0400653B RID: 25915
	private bool CanCloseViewInternal = true;

	// Token: 0x0400653C RID: 25916
	private string RecordIdInternal = "";

	// Token: 0x0400653D RID: 25917
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ICommonShowRoleInfo[] CachedGachaInfo;

	// Token: 0x0400653E RID: 25918
	private readonly List<int> LoadHandlers = new List<int>();

	// Token: 0x0400653F RID: 25919
	private readonly Dictionary<string, ULevelSequence> SequenceCache = new Dictionary<string, ULevelSequence>();

	// Token: 0x04006540 RID: 25920
	private readonly List<int> UiModelLoadHandlers = new List<int>();

	// Token: 0x04006541 RID: 25921
	private const int WEAPON_DEFAULT_SEQID = 3;

	// Token: 0x04006542 RID: 25922
	private int CurGachaPoolId;

	// Token: 0x04006543 RID: 25923
	[Nullable(2)]
	private static GachaModel _Instance;
}
