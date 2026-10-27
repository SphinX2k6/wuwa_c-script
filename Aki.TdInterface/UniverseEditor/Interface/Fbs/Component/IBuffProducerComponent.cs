using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F31 RID: 20273
	public struct IBuffProducerComponent : IFlatbufferObject
	{
		// Token: 0x1700921F RID: 37407
		// (get) Token: 0x06020162 RID: 131426 RVA: 0x00476D70 File Offset: 0x00474F70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020163 RID: 131427 RVA: 0x00476D7D File Offset: 0x00474F7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020164 RID: 131428 RVA: 0x00476D84 File Offset: 0x00474F84
		public static IBuffProducerComponent GetRootAsIBuffProducerComponent(ByteBuffer _bb)
		{
			return IBuffProducerComponent.GetRootAsIBuffProducerComponent(_bb, default(IBuffProducerComponent));
		}

		// Token: 0x06020165 RID: 131429 RVA: 0x00476DA0 File Offset: 0x00474FA0
		public static IBuffProducerComponent GetRootAsIBuffProducerComponent(ByteBuffer _bb, IBuffProducerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020166 RID: 131430 RVA: 0x00476DBD File Offset: 0x00474FBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020167 RID: 131431 RVA: 0x00476DCC File Offset: 0x00474FCC
		public IBuffProducerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009220 RID: 37408
		// (get) Token: 0x06020168 RID: 131432 RVA: 0x00476DDC File Offset: 0x00474FDC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009221 RID: 37409
		// (get) Token: 0x06020169 RID: 131433 RVA: 0x00476E1C File Offset: 0x0047501C
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

		// Token: 0x0602016A RID: 131434 RVA: 0x00476E58 File Offset: 0x00475058
		public TTable? AddBuffMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602016B RID: 131435 RVA: 0x00476E9C File Offset: 0x0047509C
		public IAdsorbAddBuff AddBuffModeAsIAdsorbAddBuff()
		{
			return this.AddBuffMode<IAdsorbAddBuff>().Value;
		}

		// Token: 0x0602016C RID: 131436 RVA: 0x00476EB8 File Offset: 0x004750B8
		public IFireBulletAddBuff AddBuffModeAsIFireBulletAddBuff()
		{
			return this.AddBuffMode<IFireBulletAddBuff>().Value;
		}

		// Token: 0x0602016D RID: 131437 RVA: 0x00476ED4 File Offset: 0x004750D4
		public IImmediateAddBuff AddBuffModeAsIImmediateAddBuff()
		{
			return this.AddBuffMode<IImmediateAddBuff>().Value;
		}

		// Token: 0x17009222 RID: 37410
		// (get) Token: 0x0602016E RID: 131438 RVA: 0x00476EF0 File Offset: 0x004750F0
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

		// Token: 0x17009223 RID: 37411
		// (get) Token: 0x0602016F RID: 131439 RVA: 0x00476F30 File Offset: 0x00475130
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

		// Token: 0x06020170 RID: 131440 RVA: 0x00476F6D File Offset: 0x0047516D
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

		// Token: 0x06020171 RID: 131441 RVA: 0x00476FA1 File Offset: 0x004751A1
		public static void StartIBuffProducerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020172 RID: 131442 RVA: 0x00476FAA File Offset: 0x004751AA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020173 RID: 131443 RVA: 0x00476FB5 File Offset: 0x004751B5
		public static void AddAddBuffModeType(FlatBufferBuilder builder, TAddBuffMode addBuffModeType)
		{
			builder.AddByte(1, (byte)addBuffModeType, 0);
		}

		// Token: 0x06020174 RID: 131444 RVA: 0x00476FC0 File Offset: 0x004751C0
		public static void AddAddBuffMode(FlatBufferBuilder builder, int addBuffModeOffset)
		{
			builder.AddOffset(2, addBuffModeOffset, 0);
		}

		// Token: 0x06020175 RID: 131445 RVA: 0x00476FCB File Offset: 0x004751CB
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(3, buffId, 0L);
		}

		// Token: 0x06020176 RID: 131446 RVA: 0x00476FD7 File Offset: 0x004751D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020177 RID: 131447 RVA: 0x00476FE2 File Offset: 0x004751E2
		public static Offset<IBuffProducerComponent> EndIBuffProducerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBuffProducerComponent>(builder.EndTable());
		}

		// Token: 0x06020178 RID: 131448 RVA: 0x00476FF0 File Offset: 0x004751F0
		public IBuffProducerComponentT UnPack()
		{
			IBuffProducerComponentT buffProducerComponentT = new IBuffProducerComponentT();
			this.UnPackTo(buffProducerComponentT);
			return buffProducerComponentT;
		}

		// Token: 0x06020179 RID: 131449 RVA: 0x0047700C File Offset: 0x0047520C
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

		// Token: 0x0602017A RID: 131450 RVA: 0x00477120 File Offset: 0x00475320
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

		// Token: 0x0400DD97 RID: 56727
		private Table __p;
	}
}
