using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAD RID: 27309
	public struct ICloseSplineMovePattern : IFlatbufferObject
	{
		// Token: 0x1700C898 RID: 51352
		// (get) Token: 0x0602EE01 RID: 192001 RVA: 0x006631C0 File Offset: 0x006613C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE02 RID: 192002 RVA: 0x006631CD File Offset: 0x006613CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE03 RID: 192003 RVA: 0x006631D4 File Offset: 0x006613D4
		public static ICloseSplineMovePattern GetRootAsICloseSplineMovePattern(ByteBuffer _bb)
		{
			return ICloseSplineMovePattern.GetRootAsICloseSplineMovePattern(_bb, default(ICloseSplineMovePattern));
		}

		// Token: 0x0602EE04 RID: 192004 RVA: 0x006631F0 File Offset: 0x006613F0
		public static ICloseSplineMovePattern GetRootAsICloseSplineMovePattern(ByteBuffer _bb, ICloseSplineMovePattern obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE05 RID: 192005 RVA: 0x0066320D File Offset: 0x0066140D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE06 RID: 192006 RVA: 0x0066321C File Offset: 0x0066141C
		public ICloseSplineMovePattern __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C899 RID: 51353
		// (get) Token: 0x0602EE07 RID: 192007 RVA: 0x0066322C File Offset: 0x0066142C
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C89A RID: 51354
		// (get) Token: 0x0602EE08 RID: 192008 RVA: 0x00663268 File Offset: 0x00661468
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C89B RID: 51355
		// (get) Token: 0x0602EE09 RID: 192009 RVA: 0x006632A8 File Offset: 0x006614A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE0A RID: 192010 RVA: 0x006632E4 File Offset: 0x006614E4
		public static Offset<ICloseSplineMovePattern> CreateICloseSplineMovePattern(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseSplineMovePattern.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseSplineMovePattern.AddNullMask(builder, NullMask);
			ICloseSplineMovePattern.AddType(builder, Type);
			return ICloseSplineMovePattern.EndICloseSplineMovePattern(builder);
		}

		// Token: 0x0602EE0B RID: 192011 RVA: 0x00663308 File Offset: 0x00661508
		public static void StartICloseSplineMovePattern(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EE0C RID: 192012 RVA: 0x00663311 File Offset: 0x00661511
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EE0D RID: 192013 RVA: 0x0066331C File Offset: 0x0066151C
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602EE0E RID: 192014 RVA: 0x0066332F File Offset: 0x0066152F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602EE0F RID: 192015 RVA: 0x0066333A File Offset: 0x0066153A
		public static Offset<ICloseSplineMovePattern> EndICloseSplineMovePattern(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSplineMovePattern>(builder.EndTable());
		}

		// Token: 0x0602EE10 RID: 192016 RVA: 0x00663348 File Offset: 0x00661548
		public ICloseSplineMovePatternT UnPack()
		{
			ICloseSplineMovePatternT closeSplineMovePatternT = new ICloseSplineMovePatternT();
			this.UnPackTo(closeSplineMovePatternT);
			return closeSplineMovePatternT;
		}

		// Token: 0x0602EE11 RID: 192017 RVA: 0x00663363 File Offset: 0x00661563
		public void UnPackTo(ICloseSplineMovePatternT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EE12 RID: 192018 RVA: 0x0066338C File Offset: 0x0066158C
		public static Offset<ICloseSplineMovePattern> Pack(FlatBufferBuilder builder, ICloseSplineMovePatternT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSplineMovePattern>);
			}
			return ICloseSplineMovePattern.CreateICloseSplineMovePattern(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04011849 RID: 71753
		private Table __p;
	}
}
