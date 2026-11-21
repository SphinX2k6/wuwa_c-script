using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569D RID: 22173
	public struct IElementalRangeTypeBase : IFlatbufferObject
	{
		// Token: 0x17009F79 RID: 40825
		// (get) Token: 0x060237E4 RID: 145380 RVA: 0x004E1EC2 File Offset: 0x004E00C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060237E5 RID: 145381 RVA: 0x004E1ECF File Offset: 0x004E00CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060237E6 RID: 145382 RVA: 0x004E1ED8 File Offset: 0x004E00D8
		public static IElementalRangeTypeBase GetRootAsIElementalRangeTypeBase(ByteBuffer _bb)
		{
			return IElementalRangeTypeBase.GetRootAsIElementalRangeTypeBase(_bb, default(IElementalRangeTypeBase));
		}

		// Token: 0x060237E7 RID: 145383 RVA: 0x004E1EF4 File Offset: 0x004E00F4
		public static IElementalRangeTypeBase GetRootAsIElementalRangeTypeBase(ByteBuffer _bb, IElementalRangeTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237E8 RID: 145384 RVA: 0x004E1F11 File Offset: 0x004E0111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237E9 RID: 145385 RVA: 0x004E1F20 File Offset: 0x004E0120
		public IElementalRangeTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F7A RID: 40826
		// (get) Token: 0x060237EA RID: 145386 RVA: 0x004E1F30 File Offset: 0x004E0130
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

		// Token: 0x060237EB RID: 145387 RVA: 0x004E1F6C File Offset: 0x004E016C
		public static Offset<IElementalRangeTypeBase> CreateIElementalRangeTypeBase(FlatBufferBuilder builder, EElementalRangeType Type = EElementalRangeType.BaseShape)
		{
			builder.StartTable(1);
			IElementalRangeTypeBase.AddType(builder, Type);
			return IElementalRangeTypeBase.EndIElementalRangeTypeBase(builder);
		}

		// Token: 0x060237EC RID: 145388 RVA: 0x004E1F82 File Offset: 0x004E0182
		public static void StartIElementalRangeTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060237ED RID: 145389 RVA: 0x004E1F8B File Offset: 0x004E018B
		public static void AddType(FlatBufferBuilder builder, EElementalRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060237EE RID: 145390 RVA: 0x004E1F96 File Offset: 0x004E0196
		public static Offset<IElementalRangeTypeBase> EndIElementalRangeTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IElementalRangeTypeBase>(builder.EndTable());
		}

		// Token: 0x060237EF RID: 145391 RVA: 0x004E1FA4 File Offset: 0x004E01A4
		public IElementalRangeTypeBaseT UnPack()
		{
			IElementalRangeTypeBaseT elementalRangeTypeBaseT = new IElementalRangeTypeBaseT();
			this.UnPackTo(elementalRangeTypeBaseT);
			return elementalRangeTypeBaseT;
		}

		// Token: 0x060237F0 RID: 145392 RVA: 0x004E1FBF File Offset: 0x004E01BF
		public void UnPackTo(IElementalRangeTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060237F1 RID: 145393 RVA: 0x004E1FD0 File Offset: 0x004E01D0
		public static Offset<IElementalRangeTypeBase> Pack(FlatBufferBuilder builder, IElementalRangeTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalRangeTypeBase>);
			}
			return IElementalRangeTypeBase.CreateIElementalRangeTypeBase(builder, _o.Type);
		}

		// Token: 0x0400EDBD RID: 60861
		private Table __p;
	}
}
