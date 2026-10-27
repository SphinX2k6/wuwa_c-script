using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EC RID: 236
	public class ConfigBeginnerGuideById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00078F8C File Offset: 0x0007718C
		static ConfigBeginnerGuideById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBeginnerGuideById.CreateStaticDefaultValue), new Action(ConfigBeginnerGuideById.ResetStaticDefaultValue));
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00078FAC File Offset: 0x000771AC
		public static void CreateStaticDefaultValue()
		{
			ConfigBeginnerGuideById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBeginnerGuideById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_beginnerlogreport.db"),
				new ValueTuple<string, object>("文件", "x.新手打点.xlsx"),
				new ValueTuple<string, object>("表名", "BeginnerGuide"),
				new ValueTuple<string, object>("语句", "select BinData from `BeginnerGuide` where Id=?")
			});
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0007902B File Offset: 0x0007722B
		public static void ResetStaticDefaultValue()
		{
			ConfigBeginnerGuideById.LogPair = null;
			ConfigBeginnerGuideById.HandleId = 0;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00079039 File Offset: 0x00077239
		public static void Init()
		{
			ConfigBeginnerGuideById.HandleId = ConfigCommon.InitDataStatement(ConfigBeginnerGuideById.HandleId, "db_beginnerlogreport.db", "select BinData from `BeginnerGuide` where Id=?");
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00079054 File Offset: 0x00077254
		public static BeginnerGuide? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBeginnerGuideById.HandleId, ConfigBeginnerGuideById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BeginnerGuideById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BeginnerGuide?(BeginnerGuide.GetRootAsBeginnerGuide(configBuffer));
				}
			}
			ConfigBeginnerGuideById.LogPair.Clear();
			ConfigBeginnerGuideById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBeginnerGuideById.HandleId, 1, p0Id, ConfigBeginnerGuideById.LogPair) || ConfigCommon.Step(ConfigBeginnerGuideById.HandleId, true, ConfigBeginnerGuideById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBeginnerGuideById.HandleId, ConfigBeginnerGuideById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBeginnerGuideById.HandleId, 0, ConfigBeginnerGuideById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBeginnerGuideById.HandleId, ConfigBeginnerGuideById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BeginnerGuide rootAsBeginnerGuide = BeginnerGuide.GetRootAsBeginnerGuide(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BeginnerGuideById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBeginnerGuideById.HandleId, ConfigBeginnerGuideById.LogPair);
			return new BeginnerGuide?(rootAsBeginnerGuide);
		}

		// Token: 0x04000658 RID: 1624
		private const string DB = "db_beginnerlogreport.db";

		// Token: 0x04000659 RID: 1625
		private const string FILE = "x.新手打点.xlsx";

		// Token: 0x0400065A RID: 1626
		private const string TABLE = "BeginnerGuide";

		// Token: 0x0400065B RID: 1627
		private const string COMMAND = "select BinData from `BeginnerGuide` where Id=?";

		// Token: 0x0400065C RID: 1628
		private const string KEY_PREFIX = "BeginnerGuideById";

		// Token: 0x0400065D RID: 1629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400065E RID: 1630
		private static int HandleId;
	}
}
