using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FB RID: 251
	public class ConfigBeginnerGuideById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x0007E8F0 File Offset: 0x0007CAF0
		static ConfigBeginnerGuideById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBeginnerGuideById.CreateStaticDefaultValue), new Action(ConfigBeginnerGuideById.ResetStaticDefaultValue));
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0007E910 File Offset: 0x0007CB10
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

		// Token: 0x060005E5 RID: 1509 RVA: 0x0007E98F File Offset: 0x0007CB8F
		public static void ResetStaticDefaultValue()
		{
			ConfigBeginnerGuideById.LogPair = null;
			ConfigBeginnerGuideById.HandleId = 0;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0007E99D File Offset: 0x0007CB9D
		public static void Init()
		{
			ConfigBeginnerGuideById.HandleId = ConfigCommon.InitDataStatement(ConfigBeginnerGuideById.HandleId, "db_beginnerlogreport.db", "select BinData from `BeginnerGuide` where Id=?");
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0007E9B8 File Offset: 0x0007CBB8
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

		// Token: 0x040006C1 RID: 1729
		private const string DB = "db_beginnerlogreport.db";

		// Token: 0x040006C2 RID: 1730
		private const string FILE = "x.新手打点.xlsx";

		// Token: 0x040006C3 RID: 1731
		private const string TABLE = "BeginnerGuide";

		// Token: 0x040006C4 RID: 1732
		private const string COMMAND = "select BinData from `BeginnerGuide` where Id=?";

		// Token: 0x040006C5 RID: 1733
		private const string KEY_PREFIX = "BeginnerGuideById";

		// Token: 0x040006C6 RID: 1734
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006C7 RID: 1735
		private static int HandleId;
	}
}
