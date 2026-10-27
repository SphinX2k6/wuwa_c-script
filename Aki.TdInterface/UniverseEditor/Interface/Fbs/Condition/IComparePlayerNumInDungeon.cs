using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC2 RID: 19394
	public struct IComparePlayerNumInDungeon : IFlatbufferObject
	{
		// Token: 0x17008CD7 RID: 36055
		// (get) Token: 0x0601E99C RID: 125340 RVA: 0x00447929 File Offset: 0x00445B29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E99D RID: 125341 RVA: 0x00447936 File Offset: 0x00445B36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E99E RID: 125342 RVA: 0x00447940 File Offset: 0x00445B40
		public static IComparePlayerNumInDungeon GetRootAsIComparePlayerNumInDungeon(ByteBuffer _bb)
		{
			return IComparePlayerNumInDungeon.GetRootAsIComparePlayerNumInDungeon(_bb, default(IComparePlayerNumInDungeon));
		}

		// Token: 0x0601E99F RID: 125343 RVA: 0x0044795C File Offset: 0x00445B5C
		public static IComparePlayerNumInDungeon GetRootAsIComparePlayerNumInDungeon(ByteBuffer _bb, IComparePlayerNumInDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E9A0 RID: 125344 RVA: 0x00447979 File Offset: 0x00445B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E9A1 RID: 125345 RVA: 0x00447988 File Offset: 0x00445B88
		public IComparePlayerNumInDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CD8 RID: 36056
		// (get) Token: 0x0601E9A2 RID: 125346 RVA: 0x00447998 File Offset: 0x00445B98
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

		// Token: 0x17008CD9 RID: 36057
		// (get) Token: 0x0601E9A3 RID: 125347 RVA: 0x004479D4 File Offset: 0x00445BD4
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

		// Token: 0x17008CDA RID: 36058
		// (get) Token: 0x0601E9A4 RID: 125348 RVA: 0x00447A10 File Offset: 0x00445C10
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

		// Token: 0x0601E9A5 RID: 125349 RVA: 0x00447A4C File Offset: 0x00445C4C
		public TTable? CompareValue<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E9A6 RID: 125350 RVA: 0x00447A94 File Offset: 0x00445C94
		public IConstVarRef CompareValueAsIConstVarRef()
		{
			return this.CompareValue<IConstVarRef>().Value;
		}

		// Token: 0x0601E9A7 RID: 125351 RVA: 0x00447AB0 File Offset: 0x00445CB0
		public IGlobalVarRef CompareValueAsIGlobalVarRef()
		{
			return this.CompareValue<IGlobalVarRef>().Value;
		}

		// Token: 0x0601E9A8 RID: 125352 RVA: 0x00447ACC File Offset: 0x00445CCC
		public IOtherVarRef CompareValueAsIOtherVarRef()
		{
			return this.CompareValue<IOtherVarRef>().Value;
		}

		// Token: 0x0601E9A9 RID: 125353 RVA: 0x00447AE8 File Offset: 0x00445CE8
		public ISelfVarRef CompareValueAsISelfVarRef()
		{
			return this.CompareValue<ISelfVarRef>().Value;
		}

		// Token: 0x0601E9AA RID: 125354 RVA: 0x00447B04 File Offset: 0x00445D04
		public ISystemVarRef CompareValueAsISystemVarRef()
		{
			return this.CompareValue<ISystemVarRef>().Value;
		}

		// Token: 0x0601E9AB RID: 125355 RVA: 0x00447B1F File Offset: 0x00445D1F
		public static Offset<IComparePlayerNumInDungeon> CreateIComparePlayerNumInDungeon(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare CompareType = ECompare.Eq, TVarRef CompareValue_type = TVarRef.NONE, int CompareValueOffset = 0)
		{
			builder.StartTable(4);
			IComparePlayerNumInDungeon.AddCompareValue(builder, CompareValueOffset);
			IComparePlayerNumInDungeon.AddCompareValueType(builder, CompareValue_type);
			IComparePlayerNumInDungeon.AddCompareType(builder, CompareType);
			IComparePlayerNumInDungeon.AddType(builder, Type);
			return IComparePlayerNumInDungeon.EndIComparePlayerNumInDungeon(builder);
		}

		// Token: 0x0601E9AC RID: 125356 RVA: 0x00447B4B File Offset: 0x00445D4B
		public static void StartIComparePlayerNumInDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E9AD RID: 125357 RVA: 0x00447B54 File Offset: 0x00445D54
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E9AE RID: 125358 RVA: 0x00447B5F File Offset: 0x00445D5F
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x0601E9AF RID: 125359 RVA: 0x00447B6A File Offset: 0x00445D6A
		public static void AddCompareValueType(FlatBufferBuilder builder, TVarRef compareValueType)
		{
			builder.AddByte(2, (byte)compareValueType, 0);
		}

		// Token: 0x0601E9B0 RID: 125360 RVA: 0x00447B75 File Offset: 0x00445D75
		public static void AddCompareValue(FlatBufferBuilder builder, int compareValueOffset)
		{
			builder.AddOffset(3, compareValueOffset, 0);
		}

		// Token: 0x0601E9B1 RID: 125361 RVA: 0x00447B80 File Offset: 0x00445D80
		public static Offset<IComparePlayerNumInDungeon> EndIComparePlayerNumInDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IComparePlayerNumInDungeon>(builder.EndTable());
		}

		// Token: 0x0601E9B2 RID: 125362 RVA: 0x00447B90 File Offset: 0x00445D90
		public IComparePlayerNumInDungeonT UnPack()
		{
			IComparePlayerNumInDungeonT comparePlayerNumInDungeonT = new IComparePlayerNumInDungeonT();
			this.UnPackTo(comparePlayerNumInDungeonT);
			return comparePlayerNumInDungeonT;
		}

		// Token: 0x0601E9B3 RID: 125363 RVA: 0x00447BAC File Offset: 0x00445DAC
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

		// Token: 0x0601E9B4 RID: 125364 RVA: 0x00447D24 File Offset: 0x00445F24
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

		// Token: 0x0400D4AC RID: 54444
		private Table __p;
	}
}
