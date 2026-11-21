using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.FloroRanch;

// Token: 0x02000FD5 RID: 4053
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchEntityDataComponent)]
public class FloroRanchEntityDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600A1CA RID: 41418 RVA: 0x002F8858 File Offset: 0x002F6A58
	public override void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		this.EntityId = entityData.PlayIncId;
		this.EntityType = (EFloroRanchEntityType)entityData.Type;
		this.LastPoint = this.Point;
		this.Point = entityData.Point;
		this.ConfigId = entityData.Id;
		this.StartStage = entityData.StartStage;
		this.StartDay = entityData.StartDay;
		this.TagId = entityData.TagId;
		this.TagData.SetTagId(this.TagId);
		FRActionSelfDefineValue selfDefineValue = entityData.SelfDefineValue;
		if (selfDefineValue != null)
		{
			this.TagData.SetDynamicParams((int)MathUtils.Instance.LongToBigInt(selfDefineValue.N), (int)MathUtils.Instance.LongToBigInt(selfDefineValue.M), (int)MathUtils.Instance.LongToBigInt(selfDefineValue.P));
		}
		this.InitBuffList(entityData.BuffList);
		this.Count = entityData.Num;
		this.DailySaleData.SetAmount(entityData.Salary);
	}

	// Token: 0x0600A1CB RID: 41419 RVA: 0x002F8948 File Offset: 0x002F6B48
	private void InitBuffList(IEnumerable<FloroRanchPlayBuff> buffList)
	{
		this.BuffMap.Clear();
		this.TipShowBuffList.Clear();
		this.EffectShowBuffList.Clear();
		foreach (FloroRanchPlayBuff buff in buffList)
		{
			FloroRanchBuffData floroRanchBuffData = new FloroRanchBuffData();
			floroRanchBuffData.RefreshBuffData(buff);
			this.BuffMap[floroRanchBuffData.GetInstanceId()] = floroRanchBuffData;
			this.AddBuffDataToShowList(floroRanchBuffData);
		}
	}

	// Token: 0x0600A1CC RID: 41420 RVA: 0x002F89D0 File Offset: 0x002F6BD0
	public void UpdateBuff(FRUnitOperateBuffAction buffAction)
	{
		if (buffAction.Type == FRBuffOperate.BuffOpAdd)
		{
			this.AddBuff(buffAction.Buff);
			return;
		}
		if (buffAction.Type == FRBuffOperate.BuffOpRemove)
		{
			this.RemoveBuff(buffAction.Buff);
			return;
		}
		this.RefreshBuff(buffAction.Buff);
	}

	// Token: 0x0600A1CD RID: 41421 RVA: 0x002F8A0C File Offset: 0x002F6C0C
	public unsafe void AddBuff(FloroRanchPlayBuff buff)
	{
		FloroRanchBuffData floroRanchBuffData;
		if (this.BuffMap.TryGetValue(buff.PlayIncId, out floroRanchBuffData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "Buff is already exist!";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", this.Info());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", floroRanchBuffData.GetConfigId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BuffInstanceId", floroRanchBuffData.GetInstanceId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AddBuffInstanceId", buff.PlayIncId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		FloroRanchBuffData floroRanchBuffData2 = new FloroRanchBuffData();
		floroRanchBuffData2.RefreshBuffData(buff);
		this.BuffMap[floroRanchBuffData2.GetInstanceId()] = floroRanchBuffData2;
		this.AddBuffDataToShowList(floroRanchBuffData2);
	}

	// Token: 0x0600A1CE RID: 41422 RVA: 0x002F8B04 File Offset: 0x002F6D04
	public unsafe void RemoveBuff(FloroRanchPlayBuff buff)
	{
		FloroRanchBuffData floroRanchBuffData;
		if (!this.BuffMap.TryGetValue(buff.PlayIncId, out floroRanchBuffData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "Buff is not exist!";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", this.Info());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", buff.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BuffInstanceId", buff.PlayIncId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		this.BuffMap.Remove(floroRanchBuffData.GetInstanceId());
		if (floroRanchBuffData.IsShowOnTip)
		{
			this.TipShowBuffList.RemoveAt(this.TipShowBuffList.IndexOf(floroRanchBuffData));
		}
		if (floroRanchBuffData.IsShowEffect)
		{
			this.EffectShowBuffList.RemoveAt(this.EffectShowBuffList.IndexOf(floroRanchBuffData));
		}
	}

	// Token: 0x0600A1CF RID: 41423 RVA: 0x002F8C04 File Offset: 0x002F6E04
	public unsafe void RefreshBuff(FloroRanchPlayBuff buff)
	{
		FloroRanchBuffData floroRanchBuffData;
		if (!this.BuffMap.TryGetValue(buff.PlayIncId, out floroRanchBuffData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "Buff is not exist!";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", this.Info());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", buff.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BuffInstanceId", buff.PlayIncId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		floroRanchBuffData.RefreshBuffData(buff);
	}

	// Token: 0x0600A1D0 RID: 41424 RVA: 0x002F8CB8 File Offset: 0x002F6EB8
	public void AddBuffDataToShowList(FloroRanchBuffData buffData)
	{
		if (buffData.IsShowOnTip)
		{
			this.TipShowBuffList.Add(buffData);
		}
		if (buffData.IsShowEffect)
		{
			this.EffectShowBuffList.Add(buffData);
		}
	}

	// Token: 0x0600A1D1 RID: 41425 RVA: 0x002F8CE4 File Offset: 0x002F6EE4
	[NullableContext(2)]
	public FloroRanchBuffData GetMinRemindDayBuff()
	{
		if (this.EffectShowBuffList.Count == 0)
		{
			return null;
		}
		FloroRanchBuffData floroRanchBuffData = this.EffectShowBuffList[0];
		foreach (FloroRanchBuffData floroRanchBuffData2 in this.EffectShowBuffList)
		{
			if (floroRanchBuffData2.RemindDay < floroRanchBuffData.RemindDay)
			{
				floroRanchBuffData = floroRanchBuffData2;
			}
		}
		return floroRanchBuffData;
	}

	// Token: 0x0600A1D2 RID: 41426 RVA: 0x002F8D60 File Offset: 0x002F6F60
	public override string Info()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 4);
		defaultInterpolatedStringHandler.AppendLiteral("EntityId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.EntityId);
		defaultInterpolatedStringHandler.AppendLiteral(", EntityType: ");
		defaultInterpolatedStringHandler.AppendFormatted<EFloroRanchEntityType>(this.EntityType);
		defaultInterpolatedStringHandler.AppendLiteral(", Point: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Point);
		defaultInterpolatedStringHandler.AppendLiteral(", TagId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.TagId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600A1D3 RID: 41427 RVA: 0x002F8DE4 File Offset: 0x002F6FE4
	public override string DebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("EntityId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.EntityId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600A1D4 RID: 41428 RVA: 0x002F8E1B File Offset: 0x002F701B
	public void Remove()
	{
		this.IsRemoveInternal = true;
	}

	// Token: 0x1700115A RID: 4442
	// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x002F8E24 File Offset: 0x002F7024
	public bool IsValid
	{
		get
		{
			return !this.IsRemoveInternal;
		}
	}

	// Token: 0x04005F21 RID: 24353
	public int EntityId;

	// Token: 0x04005F22 RID: 24354
	public EFloroRanchEntityType EntityType = EFloroRanchEntityType.Card;

	// Token: 0x04005F23 RID: 24355
	public int ConfigId;

	// Token: 0x04005F24 RID: 24356
	public int Point;

	// Token: 0x04005F25 RID: 24357
	public int LastPoint;

	// Token: 0x04005F26 RID: 24358
	public int StartStage;

	// Token: 0x04005F27 RID: 24359
	public int StartDay;

	// Token: 0x04005F28 RID: 24360
	public int TagId;

	// Token: 0x04005F29 RID: 24361
	public int Count = 1;

	// Token: 0x04005F2A RID: 24362
	public long Income;

	// Token: 0x04005F2B RID: 24363
	public FloroRanchCurrencyData DailySaleData = new FloroRanchCurrencyData(ECurrencyType.Salary);

	// Token: 0x04005F2C RID: 24364
	public readonly List<FloroRanchBuffData> TipShowBuffList = new List<FloroRanchBuffData>();

	// Token: 0x04005F2D RID: 24365
	private readonly List<FloroRanchBuffData> EffectShowBuffList = new List<FloroRanchBuffData>();

	// Token: 0x04005F2E RID: 24366
	public readonly Dictionary<int, FloroRanchBuffData> BuffMap = new Dictionary<int, FloroRanchBuffData>();

	// Token: 0x04005F2F RID: 24367
	public readonly FloroRanchTagData TagData = new FloroRanchTagData();

	// Token: 0x04005F30 RID: 24368
	private bool IsRemoveInternal;
}
