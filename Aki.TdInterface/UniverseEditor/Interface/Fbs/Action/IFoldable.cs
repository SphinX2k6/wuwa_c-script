using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED5 RID: 28373
	public struct IFoldable : IFlatbufferObject
	{
		// Token: 0x1700D019 RID: 53273
		// (get) Token: 0x0603116F RID: 201071 RVA: 0x006A7FAE File Offset: 0x006A61AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031170 RID: 201072 RVA: 0x006A7FBB File Offset: 0x006A61BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031171 RID: 201073 RVA: 0x006A7FC4 File Offset: 0x006A61C4
		public static IFoldable GetRootAsIFoldable(ByteBuffer _bb)
		{
			return IFoldable.GetRootAsIFoldable(_bb, default(IFoldable));
		}

		// Token: 0x06031172 RID: 201074 RVA: 0x006A7FE0 File Offset: 0x006A61E0
		public static IFoldable GetRootAsIFoldable(ByteBuffer _bb, IFoldable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031173 RID: 201075 RVA: 0x006A7FFD File Offset: 0x006A61FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031174 RID: 201076 RVA: 0x006A800C File Offset: 0x006A620C
		public IFoldable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D01A RID: 53274
		// (get) Token: 0x06031175 RID: 201077 RVA: 0x006A801C File Offset: 0x006A621C
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D01B RID: 53275
		// (get) Token: 0x06031176 RID: 201078 RVA: 0x006A805C File Offset: 0x006A625C
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

		// Token: 0x06031177 RID: 201079 RVA: 0x006A8098 File Offset: 0x006A6298
		public static Offset<IFoldable> CreateIFoldable(FlatBufferBuilder builder, bool _folded = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IFoldable.AddNullMask(builder, NullMask);
			IFoldable.Add_Folded(builder, _folded);
			return IFoldable.EndIFoldable(builder);
		}

		// Token: 0x06031178 RID: 201080 RVA: 0x006A80B5 File Offset: 0x006A62B5
		public static void StartIFoldable(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031179 RID: 201081 RVA: 0x006A80BE File Offset: 0x006A62BE
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(0, _Folded, false);
		}

		// Token: 0x0603117A RID: 201082 RVA: 0x006A80C9 File Offset: 0x006A62C9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0603117B RID: 201083 RVA: 0x006A80D4 File Offset: 0x006A62D4
		public static Offset<IFoldable> EndIFoldable(FlatBufferBuilder builder)
		{
			return new Offset<IFoldable>(builder.EndTable());
		}

		// Token: 0x0603117C RID: 201084 RVA: 0x006A80E4 File Offset: 0x006A62E4
		public IFoldableT UnPack()
		{
			IFoldableT foldableT = new IFoldableT();
			this.UnPackTo(foldableT);
			return foldableT;
		}

		// Token: 0x0603117D RID: 201085 RVA: 0x006A80FF File Offset: 0x006A62FF
		public void UnPackTo(IFoldableT _o)
		{
			_o._Folded = this._Folded;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603117E RID: 201086 RVA: 0x006A811C File Offset: 0x006A631C
		public static Offset<IFoldable> Pack(FlatBufferBuilder builder, IFoldableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoldable>);
			}
			return IFoldable.CreateIFoldable(builder, _o._Folded, _o.NullMask);
		}

		// Token: 0x04011DD4 RID: 73172
		private Table __p;
	}
}
