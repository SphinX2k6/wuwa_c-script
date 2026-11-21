using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004803 RID: 18435
	public struct IManualOccupationRefSource : IFlatbufferObject
	{
		// Token: 0x17008094 RID: 32916
		// (get) Token: 0x0601B3DF RID: 111583 RVA: 0x003DC26A File Offset: 0x003DA46A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3E0 RID: 111584 RVA: 0x003DC277 File Offset: 0x003DA477
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3E1 RID: 111585 RVA: 0x003DC280 File Offset: 0x003DA480
		public static IManualOccupationRefSource GetRootAsIManualOccupationRefSource(ByteBuffer _bb)
		{
			return IManualOccupationRefSource.GetRootAsIManualOccupationRefSource(_bb, default(IManualOccupationRefSource));
		}

		// Token: 0x0601B3E2 RID: 111586 RVA: 0x003DC29C File Offset: 0x003DA49C
		public static IManualOccupationRefSource GetRootAsIManualOccupationRefSource(ByteBuffer _bb, IManualOccupationRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3E3 RID: 111587 RVA: 0x003DC2B9 File Offset: 0x003DA4B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3E4 RID: 111588 RVA: 0x003DC2C8 File Offset: 0x003DA4C8
		public IManualOccupationRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008095 RID: 32917
		// (get) Token: 0x0601B3E5 RID: 111589 RVA: 0x003DC2D8 File Offset: 0x003DA4D8
		public ERefSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefSourceType.AwakeEntity;
				}
				return (ERefSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B3E6 RID: 111590 RVA: 0x003DC314 File Offset: 0x003DA514
		public static Offset<IManualOccupationRefSource> CreateIManualOccupationRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity)
		{
			builder.StartTable(1);
			IManualOccupationRefSource.AddType(builder, Type);
			return IManualOccupationRefSource.EndIManualOccupationRefSource(builder);
		}

		// Token: 0x0601B3E7 RID: 111591 RVA: 0x003DC32A File Offset: 0x003DA52A
		public static void StartIManualOccupationRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B3E8 RID: 111592 RVA: 0x003DC333 File Offset: 0x003DA533
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B3E9 RID: 111593 RVA: 0x003DC33E File Offset: 0x003DA53E
		public static Offset<IManualOccupationRefSource> EndIManualOccupationRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IManualOccupationRefSource>(builder.EndTable());
		}

		// Token: 0x0601B3EA RID: 111594 RVA: 0x003DC34C File Offset: 0x003DA54C
		public IManualOccupationRefSourceT UnPack()
		{
			IManualOccupationRefSourceT manualOccupationRefSourceT = new IManualOccupationRefSourceT();
			this.UnPackTo(manualOccupationRefSourceT);
			return manualOccupationRefSourceT;
		}

		// Token: 0x0601B3EB RID: 111595 RVA: 0x003DC367 File Offset: 0x003DA567
		public void UnPackTo(IManualOccupationRefSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B3EC RID: 111596 RVA: 0x003DC378 File Offset: 0x003DA578
		public static Offset<IManualOccupationRefSource> Pack(FlatBufferBuilder builder, IManualOccupationRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IManualOccupationRefSource>);
			}
			return IManualOccupationRefSource.CreateIManualOccupationRefSource(builder, _o.Type);
		}

		// Token: 0x0400CBF4 RID: 52212
		private Table __p;
	}
}
