using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA5 RID: 16037
	public struct IInformationView : IFlatbufferObject
	{
		// Token: 0x17006F54 RID: 28500
		// (get) Token: 0x06016A4C RID: 92748 RVA: 0x003452E8 File Offset: 0x003434E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A4D RID: 92749 RVA: 0x003452F5 File Offset: 0x003434F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A4E RID: 92750 RVA: 0x003452FC File Offset: 0x003434FC
		public static IInformationView GetRootAsIInformationView(ByteBuffer _bb)
		{
			return IInformationView.GetRootAsIInformationView(_bb, default(IInformationView));
		}

		// Token: 0x06016A4F RID: 92751 RVA: 0x00345318 File Offset: 0x00343518
		public static IInformationView GetRootAsIInformationView(ByteBuffer _bb, IInformationView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A50 RID: 92752 RVA: 0x00345335 File Offset: 0x00343535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A51 RID: 92753 RVA: 0x00345344 File Offset: 0x00343544
		public IInformationView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F55 RID: 28501
		// (get) Token: 0x06016A52 RID: 92754 RVA: 0x00345354 File Offset: 0x00343554
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

		// Token: 0x17006F56 RID: 28502
		// (get) Token: 0x06016A53 RID: 92755 RVA: 0x00345390 File Offset: 0x00343590
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

		// Token: 0x06016A54 RID: 92756 RVA: 0x003453CC File Offset: 0x003435CC
		public static Offset<IInformationView> CreateIInformationView(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, int InformationViewId = 0)
		{
			builder.StartTable(2);
			IInformationView.AddInformationViewId(builder, InformationViewId);
			IInformationView.AddType(builder, Type);
			return IInformationView.EndIInformationView(builder);
		}

		// Token: 0x06016A55 RID: 92757 RVA: 0x003453E9 File Offset: 0x003435E9
		public static void StartIInformationView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016A56 RID: 92758 RVA: 0x003453F2 File Offset: 0x003435F2
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A57 RID: 92759 RVA: 0x003453FD File Offset: 0x003435FD
		public static void AddInformationViewId(FlatBufferBuilder builder, int informationViewId)
		{
			builder.AddInt(1, informationViewId, 0);
		}

		// Token: 0x06016A58 RID: 92760 RVA: 0x00345408 File Offset: 0x00343608
		public static Offset<IInformationView> EndIInformationView(FlatBufferBuilder builder)
		{
			return new Offset<IInformationView>(builder.EndTable());
		}

		// Token: 0x06016A59 RID: 92761 RVA: 0x00345418 File Offset: 0x00343618
		public IInformationViewT UnPack()
		{
			IInformationViewT informationViewT = new IInformationViewT();
			this.UnPackTo(informationViewT);
			return informationViewT;
		}

		// Token: 0x06016A5A RID: 92762 RVA: 0x00345433 File Offset: 0x00343633
		public void UnPackTo(IInformationViewT _o)
		{
			_o.Type = this.Type;
			_o.InformationViewId = this.InformationViewId;
		}

		// Token: 0x06016A5B RID: 92763 RVA: 0x00345450 File Offset: 0x00343650
		public static Offset<IInformationView> Pack(FlatBufferBuilder builder, IInformationViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationView>);
			}
			return IInformationView.CreateIInformationView(builder, _o.Type, _o.InformationViewId);
		}

		// Token: 0x0400B871 RID: 47217
		private Table __p;
	}
}
