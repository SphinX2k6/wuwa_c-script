using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200455C RID: 17756
	public struct IShowUi : IFlatbufferObject
	{
		// Token: 0x17007C0D RID: 31757
		// (get) Token: 0x06019D1C RID: 105756 RVA: 0x003AF221 File Offset: 0x003AD421
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D1D RID: 105757 RVA: 0x003AF22E File Offset: 0x003AD42E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D1E RID: 105758 RVA: 0x003AF238 File Offset: 0x003AD438
		public static IShowUi GetRootAsIShowUi(ByteBuffer _bb)
		{
			return IShowUi.GetRootAsIShowUi(_bb, default(IShowUi));
		}

		// Token: 0x06019D1F RID: 105759 RVA: 0x003AF254 File Offset: 0x003AD454
		public static IShowUi GetRootAsIShowUi(ByteBuffer _bb, IShowUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D20 RID: 105760 RVA: 0x003AF271 File Offset: 0x003AD471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D21 RID: 105761 RVA: 0x003AF280 File Offset: 0x003AD480
		public IShowUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C0E RID: 31758
		// (get) Token: 0x06019D22 RID: 105762 RVA: 0x003AF290 File Offset: 0x003AD490
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

		// Token: 0x06019D23 RID: 105763 RVA: 0x003AF2CC File Offset: 0x003AD4CC
		public static Offset<IShowUi> CreateIShowUi(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IShowUi.AddType(builder, Type);
			return IShowUi.EndIShowUi(builder);
		}

		// Token: 0x06019D24 RID: 105764 RVA: 0x003AF2E2 File Offset: 0x003AD4E2
		public static void StartIShowUi(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019D25 RID: 105765 RVA: 0x003AF2EB File Offset: 0x003AD4EB
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019D26 RID: 105766 RVA: 0x003AF2F6 File Offset: 0x003AD4F6
		public static Offset<IShowUi> EndIShowUi(FlatBufferBuilder builder)
		{
			return new Offset<IShowUi>(builder.EndTable());
		}

		// Token: 0x06019D27 RID: 105767 RVA: 0x003AF304 File Offset: 0x003AD504
		public IShowUiT UnPack()
		{
			IShowUiT showUiT = new IShowUiT();
			this.UnPackTo(showUiT);
			return showUiT;
		}

		// Token: 0x06019D28 RID: 105768 RVA: 0x003AF31F File Offset: 0x003AD51F
		public void UnPackTo(IShowUiT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019D29 RID: 105769 RVA: 0x003AF330 File Offset: 0x003AD530
		public static Offset<IShowUi> Pack(FlatBufferBuilder builder, IShowUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUi>);
			}
			return IShowUi.CreateIShowUi(builder, _o.Type);
		}

		// Token: 0x0400C6EF RID: 50927
		private Table __p;
	}
}
