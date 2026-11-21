using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200455F RID: 17759
	public struct IShowUiAll : IFlatbufferObject
	{
		// Token: 0x17007C10 RID: 31760
		// (get) Token: 0x06019D2E RID: 105774 RVA: 0x003AF399 File Offset: 0x003AD599
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D2F RID: 105775 RVA: 0x003AF3A6 File Offset: 0x003AD5A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D30 RID: 105776 RVA: 0x003AF3B0 File Offset: 0x003AD5B0
		public static IShowUiAll GetRootAsIShowUiAll(ByteBuffer _bb)
		{
			return IShowUiAll.GetRootAsIShowUiAll(_bb, default(IShowUiAll));
		}

		// Token: 0x06019D31 RID: 105777 RVA: 0x003AF3CC File Offset: 0x003AD5CC
		public static IShowUiAll GetRootAsIShowUiAll(ByteBuffer _bb, IShowUiAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D32 RID: 105778 RVA: 0x003AF3E9 File Offset: 0x003AD5E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D33 RID: 105779 RVA: 0x003AF3F8 File Offset: 0x003AD5F8
		public IShowUiAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C11 RID: 31761
		// (get) Token: 0x06019D34 RID: 105780 RVA: 0x003AF408 File Offset: 0x003AD608
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

		// Token: 0x06019D35 RID: 105781 RVA: 0x003AF444 File Offset: 0x003AD644
		public static Offset<IShowUiAll> CreateIShowUiAll(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IShowUiAll.AddType(builder, Type);
			return IShowUiAll.EndIShowUiAll(builder);
		}

		// Token: 0x06019D36 RID: 105782 RVA: 0x003AF45A File Offset: 0x003AD65A
		public static void StartIShowUiAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019D37 RID: 105783 RVA: 0x003AF463 File Offset: 0x003AD663
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019D38 RID: 105784 RVA: 0x003AF46E File Offset: 0x003AD66E
		public static Offset<IShowUiAll> EndIShowUiAll(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiAll>(builder.EndTable());
		}

		// Token: 0x06019D39 RID: 105785 RVA: 0x003AF47C File Offset: 0x003AD67C
		public IShowUiAllT UnPack()
		{
			IShowUiAllT showUiAllT = new IShowUiAllT();
			this.UnPackTo(showUiAllT);
			return showUiAllT;
		}

		// Token: 0x06019D3A RID: 105786 RVA: 0x003AF497 File Offset: 0x003AD697
		public void UnPackTo(IShowUiAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019D3B RID: 105787 RVA: 0x003AF4A8 File Offset: 0x003AD6A8
		public static Offset<IShowUiAll> Pack(FlatBufferBuilder builder, IShowUiAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiAll>);
			}
			return IShowUiAll.CreateIShowUiAll(builder, _o.Type);
		}

		// Token: 0x0400C6F1 RID: 50929
		private Table __p;
	}
}
