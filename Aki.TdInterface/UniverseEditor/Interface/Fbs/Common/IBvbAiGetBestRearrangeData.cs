using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006368 RID: 25448
	public struct IBvbAiGetBestRearrangeData : IFlatbufferObject
	{
		// Token: 0x1700BC33 RID: 48179
		// (get) Token: 0x0602B2FF RID: 176895 RVA: 0x005E3178 File Offset: 0x005E1378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B300 RID: 176896 RVA: 0x005E3185 File Offset: 0x005E1385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B301 RID: 176897 RVA: 0x005E318C File Offset: 0x005E138C
		public static IBvbAiGetBestRearrangeData GetRootAsIBvbAiGetBestRearrangeData(ByteBuffer _bb)
		{
			return IBvbAiGetBestRearrangeData.GetRootAsIBvbAiGetBestRearrangeData(_bb, default(IBvbAiGetBestRearrangeData));
		}

		// Token: 0x0602B302 RID: 176898 RVA: 0x005E31A8 File Offset: 0x005E13A8
		public static IBvbAiGetBestRearrangeData GetRootAsIBvbAiGetBestRearrangeData(ByteBuffer _bb, IBvbAiGetBestRearrangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B303 RID: 176899 RVA: 0x005E31C5 File Offset: 0x005E13C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B304 RID: 176900 RVA: 0x005E31D4 File Offset: 0x005E13D4
		public IBvbAiGetBestRearrangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC34 RID: 48180
		// (get) Token: 0x0602B305 RID: 176901 RVA: 0x005E31E4 File Offset: 0x005E13E4
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

		// Token: 0x1700BC35 RID: 48181
		// (get) Token: 0x0602B306 RID: 176902 RVA: 0x005E3220 File Offset: 0x005E1420
		public TVarRef BoardCardStoredType
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

		// Token: 0x0602B307 RID: 176903 RVA: 0x005E325C File Offset: 0x005E145C
		public TTable? BoardCardStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B308 RID: 176904 RVA: 0x005E32A0 File Offset: 0x005E14A0
		public IConstVarRef BoardCardStoredAsIConstVarRef()
		{
			return this.BoardCardStored<IConstVarRef>().Value;
		}

		// Token: 0x0602B309 RID: 176905 RVA: 0x005E32BC File Offset: 0x005E14BC
		public IGlobalVarRef BoardCardStoredAsIGlobalVarRef()
		{
			return this.BoardCardStored<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B30A RID: 176906 RVA: 0x005E32D8 File Offset: 0x005E14D8
		public IOtherVarRef BoardCardStoredAsIOtherVarRef()
		{
			return this.BoardCardStored<IOtherVarRef>().Value;
		}

		// Token: 0x0602B30B RID: 176907 RVA: 0x005E32F4 File Offset: 0x005E14F4
		public ISelfVarRef BoardCardStoredAsISelfVarRef()
		{
			return this.BoardCardStored<ISelfVarRef>().Value;
		}

		// Token: 0x0602B30C RID: 176908 RVA: 0x005E3310 File Offset: 0x005E1510
		public ISystemVarRef BoardCardStoredAsISystemVarRef()
		{
			return this.BoardCardStored<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC36 RID: 48182
		// (get) Token: 0x0602B30D RID: 176909 RVA: 0x005E332C File Offset: 0x005E152C
		public TVarRef BoardPosStoredType
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

		// Token: 0x0602B30E RID: 176910 RVA: 0x005E336C File Offset: 0x005E156C
		public TTable? BoardPosStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B30F RID: 176911 RVA: 0x005E33B4 File Offset: 0x005E15B4
		public IConstVarRef BoardPosStoredAsIConstVarRef()
		{
			return this.BoardPosStored<IConstVarRef>().Value;
		}

		// Token: 0x0602B310 RID: 176912 RVA: 0x005E33D0 File Offset: 0x005E15D0
		public IGlobalVarRef BoardPosStoredAsIGlobalVarRef()
		{
			return this.BoardPosStored<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B311 RID: 176913 RVA: 0x005E33EC File Offset: 0x005E15EC
		public IOtherVarRef BoardPosStoredAsIOtherVarRef()
		{
			return this.BoardPosStored<IOtherVarRef>().Value;
		}

		// Token: 0x0602B312 RID: 176914 RVA: 0x005E3408 File Offset: 0x005E1608
		public ISelfVarRef BoardPosStoredAsISelfVarRef()
		{
			return this.BoardPosStored<ISelfVarRef>().Value;
		}

		// Token: 0x0602B313 RID: 176915 RVA: 0x005E3424 File Offset: 0x005E1624
		public ISystemVarRef BoardPosStoredAsISystemVarRef()
		{
			return this.BoardPosStored<ISystemVarRef>().Value;
		}

		// Token: 0x0602B314 RID: 176916 RVA: 0x005E343F File Offset: 0x005E163F
		public static Offset<IBvbAiGetBestRearrangeData> CreateIBvbAiGetBestRearrangeData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCardStored_type = TVarRef.NONE, int BoardCardStoredOffset = 0, TVarRef BoardPosStored_type = TVarRef.NONE, int BoardPosStoredOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiGetBestRearrangeData.AddBoardPosStored(builder, BoardPosStoredOffset);
			IBvbAiGetBestRearrangeData.AddBoardCardStored(builder, BoardCardStoredOffset);
			IBvbAiGetBestRearrangeData.AddBoardPosStoredType(builder, BoardPosStored_type);
			IBvbAiGetBestRearrangeData.AddBoardCardStoredType(builder, BoardCardStored_type);
			IBvbAiGetBestRearrangeData.AddType(builder, Type);
			return IBvbAiGetBestRearrangeData.EndIBvbAiGetBestRearrangeData(builder);
		}

		// Token: 0x0602B315 RID: 176917 RVA: 0x005E3473 File Offset: 0x005E1673
		public static void StartIBvbAiGetBestRearrangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B316 RID: 176918 RVA: 0x005E347C File Offset: 0x005E167C
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B317 RID: 176919 RVA: 0x005E3487 File Offset: 0x005E1687
		public static void AddBoardCardStoredType(FlatBufferBuilder builder, TVarRef boardCardStoredType)
		{
			builder.AddByte(1, (byte)boardCardStoredType, 0);
		}

		// Token: 0x0602B318 RID: 176920 RVA: 0x005E3492 File Offset: 0x005E1692
		public static void AddBoardCardStored(FlatBufferBuilder builder, int boardCardStoredOffset)
		{
			builder.AddOffset(2, boardCardStoredOffset, 0);
		}

		// Token: 0x0602B319 RID: 176921 RVA: 0x005E349D File Offset: 0x005E169D
		public static void AddBoardPosStoredType(FlatBufferBuilder builder, TVarRef boardPosStoredType)
		{
			builder.AddByte(3, (byte)boardPosStoredType, 0);
		}

		// Token: 0x0602B31A RID: 176922 RVA: 0x005E34A8 File Offset: 0x005E16A8
		public static void AddBoardPosStored(FlatBufferBuilder builder, int boardPosStoredOffset)
		{
			builder.AddOffset(4, boardPosStoredOffset, 0);
		}

		// Token: 0x0602B31B RID: 176923 RVA: 0x005E34B3 File Offset: 0x005E16B3
		public static Offset<IBvbAiGetBestRearrangeData> EndIBvbAiGetBestRearrangeData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestRearrangeData>(builder.EndTable());
		}

		// Token: 0x0602B31C RID: 176924 RVA: 0x005E34C0 File Offset: 0x005E16C0
		public IBvbAiGetBestRearrangeDataT UnPack()
		{
			IBvbAiGetBestRearrangeDataT bvbAiGetBestRearrangeDataT = new IBvbAiGetBestRearrangeDataT();
			this.UnPackTo(bvbAiGetBestRearrangeDataT);
			return bvbAiGetBestRearrangeDataT;
		}

		// Token: 0x0602B31D RID: 176925 RVA: 0x005E34DC File Offset: 0x005E16DC
		public void UnPackTo(IBvbAiGetBestRearrangeDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCardStored = new TVarRefUnion();
			_o.BoardCardStored.Type = this.BoardCardStoredType;
			switch (this.BoardCardStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IConstVarRef>() != null) ? this.BoardCardStored<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IGlobalVarRef>() != null) ? this.BoardCardStored<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IOtherVarRef>() != null) ? this.BoardCardStored<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISelfVarRef>() != null) ? this.BoardCardStored<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISystemVarRef>() != null) ? this.BoardCardStored<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardPosStored = new TVarRefUnion();
			_o.BoardPosStored.Type = this.BoardPosStoredType;
			switch (this.BoardPosStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IConstVarRef>() != null) ? this.BoardPosStored<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IGlobalVarRef>() != null) ? this.BoardPosStored<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IOtherVarRef>() != null) ? this.BoardPosStored<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<ISelfVarRef>() != null) ? this.BoardPosStored<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<ISystemVarRef>() != null) ? this.BoardPosStored<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B31E RID: 176926 RVA: 0x005E37A8 File Offset: 0x005E19A8
		public static Offset<IBvbAiGetBestRearrangeData> Pack(FlatBufferBuilder builder, IBvbAiGetBestRearrangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiGetBestRearrangeData>);
			}
			TVarRef boardCardStored_type = (_o.BoardCardStored == null) ? TVarRef.NONE : _o.BoardCardStored.Type;
			int boardCardStoredOffset = (_o.BoardCardStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCardStored);
			TVarRef boardPosStored_type = (_o.BoardPosStored == null) ? TVarRef.NONE : _o.BoardPosStored.Type;
			int boardPosStoredOffset = (_o.BoardPosStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPosStored);
			return IBvbAiGetBestRearrangeData.CreateIBvbAiGetBestRearrangeData(builder, _o.Type, boardCardStored_type, boardCardStoredOffset, boardPosStored_type, boardPosStoredOffset);
		}

		// Token: 0x04010435 RID: 66613
		private Table __p;
	}
}
