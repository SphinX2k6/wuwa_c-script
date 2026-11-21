using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EF RID: 1263
	public class ConfigLineCrossEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DA5 RID: 7589 RVA: 0x0010449C File Offset: 0x0010269C
		static ConfigLineCrossEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossEntranceById.CreateStaticDefaultValue), new Action(ConfigLineCrossEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x001044BC File Offset: 0x001026BC
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

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0010453B File Offset: 0x0010273B
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossEntranceById.LogPair = null;
			ConfigLineCrossEntranceById.HandleId = 0;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00104549 File Offset: 0x00102749
		public static void Init()
		{
			ConfigLineCrossEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossEntranceById.HandleId, "db_linecross.db", "select BinData from `LineCrossEntrance` where Id=?");
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00104564 File Offset: 0x00102764
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

		// Token: 0x0400226D RID: 8813
		private const string DB = "db_linecross.db";

		// Token: 0x0400226E RID: 8814
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x0400226F RID: 8815
		private const string TABLE = "LineCrossEntrance";

		// Token: 0x04002270 RID: 8816
		private const string COMMAND = "select BinData from `LineCrossEntrance` where Id=?";

		// Token: 0x04002271 RID: 8817
		private const string KEY_PREFIX = "LineCrossEntranceById";

		// Token: 0x04002272 RID: 8818
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002273 RID: 8819
		private static int HandleId;
	}
}
