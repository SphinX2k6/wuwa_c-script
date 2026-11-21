using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02003F65 RID: 16229
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class QuestMultiLineConfig : ConfigBase
	{
		// Token: 0x06029168 RID: 168296 RVA: 0x00B89DEB File Offset: 0x00B87FEB
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06029169 RID: 168297 RVA: 0x00B89DEE File Offset: 0x00B87FEE
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0602916A RID: 168298 RVA: 0x00B89DF4 File Offset: 0x00B87FF4
		public static QuestTimePointConfig? GetTimePointConfigById(int id)
		{
			QuestTimePointConfig? config = ConfigQuestTimePointConfigById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestTimePointConfig表 无效id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0602916B RID: 168299 RVA: 0x00B89E44 File Offset: 0x00B88044
		public static QuestTimeComponentConfig? GetComponentConfigById(int id)
		{
			QuestTimeComponentConfig? config = ConfigQuestTimeComponentConfigById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestTimeComponentConfig表 无效id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0602916C RID: 168300 RVA: 0x00B89E94 File Offset: 0x00B88094
		public static QuestComponentStatusType? GetComponentStatusConfigById(int id)
		{
			QuestComponentStatusType? config = ConfigQuestComponentStatusTypeById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestComponentStatusType表 无效Id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0602916D RID: 168301 RVA: 0x00B89EE4 File Offset: 0x00B880E4
		public static QuestBranchPageConfig? GetBranchPageConfigById(int id)
		{
			QuestBranchPageConfig? config = ConfigQuestBranchPageConfigById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestBranchPageConfig表 无效id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0602916E RID: 168302 RVA: 0x00B89F34 File Offset: 0x00B88134
		public static QuestBranchConfig? GetQuestBranchConfig(int id)
		{
			QuestBranchConfig? config = ConfigQuestBranchConfigById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestBranchConfig表 无效id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0602916F RID: 168303 RVA: 0x00B89F84 File Offset: 0x00B88184
		[NullableContext(2)]
		public static IReadOnlyList<QuestTimePointConfig> GetAllTimePointConfigs()
		{
			IReadOnlyList<QuestTimePointConfig> configList = ConfigQuestTimePointConfigAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.QuestMultiLine, ELogAuthor.CCJ, "QuestTimePointConfig表无数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x06029170 RID: 168304 RVA: 0x00B89FBC File Offset: 0x00B881BC
		public static QuestBranchComponentGroup? GetBranchComponentGroupConfig(int id)
		{
			QuestBranchComponentGroup? config = ConfigQuestBranchComponentGroupById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestBranchComponentGroup表 无效id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x06029171 RID: 168305 RVA: 0x00B8A00A File Offset: 0x00B8820A
		public static QuestMultiLineConfig Instance
		{
			get
			{
				return QuestMultiLineConfig._Instance;
			}
		}

		// Token: 0x06029172 RID: 168306 RVA: 0x00B8A011 File Offset: 0x00B88211
		public static QuestMultiLineConfig GetOrCreateInstance()
		{
			if (QuestMultiLineConfig._Instance == null)
			{
				QuestMultiLineConfig.CreateInstance();
			}
			return QuestMultiLineConfig._Instance;
		}

		// Token: 0x06029173 RID: 168307 RVA: 0x00B8A025 File Offset: 0x00B88225
		public static bool CreateInstance()
		{
			if (QuestMultiLineConfig._Instance != null)
			{
				return true;
			}
			QuestMultiLineConfig._Instance = new QuestMultiLineConfig();
			return true;
		}

		// Token: 0x06029174 RID: 168308 RVA: 0x00B8A03B File Offset: 0x00B8823B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029175 RID: 168309 RVA: 0x00B8A03D File Offset: 0x00B8823D
		public static void ResetStaticDefaultValue()
		{
			QuestMultiLineConfig._Instance = null;
		}

		// Token: 0x06029176 RID: 168310 RVA: 0x00B8A045 File Offset: 0x00B88245
		static QuestMultiLineConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuestMultiLineConfig.CreateStaticDefaultValue), new Action(QuestMultiLineConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040165B9 RID: 91577
		[Nullable(2)]
		private static QuestMultiLineConfig _Instance;
	}
}
