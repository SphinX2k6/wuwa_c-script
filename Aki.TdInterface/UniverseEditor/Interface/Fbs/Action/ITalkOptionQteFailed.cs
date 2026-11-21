using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B1B RID: 31515
	public struct ITalkOptionQteFailed : IFlatbufferObject
	{
		// Token: 0x1700EC10 RID: 60432
		// (get) Token: 0x06038BF7 RID: 232439 RVA: 0x007ACE3B File Offset: 0x007AB03B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038BF8 RID: 232440 RVA: 0x007ACE48 File Offset: 0x007AB048
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038BF9 RID: 232441 RVA: 0x007ACE50 File Offset: 0x007AB050
		public static ITalkOptionQteFailed GetRootAsITalkOptionQteFailed(ByteBuffer _bb)
		{
			return ITalkOptionQteFailed.GetRootAsITalkOptionQteFailed(_bb, default(ITalkOptionQteFailed));
		}

		// Token: 0x06038BFA RID: 232442 RVA: 0x007ACE6C File Offset: 0x007AB06C
		public static ITalkOptionQteFailed GetRootAsITalkOptionQteFailed(ByteBuffer _bb, ITalkOptionQteFailed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038BFB RID: 232443 RVA: 0x007ACE89 File Offset: 0x007AB089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038BFC RID: 232444 RVA: 0x007ACE98 File Offset: 0x007AB098
		public ITalkOptionQteFailed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC11 RID: 60433
		// (get) Token: 0x06038BFD RID: 232445 RVA: 0x007ACEA8 File Offset: 0x007AB0A8
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038BFE RID: 232446 RVA: 0x007ACEE4 File Offset: 0x007AB0E4
		public static Offset<ITalkOptionQteFailed> CreateITalkOptionQteFailed(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteFailed.AddType(builder, Type);
			return ITalkOptionQteFailed.EndITalkOptionQteFailed(builder);
		}

		// Token: 0x06038BFF RID: 232447 RVA: 0x007ACEFA File Offset: 0x007AB0FA
		public static void StartITalkOptionQteFailed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038C00 RID: 232448 RVA: 0x007ACF03 File Offset: 0x007AB103
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C01 RID: 232449 RVA: 0x007ACF0E File Offset: 0x007AB10E
		public static Offset<ITalkOptionQteFailed> EndITalkOptionQteFailed(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteFailed>(builder.EndTable());
		}

		// Token: 0x06038C02 RID: 232450 RVA: 0x007ACF1C File Offset: 0x007AB11C
		public ITalkOptionQteFailedT UnPack()
		{
			ITalkOptionQteFailedT talkOptionQteFailedT = new ITalkOptionQteFailedT();
			this.UnPackTo(talkOptionQteFailedT);
			return talkOptionQteFailedT;
		}

		// Token: 0x06038C03 RID: 232451 RVA: 0x007ACF37 File Offset: 0x007AB137
		public void UnPackTo(ITalkOptionQteFailedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038C04 RID: 232452 RVA: 0x007ACF48 File Offset: 0x007AB148
		public static Offset<ITalkOptionQteFailed> Pack(FlatBufferBuilder builder, ITalkOptionQteFailedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteFailed>);
			}
			return ITalkOptionQteFailed.CreateITalkOptionQteFailed(builder, _o.Type);
		}

		// Token: 0x04013144 RID: 78148
		private Table __p;
	}
}
