using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684F RID: 26703
	public struct IFoldable : IFlatbufferObject
	{
		// Token: 0x1700C655 RID: 50773
		// (get) Token: 0x0602E8E7 RID: 190695 RVA: 0x0065A06E File Offset: 0x0065826E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8E8 RID: 190696 RVA: 0x0065A07B File Offset: 0x0065827B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8E9 RID: 190697 RVA: 0x0065A084 File Offset: 0x00658284
		public static IFoldable GetRootAsIFoldable(ByteBuffer _bb)
		{
			return IFoldable.GetRootAsIFoldable(_bb, default(IFoldable));
		}

		// Token: 0x0602E8EA RID: 190698 RVA: 0x0065A0A0 File Offset: 0x006582A0
		public static IFoldable GetRootAsIFoldable(ByteBuffer _bb, IFoldable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E8EB RID: 190699 RVA: 0x0065A0BD File Offset: 0x006582BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8EC RID: 190700 RVA: 0x0065A0CC File Offset: 0x006582CC
		public IFoldable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C656 RID: 50774
		// (get) Token: 0x0602E8ED RID: 190701 RVA: 0x0065A0DC File Offset: 0x006582DC
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C657 RID: 50775
		// (get) Token: 0x0602E8EE RID: 190702 RVA: 0x0065A11C File Offset: 0x0065831C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E8EF RID: 190703 RVA: 0x0065A158 File Offset: 0x00658358
		public static Offset<IFoldable> CreateIFoldable(FlatBufferBuilder builder, bool _folded = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IFoldable.AddNullMask(builder, NullMask);
			IFoldable.Add_Folded(builder, _folded);
			return IFoldable.EndIFoldable(builder);
		}

		// Token: 0x0602E8F0 RID: 190704 RVA: 0x0065A175 File Offset: 0x00658375
		public static void StartIFoldable(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E8F1 RID: 190705 RVA: 0x0065A17E File Offset: 0x0065837E
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(0, _Folded, false);
		}

		// Token: 0x0602E8F2 RID: 190706 RVA: 0x0065A189 File Offset: 0x00658389
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602E8F3 RID: 190707 RVA: 0x0065A194 File Offset: 0x00658394
		public static Offset<IFoldable> EndIFoldable(FlatBufferBuilder builder)
		{
			return new Offset<IFoldable>(builder.EndTable());
		}

		// Token: 0x0602E8F4 RID: 190708 RVA: 0x0065A1A4 File Offset: 0x006583A4
		public IFoldableT UnPack()
		{
			IFoldableT foldableT = new IFoldableT();
			this.UnPackTo(foldableT);
			return foldableT;
		}

		// Token: 0x0602E8F5 RID: 190709 RVA: 0x0065A1BF File Offset: 0x006583BF
		public void UnPackTo(IFoldableT _o)
		{
			_o._Folded = this._Folded;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E8F6 RID: 190710 RVA: 0x0065A1DC File Offset: 0x006583DC
		public static Offset<IFoldable> Pack(FlatBufferBuilder builder, IFoldableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoldable>);
			}
			return IFoldable.CreateIFoldable(builder, _o._Folded, _o.NullMask);
		}

		// Token: 0x04010F9A RID: 69530
		private Table __p;
	}
}
