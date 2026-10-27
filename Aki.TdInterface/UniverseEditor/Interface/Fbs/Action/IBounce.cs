using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200621B RID: 25115
	public struct IBounce : IFlatbufferObject
	{
		// Token: 0x1700BB25 RID: 47909
		// (get) Token: 0x0602B49E RID: 177310 RVA: 0x005F648D File Offset: 0x005F468D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B49F RID: 177311 RVA: 0x005F649A File Offset: 0x005F469A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4A0 RID: 177312 RVA: 0x005F64A4 File Offset: 0x005F46A4
		public static IBounce GetRootAsIBounce(ByteBuffer _bb)
		{
			return IBounce.GetRootAsIBounce(_bb, default(IBounce));
		}

		// Token: 0x0602B4A1 RID: 177313 RVA: 0x005F64C0 File Offset: 0x005F46C0
		public static IBounce GetRootAsIBounce(ByteBuffer _bb, IBounce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4A2 RID: 177314 RVA: 0x005F64DD File Offset: 0x005F46DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4A3 RID: 177315 RVA: 0x005F64EC File Offset: 0x005F46EC
		public IBounce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB26 RID: 47910
		// (get) Token: 0x0602B4A4 RID: 177316 RVA: 0x005F64FC File Offset: 0x005F46FC
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

		// Token: 0x1700BB27 RID: 47911
		// (get) Token: 0x0602B4A5 RID: 177317 RVA: 0x005F6538 File Offset: 0x005F4738
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

		// Token: 0x1700BB28 RID: 47912
		// (get) Token: 0x0602B4A6 RID: 177318 RVA: 0x005F6574 File Offset: 0x005F4774
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

		// Token: 0x1700BB29 RID: 47913
		// (get) Token: 0x0602B4A7 RID: 177319 RVA: 0x005F65B4 File Offset: 0x005F47B4
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

		// Token: 0x0602B4A8 RID: 177320 RVA: 0x005F65EC File Offset: 0x005F47EC
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602B4A9 RID: 177321 RVA: 0x005F65FC File Offset: 0x005F47FC
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BB2A RID: 47914
		// (get) Token: 0x0602B4AA RID: 177322 RVA: 0x005F660C File Offset: 0x005F480C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B4AB RID: 177323 RVA: 0x005F6649 File Offset: 0x005F4849
		public static Offset<IBounce> CreateIBounce(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int Height = 0, float Time = 0f, StringOffset MotionCurveOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IBounce.AddMotionCurve(builder, MotionCurveOffset);
			IBounce.AddTime(builder, Time);
			IBounce.AddHeight(builder, Height);
			IBounce.AddNullMask(builder, NullMask);
			IBounce.AddType(builder, Type);
			return IBounce.EndIBounce(builder);
		}

		// Token: 0x0602B4AC RID: 177324 RVA: 0x005F667D File Offset: 0x005F487D
		public static void StartIBounce(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B4AD RID: 177325 RVA: 0x005F6686 File Offset: 0x005F4886
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4AE RID: 177326 RVA: 0x005F6691 File Offset: 0x005F4891
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(1, height, 0);
		}

		// Token: 0x0602B4AF RID: 177327 RVA: 0x005F669C File Offset: 0x005F489C
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x0602B4B0 RID: 177328 RVA: 0x005F66AF File Offset: 0x005F48AF
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(3, motionCurveOffset.Value, 0);
		}

		// Token: 0x0602B4B1 RID: 177329 RVA: 0x005F66BF File Offset: 0x005F48BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602B4B2 RID: 177330 RVA: 0x005F66CA File Offset: 0x005F48CA
		public static Offset<IBounce> EndIBounce(FlatBufferBuilder builder)
		{
			return new Offset<IBounce>(builder.EndTable());
		}

		// Token: 0x0602B4B3 RID: 177331 RVA: 0x005F66D8 File Offset: 0x005F48D8
		public IBounceT UnPack()
		{
			IBounceT bounceT = new IBounceT();
			this.UnPackTo(bounceT);
			return bounceT;
		}

		// Token: 0x0602B4B4 RID: 177332 RVA: 0x005F66F3 File Offset: 0x005F48F3
		public void UnPackTo(IBounceT _o)
		{
			_o.Type = this.Type;
			_o.Height = this.Height;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B4B5 RID: 177333 RVA: 0x005F6734 File Offset: 0x005F4934
		public static Offset<IBounce> Pack(FlatBufferBuilder builder, IBounceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBounce>);
			}
			StringOffset motionCurveOffset = (_o.MotionCurve == null) ? default(StringOffset) : builder.CreateString(_o.MotionCurve);
			return IBounce.CreateIBounce(builder, _o.Type, _o.Height, _o.Time, motionCurveOffset, _o.NullMask);
		}

		// Token: 0x04010758 RID: 67416
		private Table __p;
	}
}
