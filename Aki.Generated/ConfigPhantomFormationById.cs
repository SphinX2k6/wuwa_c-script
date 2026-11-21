using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AF RID: 1711
	public class ConfigPhantomFormationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x00140313 File Offset: 0x0013E513
		static ConfigPhantomFormationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFormationById.CreateStaticDefaultValue), new Action(ConfigPhantomFormationById.ResetStaticDefaultValue));
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00140334 File Offset: 0x0013E534
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFormationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFormationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFormation"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFormation` where Id=?")
			});
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x001403B3 File Offset: 0x0013E5B3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFormationById.LogPair = null;
			ConfigPhantomFormationById.HandleId = 0;
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x001403C1 File Offset: 0x0013E5C1
		public static void Init()
		{
			ConfigPhantomFormationById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFormationById.HandleId, "db_formation.db", "select BinData from `PhantomFormation` where Id=?");
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x001403DC File Offset: 0x0013E5DC
		public static PhantomFormation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFormationById.HandleId, ConfigPhantomFormationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFormationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomFormation?(PhantomFormation.GetRootAsPhantomFormation(configBuffer));
				}
			}
			ConfigPhantomFormationById.LogPair.Clear();
			ConfigPhantomFormationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomFormationById.HandleId, 1, p0Id, ConfigPhantomFormationById.LogPair) || ConfigCommon.Step(ConfigPhantomFormationById.HandleId, true, ConfigPhantomFormationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomFormationById.HandleId, ConfigPhantomFormationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFormationById.HandleId, 0, ConfigPhantomFormationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomFormationById.HandleId, ConfigPhantomFormationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomFormation rootAsPhantomFormation = PhantomFormation.GetRootAsPhantomFormation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFormationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomFormationById.HandleId, ConfigPhantomFormationById.LogPair);
			return new PhantomFormation?(rootAsPhantomFormation);
		}

		// Token: 0x04002EAF RID: 11951
		private const string DB = "db_formation.db";

		// Token: 0x04002EB0 RID: 11952
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04002EB1 RID: 11953
		private const string TABLE = "PhantomFormation";

		// Token: 0x04002EB2 RID: 11954
		private const string COMMAND = "select BinData from `PhantomFormation` where Id=?";

		// Token: 0x04002EB3 RID: 11955
		private const string KEY_PREFIX = "PhantomFormationById";

		// Token: 0x04002EB4 RID: 11956
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EB5 RID: 11957
		private static int HandleId;
	}
}
