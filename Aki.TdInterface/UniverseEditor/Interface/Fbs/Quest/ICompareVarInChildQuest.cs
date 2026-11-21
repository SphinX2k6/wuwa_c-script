using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BD RID: 16829
	public struct ICompareVarInChildQuest : IFlatbufferObject
	{
		// Token: 0x1700724E RID: 29262
		// (get) Token: 0x0601743C RID: 95292 RVA: 0x003522C0 File Offset: 0x003504C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601743D RID: 95293 RVA: 0x003522CD File Offset: 0x003504CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601743E RID: 95294 RVA: 0x003522D4 File Offset: 0x003504D4
		public static ICompareVarInChildQuest GetRootAsICompareVarInChildQuest(ByteBuffer _bb)
		{
			return ICompareVarInChildQuest.GetRootAsICompareVarInChildQuest(_bb, default(ICompareVarInChildQuest));
		}

		// Token: 0x0601743F RID: 95295 RVA: 0x003522F0 File Offset: 0x003504F0
		public static ICompareVarInChildQuest GetRootAsICompareVarInChildQuest(ByteBuffer _bb, ICompareVarInChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017440 RID: 95296 RVA: 0x0035230D File Offset: 0x0035050D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017441 RID: 95297 RVA: 0x0035231C File Offset: 0x0035051C
		public ICompareVarInChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700724F RID: 29263
		// (get) Token: 0x06017442 RID: 95298 RVA: 0x0035232C File Offset: 0x0035052C
		public TVarRef Var1Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017443 RID: 95299 RVA: 0x00352368 File Offset: 0x00350568
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017444 RID: 95300 RVA: 0x003523AC File Offset: 0x003505AC
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x06017445 RID: 95301 RVA: 0x003523C8 File Offset: 0x003505C8
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x06017446 RID: 95302 RVA: 0x003523E4 File Offset: 0x003505E4
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x06017447 RID: 95303 RVA: 0x00352400 File Offset: 0x00350600
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x06017448 RID: 95304 RVA: 0x0035241C File Offset: 0x0035061C
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x17007250 RID: 29264
		// (get) Token: 0x06017449 RID: 95305 RVA: 0x00352438 File Offset: 0x00350638
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

		// Token: 0x17007251 RID: 29265
		// (get) Token: 0x0601744A RID: 95306 RVA: 0x00352474 File Offset: 0x00350674
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

		// Token: 0x0601744B RID: 95307 RVA: 0x003524B4 File Offset: 0x003506B4
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601744C RID: 95308 RVA: 0x003524FC File Offset: 0x003506FC
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0601744D RID: 95309 RVA: 0x00352518 File Offset: 0x00350718
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0601744E RID: 95310 RVA: 0x00352534 File Offset: 0x00350734
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0601744F RID: 95311 RVA: 0x00352550 File Offset: 0x00350750
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x06017450 RID: 95312 RVA: 0x0035256C File Offset: 0x0035076C
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x06017451 RID: 95313 RVA: 0x00352587 File Offset: 0x00350787
		public static Offset<ICompareVarInChildQuest> CreateICompareVarInChildQuest(FlatBufferBuilder builder, TVarRef Var1_type = TVarRef.NONE, int Var1Offset = 0, ECompare Compare = ECompare.Eq, TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0)
		{
			builder.StartTable(5);
			ICompareVarInChildQuest.AddVar2(builder, Var2Offset);
			ICompareVarInChildQuest.AddVar1(builder, Var1Offset);
			ICompareVarInChildQuest.AddVar2Type(builder, Var2_type);
			ICompareVarInChildQuest.AddCompare(builder, Compare);
			ICompareVarInChildQuest.AddVar1Type(builder, Var1_type);
			return ICompareVarInChildQuest.EndICompareVarInChildQuest(builder);
		}

		// Token: 0x06017452 RID: 95314 RVA: 0x003525BB File Offset: 0x003507BB
		public static void StartICompareVarInChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017453 RID: 95315 RVA: 0x003525C4 File Offset: 0x003507C4
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x06017454 RID: 95316 RVA: 0x003525CF File Offset: 0x003507CF
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x06017455 RID: 95317 RVA: 0x003525DA File Offset: 0x003507DA
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06017456 RID: 95318 RVA: 0x003525E5 File Offset: 0x003507E5
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x06017457 RID: 95319 RVA: 0x003525F0 File Offset: 0x003507F0
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x06017458 RID: 95320 RVA: 0x003525FB File Offset: 0x003507FB
		public static Offset<ICompareVarInChildQuest> EndICompareVarInChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarInChildQuest>(builder.EndTable());
		}

		// Token: 0x06017459 RID: 95321 RVA: 0x00352608 File Offset: 0x00350808
		public ICompareVarInChildQuestT UnPack()
		{
			ICompareVarInChildQuestT compareVarInChildQuestT = new ICompareVarInChildQuestT();
			this.UnPackTo(compareVarInChildQuestT);
			return compareVarInChildQuestT;
		}

		// Token: 0x0601745A RID: 95322 RVA: 0x00352624 File Offset: 0x00350824
		public void UnPackTo(ICompareVarInChildQuestT _o)
		{
			_o.Var1 = new TVarRefUnion();
			_o.Var1.Type = this.Var1Type;
			switch (this.Var1Type)
			{
			case TVarRef.IConstVarRef:
				_o.Var1.Value = ((this.Var1<IConstVarRef>() != null) ? this.Var1<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var1.Value = ((this.Var1<IGlobalVarRef>() != null) ? this.Var1<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var1.Value = ((this.Var1<IOtherVarRef>() != null) ? this.Var1<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var1.Value = ((this.Var1<ISelfVarRef>() != null) ? this.Var1<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var1.Value = ((this.Var1<ISystemVarRef>() != null) ? this.Var1<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
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

		// Token: 0x0601745B RID: 95323 RVA: 0x003528F0 File Offset: 0x00350AF0
		public static Offset<ICompareVarInChildQuest> Pack(FlatBufferBuilder builder, ICompareVarInChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareVarInChildQuest>);
			}
			TVarRef var1_type = (_o.Var1 == null) ? TVarRef.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var1);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			return ICompareVarInChildQuest.CreateICompareVarInChildQuest(builder, var1_type, var1Offset, _o.Compare, var2_type, var2Offset);
		}

		// Token: 0x0400C064 RID: 49252
		private Table __p;
	}
}
