using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9B RID: 23451
	public struct IWuWaGoBowTrap : IFlatbufferObject
	{
		// Token: 0x1700B138 RID: 45368
		// (get) Token: 0x0602825F RID: 164447 RVA: 0x00584888 File Offset: 0x00582A88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028260 RID: 164448 RVA: 0x00584895 File Offset: 0x00582A95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028261 RID: 164449 RVA: 0x0058489C File Offset: 0x00582A9C
		public static IWuWaGoBowTrap GetRootAsIWuWaGoBowTrap(ByteBuffer _bb)
		{
			return IWuWaGoBowTrap.GetRootAsIWuWaGoBowTrap(_bb, default(IWuWaGoBowTrap));
		}

		// Token: 0x06028262 RID: 164450 RVA: 0x005848B8 File Offset: 0x00582AB8
		public static IWuWaGoBowTrap GetRootAsIWuWaGoBowTrap(ByteBuffer _bb, IWuWaGoBowTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028263 RID: 164451 RVA: 0x005848D5 File Offset: 0x00582AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028264 RID: 164452 RVA: 0x005848E4 File Offset: 0x00582AE4
		public IWuWaGoBowTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B139 RID: 45369
		// (get) Token: 0x06028265 RID: 164453 RVA: 0x005848F4 File Offset: 0x00582AF4
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

		// Token: 0x06028266 RID: 164454 RVA: 0x00584930 File Offset: 0x00582B30
		public static Offset<IWuWaGoBowTrap> CreateIWuWaGoBowTrap(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter)
		{
			builder.StartTable(1);
			IWuWaGoBowTrap.AddType(builder, Type);
			return IWuWaGoBowTrap.EndIWuWaGoBowTrap(builder);
		}

		// Token: 0x06028267 RID: 164455 RVA: 0x00584946 File Offset: 0x00582B46
		public static void StartIWuWaGoBowTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028268 RID: 164456 RVA: 0x0058494F File Offset: 0x00582B4F
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028269 RID: 164457 RVA: 0x0058495A File Offset: 0x00582B5A
		public static Offset<IWuWaGoBowTrap> EndIWuWaGoBowTrap(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoBowTrap>(builder.EndTable());
		}

		// Token: 0x0602826A RID: 164458 RVA: 0x00584968 File Offset: 0x00582B68
		public IWuWaGoBowTrapT UnPack()
		{
			IWuWaGoBowTrapT wuWaGoBowTrapT = new IWuWaGoBowTrapT();
			this.UnPackTo(wuWaGoBowTrapT);
			return wuWaGoBowTrapT;
		}

		// Token: 0x0602826B RID: 164459 RVA: 0x00584983 File Offset: 0x00582B83
		public void UnPackTo(IWuWaGoBowTrapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602826C RID: 164460 RVA: 0x00584994 File Offset: 0x00582B94
		public static Offset<IWuWaGoBowTrap> Pack(FlatBufferBuilder builder, IWuWaGoBowTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoBowTrap>);
			}
			return IWuWaGoBowTrap.CreateIWuWaGoBowTrap(builder, _o.Type);
		}

		// Token: 0x0400F301 RID: 62209
		private Table __p;
	}
}
