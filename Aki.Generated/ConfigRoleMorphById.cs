using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B9 RID: 2233
	public class ConfigRoleMorphById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003469 RID: 13417 RVA: 0x001816AC File Offset: 0x0017F8AC
		static ConfigRoleMorphById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphById.CreateStaticDefaultValue), new Action(ConfigRoleMorphById.ResetStaticDefaultValue));
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x001816CC File Offset: 0x0017F8CC
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

		// Token: 0x0600346B RID: 13419 RVA: 0x0018174B File Offset: 0x0017F94B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphById.LogPair = null;
			ConfigRoleMorphById.HandleId = 0;
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00181759 File Offset: 0x0017F959
		public static void Init()
		{
			ConfigRoleMorphById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphById.HandleId, "db_role.db", "select BinData from `RoleMorph` where Id =?");
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00181774 File Offset: 0x0017F974
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

		// Token: 0x04003CF5 RID: 15605
		private const string DB = "db_role.db";

		// Token: 0x04003CF6 RID: 15606
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003CF7 RID: 15607
		private const string TABLE = "RoleMorph";

		// Token: 0x04003CF8 RID: 15608
		private const string COMMAND = "select BinData from `RoleMorph` where Id =?";

		// Token: 0x04003CF9 RID: 15609
		private const string KEY_PREFIX = "RoleMorphById";

		// Token: 0x04003CFA RID: 15610
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CFB RID: 15611
		private static int HandleId;
	}
}
