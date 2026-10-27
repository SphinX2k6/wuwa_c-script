using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007343 RID: 29507
	public struct ITalkOptionQteFailed : IFlatbufferObject
	{
		// Token: 0x1700E014 RID: 57364
		// (get) Token: 0x060358C4 RID: 219332 RVA: 0x0074B2B3 File Offset: 0x007494B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358C5 RID: 219333 RVA: 0x0074B2C0 File Offset: 0x007494C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358C6 RID: 219334 RVA: 0x0074B2C8 File Offset: 0x007494C8
		public static ITalkOptionQteFailed GetRootAsITalkOptionQteFailed(ByteBuffer _bb)
		{
			return ITalkOptionQteFailed.GetRootAsITalkOptionQteFailed(_bb, default(ITalkOptionQteFailed));
		}

		// Token: 0x060358C7 RID: 219335 RVA: 0x0074B2E4 File Offset: 0x007494E4
		public static ITalkOptionQteFailed GetRootAsITalkOptionQteFailed(ByteBuffer _bb, ITalkOptionQteFailed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358C8 RID: 219336 RVA: 0x0074B301 File Offset: 0x00749501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358C9 RID: 219337 RVA: 0x0074B310 File Offset: 0x00749510
		public ITalkOptionQteFailed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E015 RID: 57365
		// (get) Token: 0x060358CA RID: 219338 RVA: 0x0074B320 File Offset: 0x00749520
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

		// Token: 0x060358CB RID: 219339 RVA: 0x0074B35C File Offset: 0x0074955C
		public static Offset<ITalkOptionQteFailed> CreateITalkOptionQteFailed(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteFailed.AddType(builder, Type);
			return ITalkOptionQteFailed.EndITalkOptionQteFailed(builder);
		}

		// Token: 0x060358CC RID: 219340 RVA: 0x0074B372 File Offset: 0x00749572
		public static void StartITalkOptionQteFailed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060358CD RID: 219341 RVA: 0x0074B37B File Offset: 0x0074957B
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060358CE RID: 219342 RVA: 0x0074B386 File Offset: 0x00749586
		public static Offset<ITalkOptionQteFailed> EndITalkOptionQteFailed(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteFailed>(builder.EndTable());
		}

		// Token: 0x060358CF RID: 219343 RVA: 0x0074B394 File Offset: 0x00749594
		public ITalkOptionQteFailedT UnPack()
		{
			ITalkOptionQteFailedT talkOptionQteFailedT = new ITalkOptionQteFailedT();
			this.UnPackTo(talkOptionQteFailedT);
			return talkOptionQteFailedT;
		}

		// Token: 0x060358D0 RID: 219344 RVA: 0x0074B3AF File Offset: 0x007495AF
		public void UnPackTo(ITalkOptionQteFailedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060358D1 RID: 219345 RVA: 0x0074B3C0 File Offset: 0x007495C0
		public static Offset<ITalkOptionQteFailed> Pack(FlatBufferBuilder builder, ITalkOptionQteFailedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteFailed>);
			}
			return ITalkOptionQteFailed.CreateITalkOptionQteFailed(builder, _o.Type);
		}

		// Token: 0x0401213E RID: 74046
		private Table __p;
	}
}
