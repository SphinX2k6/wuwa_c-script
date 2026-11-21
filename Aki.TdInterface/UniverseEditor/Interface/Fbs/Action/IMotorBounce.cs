using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007243 RID: 29251
	public struct IMotorBounce : IFlatbufferObject
	{
		// Token: 0x1700D64A RID: 54858
		// (get) Token: 0x06032EE4 RID: 208612 RVA: 0x006E031D File Offset: 0x006DE51D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032EE5 RID: 208613 RVA: 0x006E032A File Offset: 0x006DE52A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032EE6 RID: 208614 RVA: 0x006E0334 File Offset: 0x006DE534
		public static IMotorBounce GetRootAsIMotorBounce(ByteBuffer _bb)
		{
			return IMotorBounce.GetRootAsIMotorBounce(_bb, default(IMotorBounce));
		}

		// Token: 0x06032EE7 RID: 208615 RVA: 0x006E0350 File Offset: 0x006DE550
		public static IMotorBounce GetRootAsIMotorBounce(ByteBuffer _bb, IMotorBounce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032EE8 RID: 208616 RVA: 0x006E036D File Offset: 0x006DE56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032EE9 RID: 208617 RVA: 0x006E037C File Offset: 0x006DE57C
		public IMotorBounce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D64B RID: 54859
		// (get) Token: 0x06032EEA RID: 208618 RVA: 0x006E038C File Offset: 0x006DE58C
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D64C RID: 54860
		// (get) Token: 0x06032EEB RID: 208619 RVA: 0x006E03C8 File Offset: 0x006DE5C8
		public int Height
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

		// Token: 0x1700D64D RID: 54861
		// (get) Token: 0x06032EEC RID: 208620 RVA: 0x006E0404 File Offset: 0x006DE604
		public float Time
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

		// Token: 0x1700D64E RID: 54862
		// (get) Token: 0x06032EED RID: 208621 RVA: 0x006E0444 File Offset: 0x006DE644
		public string MotionCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032EEE RID: 208622 RVA: 0x006E047C File Offset: 0x006DE67C
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06032EEF RID: 208623 RVA: 0x006E048C File Offset: 0x006DE68C
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D64F RID: 54863
		// (get) Token: 0x06032EF0 RID: 208624 RVA: 0x006E049C File Offset: 0x006DE69C
		public EMotorBounceSkillType SkillType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EMotorBounceSkillType.None;
				}
				return (EMotorBounceSkillType)this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D650 RID: 54864
		// (get) Token: 0x06032EF1 RID: 208625 RVA: 0x006E04DC File Offset: 0x006DE6DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032EF2 RID: 208626 RVA: 0x006E0519 File Offset: 0x006DE719
		public static Offset<IMotorBounce> CreateIMotorBounce(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int Height = 0, float Time = 0f, StringOffset MotionCurveOffset = default(StringOffset), EMotorBounceSkillType SkillType = EMotorBounceSkillType.None, byte NullMask = 0)
		{
			builder.StartTable(6);
			IMotorBounce.AddSkillType(builder, SkillType);
			IMotorBounce.AddMotionCurve(builder, MotionCurveOffset);
			IMotorBounce.AddTime(builder, Time);
			IMotorBounce.AddHeight(builder, Height);
			IMotorBounce.AddNullMask(builder, NullMask);
			IMotorBounce.AddType(builder, Type);
			return IMotorBounce.EndIMotorBounce(builder);
		}

		// Token: 0x06032EF3 RID: 208627 RVA: 0x006E0555 File Offset: 0x006DE755
		public static void StartIMotorBounce(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032EF4 RID: 208628 RVA: 0x006E055E File Offset: 0x006DE75E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032EF5 RID: 208629 RVA: 0x006E0569 File Offset: 0x006DE769
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(1, height, 0);
		}

		// Token: 0x06032EF6 RID: 208630 RVA: 0x006E0574 File Offset: 0x006DE774
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x06032EF7 RID: 208631 RVA: 0x006E0587 File Offset: 0x006DE787
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(3, motionCurveOffset.Value, 0);
		}

		// Token: 0x06032EF8 RID: 208632 RVA: 0x006E0597 File Offset: 0x006DE797
		public static void AddSkillType(FlatBufferBuilder builder, EMotorBounceSkillType skillType)
		{
			builder.AddInt(4, (int)skillType, 0);
		}

		// Token: 0x06032EF9 RID: 208633 RVA: 0x006E05A2 File Offset: 0x006DE7A2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06032EFA RID: 208634 RVA: 0x006E05AD File Offset: 0x006DE7AD
		public static Offset<IMotorBounce> EndIMotorBounce(FlatBufferBuilder builder)
		{
			return new Offset<IMotorBounce>(builder.EndTable());
		}

		// Token: 0x06032EFB RID: 208635 RVA: 0x006E05BC File Offset: 0x006DE7BC
		public IMotorBounceT UnPack()
		{
			IMotorBounceT motorBounceT = new IMotorBounceT();
			this.UnPackTo(motorBounceT);
			return motorBounceT;
		}

		// Token: 0x06032EFC RID: 208636 RVA: 0x006E05D8 File Offset: 0x006DE7D8
		public void UnPackTo(IMotorBounceT _o)
		{
			_o.Type = this.Type;
			_o.Height = this.Height;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.SkillType = this.SkillType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032EFD RID: 208637 RVA: 0x006E0630 File Offset: 0x006DE830
		public static Offset<IMotorBounce> Pack(FlatBufferBuilder builder, IMotorBounceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorBounce>);
			}
			StringOffset motionCurveOffset = (_o.MotionCurve == null) ? default(StringOffset) : builder.CreateString(_o.MotionCurve);
			return IMotorBounce.CreateIMotorBounce(builder, _o.Type, _o.Height, _o.Time, motionCurveOffset, _o.SkillType, _o.NullMask);
		}

		// Token: 0x04012294 RID: 74388
		private Table __p;
	}
}
