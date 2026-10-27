using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000928 RID: 2344
	public class ConfigShortMessageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003703 RID: 14083 RVA: 0x00190643 File Offset: 0x0018E843
		static ConfigShortMessageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShortMessageById.CreateStaticDefaultValue), new Action(ConfigShortMessageById.ResetStaticDefaultValue));
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00190664 File Offset: 0x0018E864
		public static void CreateStaticDefaultValue()
		{
			ConfigShortMessageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShortMessageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ShortMessage"),
				new ValueTuple<string, object>("语句", "select BinData from `ShortMessage` where Id = ?")
			});
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x001906E3 File Offset: 0x0018E8E3
		public static void ResetStaticDefaultValue()
		{
			ConfigShortMessageById.LogPair = null;
			ConfigShortMessageById.HandleId = 0;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x001906F1 File Offset: 0x0018E8F1
		public static void Init()
		{
			ConfigShortMessageById.HandleId = ConfigCommon.InitDataStatement(ConfigShortMessageById.HandleId, "db_phonemsg.db", "select BinData from `ShortMessage` where Id = ?");
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x0019070C File Offset: 0x0018E90C
		public static ShortMessage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShortMessageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ShortMessage?(ShortMessage.GetRootAsShortMessage(configBuffer));
				}
			}
			ConfigShortMessageById.LogPair.Clear();
			ConfigShortMessageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigShortMessageById.HandleId, 1, p0Id, ConfigShortMessageById.LogPair) || ConfigCommon.Step(ConfigShortMessageById.HandleId, true, ConfigShortMessageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShortMessageById.HandleId, 0, ConfigShortMessageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ShortMessage rootAsShortMessage = ShortMessage.GetRootAsShortMessage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShortMessageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair);
			return new ShortMessage?(rootAsShortMessage);
		}

		// Token: 0x04003FFE RID: 16382
		private const string DB = "db_phonemsg.db";

		// Token: 0x04003FFF RID: 16383
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04004000 RID: 16384
		private const string TABLE = "ShortMessage";

		// Token: 0x04004001 RID: 16385
		private const string COMMAND = "select BinData from `ShortMessage` where Id = ?";

		// Token: 0x04004002 RID: 16386
		private const string KEY_PREFIX = "ShortMessageById";

		// Token: 0x04004003 RID: 16387
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004004 RID: 16388
		private static int HandleId;
	}
}
