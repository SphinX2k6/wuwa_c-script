using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005138 RID: 20792
	public struct IElementalRangeTypeBase : IFlatbufferObject
	{
		// Token: 0x1700978C RID: 38796
		// (get) Token: 0x06021890 RID: 137360 RVA: 0x004A7F36 File Offset: 0x004A6136
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021891 RID: 137361 RVA: 0x004A7F43 File Offset: 0x004A6143
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021892 RID: 137362 RVA: 0x004A7F4C File Offset: 0x004A614C
		public static IElementalRangeTypeBase GetRootAsIElementalRangeTypeBase(ByteBuffer _bb)
		{
			return IElementalRangeTypeBase.GetRootAsIElementalRangeTypeBase(_bb, default(IElementalRangeTypeBase));
		}

		// Token: 0x06021893 RID: 137363 RVA: 0x004A7F68 File Offset: 0x004A6168
		public static IElementalRangeTypeBase GetRootAsIElementalRangeTypeBase(ByteBuffer _bb, IElementalRangeTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021894 RID: 137364 RVA: 0x004A7F85 File Offset: 0x004A6185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021895 RID: 137365 RVA: 0x004A7F94 File Offset: 0x004A6194
		public IElementalRangeTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700978D RID: 38797
		// (get) Token: 0x06021896 RID: 137366 RVA: 0x004A7FA4 File Offset: 0x004A61A4
		public EElementalRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalRangeType.BaseShape;
				}
				return (EElementalRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021897 RID: 137367 RVA: 0x004A7FE0 File Offset: 0x004A61E0
		public static Offset<IElementalRangeTypeBase> CreateIElementalRangeTypeBase(FlatBufferBuilder builder, EElementalRangeType Type = EElementalRangeType.BaseShape)
		{
			builder.StartTable(1);
			IElementalRangeTypeBase.AddType(builder, Type);
			return IElementalRangeTypeBase.EndIElementalRangeTypeBase(builder);
		}

		// Token: 0x06021898 RID: 137368 RVA: 0x004A7FF6 File Offset: 0x004A61F6
		public static void StartIElementalRangeTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021899 RID: 137369 RVA: 0x004A7FFF File Offset: 0x004A61FF
		public static void AddType(FlatBufferBuilder builder, EElementalRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602189A RID: 137370 RVA: 0x004A800A File Offset: 0x004A620A
		public static Offset<IElementalRangeTypeBase> EndIElementalRangeTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IElementalRangeTypeBase>(builder.EndTable());
		}

		// Token: 0x0602189B RID: 137371 RVA: 0x004A8018 File Offset: 0x004A6218
		public IElementalRangeTypeBaseT UnPack()
		{
			IElementalRangeTypeBaseT elementalRangeTypeBaseT = new IElementalRangeTypeBaseT();
			this.UnPackTo(elementalRangeTypeBaseT);
			return elementalRangeTypeBaseT;
		}

		// Token: 0x0602189C RID: 137372 RVA: 0x004A8033 File Offset: 0x004A6233
		public void UnPackTo(IElementalRangeTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602189D RID: 137373 RVA: 0x004A8044 File Offset: 0x004A6244
		public static Offset<IElementalRangeTypeBase> Pack(FlatBufferBuilder builder, IElementalRangeTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalRangeTypeBase>);
			}
			return IElementalRangeTypeBase.CreateIElementalRangeTypeBase(builder, _o.Type);
		}

		// Token: 0x0400E1C0 RID: 57792
		private Table __p;
	}
}
