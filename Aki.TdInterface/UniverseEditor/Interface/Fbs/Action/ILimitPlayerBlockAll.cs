using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A14 RID: 27156
	public struct ILimitPlayerBlockAll : IFlatbufferObject
	{
		// Token: 0x1700C977 RID: 51575
		// (get) Token: 0x0602F84F RID: 194639 RVA: 0x006785AD File Offset: 0x006767AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F850 RID: 194640 RVA: 0x006785BA File Offset: 0x006767BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F851 RID: 194641 RVA: 0x006785C4 File Offset: 0x006767C4
		public static ILimitPlayerBlockAll GetRootAsILimitPlayerBlockAll(ByteBuffer _bb)
		{
			return ILimitPlayerBlockAll.GetRootAsILimitPlayerBlockAll(_bb, default(ILimitPlayerBlockAll));
		}

		// Token: 0x0602F852 RID: 194642 RVA: 0x006785E0 File Offset: 0x006767E0
		public static ILimitPlayerBlockAll GetRootAsILimitPlayerBlockAll(ByteBuffer _bb, ILimitPlayerBlockAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F853 RID: 194643 RVA: 0x006785FD File Offset: 0x006767FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F854 RID: 194644 RVA: 0x0067860C File Offset: 0x0067680C
		public ILimitPlayerBlockAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C978 RID: 51576
		// (get) Token: 0x0602F855 RID: 194645 RVA: 0x0067861C File Offset: 0x0067681C
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F856 RID: 194646 RVA: 0x00678658 File Offset: 0x00676858
		public static Offset<ILimitPlayerBlockAll> CreateILimitPlayerBlockAll(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerBlockAll.AddType(builder, Type);
			return ILimitPlayerBlockAll.EndILimitPlayerBlockAll(builder);
		}

		// Token: 0x0602F857 RID: 194647 RVA: 0x0067866E File Offset: 0x0067686E
		public static void StartILimitPlayerBlockAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F858 RID: 194648 RVA: 0x00678677 File Offset: 0x00676877
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F859 RID: 194649 RVA: 0x00678682 File Offset: 0x00676882
		public static Offset<ILimitPlayerBlockAll> EndILimitPlayerBlockAll(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerBlockAll>(builder.EndTable());
		}

		// Token: 0x0602F85A RID: 194650 RVA: 0x00678690 File Offset: 0x00676890
		public ILimitPlayerBlockAllT UnPack()
		{
			ILimitPlayerBlockAllT limitPlayerBlockAllT = new ILimitPlayerBlockAllT();
			this.UnPackTo(limitPlayerBlockAllT);
			return limitPlayerBlockAllT;
		}

		// Token: 0x0602F85B RID: 194651 RVA: 0x006786AB File Offset: 0x006768AB
		public void UnPackTo(ILimitPlayerBlockAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F85C RID: 194652 RVA: 0x006786BC File Offset: 0x006768BC
		public static Offset<ILimitPlayerBlockAll> Pack(FlatBufferBuilder builder, ILimitPlayerBlockAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerBlockAll>);
			}
			return ILimitPlayerBlockAll.CreateILimitPlayerBlockAll(builder, _o.Type);
		}

		// Token: 0x0401121B RID: 70171
		private Table __p;
	}
}
