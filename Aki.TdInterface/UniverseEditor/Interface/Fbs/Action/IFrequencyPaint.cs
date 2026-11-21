using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F02 RID: 28418
	public struct IFrequencyPaint : IFlatbufferObject
	{
		// Token: 0x1700D069 RID: 53353
		// (get) Token: 0x060312CF RID: 201423 RVA: 0x006AA398 File Offset: 0x006A8598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312D0 RID: 201424 RVA: 0x006AA3A5 File Offset: 0x006A85A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312D1 RID: 201425 RVA: 0x006AA3AC File Offset: 0x006A85AC
		public static IFrequencyPaint GetRootAsIFrequencyPaint(ByteBuffer _bb)
		{
			return IFrequencyPaint.GetRootAsIFrequencyPaint(_bb, default(IFrequencyPaint));
		}

		// Token: 0x060312D2 RID: 201426 RVA: 0x006AA3C8 File Offset: 0x006A85C8
		public static IFrequencyPaint GetRootAsIFrequencyPaint(ByteBuffer _bb, IFrequencyPaint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312D3 RID: 201427 RVA: 0x006AA3E5 File Offset: 0x006A85E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312D4 RID: 201428 RVA: 0x006AA3F4 File Offset: 0x006A85F4
		public IFrequencyPaint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D06A RID: 53354
		// (get) Token: 0x060312D5 RID: 201429 RVA: 0x006AA404 File Offset: 0x006A8604
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060312D6 RID: 201430 RVA: 0x006AA440 File Offset: 0x006A8640
		public static Offset<IFrequencyPaint> CreateIFrequencyPaint(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IFrequencyPaint.AddType(builder, Type);
			return IFrequencyPaint.EndIFrequencyPaint(builder);
		}

		// Token: 0x060312D7 RID: 201431 RVA: 0x006AA456 File Offset: 0x006A8656
		public static void StartIFrequencyPaint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060312D8 RID: 201432 RVA: 0x006AA45F File Offset: 0x006A865F
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312D9 RID: 201433 RVA: 0x006AA46A File Offset: 0x006A866A
		public static Offset<IFrequencyPaint> EndIFrequencyPaint(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaint>(builder.EndTable());
		}

		// Token: 0x060312DA RID: 201434 RVA: 0x006AA478 File Offset: 0x006A8678
		public IFrequencyPaintT UnPack()
		{
			IFrequencyPaintT frequencyPaintT = new IFrequencyPaintT();
			this.UnPackTo(frequencyPaintT);
			return frequencyPaintT;
		}

		// Token: 0x060312DB RID: 201435 RVA: 0x006AA493 File Offset: 0x006A8693
		public void UnPackTo(IFrequencyPaintT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060312DC RID: 201436 RVA: 0x006AA4A4 File Offset: 0x006A86A4
		public static Offset<IFrequencyPaint> Pack(FlatBufferBuilder builder, IFrequencyPaintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaint>);
			}
			return IFrequencyPaint.CreateIFrequencyPaint(builder, _o.Type);
		}

		// Token: 0x04011E09 RID: 73225
		private Table __p;
	}
}
