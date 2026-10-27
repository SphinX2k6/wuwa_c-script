using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200524F RID: 21071
	public struct IFillType : IFlatbufferObject
	{
		// Token: 0x17009A5C RID: 39516
		// (get) Token: 0x06022469 RID: 140393 RVA: 0x004C0D70 File Offset: 0x004BEF70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602246A RID: 140394 RVA: 0x004C0D7D File Offset: 0x004BEF7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602246B RID: 140395 RVA: 0x004C0D84 File Offset: 0x004BEF84
		public static IFillType GetRootAsIFillType(ByteBuffer _bb)
		{
			return IFillType.GetRootAsIFillType(_bb, default(IFillType));
		}

		// Token: 0x0602246C RID: 140396 RVA: 0x004C0DA0 File Offset: 0x004BEFA0
		public static IFillType GetRootAsIFillType(ByteBuffer _bb, IFillType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602246D RID: 140397 RVA: 0x004C0DBD File Offset: 0x004BEFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602246E RID: 140398 RVA: 0x004C0DCC File Offset: 0x004BEFCC
		public IFillType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A5D RID: 39517
		// (get) Token: 0x0602246F RID: 140399 RVA: 0x004C0DDC File Offset: 0x004BEFDC
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

		// Token: 0x06022470 RID: 140400 RVA: 0x004C0E18 File Offset: 0x004BF018
		public static Offset<IFillType> CreateIFillType(FlatBufferBuilder builder, EFillType Type = EFillType.Fixed)
		{
			builder.StartTable(1);
			IFillType.AddType(builder, Type);
			return IFillType.EndIFillType(builder);
		}

		// Token: 0x06022471 RID: 140401 RVA: 0x004C0E2E File Offset: 0x004BF02E
		public static void StartIFillType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022472 RID: 140402 RVA: 0x004C0E37 File Offset: 0x004BF037
		public static void AddType(FlatBufferBuilder builder, EFillType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022473 RID: 140403 RVA: 0x004C0E42 File Offset: 0x004BF042
		public static Offset<IFillType> EndIFillType(FlatBufferBuilder builder)
		{
			return new Offset<IFillType>(builder.EndTable());
		}

		// Token: 0x06022474 RID: 140404 RVA: 0x004C0E50 File Offset: 0x004BF050
		public IFillTypeT UnPack()
		{
			IFillTypeT fillTypeT = new IFillTypeT();
			this.UnPackTo(fillTypeT);
			return fillTypeT;
		}

		// Token: 0x06022475 RID: 140405 RVA: 0x004C0E6B File Offset: 0x004BF06B
		public void UnPackTo(IFillTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022476 RID: 140406 RVA: 0x004C0E7C File Offset: 0x004BF07C
		public static Offset<IFillType> Pack(FlatBufferBuilder builder, IFillTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFillType>);
			}
			return IFillType.CreateIFillType(builder, _o.Type);
		}

		// Token: 0x0400E39D RID: 58269
		private Table __p;
	}
}
