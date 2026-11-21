using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B7 RID: 22455
	public struct IFillType : IFlatbufferObject
	{
		// Token: 0x1700A258 RID: 41560
		// (get) Token: 0x060243FF RID: 148479 RVA: 0x004FB834 File Offset: 0x004F9A34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024400 RID: 148480 RVA: 0x004FB841 File Offset: 0x004F9A41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024401 RID: 148481 RVA: 0x004FB848 File Offset: 0x004F9A48
		public static IFillType GetRootAsIFillType(ByteBuffer _bb)
		{
			return IFillType.GetRootAsIFillType(_bb, default(IFillType));
		}

		// Token: 0x06024402 RID: 148482 RVA: 0x004FB864 File Offset: 0x004F9A64
		public static IFillType GetRootAsIFillType(ByteBuffer _bb, IFillType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024403 RID: 148483 RVA: 0x004FB881 File Offset: 0x004F9A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024404 RID: 148484 RVA: 0x004FB890 File Offset: 0x004F9A90
		public IFillType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A259 RID: 41561
		// (get) Token: 0x06024405 RID: 148485 RVA: 0x004FB8A0 File Offset: 0x004F9AA0
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

		// Token: 0x06024406 RID: 148486 RVA: 0x004FB8DC File Offset: 0x004F9ADC
		public static Offset<IFillType> CreateIFillType(FlatBufferBuilder builder, EFillType Type = EFillType.Fixed)
		{
			builder.StartTable(1);
			IFillType.AddType(builder, Type);
			return IFillType.EndIFillType(builder);
		}

		// Token: 0x06024407 RID: 148487 RVA: 0x004FB8F2 File Offset: 0x004F9AF2
		public static void StartIFillType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024408 RID: 148488 RVA: 0x004FB8FB File Offset: 0x004F9AFB
		public static void AddType(FlatBufferBuilder builder, EFillType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024409 RID: 148489 RVA: 0x004FB906 File Offset: 0x004F9B06
		public static Offset<IFillType> EndIFillType(FlatBufferBuilder builder)
		{
			return new Offset<IFillType>(builder.EndTable());
		}

		// Token: 0x0602440A RID: 148490 RVA: 0x004FB914 File Offset: 0x004F9B14
		public IFillTypeT UnPack()
		{
			IFillTypeT fillTypeT = new IFillTypeT();
			this.UnPackTo(fillTypeT);
			return fillTypeT;
		}

		// Token: 0x0602440B RID: 148491 RVA: 0x004FB92F File Offset: 0x004F9B2F
		public void UnPackTo(IFillTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602440C RID: 148492 RVA: 0x004FB940 File Offset: 0x004F9B40
		public static Offset<IFillType> Pack(FlatBufferBuilder builder, IFillTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFillType>);
			}
			return IFillType.CreateIFillType(builder, _o.Type);
		}

		// Token: 0x0400EFA3 RID: 61347
		private Table __p;
	}
}
