using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065BB RID: 26043
	public struct IDetectBattleTagType : IFlatbufferObject
	{
		// Token: 0x1700C157 RID: 49495
		// (get) Token: 0x0602D2C1 RID: 185025 RVA: 0x00631923 File Offset: 0x0062FB23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D2C2 RID: 185026 RVA: 0x00631930 File Offset: 0x0062FB30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D2C3 RID: 185027 RVA: 0x00631938 File Offset: 0x0062FB38
		public static IDetectBattleTagType GetRootAsIDetectBattleTagType(ByteBuffer _bb)
		{
			return IDetectBattleTagType.GetRootAsIDetectBattleTagType(_bb, default(IDetectBattleTagType));
		}

		// Token: 0x0602D2C4 RID: 185028 RVA: 0x00631954 File Offset: 0x0062FB54
		public static IDetectBattleTagType GetRootAsIDetectBattleTagType(ByteBuffer _bb, IDetectBattleTagType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D2C5 RID: 185029 RVA: 0x00631971 File Offset: 0x0062FB71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D2C6 RID: 185030 RVA: 0x00631980 File Offset: 0x0062FB80
		public IDetectBattleTagType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C158 RID: 49496
		// (get) Token: 0x0602D2C7 RID: 185031 RVA: 0x00631990 File Offset: 0x0062FB90
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

		// Token: 0x0602D2C8 RID: 185032 RVA: 0x006319CC File Offset: 0x0062FBCC
		public static Offset<IDetectBattleTagType> CreateIDetectBattleTagType(FlatBufferBuilder builder, EDetectBattleTagType Type = EDetectBattleTagType.MonsterOnTheGround)
		{
			builder.StartTable(1);
			IDetectBattleTagType.AddType(builder, Type);
			return IDetectBattleTagType.EndIDetectBattleTagType(builder);
		}

		// Token: 0x0602D2C9 RID: 185033 RVA: 0x006319E2 File Offset: 0x0062FBE2
		public static void StartIDetectBattleTagType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D2CA RID: 185034 RVA: 0x006319EB File Offset: 0x0062FBEB
		public static void AddType(FlatBufferBuilder builder, EDetectBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D2CB RID: 185035 RVA: 0x006319F6 File Offset: 0x0062FBF6
		public static Offset<IDetectBattleTagType> EndIDetectBattleTagType(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleTagType>(builder.EndTable());
		}

		// Token: 0x0602D2CC RID: 185036 RVA: 0x00631A04 File Offset: 0x0062FC04
		public IDetectBattleTagTypeT UnPack()
		{
			IDetectBattleTagTypeT detectBattleTagTypeT = new IDetectBattleTagTypeT();
			this.UnPackTo(detectBattleTagTypeT);
			return detectBattleTagTypeT;
		}

		// Token: 0x0602D2CD RID: 185037 RVA: 0x00631A1F File Offset: 0x0062FC1F
		public void UnPackTo(IDetectBattleTagTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D2CE RID: 185038 RVA: 0x00631A30 File Offset: 0x0062FC30
		public static Offset<IDetectBattleTagType> Pack(FlatBufferBuilder builder, IDetectBattleTagTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleTagType>);
			}
			return IDetectBattleTagType.CreateIDetectBattleTagType(builder, _o.Type);
		}

		// Token: 0x04010C19 RID: 68633
		private Table __p;
	}
}
