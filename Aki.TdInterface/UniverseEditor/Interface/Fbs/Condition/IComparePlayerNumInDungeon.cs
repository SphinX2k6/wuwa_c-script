using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050AC RID: 20652
	public struct IComparePlayerNumInDungeon : IFlatbufferObject
	{
		// Token: 0x170093F0 RID: 37872
		// (get) Token: 0x06020548 RID: 132424 RVA: 0x0047A48D File Offset: 0x0047868D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020549 RID: 132425 RVA: 0x0047A49A File Offset: 0x0047869A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602054A RID: 132426 RVA: 0x0047A4A4 File Offset: 0x004786A4
		public static IComparePlayerNumInDungeon GetRootAsIComparePlayerNumInDungeon(ByteBuffer _bb)
		{
			return IComparePlayerNumInDungeon.GetRootAsIComparePlayerNumInDungeon(_bb, default(IComparePlayerNumInDungeon));
		}

		// Token: 0x0602054B RID: 132427 RVA: 0x0047A4C0 File Offset: 0x004786C0
		public static IComparePlayerNumInDungeon GetRootAsIComparePlayerNumInDungeon(ByteBuffer _bb, IComparePlayerNumInDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602054C RID: 132428 RVA: 0x0047A4DD File Offset: 0x004786DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602054D RID: 132429 RVA: 0x0047A4EC File Offset: 0x004786EC
		public IComparePlayerNumInDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093F1 RID: 37873
		// (get) Token: 0x0602054E RID: 132430 RVA: 0x0047A4FC File Offset: 0x004786FC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093F2 RID: 37874
		// (get) Token: 0x0602054F RID: 132431 RVA: 0x0047A538 File Offset: 0x00478738
		public ECompare CompareType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093F3 RID: 37875
		// (get) Token: 0x06020550 RID: 132432 RVA: 0x0047A574 File Offset: 0x00478774
		public TVarRef CompareValueType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020551 RID: 132433 RVA: 0x0047A5B0 File Offset: 0x004787B0
		public TTable? CompareValue<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020552 RID: 132434 RVA: 0x0047A5F8 File Offset: 0x004787F8
		public IConstVarRef CompareValueAsIConstVarRef()
		{
			return this.CompareValue<IConstVarRef>().Value;
		}

		// Token: 0x06020553 RID: 132435 RVA: 0x0047A614 File Offset: 0x00478814
		public IGlobalVarRef CompareValueAsIGlobalVarRef()
		{
			return this.CompareValue<IGlobalVarRef>().Value;
		}

		// Token: 0x06020554 RID: 132436 RVA: 0x0047A630 File Offset: 0x00478830
		public IOtherVarRef CompareValueAsIOtherVarRef()
		{
			return this.CompareValue<IOtherVarRef>().Value;
		}

		// Token: 0x06020555 RID: 132437 RVA: 0x0047A64C File Offset: 0x0047884C
		public ISelfVarRef CompareValueAsISelfVarRef()
		{
			return this.CompareValue<ISelfVarRef>().Value;
		}

		// Token: 0x06020556 RID: 132438 RVA: 0x0047A668 File Offset: 0x00478868
		public ISystemVarRef CompareValueAsISystemVarRef()
		{
			return this.CompareValue<ISystemVarRef>().Value;
		}

		// Token: 0x06020557 RID: 132439 RVA: 0x0047A683 File Offset: 0x00478883
		public static Offset<IComparePlayerNumInDungeon> CreateIComparePlayerNumInDungeon(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare CompareType = ECompare.Eq, TVarRef CompareValue_type = TVarRef.NONE, int CompareValueOffset = 0)
		{
			builder.StartTable(4);
			IComparePlayerNumInDungeon.AddCompareValue(builder, CompareValueOffset);
			IComparePlayerNumInDungeon.AddCompareValueType(builder, CompareValue_type);
			IComparePlayerNumInDungeon.AddCompareType(builder, CompareType);
			IComparePlayerNumInDungeon.AddType(builder, Type);
			return IComparePlayerNumInDungeon.EndIComparePlayerNumInDungeon(builder);
		}

		// Token: 0x06020558 RID: 132440 RVA: 0x0047A6AF File Offset: 0x004788AF
		public static void StartIComparePlayerNumInDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020559 RID: 132441 RVA: 0x0047A6B8 File Offset: 0x004788B8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602055A RID: 132442 RVA: 0x0047A6C3 File Offset: 0x004788C3
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x0602055B RID: 132443 RVA: 0x0047A6CE File Offset: 0x004788CE
		public static void AddCompareValueType(FlatBufferBuilder builder, TVarRef compareValueType)
		{
			builder.AddByte(2, (byte)compareValueType, 0);
		}

		// Token: 0x0602055C RID: 132444 RVA: 0x0047A6D9 File Offset: 0x004788D9
		public static void AddCompareValue(FlatBufferBuilder builder, int compareValueOffset)
		{
			builder.AddOffset(3, compareValueOffset, 0);
		}

		// Token: 0x0602055D RID: 132445 RVA: 0x0047A6E4 File Offset: 0x004788E4
		public static Offset<IComparePlayerNumInDungeon> EndIComparePlayerNumInDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IComparePlayerNumInDungeon>(builder.EndTable());
		}

		// Token: 0x0602055E RID: 132446 RVA: 0x0047A6F4 File Offset: 0x004788F4
		public IComparePlayerNumInDungeonT UnPack()
		{
			IComparePlayerNumInDungeonT comparePlayerNumInDungeonT = new IComparePlayerNumInDungeonT();
			this.UnPackTo(comparePlayerNumInDungeonT);
			return comparePlayerNumInDungeonT;
		}

		// Token: 0x0602055F RID: 132447 RVA: 0x0047A710 File Offset: 0x00478910
		public void UnPackTo(IComparePlayerNumInDungeonT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.CompareValue = new TVarRefUnion();
			_o.CompareValue.Type = this.CompareValueType;
			switch (this.CompareValueType)
			{
			case TVarRef.IConstVarRef:
				_o.CompareValue.Value = ((this.CompareValue<IConstVarRef>() != null) ? this.CompareValue<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.CompareValue.Value = ((this.CompareValue<IGlobalVarRef>() != null) ? this.CompareValue<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.CompareValue.Value = ((this.CompareValue<IOtherVarRef>() != null) ? this.CompareValue<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.CompareValue.Value = ((this.CompareValue<ISelfVarRef>() != null) ? this.CompareValue<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.CompareValue.Value = ((this.CompareValue<ISystemVarRef>() != null) ? this.CompareValue<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06020560 RID: 132448 RVA: 0x0047A888 File Offset: 0x00478A88
		public static Offset<IComparePlayerNumInDungeon> Pack(FlatBufferBuilder builder, IComparePlayerNumInDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComparePlayerNumInDungeon>);
			}
			TVarRef compareValue_type = (_o.CompareValue == null) ? TVarRef.NONE : _o.CompareValue.Type;
			int compareValueOffset = (_o.CompareValue == null) ? 0 : TVarRefUnion.Pack(builder, _o.CompareValue);
			return IComparePlayerNumInDungeon.CreateIComparePlayerNumInDungeon(builder, _o.Type, _o.CompareType, compareValue_type, compareValueOffset);
		}

		// Token: 0x0400DFB1 RID: 57265
		private Table __p;
	}
}
