using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000152 RID: 338
	public class ConfigCharacterDisplayStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007ED RID: 2029 RVA: 0x0008A1FC File Offset: 0x000883FC
		static ConfigCharacterDisplayStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterDisplayStyleById.CreateStaticDefaultValue), new Action(ConfigCharacterDisplayStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0008A21C File Offset: 0x0008841C
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterDisplayStyleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterDisplayStyleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_characterdisplaystyle.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.角色展示样式/*.csv*"),
				new ValueTuple<string, object>("表名", "CharacterDisplayStyle"),
				new ValueTuple<string, object>("语句", "select BinData from `CharacterDisplayStyle` where Id=?")
			});
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0008A29B File Offset: 0x0008849B
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterDisplayStyleById.LogPair = null;
			ConfigCharacterDisplayStyleById.HandleId = 0;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0008A2A9 File Offset: 0x000884A9
		public static void Init()
		{
			ConfigCharacterDisplayStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterDisplayStyleById.HandleId, "db_characterdisplaystyle.db", "select BinData from `CharacterDisplayStyle` where Id=?");
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0008A2C4 File Offset: 0x000884C4
		public static CharacterDisplayStyle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterDisplayStyleById.HandleId, ConfigCharacterDisplayStyleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterDisplayStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CharacterDisplayStyle?(CharacterDisplayStyle.GetRootAsCharacterDisplayStyle(configBuffer));
				}
			}
			ConfigCharacterDisplayStyleById.LogPair.Clear();
			ConfigCharacterDisplayStyleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCharacterDisplayStyleById.HandleId, 1, p0Id, ConfigCharacterDisplayStyleById.LogPair) || ConfigCommon.Step(ConfigCharacterDisplayStyleById.HandleId, true, ConfigCharacterDisplayStyleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCharacterDisplayStyleById.HandleId, ConfigCharacterDisplayStyleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterDisplayStyleById.HandleId, 0, ConfigCharacterDisplayStyleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCharacterDisplayStyleById.HandleId, ConfigCharacterDisplayStyleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CharacterDisplayStyle rootAsCharacterDisplayStyle = CharacterDisplayStyle.GetRootAsCharacterDisplayStyle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterDisplayStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCharacterDisplayStyleById.HandleId, ConfigCharacterDisplayStyleById.LogPair);
			return new CharacterDisplayStyle?(rootAsCharacterDisplayStyle);
		}

		// Token: 0x04000922 RID: 2338
		private const string DB = "db_characterdisplaystyle.db";

		// Token: 0x04000923 RID: 2339
		private const string FILE = "k.可视化编辑/c.Csv/j.角色展示样式/*.csv*";

		// Token: 0x04000924 RID: 2340
		private const string TABLE = "CharacterDisplayStyle";

		// Token: 0x04000925 RID: 2341
		private const string COMMAND = "select BinData from `CharacterDisplayStyle` where Id=?";

		// Token: 0x04000926 RID: 2342
		private const string KEY_PREFIX = "CharacterDisplayStyleById";

		// Token: 0x04000927 RID: 2343
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000928 RID: 2344
		private static int HandleId;
	}
}
