using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extensions;
using CSharpScript.Typing;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Launcher.Define.SimpleTabel
{
	// Token: 0x02000254 RID: 596
	[NullableContext(1)]
	[Nullable(0)]
	public class TableReaderUtil : IStaticVariableResetter
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x000599D5 File Offset: 0x00057BD5
		static TableReaderUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TableReaderUtil.CreateStaticDefaultValue), new Action(TableReaderUtil.ResetStaticDefaultValue));
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000599F4 File Offset: 0x00057BF4
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public static T[] ReadArray<T>(int fieldOffset, [Nullable(1)] ByteBuffer byteBuffer, int bbPos, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<ByteBuffer, int, T> readItemFunc) where T : struct
		{
			Table table = new Table(bbPos, byteBuffer);
			return table.__vector_as_array<T>(fieldOffset) ?? Array.Empty<T>();
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00059A1C File Offset: 0x00057C1C
		public static int GetIntFromCommonConfig(string key, int defaultValue)
		{
			string dbPath = KuroApplication.ProjectContentDir() + "Aki/ConfigDB/db_common_param.db";
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 2);
			defaultInterpolatedStringHandler.AppendLiteral("select BinData from `");
			defaultInterpolatedStringHandler.AppendFormatted("CommonParam");
			defaultInterpolatedStringHandler.AppendLiteral("` where KeyName = '");
			defaultInterpolatedStringHandler.AppendFormatted(key);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			int result;
			try
			{
				if (!UKuroSqliteLibrary.Query(dbPath, sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询CommonParam失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = defaultValue;
				}
				else
				{
					FArrayBuffer farrayBuffer = default(FArrayBuffer);
					if (!ukuroSqliteResultSet.GetBytes("BinData", ref farrayBuffer))
					{
						LauncherLog.Instance.Error("获取CommonParam数据字段失败，没有BinData字段", default(ReadOnlySpan<ValueTuple<string, object>>));
						result = defaultValue;
					}
					else if (farrayBuffer.Length < 4UL)
					{
						result = defaultValue;
					}
					else
					{
						result = BitConverter.ToInt32(farrayBuffer.ToByteArray(), 0);
					}
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00059B34 File Offset: 0x00057D34
		public static void CreateStaticDefaultValue()
		{
			TableReaderUtil.ArrayCapacityObject = new Dictionary<int, int>();
			TableReaderUtil.ArrayElementInitFunc = (() => 0);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00059B64 File Offset: 0x00057D64
		public static void ResetStaticDefaultValue()
		{
			TableReaderUtil.ArrayCapacityObject = null;
			TableReaderUtil.ArrayElementInitFunc = null;
		}

		// Token: 0x040009C9 RID: 2505
		private static Dictionary<int, int> ArrayCapacityObject;

		// Token: 0x040009CA RID: 2506
		private static Func<object> ArrayElementInitFunc;

		// Token: 0x040009CB RID: 2507
		private const string CommonConfigDb = "db_common_param.db";

		// Token: 0x040009CC RID: 2508
		private const string CommonConfigTableName = "CommonParam";
	}
}
