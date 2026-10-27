using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000723 RID: 1827
	public class ConfigPinballMonsterRiskTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AE2 RID: 10978 RVA: 0x0014BCA0 File Offset: 0x00149EA0
		static ConfigPinballMonsterRiskTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterRiskTypeById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterRiskTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0014BCC0 File Offset: 0x00149EC0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterRiskTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterRiskTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonsterRiskType"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonsterRiskType` where Id=?")
			});
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0014BD3F File Offset: 0x00149F3F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterRiskTypeById.LogPair = null;
			ConfigPinballMonsterRiskTypeById.HandleId = 0;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0014BD4D File Offset: 0x00149F4D
		public static void Init()
		{
			ConfigPinballMonsterRiskTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterRiskTypeById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterRiskType` where Id=?");
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0014BD68 File Offset: 0x00149F68
		public static PinballMonsterRiskType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterRiskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonsterRiskType?(PinballMonsterRiskType.GetRootAsPinballMonsterRiskType(configBuffer));
				}
			}
			ConfigPinballMonsterRiskTypeById.LogPair.Clear();
			ConfigPinballMonsterRiskTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterRiskTypeById.HandleId, 1, p0Id, ConfigPinballMonsterRiskTypeById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterRiskTypeById.HandleId, true, ConfigPinballMonsterRiskTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterRiskTypeById.HandleId, 0, ConfigPinballMonsterRiskTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonsterRiskType rootAsPinballMonsterRiskType = PinballMonsterRiskType.GetRootAsPinballMonsterRiskType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterRiskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair);
			return new PinballMonsterRiskType?(rootAsPinballMonsterRiskType);
		}

		// Token: 0x040031DB RID: 12763
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031DC RID: 12764
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031DD RID: 12765
		private const string TABLE = "PinballMonsterRiskType";

		// Token: 0x040031DE RID: 12766
		private const string COMMAND = "select BinData from `PinballMonsterRiskType` where Id=?";

		// Token: 0x040031DF RID: 12767
		private const string KEY_PREFIX = "PinballMonsterRiskTypeById";

		// Token: 0x040031E0 RID: 12768
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031E1 RID: 12769
		private static int HandleId;
	}
}
