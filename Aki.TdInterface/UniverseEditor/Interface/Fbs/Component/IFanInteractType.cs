using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005237 RID: 21047
	public struct IFanInteractType : IFlatbufferObject
	{
		// Token: 0x17009A36 RID: 39478
		// (get) Token: 0x060223B7 RID: 140215 RVA: 0x004BFA29 File Offset: 0x004BDC29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223B8 RID: 140216 RVA: 0x004BFA36 File Offset: 0x004BDC36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223B9 RID: 140217 RVA: 0x004BFA40 File Offset: 0x004BDC40
		public static IFanInteractType GetRootAsIFanInteractType(ByteBuffer _bb)
		{
			return IFanInteractType.GetRootAsIFanInteractType(_bb, default(IFanInteractType));
		}

		// Token: 0x060223BA RID: 140218 RVA: 0x004BFA5C File Offset: 0x004BDC5C
		public static IFanInteractType GetRootAsIFanInteractType(ByteBuffer _bb, IFanInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223BB RID: 140219 RVA: 0x004BFA79 File Offset: 0x004BDC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060223BC RID: 140220 RVA: 0x004BFA88 File Offset: 0x004BDC88
		public IFanInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A37 RID: 39479
		// (get) Token: 0x060223BD RID: 140221 RVA: 0x004BFA98 File Offset: 0x004BDC98
		public EFanInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFanInteractType.Hit;
				}
				return (EFanInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060223BE RID: 140222 RVA: 0x004BFAD4 File Offset: 0x004BDCD4
		public static Offset<IFanInteractType> CreateIFanInteractType(FlatBufferBuilder builder, EFanInteractType Type = EFanInteractType.Hit)
		{
			builder.StartTable(1);
			IFanInteractType.AddType(builder, Type);
			return IFanInteractType.EndIFanInteractType(builder);
		}

		// Token: 0x060223BF RID: 140223 RVA: 0x004BFAEA File Offset: 0x004BDCEA
		public static void StartIFanInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060223C0 RID: 140224 RVA: 0x004BFAF3 File Offset: 0x004BDCF3
		public static void AddType(FlatBufferBuilder builder, EFanInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060223C1 RID: 140225 RVA: 0x004BFAFE File Offset: 0x004BDCFE
		public static Offset<IFanInteractType> EndIFanInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IFanInteractType>(builder.EndTable());
		}

		// Token: 0x060223C2 RID: 140226 RVA: 0x004BFB0C File Offset: 0x004BDD0C
		public IFanInteractTypeT UnPack()
		{
			IFanInteractTypeT fanInteractTypeT = new IFanInteractTypeT();
			this.UnPackTo(fanInteractTypeT);
			return fanInteractTypeT;
		}

		// Token: 0x060223C3 RID: 140227 RVA: 0x004BFB27 File Offset: 0x004BDD27
		public void UnPackTo(IFanInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060223C4 RID: 140228 RVA: 0x004BFB38 File Offset: 0x004BDD38
		public static Offset<IFanInteractType> Pack(FlatBufferBuilder builder, IFanInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanInteractType>);
			}
			return IFanInteractType.CreateIFanInteractType(builder, _o.Type);
		}

		// Token: 0x0400E37C RID: 58236
		private Table __p;
	}
}
