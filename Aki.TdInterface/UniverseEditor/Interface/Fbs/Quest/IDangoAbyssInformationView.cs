using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DE RID: 16862
	public struct IDangoAbyssInformationView : IFlatbufferObject
	{
		// Token: 0x170072E5 RID: 29413
		// (get) Token: 0x06017654 RID: 95828 RVA: 0x00358205 File Offset: 0x00356405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017655 RID: 95829 RVA: 0x00358212 File Offset: 0x00356412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017656 RID: 95830 RVA: 0x0035821C File Offset: 0x0035641C
		public static IDangoAbyssInformationView GetRootAsIDangoAbyssInformationView(ByteBuffer _bb)
		{
			return IDangoAbyssInformationView.GetRootAsIDangoAbyssInformationView(_bb, default(IDangoAbyssInformationView));
		}

		// Token: 0x06017657 RID: 95831 RVA: 0x00358238 File Offset: 0x00356438
		public static IDangoAbyssInformationView GetRootAsIDangoAbyssInformationView(ByteBuffer _bb, IDangoAbyssInformationView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017658 RID: 95832 RVA: 0x00358255 File Offset: 0x00356455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017659 RID: 95833 RVA: 0x00358264 File Offset: 0x00356464
		public IDangoAbyssInformationView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072E6 RID: 29414
		// (get) Token: 0x0601765A RID: 95834 RVA: 0x00358274 File Offset: 0x00356474
		public EInformationViewType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationViewType.LevelPlay;
				}
				return (EInformationViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601765B RID: 95835 RVA: 0x003582B0 File Offset: 0x003564B0
		public static Offset<IDangoAbyssInformationView> CreateIDangoAbyssInformationView(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay)
		{
			builder.StartTable(1);
			IDangoAbyssInformationView.AddType(builder, Type);
			return IDangoAbyssInformationView.EndIDangoAbyssInformationView(builder);
		}

		// Token: 0x0601765C RID: 95836 RVA: 0x003582C6 File Offset: 0x003564C6
		public static void StartIDangoAbyssInformationView(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601765D RID: 95837 RVA: 0x003582CF File Offset: 0x003564CF
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601765E RID: 95838 RVA: 0x003582DA File Offset: 0x003564DA
		public static Offset<IDangoAbyssInformationView> EndIDangoAbyssInformationView(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssInformationView>(builder.EndTable());
		}

		// Token: 0x0601765F RID: 95839 RVA: 0x003582E8 File Offset: 0x003564E8
		public IDangoAbyssInformationViewT UnPack()
		{
			IDangoAbyssInformationViewT dangoAbyssInformationViewT = new IDangoAbyssInformationViewT();
			this.UnPackTo(dangoAbyssInformationViewT);
			return dangoAbyssInformationViewT;
		}

		// Token: 0x06017660 RID: 95840 RVA: 0x00358303 File Offset: 0x00356503
		public void UnPackTo(IDangoAbyssInformationViewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017661 RID: 95841 RVA: 0x00358314 File Offset: 0x00356514
		public static Offset<IDangoAbyssInformationView> Pack(FlatBufferBuilder builder, IDangoAbyssInformationViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssInformationView>);
			}
			return IDangoAbyssInformationView.CreateIDangoAbyssInformationView(builder, _o.Type);
		}

		// Token: 0x0400C0B5 RID: 49333
		private Table __p;
	}
}
