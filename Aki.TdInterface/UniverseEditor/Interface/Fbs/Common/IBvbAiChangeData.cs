using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D1F RID: 23839
	public struct IBvbAiChangeData : IFlatbufferObject
	{
		// Token: 0x1700B2AA RID: 45738
		// (get) Token: 0x06028BC1 RID: 166849 RVA: 0x00598241 File Offset: 0x00596441
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028BC2 RID: 166850 RVA: 0x0059824E File Offset: 0x0059644E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028BC3 RID: 166851 RVA: 0x00598258 File Offset: 0x00596458
		public static IBvbAiChangeData GetRootAsIBvbAiChangeData(ByteBuffer _bb)
		{
			return IBvbAiChangeData.GetRootAsIBvbAiChangeData(_bb, default(IBvbAiChangeData));
		}

		// Token: 0x06028BC4 RID: 166852 RVA: 0x00598274 File Offset: 0x00596474
		public static IBvbAiChangeData GetRootAsIBvbAiChangeData(ByteBuffer _bb, IBvbAiChangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028BC5 RID: 166853 RVA: 0x00598291 File Offset: 0x00596491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028BC6 RID: 166854 RVA: 0x005982A0 File Offset: 0x005964A0
		public IBvbAiChangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2AB RID: 45739
		// (get) Token: 0x06028BC7 RID: 166855 RVA: 0x005982B0 File Offset: 0x005964B0
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B2AC RID: 45740
		// (get) Token: 0x06028BC8 RID: 166856 RVA: 0x005982EC File Offset: 0x005964EC
		public TVarRef HandCardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028BC9 RID: 166857 RVA: 0x00598328 File Offset: 0x00596528
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028BCA RID: 166858 RVA: 0x0059836C File Offset: 0x0059656C
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028BCB RID: 166859 RVA: 0x00598388 File Offset: 0x00596588
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028BCC RID: 166860 RVA: 0x005983A4 File Offset: 0x005965A4
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028BCD RID: 166861 RVA: 0x005983C0 File Offset: 0x005965C0
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028BCE RID: 166862 RVA: 0x005983DC File Offset: 0x005965DC
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x06028BCF RID: 166863 RVA: 0x005983F7 File Offset: 0x005965F7
		public static Offset<IBvbAiChangeData> CreateIBvbAiChangeData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0)
		{
			builder.StartTable(3);
			IBvbAiChangeData.AddHandCard(builder, HandCardOffset);
			IBvbAiChangeData.AddHandCardType(builder, HandCard_type);
			IBvbAiChangeData.AddType(builder, Type);
			return IBvbAiChangeData.EndIBvbAiChangeData(builder);
		}

		// Token: 0x06028BD0 RID: 166864 RVA: 0x0059841B File Offset: 0x0059661B
		public static void StartIBvbAiChangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028BD1 RID: 166865 RVA: 0x00598424 File Offset: 0x00596624
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028BD2 RID: 166866 RVA: 0x0059842F File Offset: 0x0059662F
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x06028BD3 RID: 166867 RVA: 0x0059843A File Offset: 0x0059663A
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x06028BD4 RID: 166868 RVA: 0x00598445 File Offset: 0x00596645
		public static Offset<IBvbAiChangeData> EndIBvbAiChangeData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiChangeData>(builder.EndTable());
		}

		// Token: 0x06028BD5 RID: 166869 RVA: 0x00598454 File Offset: 0x00596654
		public IBvbAiChangeDataT UnPack()
		{
			IBvbAiChangeDataT bvbAiChangeDataT = new IBvbAiChangeDataT();
			this.UnPackTo(bvbAiChangeDataT);
			return bvbAiChangeDataT;
		}

		// Token: 0x06028BD6 RID: 166870 RVA: 0x00598470 File Offset: 0x00596670
		public void UnPackTo(IBvbAiChangeDataT _o)
		{
			_o.Type = this.Type;
			_o.HandCard = new TVarRefUnion();
			_o.HandCard.Type = this.HandCardType;
			switch (this.HandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.HandCard.Value = ((this.HandCard<IConstVarRef>() != null) ? this.HandCard<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.HandCard.Value = ((this.HandCard<IGlobalVarRef>() != null) ? this.HandCard<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.HandCard.Value = ((this.HandCard<IOtherVarRef>() != null) ? this.HandCard<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.HandCard.Value = ((this.HandCard<ISelfVarRef>() != null) ? this.HandCard<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.HandCard.Value = ((this.HandCard<ISystemVarRef>() != null) ? this.HandCard<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028BD7 RID: 166871 RVA: 0x005985DC File Offset: 0x005967DC
		public static Offset<IBvbAiChangeData> Pack(FlatBufferBuilder builder, IBvbAiChangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiChangeData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			return IBvbAiChangeData.CreateIBvbAiChangeData(builder, _o.Type, handCard_type, handCardOffset);
		}

		// Token: 0x0400F6CC RID: 63180
		private Table __p;
	}
}
