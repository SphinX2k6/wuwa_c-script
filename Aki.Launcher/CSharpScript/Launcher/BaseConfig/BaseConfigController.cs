using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025B RID: 603
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseConfigController : Singleton
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00059BB4 File Offset: 0x00057DB4
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x00059BBC File Offset: 0x00057DBC
		public long GarUrlVersion { get; private set; }

		// Token: 0x06000F26 RID: 3878 RVA: 0x00059BC8 File Offset: 0x00057DC8
		[NullableContext(0)]
		public UniTask<bool> RequestBaseData([Nullable(1)] HotFixManager view = null)
		{
			BaseConfigController.<RequestBaseData>d__9 <RequestBaseData>d__;
			<RequestBaseData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBaseData>d__.<>4__this = this;
			<RequestBaseData>d__.view = view;
			<RequestBaseData>d__.<>1__state = -1;
			<RequestBaseData>d__.<>t__builder.Start<BaseConfigController.<RequestBaseData>d__9>(ref <RequestBaseData>d__);
			return <RequestBaseData>d__.<>t__builder.Task;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00059C14 File Offset: 0x00057E14
		private unsafe void ApplyVulkanSettingsFromCdn()
		{
			if (!Platform.Instance.IsAndroidPlatform() || Platform.Instance.IsCloudGame())
			{
				return;
			}
			string deviceProfileProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileProfileName();
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			Dictionary<string, VulkanSettingConfig> dictionary = (cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.VulkanSettings : null;
			VulkanSettingConfig vulkanSettingConfig;
			bool flag = dictionary == null || !dictionary.TryGetValue(deviceProfileProfileName, out vulkanSettingConfig) || vulkanSettingConfig == null;
			if (!flag)
			{
				int? defaultValue = vulkanSettingConfig.DefaultValue;
				bool flag2;
				if (defaultValue != null)
				{
					int valueOrDefault = defaultValue.GetValueOrDefault();
					if (valueOrDefault <= 1)
					{
						flag2 = true;
						goto IL_74;
					}
				}
				flag2 = false;
				IL_74:
				flag = !flag2;
			}
			if (flag || !(vulkanSettingConfig.Revision > 0))
			{
				return;
			}
			int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.VulkanSettingRefreshRevision");
			int valueOrDefault2 = LauncherStorageLib.Instance.GetGlobal<int?>(ELauncherStorageGlobalKey.VulkanRefreshRevision, null).GetValueOrDefault();
			if (vulkanSettingConfig.Revision.Value <= consoleVariableIntValue || vulkanSettingConfig.Revision.Value <= valueOrDefault2)
			{
				return;
			}
			UKuroRenderingRuntimeBPPluginBPLibrary.SetVulkanPromotion(vulkanSettingConfig.DefaultValue.Value > 0);
			LauncherLog instance = LauncherLog.Instance;
			string message = "CDN Vulkan配置已请求写入，下次启动生效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("profileName", deviceProfileProfileName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("revision", vulkanSettingConfig.Revision.Value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("defaultValue", vulkanSettingConfig.DefaultValue.Value);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00059DA0 File Offset: 0x00057FA0
		private Dictionary<string, EntryJson> ParseEntryMap(string contentJson)
		{
			Dictionary<string, EntryJson> result;
			using (JsonDocument jsonDocument = JsonDocument.Parse(contentJson, default(JsonDocumentOptions)))
			{
				result = this.ParseEntryMap(jsonDocument.RootElement);
			}
			return result;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00059DE8 File Offset: 0x00057FE8
		private Dictionary<string, EntryJson> ParseEntryMap(JsonElement rootElement)
		{
			Dictionary<string, EntryJson> dictionary = new Dictionary<string, EntryJson>();
			foreach (JsonProperty jsonProperty in rootElement.EnumerateObject())
			{
				if (jsonProperty.Value.ValueKind == JsonValueKind.Object)
				{
					EntryJson entryJson = LauncherJson.Parse<EntryJson>(jsonProperty.Value, null);
					if (entryJson != null)
					{
						dictionary.Add(jsonProperty.Name, entryJson);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00059E74 File Offset: 0x00058074
		private unsafe void ParseGrayBox()
		{
			IGrayBoxConfig grayBox = this.GetCdnReturnConfigInfo().GrayBox;
			if (grayBox == null)
			{
				LauncherLog.Instance.Debug("ParseGrayBox: 没有灰度配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (grayBox.Items == null || grayBox.Items.Count == 0)
			{
				LauncherLog.Instance.Error("ParseGrayBox: 灰度配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			for (int i = 0; i < grayBox.Items.Count; i++)
			{
				IGrayBoxItemConfig grayBoxItemConfig = grayBox.Items[i];
				if (grayBoxItemConfig.Name == null || grayBoxItemConfig.Name.Length == 0)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "Name参数无效";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Content", LauncherJson.Stringify(grayBoxItemConfig, null));
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else if (BaseConfigModel.Instance.GrayBoxConfigMap.ContainsKey(grayBoxItemConfig.Name))
				{
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "存在相同的Name";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Content", LauncherJson.Stringify(grayBoxItemConfig, null));
					instance2.Error(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					if (grayBoxItemConfig.Divisor != null)
					{
						int? num = grayBoxItemConfig.Divisor;
						int num2 = 1;
						if (num.GetValueOrDefault() <= num2 & num != null)
						{
							LauncherLog instance3 = LauncherLog.Instance;
							string message3 = "Divisor必须大于1";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Divisor", grayBoxItemConfig.Divisor);
							instance3.Error(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
							goto IL_539;
						}
						if (grayBoxItemConfig.Left == null)
						{
							LauncherLog instance4 = LauncherLog.Instance;
							string message4 = "Left参数无效";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Left", grayBoxItemConfig.Left);
							instance4.Error(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
							goto IL_539;
						}
						if (grayBoxItemConfig.Right == null)
						{
							LauncherLog instance5 = LauncherLog.Instance;
							string message5 = "Right参数无效";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("Right", grayBoxItemConfig.Right);
							instance5.Error(message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
							goto IL_539;
						}
						num = grayBoxItemConfig.Left;
						int? right = grayBoxItemConfig.Right;
						if (num.GetValueOrDefault() >= right.GetValueOrDefault() & (num != null & right != null))
						{
							LauncherLog instance6 = LauncherLog.Instance;
							string message6 = "Left必须小于Right的值";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("Left", grayBoxItemConfig.Left);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 2) = new ValueTuple<string, object>("Right", grayBoxItemConfig.Right);
							instance6.Error(message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 3));
							goto IL_539;
						}
						right = grayBoxItemConfig.Right;
						num = grayBoxItemConfig.Divisor;
						if (right.GetValueOrDefault() > num.GetValueOrDefault() & (right != null & num != null))
						{
							LauncherLog instance7 = LauncherLog.Instance;
							string message7 = "Right必须小于等于Divisor的值";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray7 = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 1) = new ValueTuple<string, object>("Right", grayBoxItemConfig.Right);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 2) = new ValueTuple<string, object>("Divisor", grayBoxItemConfig.Divisor);
							instance7.Error(message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray7, 3));
							goto IL_539;
						}
					}
					IGrayBoxItem grayBoxItem = new IGrayBoxItem
					{
						Divisor = grayBoxItemConfig.Divisor.GetValueOrDefault(),
						Left = grayBoxItemConfig.Left.GetValueOrDefault(),
						Right = grayBoxItemConfig.Right.GetValueOrDefault()
					};
					if (grayBoxItemConfig.Ids != null && grayBoxItemConfig.Ids.Count > 0)
					{
						grayBoxItem.PlayerIds = new HashSet<int>();
						for (int j = 0; j < grayBoxItemConfig.Ids.Count; j++)
						{
							grayBoxItem.PlayerIds.Add(grayBoxItemConfig.Ids[j]);
						}
					}
					BaseConfigModel.Instance.GrayBoxConfigMap[grayBoxItemConfig.Name] = grayBoxItem;
					LauncherLog instance8 = LauncherLog.Instance;
					string message8 = "ParseGrayBox: 添加灰度配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
					instance8.Debug(message8, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				IL_539:;
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0005A3D4 File Offset: 0x000585D4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<IResponse> DoRequest(List<string> httpList, Func<string, string> getHttpFunction, [Nullable(2)] HotFixManager view, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Func<string, IResponse, bool> resolveFunc = null)
		{
			BaseConfigController.<DoRequest>d__14 <DoRequest>d__;
			<DoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<IResponse>.Create();
			<DoRequest>d__.httpList = httpList;
			<DoRequest>d__.getHttpFunction = getHttpFunction;
			<DoRequest>d__.view = view;
			<DoRequest>d__.resolveFunc = resolveFunc;
			<DoRequest>d__.<>1__state = -1;
			<DoRequest>d__.<>t__builder.Start<BaseConfigController.<DoRequest>d__14>(ref <DoRequest>d__);
			return <DoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0005A430 File Offset: 0x00058630
		public unsafe bool CheckGrayBoxHit(string name, int playerId)
		{
			if (string.IsNullOrEmpty(name))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "name参数无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerId", playerId);
				instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (playerId == 0)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "playerId参数无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PlayerId", playerId);
				instance2.Error(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			EHitResult ehitResult;
			if (BaseConfigModel.Instance.BoxResultMap.TryGetValue(name, out ehitResult))
			{
				return ehitResult == EHitResult.Hit;
			}
			IGrayBoxItem grayBoxItem;
			if (!BaseConfigModel.Instance.GrayBoxConfigMap.TryGetValue(name, out grayBoxItem))
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "不存在GrayBox数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("PlayerId", playerId);
				instance3.Error(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return false;
			}
			if (grayBoxItem.Divisor != 0)
			{
				int num = playerId % grayBoxItem.Divisor;
				if (num >= grayBoxItem.Left && num < grayBoxItem.Right)
				{
					BaseConfigModel.Instance.BoxResultMap[name] = EHitResult.Hit;
					return true;
				}
			}
			if (grayBoxItem.PlayerIds != null && grayBoxItem.PlayerIds.Count > 0 && grayBoxItem.PlayerIds.Contains(playerId))
			{
				BaseConfigModel.Instance.BoxResultMap[name] = EHitResult.Hit;
				return true;
			}
			BaseConfigModel.Instance.BoxResultMap[name] = EHitResult.Miss;
			return false;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0005A5FC File Offset: 0x000587FC
		public unsafe bool CheckGrayBoxHitByDeviceId(string name, string deviceId)
		{
			if (string.IsNullOrEmpty(name))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "灰度检查: name参数无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DeviceId", deviceId);
				instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (string.IsNullOrEmpty(deviceId))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "灰度检查: deviceId参数无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("DeviceId", deviceId);
				instance2.Error(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			EHitResult ehitResult;
			if (BaseConfigModel.Instance.BoxResultMap.TryGetValue(name, out ehitResult))
			{
				return ehitResult == EHitResult.Hit;
			}
			IGrayBoxItem grayBoxItem;
			if (!BaseConfigModel.Instance.GrayBoxConfigMap.TryGetValue(name, out grayBoxItem))
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "灰度检查: 不存在GrayBox数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
				instance3.Warn(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (grayBoxItem.Divisor != 0)
			{
				string text = UKuroStaticLibrary.HashStringWithSHA1(deviceId);
				if (string.IsNullOrEmpty(text))
				{
					LauncherLog instance4 = LauncherLog.Instance;
					string message4 = "灰度检查: deviceId的SHA1值不合法";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Name", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("DeviceId", deviceId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("SHA1", text ?? "");
					instance4.Error(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
					return false;
				}
				int num = (int)(Convert.ToInt64(text.Substring(0, 8), 16) % (long)grayBoxItem.Divisor);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (num >= grayBoxItem.Left && num < grayBoxItem.Right)
				{
					BaseConfigModel.Instance.BoxResultMap[name] = EHitResult.Hit;
					LauncherLog instance5 = LauncherLog.Instance;
					string message5 = "灰度检查: 命中";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Name", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("DeviceId", deviceId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Mod", num);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3);
					string item = "Range";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(grayBoxItem.Left);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(grayBoxItem.Right);
					ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("Percent", ((float)(grayBoxItem.Right - grayBoxItem.Left) / (float)grayBoxItem.Divisor * 100f).ToString() + "%");
					instance5.Info(message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 5));
					return true;
				}
				LauncherLog instance6 = LauncherLog.Instance;
				string message6 = "灰度检查: 未命中";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("Name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("DeviceId", deviceId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("Mod", num);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3);
				string item2 = "Range";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(grayBoxItem.Left);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(grayBoxItem.Right);
				ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("Percent", ((float)(grayBoxItem.Right - grayBoxItem.Left) / (float)grayBoxItem.Divisor * 100f).ToString() + "%");
				instance6.Info(message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 5));
			}
			BaseConfigModel.Instance.BoxResultMap[name] = EHitResult.Miss;
			return false;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0005A9F6 File Offset: 0x00058BF6
		[NullableContext(2)]
		public EntryJson GetCdnReturnConfigInfo()
		{
			return BaseConfigModel.Instance.EntryJson;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0005AA02 File Offset: 0x00058C02
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICdnUrlData> GetCdnUrl()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return ((cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.CdnUrl : null) ?? null;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0005AA1C File Offset: 0x00058C1C
		public float? GetSpeedRatio()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.SpeedRatio;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0005AA44 File Offset: 0x00058C44
		public float? GetPriceRatio()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.PriceRatio;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0005AA6A File Offset: 0x00058C6A
		[NullableContext(2)]
		public IEvalConfig GetCdnEvalCfg()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.CdnEvalCfg;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0005AA7D File Offset: 0x00058C7D
		[NullableContext(2)]
		public ICdnScoreCfg GetCdnScoreCfg()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.CdnScoreCfg;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0005AA90 File Offset: 0x00058C90
		[NullableContext(2)]
		public string GetNoticeUrl()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.NoticeUrl;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0005AAA4 File Offset: 0x00058CA4
		[NullableContext(2)]
		public string GetGARUrl()
		{
			string[] garurls = this.GetGARUrls();
			if (garurls.Length == 0)
			{
				return null;
			}
			this.GarUrlIndex %= garurls.Length;
			return garurls[this.GarUrlIndex];
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0005AAD8 File Offset: 0x00058CD8
		public void SetGARRequestResult(bool success, long requestVersion)
		{
			if (success || requestVersion != this.GarUrlVersion)
			{
				return;
			}
			string[] garurls = this.GetGARUrls();
			if (garurls.Length <= 1)
			{
				return;
			}
			this.GarUrlIndex = (this.GarUrlIndex + 1) % garurls.Length;
			long garUrlVersion = this.GarUrlVersion;
			this.GarUrlVersion = garUrlVersion + 1L;
			LauncherLog instance = LauncherLog.Instance;
			string message = "切换GAR地址";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GARUrl", garurls[this.GarUrlIndex]);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0005AB50 File Offset: 0x00058D50
		private string[] GetGARUrls()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			string[] array = (cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.GARUrls : null;
			if (array != null && array.Length > 0)
			{
				List<string> list = new List<string>();
				HashSet<string> hashSet = new HashSet<string>();
				foreach (string text in array)
				{
					if (!string.IsNullOrEmpty(text) && hashSet.Add(text))
					{
						list.Add(text);
					}
				}
				if (list.Count > 0)
				{
					return list.ToArray();
				}
			}
			if (string.IsNullOrEmpty((cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.GARUrl : null))
			{
				return Array.Empty<string>();
			}
			return new string[]
			{
				cdnReturnConfigInfo.GARUrl
			};
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0005ABF8 File Offset: 0x00058DF8
		public bool GetGmIsOpen()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.GmOpen.GetValueOrDefault();
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0005AC1C File Offset: 0x00058E1C
		public bool GetRptIsOpen()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return ((cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.RptOpen : null).GetValueOrDefault(true);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0005AC4C File Offset: 0x00058E4C
		public bool IsUseThreadCheck()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.AsyncCheck.GetValueOrDefault();
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0005AC70 File Offset: 0x00058E70
		public bool IsUseNewHttpTimer()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.NewHttpTimer.GetValueOrDefault();
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0005AC94 File Offset: 0x00058E94
		public bool IsUseNewHttpApi()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.NewHttpApi.GetValueOrDefault();
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0005ACB8 File Offset: 0x00058EB8
		public bool GetIosAuditFirstDownloadTip()
		{
			string a = KuroApplication.IniPlatformName();
			if (a != "IOS" && a != "Mac")
			{
				return false;
			}
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.IosAuditFirstDownloadTip.GetValueOrDefault();
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0005AD00 File Offset: 0x00058F00
		public bool GetIosAuditFirstDownloadTipWithSkip()
		{
			string a = KuroApplication.IniPlatformName();
			if (a != "IOS" && a != "Mac")
			{
				return false;
			}
			bool flag = false;
			UKuroVariableFunctionLibrary.GetBoolValue("IosAuditNeedHotPatch", ref flag);
			return !flag && this.GetIosAuditFirstDownloadTip();
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0005AD49 File Offset: 0x00058F49
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> GetSdkEnvironment()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.SDKEnvironment;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0005AD5C File Offset: 0x00058F5C
		public string GetMixUri()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return "";
			}
			return cdnReturnConfigInfo.MixUri ?? "";
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0005AD88 File Offset: 0x00058F88
		public string GetResUri()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return "";
			}
			return cdnReturnConfigInfo.ResUri ?? "";
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0005ADB4 File Offset: 0x00058FB4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ILoginServersData> GetLoginServers()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.LoginServers;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		[return: Nullable(2)]
		public ILoginServersData GetLoginServerById(string serverId)
		{
			List<ILoginServersData> loginServers = this.GetLoginServers();
			if (loginServers != null)
			{
				int count = loginServers.Count;
				for (int i = 0; i < count; i++)
				{
					if (serverId == loginServers[i].id)
					{
						return loginServers[i];
					}
				}
			}
			return null;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0005AE0F File Offset: 0x0005900F
		[NullableContext(2)]
		public IGachaUrl GetGachaUrl()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.GachaUrl;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0005AE22 File Offset: 0x00059022
		[NullableContext(2)]
		public IFeedBackData GetFeedBackUrl()
		{
			return null;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0005AE25 File Offset: 0x00059025
		[NullableContext(2)]
		public IPrivateServersData GetPrivateServers()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.PrivateServers;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0005AE38 File Offset: 0x00059038
		public string GetPublicValue(TPublicConfigKey key)
		{
			return this.GetPublicValue(key.ToEnumString());
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0005AE48 File Offset: 0x00059048
		public string GetPublicValue(string key)
		{
			if (!BaseConfigModel.Instance.PublicConfigLoaded)
			{
				TArray<string> tarray = UKuroStaticLibrary.LoadFileToStringArray(BaseDefine.GetPublicConfigPath());
				for (int i = 0; i < tarray.Num(); i++)
				{
					string[] array = tarray.Get(i).Split('=', StringSplitOptions.None);
					BaseConfigModel.Instance.BaseConfig[array[0]] = array[1];
				}
				BaseConfigModel.Instance.PublicConfigLoaded = true;
			}
			string text;
			if (!BaseConfigModel.Instance.BaseConfig.TryGetValue(key, out text))
			{
				return "";
			}
			string text2 = (text != null) ? text.Trim() : null;
			if (string.IsNullOrEmpty(text2))
			{
				return "";
			}
			return text2;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0005AEE8 File Offset: 0x000590E8
		private unsafe string BuildHttp(string http)
		{
			string packageConfigOrDefault = this.GetPackageConfigOrDefault(TBuildInfoKey.Stream, null);
			string item = KuroApplication.IsWithEditor() ? "editor" : "pack";
			string appReleaseType = KuroApplication.GetAppReleaseType();
			string item2 = (this.GetPublicValue(TPublicConfigKey.UseSDK) == "1") ? "sdkon" : "sdkoff";
			string appInternalUseType = UKuroLauncherLibrary.GetAppInternalUseType();
			string buildHttpGameVersion = this.GetBuildHttpGameVersion();
			LauncherLog instance = LauncherLog.Instance;
			string message = "包构建参数";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("branch", packageConfigOrDefault);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("platform", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("edition", appReleaseType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("sdk", item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("internalUseType", appInternalUseType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("version", buildHttpGameVersion);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			string publicValue = this.GetPublicValue(TPublicConfigKey.UrlPath);
			string text = http + "/" + publicValue + "/index.json";
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "创建的cdn1地址";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("newHttp", text);
			instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return text;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0005B03D File Offset: 0x0005923D
		private string GetBuildHttpGameVersion()
		{
			return UKuroLauncherLibrary.GetAppVersion();
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0005B044 File Offset: 0x00059244
		public string GetPackageConfigOrDefault(TBuildInfoKey key, string value = null)
		{
			return this.GetPackageConfigOrDefault(key.ToEnumString(), value);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0005B054 File Offset: 0x00059254
		public string GetPackageConfigOrDefault(string key, string value = null)
		{
			if (!BaseConfigModel.Instance.ParamsConfigInited)
			{
				string path = UBlueprintPathsLibrary.ProjectConfigDir() + "/Package/ParamsConfig.ini";
				BaseConfigModel.Instance.ParamsConfigInited = this.LoadBuildInfoFromFile(path);
				if (!BaseConfigModel.Instance.ParamsConfigInited)
				{
					LauncherLog.Instance.Error("找不到ParamsConfig文件!", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.LoadConfigVersion();
				this.LoadPatchBuildInfo(false);
			}
			string text;
			if (BaseConfigModel.Instance.BuildInfoMap.TryGetValue(key, out text))
			{
				string result;
				if (string.IsNullOrEmpty(text))
				{
					result = value;
					if (value == null)
					{
						return "";
					}
				}
				else
				{
					result = text;
				}
				return result;
			}
			return value ?? "";
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0005B0F4 File Offset: 0x000592F4
		public string GetPackageClientFightConfig()
		{
			string filename = UBlueprintPathsLibrary.ProjectContentDir() + "/Aki/Config/Json/CompareFightData/ClientFightDataInfo.json";
			string text = "";
			UKuroStaticLibrary.LoadFileToString(ref text, filename);
			ClientFightConfigData clientFightConfigData = LauncherJson.Parse<ClientFightConfigData>(text, null);
			if (clientFightConfigData != null)
			{
				return clientFightConfigData.clientMd5;
			}
			return "";
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0005B138 File Offset: 0x00059338
		public void LoadPatchBuildInfo(bool isReload)
		{
			if (KuroApplication.IsWithEditor())
			{
				return;
			}
			string path = UBlueprintPathsLibrary.ProjectContentDir() + "/Aki/ConfigDB/Misc/BuildInfo.txt";
			if (!this.LoadBuildInfoFromFile(path))
			{
				string path2 = UBlueprintPathsLibrary.ProjectContentDir() + "/Aki/ConfigDB/PackageParams.txt";
				this.LoadBuildInfoFromFile(path2);
			}
			string packageConfigOrDefault = this.GetPackageConfigOrDefault(TBuildInfoKey.JSDebugId, null);
			LauncherLog.Instance.SetJsDebugId(packageConfigOrDefault);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0005B194 File Offset: 0x00059394
		private bool LoadBuildInfoFromFile(string path)
		{
			TArray<string> tarray = UKuroStaticLibrary.LoadFileToStringArray(path);
			for (int i = 0; i < tarray.Num(); i++)
			{
				string text = tarray.Get(i);
				string[] array = text.Split('=', StringSplitOptions.None);
				if (array != null && array.Length >= 2)
				{
					BaseConfigModel.Instance.BuildInfoMap[array[0].Trim()] = array[1].Trim();
				}
				else
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "无法解析数据";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("param", text);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			return tarray.Num() > 0;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0005B228 File Offset: 0x00059428
		public void LoadConfigVersion()
		{
			string path = UBlueprintPathsLibrary.ProjectContentDir() + "/Aki/ConfigDB/Misc/ConfigVersion.txt";
			this.LoadConfigVersionFromFile(path);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0005B250 File Offset: 0x00059450
		private bool LoadConfigVersionFromFile(string path)
		{
			TArray<string> tarray = UKuroStaticLibrary.LoadFileToStringArray(path);
			for (int i = 0; i < tarray.Num(); i++)
			{
				string text = tarray.Get(i);
				string[] array = text.Split('=', StringSplitOptions.None);
				if (array != null && array.Length >= 2)
				{
					BaseConfigModel.Instance.ConfigVersionMap[array[0].Trim()] = array[1].Trim();
				}
				else
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "无法解析数据";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("param", text);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			return tarray.Num() > 0;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0005B2E2 File Offset: 0x000594E2
		public string GetConfigVersion(TConfigVersionKey key)
		{
			return this.GetConfigVersion(key.ToEnumString());
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public string GetConfigVersion(string key)
		{
			string result;
			if (!BaseConfigModel.Instance.ConfigVersionMap.TryGetValue(key, out result))
			{
				return "";
			}
			return result;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0005B318 File Offset: 0x00059518
		public string GetP4Version()
		{
			string packageConfigOrDefault = this.GetPackageConfigOrDefault(TBuildInfoKey.Changelist, null);
			string deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchP4Version, null);
			RemoteInfo instance = RemoteInfo.Instance;
			string text;
			if (instance == null)
			{
				text = null;
			}
			else
			{
				RemoteVersionConfig newConfig = instance.NewConfig;
				text = ((newConfig != null) ? newConfig.ChangeList : null);
			}
			string text2 = text;
			if (!string.IsNullOrEmpty(deviceSaved))
			{
				return deviceSaved;
			}
			if (string.IsNullOrEmpty(text2) || text2.Length == 0)
			{
				return packageConfigOrDefault;
			}
			return text2;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0005B378 File Offset: 0x00059578
		public string GetPatchVersion()
		{
			string packageConfigOrDefault = this.GetPackageConfigOrDefault(TBuildInfoKey.PatchVersion, null);
			string deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, null);
			RemoteVersionConfig newConfig = RemoteInfo.Instance.NewConfig;
			VersionItem versionItem;
			string text = (((newConfig != null) ? newConfig.ResVersions : null) != null && RemoteInfo.Instance.NewConfig.ResVersions.TryGetValue("resource", out versionItem)) ? ((versionItem != null) ? versionItem.Version : null) : null;
			if (!string.IsNullOrEmpty(deviceSaved))
			{
				return deviceSaved;
			}
			if (string.IsNullOrEmpty(text))
			{
				return packageConfigOrDefault;
			}
			return text;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0005B3F8 File Offset: 0x000595F8
		public string GetVersionString()
		{
			string value = "CN";
			if (this.GetPublicValue(TPublicConfigKey.SdkArea) != "CN")
			{
				value = "OS";
			}
			string text = KuroApplication.IniPlatformName();
			if (text == "WinGDK" || text == "XSX")
			{
				text = "Xbox";
			}
			string value2 = text;
			string appReleaseType = KuroApplication.GetAppReleaseType();
			string appChangeList = UKuroLauncherLibrary.GetAppChangeList();
			string patchVersion = this.GetPatchVersion();
			string appVersion = UKuroLauncherLibrary.GetAppVersion();
			string p4Version = this.GetP4Version();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 7);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(appReleaseType);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(appVersion);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(appChangeList);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(patchVersion);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(p4Version);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x0005B504 File Offset: 0x00059704
		public static BaseConfigController Instance
		{
			get
			{
				if (BaseConfigController._instance == null)
				{
					BaseConfigController._instance = new BaseConfigController();
					BaseConfigController._instance.OnInit();
				}
				return BaseConfigController._instance;
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0005B527 File Offset: 0x00059727
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0005B529 File Offset: 0x00059729
		public static void ResetStaticDefaultValue()
		{
			BaseConfigController instance = BaseConfigController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BaseConfigController._instance = null;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0005B542 File Offset: 0x00059742
		static BaseConfigController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BaseConfigController.CreateStaticDefaultValue), new Action(BaseConfigController.ResetStaticDefaultValue));
		}

		// Token: 0x040009EB RID: 2539
		private const string BUILD_INFO_BASE_PACKAGE = "/Package/ParamsConfig.ini";

		// Token: 0x040009EC RID: 2540
		private const string BUILD_INFO_PATCH_OVERRIDE_OLD = "/Aki/ConfigDB/PackageParams.txt";

		// Token: 0x040009ED RID: 2541
		private const string BUILD_INFO_PATCH_OVERRIDE = "/Aki/ConfigDB/Misc/BuildInfo.txt";

		// Token: 0x040009EE RID: 2542
		private const string CONFIG_VERSION_PATCH_OVERRIDE = "/Aki/ConfigDB/Misc/ConfigVersion.txt";

		// Token: 0x040009EF RID: 2543
		private int GarUrlIndex;

		// Token: 0x040009F1 RID: 2545
		[Nullable(2)]
		private static BaseConfigController _instance;
	}
}
