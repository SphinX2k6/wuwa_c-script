using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E3 RID: 17123
	public struct IInformationView : IFlatbufferObject
	{
		// Token: 0x17007541 RID: 30017
		// (get) Token: 0x06018099 RID: 98457 RVA: 0x0036E270 File Offset: 0x0036C470
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601809A RID: 98458 RVA: 0x0036E27D File Offset: 0x0036C47D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601809B RID: 98459 RVA: 0x0036E284 File Offset: 0x0036C484
		public static IInformationView GetRootAsIInformationView(ByteBuffer _bb)
		{
			return IInformationView.GetRootAsIInformationView(_bb, default(IInformationView));
		}

		// Token: 0x0601809C RID: 98460 RVA: 0x0036E2A0 File Offset: 0x0036C4A0
		public static IInformationView GetRootAsIInformationView(ByteBuffer _bb, IInformationView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601809D RID: 98461 RVA: 0x0036E2BD File Offset: 0x0036C4BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601809E RID: 98462 RVA: 0x0036E2CC File Offset: 0x0036C4CC
		public IInformationView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007542 RID: 30018
		// (get) Token: 0x0601809F RID: 98463 RVA: 0x0036E2DC File Offset: 0x0036C4DC
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007543 RID: 30019
		// (get) Token: 0x060180A0 RID: 98464 RVA: 0x0036E318 File Offset: 0x0036C518
		public int InformationViewId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060180A1 RID: 98465 RVA: 0x0036E354 File Offset: 0x0036C554
		public static Offset<IInformationView> CreateIInformationView(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, int InformationViewId = 0)
		{
			builder.StartTable(2);
			IInformationView.AddInformationViewId(builder, InformationViewId);
			IInformationView.AddType(builder, Type);
			return IInformationView.EndIInformationView(builder);
		}

		// Token: 0x060180A2 RID: 98466 RVA: 0x0036E371 File Offset: 0x0036C571
		public static void StartIInformationView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060180A3 RID: 98467 RVA: 0x0036E37A File Offset: 0x0036C57A
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060180A4 RID: 98468 RVA: 0x0036E385 File Offset: 0x0036C585
		public static void AddInformationViewId(FlatBufferBuilder builder, int informationViewId)
		{
			builder.AddInt(1, informationViewId, 0);
		}

		// Token: 0x060180A5 RID: 98469 RVA: 0x0036E390 File Offset: 0x0036C590
		public static Offset<IInformationView> EndIInformationView(FlatBufferBuilder builder)
		{
			return new Offset<IInformationView>(builder.EndTable());
		}

		// Token: 0x060180A6 RID: 98470 RVA: 0x0036E3A0 File Offset: 0x0036C5A0
		public IInformationViewT UnPack()
		{
			IInformationViewT informationViewT = new IInformationViewT();
			this.UnPackTo(informationViewT);
			return informationViewT;
		}

		// Token: 0x060180A7 RID: 98471 RVA: 0x0036E3BB File Offset: 0x0036C5BB
		public void UnPackTo(IInformationViewT _o)
		{
			_o.Type = this.Type;
			_o.InformationViewId = this.InformationViewId;
		}

		// Token: 0x060180A8 RID: 98472 RVA: 0x0036E3D8 File Offset: 0x0036C5D8
		public static Offset<IInformationView> Pack(FlatBufferBuilder builder, IInformationViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationView>);
			}
			return IInformationView.CreateIInformationView(builder, _o.Type, _o.InformationViewId);
		}

		// Token: 0x0400C24D RID: 49741
		private Table __p;
	}
}
