using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B7 RID: 25015
	public struct IWuWaGoEndGrid : IFlatbufferObject
	{
		// Token: 0x1700BA8C RID: 47756
		// (get) Token: 0x0602A867 RID: 174183 RVA: 0x005CCD3A File Offset: 0x005CAF3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A868 RID: 174184 RVA: 0x005CCD47 File Offset: 0x005CAF47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A869 RID: 174185 RVA: 0x005CCD50 File Offset: 0x005CAF50
		public static IWuWaGoEndGrid GetRootAsIWuWaGoEndGrid(ByteBuffer _bb)
		{
			return IWuWaGoEndGrid.GetRootAsIWuWaGoEndGrid(_bb, default(IWuWaGoEndGrid));
		}

		// Token: 0x0602A86A RID: 174186 RVA: 0x005CCD6C File Offset: 0x005CAF6C
		public static IWuWaGoEndGrid GetRootAsIWuWaGoEndGrid(ByteBuffer _bb, IWuWaGoEndGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A86B RID: 174187 RVA: 0x005CCD89 File Offset: 0x005CAF89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A86C RID: 174188 RVA: 0x005CCD98 File Offset: 0x005CAF98
		public IWuWaGoEndGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA8D RID: 47757
		// (get) Token: 0x0602A86D RID: 174189 RVA: 0x005CCDA8 File Offset: 0x005CAFA8
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

		// Token: 0x1700BA8E RID: 47758
		// (get) Token: 0x0602A86E RID: 174190 RVA: 0x005CCDE4 File Offset: 0x005CAFE4
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

		// Token: 0x0602A86F RID: 174191 RVA: 0x005CCE36 File Offset: 0x005CB036
		public static Offset<IWuWaGoEndGrid> CreateIWuWaGoEndGrid(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null)
		{
			builder.StartTable(2);
			IWuWaGoEndGrid.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoEndGrid.AddType(builder, Type);
			return IWuWaGoEndGrid.EndIWuWaGoEndGrid(builder);
		}

		// Token: 0x0602A870 RID: 174192 RVA: 0x005CCE59 File Offset: 0x005CB059
		public static void StartIWuWaGoEndGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A871 RID: 174193 RVA: 0x005CCE62 File Offset: 0x005CB062
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A872 RID: 174194 RVA: 0x005CCE6D File Offset: 0x005CB06D
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x0602A873 RID: 174195 RVA: 0x005CCE7D File Offset: 0x005CB07D
		public static Offset<IWuWaGoEndGrid> EndIWuWaGoEndGrid(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoEndGrid>(builder.EndTable());
		}

		// Token: 0x0602A874 RID: 174196 RVA: 0x005CCE8C File Offset: 0x005CB08C
		public IWuWaGoEndGridT UnPack()
		{
			IWuWaGoEndGridT wuWaGoEndGridT = new IWuWaGoEndGridT();
			this.UnPackTo(wuWaGoEndGridT);
			return wuWaGoEndGridT;
		}

		// Token: 0x0602A875 RID: 174197 RVA: 0x005CCEA8 File Offset: 0x005CB0A8
		public void UnPackTo(IWuWaGoEndGridT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
		}

		// Token: 0x0602A876 RID: 174198 RVA: 0x005CCEF0 File Offset: 0x005CB0F0
		public static Offset<IWuWaGoEndGrid> Pack(FlatBufferBuilder builder, IWuWaGoEndGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoEndGrid>);
			}
			return IWuWaGoEndGrid.CreateIWuWaGoEndGrid(builder, _o.Type, _o.LinkData);
		}

		// Token: 0x0401000E RID: 65550
		private Table __p;
	}
}
