using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D4 RID: 724
	public class ConfigFightPhotoFrameStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x000BD10B File Offset: 0x000BB30B
		static ConfigFightPhotoFrameStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoFrameStyleById.CreateStaticDefaultValue), new Action(ConfigFightPhotoFrameStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000BD12C File Offset: 0x000BB32C
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoFrameStyleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoFrameStyleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoFrameStyle"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoFrameStyle` where Id=?")
			});
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000BD1AB File Offset: 0x000BB3AB
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoFrameStyleById.LogPair = null;
			ConfigFightPhotoFrameStyleById.HandleId = 0;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x000BD1B9 File Offset: 0x000BB3B9
		public static void Init()
		{
			ConfigFightPhotoFrameStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoFrameStyleById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoFrameStyle` where Id=?");
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		public static FightPhotoFrameStyle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoFrameStyleById.HandleId, ConfigFightPhotoFrameStyleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoFrameStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FightPhotoFrameStyle?(FightPhotoFrameStyle.GetRootAsFightPhotoFrameStyle(configBuffer));
				}
			}
			ConfigFightPhotoFrameStyleById.LogPair.Clear();
			ConfigFightPhotoFrameStyleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFightPhotoFrameStyleById.HandleId, 1, p0Id, ConfigFightPhotoFrameStyleById.LogPair) || ConfigCommon.Step(ConfigFightPhotoFrameStyleById.HandleId, true, ConfigFightPhotoFrameStyleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFightPhotoFrameStyleById.HandleId, ConfigFightPhotoFrameStyleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoFrameStyleById.HandleId, 0, ConfigFightPhotoFrameStyleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFightPhotoFrameStyleById.HandleId, ConfigFightPhotoFrameStyleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FightPhotoFrameStyle rootAsFightPhotoFrameStyle = FightPhotoFrameStyle.GetRootAsFightPhotoFrameStyle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FightPhotoFrameStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFightPhotoFrameStyleById.HandleId, ConfigFightPhotoFrameStyleById.LogPair);
			return new FightPhotoFrameStyle?(rootAsFightPhotoFrameStyle);
		}

		// Token: 0x040013B0 RID: 5040
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013B1 RID: 5041
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013B2 RID: 5042
		private const string TABLE = "FightPhotoFrameStyle";

		// Token: 0x040013B3 RID: 5043
		private const string COMMAND = "select BinData from `FightPhotoFrameStyle` where Id=?";

		// Token: 0x040013B4 RID: 5044
		private const string KEY_PREFIX = "FightPhotoFrameStyleById";

		// Token: 0x040013B5 RID: 5045
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013B6 RID: 5046
		private static int HandleId;
	}
}
