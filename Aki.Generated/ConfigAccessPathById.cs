using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000032 RID: 50
	public class ConfigAccessPathById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00060628 File Offset: 0x0005E828
		static ConfigAccessPathById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAccessPathById.CreateStaticDefaultValue), new Action(ConfigAccessPathById.ResetStaticDefaultValue));
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00060648 File Offset: 0x0005E848
		public static void CreateStaticDefaultValue()
		{
			ConfigAccessPathById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAccessPathById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_accesspath.db"),
				new ValueTuple<string, object>("文件", "t.途径.xlsx"),
				new ValueTuple<string, object>("表名", "AccessPath"),
				new ValueTuple<string, object>("语句", "select BinData from `AccessPath` where Id=?")
			});
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000606C7 File Offset: 0x0005E8C7
		public static void ResetStaticDefaultValue()
		{
			ConfigAccessPathById.LogPair = null;
			ConfigAccessPathById.HandleId = 0;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000606D5 File Offset: 0x0005E8D5
		public static void Init()
		{
			ConfigAccessPathById.HandleId = ConfigCommon.InitDataStatement(ConfigAccessPathById.HandleId, "db_accesspath.db", "select BinData from `AccessPath` where Id=?");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000606F0 File Offset: 0x0005E8F0
		public static AccessPath? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAccessPathById.HandleId, ConfigAccessPathById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AccessPathById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AccessPath?(AccessPath.GetRootAsAccessPath(configBuffer));
				}
			}
			ConfigAccessPathById.LogPair.Clear();
			ConfigAccessPathById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAccessPathById.HandleId, 1, p0Id, ConfigAccessPathById.LogPair) || ConfigCommon.Step(ConfigAccessPathById.HandleId, true, ConfigAccessPathById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAccessPathById.HandleId, ConfigAccessPathById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAccessPathById.HandleId, 0, ConfigAccessPathById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAccessPathById.HandleId, ConfigAccessPathById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AccessPath rootAsAccessPath = AccessPath.GetRootAsAccessPath(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AccessPathById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAccessPathById.HandleId, ConfigAccessPathById.LogPair);
			return new AccessPath?(rootAsAccessPath);
		}

		// Token: 0x04000142 RID: 322
		private const string DB = "db_accesspath.db";

		// Token: 0x04000143 RID: 323
		private const string FILE = "t.途径.xlsx";

		// Token: 0x04000144 RID: 324
		private const string TABLE = "AccessPath";

		// Token: 0x04000145 RID: 325
		private const string COMMAND = "select BinData from `AccessPath` where Id=?";

		// Token: 0x04000146 RID: 326
		private const string KEY_PREFIX = "AccessPathById";

		// Token: 0x04000147 RID: 327
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000148 RID: 328
		private static int HandleId;
	}
}
