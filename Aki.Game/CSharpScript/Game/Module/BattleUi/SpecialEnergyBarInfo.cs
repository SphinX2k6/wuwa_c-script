using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C84 RID: 19588
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarInfo
	{
		// Token: 0x06030DFD RID: 200189 RVA: 0x00DA17D8 File Offset: 0x00D9F9D8
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

		// Token: 0x06030DFE RID: 200190 RVA: 0x00DA1A40 File Offset: 0x00D9FC40
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

		// Token: 0x06030DFF RID: 200191 RVA: 0x00DA1A94 File Offset: 0x00D9FC94
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

		// Token: 0x06030E00 RID: 200192 RVA: 0x00DA1B10 File Offset: 0x00D9FD10
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

		// Token: 0x06030E01 RID: 200193 RVA: 0x00DA1B44 File Offset: 0x00D9FD44
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

		// Token: 0x04019EE0 RID: 106208
		public int Id;

		// Token: 0x04019EE1 RID: 106209
		public int PrefabType;

		// Token: 0x04019EE2 RID: 106210
		public int ExtraType;

		// Token: 0x04019EE3 RID: 106211
		public int SlotNum;

		// Token: 0x04019EE4 RID: 106212
		public List<float> ExtraFloatParams = new List<float>();

		// Token: 0x04019EE5 RID: 106213
		public string PrefabPath = string.Empty;

		// Token: 0x04019EE6 RID: 106214
		public int AttributeId;

		// Token: 0x04019EE7 RID: 106215
		public int MaxAttributeId;

		// Token: 0x04019EE8 RID: 106216
		public long BuffId;

		// Token: 0x04019EE9 RID: 106217
		public int KeyEnableTagId;

		// Token: 0x04019EEA RID: 106218
		[Nullable(2)]
		public Dictionary<int, int> TagEnergyBarIdMap;

		// Token: 0x04019EEB RID: 106219
		[Nullable(2)]
		public string EffectColor;

		// Token: 0x04019EEC RID: 106220
		public List<string> OtherEffectColorList = new List<string>();

		// Token: 0x04019EED RID: 106221
		[Nullable(2)]
		public string PointColor;

		// Token: 0x04019EEE RID: 106222
		public string[] PointColorList = Array.Empty<string>();

		// Token: 0x04019EEF RID: 106223
		[Nullable(2)]
		public string IconPath;

		// Token: 0x04019EF0 RID: 106224
		[Nullable(2)]
		public string EnableIconPath;

		// Token: 0x04019EF1 RID: 106225
		[Nullable(2)]
		public string FrontIconPath;

		// Token: 0x04019EF2 RID: 106226
		public List<string> NiagaraPathList = new List<string>();

		// Token: 0x04019EF3 RID: 106227
		public int KeyEnableNiagaraIndex;

		// Token: 0x04019EF4 RID: 106228
		public int KeyType;

		// Token: 0x04019EF5 RID: 106229
		public float DisableKeyOnPercent;

		// Token: 0x04019EF6 RID: 106230
		public List<SpecialEnergyBarKeyInfo> KeyInfoList = new List<SpecialEnergyBarKeyInfo>();
	}
}
