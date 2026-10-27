using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734C RID: 29516
	public struct ITalkOptionQteSucceedDelayExec : IFlatbufferObject
	{
		// Token: 0x1700E01D RID: 57373
		// (get) Token: 0x060358FA RID: 219386 RVA: 0x0074B719 File Offset: 0x00749919
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358FB RID: 219387 RVA: 0x0074B726 File Offset: 0x00749926
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358FC RID: 219388 RVA: 0x0074B730 File Offset: 0x00749930
		public static ITalkOptionQteSucceedDelayExec GetRootAsITalkOptionQteSucceedDelayExec(ByteBuffer _bb)
		{
			return ITalkOptionQteSucceedDelayExec.GetRootAsITalkOptionQteSucceedDelayExec(_bb, default(ITalkOptionQteSucceedDelayExec));
		}

		// Token: 0x060358FD RID: 219389 RVA: 0x0074B74C File Offset: 0x0074994C
		public static ITalkOptionQteSucceedDelayExec GetRootAsITalkOptionQteSucceedDelayExec(ByteBuffer _bb, ITalkOptionQteSucceedDelayExec obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358FE RID: 219390 RVA: 0x0074B769 File Offset: 0x00749969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358FF RID: 219391 RVA: 0x0074B778 File Offset: 0x00749978
		public ITalkOptionQteSucceedDelayExec __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E01E RID: 57374
		// (get) Token: 0x06035900 RID: 219392 RVA: 0x0074B788 File Offset: 0x00749988
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

		// Token: 0x06035901 RID: 219393 RVA: 0x0074B7C4 File Offset: 0x007499C4
		public static Offset<ITalkOptionQteSucceedDelayExec> CreateITalkOptionQteSucceedDelayExec(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteSucceedDelayExec.AddType(builder, Type);
			return ITalkOptionQteSucceedDelayExec.EndITalkOptionQteSucceedDelayExec(builder);
		}

		// Token: 0x06035902 RID: 219394 RVA: 0x0074B7DA File Offset: 0x007499DA
		public static void StartITalkOptionQteSucceedDelayExec(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035903 RID: 219395 RVA: 0x0074B7E3 File Offset: 0x007499E3
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035904 RID: 219396 RVA: 0x0074B7EE File Offset: 0x007499EE
		public static Offset<ITalkOptionQteSucceedDelayExec> EndITalkOptionQteSucceedDelayExec(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteSucceedDelayExec>(builder.EndTable());
		}

		// Token: 0x06035905 RID: 219397 RVA: 0x0074B7FC File Offset: 0x007499FC
		public ITalkOptionQteSucceedDelayExecT UnPack()
		{
			ITalkOptionQteSucceedDelayExecT talkOptionQteSucceedDelayExecT = new ITalkOptionQteSucceedDelayExecT();
			this.UnPackTo(talkOptionQteSucceedDelayExecT);
			return talkOptionQteSucceedDelayExecT;
		}

		// Token: 0x06035906 RID: 219398 RVA: 0x0074B817 File Offset: 0x00749A17
		public void UnPackTo(ITalkOptionQteSucceedDelayExecT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035907 RID: 219399 RVA: 0x0074B828 File Offset: 0x00749A28
		public static Offset<ITalkOptionQteSucceedDelayExec> Pack(FlatBufferBuilder builder, ITalkOptionQteSucceedDelayExecT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteSucceedDelayExec>);
			}
			return ITalkOptionQteSucceedDelayExec.CreateITalkOptionQteSucceedDelayExec(builder, _o.Type);
		}

		// Token: 0x04012144 RID: 74052
		private Table __p;
	}
}
