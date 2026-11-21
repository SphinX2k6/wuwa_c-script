using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007684 RID: 30340
	public struct IRoleTowerStrongEnemyWarning : IFlatbufferObject
	{
		// Token: 0x1700DEAC RID: 57004
		// (get) Token: 0x06035392 RID: 218002 RVA: 0x007247E9 File Offset: 0x007229E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035393 RID: 218003 RVA: 0x007247F6 File Offset: 0x007229F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035394 RID: 218004 RVA: 0x00724800 File Offset: 0x00722A00
		public static IRoleTowerStrongEnemyWarning GetRootAsIRoleTowerStrongEnemyWarning(ByteBuffer _bb)
		{
			return IRoleTowerStrongEnemyWarning.GetRootAsIRoleTowerStrongEnemyWarning(_bb, default(IRoleTowerStrongEnemyWarning));
		}

		// Token: 0x06035395 RID: 218005 RVA: 0x0072481C File Offset: 0x00722A1C
		public static IRoleTowerStrongEnemyWarning GetRootAsIRoleTowerStrongEnemyWarning(ByteBuffer _bb, IRoleTowerStrongEnemyWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035396 RID: 218006 RVA: 0x00724839 File Offset: 0x00722A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035397 RID: 218007 RVA: 0x00724848 File Offset: 0x00722A48
		public IRoleTowerStrongEnemyWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEAD RID: 57005
		// (get) Token: 0x06035398 RID: 218008 RVA: 0x00724858 File Offset: 0x00722A58
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DEAE RID: 57006
		// (get) Token: 0x06035399 RID: 218009 RVA: 0x00724894 File Offset: 0x00722A94
		public string TidMainText
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

		// Token: 0x0603539A RID: 218010 RVA: 0x007248CB File Offset: 0x00722ACB
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603539B RID: 218011 RVA: 0x007248DA File Offset: 0x00722ADA
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603539C RID: 218012 RVA: 0x007248E8 File Offset: 0x00722AE8
		public static Offset<IRoleTowerStrongEnemyWarning> CreateIRoleTowerStrongEnemyWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRoleTowerStrongEnemyWarning.AddTidMainText(builder, TidMainTextOffset);
			IRoleTowerStrongEnemyWarning.AddType(builder, Type);
			return IRoleTowerStrongEnemyWarning.EndIRoleTowerStrongEnemyWarning(builder);
		}

		// Token: 0x0603539D RID: 218013 RVA: 0x00724905 File Offset: 0x00722B05
		public static void StartIRoleTowerStrongEnemyWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603539E RID: 218014 RVA: 0x0072490E File Offset: 0x00722B0E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603539F RID: 218015 RVA: 0x00724919 File Offset: 0x00722B19
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x060353A0 RID: 218016 RVA: 0x00724929 File Offset: 0x00722B29
		public static Offset<IRoleTowerStrongEnemyWarning> EndIRoleTowerStrongEnemyWarning(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerStrongEnemyWarning>(builder.EndTable());
		}

		// Token: 0x060353A1 RID: 218017 RVA: 0x00724938 File Offset: 0x00722B38
		public IRoleTowerStrongEnemyWarningT UnPack()
		{
			IRoleTowerStrongEnemyWarningT roleTowerStrongEnemyWarningT = new IRoleTowerStrongEnemyWarningT();
			this.UnPackTo(roleTowerStrongEnemyWarningT);
			return roleTowerStrongEnemyWarningT;
		}

		// Token: 0x060353A2 RID: 218018 RVA: 0x00724953 File Offset: 0x00722B53
		public void UnPackTo(IRoleTowerStrongEnemyWarningT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
		}

		// Token: 0x060353A3 RID: 218019 RVA: 0x00724970 File Offset: 0x00722B70
		public static Offset<IRoleTowerStrongEnemyWarning> Pack(FlatBufferBuilder builder, IRoleTowerStrongEnemyWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerStrongEnemyWarning>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			return IRoleTowerStrongEnemyWarning.CreateIRoleTowerStrongEnemyWarning(builder, _o.Type, tidMainTextOffset);
		}

		// Token: 0x04012877 RID: 75895
		private Table __p;
	}
}
