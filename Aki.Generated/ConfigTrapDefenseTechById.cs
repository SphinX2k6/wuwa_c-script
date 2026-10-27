using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A45 RID: 2629
	public class ConfigTrapDefenseTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x001B6AAB File Offset: 0x001B4CAB
		static ConfigTrapDefenseTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseTechById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseTechById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x001B6ACC File Offset: 0x001B4CCC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseTechById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseTechById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseTech"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseTech` where Id=?")
			});
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x001B6B4B File Offset: 0x001B4D4B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseTechById.LogPair = null;
			ConfigTrapDefenseTechById.HandleId = 0;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x001B6B59 File Offset: 0x001B4D59
		public static void Init()
		{
			ConfigTrapDefenseTechById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseTechById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseTech` where Id=?");
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x001B6B74 File Offset: 0x001B4D74
		public static TrapDefenseTech? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseTech?(TrapDefenseTech.GetRootAsTrapDefenseTech(configBuffer));
				}
			}
			ConfigTrapDefenseTechById.LogPair.Clear();
			ConfigTrapDefenseTechById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseTechById.HandleId, 1, p0Id, ConfigTrapDefenseTechById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseTechById.HandleId, true, ConfigTrapDefenseTechById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseTechById.HandleId, 0, ConfigTrapDefenseTechById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseTech rootAsTrapDefenseTech = TrapDefenseTech.GetRootAsTrapDefenseTech(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseTechById.HandleId, ConfigTrapDefenseTechById.LogPair);
			return new TrapDefenseTech?(rootAsTrapDefenseTech);
		}

		// Token: 0x040047C9 RID: 18377
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047CA RID: 18378
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047CB RID: 18379
		private const string TABLE = "TrapDefenseTech";

		// Token: 0x040047CC RID: 18380
		private const string COMMAND = "select BinData from `TrapDefenseTech` where Id=?";

		// Token: 0x040047CD RID: 18381
		private const string KEY_PREFIX = "TrapDefenseTechById";

		// Token: 0x040047CE RID: 18382
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047CF RID: 18383
		private static int HandleId;
	}
}
