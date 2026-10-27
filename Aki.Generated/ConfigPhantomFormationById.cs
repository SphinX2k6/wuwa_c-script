using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000697 RID: 1687
	public class ConfigPhantomFormationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x00139897 File Offset: 0x00137A97
		static ConfigPhantomFormationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFormationById.CreateStaticDefaultValue), new Action(ConfigPhantomFormationById.ResetStaticDefaultValue));
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x001398B8 File Offset: 0x00137AB8
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

		// Token: 0x0600279C RID: 10140 RVA: 0x00139937 File Offset: 0x00137B37
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFormationById.LogPair = null;
			ConfigPhantomFormationById.HandleId = 0;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00139945 File Offset: 0x00137B45
		public static void Init()
		{
			ConfigPhantomFormationById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFormationById.HandleId, "db_formation.db", "select BinData from `PhantomFormation` where Id=?");
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00139960 File Offset: 0x00137B60
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

		// Token: 0x04002E07 RID: 11783
		private const string DB = "db_formation.db";

		// Token: 0x04002E08 RID: 11784
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04002E09 RID: 11785
		private const string TABLE = "PhantomFormation";

		// Token: 0x04002E0A RID: 11786
		private const string COMMAND = "select BinData from `PhantomFormation` where Id=?";

		// Token: 0x04002E0B RID: 11787
		private const string KEY_PREFIX = "PhantomFormationById";

		// Token: 0x04002E0C RID: 11788
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E0D RID: 11789
		private static int HandleId;
	}
}
