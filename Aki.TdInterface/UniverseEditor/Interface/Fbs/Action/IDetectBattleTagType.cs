using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C23 RID: 27683
	public struct IDetectBattleTagType : IFlatbufferObject
	{
		// Token: 0x1700CAE6 RID: 51942
		// (get) Token: 0x0602FA45 RID: 195141 RVA: 0x0067DAE7 File Offset: 0x0067BCE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA46 RID: 195142 RVA: 0x0067DAF4 File Offset: 0x0067BCF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA47 RID: 195143 RVA: 0x0067DAFC File Offset: 0x0067BCFC
		public static IDetectBattleTagType GetRootAsIDetectBattleTagType(ByteBuffer _bb)
		{
			return IDetectBattleTagType.GetRootAsIDetectBattleTagType(_bb, default(IDetectBattleTagType));
		}

		// Token: 0x0602FA48 RID: 195144 RVA: 0x0067DB18 File Offset: 0x0067BD18
		public static IDetectBattleTagType GetRootAsIDetectBattleTagType(ByteBuffer _bb, IDetectBattleTagType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA49 RID: 195145 RVA: 0x0067DB35 File Offset: 0x0067BD35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA4A RID: 195146 RVA: 0x0067DB44 File Offset: 0x0067BD44
		public IDetectBattleTagType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAE7 RID: 51943
		// (get) Token: 0x0602FA4B RID: 195147 RVA: 0x0067DB54 File Offset: 0x0067BD54
		public EDetectBattleTagType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDetectBattleTagType.MonsterOnTheGround;
				}
				return (EDetectBattleTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA4C RID: 195148 RVA: 0x0067DB90 File Offset: 0x0067BD90
		public static Offset<IDetectBattleTagType> CreateIDetectBattleTagType(FlatBufferBuilder builder, EDetectBattleTagType Type = EDetectBattleTagType.MonsterOnTheGround)
		{
			builder.StartTable(1);
			IDetectBattleTagType.AddType(builder, Type);
			return IDetectBattleTagType.EndIDetectBattleTagType(builder);
		}

		// Token: 0x0602FA4D RID: 195149 RVA: 0x0067DBA6 File Offset: 0x0067BDA6
		public static void StartIDetectBattleTagType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA4E RID: 195150 RVA: 0x0067DBAF File Offset: 0x0067BDAF
		public static void AddType(FlatBufferBuilder builder, EDetectBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA4F RID: 195151 RVA: 0x0067DBBA File Offset: 0x0067BDBA
		public static Offset<IDetectBattleTagType> EndIDetectBattleTagType(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleTagType>(builder.EndTable());
		}

		// Token: 0x0602FA50 RID: 195152 RVA: 0x0067DBC8 File Offset: 0x0067BDC8
		public IDetectBattleTagTypeT UnPack()
		{
			IDetectBattleTagTypeT detectBattleTagTypeT = new IDetectBattleTagTypeT();
			this.UnPackTo(detectBattleTagTypeT);
			return detectBattleTagTypeT;
		}

		// Token: 0x0602FA51 RID: 195153 RVA: 0x0067DBE3 File Offset: 0x0067BDE3
		public void UnPackTo(IDetectBattleTagTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA52 RID: 195154 RVA: 0x0067DBF4 File Offset: 0x0067BDF4
		public static Offset<IDetectBattleTagType> Pack(FlatBufferBuilder builder, IDetectBattleTagTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleTagType>);
			}
			return IDetectBattleTagType.CreateIDetectBattleTagType(builder, _o.Type);
		}

		// Token: 0x04011A2B RID: 72235
		private Table __p;
	}
}
