using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D9D RID: 15773
	public struct ICompareActorVarInChildQuest : IFlatbufferObject
	{
		// Token: 0x17006C7D RID: 27773
		// (get) Token: 0x06015E9D RID: 89757 RVA: 0x0032A036 File Offset: 0x00328236
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E9E RID: 89758 RVA: 0x0032A043 File Offset: 0x00328243
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E9F RID: 89759 RVA: 0x0032A04C File Offset: 0x0032824C
		public static ICompareActorVarInChildQuest GetRootAsICompareActorVarInChildQuest(ByteBuffer _bb)
		{
			return ICompareActorVarInChildQuest.GetRootAsICompareActorVarInChildQuest(_bb, default(ICompareActorVarInChildQuest));
		}

		// Token: 0x06015EA0 RID: 89760 RVA: 0x0032A068 File Offset: 0x00328268
		public static ICompareActorVarInChildQuest GetRootAsICompareActorVarInChildQuest(ByteBuffer _bb, ICompareActorVarInChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015EA1 RID: 89761 RVA: 0x0032A085 File Offset: 0x00328285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015EA2 RID: 89762 RVA: 0x0032A094 File Offset: 0x00328294
		public ICompareActorVarInChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C7E RID: 27774
		// (get) Token: 0x06015EA3 RID: 89763 RVA: 0x0032A0A4 File Offset: 0x003282A4
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

		// Token: 0x17006C7F RID: 27775
		// (get) Token: 0x06015EA4 RID: 89764 RVA: 0x0032A104 File Offset: 0x00328304
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

		// Token: 0x06015EA5 RID: 89765 RVA: 0x0032A13B File Offset: 0x0032833B
		public Span<byte> GetVar1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015EA6 RID: 89766 RVA: 0x0032A14A File Offset: 0x0032834A
		public byte[] GetVar1Array()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006C80 RID: 27776
		// (get) Token: 0x06015EA7 RID: 89767 RVA: 0x0032A158 File Offset: 0x00328358
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

		// Token: 0x17006C81 RID: 27777
		// (get) Token: 0x06015EA8 RID: 89768 RVA: 0x0032A194 File Offset: 0x00328394
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

		// Token: 0x06015EA9 RID: 89769 RVA: 0x0032A1D4 File Offset: 0x003283D4
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015EAA RID: 89770 RVA: 0x0032A21C File Offset: 0x0032841C
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x06015EAB RID: 89771 RVA: 0x0032A238 File Offset: 0x00328438
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x06015EAC RID: 89772 RVA: 0x0032A254 File Offset: 0x00328454
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x06015EAD RID: 89773 RVA: 0x0032A270 File Offset: 0x00328470
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x06015EAE RID: 89774 RVA: 0x0032A28C File Offset: 0x0032848C
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x06015EAF RID: 89775 RVA: 0x0032A2A7 File Offset: 0x003284A7
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

		// Token: 0x06015EB0 RID: 89776 RVA: 0x0032A2DB File Offset: 0x003284DB
		public static void StartICompareActorVarInChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015EB1 RID: 89777 RVA: 0x0032A2E4 File Offset: 0x003284E4
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x06015EB2 RID: 89778 RVA: 0x0032A2F4 File Offset: 0x003284F4
		public static void AddVar1(FlatBufferBuilder builder, StringOffset var1Offset)
		{
			builder.AddOffset(1, var1Offset.Value, 0);
		}

		// Token: 0x06015EB3 RID: 89779 RVA: 0x0032A304 File Offset: 0x00328504
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06015EB4 RID: 89780 RVA: 0x0032A30F File Offset: 0x0032850F
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x06015EB5 RID: 89781 RVA: 0x0032A31A File Offset: 0x0032851A
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x06015EB6 RID: 89782 RVA: 0x0032A325 File Offset: 0x00328525
		public static Offset<ICompareActorVarInChildQuest> EndICompareActorVarInChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompareActorVarInChildQuest>(builder.EndTable());
		}

		// Token: 0x06015EB7 RID: 89783 RVA: 0x0032A334 File Offset: 0x00328534
		public ICompareActorVarInChildQuestT UnPack()
		{
			ICompareActorVarInChildQuestT compareActorVarInChildQuestT = new ICompareActorVarInChildQuestT();
			this.UnPackTo(compareActorVarInChildQuestT);
			return compareActorVarInChildQuestT;
		}

		// Token: 0x06015EB8 RID: 89784 RVA: 0x0032A350 File Offset: 0x00328550
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

		// Token: 0x06015EB9 RID: 89785 RVA: 0x0032A4FC File Offset: 0x003286FC
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

		// Token: 0x0400B6AA RID: 46762
		private Table __p;
	}
}
