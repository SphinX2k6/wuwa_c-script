using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007349 RID: 29513
	public struct ITalkOptionQteSucceed : IFlatbufferObject
	{
		// Token: 0x1700E01A RID: 57370
		// (get) Token: 0x060358E8 RID: 219368 RVA: 0x0074B5A1 File Offset: 0x007497A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358E9 RID: 219369 RVA: 0x0074B5AE File Offset: 0x007497AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358EA RID: 219370 RVA: 0x0074B5B8 File Offset: 0x007497B8
		public static ITalkOptionQteSucceed GetRootAsITalkOptionQteSucceed(ByteBuffer _bb)
		{
			return ITalkOptionQteSucceed.GetRootAsITalkOptionQteSucceed(_bb, default(ITalkOptionQteSucceed));
		}

		// Token: 0x060358EB RID: 219371 RVA: 0x0074B5D4 File Offset: 0x007497D4
		public static ITalkOptionQteSucceed GetRootAsITalkOptionQteSucceed(ByteBuffer _bb, ITalkOptionQteSucceed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358EC RID: 219372 RVA: 0x0074B5F1 File Offset: 0x007497F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358ED RID: 219373 RVA: 0x0074B600 File Offset: 0x00749800
		public ITalkOptionQteSucceed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E01B RID: 57371
		// (get) Token: 0x060358EE RID: 219374 RVA: 0x0074B610 File Offset: 0x00749810
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

		// Token: 0x060358EF RID: 219375 RVA: 0x0074B64C File Offset: 0x0074984C
		public static Offset<ITalkOptionQteSucceed> CreateITalkOptionQteSucceed(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteSucceed.AddType(builder, Type);
			return ITalkOptionQteSucceed.EndITalkOptionQteSucceed(builder);
		}

		// Token: 0x060358F0 RID: 219376 RVA: 0x0074B662 File Offset: 0x00749862
		public static void StartITalkOptionQteSucceed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060358F1 RID: 219377 RVA: 0x0074B66B File Offset: 0x0074986B
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060358F2 RID: 219378 RVA: 0x0074B676 File Offset: 0x00749876
		public static Offset<ITalkOptionQteSucceed> EndITalkOptionQteSucceed(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteSucceed>(builder.EndTable());
		}

		// Token: 0x060358F3 RID: 219379 RVA: 0x0074B684 File Offset: 0x00749884
		public ITalkOptionQteSucceedT UnPack()
		{
			ITalkOptionQteSucceedT talkOptionQteSucceedT = new ITalkOptionQteSucceedT();
			this.UnPackTo(talkOptionQteSucceedT);
			return talkOptionQteSucceedT;
		}

		// Token: 0x060358F4 RID: 219380 RVA: 0x0074B69F File Offset: 0x0074989F
		public void UnPackTo(ITalkOptionQteSucceedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060358F5 RID: 219381 RVA: 0x0074B6B0 File Offset: 0x007498B0
		public static Offset<ITalkOptionQteSucceed> Pack(FlatBufferBuilder builder, ITalkOptionQteSucceedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteSucceed>);
			}
			return ITalkOptionQteSucceed.CreateITalkOptionQteSucceed(builder, _o.Type);
		}

		// Token: 0x04012142 RID: 74050
		private Table __p;
	}
}
