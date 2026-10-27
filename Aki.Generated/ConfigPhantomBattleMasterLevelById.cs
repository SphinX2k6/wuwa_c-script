using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067F RID: 1663
	public class ConfigPhantomBattleMasterLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600270A RID: 9994 RVA: 0x001366E3 File Offset: 0x001348E3
		static ConfigPhantomBattleMasterLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterLevelById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00136704 File Offset: 0x00134904
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMasterLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMasterLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMasterLevel` where Id=?")
			});
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00136783 File Offset: 0x00134983
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelById.LogPair = null;
			ConfigPhantomBattleMasterLevelById.HandleId = 0;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00136791 File Offset: 0x00134991
		public static void Init()
		{
			ConfigPhantomBattleMasterLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterLevelById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterLevel` where Id=?");
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x001367AC File Offset: 0x001349AC
		public static PhantomBattleMasterLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMasterLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleMasterLevel?(PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(configBuffer));
				}
			}
			ConfigPhantomBattleMasterLevelById.LogPair.Clear();
			ConfigPhantomBattleMasterLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMasterLevelById.HandleId, 1, p0Id, ConfigPhantomBattleMasterLevelById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleMasterLevelById.HandleId, true, ConfigPhantomBattleMasterLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMasterLevelById.HandleId, 0, ConfigPhantomBattleMasterLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleMasterLevel rootAsPhantomBattleMasterLevel = PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMasterLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMasterLevelById.HandleId, ConfigPhantomBattleMasterLevelById.LogPair);
			return new PhantomBattleMasterLevel?(rootAsPhantomBattleMasterLevel);
		}

		// Token: 0x04002D5F RID: 11615
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D60 RID: 11616
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D61 RID: 11617
		private const string TABLE = "PhantomBattleMasterLevel";

		// Token: 0x04002D62 RID: 11618
		private const string COMMAND = "select BinData from `PhantomBattleMasterLevel` where Id=?";

		// Token: 0x04002D63 RID: 11619
		private const string KEY_PREFIX = "PhantomBattleMasterLevelById";

		// Token: 0x04002D64 RID: 11620
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D65 RID: 11621
		private static int HandleId;
	}
}
