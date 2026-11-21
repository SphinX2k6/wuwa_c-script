using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F2 RID: 22002
	public struct IDirectionFill : IFlatbufferObject
	{
		// Token: 0x17009DAB RID: 40363
		// (get) Token: 0x060230D1 RID: 143569 RVA: 0x004D33A4 File Offset: 0x004D15A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230D2 RID: 143570 RVA: 0x004D33B1 File Offset: 0x004D15B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230D3 RID: 143571 RVA: 0x004D33B8 File Offset: 0x004D15B8
		public static IDirectionFill GetRootAsIDirectionFill(ByteBuffer _bb)
		{
			return IDirectionFill.GetRootAsIDirectionFill(_bb, default(IDirectionFill));
		}

		// Token: 0x060230D4 RID: 143572 RVA: 0x004D33D4 File Offset: 0x004D15D4
		public static IDirectionFill GetRootAsIDirectionFill(ByteBuffer _bb, IDirectionFill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230D5 RID: 143573 RVA: 0x004D33F1 File Offset: 0x004D15F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230D6 RID: 143574 RVA: 0x004D3400 File Offset: 0x004D1600
		public IDirectionFill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DAC RID: 40364
		// (get) Token: 0x060230D7 RID: 143575 RVA: 0x004D3410 File Offset: 0x004D1610
		public EFillType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFillType.Fixed;
				}
				return (EFillType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DAD RID: 40365
		// (get) Token: 0x060230D8 RID: 143576 RVA: 0x004D344C File Offset: 0x004D164C
		public bool W
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DAE RID: 40366
		// (get) Token: 0x060230D9 RID: 143577 RVA: 0x004D348C File Offset: 0x004D168C
		public bool S
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DAF RID: 40367
		// (get) Token: 0x060230DA RID: 143578 RVA: 0x004D34CC File Offset: 0x004D16CC
		public bool A
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DB0 RID: 40368
		// (get) Token: 0x060230DB RID: 143579 RVA: 0x004D350C File Offset: 0x004D170C
		public bool D
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060230DC RID: 143580 RVA: 0x004D354C File Offset: 0x004D174C
		public static Offset<IDirectionFill> CreateIDirectionFill(FlatBufferBuilder builder, EFillType Type = EFillType.Fixed, bool W = false, bool S = false, bool A = false, bool D = false)
		{
			builder.StartTable(5);
			IDirectionFill.AddD(builder, D);
			IDirectionFill.AddA(builder, A);
			IDirectionFill.AddS(builder, S);
			IDirectionFill.AddW(builder, W);
			IDirectionFill.AddType(builder, Type);
			return IDirectionFill.EndIDirectionFill(builder);
		}

		// Token: 0x060230DD RID: 143581 RVA: 0x004D3580 File Offset: 0x004D1780
		public static void StartIDirectionFill(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060230DE RID: 143582 RVA: 0x004D3589 File Offset: 0x004D1789
		public static void AddType(FlatBufferBuilder builder, EFillType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230DF RID: 143583 RVA: 0x004D3594 File Offset: 0x004D1794
		public static void AddW(FlatBufferBuilder builder, bool w)
		{
			builder.AddBool(1, w, false);
		}

		// Token: 0x060230E0 RID: 143584 RVA: 0x004D359F File Offset: 0x004D179F
		public static void AddS(FlatBufferBuilder builder, bool s)
		{
			builder.AddBool(2, s, false);
		}

		// Token: 0x060230E1 RID: 143585 RVA: 0x004D35AA File Offset: 0x004D17AA
		public static void AddA(FlatBufferBuilder builder, bool a)
		{
			builder.AddBool(3, a, false);
		}

		// Token: 0x060230E2 RID: 143586 RVA: 0x004D35B5 File Offset: 0x004D17B5
		public static void AddD(FlatBufferBuilder builder, bool d)
		{
			builder.AddBool(4, d, false);
		}

		// Token: 0x060230E3 RID: 143587 RVA: 0x004D35C0 File Offset: 0x004D17C0
		public static Offset<IDirectionFill> EndIDirectionFill(FlatBufferBuilder builder)
		{
			return new Offset<IDirectionFill>(builder.EndTable());
		}

		// Token: 0x060230E4 RID: 143588 RVA: 0x004D35D0 File Offset: 0x004D17D0
		public IDirectionFillT UnPack()
		{
			IDirectionFillT directionFillT = new IDirectionFillT();
			this.UnPackTo(directionFillT);
			return directionFillT;
		}

		// Token: 0x060230E5 RID: 143589 RVA: 0x004D35EB File Offset: 0x004D17EB
		public void UnPackTo(IDirectionFillT _o)
		{
			_o.Type = this.Type;
			_o.W = this.W;
			_o.S = this.S;
			_o.A = this.A;
			_o.D = this.D;
		}

		// Token: 0x060230E6 RID: 143590 RVA: 0x004D362C File Offset: 0x004D182C
		public static Offset<IDirectionFill> Pack(FlatBufferBuilder builder, IDirectionFillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDirectionFill>);
			}
			return IDirectionFill.CreateIDirectionFill(builder, _o.Type, _o.W, _o.S, _o.A, _o.D);
		}

		// Token: 0x0400ECA0 RID: 60576
		private Table __p;
	}
}
