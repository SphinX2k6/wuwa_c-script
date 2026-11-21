using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A44 RID: 2628
	public class ConfigSpineBackgroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x001B9490 File Offset: 0x001B7690
		static ConfigSpineBackgroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpineBackgroundById.CreateStaticDefaultValue), new Action(ConfigSpineBackgroundById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x001B94B0 File Offset: 0x001B76B0
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

		// Token: 0x06003DAE RID: 15790 RVA: 0x001B952F File Offset: 0x001B772F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpineBackgroundById.LogPair = null;
			ConfigSpineBackgroundById.HandleId = 0;
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x001B953D File Offset: 0x001B773D
		public static void Init()
		{
			ConfigSpineBackgroundById.HandleId = ConfigCommon.InitDataStatement(ConfigSpineBackgroundById.HandleId, "db_spinebackground.db", "select BinData from `SpineBackground` where Id=?");
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x001B9558 File Offset: 0x001B7758
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

		// Token: 0x040047C2 RID: 18370
		private const string DB = "db_spinebackground.db";

		// Token: 0x040047C3 RID: 18371
		private const string FILE = "k.可视化编辑/c.Csv/s.Spine动态背景图表/*.csv*";

		// Token: 0x040047C4 RID: 18372
		private const string TABLE = "SpineBackground";

		// Token: 0x040047C5 RID: 18373
		private const string COMMAND = "select BinData from `SpineBackground` where Id=?";

		// Token: 0x040047C6 RID: 18374
		private const string KEY_PREFIX = "SpineBackgroundById";

		// Token: 0x040047C7 RID: 18375
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047C8 RID: 18376
		private static int HandleId;
	}
}
