using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007346 RID: 29510
	public struct ITalkOptionQteFailedDelayExec : IFlatbufferObject
	{
		// Token: 0x1700E017 RID: 57367
		// (get) Token: 0x060358D6 RID: 219350 RVA: 0x0074B429 File Offset: 0x00749629
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358D7 RID: 219351 RVA: 0x0074B436 File Offset: 0x00749636
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358D8 RID: 219352 RVA: 0x0074B440 File Offset: 0x00749640
		public static ITalkOptionQteFailedDelayExec GetRootAsITalkOptionQteFailedDelayExec(ByteBuffer _bb)
		{
			return ITalkOptionQteFailedDelayExec.GetRootAsITalkOptionQteFailedDelayExec(_bb, default(ITalkOptionQteFailedDelayExec));
		}

		// Token: 0x060358D9 RID: 219353 RVA: 0x0074B45C File Offset: 0x0074965C
		public static ITalkOptionQteFailedDelayExec GetRootAsITalkOptionQteFailedDelayExec(ByteBuffer _bb, ITalkOptionQteFailedDelayExec obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358DA RID: 219354 RVA: 0x0074B479 File Offset: 0x00749679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358DB RID: 219355 RVA: 0x0074B488 File Offset: 0x00749688
		public ITalkOptionQteFailedDelayExec __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E018 RID: 57368
		// (get) Token: 0x060358DC RID: 219356 RVA: 0x0074B498 File Offset: 0x00749698
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

		// Token: 0x060358DD RID: 219357 RVA: 0x0074B4D4 File Offset: 0x007496D4
		public static Offset<ITalkOptionQteFailedDelayExec> CreateITalkOptionQteFailedDelayExec(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteFailedDelayExec.AddType(builder, Type);
			return ITalkOptionQteFailedDelayExec.EndITalkOptionQteFailedDelayExec(builder);
		}

		// Token: 0x060358DE RID: 219358 RVA: 0x0074B4EA File Offset: 0x007496EA
		public static void StartITalkOptionQteFailedDelayExec(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060358DF RID: 219359 RVA: 0x0074B4F3 File Offset: 0x007496F3
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060358E0 RID: 219360 RVA: 0x0074B4FE File Offset: 0x007496FE
		public static Offset<ITalkOptionQteFailedDelayExec> EndITalkOptionQteFailedDelayExec(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteFailedDelayExec>(builder.EndTable());
		}

		// Token: 0x060358E1 RID: 219361 RVA: 0x0074B50C File Offset: 0x0074970C
		public ITalkOptionQteFailedDelayExecT UnPack()
		{
			ITalkOptionQteFailedDelayExecT talkOptionQteFailedDelayExecT = new ITalkOptionQteFailedDelayExecT();
			this.UnPackTo(talkOptionQteFailedDelayExecT);
			return talkOptionQteFailedDelayExecT;
		}

		// Token: 0x060358E2 RID: 219362 RVA: 0x0074B527 File Offset: 0x00749727
		public void UnPackTo(ITalkOptionQteFailedDelayExecT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060358E3 RID: 219363 RVA: 0x0074B538 File Offset: 0x00749738
		public static Offset<ITalkOptionQteFailedDelayExec> Pack(FlatBufferBuilder builder, ITalkOptionQteFailedDelayExecT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteFailedDelayExec>);
			}
			return ITalkOptionQteFailedDelayExec.CreateITalkOptionQteFailedDelayExec(builder, _o.Type);
		}

		// Token: 0x04012140 RID: 74048
		private Table __p;
	}
}
