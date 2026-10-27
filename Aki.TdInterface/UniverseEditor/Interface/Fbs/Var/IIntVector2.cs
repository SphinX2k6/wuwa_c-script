using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A9F RID: 15007
	public struct IIntVector2 : IFlatbufferObject
	{
		// Token: 0x170066CF RID: 26319
		// (get) Token: 0x060145E8 RID: 83432 RVA: 0x002F895A File Offset: 0x002F6B5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060145E9 RID: 83433 RVA: 0x002F8967 File Offset: 0x002F6B67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060145EA RID: 83434 RVA: 0x002F8970 File Offset: 0x002F6B70
		public static IIntVector2 GetRootAsIIntVector2(ByteBuffer _bb)
		{
			return IIntVector2.GetRootAsIIntVector2(_bb, default(IIntVector2));
		}

		// Token: 0x060145EB RID: 83435 RVA: 0x002F898C File Offset: 0x002F6B8C
		public static IIntVector2 GetRootAsIIntVector2(ByteBuffer _bb, IIntVector2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060145EC RID: 83436 RVA: 0x002F89A9 File Offset: 0x002F6BA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060145ED RID: 83437 RVA: 0x002F89B8 File Offset: 0x002F6BB8
		public IIntVector2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066D0 RID: 26320
		// (get) Token: 0x060145EE RID: 83438 RVA: 0x002F89C8 File Offset: 0x002F6BC8
		public int X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066D1 RID: 26321
		// (get) Token: 0x060145EF RID: 83439 RVA: 0x002F8A04 File Offset: 0x002F6C04
		public int Y
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

		// Token: 0x170066D2 RID: 26322
		// (get) Token: 0x060145F0 RID: 83440 RVA: 0x002F8A40 File Offset: 0x002F6C40
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

		// Token: 0x060145F1 RID: 83441 RVA: 0x002F8A7C File Offset: 0x002F6C7C
		public static Offset<IIntVector2> CreateIIntVector2(FlatBufferBuilder builder, int X = 0, int Y = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IIntVector2.AddY(builder, Y);
			IIntVector2.AddX(builder, X);
			IIntVector2.AddNullMask(builder, NullMask);
			return IIntVector2.EndIIntVector2(builder);
		}

		// Token: 0x060145F2 RID: 83442 RVA: 0x002F8AA0 File Offset: 0x002F6CA0
		public static void StartIIntVector2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060145F3 RID: 83443 RVA: 0x002F8AA9 File Offset: 0x002F6CA9
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(0, x, 0);
		}

		// Token: 0x060145F4 RID: 83444 RVA: 0x002F8AB4 File Offset: 0x002F6CB4
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(1, y, 0);
		}

		// Token: 0x060145F5 RID: 83445 RVA: 0x002F8ABF File Offset: 0x002F6CBF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060145F6 RID: 83446 RVA: 0x002F8ACA File Offset: 0x002F6CCA
		public static Offset<IIntVector2> EndIIntVector2(FlatBufferBuilder builder)
		{
			return new Offset<IIntVector2>(builder.EndTable());
		}

		// Token: 0x060145F7 RID: 83447 RVA: 0x002F8AD8 File Offset: 0x002F6CD8
		public IIntVector2T UnPack()
		{
			IIntVector2T intVector2T = new IIntVector2T();
			this.UnPackTo(intVector2T);
			return intVector2T;
		}

		// Token: 0x060145F8 RID: 83448 RVA: 0x002F8AF3 File Offset: 0x002F6CF3
		public void UnPackTo(IIntVector2T _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060145F9 RID: 83449 RVA: 0x002F8B1C File Offset: 0x002F6D1C
		public static Offset<IIntVector2> Pack(FlatBufferBuilder builder, IIntVector2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IIntVector2>);
			}
			return IIntVector2.CreateIIntVector2(builder, _o.X, _o.Y, _o.NullMask);
		}

		// Token: 0x0400AF1F RID: 44831
		private Table __p;
	}
}
