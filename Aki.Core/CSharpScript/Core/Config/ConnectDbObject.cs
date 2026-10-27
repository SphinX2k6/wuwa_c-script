using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000164 RID: 356
	[NullableContext(1)]
	[Nullable(0)]
	public class ConnectDbObject : IStaticVariableResetter
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x0003A277 File Offset: 0x00038477
		static ConnectDbObject()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ConnectDbObject.CreateStaticDefaultValue), new Action(ConnectDbObject.ResetStaticDefaultValue));
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003A296 File Offset: 0x00038496
		private static string GetProjectContentDir()
		{
			if (string.IsNullOrEmpty(ConnectDbObject.ProjectContentDir))
			{
				ConnectDbObject.ProjectContentDir = UBlueprintPathsLibrary.ProjectContentDir();
			}
			return ConnectDbObject.ProjectContentDir;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003A2B3 File Offset: 0x000384B3
		public int HandleId
		{
			get
			{
				return this.HandleIdInternal;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0003A2BC File Offset: 0x000384BC
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

		// Token: 0x06000C3E RID: 3134 RVA: 0x0003A357 File Offset: 0x00038557
		public void DisConnectStatement()
		{
			if (this.HandleIdInternal > 0)
			{
				UKuroPrepareStatementLib.CloseConnection(this.HandleIdInternal);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0003A370 File Offset: 0x00038570
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

		// Token: 0x06000C40 RID: 3136 RVA: 0x0003A417 File Offset: 0x00038617
		public static void CreateStaticDefaultValue()
		{
			ConnectDbObject.ProjectContentDir = null;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0003A41F File Offset: 0x0003861F
		public static void ResetStaticDefaultValue()
		{
			ConnectDbObject.ProjectContentDir = null;
		}

		// Token: 0x04000720 RID: 1824
		[Nullable(2)]
		private static string ProjectContentDir;

		// Token: 0x04000721 RID: 1825
		private int HandleIdInternal;
	}
}
