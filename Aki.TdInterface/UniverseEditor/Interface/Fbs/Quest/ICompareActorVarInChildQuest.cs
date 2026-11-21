using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B4 RID: 16820
	public struct ICompareActorVarInChildQuest : IFlatbufferObject
	{
		// Token: 0x17007237 RID: 29239
		// (get) Token: 0x060173D5 RID: 95189 RVA: 0x00351362 File Offset: 0x0034F562
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060173D6 RID: 95190 RVA: 0x0035136F File Offset: 0x0034F56F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060173D7 RID: 95191 RVA: 0x00351378 File Offset: 0x0034F578
		public static ICompareActorVarInChildQuest GetRootAsICompareActorVarInChildQuest(ByteBuffer _bb)
		{
			return ICompareActorVarInChildQuest.GetRootAsICompareActorVarInChildQuest(_bb, default(ICompareActorVarInChildQuest));
		}

		// Token: 0x060173D8 RID: 95192 RVA: 0x00351394 File Offset: 0x0034F594
		public static ICompareActorVarInChildQuest GetRootAsICompareActorVarInChildQuest(ByteBuffer _bb, ICompareActorVarInChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060173D9 RID: 95193 RVA: 0x003513B1 File Offset: 0x0034F5B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060173DA RID: 95194 RVA: 0x003513C0 File Offset: 0x0034F5C0
		public ICompareActorVarInChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007238 RID: 29240
		// (get) Token: 0x060173DB RID: 95195 RVA: 0x003513D0 File Offset: 0x0034F5D0
		public IActorRef? ActorRef
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007239 RID: 29241
		// (get) Token: 0x060173DC RID: 95196 RVA: 0x00351430 File Offset: 0x0034F630
		public string Var1
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060173DD RID: 95197 RVA: 0x00351467 File Offset: 0x0034F667
		public Span<byte> GetVar1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060173DE RID: 95198 RVA: 0x00351476 File Offset: 0x0034F676
		public byte[] GetVar1Array()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700723A RID: 29242
		// (get) Token: 0x060173DF RID: 95199 RVA: 0x00351484 File Offset: 0x0034F684
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700723B RID: 29243
		// (get) Token: 0x060173E0 RID: 95200 RVA: 0x003514C0 File Offset: 0x0034F6C0
		public TVarRef Var2Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060173E1 RID: 95201 RVA: 0x00351500 File Offset: 0x0034F700
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060173E2 RID: 95202 RVA: 0x00351548 File Offset: 0x0034F748
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x060173E3 RID: 95203 RVA: 0x00351564 File Offset: 0x0034F764
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x060173E4 RID: 95204 RVA: 0x00351580 File Offset: 0x0034F780
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x060173E5 RID: 95205 RVA: 0x0035159C File Offset: 0x0034F79C
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x060173E6 RID: 95206 RVA: 0x003515B8 File Offset: 0x0034F7B8
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x060173E7 RID: 95207 RVA: 0x003515D3 File Offset: 0x0034F7D3
		public static Offset<ICompareActorVarInChildQuest> CreateICompareActorVarInChildQuest(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset Var1Offset = default(StringOffset), ECompare Compare = ECompare.Eq, TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0)
		{
			builder.StartTable(5);
			ICompareActorVarInChildQuest.AddVar2(builder, Var2Offset);
			ICompareActorVarInChildQuest.AddVar1(builder, Var1Offset);
			ICompareActorVarInChildQuest.AddActorRef(builder, ActorRefOffset);
			ICompareActorVarInChildQuest.AddVar2Type(builder, Var2_type);
			ICompareActorVarInChildQuest.AddCompare(builder, Compare);
			return ICompareActorVarInChildQuest.EndICompareActorVarInChildQuest(builder);
		}

		// Token: 0x060173E8 RID: 95208 RVA: 0x00351607 File Offset: 0x0034F807
		public static void StartICompareActorVarInChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060173E9 RID: 95209 RVA: 0x00351610 File Offset: 0x0034F810
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x060173EA RID: 95210 RVA: 0x00351620 File Offset: 0x0034F820
		public static void AddVar1(FlatBufferBuilder builder, StringOffset var1Offset)
		{
			builder.AddOffset(1, var1Offset.Value, 0);
		}

		// Token: 0x060173EB RID: 95211 RVA: 0x00351630 File Offset: 0x0034F830
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x060173EC RID: 95212 RVA: 0x0035163B File Offset: 0x0034F83B
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x060173ED RID: 95213 RVA: 0x00351646 File Offset: 0x0034F846
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x060173EE RID: 95214 RVA: 0x00351651 File Offset: 0x0034F851
		public static Offset<ICompareActorVarInChildQuest> EndICompareActorVarInChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompareActorVarInChildQuest>(builder.EndTable());
		}

		// Token: 0x060173EF RID: 95215 RVA: 0x00351660 File Offset: 0x0034F860
		public ICompareActorVarInChildQuestT UnPack()
		{
			ICompareActorVarInChildQuestT compareActorVarInChildQuestT = new ICompareActorVarInChildQuestT();
			this.UnPackTo(compareActorVarInChildQuestT);
			return compareActorVarInChildQuestT;
		}

		// Token: 0x060173F0 RID: 95216 RVA: 0x0035167C File Offset: 0x0034F87C
		public void UnPackTo(ICompareActorVarInChildQuestT _o)
		{
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.Var1 = this.Var1;
			_o.Compare = this.Compare;
			_o.Var2 = new TVarRefUnion();
			_o.Var2.Type = this.Var2Type;
			switch (this.Var2Type)
			{
			case TVarRef.IConstVarRef:
				_o.Var2.Value = ((this.Var2<IConstVarRef>() != null) ? this.Var2<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Var2.Value = ((this.Var2<IGlobalVarRef>() != null) ? this.Var2<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Var2.Value = ((this.Var2<IOtherVarRef>() != null) ? this.Var2<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Var2.Value = ((this.Var2<ISelfVarRef>() != null) ? this.Var2<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Var2.Value = ((this.Var2<ISystemVarRef>() != null) ? this.Var2<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060173F1 RID: 95217 RVA: 0x00351828 File Offset: 0x0034FA28
		public static Offset<ICompareActorVarInChildQuest> Pack(FlatBufferBuilder builder, ICompareActorVarInChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareActorVarInChildQuest>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			StringOffset var1Offset = (_o.Var1 == null) ? default(StringOffset) : builder.CreateString(_o.Var1);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			return ICompareActorVarInChildQuest.CreateICompareActorVarInChildQuest(builder, actorRefOffset, var1Offset, _o.Compare, var2_type, var2Offset);
		}

		// Token: 0x0400C057 RID: 49239
		private Table __p;
	}
}
