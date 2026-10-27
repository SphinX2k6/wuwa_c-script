using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000143 RID: 323
	public class ConfigCharacterDisplayStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x00084898 File Offset: 0x00082A98
		static ConfigCharacterDisplayStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterDisplayStyleById.CreateStaticDefaultValue), new Action(ConfigCharacterDisplayStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000848B8 File Offset: 0x00082AB8
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

		// Token: 0x06000795 RID: 1941 RVA: 0x00084937 File Offset: 0x00082B37
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterDisplayStyleById.LogPair = null;
			ConfigCharacterDisplayStyleById.HandleId = 0;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00084945 File Offset: 0x00082B45
		public static void Init()
		{
			ConfigCharacterDisplayStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterDisplayStyleById.HandleId, "db_characterdisplaystyle.db", "select BinData from `CharacterDisplayStyle` where Id=?");
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00084960 File Offset: 0x00082B60
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

		// Token: 0x040008B9 RID: 2233
		private const string DB = "db_characterdisplaystyle.db";

		// Token: 0x040008BA RID: 2234
		private const string FILE = "k.可视化编辑/c.Csv/j.角色展示样式/*.csv*";

		// Token: 0x040008BB RID: 2235
		private const string TABLE = "CharacterDisplayStyle";

		// Token: 0x040008BC RID: 2236
		private const string COMMAND = "select BinData from `CharacterDisplayStyle` where Id=?";

		// Token: 0x040008BD RID: 2237
		private const string KEY_PREFIX = "CharacterDisplayStyleById";

		// Token: 0x040008BE RID: 2238
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008BF RID: 2239
		private static int HandleId;
	}
}
