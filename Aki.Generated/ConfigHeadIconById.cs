using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D0 RID: 976
	public class ConfigHeadIconById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016E7 RID: 5863 RVA: 0x000DAF8C File Offset: 0x000D918C
		static ConfigHeadIconById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHeadIconById.CreateStaticDefaultValue), new Action(ConfigHeadIconById.ResetStaticDefaultValue));
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x000DAFAC File Offset: 0x000D91AC
		public static void CreateStaticDefaultValue()
		{
			ConfigHeadIconById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHeadIconById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_head_icon.db"),
				new ValueTuple<string, object>("文件", "t.头像.xlsx"),
				new ValueTuple<string, object>("表名", "HeadIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `HeadIcon` where Id=?")
			});
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000DB02B File Offset: 0x000D922B
		public static void ResetStaticDefaultValue()
		{
			ConfigHeadIconById.LogPair = null;
			ConfigHeadIconById.HandleId = 0;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000DB039 File Offset: 0x000D9239
		public static void Init()
		{
			ConfigHeadIconById.HandleId = ConfigCommon.InitDataStatement(ConfigHeadIconById.HandleId, "db_head_icon.db", "select BinData from `HeadIcon` where Id=?");
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x000DB054 File Offset: 0x000D9254
		public static HeadIcon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HeadIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HeadIcon?(HeadIcon.GetRootAsHeadIcon(configBuffer));
				}
			}
			ConfigHeadIconById.LogPair.Clear();
			ConfigHeadIconById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHeadIconById.HandleId, 1, p0Id, ConfigHeadIconById.LogPair) || ConfigCommon.Step(ConfigHeadIconById.HandleId, true, ConfigHeadIconById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHeadIconById.HandleId, 0, ConfigHeadIconById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HeadIcon rootAsHeadIcon = HeadIcon.GetRootAsHeadIcon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HeadIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair);
			return new HeadIcon?(rootAsHeadIcon);
		}

		// Token: 0x04001A94 RID: 6804
		private const string DB = "db_head_icon.db";

		// Token: 0x04001A95 RID: 6805
		private const string FILE = "t.头像.xlsx";

		// Token: 0x04001A96 RID: 6806
		private const string TABLE = "HeadIcon";

		// Token: 0x04001A97 RID: 6807
		private const string COMMAND = "select BinData from `HeadIcon` where Id=?";

		// Token: 0x04001A98 RID: 6808
		private const string KEY_PREFIX = "HeadIconById";

		// Token: 0x04001A99 RID: 6809
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A9A RID: 6810
		private static int HandleId;
	}
}
