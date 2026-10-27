using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BF RID: 703
	public class ConfigFightPhotoFrameStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x000B6BFF File Offset: 0x000B4DFF
		static ConfigFightPhotoFrameStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoFrameStyleById.CreateStaticDefaultValue), new Action(ConfigFightPhotoFrameStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000B6C20 File Offset: 0x000B4E20
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

		// Token: 0x06001081 RID: 4225 RVA: 0x000B6C9F File Offset: 0x000B4E9F
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoFrameStyleById.LogPair = null;
			ConfigFightPhotoFrameStyleById.HandleId = 0;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000B6CAD File Offset: 0x000B4EAD
		public static void Init()
		{
			ConfigFightPhotoFrameStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoFrameStyleById.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoFrameStyle` where Id=?");
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000B6CC8 File Offset: 0x000B4EC8
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

		// Token: 0x0400131D RID: 4893
		private const string DB = "db_fightphotooption.db";

		// Token: 0x0400131E RID: 4894
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x0400131F RID: 4895
		private const string TABLE = "FightPhotoFrameStyle";

		// Token: 0x04001320 RID: 4896
		private const string COMMAND = "select BinData from `FightPhotoFrameStyle` where Id=?";

		// Token: 0x04001321 RID: 4897
		private const string KEY_PREFIX = "FightPhotoFrameStyleById";

		// Token: 0x04001322 RID: 4898
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001323 RID: 4899
		private static int HandleId;
	}
}
