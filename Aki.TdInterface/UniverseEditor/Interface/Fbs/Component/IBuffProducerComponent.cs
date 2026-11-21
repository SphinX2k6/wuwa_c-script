using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005463 RID: 21603
	public struct IBuffProducerComponent : IFlatbufferObject
	{
		// Token: 0x170099A1 RID: 39329
		// (get) Token: 0x06021ED2 RID: 138962 RVA: 0x004AD104 File Offset: 0x004AB304
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021ED3 RID: 138963 RVA: 0x004AD111 File Offset: 0x004AB311
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021ED4 RID: 138964 RVA: 0x004AD118 File Offset: 0x004AB318
		public static IBuffProducerComponent GetRootAsIBuffProducerComponent(ByteBuffer _bb)
		{
			return IBuffProducerComponent.GetRootAsIBuffProducerComponent(_bb, default(IBuffProducerComponent));
		}

		// Token: 0x06021ED5 RID: 138965 RVA: 0x004AD134 File Offset: 0x004AB334
		public static IBuffProducerComponent GetRootAsIBuffProducerComponent(ByteBuffer _bb, IBuffProducerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021ED6 RID: 138966 RVA: 0x004AD151 File Offset: 0x004AB351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021ED7 RID: 138967 RVA: 0x004AD160 File Offset: 0x004AB360
		public IBuffProducerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099A2 RID: 39330
		// (get) Token: 0x06021ED8 RID: 138968 RVA: 0x004AD170 File Offset: 0x004AB370
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170099A3 RID: 39331
		// (get) Token: 0x06021ED9 RID: 138969 RVA: 0x004AD1B0 File Offset: 0x004AB3B0
		public TAddBuffMode AddBuffModeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAddBuffMode.NONE;
				}
				return (TAddBuffMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021EDA RID: 138970 RVA: 0x004AD1EC File Offset: 0x004AB3EC
		public TTable? AddBuffMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021EDB RID: 138971 RVA: 0x004AD230 File Offset: 0x004AB430
		public IAdsorbAddBuff AddBuffModeAsIAdsorbAddBuff()
		{
			return this.AddBuffMode<IAdsorbAddBuff>().Value;
		}

		// Token: 0x06021EDC RID: 138972 RVA: 0x004AD24C File Offset: 0x004AB44C
		public IFireBulletAddBuff AddBuffModeAsIFireBulletAddBuff()
		{
			return this.AddBuffMode<IFireBulletAddBuff>().Value;
		}

		// Token: 0x06021EDD RID: 138973 RVA: 0x004AD268 File Offset: 0x004AB468
		public IImmediateAddBuff AddBuffModeAsIImmediateAddBuff()
		{
			return this.AddBuffMode<IImmediateAddBuff>().Value;
		}

		// Token: 0x170099A4 RID: 39332
		// (get) Token: 0x06021EDE RID: 138974 RVA: 0x004AD284 File Offset: 0x004AB484
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170099A5 RID: 39333
		// (get) Token: 0x06021EDF RID: 138975 RVA: 0x004AD2C4 File Offset: 0x004AB4C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021EE0 RID: 138976 RVA: 0x004AD301 File Offset: 0x004AB501
		public static Offset<IBuffProducerComponent> CreateIBuffProducerComponent(FlatBufferBuilder builder, bool Disabled = false, TAddBuffMode AddBuffMode_type = TAddBuffMode.NONE, int AddBuffModeOffset = 0, long BuffId = 0L, byte NullMask = 0)
		{
			builder.StartTable(5);
			IBuffProducerComponent.AddBuffId(builder, BuffId);
			IBuffProducerComponent.AddAddBuffMode(builder, AddBuffModeOffset);
			IBuffProducerComponent.AddNullMask(builder, NullMask);
			IBuffProducerComponent.AddAddBuffModeType(builder, AddBuffMode_type);
			IBuffProducerComponent.AddDisabled(builder, Disabled);
			return IBuffProducerComponent.EndIBuffProducerComponent(builder);
		}

		// Token: 0x06021EE1 RID: 138977 RVA: 0x004AD335 File Offset: 0x004AB535
		public static void StartIBuffProducerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021EE2 RID: 138978 RVA: 0x004AD33E File Offset: 0x004AB53E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021EE3 RID: 138979 RVA: 0x004AD349 File Offset: 0x004AB549
		public static void AddAddBuffModeType(FlatBufferBuilder builder, TAddBuffMode addBuffModeType)
		{
			builder.AddByte(1, (byte)addBuffModeType, 0);
		}

		// Token: 0x06021EE4 RID: 138980 RVA: 0x004AD354 File Offset: 0x004AB554
		public static void AddAddBuffMode(FlatBufferBuilder builder, int addBuffModeOffset)
		{
			builder.AddOffset(2, addBuffModeOffset, 0);
		}

		// Token: 0x06021EE5 RID: 138981 RVA: 0x004AD35F File Offset: 0x004AB55F
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(3, buffId, 0L);
		}

		// Token: 0x06021EE6 RID: 138982 RVA: 0x004AD36B File Offset: 0x004AB56B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021EE7 RID: 138983 RVA: 0x004AD376 File Offset: 0x004AB576
		public static Offset<IBuffProducerComponent> EndIBuffProducerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBuffProducerComponent>(builder.EndTable());
		}

		// Token: 0x06021EE8 RID: 138984 RVA: 0x004AD384 File Offset: 0x004AB584
		public IBuffProducerComponentT UnPack()
		{
			IBuffProducerComponentT buffProducerComponentT = new IBuffProducerComponentT();
			this.UnPackTo(buffProducerComponentT);
			return buffProducerComponentT;
		}

		// Token: 0x06021EE9 RID: 138985 RVA: 0x004AD3A0 File Offset: 0x004AB5A0
		public void UnPackTo(IBuffProducerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AddBuffMode = new TAddBuffModeUnion();
			_o.AddBuffMode.Type = this.AddBuffModeType;
			switch (this.AddBuffModeType)
			{
			case TAddBuffMode.IAdsorbAddBuff:
				_o.AddBuffMode.Value = ((this.AddBuffMode<IAdsorbAddBuff>() != null) ? this.AddBuffMode<IAdsorbAddBuff>().Value.UnPack() : null);
				break;
			case TAddBuffMode.IFireBulletAddBuff:
				_o.AddBuffMode.Value = ((this.AddBuffMode<IFireBulletAddBuff>() != null) ? this.AddBuffMode<IFireBulletAddBuff>().Value.UnPack() : null);
				break;
			case TAddBuffMode.IImmediateAddBuff:
				_o.AddBuffMode.Value = ((this.AddBuffMode<IImmediateAddBuff>() != null) ? this.AddBuffMode<IImmediateAddBuff>().Value.UnPack() : null);
				break;
			}
			_o.BuffId = this.BuffId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021EEA RID: 138986 RVA: 0x004AD4B4 File Offset: 0x004AB6B4
		public static Offset<IBuffProducerComponent> Pack(FlatBufferBuilder builder, IBuffProducerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffProducerComponent>);
			}
			TAddBuffMode addBuffMode_type = (_o.AddBuffMode == null) ? TAddBuffMode.NONE : _o.AddBuffMode.Type;
			int addBuffModeOffset = (_o.AddBuffMode == null) ? 0 : TAddBuffModeUnion.Pack(builder, _o.AddBuffMode);
			return IBuffProducerComponent.CreateIBuffProducerComponent(builder, _o.Disabled, addBuffMode_type, addBuffModeOffset, _o.BuffId, _o.NullMask);
		}

		// Token: 0x0400E946 RID: 59718
		private Table __p;
	}
}
