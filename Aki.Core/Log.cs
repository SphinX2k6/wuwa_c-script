using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Common.Common;
using Aki.Common.Proxy;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Utils;

// Token: 0x02000032 RID: 50
[NullableContext(1)]
[Nullable(0)]
public class Log : Singleton, ILog
{
	// Token: 0x06000111 RID: 273 RVA: 0x00007FDF File Offset: 0x000061DF
	public void SetCsDebugId(string id)
	{
		if (string.IsNullOrEmpty(id))
		{
			return;
		}
		this.CsDebugId = "(" + id + ")";
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00008000 File Offset: 0x00006200
	public void Initialize()
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00008002 File Offset: 0x00006202
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00008005 File Offset: 0x00006205
	public void ApplyPostHotPatchVerbosity()
	{
		if (KuroApplication.IsBuildShipping())
		{
			KuroLoggingLibrary.RegisterTerminateDelegate();
			KuroLoggingLibrary.PromoteGlobalLogVerbosity(4);
		}
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000801C File Offset: 0x0000621C
	public void InitStat()
	{
		this.PrintStat = global::Stat.Create("Log.Print", "", "");
		this.GetStackStat = global::Stat.Create("Log.GetStack", "", "");
		this.GetBpStackStat = global::Stat.Create("Log.GetBpStack", "", "");
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00008077 File Offset: 0x00006277
	public void SetLevel(global::ELogLevel level)
	{
		this.Level = level;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00008080 File Offset: 0x00006280
	public bool CheckError()
	{
		return this.Level >= global::ELogLevel.Error;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000808E File Offset: 0x0000628E
	public bool CheckWarn()
	{
		return this.Level >= global::ELogLevel.Warn;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0000809C File Offset: 0x0000629C
	public bool CheckInfo()
	{
		return this.Level >= global::ELogLevel.Info;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x000080AA File Offset: 0x000062AA
	public bool CheckDebug()
	{
		return this.Level >= global::ELogLevel.Debug;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000080B8 File Offset: 0x000062B8
	public void Error(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(global::ELogLevel.Error, module, author, message, pairs, true, null);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000080C8 File Offset: 0x000062C8
	public void ErrorWithLogList(ELogModule module, ELogAuthor author, string message, [Nullable(new byte[]
	{
		1,
		0,
		1,
		2
	})] LogList<ValueTuple<string, object>> pairs)
	{
		this.Print(global::ELogLevel.Error, module, author, message, CollectionsMarshal.AsSpan<ValueTuple<string, object>>(pairs), true, null);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000080E2 File Offset: 0x000062E2
	public void ErrorWithStack(ELogModule module, ELogAuthor author, string message, Exception error, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(global::ELogLevel.Error, module, author, message, pairs, true, error);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000080F3 File Offset: 0x000062F3
	public void Warn(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(global::ELogLevel.Warn, module, author, message, pairs, false, null);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00008103 File Offset: 0x00006303
	public void Info(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(global::ELogLevel.Info, module, author, message, pairs, false, null);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00008113 File Offset: 0x00006313
	[Conditional("UE_BUILD_DEBUG")]
	[Conditional("UE_BUILD_DEVELOPMENT")]
	public void Debug(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(global::ELogLevel.Debug, module, author, message, pairs, false, null);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00008123 File Offset: 0x00006323
	public void LogWithLevel(global::ELogLevel Level, ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		this.Print(Level, module, author, message, pairs, Level == global::ELogLevel.Error, null);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00008138 File Offset: 0x00006338
	private static EUeLogVerbosity ToUeLogLevel(global::ELogLevel level)
	{
		EUeLogVerbosity result;
		switch (level)
		{
		case global::ELogLevel.Error:
			result = EUeLogVerbosity.Error;
			break;
		case global::ELogLevel.Warn:
			result = EUeLogVerbosity.Warning;
			break;
		case global::ELogLevel.Info:
			result = EUeLogVerbosity.Display;
			break;
		case global::ELogLevel.Debug:
			result = EUeLogVerbosity.Display;
			break;
		default:
			throw new ArgumentOutOfRangeException("level", level, null);
		}
		return result;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00008180 File Offset: 0x00006380
	private unsafe void Print(global::ELogLevel level, ELogModule module, ELogAuthor author, string message, [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs, bool trace, [Nullable(2)] Exception error = null)
	{
		if (level > this.Level)
		{
			return;
		}
		if (author >= (ELogAuthor)LogDefine.logAuthorInfo.Length)
		{
			return;
		}
		ValueTuple<string, bool> valueTuple = LogDefine.logAuthorInfo[(int)author];
		string item = valueTuple.Item1;
		if (!valueTuple.Item2)
		{
			return;
		}
		this.Increment++;
		UnsafeStringBuilder logBuilder = global::Log.LogBuilder;
		logBuilder.Clear();
		logBuilder.Append("[C#][");
		logBuilder.Append<int>(this.Increment);
		logBuilder.Append("][");
		logBuilder.Append(level.ToEnumString());
		logBuilder.Append("][");
		logBuilder.Append(module.ToEnumString());
		logBuilder.Append("][");
		logBuilder.Append(item);
		logBuilder.Append("][");
		logBuilder.Append<int>(Time.Instance.Frame);
		logBuilder.Append("] ");
		logBuilder.Append(message);
		UnsafeStringBuilder unsafeStringBuilder = null;
		if (pairs.Length > 0)
		{
			bool flag = LogAnalyzer.Instance.NeedLogContext(level);
			logBuilder.Append(' ');
			if (flag)
			{
				unsafeStringBuilder = global::Log.ContextBuilder;
				unsafeStringBuilder.Clear();
				unsafeStringBuilder.Append('{');
			}
			int num = 0;
			ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ValueTuple<string, object> valueTuple2 = *readOnlySpan[i];
				string item2 = valueTuple2.Item1;
				object item3 = valueTuple2.Item2;
				if (flag && unsafeStringBuilder != null)
				{
					UnsafeStringBuilder valueBuilder = global::Log.ValueBuilder;
					valueBuilder.Clear();
					this.AppendValueToBuilder(valueBuilder, item3);
					if (num > 0)
					{
						unsafeStringBuilder.Append(',');
					}
					unsafeStringBuilder.Append('"');
					unsafeStringBuilder.Append<int>(num);
					unsafeStringBuilder.Append("\":{\"Key\":\"");
					unsafeStringBuilder.Append(LogRecordJsonWriter.EscapeJsString(item2));
					unsafeStringBuilder.Append("\",\"Value\":\"");
					unsafeStringBuilder.Append(LogRecordJsonWriter.EscapeJsString(valueBuilder.ToString()));
					unsafeStringBuilder.Append("\"}");
					num++;
					logBuilder.Append('[');
					logBuilder.Append(item2);
					logBuilder.Append(": ");
					logBuilder.Append(valueBuilder);
					logBuilder.Append(']');
				}
				else
				{
					logBuilder.Append('[');
					logBuilder.Append(item2);
					logBuilder.Append(": ");
					this.AppendValueToBuilder(logBuilder, item3);
					logBuilder.Append(']');
				}
			}
			if (unsafeStringBuilder != null)
			{
				unsafeStringBuilder.Append('}');
			}
		}
		string arg = null;
		if (trace)
		{
			UnsafeStringBuilder stackContentBuilder = global::Log.StackContentBuilder;
			stackContentBuilder.Clear();
			this.GetStack(stackContentBuilder, error, (error == null) ? 2 : 0);
			logBuilder.Append(stackContentBuilder);
			arg = stackContentBuilder.ToString();
		}
		Action<int, global::ELogLevel, ELogModule, ELogAuthor, string, UnsafeStringBuilder, string> @delegate = this.Delegate;
		if (@delegate != null)
		{
			@delegate(this.Increment, level, module, author, message, unsafeStringBuilder, arg);
		}
		if (level < global::ELogLevel.Max)
		{
			UnrealLogger.Print(global::Log.ToUeLogLevel(level), logBuilder);
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00008448 File Offset: 0x00006648
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
		if (value is ValueType)
		{
			builder.Append(value.ToString());
			return;
		}
		ILogFormattedPrint logFormattedPrint = value as ILogFormattedPrint;
		if (logFormattedPrint != null)
		{
			logFormattedPrint.ToFormattedString(builder);
			return;
		}
		bool flag = value is IDictionary || value is IEnumerable;
		if (flag)
		{
			if (global::Log._containerDepth >= 4)
			{
				builder.Append("...");
				return;
			}
			if (global::Log._visitedContainers == null)
			{
				global::Log._visitedContainers = new HashSet<object>(ReferenceEqualityComparer.Instance);
			}
			if (!global::Log._visitedContainers.Add(value))
			{
				builder.Append("<cycle>");
				return;
			}
			global::Log._containerDepth++;
			try
			{
				IDictionary dictionary = value as IDictionary;
				if (dictionary != null)
				{
					builder.Append('{');
					bool flag2 = true;
					foreach (object obj in dictionary)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						if (!flag2)
						{
							builder.Append(", ");
						}
						flag2 = false;
						this.AppendValueToBuilder(builder, dictionaryEntry.Key);
						builder.Append(": ");
						this.AppendValueToBuilder(builder, dictionaryEntry.Value);
					}
					builder.Append('}');
				}
				else
				{
					IEnumerable enumerable = (IEnumerable)value;
					builder.Append('[');
					bool flag3 = true;
					foreach (object value2 in enumerable)
					{
						if (!flag3)
						{
							builder.Append(", ");
						}
						flag3 = false;
						this.AppendValueToBuilder(builder, value2);
					}
					builder.Append(']');
				}
			}
			finally
			{
				global::Log._visitedContainers.Remove(value);
				global::Log._containerDepth--;
			}
			return;
		}
		else
		{
			UnrealUObject unrealUObject = value as UnrealUObject;
			if (unrealUObject != null)
			{
				builder.Append(unrealUObject.ToString());
				return;
			}
			if (value is Type)
			{
				builder.Append(value.ToString());
				return;
			}
			Type type = value.GetType();
			builder.Append(type.Name);
			return;
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x000086C0 File Offset: 0x000068C0
	private void GetStack(UnsafeStringBuilder contentBuilder, [Nullable(2)] Exception error, int firstStackIndex)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(8, 1, contentBuilder);
		appendInterpolatedStringHandler.AppendLiteral("\nC# 堆栈");
		appendInterpolatedStringHandler.AppendFormatted(this.CsDebugId);
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
		if (!string.IsNullOrEmpty(blueprintCallstack))
		{
			contentBuilder.Append("\nBP 堆栈:\n");
			contentBuilder.Append(blueprintCallstack);
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0000876C File Offset: 0x0000696C
	public int GenLogId()
	{
		int num = this.Increment + 1;
		this.Increment = num;
		return num;
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000127 RID: 295 RVA: 0x0000878A File Offset: 0x0000698A
	public static global::Log Instance
	{
		get
		{
			if (global::Log._instance == null)
			{
				global::Log._instance = new global::Log();
				global::Log._instance.OnInit();
			}
			return global::Log._instance;
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x000087AD File Offset: 0x000069AD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x000087AF File Offset: 0x000069AF
	public static void ResetStaticDefaultValue()
	{
		global::Log instance = global::Log._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		global::Log._instance = null;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x000087C8 File Offset: 0x000069C8
	static Log()
	{
		global::StaticVariableRegister.RegisterAndExecute(new Action(global::Log.CreateStaticDefaultValue), new Action(global::Log.ResetStaticDefaultValue));
	}

	// Token: 0x04000115 RID: 277
	private const int DEFAULT_SKIP_INDEX = 2;

	// Token: 0x04000116 RID: 278
	private const int DEFAULT_LOG_BUILDER_CAPACITY = 128;

	// Token: 0x04000117 RID: 279
	private global::ELogLevel Level = global::ELogLevel.Debug;

	// Token: 0x04000118 RID: 280
	private const bool All = false;

	// Token: 0x04000119 RID: 281
	private int Increment;

	// Token: 0x0400011A RID: 282
	[Nullable(new byte[]
	{
		2,
		1,
		2,
		2
	})]
	public Action<int, global::ELogLevel, ELogModule, ELogAuthor, string, UnsafeStringBuilder, string> Delegate;

	// Token: 0x0400011B RID: 283
	[Nullable(2)]
	private global::Stat PrintStat;

	// Token: 0x0400011C RID: 284
	[Nullable(2)]
	private global::Stat GetStackStat;

	// Token: 0x0400011D RID: 285
	[Nullable(2)]
	private global::Stat GetBpStackStat;

	// Token: 0x0400011E RID: 286
	private string CsDebugId = "";

	// Token: 0x0400011F RID: 287
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder LogBuilder = new UnsafeStringBuilder(128);

	// Token: 0x04000120 RID: 288
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder ContextBuilder = new UnsafeStringBuilder(128);

	// Token: 0x04000121 RID: 289
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder StackContentBuilder = new UnsafeStringBuilder(128);

	// Token: 0x04000122 RID: 290
	[StaticVariableRuleIgnore]
	private static readonly UnsafeStringBuilder ValueBuilder = new UnsafeStringBuilder(128);

	// Token: 0x04000123 RID: 291
	private const int MAX_CONTAINER_DEPTH = 4;

	// Token: 0x04000124 RID: 292
	[Nullable(new byte[]
	{
		2,
		1
	})]
	[StaticVariableRuleIgnore]
	private static HashSet<object> _visitedContainers;

	// Token: 0x04000125 RID: 293
	[StaticVariableRuleIgnore]
	private static int _containerDepth;

	// Token: 0x04000126 RID: 294
	[Nullable(2)]
	private static global::Log _instance;
}
