using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000256 RID: 598
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseConfigController : Singleton
	{
		// Token: 0x06000EE3 RID: 3811 RVA: 0x00057070 File Offset: 0x00055270
		[NullableContext(0)]
		public UniTask<bool> RequestBaseData([Nullable(1)] HotFixManager view = null)
		{
			BaseConfigController.<RequestBaseData>d__4 <RequestBaseData>d__;
			<RequestBaseData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestBaseData>d__.<>4__this = this;
			<RequestBaseData>d__.view = view;
			<RequestBaseData>d__.<>1__state = -1;
			<RequestBaseData>d__.<>t__builder.Start<BaseConfigController.<RequestBaseData>d__4>(ref <RequestBaseData>d__);
			return <RequestBaseData>d__.<>t__builder.Task;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000570BC File Offset: 0x000552BC
		private Dictionary<string, EntryJson> ParseEntryMap(string contentJson)
		{
			Dictionary<string, EntryJson> result;
			using (JsonDocument jsonDocument = JsonDocument.Parse(contentJson, default(JsonDocumentOptions)))
			{
				result = this.ParseEntryMap(jsonDocument.RootElement);
			}
			return result;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00057104 File Offset: 0x00055304
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

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00057190 File Offset: 0x00055390
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
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Content", LauncherJson.Stringify<IGrayBoxItemConfig>(grayBoxItemConfig, null));
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else if (BaseConfigModel.Instance.GrayBoxConfigMap.ContainsKey(grayBoxItemConfig.Name))
				{
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "存在相同的Name";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Name", grayBoxItemConfig.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Content", LauncherJson.Stringify<IGrayBoxItemConfig>(grayBoxItemConfig, null));
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

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000576F0 File Offset: 0x000558F0
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
			BaseConfigController.<DoRequest>d__8 <DoRequest>d__;
			<DoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<IResponse>.Create();
			<DoRequest>d__.httpList = httpList;
			<DoRequest>d__.getHttpFunction = getHttpFunction;
			<DoRequest>d__.view = view;
			<DoRequest>d__.resolveFunc = resolveFunc;
			<DoRequest>d__.<>1__state = -1;
			<DoRequest>d__.<>t__builder.Start<BaseConfigController.<DoRequest>d__8>(ref <DoRequest>d__);
			return <DoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0005774C File Offset: 0x0005594C
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

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00057918 File Offset: 0x00055B18
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

		// Token: 0x06000EEA RID: 3818 RVA: 0x00057D12 File Offset: 0x00055F12
		[NullableContext(2)]
		public EntryJson GetCdnReturnConfigInfo()
		{
			return BaseConfigModel.Instance.EntryJson;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00057D1E File Offset: 0x00055F1E
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

		// Token: 0x06000EEC RID: 3820 RVA: 0x00057D38 File Offset: 0x00055F38
		public float? GetSpeedRatio()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.SpeedRatio;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00057D60 File Offset: 0x00055F60
		public float? GetPriceRatio()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.PriceRatio;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00057D86 File Offset: 0x00055F86
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

		// Token: 0x06000EEF RID: 3823 RVA: 0x00057D99 File Offset: 0x00055F99
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

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00057DAC File Offset: 0x00055FAC
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

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00057DBF File Offset: 0x00055FBF
		[NullableContext(2)]
		public string GetGARUrl()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return null;
			}
			return cdnReturnConfigInfo.GARUrl;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00057DD4 File Offset: 0x00055FD4
		public bool GetGmIsOpen()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.GmOpen.GetValueOrDefault();
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00057DF8 File Offset: 0x00055FF8
		public bool GetRptIsOpen()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return ((cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.RptOpen : null).GetValueOrDefault(true);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00057E28 File Offset: 0x00056028
		public bool IsUseThreadCheck()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.AsyncCheck.GetValueOrDefault();
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00057E4C File Offset: 0x0005604C
		public bool IsUseNewHttpTimer()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.NewHttpTimer.GetValueOrDefault();
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00057E70 File Offset: 0x00056070
		public bool IsUseNewHttpApi()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			return cdnReturnConfigInfo != null && cdnReturnConfigInfo.NewHttpApi.GetValueOrDefault();
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00057E94 File Offset: 0x00056094
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

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00057EDC File Offset: 0x000560DC
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

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00057F25 File Offset: 0x00056125
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

		// Token: 0x06000EFA RID: 3834 RVA: 0x00057F38 File Offset: 0x00056138
		public string GetMixUri()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return "";
			}
			return cdnReturnConfigInfo.MixUri ?? "";
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00057F64 File Offset: 0x00056164
		public string GetResUri()
		{
			EntryJson cdnReturnConfigInfo = this.GetCdnReturnConfigInfo();
			if (cdnReturnConfigInfo == null)
			{
				return "";
			}
			return cdnReturnConfigInfo.ResUri ?? "";
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00057F90 File Offset: 0x00056190
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

		// Token: 0x06000EFD RID: 3837 RVA: 0x00057FA4 File Offset: 0x000561A4
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

		// Token: 0x06000EFE RID: 3838 RVA: 0x00057FEB File Offset: 0x000561EB
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

		// Token: 0x06000EFF RID: 3839 RVA: 0x00057FFE File Offset: 0x000561FE
		[NullableContext(2)]
		public IFeedBackData GetFeedBackUrl()
		{
			return null;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00058001 File Offset: 0x00056201
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

		// Token: 0x06000F01 RID: 3841 RVA: 0x00058014 File Offset: 0x00056214
		public string GetPublicValue(TPublicConfigKey key)
		{
			return this.GetPublicValue(key.ToEnumString());
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00058024 File Offset: 0x00056224
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

		// Token: 0x06000F03 RID: 3843 RVA: 0x000580C4 File Offset: 0x000562C4
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

		// Token: 0x06000F04 RID: 3844 RVA: 0x00058219 File Offset: 0x00056419
		private string GetBuildHttpGameVersion()
		{
			return UKuroLauncherLibrary.GetAppVersion();
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00058220 File Offset: 0x00056420
		public string GetPackageConfigOrDefault(TBuildInfoKey key, string value = null)
		{
			return this.GetPackageConfigOrDefault(key.ToEnumString(), value);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00058230 File Offset: 0x00056430
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

		// Token: 0x06000F07 RID: 3847 RVA: 0x000582D0 File Offset: 0x000564D0
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

		// Token: 0x06000F08 RID: 3848 RVA: 0x00058314 File Offset: 0x00056514
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

		// Token: 0x06000F09 RID: 3849 RVA: 0x00058370 File Offset: 0x00056570
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

		// Token: 0x06000F0A RID: 3850 RVA: 0x00058404 File Offset: 0x00056604
		public void LoadConfigVersion()
		{
			string path = UBlueprintPathsLibrary.ProjectContentDir() + "/Aki/ConfigDB/Misc/ConfigVersion.txt";
			this.LoadConfigVersionFromFile(path);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0005842C File Offset: 0x0005662C
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

		// Token: 0x06000F0C RID: 3852 RVA: 0x000584BE File Offset: 0x000566BE
		public string GetConfigVersion(TConfigVersionKey key)
		{
			return this.GetConfigVersion(key.ToEnumString());
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000584CC File Offset: 0x000566CC
		public string GetConfigVersion(string key)
		{
			string result;
			if (!BaseConfigModel.Instance.ConfigVersionMap.TryGetValue(key, out result))
			{
				return "";
			}
			return result;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000584F4 File Offset: 0x000566F4
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

		// Token: 0x06000F0F RID: 3855 RVA: 0x00058554 File Offset: 0x00056754
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
			string text2 = this.GetPackageConfigOrDefault(TBuildInfoKey.PatchVersion, null);
			string deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, null);
			RemoteVersionConfig newConfig = RemoteInfo.Instance.NewConfig;
			VersionItem versionItem;
			string text3 = (((newConfig != null) ? newConfig.ResVersions : null) != null && RemoteInfo.Instance.NewConfig.ResVersions.TryGetValue("resource", out versionItem)) ? ((versionItem != null) ? versionItem.Version : null) : null;
			text2 = ((!string.IsNullOrEmpty(deviceSaved)) ? deviceSaved : ((!string.IsNullOrEmpty(text3)) ? text3 : text2));
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
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(p4Version);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x000586D6 File Offset: 0x000568D6
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

		// Token: 0x06000F11 RID: 3857 RVA: 0x000586F9 File Offset: 0x000568F9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000586FB File Offset: 0x000568FB
		public static void ResetStaticDefaultValue()
		{
			BaseConfigController instance = BaseConfigController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BaseConfigController._instance = null;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00058714 File Offset: 0x00056914
		static BaseConfigController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BaseConfigController.CreateStaticDefaultValue), new Action(BaseConfigController.ResetStaticDefaultValue));
		}

		// Token: 0x040009A3 RID: 2467
		private const string BUILD_INFO_BASE_PACKAGE = "/Package/ParamsConfig.ini";

		// Token: 0x040009A4 RID: 2468
		private const string BUILD_INFO_PATCH_OVERRIDE_OLD = "/Aki/ConfigDB/PackageParams.txt";

		// Token: 0x040009A5 RID: 2469
		private const string BUILD_INFO_PATCH_OVERRIDE = "/Aki/ConfigDB/Misc/BuildInfo.txt";

		// Token: 0x040009A6 RID: 2470
		private const string CONFIG_VERSION_PATCH_OVERRIDE = "/Aki/ConfigDB/Misc/ConfigVersion.txt";

		// Token: 0x040009A7 RID: 2471
		[Nullable(2)]
		private static BaseConfigController _instance;
	}
}
