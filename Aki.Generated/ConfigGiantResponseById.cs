using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000397 RID: 919
	public class ConfigGiantResponseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x000D3820 File Offset: 0x000D1A20
		static ConfigGiantResponseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantResponseById.CreateStaticDefaultValue), new Action(ConfigGiantResponseById.ResetStaticDefaultValue));
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000D3840 File Offset: 0x000D1A40
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantResponseById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantResponseById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giantresponse.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.巨人响应/*.csv*"),
				new ValueTuple<string, object>("表名", "GiantResponse"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantResponse` where Id=?")
			});
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x000D38BF File Offset: 0x000D1ABF
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantResponseById.LogPair = null;
			ConfigGiantResponseById.HandleId = 0;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000D38CD File Offset: 0x000D1ACD
		public static void Init()
		{
			ConfigGiantResponseById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantResponseById.HandleId, "db_giantresponse.db", "select BinData from `GiantResponse` where Id=?");
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000D38E8 File Offset: 0x000D1AE8
		public static GiantResponse? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantResponseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantResponse?(GiantResponse.GetRootAsGiantResponse(configBuffer));
				}
			}
			ConfigGiantResponseById.LogPair.Clear();
			ConfigGiantResponseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantResponseById.HandleId, 1, p0Id, ConfigGiantResponseById.LogPair) || ConfigCommon.Step(ConfigGiantResponseById.HandleId, true, ConfigGiantResponseById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantResponseById.HandleId, 0, ConfigGiantResponseById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantResponse rootAsGiantResponse = GiantResponse.GetRootAsGiantResponse(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantResponseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair);
			return new GiantResponse?(rootAsGiantResponse);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x000D3A60 File Offset: 0x000D1C60
		[NullableContext(2)]
		public static IReadOnlyList<GiantResponse> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantResponseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<GiantResponse> readOnlyList = (IReadOnlyList<GiantResponse>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGiantResponseById.LogPair.Clear();
			ConfigGiantResponseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantResponseById.HandleId, 1, p0Id, ConfigGiantResponseById.LogPair))
			{
				ConfigCommon.Reset(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair);
				return null;
			}
			List<GiantResponse> list = new List<GiantResponse>();
			while (ConfigCommon.Step(ConfigGiantResponseById.HandleId, false, ConfigGiantResponseById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantResponseById.HandleId, 0, ConfigGiantResponseById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair);
					return null;
				}
				GiantResponse rootAsGiantResponse = GiantResponse.GetRootAsGiantResponse(new ByteBuffer(item2));
				list.Add(rootAsGiantResponse);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantResponseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGiantResponseById.HandleId, ConfigGiantResponseById.LogPair);
			return list;
		}

		// Token: 0x04001905 RID: 6405
		private const string DB = "db_giantresponse.db";

		// Token: 0x04001906 RID: 6406
		private const string FILE = "k.可视化编辑/c.Csv/j.巨人响应/*.csv*";

		// Token: 0x04001907 RID: 6407
		private const string TABLE = "GiantResponse";

		// Token: 0x04001908 RID: 6408
		private const string COMMAND = "select BinData from `GiantResponse` where Id=?";

		// Token: 0x04001909 RID: 6409
		private const string KEY_PREFIX = "GiantResponseById";

		// Token: 0x0400190A RID: 6410
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400190B RID: 6411
		private static int HandleId;
	}
}
