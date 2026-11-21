using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD4 RID: 27860
	public struct IEnableFunction : IFlatbufferObject
	{
		// Token: 0x1700CC5B RID: 52315
		// (get) Token: 0x0603005A RID: 196698 RVA: 0x00688DB0 File Offset: 0x00686FB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603005B RID: 196699 RVA: 0x00688DBD File Offset: 0x00686FBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603005C RID: 196700 RVA: 0x00688DC4 File Offset: 0x00686FC4
		public static IEnableFunction GetRootAsIEnableFunction(ByteBuffer _bb)
		{
			return IEnableFunction.GetRootAsIEnableFunction(_bb, default(IEnableFunction));
		}

		// Token: 0x0603005D RID: 196701 RVA: 0x00688DE0 File Offset: 0x00686FE0
		public static IEnableFunction GetRootAsIEnableFunction(ByteBuffer _bb, IEnableFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603005E RID: 196702 RVA: 0x00688DFD File Offset: 0x00686FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603005F RID: 196703 RVA: 0x00688E0C File Offset: 0x0068700C
		public IEnableFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC5C RID: 52316
		// (get) Token: 0x06030060 RID: 196704 RVA: 0x00688E1C File Offset: 0x0068701C
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

		// Token: 0x06030061 RID: 196705 RVA: 0x00688E58 File Offset: 0x00687058
		public static Offset<IEnableFunction> CreateIEnableFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon)
		{
			builder.StartTable(1);
			IEnableFunction.AddType(builder, Type);
			return IEnableFunction.EndIEnableFunction(builder);
		}

		// Token: 0x06030062 RID: 196706 RVA: 0x00688E6E File Offset: 0x0068706E
		public static void StartIEnableFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030063 RID: 196707 RVA: 0x00688E77 File Offset: 0x00687077
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030064 RID: 196708 RVA: 0x00688E82 File Offset: 0x00687082
		public static Offset<IEnableFunction> EndIEnableFunction(FlatBufferBuilder builder)
		{
			return new Offset<IEnableFunction>(builder.EndTable());
		}

		// Token: 0x06030065 RID: 196709 RVA: 0x00688E90 File Offset: 0x00687090
		public IEnableFunctionT UnPack()
		{
			IEnableFunctionT enableFunctionT = new IEnableFunctionT();
			this.UnPackTo(enableFunctionT);
			return enableFunctionT;
		}

		// Token: 0x06030066 RID: 196710 RVA: 0x00688EAB File Offset: 0x006870AB
		public void UnPackTo(IEnableFunctionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030067 RID: 196711 RVA: 0x00688EBC File Offset: 0x006870BC
		public static Offset<IEnableFunction> Pack(FlatBufferBuilder builder, IEnableFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableFunction>);
			}
			return IEnableFunction.CreateIEnableFunction(builder, _o.Type);
		}

		// Token: 0x04011B21 RID: 72481
		private Table __p;
	}
}
