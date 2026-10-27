using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Utils;

// Token: 0x02000011 RID: 17
[NullableContext(1)]
[Nullable(0)]
public class LauncherLog : Singleton
{
	// Token: 0x0600009D RID: 157 RVA: 0x00006F23 File Offset: 0x00005123
	public void SetJsDebugId(string id)
	{
		if (!string.IsNullOrEmpty(id))
		{
			this.JsDebugId = "(" + id + ")";
		}
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00006F43 File Offset: 0x00005143
	public void SetLevel(LauncherLog.ELogLevel level)
	{
		this.Level = level;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00006F4C File Offset: 0x0000514C
	public bool CheckError()
	{
		return this.Level >= LauncherLog.ELogLevel.Error;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00006F5A File Offset: 0x0000515A
	public bool CheckWarn()
	{
		return this.Level >= LauncherLog.ELogLevel.Warn;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00006F68 File Offset: 0x00005168
	public bool CheckInfo()
	{
		return this.Level >= LauncherLog.ELogLevel.Info;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00006F76 File Offset: 0x00005176
	public bool CheckDebug()
	{
		return this.Level >= LauncherLog.ELogLevel.Debug;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00006F84 File Offset: 0x00005184
	public void Error(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(LauncherLog.ELogLevel.Error, message, pairs, this.LevelTrace[LauncherLog.ELogLevel.Error], null);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00006F9C File Offset: 0x0000519C
	public void ErrorWithStack(string message, Exception error, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(LauncherLog.ELogLevel.Error, message, pairs, this.LevelTrace[LauncherLog.ELogLevel.Error], error);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00006FB4 File Offset: 0x000051B4
	public void Warn(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(LauncherLog.ELogLevel.Warn, message, pairs, this.LevelTrace[LauncherLog.ELogLevel.Warn], null);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00006FCC File Offset: 0x000051CC
	public void Info(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(LauncherLog.ELogLevel.Info, message, pairs, this.LevelTrace[LauncherLog.ELogLevel.Info], null);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00006FE4 File Offset: 0x000051E4
	public void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(LauncherLog.ELogLevel.Debug, message, pairs, this.LevelTrace[LauncherLog.ELogLevel.Debug], null);
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00006FFC File Offset: 0x000051FC
	private unsafe void Print(LauncherLog.ELogLevel level, string message, [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs, bool trace, [Nullable(2)] Exception error = null)
	{
		this.Increment++;
		if (level > this.Level)
		{
			return;
		}
		UnsafeStringBuilder logBuilder = LauncherLog.LogBuilder;
		logBuilder.Clear();
		logBuilder.Append("[");
		logBuilder.Append<int>(this.Increment);
		logBuilder.Append("][");
		logBuilder.Append(this.LevelName[level]);
		logBuilder.Append("][Launcher][");
		logBuilder.Append(this.GetTime());
		logBuilder.Append("] ");
		logBuilder.Append(message);
		if (pairs.Length > 0)
		{
			logBuilder.Append(' ');
			ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ValueTuple<string, object> valueTuple = *readOnlySpan[i];
				logBuilder.Append('[');
				logBuilder.Append(valueTuple.Item1);
				logBuilder.Append(": ");
				this.AppendValueToBuilder(logBuilder, valueTuple.Item2);
				logBuilder.Append(']');
			}
		}
		if (trace)
		{
			UnsafeStringBuilder stackContentBuilder = LauncherLog.StackContentBuilder;
			stackContentBuilder.Clear();
			this.GetStack(stackContentBuilder, error, (error != null) ? 0 : 3);
			logBuilder.Append(stackContentBuilder);
		}
		this.LogMessage(level, logBuilder.ToString());
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000713C File Offset: 0x0000533C
	private string GetTime()
	{
		DateTime now = DateTime.Now;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Hour);
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Minute);
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Second);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Millisecond);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000071BC File Offset: 0x000053BC
	private void AppendValueToBuilder(UnsafeStringBuilder builder, [Nullable(2)] object value)
	{
		if (value == null)
		{
			builder.Append("null");
			return;
		}
		string text = value as string;
		if (text != null)
		{
			builder.Append(text);
			return;
		}
		if (this.Serialization && value.GetType().IsClass)
		{
			string text2 = this.Encode(value);
			builder.Append(text2 ?? "");
			return;
		}
		builder.Append(value.ToString());
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00007228 File Offset: 0x00005428
	[return: Nullable(2)]
	private string Encode(object target)
	{
		try
		{
			return LauncherJson.Stringify<object>(target, null);
		}
		catch (Exception ex)
		{
			string message = "Log 序列化异常";
			Exception error = ex;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
			this.ErrorWithStack(message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000727C File Offset: 0x0000547C
	private void GetStack(UnsafeStringBuilder contentBuilder, [Nullable(2)] Exception error, int firstStackIndex)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(8, 1, contentBuilder);
		appendInterpolatedStringHandler.AppendLiteral("\nC# 堆栈");
		appendInterpolatedStringHandler.AppendFormatted(this.JsDebugId);
		appendInterpolatedStringHandler.AppendLiteral(":\n");
		contentBuilder.Append(ref appendInterpolatedStringHandler);
		if (error != null)
		{
			contentBuilder.Append<Exception>(error);
			if (error is InvalidCastException)
			{
				StackTrace value = new StackTrace(firstStackIndex, true);
				contentBuilder.Append("\nC# InvalidCastException:\n");
				contentBuilder.Append<StackTrace>(value);
			}
		}
		else
		{
			StackTrace value2 = new StackTrace(firstStackIndex, true);
			contentBuilder.Append<StackTrace>(value2);
		}
		string blueprintCallstack = UKuroStaticLibrary.GetBlueprintCallstack();
		if (string.IsNullOrEmpty(blueprintCallstack))
		{
			return;
		}
		contentBuilder.Append("\nBP 堆栈:\n");
		contentBuilder.Append(blueprintCallstack);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00007329 File Offset: 0x00005529
	private void LogMessage(LauncherLog.ELogLevel level, string message)
	{
		switch (level)
		{
		case LauncherLog.ELogLevel.Error:
			UnrealLogger.Error(message);
			return;
		case LauncherLog.ELogLevel.Warn:
			UnrealLogger.Warn(message);
			return;
		case LauncherLog.ELogLevel.Info:
			UnrealLogger.Info(message);
			return;
		case LauncherLog.ELogLevel.Debug:
			UnrealLogger.Info(message);
			return;
		default:
			return;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000AE RID: 174 RVA: 0x0000735D File Offset: 0x0000555D
	public static LauncherLog Instance
	{
		get
		{
			if (LauncherLog._instance == null)
			{
				LauncherLog._instance = new LauncherLog();
				LauncherLog._instance.OnInit();
			}
			return LauncherLog._instance;
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00007380 File Offset: 0x00005580
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00007382 File Offset: 0x00005582
	public static void ResetStaticDefaultValue()
	{
		LauncherLog instance = LauncherLog._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LauncherLog._instance = null;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000739C File Offset: 0x0000559C
	static LauncherLog()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LauncherLog.CreateStaticDefaultValue), new Action(LauncherLog.ResetStaticDefaultValue));
	}

	// Token: 0x04000051 RID: 81
	private readonly Dictionary<LauncherLog.ELogLevel, bool> LevelTrace = new Dictionary<LauncherLog.ELogLevel, bool>
	{
		{
			LauncherLog.ELogLevel.Error,
			true
		},
		{
			LauncherLog.ELogLevel.Warn,
			false
		},
		{
			LauncherLog.ELogLevel.Info,
			false
		},
		{
			LauncherLog.ELogLevel.Debug,
			false
		}
	};

	// Token: 0x04000052 RID: 82
	private readonly Dictionary<LauncherLog.ELogLevel, string> LevelName = new Dictionary<LauncherLog.ELogLevel, string>
	{
		{
			LauncherLog.ELogLevel.Error,
			"E"
		},
		{
			LauncherLog.ELogLevel.Warn,
			"W"
		},
		{
			LauncherLog.ELogLevel.Info,
			"I"
		},
		{
			LauncherLog.ELogLevel.Debug,
			"D"
		}
	};

	// Token: 0x04000053 RID: 83
	private LauncherLog.ELogLevel Level = LauncherLog.ELogLevel.Debug;

	// Token: 0x04000054 RID: 84
	private readonly bool Serialization;

	// Token: 0x04000055 RID: 85
	private int Increment;

	// Token: 0x04000056 RID: 86
	private string JsDebugId = string.Empty;

	// Token: 0x04000057 RID: 87
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder LogBuilder = new UnsafeStringBuilder(128);

	// Token: 0x04000058 RID: 88
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder ValueBuilder = new UnsafeStringBuilder(128);

	// Token: 0x04000059 RID: 89
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder StackContentBuilder = new UnsafeStringBuilder(128);

	// Token: 0x0400005A RID: 90
	[Nullable(2)]
	private static LauncherLog _instance;

	// Token: 0x02000286 RID: 646
	[NullableContext(0)]
	public enum ELogLevel
	{
		// Token: 0x04000A3E RID: 2622
		Error,
		// Token: 0x04000A3F RID: 2623
		Warn,
		// Token: 0x04000A40 RID: 2624
		Info,
		// Token: 0x04000A41 RID: 2625
		Debug
	}
}
