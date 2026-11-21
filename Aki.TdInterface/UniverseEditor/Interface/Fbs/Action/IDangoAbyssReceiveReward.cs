using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9F RID: 27551
	public struct IDangoAbyssReceiveReward : IFlatbufferObject
	{
		// Token: 0x1700CA29 RID: 51753
		// (get) Token: 0x0602F6AC RID: 194220 RVA: 0x0067812E File Offset: 0x0067632E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6AD RID: 194221 RVA: 0x0067813B File Offset: 0x0067633B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6AE RID: 194222 RVA: 0x00678144 File Offset: 0x00676344
		public static IDangoAbyssReceiveReward GetRootAsIDangoAbyssReceiveReward(ByteBuffer _bb)
		{
			return IDangoAbyssReceiveReward.GetRootAsIDangoAbyssReceiveReward(_bb, default(IDangoAbyssReceiveReward));
		}

		// Token: 0x0602F6AF RID: 194223 RVA: 0x00678160 File Offset: 0x00676360
		public static IDangoAbyssReceiveReward GetRootAsIDangoAbyssReceiveReward(ByteBuffer _bb, IDangoAbyssReceiveReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6B0 RID: 194224 RVA: 0x0067817D File Offset: 0x0067637D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6B1 RID: 194225 RVA: 0x0067818C File Offset: 0x0067638C
		public IDangoAbyssReceiveReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F6B2 RID: 194226 RVA: 0x0067819C File Offset: 0x0067639C
		public static void StartIDangoAbyssReceiveReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602F6B3 RID: 194227 RVA: 0x006781A5 File Offset: 0x006763A5
		public static Offset<IDangoAbyssReceiveReward> EndIDangoAbyssReceiveReward(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssReceiveReward>(builder.EndTable());
		}

		// Token: 0x0602F6B4 RID: 194228 RVA: 0x006781B4 File Offset: 0x006763B4
		public IDangoAbyssReceiveRewardT UnPack()
		{
			IDangoAbyssReceiveRewardT dangoAbyssReceiveRewardT = new IDangoAbyssReceiveRewardT();
			this.UnPackTo(dangoAbyssReceiveRewardT);
			return dangoAbyssReceiveRewardT;
		}

		// Token: 0x0602F6B5 RID: 194229 RVA: 0x006781CF File Offset: 0x006763CF
		public void UnPackTo(IDangoAbyssReceiveRewardT _o)
		{
		}

		// Token: 0x0602F6B6 RID: 194230 RVA: 0x006781D4 File Offset: 0x006763D4
		public static Offset<IDangoAbyssReceiveReward> Pack(FlatBufferBuilder builder, IDangoAbyssReceiveRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssReceiveReward>);
			}
			IDangoAbyssReceiveReward.StartIDangoAbyssReceiveReward(builder);
			return IDangoAbyssReceiveReward.EndIDangoAbyssReceiveReward(builder);
		}

		// Token: 0x04011994 RID: 72084
		private Table __p;
	}
}
