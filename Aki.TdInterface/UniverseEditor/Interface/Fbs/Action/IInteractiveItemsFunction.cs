using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006990 RID: 27024
	public struct IInteractiveItemsFunction : IFlatbufferObject
	{
		// Token: 0x1700C862 RID: 51298
		// (get) Token: 0x0602F318 RID: 193304 RVA: 0x0066D91A File Offset: 0x0066BB1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F319 RID: 193305 RVA: 0x0066D927 File Offset: 0x0066BB27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F31A RID: 193306 RVA: 0x0066D930 File Offset: 0x0066BB30
		public static IInteractiveItemsFunction GetRootAsIInteractiveItemsFunction(ByteBuffer _bb)
		{
			return IInteractiveItemsFunction.GetRootAsIInteractiveItemsFunction(_bb, default(IInteractiveItemsFunction));
		}

		// Token: 0x0602F31B RID: 193307 RVA: 0x0066D94C File Offset: 0x0066BB4C
		public static IInteractiveItemsFunction GetRootAsIInteractiveItemsFunction(ByteBuffer _bb, IInteractiveItemsFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F31C RID: 193308 RVA: 0x0066D969 File Offset: 0x0066BB69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F31D RID: 193309 RVA: 0x0066D978 File Offset: 0x0066BB78
		public IInteractiveItemsFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C863 RID: 51299
		// (get) Token: 0x0602F31E RID: 193310 RVA: 0x0066D988 File Offset: 0x0066BB88
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

		// Token: 0x1700C864 RID: 51300
		// (get) Token: 0x0602F31F RID: 193311 RVA: 0x0066D9C4 File Offset: 0x0066BBC4
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602F320 RID: 193312 RVA: 0x0066DA03 File Offset: 0x0066BC03
		public static Offset<IInteractiveItemsFunction> CreateIInteractiveItemsFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon, bool Enable = false)
		{
			builder.StartTable(2);
			IInteractiveItemsFunction.AddEnable(builder, Enable);
			IInteractiveItemsFunction.AddType(builder, Type);
			return IInteractiveItemsFunction.EndIInteractiveItemsFunction(builder);
		}

		// Token: 0x0602F321 RID: 193313 RVA: 0x0066DA20 File Offset: 0x0066BC20
		public static void StartIInteractiveItemsFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F322 RID: 193314 RVA: 0x0066DA29 File Offset: 0x0066BC29
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F323 RID: 193315 RVA: 0x0066DA34 File Offset: 0x0066BC34
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x0602F324 RID: 193316 RVA: 0x0066DA3F File Offset: 0x0066BC3F
		public static Offset<IInteractiveItemsFunction> EndIInteractiveItemsFunction(FlatBufferBuilder builder)
		{
			return new Offset<IInteractiveItemsFunction>(builder.EndTable());
		}

		// Token: 0x0602F325 RID: 193317 RVA: 0x0066DA4C File Offset: 0x0066BC4C
		public IInteractiveItemsFunctionT UnPack()
		{
			IInteractiveItemsFunctionT interactiveItemsFunctionT = new IInteractiveItemsFunctionT();
			this.UnPackTo(interactiveItemsFunctionT);
			return interactiveItemsFunctionT;
		}

		// Token: 0x0602F326 RID: 193318 RVA: 0x0066DA67 File Offset: 0x0066BC67
		public void UnPackTo(IInteractiveItemsFunctionT _o)
		{
			_o.Type = this.Type;
			_o.Enable = this.Enable;
		}

		// Token: 0x0602F327 RID: 193319 RVA: 0x0066DA84 File Offset: 0x0066BC84
		public static Offset<IInteractiveItemsFunction> Pack(FlatBufferBuilder builder, IInteractiveItemsFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractiveItemsFunction>);
			}
			return IInteractiveItemsFunction.CreateIInteractiveItemsFunction(builder, _o.Type, _o.Enable);
		}

		// Token: 0x04011122 RID: 69922
		private Table __p;
	}
}
