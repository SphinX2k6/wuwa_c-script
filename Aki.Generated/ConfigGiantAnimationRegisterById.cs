using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038F RID: 911
	public class ConfigGiantAnimationRegisterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x000D2748 File Offset: 0x000D0948
		static ConfigGiantAnimationRegisterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantAnimationRegisterById.CreateStaticDefaultValue), new Action(ConfigGiantAnimationRegisterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000D2768 File Offset: 0x000D0968
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantAnimationRegisterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantAnimationRegisterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giantanimationregister.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.巨人动画注册/*.csv*"),
				new ValueTuple<string, object>("表名", "GiantAnimationRegister"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantAnimationRegister` where Id=?")
			});
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000D27E7 File Offset: 0x000D09E7
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantAnimationRegisterById.LogPair = null;
			ConfigGiantAnimationRegisterById.HandleId = 0;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000D27F5 File Offset: 0x000D09F5
		public static void Init()
		{
			ConfigGiantAnimationRegisterById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantAnimationRegisterById.HandleId, "db_giantanimationregister.db", "select BinData from `GiantAnimationRegister` where Id=?");
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000D2810 File Offset: 0x000D0A10
		public static GiantAnimationRegister? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantAnimationRegisterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantAnimationRegister?(GiantAnimationRegister.GetRootAsGiantAnimationRegister(configBuffer));
				}
			}
			ConfigGiantAnimationRegisterById.LogPair.Clear();
			ConfigGiantAnimationRegisterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantAnimationRegisterById.HandleId, 1, p0Id, ConfigGiantAnimationRegisterById.LogPair) || ConfigCommon.Step(ConfigGiantAnimationRegisterById.HandleId, true, ConfigGiantAnimationRegisterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantAnimationRegisterById.HandleId, 0, ConfigGiantAnimationRegisterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantAnimationRegister rootAsGiantAnimationRegister = GiantAnimationRegister.GetRootAsGiantAnimationRegister(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantAnimationRegisterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair);
			return new GiantAnimationRegister?(rootAsGiantAnimationRegister);
		}

		// Token: 0x040018CD RID: 6349
		private const string DB = "db_giantanimationregister.db";

		// Token: 0x040018CE RID: 6350
		private const string FILE = "k.可视化编辑/c.Csv/j.巨人动画注册/*.csv*";

		// Token: 0x040018CF RID: 6351
		private const string TABLE = "GiantAnimationRegister";

		// Token: 0x040018D0 RID: 6352
		private const string COMMAND = "select BinData from `GiantAnimationRegister` where Id=?";

		// Token: 0x040018D1 RID: 6353
		private const string KEY_PREFIX = "GiantAnimationRegisterById";

		// Token: 0x040018D2 RID: 6354
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018D3 RID: 6355
		private static int HandleId;
	}
}
