using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020001F6 RID: 502
[NullableContext(1)]
[Nullable(0)]
internal class DtCameraConfig
{
	// Token: 0x06001F8A RID: 8074 RVA: 0x000A04D8 File Offset: 0x0009E6D8
	public DtCameraConfig(UDataTable dataTable)
	{
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06001F8B RID: 8075 RVA: 0x000A050F File Offset: 0x0009E70F
	public UDataTable DataTable { get; } = dataTable;

	// Token: 0x06001F8C RID: 8076 RVA: 0x000A0518 File Offset: 0x0009E718
	public unsafe void SetToConfigs(Dictionary<int, CameraConfig> subConfigs, Dictionary<int, CameraConfig> focusConfigs, Dictionary<int, CameraConfig> accompanyConfigs, string platformCheckKey)
	{
		TArray<SCameraConfig> cameraConfigList = CameraController.Instance.GetCameraConfigList(this.DataTable);
		int num = cameraConfigList.Num();
		for (int i = 0; i < num; i++)
		{
			CameraConfig cameraConfig = new CameraConfig(cameraConfigList.Get(i));
			FieldInfo field = typeof(CameraConfig).GetField(platformCheckKey);
			if (!(field == null) && (bool)field.GetValue(cameraConfig))
			{
				if (cameraConfig.Tag == null || cameraConfig.Tag.Value.TagName == FName.NAME_None)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Camera;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "独有镜头配置不允许Tag为None";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DT", this.DataTable.GetOuter());
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					int num2 = cameraConfig.Tag.Value.TagId();
					if (cameraConfig.Type == EFightCameraType.子镜头)
					{
						if (!subConfigs.TryAdd(num2, cameraConfig))
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.Camera;
							ELogAuthor author2 = ELogAuthor.LJM;
							string message2 = "[子镜头]独有镜头配置不允许重复的Tag";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DT", this.DataTable.GetOuter());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tag", cameraConfig.Tag.Value.TagName);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", cameraConfig.Type);
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
						else
						{
							this.SubValidKeys.Add(num2);
						}
					}
					else if (cameraConfig.Type == EFightCameraType.锁定目标镜头)
					{
						if (!focusConfigs.TryAdd(num2, cameraConfig))
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.Camera;
							ELogAuthor author3 = ELogAuthor.LJM;
							string message3 = "[锁定目标镜头]独有镜头配置不允许重复的Tag";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("DT", this.DataTable.GetOuter());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Tag", cameraConfig.Tag.Value.TagName);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Type", cameraConfig.Type);
							instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
						}
						else
						{
							this.FocusValidKeys.Add(num2);
						}
					}
					else if (cameraConfig.Type == EFightCameraType.伴随目标镜头)
					{
						if (!accompanyConfigs.TryAdd(num2, cameraConfig))
						{
							Log instance4 = Log.Instance;
							ELogModule module4 = ELogModule.Camera;
							ELogAuthor author4 = ELogAuthor.LJM;
							string message4 = "[伴随目标镜头]独有镜头配置不允许重复的Tag";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("DT", this.DataTable.GetOuter());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Tag", cameraConfig.Tag.Value.TagName);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("Type", cameraConfig.Type);
							instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
						}
						else
						{
							this.AccompanyValidKeys.Add(num2);
						}
					}
				}
			}
		}
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000A085C File Offset: 0x0009EA5C
	[Conditional("DEBUG")]
	private void PrintToScreen(string content)
	{
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000A0860 File Offset: 0x0009EA60
	public void RemoveFromConfigs(Dictionary<int, CameraConfig> subConfigs, Dictionary<int, CameraConfig> focusConfigs, Dictionary<int, CameraConfig> accompanyConfigs)
	{
		foreach (int key in this.SubValidKeys)
		{
			subConfigs.Remove(key);
		}
		foreach (int key2 in this.FocusValidKeys)
		{
			focusConfigs.Remove(key2);
		}
		foreach (int key3 in this.AccompanyValidKeys)
		{
			accompanyConfigs.Remove(key3);
		}
		this.SubValidKeys.Clear();
		this.FocusValidKeys.Clear();
		this.AccompanyValidKeys.Clear();
	}

	// Token: 0x0400137E RID: 4990
	public int ReferenceCount;

	// Token: 0x0400137F RID: 4991
	public HashSet<int> SubValidKeys = new HashSet<int>();

	// Token: 0x04001380 RID: 4992
	public HashSet<int> FocusValidKeys = new HashSet<int>();

	// Token: 0x04001381 RID: 4993
	public HashSet<int> AccompanyValidKeys = new HashSet<int>();

	// Token: 0x04001382 RID: 4994
	private readonly bool EnablePrintLogToScreen = true;
}
