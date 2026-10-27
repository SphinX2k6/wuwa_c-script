using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CSharpScript.Core.Net;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.LogUpload;
using CSharpScript.Launcher.NetworkDetection;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.PreDownload;
using CSharpScript.Launcher.Server;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;

namespace CSharpScript.Launcher.Util.Json.Generated
{
	// Token: 0x02000083 RID: 131
	[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, IncludeFields = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonSerializable(typeof(EntryJson))]
	[JsonSerializable(typeof(PatchManifestJson))]
	[JsonSerializable(typeof(RemoteVideoConfig))]
	[JsonSerializable(typeof(RemoteVideoConfigUpdateTime))]
	[JsonSerializable(typeof(GameWindowStateData))]
	[JsonSerializable(typeof(UserInfo))]
	[JsonSerializable(typeof(ILocalSendedSave))]
	[JsonSerializable(typeof(INetworkDetectionConfig))]
	[JsonSerializable(typeof(IBlockResponseData))]
	[JsonSerializable(typeof(ICheckoutProductResponse))]
	[JsonSerializable(typeof(IConfigJson))]
	[JsonSerializable(typeof(IConnectResponse))]
	[JsonSerializable(typeof(IGetAccessTokenResponse))]
	[JsonSerializable(typeof(IIdTokenData))]
	[JsonSerializable(typeof(ILoginResponse))]
	[JsonSerializable(typeof(IQueryGoodsResponse))]
	[JsonSerializable(typeof(IRenewAccessTokenResponse))]
	[JsonSerializable(typeof(IReportResponse))]
	[JsonSerializable(typeof(ISdkRequestEmailCodeResponse))]
	[JsonSerializable(typeof(SdkPlatformConfig))]
	[JsonSerializable(typeof(PreDownloadConfig))]
	[JsonSerializable(typeof(RemoteConfig))]
	[JsonSerializable(typeof(RemoteVersionConfig))]
	[JsonSerializable(typeof(LoginPlayerInfo))]
	[JsonSerializable(typeof(HttpSubPackageResult))]
	[JsonSerializable(typeof(PakListConfig))]
	[JsonSerializable(typeof(HttpResult))]
	[JsonSerializable(typeof(LoginNoticeEx))]
	[JsonSerializable(typeof(Result))]
	[JsonSerializable(typeof(Dictionary<int, double>))]
	[JsonSerializable(typeof(Dictionary<string, double>))]
	[JsonSerializable(typeof(Dictionary<string, PatchManifestJson>))]
	[JsonSerializable(typeof(Dictionary<string, object>))]
	[GeneratedCode("System.Text.Json.SourceGeneration", "9.0.12.26613")]
	internal class LauncherJsonSourceGenContext : JsonSerializerContext, IJsonTypeInfoResolver
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00012BF0 File Offset: 0x00010DF0
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

		// Token: 0x06000374 RID: 884 RVA: 0x00012C2C File Offset: 0x00010E2C
		[NullableContext(1)]
		private JsonTypeInfo<bool> Create_Boolean(JsonSerializerOptions options)
		{
			JsonTypeInfo<bool> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<bool>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<bool>(options, JsonMetadataServices.BooleanConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00012C58 File Offset: 0x00010E58
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

		// Token: 0x06000376 RID: 886 RVA: 0x00012C94 File Offset: 0x00010E94
		[NullableContext(1)]
		private JsonTypeInfo<bool?> Create_NullableBoolean(JsonSerializerOptions options)
		{
			JsonTypeInfo<bool?> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<bool?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<bool>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<bool?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00012CC4 File Offset: 0x00010EC4
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

		// Token: 0x06000378 RID: 888 RVA: 0x00012D00 File Offset: 0x00010F00
		[NullableContext(1)]
		private JsonTypeInfo<double> Create_Double(JsonSerializerOptions options)
		{
			JsonTypeInfo<double> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<double>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<double>(options, JsonMetadataServices.DoubleConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00012D2C File Offset: 0x00010F2C
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

		// Token: 0x0600037A RID: 890 RVA: 0x00012D68 File Offset: 0x00010F68
		[NullableContext(1)]
		private JsonTypeInfo<float> Create_Single(JsonSerializerOptions options)
		{
			JsonTypeInfo<float> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<float>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<float>(options, JsonMetadataServices.SingleConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00012D94 File Offset: 0x00010F94
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

		// Token: 0x0600037C RID: 892 RVA: 0x00012DD0 File Offset: 0x00010FD0
		[NullableContext(1)]
		private JsonTypeInfo<float?> Create_NullableSingle(JsonSerializerOptions options)
		{
			JsonTypeInfo<float?> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<float?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<float>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<float?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00012E00 File Offset: 0x00011000
		public JsonTypeInfo<GatewayLatencyConfigVo> GatewayLatencyConfigVo
		{
			get
			{
				JsonTypeInfo<GatewayLatencyConfigVo> result;
				if ((result = this._GatewayLatencyConfigVo) == null)
				{
					result = (this._GatewayLatencyConfigVo = (JsonTypeInfo<GatewayLatencyConfigVo>)base.Options.GetTypeInfo(typeof(GatewayLatencyConfigVo)));
				}
				return result;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00012E3C File Offset: 0x0001103C
		[NullableContext(1)]
		private JsonTypeInfo<GatewayLatencyConfigVo> Create_GatewayLatencyConfigVo(JsonSerializerOptions options)
		{
			JsonTypeInfo<GatewayLatencyConfigVo> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<GatewayLatencyConfigVo>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<GatewayLatencyConfigVo> jsonObjectInfoValues = new JsonObjectInfoValues<GatewayLatencyConfigVo>();
				jsonObjectInfoValues.ObjectCreator = (() => new GatewayLatencyConfigVo());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.GatewayLatencyConfigVoPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(GatewayLatencyConfigVo).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<GatewayLatencyConfigVo> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<GatewayLatencyConfigVo>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00012F04 File Offset: 0x00011104
		[NullableContext(1)]
		private static JsonPropertyInfo[] GatewayLatencyConfigVoPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(GatewayLatencyConfigVo);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((GatewayLatencyConfigVo)obj).enabled);
			jsonPropertyInfoValues.Setter = delegate(object obj, bool value)
			{
				((GatewayLatencyConfigVo)obj).enabled = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "enabled";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(GatewayLatencyConfigVo).GetField("enabled", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(GatewayLatencyConfigVo);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((GatewayLatencyConfigVo)obj).count);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((GatewayLatencyConfigVo)obj).count = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "count";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(GatewayLatencyConfigVo).GetField("count", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(GatewayLatencyConfigVo);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((GatewayLatencyConfigVo)obj).timeoutMs);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int value)
			{
				((GatewayLatencyConfigVo)obj).timeoutMs = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "timeoutMs";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(GatewayLatencyConfigVo).GetField("timeoutMs", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo3);
			return array;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000380 RID: 896 RVA: 0x000131D8 File Offset: 0x000113D8
		public JsonTypeInfo<NetHostInfo> NetHostInfo
		{
			get
			{
				JsonTypeInfo<NetHostInfo> result;
				if ((result = this._NetHostInfo) == null)
				{
					result = (this._NetHostInfo = (JsonTypeInfo<NetHostInfo>)base.Options.GetTypeInfo(typeof(NetHostInfo)));
				}
				return result;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00013214 File Offset: 0x00011414
		[NullableContext(1)]
		private JsonTypeInfo<NetHostInfo> Create_NetHostInfo(JsonSerializerOptions options)
		{
			JsonTypeInfo<NetHostInfo> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<NetHostInfo>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<NetHostInfo> jsonObjectInfoValues = new JsonObjectInfoValues<NetHostInfo>();
				jsonObjectInfoValues.ObjectCreator = (() => new NetHostInfo());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.NetHostInfoPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(NetHostInfo).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<NetHostInfo> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<NetHostInfo>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000132DC File Offset: 0x000114DC
		[NullableContext(1)]
		private static JsonPropertyInfo[] NetHostInfoPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(NetHostInfo);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((NetHostInfo)obj).host);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((NetHostInfo)obj).host = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "host";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(NetHostInfo).GetField("host", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(NetHostInfo);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((NetHostInfo)obj).port);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((NetHostInfo)obj).port = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "port";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(NetHostInfo).GetField("port", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			return array;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000134D4 File Offset: 0x000116D4
		public JsonTypeInfo<EntryJson> EntryJson
		{
			get
			{
				JsonTypeInfo<EntryJson> result;
				if ((result = this._EntryJson) == null)
				{
					result = (this._EntryJson = (JsonTypeInfo<EntryJson>)base.Options.GetTypeInfo(typeof(EntryJson)));
				}
				return result;
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00013510 File Offset: 0x00011710
		[NullableContext(1)]
		private JsonTypeInfo<EntryJson> Create_EntryJson(JsonSerializerOptions options)
		{
			JsonTypeInfo<EntryJson> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<EntryJson>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<EntryJson> jsonObjectInfoValues = new JsonObjectInfoValues<EntryJson>();
				jsonObjectInfoValues.ObjectCreator = (() => new EntryJson());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.EntryJsonPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(EntryJson).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<EntryJson> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<EntryJson>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000135D8 File Offset: 0x000117D8
		[NullableContext(1)]
		private static JsonPropertyInfo[] EntryJsonPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[28];
			JsonPropertyInfoValues<List<ICdnUrlData>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<ICdnUrlData>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((EntryJson)obj).CdnUrl);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<ICdnUrlData> value)
			{
				((EntryJson)obj).CdnUrl = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "CdnUrl";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(EntryJson).GetField("CdnUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<ICdnUrlData>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<ICdnUrlData>>(options, propertyInfo);
			JsonPropertyInfoValues<float?> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<float?>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((EntryJson)obj).SpeedRatio);
			jsonPropertyInfoValues2.Setter = delegate(object obj, float? value)
			{
				((EntryJson)obj).SpeedRatio = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "SpeedRatio";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(EntryJson).GetField("SpeedRatio", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<float?> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<float?>(options, propertyInfo2);
			JsonPropertyInfoValues<float?> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<float?>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((EntryJson)obj).PriceRatio);
			jsonPropertyInfoValues3.Setter = delegate(object obj, float? value)
			{
				((EntryJson)obj).PriceRatio = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "PriceRatio";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(EntryJson).GetField("PriceRatio", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<float?> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<float?>(options, propertyInfo3);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((EntryJson)obj).NoticeUrl);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((EntryJson)obj).NoticeUrl = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "NoticeUrl";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(EntryJson).GetField("NoticeUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			JsonPropertyInfoValues<List<ILoginServersData>> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<List<ILoginServersData>>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((EntryJson)obj).LoginServers);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<ILoginServersData> value)
			{
				((EntryJson)obj).LoginServers = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "LoginServers";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(EntryJson).GetField("LoginServers", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<ILoginServersData>> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<List<ILoginServersData>>(options, propertyInfo5);
			JsonPropertyInfoValues<IPrivateServersData> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<IPrivateServersData>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((EntryJson)obj).PrivateServers);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] IPrivateServersData value)
			{
				((EntryJson)obj).PrivateServers = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "PrivateServers";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(EntryJson).GetField("PrivateServers", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IPrivateServersData> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<IPrivateServersData>(options, propertyInfo6);
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((EntryJson)obj).GmOpen);
			jsonPropertyInfoValues7.Setter = delegate(object obj, bool? value)
			{
				((EntryJson)obj).GmOpen = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "GmOpen";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(EntryJson).GetField("GmOpen", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo7);
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((EntryJson)obj).RptOpen);
			jsonPropertyInfoValues8.Setter = delegate(object obj, bool? value)
			{
				((EntryJson)obj).RptOpen = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "RptOpen";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(EntryJson).GetField("RptOpen", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo8);
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((EntryJson)obj).AsyncCheck);
			jsonPropertyInfoValues9.Setter = delegate(object obj, bool? value)
			{
				((EntryJson)obj).AsyncCheck = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "AsyncCheck";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(EntryJson).GetField("AsyncCheck", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo9);
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((EntryJson)obj).NewHttpTimer);
			jsonPropertyInfoValues10.Setter = delegate(object obj, bool? value)
			{
				((EntryJson)obj).NewHttpTimer = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "NewHttpTimer";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(EntryJson).GetField("NewHttpTimer", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo10);
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((EntryJson)obj).NewHttpApi);
			jsonPropertyInfoValues11.Setter = delegate(object obj, bool? value)
			{
				((EntryJson)obj).NewHttpApi = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "NewHttpApi";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(EntryJson).GetField("NewHttpApi", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo11);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((EntryJson)obj).GARUrl);
			jsonPropertyInfoValues12.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((EntryJson)obj).GARUrl = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "GARUrl";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(EntryJson).GetField("GARUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo12);
			JsonPropertyInfoValues<ITDConfig> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<ITDConfig>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((EntryJson)obj).TDCfg);
			jsonPropertyInfoValues13.Setter = delegate(object obj, [Nullable(2)] ITDConfig value)
			{
				((EntryJson)obj).TDCfg = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "TDCfg";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(EntryJson).GetField("TDCfg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ITDConfig> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<ITDConfig>(options, propertyInfo13);
			JsonPropertyInfoValues<ITDConfig> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<ITDConfig>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((EntryJson)obj).KDCfg);
			jsonPropertyInfoValues14.Setter = delegate(object obj, [Nullable(2)] ITDConfig value)
			{
				((EntryJson)obj).KDCfg = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "KDCfg";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(EntryJson).GetField("KDCfg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ITDConfig> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<ITDConfig>(options, propertyInfo14);
			JsonPropertyInfoValues<string[]> jsonPropertyInfoValues15 = new JsonPropertyInfoValues<string[]>();
			jsonPropertyInfoValues15.IsProperty = false;
			jsonPropertyInfoValues15.IsPublic = true;
			jsonPropertyInfoValues15.IsVirtual = false;
			jsonPropertyInfoValues15.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues15.Converter = null;
			jsonPropertyInfoValues15.Getter = ((object obj) => ((EntryJson)obj).ServerTimeUrl);
			jsonPropertyInfoValues15.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] string[] value)
			{
				((EntryJson)obj).ServerTimeUrl = value;
			};
			jsonPropertyInfoValues15.IgnoreCondition = null;
			jsonPropertyInfoValues15.HasJsonInclude = false;
			jsonPropertyInfoValues15.IsExtensionData = false;
			jsonPropertyInfoValues15.NumberHandling = null;
			jsonPropertyInfoValues15.PropertyName = "ServerTimeUrl";
			jsonPropertyInfoValues15.JsonPropertyName = null;
			jsonPropertyInfoValues15.AttributeProviderFactory = (() => typeof(EntryJson).GetField("ServerTimeUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string[]> propertyInfo15 = jsonPropertyInfoValues15;
			array[14] = JsonMetadataServices.CreatePropertyInfo<string[]>(options, propertyInfo15);
			array[14].IsGetNullable = false;
			array[14].IsSetNullable = false;
			JsonPropertyInfoValues<ILogReport> jsonPropertyInfoValues16 = new JsonPropertyInfoValues<ILogReport>();
			jsonPropertyInfoValues16.IsProperty = false;
			jsonPropertyInfoValues16.IsPublic = true;
			jsonPropertyInfoValues16.IsVirtual = false;
			jsonPropertyInfoValues16.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues16.Converter = null;
			jsonPropertyInfoValues16.Getter = ((object obj) => ((EntryJson)obj).LogReport);
			jsonPropertyInfoValues16.Setter = delegate(object obj, [Nullable(2)] ILogReport value)
			{
				((EntryJson)obj).LogReport = value;
			};
			jsonPropertyInfoValues16.IgnoreCondition = null;
			jsonPropertyInfoValues16.HasJsonInclude = false;
			jsonPropertyInfoValues16.IsExtensionData = false;
			jsonPropertyInfoValues16.NumberHandling = null;
			jsonPropertyInfoValues16.PropertyName = "LogReport";
			jsonPropertyInfoValues16.JsonPropertyName = null;
			jsonPropertyInfoValues16.AttributeProviderFactory = (() => typeof(EntryJson).GetField("LogReport", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ILogReport> propertyInfo16 = jsonPropertyInfoValues16;
			array[15] = JsonMetadataServices.CreatePropertyInfo<ILogReport>(options, propertyInfo16);
			JsonPropertyInfoValues<IUpdateUrl> jsonPropertyInfoValues17 = new JsonPropertyInfoValues<IUpdateUrl>();
			jsonPropertyInfoValues17.IsProperty = false;
			jsonPropertyInfoValues17.IsPublic = true;
			jsonPropertyInfoValues17.IsVirtual = false;
			jsonPropertyInfoValues17.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues17.Converter = null;
			jsonPropertyInfoValues17.Getter = ((object obj) => ((EntryJson)obj).PackageUpdateUrl);
			jsonPropertyInfoValues17.Setter = delegate(object obj, [Nullable(2)] IUpdateUrl value)
			{
				((EntryJson)obj).PackageUpdateUrl = value;
			};
			jsonPropertyInfoValues17.IgnoreCondition = null;
			jsonPropertyInfoValues17.HasJsonInclude = false;
			jsonPropertyInfoValues17.IsExtensionData = false;
			jsonPropertyInfoValues17.NumberHandling = null;
			jsonPropertyInfoValues17.PropertyName = "PackageUpdateUrl";
			jsonPropertyInfoValues17.JsonPropertyName = null;
			jsonPropertyInfoValues17.AttributeProviderFactory = (() => typeof(EntryJson).GetField("PackageUpdateUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IUpdateUrl> propertyInfo17 = jsonPropertyInfoValues17;
			array[16] = JsonMetadataServices.CreatePropertyInfo<IUpdateUrl>(options, propertyInfo17);
			JsonPropertyInfoValues<IUpdateUrl> jsonPropertyInfoValues18 = new JsonPropertyInfoValues<IUpdateUrl>();
			jsonPropertyInfoValues18.IsProperty = false;
			jsonPropertyInfoValues18.IsPublic = true;
			jsonPropertyInfoValues18.IsVirtual = false;
			jsonPropertyInfoValues18.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues18.Converter = null;
			jsonPropertyInfoValues18.Getter = ((object obj) => ((EntryJson)obj).PackageUpdateDescUrl);
			jsonPropertyInfoValues18.Setter = delegate(object obj, [Nullable(2)] IUpdateUrl value)
			{
				((EntryJson)obj).PackageUpdateDescUrl = value;
			};
			jsonPropertyInfoValues18.IgnoreCondition = null;
			jsonPropertyInfoValues18.HasJsonInclude = false;
			jsonPropertyInfoValues18.IsExtensionData = false;
			jsonPropertyInfoValues18.NumberHandling = null;
			jsonPropertyInfoValues18.PropertyName = "PackageUpdateDescUrl";
			jsonPropertyInfoValues18.JsonPropertyName = null;
			jsonPropertyInfoValues18.AttributeProviderFactory = (() => typeof(EntryJson).GetField("PackageUpdateDescUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IUpdateUrl> propertyInfo18 = jsonPropertyInfoValues18;
			array[17] = JsonMetadataServices.CreatePropertyInfo<IUpdateUrl>(options, propertyInfo18);
			JsonPropertyInfoValues<IUpdateUrl> jsonPropertyInfoValues19 = new JsonPropertyInfoValues<IUpdateUrl>();
			jsonPropertyInfoValues19.IsProperty = false;
			jsonPropertyInfoValues19.IsPublic = true;
			jsonPropertyInfoValues19.IsVirtual = false;
			jsonPropertyInfoValues19.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues19.Converter = null;
			jsonPropertyInfoValues19.Getter = ((object obj) => ((EntryJson)obj).ParallelPackageDescUrl);
			jsonPropertyInfoValues19.Setter = delegate(object obj, [Nullable(2)] IUpdateUrl value)
			{
				((EntryJson)obj).ParallelPackageDescUrl = value;
			};
			jsonPropertyInfoValues19.IgnoreCondition = null;
			jsonPropertyInfoValues19.HasJsonInclude = false;
			jsonPropertyInfoValues19.IsExtensionData = false;
			jsonPropertyInfoValues19.NumberHandling = null;
			jsonPropertyInfoValues19.PropertyName = "ParallelPackageDescUrl";
			jsonPropertyInfoValues19.JsonPropertyName = null;
			jsonPropertyInfoValues19.AttributeProviderFactory = (() => typeof(EntryJson).GetField("ParallelPackageDescUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IUpdateUrl> propertyInfo19 = jsonPropertyInfoValues19;
			array[18] = JsonMetadataServices.CreatePropertyInfo<IUpdateUrl>(options, propertyInfo19);
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues20 = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues20.IsProperty = false;
			jsonPropertyInfoValues20.IsPublic = true;
			jsonPropertyInfoValues20.IsVirtual = false;
			jsonPropertyInfoValues20.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues20.Converter = null;
			jsonPropertyInfoValues20.Getter = ((object obj) => ((EntryJson)obj).IosAuditFirstDownloadTip);
			jsonPropertyInfoValues20.Setter = delegate(object obj, bool? value)
			{
				((EntryJson)obj).IosAuditFirstDownloadTip = value;
			};
			jsonPropertyInfoValues20.IgnoreCondition = null;
			jsonPropertyInfoValues20.HasJsonInclude = false;
			jsonPropertyInfoValues20.IsExtensionData = false;
			jsonPropertyInfoValues20.NumberHandling = null;
			jsonPropertyInfoValues20.PropertyName = "IosAuditFirstDownloadTip";
			jsonPropertyInfoValues20.JsonPropertyName = null;
			jsonPropertyInfoValues20.AttributeProviderFactory = (() => typeof(EntryJson).GetField("IosAuditFirstDownloadTip", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo20 = jsonPropertyInfoValues20;
			array[19] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo20);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues21 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues21.IsProperty = false;
			jsonPropertyInfoValues21.IsPublic = true;
			jsonPropertyInfoValues21.IsVirtual = false;
			jsonPropertyInfoValues21.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues21.Converter = null;
			jsonPropertyInfoValues21.Getter = ((object obj) => ((EntryJson)obj).MixUri);
			jsonPropertyInfoValues21.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((EntryJson)obj).MixUri = value;
			};
			jsonPropertyInfoValues21.IgnoreCondition = null;
			jsonPropertyInfoValues21.HasJsonInclude = false;
			jsonPropertyInfoValues21.IsExtensionData = false;
			jsonPropertyInfoValues21.NumberHandling = null;
			jsonPropertyInfoValues21.PropertyName = "MixUri";
			jsonPropertyInfoValues21.JsonPropertyName = null;
			jsonPropertyInfoValues21.AttributeProviderFactory = (() => typeof(EntryJson).GetField("MixUri", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo21 = jsonPropertyInfoValues21;
			array[20] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo21);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues22 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues22.IsProperty = false;
			jsonPropertyInfoValues22.IsPublic = true;
			jsonPropertyInfoValues22.IsVirtual = false;
			jsonPropertyInfoValues22.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues22.Converter = null;
			jsonPropertyInfoValues22.Getter = ((object obj) => ((EntryJson)obj).ResUri);
			jsonPropertyInfoValues22.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((EntryJson)obj).ResUri = value;
			};
			jsonPropertyInfoValues22.IgnoreCondition = null;
			jsonPropertyInfoValues22.HasJsonInclude = false;
			jsonPropertyInfoValues22.IsExtensionData = false;
			jsonPropertyInfoValues22.NumberHandling = null;
			jsonPropertyInfoValues22.PropertyName = "ResUri";
			jsonPropertyInfoValues22.JsonPropertyName = null;
			jsonPropertyInfoValues22.AttributeProviderFactory = (() => typeof(EntryJson).GetField("ResUri", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo22 = jsonPropertyInfoValues22;
			array[21] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo22);
			JsonPropertyInfoValues<IGachaUrl> jsonPropertyInfoValues23 = new JsonPropertyInfoValues<IGachaUrl>();
			jsonPropertyInfoValues23.IsProperty = false;
			jsonPropertyInfoValues23.IsPublic = true;
			jsonPropertyInfoValues23.IsVirtual = false;
			jsonPropertyInfoValues23.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues23.Converter = null;
			jsonPropertyInfoValues23.Getter = ((object obj) => ((EntryJson)obj).GachaUrl);
			jsonPropertyInfoValues23.Setter = delegate(object obj, [Nullable(2)] IGachaUrl value)
			{
				((EntryJson)obj).GachaUrl = value;
			};
			jsonPropertyInfoValues23.IgnoreCondition = null;
			jsonPropertyInfoValues23.HasJsonInclude = false;
			jsonPropertyInfoValues23.IsExtensionData = false;
			jsonPropertyInfoValues23.NumberHandling = null;
			jsonPropertyInfoValues23.PropertyName = "GachaUrl";
			jsonPropertyInfoValues23.JsonPropertyName = null;
			jsonPropertyInfoValues23.AttributeProviderFactory = (() => typeof(EntryJson).GetField("GachaUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IGachaUrl> propertyInfo23 = jsonPropertyInfoValues23;
			array[22] = JsonMetadataServices.CreatePropertyInfo<IGachaUrl>(options, propertyInfo23);
			JsonPropertyInfoValues<IGrayBoxConfig> jsonPropertyInfoValues24 = new JsonPropertyInfoValues<IGrayBoxConfig>();
			jsonPropertyInfoValues24.IsProperty = false;
			jsonPropertyInfoValues24.IsPublic = true;
			jsonPropertyInfoValues24.IsVirtual = false;
			jsonPropertyInfoValues24.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues24.Converter = null;
			jsonPropertyInfoValues24.Getter = ((object obj) => ((EntryJson)obj).GrayBox);
			jsonPropertyInfoValues24.Setter = delegate(object obj, [Nullable(2)] IGrayBoxConfig value)
			{
				((EntryJson)obj).GrayBox = value;
			};
			jsonPropertyInfoValues24.IgnoreCondition = null;
			jsonPropertyInfoValues24.HasJsonInclude = false;
			jsonPropertyInfoValues24.IsExtensionData = false;
			jsonPropertyInfoValues24.NumberHandling = null;
			jsonPropertyInfoValues24.PropertyName = "GrayBox";
			jsonPropertyInfoValues24.JsonPropertyName = null;
			jsonPropertyInfoValues24.AttributeProviderFactory = (() => typeof(EntryJson).GetField("GrayBox", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IGrayBoxConfig> propertyInfo24 = jsonPropertyInfoValues24;
			array[23] = JsonMetadataServices.CreatePropertyInfo<IGrayBoxConfig>(options, propertyInfo24);
			JsonPropertyInfoValues<Dictionary<string, IUdpRegion>> jsonPropertyInfoValues25 = new JsonPropertyInfoValues<Dictionary<string, IUdpRegion>>();
			jsonPropertyInfoValues25.IsProperty = false;
			jsonPropertyInfoValues25.IsPublic = true;
			jsonPropertyInfoValues25.IsVirtual = false;
			jsonPropertyInfoValues25.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues25.Converter = null;
			jsonPropertyInfoValues25.Getter = ((object obj) => ((EntryJson)obj).UdpDelay);
			jsonPropertyInfoValues25.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, IUdpRegion> value)
			{
				((EntryJson)obj).UdpDelay = value;
			};
			jsonPropertyInfoValues25.IgnoreCondition = null;
			jsonPropertyInfoValues25.HasJsonInclude = false;
			jsonPropertyInfoValues25.IsExtensionData = false;
			jsonPropertyInfoValues25.NumberHandling = null;
			jsonPropertyInfoValues25.PropertyName = "UdpDelay";
			jsonPropertyInfoValues25.JsonPropertyName = null;
			jsonPropertyInfoValues25.AttributeProviderFactory = (() => typeof(EntryJson).GetField("UdpDelay", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, IUdpRegion>> propertyInfo25 = jsonPropertyInfoValues25;
			array[24] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, IUdpRegion>>(options, propertyInfo25);
			JsonPropertyInfoValues<IEvalConfig> jsonPropertyInfoValues26 = new JsonPropertyInfoValues<IEvalConfig>();
			jsonPropertyInfoValues26.IsProperty = false;
			jsonPropertyInfoValues26.IsPublic = true;
			jsonPropertyInfoValues26.IsVirtual = false;
			jsonPropertyInfoValues26.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues26.Converter = null;
			jsonPropertyInfoValues26.Getter = ((object obj) => ((EntryJson)obj).CdnEvalCfg);
			jsonPropertyInfoValues26.Setter = delegate(object obj, [Nullable(2)] IEvalConfig value)
			{
				((EntryJson)obj).CdnEvalCfg = value;
			};
			jsonPropertyInfoValues26.IgnoreCondition = null;
			jsonPropertyInfoValues26.HasJsonInclude = false;
			jsonPropertyInfoValues26.IsExtensionData = false;
			jsonPropertyInfoValues26.NumberHandling = null;
			jsonPropertyInfoValues26.PropertyName = "CdnEvalCfg";
			jsonPropertyInfoValues26.JsonPropertyName = null;
			jsonPropertyInfoValues26.AttributeProviderFactory = (() => typeof(EntryJson).GetField("CdnEvalCfg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IEvalConfig> propertyInfo26 = jsonPropertyInfoValues26;
			array[25] = JsonMetadataServices.CreatePropertyInfo<IEvalConfig>(options, propertyInfo26);
			JsonPropertyInfoValues<ICdnScoreCfg> jsonPropertyInfoValues27 = new JsonPropertyInfoValues<ICdnScoreCfg>();
			jsonPropertyInfoValues27.IsProperty = false;
			jsonPropertyInfoValues27.IsPublic = true;
			jsonPropertyInfoValues27.IsVirtual = false;
			jsonPropertyInfoValues27.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues27.Converter = null;
			jsonPropertyInfoValues27.Getter = ((object obj) => ((EntryJson)obj).CdnScoreCfg);
			jsonPropertyInfoValues27.Setter = delegate(object obj, [Nullable(2)] ICdnScoreCfg value)
			{
				((EntryJson)obj).CdnScoreCfg = value;
			};
			jsonPropertyInfoValues27.IgnoreCondition = null;
			jsonPropertyInfoValues27.HasJsonInclude = false;
			jsonPropertyInfoValues27.IsExtensionData = false;
			jsonPropertyInfoValues27.NumberHandling = null;
			jsonPropertyInfoValues27.PropertyName = "CdnScoreCfg";
			jsonPropertyInfoValues27.JsonPropertyName = null;
			jsonPropertyInfoValues27.AttributeProviderFactory = (() => typeof(EntryJson).GetField("CdnScoreCfg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ICdnScoreCfg> propertyInfo27 = jsonPropertyInfoValues27;
			array[26] = JsonMetadataServices.CreatePropertyInfo<ICdnScoreCfg>(options, propertyInfo27);
			JsonPropertyInfoValues<Dictionary<string, string>> jsonPropertyInfoValues28 = new JsonPropertyInfoValues<Dictionary<string, string>>();
			jsonPropertyInfoValues28.IsProperty = false;
			jsonPropertyInfoValues28.IsPublic = true;
			jsonPropertyInfoValues28.IsVirtual = false;
			jsonPropertyInfoValues28.DeclaringType = typeof(EntryJson);
			jsonPropertyInfoValues28.Converter = null;
			jsonPropertyInfoValues28.Getter = ((object obj) => ((EntryJson)obj).SDKEnvironment);
			jsonPropertyInfoValues28.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, string> value)
			{
				((EntryJson)obj).SDKEnvironment = value;
			};
			jsonPropertyInfoValues28.IgnoreCondition = null;
			jsonPropertyInfoValues28.HasJsonInclude = false;
			jsonPropertyInfoValues28.IsExtensionData = false;
			jsonPropertyInfoValues28.NumberHandling = null;
			jsonPropertyInfoValues28.PropertyName = "SDKEnvironment";
			jsonPropertyInfoValues28.JsonPropertyName = null;
			jsonPropertyInfoValues28.AttributeProviderFactory = (() => typeof(EntryJson).GetField("SDKEnvironment", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, string>> propertyInfo28 = jsonPropertyInfoValues28;
			array[27] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, string>>(options, propertyInfo28);
			return array;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00014FF8 File Offset: 0x000131F8
		public JsonTypeInfo<ICdnScoreCfg> ICdnScoreCfg
		{
			get
			{
				JsonTypeInfo<ICdnScoreCfg> result;
				if ((result = this._ICdnScoreCfg) == null)
				{
					result = (this._ICdnScoreCfg = (JsonTypeInfo<ICdnScoreCfg>)base.Options.GetTypeInfo(typeof(ICdnScoreCfg)));
				}
				return result;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00015034 File Offset: 0x00013234
		[NullableContext(1)]
		private JsonTypeInfo<ICdnScoreCfg> Create_ICdnScoreCfg(JsonSerializerOptions options)
		{
			JsonTypeInfo<ICdnScoreCfg> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ICdnScoreCfg>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ICdnScoreCfg> jsonObjectInfoValues = new JsonObjectInfoValues<ICdnScoreCfg>();
				jsonObjectInfoValues.ObjectCreator = (() => new ICdnScoreCfg());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ICdnScoreCfgPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ICdnScoreCfg).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ICdnScoreCfg> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ICdnScoreCfg>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000150FC File Offset: 0x000132FC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ICdnScoreCfgPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ICdnScoreCfg);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ICdnScoreCfg)obj).UsedCandidate);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreCfg)obj).UsedCandidate = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "UsedCandidate";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ICdnScoreCfg).GetField("UsedCandidate", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<List<ICdnScoreFormula>> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<List<ICdnScoreFormula>>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ICdnScoreCfg);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ICdnScoreCfg)obj).Candidates);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<ICdnScoreFormula> value)
			{
				((ICdnScoreCfg)obj).Candidates = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Candidates";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ICdnScoreCfg).GetField("Candidates", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<ICdnScoreFormula>> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<List<ICdnScoreFormula>>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00015308 File Offset: 0x00013508
		public JsonTypeInfo<ICdnScoreFormula> ICdnScoreFormula
		{
			get
			{
				JsonTypeInfo<ICdnScoreFormula> result;
				if ((result = this._ICdnScoreFormula) == null)
				{
					result = (this._ICdnScoreFormula = (JsonTypeInfo<ICdnScoreFormula>)base.Options.GetTypeInfo(typeof(ICdnScoreFormula)));
				}
				return result;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00015344 File Offset: 0x00013544
		[NullableContext(1)]
		private JsonTypeInfo<ICdnScoreFormula> Create_ICdnScoreFormula(JsonSerializerOptions options)
		{
			JsonTypeInfo<ICdnScoreFormula> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ICdnScoreFormula>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ICdnScoreFormula> jsonObjectInfoValues = new JsonObjectInfoValues<ICdnScoreFormula>();
				jsonObjectInfoValues.ObjectCreator = (() => new ICdnScoreFormula());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ICdnScoreFormulaPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ICdnScoreFormula).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ICdnScoreFormula> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ICdnScoreFormula>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001540C File Offset: 0x0001360C
		[NullableContext(1)]
		private static JsonPropertyInfo[] ICdnScoreFormulaPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ICdnScoreFormula);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ICdnScoreFormula)obj).Name);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreFormula)obj).Name = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Name";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ICdnScoreFormula).GetField("Name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<List<ICdnScoreStep>> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<List<ICdnScoreStep>>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ICdnScoreFormula);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ICdnScoreFormula)obj).Steps);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<ICdnScoreStep> value)
			{
				((ICdnScoreFormula)obj).Steps = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Steps";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ICdnScoreFormula).GetField("Steps", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<ICdnScoreStep>> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<List<ICdnScoreStep>>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ICdnScoreFormula);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ICdnScoreFormula)obj).Output);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreFormula)obj).Output = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "Output";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ICdnScoreFormula).GetField("Output", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ICdnScoreFormula);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ICdnScoreFormula)obj).Order);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreFormula)obj).Order = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "Order";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ICdnScoreFormula).GetField("Order", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(ICdnScoreFormula);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((ICdnScoreFormula)obj).Note);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreFormula)obj).Note = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "Note";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(ICdnScoreFormula).GetField("Note", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			return array;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00015900 File Offset: 0x00013B00
		public JsonTypeInfo<ICdnScoreStep> ICdnScoreStep
		{
			get
			{
				JsonTypeInfo<ICdnScoreStep> result;
				if ((result = this._ICdnScoreStep) == null)
				{
					result = (this._ICdnScoreStep = (JsonTypeInfo<ICdnScoreStep>)base.Options.GetTypeInfo(typeof(ICdnScoreStep)));
				}
				return result;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001593C File Offset: 0x00013B3C
		[NullableContext(1)]
		private JsonTypeInfo<ICdnScoreStep> Create_ICdnScoreStep(JsonSerializerOptions options)
		{
			JsonTypeInfo<ICdnScoreStep> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ICdnScoreStep>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ICdnScoreStep> jsonObjectInfoValues = new JsonObjectInfoValues<ICdnScoreStep>();
				jsonObjectInfoValues.ObjectCreator = (() => new ICdnScoreStep());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ICdnScoreStepPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ICdnScoreStep).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ICdnScoreStep> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ICdnScoreStep>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00015A04 File Offset: 0x00013C04
		[NullableContext(1)]
		private static JsonPropertyInfo[] ICdnScoreStepPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ICdnScoreStep);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ICdnScoreStep)obj).Let);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreStep)obj).Let = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Let";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ICdnScoreStep).GetField("Let", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ICdnScoreStep);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ICdnScoreStep)obj).Op);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreStep)obj).Op = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Op";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ICdnScoreStep).GetField("Op", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<JsonElement> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<JsonElement>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ICdnScoreStep);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ICdnScoreStep)obj).A);
			jsonPropertyInfoValues3.Setter = delegate(object obj, JsonElement value)
			{
				((ICdnScoreStep)obj).A = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "A";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ICdnScoreStep).GetField("A", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<JsonElement> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<JsonElement>(options, propertyInfo3);
			JsonPropertyInfoValues<JsonElement?> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<JsonElement?>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ICdnScoreStep);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ICdnScoreStep)obj).B);
			jsonPropertyInfoValues4.Setter = delegate(object obj, JsonElement? value)
			{
				((ICdnScoreStep)obj).B = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "B";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ICdnScoreStep).GetField("B", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<JsonElement?> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<JsonElement?>(options, propertyInfo4);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(ICdnScoreStep);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((ICdnScoreStep)obj).Note);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnScoreStep)obj).Note = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "Note";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(ICdnScoreStep).GetField("Note", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			return array;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00015ED4 File Offset: 0x000140D4
		public JsonTypeInfo<ICdnUrlData> ICdnUrlData
		{
			get
			{
				JsonTypeInfo<ICdnUrlData> result;
				if ((result = this._ICdnUrlData) == null)
				{
					result = (this._ICdnUrlData = (JsonTypeInfo<ICdnUrlData>)base.Options.GetTypeInfo(typeof(ICdnUrlData)));
				}
				return result;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00015F10 File Offset: 0x00014110
		[NullableContext(1)]
		private JsonTypeInfo<ICdnUrlData> Create_ICdnUrlData(JsonSerializerOptions options)
		{
			JsonTypeInfo<ICdnUrlData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ICdnUrlData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ICdnUrlData> jsonObjectInfoValues = new JsonObjectInfoValues<ICdnUrlData>();
				jsonObjectInfoValues.ObjectCreator = (() => new ICdnUrlData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ICdnUrlDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ICdnUrlData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ICdnUrlData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ICdnUrlData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00015FD8 File Offset: 0x000141D8
		[NullableContext(1)]
		private static JsonPropertyInfo[] ICdnUrlDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ICdnUrlData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ICdnUrlData)obj).url);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnUrlData)obj).url = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "url";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ICdnUrlData).GetField("url", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ICdnUrlData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ICdnUrlData)obj).weight);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICdnUrlData)obj).weight = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "weight";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ICdnUrlData).GetField("weight", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000161E4 File Offset: 0x000143E4
		public JsonTypeInfo<IEvalConfig> IEvalConfig
		{
			get
			{
				JsonTypeInfo<IEvalConfig> result;
				if ((result = this._IEvalConfig) == null)
				{
					result = (this._IEvalConfig = (JsonTypeInfo<IEvalConfig>)base.Options.GetTypeInfo(typeof(IEvalConfig)));
				}
				return result;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00016220 File Offset: 0x00014420
		[NullableContext(1)]
		private JsonTypeInfo<IEvalConfig> Create_IEvalConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<IEvalConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IEvalConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IEvalConfig> jsonObjectInfoValues = new JsonObjectInfoValues<IEvalConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new IEvalConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IEvalConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IEvalConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IEvalConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IEvalConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000162E8 File Offset: 0x000144E8
		[NullableContext(1)]
		private static JsonPropertyInfo[] IEvalConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<IEvalNetworkConfig> jsonPropertyInfoValues = new JsonPropertyInfoValues<IEvalNetworkConfig>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IEvalConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IEvalConfig)obj).Cellular);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] IEvalNetworkConfig value)
			{
				((IEvalConfig)obj).Cellular = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Cellular";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IEvalConfig).GetField("Cellular", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IEvalNetworkConfig> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<IEvalNetworkConfig>(options, propertyInfo);
			JsonPropertyInfoValues<IEvalNetworkConfig> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<IEvalNetworkConfig>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IEvalConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IEvalConfig)obj).Broadband);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] IEvalNetworkConfig value)
			{
				((IEvalConfig)obj).Broadband = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Broadband";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IEvalConfig).GetField("Broadband", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IEvalNetworkConfig> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<IEvalNetworkConfig>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000164D0 File Offset: 0x000146D0
		public JsonTypeInfo<IEvalNetworkConfig> IEvalNetworkConfig
		{
			get
			{
				JsonTypeInfo<IEvalNetworkConfig> result;
				if ((result = this._IEvalNetworkConfig) == null)
				{
					result = (this._IEvalNetworkConfig = (JsonTypeInfo<IEvalNetworkConfig>)base.Options.GetTypeInfo(typeof(IEvalNetworkConfig)));
				}
				return result;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001650C File Offset: 0x0001470C
		[NullableContext(1)]
		private JsonTypeInfo<IEvalNetworkConfig> Create_IEvalNetworkConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<IEvalNetworkConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IEvalNetworkConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IEvalNetworkConfig> jsonObjectInfoValues = new JsonObjectInfoValues<IEvalNetworkConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new IEvalNetworkConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IEvalNetworkConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IEvalNetworkConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IEvalNetworkConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IEvalNetworkConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000165D4 File Offset: 0x000147D4
		[NullableContext(1)]
		private static JsonPropertyInfo[] IEvalNetworkConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<bool?> jsonPropertyInfoValues = new JsonPropertyInfoValues<bool?>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IEvalNetworkConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IEvalNetworkConfig)obj).Shuffle);
			jsonPropertyInfoValues.Setter = delegate(object obj, bool? value)
			{
				((IEvalNetworkConfig)obj).Shuffle = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Shuffle";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IEvalNetworkConfig).GetField("Shuffle", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool?> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<bool?>(options, propertyInfo);
			JsonPropertyInfoValues<float?> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<float?>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IEvalNetworkConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IEvalNetworkConfig)obj).EvalTime);
			jsonPropertyInfoValues2.Setter = delegate(object obj, float? value)
			{
				((IEvalNetworkConfig)obj).EvalTime = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "EvalTime";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IEvalNetworkConfig).GetField("EvalTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<float?> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<float?>(options, propertyInfo2);
			JsonPropertyInfoValues<float?> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<float?>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IEvalNetworkConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IEvalNetworkConfig)obj).SkipSize);
			jsonPropertyInfoValues3.Setter = delegate(object obj, float? value)
			{
				((IEvalNetworkConfig)obj).SkipSize = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "SkipSize";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IEvalNetworkConfig).GetField("SkipSize", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<float?> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<float?>(options, propertyInfo3);
			return array;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000168A8 File Offset: 0x00014AA8
		public JsonTypeInfo<IGachaUrl> IGachaUrl
		{
			get
			{
				JsonTypeInfo<IGachaUrl> result;
				if ((result = this._IGachaUrl) == null)
				{
					result = (this._IGachaUrl = (JsonTypeInfo<IGachaUrl>)base.Options.GetTypeInfo(typeof(IGachaUrl)));
				}
				return result;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000168E4 File Offset: 0x00014AE4
		[NullableContext(1)]
		private JsonTypeInfo<IGachaUrl> Create_IGachaUrl(JsonSerializerOptions options)
		{
			JsonTypeInfo<IGachaUrl> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IGachaUrl>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IGachaUrl> jsonObjectInfoValues = new JsonObjectInfoValues<IGachaUrl>();
				jsonObjectInfoValues.ObjectCreator = (() => new IGachaUrl());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IGachaUrlPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IGachaUrl).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IGachaUrl> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IGachaUrl>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000169AC File Offset: 0x00014BAC
		[NullableContext(1)]
		private static JsonPropertyInfo[] IGachaUrlPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IGachaUrl);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IGachaUrl)obj).GachaRecord);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IGachaUrl)obj).GachaRecord = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "GachaRecord";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IGachaUrl).GetField("GachaRecord", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00016ABC File Offset: 0x00014CBC
		public JsonTypeInfo<IGrayBoxConfig> IGrayBoxConfig
		{
			get
			{
				JsonTypeInfo<IGrayBoxConfig> result;
				if ((result = this._IGrayBoxConfig) == null)
				{
					result = (this._IGrayBoxConfig = (JsonTypeInfo<IGrayBoxConfig>)base.Options.GetTypeInfo(typeof(IGrayBoxConfig)));
				}
				return result;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00016AF8 File Offset: 0x00014CF8
		[NullableContext(1)]
		private JsonTypeInfo<IGrayBoxConfig> Create_IGrayBoxConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<IGrayBoxConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IGrayBoxConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IGrayBoxConfig> jsonObjectInfoValues = new JsonObjectInfoValues<IGrayBoxConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new IGrayBoxConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IGrayBoxConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IGrayBoxConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IGrayBoxConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IGrayBoxConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[NullableContext(1)]
		private static JsonPropertyInfo[] IGrayBoxConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<List<IGrayBoxItemConfig>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<IGrayBoxItemConfig>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IGrayBoxConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IGrayBoxConfig)obj).Items);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<IGrayBoxItemConfig> value)
			{
				((IGrayBoxConfig)obj).Items = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Items";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IGrayBoxConfig).GetField("Items", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<IGrayBoxItemConfig>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<IGrayBoxItemConfig>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00016CD0 File Offset: 0x00014ED0
		public JsonTypeInfo<IGrayBoxItemConfig> IGrayBoxItemConfig
		{
			get
			{
				JsonTypeInfo<IGrayBoxItemConfig> result;
				if ((result = this._IGrayBoxItemConfig) == null)
				{
					result = (this._IGrayBoxItemConfig = (JsonTypeInfo<IGrayBoxItemConfig>)base.Options.GetTypeInfo(typeof(IGrayBoxItemConfig)));
				}
				return result;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00016D0C File Offset: 0x00014F0C
		[NullableContext(1)]
		private JsonTypeInfo<IGrayBoxItemConfig> Create_IGrayBoxItemConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<IGrayBoxItemConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IGrayBoxItemConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IGrayBoxItemConfig> jsonObjectInfoValues = new JsonObjectInfoValues<IGrayBoxItemConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new IGrayBoxItemConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IGrayBoxItemConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IGrayBoxItemConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IGrayBoxItemConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IGrayBoxItemConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00016DD4 File Offset: 0x00014FD4
		[NullableContext(1)]
		private static JsonPropertyInfo[] IGrayBoxItemConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IGrayBoxItemConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IGrayBoxItemConfig)obj).Name);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IGrayBoxItemConfig)obj).Name = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Name";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IGrayBoxItemConfig).GetField("Name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IGrayBoxItemConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IGrayBoxItemConfig)obj).Divisor);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int? value)
			{
				((IGrayBoxItemConfig)obj).Divisor = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues2.PropertyName = "Divisor";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IGrayBoxItemConfig).GetField("Divisor", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo2);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IGrayBoxItemConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IGrayBoxItemConfig)obj).Left);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int? value)
			{
				((IGrayBoxItemConfig)obj).Left = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues3.PropertyName = "Left";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IGrayBoxItemConfig).GetField("Left", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo3);
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IGrayBoxItemConfig);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IGrayBoxItemConfig)obj).Right);
			jsonPropertyInfoValues4.Setter = delegate(object obj, int? value)
			{
				((IGrayBoxItemConfig)obj).Right = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues4.PropertyName = "Right";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IGrayBoxItemConfig).GetField("Right", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo4);
			JsonPropertyInfoValues<List<int>> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<List<int>>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(IGrayBoxItemConfig);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((IGrayBoxItemConfig)obj).Ids);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] List<int> value)
			{
				((IGrayBoxItemConfig)obj).Ids = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues5.PropertyName = "Ids";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(IGrayBoxItemConfig).GetField("Ids", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<int>> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<List<int>>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00017294 File Offset: 0x00015494
		public JsonTypeInfo<ILoginServersData> ILoginServersData
		{
			get
			{
				JsonTypeInfo<ILoginServersData> result;
				if ((result = this._ILoginServersData) == null)
				{
					result = (this._ILoginServersData = (JsonTypeInfo<ILoginServersData>)base.Options.GetTypeInfo(typeof(ILoginServersData)));
				}
				return result;
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000172D0 File Offset: 0x000154D0
		[NullableContext(1)]
		private JsonTypeInfo<ILoginServersData> Create_ILoginServersData(JsonSerializerOptions options)
		{
			JsonTypeInfo<ILoginServersData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ILoginServersData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ILoginServersData> jsonObjectInfoValues = new JsonObjectInfoValues<ILoginServersData>();
				jsonObjectInfoValues.ObjectCreator = (() => new ILoginServersData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ILoginServersDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ILoginServersData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ILoginServersData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ILoginServersData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00017398 File Offset: 0x00015598
		[NullableContext(1)]
		private static JsonPropertyInfo[] ILoginServersDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[8];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ILoginServersData)obj).name);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginServersData)obj).name = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "name";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ILoginServersData)obj).ip);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginServersData)obj).ip = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "ip";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("ip", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ILoginServersData)obj).id);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginServersData)obj).id = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "id";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("id", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ILoginServersData)obj).Region);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginServersData)obj).Region = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "Region";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("Region", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((ILoginServersData)obj).PingUrl);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginServersData)obj).PingUrl = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "PingUrl";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("PingUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<ITDConfig> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<ITDConfig>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((ILoginServersData)obj).TDCfg);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] ITDConfig value)
			{
				((ILoginServersData)obj).TDCfg = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "TDCfg";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("TDCfg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ITDConfig> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<ITDConfig>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<ITDConfig> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<ITDConfig>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((ILoginServersData)obj).KDCfg);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] ITDConfig value)
			{
				((ILoginServersData)obj).KDCfg = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "KDCfg";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("KDCfg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ITDConfig> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<ITDConfig>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<List<string>> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<List<string>>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(ILoginServersData);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((ILoginServersData)obj).LoginUrl);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<string> value)
			{
				((ILoginServersData)obj).LoginUrl = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "LoginUrl";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(ILoginServersData).GetField("LoginUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<string>> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<List<string>>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00017B9C File Offset: 0x00015D9C
		public JsonTypeInfo<ILogReport> ILogReport
		{
			get
			{
				JsonTypeInfo<ILogReport> result;
				if ((result = this._ILogReport) == null)
				{
					result = (this._ILogReport = (JsonTypeInfo<ILogReport>)base.Options.GetTypeInfo(typeof(ILogReport)));
				}
				return result;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00017BD8 File Offset: 0x00015DD8
		[NullableContext(1)]
		private JsonTypeInfo<ILogReport> Create_ILogReport(JsonSerializerOptions options)
		{
			JsonTypeInfo<ILogReport> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ILogReport>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ILogReport> jsonObjectInfoValues = new JsonObjectInfoValues<ILogReport>();
				jsonObjectInfoValues.ObjectCreator = (() => new ILogReport());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ILogReportPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ILogReport).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ILogReport> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ILogReport>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00017CA0 File Offset: 0x00015EA0
		[NullableContext(1)]
		private static JsonPropertyInfo[] ILogReportPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ILogReport);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ILogReport)obj).name);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILogReport)obj).name = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "name";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ILogReport).GetField("name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ILogReport);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ILogReport)obj).region);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILogReport)obj).region = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "region";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ILogReport).GetField("region", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00017EAC File Offset: 0x000160AC
		public JsonTypeInfo<IPrivateServersData> IPrivateServersData
		{
			get
			{
				JsonTypeInfo<IPrivateServersData> result;
				if ((result = this._IPrivateServersData) == null)
				{
					result = (this._IPrivateServersData = (JsonTypeInfo<IPrivateServersData>)base.Options.GetTypeInfo(typeof(IPrivateServersData)));
				}
				return result;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00017EE8 File Offset: 0x000160E8
		[NullableContext(1)]
		private JsonTypeInfo<IPrivateServersData> Create_IPrivateServersData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IPrivateServersData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IPrivateServersData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IPrivateServersData> jsonObjectInfoValues = new JsonObjectInfoValues<IPrivateServersData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IPrivateServersData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IPrivateServersDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IPrivateServersData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IPrivateServersData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IPrivateServersData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00017FB0 File Offset: 0x000161B0
		[NullableContext(1)]
		private static JsonPropertyInfo[] IPrivateServersDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IPrivateServersData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IPrivateServersData)obj).enable);
			jsonPropertyInfoValues.Setter = delegate(object obj, bool value)
			{
				((IPrivateServersData)obj).enable = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "enable";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IPrivateServersData).GetField("enable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IPrivateServersData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IPrivateServersData)obj).serverUrl);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPrivateServersData)obj).serverUrl = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "serverUrl";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IPrivateServersData).GetField("serverUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000181A8 File Offset: 0x000163A8
		public JsonTypeInfo<ITDConfig> ITDConfig
		{
			get
			{
				JsonTypeInfo<ITDConfig> result;
				if ((result = this._ITDConfig) == null)
				{
					result = (this._ITDConfig = (JsonTypeInfo<ITDConfig>)base.Options.GetTypeInfo(typeof(ITDConfig)));
				}
				return result;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000181E4 File Offset: 0x000163E4
		[NullableContext(1)]
		private JsonTypeInfo<ITDConfig> Create_ITDConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<ITDConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ITDConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ITDConfig> jsonObjectInfoValues = new JsonObjectInfoValues<ITDConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new ITDConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ITDConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ITDConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ITDConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ITDConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000182AC File Offset: 0x000164AC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ITDConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ITDConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ITDConfig)obj).URL);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ITDConfig)obj).URL = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "URL";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ITDConfig).GetField("URL", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ITDConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ITDConfig)obj).AppID);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ITDConfig)obj).AppID = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "AppID";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ITDConfig).GetField("AppID", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000184B8 File Offset: 0x000166B8
		public JsonTypeInfo<IUdpProbe> IUdpProbe
		{
			get
			{
				JsonTypeInfo<IUdpProbe> result;
				if ((result = this._IUdpProbe) == null)
				{
					result = (this._IUdpProbe = (JsonTypeInfo<IUdpProbe>)base.Options.GetTypeInfo(typeof(IUdpProbe)));
				}
				return result;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000184F4 File Offset: 0x000166F4
		[NullableContext(1)]
		private JsonTypeInfo<IUdpProbe> Create_IUdpProbe(JsonSerializerOptions options)
		{
			JsonTypeInfo<IUdpProbe> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IUdpProbe>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IUdpProbe> jsonObjectInfoValues = new JsonObjectInfoValues<IUdpProbe>();
				jsonObjectInfoValues.ObjectCreator = (() => new IUdpProbe());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IUdpProbePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IUdpProbe).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IUdpProbe> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IUdpProbe>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000185BC File Offset: 0x000167BC
		[NullableContext(1)]
		private static JsonPropertyInfo[] IUdpProbePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IUdpProbe);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IUdpProbe)obj).ip);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IUdpProbe)obj).ip = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ip";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IUdpProbe).GetField("ip", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IUdpProbe);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IUdpProbe)obj).port);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IUdpProbe)obj).port = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "port";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IUdpProbe).GetField("port", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<Dictionary<string, string>> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<Dictionary<string, string>>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IUdpProbe);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IUdpProbe)obj).ext);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, string> value)
			{
				((IUdpProbe)obj).ext = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "ext";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IUdpProbe).GetField("ext", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, string>> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, string>>(options, propertyInfo3);
			return array;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000188A0 File Offset: 0x00016AA0
		public JsonTypeInfo<IUdpRegion> IUdpRegion
		{
			get
			{
				JsonTypeInfo<IUdpRegion> result;
				if ((result = this._IUdpRegion) == null)
				{
					result = (this._IUdpRegion = (JsonTypeInfo<IUdpRegion>)base.Options.GetTypeInfo(typeof(IUdpRegion)));
				}
				return result;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000188DC File Offset: 0x00016ADC
		[NullableContext(1)]
		private JsonTypeInfo<IUdpRegion> Create_IUdpRegion(JsonSerializerOptions options)
		{
			JsonTypeInfo<IUdpRegion> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IUdpRegion>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IUdpRegion> jsonObjectInfoValues = new JsonObjectInfoValues<IUdpRegion>();
				jsonObjectInfoValues.ObjectCreator = (() => new IUdpRegion());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IUdpRegionPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IUdpRegion).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IUdpRegion> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IUdpRegion>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000189A4 File Offset: 0x00016BA4
		[NullableContext(1)]
		private static JsonPropertyInfo[] IUdpRegionPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<List<IUdpProbe>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<IUdpProbe>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IUdpRegion);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IUdpRegion)obj).Probe);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<IUdpProbe> value)
			{
				((IUdpRegion)obj).Probe = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Probe";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IUdpRegion).GetField("Probe", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<IUdpProbe>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<IUdpProbe>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IUdpRegion);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IUdpRegion)obj).ProbeInterval);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IUdpRegion)obj).ProbeInterval = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "ProbeInterval";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IUdpRegion).GetField("ProbeInterval", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IUdpRegion);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IUdpRegion)obj).ProbeOpen);
			jsonPropertyInfoValues3.Setter = delegate(object obj, bool value)
			{
				((IUdpRegion)obj).ProbeOpen = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "ProbeOpen";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IUdpRegion).GetField("ProbeOpen", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo3);
			return array;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00018C88 File Offset: 0x00016E88
		public JsonTypeInfo<IUpdateUrl> IUpdateUrl
		{
			get
			{
				JsonTypeInfo<IUpdateUrl> result;
				if ((result = this._IUpdateUrl) == null)
				{
					result = (this._IUpdateUrl = (JsonTypeInfo<IUpdateUrl>)base.Options.GetTypeInfo(typeof(IUpdateUrl)));
				}
				return result;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00018CC4 File Offset: 0x00016EC4
		[NullableContext(1)]
		private JsonTypeInfo<IUpdateUrl> Create_IUpdateUrl(JsonSerializerOptions options)
		{
			JsonTypeInfo<IUpdateUrl> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IUpdateUrl>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IUpdateUrl> jsonObjectInfoValues = new JsonObjectInfoValues<IUpdateUrl>();
				jsonObjectInfoValues.ObjectCreator = (() => new IUpdateUrl());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IUpdateUrlPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IUpdateUrl).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IUpdateUrl> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IUpdateUrl>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00018D8C File Offset: 0x00016F8C
		[NullableContext(1)]
		private static JsonPropertyInfo[] IUpdateUrlPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IUpdateUrl);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IUpdateUrl)obj).MainUrl);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IUpdateUrl)obj).MainUrl = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "MainUrl";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IUpdateUrl).GetField("MainUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IUpdateUrl);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IUpdateUrl)obj).SubUrl);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IUpdateUrl)obj).SubUrl = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "SubUrl";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IUpdateUrl).GetField("SubUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00018F98 File Offset: 0x00017198
		public JsonTypeInfo<PatchManifest> PatchManifest
		{
			get
			{
				JsonTypeInfo<PatchManifest> result;
				if ((result = this._PatchManifest) == null)
				{
					result = (this._PatchManifest = (JsonTypeInfo<PatchManifest>)base.Options.GetTypeInfo(typeof(PatchManifest)));
				}
				return result;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00018FD4 File Offset: 0x000171D4
		[NullableContext(1)]
		private JsonTypeInfo<PatchManifest> Create_PatchManifest(JsonSerializerOptions options)
		{
			JsonTypeInfo<PatchManifest> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<PatchManifest>(options, out jsonTypeInfo))
			{
				JsonConverter converter = LauncherJsonSourceGenContext.ExpandConverter(typeof(PatchManifest), new PatchManifestConverter(), options, true);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<PatchManifest>(options, converter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00019014 File Offset: 0x00017214
		public JsonTypeInfo<PatchManifestJson> PatchManifestJson
		{
			get
			{
				JsonTypeInfo<PatchManifestJson> result;
				if ((result = this._PatchManifestJson) == null)
				{
					result = (this._PatchManifestJson = (JsonTypeInfo<PatchManifestJson>)base.Options.GetTypeInfo(typeof(PatchManifestJson)));
				}
				return result;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00019050 File Offset: 0x00017250
		[NullableContext(1)]
		private JsonTypeInfo<PatchManifestJson> Create_PatchManifestJson(JsonSerializerOptions options)
		{
			JsonTypeInfo<PatchManifestJson> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<PatchManifestJson>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<PatchManifestJson> jsonObjectInfoValues = new JsonObjectInfoValues<PatchManifestJson>();
				jsonObjectInfoValues.ObjectCreator = (() => new PatchManifestJson());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.PatchManifestJsonPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(PatchManifestJson).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<PatchManifestJson> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<PatchManifestJson>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00019118 File Offset: 0x00017318
		[NullableContext(1)]
		private static JsonPropertyInfo[] PatchManifestJsonPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<PatchManifest> jsonPropertyInfoValues = new JsonPropertyInfoValues<PatchManifest>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(PatchManifestJson);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((PatchManifestJson)obj).DiffPatch);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] PatchManifest value)
			{
				((PatchManifestJson)obj).DiffPatch = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "DiffPatch";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(PatchManifestJson).GetField("DiffPatch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<PatchManifest> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<PatchManifest>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00019228 File Offset: 0x00017428
		public JsonTypeInfo<RemotePakMapConfig> RemotePakMapConfig
		{
			get
			{
				JsonTypeInfo<RemotePakMapConfig> result;
				if ((result = this._RemotePakMapConfig) == null)
				{
					result = (this._RemotePakMapConfig = (JsonTypeInfo<RemotePakMapConfig>)base.Options.GetTypeInfo(typeof(RemotePakMapConfig)));
				}
				return result;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00019264 File Offset: 0x00017464
		[NullableContext(1)]
		private JsonTypeInfo<RemotePakMapConfig> Create_RemotePakMapConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<RemotePakMapConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RemotePakMapConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RemotePakMapConfig> jsonObjectInfoValues = new JsonObjectInfoValues<RemotePakMapConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new RemotePakMapConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.RemotePakMapConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RemotePakMapConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RemotePakMapConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RemotePakMapConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0001932C File Offset: 0x0001752C
		[NullableContext(1)]
		private static JsonPropertyInfo[] RemotePakMapConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<Dictionary<string, VideoItem>> jsonPropertyInfoValues = new JsonPropertyInfoValues<Dictionary<string, VideoItem>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RemotePakMapConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RemotePakMapConfig)obj).PakMap);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, VideoItem> value)
			{
				((RemotePakMapConfig)obj).PakMap = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PakMap";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RemotePakMapConfig).GetField("PakMap", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, VideoItem>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, VideoItem>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0001943C File Offset: 0x0001763C
		public JsonTypeInfo<RemoteVideoConfig> RemoteVideoConfig
		{
			get
			{
				JsonTypeInfo<RemoteVideoConfig> result;
				if ((result = this._RemoteVideoConfig) == null)
				{
					result = (this._RemoteVideoConfig = (JsonTypeInfo<RemoteVideoConfig>)base.Options.GetTypeInfo(typeof(RemoteVideoConfig)));
				}
				return result;
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00019478 File Offset: 0x00017678
		[NullableContext(1)]
		private JsonTypeInfo<RemoteVideoConfig> Create_RemoteVideoConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<RemoteVideoConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RemoteVideoConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RemoteVideoConfig> jsonObjectInfoValues = new JsonObjectInfoValues<RemoteVideoConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new RemoteVideoConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.RemoteVideoConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RemoteVideoConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RemoteVideoConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RemoteVideoConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00019540 File Offset: 0x00017740
		[NullableContext(1)]
		private static JsonPropertyInfo[] RemoteVideoConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<RemotePakMapConfig> jsonPropertyInfoValues = new JsonPropertyInfoValues<RemotePakMapConfig>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RemoteVideoConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RemoteVideoConfig)obj).VideoInfos);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] RemotePakMapConfig value)
			{
				((RemoteVideoConfig)obj).VideoInfos = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "VideoInfos";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RemoteVideoConfig).GetField("VideoInfos", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<RemotePakMapConfig> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<RemotePakMapConfig>(options, propertyInfo);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(RemoteVideoConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((RemoteVideoConfig)obj).UpdateTime);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((RemoteVideoConfig)obj).UpdateTime = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "UpdateTime";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(RemoteVideoConfig).GetField("UpdateTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00019728 File Offset: 0x00017928
		public JsonTypeInfo<RemoteVideoConfigUpdateTime> RemoteVideoConfigUpdateTime
		{
			get
			{
				JsonTypeInfo<RemoteVideoConfigUpdateTime> result;
				if ((result = this._RemoteVideoConfigUpdateTime) == null)
				{
					result = (this._RemoteVideoConfigUpdateTime = (JsonTypeInfo<RemoteVideoConfigUpdateTime>)base.Options.GetTypeInfo(typeof(RemoteVideoConfigUpdateTime)));
				}
				return result;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00019764 File Offset: 0x00017964
		[NullableContext(1)]
		private JsonTypeInfo<RemoteVideoConfigUpdateTime> Create_RemoteVideoConfigUpdateTime(JsonSerializerOptions options)
		{
			JsonTypeInfo<RemoteVideoConfigUpdateTime> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RemoteVideoConfigUpdateTime>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RemoteVideoConfigUpdateTime> jsonObjectInfoValues = new JsonObjectInfoValues<RemoteVideoConfigUpdateTime>();
				jsonObjectInfoValues.ObjectCreator = (() => new RemoteVideoConfigUpdateTime());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.RemoteVideoConfigUpdateTimePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RemoteVideoConfigUpdateTime).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RemoteVideoConfigUpdateTime> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RemoteVideoConfigUpdateTime>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0001982C File Offset: 0x00017A2C
		[NullableContext(1)]
		private static JsonPropertyInfo[] RemoteVideoConfigUpdateTimePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RemoteVideoConfigUpdateTime);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RemoteVideoConfigUpdateTime)obj).UpdateTime);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((RemoteVideoConfigUpdateTime)obj).UpdateTime = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "UpdateTime";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RemoteVideoConfigUpdateTime).GetField("UpdateTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(RemoteVideoConfigUpdateTime);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((RemoteVideoConfigUpdateTime)obj).IndexSha1);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteVideoConfigUpdateTime)obj).IndexSha1 = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "IndexSha1";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(RemoteVideoConfigUpdateTime).GetField("IndexSha1", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00019A24 File Offset: 0x00017C24
		public JsonTypeInfo<VideoItem> VideoItem
		{
			get
			{
				JsonTypeInfo<VideoItem> result;
				if ((result = this._VideoItem) == null)
				{
					result = (this._VideoItem = (JsonTypeInfo<VideoItem>)base.Options.GetTypeInfo(typeof(VideoItem)));
				}
				return result;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00019A60 File Offset: 0x00017C60
		[NullableContext(1)]
		private JsonTypeInfo<VideoItem> Create_VideoItem(JsonSerializerOptions options)
		{
			JsonTypeInfo<VideoItem> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<VideoItem>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<VideoItem> jsonObjectInfoValues = new JsonObjectInfoValues<VideoItem>();
				jsonObjectInfoValues.ObjectCreator = (() => new VideoItem());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.VideoItemPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(VideoItem).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<VideoItem> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<VideoItem>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00019B28 File Offset: 0x00017D28
		[NullableContext(1)]
		private static JsonPropertyInfo[] VideoItemPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[6];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(VideoItem);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((VideoItem)obj).PakName);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((VideoItem)obj).PakName = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PakName";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(VideoItem).GetField("PakName", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(VideoItem);
			jsonPropertyInfoValues2.Converter = (JsonConverter<long>)LauncherJsonSourceGenContext.ExpandConverter(typeof(long), new TsBigIntJsonConverter(), options, true);
			jsonPropertyInfoValues2.Getter = ((object obj) => ((VideoItem)obj).PakSize);
			jsonPropertyInfoValues2.Setter = delegate(object obj, long value)
			{
				((VideoItem)obj).PakSize = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "PakSize";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(VideoItem).GetField("PakSize", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(VideoItem);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((VideoItem)obj).PakHash);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((VideoItem)obj).PakHash = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "PakHash";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(VideoItem).GetField("PakHash", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(VideoItem);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((VideoItem)obj).SigName);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((VideoItem)obj).SigName = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "SigName";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(VideoItem).GetField("SigName", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(VideoItem);
			jsonPropertyInfoValues5.Converter = (JsonConverter<long>)LauncherJsonSourceGenContext.ExpandConverter(typeof(long), new TsBigIntJsonConverter(), options, true);
			jsonPropertyInfoValues5.Getter = ((object obj) => ((VideoItem)obj).SigSize);
			jsonPropertyInfoValues5.Setter = delegate(object obj, long value)
			{
				((VideoItem)obj).SigSize = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "SigSize";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(VideoItem).GetField("SigSize", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo5);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(VideoItem);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((VideoItem)obj).SigHash);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((VideoItem)obj).SigHash = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "SigHash";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(VideoItem).GetField("SigHash", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0001A140 File Offset: 0x00018340
		public JsonTypeInfo<GameWindowStateData> GameWindowStateData
		{
			get
			{
				JsonTypeInfo<GameWindowStateData> result;
				if ((result = this._GameWindowStateData) == null)
				{
					result = (this._GameWindowStateData = (JsonTypeInfo<GameWindowStateData>)base.Options.GetTypeInfo(typeof(GameWindowStateData)));
				}
				return result;
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0001A17C File Offset: 0x0001837C
		[NullableContext(1)]
		private JsonTypeInfo<GameWindowStateData> Create_GameWindowStateData(JsonSerializerOptions options)
		{
			JsonTypeInfo<GameWindowStateData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<GameWindowStateData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<GameWindowStateData> jsonObjectInfoValues = new JsonObjectInfoValues<GameWindowStateData>();
				jsonObjectInfoValues.ObjectCreator = (() => new GameWindowStateData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.GameWindowStateDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(GameWindowStateData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<GameWindowStateData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<GameWindowStateData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001A244 File Offset: 0x00018444
		[NullableContext(1)]
		private static JsonPropertyInfo[] GameWindowStateDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(GameWindowStateData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((GameWindowStateData)obj).status);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((GameWindowStateData)obj).status = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "status";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(GameWindowStateData).GetField("status", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			return array;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0001A340 File Offset: 0x00018540
		public JsonTypeInfo<UserInfo> UserInfo
		{
			get
			{
				JsonTypeInfo<UserInfo> result;
				if ((result = this._UserInfo) == null)
				{
					result = (this._UserInfo = (JsonTypeInfo<UserInfo>)base.Options.GetTypeInfo(typeof(UserInfo)));
				}
				return result;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001A37C File Offset: 0x0001857C
		[NullableContext(1)]
		private JsonTypeInfo<UserInfo> Create_UserInfo(JsonSerializerOptions options)
		{
			JsonTypeInfo<UserInfo> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<UserInfo>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<UserInfo> jsonObjectInfoValues = new JsonObjectInfoValues<UserInfo>();
				jsonObjectInfoValues.ObjectCreator = (() => new UserInfo());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.UserInfoPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(UserInfo).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<UserInfo> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<UserInfo>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001A444 File Offset: 0x00018644
		[NullableContext(1)]
		private static JsonPropertyInfo[] UserInfoPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(UserInfo);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((UserInfo)obj).channelId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((UserInfo)obj).channelId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "channelId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(UserInfo).GetField("channelId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			return array;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0001A540 File Offset: 0x00018740
		public JsonTypeInfo<ILocalSendedSave> ILocalSendedSave
		{
			get
			{
				JsonTypeInfo<ILocalSendedSave> result;
				if ((result = this._ILocalSendedSave) == null)
				{
					result = (this._ILocalSendedSave = (JsonTypeInfo<ILocalSendedSave>)base.Options.GetTypeInfo(typeof(ILocalSendedSave)));
				}
				return result;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001A57C File Offset: 0x0001877C
		[NullableContext(1)]
		private JsonTypeInfo<ILocalSendedSave> Create_ILocalSendedSave(JsonSerializerOptions options)
		{
			JsonTypeInfo<ILocalSendedSave> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ILocalSendedSave>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ILocalSendedSave> jsonObjectInfoValues = new JsonObjectInfoValues<ILocalSendedSave>();
				jsonObjectInfoValues.ObjectCreator = (() => new ILocalSendedSave());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ILocalSendedSavePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ILocalSendedSave).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ILocalSendedSave> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ILocalSendedSave>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001A644 File Offset: 0x00018844
		[NullableContext(1)]
		private static JsonPropertyInfo[] ILocalSendedSavePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<List<string>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<string>>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ILocalSendedSave);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ILocalSendedSave)obj).Paths);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<string> value)
			{
				((ILocalSendedSave)obj).Paths = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Paths";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ILocalSendedSave).GetProperty("Paths", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(List<string>), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<List<string>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<string>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001A754 File Offset: 0x00018954
		public JsonTypeInfo<INetworkDetectionConfig> INetworkDetectionConfig
		{
			get
			{
				JsonTypeInfo<INetworkDetectionConfig> result;
				if ((result = this._INetworkDetectionConfig) == null)
				{
					result = (this._INetworkDetectionConfig = (JsonTypeInfo<INetworkDetectionConfig>)base.Options.GetTypeInfo(typeof(INetworkDetectionConfig)));
				}
				return result;
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0001A790 File Offset: 0x00018990
		[NullableContext(1)]
		private JsonTypeInfo<INetworkDetectionConfig> Create_INetworkDetectionConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<INetworkDetectionConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<INetworkDetectionConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<INetworkDetectionConfig> jsonObjectInfoValues = new JsonObjectInfoValues<INetworkDetectionConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new INetworkDetectionConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.INetworkDetectionConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(INetworkDetectionConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<INetworkDetectionConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<INetworkDetectionConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0001A858 File Offset: 0x00018A58
		[NullableContext(1)]
		private static JsonPropertyInfo[] INetworkDetectionConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(INetworkDetectionConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((INetworkDetectionConfig)obj).ip);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((INetworkDetectionConfig)obj).ip = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ip";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(INetworkDetectionConfig).GetProperty("ip", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(INetworkDetectionConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((INetworkDetectionConfig)obj).PingUrl);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((INetworkDetectionConfig)obj).PingUrl = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "PingUrl";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(INetworkDetectionConfig).GetProperty("PingUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			JsonPropertyInfoValues<int[]> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int[]>();
			jsonPropertyInfoValues3.IsProperty = true;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(INetworkDetectionConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((INetworkDetectionConfig)obj).UdpPort);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] int[] value)
			{
				((INetworkDetectionConfig)obj).UdpPort = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "UdpPort";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(INetworkDetectionConfig).GetProperty("UdpPort", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(int[]), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<int[]> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int[]>(options, propertyInfo3);
			JsonPropertyInfoValues<string[]> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string[]>();
			jsonPropertyInfoValues4.IsProperty = true;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(INetworkDetectionConfig);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((INetworkDetectionConfig)obj).LoginUrl);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] string[] value)
			{
				((INetworkDetectionConfig)obj).LoginUrl = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "LoginUrl";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(INetworkDetectionConfig).GetProperty("LoginUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string[]), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string[]> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string[]>(options, propertyInfo4);
			return array;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0001AC18 File Offset: 0x00018E18
		public JsonTypeInfo<BilibiliParam> BilibiliParam
		{
			get
			{
				JsonTypeInfo<BilibiliParam> result;
				if ((result = this._BilibiliParam) == null)
				{
					result = (this._BilibiliParam = (JsonTypeInfo<BilibiliParam>)base.Options.GetTypeInfo(typeof(BilibiliParam)));
				}
				return result;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001AC54 File Offset: 0x00018E54
		[NullableContext(1)]
		private JsonTypeInfo<BilibiliParam> Create_BilibiliParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<BilibiliParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<BilibiliParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<BilibiliParam> jsonObjectInfoValues = new JsonObjectInfoValues<BilibiliParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new BilibiliParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.BilibiliParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(BilibiliParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<BilibiliParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<BilibiliParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0001AD1C File Offset: 0x00018F1C
		[NullableContext(1)]
		private static JsonPropertyInfo[] BilibiliParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(BilibiliParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((BilibiliParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((BilibiliParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(BilibiliParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(BilibiliParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((BilibiliParam)obj).appKey);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((BilibiliParam)obj).appKey = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appKey";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(BilibiliParam).GetProperty("appKey", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001AF28 File Offset: 0x00019128
		public JsonTypeInfo<ClientSwitch> ClientSwitch
		{
			get
			{
				JsonTypeInfo<ClientSwitch> result;
				if ((result = this._ClientSwitch) == null)
				{
					result = (this._ClientSwitch = (JsonTypeInfo<ClientSwitch>)base.Options.GetTypeInfo(typeof(ClientSwitch)));
				}
				return result;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001AF64 File Offset: 0x00019164
		[NullableContext(1)]
		private JsonTypeInfo<ClientSwitch> Create_ClientSwitch(JsonSerializerOptions options)
		{
			JsonTypeInfo<ClientSwitch> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ClientSwitch>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ClientSwitch> jsonObjectInfoValues = new JsonObjectInfoValues<ClientSwitch>();
				jsonObjectInfoValues.ObjectCreator = (() => new ClientSwitch());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ClientSwitchPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ClientSwitch).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ClientSwitch> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ClientSwitch>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001B02C File Offset: 0x0001922C
		[NullableContext(1)]
		private static JsonPropertyInfo[] ClientSwitchPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ClientSwitch);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ClientSwitch)obj).td);
			jsonPropertyInfoValues.Setter = delegate(object obj, bool value)
			{
				((ClientSwitch)obj).td = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "td";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ClientSwitch).GetField("td", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ClientSwitch);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ClientSwitch)obj).didGt);
			jsonPropertyInfoValues2.Setter = delegate(object obj, bool value)
			{
				((ClientSwitch)obj).didGt = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "didGt";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ClientSwitch).GetField("didGt", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo2);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ClientSwitch);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ClientSwitch)obj).kefu);
			jsonPropertyInfoValues3.Setter = delegate(object obj, bool value)
			{
				((ClientSwitch)obj).kefu = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "kefu";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ClientSwitch).GetField("kefu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo3);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ClientSwitch);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ClientSwitch)obj).sobot);
			jsonPropertyInfoValues4.Setter = delegate(object obj, bool value)
			{
				((ClientSwitch)obj).sobot = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "sobot";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ClientSwitch).GetField("sobot", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo4);
			return array;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0001B3EC File Offset: 0x000195EC
		public JsonTypeInfo<ClientUrl> ClientUrl
		{
			get
			{
				JsonTypeInfo<ClientUrl> result;
				if ((result = this._ClientUrl) == null)
				{
					result = (this._ClientUrl = (JsonTypeInfo<ClientUrl>)base.Options.GetTypeInfo(typeof(ClientUrl)));
				}
				return result;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001B428 File Offset: 0x00019628
		[NullableContext(1)]
		private JsonTypeInfo<ClientUrl> Create_ClientUrl(JsonSerializerOptions options)
		{
			JsonTypeInfo<ClientUrl> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ClientUrl>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ClientUrl> jsonObjectInfoValues = new JsonObjectInfoValues<ClientUrl>();
				jsonObjectInfoValues.ObjectCreator = (() => new ClientUrl());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ClientUrlPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ClientUrl).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ClientUrl> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ClientUrl>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001B4F0 File Offset: 0x000196F0
		[NullableContext(1)]
		private static JsonPropertyInfo[] ClientUrlPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ClientUrl);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ClientUrl)obj).accCenterUrl);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ClientUrl)obj).accCenterUrl = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "accCenterUrl";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ClientUrl).GetField("accCenterUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0001B600 File Offset: 0x00019800
		public JsonTypeInfo<CsLinkEntry> CsLinkEntry
		{
			get
			{
				JsonTypeInfo<CsLinkEntry> result;
				if ((result = this._CsLinkEntry) == null)
				{
					result = (this._CsLinkEntry = (JsonTypeInfo<CsLinkEntry>)base.Options.GetTypeInfo(typeof(CsLinkEntry)));
				}
				return result;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001B63C File Offset: 0x0001983C
		[NullableContext(1)]
		private JsonTypeInfo<CsLinkEntry> Create_CsLinkEntry(JsonSerializerOptions options)
		{
			JsonTypeInfo<CsLinkEntry> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<CsLinkEntry>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<CsLinkEntry> jsonObjectInfoValues = new JsonObjectInfoValues<CsLinkEntry>();
				jsonObjectInfoValues.ObjectCreator = (() => new CsLinkEntry());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.CsLinkEntryPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(CsLinkEntry).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<CsLinkEntry> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<CsLinkEntry>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001B704 File Offset: 0x00019904
		[NullableContext(1)]
		private static JsonPropertyInfo[] CsLinkEntryPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(CsLinkEntry);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((CsLinkEntry)obj).link);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((CsLinkEntry)obj).link = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "link";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(CsLinkEntry).GetField("link", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0001B814 File Offset: 0x00019A14
		public JsonTypeInfo<DouyinParam> DouyinParam
		{
			get
			{
				JsonTypeInfo<DouyinParam> result;
				if ((result = this._DouyinParam) == null)
				{
					result = (this._DouyinParam = (JsonTypeInfo<DouyinParam>)base.Options.GetTypeInfo(typeof(DouyinParam)));
				}
				return result;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001B850 File Offset: 0x00019A50
		[NullableContext(1)]
		private JsonTypeInfo<DouyinParam> Create_DouyinParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<DouyinParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<DouyinParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<DouyinParam> jsonObjectInfoValues = new JsonObjectInfoValues<DouyinParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new DouyinParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.DouyinParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(DouyinParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<DouyinParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<DouyinParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001B918 File Offset: 0x00019B18
		[NullableContext(1)]
		private static JsonPropertyInfo[] DouyinParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(DouyinParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((DouyinParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((DouyinParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(DouyinParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(DouyinParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((DouyinParam)obj).appKey);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((DouyinParam)obj).appKey = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appKey";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(DouyinParam).GetProperty("appKey", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0001BB24 File Offset: 0x00019D24
		public JsonTypeInfo<IBlockData> IBlockData
		{
			get
			{
				JsonTypeInfo<IBlockData> result;
				if ((result = this._IBlockData) == null)
				{
					result = (this._IBlockData = (JsonTypeInfo<IBlockData>)base.Options.GetTypeInfo(typeof(IBlockData)));
				}
				return result;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001BB60 File Offset: 0x00019D60
		[NullableContext(1)]
		private JsonTypeInfo<IBlockData> Create_IBlockData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IBlockData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IBlockData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IBlockData> jsonObjectInfoValues = new JsonObjectInfoValues<IBlockData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IBlockData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IBlockDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IBlockData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IBlockData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IBlockData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001BC28 File Offset: 0x00019E28
		[NullableContext(1)]
		private static JsonPropertyInfo[] IBlockDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<List<IBlockDataContent>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<IBlockDataContent>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IBlockData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IBlockData)obj).blockList);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<IBlockDataContent> value)
			{
				((IBlockData)obj).blockList = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "blockList";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IBlockData).GetField("blockList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<IBlockDataContent>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<IBlockDataContent>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0001BD38 File Offset: 0x00019F38
		public JsonTypeInfo<IBlockDataContent> IBlockDataContent
		{
			get
			{
				JsonTypeInfo<IBlockDataContent> result;
				if ((result = this._IBlockDataContent) == null)
				{
					result = (this._IBlockDataContent = (JsonTypeInfo<IBlockDataContent>)base.Options.GetTypeInfo(typeof(IBlockDataContent)));
				}
				return result;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001BD74 File Offset: 0x00019F74
		[NullableContext(1)]
		private JsonTypeInfo<IBlockDataContent> Create_IBlockDataContent(JsonSerializerOptions options)
		{
			JsonTypeInfo<IBlockDataContent> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IBlockDataContent>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IBlockDataContent> jsonObjectInfoValues = new JsonObjectInfoValues<IBlockDataContent>();
				jsonObjectInfoValues.ObjectCreator = (() => new IBlockDataContent());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IBlockDataContentPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IBlockDataContent).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IBlockDataContent> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IBlockDataContent>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001BE3C File Offset: 0x0001A03C
		[NullableContext(1)]
		private static JsonPropertyInfo[] IBlockDataContentPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IBlockDataContent);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IBlockDataContent)obj).accountId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IBlockDataContent)obj).accountId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "accountId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IBlockDataContent).GetField("accountId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IBlockDataContent);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IBlockDataContent)obj).isBlocking);
			jsonPropertyInfoValues2.Setter = delegate(object obj, bool value)
			{
				((IBlockDataContent)obj).isBlocking = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "isBlocking";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IBlockDataContent).GetField("isBlocking", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo2);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IBlockDataContent);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IBlockDataContent)obj).isBlocked);
			jsonPropertyInfoValues3.Setter = delegate(object obj, bool value)
			{
				((IBlockDataContent)obj).isBlocked = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "isBlocked";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IBlockDataContent).GetField("isBlocked", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo3);
			return array;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001C120 File Offset: 0x0001A320
		public JsonTypeInfo<IBlockResponseData> IBlockResponseData
		{
			get
			{
				JsonTypeInfo<IBlockResponseData> result;
				if ((result = this._IBlockResponseData) == null)
				{
					result = (this._IBlockResponseData = (JsonTypeInfo<IBlockResponseData>)base.Options.GetTypeInfo(typeof(IBlockResponseData)));
				}
				return result;
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001C15C File Offset: 0x0001A35C
		[NullableContext(1)]
		private JsonTypeInfo<IBlockResponseData> Create_IBlockResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IBlockResponseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IBlockResponseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IBlockResponseData> jsonObjectInfoValues = new JsonObjectInfoValues<IBlockResponseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IBlockResponseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IBlockResponseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IBlockResponseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IBlockResponseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IBlockResponseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001C224 File Offset: 0x0001A424
		[NullableContext(1)]
		private static JsonPropertyInfo[] IBlockResponseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<IBlockData> jsonPropertyInfoValues = new JsonPropertyInfoValues<IBlockData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IBlockResponseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IBlockResponseData)obj).data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] IBlockData value)
			{
				((IBlockResponseData)obj).data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IBlockResponseData).GetField("data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IBlockData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<IBlockData>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0001C334 File Offset: 0x0001A534
		public JsonTypeInfo<ICheckoutProductResponse> ICheckoutProductResponse
		{
			get
			{
				JsonTypeInfo<ICheckoutProductResponse> result;
				if ((result = this._ICheckoutProductResponse) == null)
				{
					result = (this._ICheckoutProductResponse = (JsonTypeInfo<ICheckoutProductResponse>)base.Options.GetTypeInfo(typeof(ICheckoutProductResponse)));
				}
				return result;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001C370 File Offset: 0x0001A570
		[NullableContext(1)]
		private JsonTypeInfo<ICheckoutProductResponse> Create_ICheckoutProductResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<ICheckoutProductResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ICheckoutProductResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ICheckoutProductResponse> jsonObjectInfoValues = new JsonObjectInfoValues<ICheckoutProductResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new ICheckoutProductResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ICheckoutProductResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ICheckoutProductResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ICheckoutProductResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ICheckoutProductResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001C438 File Offset: 0x0001A638
		[NullableContext(1)]
		private static JsonPropertyInfo[] ICheckoutProductResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ICheckoutProductResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ICheckoutProductResponse)obj).code);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((ICheckoutProductResponse)obj).code = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "code";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ICheckoutProductResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ICheckoutProductResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ICheckoutProductResponse)obj).msg);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ICheckoutProductResponse)obj).msg = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "msg";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ICheckoutProductResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ICheckoutProductResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ICheckoutProductResponse)obj).timestamp);
			jsonPropertyInfoValues3.Setter = delegate(object obj, long value)
			{
				((ICheckoutProductResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "timestamp";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ICheckoutProductResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo3);
			return array;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0001C71C File Offset: 0x0001A91C
		public JsonTypeInfo<IConfigJson> IConfigJson
		{
			get
			{
				JsonTypeInfo<IConfigJson> result;
				if ((result = this._IConfigJson) == null)
				{
					result = (this._IConfigJson = (JsonTypeInfo<IConfigJson>)base.Options.GetTypeInfo(typeof(IConfigJson)));
				}
				return result;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001C758 File Offset: 0x0001A958
		[NullableContext(1)]
		private JsonTypeInfo<IConfigJson> Create_IConfigJson(JsonSerializerOptions options)
		{
			JsonTypeInfo<IConfigJson> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IConfigJson>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IConfigJson> jsonObjectInfoValues = new JsonObjectInfoValues<IConfigJson>();
				jsonObjectInfoValues.ObjectCreator = (() => new IConfigJson());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IConfigJsonPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IConfigJson).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IConfigJson> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IConfigJson>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001C820 File Offset: 0x0001AA20
		[NullableContext(1)]
		private static JsonPropertyInfo[] IConfigJsonPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<IPlatformData> jsonPropertyInfoValues = new JsonPropertyInfoValues<IPlatformData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IConfigJson);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IConfigJson)obj).PS5);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] IPlatformData value)
			{
				((IConfigJson)obj).PS5 = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PS5";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IConfigJson).GetField("PS5", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IPlatformData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<IPlatformData>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0001C930 File Offset: 0x0001AB30
		public JsonTypeInfo<IConnectResponse> IConnectResponse
		{
			get
			{
				JsonTypeInfo<IConnectResponse> result;
				if ((result = this._IConnectResponse) == null)
				{
					result = (this._IConnectResponse = (JsonTypeInfo<IConnectResponse>)base.Options.GetTypeInfo(typeof(IConnectResponse)));
				}
				return result;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001C96C File Offset: 0x0001AB6C
		[NullableContext(1)]
		private JsonTypeInfo<IConnectResponse> Create_IConnectResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<IConnectResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IConnectResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IConnectResponse> jsonObjectInfoValues = new JsonObjectInfoValues<IConnectResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new IConnectResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IConnectResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IConnectResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IConnectResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IConnectResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001CA34 File Offset: 0x0001AC34
		[NullableContext(1)]
		private static JsonPropertyInfo[] IConnectResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<IConnectResponseData> jsonPropertyInfoValues = new JsonPropertyInfoValues<IConnectResponseData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IConnectResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IConnectResponse)obj).data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] IConnectResponseData value)
			{
				((IConnectResponse)obj).data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IConnectResponse).GetField("data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IConnectResponseData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<IConnectResponseData>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IConnectResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IConnectResponse)obj).code);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IConnectResponse)obj).code = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "code";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IConnectResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IConnectResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IConnectResponse)obj).msg);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IConnectResponse)obj).msg = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "msg";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IConnectResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IConnectResponse);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IConnectResponse)obj).timestamp);
			jsonPropertyInfoValues4.Setter = delegate(object obj, long value)
			{
				((IConnectResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "timestamp";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IConnectResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo4);
			return array;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0001CE18 File Offset: 0x0001B018
		public JsonTypeInfo<IConnectResponseData> IConnectResponseData
		{
			get
			{
				JsonTypeInfo<IConnectResponseData> result;
				if ((result = this._IConnectResponseData) == null)
				{
					result = (this._IConnectResponseData = (JsonTypeInfo<IConnectResponseData>)base.Options.GetTypeInfo(typeof(IConnectResponseData)));
				}
				return result;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001CE54 File Offset: 0x0001B054
		[NullableContext(1)]
		private JsonTypeInfo<IConnectResponseData> Create_IConnectResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IConnectResponseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IConnectResponseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IConnectResponseData> jsonObjectInfoValues = new JsonObjectInfoValues<IConnectResponseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IConnectResponseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IConnectResponseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IConnectResponseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IConnectResponseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IConnectResponseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001CF1C File Offset: 0x0001B11C
		[NullableContext(1)]
		private static JsonPropertyInfo[] IConnectResponseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[20];
			JsonPropertyInfoValues<ThirdLogin> jsonPropertyInfoValues = new JsonPropertyInfoValues<ThirdLogin>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IConnectResponseData)obj).thirdLogin);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] ThirdLogin value)
			{
				((IConnectResponseData)obj).thirdLogin = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "thirdLogin";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("thirdLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ThirdLogin> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<ThirdLogin>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IConnectResponseData)obj).heartFreq);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IConnectResponseData)obj).heartFreq = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "heartFreq";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("heartFreq", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IConnectResponseData)obj).heartEnable);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int value)
			{
				((IConnectResponseData)obj).heartEnable = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "heartEnable";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("heartEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo3);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IConnectResponseData)obj).uagr);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IConnectResponseData)obj).uagr = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "uagr";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("uagr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((IConnectResponseData)obj).pagr);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IConnectResponseData)obj).pagr = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "pagr";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("pagr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((IConnectResponseData)obj).childArgUrl);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IConnectResponseData)obj).childArgUrl = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "childArgUrl";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("childArgUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((IConnectResponseData)obj).pwdLife);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IConnectResponseData)obj).pwdLife = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "pwdLife";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("pwdLife", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<ClientSwitch> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<ClientSwitch>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((IConnectResponseData)obj).clientSwitch);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(2)] ClientSwitch value)
			{
				((IConnectResponseData)obj).clientSwitch = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "clientSwitch";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("clientSwitch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ClientSwitch> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<ClientSwitch>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			JsonPropertyInfoValues<ClientUrl> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<ClientUrl>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((IConnectResponseData)obj).clientUrl);
			jsonPropertyInfoValues9.Setter = delegate(object obj, [Nullable(2)] ClientUrl value)
			{
				((IConnectResponseData)obj).clientUrl = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "clientUrl";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("clientUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ClientUrl> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<ClientUrl>(options, propertyInfo9);
			array[8].IsGetNullable = false;
			array[8].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((IConnectResponseData)obj).kefuInterval);
			jsonPropertyInfoValues10.Setter = delegate(object obj, int value)
			{
				((IConnectResponseData)obj).kefuInterval = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "kefuInterval";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("kefuInterval", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo10);
			JsonPropertyInfoValues<ThirdShareParams> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<ThirdShareParams>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((IConnectResponseData)obj).thirdShareParams);
			jsonPropertyInfoValues11.Setter = delegate(object obj, [Nullable(2)] ThirdShareParams value)
			{
				((IConnectResponseData)obj).thirdShareParams = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "thirdShareParams";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("thirdShareParams", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ThirdShareParams> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<ThirdShareParams>(options, propertyInfo11);
			array[10].IsGetNullable = false;
			array[10].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((IConnectResponseData)obj).regionMinAge);
			jsonPropertyInfoValues12.Setter = delegate(object obj, int value)
			{
				((IConnectResponseData)obj).regionMinAge = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "regionMinAge";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("regionMinAge", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo12);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((IConnectResponseData)obj).ageCheckBox);
			jsonPropertyInfoValues13.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).ageCheckBox = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "ageCheckBox";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("ageCheckBox", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo13);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((IConnectResponseData)obj).didSmSwitch);
			jsonPropertyInfoValues14.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).didSmSwitch = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "didSmSwitch";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("didSmSwitch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo14);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues15 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues15.IsProperty = false;
			jsonPropertyInfoValues15.IsPublic = true;
			jsonPropertyInfoValues15.IsVirtual = false;
			jsonPropertyInfoValues15.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues15.Converter = null;
			jsonPropertyInfoValues15.Getter = ((object obj) => ((IConnectResponseData)obj).didTxSwitch);
			jsonPropertyInfoValues15.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).didTxSwitch = value;
			};
			jsonPropertyInfoValues15.IgnoreCondition = null;
			jsonPropertyInfoValues15.HasJsonInclude = false;
			jsonPropertyInfoValues15.IsExtensionData = false;
			jsonPropertyInfoValues15.NumberHandling = null;
			jsonPropertyInfoValues15.PropertyName = "didTxSwitch";
			jsonPropertyInfoValues15.JsonPropertyName = null;
			jsonPropertyInfoValues15.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("didTxSwitch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo15 = jsonPropertyInfoValues15;
			array[14] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo15);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues16 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues16.IsProperty = false;
			jsonPropertyInfoValues16.IsPublic = true;
			jsonPropertyInfoValues16.IsVirtual = false;
			jsonPropertyInfoValues16.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues16.Converter = null;
			jsonPropertyInfoValues16.Getter = ((object obj) => ((IConnectResponseData)obj).geetestSwitch);
			jsonPropertyInfoValues16.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).geetestSwitch = value;
			};
			jsonPropertyInfoValues16.IgnoreCondition = null;
			jsonPropertyInfoValues16.HasJsonInclude = false;
			jsonPropertyInfoValues16.IsExtensionData = false;
			jsonPropertyInfoValues16.NumberHandling = null;
			jsonPropertyInfoValues16.PropertyName = "geetestSwitch";
			jsonPropertyInfoValues16.JsonPropertyName = null;
			jsonPropertyInfoValues16.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("geetestSwitch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo16 = jsonPropertyInfoValues16;
			array[15] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo16);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues17 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues17.IsProperty = false;
			jsonPropertyInfoValues17.IsPublic = true;
			jsonPropertyInfoValues17.IsVirtual = false;
			jsonPropertyInfoValues17.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues17.Converter = null;
			jsonPropertyInfoValues17.Getter = ((object obj) => ((IConnectResponseData)obj).audioSwitch);
			jsonPropertyInfoValues17.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).audioSwitch = value;
			};
			jsonPropertyInfoValues17.IgnoreCondition = null;
			jsonPropertyInfoValues17.HasJsonInclude = false;
			jsonPropertyInfoValues17.IsExtensionData = false;
			jsonPropertyInfoValues17.NumberHandling = null;
			jsonPropertyInfoValues17.PropertyName = "audioSwitch";
			jsonPropertyInfoValues17.JsonPropertyName = null;
			jsonPropertyInfoValues17.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("audioSwitch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo17 = jsonPropertyInfoValues17;
			array[16] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo17);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues18 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues18.IsProperty = false;
			jsonPropertyInfoValues18.IsPublic = true;
			jsonPropertyInfoValues18.IsVirtual = false;
			jsonPropertyInfoValues18.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues18.Converter = null;
			jsonPropertyInfoValues18.Getter = ((object obj) => ((IConnectResponseData)obj).iosCrossDistrict);
			jsonPropertyInfoValues18.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).iosCrossDistrict = value;
			};
			jsonPropertyInfoValues18.IgnoreCondition = null;
			jsonPropertyInfoValues18.HasJsonInclude = false;
			jsonPropertyInfoValues18.IsExtensionData = false;
			jsonPropertyInfoValues18.NumberHandling = null;
			jsonPropertyInfoValues18.PropertyName = "iosCrossDistrict";
			jsonPropertyInfoValues18.JsonPropertyName = null;
			jsonPropertyInfoValues18.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("iosCrossDistrict", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo18 = jsonPropertyInfoValues18;
			array[17] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo18);
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues19 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues19.IsProperty = false;
			jsonPropertyInfoValues19.IsPublic = true;
			jsonPropertyInfoValues19.IsVirtual = false;
			jsonPropertyInfoValues19.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues19.Converter = null;
			jsonPropertyInfoValues19.Getter = ((object obj) => ((IConnectResponseData)obj).googleCrossDistrict);
			jsonPropertyInfoValues19.Setter = delegate(object obj, bool value)
			{
				((IConnectResponseData)obj).googleCrossDistrict = value;
			};
			jsonPropertyInfoValues19.IgnoreCondition = null;
			jsonPropertyInfoValues19.HasJsonInclude = false;
			jsonPropertyInfoValues19.IsExtensionData = false;
			jsonPropertyInfoValues19.NumberHandling = null;
			jsonPropertyInfoValues19.PropertyName = "googleCrossDistrict";
			jsonPropertyInfoValues19.JsonPropertyName = null;
			jsonPropertyInfoValues19.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("googleCrossDistrict", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo19 = jsonPropertyInfoValues19;
			array[18] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo19);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues20 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues20.IsProperty = false;
			jsonPropertyInfoValues20.IsPublic = true;
			jsonPropertyInfoValues20.IsVirtual = false;
			jsonPropertyInfoValues20.DeclaringType = typeof(IConnectResponseData);
			jsonPropertyInfoValues20.Converter = null;
			jsonPropertyInfoValues20.Getter = ((object obj) => ((IConnectResponseData)obj).googlePcConsumeIntervalSec);
			jsonPropertyInfoValues20.Setter = delegate(object obj, int value)
			{
				((IConnectResponseData)obj).googlePcConsumeIntervalSec = value;
			};
			jsonPropertyInfoValues20.IgnoreCondition = null;
			jsonPropertyInfoValues20.HasJsonInclude = false;
			jsonPropertyInfoValues20.IsExtensionData = false;
			jsonPropertyInfoValues20.NumberHandling = null;
			jsonPropertyInfoValues20.PropertyName = "googlePcConsumeIntervalSec";
			jsonPropertyInfoValues20.JsonPropertyName = null;
			jsonPropertyInfoValues20.AttributeProviderFactory = (() => typeof(IConnectResponseData).GetField("googlePcConsumeIntervalSec", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo20 = jsonPropertyInfoValues20;
			array[19] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo20);
			return array;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0001E24C File Offset: 0x0001C44C
		public JsonTypeInfo<IGetAccessTokenResponse> IGetAccessTokenResponse
		{
			get
			{
				JsonTypeInfo<IGetAccessTokenResponse> result;
				if ((result = this._IGetAccessTokenResponse) == null)
				{
					result = (this._IGetAccessTokenResponse = (JsonTypeInfo<IGetAccessTokenResponse>)base.Options.GetTypeInfo(typeof(IGetAccessTokenResponse)));
				}
				return result;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001E288 File Offset: 0x0001C488
		[NullableContext(1)]
		private JsonTypeInfo<IGetAccessTokenResponse> Create_IGetAccessTokenResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<IGetAccessTokenResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IGetAccessTokenResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IGetAccessTokenResponse> jsonObjectInfoValues = new JsonObjectInfoValues<IGetAccessTokenResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new IGetAccessTokenResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IGetAccessTokenResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IGetAccessTokenResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IGetAccessTokenResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IGetAccessTokenResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001E350 File Offset: 0x0001C550
		[NullableContext(1)]
		private static JsonPropertyInfo[] IGetAccessTokenResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<IGetAccessTokenResponseData> jsonPropertyInfoValues = new JsonPropertyInfoValues<IGetAccessTokenResponseData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IGetAccessTokenResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IGetAccessTokenResponse)obj).data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] IGetAccessTokenResponseData value)
			{
				((IGetAccessTokenResponse)obj).data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IGetAccessTokenResponse).GetField("data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IGetAccessTokenResponseData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<IGetAccessTokenResponseData>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IGetAccessTokenResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IGetAccessTokenResponse)obj).code);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IGetAccessTokenResponse)obj).code = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "code";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IGetAccessTokenResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IGetAccessTokenResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IGetAccessTokenResponse)obj).msg);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IGetAccessTokenResponse)obj).msg = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "msg";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IGetAccessTokenResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IGetAccessTokenResponse);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IGetAccessTokenResponse)obj).timestamp);
			jsonPropertyInfoValues4.Setter = delegate(object obj, long value)
			{
				((IGetAccessTokenResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "timestamp";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IGetAccessTokenResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo4);
			return array;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001E734 File Offset: 0x0001C934
		public JsonTypeInfo<IGetAccessTokenResponseData> IGetAccessTokenResponseData
		{
			get
			{
				JsonTypeInfo<IGetAccessTokenResponseData> result;
				if ((result = this._IGetAccessTokenResponseData) == null)
				{
					result = (this._IGetAccessTokenResponseData = (JsonTypeInfo<IGetAccessTokenResponseData>)base.Options.GetTypeInfo(typeof(IGetAccessTokenResponseData)));
				}
				return result;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001E770 File Offset: 0x0001C970
		[NullableContext(1)]
		private JsonTypeInfo<IGetAccessTokenResponseData> Create_IGetAccessTokenResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IGetAccessTokenResponseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IGetAccessTokenResponseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IGetAccessTokenResponseData> jsonObjectInfoValues = new JsonObjectInfoValues<IGetAccessTokenResponseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IGetAccessTokenResponseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IGetAccessTokenResponseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IGetAccessTokenResponseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IGetAccessTokenResponseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IGetAccessTokenResponseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001E838 File Offset: 0x0001CA38
		[NullableContext(1)]
		private static JsonPropertyInfo[] IGetAccessTokenResponseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IGetAccessTokenResponseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IGetAccessTokenResponseData)obj).access_token);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IGetAccessTokenResponseData)obj).access_token = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "access_token";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IGetAccessTokenResponseData).GetField("access_token", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IGetAccessTokenResponseData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IGetAccessTokenResponseData)obj).expires_in);
			jsonPropertyInfoValues2.Setter = delegate(object obj, long value)
			{
				((IGetAccessTokenResponseData)obj).expires_in = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "expires_in";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IGetAccessTokenResponseData).GetField("expires_in", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo2);
			return array;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0001EA30 File Offset: 0x0001CC30
		public JsonTypeInfo<IIdTokenData> IIdTokenData
		{
			get
			{
				JsonTypeInfo<IIdTokenData> result;
				if ((result = this._IIdTokenData) == null)
				{
					result = (this._IIdTokenData = (JsonTypeInfo<IIdTokenData>)base.Options.GetTypeInfo(typeof(IIdTokenData)));
				}
				return result;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001EA6C File Offset: 0x0001CC6C
		[NullableContext(1)]
		private JsonTypeInfo<IIdTokenData> Create_IIdTokenData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IIdTokenData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IIdTokenData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IIdTokenData> jsonObjectInfoValues = new JsonObjectInfoValues<IIdTokenData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IIdTokenData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IIdTokenDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IIdTokenData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IIdTokenData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IIdTokenData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001EB34 File Offset: 0x0001CD34
		[NullableContext(1)]
		private static JsonPropertyInfo[] IIdTokenDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[15];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IIdTokenData)obj).age);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((IIdTokenData)obj).age = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "age";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("age", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IIdTokenData)obj).at_hash);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).at_hash = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "at_hash";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("at_hash", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string[]> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string[]>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IIdTokenData)obj).aud);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] string[] value)
			{
				((IIdTokenData)obj).aud = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "aud";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("aud", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string[]> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string[]>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IIdTokenData)obj).auth_mode);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).auth_mode = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "auth_mode";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("auth_mode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((IIdTokenData)obj).device_type);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).device_type = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "device_type";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("device_type", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((IIdTokenData)obj).duid);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).duid = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "duid";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("duid", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((IIdTokenData)obj).env_iss_id);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).env_iss_id = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "env_iss_id";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("env_iss_id", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((IIdTokenData)obj).exp);
			jsonPropertyInfoValues8.Setter = delegate(object obj, int value)
			{
				((IIdTokenData)obj).exp = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "exp";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("exp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo8);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((IIdTokenData)obj).iat);
			jsonPropertyInfoValues9.Setter = delegate(object obj, int value)
			{
				((IIdTokenData)obj).iat = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "iat";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("iat", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo9);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((IIdTokenData)obj).iss);
			jsonPropertyInfoValues10.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).iss = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "iss";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("iss", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo10);
			array[9].IsGetNullable = false;
			array[9].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((IIdTokenData)obj).legal_country);
			jsonPropertyInfoValues11.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).legal_country = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "legal_country";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("legal_country", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo11);
			array[10].IsGetNullable = false;
			array[10].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((IIdTokenData)obj).locale);
			jsonPropertyInfoValues12.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).locale = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "locale";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("locale", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo12);
			array[11].IsGetNullable = false;
			array[11].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((IIdTokenData)obj).online_id);
			jsonPropertyInfoValues13.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).online_id = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "online_id";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("online_id", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo13);
			array[12].IsGetNullable = false;
			array[12].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((IIdTokenData)obj).sub);
			jsonPropertyInfoValues14.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).sub = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "sub";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("sub", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo14);
			array[13].IsGetNullable = false;
			array[13].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues15 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues15.IsProperty = false;
			jsonPropertyInfoValues15.IsPublic = true;
			jsonPropertyInfoValues15.IsVirtual = false;
			jsonPropertyInfoValues15.DeclaringType = typeof(IIdTokenData);
			jsonPropertyInfoValues15.Converter = null;
			jsonPropertyInfoValues15.Getter = ((object obj) => ((IIdTokenData)obj).ver);
			jsonPropertyInfoValues15.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IIdTokenData)obj).ver = value;
			};
			jsonPropertyInfoValues15.IgnoreCondition = null;
			jsonPropertyInfoValues15.HasJsonInclude = false;
			jsonPropertyInfoValues15.IsExtensionData = false;
			jsonPropertyInfoValues15.NumberHandling = null;
			jsonPropertyInfoValues15.PropertyName = "ver";
			jsonPropertyInfoValues15.JsonPropertyName = null;
			jsonPropertyInfoValues15.AttributeProviderFactory = (() => typeof(IIdTokenData).GetField("ver", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo15 = jsonPropertyInfoValues15;
			array[14] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo15);
			array[14].IsGetNullable = false;
			array[14].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001FA10 File Offset: 0x0001DC10
		public JsonTypeInfo<ILoginResponse> ILoginResponse
		{
			get
			{
				JsonTypeInfo<ILoginResponse> result;
				if ((result = this._ILoginResponse) == null)
				{
					result = (this._ILoginResponse = (JsonTypeInfo<ILoginResponse>)base.Options.GetTypeInfo(typeof(ILoginResponse)));
				}
				return result;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001FA4C File Offset: 0x0001DC4C
		[NullableContext(1)]
		private JsonTypeInfo<ILoginResponse> Create_ILoginResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<ILoginResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ILoginResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ILoginResponse> jsonObjectInfoValues = new JsonObjectInfoValues<ILoginResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new ILoginResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ILoginResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ILoginResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ILoginResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ILoginResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001FB14 File Offset: 0x0001DD14
		[NullableContext(1)]
		private static JsonPropertyInfo[] ILoginResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<ILoginResponseData> jsonPropertyInfoValues = new JsonPropertyInfoValues<ILoginResponseData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ILoginResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ILoginResponse)obj).data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] ILoginResponseData value)
			{
				((ILoginResponse)obj).data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ILoginResponse).GetField("data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ILoginResponseData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<ILoginResponseData>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ILoginResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ILoginResponse)obj).code);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((ILoginResponse)obj).code = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "code";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ILoginResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ILoginResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ILoginResponse)obj).msg);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponse)obj).msg = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "msg";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ILoginResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ILoginResponse);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ILoginResponse)obj).timestamp);
			jsonPropertyInfoValues4.Setter = delegate(object obj, long value)
			{
				((ILoginResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "timestamp";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ILoginResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo4);
			return array;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
		public JsonTypeInfo<ILoginResponseData> ILoginResponseData
		{
			get
			{
				JsonTypeInfo<ILoginResponseData> result;
				if ((result = this._ILoginResponseData) == null)
				{
					result = (this._ILoginResponseData = (JsonTypeInfo<ILoginResponseData>)base.Options.GetTypeInfo(typeof(ILoginResponseData)));
				}
				return result;
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001FF34 File Offset: 0x0001E134
		[NullableContext(1)]
		private JsonTypeInfo<ILoginResponseData> Create_ILoginResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<ILoginResponseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ILoginResponseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ILoginResponseData> jsonObjectInfoValues = new JsonObjectInfoValues<ILoginResponseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new ILoginResponseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ILoginResponseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ILoginResponseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ILoginResponseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ILoginResponseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ILoginResponseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[11];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ILoginResponseData)obj).username);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).username = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "username";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("username", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ILoginResponseData)obj).id);
			jsonPropertyInfoValues2.Setter = delegate(object obj, long value)
			{
				((ILoginResponseData)obj).id = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "id";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("id", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo2);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ILoginResponseData)obj).loginType);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int value)
			{
				((ILoginResponseData)obj).loginType = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "loginType";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("loginType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo3);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ILoginResponseData)obj).code);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).code = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "code";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((ILoginResponseData)obj).cuid);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).cuid = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "cuid";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("cuid", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<bool> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<bool>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((ILoginResponseData)obj).bindDevSwitch);
			jsonPropertyInfoValues6.Setter = delegate(object obj, bool value)
			{
				((ILoginResponseData)obj).bindDevSwitch = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "bindDevSwitch";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("bindDevSwitch", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<bool> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<bool>(options, propertyInfo6);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((ILoginResponseData)obj).autoToken);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).autoToken = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "autoToken";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("autoToken", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((ILoginResponseData)obj).thirdNickName);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).thirdNickName = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "thirdNickName";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("thirdNickName", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((ILoginResponseData)obj).firstLgn);
			jsonPropertyInfoValues9.Setter = delegate(object obj, int value)
			{
				((ILoginResponseData)obj).firstLgn = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "firstLgn";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("firstLgn", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo9);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((ILoginResponseData)obj).realNameMethod);
			jsonPropertyInfoValues10.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).realNameMethod = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "realNameMethod";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("realNameMethod", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo10);
			array[9].IsGetNullable = false;
			array[9].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(ILoginResponseData);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((ILoginResponseData)obj).thirdUnionId);
			jsonPropertyInfoValues11.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ILoginResponseData)obj).thirdUnionId = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "thirdUnionId";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(ILoginResponseData).GetField("thirdUnionId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo11);
			array[10].IsGetNullable = false;
			array[10].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00020ABC File Offset: 0x0001ECBC
		public JsonTypeInfo<IPlatformData> IPlatformData
		{
			get
			{
				JsonTypeInfo<IPlatformData> result;
				if ((result = this._IPlatformData) == null)
				{
					result = (this._IPlatformData = (JsonTypeInfo<IPlatformData>)base.Options.GetTypeInfo(typeof(IPlatformData)));
				}
				return result;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		[NullableContext(1)]
		private JsonTypeInfo<IPlatformData> Create_IPlatformData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IPlatformData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IPlatformData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IPlatformData> jsonObjectInfoValues = new JsonObjectInfoValues<IPlatformData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IPlatformData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IPlatformDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IPlatformData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IPlatformData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IPlatformData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		[NullableContext(1)]
		private static JsonPropertyInfo[] IPlatformDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[9];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IPlatformData)obj).projectId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformData)obj).projectId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "projectId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("projectId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IPlatformData)obj).channelId);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformData)obj).channelId = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "channelId";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("channelId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IPlatformData)obj).platform);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformData)obj).platform = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "platform";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("platform", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IPlatformData)obj).version);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformData)obj).version = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "version";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("version", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((IPlatformData)obj).sdkVersion);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformData)obj).sdkVersion = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "sdkVersion";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("sdkVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((IPlatformData)obj).sdkServerVersion);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformData)obj).sdkServerVersion = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "sdkServerVersion";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("sdkServerVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<IPlatformReleaseData> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<IPlatformReleaseData>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((IPlatformData)obj).Development);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] IPlatformReleaseData value)
			{
				((IPlatformData)obj).Development = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "Development";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("Development", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IPlatformReleaseData> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<IPlatformReleaseData>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<IPlatformReleaseData> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<IPlatformReleaseData>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((IPlatformData)obj).PreRelease);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(2)] IPlatformReleaseData value)
			{
				((IPlatformData)obj).PreRelease = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "PreRelease";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("PreRelease", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IPlatformReleaseData> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<IPlatformReleaseData>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			JsonPropertyInfoValues<IPlatformReleaseData> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<IPlatformReleaseData>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(IPlatformData);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((IPlatformData)obj).Release);
			jsonPropertyInfoValues9.Setter = delegate(object obj, [Nullable(2)] IPlatformReleaseData value)
			{
				((IPlatformData)obj).Release = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "Release";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(IPlatformData).GetField("Release", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IPlatformReleaseData> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<IPlatformReleaseData>(options, propertyInfo9);
			array[8].IsGetNullable = false;
			array[8].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000214C4 File Offset: 0x0001F6C4
		public JsonTypeInfo<IPlatformReleaseData> IPlatformReleaseData
		{
			get
			{
				JsonTypeInfo<IPlatformReleaseData> result;
				if ((result = this._IPlatformReleaseData) == null)
				{
					result = (this._IPlatformReleaseData = (JsonTypeInfo<IPlatformReleaseData>)base.Options.GetTypeInfo(typeof(IPlatformReleaseData)));
				}
				return result;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00021500 File Offset: 0x0001F700
		[NullableContext(1)]
		private JsonTypeInfo<IPlatformReleaseData> Create_IPlatformReleaseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IPlatformReleaseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IPlatformReleaseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IPlatformReleaseData> jsonObjectInfoValues = new JsonObjectInfoValues<IPlatformReleaseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IPlatformReleaseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IPlatformReleaseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IPlatformReleaseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IPlatformReleaseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IPlatformReleaseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000215C8 File Offset: 0x0001F7C8
		[NullableContext(1)]
		private static JsonPropertyInfo[] IPlatformReleaseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<List<string>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<string>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IPlatformReleaseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IPlatformReleaseData)obj).CdnUrlPrefix);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<string> value)
			{
				((IPlatformReleaseData)obj).CdnUrlPrefix = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "CdnUrlPrefix";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IPlatformReleaseData).GetField("CdnUrlPrefix", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<string>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<string>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IPlatformReleaseData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IPlatformReleaseData)obj).productId);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IPlatformReleaseData)obj).productId = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "productId";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IPlatformReleaseData).GetField("productId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000217D4 File Offset: 0x0001F9D4
		public JsonTypeInfo<IQueryGoodsResponse> IQueryGoodsResponse
		{
			get
			{
				JsonTypeInfo<IQueryGoodsResponse> result;
				if ((result = this._IQueryGoodsResponse) == null)
				{
					result = (this._IQueryGoodsResponse = (JsonTypeInfo<IQueryGoodsResponse>)base.Options.GetTypeInfo(typeof(IQueryGoodsResponse)));
				}
				return result;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00021810 File Offset: 0x0001FA10
		[NullableContext(1)]
		private JsonTypeInfo<IQueryGoodsResponse> Create_IQueryGoodsResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<IQueryGoodsResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IQueryGoodsResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IQueryGoodsResponse> jsonObjectInfoValues = new JsonObjectInfoValues<IQueryGoodsResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new IQueryGoodsResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IQueryGoodsResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IQueryGoodsResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IQueryGoodsResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IQueryGoodsResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000218D8 File Offset: 0x0001FAD8
		[NullableContext(1)]
		private static JsonPropertyInfo[] IQueryGoodsResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<List<IQueryGoodsResponseData>> jsonPropertyInfoValues = new JsonPropertyInfoValues<List<IQueryGoodsResponseData>>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IQueryGoodsResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IQueryGoodsResponse)obj).data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<IQueryGoodsResponseData> value)
			{
				((IQueryGoodsResponse)obj).data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IQueryGoodsResponse).GetField("data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<IQueryGoodsResponseData>> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<List<IQueryGoodsResponseData>>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IQueryGoodsResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IQueryGoodsResponse)obj).code);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IQueryGoodsResponse)obj).code = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "code";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IQueryGoodsResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IQueryGoodsResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IQueryGoodsResponse)obj).msg);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IQueryGoodsResponse)obj).msg = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "msg";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IQueryGoodsResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IQueryGoodsResponse);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IQueryGoodsResponse)obj).timestamp);
			jsonPropertyInfoValues4.Setter = delegate(object obj, long value)
			{
				((IQueryGoodsResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "timestamp";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IQueryGoodsResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo4);
			return array;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00021CBC File Offset: 0x0001FEBC
		public JsonTypeInfo<IQueryGoodsResponseData> IQueryGoodsResponseData
		{
			get
			{
				JsonTypeInfo<IQueryGoodsResponseData> result;
				if ((result = this._IQueryGoodsResponseData) == null)
				{
					result = (this._IQueryGoodsResponseData = (JsonTypeInfo<IQueryGoodsResponseData>)base.Options.GetTypeInfo(typeof(IQueryGoodsResponseData)));
				}
				return result;
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		[NullableContext(1)]
		private JsonTypeInfo<IQueryGoodsResponseData> Create_IQueryGoodsResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IQueryGoodsResponseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IQueryGoodsResponseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IQueryGoodsResponseData> jsonObjectInfoValues = new JsonObjectInfoValues<IQueryGoodsResponseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IQueryGoodsResponseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IQueryGoodsResponseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IQueryGoodsResponseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IQueryGoodsResponseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00021DC0 File Offset: 0x0001FFC0
		[NullableContext(1)]
		private static JsonPropertyInfo[] IQueryGoodsResponseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[6];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IQueryGoodsResponseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IQueryGoodsResponseData)obj).goodsId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IQueryGoodsResponseData)obj).goodsId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "goodsId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetField("goodsId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IQueryGoodsResponseData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IQueryGoodsResponseData)obj).name);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IQueryGoodsResponseData)obj).name = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "name";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetField("name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IQueryGoodsResponseData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IQueryGoodsResponseData)obj).currency);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IQueryGoodsResponseData)obj).currency = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "currency";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetField("currency", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<double> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IQueryGoodsResponseData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IQueryGoodsResponseData)obj).price);
			jsonPropertyInfoValues4.Setter = delegate(object obj, double value)
			{
				((IQueryGoodsResponseData)obj).price = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "price";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetField("price", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo4);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(IQueryGoodsResponseData);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((IQueryGoodsResponseData)obj).desc);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IQueryGoodsResponseData)obj).desc = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "desc";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetField("desc", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(IQueryGoodsResponseData);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((IQueryGoodsResponseData)obj).channelGoodsId);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IQueryGoodsResponseData)obj).channelGoodsId = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "channelGoodsId";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(IQueryGoodsResponseData).GetField("channelGoodsId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x000223B4 File Offset: 0x000205B4
		public JsonTypeInfo<IRenewAccessTokenResponse> IRenewAccessTokenResponse
		{
			get
			{
				JsonTypeInfo<IRenewAccessTokenResponse> result;
				if ((result = this._IRenewAccessTokenResponse) == null)
				{
					result = (this._IRenewAccessTokenResponse = (JsonTypeInfo<IRenewAccessTokenResponse>)base.Options.GetTypeInfo(typeof(IRenewAccessTokenResponse)));
				}
				return result;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000223F0 File Offset: 0x000205F0
		[NullableContext(1)]
		private JsonTypeInfo<IRenewAccessTokenResponse> Create_IRenewAccessTokenResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<IRenewAccessTokenResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IRenewAccessTokenResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IRenewAccessTokenResponse> jsonObjectInfoValues = new JsonObjectInfoValues<IRenewAccessTokenResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new IRenewAccessTokenResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IRenewAccessTokenResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IRenewAccessTokenResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IRenewAccessTokenResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IRenewAccessTokenResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000224B8 File Offset: 0x000206B8
		[NullableContext(1)]
		private static JsonPropertyInfo[] IRenewAccessTokenResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<IRenewAccessTokenResponseData> jsonPropertyInfoValues = new JsonPropertyInfoValues<IRenewAccessTokenResponseData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IRenewAccessTokenResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IRenewAccessTokenResponse)obj).data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] IRenewAccessTokenResponseData value)
			{
				((IRenewAccessTokenResponse)obj).data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IRenewAccessTokenResponse).GetField("data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<IRenewAccessTokenResponseData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<IRenewAccessTokenResponseData>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IRenewAccessTokenResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IRenewAccessTokenResponse)obj).code);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((IRenewAccessTokenResponse)obj).code = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "code";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IRenewAccessTokenResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IRenewAccessTokenResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IRenewAccessTokenResponse)obj).msg);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IRenewAccessTokenResponse)obj).msg = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "msg";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IRenewAccessTokenResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(IRenewAccessTokenResponse);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((IRenewAccessTokenResponse)obj).timestamp);
			jsonPropertyInfoValues4.Setter = delegate(object obj, long value)
			{
				((IRenewAccessTokenResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "timestamp";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(IRenewAccessTokenResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo4);
			return array;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0002289C File Offset: 0x00020A9C
		public JsonTypeInfo<IRenewAccessTokenResponseData> IRenewAccessTokenResponseData
		{
			get
			{
				JsonTypeInfo<IRenewAccessTokenResponseData> result;
				if ((result = this._IRenewAccessTokenResponseData) == null)
				{
					result = (this._IRenewAccessTokenResponseData = (JsonTypeInfo<IRenewAccessTokenResponseData>)base.Options.GetTypeInfo(typeof(IRenewAccessTokenResponseData)));
				}
				return result;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000228D8 File Offset: 0x00020AD8
		[NullableContext(1)]
		private JsonTypeInfo<IRenewAccessTokenResponseData> Create_IRenewAccessTokenResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<IRenewAccessTokenResponseData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IRenewAccessTokenResponseData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IRenewAccessTokenResponseData> jsonObjectInfoValues = new JsonObjectInfoValues<IRenewAccessTokenResponseData>();
				jsonObjectInfoValues.ObjectCreator = (() => new IRenewAccessTokenResponseData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IRenewAccessTokenResponseDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IRenewAccessTokenResponseData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IRenewAccessTokenResponseData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IRenewAccessTokenResponseData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000229A0 File Offset: 0x00020BA0
		[NullableContext(1)]
		private static JsonPropertyInfo[] IRenewAccessTokenResponseDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IRenewAccessTokenResponseData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IRenewAccessTokenResponseData)obj).expireSec);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IRenewAccessTokenResponseData)obj).expireSec = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "expireSec";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IRenewAccessTokenResponseData).GetField("expireSec", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00022AB0 File Offset: 0x00020CB0
		public JsonTypeInfo<IReportResponse> IReportResponse
		{
			get
			{
				JsonTypeInfo<IReportResponse> result;
				if ((result = this._IReportResponse) == null)
				{
					result = (this._IReportResponse = (JsonTypeInfo<IReportResponse>)base.Options.GetTypeInfo(typeof(IReportResponse)));
				}
				return result;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00022AEC File Offset: 0x00020CEC
		[NullableContext(1)]
		private JsonTypeInfo<IReportResponse> Create_IReportResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<IReportResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<IReportResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<IReportResponse> jsonObjectInfoValues = new JsonObjectInfoValues<IReportResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new IReportResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.IReportResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(IReportResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<IReportResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<IReportResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00022BB4 File Offset: 0x00020DB4
		[NullableContext(1)]
		private static JsonPropertyInfo[] IReportResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(IReportResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((IReportResponse)obj).code);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((IReportResponse)obj).code = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "code";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(IReportResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(IReportResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((IReportResponse)obj).msg);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((IReportResponse)obj).msg = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "msg";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(IReportResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(IReportResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((IReportResponse)obj).timestamp);
			jsonPropertyInfoValues3.Setter = delegate(object obj, long value)
			{
				((IReportResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "timestamp";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(IReportResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo3);
			return array;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00022E98 File Offset: 0x00021098
		public JsonTypeInfo<ISdkRequestEmailCodeResponse> ISdkRequestEmailCodeResponse
		{
			get
			{
				JsonTypeInfo<ISdkRequestEmailCodeResponse> result;
				if ((result = this._ISdkRequestEmailCodeResponse) == null)
				{
					result = (this._ISdkRequestEmailCodeResponse = (JsonTypeInfo<ISdkRequestEmailCodeResponse>)base.Options.GetTypeInfo(typeof(ISdkRequestEmailCodeResponse)));
				}
				return result;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00022ED4 File Offset: 0x000210D4
		[NullableContext(1)]
		private JsonTypeInfo<ISdkRequestEmailCodeResponse> Create_ISdkRequestEmailCodeResponse(JsonSerializerOptions options)
		{
			JsonTypeInfo<ISdkRequestEmailCodeResponse> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ISdkRequestEmailCodeResponse>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ISdkRequestEmailCodeResponse> jsonObjectInfoValues = new JsonObjectInfoValues<ISdkRequestEmailCodeResponse>();
				jsonObjectInfoValues.ObjectCreator = (() => new ISdkRequestEmailCodeResponse());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ISdkRequestEmailCodeResponsePropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ISdkRequestEmailCodeResponse).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ISdkRequestEmailCodeResponse> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ISdkRequestEmailCodeResponse>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00022F9C File Offset: 0x0002119C
		[NullableContext(1)]
		private static JsonPropertyInfo[] ISdkRequestEmailCodeResponsePropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ISdkRequestEmailCodeResponse);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ISdkRequestEmailCodeResponse)obj).code);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((ISdkRequestEmailCodeResponse)obj).code = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "code";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ISdkRequestEmailCodeResponse).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ISdkRequestEmailCodeResponse);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ISdkRequestEmailCodeResponse)obj).msg);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ISdkRequestEmailCodeResponse)obj).msg = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "msg";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ISdkRequestEmailCodeResponse).GetField("msg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<long> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ISdkRequestEmailCodeResponse);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ISdkRequestEmailCodeResponse)obj).timestamp);
			jsonPropertyInfoValues3.Setter = delegate(object obj, long value)
			{
				((ISdkRequestEmailCodeResponse)obj).timestamp = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "timestamp";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ISdkRequestEmailCodeResponse).GetField("timestamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo3);
			return array;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00023280 File Offset: 0x00021480
		public JsonTypeInfo<KujiequParam> KujiequParam
		{
			get
			{
				JsonTypeInfo<KujiequParam> result;
				if ((result = this._KujiequParam) == null)
				{
					result = (this._KujiequParam = (JsonTypeInfo<KujiequParam>)base.Options.GetTypeInfo(typeof(KujiequParam)));
				}
				return result;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000232BC File Offset: 0x000214BC
		[NullableContext(1)]
		private JsonTypeInfo<KujiequParam> Create_KujiequParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<KujiequParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<KujiequParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<KujiequParam> jsonObjectInfoValues = new JsonObjectInfoValues<KujiequParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new KujiequParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.KujiequParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(KujiequParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<KujiequParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<KujiequParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00023384 File Offset: 0x00021584
		[NullableContext(1)]
		private static JsonPropertyInfo[] KujiequParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(KujiequParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((KujiequParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((KujiequParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(KujiequParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(KujiequParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((KujiequParam)obj).appKey);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((KujiequParam)obj).appKey = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appKey";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(KujiequParam).GetProperty("appKey", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00023590 File Offset: 0x00021790
		public JsonTypeInfo<LoginElement> LoginElement
		{
			get
			{
				JsonTypeInfo<LoginElement> result;
				if ((result = this._LoginElement) == null)
				{
					result = (this._LoginElement = (JsonTypeInfo<LoginElement>)base.Options.GetTypeInfo(typeof(LoginElement)));
				}
				return result;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000235CC File Offset: 0x000217CC
		[NullableContext(1)]
		private JsonTypeInfo<LoginElement> Create_LoginElement(JsonSerializerOptions options)
		{
			JsonTypeInfo<LoginElement> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<LoginElement>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<LoginElement> jsonObjectInfoValues = new JsonObjectInfoValues<LoginElement>();
				jsonObjectInfoValues.ObjectCreator = (() => new LoginElement());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.LoginElementPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(LoginElement).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<LoginElement> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<LoginElement>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00023694 File Offset: 0x00021894
		[NullableContext(1)]
		private static JsonPropertyInfo[] LoginElementPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(LoginElement);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((LoginElement)obj).enabled);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((LoginElement)obj).enabled = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "enabled";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(LoginElement).GetField("enabled", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			return array;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00023790 File Offset: 0x00021990
		public JsonTypeInfo<QQParam> QQParam
		{
			get
			{
				JsonTypeInfo<QQParam> result;
				if ((result = this._QQParam) == null)
				{
					result = (this._QQParam = (JsonTypeInfo<QQParam>)base.Options.GetTypeInfo(typeof(QQParam)));
				}
				return result;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000237CC File Offset: 0x000219CC
		[NullableContext(1)]
		private JsonTypeInfo<QQParam> Create_QQParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<QQParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<QQParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<QQParam> jsonObjectInfoValues = new JsonObjectInfoValues<QQParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new QQParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.QQParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(QQParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<QQParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<QQParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00023894 File Offset: 0x00021A94
		[NullableContext(1)]
		private static JsonPropertyInfo[] QQParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(QQParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((QQParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((QQParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(QQParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(QQParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((QQParam)obj).appKey);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((QQParam)obj).appKey = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appKey";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(QQParam).GetProperty("appKey", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00023AA0 File Offset: 0x00021CA0
		public JsonTypeInfo<SdkPlatformConfig> SdkPlatformConfig
		{
			get
			{
				JsonTypeInfo<SdkPlatformConfig> result;
				if ((result = this._SdkPlatformConfig) == null)
				{
					result = (this._SdkPlatformConfig = (JsonTypeInfo<SdkPlatformConfig>)base.Options.GetTypeInfo(typeof(SdkPlatformConfig)));
				}
				return result;
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00023ADC File Offset: 0x00021CDC
		[NullableContext(1)]
		private JsonTypeInfo<SdkPlatformConfig> Create_SdkPlatformConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<SdkPlatformConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<SdkPlatformConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<SdkPlatformConfig> jsonObjectInfoValues = new JsonObjectInfoValues<SdkPlatformConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new SdkPlatformConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.SdkPlatformConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<SdkPlatformConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<SdkPlatformConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00023BA4 File Offset: 0x00021DA4
		[NullableContext(1)]
		private static JsonPropertyInfo[] SdkPlatformConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[16];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((SdkPlatformConfig)obj).PrivacyPolicy);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).PrivacyPolicy = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PrivacyPolicy";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("PrivacyPolicy", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((SdkPlatformConfig)obj).TermsOfService);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).TermsOfService = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "TermsOfService";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("TermsOfService", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((SdkPlatformConfig)obj).ChildProtocol);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).ChildProtocol = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "ChildProtocol";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("ChildProtocol", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<List<string>> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<List<string>>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((SdkPlatformConfig)obj).ServerUrl);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<string> value)
			{
				((SdkPlatformConfig)obj).ServerUrl = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "ServerUrl";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("ServerUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<string>> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<List<string>>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<List<string>> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<List<string>>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((SdkPlatformConfig)obj).PayUrl);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<string> value)
			{
				((SdkPlatformConfig)obj).PayUrl = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "PayUrl";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("PayUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<string>> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<List<string>>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((SdkPlatformConfig)obj).client_id);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).client_id = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "client_id";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("client_id", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((SdkPlatformConfig)obj).client_secret);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).client_secret = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "client_secret";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("client_secret", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((SdkPlatformConfig)obj).platform_pkg);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).platform_pkg = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "platform_pkg";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("platform_pkg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((SdkPlatformConfig)obj).platform_client_id);
			jsonPropertyInfoValues9.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).platform_client_id = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "platform_client_id";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("platform_client_id", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo9);
			array[8].IsGetNullable = false;
			array[8].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((SdkPlatformConfig)obj).platform_client_secret);
			jsonPropertyInfoValues10.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).platform_client_secret = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "platform_client_secret";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("platform_client_secret", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo10);
			array[9].IsGetNullable = false;
			array[9].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((SdkPlatformConfig)obj).UserCenterUrl);
			jsonPropertyInfoValues11.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).UserCenterUrl = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "UserCenterUrl";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("UserCenterUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo11);
			array[10].IsGetNullable = false;
			array[10].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((SdkPlatformConfig)obj).CustomServiceUrl);
			jsonPropertyInfoValues12.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).CustomServiceUrl = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "CustomServiceUrl";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("CustomServiceUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo12);
			array[11].IsGetNullable = false;
			array[11].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((SdkPlatformConfig)obj).DataReportUrl);
			jsonPropertyInfoValues13.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).DataReportUrl = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "DataReportUrl";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("DataReportUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo13);
			array[12].IsGetNullable = false;
			array[12].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((SdkPlatformConfig)obj).DataReportId);
			jsonPropertyInfoValues14.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).DataReportId = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "DataReportId";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("DataReportId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo14);
			array[13].IsGetNullable = false;
			array[13].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues15 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues15.IsProperty = false;
			jsonPropertyInfoValues15.IsPublic = true;
			jsonPropertyInfoValues15.IsVirtual = false;
			jsonPropertyInfoValues15.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues15.Converter = null;
			jsonPropertyInfoValues15.Getter = ((object obj) => ((SdkPlatformConfig)obj).kuro_DataReportUrl);
			jsonPropertyInfoValues15.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((SdkPlatformConfig)obj).kuro_DataReportUrl = value;
			};
			jsonPropertyInfoValues15.IgnoreCondition = null;
			jsonPropertyInfoValues15.HasJsonInclude = false;
			jsonPropertyInfoValues15.IsExtensionData = false;
			jsonPropertyInfoValues15.NumberHandling = null;
			jsonPropertyInfoValues15.PropertyName = "kuro_DataReportUrl";
			jsonPropertyInfoValues15.JsonPropertyName = null;
			jsonPropertyInfoValues15.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("kuro_DataReportUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo15 = jsonPropertyInfoValues15;
			array[14] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo15);
			array[14].IsGetNullable = false;
			array[14].IsSetNullable = false;
			JsonPropertyInfoValues<Dictionary<string, CsLinkEntry>> jsonPropertyInfoValues16 = new JsonPropertyInfoValues<Dictionary<string, CsLinkEntry>>();
			jsonPropertyInfoValues16.IsProperty = false;
			jsonPropertyInfoValues16.IsPublic = true;
			jsonPropertyInfoValues16.IsVirtual = false;
			jsonPropertyInfoValues16.DeclaringType = typeof(SdkPlatformConfig);
			jsonPropertyInfoValues16.Converter = null;
			jsonPropertyInfoValues16.Getter = ((object obj) => ((SdkPlatformConfig)obj).cs_links);
			jsonPropertyInfoValues16.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, CsLinkEntry> value)
			{
				((SdkPlatformConfig)obj).cs_links = value;
			};
			jsonPropertyInfoValues16.IgnoreCondition = null;
			jsonPropertyInfoValues16.HasJsonInclude = false;
			jsonPropertyInfoValues16.IsExtensionData = false;
			jsonPropertyInfoValues16.NumberHandling = null;
			jsonPropertyInfoValues16.PropertyName = "cs_links";
			jsonPropertyInfoValues16.JsonPropertyName = null;
			jsonPropertyInfoValues16.AttributeProviderFactory = (() => typeof(SdkPlatformConfig).GetField("cs_links", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, CsLinkEntry>> propertyInfo16 = jsonPropertyInfoValues16;
			array[15] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, CsLinkEntry>>(options, propertyInfo16);
			array[15].IsGetNullable = false;
			array[15].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00024BB8 File Offset: 0x00022DB8
		public JsonTypeInfo<ShareSDKParam> ShareSDKParam
		{
			get
			{
				JsonTypeInfo<ShareSDKParam> result;
				if ((result = this._ShareSDKParam) == null)
				{
					result = (this._ShareSDKParam = (JsonTypeInfo<ShareSDKParam>)base.Options.GetTypeInfo(typeof(ShareSDKParam)));
				}
				return result;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00024BF4 File Offset: 0x00022DF4
		[NullableContext(1)]
		private JsonTypeInfo<ShareSDKParam> Create_ShareSDKParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<ShareSDKParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ShareSDKParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ShareSDKParam> jsonObjectInfoValues = new JsonObjectInfoValues<ShareSDKParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new ShareSDKParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ShareSDKParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ShareSDKParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ShareSDKParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ShareSDKParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00024CBC File Offset: 0x00022EBC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ShareSDKParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ShareSDKParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ShareSDKParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ShareSDKParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ShareSDKParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ShareSDKParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ShareSDKParam)obj).appKey);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ShareSDKParam)obj).appKey = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appKey";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ShareSDKParam).GetProperty("appKey", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00024EC8 File Offset: 0x000230C8
		public JsonTypeInfo<ThirdLogin> ThirdLogin
		{
			get
			{
				JsonTypeInfo<ThirdLogin> result;
				if ((result = this._ThirdLogin) == null)
				{
					result = (this._ThirdLogin = (JsonTypeInfo<ThirdLogin>)base.Options.GetTypeInfo(typeof(ThirdLogin)));
				}
				return result;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00024F04 File Offset: 0x00023104
		[NullableContext(1)]
		private JsonTypeInfo<ThirdLogin> Create_ThirdLogin(JsonSerializerOptions options)
		{
			JsonTypeInfo<ThirdLogin> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ThirdLogin>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ThirdLogin> jsonObjectInfoValues = new JsonObjectInfoValues<ThirdLogin>();
				jsonObjectInfoValues.ObjectCreator = (() => new ThirdLogin());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ThirdLoginPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ThirdLogin).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ThirdLogin> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ThirdLogin>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00024FCC File Offset: 0x000231CC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ThirdLoginPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[19];
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ThirdLogin)obj).wechat);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).wechat = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "wechat";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("wechat", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ThirdLogin)obj).qq);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).qq = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "qq";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("qq", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ThirdLogin)obj).phone);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).phone = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "phone";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("phone", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ThirdLogin)obj).phoneQk);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).phoneQk = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "phoneQk";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("phoneQk", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((ThirdLogin)obj).tourist);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).tourist = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "tourist";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("tourist", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((ThirdLogin)obj).accLogin);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).accLogin = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "accLogin";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("accLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((ThirdLogin)obj).accReg);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).accReg = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "accReg";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("accReg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((ThirdLogin)obj).apple);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).apple = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "apple";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("apple", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((ThirdLogin)obj).qrLogin);
			jsonPropertyInfoValues9.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).qrLogin = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "qrLogin";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("qrLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo9);
			array[8].IsGetNullable = false;
			array[8].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((ThirdLogin)obj).emailLogin);
			jsonPropertyInfoValues10.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).emailLogin = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "emailLogin";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("emailLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo10);
			array[9].IsGetNullable = false;
			array[9].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((ThirdLogin)obj).emailReg);
			jsonPropertyInfoValues11.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).emailReg = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "emailReg";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("emailReg", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo11);
			array[10].IsGetNullable = false;
			array[10].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((ThirdLogin)obj).fbLogin);
			jsonPropertyInfoValues12.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).fbLogin = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "fbLogin";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("fbLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo12);
			array[11].IsGetNullable = false;
			array[11].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((ThirdLogin)obj).gcLogin);
			jsonPropertyInfoValues13.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).gcLogin = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "gcLogin";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("gcLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo13);
			array[12].IsGetNullable = false;
			array[12].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((ThirdLogin)obj).googleLogin);
			jsonPropertyInfoValues14.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).googleLogin = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "googleLogin";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("googleLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo14);
			array[13].IsGetNullable = false;
			array[13].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues15 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues15.IsProperty = false;
			jsonPropertyInfoValues15.IsPublic = true;
			jsonPropertyInfoValues15.IsVirtual = false;
			jsonPropertyInfoValues15.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues15.Converter = null;
			jsonPropertyInfoValues15.Getter = ((object obj) => ((ThirdLogin)obj).lineLogin);
			jsonPropertyInfoValues15.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).lineLogin = value;
			};
			jsonPropertyInfoValues15.IgnoreCondition = null;
			jsonPropertyInfoValues15.HasJsonInclude = false;
			jsonPropertyInfoValues15.IsExtensionData = false;
			jsonPropertyInfoValues15.NumberHandling = null;
			jsonPropertyInfoValues15.PropertyName = "lineLogin";
			jsonPropertyInfoValues15.JsonPropertyName = null;
			jsonPropertyInfoValues15.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("lineLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo15 = jsonPropertyInfoValues15;
			array[14] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo15);
			array[14].IsGetNullable = false;
			array[14].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues16 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues16.IsProperty = false;
			jsonPropertyInfoValues16.IsPublic = true;
			jsonPropertyInfoValues16.IsVirtual = false;
			jsonPropertyInfoValues16.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues16.Converter = null;
			jsonPropertyInfoValues16.Getter = ((object obj) => ((ThirdLogin)obj).twitterLogin);
			jsonPropertyInfoValues16.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).twitterLogin = value;
			};
			jsonPropertyInfoValues16.IgnoreCondition = null;
			jsonPropertyInfoValues16.HasJsonInclude = false;
			jsonPropertyInfoValues16.IsExtensionData = false;
			jsonPropertyInfoValues16.NumberHandling = null;
			jsonPropertyInfoValues16.PropertyName = "twitterLogin";
			jsonPropertyInfoValues16.JsonPropertyName = null;
			jsonPropertyInfoValues16.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("twitterLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo16 = jsonPropertyInfoValues16;
			array[15] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo16);
			array[15].IsGetNullable = false;
			array[15].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues17 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues17.IsProperty = false;
			jsonPropertyInfoValues17.IsPublic = true;
			jsonPropertyInfoValues17.IsVirtual = false;
			jsonPropertyInfoValues17.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues17.Converter = null;
			jsonPropertyInfoValues17.Getter = ((object obj) => ((ThirdLogin)obj).naverLogin);
			jsonPropertyInfoValues17.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).naverLogin = value;
			};
			jsonPropertyInfoValues17.IgnoreCondition = null;
			jsonPropertyInfoValues17.HasJsonInclude = false;
			jsonPropertyInfoValues17.IsExtensionData = false;
			jsonPropertyInfoValues17.NumberHandling = null;
			jsonPropertyInfoValues17.PropertyName = "naverLogin";
			jsonPropertyInfoValues17.JsonPropertyName = null;
			jsonPropertyInfoValues17.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("naverLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo17 = jsonPropertyInfoValues17;
			array[16] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo17);
			array[16].IsGetNullable = false;
			array[16].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues18 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues18.IsProperty = false;
			jsonPropertyInfoValues18.IsPublic = true;
			jsonPropertyInfoValues18.IsVirtual = false;
			jsonPropertyInfoValues18.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues18.Converter = null;
			jsonPropertyInfoValues18.Getter = ((object obj) => ((ThirdLogin)obj).psnLogin);
			jsonPropertyInfoValues18.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).psnLogin = value;
			};
			jsonPropertyInfoValues18.IgnoreCondition = null;
			jsonPropertyInfoValues18.HasJsonInclude = false;
			jsonPropertyInfoValues18.IsExtensionData = false;
			jsonPropertyInfoValues18.NumberHandling = null;
			jsonPropertyInfoValues18.PropertyName = "psnLogin";
			jsonPropertyInfoValues18.JsonPropertyName = null;
			jsonPropertyInfoValues18.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("psnLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo18 = jsonPropertyInfoValues18;
			array[17] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo18);
			array[17].IsGetNullable = false;
			array[17].IsSetNullable = false;
			JsonPropertyInfoValues<LoginElement> jsonPropertyInfoValues19 = new JsonPropertyInfoValues<LoginElement>();
			jsonPropertyInfoValues19.IsProperty = false;
			jsonPropertyInfoValues19.IsPublic = true;
			jsonPropertyInfoValues19.IsVirtual = false;
			jsonPropertyInfoValues19.DeclaringType = typeof(ThirdLogin);
			jsonPropertyInfoValues19.Converter = null;
			jsonPropertyInfoValues19.Getter = ((object obj) => ((ThirdLogin)obj).psnEmailLogin);
			jsonPropertyInfoValues19.Setter = delegate(object obj, [Nullable(2)] LoginElement value)
			{
				((ThirdLogin)obj).psnEmailLogin = value;
			};
			jsonPropertyInfoValues19.IgnoreCondition = null;
			jsonPropertyInfoValues19.HasJsonInclude = false;
			jsonPropertyInfoValues19.IsExtensionData = false;
			jsonPropertyInfoValues19.NumberHandling = null;
			jsonPropertyInfoValues19.PropertyName = "psnEmailLogin";
			jsonPropertyInfoValues19.JsonPropertyName = null;
			jsonPropertyInfoValues19.AttributeProviderFactory = (() => typeof(ThirdLogin).GetField("psnEmailLogin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<LoginElement> propertyInfo19 = jsonPropertyInfoValues19;
			array[18] = JsonMetadataServices.CreatePropertyInfo<LoginElement>(options, propertyInfo19);
			array[18].IsGetNullable = false;
			array[18].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x000262E4 File Offset: 0x000244E4
		public JsonTypeInfo<ThirdShareParams> ThirdShareParams
		{
			get
			{
				JsonTypeInfo<ThirdShareParams> result;
				if ((result = this._ThirdShareParams) == null)
				{
					result = (this._ThirdShareParams = (JsonTypeInfo<ThirdShareParams>)base.Options.GetTypeInfo(typeof(ThirdShareParams)));
				}
				return result;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00026320 File Offset: 0x00024520
		[NullableContext(1)]
		private JsonTypeInfo<ThirdShareParams> Create_ThirdShareParams(JsonSerializerOptions options)
		{
			JsonTypeInfo<ThirdShareParams> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ThirdShareParams>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ThirdShareParams> jsonObjectInfoValues = new JsonObjectInfoValues<ThirdShareParams>();
				jsonObjectInfoValues.ObjectCreator = (() => new ThirdShareParams());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ThirdShareParamsPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ThirdShareParams).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ThirdShareParams> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ThirdShareParams>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000263E8 File Offset: 0x000245E8
		[NullableContext(1)]
		private static JsonPropertyInfo[] ThirdShareParamsPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[7];
			JsonPropertyInfoValues<QQParam> jsonPropertyInfoValues = new JsonPropertyInfoValues<QQParam>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ThirdShareParams)obj).qq);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] QQParam value)
			{
				((ThirdShareParams)obj).qq = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "qq";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("qq", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(QQParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<QQParam> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<QQParam>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<WeChatParam> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<WeChatParam>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ThirdShareParams)obj).wechat);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] WeChatParam value)
			{
				((ThirdShareParams)obj).wechat = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "wechat";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("wechat", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(WeChatParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<WeChatParam> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<WeChatParam>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<BilibiliParam> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<BilibiliParam>();
			jsonPropertyInfoValues3.IsProperty = true;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ThirdShareParams)obj).bilibili);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] BilibiliParam value)
			{
				((ThirdShareParams)obj).bilibili = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "bilibili";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("bilibili", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(BilibiliParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<BilibiliParam> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<BilibiliParam>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<DouyinParam> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<DouyinParam>();
			jsonPropertyInfoValues4.IsProperty = true;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ThirdShareParams)obj).douyin);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] DouyinParam value)
			{
				((ThirdShareParams)obj).douyin = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "douyin";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("douyin", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(DouyinParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<DouyinParam> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<DouyinParam>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<WeiboParam> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<WeiboParam>();
			jsonPropertyInfoValues5.IsProperty = true;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((ThirdShareParams)obj).weibo);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] WeiboParam value)
			{
				((ThirdShareParams)obj).weibo = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "weibo";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("weibo", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(WeiboParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<WeiboParam> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<WeiboParam>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<KujiequParam> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<KujiequParam>();
			jsonPropertyInfoValues6.IsProperty = true;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((ThirdShareParams)obj).kujiequ);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] KujiequParam value)
			{
				((ThirdShareParams)obj).kujiequ = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "kujiequ";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("kujiequ", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(KujiequParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<KujiequParam> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<KujiequParam>(options, propertyInfo6);
			array[5].IsGetNullable = false;
			array[5].IsSetNullable = false;
			JsonPropertyInfoValues<ShareSDKParam> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<ShareSDKParam>();
			jsonPropertyInfoValues7.IsProperty = true;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(ThirdShareParams);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((ThirdShareParams)obj).sharesdk);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(2)] ShareSDKParam value)
			{
				((ThirdShareParams)obj).sharesdk = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "sharesdk";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(ThirdShareParams).GetProperty("sharesdk", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(ShareSDKParam), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<ShareSDKParam> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<ShareSDKParam>(options, propertyInfo7);
			array[6].IsGetNullable = false;
			array[6].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00026AEC File Offset: 0x00024CEC
		public JsonTypeInfo<WeChatParam> WeChatParam
		{
			get
			{
				JsonTypeInfo<WeChatParam> result;
				if ((result = this._WeChatParam) == null)
				{
					result = (this._WeChatParam = (JsonTypeInfo<WeChatParam>)base.Options.GetTypeInfo(typeof(WeChatParam)));
				}
				return result;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00026B28 File Offset: 0x00024D28
		[NullableContext(1)]
		private JsonTypeInfo<WeChatParam> Create_WeChatParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<WeChatParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<WeChatParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<WeChatParam> jsonObjectInfoValues = new JsonObjectInfoValues<WeChatParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new WeChatParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.WeChatParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(WeChatParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<WeChatParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<WeChatParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00026BF0 File Offset: 0x00024DF0
		[NullableContext(1)]
		private static JsonPropertyInfo[] WeChatParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(WeChatParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((WeChatParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((WeChatParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(WeChatParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(WeChatParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((WeChatParam)obj).appSecret);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((WeChatParam)obj).appSecret = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appSecret";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(WeChatParam).GetProperty("appSecret", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00026DFC File Offset: 0x00024FFC
		public JsonTypeInfo<WeiboParam> WeiboParam
		{
			get
			{
				JsonTypeInfo<WeiboParam> result;
				if ((result = this._WeiboParam) == null)
				{
					result = (this._WeiboParam = (JsonTypeInfo<WeiboParam>)base.Options.GetTypeInfo(typeof(WeiboParam)));
				}
				return result;
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00026E38 File Offset: 0x00025038
		[NullableContext(1)]
		private JsonTypeInfo<WeiboParam> Create_WeiboParam(JsonSerializerOptions options)
		{
			JsonTypeInfo<WeiboParam> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<WeiboParam>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<WeiboParam> jsonObjectInfoValues = new JsonObjectInfoValues<WeiboParam>();
				jsonObjectInfoValues.ObjectCreator = (() => new WeiboParam());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.WeiboParamPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(WeiboParam).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<WeiboParam> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<WeiboParam>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00026F00 File Offset: 0x00025100
		[NullableContext(1)]
		private static JsonPropertyInfo[] WeiboParamPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[2];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = true;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(WeiboParam);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((WeiboParam)obj).appId);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((WeiboParam)obj).appId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "appId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(WeiboParam).GetProperty("appId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = true;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(WeiboParam);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((WeiboParam)obj).appKey);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((WeiboParam)obj).appKey = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "appKey";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(WeiboParam).GetProperty("appKey", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeof(string), Array.Empty<Type>(), null));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0002710C File Offset: 0x0002530C
		public JsonTypeInfo<PreDownloadConfig> PreDownloadConfig
		{
			get
			{
				JsonTypeInfo<PreDownloadConfig> result;
				if ((result = this._PreDownloadConfig) == null)
				{
					result = (this._PreDownloadConfig = (JsonTypeInfo<PreDownloadConfig>)base.Options.GetTypeInfo(typeof(PreDownloadConfig)));
				}
				return result;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00027148 File Offset: 0x00025348
		[NullableContext(1)]
		private JsonTypeInfo<PreDownloadConfig> Create_PreDownloadConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<PreDownloadConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<PreDownloadConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<PreDownloadConfig> jsonObjectInfoValues = new JsonObjectInfoValues<PreDownloadConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new PreDownloadConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.PreDownloadConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(PreDownloadConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<PreDownloadConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<PreDownloadConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00027210 File Offset: 0x00025410
		[NullableContext(1)]
		private static JsonPropertyInfo[] PreDownloadConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(PreDownloadConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((PreDownloadConfig)obj).MixUri);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((PreDownloadConfig)obj).MixUri = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "MixUri";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(PreDownloadConfig).GetField("MixUri", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(PreDownloadConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((PreDownloadConfig)obj).ResUri);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((PreDownloadConfig)obj).ResUri = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "ResUri";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(PreDownloadConfig).GetField("ResUri", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(PreDownloadConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((PreDownloadConfig)obj).ModifyTime);
			jsonPropertyInfoValues3.Setter = delegate(object obj, int value)
			{
				((PreDownloadConfig)obj).ModifyTime = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "ModifyTime";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(PreDownloadConfig).GetField("ModifyTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo3);
			return array;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00027508 File Offset: 0x00025708
		public JsonTypeInfo<RemoteConfig> RemoteConfig
		{
			get
			{
				JsonTypeInfo<RemoteConfig> result;
				if ((result = this._RemoteConfig) == null)
				{
					result = (this._RemoteConfig = (JsonTypeInfo<RemoteConfig>)base.Options.GetTypeInfo(typeof(RemoteConfig)));
				}
				return result;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00027544 File Offset: 0x00025744
		[NullableContext(1)]
		private JsonTypeInfo<RemoteConfig> Create_RemoteConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<RemoteConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RemoteConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RemoteConfig> jsonObjectInfoValues = new JsonObjectInfoValues<RemoteConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new RemoteConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.RemoteConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RemoteConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RemoteConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RemoteConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0002760C File Offset: 0x0002580C
		[NullableContext(1)]
		private static JsonPropertyInfo[] RemoteConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[9];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RemoteConfig)obj).PackageVersion);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteConfig)obj).PackageVersion = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PackageVersion";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("PackageVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((RemoteConfig)obj).LauncherPackageVersion);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteConfig)obj).LauncherPackageVersion = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "LauncherPackageVersion";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("LauncherPackageVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((RemoteConfig)obj).LauncherVersion);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteConfig)obj).LauncherVersion = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "LauncherVersion";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("LauncherVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((RemoteConfig)obj).ResourceVersion);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteConfig)obj).ResourceVersion = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "ResourceVersion";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("ResourceVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((RemoteConfig)obj).ChangeList);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteConfig)obj).ChangeList = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "ChangeList";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("ChangeList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			JsonPropertyInfoValues<long?> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<long?>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((RemoteConfig)obj).UpdateTime);
			jsonPropertyInfoValues6.Setter = delegate(object obj, long? value)
			{
				((RemoteConfig)obj).UpdateTime = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "UpdateTime";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("UpdateTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long?> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<long?>(options, propertyInfo6);
			JsonPropertyInfoValues<Dictionary<string, string>> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<Dictionary<string, string>>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((RemoteConfig)obj).LauncherIndexSha1);
			jsonPropertyInfoValues7.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, string> value)
			{
				((RemoteConfig)obj).LauncherIndexSha1 = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "LauncherIndexSha1";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("LauncherIndexSha1", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, string>> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, string>>(options, propertyInfo7);
			JsonPropertyInfoValues<Dictionary<string, string>> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<Dictionary<string, string>>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((RemoteConfig)obj).ResourceIndexSha1);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, string> value)
			{
				((RemoteConfig)obj).ResourceIndexSha1 = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "ResourceIndexSha1";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("ResourceIndexSha1", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, string>> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, string>>(options, propertyInfo8);
			JsonPropertyInfoValues<List<VersionItem>> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<List<VersionItem>>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(RemoteConfig);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((RemoteConfig)obj).Versions);
			jsonPropertyInfoValues9.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<VersionItem> value)
			{
				((RemoteConfig)obj).Versions = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "Versions";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(RemoteConfig).GetField("Versions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<VersionItem>> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<List<VersionItem>>(options, propertyInfo9);
			return array;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00027EC8 File Offset: 0x000260C8
		public JsonTypeInfo<RemoteVersionConfig> RemoteVersionConfig
		{
			get
			{
				JsonTypeInfo<RemoteVersionConfig> result;
				if ((result = this._RemoteVersionConfig) == null)
				{
					result = (this._RemoteVersionConfig = (JsonTypeInfo<RemoteVersionConfig>)base.Options.GetTypeInfo(typeof(RemoteVersionConfig)));
				}
				return result;
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00027F04 File Offset: 0x00026104
		[NullableContext(1)]
		private JsonTypeInfo<RemoteVersionConfig> Create_RemoteVersionConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<RemoteVersionConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<RemoteVersionConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<RemoteVersionConfig> jsonObjectInfoValues = new JsonObjectInfoValues<RemoteVersionConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new RemoteVersionConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.RemoteVersionConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(RemoteVersionConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<RemoteVersionConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<RemoteVersionConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00027FCC File Offset: 0x000261CC
		[NullableContext(1)]
		private static JsonPropertyInfo[] RemoteVersionConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(RemoteVersionConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((RemoteVersionConfig)obj).PackageVersion);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteVersionConfig)obj).PackageVersion = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "PackageVersion";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(RemoteVersionConfig).GetField("PackageVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(RemoteVersionConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((RemoteVersionConfig)obj).LauncherPackageVersion);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteVersionConfig)obj).LauncherPackageVersion = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "LauncherPackageVersion";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(RemoteVersionConfig).GetField("LauncherPackageVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(RemoteVersionConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((RemoteVersionConfig)obj).ChangeList);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((RemoteVersionConfig)obj).ChangeList = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "ChangeList";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(RemoteVersionConfig).GetField("ChangeList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<long?> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<long?>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(RemoteVersionConfig);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((RemoteVersionConfig)obj).UpdateTime);
			jsonPropertyInfoValues4.Setter = delegate(object obj, long? value)
			{
				((RemoteVersionConfig)obj).UpdateTime = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "UpdateTime";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(RemoteVersionConfig).GetField("UpdateTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long?> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<long?>(options, propertyInfo4);
			JsonPropertyInfoValues<Dictionary<string, VersionItem>> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<Dictionary<string, VersionItem>>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(RemoteVersionConfig);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((RemoteVersionConfig)obj).ResVersions);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, VersionItem> value)
			{
				((RemoteVersionConfig)obj).ResVersions = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "ResVersions";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(RemoteVersionConfig).GetField("ResVersions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, VersionItem>> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, VersionItem>>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			return array;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000284C0 File Offset: 0x000266C0
		public JsonTypeInfo<LoginPlayerInfo> LoginPlayerInfo
		{
			get
			{
				JsonTypeInfo<LoginPlayerInfo> result;
				if ((result = this._LoginPlayerInfo) == null)
				{
					result = (this._LoginPlayerInfo = (JsonTypeInfo<LoginPlayerInfo>)base.Options.GetTypeInfo(typeof(LoginPlayerInfo)));
				}
				return result;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000284FC File Offset: 0x000266FC
		[NullableContext(1)]
		private JsonTypeInfo<LoginPlayerInfo> Create_LoginPlayerInfo(JsonSerializerOptions options)
		{
			JsonTypeInfo<LoginPlayerInfo> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<LoginPlayerInfo>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<LoginPlayerInfo> jsonObjectInfoValues = new JsonObjectInfoValues<LoginPlayerInfo>();
				jsonObjectInfoValues.ObjectCreator = (() => new LoginPlayerInfo());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.LoginPlayerInfoPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(LoginPlayerInfo).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<LoginPlayerInfo> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<LoginPlayerInfo>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000285C4 File Offset: 0x000267C4
		[NullableContext(1)]
		private static JsonPropertyInfo[] LoginPlayerInfoPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(LoginPlayerInfo);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((LoginPlayerInfo)obj).Code);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((LoginPlayerInfo)obj).Code = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Code";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(LoginPlayerInfo).GetField("Code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(LoginPlayerInfo);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((LoginPlayerInfo)obj).SdkLoginCode);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((LoginPlayerInfo)obj).SdkLoginCode = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "SdkLoginCode";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(LoginPlayerInfo).GetField("SdkLoginCode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(LoginPlayerInfo);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((LoginPlayerInfo)obj).UserId);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((LoginPlayerInfo)obj).UserId = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "UserId";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(LoginPlayerInfo).GetField("UserId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<List<UserRegionInfo>> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<List<UserRegionInfo>>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(LoginPlayerInfo);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((LoginPlayerInfo)obj).UserInfos);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<UserRegionInfo> value)
			{
				((LoginPlayerInfo)obj).UserInfos = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "UserInfos";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(LoginPlayerInfo).GetField("UserInfos", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<UserRegionInfo>> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<List<UserRegionInfo>>(options, propertyInfo4);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(LoginPlayerInfo);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((LoginPlayerInfo)obj).RecommendRegion);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((LoginPlayerInfo)obj).RecommendRegion = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "RecommendRegion";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(LoginPlayerInfo).GetField("RecommendRegion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo5);
			array[4].IsGetNullable = false;
			array[4].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00028A94 File Offset: 0x00026C94
		public JsonTypeInfo<UserRegionInfo> UserRegionInfo
		{
			get
			{
				JsonTypeInfo<UserRegionInfo> result;
				if ((result = this._UserRegionInfo) == null)
				{
					result = (this._UserRegionInfo = (JsonTypeInfo<UserRegionInfo>)base.Options.GetTypeInfo(typeof(UserRegionInfo)));
				}
				return result;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00028AD0 File Offset: 0x00026CD0
		[NullableContext(1)]
		private JsonTypeInfo<UserRegionInfo> Create_UserRegionInfo(JsonSerializerOptions options)
		{
			JsonTypeInfo<UserRegionInfo> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<UserRegionInfo>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<UserRegionInfo> jsonObjectInfoValues = new JsonObjectInfoValues<UserRegionInfo>();
				jsonObjectInfoValues.ObjectCreator = (() => new UserRegionInfo());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.UserRegionInfoPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(UserRegionInfo).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<UserRegionInfo> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<UserRegionInfo>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00028B98 File Offset: 0x00026D98
		[NullableContext(1)]
		private static JsonPropertyInfo[] UserRegionInfoPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(UserRegionInfo);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((UserRegionInfo)obj).Region);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((UserRegionInfo)obj).Region = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Region";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(UserRegionInfo).GetField("Region", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(UserRegionInfo);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((UserRegionInfo)obj).Level);
			jsonPropertyInfoValues2.Setter = delegate(object obj, int value)
			{
				((UserRegionInfo)obj).Level = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Level";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(UserRegionInfo).GetField("Level", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo2);
			JsonPropertyInfoValues<long> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(UserRegionInfo);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((UserRegionInfo)obj).LastOnlineTime);
			jsonPropertyInfoValues3.Setter = delegate(object obj, long value)
			{
				((UserRegionInfo)obj).LastOnlineTime = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "LastOnlineTime";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(UserRegionInfo).GetField("LastOnlineTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo3);
			return array;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00028E7C File Offset: 0x0002707C
		public JsonTypeInfo<HttpSubPackageResult> HttpSubPackageResult
		{
			get
			{
				JsonTypeInfo<HttpSubPackageResult> result;
				if ((result = this._HttpSubPackageResult) == null)
				{
					result = (this._HttpSubPackageResult = (JsonTypeInfo<HttpSubPackageResult>)base.Options.GetTypeInfo(typeof(HttpSubPackageResult)));
				}
				return result;
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00028EB8 File Offset: 0x000270B8
		[NullableContext(1)]
		private JsonTypeInfo<HttpSubPackageResult> Create_HttpSubPackageResult(JsonSerializerOptions options)
		{
			JsonTypeInfo<HttpSubPackageResult> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<HttpSubPackageResult>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<HttpSubPackageResult> jsonObjectInfoValues = new JsonObjectInfoValues<HttpSubPackageResult>();
				jsonObjectInfoValues.ObjectCreator = (() => new HttpSubPackageResult());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.HttpSubPackageResultPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<HttpSubPackageResult> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<HttpSubPackageResult>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00028F80 File Offset: 0x00027180
		[NullableContext(1)]
		private static JsonPropertyInfo[] HttpSubPackageResultPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[9];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((HttpSubPackageResult)obj).code);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((HttpSubPackageResult)obj).code = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues.PropertyName = "code";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<long> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((HttpSubPackageResult)obj).userId);
			jsonPropertyInfoValues2.Setter = delegate(object obj, long value)
			{
				((HttpSubPackageResult)obj).userId = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues2.PropertyName = "userId";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("userId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo2);
			JsonPropertyInfoValues<List<int>> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<List<int>>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((HttpSubPackageResult)obj).needConfirmQuestIdSet);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] List<int> value)
			{
				((HttpSubPackageResult)obj).needConfirmQuestIdSet = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues3.PropertyName = "needConfirmQuestIdSet";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("needConfirmQuestIdSet", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<int>> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<List<int>>(options, propertyInfo3);
			JsonPropertyInfoValues<List<int>> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<List<int>>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((HttpSubPackageResult)obj).finishQuestIdSet);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(2)] List<int> value)
			{
				((HttpSubPackageResult)obj).finishQuestIdSet = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues4.PropertyName = "finishQuestIdSet";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("finishQuestIdSet", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<int>> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<List<int>>(options, propertyInfo4);
			JsonPropertyInfoValues<List<int>> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<List<int>>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((HttpSubPackageResult)obj).currentBlockIdSet);
			jsonPropertyInfoValues5.Setter = delegate(object obj, [Nullable(2)] List<int> value)
			{
				((HttpSubPackageResult)obj).currentBlockIdSet = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues5.PropertyName = "currentBlockIdSet";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("currentBlockIdSet", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<int>> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<List<int>>(options, propertyInfo5);
			JsonPropertyInfoValues<List<uint>> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<List<uint>>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((HttpSubPackageResult)obj).mp4FinishQuestFlag);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] List<uint> value)
			{
				((HttpSubPackageResult)obj).mp4FinishQuestFlag = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues6.PropertyName = "mp4FinishQuestFlag";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("mp4FinishQuestFlag", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<uint>> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<List<uint>>(options, propertyInfo6);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((HttpSubPackageResult)obj).sex);
			jsonPropertyInfoValues7.Setter = delegate(object obj, int value)
			{
				((HttpSubPackageResult)obj).sex = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues7.PropertyName = "sex";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("sex", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo7);
			JsonPropertyInfoValues<List<ResourcePackagePositionData>> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<List<ResourcePackagePositionData>>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((HttpSubPackageResult)obj).positions);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<ResourcePackagePositionData> value)
			{
				((HttpSubPackageResult)obj).positions = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "positions";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("positions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<ResourcePackagePositionData>> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<List<ResourcePackagePositionData>>(options, propertyInfo8);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(HttpSubPackageResult);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((HttpSubPackageResult)obj).curRecallId);
			jsonPropertyInfoValues9.Setter = delegate(object obj, int value)
			{
				((HttpSubPackageResult)obj).curRecallId = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "curRecallId";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(HttpSubPackageResult).GetField("curRecallId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo9);
			return array;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000297C8 File Offset: 0x000279C8
		public JsonTypeInfo<ResourcePackagePositionData> ResourcePackagePositionData
		{
			get
			{
				JsonTypeInfo<ResourcePackagePositionData> result;
				if ((result = this._ResourcePackagePositionData) == null)
				{
					result = (this._ResourcePackagePositionData = (JsonTypeInfo<ResourcePackagePositionData>)base.Options.GetTypeInfo(typeof(ResourcePackagePositionData)));
				}
				return result;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00029804 File Offset: 0x00027A04
		[NullableContext(1)]
		private JsonTypeInfo<ResourcePackagePositionData> Create_ResourcePackagePositionData(JsonSerializerOptions options)
		{
			JsonTypeInfo<ResourcePackagePositionData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ResourcePackagePositionData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ResourcePackagePositionData> jsonObjectInfoValues = new JsonObjectInfoValues<ResourcePackagePositionData>();
				jsonObjectInfoValues.ObjectCreator = (() => new ResourcePackagePositionData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ResourcePackagePositionDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ResourcePackagePositionData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ResourcePackagePositionData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ResourcePackagePositionData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000298CC File Offset: 0x00027ACC
		[NullableContext(1)]
		private static JsonPropertyInfo[] ResourcePackagePositionDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ResourcePackagePositionData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ResourcePackagePositionData)obj).instanceId);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((ResourcePackagePositionData)obj).instanceId = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues.PropertyName = "instanceId";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ResourcePackagePositionData).GetField("instanceId", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(ResourcePackagePositionData);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((ResourcePackagePositionData)obj).x);
			jsonPropertyInfoValues2.Setter = delegate(object obj, double value)
			{
				((ResourcePackagePositionData)obj).x = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues2.PropertyName = "x";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(ResourcePackagePositionData).GetField("x", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo2);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(ResourcePackagePositionData);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((ResourcePackagePositionData)obj).y);
			jsonPropertyInfoValues3.Setter = delegate(object obj, double value)
			{
				((ResourcePackagePositionData)obj).y = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues3.PropertyName = "y";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(ResourcePackagePositionData).GetField("y", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo3);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(ResourcePackagePositionData);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((ResourcePackagePositionData)obj).z);
			jsonPropertyInfoValues4.Setter = delegate(object obj, double value)
			{
				((ResourcePackagePositionData)obj).z = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = new JsonNumberHandling?(JsonNumberHandling.AllowReadingFromString);
			jsonPropertyInfoValues4.PropertyName = "z";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(ResourcePackagePositionData).GetField("z", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo4);
			return array;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00029C7C File Offset: 0x00027E7C
		public JsonTypeInfo<PakListConfig> PakListConfig
		{
			get
			{
				JsonTypeInfo<PakListConfig> result;
				if ((result = this._PakListConfig) == null)
				{
					result = (this._PakListConfig = (JsonTypeInfo<PakListConfig>)base.Options.GetTypeInfo(typeof(PakListConfig)));
				}
				return result;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00029CB8 File Offset: 0x00027EB8
		[NullableContext(1)]
		private JsonTypeInfo<PakListConfig> Create_PakListConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<PakListConfig> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<PakListConfig>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<PakListConfig> jsonObjectInfoValues = new JsonObjectInfoValues<PakListConfig>();
				jsonObjectInfoValues.ObjectCreator = (() => new PakListConfig());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.PakListConfigPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(PakListConfig).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<PakListConfig> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<PakListConfig>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00029D80 File Offset: 0x00027F80
		[NullableContext(1)]
		private static JsonPropertyInfo[] PakListConfigPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[4];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(PakListConfig);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((PakListConfig)obj).Hash);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((PakListConfig)obj).Hash = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Hash";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(PakListConfig).GetField("Hash", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(PakListConfig);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((PakListConfig)obj).Random);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((PakListConfig)obj).Random = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Random";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(PakListConfig).GetField("Random", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(PakListConfig);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((PakListConfig)obj).Key);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((PakListConfig)obj).Key = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "Key";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(PakListConfig).GetField("Key", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(PakListConfig);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((PakListConfig)obj).UpdateTime);
			jsonPropertyInfoValues4.Setter = delegate(object obj, int value)
			{
				((PakListConfig)obj).UpdateTime = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "UpdateTime";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(PakListConfig).GetField("UpdateTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo4);
			return array;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0002A178 File Offset: 0x00028378
		public JsonTypeInfo<VersionItem> VersionItem
		{
			get
			{
				JsonTypeInfo<VersionItem> result;
				if ((result = this._VersionItem) == null)
				{
					result = (this._VersionItem = (JsonTypeInfo<VersionItem>)base.Options.GetTypeInfo(typeof(VersionItem)));
				}
				return result;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0002A1B4 File Offset: 0x000283B4
		[NullableContext(1)]
		private JsonTypeInfo<VersionItem> Create_VersionItem(JsonSerializerOptions options)
		{
			JsonTypeInfo<VersionItem> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<VersionItem>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<VersionItem> jsonObjectInfoValues = new JsonObjectInfoValues<VersionItem>();
				jsonObjectInfoValues.ObjectCreator = (() => new VersionItem());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.VersionItemPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(VersionItem).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<VersionItem> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<VersionItem>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0002A27C File Offset: 0x0002847C
		[NullableContext(1)]
		private static JsonPropertyInfo[] VersionItemPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[3];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(VersionItem);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((VersionItem)obj).Name);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((VersionItem)obj).Name = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Name";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(VersionItem).GetField("Name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(VersionItem);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((VersionItem)obj).Version);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((VersionItem)obj).Version = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "Version";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(VersionItem).GetField("Version", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<Dictionary<string, string>> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<Dictionary<string, string>>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(VersionItem);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((VersionItem)obj).IndexSha1);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, string> value)
			{
				((VersionItem)obj).IndexSha1 = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "IndexSha1";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(VersionItem).GetField("IndexSha1", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<Dictionary<string, string>> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<Dictionary<string, string>>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0002A584 File Offset: 0x00028784
		public JsonTypeInfo<HttpResult> HttpResult
		{
			get
			{
				JsonTypeInfo<HttpResult> result;
				if ((result = this._HttpResult) == null)
				{
					result = (this._HttpResult = (JsonTypeInfo<HttpResult>)base.Options.GetTypeInfo(typeof(HttpResult)));
				}
				return result;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002A5C0 File Offset: 0x000287C0
		[NullableContext(1)]
		private JsonTypeInfo<HttpResult> Create_HttpResult(JsonSerializerOptions options)
		{
			JsonTypeInfo<HttpResult> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<HttpResult>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<HttpResult> jsonObjectInfoValues = new JsonObjectInfoValues<HttpResult>();
				jsonObjectInfoValues.ObjectCreator = (() => new HttpResult());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.HttpResultPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(HttpResult).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<HttpResult> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<HttpResult>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0002A688 File Offset: 0x00028888
		[NullableContext(1)]
		private static JsonPropertyInfo[] HttpResultPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[14];
			JsonPropertyInfoValues<int> jsonPropertyInfoValues = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((HttpResult)obj).code);
			jsonPropertyInfoValues.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).code = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "code";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(HttpResult).GetField("code", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((HttpResult)obj).token);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((HttpResult)obj).token = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "token";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(HttpResult).GetField("token", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<List<NetHostInfo>> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<List<NetHostInfo>>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((HttpResult)obj).udpHosts);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<NetHostInfo> value)
			{
				((HttpResult)obj).udpHosts = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "udpHosts";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(HttpResult).GetField("udpHosts", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<NetHostInfo>> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<List<NetHostInfo>>(options, propertyInfo3);
			array[2].IsGetNullable = false;
			array[2].IsSetNullable = false;
			JsonPropertyInfoValues<List<NetHostInfo>> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<List<NetHostInfo>>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((HttpResult)obj).tcpHosts);
			jsonPropertyInfoValues4.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] List<NetHostInfo> value)
			{
				((HttpResult)obj).tcpHosts = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "tcpHosts";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(HttpResult).GetField("tcpHosts", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<List<NetHostInfo>> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<List<NetHostInfo>>(options, propertyInfo4);
			array[3].IsGetNullable = false;
			array[3].IsSetNullable = false;
			JsonPropertyInfoValues<int> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((HttpResult)obj).tcpRatio);
			jsonPropertyInfoValues5.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).tcpRatio = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "tcpRatio";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(HttpResult).GetField("tcpRatio", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo5);
			JsonPropertyInfoValues<GatewayLatencyConfigVo> jsonPropertyInfoValues6 = new JsonPropertyInfoValues<GatewayLatencyConfigVo>();
			jsonPropertyInfoValues6.IsProperty = false;
			jsonPropertyInfoValues6.IsPublic = true;
			jsonPropertyInfoValues6.IsVirtual = false;
			jsonPropertyInfoValues6.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues6.Converter = null;
			jsonPropertyInfoValues6.Getter = ((object obj) => ((HttpResult)obj).gatewayLatencyConfig);
			jsonPropertyInfoValues6.Setter = delegate(object obj, [Nullable(2)] GatewayLatencyConfigVo value)
			{
				((HttpResult)obj).gatewayLatencyConfig = value;
			};
			jsonPropertyInfoValues6.IgnoreCondition = null;
			jsonPropertyInfoValues6.HasJsonInclude = false;
			jsonPropertyInfoValues6.IsExtensionData = false;
			jsonPropertyInfoValues6.NumberHandling = null;
			jsonPropertyInfoValues6.PropertyName = "gatewayLatencyConfig";
			jsonPropertyInfoValues6.JsonPropertyName = null;
			jsonPropertyInfoValues6.AttributeProviderFactory = (() => typeof(HttpResult).GetField("gatewayLatencyConfig", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<GatewayLatencyConfigVo> propertyInfo6 = jsonPropertyInfoValues6;
			array[5] = JsonMetadataServices.CreatePropertyInfo<GatewayLatencyConfigVo>(options, propertyInfo6);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues7 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues7.IsProperty = false;
			jsonPropertyInfoValues7.IsPublic = true;
			jsonPropertyInfoValues7.IsVirtual = false;
			jsonPropertyInfoValues7.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues7.Converter = null;
			jsonPropertyInfoValues7.Getter = ((object obj) => ((HttpResult)obj).userData);
			jsonPropertyInfoValues7.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).userData = value;
			};
			jsonPropertyInfoValues7.IgnoreCondition = null;
			jsonPropertyInfoValues7.HasJsonInclude = false;
			jsonPropertyInfoValues7.IsExtensionData = false;
			jsonPropertyInfoValues7.NumberHandling = null;
			jsonPropertyInfoValues7.PropertyName = "userData";
			jsonPropertyInfoValues7.JsonPropertyName = null;
			jsonPropertyInfoValues7.AttributeProviderFactory = (() => typeof(HttpResult).GetField("userData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo7 = jsonPropertyInfoValues7;
			array[6] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo7);
			JsonPropertyInfoValues<string> jsonPropertyInfoValues8 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues8.IsProperty = false;
			jsonPropertyInfoValues8.IsPublic = true;
			jsonPropertyInfoValues8.IsVirtual = false;
			jsonPropertyInfoValues8.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues8.Converter = null;
			jsonPropertyInfoValues8.Getter = ((object obj) => ((HttpResult)obj).errMessage);
			jsonPropertyInfoValues8.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((HttpResult)obj).errMessage = value;
			};
			jsonPropertyInfoValues8.IgnoreCondition = null;
			jsonPropertyInfoValues8.HasJsonInclude = false;
			jsonPropertyInfoValues8.IsExtensionData = false;
			jsonPropertyInfoValues8.NumberHandling = null;
			jsonPropertyInfoValues8.PropertyName = "errMessage";
			jsonPropertyInfoValues8.JsonPropertyName = null;
			jsonPropertyInfoValues8.AttributeProviderFactory = (() => typeof(HttpResult).GetField("errMessage", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo8 = jsonPropertyInfoValues8;
			array[7] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo8);
			array[7].IsGetNullable = false;
			array[7].IsSetNullable = false;
			JsonPropertyInfoValues<int?> jsonPropertyInfoValues9 = new JsonPropertyInfoValues<int?>();
			jsonPropertyInfoValues9.IsProperty = false;
			jsonPropertyInfoValues9.IsPublic = true;
			jsonPropertyInfoValues9.IsVirtual = false;
			jsonPropertyInfoValues9.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues9.Converter = null;
			jsonPropertyInfoValues9.Getter = ((object obj) => ((HttpResult)obj).sex);
			jsonPropertyInfoValues9.Setter = delegate(object obj, int? value)
			{
				((HttpResult)obj).sex = value;
			};
			jsonPropertyInfoValues9.IgnoreCondition = null;
			jsonPropertyInfoValues9.HasJsonInclude = false;
			jsonPropertyInfoValues9.IsExtensionData = false;
			jsonPropertyInfoValues9.NumberHandling = null;
			jsonPropertyInfoValues9.PropertyName = "sex";
			jsonPropertyInfoValues9.JsonPropertyName = null;
			jsonPropertyInfoValues9.AttributeProviderFactory = (() => typeof(HttpResult).GetField("sex", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int?> propertyInfo9 = jsonPropertyInfoValues9;
			array[8] = JsonMetadataServices.CreatePropertyInfo<int?>(options, propertyInfo9);
			JsonPropertyInfoValues<long> jsonPropertyInfoValues10 = new JsonPropertyInfoValues<long>();
			jsonPropertyInfoValues10.IsProperty = false;
			jsonPropertyInfoValues10.IsPublic = true;
			jsonPropertyInfoValues10.IsVirtual = false;
			jsonPropertyInfoValues10.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues10.Converter = null;
			jsonPropertyInfoValues10.Getter = ((object obj) => ((HttpResult)obj).banTimeStamp);
			jsonPropertyInfoValues10.Setter = delegate(object obj, long value)
			{
				((HttpResult)obj).banTimeStamp = value;
			};
			jsonPropertyInfoValues10.IgnoreCondition = null;
			jsonPropertyInfoValues10.HasJsonInclude = false;
			jsonPropertyInfoValues10.IsExtensionData = false;
			jsonPropertyInfoValues10.NumberHandling = null;
			jsonPropertyInfoValues10.PropertyName = "banTimeStamp";
			jsonPropertyInfoValues10.JsonPropertyName = null;
			jsonPropertyInfoValues10.AttributeProviderFactory = (() => typeof(HttpResult).GetField("banTimeStamp", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<long> propertyInfo10 = jsonPropertyInfoValues10;
			array[9] = JsonMetadataServices.CreatePropertyInfo<long>(options, propertyInfo10);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues11 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues11.IsProperty = false;
			jsonPropertyInfoValues11.IsPublic = true;
			jsonPropertyInfoValues11.IsVirtual = false;
			jsonPropertyInfoValues11.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues11.Converter = null;
			jsonPropertyInfoValues11.Getter = ((object obj) => ((HttpResult)obj).banReason);
			jsonPropertyInfoValues11.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).banReason = value;
			};
			jsonPropertyInfoValues11.IgnoreCondition = null;
			jsonPropertyInfoValues11.HasJsonInclude = false;
			jsonPropertyInfoValues11.IsExtensionData = false;
			jsonPropertyInfoValues11.NumberHandling = null;
			jsonPropertyInfoValues11.PropertyName = "banReason";
			jsonPropertyInfoValues11.JsonPropertyName = null;
			jsonPropertyInfoValues11.AttributeProviderFactory = (() => typeof(HttpResult).GetField("banReason", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo11 = jsonPropertyInfoValues11;
			array[10] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo11);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues12 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues12.IsProperty = false;
			jsonPropertyInfoValues12.IsPublic = true;
			jsonPropertyInfoValues12.IsVirtual = false;
			jsonPropertyInfoValues12.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues12.Converter = null;
			jsonPropertyInfoValues12.Getter = ((object obj) => ((HttpResult)obj).clientWaitingMode);
			jsonPropertyInfoValues12.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).clientWaitingMode = value;
			};
			jsonPropertyInfoValues12.IgnoreCondition = null;
			jsonPropertyInfoValues12.HasJsonInclude = false;
			jsonPropertyInfoValues12.IsExtensionData = false;
			jsonPropertyInfoValues12.NumberHandling = null;
			jsonPropertyInfoValues12.PropertyName = "clientWaitingMode";
			jsonPropertyInfoValues12.JsonPropertyName = null;
			jsonPropertyInfoValues12.AttributeProviderFactory = (() => typeof(HttpResult).GetField("clientWaitingMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo12 = jsonPropertyInfoValues12;
			array[11] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo12);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues13 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues13.IsProperty = false;
			jsonPropertyInfoValues13.IsPublic = true;
			jsonPropertyInfoValues13.IsVirtual = false;
			jsonPropertyInfoValues13.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues13.Converter = null;
			jsonPropertyInfoValues13.Getter = ((object obj) => ((HttpResult)obj).clientWaitingTime);
			jsonPropertyInfoValues13.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).clientWaitingTime = value;
			};
			jsonPropertyInfoValues13.IgnoreCondition = null;
			jsonPropertyInfoValues13.HasJsonInclude = false;
			jsonPropertyInfoValues13.IsExtensionData = false;
			jsonPropertyInfoValues13.NumberHandling = null;
			jsonPropertyInfoValues13.PropertyName = "clientWaitingTime";
			jsonPropertyInfoValues13.JsonPropertyName = null;
			jsonPropertyInfoValues13.AttributeProviderFactory = (() => typeof(HttpResult).GetField("clientWaitingTime", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo13 = jsonPropertyInfoValues13;
			array[12] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo13);
			JsonPropertyInfoValues<int> jsonPropertyInfoValues14 = new JsonPropertyInfoValues<int>();
			jsonPropertyInfoValues14.IsProperty = false;
			jsonPropertyInfoValues14.IsPublic = true;
			jsonPropertyInfoValues14.IsVirtual = false;
			jsonPropertyInfoValues14.DeclaringType = typeof(HttpResult);
			jsonPropertyInfoValues14.Converter = null;
			jsonPropertyInfoValues14.Getter = ((object obj) => ((HttpResult)obj).clientAutoInInterval);
			jsonPropertyInfoValues14.Setter = delegate(object obj, int value)
			{
				((HttpResult)obj).clientAutoInInterval = value;
			};
			jsonPropertyInfoValues14.IgnoreCondition = null;
			jsonPropertyInfoValues14.HasJsonInclude = false;
			jsonPropertyInfoValues14.IsExtensionData = false;
			jsonPropertyInfoValues14.NumberHandling = null;
			jsonPropertyInfoValues14.PropertyName = "clientAutoInInterval";
			jsonPropertyInfoValues14.JsonPropertyName = null;
			jsonPropertyInfoValues14.AttributeProviderFactory = (() => typeof(HttpResult).GetField("clientAutoInInterval", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<int> propertyInfo14 = jsonPropertyInfoValues14;
			array[13] = JsonMetadataServices.CreatePropertyInfo<int>(options, propertyInfo14);
			return array;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0002B3D8 File Offset: 0x000295D8
		public JsonTypeInfo<LoginNoticeEx> LoginNoticeEx
		{
			get
			{
				JsonTypeInfo<LoginNoticeEx> result;
				if ((result = this._LoginNoticeEx) == null)
				{
					result = (this._LoginNoticeEx = (JsonTypeInfo<LoginNoticeEx>)base.Options.GetTypeInfo(typeof(LoginNoticeEx)));
				}
				return result;
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002B414 File Offset: 0x00029614
		[NullableContext(1)]
		private JsonTypeInfo<LoginNoticeEx> Create_LoginNoticeEx(JsonSerializerOptions options)
		{
			JsonTypeInfo<LoginNoticeEx> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<LoginNoticeEx>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<LoginNoticeEx> jsonObjectInfoValues = new JsonObjectInfoValues<LoginNoticeEx>();
				jsonObjectInfoValues.ObjectCreator = (() => new LoginNoticeEx());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.LoginNoticeExPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(LoginNoticeEx).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<LoginNoticeEx> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<LoginNoticeEx>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0002B4DC File Offset: 0x000296DC
		[NullableContext(1)]
		private static JsonPropertyInfo[] LoginNoticeExPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[5];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(LoginNoticeEx);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((LoginNoticeEx)obj).title);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((LoginNoticeEx)obj).title = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "title";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(LoginNoticeEx).GetField("title", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			JsonPropertyInfoValues<string> jsonPropertyInfoValues2 = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues2.IsProperty = false;
			jsonPropertyInfoValues2.IsPublic = true;
			jsonPropertyInfoValues2.IsVirtual = false;
			jsonPropertyInfoValues2.DeclaringType = typeof(LoginNoticeEx);
			jsonPropertyInfoValues2.Converter = null;
			jsonPropertyInfoValues2.Getter = ((object obj) => ((LoginNoticeEx)obj).content);
			jsonPropertyInfoValues2.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((LoginNoticeEx)obj).content = value;
			};
			jsonPropertyInfoValues2.IgnoreCondition = null;
			jsonPropertyInfoValues2.HasJsonInclude = false;
			jsonPropertyInfoValues2.IsExtensionData = false;
			jsonPropertyInfoValues2.NumberHandling = null;
			jsonPropertyInfoValues2.PropertyName = "content";
			jsonPropertyInfoValues2.JsonPropertyName = null;
			jsonPropertyInfoValues2.AttributeProviderFactory = (() => typeof(LoginNoticeEx).GetField("content", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo2 = jsonPropertyInfoValues2;
			array[1] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo2);
			array[1].IsGetNullable = false;
			array[1].IsSetNullable = false;
			JsonPropertyInfoValues<string[]> jsonPropertyInfoValues3 = new JsonPropertyInfoValues<string[]>();
			jsonPropertyInfoValues3.IsProperty = false;
			jsonPropertyInfoValues3.IsPublic = true;
			jsonPropertyInfoValues3.IsVirtual = false;
			jsonPropertyInfoValues3.DeclaringType = typeof(LoginNoticeEx);
			jsonPropertyInfoValues3.Converter = null;
			jsonPropertyInfoValues3.Getter = ((object obj) => ((LoginNoticeEx)obj).whiteList);
			jsonPropertyInfoValues3.Setter = delegate(object obj, [Nullable(new byte[]
			{
				2,
				1
			})] string[] value)
			{
				((LoginNoticeEx)obj).whiteList = value;
			};
			jsonPropertyInfoValues3.IgnoreCondition = null;
			jsonPropertyInfoValues3.HasJsonInclude = false;
			jsonPropertyInfoValues3.IsExtensionData = false;
			jsonPropertyInfoValues3.NumberHandling = null;
			jsonPropertyInfoValues3.PropertyName = "whiteList";
			jsonPropertyInfoValues3.JsonPropertyName = null;
			jsonPropertyInfoValues3.AttributeProviderFactory = (() => typeof(LoginNoticeEx).GetField("whiteList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string[]> propertyInfo3 = jsonPropertyInfoValues3;
			array[2] = JsonMetadataServices.CreatePropertyInfo<string[]>(options, propertyInfo3);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues4 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues4.IsProperty = false;
			jsonPropertyInfoValues4.IsPublic = true;
			jsonPropertyInfoValues4.IsVirtual = false;
			jsonPropertyInfoValues4.DeclaringType = typeof(LoginNoticeEx);
			jsonPropertyInfoValues4.Converter = null;
			jsonPropertyInfoValues4.Getter = ((object obj) => ((LoginNoticeEx)obj).startTimeMs);
			jsonPropertyInfoValues4.Setter = delegate(object obj, double value)
			{
				((LoginNoticeEx)obj).startTimeMs = value;
			};
			jsonPropertyInfoValues4.IgnoreCondition = null;
			jsonPropertyInfoValues4.HasJsonInclude = false;
			jsonPropertyInfoValues4.IsExtensionData = false;
			jsonPropertyInfoValues4.NumberHandling = null;
			jsonPropertyInfoValues4.PropertyName = "startTimeMs";
			jsonPropertyInfoValues4.JsonPropertyName = null;
			jsonPropertyInfoValues4.AttributeProviderFactory = (() => typeof(LoginNoticeEx).GetField("startTimeMs", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo4 = jsonPropertyInfoValues4;
			array[3] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo4);
			JsonPropertyInfoValues<double> jsonPropertyInfoValues5 = new JsonPropertyInfoValues<double>();
			jsonPropertyInfoValues5.IsProperty = false;
			jsonPropertyInfoValues5.IsPublic = true;
			jsonPropertyInfoValues5.IsVirtual = false;
			jsonPropertyInfoValues5.DeclaringType = typeof(LoginNoticeEx);
			jsonPropertyInfoValues5.Converter = null;
			jsonPropertyInfoValues5.Getter = ((object obj) => ((LoginNoticeEx)obj).endTimeMs);
			jsonPropertyInfoValues5.Setter = delegate(object obj, double value)
			{
				((LoginNoticeEx)obj).endTimeMs = value;
			};
			jsonPropertyInfoValues5.IgnoreCondition = null;
			jsonPropertyInfoValues5.HasJsonInclude = false;
			jsonPropertyInfoValues5.IsExtensionData = false;
			jsonPropertyInfoValues5.NumberHandling = null;
			jsonPropertyInfoValues5.PropertyName = "endTimeMs";
			jsonPropertyInfoValues5.JsonPropertyName = null;
			jsonPropertyInfoValues5.AttributeProviderFactory = (() => typeof(LoginNoticeEx).GetField("endTimeMs", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<double> propertyInfo5 = jsonPropertyInfoValues5;
			array[4] = JsonMetadataServices.CreatePropertyInfo<double>(options, propertyInfo5);
			return array;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0002B9AC File Offset: 0x00029BAC
		public JsonTypeInfo<Result> Result
		{
			get
			{
				JsonTypeInfo<Result> result;
				if ((result = this._Result) == null)
				{
					result = (this._Result = (JsonTypeInfo<Result>)base.Options.GetTypeInfo(typeof(Result)));
				}
				return result;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0002B9E8 File Offset: 0x00029BE8
		[NullableContext(1)]
		private JsonTypeInfo<Result> Create_Result(JsonSerializerOptions options)
		{
			JsonTypeInfo<Result> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Result>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<Result> jsonObjectInfoValues = new JsonObjectInfoValues<Result>();
				jsonObjectInfoValues.ObjectCreator = (() => new Result());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ResultPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(Result).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<Result> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<Result>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0002BAB0 File Offset: 0x00029CB0
		[NullableContext(1)]
		private static JsonPropertyInfo[] ResultPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<ResultData> jsonPropertyInfoValues = new JsonPropertyInfoValues<ResultData>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(Result);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((Result)obj).Data);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] ResultData value)
			{
				((Result)obj).Data = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "Data";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(Result).GetField("Data", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<ResultData> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<ResultData>(options, propertyInfo);
			return array;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0002BBAC File Offset: 0x00029DAC
		public JsonTypeInfo<ResultData> ResultData
		{
			get
			{
				JsonTypeInfo<ResultData> result;
				if ((result = this._ResultData) == null)
				{
					result = (this._ResultData = (JsonTypeInfo<ResultData>)base.Options.GetTypeInfo(typeof(ResultData)));
				}
				return result;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0002BBE8 File Offset: 0x00029DE8
		[NullableContext(1)]
		private JsonTypeInfo<ResultData> Create_ResultData(JsonSerializerOptions options)
		{
			JsonTypeInfo<ResultData> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<ResultData>(options, out jsonTypeInfo))
			{
				JsonObjectInfoValues<ResultData> jsonObjectInfoValues = new JsonObjectInfoValues<ResultData>();
				jsonObjectInfoValues.ObjectCreator = (() => new ResultData());
				jsonObjectInfoValues.ObjectWithParameterizedConstructorCreator = null;
				jsonObjectInfoValues.PropertyMetadataInitializer = ((JsonSerializerContext _) => LauncherJsonSourceGenContext.ResultDataPropInit(options));
				jsonObjectInfoValues.ConstructorParameterMetadataInitializer = null;
				jsonObjectInfoValues.ConstructorAttributeProviderFactory = (() => typeof(ResultData).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Array.Empty<Type>(), null));
				jsonObjectInfoValues.SerializeHandler = null;
				JsonObjectInfoValues<ResultData> objectInfo = jsonObjectInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateObjectInfo<ResultData>(options, objectInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		[NullableContext(1)]
		private static JsonPropertyInfo[] ResultDataPropInit(JsonSerializerOptions options)
		{
			JsonPropertyInfo[] array = new JsonPropertyInfo[1];
			JsonPropertyInfoValues<string> jsonPropertyInfoValues = new JsonPropertyInfoValues<string>();
			jsonPropertyInfoValues.IsProperty = false;
			jsonPropertyInfoValues.IsPublic = true;
			jsonPropertyInfoValues.IsVirtual = false;
			jsonPropertyInfoValues.DeclaringType = typeof(ResultData);
			jsonPropertyInfoValues.Converter = null;
			jsonPropertyInfoValues.Getter = ((object obj) => ((ResultData)obj).ImageUrl);
			jsonPropertyInfoValues.Setter = delegate(object obj, [Nullable(2)] string value)
			{
				((ResultData)obj).ImageUrl = value;
			};
			jsonPropertyInfoValues.IgnoreCondition = null;
			jsonPropertyInfoValues.HasJsonInclude = false;
			jsonPropertyInfoValues.IsExtensionData = false;
			jsonPropertyInfoValues.NumberHandling = null;
			jsonPropertyInfoValues.PropertyName = "ImageUrl";
			jsonPropertyInfoValues.JsonPropertyName = null;
			jsonPropertyInfoValues.AttributeProviderFactory = (() => typeof(ResultData).GetField("ImageUrl", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			JsonPropertyInfoValues<string> propertyInfo = jsonPropertyInfoValues;
			array[0] = JsonMetadataServices.CreatePropertyInfo<string>(options, propertyInfo);
			array[0].IsGetNullable = false;
			array[0].IsSetNullable = false;
			return array;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0002BDC0 File Offset: 0x00029FC0
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

		// Token: 0x06000461 RID: 1121 RVA: 0x0002BDFC File Offset: 0x00029FFC
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<int, double>> Create_DictionaryInt32Double(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<int, double>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<int, double>>(options, out jsonTypeInfo))
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0002BE64 File Offset: 0x0002A064
		public JsonTypeInfo<Dictionary<string, double>> DictionaryStringDouble
		{
			get
			{
				JsonTypeInfo<Dictionary<string, double>> result;
				if ((result = this._DictionaryStringDouble) == null)
				{
					result = (this._DictionaryStringDouble = (JsonTypeInfo<Dictionary<string, double>>)base.Options.GetTypeInfo(typeof(Dictionary<string, double>)));
				}
				return result;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, double>> Create_DictionaryStringDouble(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, double>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, double>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, double>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, double>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, double>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, double>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, double>, string, double>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0002BF08 File Offset: 0x0002A108
		public JsonTypeInfo<Dictionary<string, IUdpRegion>> DictionaryStringIUdpRegion
		{
			get
			{
				JsonTypeInfo<Dictionary<string, IUdpRegion>> result;
				if ((result = this._DictionaryStringIUdpRegion) == null)
				{
					result = (this._DictionaryStringIUdpRegion = (JsonTypeInfo<Dictionary<string, IUdpRegion>>)base.Options.GetTypeInfo(typeof(Dictionary<string, IUdpRegion>)));
				}
				return result;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0002BF44 File Offset: 0x0002A144
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, IUdpRegion>> Create_DictionaryStringIUdpRegion(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, IUdpRegion>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, IUdpRegion>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, IUdpRegion>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, IUdpRegion>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, IUdpRegion>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, IUdpRegion>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, IUdpRegion>, string, IUdpRegion>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		public JsonTypeInfo<Dictionary<string, PatchManifestJson>> DictionaryStringPatchManifestJson
		{
			get
			{
				JsonTypeInfo<Dictionary<string, PatchManifestJson>> result;
				if ((result = this._DictionaryStringPatchManifestJson) == null)
				{
					result = (this._DictionaryStringPatchManifestJson = (JsonTypeInfo<Dictionary<string, PatchManifestJson>>)base.Options.GetTypeInfo(typeof(Dictionary<string, PatchManifestJson>)));
				}
				return result;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, PatchManifestJson>> Create_DictionaryStringPatchManifestJson(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, PatchManifestJson>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, PatchManifestJson>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, PatchManifestJson>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, PatchManifestJson>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, PatchManifestJson>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, PatchManifestJson>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, PatchManifestJson>, string, PatchManifestJson>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0002C050 File Offset: 0x0002A250
		public JsonTypeInfo<Dictionary<string, VideoItem>> DictionaryStringVideoItem
		{
			get
			{
				JsonTypeInfo<Dictionary<string, VideoItem>> result;
				if ((result = this._DictionaryStringVideoItem) == null)
				{
					result = (this._DictionaryStringVideoItem = (JsonTypeInfo<Dictionary<string, VideoItem>>)base.Options.GetTypeInfo(typeof(Dictionary<string, VideoItem>)));
				}
				return result;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0002C08C File Offset: 0x0002A28C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, VideoItem>> Create_DictionaryStringVideoItem(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, VideoItem>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, VideoItem>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, VideoItem>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, VideoItem>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, VideoItem>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, VideoItem>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, VideoItem>, string, VideoItem>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0002C0F4 File Offset: 0x0002A2F4
		public JsonTypeInfo<Dictionary<string, CsLinkEntry>> DictionaryStringCsLinkEntry
		{
			get
			{
				JsonTypeInfo<Dictionary<string, CsLinkEntry>> result;
				if ((result = this._DictionaryStringCsLinkEntry) == null)
				{
					result = (this._DictionaryStringCsLinkEntry = (JsonTypeInfo<Dictionary<string, CsLinkEntry>>)base.Options.GetTypeInfo(typeof(Dictionary<string, CsLinkEntry>)));
				}
				return result;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0002C130 File Offset: 0x0002A330
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, CsLinkEntry>> Create_DictionaryStringCsLinkEntry(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, CsLinkEntry>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, CsLinkEntry>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, CsLinkEntry>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, CsLinkEntry>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, CsLinkEntry>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, CsLinkEntry>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, CsLinkEntry>, string, CsLinkEntry>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0002C198 File Offset: 0x0002A398
		public JsonTypeInfo<Dictionary<string, VersionItem>> DictionaryStringVersionItem
		{
			get
			{
				JsonTypeInfo<Dictionary<string, VersionItem>> result;
				if ((result = this._DictionaryStringVersionItem) == null)
				{
					result = (this._DictionaryStringVersionItem = (JsonTypeInfo<Dictionary<string, VersionItem>>)base.Options.GetTypeInfo(typeof(Dictionary<string, VersionItem>)));
				}
				return result;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, VersionItem>> Create_DictionaryStringVersionItem(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, VersionItem>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, VersionItem>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, VersionItem>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, VersionItem>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, VersionItem>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, VersionItem>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, VersionItem>, string, VersionItem>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0002C23C File Offset: 0x0002A43C
		public JsonTypeInfo<Dictionary<string, object>> DictionaryStringObject
		{
			get
			{
				JsonTypeInfo<Dictionary<string, object>> result;
				if ((result = this._DictionaryStringObject) == null)
				{
					result = (this._DictionaryStringObject = (JsonTypeInfo<Dictionary<string, object>>)base.Options.GetTypeInfo(typeof(Dictionary<string, object>)));
				}
				return result;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0002C278 File Offset: 0x0002A478
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, object>> Create_DictionaryStringObject(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, object>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, object>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, object>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, object>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, object>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, object>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, object>, string, object>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		public JsonTypeInfo<Dictionary<string, string>> DictionaryStringString
		{
			get
			{
				JsonTypeInfo<Dictionary<string, string>> result;
				if ((result = this._DictionaryStringString) == null)
				{
					result = (this._DictionaryStringString = (JsonTypeInfo<Dictionary<string, string>>)base.Options.GetTypeInfo(typeof(Dictionary<string, string>)));
				}
				return result;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0002C31C File Offset: 0x0002A51C
		[NullableContext(1)]
		private JsonTypeInfo<Dictionary<string, string>> Create_DictionaryStringString(JsonSerializerOptions options)
		{
			JsonTypeInfo<Dictionary<string, string>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<Dictionary<string, string>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<Dictionary<string, string>> jsonCollectionInfoValues = new JsonCollectionInfoValues<Dictionary<string, string>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new Dictionary<string, string>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<Dictionary<string, string>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, string>, string, string>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0002C384 File Offset: 0x0002A584
		public JsonTypeInfo<List<NetHostInfo>> ListNetHostInfo
		{
			get
			{
				JsonTypeInfo<List<NetHostInfo>> result;
				if ((result = this._ListNetHostInfo) == null)
				{
					result = (this._ListNetHostInfo = (JsonTypeInfo<List<NetHostInfo>>)base.Options.GetTypeInfo(typeof(List<NetHostInfo>)));
				}
				return result;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		[NullableContext(1)]
		private JsonTypeInfo<List<NetHostInfo>> Create_ListNetHostInfo(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<NetHostInfo>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<NetHostInfo>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<NetHostInfo>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<NetHostInfo>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<NetHostInfo>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<NetHostInfo>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<NetHostInfo>, NetHostInfo>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0002C428 File Offset: 0x0002A628
		public JsonTypeInfo<List<ICdnScoreFormula>> ListICdnScoreFormula
		{
			get
			{
				JsonTypeInfo<List<ICdnScoreFormula>> result;
				if ((result = this._ListICdnScoreFormula) == null)
				{
					result = (this._ListICdnScoreFormula = (JsonTypeInfo<List<ICdnScoreFormula>>)base.Options.GetTypeInfo(typeof(List<ICdnScoreFormula>)));
				}
				return result;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0002C464 File Offset: 0x0002A664
		[NullableContext(1)]
		private JsonTypeInfo<List<ICdnScoreFormula>> Create_ListICdnScoreFormula(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<ICdnScoreFormula>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<ICdnScoreFormula>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<ICdnScoreFormula>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<ICdnScoreFormula>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<ICdnScoreFormula>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<ICdnScoreFormula>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<ICdnScoreFormula>, ICdnScoreFormula>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0002C4CC File Offset: 0x0002A6CC
		public JsonTypeInfo<List<ICdnScoreStep>> ListICdnScoreStep
		{
			get
			{
				JsonTypeInfo<List<ICdnScoreStep>> result;
				if ((result = this._ListICdnScoreStep) == null)
				{
					result = (this._ListICdnScoreStep = (JsonTypeInfo<List<ICdnScoreStep>>)base.Options.GetTypeInfo(typeof(List<ICdnScoreStep>)));
				}
				return result;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0002C508 File Offset: 0x0002A708
		[NullableContext(1)]
		private JsonTypeInfo<List<ICdnScoreStep>> Create_ListICdnScoreStep(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<ICdnScoreStep>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<ICdnScoreStep>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<ICdnScoreStep>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<ICdnScoreStep>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<ICdnScoreStep>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<ICdnScoreStep>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<ICdnScoreStep>, ICdnScoreStep>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0002C570 File Offset: 0x0002A770
		public JsonTypeInfo<List<ICdnUrlData>> ListICdnUrlData
		{
			get
			{
				JsonTypeInfo<List<ICdnUrlData>> result;
				if ((result = this._ListICdnUrlData) == null)
				{
					result = (this._ListICdnUrlData = (JsonTypeInfo<List<ICdnUrlData>>)base.Options.GetTypeInfo(typeof(List<ICdnUrlData>)));
				}
				return result;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		[NullableContext(1)]
		private JsonTypeInfo<List<ICdnUrlData>> Create_ListICdnUrlData(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<ICdnUrlData>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<ICdnUrlData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<ICdnUrlData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<ICdnUrlData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<ICdnUrlData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<ICdnUrlData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<ICdnUrlData>, ICdnUrlData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0002C614 File Offset: 0x0002A814
		public JsonTypeInfo<List<IGrayBoxItemConfig>> ListIGrayBoxItemConfig
		{
			get
			{
				JsonTypeInfo<List<IGrayBoxItemConfig>> result;
				if ((result = this._ListIGrayBoxItemConfig) == null)
				{
					result = (this._ListIGrayBoxItemConfig = (JsonTypeInfo<List<IGrayBoxItemConfig>>)base.Options.GetTypeInfo(typeof(List<IGrayBoxItemConfig>)));
				}
				return result;
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0002C650 File Offset: 0x0002A850
		[NullableContext(1)]
		private JsonTypeInfo<List<IGrayBoxItemConfig>> Create_ListIGrayBoxItemConfig(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<IGrayBoxItemConfig>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<IGrayBoxItemConfig>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<IGrayBoxItemConfig>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<IGrayBoxItemConfig>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<IGrayBoxItemConfig>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<IGrayBoxItemConfig>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<IGrayBoxItemConfig>, IGrayBoxItemConfig>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
		public JsonTypeInfo<List<ILoginServersData>> ListILoginServersData
		{
			get
			{
				JsonTypeInfo<List<ILoginServersData>> result;
				if ((result = this._ListILoginServersData) == null)
				{
					result = (this._ListILoginServersData = (JsonTypeInfo<List<ILoginServersData>>)base.Options.GetTypeInfo(typeof(List<ILoginServersData>)));
				}
				return result;
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		[NullableContext(1)]
		private JsonTypeInfo<List<ILoginServersData>> Create_ListILoginServersData(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<ILoginServersData>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<ILoginServersData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<ILoginServersData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<ILoginServersData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<ILoginServersData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<ILoginServersData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<ILoginServersData>, ILoginServersData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0002C75C File Offset: 0x0002A95C
		public JsonTypeInfo<List<IUdpProbe>> ListIUdpProbe
		{
			get
			{
				JsonTypeInfo<List<IUdpProbe>> result;
				if ((result = this._ListIUdpProbe) == null)
				{
					result = (this._ListIUdpProbe = (JsonTypeInfo<List<IUdpProbe>>)base.Options.GetTypeInfo(typeof(List<IUdpProbe>)));
				}
				return result;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0002C798 File Offset: 0x0002A998
		[NullableContext(1)]
		private JsonTypeInfo<List<IUdpProbe>> Create_ListIUdpProbe(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<IUdpProbe>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<IUdpProbe>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<IUdpProbe>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<IUdpProbe>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<IUdpProbe>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<IUdpProbe>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<IUdpProbe>, IUdpProbe>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0002C800 File Offset: 0x0002AA00
		public JsonTypeInfo<List<IBlockDataContent>> ListIBlockDataContent
		{
			get
			{
				JsonTypeInfo<List<IBlockDataContent>> result;
				if ((result = this._ListIBlockDataContent) == null)
				{
					result = (this._ListIBlockDataContent = (JsonTypeInfo<List<IBlockDataContent>>)base.Options.GetTypeInfo(typeof(List<IBlockDataContent>)));
				}
				return result;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0002C83C File Offset: 0x0002AA3C
		[NullableContext(1)]
		private JsonTypeInfo<List<IBlockDataContent>> Create_ListIBlockDataContent(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<IBlockDataContent>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<IBlockDataContent>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<IBlockDataContent>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<IBlockDataContent>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<IBlockDataContent>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<IBlockDataContent>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<IBlockDataContent>, IBlockDataContent>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
		public JsonTypeInfo<List<IQueryGoodsResponseData>> ListIQueryGoodsResponseData
		{
			get
			{
				JsonTypeInfo<List<IQueryGoodsResponseData>> result;
				if ((result = this._ListIQueryGoodsResponseData) == null)
				{
					result = (this._ListIQueryGoodsResponseData = (JsonTypeInfo<List<IQueryGoodsResponseData>>)base.Options.GetTypeInfo(typeof(List<IQueryGoodsResponseData>)));
				}
				return result;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		[NullableContext(1)]
		private JsonTypeInfo<List<IQueryGoodsResponseData>> Create_ListIQueryGoodsResponseData(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<IQueryGoodsResponseData>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<IQueryGoodsResponseData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<IQueryGoodsResponseData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<IQueryGoodsResponseData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<IQueryGoodsResponseData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<IQueryGoodsResponseData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<IQueryGoodsResponseData>, IQueryGoodsResponseData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0002C948 File Offset: 0x0002AB48
		public JsonTypeInfo<List<UserRegionInfo>> ListUserRegionInfo
		{
			get
			{
				JsonTypeInfo<List<UserRegionInfo>> result;
				if ((result = this._ListUserRegionInfo) == null)
				{
					result = (this._ListUserRegionInfo = (JsonTypeInfo<List<UserRegionInfo>>)base.Options.GetTypeInfo(typeof(List<UserRegionInfo>)));
				}
				return result;
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0002C984 File Offset: 0x0002AB84
		[NullableContext(1)]
		private JsonTypeInfo<List<UserRegionInfo>> Create_ListUserRegionInfo(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<UserRegionInfo>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<UserRegionInfo>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<UserRegionInfo>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<UserRegionInfo>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<UserRegionInfo>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<UserRegionInfo>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<UserRegionInfo>, UserRegionInfo>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0002C9EC File Offset: 0x0002ABEC
		public JsonTypeInfo<List<ResourcePackagePositionData>> ListResourcePackagePositionData
		{
			get
			{
				JsonTypeInfo<List<ResourcePackagePositionData>> result;
				if ((result = this._ListResourcePackagePositionData) == null)
				{
					result = (this._ListResourcePackagePositionData = (JsonTypeInfo<List<ResourcePackagePositionData>>)base.Options.GetTypeInfo(typeof(List<ResourcePackagePositionData>)));
				}
				return result;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0002CA28 File Offset: 0x0002AC28
		[NullableContext(1)]
		private JsonTypeInfo<List<ResourcePackagePositionData>> Create_ListResourcePackagePositionData(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<ResourcePackagePositionData>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<ResourcePackagePositionData>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<ResourcePackagePositionData>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<ResourcePackagePositionData>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<ResourcePackagePositionData>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<ResourcePackagePositionData>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<ResourcePackagePositionData>, ResourcePackagePositionData>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002CA90 File Offset: 0x0002AC90
		public JsonTypeInfo<List<VersionItem>> ListVersionItem
		{
			get
			{
				JsonTypeInfo<List<VersionItem>> result;
				if ((result = this._ListVersionItem) == null)
				{
					result = (this._ListVersionItem = (JsonTypeInfo<List<VersionItem>>)base.Options.GetTypeInfo(typeof(List<VersionItem>)));
				}
				return result;
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0002CACC File Offset: 0x0002ACCC
		[NullableContext(1)]
		private JsonTypeInfo<List<VersionItem>> Create_ListVersionItem(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<VersionItem>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<VersionItem>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<VersionItem>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<VersionItem>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<VersionItem>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<VersionItem>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<VersionItem>, VersionItem>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0002CB34 File Offset: 0x0002AD34
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

		// Token: 0x0600048B RID: 1163 RVA: 0x0002CB70 File Offset: 0x0002AD70
		[NullableContext(1)]
		private JsonTypeInfo<List<int>> Create_ListInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<int>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<int>>(options, out jsonTypeInfo))
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
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

		// Token: 0x0600048D RID: 1165 RVA: 0x0002CC14 File Offset: 0x0002AE14
		[NullableContext(1)]
		private JsonTypeInfo<List<string>> Create_ListString(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<string>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<string>>(options, out jsonTypeInfo))
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0002CC7C File Offset: 0x0002AE7C
		public JsonTypeInfo<List<uint>> ListUInt32
		{
			get
			{
				JsonTypeInfo<List<uint>> result;
				if ((result = this._ListUInt32) == null)
				{
					result = (this._ListUInt32 = (JsonTypeInfo<List<uint>>)base.Options.GetTypeInfo(typeof(List<uint>)));
				}
				return result;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		[NullableContext(1)]
		private JsonTypeInfo<List<uint>> Create_ListUInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<List<uint>> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<List<uint>>(options, out jsonTypeInfo))
			{
				JsonCollectionInfoValues<List<uint>> jsonCollectionInfoValues = new JsonCollectionInfoValues<List<uint>>();
				jsonCollectionInfoValues.ObjectCreator = (() => new List<uint>());
				jsonCollectionInfoValues.SerializeHandler = null;
				JsonCollectionInfoValues<List<uint>> collectionInfo = jsonCollectionInfoValues;
				jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<uint>, uint>(options, collectionInfo);
				jsonTypeInfo.NumberHandling = null;
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0002CD20 File Offset: 0x0002AF20
		public JsonTypeInfo<JsonElement> JsonElement
		{
			get
			{
				JsonTypeInfo<JsonElement> result;
				if ((result = this._JsonElement) == null)
				{
					result = (this._JsonElement = (JsonTypeInfo<JsonElement>)base.Options.GetTypeInfo(typeof(JsonElement)));
				}
				return result;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		[NullableContext(1)]
		private JsonTypeInfo<JsonElement> Create_JsonElement(JsonSerializerOptions options)
		{
			JsonTypeInfo<JsonElement> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<JsonElement>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<JsonElement>(options, JsonMetadataServices.JsonElementConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0002CD88 File Offset: 0x0002AF88
		public JsonTypeInfo<JsonElement?> NullableJsonElement
		{
			get
			{
				JsonTypeInfo<JsonElement?> result;
				if ((result = this._NullableJsonElement) == null)
				{
					result = (this._NullableJsonElement = (JsonTypeInfo<JsonElement?>)base.Options.GetTypeInfo(typeof(JsonElement?)));
				}
				return result;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		[NullableContext(1)]
		private JsonTypeInfo<JsonElement?> Create_NullableJsonElement(JsonSerializerOptions options)
		{
			JsonTypeInfo<JsonElement?> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<JsonElement?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<JsonElement>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<JsonElement?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
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

		// Token: 0x06000495 RID: 1173 RVA: 0x0002CE30 File Offset: 0x0002B030
		[NullableContext(1)]
		private JsonTypeInfo<int> Create_Int32(JsonSerializerOptions options)
		{
			JsonTypeInfo<int> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<int>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int>(options, JsonMetadataServices.Int32Converter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0002CE5C File Offset: 0x0002B05C
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

		// Token: 0x06000497 RID: 1175 RVA: 0x0002CE98 File Offset: 0x0002B098
		[NullableContext(1)]
		private JsonTypeInfo<int?> Create_NullableInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<int?> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<int?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<int>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
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

		// Token: 0x06000499 RID: 1177 RVA: 0x0002CF04 File Offset: 0x0002B104
		[NullableContext(1)]
		private JsonTypeInfo<int[]> Create_Int32Array(JsonSerializerOptions options)
		{
			JsonTypeInfo<int[]> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<int[]>(options, out jsonTypeInfo))
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0002CF50 File Offset: 0x0002B150
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

		// Token: 0x0600049B RID: 1179 RVA: 0x0002CF8C File Offset: 0x0002B18C
		[NullableContext(1)]
		private JsonTypeInfo<long> Create_Int64(JsonSerializerOptions options)
		{
			JsonTypeInfo<long> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<long>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<long>(options, JsonMetadataServices.Int64Converter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		public JsonTypeInfo<long?> NullableInt64
		{
			get
			{
				JsonTypeInfo<long?> result;
				if ((result = this._NullableInt64) == null)
				{
					result = (this._NullableInt64 = (JsonTypeInfo<long?>)base.Options.GetTypeInfo(typeof(long?)));
				}
				return result;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
		[NullableContext(1)]
		private JsonTypeInfo<long?> Create_NullableInt64(JsonSerializerOptions options)
		{
			JsonTypeInfo<long?> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<long?>(options, out jsonTypeInfo))
			{
				JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<long>(options);
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<long?>(options, nullableConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0002D024 File Offset: 0x0002B224
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

		// Token: 0x0600049F RID: 1183 RVA: 0x0002D060 File Offset: 0x0002B260
		[NullableContext(1)]
		private JsonTypeInfo<object> Create_Object(JsonSerializerOptions options)
		{
			JsonTypeInfo<object> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<object>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<object>(options, JsonMetadataServices.ObjectConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0002D08C File Offset: 0x0002B28C
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

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
		[NullableContext(1)]
		private JsonTypeInfo<string> Create_String(JsonSerializerOptions options)
		{
			JsonTypeInfo<string> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<string>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<string>(options, JsonMetadataServices.StringConverter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0002D0F4 File Offset: 0x0002B2F4
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

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002D130 File Offset: 0x0002B330
		[NullableContext(1)]
		private JsonTypeInfo<string[]> Create_StringArray(JsonSerializerOptions options)
		{
			JsonTypeInfo<string[]> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<string[]>(options, out jsonTypeInfo))
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0002D17C File Offset: 0x0002B37C
		public JsonTypeInfo<uint> UInt32
		{
			get
			{
				JsonTypeInfo<uint> result;
				if ((result = this._UInt32) == null)
				{
					result = (this._UInt32 = (JsonTypeInfo<uint>)base.Options.GetTypeInfo(typeof(uint)));
				}
				return result;
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002D1B8 File Offset: 0x0002B3B8
		[NullableContext(1)]
		private JsonTypeInfo<uint> Create_UInt32(JsonSerializerOptions options)
		{
			JsonTypeInfo<uint> jsonTypeInfo;
			if (!LauncherJsonSourceGenContext.TryGetTypeInfoForRuntimeCustomConverter<uint>(options, out jsonTypeInfo))
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<uint>(options, JsonMetadataServices.UInt32Converter);
			}
			jsonTypeInfo.OriginatingResolver = this;
			return jsonTypeInfo;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0002D1E3 File Offset: 0x0002B3E3
		[Nullable(1)]
		public static LauncherJsonSourceGenContext Default { [NullableContext(1)] get; } = new LauncherJsonSourceGenContext(new JsonSerializerOptions(LauncherJsonSourceGenContext.s_defaultOptions));

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0002D1EA File Offset: 0x0002B3EA
		[Nullable(2)]
		protected override JsonSerializerOptions GeneratedSerializerOptions { [NullableContext(2)] get; } = LauncherJsonSourceGenContext.s_defaultOptions;

		// Token: 0x060004A8 RID: 1192 RVA: 0x0002D1F2 File Offset: 0x0002B3F2
		public LauncherJsonSourceGenContext() : base(null)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0002D206 File Offset: 0x0002B406
		[NullableContext(1)]
		public LauncherJsonSourceGenContext(JsonSerializerOptions options) : base(options)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0002D21C File Offset: 0x0002B41C
		[NullableContext(1)]
		private static bool TryGetTypeInfoForRuntimeCustomConverter<[Nullable(2)] TJsonMetadataType>(JsonSerializerOptions options, out JsonTypeInfo<TJsonMetadataType> jsonTypeInfo)
		{
			JsonConverter runtimeConverterForType = LauncherJsonSourceGenContext.GetRuntimeConverterForType(typeof(TJsonMetadataType), options);
			if (runtimeConverterForType != null)
			{
				jsonTypeInfo = JsonMetadataServices.CreateValueInfo<TJsonMetadataType>(options, runtimeConverterForType);
				return true;
			}
			jsonTypeInfo = null;
			return false;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0002D24C File Offset: 0x0002B44C
		[NullableContext(1)]
		[return: Nullable(2)]
		private static JsonConverter GetRuntimeConverterForType(Type type, JsonSerializerOptions options)
		{
			for (int i = 0; i < options.Converters.Count; i++)
			{
				JsonConverter jsonConverter = options.Converters[i];
				if (jsonConverter != null && jsonConverter.CanConvert(type))
				{
					return LauncherJsonSourceGenContext.ExpandConverter(type, jsonConverter, options, false);
				}
			}
			return null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0002D294 File Offset: 0x0002B494
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

		// Token: 0x060004AD RID: 1197 RVA: 0x0002D2FC File Offset: 0x0002B4FC
		[NullableContext(1)]
		[return: Nullable(2)]
		public override JsonTypeInfo GetTypeInfo(Type type)
		{
			JsonTypeInfo result;
			base.Options.TryGetTypeInfo(type, out result);
			return result;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002D31C File Offset: 0x0002B51C
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
			if (type == typeof(float))
			{
				return this.Create_Single(options);
			}
			if (type == typeof(float?))
			{
				return this.Create_NullableSingle(options);
			}
			if (type == typeof(GatewayLatencyConfigVo))
			{
				return this.Create_GatewayLatencyConfigVo(options);
			}
			if (type == typeof(NetHostInfo))
			{
				return this.Create_NetHostInfo(options);
			}
			if (type == typeof(EntryJson))
			{
				return this.Create_EntryJson(options);
			}
			if (type == typeof(ICdnScoreCfg))
			{
				return this.Create_ICdnScoreCfg(options);
			}
			if (type == typeof(ICdnScoreFormula))
			{
				return this.Create_ICdnScoreFormula(options);
			}
			if (type == typeof(ICdnScoreStep))
			{
				return this.Create_ICdnScoreStep(options);
			}
			if (type == typeof(ICdnUrlData))
			{
				return this.Create_ICdnUrlData(options);
			}
			if (type == typeof(IEvalConfig))
			{
				return this.Create_IEvalConfig(options);
			}
			if (type == typeof(IEvalNetworkConfig))
			{
				return this.Create_IEvalNetworkConfig(options);
			}
			if (type == typeof(IGachaUrl))
			{
				return this.Create_IGachaUrl(options);
			}
			if (type == typeof(IGrayBoxConfig))
			{
				return this.Create_IGrayBoxConfig(options);
			}
			if (type == typeof(IGrayBoxItemConfig))
			{
				return this.Create_IGrayBoxItemConfig(options);
			}
			if (type == typeof(ILoginServersData))
			{
				return this.Create_ILoginServersData(options);
			}
			if (type == typeof(ILogReport))
			{
				return this.Create_ILogReport(options);
			}
			if (type == typeof(IPrivateServersData))
			{
				return this.Create_IPrivateServersData(options);
			}
			if (type == typeof(ITDConfig))
			{
				return this.Create_ITDConfig(options);
			}
			if (type == typeof(IUdpProbe))
			{
				return this.Create_IUdpProbe(options);
			}
			if (type == typeof(IUdpRegion))
			{
				return this.Create_IUdpRegion(options);
			}
			if (type == typeof(IUpdateUrl))
			{
				return this.Create_IUpdateUrl(options);
			}
			if (type == typeof(PatchManifest))
			{
				return this.Create_PatchManifest(options);
			}
			if (type == typeof(PatchManifestJson))
			{
				return this.Create_PatchManifestJson(options);
			}
			if (type == typeof(RemotePakMapConfig))
			{
				return this.Create_RemotePakMapConfig(options);
			}
			if (type == typeof(RemoteVideoConfig))
			{
				return this.Create_RemoteVideoConfig(options);
			}
			if (type == typeof(RemoteVideoConfigUpdateTime))
			{
				return this.Create_RemoteVideoConfigUpdateTime(options);
			}
			if (type == typeof(VideoItem))
			{
				return this.Create_VideoItem(options);
			}
			if (type == typeof(GameWindowStateData))
			{
				return this.Create_GameWindowStateData(options);
			}
			if (type == typeof(UserInfo))
			{
				return this.Create_UserInfo(options);
			}
			if (type == typeof(ILocalSendedSave))
			{
				return this.Create_ILocalSendedSave(options);
			}
			if (type == typeof(INetworkDetectionConfig))
			{
				return this.Create_INetworkDetectionConfig(options);
			}
			if (type == typeof(BilibiliParam))
			{
				return this.Create_BilibiliParam(options);
			}
			if (type == typeof(ClientSwitch))
			{
				return this.Create_ClientSwitch(options);
			}
			if (type == typeof(ClientUrl))
			{
				return this.Create_ClientUrl(options);
			}
			if (type == typeof(CsLinkEntry))
			{
				return this.Create_CsLinkEntry(options);
			}
			if (type == typeof(DouyinParam))
			{
				return this.Create_DouyinParam(options);
			}
			if (type == typeof(IBlockData))
			{
				return this.Create_IBlockData(options);
			}
			if (type == typeof(IBlockDataContent))
			{
				return this.Create_IBlockDataContent(options);
			}
			if (type == typeof(IBlockResponseData))
			{
				return this.Create_IBlockResponseData(options);
			}
			if (type == typeof(ICheckoutProductResponse))
			{
				return this.Create_ICheckoutProductResponse(options);
			}
			if (type == typeof(IConfigJson))
			{
				return this.Create_IConfigJson(options);
			}
			if (type == typeof(IConnectResponse))
			{
				return this.Create_IConnectResponse(options);
			}
			if (type == typeof(IConnectResponseData))
			{
				return this.Create_IConnectResponseData(options);
			}
			if (type == typeof(IGetAccessTokenResponse))
			{
				return this.Create_IGetAccessTokenResponse(options);
			}
			if (type == typeof(IGetAccessTokenResponseData))
			{
				return this.Create_IGetAccessTokenResponseData(options);
			}
			if (type == typeof(IIdTokenData))
			{
				return this.Create_IIdTokenData(options);
			}
			if (type == typeof(ILoginResponse))
			{
				return this.Create_ILoginResponse(options);
			}
			if (type == typeof(ILoginResponseData))
			{
				return this.Create_ILoginResponseData(options);
			}
			if (type == typeof(IPlatformData))
			{
				return this.Create_IPlatformData(options);
			}
			if (type == typeof(IPlatformReleaseData))
			{
				return this.Create_IPlatformReleaseData(options);
			}
			if (type == typeof(IQueryGoodsResponse))
			{
				return this.Create_IQueryGoodsResponse(options);
			}
			if (type == typeof(IQueryGoodsResponseData))
			{
				return this.Create_IQueryGoodsResponseData(options);
			}
			if (type == typeof(IRenewAccessTokenResponse))
			{
				return this.Create_IRenewAccessTokenResponse(options);
			}
			if (type == typeof(IRenewAccessTokenResponseData))
			{
				return this.Create_IRenewAccessTokenResponseData(options);
			}
			if (type == typeof(IReportResponse))
			{
				return this.Create_IReportResponse(options);
			}
			if (type == typeof(ISdkRequestEmailCodeResponse))
			{
				return this.Create_ISdkRequestEmailCodeResponse(options);
			}
			if (type == typeof(KujiequParam))
			{
				return this.Create_KujiequParam(options);
			}
			if (type == typeof(LoginElement))
			{
				return this.Create_LoginElement(options);
			}
			if (type == typeof(QQParam))
			{
				return this.Create_QQParam(options);
			}
			if (type == typeof(SdkPlatformConfig))
			{
				return this.Create_SdkPlatformConfig(options);
			}
			if (type == typeof(ShareSDKParam))
			{
				return this.Create_ShareSDKParam(options);
			}
			if (type == typeof(ThirdLogin))
			{
				return this.Create_ThirdLogin(options);
			}
			if (type == typeof(ThirdShareParams))
			{
				return this.Create_ThirdShareParams(options);
			}
			if (type == typeof(WeChatParam))
			{
				return this.Create_WeChatParam(options);
			}
			if (type == typeof(WeiboParam))
			{
				return this.Create_WeiboParam(options);
			}
			if (type == typeof(PreDownloadConfig))
			{
				return this.Create_PreDownloadConfig(options);
			}
			if (type == typeof(RemoteConfig))
			{
				return this.Create_RemoteConfig(options);
			}
			if (type == typeof(RemoteVersionConfig))
			{
				return this.Create_RemoteVersionConfig(options);
			}
			if (type == typeof(LoginPlayerInfo))
			{
				return this.Create_LoginPlayerInfo(options);
			}
			if (type == typeof(UserRegionInfo))
			{
				return this.Create_UserRegionInfo(options);
			}
			if (type == typeof(HttpSubPackageResult))
			{
				return this.Create_HttpSubPackageResult(options);
			}
			if (type == typeof(ResourcePackagePositionData))
			{
				return this.Create_ResourcePackagePositionData(options);
			}
			if (type == typeof(PakListConfig))
			{
				return this.Create_PakListConfig(options);
			}
			if (type == typeof(VersionItem))
			{
				return this.Create_VersionItem(options);
			}
			if (type == typeof(HttpResult))
			{
				return this.Create_HttpResult(options);
			}
			if (type == typeof(LoginNoticeEx))
			{
				return this.Create_LoginNoticeEx(options);
			}
			if (type == typeof(Result))
			{
				return this.Create_Result(options);
			}
			if (type == typeof(ResultData))
			{
				return this.Create_ResultData(options);
			}
			if (type == typeof(Dictionary<int, double>))
			{
				return this.Create_DictionaryInt32Double(options);
			}
			if (type == typeof(Dictionary<string, double>))
			{
				return this.Create_DictionaryStringDouble(options);
			}
			if (type == typeof(Dictionary<string, IUdpRegion>))
			{
				return this.Create_DictionaryStringIUdpRegion(options);
			}
			if (type == typeof(Dictionary<string, PatchManifestJson>))
			{
				return this.Create_DictionaryStringPatchManifestJson(options);
			}
			if (type == typeof(Dictionary<string, VideoItem>))
			{
				return this.Create_DictionaryStringVideoItem(options);
			}
			if (type == typeof(Dictionary<string, CsLinkEntry>))
			{
				return this.Create_DictionaryStringCsLinkEntry(options);
			}
			if (type == typeof(Dictionary<string, VersionItem>))
			{
				return this.Create_DictionaryStringVersionItem(options);
			}
			if (type == typeof(Dictionary<string, object>))
			{
				return this.Create_DictionaryStringObject(options);
			}
			if (type == typeof(Dictionary<string, string>))
			{
				return this.Create_DictionaryStringString(options);
			}
			if (type == typeof(List<NetHostInfo>))
			{
				return this.Create_ListNetHostInfo(options);
			}
			if (type == typeof(List<ICdnScoreFormula>))
			{
				return this.Create_ListICdnScoreFormula(options);
			}
			if (type == typeof(List<ICdnScoreStep>))
			{
				return this.Create_ListICdnScoreStep(options);
			}
			if (type == typeof(List<ICdnUrlData>))
			{
				return this.Create_ListICdnUrlData(options);
			}
			if (type == typeof(List<IGrayBoxItemConfig>))
			{
				return this.Create_ListIGrayBoxItemConfig(options);
			}
			if (type == typeof(List<ILoginServersData>))
			{
				return this.Create_ListILoginServersData(options);
			}
			if (type == typeof(List<IUdpProbe>))
			{
				return this.Create_ListIUdpProbe(options);
			}
			if (type == typeof(List<IBlockDataContent>))
			{
				return this.Create_ListIBlockDataContent(options);
			}
			if (type == typeof(List<IQueryGoodsResponseData>))
			{
				return this.Create_ListIQueryGoodsResponseData(options);
			}
			if (type == typeof(List<UserRegionInfo>))
			{
				return this.Create_ListUserRegionInfo(options);
			}
			if (type == typeof(List<ResourcePackagePositionData>))
			{
				return this.Create_ListResourcePackagePositionData(options);
			}
			if (type == typeof(List<VersionItem>))
			{
				return this.Create_ListVersionItem(options);
			}
			if (type == typeof(List<int>))
			{
				return this.Create_ListInt32(options);
			}
			if (type == typeof(List<string>))
			{
				return this.Create_ListString(options);
			}
			if (type == typeof(List<uint>))
			{
				return this.Create_ListUInt32(options);
			}
			if (type == typeof(JsonElement))
			{
				return this.Create_JsonElement(options);
			}
			if (type == typeof(JsonElement?))
			{
				return this.Create_NullableJsonElement(options);
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
			if (type == typeof(long?))
			{
				return this.Create_NullableInt64(options);
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
			if (type == typeof(uint))
			{
				return this.Create_UInt32(options);
			}
			return null;
		}

		// Token: 0x04000255 RID: 597
		[Nullable(2)]
		private JsonTypeInfo<bool> _Boolean;

		// Token: 0x04000256 RID: 598
		[Nullable(2)]
		private JsonTypeInfo<bool?> _NullableBoolean;

		// Token: 0x04000257 RID: 599
		[Nullable(2)]
		private JsonTypeInfo<double> _Double;

		// Token: 0x04000258 RID: 600
		[Nullable(2)]
		private JsonTypeInfo<float> _Single;

		// Token: 0x04000259 RID: 601
		[Nullable(2)]
		private JsonTypeInfo<float?> _NullableSingle;

		// Token: 0x0400025A RID: 602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<GatewayLatencyConfigVo> _GatewayLatencyConfigVo;

		// Token: 0x0400025B RID: 603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<NetHostInfo> _NetHostInfo;

		// Token: 0x0400025C RID: 604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<EntryJson> _EntryJson;

		// Token: 0x0400025D RID: 605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ICdnScoreCfg> _ICdnScoreCfg;

		// Token: 0x0400025E RID: 606
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ICdnScoreFormula> _ICdnScoreFormula;

		// Token: 0x0400025F RID: 607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ICdnScoreStep> _ICdnScoreStep;

		// Token: 0x04000260 RID: 608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ICdnUrlData> _ICdnUrlData;

		// Token: 0x04000261 RID: 609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IEvalConfig> _IEvalConfig;

		// Token: 0x04000262 RID: 610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IEvalNetworkConfig> _IEvalNetworkConfig;

		// Token: 0x04000263 RID: 611
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IGachaUrl> _IGachaUrl;

		// Token: 0x04000264 RID: 612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IGrayBoxConfig> _IGrayBoxConfig;

		// Token: 0x04000265 RID: 613
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IGrayBoxItemConfig> _IGrayBoxItemConfig;

		// Token: 0x04000266 RID: 614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ILoginServersData> _ILoginServersData;

		// Token: 0x04000267 RID: 615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ILogReport> _ILogReport;

		// Token: 0x04000268 RID: 616
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IPrivateServersData> _IPrivateServersData;

		// Token: 0x04000269 RID: 617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ITDConfig> _ITDConfig;

		// Token: 0x0400026A RID: 618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IUdpProbe> _IUdpProbe;

		// Token: 0x0400026B RID: 619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IUdpRegion> _IUdpRegion;

		// Token: 0x0400026C RID: 620
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IUpdateUrl> _IUpdateUrl;

		// Token: 0x0400026D RID: 621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<PatchManifest> _PatchManifest;

		// Token: 0x0400026E RID: 622
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<PatchManifestJson> _PatchManifestJson;

		// Token: 0x0400026F RID: 623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RemotePakMapConfig> _RemotePakMapConfig;

		// Token: 0x04000270 RID: 624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RemoteVideoConfig> _RemoteVideoConfig;

		// Token: 0x04000271 RID: 625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RemoteVideoConfigUpdateTime> _RemoteVideoConfigUpdateTime;

		// Token: 0x04000272 RID: 626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<VideoItem> _VideoItem;

		// Token: 0x04000273 RID: 627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<GameWindowStateData> _GameWindowStateData;

		// Token: 0x04000274 RID: 628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<UserInfo> _UserInfo;

		// Token: 0x04000275 RID: 629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ILocalSendedSave> _ILocalSendedSave;

		// Token: 0x04000276 RID: 630
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<INetworkDetectionConfig> _INetworkDetectionConfig;

		// Token: 0x04000277 RID: 631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<BilibiliParam> _BilibiliParam;

		// Token: 0x04000278 RID: 632
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ClientSwitch> _ClientSwitch;

		// Token: 0x04000279 RID: 633
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ClientUrl> _ClientUrl;

		// Token: 0x0400027A RID: 634
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<CsLinkEntry> _CsLinkEntry;

		// Token: 0x0400027B RID: 635
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<DouyinParam> _DouyinParam;

		// Token: 0x0400027C RID: 636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IBlockData> _IBlockData;

		// Token: 0x0400027D RID: 637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IBlockDataContent> _IBlockDataContent;

		// Token: 0x0400027E RID: 638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IBlockResponseData> _IBlockResponseData;

		// Token: 0x0400027F RID: 639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ICheckoutProductResponse> _ICheckoutProductResponse;

		// Token: 0x04000280 RID: 640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IConfigJson> _IConfigJson;

		// Token: 0x04000281 RID: 641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IConnectResponse> _IConnectResponse;

		// Token: 0x04000282 RID: 642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IConnectResponseData> _IConnectResponseData;

		// Token: 0x04000283 RID: 643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IGetAccessTokenResponse> _IGetAccessTokenResponse;

		// Token: 0x04000284 RID: 644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IGetAccessTokenResponseData> _IGetAccessTokenResponseData;

		// Token: 0x04000285 RID: 645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IIdTokenData> _IIdTokenData;

		// Token: 0x04000286 RID: 646
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ILoginResponse> _ILoginResponse;

		// Token: 0x04000287 RID: 647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ILoginResponseData> _ILoginResponseData;

		// Token: 0x04000288 RID: 648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IPlatformData> _IPlatformData;

		// Token: 0x04000289 RID: 649
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IPlatformReleaseData> _IPlatformReleaseData;

		// Token: 0x0400028A RID: 650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IQueryGoodsResponse> _IQueryGoodsResponse;

		// Token: 0x0400028B RID: 651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IQueryGoodsResponseData> _IQueryGoodsResponseData;

		// Token: 0x0400028C RID: 652
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IRenewAccessTokenResponse> _IRenewAccessTokenResponse;

		// Token: 0x0400028D RID: 653
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IRenewAccessTokenResponseData> _IRenewAccessTokenResponseData;

		// Token: 0x0400028E RID: 654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<IReportResponse> _IReportResponse;

		// Token: 0x0400028F RID: 655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ISdkRequestEmailCodeResponse> _ISdkRequestEmailCodeResponse;

		// Token: 0x04000290 RID: 656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<KujiequParam> _KujiequParam;

		// Token: 0x04000291 RID: 657
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<LoginElement> _LoginElement;

		// Token: 0x04000292 RID: 658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<QQParam> _QQParam;

		// Token: 0x04000293 RID: 659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<SdkPlatformConfig> _SdkPlatformConfig;

		// Token: 0x04000294 RID: 660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ShareSDKParam> _ShareSDKParam;

		// Token: 0x04000295 RID: 661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ThirdLogin> _ThirdLogin;

		// Token: 0x04000296 RID: 662
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ThirdShareParams> _ThirdShareParams;

		// Token: 0x04000297 RID: 663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<WeChatParam> _WeChatParam;

		// Token: 0x04000298 RID: 664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<WeiboParam> _WeiboParam;

		// Token: 0x04000299 RID: 665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<PreDownloadConfig> _PreDownloadConfig;

		// Token: 0x0400029A RID: 666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RemoteConfig> _RemoteConfig;

		// Token: 0x0400029B RID: 667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<RemoteVersionConfig> _RemoteVersionConfig;

		// Token: 0x0400029C RID: 668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<LoginPlayerInfo> _LoginPlayerInfo;

		// Token: 0x0400029D RID: 669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<UserRegionInfo> _UserRegionInfo;

		// Token: 0x0400029E RID: 670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<HttpSubPackageResult> _HttpSubPackageResult;

		// Token: 0x0400029F RID: 671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ResourcePackagePositionData> _ResourcePackagePositionData;

		// Token: 0x040002A0 RID: 672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<PakListConfig> _PakListConfig;

		// Token: 0x040002A1 RID: 673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<VersionItem> _VersionItem;

		// Token: 0x040002A2 RID: 674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<HttpResult> _HttpResult;

		// Token: 0x040002A3 RID: 675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<LoginNoticeEx> _LoginNoticeEx;

		// Token: 0x040002A4 RID: 676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Result> _Result;

		// Token: 0x040002A5 RID: 677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<ResultData> _ResultData;

		// Token: 0x040002A6 RID: 678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<Dictionary<int, double>> _DictionaryInt32Double;

		// Token: 0x040002A7 RID: 679
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, double>> _DictionaryStringDouble;

		// Token: 0x040002A8 RID: 680
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, IUdpRegion>> _DictionaryStringIUdpRegion;

		// Token: 0x040002A9 RID: 681
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, PatchManifestJson>> _DictionaryStringPatchManifestJson;

		// Token: 0x040002AA RID: 682
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, VideoItem>> _DictionaryStringVideoItem;

		// Token: 0x040002AB RID: 683
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, CsLinkEntry>> _DictionaryStringCsLinkEntry;

		// Token: 0x040002AC RID: 684
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, VersionItem>> _DictionaryStringVersionItem;

		// Token: 0x040002AD RID: 685
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, object>> _DictionaryStringObject;

		// Token: 0x040002AE RID: 686
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private JsonTypeInfo<Dictionary<string, string>> _DictionaryStringString;

		// Token: 0x040002AF RID: 687
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<NetHostInfo>> _ListNetHostInfo;

		// Token: 0x040002B0 RID: 688
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<ICdnScoreFormula>> _ListICdnScoreFormula;

		// Token: 0x040002B1 RID: 689
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<ICdnScoreStep>> _ListICdnScoreStep;

		// Token: 0x040002B2 RID: 690
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<ICdnUrlData>> _ListICdnUrlData;

		// Token: 0x040002B3 RID: 691
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<IGrayBoxItemConfig>> _ListIGrayBoxItemConfig;

		// Token: 0x040002B4 RID: 692
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<ILoginServersData>> _ListILoginServersData;

		// Token: 0x040002B5 RID: 693
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<IUdpProbe>> _ListIUdpProbe;

		// Token: 0x040002B6 RID: 694
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<IBlockDataContent>> _ListIBlockDataContent;

		// Token: 0x040002B7 RID: 695
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<IQueryGoodsResponseData>> _ListIQueryGoodsResponseData;

		// Token: 0x040002B8 RID: 696
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<UserRegionInfo>> _ListUserRegionInfo;

		// Token: 0x040002B9 RID: 697
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<ResourcePackagePositionData>> _ListResourcePackagePositionData;

		// Token: 0x040002BA RID: 698
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<VersionItem>> _ListVersionItem;

		// Token: 0x040002BB RID: 699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<List<int>> _ListInt32;

		// Token: 0x040002BC RID: 700
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<List<string>> _ListString;

		// Token: 0x040002BD RID: 701
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<List<uint>> _ListUInt32;

		// Token: 0x040002BE RID: 702
		[Nullable(2)]
		private JsonTypeInfo<JsonElement> _JsonElement;

		// Token: 0x040002BF RID: 703
		[Nullable(2)]
		private JsonTypeInfo<JsonElement?> _NullableJsonElement;

		// Token: 0x040002C0 RID: 704
		[Nullable(2)]
		private JsonTypeInfo<int> _Int32;

		// Token: 0x040002C1 RID: 705
		[Nullable(2)]
		private JsonTypeInfo<int?> _NullableInt32;

		// Token: 0x040002C2 RID: 706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<int[]> _Int32Array;

		// Token: 0x040002C3 RID: 707
		[Nullable(2)]
		private JsonTypeInfo<long> _Int64;

		// Token: 0x040002C4 RID: 708
		[Nullable(2)]
		private JsonTypeInfo<long?> _NullableInt64;

		// Token: 0x040002C5 RID: 709
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<object> _Object;

		// Token: 0x040002C6 RID: 710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private JsonTypeInfo<string> _String;

		// Token: 0x040002C7 RID: 711
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private JsonTypeInfo<string[]> _StringArray;

		// Token: 0x040002C8 RID: 712
		[Nullable(2)]
		private JsonTypeInfo<uint> _UInt32;

		// Token: 0x040002C9 RID: 713
		[Nullable(1)]
		private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			IncludeFields = true
		};

		// Token: 0x040002CA RID: 714
		private const BindingFlags InstanceMemberBindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
