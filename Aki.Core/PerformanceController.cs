using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnrealEngine;

// Token: 0x020000C5 RID: 197
[NullableContext(1)]
[Nullable(0)]
public class PerformanceController : Singleton
{
	// Token: 0x170000DE RID: 222
	// (get) Token: 0x0600063A RID: 1594 RVA: 0x000201EB File Offset: 0x0001E3EB
	public bool IsEntityTickPerformanceTest
	{
		get
		{
			return this.IsEntityTickPerformanceTestInternal;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x0600063B RID: 1595 RVA: 0x000201F3 File Offset: 0x0001E3F3
	public bool IsEntityPerformanceTest
	{
		get
		{
			return this.IsEntityTickPerformanceTestInternal || this.IsEntityGpuPerformanceTestInternal;
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x0600063C RID: 1596 RVA: 0x00020205 File Offset: 0x0001E405
	public bool IsPlayerPerformanceTest
	{
		get
		{
			return this.IsPlayerTickPerformanceTestInternal;
		}
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00020210 File Offset: 0x0001E410
	public void SetEntityTickPerformanceTest(bool isOpen)
	{
		this.IsEntityTickPerformanceTestInternal = isOpen;
		if (isOpen)
		{
			this.TickPerformanceMap = new Dictionary<string, double[]>();
			this.EffectTickPerformanceMap = new Dictionary<string, EffectPerformanceRecords>();
			this.EntityComponentTickDataMap = new Dictionary<int, Dictionary<string, double[]>>();
			this.StartFrameCount = new long?(UKismetSystemLibrary.GetFrameCount());
			return;
		}
		this.TickPerformanceMap.Clear();
		this.EffectTickPerformanceMap.Clear();
		this.EntityComponentTickDataMap.Clear();
		this.TickPerformanceMap = null;
		this.EffectTickPerformanceMap = null;
		this.EntityComponentTickDataMap = null;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00020290 File Offset: 0x0001E490
	public void SetPlayerTickPerformanceTest(bool isOpen)
	{
		this.IsPlayerTickPerformanceTestInternal = isOpen;
		if (isOpen)
		{
			this.TickPerformanceMap = new Dictionary<string, double[]>();
			this.EffectTickPerformanceMap = new Dictionary<string, EffectPerformanceRecords>();
			this.EntityComponentTickDataMap = new Dictionary<int, Dictionary<string, double[]>>();
			this.StartFrameCount = new long?(UKismetSystemLibrary.GetFrameCount());
			return;
		}
		this.TickPerformanceMap.Clear();
		this.EffectTickPerformanceMap.Clear();
		this.EntityComponentTickDataMap.Clear();
		this.TickPerformanceMap = null;
		this.EffectTickPerformanceMap = null;
		this.EntityComponentTickDataMap = null;
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x0002030F File Offset: 0x0001E50F
	public void SetEntityGpuPerformanceTest(bool isOpen)
	{
		this.IsEntityGpuPerformanceTestInternal = isOpen;
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00020318 File Offset: 0x0001E518
	public void CollectPlayerSkeletalTickPerformanceInfo(string key, int entityId, float tickTime, long? bornFrame = null)
	{
		if (bornFrame != null)
		{
			long? num = bornFrame;
			long? startFrameCount = this.StartFrameCount;
			if (num.GetValueOrDefault() < startFrameCount.GetValueOrDefault() & (num != null & startFrameCount != null))
			{
				return;
			}
		}
		if (this.InStatisticsMode && this.TargetEntity != -1 && this.TargetEntity == entityId)
		{
			if (this.TickFrameTimeMap == null)
			{
				this.TickFrameTimeMap = new Dictionary<string, ValueTuple<long, double, int, bool>>();
			}
			long frameCount = UKismetSystemLibrary.GetFrameCount();
			ValueTuple<long, double, int, bool> valueTuple;
			if (this.TickFrameTimeMap.TryGetValue(key, out valueTuple))
			{
				if (frameCount == valueTuple.Item1)
				{
					valueTuple.Item2 += (double)tickTime;
					this.TickFrameTimeMap[key] = valueTuple;
					return;
				}
				string str = this.MeasureModeStringMap[1];
				this.AddStatistics(key + "." + str, EMeasureMode.Tick, valueTuple.Item2, new long?(valueTuple.Item1));
				valueTuple.Item1 = frameCount;
				valueTuple.Item2 = (double)tickTime;
				this.TickFrameTimeMap[key] = valueTuple;
				return;
			}
			else
			{
				this.TickFrameTimeMap[key] = new ValueTuple<long, double, int, bool>(frameCount, (double)tickTime, 1, false);
			}
		}
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00020434 File Offset: 0x0001E634
	public void CollectTickPerformanceInfo(string key, bool isTickCount, double tickTime, EMeasureMode measureMode = EMeasureMode.Tick, long? bornFrame = null)
	{
		if (bornFrame != null)
		{
			long? num = bornFrame;
			long? startFrameCount = this.StartFrameCount;
			if (num.GetValueOrDefault() < startFrameCount.GetValueOrDefault() & (num != null & startFrameCount != null))
			{
				return;
			}
		}
		if (this.TickPerformanceMap == null)
		{
			this.TickPerformanceMap = new Dictionary<string, double[]>();
		}
		double[] array;
		if (this.TickPerformanceMap.TryGetValue(key, out array))
		{
			array[0] = array[0] + (isTickCount > false);
			array[1] = array[1] + tickTime;
		}
		else
		{
			this.TickPerformanceMap[key] = new double[]
			{
				1.0,
				tickTime
			};
		}
		if (this.InStatisticsMode)
		{
			if (key.Contains("EntityTick"))
			{
				int num2 = int.Parse(key.Substring(10));
				if (this.TargetEntity != -1 && this.TargetEntity != num2)
				{
					return;
				}
			}
			if (this.TickFrameTimeMap == null)
			{
				this.TickFrameTimeMap = new Dictionary<string, ValueTuple<long, double, int, bool>>();
			}
			string text = Regex.Replace(key, "\\d", "");
			long frameCount = UKismetSystemLibrary.GetFrameCount();
			if (measureMode == EMeasureMode.Create)
			{
				this.AddStatistics(text + "." + this.MeasureModeStringMap[(int)measureMode], measureMode, tickTime, new long?(frameCount));
				return;
			}
			ValueTuple<long, double, int, bool> valueTuple;
			if (this.TickFrameTimeMap.TryGetValue(text, out valueTuple))
			{
				if (frameCount == valueTuple.Item1)
				{
					valueTuple.Item2 += tickTime;
					this.TickFrameTimeMap[text] = valueTuple;
					return;
				}
				string str = this.MeasureModeStringMap[(int)measureMode];
				this.AddStatistics(text + "." + str, measureMode, valueTuple.Item2, new long?(valueTuple.Item1));
				valueTuple.Item1 = frameCount;
				valueTuple.Item2 = tickTime;
				this.TickFrameTimeMap[text] = valueTuple;
				this.AddStatistics("GameThread.Tick", measureMode, (double)UKuroRenderingRuntimeBPPluginBPLibrary.GetGameThreadTime(), new long?(valueTuple.Item1));
				return;
			}
			else
			{
				this.TickFrameTimeMap[text] = new ValueTuple<long, double, int, bool>(frameCount, tickTime, (int)measureMode, false);
			}
		}
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x0002062C File Offset: 0x0001E82C
	public unsafe double ConsumeTickTime(string key)
	{
		double[] array;
		if (!this.TickPerformanceMap.TryGetValue(key, out array))
		{
			return 0.0;
		}
		double num = array[0];
		double num2 = array[1];
		double result = (num == 0.0) ? 0.0 : (num2 / num);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.ZFJ;
		string message = "ConsumeTickTime";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("time", num2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", num);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.TickPerformanceMap.Remove(key);
		return result;
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x000206E0 File Offset: 0x0001E8E0
	public void CollectComponentTickPerformanceInfo(int entityId, string componentName, bool isTickCount, float tickTime)
	{
		if (this.EntityComponentTickDataMap == null)
		{
			this.EntityComponentTickDataMap = new Dictionary<int, Dictionary<string, double[]>>();
		}
		Dictionary<string, double[]> dictionary;
		if (this.EntityComponentTickDataMap.TryGetValue(entityId, out dictionary))
		{
			double[] array;
			if (dictionary.TryGetValue(componentName, out array))
			{
				array[0] = array[0] + (isTickCount > false);
				array[1] = array[1] + (double)tickTime;
			}
			else
			{
				dictionary[componentName] = new double[]
				{
					1.0,
					(double)tickTime
				};
			}
		}
		else
		{
			Dictionary<string, double[]> dictionary2 = new Dictionary<string, double[]>();
			dictionary2[componentName] = new double[]
			{
				1.0,
				(double)tickTime
			};
			this.EntityComponentTickDataMap[entityId] = dictionary2;
		}
		if (this.InStatisticsMode && (this.TargetEntity == -1 || this.TargetEntity == entityId))
		{
			if (this.TickFrameTimeMap == null)
			{
				this.TickFrameTimeMap = new Dictionary<string, ValueTuple<long, double, int, bool>>();
			}
			string text = "Entity.Tick." + componentName;
			ValueTuple<long, double, int, bool> valueTuple;
			if (this.TickFrameTimeMap.TryGetValue(text, out valueTuple))
			{
				long frameCount = UKismetSystemLibrary.GetFrameCount();
				if (frameCount == valueTuple.Item1)
				{
					valueTuple.Item2 += (double)tickTime;
					this.TickFrameTimeMap[text] = valueTuple;
					return;
				}
				this.AddStatistics(text, EMeasureMode.Tick, valueTuple.Item2, new long?(valueTuple.Item1));
				valueTuple.Item1 = frameCount;
				valueTuple.Item2 = (double)tickTime;
				this.TickFrameTimeMap[text] = valueTuple;
				return;
			}
			else
			{
				long frameCount2 = UKismetSystemLibrary.GetFrameCount();
				this.TickFrameTimeMap[text] = new ValueTuple<long, double, int, bool>(frameCount2, (double)tickTime, 1, true);
			}
		}
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00020860 File Offset: 0x0001EA60
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, string> ConsumeComponentTickTime(int entityId)
	{
		Dictionary<string, double[]> dictionary;
		if (!this.EntityComponentTickDataMap.TryGetValue(entityId, out dictionary))
		{
			return null;
		}
		if (this.TempComponentOutMap == null)
		{
			this.TempComponentOutMap = new Dictionary<string, string>();
		}
		this.TempComponentOutMap.Clear();
		double num = 0.0;
		foreach (string key in dictionary.Keys)
		{
			double[] array = dictionary[key];
			double num2 = (array[0] == 0.0) ? 0.0 : (array[1] / array[0]);
			num += array[1];
			this.TempComponentOutMap[key] = num2.ToString("F3");
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.ZFJ;
		string message = "ConsumeComponentTickTimeMax";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mm", num);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		dictionary.Clear();
		return this.TempComponentOutMap;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00020970 File Offset: 0x0001EB70
	public void CollectEffectTickPerformanceInfo(string key, bool isTickCount, double startTime, double endTime, EMeasureMode measureMode, long bornFrame, int? particleCount = null, int? emitterCount = null)
	{
		long? startFrameCount = this.StartFrameCount;
		if ((bornFrame < startFrameCount.GetValueOrDefault() & startFrameCount != null) || this.MeasureModeStringMap == null)
		{
			return;
		}
		if (this.EffectTickPerformanceMap == null)
		{
			this.EffectTickPerformanceMap = new Dictionary<string, EffectPerformanceRecords>();
		}
		int length = key.IndexOf('.');
		string text = key.Substring(0, length);
		EffectPerformanceRecords effectPerformanceRecords;
		this.EffectTickPerformanceMap.TryGetValue(text, out effectPerformanceRecords);
		float num = (float)(endTime - startTime);
		EffectPerformanceStatistics effectPerformanceStatistics = new EffectPerformanceStatistics();
		effectPerformanceStatistics.Frame = new long?(UKismetSystemLibrary.GetFrameCount());
		effectPerformanceStatistics.StartTime = startTime;
		effectPerformanceStatistics.EndTime = endTime;
		effectPerformanceStatistics.ParticleCount = particleCount.GetValueOrDefault();
		effectPerformanceStatistics.EmitterCount = emitterCount.GetValueOrDefault();
		effectPerformanceStatistics.Type = this.MeasureModeStringMap[(int)measureMode];
		if (effectPerformanceRecords == null)
		{
			EffectPerformanceRecords effectPerformanceRecords2 = new EffectPerformanceRecords();
			effectPerformanceRecords2.TickCount = 1;
			effectPerformanceRecords2.Duration = num;
			effectPerformanceRecords2.Records.Add(effectPerformanceStatistics);
			this.EffectTickPerformanceMap[text] = effectPerformanceRecords2;
		}
		else
		{
			effectPerformanceRecords.TickCount += ((isTickCount > false) ? 1 : 0);
			effectPerformanceRecords.Duration += num;
			effectPerformanceRecords.Records.Add(effectPerformanceStatistics);
		}
		if (this.InStatisticsMode)
		{
			string str = this.MeasureModeStringMap[(int)measureMode];
			this.AddStatistics("EffectHandle." + str + "." + text, measureMode, (double)num, null);
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00020AD8 File Offset: 0x0001ECD8
	[return: Nullable(new byte[]
	{
		2,
		1,
		1,
		0,
		1,
		1
	})]
	public Dictionary<string, List<ValueTuple<string, string>>> ConsumeEffectTickTime()
	{
		if (this.EffectTickPerformanceMap == null)
		{
			return null;
		}
		if (this.TempEffectOutMap == null)
		{
			this.TempEffectOutMap = new Dictionary<string, List<ValueTuple<string, string>>>();
		}
		this.TempEffectOutMap.Clear();
		foreach (string key in this.EffectTickPerformanceMap.Keys)
		{
			EffectPerformanceRecords effectPerformanceRecords = this.EffectTickPerformanceMap[key];
			float num = (effectPerformanceRecords.TickCount == 0) ? 0f : (effectPerformanceRecords.Duration / (float)effectPerformanceRecords.TickCount);
			List<ValueTuple<string, string>> list = new List<ValueTuple<string, string>>();
			list.Add(new ValueTuple<string, string>("Score", num.ToString("F3")));
			list.Add(new ValueTuple<string, string>("TickCount", effectPerformanceRecords.TickCount.ToString()));
			list.Add(new ValueTuple<string, string>("Duration", effectPerformanceRecords.Duration.ToString("F3")));
			int num2 = 0;
			foreach (EffectPerformanceStatistics effectPerformanceStatistics in effectPerformanceRecords.Records)
			{
				List<ValueTuple<string, string>> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Frame_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				list2.Add(new ValueTuple<string, string>(defaultInterpolatedStringHandler.ToStringAndClear(), effectPerformanceStatistics.Frame.Value.ToString()));
				List<ValueTuple<string, string>> list3 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("StartTime_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				list3.Add(new ValueTuple<string, string>(defaultInterpolatedStringHandler.ToStringAndClear(), effectPerformanceStatistics.StartTime.ToString("F3")));
				List<ValueTuple<string, string>> list4 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("EndTime_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				list4.Add(new ValueTuple<string, string>(defaultInterpolatedStringHandler.ToStringAndClear(), effectPerformanceStatistics.EndTime.ToString("F3")));
				List<ValueTuple<string, string>> list5 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral("ParticleCount_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				list5.Add(new ValueTuple<string, string>(defaultInterpolatedStringHandler.ToStringAndClear(), effectPerformanceStatistics.ParticleCount.ToString()));
				List<ValueTuple<string, string>> list6 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("EmitterCount_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				list6.Add(new ValueTuple<string, string>(defaultInterpolatedStringHandler.ToStringAndClear(), effectPerformanceStatistics.EmitterCount.ToString()));
				List<ValueTuple<string, string>> list7 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Type_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				list7.Add(new ValueTuple<string, string>(defaultInterpolatedStringHandler.ToStringAndClear(), effectPerformanceStatistics.Type));
				num2++;
			}
			this.TempEffectOutMap[key] = list;
		}
		this.EffectTickPerformanceMap.Clear();
		return this.TempEffectOutMap;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00020DE8 File Offset: 0x0001EFE8
	public void SetStatisticsMode(bool isOpen, int targetEntity, string sectionName = "")
	{
		this.InStatisticsMode = isOpen;
		if (isOpen)
		{
			this.CurSectionName = new FName?(new FName(sectionName));
			this.StartFrameCount = new long?(UKismetSystemLibrary.GetFrameCount());
			this.FrameCount = this.StartFrameCount;
			this.TargetEntity = targetEntity;
			this.MeasureModeStringMap = new Dictionary<int, string>();
			this.MeasureModeStringMap[0] = "Create";
			this.MeasureModeStringMap[1] = "Tick";
			this.MeasureModeStringMap[2] = "Other";
			return;
		}
		if (this.TickFrameTimeMap != null)
		{
			foreach (string text in this.TickFrameTimeMap.Keys)
			{
				ValueTuple<long, double, int, bool> valueTuple = this.TickFrameTimeMap[text];
				string str = this.MeasureModeStringMap[valueTuple.Item3];
				this.AddStatistics(valueTuple.Item4 ? (text ?? "") : (text + "." + str), (EMeasureMode)valueTuple.Item3, valueTuple.Item2, new long?(valueTuple.Item1));
			}
			this.TickFrameTimeMap.Clear();
			this.TickFrameTimeMap = null;
		}
		this.MeasureModeStringMap = null;
		this.CurSectionName = null;
		this.TargetEntity = -1;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00020F4C File Offset: 0x0001F14C
	private void AddStatistics(string tag, EMeasureMode measureMode, double time, long? frame = null)
	{
		if (this.CurSectionName == null)
		{
			return;
		}
		long frameCount = UKismetSystemLibrary.GetFrameCount();
		long num = frameCount;
		long? frameCount2 = this.FrameCount;
		if (!(num == frameCount2.GetValueOrDefault() & frameCount2 != null))
		{
			this.FrameCount = new long?(frameCount);
		}
		UPerformanceStatisticsLibrary.AddStatistics(this.CurSectionName.Value, (int)((frame != null) ? frame.Value : frameCount), tag, (int)measureMode, (float)time, "");
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x00020FC1 File Offset: 0x0001F1C1
	public static PerformanceController Instance
	{
		get
		{
			if (PerformanceController._instance == null)
			{
				PerformanceController._instance = new PerformanceController();
				PerformanceController._instance.OnInit();
			}
			return PerformanceController._instance;
		}
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00020FE4 File Offset: 0x0001F1E4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00020FE6 File Offset: 0x0001F1E6
	public static void ResetStaticDefaultValue()
	{
		PerformanceController instance = PerformanceController._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		PerformanceController._instance = null;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00020FFF File Offset: 0x0001F1FF
	static PerformanceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformanceController.CreateStaticDefaultValue), new Action(PerformanceController.ResetStaticDefaultValue));
	}

	// Token: 0x040004ED RID: 1261
	public bool IsInAnyEntitySkillTickTest;

	// Token: 0x040004EE RID: 1262
	public bool IsOpenCatchWorldEntity;

	// Token: 0x040004EF RID: 1263
	private bool IsEntityTickPerformanceTestInternal;

	// Token: 0x040004F0 RID: 1264
	private bool IsPlayerTickPerformanceTestInternal;

	// Token: 0x040004F1 RID: 1265
	private bool IsEntityGpuPerformanceTestInternal;

	// Token: 0x040004F2 RID: 1266
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, double[]> TickPerformanceMap;

	// Token: 0x040004F3 RID: 1267
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<int, Dictionary<string, double[]>> EntityComponentTickDataMap;

	// Token: 0x040004F4 RID: 1268
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, EffectPerformanceRecords> EffectTickPerformanceMap;

	// Token: 0x040004F5 RID: 1269
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		0,
		1,
		1
	})]
	private Dictionary<string, List<ValueTuple<string, string>>> TempEffectOutMap;

	// Token: 0x040004F6 RID: 1270
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, string> TempComponentOutMap;

	// Token: 0x040004F7 RID: 1271
	private bool InStatisticsMode;

	// Token: 0x040004F8 RID: 1272
	private FName? CurSectionName;

	// Token: 0x040004F9 RID: 1273
	private int TargetEntity = -1;

	// Token: 0x040004FA RID: 1274
	private long? FrameCount;

	// Token: 0x040004FB RID: 1275
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private Dictionary<string, ValueTuple<long, double, int, bool>> TickFrameTimeMap;

	// Token: 0x040004FC RID: 1276
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> MeasureModeStringMap;

	// Token: 0x040004FD RID: 1277
	private long? StartFrameCount;

	// Token: 0x040004FE RID: 1278
	[Nullable(2)]
	private static PerformanceController _instance;
}
