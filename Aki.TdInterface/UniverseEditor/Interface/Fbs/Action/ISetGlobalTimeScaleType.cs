using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C1 RID: 30657
	public struct ISetGlobalTimeScaleType : IFlatbufferObject
	{
		// Token: 0x1700E0C3 RID: 57539
		// (get) Token: 0x06035DA4 RID: 220580 RVA: 0x0073732C File Offset: 0x0073552C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035DA5 RID: 220581 RVA: 0x00737339 File Offset: 0x00735539
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035DA6 RID: 220582 RVA: 0x00737340 File Offset: 0x00735540
		public static ISetGlobalTimeScaleType GetRootAsISetGlobalTimeScaleType(ByteBuffer _bb)
		{
			return ISetGlobalTimeScaleType.GetRootAsISetGlobalTimeScaleType(_bb, default(ISetGlobalTimeScaleType));
		}

		// Token: 0x06035DA7 RID: 220583 RVA: 0x0073735C File Offset: 0x0073555C
		public static ISetGlobalTimeScaleType GetRootAsISetGlobalTimeScaleType(ByteBuffer _bb, ISetGlobalTimeScaleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035DA8 RID: 220584 RVA: 0x00737379 File Offset: 0x00735579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035DA9 RID: 220585 RVA: 0x00737388 File Offset: 0x00735588
		public ISetGlobalTimeScaleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0C4 RID: 57540
		// (get) Token: 0x06035DAA RID: 220586 RVA: 0x00737398 File Offset: 0x00735598
		public ESetTimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTimeScaleType.Open;
				}
				return (ESetTimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035DAB RID: 220587 RVA: 0x007373D4 File Offset: 0x007355D4
		public static Offset<ISetGlobalTimeScaleType> CreateISetGlobalTimeScaleType(FlatBufferBuilder builder, ESetTimeScaleType Type = ESetTimeScaleType.Open)
		{
			builder.StartTable(1);
			ISetGlobalTimeScaleType.AddType(builder, Type);
			return ISetGlobalTimeScaleType.EndISetGlobalTimeScaleType(builder);
		}

		// Token: 0x06035DAC RID: 220588 RVA: 0x007373EA File Offset: 0x007355EA
		public static void StartISetGlobalTimeScaleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035DAD RID: 220589 RVA: 0x007373F3 File Offset: 0x007355F3
		public static void AddType(FlatBufferBuilder builder, ESetTimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035DAE RID: 220590 RVA: 0x007373FE File Offset: 0x007355FE
		public static Offset<ISetGlobalTimeScaleType> EndISetGlobalTimeScaleType(FlatBufferBuilder builder)
		{
			return new Offset<ISetGlobalTimeScaleType>(builder.EndTable());
		}

		// Token: 0x06035DAF RID: 220591 RVA: 0x0073740C File Offset: 0x0073560C
		public ISetGlobalTimeScaleTypeT UnPack()
		{
			ISetGlobalTimeScaleTypeT setGlobalTimeScaleTypeT = new ISetGlobalTimeScaleTypeT();
			this.UnPackTo(setGlobalTimeScaleTypeT);
			return setGlobalTimeScaleTypeT;
		}

		// Token: 0x06035DB0 RID: 220592 RVA: 0x00737427 File Offset: 0x00735627
		public void UnPackTo(ISetGlobalTimeScaleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035DB1 RID: 220593 RVA: 0x00737438 File Offset: 0x00735638
		public static Offset<ISetGlobalTimeScaleType> Pack(FlatBufferBuilder builder, ISetGlobalTimeScaleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetGlobalTimeScaleType>);
			}
			return ISetGlobalTimeScaleType.CreateISetGlobalTimeScaleType(builder, _o.Type);
		}

		// Token: 0x040129FE RID: 76286
		private Table __p;
	}
}
