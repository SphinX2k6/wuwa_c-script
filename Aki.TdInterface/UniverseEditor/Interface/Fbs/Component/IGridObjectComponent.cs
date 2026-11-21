using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B3 RID: 22707
	public struct IGridObjectComponent : IFlatbufferObject
	{
		// Token: 0x1700A4A0 RID: 42144
		// (get) Token: 0x06024DA8 RID: 150952 RVA: 0x0050FB3C File Offset: 0x0050DD3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024DA9 RID: 150953 RVA: 0x0050FB49 File Offset: 0x0050DD49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024DAA RID: 150954 RVA: 0x0050FB50 File Offset: 0x0050DD50
		public static IGridObjectComponent GetRootAsIGridObjectComponent(ByteBuffer _bb)
		{
			return IGridObjectComponent.GetRootAsIGridObjectComponent(_bb, default(IGridObjectComponent));
		}

		// Token: 0x06024DAB RID: 150955 RVA: 0x0050FB6C File Offset: 0x0050DD6C
		public static IGridObjectComponent GetRootAsIGridObjectComponent(ByteBuffer _bb, IGridObjectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024DAC RID: 150956 RVA: 0x0050FB89 File Offset: 0x0050DD89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024DAD RID: 150957 RVA: 0x0050FB98 File Offset: 0x0050DD98
		public IGridObjectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4A1 RID: 42145
		// (get) Token: 0x06024DAE RID: 150958 RVA: 0x0050FBA8 File Offset: 0x0050DDA8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A4A2 RID: 42146
		// (get) Token: 0x06024DAF RID: 150959 RVA: 0x0050FBE8 File Offset: 0x0050DDE8
		public IVector2? CellSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A4A3 RID: 42147
		// (get) Token: 0x06024DB0 RID: 150960 RVA: 0x0050FC48 File Offset: 0x0050DE48
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024DB1 RID: 150961 RVA: 0x0050FC84 File Offset: 0x0050DE84
		public static Offset<IGridObjectComponent> CreateIGridObjectComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IVector2> CellSizeOffset = default(Offset<IVector2>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGridObjectComponent.AddCellSize(builder, CellSizeOffset);
			IGridObjectComponent.AddNullMask(builder, NullMask);
			IGridObjectComponent.AddDisabled(builder, Disabled);
			return IGridObjectComponent.EndIGridObjectComponent(builder);
		}

		// Token: 0x06024DB2 RID: 150962 RVA: 0x0050FCA8 File Offset: 0x0050DEA8
		public static void StartIGridObjectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024DB3 RID: 150963 RVA: 0x0050FCB1 File Offset: 0x0050DEB1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024DB4 RID: 150964 RVA: 0x0050FCBC File Offset: 0x0050DEBC
		public static void AddCellSize(FlatBufferBuilder builder, Offset<IVector2> cellSizeOffset)
		{
			builder.AddOffset(1, cellSizeOffset.Value, 0);
		}

		// Token: 0x06024DB5 RID: 150965 RVA: 0x0050FCCC File Offset: 0x0050DECC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024DB6 RID: 150966 RVA: 0x0050FCD7 File Offset: 0x0050DED7
		public static Offset<IGridObjectComponent> EndIGridObjectComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGridObjectComponent>(builder.EndTable());
		}

		// Token: 0x06024DB7 RID: 150967 RVA: 0x0050FCE4 File Offset: 0x0050DEE4
		public IGridObjectComponentT UnPack()
		{
			IGridObjectComponentT gridObjectComponentT = new IGridObjectComponentT();
			this.UnPackTo(gridObjectComponentT);
			return gridObjectComponentT;
		}

		// Token: 0x06024DB8 RID: 150968 RVA: 0x0050FD00 File Offset: 0x0050DF00
		public void UnPackTo(IGridObjectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CellSize = ((this.CellSize != null) ? this.CellSize.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024DB9 RID: 150969 RVA: 0x0050FD54 File Offset: 0x0050DF54
		public static Offset<IGridObjectComponent> Pack(FlatBufferBuilder builder, IGridObjectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGridObjectComponent>);
			}
			Offset<IVector2> cellSizeOffset = (_o.CellSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.CellSize);
			return IGridObjectComponent.CreateIGridObjectComponent(builder, _o.Disabled, cellSizeOffset, _o.NullMask);
		}

		// Token: 0x0400F120 RID: 61728
		private Table __p;
	}
}
