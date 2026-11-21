using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200252B RID: 9515
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueTrailChain : GameplayCueEffect, IStaticVariableResetter
{
	// Token: 0x0601787C RID: 96380 RVA: 0x006F2274 File Offset: 0x006F0474
	static GameplayCueTrailChain()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayCueTrailChain.CreateStaticDefaultValue), new Action(GameplayCueTrailChain.ResetStaticDefaultValue));
	}

	// Token: 0x0601787D RID: 96381 RVA: 0x006F2293 File Offset: 0x006F0493
	public static bool SetDebugLogEnable(bool enable)
	{
		GameplayCueTrailChain.DebugLogEnable = enable;
		return enable;
	}

	// Token: 0x0601787E RID: 96382 RVA: 0x006F229C File Offset: 0x006F049C
	protected override void OnInit()
	{
		base.OnInit();
		this.PendingSkeletalMeshBinding = false;
		this.ParseEmitterConfig();
	}

	// Token: 0x0601787F RID: 96383 RVA: 0x006F22B1 File Offset: 0x006F04B1
	protected override void OnCreate()
	{
		base.OnCreate();
		EffectSystem.Instance.DynamicRegisterSpawnCallback(this.EffectViewHandle, delegate(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success || !this.IsActive)
			{
				return;
			}
			this.OnEffectReady(handle);
		});
	}

	// Token: 0x06017880 RID: 96384 RVA: 0x006F22D5 File Offset: 0x006F04D5
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.FlushOneSpawn();
	}

	// Token: 0x06017881 RID: 96385 RVA: 0x006F22E4 File Offset: 0x006F04E4
	public unsafe void SpawnFlowerAtLocation(in FVector worldPosition, int count = 1)
	{
		int val = this.TotalCapacity - this.GetFlowerCount() - this.PendingSpawnQueue.Size;
		int num = Math.Min(count, val);
		if (num <= 0)
		{
			if (GameplayCueTrailChain.DebugLogEnable)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[GameplayCueTrailChain] 达到最大数量，丢弃本次生成";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Request", count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowerCount", this.GetFlowerCount());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Queued", this.PendingSpawnQueue.Size);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TotalCapacity", this.TotalCapacity);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
			return;
		}
		for (int i = 0; i < num; i++)
		{
			this.PendingSpawnQueue.Push(worldPosition);
		}
		if (GameplayCueTrailChain.DebugLogEnable)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[GameplayCueTrailChain] 入队";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Request", count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Enqueued", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Dropped", count - num);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4);
			string item = "Position";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<float>(worldPosition.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(worldPosition.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(worldPosition.Z);
			ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("QueueSize", this.PendingSpawnQueue.Size);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("FlowerCount", this.GetFlowerCount());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 7));
		}
	}

	// Token: 0x06017882 RID: 96386 RVA: 0x006F2574 File Offset: 0x006F0774
	public int GetFlowerCount()
	{
		int num = 0;
		int i = 0;
		int count = this.FlowerCounts.Count;
		while (i < count)
		{
			num += this.FlowerCounts[i];
			i++;
		}
		return num;
	}

	// Token: 0x06017883 RID: 96387 RVA: 0x006F25AB File Offset: 0x006F07AB
	public int GetMaxFlowerCount()
	{
		return this.TotalCapacity;
	}

	// Token: 0x06017884 RID: 96388 RVA: 0x006F25B3 File Offset: 0x006F07B3
	public int GetEmitterCount()
	{
		return this.NumChains.Count;
	}

	// Token: 0x06017885 RID: 96389 RVA: 0x006F25C0 File Offset: 0x006F07C0
	private unsafe void ParseEmitterConfig()
	{
		this.CollectConfigParams();
		this.NumBonesParam = (this.FindConfigValue("NumBonesParam") ?? "01_Bone.NumBones");
		this.NumBones = this.ParsePositiveInt("NumBones");
		if (!this.CollectEmitters())
		{
			this.ClearEmitterConfig();
			return;
		}
		if (this.TotalCapacity > 100)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 所有发射器总容量超出上限，配置不合法，本 Cue 不生成花瓣";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EmitterCount", this.GetEmitterCount());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TotalCapacity", this.TotalCapacity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Limit", 100);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.ClearEmitterConfig();
		}
	}

	// Token: 0x06017886 RID: 96390 RVA: 0x006F26CC File Offset: 0x006F08CC
	private unsafe bool CollectEmitters()
	{
		int num = this.FindMaxEmitterIndex();
		if (num <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 没有配置任何发射器，本 Cue 不生成花瓣";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExpectKey", "Numchain1 / NumchainFlowers1");
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		for (int i = 1; i <= num; i++)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("Numchain");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			int num2 = this.ParsePositiveInt(defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("NumchainFlowers");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			int num3 = this.ParsePositiveInt(defaultInterpolatedStringHandler.ToStringAndClear());
			if (num2 <= 0 || num3 <= 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "[GameplayCueTrailChain] 发射器序号必须从 1 连续配到最大序号，且链数与每链粒子数量成对";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Emitter", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("EmitterCount", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("NumChain", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("NumChainFlowers", num3);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
				return false;
			}
			int num4 = num2 * num3;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("FlowerCount");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			int num5 = this.ParseNonNegativeInt(defaultInterpolatedStringHandler.ToStringAndClear());
			if (num5 > num4)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.LJM;
				string message3 = "[GameplayCueTrailChain] 初始花瓣数量超出该发射器容量（链数 × 每链粒子数量），本 Cue 不生成花瓣";
				<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray7<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Emitter", i);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2);
				string item = "Key";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlowerCount");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("FlowerCount", num5);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("NumChain", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("NumChainFlowers", num3);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 6) = new ValueTuple<string, object>("Capacity", num4);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 7));
				return false;
			}
			this.NumChains.Add(num2);
			this.NumChainFlowers.Add(num3);
			this.MaxFlowerCounts.Add(num4);
			this.FlowerCounts.Add(num5);
			List<FName> numChainParams = this.NumChainParams;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("Numchain");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			numChainParams.Add(new FName(defaultInterpolatedStringHandler.ToStringAndClear()));
			List<FName> numChainFlowersParams = this.NumChainFlowersParams;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("NumchainFlowers");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			numChainFlowersParams.Add(new FName(defaultInterpolatedStringHandler.ToStringAndClear()));
			List<FName> flowerCountParams = this.FlowerCountParams;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("FlowerCount");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			flowerCountParams.Add(new FName(defaultInterpolatedStringHandler.ToStringAndClear()));
			this.TotalCapacity += num4;
		}
		return true;
	}

	// Token: 0x06017887 RID: 96391 RVA: 0x006F2ACC File Offset: 0x006F0CCC
	private int FindMaxEmitterIndex()
	{
		int num = 0;
		List<string> configParams = this.ConfigParams;
		int i = 0;
		int count = configParams.Count;
		while (i < count)
		{
			int num2 = this.ParseEmitterIndex(configParams[i]);
			if (num2 > num)
			{
				num = num2;
			}
			i++;
		}
		return num;
	}

	// Token: 0x06017888 RID: 96392 RVA: 0x006F2B10 File Offset: 0x006F0D10
	private int ParseEmitterIndex(string param)
	{
		if (!param.StartsWith("Numchain"))
		{
			return 0;
		}
		int num = param.IndexOf('=');
		if (num <= "Numchain".Length)
		{
			return 0;
		}
		string text = param.Substring("Numchain".Length, num - "Numchain".Length);
		int i = 0;
		int length = text.Length;
		while (i < length)
		{
			if (text[i] < '0' || text[i] > '9')
			{
				return 0;
			}
			i++;
		}
		int result;
		if (!int.TryParse(text, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06017889 RID: 96393 RVA: 0x006F2B9C File Offset: 0x006F0D9C
	private void ClearEmitterConfig()
	{
		this.NumChains.Clear();
		this.NumChainFlowers.Clear();
		this.MaxFlowerCounts.Clear();
		this.FlowerCounts.Clear();
		this.NumChainParams.Clear();
		this.NumChainFlowersParams.Clear();
		this.FlowerCountParams.Clear();
		this.TotalCapacity = 0;
	}

	// Token: 0x0601788A RID: 96394 RVA: 0x006F2C00 File Offset: 0x006F0E00
	private void CollectConfigParams()
	{
		this.ConfigParams.Clear();
		int parametersLength = this.CueConfig.ParametersLength;
		for (int i = 0; i < parametersLength; i++)
		{
			this.ConfigParams.Add(this.CueConfig.Parameters(i));
		}
	}

	// Token: 0x0601788B RID: 96395 RVA: 0x006F2C48 File Offset: 0x006F0E48
	[return: Nullable(2)]
	private string FindConfigValue(string key)
	{
		List<string> configParams = this.ConfigParams;
		string text = key + "=";
		int i = 0;
		int count = configParams.Count;
		while (i < count)
		{
			string text2 = configParams[i];
			if (text2.StartsWith(text))
			{
				return text2.Substring(text.Length);
			}
			i++;
		}
		return null;
	}

	// Token: 0x0601788C RID: 96396 RVA: 0x006F2CA0 File Offset: 0x006F0EA0
	private unsafe int ParsePositiveInt(string key)
	{
		string text = this.FindConfigValue(key);
		if (text == null)
		{
			return 0;
		}
		int num;
		if (!int.TryParse(text, out num) || num <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 配置项必须是正整数，按未配置处理";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Raw", text);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		return num;
	}

	// Token: 0x0601788D RID: 96397 RVA: 0x006F2D48 File Offset: 0x006F0F48
	private unsafe int ParseNonNegativeInt(string key)
	{
		string text = this.FindConfigValue(key);
		if (text == null)
		{
			return 0;
		}
		int num;
		if (!int.TryParse(text, out num) || num < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 配置项必须是非负整数，按 0 处理";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Raw", text);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		return num;
	}

	// Token: 0x0601788E RID: 96398 RVA: 0x006F2DF0 File Offset: 0x006F0FF0
	private int PickEmitterIndex()
	{
		int num = -1;
		int i = 0;
		int count = this.FlowerCounts.Count;
		while (i < count)
		{
			if (this.FlowerCounts[i] < this.MaxFlowerCounts[i] && (num < 0 || this.FlowerCounts[i] < this.FlowerCounts[num]))
			{
				num = i;
			}
			i++;
		}
		return num;
	}

	// Token: 0x0601788F RID: 96399 RVA: 0x006F2E54 File Offset: 0x006F1054
	private string JoinCounts(List<int> counts)
	{
		string text = string.Empty;
		int i = 0;
		int count = counts.Count;
		while (i < count)
		{
			string str = text;
			string str2;
			if (i != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(counts[i]);
				str2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(counts[i]);
				str2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			text = str + str2;
			i++;
		}
		return text;
	}

	// Token: 0x06017890 RID: 96400 RVA: 0x006F2ED0 File Offset: 0x006F10D0
	private unsafe void OnEffectReady(int handle)
	{
		OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(handle);
		if (!niagaraComponent.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 未取到 NiagaraComponent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", this.BuffId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.PendingSkeletalMeshBinding = true;
		if (niagaraComponent.IsT2)
		{
			this.BindSkeletalMesh(niagaraComponent.AsT2);
			this.PendingSkeletalMeshBinding = false;
		}
		if (this.TotalCapacity <= 0)
		{
			return;
		}
		if (this.NumBones > 0)
		{
			niagaraComponent.SetNiagaraVariableFloat(this.NumBonesParam, (float)this.NumBones);
		}
		int i = 0;
		int count = this.NumChains.Count;
		while (i < count)
		{
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self = niagaraComponent;
			FName fname = this.NumChainParams[i];
			self.SetIntParameter(fname, this.NumChains[i]);
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self2 = niagaraComponent;
			fname = this.NumChainFlowersParams[i];
			self2.SetIntParameter(fname, this.NumChainFlowers[i]);
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self3 = niagaraComponent;
			fname = this.FlowerCountParams[i];
			self3.SetIntParameter(fname, this.FlowerCounts[i]);
			i++;
		}
		if (GameplayCueTrailChain.DebugLogEnable)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[GameplayCueTrailChain] 下发发射器配置";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EmitterCount", this.GetEmitterCount());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("NumBonesParam", this.NumBonesParam);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("NumBones", this.NumBones);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("NumChains", this.JoinCounts(this.NumChains));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("NumChainFlowers", this.JoinCounts(this.NumChainFlowers));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("Capacity", this.JoinCounts(this.MaxFlowerCounts));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 7) = new ValueTuple<string, object>("TotalCapacity", this.TotalCapacity);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 8));
		}
		HashSet<GameplayCueTrailChain> testLiveInstances = GameplayCueTrailChain.TestLiveInstances;
		if (testLiveInstances != null)
		{
			testLiveInstances.Add(this);
		}
		this.StartTestAutoSpawn();
	}

	// Token: 0x06017891 RID: 96401 RVA: 0x006F3180 File Offset: 0x006F1380
	private unsafe void BindSkeletalMesh(UNiagaraComponent niagaraComponent)
	{
		if (this.TargetMesh == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 未取到目标骨骼网格体，骨骼绑定失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", this.BuffId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		UKuroRenderingRuntimeBPPluginBPLibrary.SetNiagaraSkeletalMeshComponentWithoutWarning(niagaraComponent, "Sketel", this.TargetMesh);
	}

	// Token: 0x06017892 RID: 96402 RVA: 0x006F3214 File Offset: 0x006F1414
	private unsafe void FlushOneSpawn()
	{
		if (!this.PendingSkeletalMeshBinding && this.PendingSpawnQueue.Size == 0)
		{
			return;
		}
		OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(this.EffectViewHandle);
		if (!niagaraComponent.IsValid() || !niagaraComponent.IsT2)
		{
			return;
		}
		if (this.PendingSkeletalMeshBinding)
		{
			this.BindSkeletalMesh(niagaraComponent.AsT2);
			this.PendingSkeletalMeshBinding = false;
		}
		if (this.PendingSpawnQueue.Size == 0)
		{
			return;
		}
		int num = this.PickEmitterIndex();
		if (num < 0)
		{
			this.PendingSpawnQueue.Clear();
			return;
		}
		FVector fvector;
		if (!this.PendingSpawnQueue.TryPop(out fvector))
		{
			return;
		}
		List<int> flowerCounts = this.FlowerCounts;
		int index = num;
		int num2 = flowerCounts[index];
		flowerCounts[index] = num2 + 1;
		niagaraComponent.SetNiagaraVariableVec3("CollisionPos", fvector);
		int i = 0;
		int count = this.FlowerCounts.Count;
		while (i < count)
		{
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self = niagaraComponent;
			FName fname = this.FlowerCountParams[i];
			self.SetIntParameter(fname, this.FlowerCounts[i]);
			i++;
		}
		if (GameplayCueTrailChain.DebugLogEnable)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[GameplayCueTrailChain] 出队并下发";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "Position";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<float>(fvector.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(fvector.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(fvector.Z);
			ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Emitter", num + 1);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("FlowerCounts", this.JoinCounts(this.FlowerCounts));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Capacity", this.JoinCounts(this.MaxFlowerCounts));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("QueueRemain", this.PendingSpawnQueue.Size);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			if (this.GetFlowerCount() >= this.TotalCapacity)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "[GameplayCueTrailChain] 所有发射器已全部收满";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowerCounts", this.JoinCounts(this.FlowerCounts));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TotalCapacity", this.TotalCapacity);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}
	}

	// Token: 0x06017893 RID: 96403 RVA: 0x006F3500 File Offset: 0x006F1700
	protected override void OnDestroy()
	{
		HashSet<GameplayCueTrailChain> testLiveInstances = GameplayCueTrailChain.TestLiveInstances;
		if (testLiveInstances != null)
		{
			testLiveInstances.Remove(this);
		}
		this.StopTestAutoSpawn();
		this.PendingSkeletalMeshBinding = false;
		int i = 0;
		int count = this.FlowerCounts.Count;
		while (i < count)
		{
			this.FlowerCounts[i] = 0;
			i++;
		}
		this.PendingSpawnQueue.Clear();
		base.OnDestroy();
	}

	// Token: 0x06017894 RID: 96404 RVA: 0x006F3562 File Offset: 0x006F1762
	public static void CreateStaticDefaultValue()
	{
		GameplayCueTrailChain.DebugLogEnable = false;
		GameplayCueTrailChain.TestAutoSpawnEnable = false;
		GameplayCueTrailChain.TestLiveInstances = new HashSet<GameplayCueTrailChain>();
	}

	// Token: 0x06017895 RID: 96405 RVA: 0x006F357A File Offset: 0x006F177A
	public static void ResetStaticDefaultValue()
	{
		GameplayCueTrailChain.DebugLogEnable = false;
		GameplayCueTrailChain.TestAutoSpawnEnable = false;
		GameplayCueTrailChain.TestLiveInstances = null;
	}

	// Token: 0x06017896 RID: 96406 RVA: 0x006F3590 File Offset: 0x006F1790
	public static int SetTestAutoSpawnEnable(bool enable)
	{
		GameplayCueTrailChain.TestAutoSpawnEnable = enable;
		if (GameplayCueTrailChain.TestLiveInstances == null)
		{
			return 0;
		}
		foreach (GameplayCueTrailChain gameplayCueTrailChain in GameplayCueTrailChain.TestLiveInstances)
		{
			if (enable)
			{
				gameplayCueTrailChain.StartTestAutoSpawn();
			}
			else
			{
				gameplayCueTrailChain.StopTestAutoSpawn();
			}
		}
		return GameplayCueTrailChain.TestLiveInstances.Count;
	}

	// Token: 0x06017897 RID: 96407 RVA: 0x006F3608 File Offset: 0x006F1808
	private void StartTestAutoSpawn()
	{
		if (!GameplayCueTrailChain.TestAutoSpawnEnable || this.TestAutoSpawnTimer != null)
		{
			return;
		}
		this.TestAutoSpawnTimer = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.TestSpawnFlowerAroundActor();
		}, 5000f, 1f, null, "[GameplayCueTrailChain.TestAutoSpawn]", true);
	}

	// Token: 0x06017898 RID: 96408 RVA: 0x006F3647 File Offset: 0x006F1847
	private void StopTestAutoSpawn()
	{
		if (this.TestAutoSpawnTimer == null)
		{
			return;
		}
		this.TestAutoSpawnTimer.Remove();
		this.TestAutoSpawnTimer = null;
		this.TestAutoSpawnAngle = 0f;
	}

	// Token: 0x06017899 RID: 96409 RVA: 0x006F3670 File Offset: 0x006F1870
	private void TestSpawnFlowerAroundActor()
	{
		if (!this.IsActive || !this.ActorInternal.IsValid())
		{
			this.StopTestAutoSpawn();
			return;
		}
		this.TestAutoSpawnAngle = (this.TestAutoSpawnAngle + 60f) % 360f;
		float num = this.TestAutoSpawnAngle * 0.017453292f;
		FVectorDouble fvectorDouble = this.ActorInternal.D_K2_GetActorLocation();
		FVector fvector = new FVector((float)(fvectorDouble.X + 200.0 * Math.Cos((double)num)), (float)(fvectorDouble.Y + 200.0 * Math.Sin((double)num)), (float)(fvectorDouble.Z + 100.0));
		this.SpawnFlowerAtLocation(fvector, 1);
	}

	// Token: 0x0400C843 RID: 51267
	private const string SKELETAL_MESH_PARAM = "Sketel";

	// Token: 0x0400C844 RID: 51268
	private const string COLLISION_POS_PARAM = "CollisionPos";

	// Token: 0x0400C845 RID: 51269
	private const string FLOWER_COUNT_PREFIX = "FlowerCount";

	// Token: 0x0400C846 RID: 51270
	private const string NUM_CHAIN_PREFIX = "Numchain";

	// Token: 0x0400C847 RID: 51271
	private const string NUM_CHAIN_FLOWERS_PREFIX = "NumchainFlowers";

	// Token: 0x0400C848 RID: 51272
	private const string DEFAULT_NUM_BONES_PARAM = "01_Bone.NumBones";

	// Token: 0x0400C849 RID: 51273
	private const string NUM_BONES_PARAM_KEY = "NumBonesParam";

	// Token: 0x0400C84A RID: 51274
	private const string NUM_BONES_KEY = "NumBones";

	// Token: 0x0400C84B RID: 51275
	private const int TOTAL_CAPACITY_LIMIT = 100;

	// Token: 0x0400C84C RID: 51276
	private const float TEST_AUTO_SPAWN_INTERVAL = 5000f;

	// Token: 0x0400C84D RID: 51277
	private const float TEST_AUTO_SPAWN_RADIUS = 200f;

	// Token: 0x0400C84E RID: 51278
	private const float TEST_AUTO_SPAWN_HEIGHT = 100f;

	// Token: 0x0400C84F RID: 51279
	private const float TEST_AUTO_SPAWN_ANGLE_STEP = 60f;

	// Token: 0x0400C850 RID: 51280
	private static bool DebugLogEnable;

	// Token: 0x0400C851 RID: 51281
	private readonly List<int> FlowerCounts = new List<int>();

	// Token: 0x0400C852 RID: 51282
	private readonly List<int> MaxFlowerCounts = new List<int>();

	// Token: 0x0400C853 RID: 51283
	private readonly List<int> NumChains = new List<int>();

	// Token: 0x0400C854 RID: 51284
	private readonly List<int> NumChainFlowers = new List<int>();

	// Token: 0x0400C855 RID: 51285
	private readonly List<FName> FlowerCountParams = new List<FName>();

	// Token: 0x0400C856 RID: 51286
	private readonly List<FName> NumChainParams = new List<FName>();

	// Token: 0x0400C857 RID: 51287
	private readonly List<FName> NumChainFlowersParams = new List<FName>();

	// Token: 0x0400C858 RID: 51288
	private string NumBonesParam = "01_Bone.NumBones";

	// Token: 0x0400C859 RID: 51289
	private int NumBones;

	// Token: 0x0400C85A RID: 51290
	private int TotalCapacity;

	// Token: 0x0400C85B RID: 51291
	private readonly List<string> ConfigParams = new List<string>();

	// Token: 0x0400C85C RID: 51292
	private readonly Queue<FVector> PendingSpawnQueue = new Queue<FVector>(4);

	// Token: 0x0400C85D RID: 51293
	private bool PendingSkeletalMeshBinding;

	// Token: 0x0400C85E RID: 51294
	[Nullable(2)]
	private TimerHandle TestAutoSpawnTimer;

	// Token: 0x0400C85F RID: 51295
	private float TestAutoSpawnAngle;

	// Token: 0x0400C860 RID: 51296
	private static bool TestAutoSpawnEnable;

	// Token: 0x0400C861 RID: 51297
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<GameplayCueTrailChain> TestLiveInstances;
}
