using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D0 RID: 29648
	public struct IPathLineFacingType : IFlatbufferObject
	{
		// Token: 0x1700D9C8 RID: 55752
		// (get) Token: 0x06033DB8 RID: 212408 RVA: 0x006FE522 File Offset: 0x006FC722
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DB9 RID: 212409 RVA: 0x006FE52F File Offset: 0x006FC72F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DBA RID: 212410 RVA: 0x006FE538 File Offset: 0x006FC738
		public static IPathLineFacingType GetRootAsIPathLineFacingType(ByteBuffer _bb)
		{
			return IPathLineFacingType.GetRootAsIPathLineFacingType(_bb, default(IPathLineFacingType));
		}

		// Token: 0x06033DBB RID: 212411 RVA: 0x006FE554 File Offset: 0x006FC754
		public static IPathLineFacingType GetRootAsIPathLineFacingType(ByteBuffer _bb, IPathLineFacingType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DBC RID: 212412 RVA: 0x006FE571 File Offset: 0x006FC771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DBD RID: 212413 RVA: 0x006FE580 File Offset: 0x006FC780
		public IPathLineFacingType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9C9 RID: 55753
		// (get) Token: 0x06033DBE RID: 212414 RVA: 0x006FE590 File Offset: 0x006FC790
		public EPathLineFacingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathLineFacingType.Current;
				}
				return (EPathLineFacingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033DBF RID: 212415 RVA: 0x006FE5CC File Offset: 0x006FC7CC
		public static Offset<IPathLineFacingType> CreateIPathLineFacingType(FlatBufferBuilder builder, EPathLineFacingType Type = EPathLineFacingType.Current)
		{
			builder.StartTable(1);
			IPathLineFacingType.AddType(builder, Type);
			return IPathLineFacingType.EndIPathLineFacingType(builder);
		}

		// Token: 0x06033DC0 RID: 212416 RVA: 0x006FE5E2 File Offset: 0x006FC7E2
		public static void StartIPathLineFacingType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033DC1 RID: 212417 RVA: 0x006FE5EB File Offset: 0x006FC7EB
		public static void AddType(FlatBufferBuilder builder, EPathLineFacingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DC2 RID: 212418 RVA: 0x006FE5F6 File Offset: 0x006FC7F6
		public static Offset<IPathLineFacingType> EndIPathLineFacingType(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineFacingType>(builder.EndTable());
		}

		// Token: 0x06033DC3 RID: 212419 RVA: 0x006FE604 File Offset: 0x006FC804
		public IPathLineFacingTypeT UnPack()
		{
			IPathLineFacingTypeT pathLineFacingTypeT = new IPathLineFacingTypeT();
			this.UnPackTo(pathLineFacingTypeT);
			return pathLineFacingTypeT;
		}

		// Token: 0x06033DC4 RID: 212420 RVA: 0x006FE61F File Offset: 0x006FC81F
		public void UnPackTo(IPathLineFacingTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033DC5 RID: 212421 RVA: 0x006FE630 File Offset: 0x006FC830
		public static Offset<IPathLineFacingType> Pack(FlatBufferBuilder builder, IPathLineFacingTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineFacingType>);
			}
			return IPathLineFacingType.CreateIPathLineFacingType(builder, _o.Type);
		}

		// Token: 0x04012506 RID: 75014
		private Table __p;
	}
}
