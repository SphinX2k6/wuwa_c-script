using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540A RID: 21514
	public struct IInhaledDestroySelf : IFlatbufferObject
	{
		// Token: 0x17009E49 RID: 40521
		// (get) Token: 0x0602354F RID: 144719 RVA: 0x004E4025 File Offset: 0x004E2225
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023550 RID: 144720 RVA: 0x004E4032 File Offset: 0x004E2232
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023551 RID: 144721 RVA: 0x004E403C File Offset: 0x004E223C
		public static IInhaledDestroySelf GetRootAsIInhaledDestroySelf(ByteBuffer _bb)
		{
			return IInhaledDestroySelf.GetRootAsIInhaledDestroySelf(_bb, default(IInhaledDestroySelf));
		}

		// Token: 0x06023552 RID: 144722 RVA: 0x004E4058 File Offset: 0x004E2258
		public static IInhaledDestroySelf GetRootAsIInhaledDestroySelf(ByteBuffer _bb, IInhaledDestroySelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023553 RID: 144723 RVA: 0x004E4075 File Offset: 0x004E2275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023554 RID: 144724 RVA: 0x004E4084 File Offset: 0x004E2284
		public IInhaledDestroySelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E4A RID: 40522
		// (get) Token: 0x06023555 RID: 144725 RVA: 0x004E4094 File Offset: 0x004E2294
		public EInhaledPerResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return (EInhaledPerResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023556 RID: 144726 RVA: 0x004E40D0 File Offset: 0x004E22D0
		public static Offset<IInhaledDestroySelf> CreateIInhaledDestroySelf(FlatBufferBuilder builder, EInhaledPerResultType Type = EInhaledPerResultType.DestroySelf)
		{
			builder.StartTable(1);
			IInhaledDestroySelf.AddType(builder, Type);
			return IInhaledDestroySelf.EndIInhaledDestroySelf(builder);
		}

		// Token: 0x06023557 RID: 144727 RVA: 0x004E40E6 File Offset: 0x004E22E6
		public static void StartIInhaledDestroySelf(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023558 RID: 144728 RVA: 0x004E40EF File Offset: 0x004E22EF
		public static void AddType(FlatBufferBuilder builder, EInhaledPerResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023559 RID: 144729 RVA: 0x004E40FA File Offset: 0x004E22FA
		public static Offset<IInhaledDestroySelf> EndIInhaledDestroySelf(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledDestroySelf>(builder.EndTable());
		}

		// Token: 0x0602355A RID: 144730 RVA: 0x004E4108 File Offset: 0x004E2308
		public IInhaledDestroySelfT UnPack()
		{
			IInhaledDestroySelfT inhaledDestroySelfT = new IInhaledDestroySelfT();
			this.UnPackTo(inhaledDestroySelfT);
			return inhaledDestroySelfT;
		}

		// Token: 0x0602355B RID: 144731 RVA: 0x004E4123 File Offset: 0x004E2323
		public void UnPackTo(IInhaledDestroySelfT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602355C RID: 144732 RVA: 0x004E4134 File Offset: 0x004E2334
		public static Offset<IInhaledDestroySelf> Pack(FlatBufferBuilder builder, IInhaledDestroySelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledDestroySelf>);
			}
			return IInhaledDestroySelf.CreateIInhaledDestroySelf(builder, _o.Type);
		}

		// Token: 0x0400E651 RID: 58961
		private Table __p;
	}
}
