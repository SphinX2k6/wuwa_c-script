using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02004F9C RID: 20380
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class QuestMultiLineConfig : ConfigBase
	{
		// Token: 0x060342FA RID: 213754 RVA: 0x00C4063F File Offset: 0x00C3E83F
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060342FB RID: 213755 RVA: 0x00C40642 File Offset: 0x00C3E842
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x060342FC RID: 213756 RVA: 0x00C40648 File Offset: 0x00C3E848
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

		// Token: 0x060342FD RID: 213757 RVA: 0x00C40698 File Offset: 0x00C3E898
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

		// Token: 0x060342FE RID: 213758 RVA: 0x00C406E8 File Offset: 0x00C3E8E8
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

		// Token: 0x060342FF RID: 213759 RVA: 0x00C40738 File Offset: 0x00C3E938
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

		// Token: 0x06034300 RID: 213760 RVA: 0x00C40788 File Offset: 0x00C3E988
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

		// Token: 0x06034301 RID: 213761 RVA: 0x00C407D8 File Offset: 0x00C3E9D8
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

		// Token: 0x06034302 RID: 213762 RVA: 0x00C40810 File Offset: 0x00C3EA10
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

		// Token: 0x17007F6D RID: 32621
		// (get) Token: 0x06034303 RID: 213763 RVA: 0x00C4085E File Offset: 0x00C3EA5E
		public static QuestMultiLineConfig Instance
		{
			get
			{
				return QuestMultiLineConfig._Instance;
			}
		}

		// Token: 0x06034304 RID: 213764 RVA: 0x00C40865 File Offset: 0x00C3EA65
		public static QuestMultiLineConfig GetOrCreateInstance()
		{
			if (QuestMultiLineConfig._Instance == null)
			{
				QuestMultiLineConfig.CreateInstance();
			}
			return QuestMultiLineConfig._Instance;
		}

		// Token: 0x06034305 RID: 213765 RVA: 0x00C40879 File Offset: 0x00C3EA79
		public static bool CreateInstance()
		{
			if (QuestMultiLineConfig._Instance != null)
			{
				return true;
			}
			QuestMultiLineConfig._Instance = new QuestMultiLineConfig();
			return true;
		}

		// Token: 0x06034306 RID: 213766 RVA: 0x00C4088F File Offset: 0x00C3EA8F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034307 RID: 213767 RVA: 0x00C40891 File Offset: 0x00C3EA91
		public static void ResetStaticDefaultValue()
		{
			QuestMultiLineConfig._Instance = null;
		}

		// Token: 0x06034308 RID: 213768 RVA: 0x00C40899 File Offset: 0x00C3EA99
		static QuestMultiLineConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuestMultiLineConfig.CreateStaticDefaultValue), new Action(QuestMultiLineConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BBE4 RID: 113636
		[Nullable(2)]
		private static QuestMultiLineConfig _Instance;
	}
}
