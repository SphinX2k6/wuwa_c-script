using System;
using System.Collections.Generic;
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

// Token: 0x02001150 RID: 4432
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GachaModel : ModelBase
{
	// Token: 0x0600B0C8 RID: 45256 RVA: 0x00343540 File Offset: 0x00341740
	public bool IsLimit(ProtoGachaInfo gachaInfo)
	{
		return gachaInfo.BeginTime != 0.0 || gachaInfo.EndTime != 0.0;
	}

	// Token: 0x0600B0C9 RID: 45257 RVA: 0x0034356C File Offset: 0x0034176C
	public bool IsValid(ProtoGachaInfo gachaInfo)
	{
		if (!this.IsLimit(gachaInfo))
		{
			return true;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= gachaInfo.BeginTime && (serverTime < gachaInfo.EndTime || gachaInfo.EndTime == 0.0);
	}

	// Token: 0x0600B0CA RID: 45258 RVA: 0x003435B8 File Offset: 0x003417B8
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

	// Token: 0x0600B0CB RID: 45259 RVA: 0x0034361C File Offset: 0x0034181C
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

	// Token: 0x17001214 RID: 4628
	// (get) Token: 0x0600B0CC RID: 45260 RVA: 0x00343682 File Offset: 0x00341882
	// (set) Token: 0x0600B0CD RID: 45261 RVA: 0x0034368A File Offset: 0x0034188A
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

	// Token: 0x17001215 RID: 4629
	// (get) Token: 0x0600B0CE RID: 45262 RVA: 0x00343693 File Offset: 0x00341893
	// (set) Token: 0x0600B0CF RID: 45263 RVA: 0x0034369B File Offset: 0x0034189B
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

	// Token: 0x17001216 RID: 4630
	// (get) Token: 0x0600B0D0 RID: 45264 RVA: 0x003436A4 File Offset: 0x003418A4
	// (set) Token: 0x0600B0D1 RID: 45265 RVA: 0x003436AC File Offset: 0x003418AC
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

	// Token: 0x17001217 RID: 4631
	// (get) Token: 0x0600B0D2 RID: 45266 RVA: 0x003436B5 File Offset: 0x003418B5
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

	// Token: 0x17001218 RID: 4632
	// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x003436BD File Offset: 0x003418BD
	// (set) Token: 0x0600B0D4 RID: 45268 RVA: 0x003436C5 File Offset: 0x003418C5
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

	// Token: 0x0600B0D5 RID: 45269 RVA: 0x003436D0 File Offset: 0x003418D0
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

	// Token: 0x0600B0D6 RID: 45270 RVA: 0x003438F8 File Offset: 0x00341AF8
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

	// Token: 0x0600B0D7 RID: 45271 RVA: 0x00343938 File Offset: 0x00341B38
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

	// Token: 0x0600B0D8 RID: 45272 RVA: 0x0034397C File Offset: 0x00341B7C
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
		using (List<EffectiveGachaButtonInfo>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsDiscount)
				{
					break;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600B0D9 RID: 45273 RVA: 0x00343AB0 File Offset: 0x00341CB0
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

	// Token: 0x0600B0DA RID: 45274 RVA: 0x00343B34 File Offset: 0x00341D34
	protected override bool OnInit()
	{
		this.CachedGachaInfo = new ICommonShowRoleInfo[0];
		return true;
	}

	// Token: 0x0600B0DB RID: 45275 RVA: 0x00343B44 File Offset: 0x00341D44
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

	// Token: 0x0600B0DC RID: 45276 RVA: 0x00343B90 File Offset: 0x00341D90
	public void InitGachaInfoMap(IReadOnlyList<GachaInfo> gachaInfoArray)
	{
		this.GachaInfoArrayInternal = new ProtoGachaInfo[gachaInfoArray.Count];
		for (int i = 0; i < gachaInfoArray.Count; i++)
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

	// Token: 0x0600B0DD RID: 45277 RVA: 0x00343C43 File Offset: 0x00341E43
	public bool CheckGachaValid(ProtoGachaInfo gachaInfo)
	{
		return this.IsValid(gachaInfo);
	}

	// Token: 0x0600B0DE RID: 45278 RVA: 0x00343C4C File Offset: 0x00341E4C
	public bool CheckGachaValidByGachaId(int gachaId)
	{
		ProtoGachaInfo gachaInfo = this.GetGachaInfo(gachaId);
		return gachaInfo != null && this.CheckGachaValid(gachaInfo);
	}

	// Token: 0x0600B0DF RID: 45279 RVA: 0x00343C70 File Offset: 0x00341E70
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

	// Token: 0x0600B0E0 RID: 45280 RVA: 0x00343CF0 File Offset: 0x00341EF0
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

	// Token: 0x0600B0E1 RID: 45281 RVA: 0x00343D80 File Offset: 0x00341F80
	public bool IsTotalTimesZero(ProtoGachaInfo gachaInfo)
	{
		return gachaInfo.TotalLimitTimes > 0 && gachaInfo.TotalTimes >= gachaInfo.TotalLimitTimes;
	}

	// Token: 0x0600B0E2 RID: 45282 RVA: 0x00343DA0 File Offset: 0x00341FA0
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

	// Token: 0x0600B0E3 RID: 45283 RVA: 0x00343DDC File Offset: 0x00341FDC
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

	// Token: 0x0600B0E4 RID: 45284 RVA: 0x00343E88 File Offset: 0x00342088
	public void InitGachaPoolOpenRecord()
	{
		this.GachaPoolOpenRecord = (LocalStorage.GetPlayer<int[]>(ELocalStoragePlayerKey.GachaPoolOpenRecord, null) ?? Array.Empty<int>());
		this.GachaPoolSet = new HashSet<int>();
		foreach (int item in this.GachaPoolOpenRecord)
		{
			this.GachaPoolSet.Add(item);
		}
	}

	// Token: 0x0600B0E5 RID: 45285 RVA: 0x00343EDC File Offset: 0x003420DC
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

	// Token: 0x0600B0E6 RID: 45286 RVA: 0x00343F48 File Offset: 0x00342148
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

	// Token: 0x0600B0E7 RID: 45287 RVA: 0x00343FC4 File Offset: 0x003421C4
	public bool CheckNewGachaPoolById(int id)
	{
		return this.GachaPoolSet != null && !this.GachaPoolSet.Contains(id);
	}

	// Token: 0x0600B0E8 RID: 45288 RVA: 0x00343FE0 File Offset: 0x003421E0
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

	// Token: 0x0600B0E9 RID: 45289 RVA: 0x0034402B File Offset: 0x0034222B
	[return: Nullable(2)]
	public ULevelSequence GetLoadedSequence(string path)
	{
		if (!this.SequenceCache.ContainsKey(path))
		{
			return null;
		}
		return this.SequenceCache[path];
	}

	// Token: 0x0600B0EA RID: 45290 RVA: 0x0034404C File Offset: 0x0034224C
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

	// Token: 0x0600B0EB RID: 45291 RVA: 0x00344098 File Offset: 0x00342298
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

	// Token: 0x0600B0EC RID: 45292 RVA: 0x003440F0 File Offset: 0x003422F0
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

	// Token: 0x0600B0ED RID: 45293 RVA: 0x00344184 File Offset: 0x00342384
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

	// Token: 0x0600B0EE RID: 45294 RVA: 0x003441E8 File Offset: 0x003423E8
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

	// Token: 0x0600B0EF RID: 45295 RVA: 0x00344320 File Offset: 0x00342520
	public bool IsRolePool(GachaDefine.EGachaViewType type)
	{
		return type == GachaDefine.EGachaViewType.NewPlayer || type == GachaDefine.EGachaViewType.RoleCommon || type == GachaDefine.EGachaViewType.RoleUp || type == GachaDefine.EGachaViewType.AnniversaryRole || type == GachaDefine.EGachaViewType.NewPlayerCustom || type == GachaDefine.EGachaViewType.CarnivalRole || type == GachaDefine.EGachaViewType.CyberRole || type == GachaDefine.EGachaViewType.OldCarnivalRole;
	}

	// Token: 0x0600B0F0 RID: 45296 RVA: 0x00344348 File Offset: 0x00342548
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

	// Token: 0x0600B0F1 RID: 45297 RVA: 0x003443E8 File Offset: 0x003425E8
	public string GetGachaRecordUrlPrefix()
	{
		return BaseConfigController.Instance.GetGachaUrl().GachaRecord;
	}

	// Token: 0x0600B0F2 RID: 45298 RVA: 0x003443F9 File Offset: 0x003425F9
	public string GetServerArea()
	{
		if (!KuroSdkController.Instance.GetIfGlobalSdk())
		{
			return "cn";
		}
		return "global";
	}

	// Token: 0x17001219 RID: 4633
	// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x00344412 File Offset: 0x00342612
	public static GachaModel Instance
	{
		get
		{
			return GachaModel._Instance;
		}
	}

	// Token: 0x0600B0F4 RID: 45300 RVA: 0x00344419 File Offset: 0x00342619
	public static GachaModel GetOrCreateInstance()
	{
		if (GachaModel._Instance == null)
		{
			GachaModel.CreateInstance();
		}
		return GachaModel._Instance;
	}

	// Token: 0x0600B0F5 RID: 45301 RVA: 0x0034442D File Offset: 0x0034262D
	public static bool CreateInstance()
	{
		if (GachaModel._Instance != null)
		{
			return true;
		}
		GachaModel._Instance = new GachaModel();
		return true;
	}

	// Token: 0x0600B0F6 RID: 45302 RVA: 0x00344443 File Offset: 0x00342643
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B0F7 RID: 45303 RVA: 0x00344445 File Offset: 0x00342645
	public static void ResetStaticDefaultValue()
	{
		GachaModel._Instance = null;
	}

	// Token: 0x0600B0F8 RID: 45304 RVA: 0x0034444D File Offset: 0x0034264D
	static GachaModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaModel.CreateStaticDefaultValue), new Action(GachaModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006607 RID: 26119
	public bool IsCacheShowNewNotify;

	// Token: 0x04006608 RID: 26120
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ProtoGachaInfo[] GachaInfoArrayInternal;

	// Token: 0x04006609 RID: 26121
	private int TodayResultCountInternal;

	// Token: 0x0400660A RID: 26122
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private global::GachaResult[] CurGachaResultInternal;

	// Token: 0x0400660B RID: 26123
	[Nullable(2)]
	private int[] GachaPoolOpenRecord;

	// Token: 0x0400660C RID: 26124
	[Nullable(2)]
	private HashSet<int> GachaPoolSet;

	// Token: 0x0400660D RID: 26125
	private bool CanCloseViewInternal = true;

	// Token: 0x0400660E RID: 26126
	private string RecordIdInternal = "";

	// Token: 0x0400660F RID: 26127
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ICommonShowRoleInfo[] CachedGachaInfo;

	// Token: 0x04006610 RID: 26128
	private readonly List<int> LoadHandlers = new List<int>();

	// Token: 0x04006611 RID: 26129
	private readonly Dictionary<string, ULevelSequence> SequenceCache = new Dictionary<string, ULevelSequence>();

	// Token: 0x04006612 RID: 26130
	private readonly List<int> UiModelLoadHandlers = new List<int>();

	// Token: 0x04006613 RID: 26131
	private const int WEAPON_DEFAULT_SEQID = 3;

	// Token: 0x04006614 RID: 26132
	private int CurGachaPoolId;

	// Token: 0x04006615 RID: 26133
	[Nullable(2)]
	private static GachaModel _Instance;
}
