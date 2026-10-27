using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DD RID: 1245
	public class ConfigLinkCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D39 RID: 7481 RVA: 0x000FE658 File Offset: 0x000FC858
		static ConfigLinkCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkCharacterById.CreateStaticDefaultValue), new Action(ConfigLinkCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000FE678 File Offset: 0x000FC878
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

		// Token: 0x06001D3B RID: 7483 RVA: 0x000FE6F7 File Offset: 0x000FC8F7
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkCharacterById.LogPair = null;
			ConfigLinkCharacterById.HandleId = 0;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000FE705 File Offset: 0x000FC905
		public static void Init()
		{
			ConfigLinkCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkCharacterById.HandleId, "db_link.db", "select BinData from `LinkCharacter` where Id=?");
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x000FE720 File Offset: 0x000FC920
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

		// Token: 0x040021EF RID: 8687
		private const string DB = "db_link.db";

		// Token: 0x040021F0 RID: 8688
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x040021F1 RID: 8689
		private const string TABLE = "LinkCharacter";

		// Token: 0x040021F2 RID: 8690
		private const string COMMAND = "select BinData from `LinkCharacter` where Id=?";

		// Token: 0x040021F3 RID: 8691
		private const string KEY_PREFIX = "LinkCharacterById";

		// Token: 0x040021F4 RID: 8692
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021F5 RID: 8693
		private static int HandleId;
	}
}
