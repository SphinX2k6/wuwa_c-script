using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007043 RID: 28739
	public struct IInteractiveItemsFunction : IFlatbufferObject
	{
		// Token: 0x1700D265 RID: 53861
		// (get) Token: 0x06031CE8 RID: 204008 RVA: 0x006BDE02 File Offset: 0x006BC002
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CE9 RID: 204009 RVA: 0x006BDE0F File Offset: 0x006BC00F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031CEA RID: 204010 RVA: 0x006BDE18 File Offset: 0x006BC018
		public static IInteractiveItemsFunction GetRootAsIInteractiveItemsFunction(ByteBuffer _bb)
		{
			return IInteractiveItemsFunction.GetRootAsIInteractiveItemsFunction(_bb, default(IInteractiveItemsFunction));
		}

		// Token: 0x06031CEB RID: 204011 RVA: 0x006BDE34 File Offset: 0x006BC034
		public static IInteractiveItemsFunction GetRootAsIInteractiveItemsFunction(ByteBuffer _bb, IInteractiveItemsFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031CEC RID: 204012 RVA: 0x006BDE51 File Offset: 0x006BC051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031CED RID: 204013 RVA: 0x006BDE60 File Offset: 0x006BC060
		public IInteractiveItemsFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D266 RID: 53862
		// (get) Token: 0x06031CEE RID: 204014 RVA: 0x006BDE70 File Offset: 0x006BC070
		public EEnableFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return (EEnableFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D267 RID: 53863
		// (get) Token: 0x06031CEF RID: 204015 RVA: 0x006BDEAC File Offset: 0x006BC0AC
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06031CF0 RID: 204016 RVA: 0x006BDEEB File Offset: 0x006BC0EB
		public static Offset<IInteractiveItemsFunction> CreateIInteractiveItemsFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon, bool Enable = false)
		{
			builder.StartTable(2);
			IInteractiveItemsFunction.AddEnable(builder, Enable);
			IInteractiveItemsFunction.AddType(builder, Type);
			return IInteractiveItemsFunction.EndIInteractiveItemsFunction(builder);
		}

		// Token: 0x06031CF1 RID: 204017 RVA: 0x006BDF08 File Offset: 0x006BC108
		public static void StartIInteractiveItemsFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031CF2 RID: 204018 RVA: 0x006BDF11 File Offset: 0x006BC111
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031CF3 RID: 204019 RVA: 0x006BDF1C File Offset: 0x006BC11C
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x06031CF4 RID: 204020 RVA: 0x006BDF27 File Offset: 0x006BC127
		public static Offset<IInteractiveItemsFunction> EndIInteractiveItemsFunction(FlatBufferBuilder builder)
		{
			return new Offset<IInteractiveItemsFunction>(builder.EndTable());
		}

		// Token: 0x06031CF5 RID: 204021 RVA: 0x006BDF34 File Offset: 0x006BC134
		public IInteractiveItemsFunctionT UnPack()
		{
			IInteractiveItemsFunctionT interactiveItemsFunctionT = new IInteractiveItemsFunctionT();
			this.UnPackTo(interactiveItemsFunctionT);
			return interactiveItemsFunctionT;
		}

		// Token: 0x06031CF6 RID: 204022 RVA: 0x006BDF4F File Offset: 0x006BC14F
		public void UnPackTo(IInteractiveItemsFunctionT _o)
		{
			_o.Type = this.Type;
			_o.Enable = this.Enable;
		}

		// Token: 0x06031CF7 RID: 204023 RVA: 0x006BDF6C File Offset: 0x006BC16C
		public static Offset<IInteractiveItemsFunction> Pack(FlatBufferBuilder builder, IInteractiveItemsFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractiveItemsFunction>);
			}
			return IInteractiveItemsFunction.CreateIInteractiveItemsFunction(builder, _o.Type, _o.Enable);
		}

		// Token: 0x04011F8E RID: 73614
		private Table __p;
	}
}
