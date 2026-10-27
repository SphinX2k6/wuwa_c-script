using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extensions;
using CSharpScript.Typing;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Launcher.Define.SimpleTabel
{
	// Token: 0x0200024C RID: 588
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TableReader<[Nullable(0)] T> where T : TableBaseRow
	{
		// Token: 0x06000EC6 RID: 3782
		protected abstract string GetTableName();

		// Token: 0x06000EC7 RID: 3783
		protected abstract string GetDbFile();

		// Token: 0x06000EC8 RID: 3784
		protected abstract string GetIdString();

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00056A9A File Offset: 0x00054C9A
		private string GetDbPath()
		{
			return KuroApplication.ProjectContentDir() + "Aki/ConfigDB/" + this.GetDbFile();
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00056AB4 File Offset: 0x00054CB4
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

		// Token: 0x06000ECB RID: 3787 RVA: 0x00056AEC File Offset: 0x00054CEC
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

		// Token: 0x06000ECC RID: 3788 RVA: 0x00056B14 File Offset: 0x00054D14
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

		// Token: 0x06000ECD RID: 3789 RVA: 0x00056C88 File Offset: 0x00054E88
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

		// Token: 0x06000ECE RID: 3790
		public abstract T Parse(ByteBuffer byteBuffer);

		// Token: 0x06000ECF RID: 3791 RVA: 0x00056DBC File Offset: 0x00054FBC
		public List<T> GetAll()
		{
			if (this.Rows.Count == 0)
			{
				this.Rows = this.LoadFromDb();
			}
			return this.Rows;
		}

		// Token: 0x0400097E RID: 2430
		protected List<T> Rows = new List<T>();

		// Token: 0x0400097F RID: 2431
		protected Dictionary<object, T> RowMap = new Dictionary<object, T>();
	}
}
