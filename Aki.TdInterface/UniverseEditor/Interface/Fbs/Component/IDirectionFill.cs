using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200508D RID: 20621
	public struct IDirectionFill : IFlatbufferObject
	{
		// Token: 0x170095BE RID: 38334
		// (get) Token: 0x0602117D RID: 135549 RVA: 0x00499418 File Offset: 0x00497618
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602117E RID: 135550 RVA: 0x00499425 File Offset: 0x00497625
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602117F RID: 135551 RVA: 0x0049942C File Offset: 0x0049762C
		public static IDirectionFill GetRootAsIDirectionFill(ByteBuffer _bb)
		{
			return IDirectionFill.GetRootAsIDirectionFill(_bb, default(IDirectionFill));
		}

		// Token: 0x06021180 RID: 135552 RVA: 0x00499448 File Offset: 0x00497648
		public static IDirectionFill GetRootAsIDirectionFill(ByteBuffer _bb, IDirectionFill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021181 RID: 135553 RVA: 0x00499465 File Offset: 0x00497665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021182 RID: 135554 RVA: 0x00499474 File Offset: 0x00497674
		public IDirectionFill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095BF RID: 38335
		// (get) Token: 0x06021183 RID: 135555 RVA: 0x00499484 File Offset: 0x00497684
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

		// Token: 0x170095C0 RID: 38336
		// (get) Token: 0x06021184 RID: 135556 RVA: 0x004994C0 File Offset: 0x004976C0
		public bool W
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170095C1 RID: 38337
		// (get) Token: 0x06021185 RID: 135557 RVA: 0x00499500 File Offset: 0x00497700
		public bool S
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170095C2 RID: 38338
		// (get) Token: 0x06021186 RID: 135558 RVA: 0x00499540 File Offset: 0x00497740
		public bool A
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170095C3 RID: 38339
		// (get) Token: 0x06021187 RID: 135559 RVA: 0x00499580 File Offset: 0x00497780
		public bool D
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021188 RID: 135560 RVA: 0x004995C0 File Offset: 0x004977C0
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

		// Token: 0x06021189 RID: 135561 RVA: 0x004995F4 File Offset: 0x004977F4
		public static void StartIDirectionFill(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602118A RID: 135562 RVA: 0x004995FD File Offset: 0x004977FD
		public static void AddType(FlatBufferBuilder builder, EFillType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602118B RID: 135563 RVA: 0x00499608 File Offset: 0x00497808
		public static void AddW(FlatBufferBuilder builder, bool w)
		{
			builder.AddBool(1, w, false);
		}

		// Token: 0x0602118C RID: 135564 RVA: 0x00499613 File Offset: 0x00497813
		public static void AddS(FlatBufferBuilder builder, bool s)
		{
			builder.AddBool(2, s, false);
		}

		// Token: 0x0602118D RID: 135565 RVA: 0x0049961E File Offset: 0x0049781E
		public static void AddA(FlatBufferBuilder builder, bool a)
		{
			builder.AddBool(3, a, false);
		}

		// Token: 0x0602118E RID: 135566 RVA: 0x00499629 File Offset: 0x00497829
		public static void AddD(FlatBufferBuilder builder, bool d)
		{
			builder.AddBool(4, d, false);
		}

		// Token: 0x0602118F RID: 135567 RVA: 0x00499634 File Offset: 0x00497834
		public static Offset<IDirectionFill> EndIDirectionFill(FlatBufferBuilder builder)
		{
			return new Offset<IDirectionFill>(builder.EndTable());
		}

		// Token: 0x06021190 RID: 135568 RVA: 0x00499644 File Offset: 0x00497844
		public IDirectionFillT UnPack()
		{
			IDirectionFillT directionFillT = new IDirectionFillT();
			this.UnPackTo(directionFillT);
			return directionFillT;
		}

		// Token: 0x06021191 RID: 135569 RVA: 0x0049965F File Offset: 0x0049785F
		public void UnPackTo(IDirectionFillT _o)
		{
			_o.Type = this.Type;
			_o.W = this.W;
			_o.S = this.S;
			_o.A = this.A;
			_o.D = this.D;
		}

		// Token: 0x06021192 RID: 135570 RVA: 0x004996A0 File Offset: 0x004978A0
		public static Offset<IDirectionFill> Pack(FlatBufferBuilder builder, IDirectionFillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDirectionFill>);
			}
			return IDirectionFill.CreateIDirectionFill(builder, _o.Type, _o.W, _o.S, _o.A, _o.D);
		}

		// Token: 0x0400E0A3 RID: 57507
		private Table __p;
	}
}
