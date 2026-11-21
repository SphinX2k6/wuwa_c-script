using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A4 RID: 676
	public class ConfigExhibitPhantomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FDD RID: 4061 RVA: 0x000B6B77 File Offset: 0x000B4D77
		static ConfigExhibitPhantomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExhibitPhantomById.CreateStaticDefaultValue), new Action(ConfigExhibitPhantomById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000B6B98 File Offset: 0x000B4D98
		public static void CreateStaticDefaultValue()
		{
			ConfigExhibitPhantomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExhibitPhantomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "z.展台.xlsx"),
				new ValueTuple<string, object>("表名", "ExhibitPhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `ExhibitPhantom` where Id=?")
			});
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000B6C17 File Offset: 0x000B4E17
		public static void ResetStaticDefaultValue()
		{
			ConfigExhibitPhantomById.LogPair = null;
			ConfigExhibitPhantomById.HandleId = 0;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000B6C25 File Offset: 0x000B4E25
		public static void Init()
		{
			ConfigExhibitPhantomById.HandleId = ConfigCommon.InitDataStatement(ConfigExhibitPhantomById.HandleId, "db_spring26.db", "select BinData from `ExhibitPhantom` where Id=?");
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000B6C40 File Offset: 0x000B4E40
		public static ExhibitPhantom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitPhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExhibitPhantom?(ExhibitPhantom.GetRootAsExhibitPhantom(configBuffer));
				}
			}
			ConfigExhibitPhantomById.LogPair.Clear();
			ConfigExhibitPhantomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExhibitPhantomById.HandleId, 1, p0Id, ConfigExhibitPhantomById.LogPair) || ConfigCommon.Step(ConfigExhibitPhantomById.HandleId, true, ConfigExhibitPhantomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExhibitPhantomById.HandleId, 0, ConfigExhibitPhantomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExhibitPhantom rootAsExhibitPhantom = ExhibitPhantom.GetRootAsExhibitPhantom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitPhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair);
			return new ExhibitPhantom?(rootAsExhibitPhantom);
		}

		// Token: 0x04001260 RID: 4704
		private const string DB = "db_spring26.db";

		// Token: 0x04001261 RID: 4705
		private const string FILE = "z.展台.xlsx";

		// Token: 0x04001262 RID: 4706
		private const string TABLE = "ExhibitPhantom";

		// Token: 0x04001263 RID: 4707
		private const string COMMAND = "select BinData from `ExhibitPhantom` where Id=?";

		// Token: 0x04001264 RID: 4708
		private const string KEY_PREFIX = "ExhibitPhantomById";

		// Token: 0x04001265 RID: 4709
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001266 RID: 4710
		private static int HandleId;
	}
}
