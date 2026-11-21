using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extensions;
using CSharpScript.Typing;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Launcher.Define.SimpleTabel
{
	// Token: 0x02000251 RID: 593
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TableReader<[Nullable(0)] T> where T : TableBaseRow
	{
		// Token: 0x06000F07 RID: 3847
		protected abstract string GetTableName();

		// Token: 0x06000F08 RID: 3848
		protected abstract string GetDbFile();

		// Token: 0x06000F09 RID: 3849
		protected abstract string GetIdString();

		// Token: 0x06000F0A RID: 3850 RVA: 0x000595DE File Offset: 0x000577DE
		private string GetDbPath()
		{
			return KuroApplication.ProjectContentDir() + "Aki/ConfigDB/" + this.GetDbFile();
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000595F8 File Offset: 0x000577F8
		[NullableContext(2)]
		public T GetById(int id)
		{
			T result;
			if (this.RowMap.TryGetValue(id, out result))
			{
				return result;
			}
			return this.LoadFromDbById(id, id.ToString());
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00059630 File Offset: 0x00057830
		[return: Nullable(2)]
		public T GetById(string id)
		{
			T result;
			if (this.RowMap.TryGetValue(id, out result))
			{
				return result;
			}
			return this.LoadFromDbById(id, id);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00059658 File Offset: 0x00057858
		[return: Nullable(2)]
		private T LoadFromDbById(object id, string tempId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
			defaultInterpolatedStringHandler.AppendLiteral("SELECT BinData FROM `");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetTableName());
			defaultInterpolatedStringHandler.AppendLiteral("` WHERE ");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetIdString());
			defaultInterpolatedStringHandler.AppendLiteral("=");
			defaultInterpolatedStringHandler.AppendFormatted(tempId);
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			T t;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.GetDbPath(), sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询" + this.GetTableName() + "失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", tempId);
					instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					t = default(T);
					t = t;
				}
				else
				{
					FArrayBuffer farrayBuffer = default(FArrayBuffer);
					if (!ukuroSqliteResultSet.GetBytes("BinData", ref farrayBuffer))
					{
						LauncherLog.Instance.Error("获取" + this.GetTableName() + "数据字段失败，没有BinData字段", default(ReadOnlySpan<ValueTuple<string, object>>));
						t = default(T);
					}
					else if (farrayBuffer.Length == 0UL)
					{
						t = default(T);
					}
					else
					{
						T t2 = this.Parse(new ByteBuffer(farrayBuffer.ToByteArray()));
						if (t2 != null)
						{
							this.RowMap[id] = t2;
						}
						t = t2;
					}
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return t;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000597CC File Offset: 0x000579CC
		protected List<T> LoadFromDb()
		{
			string sql = "SELECT BinData FROM `" + this.GetTableName() + "`";
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			List<T> result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.GetDbPath(), sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog.Instance.Error("查询" + this.GetTableName() + "失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = new List<T>();
				}
				else
				{
					List<T> list = new List<T>();
					for (;;)
					{
						FArrayBuffer farrayBuffer = default(FArrayBuffer);
						if (!ukuroSqliteResultSet.GetBytes("BinData", ref farrayBuffer))
						{
							break;
						}
						if (farrayBuffer.Length != 0UL)
						{
							T t = this.Parse(new ByteBuffer(farrayBuffer.ToByteArray()));
							if (t != null)
							{
								list.Add(t);
								this.RowMap[t.GetId()] = t;
							}
						}
						if (!ukuroSqliteResultSet.MoveToNext())
						{
							goto Block_7;
						}
					}
					LauncherLog.Instance.Error("获取" + this.GetTableName() + "数据字段失败，没有BinData字段", default(ReadOnlySpan<ValueTuple<string, object>>));
					return new List<T>();
					Block_7:
					result = list;
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000F0F RID: 3855
		public abstract T Parse(ByteBuffer byteBuffer);

		// Token: 0x06000F10 RID: 3856 RVA: 0x00059900 File Offset: 0x00057B00
		public List<T> GetAll()
		{
			if (this.Rows.Count == 0)
			{
				this.Rows = this.LoadFromDb();
			}
			return this.Rows;
		}

		// Token: 0x040009C6 RID: 2502
		protected List<T> Rows = new List<T>();

		// Token: 0x040009C7 RID: 2503
		protected Dictionary<object, T> RowMap = new Dictionary<object, T>();
	}
}
