using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006663 RID: 26211
	public struct IEnableFunction : IFlatbufferObject
	{
		// Token: 0x1700C2BD RID: 49853
		// (get) Token: 0x0602D889 RID: 186505 RVA: 0x0063C248 File Offset: 0x0063A448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D88A RID: 186506 RVA: 0x0063C255 File Offset: 0x0063A455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D88B RID: 186507 RVA: 0x0063C25C File Offset: 0x0063A45C
		public static IEnableFunction GetRootAsIEnableFunction(ByteBuffer _bb)
		{
			return IEnableFunction.GetRootAsIEnableFunction(_bb, default(IEnableFunction));
		}

		// Token: 0x0602D88C RID: 186508 RVA: 0x0063C278 File Offset: 0x0063A478
		public static IEnableFunction GetRootAsIEnableFunction(ByteBuffer _bb, IEnableFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D88D RID: 186509 RVA: 0x0063C295 File Offset: 0x0063A495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D88E RID: 186510 RVA: 0x0063C2A4 File Offset: 0x0063A4A4
		public IEnableFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2BE RID: 49854
		// (get) Token: 0x0602D88F RID: 186511 RVA: 0x0063C2B4 File Offset: 0x0063A4B4
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

		// Token: 0x0602D890 RID: 186512 RVA: 0x0063C2F0 File Offset: 0x0063A4F0
		public static Offset<IEnableFunction> CreateIEnableFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon)
		{
			builder.StartTable(1);
			IEnableFunction.AddType(builder, Type);
			return IEnableFunction.EndIEnableFunction(builder);
		}

		// Token: 0x0602D891 RID: 186513 RVA: 0x0063C306 File Offset: 0x0063A506
		public static void StartIEnableFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D892 RID: 186514 RVA: 0x0063C30F File Offset: 0x0063A50F
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D893 RID: 186515 RVA: 0x0063C31A File Offset: 0x0063A51A
		public static Offset<IEnableFunction> EndIEnableFunction(FlatBufferBuilder builder)
		{
			return new Offset<IEnableFunction>(builder.EndTable());
		}

		// Token: 0x0602D894 RID: 186516 RVA: 0x0063C328 File Offset: 0x0063A528
		public IEnableFunctionT UnPack()
		{
			IEnableFunctionT enableFunctionT = new IEnableFunctionT();
			this.UnPackTo(enableFunctionT);
			return enableFunctionT;
		}

		// Token: 0x0602D895 RID: 186517 RVA: 0x0063C343 File Offset: 0x0063A543
		public void UnPackTo(IEnableFunctionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D896 RID: 186518 RVA: 0x0063C354 File Offset: 0x0063A554
		public static Offset<IEnableFunction> Pack(FlatBufferBuilder builder, IEnableFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableFunction>);
			}
			return IEnableFunction.CreateIEnableFunction(builder, _o.Type);
		}

		// Token: 0x04010D06 RID: 68870
		private Table __p;
	}
}
