using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000169 RID: 361
	[NullableContext(1)]
	[Nullable(0)]
	public class ConnectDbObject : IStaticVariableResetter
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x0003AFBB File Offset: 0x000391BB
		static ConnectDbObject()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ConnectDbObject.CreateStaticDefaultValue), new Action(ConnectDbObject.ResetStaticDefaultValue));
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0003AFDA File Offset: 0x000391DA
		private static string GetProjectContentDir()
		{
			if (string.IsNullOrEmpty(ConnectDbObject.ProjectContentDir))
			{
				ConnectDbObject.ProjectContentDir = UBlueprintPathsLibrary.ProjectContentDir();
			}
			return ConnectDbObject.ProjectContentDir;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0003AFF7 File Offset: 0x000391F7
		public int HandleId
		{
			get
			{
				return this.HandleIdInternal;
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0003B000 File Offset: 0x00039200
		private unsafe int CreateDbConnection(string dbPath, string command)
		{
			int num = ConfigStatementLibSync.CreateStatement(dbPath, command);
			if (num != -2)
			{
				if (num == -1)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.CommonDbConnect;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "找不到Db连接";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", dbPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CommonDbConnect;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "创建语句失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", dbPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("command", command);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return num;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0003B09B File Offset: 0x0003929B
		public void DisConnectStatement()
		{
			if (this.HandleIdInternal > 0)
			{
				UKuroPrepareStatementLib.CloseConnection(this.HandleIdInternal);
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003B0B4 File Offset: 0x000392B4
		public void ConnectStatement(CommonDbData dbData)
		{
			if (!string.IsNullOrEmpty(dbData.Culture))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
				defaultInterpolatedStringHandler.AppendFormatted(ConnectDbObject.GetProjectContentDir());
				defaultInterpolatedStringHandler.AppendLiteral("Aki/ConfigDB/");
				defaultInterpolatedStringHandler.AppendFormatted(dbData.Culture);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(dbData.DbName);
				string dbPath = defaultInterpolatedStringHandler.ToStringAndClear();
				this.HandleIdInternal = this.CreateDbConnection(dbPath, dbData.Command);
				return;
			}
			string dbPath2 = ConnectDbObject.GetProjectContentDir() + "Aki/ConfigDB/" + dbData.DbName;
			this.HandleIdInternal = this.CreateDbConnection(dbPath2, dbData.Command);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0003B15B File Offset: 0x0003935B
		public static void CreateStaticDefaultValue()
		{
			ConnectDbObject.ProjectContentDir = null;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0003B163 File Offset: 0x00039363
		public static void ResetStaticDefaultValue()
		{
			ConnectDbObject.ProjectContentDir = null;
		}

		// Token: 0x0400072F RID: 1839
		[Nullable(2)]
		private static string ProjectContentDir;

		// Token: 0x04000730 RID: 1840
		private int HandleIdInternal;
	}
}
