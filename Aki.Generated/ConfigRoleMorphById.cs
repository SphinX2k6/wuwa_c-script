using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D5 RID: 2261
	public class ConfigRoleMorphById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003511 RID: 13585 RVA: 0x00188994 File Offset: 0x00186B94
		static ConfigRoleMorphById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphById.CreateStaticDefaultValue), new Action(ConfigRoleMorphById.ResetStaticDefaultValue));
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x001889B4 File Offset: 0x00186BB4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleMorphById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleMorphById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleMorph"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleMorph` where Id =?")
			});
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x00188A33 File Offset: 0x00186C33
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphById.LogPair = null;
			ConfigRoleMorphById.HandleId = 0;
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00188A41 File Offset: 0x00186C41
		public static void Init()
		{
			ConfigRoleMorphById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphById.HandleId, "db_role.db", "select BinData from `RoleMorph` where Id =?");
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x00188A5C File Offset: 0x00186C5C
		public static RoleMorph? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleMorphById.HandleId, ConfigRoleMorphById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleMorph?(RoleMorph.GetRootAsRoleMorph(configBuffer));
				}
			}
			ConfigRoleMorphById.LogPair.Clear();
			ConfigRoleMorphById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleMorphById.HandleId, 1, p0Id, ConfigRoleMorphById.LogPair) || ConfigCommon.Step(ConfigRoleMorphById.HandleId, true, ConfigRoleMorphById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleMorphById.HandleId, ConfigRoleMorphById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleMorphById.HandleId, 0, ConfigRoleMorphById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleMorphById.HandleId, ConfigRoleMorphById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleMorph rootAsRoleMorph = RoleMorph.GetRootAsRoleMorph(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleMorphById.HandleId, ConfigRoleMorphById.LogPair);
			return new RoleMorph?(rootAsRoleMorph);
		}

		// Token: 0x04003DB9 RID: 15801
		private const string DB = "db_role.db";

		// Token: 0x04003DBA RID: 15802
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003DBB RID: 15803
		private const string TABLE = "RoleMorph";

		// Token: 0x04003DBC RID: 15804
		private const string COMMAND = "select BinData from `RoleMorph` where Id =?";

		// Token: 0x04003DBD RID: 15805
		private const string KEY_PREFIX = "RoleMorphById";

		// Token: 0x04003DBE RID: 15806
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DBF RID: 15807
		private static int HandleId;
	}
}
