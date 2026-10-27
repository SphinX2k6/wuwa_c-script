using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CSharpScript.Game.Module.WorldMap;
using FilterDefine;

namespace CSharpScript.Game.Common.LocalStorageJson.Generated
{
	// Token: 0x02007294 RID: 29332
	[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, IncludeFields = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonSerializable(typeof(bool))]
	[JsonSerializable(typeof(bool?))]
	[JsonSerializable(typeof(double))]
	[JsonSerializable(typeof(double?))]
	[JsonSerializable(typeof(double[]))]
	[JsonSerializable(typeof(float))]
	[JsonSerializable(typeof(float?))]
	[JsonSerializable(typeof(float[]))]
	[JsonSerializable(typeof(AbyssDangoOwnerData))]
	[JsonSerializable(typeof(ActivityCacheData))]
	[JsonSerializable(typeof(AreaExplorePlayState))]
	[JsonSerializable(typeof(EMapNoteId))]
	[JsonSerializable(typeof(EExploreType))]
	[JsonSerializable(typeof(EFunction))]
	[JsonSerializable(typeof(EMotorMusicPlayMode))]
	[JsonSerializable(typeof(EPlayPointState))]
	[JsonSerializable(typeof(ERouletteType))]
	[JsonSerializable(typeof(ERouletteType?))]
	[JsonSerializable(typeof(EVisionLevelUpIdentify))]
	[JsonSerializable(typeof(EVisionLevelUpIdentify?))]
	[JsonSerializable(typeof(EVisionLevelUpMaterialPutInMode))]
	[JsonSerializable(typeof(EVisionLevelUpMaterialPutInMode?))]
	[JsonSerializable(typeof(EVisionLevelUpMaterialUseType))]
	[JsonSerializable(typeof(EVisionLevelUpMaterialUseType?))]
	[JsonSerializable(typeof(FilterDefine.EFilterType))]
	[JsonSerializable(typeof(FilterStorageData))]
	[JsonSerializable(typeof(GamepadTypeUsage))]
	[JsonSerializable(typeof(GameQualityData))]
	[JsonSerializable(typeof(LocalFriendApplication))]
	[JsonSerializable(typeof(LocalPlayerIpLevelData))]
	[JsonSerializable(typeof(LocalPlayerIpLevelData[]))]
	[JsonSerializable(typeof(MarqueeStorageData))]
	[JsonSerializable(typeof(RacingBetsRedDotState))]
	[JsonSerializable(typeof(RegionAndIpSt))]
	[JsonSerializable(typeof(SortStorageData))]
	[JsonSerializable(typeof(Dictionary<EFunction, int>))]
	[JsonSerializable(typeof(Dictionary<FilterDefine.EFilterType, List<int>>))]
	[JsonSerializable(typeof(Dictionary<int, bool>))]
	[JsonSerializable(typeof(Dictionary<int, double>))]
	[JsonSerializable(typeof(Dictionary<int, float>))]
	[JsonSerializable(typeof(Dictionary<int, float[]>))]
	[JsonSerializable(typeof(Dictionary<int, AbyssDangoOwnerData>))]
	[JsonSerializable(typeof(Dictionary<int, AreaExplorePlayState>))]
	[JsonSerializable(typeof(Dictionary<int, LocalFriendApplication>))]
	[JsonSerializable(typeof(Dictionary<int, Dictionary<int, double>>))]
	[JsonSerializable(typeof(Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>))]
	[JsonSerializable(typeof(Dictionary<int, Dictionary<int, AreaExplorePlayState>>))]
	[JsonSerializable(typeof(Dictionary<int, Dictionary<int, HashSet<int>>>))]
	[JsonSerializable(typeof(Dictionary<int, HashSet<int>>))]
	[JsonSerializable(typeof(Dictionary<int, List<int>>))]
	[JsonSerializable(typeof(Dictionary<int, int>))]
	[JsonSerializable(typeof(Dictionary<int, int[]>))]
	[JsonSerializable(typeof(Dictionary<int, long>))]
	[JsonSerializable(typeof(Dictionary<int, string>))]
	[JsonSerializable(typeof(Dictionary<string, bool>))]
	[JsonSerializable(typeof(Dictionary<string, FilterStorageData>))]
	[JsonSerializable(typeof(Dictionary<string, GamepadTypeUsage>))]
	[JsonSerializable(typeof(Dictionary<string, LocalPlayerIpLevelData[]>))]
	[JsonSerializable(typeof(Dictionary<string, MarqueeStorageData>))]
	[JsonSerializable(typeof(Dictionary<string, RegionAndIpSt>))]
	[JsonSerializable(typeof(Dictionary<string, SortStorageData>))]
	[JsonSerializable(typeof(Dictionary<string, List<ActivityCacheData>>))]
	[JsonSerializable(typeof(Dictionary<string, int>))]
	[JsonSerializable(typeof(HashSet<EMapNoteId>))]
	[JsonSerializable(typeof(HashSet<int>))]
	[JsonSerializable(typeof(List<ActivityCacheData>))]
	[JsonSerializable(typeof(List<EPlayPointState>))]
	[JsonSerializable(typeof(List<int>))]
	[JsonSerializable(typeof(List<string>))]
	[JsonSerializable(typeof(int))]
	[JsonSerializable(typeof(int?))]
	[JsonSerializable(typeof(int[]))]
	[JsonSerializable(typeof(long))]
	[JsonSerializable(typeof(object))]
	[JsonSerializable(typeof(string))]
	[JsonSerializable(typeof(string[]))]
	[JsonSerializable(typeof(IRacingBetsSettlementMainViewRecord))]
	[JsonSerializable(typeof(Dictionary<string, IList<IList<string>>>))]
	[GeneratedCode("System.Text.Json.SourceGeneration", "9.0.12.26613")]
	internal class LocalStorageJsonSourceGenContext : JsonSerializerContext, IJsonTypeInfoResolver
	{
		// Token: 0x17009EA8 RID: 40616
		// (get) Token: 0x06047E21 RID: 294433 RVA: 0x01265AA8 File Offset: 0x01263CA8
		public JsonTypeInfo<bool> Boolean
		{
			get
			{
				JsonTypeInfo<bool> result;
				if ((result = this._Boolean) == null)
				{
					result = (this._Boolean = (JsonTypeInfo<bool>)base.Options.GetTypeInfo(typeof(bool)));
				}
				return result;
			}
		}

		// Token: 0x06047E22 RID: 294434 RVA: 0x01265AE4 File Offset: 0x01263CE4
		[NullableContext(1)]
		private JsonTypeInfo<bool> Create_Boolean(JsonSerializerOptions options)
		{
			JsonTypeInfo<bool> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<bool>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<bool>(options, JsonMetadataServices.BooleanConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EA9 RID: 40617
		// (get) Token: 0x06047E23 RID: 294435 RVA: 0x01265B10 File Offset: 0x01263D10
		public JsonTypeInfo<bool?> NullableBoolean
		{
			get
			{
				JsonTypeInfo<bool?> result;
				if ((result = this._NullableBoolean) == null)
				{
					result = (this._NullableBoolean = (JsonTypeInfo<bool?>)base.Options.GetTypeInfo(typeof(bool?)));
				}
				return result;
			}
		}

		// Token: 0x06047E24 RID: 294436 RVA: 0x01265B4C File Offset: 0x01263D4C
		[NullableContext(1)]
		private JsonTypeInfo<bool?> Create_NullableBoolean(JsonSerializerOptions options)
		{
			JsonTypeInfo<bool?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<bool?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<bool>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<bool?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EAA RID: 40618
		// (get) Token: 0x06047E25 RID: 294437 RVA: 0x01265B7C File Offset: 0x01263D7C
		public JsonTypeInfo<double> Double
		{
			get
			{
				JsonTypeInfo<double> result;
				if ((result = this._Double) == null)
				{
					result = (this._Double = (JsonTypeInfo<double>)base.Options.GetTypeInfo(typeof(double)));
				}
				return result;
			}
		}

		// Token: 0x06047E26 RID: 294438 RVA: 0x01265BB8 File Offset: 0x01263DB8
		[NullableContext(1)]
		private JsonTypeInfo<double> Create_Double(JsonSerializerOptions options)
		{
			JsonTypeInfo<double> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<double>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<double>(options, JsonMetadataServices.DoubleConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EAB RID: 40619
		// (get) Token: 0x06047E27 RID: 294439 RVA: 0x01265BE4 File Offset: 0x01263DE4
		public JsonTypeInfo<double?> NullableDouble
		{
			get
			{
				JsonTypeInfo<double?> result;
				if ((result = this._NullableDouble) == null)
				{
					result = (this._NullableDouble = (JsonTypeInfo<double?>)base.Options.GetTypeInfo(typeof(double?)));
				}
				return result;
			}
		}

		// Token: 0x06047E28 RID: 294440 RVA: 0x01265C20 File Offset: 0x01263E20
		[NullableContext(1)]
		private JsonTypeInfo<double?> Create_NullableDouble(JsonSerializerOptions options)
		{
			JsonTypeInfo<double?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<double?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<double>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<double?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EAC RID: 40620
		// (get) Token: 0x06047E29 RID: 294441 RVA: 0x01265C50 File Offset: 0x01263E50
		public JsonTypeInfo<double[]> DoubleArray
		{
			get
			{
				JsonTypeInfo<double[]> result;
				if ((result = this._DoubleArray) == null)
				{
					result = (this._DoubleArray = (JsonTypeInfo<double[]>)base.Options.GetTypeInfo(typeof(double[])));
				}
				return result;
			}
		}

		// Token: 0x06047E2A RID: 294442 RVA: 0x01265C8C File Offset: 0x01263E8C
		[NullableContext(1)]
		private JsonTypeInfo<double[]> Create_DoubleArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<double[]> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<double[]>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<double[]> collectionInfo = new JsonCollectionInfoValues<double[]>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateArrayInfo<double>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EAD RID: 40621
		// (get) Token: 0x06047E2B RID: 294443 RVA: 0x01265CD8 File Offset: 0x01263ED8
		public JsonTypeInfo<float> Single
		{
			get
			{
				JsonTypeInfo<float> result;
				if ((result = this._Single) == null)
				{
					result = (this._Single = (JsonTypeInfo<float>)base.Options.GetTypeInfo(typeof(float)));
				}
				return result;
			}
		}

		// Token: 0x06047E2C RID: 294444 RVA: 0x01265D14 File Offset: 0x01263F14
		[NullableContext(1)]
		private JsonTypeInfo<float> Create_Single(JsonSerializerOptions options)
		{
			JsonTypeInfo<float> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<float>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<float>(options, JsonMetadataServices.SingleConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EAE RID: 40622
		// (get) Token: 0x06047E2D RID: 294445 RVA: 0x01265D40 File Offset: 0x01263F40
		public JsonTypeInfo<float?> NullableSingle
		{
			get
			{
				JsonTypeInfo<float?> result;
				if ((result = this._NullableSingle) == null)
				{
					result = (this._NullableSingle = (JsonTypeInfo<float?>)base.Options.GetTypeInfo(typeof(float?)));
				}
				return result;
			}
		}

		// Token: 0x06047E2E RID: 294446 RVA: 0x01265D7C File Offset: 0x01263F7C
		[NullableContext(1)]
		private JsonTypeInfo<float?> Create_NullableSingle(JsonSerializerOptions options)
		{
			JsonTypeInfo<float?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<float?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<float>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<float?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EAF RID: 40623
		// (get) Token: 0x06047E2F RID: 294447 RVA: 0x01265DAC File Offset: 0x01263FAC
		public JsonTypeInfo<float[]> SingleArray
		{
			get
			{
				JsonTypeInfo<float[]> result;
				if ((result = this._SingleArray) == null)
				{
					result = (this._SingleArray = (JsonTypeInfo<float[]>)base.Options.GetTypeInfo(typeof(float[])));
				}
				return result;
			}
		}

		// Token: 0x06047E30 RID: 294448 RVA: 0x01265DE8 File Offset: 0x01263FE8
		[NullableContext(1)]
		private JsonTypeInfo<float[]> Create_SingleArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<float[]> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<float[]>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<float[]> collectionInfo = new JsonCollectionInfoValues<float[]>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateArrayInfo<float>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB0 RID: 40624
		// (get) Token: 0x06047E31 RID: 294449 RVA: 0x01265E34 File Offset: 0x01264034
		public JsonTypeInfo<AbyssDangoOwnerData> AbyssDangoOwnerData
		{
			get
			{
				JsonTypeInfo<AbyssDangoOwnerData> result;
				if ((result = this._AbyssDangoOwnerData) == null)
				{
					result = (this._AbyssDangoOwnerData = (JsonTypeInfo<AbyssDangoOwnerData>)base.Options.GetTypeInfo(typeof(AbyssDangoOwnerData)));
				}
				return result;
			}
		}

		// Token: 0x06047E32 RID: 294450 RVA: 0x01265E70 File Offset: 0x01264070
		[NullableContext(1)]
		private JsonTypeInfo<AbyssDangoOwnerData> Create_AbyssDangoOwnerData(JsonSerializerOptions options)
		{
			JsonTypeInfo<AbyssDangoOwnerData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<AbyssDangoOwnerData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<AbyssDangoOwnerData> jsonObjectInfoValues = new JsonObjectInfoValues<AbyssDangoOwnerData>();
				jsonObjectInfoValues.ObjectCreator = (() => new AbyssDangoOwnerData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.AbyssDangoOwnerDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(AbyssDangoOwnerData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<AbyssDangoOwnerData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<AbyssDangoOwnerData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E33 RID: 294451 RVA: 0x01265F38 File Offset: 0x01264138
		[NullableContext(1)]
		private static JsonPropertyInfo[] AbyssDangoOwnerDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(AbyssDangoOwnerData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((AbyssDangoOwnerData)obj).PlayerId);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((AbyssDangoOwnerData)obj).PlayerId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PlayerId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(AbyssDangoOwnerData).GetField("PlayerId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(AbyssDangoOwnerData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((AbyssDangoOwnerData)obj).RoleCfgId);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((AbyssDangoOwnerData)obj).RoleCfgId = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "RoleCfgId";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(AbyssDangoOwnerData).GetField("RoleCfgId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(AbyssDangoOwnerData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((AbyssDangoOwnerData)obj).DangoId);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int value)
			{
				((AbyssDangoOwnerData)obj).DangoId = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "DangoId";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(AbyssDangoOwnerData).GetField("DangoId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo3);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(AbyssDangoOwnerData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((AbyssDangoOwnerData)obj).DangoLevel);
			jsonPropertyInfoValues4.Setter = delegate(object obj, int value)
			{
				((AbyssDangoOwnerData)obj).DangoLevel = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "DangoLevel";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(AbyssDangoOwnerData).GetField("DangoLevel", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo4);
			JsonPropertyInfoValues<int[]> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<int[]>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(AbyssDangoOwnerData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((AbyssDangoOwnerData)obj).DangoEquipIds);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] int[] value)
			{
				((AbyssDangoOwnerData)obj).DangoEquipIds = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "DangoEquipIds";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(AbyssDangoOwnerData).GetField("DangoEquipIds", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int[]> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<int[]>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			return array;
		}

		// Token: 0x17009EB1 RID: 40625
		// (get) Token: 0x06047E34 RID: 294452 RVA: 0x012663F8 File Offset: 0x012645F8
		public JsonTypeInfo<ActivityCacheData> ActivityCacheData
		{
			get
			{
				JsonTypeInfo<ActivityCacheData> result;
				if ((result = this._ActivityCacheData) == null)
				{
					result = (this._ActivityCacheData = (JsonTypeInfo<ActivityCacheData>)base.Options.GetTypeInfo(typeof(ActivityCacheData)));
				}
				return result;
			}
		}

		// Token: 0x06047E35 RID: 294453 RVA: 0x01266434 File Offset: 0x01264634
		[NullableContext(1)]
		private JsonTypeInfo<ActivityCacheData> Create_ActivityCacheData(JsonSerializerOptions options)
		{
			JsonTypeInfo<ActivityCacheData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ActivityCacheData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ActivityCacheData> jsonObjectInfoValues = new JsonObjectInfoValues<ActivityCacheData>();
				jsonObjectInfoValues.ObjectCreator = (() => new ActivityCacheData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.ActivityCacheDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ActivityCacheData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ActivityCacheData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ActivityCacheData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E36 RID: 294454 RVA: 0x012664FC File Offset: 0x012646FC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ActivityCacheDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ActivityCacheData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ActivityCacheData)obj).Key);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((ActivityCacheData)obj).Key = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Key";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ActivityCacheData).GetField("Key", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ActivityCacheData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ActivityCacheData)obj).Value);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((ActivityCacheData)obj).Value = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Value";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ActivityCacheData).GetField("Value", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17009EB2 RID: 40626
		// (get) Token: 0x06047E37 RID: 294455 RVA: 0x012666E4 File Offset: 0x012648E4
		public JsonTypeInfo<AreaExplorePlayState> AreaExplorePlayState
		{
			get
			{
				JsonTypeInfo<AreaExplorePlayState> result;
				if ((result = this._AreaExplorePlayState) == null)
				{
					result = (this._AreaExplorePlayState = (JsonTypeInfo<AreaExplorePlayState>)base.Options.GetTypeInfo(typeof(AreaExplorePlayState)));
				}
				return result;
			}
		}

		// Token: 0x06047E38 RID: 294456 RVA: 0x01266720 File Offset: 0x01264920
		[NullableContext(1)]
		private JsonTypeInfo<AreaExplorePlayState> Create_AreaExplorePlayState(JsonSerializerOptions options)
		{
			JsonTypeInfo<AreaExplorePlayState> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<AreaExplorePlayState>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<AreaExplorePlayState> jsonObjectInfoValues = new JsonObjectInfoValues<AreaExplorePlayState>();
				jsonObjectInfoValues.ObjectCreator = (() => new AreaExplorePlayState());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.AreaExplorePlayStatePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(AreaExplorePlayState).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<AreaExplorePlayState> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<AreaExplorePlayState>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E39 RID: 294457 RVA: 0x012667E8 File Offset: 0x012649E8
		[NullableContext(1)]
		private static JsonPropertyInfo[] AreaExplorePlayStatePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<EExploreType> jsonPropertyInfoValues = new JsonPropertyInfoValues<EExploreType>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(AreaExplorePlayState);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((AreaExplorePlayState)obj).ExploreType);
			jsonPropertyInfoValues.Setter = delegate(object obj, EExploreType value)
			{
				((AreaExplorePlayState)obj).ExploreType = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ExploreType";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(AreaExplorePlayState).GetProperty("ExploreType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(EExploreType), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<EExploreType> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<EExploreType>(options, propertyInfo);
			JsonPropertyInfoValues<List<EPlayPointState>> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<List<EPlayPointState>>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(AreaExplorePlayState);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((AreaExplorePlayState)obj).PlayPointStateList);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] List<EPlayPointState> value)
			{
				((AreaExplorePlayState)obj).PlayPointStateList = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "PlayPointStateList";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(AreaExplorePlayState).GetProperty("PlayPointStateList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(List<EPlayPointState>), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<List<EPlayPointState>> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<List<EPlayPointState>>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17009EB3 RID: 40627
		// (get) Token: 0x06047E3A RID: 294458 RVA: 0x012669E0 File Offset: 0x01264BE0
		public JsonTypeInfo<EMapNoteId> EMapNoteId
		{
			get
			{
				JsonTypeInfo<EMapNoteId> result;
				if ((result = this._EMapNoteId) == null)
				{
					result = (this._EMapNoteId = (JsonTypeInfo<EMapNoteId>)base.Options.GetTypeInfo(typeof(EMapNoteId)));
				}
				return result;
			}
		}

		// Token: 0x06047E3B RID: 294459 RVA: 0x01266A1C File Offset: 0x01264C1C
		[NullableContext(1)]
		private JsonTypeInfo<EMapNoteId> Create_EMapNoteId(JsonSerializerOptions options)
		{
			JsonTypeInfo<EMapNoteId> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EMapNoteId>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EMapNoteId>(options, JsonMetadataServices.GetEnumConverter<EMapNoteId>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB4 RID: 40628
		// (get) Token: 0x06047E3C RID: 294460 RVA: 0x01266A48 File Offset: 0x01264C48
		public JsonTypeInfo<EExploreType> EExploreType
		{
			get
			{
				JsonTypeInfo<EExploreType> result;
				if ((result = this._EExploreType) == null)
				{
					result = (this._EExploreType = (JsonTypeInfo<EExploreType>)base.Options.GetTypeInfo(typeof(EExploreType)));
				}
				return result;
			}
		}

		// Token: 0x06047E3D RID: 294461 RVA: 0x01266A84 File Offset: 0x01264C84
		[NullableContext(1)]
		private JsonTypeInfo<EExploreType> Create_EExploreType(JsonSerializerOptions options)
		{
			JsonTypeInfo<EExploreType> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EExploreType>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EExploreType>(options, JsonMetadataServices.GetEnumConverter<EExploreType>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB5 RID: 40629
		// (get) Token: 0x06047E3E RID: 294462 RVA: 0x01266AB0 File Offset: 0x01264CB0
		public JsonTypeInfo<EFunction> EFunction
		{
			get
			{
				JsonTypeInfo<EFunction> result;
				if ((result = this._EFunction) == null)
				{
					result = (this._EFunction = (JsonTypeInfo<EFunction>)base.Options.GetTypeInfo(typeof(EFunction)));
				}
				return result;
			}
		}

		// Token: 0x06047E3F RID: 294463 RVA: 0x01266AEC File Offset: 0x01264CEC
		[NullableContext(1)]
		private JsonTypeInfo<EFunction> Create_EFunction(JsonSerializerOptions options)
		{
			JsonTypeInfo<EFunction> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EFunction>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EFunction>(options, JsonMetadataServices.GetEnumConverter<EFunction>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB6 RID: 40630
		// (get) Token: 0x06047E40 RID: 294464 RVA: 0x01266B18 File Offset: 0x01264D18
		public JsonTypeInfo<EMotorMusicPlayMode> EMotorMusicPlayMode
		{
			get
			{
				JsonTypeInfo<EMotorMusicPlayMode> result;
				if ((result = this._EMotorMusicPlayMode) == null)
				{
					result = (this._EMotorMusicPlayMode = (JsonTypeInfo<EMotorMusicPlayMode>)base.Options.GetTypeInfo(typeof(EMotorMusicPlayMode)));
				}
				return result;
			}
		}

		// Token: 0x06047E41 RID: 294465 RVA: 0x01266B54 File Offset: 0x01264D54
		[NullableContext(1)]
		private JsonTypeInfo<EMotorMusicPlayMode> Create_EMotorMusicPlayMode(JsonSerializerOptions options)
		{
			JsonTypeInfo<EMotorMusicPlayMode> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EMotorMusicPlayMode>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EMotorMusicPlayMode>(options, JsonMetadataServices.GetEnumConverter<EMotorMusicPlayMode>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB7 RID: 40631
		// (get) Token: 0x06047E42 RID: 294466 RVA: 0x01266B80 File Offset: 0x01264D80
		public JsonTypeInfo<EPlayPointState> EPlayPointState
		{
			get
			{
				JsonTypeInfo<EPlayPointState> result;
				if ((result = this._EPlayPointState) == null)
				{
					result = (this._EPlayPointState = (JsonTypeInfo<EPlayPointState>)base.Options.GetTypeInfo(typeof(EPlayPointState)));
				}
				return result;
			}
		}

		// Token: 0x06047E43 RID: 294467 RVA: 0x01266BBC File Offset: 0x01264DBC
		[NullableContext(1)]
		private JsonTypeInfo<EPlayPointState> Create_EPlayPointState(JsonSerializerOptions options)
		{
			JsonTypeInfo<EPlayPointState> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EPlayPointState>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EPlayPointState>(options, JsonMetadataServices.GetEnumConverter<EPlayPointState>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB8 RID: 40632
		// (get) Token: 0x06047E44 RID: 294468 RVA: 0x01266BE8 File Offset: 0x01264DE8
		public JsonTypeInfo<ERouletteType> ERouletteType
		{
			get
			{
				JsonTypeInfo<ERouletteType> result;
				if ((result = this._ERouletteType) == null)
				{
					result = (this._ERouletteType = (JsonTypeInfo<ERouletteType>)base.Options.GetTypeInfo(typeof(ERouletteType)));
				}
				return result;
			}
		}

		// Token: 0x06047E45 RID: 294469 RVA: 0x01266C24 File Offset: 0x01264E24
		[NullableContext(1)]
		private JsonTypeInfo<ERouletteType> Create_ERouletteType(JsonSerializerOptions options)
		{
			JsonTypeInfo<ERouletteType> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ERouletteType>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<ERouletteType>(options, JsonMetadataServices.GetEnumConverter<ERouletteType>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EB9 RID: 40633
		// (get) Token: 0x06047E46 RID: 294470 RVA: 0x01266C50 File Offset: 0x01264E50
		public JsonTypeInfo<ERouletteType?> NullableERouletteType
		{
			get
			{
				JsonTypeInfo<ERouletteType?> result;
				if ((result = this._NullableERouletteType) == null)
				{
					result = (this._NullableERouletteType = (JsonTypeInfo<ERouletteType?>)base.Options.GetTypeInfo(typeof(ERouletteType?)));
				}
				return result;
			}
		}

		// Token: 0x06047E47 RID: 294471 RVA: 0x01266C8C File Offset: 0x01264E8C
		[NullableContext(1)]
		private JsonTypeInfo<ERouletteType?> Create_NullableERouletteType(JsonSerializerOptions options)
		{
			JsonTypeInfo<ERouletteType?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ERouletteType?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<ERouletteType>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<ERouletteType?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EBA RID: 40634
		// (get) Token: 0x06047E48 RID: 294472 RVA: 0x01266CBC File Offset: 0x01264EBC
		public JsonTypeInfo<EVisionLevelUpIdentify> EVisionLevelUpIdentify
		{
			get
			{
				JsonTypeInfo<EVisionLevelUpIdentify> result;
				if ((result = this._EVisionLevelUpIdentify) == null)
				{
					result = (this._EVisionLevelUpIdentify = (JsonTypeInfo<EVisionLevelUpIdentify>)base.Options.GetTypeInfo(typeof(EVisionLevelUpIdentify)));
				}
				return result;
			}
		}

		// Token: 0x06047E49 RID: 294473 RVA: 0x01266CF8 File Offset: 0x01264EF8
		[NullableContext(1)]
		private JsonTypeInfo<EVisionLevelUpIdentify> Create_EVisionLevelUpIdentify(JsonSerializerOptions options)
		{
			JsonTypeInfo<EVisionLevelUpIdentify> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EVisionLevelUpIdentify>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EVisionLevelUpIdentify>(options, JsonMetadataServices.GetEnumConverter<EVisionLevelUpIdentify>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EBB RID: 40635
		// (get) Token: 0x06047E4A RID: 294474 RVA: 0x01266D24 File Offset: 0x01264F24
		public JsonTypeInfo<EVisionLevelUpIdentify?> NullableEVisionLevelUpIdentify
		{
			get
			{
				JsonTypeInfo<EVisionLevelUpIdentify?> result;
				if ((result = this._NullableEVisionLevelUpIdentify) == null)
				{
					result = (this._NullableEVisionLevelUpIdentify = (JsonTypeInfo<EVisionLevelUpIdentify?>)base.Options.GetTypeInfo(typeof(EVisionLevelUpIdentify?)));
				}
				return result;
			}
		}

		// Token: 0x06047E4B RID: 294475 RVA: 0x01266D60 File Offset: 0x01264F60
		[NullableContext(1)]
		private JsonTypeInfo<EVisionLevelUpIdentify?> Create_NullableEVisionLevelUpIdentify(JsonSerializerOptions options)
		{
			JsonTypeInfo<EVisionLevelUpIdentify?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EVisionLevelUpIdentify?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<EVisionLevelUpIdentify>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EVisionLevelUpIdentify?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EBC RID: 40636
		// (get) Token: 0x06047E4C RID: 294476 RVA: 0x01266D90 File Offset: 0x01264F90
		public JsonTypeInfo<EVisionLevelUpMaterialPutInMode> EVisionLevelUpMaterialPutInMode
		{
			get
			{
				JsonTypeInfo<EVisionLevelUpMaterialPutInMode> result;
				if ((result = this._EVisionLevelUpMaterialPutInMode) == null)
				{
					result = (this._EVisionLevelUpMaterialPutInMode = (JsonTypeInfo<EVisionLevelUpMaterialPutInMode>)base.Options.GetTypeInfo(typeof(EVisionLevelUpMaterialPutInMode)));
				}
				return result;
			}
		}

		// Token: 0x06047E4D RID: 294477 RVA: 0x01266DCC File Offset: 0x01264FCC
		[NullableContext(1)]
		private JsonTypeInfo<EVisionLevelUpMaterialPutInMode> Create_EVisionLevelUpMaterialPutInMode(JsonSerializerOptions options)
		{
			JsonTypeInfo<EVisionLevelUpMaterialPutInMode> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EVisionLevelUpMaterialPutInMode>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EVisionLevelUpMaterialPutInMode>(options, JsonMetadataServices.GetEnumConverter<EVisionLevelUpMaterialPutInMode>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EBD RID: 40637
		// (get) Token: 0x06047E4E RID: 294478 RVA: 0x01266DF8 File Offset: 0x01264FF8
		public JsonTypeInfo<EVisionLevelUpMaterialPutInMode?> NullableEVisionLevelUpMaterialPutInMode
		{
			get
			{
				JsonTypeInfo<EVisionLevelUpMaterialPutInMode?> result;
				if ((result = this._NullableEVisionLevelUpMaterialPutInMode) == null)
				{
					result = (this._NullableEVisionLevelUpMaterialPutInMode = (JsonTypeInfo<EVisionLevelUpMaterialPutInMode?>)base.Options.GetTypeInfo(typeof(EVisionLevelUpMaterialPutInMode?)));
				}
				return result;
			}
		}

		// Token: 0x06047E4F RID: 294479 RVA: 0x01266E34 File Offset: 0x01265034
		[NullableContext(1)]
		private JsonTypeInfo<EVisionLevelUpMaterialPutInMode?> Create_NullableEVisionLevelUpMaterialPutInMode(JsonSerializerOptions options)
		{
			JsonTypeInfo<EVisionLevelUpMaterialPutInMode?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EVisionLevelUpMaterialPutInMode?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<EVisionLevelUpMaterialPutInMode>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EVisionLevelUpMaterialPutInMode?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EBE RID: 40638
		// (get) Token: 0x06047E50 RID: 294480 RVA: 0x01266E64 File Offset: 0x01265064
		public JsonTypeInfo<EVisionLevelUpMaterialUseType> EVisionLevelUpMaterialUseType
		{
			get
			{
				JsonTypeInfo<EVisionLevelUpMaterialUseType> result;
				if ((result = this._EVisionLevelUpMaterialUseType) == null)
				{
					result = (this._EVisionLevelUpMaterialUseType = (JsonTypeInfo<EVisionLevelUpMaterialUseType>)base.Options.GetTypeInfo(typeof(EVisionLevelUpMaterialUseType)));
				}
				return result;
			}
		}

		// Token: 0x06047E51 RID: 294481 RVA: 0x01266EA0 File Offset: 0x012650A0
		[NullableContext(1)]
		private JsonTypeInfo<EVisionLevelUpMaterialUseType> Create_EVisionLevelUpMaterialUseType(JsonSerializerOptions options)
		{
			JsonTypeInfo<EVisionLevelUpMaterialUseType> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EVisionLevelUpMaterialUseType>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EVisionLevelUpMaterialUseType>(options, JsonMetadataServices.GetEnumConverter<EVisionLevelUpMaterialUseType>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EBF RID: 40639
		// (get) Token: 0x06047E52 RID: 294482 RVA: 0x01266ECC File Offset: 0x012650CC
		public JsonTypeInfo<EVisionLevelUpMaterialUseType?> NullableEVisionLevelUpMaterialUseType
		{
			get
			{
				JsonTypeInfo<EVisionLevelUpMaterialUseType?> result;
				if ((result = this._NullableEVisionLevelUpMaterialUseType) == null)
				{
					result = (this._NullableEVisionLevelUpMaterialUseType = (JsonTypeInfo<EVisionLevelUpMaterialUseType?>)base.Options.GetTypeInfo(typeof(EVisionLevelUpMaterialUseType?)));
				}
				return result;
			}
		}

		// Token: 0x06047E53 RID: 294483 RVA: 0x01266F08 File Offset: 0x01265108
		[NullableContext(1)]
		private JsonTypeInfo<EVisionLevelUpMaterialUseType?> Create_NullableEVisionLevelUpMaterialUseType(JsonSerializerOptions options)
		{
			JsonTypeInfo<EVisionLevelUpMaterialUseType?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EVisionLevelUpMaterialUseType?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<EVisionLevelUpMaterialUseType>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<EVisionLevelUpMaterialUseType?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EC0 RID: 40640
		// (get) Token: 0x06047E54 RID: 294484 RVA: 0x01266F38 File Offset: 0x01265138
		public JsonTypeInfo<FilterDefine.EFilterType> EFilterType
		{
			get
			{
				JsonTypeInfo<FilterDefine.EFilterType> result;
				if ((result = this._EFilterType) == null)
				{
					result = (this._EFilterType = (JsonTypeInfo<FilterDefine.EFilterType>)base.Options.GetTypeInfo(typeof(FilterDefine.EFilterType)));
				}
				return result;
			}
		}

		// Token: 0x06047E55 RID: 294485 RVA: 0x01266F74 File Offset: 0x01265174
		[NullableContext(1)]
		private JsonTypeInfo<FilterDefine.EFilterType> Create_EFilterType(JsonSerializerOptions options)
		{
			JsonTypeInfo<FilterDefine.EFilterType> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<FilterDefine.EFilterType>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<FilterDefine.EFilterType>(options, JsonMetadataServices.GetEnumConverter<FilterDefine.EFilterType>(options));
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EC1 RID: 40641
		// (get) Token: 0x06047E56 RID: 294486 RVA: 0x01266FA0 File Offset: 0x012651A0
		public JsonTypeInfo<FilterStorageData> FilterStorageData
		{
			get
			{
				JsonTypeInfo<FilterStorageData> result;
				if ((result = this._FilterStorageData) == null)
				{
					result = (this._FilterStorageData = (JsonTypeInfo<FilterStorageData>)base.Options.GetTypeInfo(typeof(FilterStorageData)));
				}
				return result;
			}
		}

		// Token: 0x06047E57 RID: 294487 RVA: 0x01266FDC File Offset: 0x012651DC
		[NullableContext(1)]
		private JsonTypeInfo<FilterStorageData> Create_FilterStorageData(JsonSerializerOptions options)
		{
			JsonTypeInfo<FilterStorageData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<FilterStorageData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<FilterStorageData> jsonObjectInfoValues = new JsonObjectInfoValues<FilterStorageData>();
				jsonObjectInfoValues.ObjectCreator = (() => new FilterStorageData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.FilterStorageDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(FilterStorageData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<FilterStorageData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<FilterStorageData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E58 RID: 294488 RVA: 0x012670A4 File Offset: 0x012652A4
		[NullableContext(1)]
		private static JsonPropertyInfo[] FilterStorageDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(FilterStorageData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((FilterStorageData)obj).ConfigId);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((FilterStorageData)obj).ConfigId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ConfigId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(FilterStorageData).GetProperty("ConfigId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(int), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<Dictionary<FilterDefine.EFilterType, List<int>>> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<Dictionary<FilterDefine.EFilterType, List<int>>>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(FilterStorageData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((FilterStorageData)obj).SelectRuleMap);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] Dictionary<FilterDefine.EFilterType, List<int>> value)
			{
				((FilterStorageData)obj).SelectRuleMap = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "SelectRuleMap";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(FilterStorageData).GetProperty("SelectRuleMap", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(Dictionary<FilterDefine.EFilterType, List<int>>), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<Dictionary<FilterDefine.EFilterType, List<int>>> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<Dictionary<FilterDefine.EFilterType, List<int>>>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17009EC2 RID: 40642
		// (get) Token: 0x06047E59 RID: 294489 RVA: 0x0126729C File Offset: 0x0126549C
		public JsonTypeInfo<GamepadTypeUsage> GamepadTypeUsage
		{
			get
			{
				JsonTypeInfo<GamepadTypeUsage> result;
				if ((result = this._GamepadTypeUsage) == null)
				{
					result = (this._GamepadTypeUsage = (JsonTypeInfo<GamepadTypeUsage>)base.Options.GetTypeInfo(typeof(GamepadTypeUsage)));
				}
				return result;
			}
		}

		// Token: 0x06047E5A RID: 294490 RVA: 0x012672D8 File Offset: 0x012654D8
		[NullableContext(1)]
		private JsonTypeInfo<GamepadTypeUsage> Create_GamepadTypeUsage(JsonSerializerOptions options)
		{
			JsonTypeInfo<GamepadTypeUsage> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<GamepadTypeUsage>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<GamepadTypeUsage> jsonObjectInfoValues = new JsonObjectInfoValues<GamepadTypeUsage>();
				jsonObjectInfoValues.ObjectCreator = (() => new GamepadTypeUsage());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.GamepadTypeUsagePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(GamepadTypeUsage).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<GamepadTypeUsage> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<GamepadTypeUsage>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E5B RID: 294491 RVA: 0x012673A0 File Offset: 0x012655A0
		[NullableContext(1)]
		private static JsonPropertyInfo[] GamepadTypeUsagePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(GamepadTypeUsage);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((GamepadTypeUsage)obj).Count);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((GamepadTypeUsage)obj).Count = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Count";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(GamepadTypeUsage).GetField("Count", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(GamepadTypeUsage);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((GamepadTypeUsage)obj).Time);
			jsonPropertyInfoValues2.Setter = delegate(object obj, double value)
			{
				((GamepadTypeUsage)obj).Time = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Time";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(GamepadTypeUsage).GetField("Time", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17009EC3 RID: 40643
		// (get) Token: 0x06047E5C RID: 294492 RVA: 0x01267588 File Offset: 0x01265788
		public JsonTypeInfo<GameQualityData> GameQualityData
		{
			get
			{
				JsonTypeInfo<GameQualityData> result;
				if ((result = this._GameQualityData) == null)
				{
					result = (this._GameQualityData = (JsonTypeInfo<GameQualityData>)base.Options.GetTypeInfo(typeof(GameQualityData)));
				}
				return result;
			}
		}

		// Token: 0x06047E5D RID: 294493 RVA: 0x012675C4 File Offset: 0x012657C4
		[NullableContext(1)]
		private JsonTypeInfo<GameQualityData> Create_GameQualityData(JsonSerializerOptions options)
		{
			JsonTypeInfo<GameQualityData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<GameQualityData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<GameQualityData> jsonObjectInfoValues = new JsonObjectInfoValues<GameQualityData>();
				jsonObjectInfoValues.ObjectCreator = (() => new GameQualityData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.GameQualityDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(GameQualityData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<GameQualityData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<GameQualityData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E5E RID: 294494 RVA: 0x0126768C File Offset: 0x0126588C
		[NullableContext(1)]
		private static JsonPropertyInfo[] GameQualityDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[52];
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((GameQualityData)obj).KeyQualityLevel);
			jsonPropertyInfoValues.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyQualityLevel = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "KeyQualityLevel";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyQualityLevel", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((GameQualityData)obj).KeyCustomFrameRate);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyCustomFrameRate = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "KeyCustomFrameRate";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyCustomFrameRate", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo2);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((GameQualityData)obj).KeyNewShadowQuality);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNewShadowQuality = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "KeyNewShadowQuality";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNewShadowQuality", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo3);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((GameQualityData)obj).KeyNiagaraQuality);
			jsonPropertyInfoValues4.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNiagaraQuality = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "KeyNiagaraQuality";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNiagaraQuality", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo4);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((GameQualityData)obj).KeyImageDetail);
			jsonPropertyInfoValues5.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyImageDetail = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "KeyImageDetail";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyImageDetail", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo5);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((GameQualityData)obj).KeyAntiAliasing);
			jsonPropertyInfoValues6.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyAntiAliasing = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "KeyAntiAliasing";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyAntiAliasing", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo6);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((GameQualityData)obj).KeySceneAo);
			jsonPropertyInfoValues7.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeySceneAo = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "KeySceneAo";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeySceneAo", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo7);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((GameQualityData)obj).KeyVolumeFog);
			jsonPropertyInfoValues8.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyVolumeFog = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "KeyVolumeFog";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyVolumeFog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo8);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((GameQualityData)obj).KeyVolumeLight);
			jsonPropertyInfoValues9.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyVolumeLight = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "KeyVolumeLight";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyVolumeLight", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo9);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((GameQualityData)obj).KeyMotionBlur);
			jsonPropertyInfoValues10.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyMotionBlur = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "KeyMotionBlur";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyMotionBlur", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo10);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((GameQualityData)obj).KeyStreamLevel);
			jsonPropertyInfoValues11.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyStreamLevel = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "KeyStreamLevel";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyStreamLevel", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo11);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((GameQualityData)obj).KeyPcVsync);
			jsonPropertyInfoValues12.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyPcVsync = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "KeyPcVsync";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyPcVsync", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo12);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((GameQualityData)obj).KeyMobileResolution);
			jsonPropertyInfoValues13.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyMobileResolution = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "KeyMobileResolution";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyMobileResolution", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo13);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((GameQualityData)obj).KeySuperResolution);
			jsonPropertyInfoValues14.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeySuperResolution = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "KeySuperResolution";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeySuperResolution", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo14);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues15 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues15.IsProperty = false;
			jsonPropertyInfoValues15.IsPublic = true;
			jsonPropertyInfoValues15.IsVirtual = false;
			jsonPropertyInfoValues15.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues15.Converter = null;
			jsonPropertyInfoValues15.Getter = ((object obj) => ((GameQualityData)obj).KeyPcResolutionWidth);
			jsonPropertyInfoValues15.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyPcResolutionWidth = value;
			};
			jsonPropertyInfoValues15.IgnoreCondition = null;
			jsonPropertyInfoValues15.HasJsonInclude = false;
			jsonPropertyInfoValues15.IsExtensionData = false;
			jsonPropertyInfoValues15.NumberHandling = null;
			jsonPropertyInfoValues15.PropertyName = "KeyPcResolutionWidth";
			jsonPropertyInfoValues15.JsonPropertyName = null;
			jsonPropertyInfoValues15.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyPcResolutionWidth", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo15 = jsonPropertyInfoValues15;
			array[14] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo15);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues16 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues16.IsProperty = false;
			jsonPropertyInfoValues16.IsPublic = true;
			jsonPropertyInfoValues16.IsVirtual = false;
			jsonPropertyInfoValues16.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues16.Converter = null;
			jsonPropertyInfoValues16.Getter = ((object obj) => ((GameQualityData)obj).KeyPcResolutionHeight);
			jsonPropertyInfoValues16.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyPcResolutionHeight = value;
			};
			jsonPropertyInfoValues16.IgnoreCondition = null;
			jsonPropertyInfoValues16.HasJsonInclude = false;
			jsonPropertyInfoValues16.IsExtensionData = false;
			jsonPropertyInfoValues16.NumberHandling = null;
			jsonPropertyInfoValues16.PropertyName = "KeyPcResolutionHeight";
			jsonPropertyInfoValues16.JsonPropertyName = null;
			jsonPropertyInfoValues16.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyPcResolutionHeight", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo16 = jsonPropertyInfoValues16;
			array[15] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo16);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues17 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues17.IsProperty = false;
			jsonPropertyInfoValues17.IsPublic = true;
			jsonPropertyInfoValues17.IsVirtual = false;
			jsonPropertyInfoValues17.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues17.Converter = null;
			jsonPropertyInfoValues17.Getter = ((object obj) => ((GameQualityData)obj).KeyBrightness);
			jsonPropertyInfoValues17.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyBrightness = value;
			};
			jsonPropertyInfoValues17.IgnoreCondition = null;
			jsonPropertyInfoValues17.HasJsonInclude = false;
			jsonPropertyInfoValues17.IsExtensionData = false;
			jsonPropertyInfoValues17.NumberHandling = null;
			jsonPropertyInfoValues17.PropertyName = "KeyBrightness";
			jsonPropertyInfoValues17.JsonPropertyName = null;
			jsonPropertyInfoValues17.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyBrightness", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo17 = jsonPropertyInfoValues17;
			array[16] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo17);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues18 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues18.IsProperty = false;
			jsonPropertyInfoValues18.IsPublic = true;
			jsonPropertyInfoValues18.IsVirtual = false;
			jsonPropertyInfoValues18.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues18.Converter = null;
			jsonPropertyInfoValues18.Getter = ((object obj) => ((GameQualityData)obj).KeyPcWindowMode);
			jsonPropertyInfoValues18.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyPcWindowMode = value;
			};
			jsonPropertyInfoValues18.IgnoreCondition = null;
			jsonPropertyInfoValues18.HasJsonInclude = false;
			jsonPropertyInfoValues18.IsExtensionData = false;
			jsonPropertyInfoValues18.NumberHandling = null;
			jsonPropertyInfoValues18.PropertyName = "KeyPcWindowMode";
			jsonPropertyInfoValues18.JsonPropertyName = null;
			jsonPropertyInfoValues18.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyPcWindowMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo18 = jsonPropertyInfoValues18;
			array[17] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo18);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues19 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues19.IsProperty = false;
			jsonPropertyInfoValues19.IsPublic = true;
			jsonPropertyInfoValues19.IsVirtual = false;
			jsonPropertyInfoValues19.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues19.Converter = null;
			jsonPropertyInfoValues19.Getter = ((object obj) => ((GameQualityData)obj).KeyNvidiaSuperSamplingEnable);
			jsonPropertyInfoValues19.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNvidiaSuperSamplingEnable = value;
			};
			jsonPropertyInfoValues19.IgnoreCondition = null;
			jsonPropertyInfoValues19.HasJsonInclude = false;
			jsonPropertyInfoValues19.IsExtensionData = false;
			jsonPropertyInfoValues19.NumberHandling = null;
			jsonPropertyInfoValues19.PropertyName = "KeyNvidiaSuperSamplingEnable";
			jsonPropertyInfoValues19.JsonPropertyName = null;
			jsonPropertyInfoValues19.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNvidiaSuperSamplingEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo19 = jsonPropertyInfoValues19;
			array[18] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo19);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues20 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues20.IsProperty = false;
			jsonPropertyInfoValues20.IsPublic = true;
			jsonPropertyInfoValues20.IsVirtual = false;
			jsonPropertyInfoValues20.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues20.Converter = null;
			jsonPropertyInfoValues20.Getter = ((object obj) => ((GameQualityData)obj).KeyNvidiaSuperSamplingFrameGenerate);
			jsonPropertyInfoValues20.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNvidiaSuperSamplingFrameGenerate = value;
			};
			jsonPropertyInfoValues20.IgnoreCondition = null;
			jsonPropertyInfoValues20.HasJsonInclude = false;
			jsonPropertyInfoValues20.IsExtensionData = false;
			jsonPropertyInfoValues20.NumberHandling = null;
			jsonPropertyInfoValues20.PropertyName = "KeyNvidiaSuperSamplingFrameGenerate";
			jsonPropertyInfoValues20.JsonPropertyName = null;
			jsonPropertyInfoValues20.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNvidiaSuperSamplingFrameGenerate", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo20 = jsonPropertyInfoValues20;
			array[19] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo20);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues21 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues21.IsProperty = false;
			jsonPropertyInfoValues21.IsPublic = true;
			jsonPropertyInfoValues21.IsVirtual = false;
			jsonPropertyInfoValues21.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues21.Converter = null;
			jsonPropertyInfoValues21.Getter = ((object obj) => ((GameQualityData)obj).KeyNvidiaSuperSamplingMode);
			jsonPropertyInfoValues21.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNvidiaSuperSamplingMode = value;
			};
			jsonPropertyInfoValues21.IgnoreCondition = null;
			jsonPropertyInfoValues21.HasJsonInclude = false;
			jsonPropertyInfoValues21.IsExtensionData = false;
			jsonPropertyInfoValues21.NumberHandling = null;
			jsonPropertyInfoValues21.PropertyName = "KeyNvidiaSuperSamplingMode";
			jsonPropertyInfoValues21.JsonPropertyName = null;
			jsonPropertyInfoValues21.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNvidiaSuperSamplingMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo21 = jsonPropertyInfoValues21;
			array[20] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo21);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues22 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues22.IsProperty = false;
			jsonPropertyInfoValues22.IsPublic = true;
			jsonPropertyInfoValues22.IsVirtual = false;
			jsonPropertyInfoValues22.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues22.Converter = null;
			jsonPropertyInfoValues22.Getter = ((object obj) => ((GameQualityData)obj).KeyNvidiaSuperSamplingSharpness);
			jsonPropertyInfoValues22.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNvidiaSuperSamplingSharpness = value;
			};
			jsonPropertyInfoValues22.IgnoreCondition = null;
			jsonPropertyInfoValues22.HasJsonInclude = false;
			jsonPropertyInfoValues22.IsExtensionData = false;
			jsonPropertyInfoValues22.NumberHandling = null;
			jsonPropertyInfoValues22.PropertyName = "KeyNvidiaSuperSamplingSharpness";
			jsonPropertyInfoValues22.JsonPropertyName = null;
			jsonPropertyInfoValues22.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNvidiaSuperSamplingSharpness", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo22 = jsonPropertyInfoValues22;
			array[21] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo22);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues23 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues23.IsProperty = false;
			jsonPropertyInfoValues23.IsPublic = true;
			jsonPropertyInfoValues23.IsVirtual = false;
			jsonPropertyInfoValues23.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues23.Converter = null;
			jsonPropertyInfoValues23.Getter = ((object obj) => ((GameQualityData)obj).KeyNvidiaReflex);
			jsonPropertyInfoValues23.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNvidiaReflex = value;
			};
			jsonPropertyInfoValues23.IgnoreCondition = null;
			jsonPropertyInfoValues23.HasJsonInclude = false;
			jsonPropertyInfoValues23.IsExtensionData = false;
			jsonPropertyInfoValues23.NumberHandling = null;
			jsonPropertyInfoValues23.PropertyName = "KeyNvidiaReflex";
			jsonPropertyInfoValues23.JsonPropertyName = null;
			jsonPropertyInfoValues23.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNvidiaReflex", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo23 = jsonPropertyInfoValues23;
			array[22] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo23);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues24 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues24.IsProperty = false;
			jsonPropertyInfoValues24.IsPublic = true;
			jsonPropertyInfoValues24.IsVirtual = false;
			jsonPropertyInfoValues24.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues24.Converter = null;
			jsonPropertyInfoValues24.Getter = ((object obj) => ((GameQualityData)obj).KeyFsrEnable);
			jsonPropertyInfoValues24.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyFsrEnable = value;
			};
			jsonPropertyInfoValues24.IgnoreCondition = null;
			jsonPropertyInfoValues24.HasJsonInclude = false;
			jsonPropertyInfoValues24.IsExtensionData = false;
			jsonPropertyInfoValues24.NumberHandling = null;
			jsonPropertyInfoValues24.PropertyName = "KeyFsrEnable";
			jsonPropertyInfoValues24.JsonPropertyName = null;
			jsonPropertyInfoValues24.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyFsrEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo24 = jsonPropertyInfoValues24;
			array[23] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo24);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues25 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues25.IsProperty = false;
			jsonPropertyInfoValues25.IsPublic = true;
			jsonPropertyInfoValues25.IsVirtual = false;
			jsonPropertyInfoValues25.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues25.Converter = null;
			jsonPropertyInfoValues25.Getter = ((object obj) => ((GameQualityData)obj).KeyXessEnable);
			jsonPropertyInfoValues25.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyXessEnable = value;
			};
			jsonPropertyInfoValues25.IgnoreCondition = null;
			jsonPropertyInfoValues25.HasJsonInclude = false;
			jsonPropertyInfoValues25.IsExtensionData = false;
			jsonPropertyInfoValues25.NumberHandling = null;
			jsonPropertyInfoValues25.PropertyName = "KeyXessEnable";
			jsonPropertyInfoValues25.JsonPropertyName = null;
			jsonPropertyInfoValues25.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyXessEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo25 = jsonPropertyInfoValues25;
			array[24] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo25);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues26 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues26.IsProperty = false;
			jsonPropertyInfoValues26.IsPublic = true;
			jsonPropertyInfoValues26.IsVirtual = false;
			jsonPropertyInfoValues26.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues26.Converter = null;
			jsonPropertyInfoValues26.Getter = ((object obj) => ((GameQualityData)obj).KeyXessQuality);
			jsonPropertyInfoValues26.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyXessQuality = value;
			};
			jsonPropertyInfoValues26.IgnoreCondition = null;
			jsonPropertyInfoValues26.HasJsonInclude = false;
			jsonPropertyInfoValues26.IsExtensionData = false;
			jsonPropertyInfoValues26.NumberHandling = null;
			jsonPropertyInfoValues26.PropertyName = "KeyXessQuality";
			jsonPropertyInfoValues26.JsonPropertyName = null;
			jsonPropertyInfoValues26.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyXessQuality", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo26 = jsonPropertyInfoValues26;
			array[25] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo26);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues27 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues27.IsProperty = false;
			jsonPropertyInfoValues27.IsPublic = true;
			jsonPropertyInfoValues27.IsVirtual = false;
			jsonPropertyInfoValues27.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues27.Converter = null;
			jsonPropertyInfoValues27.Getter = ((object obj) => ((GameQualityData)obj).KeyMetalFxEnable);
			jsonPropertyInfoValues27.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyMetalFxEnable = value;
			};
			jsonPropertyInfoValues27.IgnoreCondition = null;
			jsonPropertyInfoValues27.HasJsonInclude = false;
			jsonPropertyInfoValues27.IsExtensionData = false;
			jsonPropertyInfoValues27.NumberHandling = null;
			jsonPropertyInfoValues27.PropertyName = "KeyMetalFxEnable";
			jsonPropertyInfoValues27.JsonPropertyName = null;
			jsonPropertyInfoValues27.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyMetalFxEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo27 = jsonPropertyInfoValues27;
			array[26] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo27);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues28 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues28.IsProperty = false;
			jsonPropertyInfoValues28.IsPublic = true;
			jsonPropertyInfoValues28.IsVirtual = false;
			jsonPropertyInfoValues28.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues28.Converter = null;
			jsonPropertyInfoValues28.Getter = ((object obj) => ((GameQualityData)obj).KeyIrxEnable);
			jsonPropertyInfoValues28.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyIrxEnable = value;
			};
			jsonPropertyInfoValues28.IgnoreCondition = null;
			jsonPropertyInfoValues28.HasJsonInclude = false;
			jsonPropertyInfoValues28.IsExtensionData = false;
			jsonPropertyInfoValues28.NumberHandling = null;
			jsonPropertyInfoValues28.PropertyName = "KeyIrxEnable";
			jsonPropertyInfoValues28.JsonPropertyName = null;
			jsonPropertyInfoValues28.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyIrxEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo28 = jsonPropertyInfoValues28;
			array[27] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo28);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues29 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues29.IsProperty = false;
			jsonPropertyInfoValues29.IsPublic = true;
			jsonPropertyInfoValues29.IsVirtual = false;
			jsonPropertyInfoValues29.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues29.Converter = null;
			jsonPropertyInfoValues29.Getter = ((object obj) => ((GameQualityData)obj).KeyBloomEnable);
			jsonPropertyInfoValues29.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyBloomEnable = value;
			};
			jsonPropertyInfoValues29.IgnoreCondition = null;
			jsonPropertyInfoValues29.HasJsonInclude = false;
			jsonPropertyInfoValues29.IsExtensionData = false;
			jsonPropertyInfoValues29.NumberHandling = null;
			jsonPropertyInfoValues29.PropertyName = "KeyBloomEnable";
			jsonPropertyInfoValues29.JsonPropertyName = null;
			jsonPropertyInfoValues29.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyBloomEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo29 = jsonPropertyInfoValues29;
			array[28] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo29);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues30 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues30.IsProperty = false;
			jsonPropertyInfoValues30.IsPublic = true;
			jsonPropertyInfoValues30.IsVirtual = false;
			jsonPropertyInfoValues30.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues30.Converter = null;
			jsonPropertyInfoValues30.Getter = ((object obj) => ((GameQualityData)obj).KeyNpcDensity);
			jsonPropertyInfoValues30.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).KeyNpcDensity = value;
			};
			jsonPropertyInfoValues30.IgnoreCondition = null;
			jsonPropertyInfoValues30.HasJsonInclude = false;
			jsonPropertyInfoValues30.IsExtensionData = false;
			jsonPropertyInfoValues30.NumberHandling = null;
			jsonPropertyInfoValues30.PropertyName = "KeyNpcDensity";
			jsonPropertyInfoValues30.JsonPropertyName = null;
			jsonPropertyInfoValues30.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("KeyNpcDensity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo30 = jsonPropertyInfoValues30;
			array[29] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo30);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues31 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues31.IsProperty = false;
			jsonPropertyInfoValues31.IsPublic = true;
			jsonPropertyInfoValues31.IsVirtual = false;
			jsonPropertyInfoValues31.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues31.Converter = null;
			jsonPropertyInfoValues31.Getter = ((object obj) => ((GameQualityData)obj).HorizontalViewSensitivity);
			jsonPropertyInfoValues31.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).HorizontalViewSensitivity = value;
			};
			jsonPropertyInfoValues31.IgnoreCondition = null;
			jsonPropertyInfoValues31.HasJsonInclude = false;
			jsonPropertyInfoValues31.IsExtensionData = false;
			jsonPropertyInfoValues31.NumberHandling = null;
			jsonPropertyInfoValues31.PropertyName = "HorizontalViewSensitivity";
			jsonPropertyInfoValues31.JsonPropertyName = null;
			jsonPropertyInfoValues31.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("HorizontalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo31 = jsonPropertyInfoValues31;
			array[30] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo31);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues32 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues32.IsProperty = false;
			jsonPropertyInfoValues32.IsPublic = true;
			jsonPropertyInfoValues32.IsVirtual = false;
			jsonPropertyInfoValues32.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues32.Converter = null;
			jsonPropertyInfoValues32.Getter = ((object obj) => ((GameQualityData)obj).VerticalViewSensitivity);
			jsonPropertyInfoValues32.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).VerticalViewSensitivity = value;
			};
			jsonPropertyInfoValues32.IgnoreCondition = null;
			jsonPropertyInfoValues32.HasJsonInclude = false;
			jsonPropertyInfoValues32.IsExtensionData = false;
			jsonPropertyInfoValues32.NumberHandling = null;
			jsonPropertyInfoValues32.PropertyName = "VerticalViewSensitivity";
			jsonPropertyInfoValues32.JsonPropertyName = null;
			jsonPropertyInfoValues32.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("VerticalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo32 = jsonPropertyInfoValues32;
			array[31] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo32);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues33 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues33.IsProperty = false;
			jsonPropertyInfoValues33.IsPublic = true;
			jsonPropertyInfoValues33.IsVirtual = false;
			jsonPropertyInfoValues33.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues33.Converter = null;
			jsonPropertyInfoValues33.Getter = ((object obj) => ((GameQualityData)obj).AimHorizontalViewSensitivity);
			jsonPropertyInfoValues33.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).AimHorizontalViewSensitivity = value;
			};
			jsonPropertyInfoValues33.IgnoreCondition = null;
			jsonPropertyInfoValues33.HasJsonInclude = false;
			jsonPropertyInfoValues33.IsExtensionData = false;
			jsonPropertyInfoValues33.NumberHandling = null;
			jsonPropertyInfoValues33.PropertyName = "AimHorizontalViewSensitivity";
			jsonPropertyInfoValues33.JsonPropertyName = null;
			jsonPropertyInfoValues33.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("AimHorizontalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo33 = jsonPropertyInfoValues33;
			array[32] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo33);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues34 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues34.IsProperty = false;
			jsonPropertyInfoValues34.IsPublic = true;
			jsonPropertyInfoValues34.IsVirtual = false;
			jsonPropertyInfoValues34.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues34.Converter = null;
			jsonPropertyInfoValues34.Getter = ((object obj) => ((GameQualityData)obj).AimVerticalViewSensitivity);
			jsonPropertyInfoValues34.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).AimVerticalViewSensitivity = value;
			};
			jsonPropertyInfoValues34.IgnoreCondition = null;
			jsonPropertyInfoValues34.HasJsonInclude = false;
			jsonPropertyInfoValues34.IsExtensionData = false;
			jsonPropertyInfoValues34.NumberHandling = null;
			jsonPropertyInfoValues34.PropertyName = "AimVerticalViewSensitivity";
			jsonPropertyInfoValues34.JsonPropertyName = null;
			jsonPropertyInfoValues34.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("AimVerticalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo34 = jsonPropertyInfoValues34;
			array[33] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo34);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues35 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues35.IsProperty = false;
			jsonPropertyInfoValues35.IsPublic = true;
			jsonPropertyInfoValues35.IsVirtual = false;
			jsonPropertyInfoValues35.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues35.Converter = null;
			jsonPropertyInfoValues35.Getter = ((object obj) => ((GameQualityData)obj).CameraShakeStrength);
			jsonPropertyInfoValues35.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).CameraShakeStrength = value;
			};
			jsonPropertyInfoValues35.IgnoreCondition = null;
			jsonPropertyInfoValues35.HasJsonInclude = false;
			jsonPropertyInfoValues35.IsExtensionData = false;
			jsonPropertyInfoValues35.NumberHandling = null;
			jsonPropertyInfoValues35.PropertyName = "CameraShakeStrength";
			jsonPropertyInfoValues35.JsonPropertyName = null;
			jsonPropertyInfoValues35.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("CameraShakeStrength", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo35 = jsonPropertyInfoValues35;
			array[34] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo35);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues36 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues36.IsProperty = false;
			jsonPropertyInfoValues36.IsPublic = true;
			jsonPropertyInfoValues36.IsVirtual = false;
			jsonPropertyInfoValues36.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues36.Converter = null;
			jsonPropertyInfoValues36.Getter = ((object obj) => ((GameQualityData)obj).MobileHorizontalViewSensitivity);
			jsonPropertyInfoValues36.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).MobileHorizontalViewSensitivity = value;
			};
			jsonPropertyInfoValues36.IgnoreCondition = null;
			jsonPropertyInfoValues36.HasJsonInclude = false;
			jsonPropertyInfoValues36.IsExtensionData = false;
			jsonPropertyInfoValues36.NumberHandling = null;
			jsonPropertyInfoValues36.PropertyName = "MobileHorizontalViewSensitivity";
			jsonPropertyInfoValues36.JsonPropertyName = null;
			jsonPropertyInfoValues36.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("MobileHorizontalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo36 = jsonPropertyInfoValues36;
			array[35] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo36);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues37 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues37.IsProperty = false;
			jsonPropertyInfoValues37.IsPublic = true;
			jsonPropertyInfoValues37.IsVirtual = false;
			jsonPropertyInfoValues37.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues37.Converter = null;
			jsonPropertyInfoValues37.Getter = ((object obj) => ((GameQualityData)obj).MobileVerticalViewSensitivity);
			jsonPropertyInfoValues37.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).MobileVerticalViewSensitivity = value;
			};
			jsonPropertyInfoValues37.IgnoreCondition = null;
			jsonPropertyInfoValues37.HasJsonInclude = false;
			jsonPropertyInfoValues37.IsExtensionData = false;
			jsonPropertyInfoValues37.NumberHandling = null;
			jsonPropertyInfoValues37.PropertyName = "MobileVerticalViewSensitivity";
			jsonPropertyInfoValues37.JsonPropertyName = null;
			jsonPropertyInfoValues37.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("MobileVerticalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo37 = jsonPropertyInfoValues37;
			array[36] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo37);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues38 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues38.IsProperty = false;
			jsonPropertyInfoValues38.IsPublic = true;
			jsonPropertyInfoValues38.IsVirtual = false;
			jsonPropertyInfoValues38.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues38.Converter = null;
			jsonPropertyInfoValues38.Getter = ((object obj) => ((GameQualityData)obj).MobileAimHorizontalViewSensitivity);
			jsonPropertyInfoValues38.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).MobileAimHorizontalViewSensitivity = value;
			};
			jsonPropertyInfoValues38.IgnoreCondition = null;
			jsonPropertyInfoValues38.HasJsonInclude = false;
			jsonPropertyInfoValues38.IsExtensionData = false;
			jsonPropertyInfoValues38.NumberHandling = null;
			jsonPropertyInfoValues38.PropertyName = "MobileAimHorizontalViewSensitivity";
			jsonPropertyInfoValues38.JsonPropertyName = null;
			jsonPropertyInfoValues38.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("MobileAimHorizontalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo38 = jsonPropertyInfoValues38;
			array[37] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo38);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues39 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues39.IsProperty = false;
			jsonPropertyInfoValues39.IsPublic = true;
			jsonPropertyInfoValues39.IsVirtual = false;
			jsonPropertyInfoValues39.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues39.Converter = null;
			jsonPropertyInfoValues39.Getter = ((object obj) => ((GameQualityData)obj).MobileAimVerticalViewSensitivity);
			jsonPropertyInfoValues39.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).MobileAimVerticalViewSensitivity = value;
			};
			jsonPropertyInfoValues39.IgnoreCondition = null;
			jsonPropertyInfoValues39.HasJsonInclude = false;
			jsonPropertyInfoValues39.IsExtensionData = false;
			jsonPropertyInfoValues39.NumberHandling = null;
			jsonPropertyInfoValues39.PropertyName = "MobileAimVerticalViewSensitivity";
			jsonPropertyInfoValues39.JsonPropertyName = null;
			jsonPropertyInfoValues39.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("MobileAimVerticalViewSensitivity", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo39 = jsonPropertyInfoValues39;
			array[38] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo39);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues40 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues40.IsProperty = false;
			jsonPropertyInfoValues40.IsPublic = true;
			jsonPropertyInfoValues40.IsVirtual = false;
			jsonPropertyInfoValues40.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues40.Converter = null;
			jsonPropertyInfoValues40.Getter = ((object obj) => ((GameQualityData)obj).CommonSpringArmLength);
			jsonPropertyInfoValues40.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).CommonSpringArmLength = value;
			};
			jsonPropertyInfoValues40.IgnoreCondition = null;
			jsonPropertyInfoValues40.HasJsonInclude = false;
			jsonPropertyInfoValues40.IsExtensionData = false;
			jsonPropertyInfoValues40.NumberHandling = null;
			jsonPropertyInfoValues40.PropertyName = "CommonSpringArmLength";
			jsonPropertyInfoValues40.JsonPropertyName = null;
			jsonPropertyInfoValues40.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("CommonSpringArmLength", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo40 = jsonPropertyInfoValues40;
			array[39] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo40);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues41 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues41.IsProperty = false;
			jsonPropertyInfoValues41.IsPublic = true;
			jsonPropertyInfoValues41.IsVirtual = false;
			jsonPropertyInfoValues41.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues41.Converter = null;
			jsonPropertyInfoValues41.Getter = ((object obj) => ((GameQualityData)obj).FightSpringArmLength);
			jsonPropertyInfoValues41.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).FightSpringArmLength = value;
			};
			jsonPropertyInfoValues41.IgnoreCondition = null;
			jsonPropertyInfoValues41.HasJsonInclude = false;
			jsonPropertyInfoValues41.IsExtensionData = false;
			jsonPropertyInfoValues41.NumberHandling = null;
			jsonPropertyInfoValues41.PropertyName = "FightSpringArmLength";
			jsonPropertyInfoValues41.JsonPropertyName = null;
			jsonPropertyInfoValues41.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("FightSpringArmLength", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo41 = jsonPropertyInfoValues41;
			array[40] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo41);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues42 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues42.IsProperty = false;
			jsonPropertyInfoValues42.IsPublic = true;
			jsonPropertyInfoValues42.IsVirtual = false;
			jsonPropertyInfoValues42.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues42.Converter = null;
			jsonPropertyInfoValues42.Getter = ((object obj) => ((GameQualityData)obj).IsResetFocusEnable);
			jsonPropertyInfoValues42.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).IsResetFocusEnable = value;
			};
			jsonPropertyInfoValues42.IgnoreCondition = null;
			jsonPropertyInfoValues42.HasJsonInclude = false;
			jsonPropertyInfoValues42.IsExtensionData = false;
			jsonPropertyInfoValues42.NumberHandling = null;
			jsonPropertyInfoValues42.PropertyName = "IsResetFocusEnable";
			jsonPropertyInfoValues42.JsonPropertyName = null;
			jsonPropertyInfoValues42.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("IsResetFocusEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo42 = jsonPropertyInfoValues42;
			array[41] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo42);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues43 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues43.IsProperty = false;
			jsonPropertyInfoValues43.IsPublic = true;
			jsonPropertyInfoValues43.IsVirtual = false;
			jsonPropertyInfoValues43.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues43.Converter = null;
			jsonPropertyInfoValues43.Getter = ((object obj) => ((GameQualityData)obj).IsSidestepCameraEnable);
			jsonPropertyInfoValues43.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).IsSidestepCameraEnable = value;
			};
			jsonPropertyInfoValues43.IgnoreCondition = null;
			jsonPropertyInfoValues43.HasJsonInclude = false;
			jsonPropertyInfoValues43.IsExtensionData = false;
			jsonPropertyInfoValues43.NumberHandling = null;
			jsonPropertyInfoValues43.PropertyName = "IsSidestepCameraEnable";
			jsonPropertyInfoValues43.JsonPropertyName = null;
			jsonPropertyInfoValues43.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("IsSidestepCameraEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo43 = jsonPropertyInfoValues43;
			array[42] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo43);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues44 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues44.IsProperty = false;
			jsonPropertyInfoValues44.IsPublic = true;
			jsonPropertyInfoValues44.IsVirtual = false;
			jsonPropertyInfoValues44.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues44.Converter = null;
			jsonPropertyInfoValues44.Getter = ((object obj) => ((GameQualityData)obj).IsSoftLockCameraEnable);
			jsonPropertyInfoValues44.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).IsSoftLockCameraEnable = value;
			};
			jsonPropertyInfoValues44.IgnoreCondition = null;
			jsonPropertyInfoValues44.HasJsonInclude = false;
			jsonPropertyInfoValues44.IsExtensionData = false;
			jsonPropertyInfoValues44.NumberHandling = null;
			jsonPropertyInfoValues44.PropertyName = "IsSoftLockCameraEnable";
			jsonPropertyInfoValues44.JsonPropertyName = null;
			jsonPropertyInfoValues44.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("IsSoftLockCameraEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo44 = jsonPropertyInfoValues44;
			array[43] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo44);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues45 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues45.IsProperty = false;
			jsonPropertyInfoValues45.IsPublic = true;
			jsonPropertyInfoValues45.IsVirtual = false;
			jsonPropertyInfoValues45.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues45.Converter = null;
			jsonPropertyInfoValues45.Getter = ((object obj) => ((GameQualityData)obj).JoystickShakeStrength);
			jsonPropertyInfoValues45.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).JoystickShakeStrength = value;
			};
			jsonPropertyInfoValues45.IgnoreCondition = null;
			jsonPropertyInfoValues45.HasJsonInclude = false;
			jsonPropertyInfoValues45.IsExtensionData = false;
			jsonPropertyInfoValues45.NumberHandling = null;
			jsonPropertyInfoValues45.PropertyName = "JoystickShakeStrength";
			jsonPropertyInfoValues45.JsonPropertyName = null;
			jsonPropertyInfoValues45.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("JoystickShakeStrength", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo45 = jsonPropertyInfoValues45;
			array[44] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo45);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues46 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues46.IsProperty = false;
			jsonPropertyInfoValues46.IsPublic = true;
			jsonPropertyInfoValues46.IsVirtual = false;
			jsonPropertyInfoValues46.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues46.Converter = null;
			jsonPropertyInfoValues46.Getter = ((object obj) => ((GameQualityData)obj).JoystickShakeType);
			jsonPropertyInfoValues46.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).JoystickShakeType = value;
			};
			jsonPropertyInfoValues46.IgnoreCondition = null;
			jsonPropertyInfoValues46.HasJsonInclude = false;
			jsonPropertyInfoValues46.IsExtensionData = false;
			jsonPropertyInfoValues46.NumberHandling = null;
			jsonPropertyInfoValues46.PropertyName = "JoystickShakeType";
			jsonPropertyInfoValues46.JsonPropertyName = null;
			jsonPropertyInfoValues46.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("JoystickShakeType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo46 = jsonPropertyInfoValues46;
			array[45] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo46);
			JsonPropertyInfoValues<float?> jsonPropertyInfoValues47 = new JsonPropertyInfoValues<float?>();
			jsonPropertyInfoValues47.IsProperty = false;
			jsonPropertyInfoValues47.IsPublic = true;
			jsonPropertyInfoValues47.IsVirtual = false;
			jsonPropertyInfoValues47.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues47.Converter = null;
			jsonPropertyInfoValues47.Getter = ((object obj) => ((GameQualityData)obj).WalkOrRunRate);
			jsonPropertyInfoValues47.Setter = delegate(object obj, float? value)
			{
				((GameQualityData)obj).WalkOrRunRate = value;
			};
			jsonPropertyInfoValues47.IgnoreCondition = null;
			jsonPropertyInfoValues47.HasJsonInclude = false;
			jsonPropertyInfoValues47.IsExtensionData = false;
			jsonPropertyInfoValues47.NumberHandling = null;
			jsonPropertyInfoValues47.PropertyName = "WalkOrRunRate";
			jsonPropertyInfoValues47.JsonPropertyName = null;
			jsonPropertyInfoValues47.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("WalkOrRunRate", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<float?> propertyInfo47 = jsonPropertyInfoValues47;
			array[46] = JsonMetadataServices.CreatePropertyInfo<float?>(options, propertyInfo47);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues48 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues48.IsProperty = false;
			jsonPropertyInfoValues48.IsPublic = true;
			jsonPropertyInfoValues48.IsVirtual = false;
			jsonPropertyInfoValues48.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues48.Converter = null;
			jsonPropertyInfoValues48.Getter = ((object obj) => ((GameQualityData)obj).JoystickMode);
			jsonPropertyInfoValues48.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).JoystickMode = value;
			};
			jsonPropertyInfoValues48.IgnoreCondition = null;
			jsonPropertyInfoValues48.HasJsonInclude = false;
			jsonPropertyInfoValues48.IsExtensionData = false;
			jsonPropertyInfoValues48.NumberHandling = null;
			jsonPropertyInfoValues48.PropertyName = "JoystickMode";
			jsonPropertyInfoValues48.JsonPropertyName = null;
			jsonPropertyInfoValues48.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("JoystickMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo48 = jsonPropertyInfoValues48;
			array[47] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo48);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues49 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues49.IsProperty = false;
			jsonPropertyInfoValues49.IsPublic = true;
			jsonPropertyInfoValues49.IsVirtual = false;
			jsonPropertyInfoValues49.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues49.Converter = null;
			jsonPropertyInfoValues49.Getter = ((object obj) => ((GameQualityData)obj).IsAutoSwitchSkillButtonMode);
			jsonPropertyInfoValues49.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).IsAutoSwitchSkillButtonMode = value;
			};
			jsonPropertyInfoValues49.IgnoreCondition = null;
			jsonPropertyInfoValues49.HasJsonInclude = false;
			jsonPropertyInfoValues49.IsExtensionData = false;
			jsonPropertyInfoValues49.NumberHandling = null;
			jsonPropertyInfoValues49.PropertyName = "IsAutoSwitchSkillButtonMode";
			jsonPropertyInfoValues49.JsonPropertyName = null;
			jsonPropertyInfoValues49.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("IsAutoSwitchSkillButtonMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo49 = jsonPropertyInfoValues49;
			array[48] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo49);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues50 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues50.IsProperty = false;
			jsonPropertyInfoValues50.IsPublic = true;
			jsonPropertyInfoValues50.IsVirtual = false;
			jsonPropertyInfoValues50.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues50.Converter = null;
			jsonPropertyInfoValues50.Getter = ((object obj) => ((GameQualityData)obj).AimAssistEnable);
			jsonPropertyInfoValues50.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).AimAssistEnable = value;
			};
			jsonPropertyInfoValues50.IgnoreCondition = null;
			jsonPropertyInfoValues50.HasJsonInclude = false;
			jsonPropertyInfoValues50.IsExtensionData = false;
			jsonPropertyInfoValues50.NumberHandling = null;
			jsonPropertyInfoValues50.PropertyName = "AimAssistEnable";
			jsonPropertyInfoValues50.JsonPropertyName = null;
			jsonPropertyInfoValues50.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("AimAssistEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo50 = jsonPropertyInfoValues50;
			array[49] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo50);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues51 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues51.IsProperty = false;
			jsonPropertyInfoValues51.IsPublic = true;
			jsonPropertyInfoValues51.IsVirtual = false;
			jsonPropertyInfoValues51.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues51.Converter = null;
			jsonPropertyInfoValues51.Getter = ((object obj) => ((GameQualityData)obj).HorizontalViewRevert);
			jsonPropertyInfoValues51.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).HorizontalViewRevert = value;
			};
			jsonPropertyInfoValues51.IgnoreCondition = null;
			jsonPropertyInfoValues51.HasJsonInclude = false;
			jsonPropertyInfoValues51.IsExtensionData = false;
			jsonPropertyInfoValues51.NumberHandling = null;
			jsonPropertyInfoValues51.PropertyName = "HorizontalViewRevert";
			jsonPropertyInfoValues51.JsonPropertyName = null;
			jsonPropertyInfoValues51.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("HorizontalViewRevert", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo51 = jsonPropertyInfoValues51;
			array[50] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo51);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues52 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues52.IsProperty = false;
			jsonPropertyInfoValues52.IsPublic = true;
			jsonPropertyInfoValues52.IsVirtual = false;
			jsonPropertyInfoValues52.DeclaringType = typeof(GameQualityData);
			jsonPropertyInfoValues52.Converter = null;
			jsonPropertyInfoValues52.Getter = ((object obj) => ((GameQualityData)obj).VerticalViewRevert);
			jsonPropertyInfoValues52.Setter = delegate(object obj, int? value)
			{
				((GameQualityData)obj).VerticalViewRevert = value;
			};
			jsonPropertyInfoValues52.IgnoreCondition = null;
			jsonPropertyInfoValues52.HasJsonInclude = false;
			jsonPropertyInfoValues52.IsExtensionData = false;
			jsonPropertyInfoValues52.NumberHandling = null;
			jsonPropertyInfoValues52.PropertyName = "VerticalViewRevert";
			jsonPropertyInfoValues52.JsonPropertyName = null;
			jsonPropertyInfoValues52.AttributeProviderFactory = (() => typeof(GameQualityData).GetField("VerticalViewRevert", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo52 = jsonPropertyInfoValues52;
			array[51] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo52);
			return array;
		}

		// Token: 0x17009EC4 RID: 40644
		// (get) Token: 0x06047E5F RID: 294495 RVA: 0x0126A6E8 File Offset: 0x012688E8
		public JsonTypeInfo<IRacingBetsSettlementMainViewRecord> IRacingBetsSettlementMainViewRecord
		{
			get
			{
				JsonTypeInfo<IRacingBetsSettlementMainViewRecord> result;
				if ((result = this._IRacingBetsSettlementMainViewRecord) == null)
				{
					result = (this._IRacingBetsSettlementMainViewRecord = (JsonTypeInfo<IRacingBetsSettlementMainViewRecord>)base.Options.GetTypeInfo(typeof(IRacingBetsSettlementMainViewRecord)));
				}
				return result;
			}
		}

		// Token: 0x06047E60 RID: 294496 RVA: 0x0126A724 File Offset: 0x01268924
		[NullableContext(1)]
		private JsonTypeInfo<IRacingBetsSettlementMainViewRecord> Create_IRacingBetsSettlementMainViewRecord(JsonSerializerOptions options)
		{
			JsonTypeInfo<IRacingBetsSettlementMainViewRecord> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IRacingBetsSettlementMainViewRecord>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IRacingBetsSettlementMainViewRecord> objectInfo = new JsonObjectInfoValues<IRacingBetsSettlementMainViewRecord>
				{
					ObjectCreator = null,
					ObjectWithParameterizedConstructorCreator = null,
					PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.IRacingBetsSettlementMainViewRecordPropInit(options)),
					ConstructorParameterMetadataInitializer = null,
					ConstructorAttributeProviderFactory = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IRacingBetsSettlementMainViewRecord>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E61 RID: 294497 RVA: 0x0126A7AC File Offset: 0x012689AC
		[NullableContext(1)]
		private static JsonPropertyInfo[] IRacingBetsSettlementMainViewRecordPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = true;
			jsonPropertyInfoValues.DeclaringType = typeof(IRacingBetsSettlementMainViewRecord);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IRacingBetsSettlementMainViewRecord)obj).SeasonId);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((IRacingBetsSettlementMainViewRecord)obj).SeasonId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "SeasonId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IRacingBetsSettlementMainViewRecord).GetProperty("SeasonId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(int), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<List<int>> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<List<int>>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = true;
			jsonPropertyInfoValues2.DeclaringType = typeof(IRacingBetsSettlementMainViewRecord);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IRacingBetsSettlementMainViewRecord)obj).ViewedLegMatchIds);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] List<int> value)
			{
				((IRacingBetsSettlementMainViewRecord)obj).ViewedLegMatchIds = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "ViewedLegMatchIds";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IRacingBetsSettlementMainViewRecord).GetProperty("ViewedLegMatchIds", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(List<int>), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<List<int>> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<List<int>>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17009EC5 RID: 40645
		// (get) Token: 0x06047E62 RID: 294498 RVA: 0x0126A9A4 File Offset: 0x01268BA4
		public JsonTypeInfo<LocalFriendApplication> LocalFriendApplication
		{
			get
			{
				JsonTypeInfo<LocalFriendApplication> result;
				if ((result = this._LocalFriendApplication) == null)
				{
					result = (this._LocalFriendApplication = (JsonTypeInfo<LocalFriendApplication>)base.Options.GetTypeInfo(typeof(LocalFriendApplication)));
				}
				return result;
			}
		}

		// Token: 0x06047E63 RID: 294499 RVA: 0x0126A9E0 File Offset: 0x01268BE0
		[NullableContext(1)]
		private JsonTypeInfo<LocalFriendApplication> Create_LocalFriendApplication(JsonSerializerOptions options)
		{
			JsonTypeInfo<LocalFriendApplication> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<LocalFriendApplication>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<LocalFriendApplication> jsonObjectInfoValues = new JsonObjectInfoValues<LocalFriendApplication>();
				jsonObjectInfoValues.ObjectCreator = (() => new LocalFriendApplication());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.LocalFriendApplicationPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(LocalFriendApplication).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<LocalFriendApplication> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<LocalFriendApplication>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E64 RID: 294500 RVA: 0x0126AAA8 File Offset: 0x01268CA8
		[NullableContext(1)]
		private static JsonPropertyInfo[] LocalFriendApplicationPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(LocalFriendApplication);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((LocalFriendApplication)obj).Fresh);
			jsonPropertyInfoValues.Setter = delegate(object obj, bool value)
			{
				((LocalFriendApplication)obj).Fresh = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Fresh";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(LocalFriendApplication).GetField("Fresh", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo);
			JsonPropertyInfoValues<long> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(LocalFriendApplication);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((LocalFriendApplication)obj).CreatedTime);
			jsonPropertyInfoValues2.Setter = delegate(object obj, long value)
			{
				((LocalFriendApplication)obj).CreatedTime = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "CreatedTime";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(LocalFriendApplication).GetField("CreatedTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17009EC6 RID: 40646
		// (get) Token: 0x06047E65 RID: 294501 RVA: 0x0126AC90 File Offset: 0x01268E90
		public JsonTypeInfo<LocalPlayerIpLevelData> LocalPlayerIpLevelData
		{
			get
			{
				JsonTypeInfo<LocalPlayerIpLevelData> result;
				if ((result = this._LocalPlayerIpLevelData) == null)
				{
					result = (this._LocalPlayerIpLevelData = (JsonTypeInfo<LocalPlayerIpLevelData>)base.Options.GetTypeInfo(typeof(LocalPlayerIpLevelData)));
				}
				return result;
			}
		}

		// Token: 0x06047E66 RID: 294502 RVA: 0x0126ACCC File Offset: 0x01268ECC
		[NullableContext(1)]
		private JsonTypeInfo<LocalPlayerIpLevelData> Create_LocalPlayerIpLevelData(JsonSerializerOptions options)
		{
			JsonTypeInfo<LocalPlayerIpLevelData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<LocalPlayerIpLevelData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<LocalPlayerIpLevelData> jsonObjectInfoValues = new JsonObjectInfoValues<LocalPlayerIpLevelData>();
				jsonObjectInfoValues.ObjectCreator = (() => new LocalPlayerIpLevelData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.LocalPlayerIpLevelDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(LocalPlayerIpLevelData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<LocalPlayerIpLevelData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<LocalPlayerIpLevelData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E67 RID: 294503 RVA: 0x0126AD94 File Offset: 0x01268F94
		[NullableContext(1)]
		private static JsonPropertyInfo[] LocalPlayerIpLevelDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(LocalPlayerIpLevelData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((LocalPlayerIpLevelData)obj).Region);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((LocalPlayerIpLevelData)obj).Region = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Region";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(LocalPlayerIpLevelData).GetField("Region", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(LocalPlayerIpLevelData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((LocalPlayerIpLevelData)obj).Level);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((LocalPlayerIpLevelData)obj).Level = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Level";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(LocalPlayerIpLevelData).GetField("Level", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17009EC7 RID: 40647
		// (get) Token: 0x06047E68 RID: 294504 RVA: 0x0126AF8C File Offset: 0x0126918C
		public JsonTypeInfo<LocalPlayerIpLevelData[]> LocalPlayerIpLevelDataArray
		{
			get
			{
				JsonTypeInfo<LocalPlayerIpLevelData[]> result;
				if ((result = this._LocalPlayerIpLevelDataArray) == null)
				{
					result = (this._LocalPlayerIpLevelDataArray = (JsonTypeInfo<LocalPlayerIpLevelData[]>)base.Options.GetTypeInfo(typeof(LocalPlayerIpLevelData[])));
				}
				return result;
			}
		}

		// Token: 0x06047E69 RID: 294505 RVA: 0x0126AFC8 File Offset: 0x012691C8
		[NullableContext(1)]
		private JsonTypeInfo<LocalPlayerIpLevelData[]> Create_LocalPlayerIpLevelDataArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<LocalPlayerIpLevelData[]> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<LocalPlayerIpLevelData[]>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<LocalPlayerIpLevelData[]> collectionInfo = new JsonCollectionInfoValues<LocalPlayerIpLevelData[]>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateArrayInfo<LocalPlayerIpLevelData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EC8 RID: 40648
		// (get) Token: 0x06047E6A RID: 294506 RVA: 0x0126B014 File Offset: 0x01269214
		public JsonTypeInfo<MarqueeStorageData> MarqueeStorageData
		{
			get
			{
				JsonTypeInfo<MarqueeStorageData> result;
				if ((result = this._MarqueeStorageData) == null)
				{
					result = (this._MarqueeStorageData = (JsonTypeInfo<MarqueeStorageData>)base.Options.GetTypeInfo(typeof(MarqueeStorageData)));
				}
				return result;
			}
		}

		// Token: 0x06047E6B RID: 294507 RVA: 0x0126B050 File Offset: 0x01269250
		[NullableContext(1)]
		private JsonTypeInfo<MarqueeStorageData> Create_MarqueeStorageData(JsonSerializerOptions options)
		{
			JsonTypeInfo<MarqueeStorageData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<MarqueeStorageData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<MarqueeStorageData> jsonObjectInfoValues = new JsonObjectInfoValues<MarqueeStorageData>();
				jsonObjectInfoValues.ObjectCreator = null;
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = ((object[] args) => new MarqueeStorageData((double)args[0]));
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.MarqueeStorageDataPropInit(options));
				Func<JsonParameterInfoValues[]> constructorParameterMetadataInitializer;
				if ((constructorParameterMetadataInitializer = LocalStorageJsonSourceGenContext.<>O.<0>__MarqueeStorageDataCtorParamInit) == null)
				{
					constructorParameterMetadataInitializer = (LocalStorageJsonSourceGenContext.<>O.<0>__MarqueeStorageDataCtorParamInit = new Func<JsonParameterInfoValues[]>(LocalStorageJsonSourceGenContext.MarqueeStorageDataCtorParamInit));
				}
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = constructorParameterMetadataInitializer;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(MarqueeStorageData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
				{
					typeof(double)
				}, null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<MarqueeStorageData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<MarqueeStorageData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E6C RID: 294508 RVA: 0x0126B134 File Offset: 0x01269334
		[NullableContext(1)]
		private static JsonPropertyInfo[] MarqueeStorageDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(MarqueeStorageData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((MarqueeStorageData)obj).ScrollingTime);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((MarqueeStorageData)obj).ScrollingTime = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ScrollingTime";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(MarqueeStorageData).GetField("ScrollingTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(MarqueeStorageData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((MarqueeStorageData)obj).EndTime);
			jsonPropertyInfoValues2.Setter = delegate(object obj, double value)
			{
				((MarqueeStorageData)obj).EndTime = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "EndTime";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(MarqueeStorageData).GetField("EndTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo2);
			return array;
		}

		// Token: 0x06047E6D RID: 294509 RVA: 0x0126B31C File Offset: 0x0126951C
		[NullableContext(1)]
		private static JsonParameterInfoValues[] MarqueeStorageDataCtorParamInit()
		{
			return new JsonParameterInfoValues[]
			{
				new JsonParameterInfoValues
				{
					Name = "endTime",
					ParameterType = typeof(double),
					Position = 0,
					HasDefaultValue = false,
					DefaultValue = null,
					IsNullable = false
				}
			};
		}

		// Token: 0x17009EC9 RID: 40649
		// (get) Token: 0x06047E6E RID: 294510 RVA: 0x0126B370 File Offset: 0x01269570
		public JsonTypeInfo<RacingBetsRedDotState> RacingBetsRedDotState
		{
			get
			{
				JsonTypeInfo<RacingBetsRedDotState> result;
				if ((result = this._RacingBetsRedDotState) == null)
				{
					result = (this._RacingBetsRedDotState = (JsonTypeInfo<RacingBetsRedDotState>)base.Options.GetTypeInfo(typeof(RacingBetsRedDotState)));
				}
				return result;
			}
		}

		// Token: 0x06047E6F RID: 294511 RVA: 0x0126B3AC File Offset: 0x012695AC
		[NullableContext(1)]
		private JsonTypeInfo<RacingBetsRedDotState> Create_RacingBetsRedDotState(JsonSerializerOptions options)
		{
			JsonTypeInfo<RacingBetsRedDotState> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RacingBetsRedDotState>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RacingBetsRedDotState> jsonObjectInfoValues = new JsonObjectInfoValues<RacingBetsRedDotState>();
				jsonObjectInfoValues.ObjectCreator = (() => new RacingBetsRedDotState());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.RacingBetsRedDotStatePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RacingBetsRedDotState).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RacingBetsRedDotState> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RacingBetsRedDotState>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E70 RID: 294512 RVA: 0x0126B474 File Offset: 0x01269674
		[NullableContext(1)]
		private static JsonPropertyInfo[] RacingBetsRedDotStatePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RacingBetsRedDotState);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RacingBetsRedDotState)obj).HasViewed);
			jsonPropertyInfoValues.Setter = delegate(object obj, bool value)
			{
				((RacingBetsRedDotState)obj).HasViewed = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "HasViewed";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RacingBetsRedDotState).GetProperty("HasViewed", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(bool), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<bool> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo);
			JsonPropertyInfoValues<long> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(RacingBetsRedDotState);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((RacingBetsRedDotState)obj).LastViewedData);
			jsonPropertyInfoValues2.Setter = delegate(object obj, long value)
			{
				((RacingBetsRedDotState)obj).LastViewedData = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "LastViewedData";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(RacingBetsRedDotState).GetProperty("LastViewedData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(long), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<long> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17009ECA RID: 40650
		// (get) Token: 0x06047E71 RID: 294513 RVA: 0x0126B65C File Offset: 0x0126985C
		public JsonTypeInfo<RegionAndIpSt> RegionAndIpSt
		{
			get
			{
				JsonTypeInfo<RegionAndIpSt> result;
				if ((result = this._RegionAndIpSt) == null)
				{
					result = (this._RegionAndIpSt = (JsonTypeInfo<RegionAndIpSt>)base.Options.GetTypeInfo(typeof(RegionAndIpSt)));
				}
				return result;
			}
		}

		// Token: 0x06047E72 RID: 294514 RVA: 0x0126B698 File Offset: 0x01269898
		[NullableContext(1)]
		private JsonTypeInfo<RegionAndIpSt> Create_RegionAndIpSt(JsonSerializerOptions options)
		{
			JsonTypeInfo<RegionAndIpSt> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RegionAndIpSt>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RegionAndIpSt> jsonObjectInfoValues = new JsonObjectInfoValues<RegionAndIpSt>();
				jsonObjectInfoValues.ObjectCreator = (() => new RegionAndIpSt());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.RegionAndIpStPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RegionAndIpSt).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RegionAndIpSt> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RegionAndIpSt>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E73 RID: 294515 RVA: 0x0126B760 File Offset: 0x01269960
		[NullableContext(1)]
		private static JsonPropertyInfo[] RegionAndIpStPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RegionAndIpSt);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RegionAndIpSt)obj).Region);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RegionAndIpSt)obj).Region = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Region";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RegionAndIpSt).GetField("Region", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(RegionAndIpSt);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((RegionAndIpSt)obj).Ip);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RegionAndIpSt)obj).Ip = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Ip";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(RegionAndIpSt).GetField("Ip", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17009ECB RID: 40651
		// (get) Token: 0x06047E74 RID: 294516 RVA: 0x0126B96C File Offset: 0x01269B6C
		public JsonTypeInfo<SortStorageData> SortStorageData
		{
			get
			{
				JsonTypeInfo<SortStorageData> result;
				if ((result = this._SortStorageData) == null)
				{
					result = (this._SortStorageData = (JsonTypeInfo<SortStorageData>)base.Options.GetTypeInfo(typeof(SortStorageData)));
				}
				return result;
			}
		}

		// Token: 0x06047E75 RID: 294517 RVA: 0x0126B9A8 File Offset: 0x01269BA8
		[NullableContext(1)]
		private JsonTypeInfo<SortStorageData> Create_SortStorageData(JsonSerializerOptions options)
		{
			JsonTypeInfo<SortStorageData> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<SortStorageData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<SortStorageData> jsonObjectInfoValues = new JsonObjectInfoValues<SortStorageData>();
				jsonObjectInfoValues.ObjectCreator = (() => new SortStorageData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LocalStorageJsonSourceGenContext.SortStorageDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(SortStorageData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<SortStorageData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<SortStorageData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06047E76 RID: 294518 RVA: 0x0126BA70 File Offset: 0x01269C70
		[NullableContext(1)]
		private static JsonPropertyInfo[] SortStorageDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(SortStorageData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((SortStorageData)obj).ConfigId);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((SortStorageData)obj).ConfigId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ConfigId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(SortStorageData).GetProperty("ConfigId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(int), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(SortStorageData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((SortStorageData)obj).SelectBaseSort);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int? value)
			{
				((SortStorageData)obj).SelectBaseSort = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "SelectBaseSort";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(SortStorageData).GetProperty("SelectBaseSort", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(int?), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<int?> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo2);
			JsonPropertyInfoValues<List<int>> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<List<int>>();
			jsonPropertyInfoValues3.IsProperty = true;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(SortStorageData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((SortStorageData)obj).SelectAttributeSort);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] List<int> value)
			{
				((SortStorageData)obj).SelectAttributeSort = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "SelectAttributeSort";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(SortStorageData).GetProperty("SelectAttributeSort", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(List<int>), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<List<int>> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<List<int>>(options, propertyInfo3);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues4.IsProperty = true;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(SortStorageData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((SortStorageData)obj).IsAscending);
			jsonPropertyInfoValues4.Setter = delegate(object obj, bool value)
			{
				((SortStorageData)obj).IsAscending = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "IsAscending";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(SortStorageData).GetProperty("IsAscending", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(bool), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<bool> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo4);
			return array;
		}

		// Token: 0x17009ECC RID: 40652
		// (get) Token: 0x06047E77 RID: 294519 RVA: 0x0126BE30 File Offset: 0x0126A030
		public JsonTypeInfo<Dictionary<EFunction, int>> DictionaryEFunctionInt32
		{
			get
			{
				JsonTypeInfo<Dictionary<EFunction, int>> result;
				if ((result = this._DictionaryEFunctionInt32) == null)
				{
					result = (this._DictionaryEFunctionInt32 = (JsonTypeInfo<Dictionary<EFunction, int>>)base.Options.GetTypeInfo(typeof(Dictionary<EFunction, int>)));
				}
				return result;
			}
		}

		// Token: 0x06047E78 RID: 294520 RVA: 0x0126BE6C File Offset: 0x0126A06C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<EFunction, int>> Create_DictionaryEFunctionInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<EFunction, int>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<EFunction, int>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<EFunction, int>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<EFunction, int>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<EFunction, int>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<EFunction, int>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<EFunction, int>, EFunction, int>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ECD RID: 40653
		// (get) Token: 0x06047E79 RID: 294521 RVA: 0x0126BED4 File Offset: 0x0126A0D4
		public JsonTypeInfo<Dictionary<FilterDefine.EFilterType, List<int>>> DictionaryEFilterTypeListInt32
		{
			get
			{
				JsonTypeInfo<Dictionary<FilterDefine.EFilterType, List<int>>> result;
				if ((result = this._DictionaryEFilterTypeListInt32) == null)
				{
					result = (this._DictionaryEFilterTypeListInt32 = (JsonTypeInfo<Dictionary<FilterDefine.EFilterType, List<int>>>)base.Options.GetTypeInfo(typeof(Dictionary<FilterDefine.EFilterType, List<int>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E7A RID: 294522 RVA: 0x0126BF10 File Offset: 0x0126A110
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<FilterDefine.EFilterType, List<int>>> Create_DictionaryEFilterTypeListInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<FilterDefine.EFilterType, List<int>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<FilterDefine.EFilterType, List<int>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<FilterDefine.EFilterType, List<int>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<FilterDefine.EFilterType, List<int>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<FilterDefine.EFilterType, List<int>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<FilterDefine.EFilterType, List<int>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<FilterDefine.EFilterType, List<int>>, FilterDefine.EFilterType, List<int>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ECE RID: 40654
		// (get) Token: 0x06047E7B RID: 294523 RVA: 0x0126BF78 File Offset: 0x0126A178
		public JsonTypeInfo<Dictionary<int, bool>> DictionaryInt32Boolean
		{
			get
			{
				JsonTypeInfo<Dictionary<int, bool>> result;
				if ((result = this._DictionaryInt32Boolean) == null)
				{
					result = (this._DictionaryInt32Boolean = (JsonTypeInfo<Dictionary<int, bool>>)base.Options.GetTypeInfo(typeof(Dictionary<int, bool>)));
				}
				return result;
			}
		}

		// Token: 0x06047E7C RID: 294524 RVA: 0x0126BFB4 File Offset: 0x0126A1B4
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, bool>> Create_DictionaryInt32Boolean(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, bool>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, bool>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, bool>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, bool>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, bool>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, bool>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, bool>, int, bool>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ECF RID: 40655
		// (get) Token: 0x06047E7D RID: 294525 RVA: 0x0126C01C File Offset: 0x0126A21C
		public JsonTypeInfo<Dictionary<int, double>> DictionaryInt32Double
		{
			get
			{
				JsonTypeInfo<Dictionary<int, double>> result;
				if ((result = this._DictionaryInt32Double) == null)
				{
					result = (this._DictionaryInt32Double = (JsonTypeInfo<Dictionary<int, double>>)base.Options.GetTypeInfo(typeof(Dictionary<int, double>)));
				}
				return result;
			}
		}

		// Token: 0x06047E7E RID: 294526 RVA: 0x0126C058 File Offset: 0x0126A258
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, double>> Create_DictionaryInt32Double(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, double>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, double>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, double>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, double>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, double>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, double>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, double>, int, double>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED0 RID: 40656
		// (get) Token: 0x06047E7F RID: 294527 RVA: 0x0126C0C0 File Offset: 0x0126A2C0
		public JsonTypeInfo<Dictionary<int, float[]>> DictionaryInt32SingleArray
		{
			get
			{
				JsonTypeInfo<Dictionary<int, float[]>> result;
				if ((result = this._DictionaryInt32SingleArray) == null)
				{
					result = (this._DictionaryInt32SingleArray = (JsonTypeInfo<Dictionary<int, float[]>>)base.Options.GetTypeInfo(typeof(Dictionary<int, float[]>)));
				}
				return result;
			}
		}

		// Token: 0x06047E80 RID: 294528 RVA: 0x0126C0FC File Offset: 0x0126A2FC
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, float[]>> Create_DictionaryInt32SingleArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, float[]>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, float[]>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, float[]>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, float[]>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, float[]>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, float[]>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, float[]>, int, float[]>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED1 RID: 40657
		// (get) Token: 0x06047E81 RID: 294529 RVA: 0x0126C164 File Offset: 0x0126A364
		public JsonTypeInfo<Dictionary<int, float>> DictionaryInt32Single
		{
			get
			{
				JsonTypeInfo<Dictionary<int, float>> result;
				if ((result = this._DictionaryInt32Single) == null)
				{
					result = (this._DictionaryInt32Single = (JsonTypeInfo<Dictionary<int, float>>)base.Options.GetTypeInfo(typeof(Dictionary<int, float>)));
				}
				return result;
			}
		}

		// Token: 0x06047E82 RID: 294530 RVA: 0x0126C1A0 File Offset: 0x0126A3A0
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, float>> Create_DictionaryInt32Single(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, float>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, float>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, float>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, float>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, float>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, float>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, float>, int, float>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED2 RID: 40658
		// (get) Token: 0x06047E83 RID: 294531 RVA: 0x0126C208 File Offset: 0x0126A408
		public JsonTypeInfo<Dictionary<int, AbyssDangoOwnerData>> DictionaryInt32AbyssDangoOwnerData
		{
			get
			{
				JsonTypeInfo<Dictionary<int, AbyssDangoOwnerData>> result;
				if ((result = this._DictionaryInt32AbyssDangoOwnerData) == null)
				{
					result = (this._DictionaryInt32AbyssDangoOwnerData = (JsonTypeInfo<Dictionary<int, AbyssDangoOwnerData>>)base.Options.GetTypeInfo(typeof(Dictionary<int, AbyssDangoOwnerData>)));
				}
				return result;
			}
		}

		// Token: 0x06047E84 RID: 294532 RVA: 0x0126C244 File Offset: 0x0126A444
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, AbyssDangoOwnerData>> Create_DictionaryInt32AbyssDangoOwnerData(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, AbyssDangoOwnerData>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, AbyssDangoOwnerData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, AbyssDangoOwnerData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, AbyssDangoOwnerData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, AbyssDangoOwnerData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, AbyssDangoOwnerData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, AbyssDangoOwnerData>, int, AbyssDangoOwnerData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED3 RID: 40659
		// (get) Token: 0x06047E85 RID: 294533 RVA: 0x0126C2AC File Offset: 0x0126A4AC
		public JsonTypeInfo<Dictionary<int, AreaExplorePlayState>> DictionaryInt32AreaExplorePlayState
		{
			get
			{
				JsonTypeInfo<Dictionary<int, AreaExplorePlayState>> result;
				if ((result = this._DictionaryInt32AreaExplorePlayState) == null)
				{
					result = (this._DictionaryInt32AreaExplorePlayState = (JsonTypeInfo<Dictionary<int, AreaExplorePlayState>>)base.Options.GetTypeInfo(typeof(Dictionary<int, AreaExplorePlayState>)));
				}
				return result;
			}
		}

		// Token: 0x06047E86 RID: 294534 RVA: 0x0126C2E8 File Offset: 0x0126A4E8
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, AreaExplorePlayState>> Create_DictionaryInt32AreaExplorePlayState(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, AreaExplorePlayState>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, AreaExplorePlayState>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, AreaExplorePlayState>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, AreaExplorePlayState>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, AreaExplorePlayState>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, AreaExplorePlayState>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, AreaExplorePlayState>, int, AreaExplorePlayState>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED4 RID: 40660
		// (get) Token: 0x06047E87 RID: 294535 RVA: 0x0126C350 File Offset: 0x0126A550
		public JsonTypeInfo<Dictionary<int, LocalFriendApplication>> DictionaryInt32LocalFriendApplication
		{
			get
			{
				JsonTypeInfo<Dictionary<int, LocalFriendApplication>> result;
				if ((result = this._DictionaryInt32LocalFriendApplication) == null)
				{
					result = (this._DictionaryInt32LocalFriendApplication = (JsonTypeInfo<Dictionary<int, LocalFriendApplication>>)base.Options.GetTypeInfo(typeof(Dictionary<int, LocalFriendApplication>)));
				}
				return result;
			}
		}

		// Token: 0x06047E88 RID: 294536 RVA: 0x0126C38C File Offset: 0x0126A58C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, LocalFriendApplication>> Create_DictionaryInt32LocalFriendApplication(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, LocalFriendApplication>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, LocalFriendApplication>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, LocalFriendApplication>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, LocalFriendApplication>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, LocalFriendApplication>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, LocalFriendApplication>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, LocalFriendApplication>, int, LocalFriendApplication>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED5 RID: 40661
		// (get) Token: 0x06047E89 RID: 294537 RVA: 0x0126C3F4 File Offset: 0x0126A5F4
		public JsonTypeInfo<Dictionary<int, Dictionary<int, double>>> DictionaryInt32DictionaryInt32Double
		{
			get
			{
				JsonTypeInfo<Dictionary<int, Dictionary<int, double>>> result;
				if ((result = this._DictionaryInt32DictionaryInt32Double) == null)
				{
					result = (this._DictionaryInt32DictionaryInt32Double = (JsonTypeInfo<Dictionary<int, Dictionary<int, double>>>)base.Options.GetTypeInfo(typeof(Dictionary<int, Dictionary<int, double>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E8A RID: 294538 RVA: 0x0126C430 File Offset: 0x0126A630
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, double>>> Create_DictionaryInt32DictionaryInt32Double(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, Dictionary<int, double>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, Dictionary<int, double>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, double>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, Dictionary<int, double>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, Dictionary<int, double>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, double>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, Dictionary<int, double>>, int, Dictionary<int, double>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED6 RID: 40662
		// (get) Token: 0x06047E8B RID: 294539 RVA: 0x0126C498 File Offset: 0x0126A698
		public JsonTypeInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> DictionaryInt32DictionaryInt32AbyssDangoOwnerData
		{
			get
			{
				JsonTypeInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> result;
				if ((result = this._DictionaryInt32DictionaryInt32AbyssDangoOwnerData) == null)
				{
					result = (this._DictionaryInt32DictionaryInt32AbyssDangoOwnerData = (JsonTypeInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>>)base.Options.GetTypeInfo(typeof(Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E8C RID: 294540 RVA: 0x0126C4D4 File Offset: 0x0126A6D4
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> Create_DictionaryInt32DictionaryInt32AbyssDangoOwnerData(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>, int, Dictionary<int, AbyssDangoOwnerData>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED7 RID: 40663
		// (get) Token: 0x06047E8D RID: 294541 RVA: 0x0126C53C File Offset: 0x0126A73C
		public JsonTypeInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> DictionaryInt32DictionaryInt32AreaExplorePlayState
		{
			get
			{
				JsonTypeInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> result;
				if ((result = this._DictionaryInt32DictionaryInt32AreaExplorePlayState) == null)
				{
					result = (this._DictionaryInt32DictionaryInt32AreaExplorePlayState = (JsonTypeInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>)base.Options.GetTypeInfo(typeof(Dictionary<int, Dictionary<int, AreaExplorePlayState>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E8E RID: 294542 RVA: 0x0126C578 File Offset: 0x0126A778
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> Create_DictionaryInt32DictionaryInt32AreaExplorePlayState(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, Dictionary<int, AreaExplorePlayState>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, Dictionary<int, AreaExplorePlayState>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>, int, Dictionary<int, AreaExplorePlayState>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED8 RID: 40664
		// (get) Token: 0x06047E8F RID: 294543 RVA: 0x0126C5E0 File Offset: 0x0126A7E0
		public JsonTypeInfo<Dictionary<int, Dictionary<int, HashSet<int>>>> DictionaryInt32DictionaryInt32HashSetInt32
		{
			get
			{
				JsonTypeInfo<Dictionary<int, Dictionary<int, HashSet<int>>>> result;
				if ((result = this._DictionaryInt32DictionaryInt32HashSetInt32) == null)
				{
					result = (this._DictionaryInt32DictionaryInt32HashSetInt32 = (JsonTypeInfo<Dictionary<int, Dictionary<int, HashSet<int>>>>)base.Options.GetTypeInfo(typeof(Dictionary<int, Dictionary<int, HashSet<int>>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E90 RID: 294544 RVA: 0x0126C61C File Offset: 0x0126A81C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, HashSet<int>>>> Create_DictionaryInt32DictionaryInt32HashSetInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, Dictionary<int, HashSet<int>>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, Dictionary<int, HashSet<int>>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, HashSet<int>>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, Dictionary<int, HashSet<int>>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, Dictionary<int, HashSet<int>>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, Dictionary<int, HashSet<int>>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, Dictionary<int, HashSet<int>>>, int, Dictionary<int, HashSet<int>>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009ED9 RID: 40665
		// (get) Token: 0x06047E91 RID: 294545 RVA: 0x0126C684 File Offset: 0x0126A884
		public JsonTypeInfo<Dictionary<int, HashSet<int>>> DictionaryInt32HashSetInt32
		{
			get
			{
				JsonTypeInfo<Dictionary<int, HashSet<int>>> result;
				if ((result = this._DictionaryInt32HashSetInt32) == null)
				{
					result = (this._DictionaryInt32HashSetInt32 = (JsonTypeInfo<Dictionary<int, HashSet<int>>>)base.Options.GetTypeInfo(typeof(Dictionary<int, HashSet<int>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E92 RID: 294546 RVA: 0x0126C6C0 File Offset: 0x0126A8C0
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, HashSet<int>>> Create_DictionaryInt32HashSetInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, HashSet<int>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, HashSet<int>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, HashSet<int>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, HashSet<int>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, HashSet<int>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, HashSet<int>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, HashSet<int>>, int, HashSet<int>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EDA RID: 40666
		// (get) Token: 0x06047E93 RID: 294547 RVA: 0x0126C728 File Offset: 0x0126A928
		public JsonTypeInfo<Dictionary<int, List<int>>> DictionaryInt32ListInt32
		{
			get
			{
				JsonTypeInfo<Dictionary<int, List<int>>> result;
				if ((result = this._DictionaryInt32ListInt32) == null)
				{
					result = (this._DictionaryInt32ListInt32 = (JsonTypeInfo<Dictionary<int, List<int>>>)base.Options.GetTypeInfo(typeof(Dictionary<int, List<int>>)));
				}
				return result;
			}
		}

		// Token: 0x06047E94 RID: 294548 RVA: 0x0126C764 File Offset: 0x0126A964
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, List<int>>> Create_DictionaryInt32ListInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, List<int>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, List<int>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, List<int>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, List<int>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, List<int>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, List<int>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, List<int>>, int, List<int>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EDB RID: 40667
		// (get) Token: 0x06047E95 RID: 294549 RVA: 0x0126C7CC File Offset: 0x0126A9CC
		public JsonTypeInfo<Dictionary<int, int[]>> DictionaryInt32Int32Array
		{
			get
			{
				JsonTypeInfo<Dictionary<int, int[]>> result;
				if ((result = this._DictionaryInt32Int32Array) == null)
				{
					result = (this._DictionaryInt32Int32Array = (JsonTypeInfo<Dictionary<int, int[]>>)base.Options.GetTypeInfo(typeof(Dictionary<int, int[]>)));
				}
				return result;
			}
		}

		// Token: 0x06047E96 RID: 294550 RVA: 0x0126C808 File Offset: 0x0126AA08
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, int[]>> Create_DictionaryInt32Int32Array(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, int[]>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, int[]>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, int[]>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, int[]>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, int[]>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, int[]>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, int[]>, int, int[]>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EDC RID: 40668
		// (get) Token: 0x06047E97 RID: 294551 RVA: 0x0126C870 File Offset: 0x0126AA70
		public JsonTypeInfo<Dictionary<int, int>> DictionaryInt32Int32
		{
			get
			{
				JsonTypeInfo<Dictionary<int, int>> result;
				if ((result = this._DictionaryInt32Int32) == null)
				{
					result = (this._DictionaryInt32Int32 = (JsonTypeInfo<Dictionary<int, int>>)base.Options.GetTypeInfo(typeof(Dictionary<int, int>)));
				}
				return result;
			}
		}

		// Token: 0x06047E98 RID: 294552 RVA: 0x0126C8AC File Offset: 0x0126AAAC
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, int>> Create_DictionaryInt32Int32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, int>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, int>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, int>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, int>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, int>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, int>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, int>, int, int>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EDD RID: 40669
		// (get) Token: 0x06047E99 RID: 294553 RVA: 0x0126C914 File Offset: 0x0126AB14
		public JsonTypeInfo<Dictionary<int, long>> DictionaryInt32Int64
		{
			get
			{
				JsonTypeInfo<Dictionary<int, long>> result;
				if ((result = this._DictionaryInt32Int64) == null)
				{
					result = (this._DictionaryInt32Int64 = (JsonTypeInfo<Dictionary<int, long>>)base.Options.GetTypeInfo(typeof(Dictionary<int, long>)));
				}
				return result;
			}
		}

		// Token: 0x06047E9A RID: 294554 RVA: 0x0126C950 File Offset: 0x0126AB50
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, long>> Create_DictionaryInt32Int64(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, long>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, long>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, long>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, long>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, long>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, long>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, long>, int, long>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EDE RID: 40670
		// (get) Token: 0x06047E9B RID: 294555 RVA: 0x0126C9B8 File Offset: 0x0126ABB8
		public JsonTypeInfo<Dictionary<int, string>> DictionaryInt32String
		{
			get
			{
				JsonTypeInfo<Dictionary<int, string>> result;
				if ((result = this._DictionaryInt32String) == null)
				{
					result = (this._DictionaryInt32String = (JsonTypeInfo<Dictionary<int, string>>)base.Options.GetTypeInfo(typeof(Dictionary<int, string>)));
				}
				return result;
			}
		}

		// Token: 0x06047E9C RID: 294556 RVA: 0x0126C9F4 File Offset: 0x0126ABF4
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, string>> Create_DictionaryInt32String(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, string>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, string>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<int, string>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<int, string>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<int, string>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<int, string>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<int, string>, int, string>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EDF RID: 40671
		// (get) Token: 0x06047E9D RID: 294557 RVA: 0x0126CA5C File Offset: 0x0126AC5C
		public JsonTypeInfo<Dictionary<string, bool>> DictionaryStringBoolean
		{
			get
			{
				JsonTypeInfo<Dictionary<string, bool>> result;
				if ((result = this._DictionaryStringBoolean) == null)
				{
					result = (this._DictionaryStringBoolean = (JsonTypeInfo<Dictionary<string, bool>>)base.Options.GetTypeInfo(typeof(Dictionary<string, bool>)));
				}
				return result;
			}
		}

		// Token: 0x06047E9E RID: 294558 RVA: 0x0126CA98 File Offset: 0x0126AC98
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, bool>> Create_DictionaryStringBoolean(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, bool>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, bool>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, bool>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, bool>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, bool>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, bool>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, bool>, string, bool>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE0 RID: 40672
		// (get) Token: 0x06047E9F RID: 294559 RVA: 0x0126CB00 File Offset: 0x0126AD00
		public JsonTypeInfo<Dictionary<string, FilterStorageData>> DictionaryStringFilterStorageData
		{
			get
			{
				JsonTypeInfo<Dictionary<string, FilterStorageData>> result;
				if ((result = this._DictionaryStringFilterStorageData) == null)
				{
					result = (this._DictionaryStringFilterStorageData = (JsonTypeInfo<Dictionary<string, FilterStorageData>>)base.Options.GetTypeInfo(typeof(Dictionary<string, FilterStorageData>)));
				}
				return result;
			}
		}

		// Token: 0x06047EA0 RID: 294560 RVA: 0x0126CB3C File Offset: 0x0126AD3C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, FilterStorageData>> Create_DictionaryStringFilterStorageData(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, FilterStorageData>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, FilterStorageData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, FilterStorageData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, FilterStorageData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, FilterStorageData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, FilterStorageData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, FilterStorageData>, string, FilterStorageData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE1 RID: 40673
		// (get) Token: 0x06047EA1 RID: 294561 RVA: 0x0126CBA4 File Offset: 0x0126ADA4
		public JsonTypeInfo<Dictionary<string, GamepadTypeUsage>> DictionaryStringGamepadTypeUsage
		{
			get
			{
				JsonTypeInfo<Dictionary<string, GamepadTypeUsage>> result;
				if ((result = this._DictionaryStringGamepadTypeUsage) == null)
				{
					result = (this._DictionaryStringGamepadTypeUsage = (JsonTypeInfo<Dictionary<string, GamepadTypeUsage>>)base.Options.GetTypeInfo(typeof(Dictionary<string, GamepadTypeUsage>)));
				}
				return result;
			}
		}

		// Token: 0x06047EA2 RID: 294562 RVA: 0x0126CBE0 File Offset: 0x0126ADE0
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, GamepadTypeUsage>> Create_DictionaryStringGamepadTypeUsage(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, GamepadTypeUsage>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, GamepadTypeUsage>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, GamepadTypeUsage>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, GamepadTypeUsage>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, GamepadTypeUsage>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, GamepadTypeUsage>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, GamepadTypeUsage>, string, GamepadTypeUsage>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE2 RID: 40674
		// (get) Token: 0x06047EA3 RID: 294563 RVA: 0x0126CC48 File Offset: 0x0126AE48
		public JsonTypeInfo<Dictionary<string, LocalPlayerIpLevelData[]>> DictionaryStringLocalPlayerIpLevelDataArray
		{
			get
			{
				JsonTypeInfo<Dictionary<string, LocalPlayerIpLevelData[]>> result;
				if ((result = this._DictionaryStringLocalPlayerIpLevelDataArray) == null)
				{
					result = (this._DictionaryStringLocalPlayerIpLevelDataArray = (JsonTypeInfo<Dictionary<string, LocalPlayerIpLevelData[]>>)base.Options.GetTypeInfo(typeof(Dictionary<string, LocalPlayerIpLevelData[]>)));
				}
				return result;
			}
		}

		// Token: 0x06047EA4 RID: 294564 RVA: 0x0126CC84 File Offset: 0x0126AE84
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, LocalPlayerIpLevelData[]>> Create_DictionaryStringLocalPlayerIpLevelDataArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, LocalPlayerIpLevelData[]>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, LocalPlayerIpLevelData[]>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, LocalPlayerIpLevelData[]>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, LocalPlayerIpLevelData[]>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, LocalPlayerIpLevelData[]>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, LocalPlayerIpLevelData[]>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, LocalPlayerIpLevelData[]>, string, LocalPlayerIpLevelData[]>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE3 RID: 40675
		// (get) Token: 0x06047EA5 RID: 294565 RVA: 0x0126CCEC File Offset: 0x0126AEEC
		public JsonTypeInfo<Dictionary<string, MarqueeStorageData>> DictionaryStringMarqueeStorageData
		{
			get
			{
				JsonTypeInfo<Dictionary<string, MarqueeStorageData>> result;
				if ((result = this._DictionaryStringMarqueeStorageData) == null)
				{
					result = (this._DictionaryStringMarqueeStorageData = (JsonTypeInfo<Dictionary<string, MarqueeStorageData>>)base.Options.GetTypeInfo(typeof(Dictionary<string, MarqueeStorageData>)));
				}
				return result;
			}
		}

		// Token: 0x06047EA6 RID: 294566 RVA: 0x0126CD28 File Offset: 0x0126AF28
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, MarqueeStorageData>> Create_DictionaryStringMarqueeStorageData(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, MarqueeStorageData>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, MarqueeStorageData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, MarqueeStorageData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, MarqueeStorageData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, MarqueeStorageData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, MarqueeStorageData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, MarqueeStorageData>, string, MarqueeStorageData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE4 RID: 40676
		// (get) Token: 0x06047EA7 RID: 294567 RVA: 0x0126CD90 File Offset: 0x0126AF90
		public JsonTypeInfo<Dictionary<string, RegionAndIpSt>> DictionaryStringRegionAndIpSt
		{
			get
			{
				JsonTypeInfo<Dictionary<string, RegionAndIpSt>> result;
				if ((result = this._DictionaryStringRegionAndIpSt) == null)
				{
					result = (this._DictionaryStringRegionAndIpSt = (JsonTypeInfo<Dictionary<string, RegionAndIpSt>>)base.Options.GetTypeInfo(typeof(Dictionary<string, RegionAndIpSt>)));
				}
				return result;
			}
		}

		// Token: 0x06047EA8 RID: 294568 RVA: 0x0126CDCC File Offset: 0x0126AFCC
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, RegionAndIpSt>> Create_DictionaryStringRegionAndIpSt(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, RegionAndIpSt>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, RegionAndIpSt>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, RegionAndIpSt>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, RegionAndIpSt>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, RegionAndIpSt>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, RegionAndIpSt>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, RegionAndIpSt>, string, RegionAndIpSt>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE5 RID: 40677
		// (get) Token: 0x06047EA9 RID: 294569 RVA: 0x0126CE34 File Offset: 0x0126B034
		public JsonTypeInfo<Dictionary<string, SortStorageData>> DictionaryStringSortStorageData
		{
			get
			{
				JsonTypeInfo<Dictionary<string, SortStorageData>> result;
				if ((result = this._DictionaryStringSortStorageData) == null)
				{
					result = (this._DictionaryStringSortStorageData = (JsonTypeInfo<Dictionary<string, SortStorageData>>)base.Options.GetTypeInfo(typeof(Dictionary<string, SortStorageData>)));
				}
				return result;
			}
		}

		// Token: 0x06047EAA RID: 294570 RVA: 0x0126CE70 File Offset: 0x0126B070
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, SortStorageData>> Create_DictionaryStringSortStorageData(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, SortStorageData>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, SortStorageData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, SortStorageData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, SortStorageData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, SortStorageData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, SortStorageData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, SortStorageData>, string, SortStorageData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE6 RID: 40678
		// (get) Token: 0x06047EAB RID: 294571 RVA: 0x0126CED8 File Offset: 0x0126B0D8
		public JsonTypeInfo<Dictionary<string, IList<IList<string>>>> DictionaryStringIListIListString
		{
			get
			{
				JsonTypeInfo<Dictionary<string, IList<IList<string>>>> result;
				if ((result = this._DictionaryStringIListIListString) == null)
				{
					result = (this._DictionaryStringIListIListString = (JsonTypeInfo<Dictionary<string, IList<IList<string>>>>)base.Options.GetTypeInfo(typeof(Dictionary<string, IList<IList<string>>>)));
				}
				return result;
			}
		}

		// Token: 0x06047EAC RID: 294572 RVA: 0x0126CF14 File Offset: 0x0126B114
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, IList<IList<string>>>> Create_DictionaryStringIListIListString(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, IList<IList<string>>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, IList<IList<string>>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, IList<IList<string>>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, IList<IList<string>>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, IList<IList<string>>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, IList<IList<string>>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, IList<IList<string>>>, string, IList<IList<string>>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE7 RID: 40679
		// (get) Token: 0x06047EAD RID: 294573 RVA: 0x0126CF7C File Offset: 0x0126B17C
		public JsonTypeInfo<Dictionary<string, List<ActivityCacheData>>> DictionaryStringListActivityCacheData
		{
			get
			{
				JsonTypeInfo<Dictionary<string, List<ActivityCacheData>>> result;
				if ((result = this._DictionaryStringListActivityCacheData) == null)
				{
					result = (this._DictionaryStringListActivityCacheData = (JsonTypeInfo<Dictionary<string, List<ActivityCacheData>>>)base.Options.GetTypeInfo(typeof(Dictionary<string, List<ActivityCacheData>>)));
				}
				return result;
			}
		}

		// Token: 0x06047EAE RID: 294574 RVA: 0x0126CFB8 File Offset: 0x0126B1B8
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, List<ActivityCacheData>>> Create_DictionaryStringListActivityCacheData(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, List<ActivityCacheData>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, List<ActivityCacheData>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, List<ActivityCacheData>>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, List<ActivityCacheData>>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, List<ActivityCacheData>>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, List<ActivityCacheData>>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, List<ActivityCacheData>>, string, List<ActivityCacheData>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE8 RID: 40680
		// (get) Token: 0x06047EAF RID: 294575 RVA: 0x0126D020 File Offset: 0x0126B220
		public JsonTypeInfo<Dictionary<string, int>> DictionaryStringInt32
		{
			get
			{
				JsonTypeInfo<Dictionary<string, int>> result;
				if ((result = this._DictionaryStringInt32) == null)
				{
					result = (this._DictionaryStringInt32 = (JsonTypeInfo<Dictionary<string, int>>)base.Options.GetTypeInfo(typeof(Dictionary<string, int>)));
				}
				return result;
			}
		}

		// Token: 0x06047EB0 RID: 294576 RVA: 0x0126D05C File Offset: 0x0126B25C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, int>> Create_DictionaryStringInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, int>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, int>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, int>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, int>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, int>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, int>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, int>, string, int>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EE9 RID: 40681
		// (get) Token: 0x06047EB1 RID: 294577 RVA: 0x0126D0C4 File Offset: 0x0126B2C4
		public JsonTypeInfo<HashSet<EMapNoteId>> HashSetEMapNoteId
		{
			get
			{
				JsonTypeInfo<HashSet<EMapNoteId>> result;
				if ((result = this._HashSetEMapNoteId) == null)
				{
					result = (this._HashSetEMapNoteId = (JsonTypeInfo<HashSet<EMapNoteId>>)base.Options.GetTypeInfo(typeof(HashSet<EMapNoteId>)));
				}
				return result;
			}
		}

		// Token: 0x06047EB2 RID: 294578 RVA: 0x0126D100 File Offset: 0x0126B300
		[NullableContext(1)]
		private JsonTypeInfo<HashSet<EMapNoteId>> Create_HashSetEMapNoteId(JsonSerializerOptions options)
		{
			JsonTypeInfo<HashSet<EMapNoteId>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<HashSet<EMapNoteId>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<HashSet<EMapNoteId>> jsonCollectionInfoValues = new JsonCollectionInfoValues<HashSet<EMapNoteId>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new HashSet<EMapNoteId>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<HashSet<EMapNoteId>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateISetInfo<HashSet<EMapNoteId>, EMapNoteId>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EEA RID: 40682
		// (get) Token: 0x06047EB3 RID: 294579 RVA: 0x0126D168 File Offset: 0x0126B368
		public JsonTypeInfo<HashSet<int>> HashSetInt32
		{
			get
			{
				JsonTypeInfo<HashSet<int>> result;
				if ((result = this._HashSetInt32) == null)
				{
					result = (this._HashSetInt32 = (JsonTypeInfo<HashSet<int>>)base.Options.GetTypeInfo(typeof(HashSet<int>)));
				}
				return result;
			}
		}

		// Token: 0x06047EB4 RID: 294580 RVA: 0x0126D1A4 File Offset: 0x0126B3A4
		[NullableContext(1)]
		private JsonTypeInfo<HashSet<int>> Create_HashSetInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<HashSet<int>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<HashSet<int>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<HashSet<int>> jsonCollectionInfoValues = new JsonCollectionInfoValues<HashSet<int>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new HashSet<int>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<HashSet<int>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateISetInfo<HashSet<int>, int>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EEB RID: 40683
		// (get) Token: 0x06047EB5 RID: 294581 RVA: 0x0126D20C File Offset: 0x0126B40C
		public JsonTypeInfo<IList<IList<string>>> IListIListString
		{
			get
			{
				JsonTypeInfo<IList<IList<string>>> result;
				if ((result = this._IListIListString) == null)
				{
					result = (this._IListIListString = (JsonTypeInfo<IList<IList<string>>>)base.Options.GetTypeInfo(typeof(IList<IList<string>>)));
				}
				return result;
			}
		}

		// Token: 0x06047EB6 RID: 294582 RVA: 0x0126D248 File Offset: 0x0126B448
		[NullableContext(1)]
		private JsonTypeInfo<IList<IList<string>>> Create_IListIListString(JsonSerializerOptions options)
		{
			JsonTypeInfo<IList<IList<string>>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IList<IList<string>>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<IList<IList<string>>> collectionInfo = new JsonCollectionInfoValues<IList<IList<string>>>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateIListInfo<IList<IList<string>>, IList<string>>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EEC RID: 40684
		// (get) Token: 0x06047EB7 RID: 294583 RVA: 0x0126D294 File Offset: 0x0126B494
		public JsonTypeInfo<IList<string>> IListString
		{
			get
			{
				JsonTypeInfo<IList<string>> result;
				if ((result = this._IListString) == null)
				{
					result = (this._IListString = (JsonTypeInfo<IList<string>>)base.Options.GetTypeInfo(typeof(IList<string>)));
				}
				return result;
			}
		}

		// Token: 0x06047EB8 RID: 294584 RVA: 0x0126D2D0 File Offset: 0x0126B4D0
		[NullableContext(1)]
		private JsonTypeInfo<IList<string>> Create_IListString(JsonSerializerOptions options)
		{
			JsonTypeInfo<IList<string>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IList<string>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<IList<string>> collectionInfo = new JsonCollectionInfoValues<IList<string>>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateIListInfo<IList<string>, string>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EED RID: 40685
		// (get) Token: 0x06047EB9 RID: 294585 RVA: 0x0126D31C File Offset: 0x0126B51C
		public JsonTypeInfo<List<ActivityCacheData>> ListActivityCacheData
		{
			get
			{
				JsonTypeInfo<List<ActivityCacheData>> result;
				if ((result = this._ListActivityCacheData) == null)
				{
					result = (this._ListActivityCacheData = (JsonTypeInfo<List<ActivityCacheData>>)base.Options.GetTypeInfo(typeof(List<ActivityCacheData>)));
				}
				return result;
			}
		}

		// Token: 0x06047EBA RID: 294586 RVA: 0x0126D358 File Offset: 0x0126B558
		[NullableContext(1)]
		private JsonTypeInfo<List<ActivityCacheData>> Create_ListActivityCacheData(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<ActivityCacheData>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<ActivityCacheData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<ActivityCacheData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<ActivityCacheData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<ActivityCacheData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<ActivityCacheData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<ActivityCacheData>, ActivityCacheData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EEE RID: 40686
		// (get) Token: 0x06047EBB RID: 294587 RVA: 0x0126D3C0 File Offset: 0x0126B5C0
		public JsonTypeInfo<List<EPlayPointState>> ListEPlayPointState
		{
			get
			{
				JsonTypeInfo<List<EPlayPointState>> result;
				if ((result = this._ListEPlayPointState) == null)
				{
					result = (this._ListEPlayPointState = (JsonTypeInfo<List<EPlayPointState>>)base.Options.GetTypeInfo(typeof(List<EPlayPointState>)));
				}
				return result;
			}
		}

		// Token: 0x06047EBC RID: 294588 RVA: 0x0126D3FC File Offset: 0x0126B5FC
		[NullableContext(1)]
		private JsonTypeInfo<List<EPlayPointState>> Create_ListEPlayPointState(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<EPlayPointState>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<EPlayPointState>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<EPlayPointState>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<EPlayPointState>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<EPlayPointState>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<EPlayPointState>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<EPlayPointState>, EPlayPointState>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EEF RID: 40687
		// (get) Token: 0x06047EBD RID: 294589 RVA: 0x0126D464 File Offset: 0x0126B664
		public JsonTypeInfo<List<int>> ListInt32
		{
			get
			{
				JsonTypeInfo<List<int>> result;
				if ((result = this._ListInt32) == null)
				{
					result = (this._ListInt32 = (JsonTypeInfo<List<int>>)base.Options.GetTypeInfo(typeof(List<int>)));
				}
				return result;
			}
		}

		// Token: 0x06047EBE RID: 294590 RVA: 0x0126D4A0 File Offset: 0x0126B6A0
		[NullableContext(1)]
		private JsonTypeInfo<List<int>> Create_ListInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<int>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<int>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<int>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<int>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<int>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<int>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<int>, int>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF0 RID: 40688
		// (get) Token: 0x06047EBF RID: 294591 RVA: 0x0126D508 File Offset: 0x0126B708
		public JsonTypeInfo<List<string>> ListString
		{
			get
			{
				JsonTypeInfo<List<string>> result;
				if ((result = this._ListString) == null)
				{
					result = (this._ListString = (JsonTypeInfo<List<string>>)base.Options.GetTypeInfo(typeof(List<string>)));
				}
				return result;
			}
		}

		// Token: 0x06047EC0 RID: 294592 RVA: 0x0126D544 File Offset: 0x0126B744
		[NullableContext(1)]
		private JsonTypeInfo<List<string>> Create_ListString(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<string>> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<string>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<string>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<string>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<string>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<string>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<string>, string>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF1 RID: 40689
		// (get) Token: 0x06047EC1 RID: 294593 RVA: 0x0126D5AC File Offset: 0x0126B7AC
		public JsonTypeInfo<int> Int32
		{
			get
			{
				JsonTypeInfo<int> result;
				if ((result = this._Int32) == null)
				{
					result = (this._Int32 = (JsonTypeInfo<int>)base.Options.GetTypeInfo(typeof(int)));
				}
				return result;
			}
		}

		// Token: 0x06047EC2 RID: 294594 RVA: 0x0126D5E8 File Offset: 0x0126B7E8
		[NullableContext(1)]
		private JsonTypeInfo<int> Create_Int32(JsonSerializerOptions options)
		{
			JsonTypeInfo<int> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<int>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int>(options, JsonMetadataServices.Int32Converter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF2 RID: 40690
		// (get) Token: 0x06047EC3 RID: 294595 RVA: 0x0126D614 File Offset: 0x0126B814
		public JsonTypeInfo<int?> NullableInt32
		{
			get
			{
				JsonTypeInfo<int?> result;
				if ((result = this._NullableInt32) == null)
				{
					result = (this._NullableInt32 = (JsonTypeInfo<int?>)base.Options.GetTypeInfo(typeof(int?)));
				}
				return result;
			}
		}

		// Token: 0x06047EC4 RID: 294596 RVA: 0x0126D650 File Offset: 0x0126B850
		[NullableContext(1)]
		private JsonTypeInfo<int?> Create_NullableInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<int?> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<int?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<int>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF3 RID: 40691
		// (get) Token: 0x06047EC5 RID: 294597 RVA: 0x0126D680 File Offset: 0x0126B880
		public JsonTypeInfo<int[]> Int32Array
		{
			get
			{
				JsonTypeInfo<int[]> result;
				if ((result = this._Int32Array) == null)
				{
					result = (this._Int32Array = (JsonTypeInfo<int[]>)base.Options.GetTypeInfo(typeof(int[])));
				}
				return result;
			}
		}

		// Token: 0x06047EC6 RID: 294598 RVA: 0x0126D6BC File Offset: 0x0126B8BC
		[NullableContext(1)]
		private JsonTypeInfo<int[]> Create_Int32Array(JsonSerializerOptions options)
		{
			JsonTypeInfo<int[]> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<int[]>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<int[]> collectionInfo = new JsonCollectionInfoValues<int[]>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateArrayInfo<int>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF4 RID: 40692
		// (get) Token: 0x06047EC7 RID: 294599 RVA: 0x0126D708 File Offset: 0x0126B908
		public JsonTypeInfo<long> Int64
		{
			get
			{
				JsonTypeInfo<long> result;
				if ((result = this._Int64) == null)
				{
					result = (this._Int64 = (JsonTypeInfo<long>)base.Options.GetTypeInfo(typeof(long)));
				}
				return result;
			}
		}

		// Token: 0x06047EC8 RID: 294600 RVA: 0x0126D744 File Offset: 0x0126B944
		[NullableContext(1)]
		private JsonTypeInfo<long> Create_Int64(JsonSerializerOptions options)
		{
			JsonTypeInfo<long> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<long>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<long>(options, JsonMetadataServices.Int64Converter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF5 RID: 40693
		// (get) Token: 0x06047EC9 RID: 294601 RVA: 0x0126D770 File Offset: 0x0126B970
		public JsonTypeInfo<object> Object
		{
			get
			{
				JsonTypeInfo<object> result;
				if ((result = this._Object) == null)
				{
					result = (this._Object = (JsonTypeInfo<object>)base.Options.GetTypeInfo(typeof(object)));
				}
				return result;
			}
		}

		// Token: 0x06047ECA RID: 294602 RVA: 0x0126D7AC File Offset: 0x0126B9AC
		[NullableContext(1)]
		private JsonTypeInfo<object> Create_Object(JsonSerializerOptions options)
		{
			JsonTypeInfo<object> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<object>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<object>(options, JsonMetadataServices.ObjectConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF6 RID: 40694
		// (get) Token: 0x06047ECB RID: 294603 RVA: 0x0126D7D8 File Offset: 0x0126B9D8
		public JsonTypeInfo<string> String
		{
			get
			{
				JsonTypeInfo<string> result;
				if ((result = this._String) == null)
				{
					result = (this._String = (JsonTypeInfo<string>)base.Options.GetTypeInfo(typeof(string)));
				}
				return result;
			}
		}

		// Token: 0x06047ECC RID: 294604 RVA: 0x0126D814 File Offset: 0x0126BA14
		[NullableContext(1)]
		private JsonTypeInfo<string> Create_String(JsonSerializerOptions options)
		{
			JsonTypeInfo<string> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<string>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<string>(options, JsonMetadataServices.StringConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF7 RID: 40695
		// (get) Token: 0x06047ECD RID: 294605 RVA: 0x0126D840 File Offset: 0x0126BA40
		public JsonTypeInfo<string[]> StringArray
		{
			get
			{
				JsonTypeInfo<string[]> result;
				if ((result = this._StringArray) == null)
				{
					result = (this._StringArray = (JsonTypeInfo<string[]>)base.Options.GetTypeInfo(typeof(string[])));
				}
				return result;
			}
		}

		// Token: 0x06047ECE RID: 294606 RVA: 0x0126D87C File Offset: 0x0126BA7C
		[NullableContext(1)]
		private JsonTypeInfo<string[]> Create_StringArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<string[]> jsonTypeInfo;
			if (!LocalStorageJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<string[]>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<string[]> collectionInfo = new JsonCollectionInfoValues<string[]>
				{
					ObjectCreator = null,
					SerializeHandler = null
				};
				jsonTypeInfo = JsonMetadataServices.CreateArrayInfo<string>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17009EF8 RID: 40696
		// (get) Token: 0x06047ECF RID: 294607 RVA: 0x0126D8C6 File Offset: 0x0126BAC6
		[Nullable(1)]
		public static LocalStorageJsonSourceGenContext Default { [NullableContext(1)] get; } = new LocalStorageJsonSourceGenContext(new JsonSerializerOptions(LocalStorageJsonSourceGenContext.s_defaultOptions));

		// Token: 0x17009EF9 RID: 40697
		// (get) Token: 0x06047ED0 RID: 294608 RVA: 0x0126D8CD File Offset: 0x0126BACD
		[Nullable(2)]
		protected override JsonSerializerOptions GeneratedSerializerOptions { [NullableContext(2)] get; } = LocalStorageJsonSourceGenContext.s_defaultOptions;

		// Token: 0x06047ED1 RID: 294609 RVA: 0x0126D8D5 File Offset: 0x0126BAD5
		public LocalStorageJsonSourceGenContext() : base(null)
		{
		}

		// Token: 0x06047ED2 RID: 294610 RVA: 0x0126D8E9 File Offset: 0x0126BAE9
		[NullableContext(1)]
		public LocalStorageJsonSourceGenContext(JsonSerializerOptions options) : base(options)
		{
		}

		// Token: 0x06047ED3 RID: 294611 RVA: 0x0126D900 File Offset: 0x0126BB00
		[NullableContext(1)]
		private static bool TryGetTypeInfoForRuntimeCustomConverter<[Nullable(2)] TJsonMetadataType>(JsonSerializerOptions options, out JsonTypeInfo<TJsonMetadataType> jsonTypeInfo)
		{
			JsonConverter runtimeConverterForType = LocalStorageJsonSourceGenContext.GetRuntimeConverterForType(typeof(TJsonMetadataType), options);
			if (runtimeConverterForType != null)
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<TJsonMetadataType>(options, runtimeConverterForType);
				return true;
			}
			jsonTypeInfo = null;
			return false;
		}

		// Token: 0x06047ED4 RID: 294612 RVA: 0x0126D930 File Offset: 0x0126BB30
		[NullableContext(1)]
		[return: Nullable(2)]
		private static JsonConverter GetRuntimeConverterForType(Type type, JsonSerializerOptions options)
		{
			for (int i = 0; i < options.Converters.Count; i++)
			{
				JsonConverter jsonConverter = options.Converters[i];
				if (jsonConverter != null && jsonConverter.CanConvert(type))
				{
					return LocalStorageJsonSourceGenContext.ExpandConverter(type, jsonConverter, options, false);
				}
			}
			return null;
		}

		// Token: 0x06047ED5 RID: 294613 RVA: 0x0126D978 File Offset: 0x0126BB78
		[NullableContext(1)]
		private static JsonConverter ExpandConverter(Type type, JsonConverter converter, JsonSerializerOptions options, bool validateCanConvert = true)
		{
			if (validateCanConvert && !converter.CanConvert(type))
			{
				throw new InvalidOperationException(string.Format("The converter '{0}' is not compatible with the type '{1}'.", converter.GetType(), type));
			}
			JsonConverterFactory jsonConverterFactory = converter as JsonConverterFactory;
			if (jsonConverterFactory != null)
			{
				converter = jsonConverterFactory.CreateConverter(type, options);
				if (converter == null || converter is JsonConverterFactory)
				{
					throw new InvalidOperationException(string.Format("The converter '{0}' cannot return null or a JsonConverterFactory instance.", jsonConverterFactory.GetType()));
				}
			}
			return converter;
		}

		// Token: 0x06047ED6 RID: 294614 RVA: 0x0126D9E0 File Offset: 0x0126BBE0
		[NullableContext(1)]
		[return: Nullable(2)]
		public override JsonTypeInfo GetTypeInfo(Type type)
		{
			JsonTypeInfo result;
			base.Options.TryGetTypeInfo(type, out result);
			return result;
		}

		// Token: 0x06047ED7 RID: 294615 RVA: 0x0126DA00 File Offset: 0x0126BC00
		[NullableContext(1)]
		[return: Nullable(2)]
		JsonTypeInfo IJsonTypeInfoResolver.GetTypeInfo(Type type, JsonSerializerOptions options)
		{
			if (type == typeof(bool))
			{
				return this.Create_Boolean(options);
			}
			if (type == typeof(bool?))
			{
				return this.Create_NullableBoolean(options);
			}
			if (type == typeof(double))
			{
				return this.Create_Double(options);
			}
			if (type == typeof(double?))
			{
				return this.Create_NullableDouble(options);
			}
			if (type == typeof(double[]))
			{
				return this.Create_DoubleArray(options);
			}
			if (type == typeof(float))
			{
				return this.Create_Single(options);
			}
			if (type == typeof(float?))
			{
				return this.Create_NullableSingle(options);
			}
			if (type == typeof(float[]))
			{
				return this.Create_SingleArray(options);
			}
			if (type == typeof(AbyssDangoOwnerData))
			{
				return this.Create_AbyssDangoOwnerData(options);
			}
			if (type == typeof(ActivityCacheData))
			{
				return this.Create_ActivityCacheData(options);
			}
			if (type == typeof(AreaExplorePlayState))
			{
				return this.Create_AreaExplorePlayState(options);
			}
			if (type == typeof(EMapNoteId))
			{
				return this.Create_EMapNoteId(options);
			}
			if (type == typeof(EExploreType))
			{
				return this.Create_EExploreType(options);
			}
			if (type == typeof(EFunction))
			{
				return this.Create_EFunction(options);
			}
			if (type == typeof(EMotorMusicPlayMode))
			{
				return this.Create_EMotorMusicPlayMode(options);
			}
			if (type == typeof(EPlayPointState))
			{
				return this.Create_EPlayPointState(options);
			}
			if (type == typeof(ERouletteType))
			{
				return this.Create_ERouletteType(options);
			}
			if (type == typeof(ERouletteType?))
			{
				return this.Create_NullableERouletteType(options);
			}
			if (type == typeof(EVisionLevelUpIdentify))
			{
				return this.Create_EVisionLevelUpIdentify(options);
			}
			if (type == typeof(EVisionLevelUpIdentify?))
			{
				return this.Create_NullableEVisionLevelUpIdentify(options);
			}
			if (type == typeof(EVisionLevelUpMaterialPutInMode))
			{
				return this.Create_EVisionLevelUpMaterialPutInMode(options);
			}
			if (type == typeof(EVisionLevelUpMaterialPutInMode?))
			{
				return this.Create_NullableEVisionLevelUpMaterialPutInMode(options);
			}
			if (type == typeof(EVisionLevelUpMaterialUseType))
			{
				return this.Create_EVisionLevelUpMaterialUseType(options);
			}
			if (type == typeof(EVisionLevelUpMaterialUseType?))
			{
				return this.Create_NullableEVisionLevelUpMaterialUseType(options);
			}
			if (type == typeof(FilterDefine.EFilterType))
			{
				return this.Create_EFilterType(options);
			}
			if (type == typeof(FilterStorageData))
			{
				return this.Create_FilterStorageData(options);
			}
			if (type == typeof(GamepadTypeUsage))
			{
				return this.Create_GamepadTypeUsage(options);
			}
			if (type == typeof(GameQualityData))
			{
				return this.Create_GameQualityData(options);
			}
			if (type == typeof(IRacingBetsSettlementMainViewRecord))
			{
				return this.Create_IRacingBetsSettlementMainViewRecord(options);
			}
			if (type == typeof(LocalFriendApplication))
			{
				return this.Create_LocalFriendApplication(options);
			}
			if (type == typeof(LocalPlayerIpLevelData))
			{
				return this.Create_LocalPlayerIpLevelData(options);
			}
			if (type == typeof(LocalPlayerIpLevelData[]))
			{
				return this.Create_LocalPlayerIpLevelDataArray(options);
			}
			if (type == typeof(MarqueeStorageData))
			{
				return this.Create_MarqueeStorageData(options);
			}
			if (type == typeof(RacingBetsRedDotState))
			{
				return this.Create_RacingBetsRedDotState(options);
			}
			if (type == typeof(RegionAndIpSt))
			{
				return this.Create_RegionAndIpSt(options);
			}
			if (type == typeof(SortStorageData))
			{
				return this.Create_SortStorageData(options);
			}
			if (type == typeof(Dictionary<EFunction, int>))
			{
				return this.Create_DictionaryEFunctionInt32(options);
			}
			if (type == typeof(Dictionary<FilterDefine.EFilterType, List<int>>))
			{
				return this.Create_DictionaryEFilterTypeListInt32(options);
			}
			if (type == typeof(Dictionary<int, bool>))
			{
				return this.Create_DictionaryInt32Boolean(options);
			}
			if (type == typeof(Dictionary<int, double>))
			{
				return this.Create_DictionaryInt32Double(options);
			}
			if (type == typeof(Dictionary<int, float[]>))
			{
				return this.Create_DictionaryInt32SingleArray(options);
			}
			if (type == typeof(Dictionary<int, float>))
			{
				return this.Create_DictionaryInt32Single(options);
			}
			if (type == typeof(Dictionary<int, AbyssDangoOwnerData>))
			{
				return this.Create_DictionaryInt32AbyssDangoOwnerData(options);
			}
			if (type == typeof(Dictionary<int, AreaExplorePlayState>))
			{
				return this.Create_DictionaryInt32AreaExplorePlayState(options);
			}
			if (type == typeof(Dictionary<int, LocalFriendApplication>))
			{
				return this.Create_DictionaryInt32LocalFriendApplication(options);
			}
			if (type == typeof(Dictionary<int, Dictionary<int, double>>))
			{
				return this.Create_DictionaryInt32DictionaryInt32Double(options);
			}
			if (type == typeof(Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>))
			{
				return this.Create_DictionaryInt32DictionaryInt32AbyssDangoOwnerData(options);
			}
			if (type == typeof(Dictionary<int, Dictionary<int, AreaExplorePlayState>>))
			{
				return this.Create_DictionaryInt32DictionaryInt32AreaExplorePlayState(options);
			}
			if (type == typeof(Dictionary<int, Dictionary<int, HashSet<int>>>))
			{
				return this.Create_DictionaryInt32DictionaryInt32HashSetInt32(options);
			}
			if (type == typeof(Dictionary<int, HashSet<int>>))
			{
				return this.Create_DictionaryInt32HashSetInt32(options);
			}
			if (type == typeof(Dictionary<int, List<int>>))
			{
				return this.Create_DictionaryInt32ListInt32(options);
			}
			if (type == typeof(Dictionary<int, int[]>))
			{
				return this.Create_DictionaryInt32Int32Array(options);
			}
			if (type == typeof(Dictionary<int, int>))
			{
				return this.Create_DictionaryInt32Int32(options);
			}
			if (type == typeof(Dictionary<int, long>))
			{
				return this.Create_DictionaryInt32Int64(options);
			}
			if (type == typeof(Dictionary<int, string>))
			{
				return this.Create_DictionaryInt32String(options);
			}
			if (type == typeof(Dictionary<string, bool>))
			{
				return this.Create_DictionaryStringBoolean(options);
			}
			if (type == typeof(Dictionary<string, FilterStorageData>))
			{
				return this.Create_DictionaryStringFilterStorageData(options);
			}
			if (type == typeof(Dictionary<string, GamepadTypeUsage>))
			{
				return this.Create_DictionaryStringGamepadTypeUsage(options);
			}
			if (type == typeof(Dictionary<string, LocalPlayerIpLevelData[]>))
			{
				return this.Create_DictionaryStringLocalPlayerIpLevelDataArray(options);
			}
			if (type == typeof(Dictionary<string, MarqueeStorageData>))
			{
				return this.Create_DictionaryStringMarqueeStorageData(options);
			}
			if (type == typeof(Dictionary<string, RegionAndIpSt>))
			{
				return this.Create_DictionaryStringRegionAndIpSt(options);
			}
			if (type == typeof(Dictionary<string, SortStorageData>))
			{
				return this.Create_DictionaryStringSortStorageData(options);
			}
			if (type == typeof(Dictionary<string, IList<IList<string>>>))
			{
				return this.Create_DictionaryStringIListIListString(options);
			}
			if (type == typeof(Dictionary<string, List<ActivityCacheData>>))
			{
				return this.Create_DictionaryStringListActivityCacheData(options);
			}
			if (type == typeof(Dictionary<string, int>))
			{
				return this.Create_DictionaryStringInt32(options);
			}
			if (type == typeof(HashSet<EMapNoteId>))
			{
				return this.Create_HashSetEMapNoteId(options);
			}
			if (type == typeof(HashSet<int>))
			{
				return this.Create_HashSetInt32(options);
			}
			if (type == typeof(IList<IList<string>>))
			{
				return this.Create_IListIListString(options);
			}
			if (type == typeof(IList<string>))
			{
				return this.Create_IListString(options);
			}
			if (type == typeof(List<ActivityCacheData>))
			{
				return this.Create_ListActivityCacheData(options);
			}
			if (type == typeof(List<EPlayPointState>))
			{
				return this.Create_ListEPlayPointState(options);
			}
			if (type == typeof(List<int>))
			{
				return this.Create_ListInt32(options);
			}
			if (type == typeof(List<string>))
			{
				return this.Create_ListString(options);
			}
			if (type == typeof(int))
			{
				return this.Create_Int32(options);
			}
			if (type == typeof(int?))
			{
				return this.Create_NullableInt32(options);
			}
			if (type == typeof(int[]))
			{
				return this.Create_Int32Array(options);
			}
			if (type == typeof(long))
			{
				return this.Create_Int64(options);
			}
			if (type == typeof(object))
			{
				return this.Create_Object(options);
			}
			if (type == typeof(string))
			{
				return this.Create_String(options);
			}
			if (type == typeof(string[]))
			{
				return this.Create_StringArray(options);
			}
			return null;
		}

		// Token: 0x04025E7C RID: 155260
		[Nullable(2)]
		private JsonTypeInfo<bool> _Boolean;

		// Token: 0x04025E7D RID: 155261
		[Nullable(2)]
		private JsonTypeInfo<bool?> _NullableBoolean;

		// Token: 0x04025E7E RID: 155262
		[Nullable(2)]
		private JsonTypeInfo<double> _Double;

		// Token: 0x04025E7F RID: 155263
		[Nullable(2)]
		private JsonTypeInfo<double?> _NullableDouble;

		// Token: 0x04025E80 RID: 155264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<double[]> _DoubleArray;

		// Token: 0x04025E81 RID: 155265
		[Nullable(2)]
		private JsonTypeInfo<float> _Single;

		// Token: 0x04025E82 RID: 155266
		[Nullable(2)]
		private JsonTypeInfo<float?> _NullableSingle;

		// Token: 0x04025E83 RID: 155267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<float[]> _SingleArray;

		// Token: 0x04025E84 RID: 155268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<AbyssDangoOwnerData> _AbyssDangoOwnerData;

		// Token: 0x04025E85 RID: 155269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ActivityCacheData> _ActivityCacheData;

		// Token: 0x04025E86 RID: 155270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<AreaExplorePlayState> _AreaExplorePlayState;

		// Token: 0x04025E87 RID: 155271
		[Nullable(2)]
		private JsonTypeInfo<EMapNoteId> _EMapNoteId;

		// Token: 0x04025E88 RID: 155272
		[Nullable(2)]
		private JsonTypeInfo<EExploreType> _EExploreType;

		// Token: 0x04025E89 RID: 155273
		[Nullable(2)]
		private JsonTypeInfo<EFunction> _EFunction;

		// Token: 0x04025E8A RID: 155274
		[Nullable(2)]
		private JsonTypeInfo<EMotorMusicPlayMode> _EMotorMusicPlayMode;

		// Token: 0x04025E8B RID: 155275
		[Nullable(2)]
		private JsonTypeInfo<EPlayPointState> _EPlayPointState;

		// Token: 0x04025E8C RID: 155276
		[Nullable(2)]
		private JsonTypeInfo<ERouletteType> _ERouletteType;

		// Token: 0x04025E8D RID: 155277
		[Nullable(2)]
		private JsonTypeInfo<ERouletteType?> _NullableERouletteType;

		// Token: 0x04025E8E RID: 155278
		[Nullable(2)]
		private JsonTypeInfo<EVisionLevelUpIdentify> _EVisionLevelUpIdentify;

		// Token: 0x04025E8F RID: 155279
		[Nullable(2)]
		private JsonTypeInfo<EVisionLevelUpIdentify?> _NullableEVisionLevelUpIdentify;

		// Token: 0x04025E90 RID: 155280
		[Nullable(2)]
		private JsonTypeInfo<EVisionLevelUpMaterialPutInMode> _EVisionLevelUpMaterialPutInMode;

		// Token: 0x04025E91 RID: 155281
		[Nullable(2)]
		private JsonTypeInfo<EVisionLevelUpMaterialPutInMode?> _NullableEVisionLevelUpMaterialPutInMode;

		// Token: 0x04025E92 RID: 155282
		[Nullable(2)]
		private JsonTypeInfo<EVisionLevelUpMaterialUseType> _EVisionLevelUpMaterialUseType;

		// Token: 0x04025E93 RID: 155283
		[Nullable(2)]
		private JsonTypeInfo<EVisionLevelUpMaterialUseType?> _NullableEVisionLevelUpMaterialUseType;

		// Token: 0x04025E94 RID: 155284
		[Nullable(2)]
		private JsonTypeInfo<FilterDefine.EFilterType> _EFilterType;

		// Token: 0x04025E95 RID: 155285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<FilterStorageData> _FilterStorageData;

		// Token: 0x04025E96 RID: 155286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<GamepadTypeUsage> _GamepadTypeUsage;

		// Token: 0x04025E97 RID: 155287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<GameQualityData> _GameQualityData;

		// Token: 0x04025E98 RID: 155288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IRacingBetsSettlementMainViewRecord> _IRacingBetsSettlementMainViewRecord;

		// Token: 0x04025E99 RID: 155289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<LocalFriendApplication> _LocalFriendApplication;

		// Token: 0x04025E9A RID: 155290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<LocalPlayerIpLevelData> _LocalPlayerIpLevelData;

		// Token: 0x04025E9B RID: 155291
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<LocalPlayerIpLevelData[]> _LocalPlayerIpLevelDataArray;

		// Token: 0x04025E9C RID: 155292
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<MarqueeStorageData> _MarqueeStorageData;

		// Token: 0x04025E9D RID: 155293
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RacingBetsRedDotState> _RacingBetsRedDotState;

		// Token: 0x04025E9E RID: 155294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RegionAndIpSt> _RegionAndIpSt;

		// Token: 0x04025E9F RID: 155295
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<SortStorageData> _SortStorageData;

		// Token: 0x04025EA0 RID: 155296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<EFunction, int>> _DictionaryEFunctionInt32;

		// Token: 0x04025EA1 RID: 155297
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<FilterDefine.EFilterType, List<int>>> _DictionaryEFilterTypeListInt32;

		// Token: 0x04025EA2 RID: 155298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<int, bool>> _DictionaryInt32Boolean;

		// Token: 0x04025EA3 RID: 155299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<int, double>> _DictionaryInt32Double;

		// Token: 0x04025EA4 RID: 155300
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, float[]>> _DictionaryInt32SingleArray;

		// Token: 0x04025EA5 RID: 155301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<int, float>> _DictionaryInt32Single;

		// Token: 0x04025EA6 RID: 155302
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, AbyssDangoOwnerData>> _DictionaryInt32AbyssDangoOwnerData;

		// Token: 0x04025EA7 RID: 155303
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, AreaExplorePlayState>> _DictionaryInt32AreaExplorePlayState;

		// Token: 0x04025EA8 RID: 155304
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, LocalFriendApplication>> _DictionaryInt32LocalFriendApplication;

		// Token: 0x04025EA9 RID: 155305
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, double>>> _DictionaryInt32DictionaryInt32Double;

		// Token: 0x04025EAA RID: 155306
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>> _DictionaryInt32DictionaryInt32AbyssDangoOwnerData;

		// Token: 0x04025EAB RID: 155307
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, AreaExplorePlayState>>> _DictionaryInt32DictionaryInt32AreaExplorePlayState;

		// Token: 0x04025EAC RID: 155308
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, Dictionary<int, HashSet<int>>>> _DictionaryInt32DictionaryInt32HashSetInt32;

		// Token: 0x04025EAD RID: 155309
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, HashSet<int>>> _DictionaryInt32HashSetInt32;

		// Token: 0x04025EAE RID: 155310
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, List<int>>> _DictionaryInt32ListInt32;

		// Token: 0x04025EAF RID: 155311
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, int[]>> _DictionaryInt32Int32Array;

		// Token: 0x04025EB0 RID: 155312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<int, int>> _DictionaryInt32Int32;

		// Token: 0x04025EB1 RID: 155313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<int, long>> _DictionaryInt32Int64;

		// Token: 0x04025EB2 RID: 155314
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<int, string>> _DictionaryInt32String;

		// Token: 0x04025EB3 RID: 155315
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, bool>> _DictionaryStringBoolean;

		// Token: 0x04025EB4 RID: 155316
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, FilterStorageData>> _DictionaryStringFilterStorageData;

		// Token: 0x04025EB5 RID: 155317
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, GamepadTypeUsage>> _DictionaryStringGamepadTypeUsage;

		// Token: 0x04025EB6 RID: 155318
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, LocalPlayerIpLevelData[]>> _DictionaryStringLocalPlayerIpLevelDataArray;

		// Token: 0x04025EB7 RID: 155319
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, MarqueeStorageData>> _DictionaryStringMarqueeStorageData;

		// Token: 0x04025EB8 RID: 155320
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, RegionAndIpSt>> _DictionaryStringRegionAndIpSt;

		// Token: 0x04025EB9 RID: 155321
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, SortStorageData>> _DictionaryStringSortStorageData;

		// Token: 0x04025EBA RID: 155322
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, IList<IList<string>>>> _DictionaryStringIListIListString;

		// Token: 0x04025EBB RID: 155323
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, List<ActivityCacheData>>> _DictionaryStringListActivityCacheData;

		// Token: 0x04025EBC RID: 155324
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, int>> _DictionaryStringInt32;

		// Token: 0x04025EBD RID: 155325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<HashSet<EMapNoteId>> _HashSetEMapNoteId;

		// Token: 0x04025EBE RID: 155326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<HashSet<int>> _HashSetInt32;

		// Token: 0x04025EBF RID: 155327
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<IList<IList<string>>> _IListIListString;

		// Token: 0x04025EC0 RID: 155328
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<IList<string>> _IListString;

		// Token: 0x04025EC1 RID: 155329
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<ActivityCacheData>> _ListActivityCacheData;

		// Token: 0x04025EC2 RID: 155330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<List<EPlayPointState>> _ListEPlayPointState;

		// Token: 0x04025EC3 RID: 155331
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<List<int>> _ListInt32;

		// Token: 0x04025EC4 RID: 155332
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<string>> _ListString;

		// Token: 0x04025EC5 RID: 155333
		[Nullable(2)]
		private JsonTypeInfo<int> _Int32;

		// Token: 0x04025EC6 RID: 155334
		[Nullable(2)]
		private JsonTypeInfo<int?> _NullableInt32;

		// Token: 0x04025EC7 RID: 155335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<int[]> _Int32Array;

		// Token: 0x04025EC8 RID: 155336
		[Nullable(2)]
		private JsonTypeInfo<long> _Int64;

		// Token: 0x04025EC9 RID: 155337
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<object> _Object;

		// Token: 0x04025ECA RID: 155338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<string> _String;

		// Token: 0x04025ECB RID: 155339
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<string[]> _StringArray;

		// Token: 0x04025ECC RID: 155340
		[Nullable(1)]
		private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			IncludeFields = true
		};

		// Token: 0x04025ECD RID: 155341
		private const BindingFlags InstanceMemberBindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x0200CF95 RID: 53141
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E633 RID: 255539
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Func<JsonParameterInfoValues[]> <0>__MarqueeStorageDataCtorParamInit;
		}
	}
}
