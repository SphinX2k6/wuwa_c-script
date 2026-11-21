using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007762 RID: 30562
	public struct ISetAnimSequenceBlendAnimType : IFlatbufferObject
	{
		// Token: 0x1700DFFF RID: 57343
		// (get) Token: 0x06035A33 RID: 219699 RVA: 0x00730570 File Offset: 0x0072E770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A34 RID: 219700 RVA: 0x0073057D File Offset: 0x0072E77D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A35 RID: 219701 RVA: 0x00730584 File Offset: 0x0072E784
		public static ISetAnimSequenceBlendAnimType GetRootAsISetAnimSequenceBlendAnimType(ByteBuffer _bb)
		{
			return ISetAnimSequenceBlendAnimType.GetRootAsISetAnimSequenceBlendAnimType(_bb, default(ISetAnimSequenceBlendAnimType));
		}

		// Token: 0x06035A36 RID: 219702 RVA: 0x007305A0 File Offset: 0x0072E7A0
		public static ISetAnimSequenceBlendAnimType GetRootAsISetAnimSequenceBlendAnimType(ByteBuffer _bb, ISetAnimSequenceBlendAnimType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A37 RID: 219703 RVA: 0x007305BD File Offset: 0x0072E7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A38 RID: 219704 RVA: 0x007305CC File Offset: 0x0072E7CC
		public ISetAnimSequenceBlendAnimType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E000 RID: 57344
		// (get) Token: 0x06035A39 RID: 219705 RVA: 0x007305DC File Offset: 0x0072E7DC
		public EBlendAnimType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimType.StateMachine;
				}
				return (EBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E001 RID: 57345
		// (get) Token: 0x06035A3A RID: 219706 RVA: 0x00730618 File Offset: 0x0072E818
		public string AnimSequence
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A3B RID: 219707 RVA: 0x0073064F File Offset: 0x0072E84F
		public Span<byte> GetAnimSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035A3C RID: 219708 RVA: 0x0073065E File Offset: 0x0072E85E
		public byte[] GetAnimSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E002 RID: 57346
		// (get) Token: 0x06035A3D RID: 219709 RVA: 0x0073066C File Offset: 0x0072E86C
		public float ProtectTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E003 RID: 57347
		// (get) Token: 0x06035A3E RID: 219710 RVA: 0x007306AC File Offset: 0x0072E8AC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A3F RID: 219711 RVA: 0x007306E9 File Offset: 0x0072E8E9
		public static Offset<ISetAnimSequenceBlendAnimType> CreateISetAnimSequenceBlendAnimType(FlatBufferBuilder builder, EBlendAnimType Type = EBlendAnimType.StateMachine, StringOffset AnimSequenceOffset = default(StringOffset), float ProtectTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetAnimSequenceBlendAnimType.AddProtectTime(builder, ProtectTime);
			ISetAnimSequenceBlendAnimType.AddAnimSequence(builder, AnimSequenceOffset);
			ISetAnimSequenceBlendAnimType.AddNullMask(builder, NullMask);
			ISetAnimSequenceBlendAnimType.AddType(builder, Type);
			return ISetAnimSequenceBlendAnimType.EndISetAnimSequenceBlendAnimType(builder);
		}

		// Token: 0x06035A40 RID: 219712 RVA: 0x00730715 File Offset: 0x0072E915
		public static void StartISetAnimSequenceBlendAnimType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035A41 RID: 219713 RVA: 0x0073071E File Offset: 0x0072E91E
		public static void AddType(FlatBufferBuilder builder, EBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A42 RID: 219714 RVA: 0x00730729 File Offset: 0x0072E929
		public static void AddAnimSequence(FlatBufferBuilder builder, StringOffset animSequenceOffset)
		{
			builder.AddOffset(1, animSequenceOffset.Value, 0);
		}

		// Token: 0x06035A43 RID: 219715 RVA: 0x00730739 File Offset: 0x0072E939
		public static void AddProtectTime(FlatBufferBuilder builder, float protectTime)
		{
			builder.AddFloat(2, protectTime, 0.0);
		}

		// Token: 0x06035A44 RID: 219716 RVA: 0x0073074C File Offset: 0x0072E94C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035A45 RID: 219717 RVA: 0x00730757 File Offset: 0x0072E957
		public static Offset<ISetAnimSequenceBlendAnimType> EndISetAnimSequenceBlendAnimType(FlatBufferBuilder builder)
		{
			return new Offset<ISetAnimSequenceBlendAnimType>(builder.EndTable());
		}

		// Token: 0x06035A46 RID: 219718 RVA: 0x00730764 File Offset: 0x0072E964
		public ISetAnimSequenceBlendAnimTypeT UnPack()
		{
			ISetAnimSequenceBlendAnimTypeT setAnimSequenceBlendAnimTypeT = new ISetAnimSequenceBlendAnimTypeT();
			this.UnPackTo(setAnimSequenceBlendAnimTypeT);
			return setAnimSequenceBlendAnimTypeT;
		}

		// Token: 0x06035A47 RID: 219719 RVA: 0x0073077F File Offset: 0x0072E97F
		public void UnPackTo(ISetAnimSequenceBlendAnimTypeT _o)
		{
			_o.Type = this.Type;
			_o.AnimSequence = this.AnimSequence;
			_o.ProtectTime = this.ProtectTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035A48 RID: 219720 RVA: 0x007307B4 File Offset: 0x0072E9B4
		public static Offset<ISetAnimSequenceBlendAnimType> Pack(FlatBufferBuilder builder, ISetAnimSequenceBlendAnimTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAnimSequenceBlendAnimType>);
			}
			StringOffset animSequenceOffset = (_o.AnimSequence == null) ? default(StringOffset) : builder.CreateString(_o.AnimSequence);
			return ISetAnimSequenceBlendAnimType.CreateISetAnimSequenceBlendAnimType(builder, _o.Type, animSequenceOffset, _o.ProtectTime, _o.NullMask);
		}

		// Token: 0x04012980 RID: 76160
		private Table __p;
	}
}
