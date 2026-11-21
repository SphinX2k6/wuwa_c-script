using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000926 RID: 2342
	public class ConfigRougeResMiraclecreationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036F7 RID: 14071 RVA: 0x001933E4 File Offset: 0x001915E4
		static ConfigRougeResMiraclecreationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougeResMiraclecreationById.CreateStaticDefaultValue), new Action(ConfigRougeResMiraclecreationById.ResetStaticDefaultValue));
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00193404 File Offset: 0x00191604
		public static void CreateStaticDefaultValue()
		{
			ConfigRougeResMiraclecreationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougeResMiraclecreationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougeResMiraclecreation"),
				new ValueTuple<string, object>("语句", "select BinData from `RougeResMiraclecreation` where Id=?")
			});
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00193483 File Offset: 0x00191683
		public static void ResetStaticDefaultValue()
		{
			ConfigRougeResMiraclecreationById.LogPair = null;
			ConfigRougeResMiraclecreationById.HandleId = 0;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00193491 File Offset: 0x00191691
		public static void Init()
		{
			ConfigRougeResMiraclecreationById.HandleId = ConfigCommon.InitDataStatement(ConfigRougeResMiraclecreationById.HandleId, "db_permanentrogue.db", "select BinData from `RougeResMiraclecreation` where Id=?");
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x001934AC File Offset: 0x001916AC
		public static RougeResMiraclecreation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeResMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RougeResMiraclecreation?(RougeResMiraclecreation.GetRootAsRougeResMiraclecreation(configBuffer));
				}
			}
			ConfigRougeResMiraclecreationById.LogPair.Clear();
			ConfigRougeResMiraclecreationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRougeResMiraclecreationById.HandleId, 1, p0Id, ConfigRougeResMiraclecreationById.LogPair) || ConfigCommon.Step(ConfigRougeResMiraclecreationById.HandleId, true, ConfigRougeResMiraclecreationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougeResMiraclecreationById.HandleId, 0, ConfigRougeResMiraclecreationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RougeResMiraclecreation rootAsRougeResMiraclecreation = RougeResMiraclecreation.GetRootAsRougeResMiraclecreation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeResMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair);
			return new RougeResMiraclecreation?(rootAsRougeResMiraclecreation);
		}

		// Token: 0x04003FF0 RID: 16368
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003FF1 RID: 16369
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003FF2 RID: 16370
		private const string TABLE = "RougeResMiraclecreation";

		// Token: 0x04003FF3 RID: 16371
		private const string COMMAND = "select BinData from `RougeResMiraclecreation` where Id=?";

		// Token: 0x04003FF4 RID: 16372
		private const string KEY_PREFIX = "RougeResMiraclecreationById";

		// Token: 0x04003FF5 RID: 16373
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FF6 RID: 16374
		private static int HandleId;
	}
}
