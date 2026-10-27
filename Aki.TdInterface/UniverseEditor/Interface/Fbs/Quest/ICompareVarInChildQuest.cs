using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA6 RID: 15782
	public struct ICompareVarInChildQuest : IFlatbufferObject
	{
		// Token: 0x17006C94 RID: 27796
		// (get) Token: 0x06015F04 RID: 89860 RVA: 0x0032AF94 File Offset: 0x00329194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F05 RID: 89861 RVA: 0x0032AFA1 File Offset: 0x003291A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F06 RID: 89862 RVA: 0x0032AFA8 File Offset: 0x003291A8
		public static ICompareVarInChildQuest GetRootAsICompareVarInChildQuest(ByteBuffer _bb)
		{
			return ICompareVarInChildQuest.GetRootAsICompareVarInChildQuest(_bb, default(ICompareVarInChildQuest));
		}

		// Token: 0x06015F07 RID: 89863 RVA: 0x0032AFC4 File Offset: 0x003291C4
		public static ICompareVarInChildQuest GetRootAsICompareVarInChildQuest(ByteBuffer _bb, ICompareVarInChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F08 RID: 89864 RVA: 0x0032AFE1 File Offset: 0x003291E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F09 RID: 89865 RVA: 0x0032AFF0 File Offset: 0x003291F0
		public ICompareVarInChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C95 RID: 27797
		// (get) Token: 0x06015F0A RID: 89866 RVA: 0x0032B000 File Offset: 0x00329200
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

		// Token: 0x06015F0B RID: 89867 RVA: 0x0032B03C File Offset: 0x0032923C
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015F0C RID: 89868 RVA: 0x0032B080 File Offset: 0x00329280
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x06015F0D RID: 89869 RVA: 0x0032B09C File Offset: 0x0032929C
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x06015F0E RID: 89870 RVA: 0x0032B0B8 File Offset: 0x003292B8
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x06015F0F RID: 89871 RVA: 0x0032B0D4 File Offset: 0x003292D4
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x06015F10 RID: 89872 RVA: 0x0032B0F0 File Offset: 0x003292F0
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x17006C96 RID: 27798
		// (get) Token: 0x06015F11 RID: 89873 RVA: 0x0032B10C File Offset: 0x0032930C
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

		// Token: 0x17006C97 RID: 27799
		// (get) Token: 0x06015F12 RID: 89874 RVA: 0x0032B148 File Offset: 0x00329348
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

		// Token: 0x06015F13 RID: 89875 RVA: 0x0032B188 File Offset: 0x00329388
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015F14 RID: 89876 RVA: 0x0032B1D0 File Offset: 0x003293D0
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x06015F15 RID: 89877 RVA: 0x0032B1EC File Offset: 0x003293EC
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x06015F16 RID: 89878 RVA: 0x0032B208 File Offset: 0x00329408
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x06015F17 RID: 89879 RVA: 0x0032B224 File Offset: 0x00329424
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x06015F18 RID: 89880 RVA: 0x0032B240 File Offset: 0x00329440
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x06015F19 RID: 89881 RVA: 0x0032B25B File Offset: 0x0032945B
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

		// Token: 0x06015F1A RID: 89882 RVA: 0x0032B28F File Offset: 0x0032948F
		public static void StartICompareVarInChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015F1B RID: 89883 RVA: 0x0032B298 File Offset: 0x00329498
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x06015F1C RID: 89884 RVA: 0x0032B2A3 File Offset: 0x003294A3
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x06015F1D RID: 89885 RVA: 0x0032B2AE File Offset: 0x003294AE
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06015F1E RID: 89886 RVA: 0x0032B2B9 File Offset: 0x003294B9
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x06015F1F RID: 89887 RVA: 0x0032B2C4 File Offset: 0x003294C4
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x06015F20 RID: 89888 RVA: 0x0032B2CF File Offset: 0x003294CF
		public static Offset<ICompareVarInChildQuest> EndICompareVarInChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarInChildQuest>(builder.EndTable());
		}

		// Token: 0x06015F21 RID: 89889 RVA: 0x0032B2DC File Offset: 0x003294DC
		public ICompareVarInChildQuestT UnPack()
		{
			ICompareVarInChildQuestT compareVarInChildQuestT = new ICompareVarInChildQuestT();
			this.UnPackTo(compareVarInChildQuestT);
			return compareVarInChildQuestT;
		}

		// Token: 0x06015F22 RID: 89890 RVA: 0x0032B2F8 File Offset: 0x003294F8
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

		// Token: 0x06015F23 RID: 89891 RVA: 0x0032B5C4 File Offset: 0x003297C4
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

		// Token: 0x0400B6B7 RID: 46775
		private Table __p;
	}
}
