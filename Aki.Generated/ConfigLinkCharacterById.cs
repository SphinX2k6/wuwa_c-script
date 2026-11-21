using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F3 RID: 1267
	public class ConfigLinkCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DBD RID: 7613 RVA: 0x00104DAC File Offset: 0x00102FAC
		static ConfigLinkCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkCharacterById.CreateStaticDefaultValue), new Action(ConfigLinkCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00104DCC File Offset: 0x00102FCC
		public static void CreateStaticDefaultValue()
		{
			ConfigLinkCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLinkCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_link.db"),
				new ValueTuple<string, object>("文件", "l.Link功能.xlsx"),
				new ValueTuple<string, object>("表名", "LinkCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `LinkCharacter` where Id=?")
			});
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00104E4B File Offset: 0x0010304B
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkCharacterById.LogPair = null;
			ConfigLinkCharacterById.HandleId = 0;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00104E59 File Offset: 0x00103059
		public static void Init()
		{
			ConfigLinkCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkCharacterById.HandleId, "db_link.db", "select BinData from `LinkCharacter` where Id=?");
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00104E74 File Offset: 0x00103074
		public static LinkCharacter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLinkCharacterById.HandleId, ConfigLinkCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LinkCharacter?(LinkCharacter.GetRootAsLinkCharacter(configBuffer));
				}
			}
			ConfigLinkCharacterById.LogPair.Clear();
			ConfigLinkCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLinkCharacterById.HandleId, 1, p0Id, ConfigLinkCharacterById.LogPair) || ConfigCommon.Step(ConfigLinkCharacterById.HandleId, true, ConfigLinkCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLinkCharacterById.HandleId, ConfigLinkCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLinkCharacterById.HandleId, 0, ConfigLinkCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLinkCharacterById.HandleId, ConfigLinkCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LinkCharacter rootAsLinkCharacter = LinkCharacter.GetRootAsLinkCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLinkCharacterById.HandleId, ConfigLinkCharacterById.LogPair);
			return new LinkCharacter?(rootAsLinkCharacter);
		}

		// Token: 0x04002289 RID: 8841
		private const string DB = "db_link.db";

		// Token: 0x0400228A RID: 8842
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x0400228B RID: 8843
		private const string TABLE = "LinkCharacter";

		// Token: 0x0400228C RID: 8844
		private const string COMMAND = "select BinData from `LinkCharacter` where Id=?";

		// Token: 0x0400228D RID: 8845
		private const string KEY_PREFIX = "LinkCharacterById";

		// Token: 0x0400228E RID: 8846
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400228F RID: 8847
		private static int HandleId;
	}
}
