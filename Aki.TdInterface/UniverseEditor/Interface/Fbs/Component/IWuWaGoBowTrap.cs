using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B1 RID: 25009
	public struct IWuWaGoBowTrap : IFlatbufferObject
	{
		// Token: 0x1700BA80 RID: 47744
		// (get) Token: 0x0602A823 RID: 174115 RVA: 0x005CC318 File Offset: 0x005CA518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A824 RID: 174116 RVA: 0x005CC325 File Offset: 0x005CA525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A825 RID: 174117 RVA: 0x005CC32C File Offset: 0x005CA52C
		public static IWuWaGoBowTrap GetRootAsIWuWaGoBowTrap(ByteBuffer _bb)
		{
			return IWuWaGoBowTrap.GetRootAsIWuWaGoBowTrap(_bb, default(IWuWaGoBowTrap));
		}

		// Token: 0x0602A826 RID: 174118 RVA: 0x005CC348 File Offset: 0x005CA548
		public static IWuWaGoBowTrap GetRootAsIWuWaGoBowTrap(ByteBuffer _bb, IWuWaGoBowTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A827 RID: 174119 RVA: 0x005CC365 File Offset: 0x005CA565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A828 RID: 174120 RVA: 0x005CC374 File Offset: 0x005CA574
		public IWuWaGoBowTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA81 RID: 47745
		// (get) Token: 0x0602A829 RID: 174121 RVA: 0x005CC384 File Offset: 0x005CA584
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A82A RID: 174122 RVA: 0x005CC3C0 File Offset: 0x005CA5C0
		public static Offset<IWuWaGoBowTrap> CreateIWuWaGoBowTrap(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter)
		{
			builder.StartTable(1);
			IWuWaGoBowTrap.AddType(builder, Type);
			return IWuWaGoBowTrap.EndIWuWaGoBowTrap(builder);
		}

		// Token: 0x0602A82B RID: 174123 RVA: 0x005CC3D6 File Offset: 0x005CA5D6
		public static void StartIWuWaGoBowTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A82C RID: 174124 RVA: 0x005CC3DF File Offset: 0x005CA5DF
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A82D RID: 174125 RVA: 0x005CC3EA File Offset: 0x005CA5EA
		public static Offset<IWuWaGoBowTrap> EndIWuWaGoBowTrap(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoBowTrap>(builder.EndTable());
		}

		// Token: 0x0602A82E RID: 174126 RVA: 0x005CC3F8 File Offset: 0x005CA5F8
		public IWuWaGoBowTrapT UnPack()
		{
			IWuWaGoBowTrapT wuWaGoBowTrapT = new IWuWaGoBowTrapT();
			this.UnPackTo(wuWaGoBowTrapT);
			return wuWaGoBowTrapT;
		}

		// Token: 0x0602A82F RID: 174127 RVA: 0x005CC413 File Offset: 0x005CA613
		public void UnPackTo(IWuWaGoBowTrapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A830 RID: 174128 RVA: 0x005CC424 File Offset: 0x005CA624
		public static Offset<IWuWaGoBowTrap> Pack(FlatBufferBuilder builder, IWuWaGoBowTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoBowTrap>);
			}
			return IWuWaGoBowTrap.CreateIWuWaGoBowTrap(builder, _o.Type);
		}

		// Token: 0x04010007 RID: 65543
		private Table __p;
	}
}
