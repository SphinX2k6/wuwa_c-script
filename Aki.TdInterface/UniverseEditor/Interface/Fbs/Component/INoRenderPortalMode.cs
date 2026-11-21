using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAF RID: 23471
	public struct INoRenderPortalMode : IFlatbufferObject
	{
		// Token: 0x1700AB94 RID: 43924
		// (get) Token: 0x06026B21 RID: 158497 RVA: 0x0054C1F7 File Offset: 0x0054A3F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B22 RID: 158498 RVA: 0x0054C204 File Offset: 0x0054A404
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B23 RID: 158499 RVA: 0x0054C20C File Offset: 0x0054A40C
		public static INoRenderPortalMode GetRootAsINoRenderPortalMode(ByteBuffer _bb)
		{
			return INoRenderPortalMode.GetRootAsINoRenderPortalMode(_bb, default(INoRenderPortalMode));
		}

		// Token: 0x06026B24 RID: 158500 RVA: 0x0054C228 File Offset: 0x0054A428
		public static INoRenderPortalMode GetRootAsINoRenderPortalMode(ByteBuffer _bb, INoRenderPortalMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B25 RID: 158501 RVA: 0x0054C245 File Offset: 0x0054A445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B26 RID: 158502 RVA: 0x0054C254 File Offset: 0x0054A454
		public INoRenderPortalMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB95 RID: 43925
		// (get) Token: 0x06026B27 RID: 158503 RVA: 0x0054C264 File Offset: 0x0054A464
		public ENoRenderPortalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoRenderPortalType.Static;
				}
				return (ENoRenderPortalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB96 RID: 43926
		// (get) Token: 0x06026B28 RID: 158504 RVA: 0x0054C2A0 File Offset: 0x0054A4A0
		public EPortalModel PortalModel
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPortalModel.A;
				}
				return (EPortalModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026B29 RID: 158505 RVA: 0x0054C2DC File Offset: 0x0054A4DC
		public static Offset<INoRenderPortalMode> CreateINoRenderPortalMode(FlatBufferBuilder builder, ENoRenderPortalType Type = ENoRenderPortalType.Static, EPortalModel PortalModel = EPortalModel.A)
		{
			builder.StartTable(2);
			INoRenderPortalMode.AddPortalModel(builder, PortalModel);
			INoRenderPortalMode.AddType(builder, Type);
			return INoRenderPortalMode.EndINoRenderPortalMode(builder);
		}

		// Token: 0x06026B2A RID: 158506 RVA: 0x0054C2F9 File Offset: 0x0054A4F9
		public static void StartINoRenderPortalMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026B2B RID: 158507 RVA: 0x0054C302 File Offset: 0x0054A502
		public static void AddType(FlatBufferBuilder builder, ENoRenderPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026B2C RID: 158508 RVA: 0x0054C30D File Offset: 0x0054A50D
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x06026B2D RID: 158509 RVA: 0x0054C318 File Offset: 0x0054A518
		public static Offset<INoRenderPortalMode> EndINoRenderPortalMode(FlatBufferBuilder builder)
		{
			return new Offset<INoRenderPortalMode>(builder.EndTable());
		}

		// Token: 0x06026B2E RID: 158510 RVA: 0x0054C328 File Offset: 0x0054A528
		public INoRenderPortalModeT UnPack()
		{
			INoRenderPortalModeT noRenderPortalModeT = new INoRenderPortalModeT();
			this.UnPackTo(noRenderPortalModeT);
			return noRenderPortalModeT;
		}

		// Token: 0x06026B2F RID: 158511 RVA: 0x0054C343 File Offset: 0x0054A543
		public void UnPackTo(INoRenderPortalModeT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
		}

		// Token: 0x06026B30 RID: 158512 RVA: 0x0054C360 File Offset: 0x0054A560
		public static Offset<INoRenderPortalMode> Pack(FlatBufferBuilder builder, INoRenderPortalModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoRenderPortalMode>);
			}
			return INoRenderPortalMode.CreateINoRenderPortalMode(builder, _o.Type, _o.PortalModel);
		}

		// Token: 0x0400F5F5 RID: 62965
		private Table __p;
	}
}
