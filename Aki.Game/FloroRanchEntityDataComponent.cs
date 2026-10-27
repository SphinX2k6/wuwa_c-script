using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.FloroRanch;

// Token: 0x02001B16 RID: 6934
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchEntityDataComponent)]
public class FloroRanchEntityDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600CDB9 RID: 52665 RVA: 0x002ED76C File Offset: 0x002EB96C
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
		this.InitBuffList(entityData.BuffList.ToList<FloroRanchPlayBuff>());
		this.Count = entityData.Num;
		this.DailySaleData.SetAmount(entityData.Salary);
	}

	// Token: 0x0600CDBA RID: 52666 RVA: 0x002ED860 File Offset: 0x002EBA60
	private void InitBuffList(List<FloroRanchPlayBuff> buffList)
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

	// Token: 0x0600CDBB RID: 52667 RVA: 0x002ED8F0 File Offset: 0x002EBAF0
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

	// Token: 0x0600CDBC RID: 52668 RVA: 0x002ED92C File Offset: 0x002EBB2C
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

	// Token: 0x0600CDBD RID: 52669 RVA: 0x002EDA24 File Offset: 0x002EBC24
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

	// Token: 0x0600CDBE RID: 52670 RVA: 0x002EDB24 File Offset: 0x002EBD24
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

	// Token: 0x0600CDBF RID: 52671 RVA: 0x002EDBD8 File Offset: 0x002EBDD8
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

	// Token: 0x0600CDC0 RID: 52672 RVA: 0x002EDC04 File Offset: 0x002EBE04
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

	// Token: 0x0600CDC1 RID: 52673 RVA: 0x002EDC80 File Offset: 0x002EBE80
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

	// Token: 0x0600CDC2 RID: 52674 RVA: 0x002EDD04 File Offset: 0x002EBF04
	public override string DebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("EntityId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.EntityId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600CDC3 RID: 52675 RVA: 0x002EDD3B File Offset: 0x002EBF3B
	public void Remove()
	{
		this.IsRemoveInternal = true;
	}

	// Token: 0x17001135 RID: 4405
	// (get) Token: 0x0600CDC4 RID: 52676 RVA: 0x002EDD44 File Offset: 0x002EBF44
	public bool IsValid
	{
		get
		{
			return !this.IsRemoveInternal;
		}
	}

	// Token: 0x04005E52 RID: 24146
	public int EntityId;

	// Token: 0x04005E53 RID: 24147
	public EFloroRanchEntityType EntityType = EFloroRanchEntityType.Card;

	// Token: 0x04005E54 RID: 24148
	public int ConfigId;

	// Token: 0x04005E55 RID: 24149
	public int Point;

	// Token: 0x04005E56 RID: 24150
	public int LastPoint;

	// Token: 0x04005E57 RID: 24151
	public int StartStage;

	// Token: 0x04005E58 RID: 24152
	public int StartDay;

	// Token: 0x04005E59 RID: 24153
	public int TagId;

	// Token: 0x04005E5A RID: 24154
	public int Count = 1;

	// Token: 0x04005E5B RID: 24155
	public long Income;

	// Token: 0x04005E5C RID: 24156
	public FloroRanchCurrencyData DailySaleData = new FloroRanchCurrencyData(ECurrencyType.Salary);

	// Token: 0x04005E5D RID: 24157
	public readonly List<FloroRanchBuffData> TipShowBuffList = new List<FloroRanchBuffData>();

	// Token: 0x04005E5E RID: 24158
	private readonly List<FloroRanchBuffData> EffectShowBuffList = new List<FloroRanchBuffData>();

	// Token: 0x04005E5F RID: 24159
	public readonly Dictionary<int, FloroRanchBuffData> BuffMap = new Dictionary<int, FloroRanchBuffData>();

	// Token: 0x04005E60 RID: 24160
	public readonly FloroRanchTagData TagData = new FloroRanchTagData();

	// Token: 0x04005E61 RID: 24161
	private bool IsRemoveInternal;
}
