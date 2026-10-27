using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006531 RID: 25905
	public struct IDangoAbyssReceiveReward : IFlatbufferObject
	{
		// Token: 0x1700C097 RID: 49303
		// (get) Token: 0x0602CF0E RID: 184078 RVA: 0x0062BC82 File Offset: 0x00629E82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF0F RID: 184079 RVA: 0x0062BC8F File Offset: 0x00629E8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF10 RID: 184080 RVA: 0x0062BC98 File Offset: 0x00629E98
		public static IDangoAbyssReceiveReward GetRootAsIDangoAbyssReceiveReward(ByteBuffer _bb)
		{
			return IDangoAbyssReceiveReward.GetRootAsIDangoAbyssReceiveReward(_bb, default(IDangoAbyssReceiveReward));
		}

		// Token: 0x0602CF11 RID: 184081 RVA: 0x0062BCB4 File Offset: 0x00629EB4
		public static IDangoAbyssReceiveReward GetRootAsIDangoAbyssReceiveReward(ByteBuffer _bb, IDangoAbyssReceiveReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF12 RID: 184082 RVA: 0x0062BCD1 File Offset: 0x00629ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF13 RID: 184083 RVA: 0x0062BCE0 File Offset: 0x00629EE0
		public IDangoAbyssReceiveReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CF14 RID: 184084 RVA: 0x0062BCF0 File Offset: 0x00629EF0
		public static void StartIDangoAbyssReceiveReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CF15 RID: 184085 RVA: 0x0062BCF9 File Offset: 0x00629EF9
		public static Offset<IDangoAbyssReceiveReward> EndIDangoAbyssReceiveReward(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssReceiveReward>(builder.EndTable());
		}

		// Token: 0x0602CF16 RID: 184086 RVA: 0x0062BD08 File Offset: 0x00629F08
		public IDangoAbyssReceiveRewardT UnPack()
		{
			IDangoAbyssReceiveRewardT dangoAbyssReceiveRewardT = new IDangoAbyssReceiveRewardT();
			this.UnPackTo(dangoAbyssReceiveRewardT);
			return dangoAbyssReceiveRewardT;
		}

		// Token: 0x0602CF17 RID: 184087 RVA: 0x0062BD23 File Offset: 0x00629F23
		public void UnPackTo(IDangoAbyssReceiveRewardT _o)
		{
		}

		// Token: 0x0602CF18 RID: 184088 RVA: 0x0062BD28 File Offset: 0x00629F28
		public static Offset<IDangoAbyssReceiveReward> Pack(FlatBufferBuilder builder, IDangoAbyssReceiveRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssReceiveReward>);
			}
			IDangoAbyssReceiveReward.StartIDangoAbyssReceiveReward(builder);
			return IDangoAbyssReceiveReward.EndIDangoAbyssReceiveReward(builder);
		}

		// Token: 0x04010B7B RID: 68475
		private Table __p;
	}
}
