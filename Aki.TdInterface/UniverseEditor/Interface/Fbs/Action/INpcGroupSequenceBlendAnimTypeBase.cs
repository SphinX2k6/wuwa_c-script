using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007313 RID: 29459
	public struct INpcGroupSequenceBlendAnimTypeBase : IFlatbufferObject
	{
		// Token: 0x1700D7F2 RID: 55282
		// (get) Token: 0x060335E5 RID: 210405 RVA: 0x006ED440 File Offset: 0x006EB640
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060335E6 RID: 210406 RVA: 0x006ED44D File Offset: 0x006EB64D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060335E7 RID: 210407 RVA: 0x006ED454 File Offset: 0x006EB654
		public static INpcGroupSequenceBlendAnimTypeBase GetRootAsINpcGroupSequenceBlendAnimTypeBase(ByteBuffer _bb)
		{
			return INpcGroupSequenceBlendAnimTypeBase.GetRootAsINpcGroupSequenceBlendAnimTypeBase(_bb, default(INpcGroupSequenceBlendAnimTypeBase));
		}

		// Token: 0x060335E8 RID: 210408 RVA: 0x006ED470 File Offset: 0x006EB670
		public static INpcGroupSequenceBlendAnimTypeBase GetRootAsINpcGroupSequenceBlendAnimTypeBase(ByteBuffer _bb, INpcGroupSequenceBlendAnimTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060335E9 RID: 210409 RVA: 0x006ED48D File Offset: 0x006EB68D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060335EA RID: 210410 RVA: 0x006ED49C File Offset: 0x006EB69C
		public INpcGroupSequenceBlendAnimTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7F3 RID: 55283
		// (get) Token: 0x060335EB RID: 210411 RVA: 0x006ED4AC File Offset: 0x006EB6AC
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

		// Token: 0x060335EC RID: 210412 RVA: 0x006ED4E8 File Offset: 0x006EB6E8
		public static Offset<INpcGroupSequenceBlendAnimTypeBase> CreateINpcGroupSequenceBlendAnimTypeBase(FlatBufferBuilder builder, ENpcGroupSequenceBlendAnimType Type = ENpcGroupSequenceBlendAnimType.AnimSequence)
		{
			builder.StartTable(1);
			INpcGroupSequenceBlendAnimTypeBase.AddType(builder, Type);
			return INpcGroupSequenceBlendAnimTypeBase.EndINpcGroupSequenceBlendAnimTypeBase(builder);
		}

		// Token: 0x060335ED RID: 210413 RVA: 0x006ED4FE File Offset: 0x006EB6FE
		public static void StartINpcGroupSequenceBlendAnimTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060335EE RID: 210414 RVA: 0x006ED507 File Offset: 0x006EB707
		public static void AddType(FlatBufferBuilder builder, ENpcGroupSequenceBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060335EF RID: 210415 RVA: 0x006ED512 File Offset: 0x006EB712
		public static Offset<INpcGroupSequenceBlendAnimTypeBase> EndINpcGroupSequenceBlendAnimTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupSequenceBlendAnimTypeBase>(builder.EndTable());
		}

		// Token: 0x060335F0 RID: 210416 RVA: 0x006ED520 File Offset: 0x006EB720
		public INpcGroupSequenceBlendAnimTypeBaseT UnPack()
		{
			INpcGroupSequenceBlendAnimTypeBaseT npcGroupSequenceBlendAnimTypeBaseT = new INpcGroupSequenceBlendAnimTypeBaseT();
			this.UnPackTo(npcGroupSequenceBlendAnimTypeBaseT);
			return npcGroupSequenceBlendAnimTypeBaseT;
		}

		// Token: 0x060335F1 RID: 210417 RVA: 0x006ED53B File Offset: 0x006EB73B
		public void UnPackTo(INpcGroupSequenceBlendAnimTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060335F2 RID: 210418 RVA: 0x006ED54C File Offset: 0x006EB74C
		public static Offset<INpcGroupSequenceBlendAnimTypeBase> Pack(FlatBufferBuilder builder, INpcGroupSequenceBlendAnimTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupSequenceBlendAnimTypeBase>);
			}
			return INpcGroupSequenceBlendAnimTypeBase.CreateINpcGroupSequenceBlendAnimTypeBase(builder, _o.Type);
		}

		// Token: 0x040123D2 RID: 74706
		private Table __p;
	}
}
