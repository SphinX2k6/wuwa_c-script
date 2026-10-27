using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA1 RID: 23457
	public struct IWuWaGoEndGrid : IFlatbufferObject
	{
		// Token: 0x1700B144 RID: 45380
		// (get) Token: 0x060282A3 RID: 164515 RVA: 0x005852AA File Offset: 0x005834AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060282A4 RID: 164516 RVA: 0x005852B7 File Offset: 0x005834B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060282A5 RID: 164517 RVA: 0x005852C0 File Offset: 0x005834C0
		public static IWuWaGoEndGrid GetRootAsIWuWaGoEndGrid(ByteBuffer _bb)
		{
			return IWuWaGoEndGrid.GetRootAsIWuWaGoEndGrid(_bb, default(IWuWaGoEndGrid));
		}

		// Token: 0x060282A6 RID: 164518 RVA: 0x005852DC File Offset: 0x005834DC
		public static IWuWaGoEndGrid GetRootAsIWuWaGoEndGrid(ByteBuffer _bb, IWuWaGoEndGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060282A7 RID: 164519 RVA: 0x005852F9 File Offset: 0x005834F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060282A8 RID: 164520 RVA: 0x00585308 File Offset: 0x00583508
		public IWuWaGoEndGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B145 RID: 45381
		// (get) Token: 0x060282A9 RID: 164521 RVA: 0x00585318 File Offset: 0x00583518
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

		// Token: 0x1700B146 RID: 45382
		// (get) Token: 0x060282AA RID: 164522 RVA: 0x00585354 File Offset: 0x00583554
		public IWuWaGoGridLinkData? LinkData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x060282AB RID: 164523 RVA: 0x005853A6 File Offset: 0x005835A6
		public static Offset<IWuWaGoEndGrid> CreateIWuWaGoEndGrid(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null)
		{
			builder.StartTable(2);
			IWuWaGoEndGrid.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoEndGrid.AddType(builder, Type);
			return IWuWaGoEndGrid.EndIWuWaGoEndGrid(builder);
		}

		// Token: 0x060282AC RID: 164524 RVA: 0x005853C9 File Offset: 0x005835C9
		public static void StartIWuWaGoEndGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060282AD RID: 164525 RVA: 0x005853D2 File Offset: 0x005835D2
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060282AE RID: 164526 RVA: 0x005853DD File Offset: 0x005835DD
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x060282AF RID: 164527 RVA: 0x005853ED File Offset: 0x005835ED
		public static Offset<IWuWaGoEndGrid> EndIWuWaGoEndGrid(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoEndGrid>(builder.EndTable());
		}

		// Token: 0x060282B0 RID: 164528 RVA: 0x005853FC File Offset: 0x005835FC
		public IWuWaGoEndGridT UnPack()
		{
			IWuWaGoEndGridT wuWaGoEndGridT = new IWuWaGoEndGridT();
			this.UnPackTo(wuWaGoEndGridT);
			return wuWaGoEndGridT;
		}

		// Token: 0x060282B1 RID: 164529 RVA: 0x00585418 File Offset: 0x00583618
		public void UnPackTo(IWuWaGoEndGridT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
		}

		// Token: 0x060282B2 RID: 164530 RVA: 0x00585460 File Offset: 0x00583660
		public static Offset<IWuWaGoEndGrid> Pack(FlatBufferBuilder builder, IWuWaGoEndGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoEndGrid>);
			}
			return IWuWaGoEndGrid.CreateIWuWaGoEndGrid(builder, _o.Type, _o.LinkData);
		}

		// Token: 0x0400F308 RID: 62216
		private Table __p;
	}
}
