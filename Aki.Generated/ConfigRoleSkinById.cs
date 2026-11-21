using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E3 RID: 2275
	public class ConfigRoleSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003565 RID: 13669 RVA: 0x0018A8E3 File Offset: 0x00188AE3
		static ConfigRoleSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinById.CreateStaticDefaultValue), new Action(ConfigRoleSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0018A904 File Offset: 0x00188B04
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin` where Id =?")
			});
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x0018A983 File Offset: 0x00188B83
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinById.LogPair = null;
			ConfigRoleSkinById.HandleId = 0;
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x0018A991 File Offset: 0x00188B91
		public static void Init()
		{
			ConfigRoleSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinById.HandleId, "db_role.db", "select BinData from `RoleSkin` where Id =?");
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x0018A9AC File Offset: 0x00188BAC
		public static RoleSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkin?(RoleSkin.GetRootAsRoleSkin(configBuffer));
				}
			}
			ConfigRoleSkinById.LogPair.Clear();
			ConfigRoleSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinById.HandleId, 1, p0Id, ConfigRoleSkinById.LogPair) || ConfigCommon.Step(ConfigRoleSkinById.HandleId, true, ConfigRoleSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinById.HandleId, 0, ConfigRoleSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair);
			return new RoleSkin?(rootAsRoleSkin);
		}

		// Token: 0x04003E1B RID: 15899
		private const string DB = "db_role.db";

		// Token: 0x04003E1C RID: 15900
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E1D RID: 15901
		private const string TABLE = "RoleSkin";

		// Token: 0x04003E1E RID: 15902
		private const string COMMAND = "select BinData from `RoleSkin` where Id =?";

		// Token: 0x04003E1F RID: 15903
		private const string KEY_PREFIX = "RoleSkinById";

		// Token: 0x04003E20 RID: 15904
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E21 RID: 15905
		private static int HandleId;
	}
}
