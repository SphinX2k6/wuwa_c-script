using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA2 RID: 23714
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarInfo
	{
		// Token: 0x0603BEAA RID: 245418 RVA: 0x00E51138 File Offset: 0x00E4F338
		public unsafe void Init(int id, SSpecialEnergyBar config)
		{
			this.Id = id;
			this.PrefabType = (int)config.PrefabType;
			this.ExtraType = config.ExtraType;
			this.SlotNum = config.SlotNum;
			this.InitExtraParams<float>(config.ExtraFloatParams, this.ExtraFloatParams);
			this.PrefabPath = config.PrefabPath.ToAssetPathName();
			this.AttributeId = config.AttributeId;
			this.MaxAttributeId = config.MaxAttributeId;
			this.BuffId = config.BuffId;
			this.TagEnergyBarIdMap = this.ParseGameplayAnySimple<int>(config.TagEnergyBarIdMap);
			if (!string.IsNullOrEmpty(config.EffectColor))
			{
				string[] array = config.EffectColor.Split('#', StringSplitOptions.None);
				this.EffectColor = array[0];
				this.OtherEffectColorList = new List<string>(RuntimeHelpers.GetSubArray<string>(array, Range.StartAt(1)));
			}
			else
			{
				this.EffectColor = null;
			}
			if (!string.IsNullOrEmpty(config.PointColor))
			{
				string[] array2 = config.PointColor.Split('#', StringSplitOptions.None);
				this.PointColor = array2[0];
				this.PointColorList = array2;
			}
			else
			{
				this.PointColor = null;
			}
			this.IconPath = config.TexturePath.ToAssetPathName();
			this.EnableIconPath = config.EnableTexturePath.ToAssetPathName();
			this.FrontIconPath = config.FrontTexturePath.ToAssetPathName();
			this.InitPathList(config.NiagaraList, this.NiagaraPathList);
			this.KeyEnableNiagaraIndex = config.KeyEnableNiagaraIndex;
			if (this.KeyEnableNiagaraIndex >= this.NiagaraPathList.Count)
			{
				this.KeyEnableNiagaraIndex = -1;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "能量条配置错误, 可用时粒子特效索引超出粒子数组长度";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", config.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("索引", this.KeyEnableNiagaraIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("数组长度", this.NiagaraPathList.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.KeyType = config.KeyType;
			this.DisableKeyOnPercent = (float)config.DisableKeyOnPercent / 100f;
			if (config.KeyEnableTag.TagName != FName.NAME_None)
			{
				this.KeyEnableTagId = config.KeyEnableTag.TagId();
			}
			else
			{
				this.KeyEnableTagId = 0;
			}
			this.InitKeyInfo(config.KeyInfoList);
		}

		// Token: 0x0603BEAB RID: 245419 RVA: 0x00E513A0 File Offset: 0x00E4F5A0
		private void InitKeyInfo(TArray<SSpecialEnergyBarKey> keyInfoList)
		{
			int num = keyInfoList.Num();
			for (int i = 0; i < num; i++)
			{
				SSpecialEnergyBarKey sspecialEnergyBarKey = keyInfoList.Get(i);
				SpecialEnergyBarKeyInfo item = new SpecialEnergyBarKeyInfo
				{
					Action = sspecialEnergyBarKey.Action,
					ActionType = sspecialEnergyBarKey.ActionType
				};
				this.KeyInfoList.Add(item);
			}
		}

		// Token: 0x0603BEAC RID: 245420 RVA: 0x00E513F4 File Offset: 0x00E4F5F4
		private Dictionary<int, T> ParseGameplayAnySimple<[Nullable(2)] T>(TMap<FGameplayTag, T> map)
		{
			int num = map.Num();
			Dictionary<int, T> dictionary = new Dictionary<int, T>(num);
			if (num <= 0)
			{
				return dictionary;
			}
			foreach (KeyValuePair<FGameplayTag, T> keyValuePair in map)
			{
				FGameplayTag fgameplayTag;
				T t;
				keyValuePair.Deconstruct(out fgameplayTag, out t);
				FGameplayTag tag = fgameplayTag;
				T value = t;
				dictionary[tag.TagId()] = value;
			}
			return dictionary;
		}

		// Token: 0x0603BEAD RID: 245421 RVA: 0x00E51468 File Offset: 0x00E4F668
		private void InitExtraParams<[Nullable(2)] T>(TArray<T> srcArray, List<T> destArray)
		{
			int num = srcArray.Num();
			if (num <= 0)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				T item = srcArray.Get(i);
				destArray.Add(item);
			}
		}

		// Token: 0x0603BEAE RID: 245422 RVA: 0x00E5149C File Offset: 0x00E4F69C
		private void InitPathList(TArray<TSoftObjectPtr<UNiagaraSystem>> srcArray, List<string> destArray)
		{
			int num = srcArray.Num();
			if (num <= 0)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				TSoftObjectPtr<UNiagaraSystem> tsoftObjectPtr = srcArray.Get(i);
				destArray.Add(tsoftObjectPtr.ToAssetPathName());
			}
		}

		// Token: 0x0401F427 RID: 128039
		public int Id;

		// Token: 0x0401F428 RID: 128040
		public int PrefabType;

		// Token: 0x0401F429 RID: 128041
		public int ExtraType;

		// Token: 0x0401F42A RID: 128042
		public int SlotNum;

		// Token: 0x0401F42B RID: 128043
		public List<float> ExtraFloatParams = new List<float>();

		// Token: 0x0401F42C RID: 128044
		public string PrefabPath = string.Empty;

		// Token: 0x0401F42D RID: 128045
		public int AttributeId;

		// Token: 0x0401F42E RID: 128046
		public int MaxAttributeId;

		// Token: 0x0401F42F RID: 128047
		public long BuffId;

		// Token: 0x0401F430 RID: 128048
		public int KeyEnableTagId;

		// Token: 0x0401F431 RID: 128049
		[Nullable(2)]
		public Dictionary<int, int> TagEnergyBarIdMap;

		// Token: 0x0401F432 RID: 128050
		[Nullable(2)]
		public string EffectColor;

		// Token: 0x0401F433 RID: 128051
		public List<string> OtherEffectColorList = new List<string>();

		// Token: 0x0401F434 RID: 128052
		[Nullable(2)]
		public string PointColor;

		// Token: 0x0401F435 RID: 128053
		public string[] PointColorList = Array.Empty<string>();

		// Token: 0x0401F436 RID: 128054
		[Nullable(2)]
		public string IconPath;

		// Token: 0x0401F437 RID: 128055
		[Nullable(2)]
		public string EnableIconPath;

		// Token: 0x0401F438 RID: 128056
		[Nullable(2)]
		public string FrontIconPath;

		// Token: 0x0401F439 RID: 128057
		public List<string> NiagaraPathList = new List<string>();

		// Token: 0x0401F43A RID: 128058
		public int KeyEnableNiagaraIndex;

		// Token: 0x0401F43B RID: 128059
		public int KeyType;

		// Token: 0x0401F43C RID: 128060
		public float DisableKeyOnPercent;

		// Token: 0x0401F43D RID: 128061
		public List<SpecialEnergyBarKeyInfo> KeyInfoList = new List<SpecialEnergyBarKeyInfo>();
	}
}
