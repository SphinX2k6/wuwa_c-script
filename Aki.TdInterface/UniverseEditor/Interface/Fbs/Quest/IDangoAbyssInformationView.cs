using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC7 RID: 15815
	public struct IDangoAbyssInformationView : IFlatbufferObject
	{
		// Token: 0x17006D2B RID: 27947
		// (get) Token: 0x0601611B RID: 90395 RVA: 0x00330E7D File Offset: 0x0032F07D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601611C RID: 90396 RVA: 0x00330E8A File Offset: 0x0032F08A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601611D RID: 90397 RVA: 0x00330E94 File Offset: 0x0032F094
		public static IDangoAbyssInformationView GetRootAsIDangoAbyssInformationView(ByteBuffer _bb)
		{
			return IDangoAbyssInformationView.GetRootAsIDangoAbyssInformationView(_bb, default(IDangoAbyssInformationView));
		}

		// Token: 0x0601611E RID: 90398 RVA: 0x00330EB0 File Offset: 0x0032F0B0
		public static IDangoAbyssInformationView GetRootAsIDangoAbyssInformationView(ByteBuffer _bb, IDangoAbyssInformationView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601611F RID: 90399 RVA: 0x00330ECD File Offset: 0x0032F0CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016120 RID: 90400 RVA: 0x00330EDC File Offset: 0x0032F0DC
		public IDangoAbyssInformationView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D2C RID: 27948
		// (get) Token: 0x06016121 RID: 90401 RVA: 0x00330EEC File Offset: 0x0032F0EC
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

		// Token: 0x06016122 RID: 90402 RVA: 0x00330F28 File Offset: 0x0032F128
		public static Offset<IDangoAbyssInformationView> CreateIDangoAbyssInformationView(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay)
		{
			builder.StartTable(1);
			IDangoAbyssInformationView.AddType(builder, Type);
			return IDangoAbyssInformationView.EndIDangoAbyssInformationView(builder);
		}

		// Token: 0x06016123 RID: 90403 RVA: 0x00330F3E File Offset: 0x0032F13E
		public static void StartIDangoAbyssInformationView(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016124 RID: 90404 RVA: 0x00330F47 File Offset: 0x0032F147
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016125 RID: 90405 RVA: 0x00330F52 File Offset: 0x0032F152
		public static Offset<IDangoAbyssInformationView> EndIDangoAbyssInformationView(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssInformationView>(builder.EndTable());
		}

		// Token: 0x06016126 RID: 90406 RVA: 0x00330F60 File Offset: 0x0032F160
		public IDangoAbyssInformationViewT UnPack()
		{
			IDangoAbyssInformationViewT dangoAbyssInformationViewT = new IDangoAbyssInformationViewT();
			this.UnPackTo(dangoAbyssInformationViewT);
			return dangoAbyssInformationViewT;
		}

		// Token: 0x06016127 RID: 90407 RVA: 0x00330F7B File Offset: 0x0032F17B
		public void UnPackTo(IDangoAbyssInformationViewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016128 RID: 90408 RVA: 0x00330F8C File Offset: 0x0032F18C
		public static Offset<IDangoAbyssInformationView> Pack(FlatBufferBuilder builder, IDangoAbyssInformationViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssInformationView>);
			}
			return IDangoAbyssInformationView.CreateIDangoAbyssInformationView(builder, _o.Type);
		}

		// Token: 0x0400B708 RID: 46856
		private Table __p;
	}
}
