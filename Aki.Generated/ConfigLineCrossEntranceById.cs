using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D9 RID: 1241
	public class ConfigLineCrossEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D21 RID: 7457 RVA: 0x000FDD48 File Offset: 0x000FBF48
		static ConfigLineCrossEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossEntranceById.CreateStaticDefaultValue), new Action(ConfigLineCrossEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000FDD68 File Offset: 0x000FBF68
		public static void CreateStaticDefaultValue()
		{
			ConfigLineCrossEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLineCrossEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_linecross.db"),
				new ValueTuple<string, object>("文件", "s.十字连线.xlsx"),
				new ValueTuple<string, object>("表名", "LineCrossEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LineCrossEntrance` where Id=?")
			});
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000FDDE7 File Offset: 0x000FBFE7
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossEntranceById.LogPair = null;
			ConfigLineCrossEntranceById.HandleId = 0;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000FDDF5 File Offset: 0x000FBFF5
		public static void Init()
		{
			ConfigLineCrossEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossEntranceById.HandleId, "db_linecross.db", "select BinData from `LineCrossEntrance` where Id=?");
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000FDE10 File Offset: 0x000FC010
		public static LineCrossEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLineCrossEntranceById.HandleId, ConfigLineCrossEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LineCrossEntrance?(LineCrossEntrance.GetRootAsLineCrossEntrance(configBuffer));
				}
			}
			ConfigLineCrossEntranceById.LogPair.Clear();
			ConfigLineCrossEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLineCrossEntranceById.HandleId, 1, p0Id, ConfigLineCrossEntranceById.LogPair) || ConfigCommon.Step(ConfigLineCrossEntranceById.HandleId, true, ConfigLineCrossEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLineCrossEntranceById.HandleId, ConfigLineCrossEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLineCrossEntranceById.HandleId, 0, ConfigLineCrossEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLineCrossEntranceById.HandleId, ConfigLineCrossEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LineCrossEntrance rootAsLineCrossEntrance = LineCrossEntrance.GetRootAsLineCrossEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLineCrossEntranceById.HandleId, ConfigLineCrossEntranceById.LogPair);
			return new LineCrossEntrance?(rootAsLineCrossEntrance);
		}

		// Token: 0x040021D3 RID: 8659
		private const string DB = "db_linecross.db";

		// Token: 0x040021D4 RID: 8660
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x040021D5 RID: 8661
		private const string TABLE = "LineCrossEntrance";

		// Token: 0x040021D6 RID: 8662
		private const string COMMAND = "select BinData from `LineCrossEntrance` where Id=?";

		// Token: 0x040021D7 RID: 8663
		private const string KEY_PREFIX = "LineCrossEntranceById";

		// Token: 0x040021D8 RID: 8664
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021D9 RID: 8665
		private static int HandleId;
	}
}
