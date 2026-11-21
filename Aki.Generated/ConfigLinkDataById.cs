using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F4 RID: 1268
	public class ConfigLinkDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DC3 RID: 7619 RVA: 0x00104FF4 File Offset: 0x001031F4
		static ConfigLinkDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkDataById.CreateStaticDefaultValue), new Action(ConfigLinkDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00105014 File Offset: 0x00103214
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

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00105093 File Offset: 0x00103293
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkDataById.LogPair = null;
			ConfigLinkDataById.HandleId = 0;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x001050A1 File Offset: 0x001032A1
		public static void Init()
		{
			ConfigLinkDataById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkDataById.HandleId, "db_link.db", "select BinData from `LinkData` where Id=?");
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x001050BC File Offset: 0x001032BC
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

		// Token: 0x04002290 RID: 8848
		private const string DB = "db_link.db";

		// Token: 0x04002291 RID: 8849
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x04002292 RID: 8850
		private const string TABLE = "LinkData";

		// Token: 0x04002293 RID: 8851
		private const string COMMAND = "select BinData from `LinkData` where Id=?";

		// Token: 0x04002294 RID: 8852
		private const string KEY_PREFIX = "LinkDataById";

		// Token: 0x04002295 RID: 8853
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002296 RID: 8854
		private static int HandleId;
	}
}
