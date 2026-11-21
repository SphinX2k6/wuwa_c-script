using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007319 RID: 29465
	public struct INpcGroupSequenceMontageBlendAnimType : IFlatbufferObject
	{
		// Token: 0x1700D7F7 RID: 55287
		// (get) Token: 0x06033603 RID: 210435 RVA: 0x006ED6B2 File Offset: 0x006EB8B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033604 RID: 210436 RVA: 0x006ED6BF File Offset: 0x006EB8BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033605 RID: 210437 RVA: 0x006ED6C8 File Offset: 0x006EB8C8
		public static INpcGroupSequenceMontageBlendAnimType GetRootAsINpcGroupSequenceMontageBlendAnimType(ByteBuffer _bb)
		{
			return INpcGroupSequenceMontageBlendAnimType.GetRootAsINpcGroupSequenceMontageBlendAnimType(_bb, default(INpcGroupSequenceMontageBlendAnimType));
		}

		// Token: 0x06033606 RID: 210438 RVA: 0x006ED6E4 File Offset: 0x006EB8E4
		public static INpcGroupSequenceMontageBlendAnimType GetRootAsINpcGroupSequenceMontageBlendAnimType(ByteBuffer _bb, INpcGroupSequenceMontageBlendAnimType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033607 RID: 210439 RVA: 0x006ED701 File Offset: 0x006EB901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033608 RID: 210440 RVA: 0x006ED710 File Offset: 0x006EB910
		public INpcGroupSequenceMontageBlendAnimType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7F8 RID: 55288
		// (get) Token: 0x06033609 RID: 210441 RVA: 0x006ED720 File Offset: 0x006EB920
		public ENpcGroupSequenceBlendAnimType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupSequenceBlendAnimType.AnimSequence;
				}
				return (ENpcGroupSequenceBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7F9 RID: 55289
		// (get) Token: 0x0603360A RID: 210442 RVA: 0x006ED75C File Offset: 0x006EB95C
		public int MontageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603360B RID: 210443 RVA: 0x006ED798 File Offset: 0x006EB998
		public static Offset<INpcGroupSequenceMontageBlendAnimType> CreateINpcGroupSequenceMontageBlendAnimType(FlatBufferBuilder builder, ENpcGroupSequenceBlendAnimType Type = ENpcGroupSequenceBlendAnimType.AnimSequence, int MontageId = 0)
		{
			builder.StartTable(2);
			INpcGroupSequenceMontageBlendAnimType.AddMontageId(builder, MontageId);
			INpcGroupSequenceMontageBlendAnimType.AddType(builder, Type);
			return INpcGroupSequenceMontageBlendAnimType.EndINpcGroupSequenceMontageBlendAnimType(builder);
		}

		// Token: 0x0603360C RID: 210444 RVA: 0x006ED7B5 File Offset: 0x006EB9B5
		public static void StartINpcGroupSequenceMontageBlendAnimType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603360D RID: 210445 RVA: 0x006ED7BE File Offset: 0x006EB9BE
		public static void AddType(FlatBufferBuilder builder, ENpcGroupSequenceBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603360E RID: 210446 RVA: 0x006ED7C9 File Offset: 0x006EB9C9
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(1, montageId, 0);
		}

		// Token: 0x0603360F RID: 210447 RVA: 0x006ED7D4 File Offset: 0x006EB9D4
		public static Offset<INpcGroupSequenceMontageBlendAnimType> EndINpcGroupSequenceMontageBlendAnimType(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupSequenceMontageBlendAnimType>(builder.EndTable());
		}

		// Token: 0x06033610 RID: 210448 RVA: 0x006ED7E4 File Offset: 0x006EB9E4
		public INpcGroupSequenceMontageBlendAnimTypeT UnPack()
		{
			INpcGroupSequenceMontageBlendAnimTypeT npcGroupSequenceMontageBlendAnimTypeT = new INpcGroupSequenceMontageBlendAnimTypeT();
			this.UnPackTo(npcGroupSequenceMontageBlendAnimTypeT);
			return npcGroupSequenceMontageBlendAnimTypeT;
		}

		// Token: 0x06033611 RID: 210449 RVA: 0x006ED7FF File Offset: 0x006EB9FF
		public void UnPackTo(INpcGroupSequenceMontageBlendAnimTypeT _o)
		{
			_o.Type = this.Type;
			_o.MontageId = this.MontageId;
		}

		// Token: 0x06033612 RID: 210450 RVA: 0x006ED81C File Offset: 0x006EBA1C
		public static Offset<INpcGroupSequenceMontageBlendAnimType> Pack(FlatBufferBuilder builder, INpcGroupSequenceMontageBlendAnimTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupSequenceMontageBlendAnimType>);
			}
			return INpcGroupSequenceMontageBlendAnimType.CreateINpcGroupSequenceMontageBlendAnimType(builder, _o.Type, _o.MontageId);
		}

		// Token: 0x040123DA RID: 74714
		private Table __p;
	}
}
