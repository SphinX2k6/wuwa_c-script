using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0C RID: 27404
	public struct IMotorBounce : IFlatbufferObject
	{
		// Token: 0x1700CB7B RID: 52091
		// (get) Token: 0x06030110 RID: 196880 RVA: 0x00688C65 File Offset: 0x00686E65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030111 RID: 196881 RVA: 0x00688C72 File Offset: 0x00686E72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030112 RID: 196882 RVA: 0x00688C7C File Offset: 0x00686E7C
		public static IMotorBounce GetRootAsIMotorBounce(ByteBuffer _bb)
		{
			return IMotorBounce.GetRootAsIMotorBounce(_bb, default(IMotorBounce));
		}

		// Token: 0x06030113 RID: 196883 RVA: 0x00688C98 File Offset: 0x00686E98
		public static IMotorBounce GetRootAsIMotorBounce(ByteBuffer _bb, IMotorBounce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030114 RID: 196884 RVA: 0x00688CB5 File Offset: 0x00686EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030115 RID: 196885 RVA: 0x00688CC4 File Offset: 0x00686EC4
		public IMotorBounce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB7C RID: 52092
		// (get) Token: 0x06030116 RID: 196886 RVA: 0x00688CD4 File Offset: 0x00686ED4
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

		// Token: 0x1700CB7D RID: 52093
		// (get) Token: 0x06030117 RID: 196887 RVA: 0x00688D10 File Offset: 0x00686F10
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

		// Token: 0x1700CB7E RID: 52094
		// (get) Token: 0x06030118 RID: 196888 RVA: 0x00688D4C File Offset: 0x00686F4C
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

		// Token: 0x1700CB7F RID: 52095
		// (get) Token: 0x06030119 RID: 196889 RVA: 0x00688D8C File Offset: 0x00686F8C
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

		// Token: 0x0603011A RID: 196890 RVA: 0x00688DC4 File Offset: 0x00686FC4
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603011B RID: 196891 RVA: 0x00688DD4 File Offset: 0x00686FD4
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700CB80 RID: 52096
		// (get) Token: 0x0603011C RID: 196892 RVA: 0x00688DE4 File Offset: 0x00686FE4
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

		// Token: 0x1700CB81 RID: 52097
		// (get) Token: 0x0603011D RID: 196893 RVA: 0x00688E24 File Offset: 0x00687024
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

		// Token: 0x0603011E RID: 196894 RVA: 0x00688E61 File Offset: 0x00687061
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

		// Token: 0x0603011F RID: 196895 RVA: 0x00688E9D File Offset: 0x0068709D
		public static void StartIMotorBounce(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06030120 RID: 196896 RVA: 0x00688EA6 File Offset: 0x006870A6
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030121 RID: 196897 RVA: 0x00688EB1 File Offset: 0x006870B1
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(1, height, 0);
		}

		// Token: 0x06030122 RID: 196898 RVA: 0x00688EBC File Offset: 0x006870BC
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x06030123 RID: 196899 RVA: 0x00688ECF File Offset: 0x006870CF
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(3, motionCurveOffset.Value, 0);
		}

		// Token: 0x06030124 RID: 196900 RVA: 0x00688EDF File Offset: 0x006870DF
		public static void AddSkillType(FlatBufferBuilder builder, EMotorBounceSkillType skillType)
		{
			builder.AddInt(4, (int)skillType, 0);
		}

		// Token: 0x06030125 RID: 196901 RVA: 0x00688EEA File Offset: 0x006870EA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06030126 RID: 196902 RVA: 0x00688EF5 File Offset: 0x006870F5
		public static Offset<IMotorBounce> EndIMotorBounce(FlatBufferBuilder builder)
		{
			return new Offset<IMotorBounce>(builder.EndTable());
		}

		// Token: 0x06030127 RID: 196903 RVA: 0x00688F04 File Offset: 0x00687104
		public IMotorBounceT UnPack()
		{
			IMotorBounceT motorBounceT = new IMotorBounceT();
			this.UnPackTo(motorBounceT);
			return motorBounceT;
		}

		// Token: 0x06030128 RID: 196904 RVA: 0x00688F20 File Offset: 0x00687120
		public void UnPackTo(IMotorBounceT _o)
		{
			_o.Type = this.Type;
			_o.Height = this.Height;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.SkillType = this.SkillType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030129 RID: 196905 RVA: 0x00688F78 File Offset: 0x00687178
		public static Offset<IMotorBounce> Pack(FlatBufferBuilder builder, IMotorBounceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorBounce>);
			}
			StringOffset motionCurveOffset = (_o.MotionCurve == null) ? default(StringOffset) : builder.CreateString(_o.MotionCurve);
			return IMotorBounce.CreateIMotorBounce(builder, _o.Type, _o.Height, _o.Time, motionCurveOffset, _o.SkillType, _o.NullMask);
		}

		// Token: 0x04011381 RID: 70529
		private Table __p;
	}
}
