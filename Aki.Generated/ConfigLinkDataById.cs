using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DE RID: 1246
	public class ConfigLinkDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x000FE8A0 File Offset: 0x000FCAA0
		static ConfigLinkDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkDataById.CreateStaticDefaultValue), new Action(ConfigLinkDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000FE8C0 File Offset: 0x000FCAC0
		public static void CreateStaticDefaultValue()
		{
			ConfigLinkDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLinkDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_link.db"),
				new ValueTuple<string, object>("文件", "l.Link功能.xlsx"),
				new ValueTuple<string, object>("表名", "LinkData"),
				new ValueTuple<string, object>("语句", "select BinData from `LinkData` where Id=?")
			});
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x000FE93F File Offset: 0x000FCB3F
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkDataById.LogPair = null;
			ConfigLinkDataById.HandleId = 0;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x000FE94D File Offset: 0x000FCB4D
		public static void Init()
		{
			ConfigLinkDataById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkDataById.HandleId, "db_link.db", "select BinData from `LinkData` where Id=?");
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000FE968 File Offset: 0x000FCB68
		public static LinkData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLinkDataById.HandleId, ConfigLinkDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LinkData?(LinkData.GetRootAsLinkData(configBuffer));
				}
			}
			ConfigLinkDataById.LogPair.Clear();
			ConfigLinkDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLinkDataById.HandleId, 1, p0Id, ConfigLinkDataById.LogPair) || ConfigCommon.Step(ConfigLinkDataById.HandleId, true, ConfigLinkDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLinkDataById.HandleId, ConfigLinkDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLinkDataById.HandleId, 0, ConfigLinkDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLinkDataById.HandleId, ConfigLinkDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LinkData rootAsLinkData = LinkData.GetRootAsLinkData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLinkDataById.HandleId, ConfigLinkDataById.LogPair);
			return new LinkData?(rootAsLinkData);
		}

		// Token: 0x040021F6 RID: 8694
		private const string DB = "db_link.db";

		// Token: 0x040021F7 RID: 8695
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x040021F8 RID: 8696
		private const string TABLE = "LinkData";

		// Token: 0x040021F9 RID: 8697
		private const string COMMAND = "select BinData from `LinkData` where Id=?";

		// Token: 0x040021FA RID: 8698
		private const string KEY_PREFIX = "LinkDataById";

		// Token: 0x040021FB RID: 8699
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021FC RID: 8700
		private static int HandleId;
	}
}
