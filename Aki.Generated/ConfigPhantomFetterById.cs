using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000693 RID: 1683
	public class ConfigPhantomFetterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002782 RID: 10114 RVA: 0x001390DF File Offset: 0x001372DF
		static ConfigPhantomFetterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterById.CreateStaticDefaultValue), new Action(ConfigPhantomFetterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00139100 File Offset: 0x00137300
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetter` where Id=?")
			});
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0013917F File Offset: 0x0013737F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterById.LogPair = null;
			ConfigPhantomFetterById.HandleId = 0;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0013918D File Offset: 0x0013738D
		public static void Init()
		{
			ConfigPhantomFetterById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterById.HandleId, "db_phantom.db", "select BinData from `PhantomFetter` where Id=?");
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x001391A8 File Offset: 0x001373A8
		public static PhantomFetter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomFetter?(PhantomFetter.GetRootAsPhantomFetter(configBuffer));
				}
			}
			ConfigPhantomFetterById.LogPair.Clear();
			ConfigPhantomFetterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomFetterById.HandleId, 1, p0Id, ConfigPhantomFetterById.LogPair) || ConfigCommon.Step(ConfigPhantomFetterById.HandleId, true, ConfigPhantomFetterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterById.HandleId, 0, ConfigPhantomFetterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomFetter rootAsPhantomFetter = PhantomFetter.GetRootAsPhantomFetter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair);
			return new PhantomFetter?(rootAsPhantomFetter);
		}

		// Token: 0x04002DEB RID: 11755
		private const string DB = "db_phantom.db";

		// Token: 0x04002DEC RID: 11756
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DED RID: 11757
		private const string TABLE = "PhantomFetter";

		// Token: 0x04002DEE RID: 11758
		private const string COMMAND = "select BinData from `PhantomFetter` where Id=?";

		// Token: 0x04002DEF RID: 11759
		private const string KEY_PREFIX = "PhantomFetterById";

		// Token: 0x04002DF0 RID: 11760
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DF1 RID: 11761
		private static int HandleId;
	}
}
