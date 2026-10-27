using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096F RID: 2415
	public class ConfigSpineBackgroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038AE RID: 14510 RVA: 0x0019A0FC File Offset: 0x001982FC
		static ConfigSpineBackgroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpineBackgroundById.CreateStaticDefaultValue), new Action(ConfigSpineBackgroundById.ResetStaticDefaultValue));
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0019A11C File Offset: 0x0019831C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpineBackgroundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpineBackgroundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spinebackground.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/s.Spine动态背景图表/*.csv*"),
				new ValueTuple<string, object>("表名", "SpineBackground"),
				new ValueTuple<string, object>("语句", "select BinData from `SpineBackground` where Id=?")
			});
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0019A19B File Offset: 0x0019839B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpineBackgroundById.LogPair = null;
			ConfigSpineBackgroundById.HandleId = 0;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0019A1A9 File Offset: 0x001983A9
		public static void Init()
		{
			ConfigSpineBackgroundById.HandleId = ConfigCommon.InitDataStatement(ConfigSpineBackgroundById.HandleId, "db_spinebackground.db", "select BinData from `SpineBackground` where Id=?");
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0019A1C4 File Offset: 0x001983C4
		public static SpineBackground? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpineBackgroundById.HandleId, ConfigSpineBackgroundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpineBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpineBackground?(SpineBackground.GetRootAsSpineBackground(configBuffer));
				}
			}
			ConfigSpineBackgroundById.LogPair.Clear();
			ConfigSpineBackgroundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpineBackgroundById.HandleId, 1, p0Id, ConfigSpineBackgroundById.LogPair) || ConfigCommon.Step(ConfigSpineBackgroundById.HandleId, true, ConfigSpineBackgroundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpineBackgroundById.HandleId, ConfigSpineBackgroundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpineBackgroundById.HandleId, 0, ConfigSpineBackgroundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpineBackgroundById.HandleId, ConfigSpineBackgroundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpineBackground rootAsSpineBackground = SpineBackground.GetRootAsSpineBackground(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpineBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpineBackgroundById.HandleId, ConfigSpineBackgroundById.LogPair);
			return new SpineBackground?(rootAsSpineBackground);
		}

		// Token: 0x040041EF RID: 16879
		private const string DB = "db_spinebackground.db";

		// Token: 0x040041F0 RID: 16880
		private const string FILE = "k.可视化编辑/c.Csv/s.Spine动态背景图表/*.csv*";

		// Token: 0x040041F1 RID: 16881
		private const string TABLE = "SpineBackground";

		// Token: 0x040041F2 RID: 16882
		private const string COMMAND = "select BinData from `SpineBackground` where Id=?";

		// Token: 0x040041F3 RID: 16883
		private const string KEY_PREFIX = "SpineBackgroundById";

		// Token: 0x040041F4 RID: 16884
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041F5 RID: 16885
		private static int HandleId;
	}
}
