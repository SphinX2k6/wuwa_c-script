using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B2 RID: 26034
	public struct IDetectBattleStateType : IFlatbufferObject
	{
		// Token: 0x1700C149 RID: 49481
		// (get) Token: 0x0602D285 RID: 184965 RVA: 0x006312FD File Offset: 0x0062F4FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D286 RID: 184966 RVA: 0x0063130A File Offset: 0x0062F50A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D287 RID: 184967 RVA: 0x00631314 File Offset: 0x0062F514
		public static IDetectBattleStateType GetRootAsIDetectBattleStateType(ByteBuffer _bb)
		{
			return IDetectBattleStateType.GetRootAsIDetectBattleStateType(_bb, default(IDetectBattleStateType));
		}

		// Token: 0x0602D288 RID: 184968 RVA: 0x00631330 File Offset: 0x0062F530
		public static IDetectBattleStateType GetRootAsIDetectBattleStateType(ByteBuffer _bb, IDetectBattleStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D289 RID: 184969 RVA: 0x0063134D File Offset: 0x0062F54D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D28A RID: 184970 RVA: 0x0063135C File Offset: 0x0062F55C
		public IDetectBattleStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C14A RID: 49482
		// (get) Token: 0x0602D28B RID: 184971 RVA: 0x0063136C File Offset: 0x0062F56C
		public EDetectBattleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDetectBattleConditionType.DetectBattleTag;
				}
				return (EDetectBattleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D28C RID: 184972 RVA: 0x006313A8 File Offset: 0x0062F5A8
		public static Offset<IDetectBattleStateType> CreateIDetectBattleStateType(FlatBufferBuilder builder, EDetectBattleConditionType Type = EDetectBattleConditionType.DetectBattleTag)
		{
			builder.StartTable(1);
			IDetectBattleStateType.AddType(builder, Type);
			return IDetectBattleStateType.EndIDetectBattleStateType(builder);
		}

		// Token: 0x0602D28D RID: 184973 RVA: 0x006313BE File Offset: 0x0062F5BE
		public static void StartIDetectBattleStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D28E RID: 184974 RVA: 0x006313C7 File Offset: 0x0062F5C7
		public static void AddType(FlatBufferBuilder builder, EDetectBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D28F RID: 184975 RVA: 0x006313D2 File Offset: 0x0062F5D2
		public static Offset<IDetectBattleStateType> EndIDetectBattleStateType(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleStateType>(builder.EndTable());
		}

		// Token: 0x0602D290 RID: 184976 RVA: 0x006313E0 File Offset: 0x0062F5E0
		public IDetectBattleStateTypeT UnPack()
		{
			IDetectBattleStateTypeT detectBattleStateTypeT = new IDetectBattleStateTypeT();
			this.UnPackTo(detectBattleStateTypeT);
			return detectBattleStateTypeT;
		}

		// Token: 0x0602D291 RID: 184977 RVA: 0x006313FB File Offset: 0x0062F5FB
		public void UnPackTo(IDetectBattleStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D292 RID: 184978 RVA: 0x0063140C File Offset: 0x0062F60C
		public static Offset<IDetectBattleStateType> Pack(FlatBufferBuilder builder, IDetectBattleStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleStateType>);
			}
			return IDetectBattleStateType.CreateIDetectBattleStateType(builder, _o.Type);
		}

		// Token: 0x04010C0C RID: 68620
		private Table __p;
	}
}
