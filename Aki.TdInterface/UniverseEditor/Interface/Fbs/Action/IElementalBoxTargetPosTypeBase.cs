using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA1 RID: 27809
	public struct IElementalBoxTargetPosTypeBase : IFlatbufferObject
	{
		// Token: 0x1700CBFA RID: 52218
		// (get) Token: 0x0602FEB0 RID: 196272 RVA: 0x00685F1B File Offset: 0x0068411B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FEB1 RID: 196273 RVA: 0x00685F28 File Offset: 0x00684128
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FEB2 RID: 196274 RVA: 0x00685F30 File Offset: 0x00684130
		public static IElementalBoxTargetPosTypeBase GetRootAsIElementalBoxTargetPosTypeBase(ByteBuffer _bb)
		{
			return IElementalBoxTargetPosTypeBase.GetRootAsIElementalBoxTargetPosTypeBase(_bb, default(IElementalBoxTargetPosTypeBase));
		}

		// Token: 0x0602FEB3 RID: 196275 RVA: 0x00685F4C File Offset: 0x0068414C
		public static IElementalBoxTargetPosTypeBase GetRootAsIElementalBoxTargetPosTypeBase(ByteBuffer _bb, IElementalBoxTargetPosTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FEB4 RID: 196276 RVA: 0x00685F69 File Offset: 0x00684169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FEB5 RID: 196277 RVA: 0x00685F78 File Offset: 0x00684178
		public IElementalBoxTargetPosTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBFB RID: 52219
		// (get) Token: 0x0602FEB6 RID: 196278 RVA: 0x00685F88 File Offset: 0x00684188
		public EElementalBoxTargetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				}
				return (EElementalBoxTargetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FEB7 RID: 196279 RVA: 0x00685FC4 File Offset: 0x006841C4
		public static Offset<IElementalBoxTargetPosTypeBase> CreateIElementalBoxTargetPosTypeBase(FlatBufferBuilder builder, EElementalBoxTargetPosType Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos)
		{
			builder.StartTable(1);
			IElementalBoxTargetPosTypeBase.AddType(builder, Type);
			return IElementalBoxTargetPosTypeBase.EndIElementalBoxTargetPosTypeBase(builder);
		}

		// Token: 0x0602FEB8 RID: 196280 RVA: 0x00685FDA File Offset: 0x006841DA
		public static void StartIElementalBoxTargetPosTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FEB9 RID: 196281 RVA: 0x00685FE3 File Offset: 0x006841E3
		public static void AddType(FlatBufferBuilder builder, EElementalBoxTargetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FEBA RID: 196282 RVA: 0x00685FEE File Offset: 0x006841EE
		public static Offset<IElementalBoxTargetPosTypeBase> EndIElementalBoxTargetPosTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxTargetPosTypeBase>(builder.EndTable());
		}

		// Token: 0x0602FEBB RID: 196283 RVA: 0x00685FFC File Offset: 0x006841FC
		public IElementalBoxTargetPosTypeBaseT UnPack()
		{
			IElementalBoxTargetPosTypeBaseT elementalBoxTargetPosTypeBaseT = new IElementalBoxTargetPosTypeBaseT();
			this.UnPackTo(elementalBoxTargetPosTypeBaseT);
			return elementalBoxTargetPosTypeBaseT;
		}

		// Token: 0x0602FEBC RID: 196284 RVA: 0x00686017 File Offset: 0x00684217
		public void UnPackTo(IElementalBoxTargetPosTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FEBD RID: 196285 RVA: 0x00686028 File Offset: 0x00684228
		public static Offset<IElementalBoxTargetPosTypeBase> Pack(FlatBufferBuilder builder, IElementalBoxTargetPosTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxTargetPosTypeBase>);
			}
			return IElementalBoxTargetPosTypeBase.CreateIElementalBoxTargetPosTypeBase(builder, _o.Type);
		}

		// Token: 0x04011ADE RID: 72414
		private Table __p;
	}
}
