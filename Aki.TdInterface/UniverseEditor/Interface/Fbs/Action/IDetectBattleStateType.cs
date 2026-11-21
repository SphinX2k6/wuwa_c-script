using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1A RID: 27674
	public struct IDetectBattleStateType : IFlatbufferObject
	{
		// Token: 0x1700CAD8 RID: 51928
		// (get) Token: 0x0602FA09 RID: 195081 RVA: 0x0067D4C1 File Offset: 0x0067B6C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA0A RID: 195082 RVA: 0x0067D4CE File Offset: 0x0067B6CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA0B RID: 195083 RVA: 0x0067D4D8 File Offset: 0x0067B6D8
		public static IDetectBattleStateType GetRootAsIDetectBattleStateType(ByteBuffer _bb)
		{
			return IDetectBattleStateType.GetRootAsIDetectBattleStateType(_bb, default(IDetectBattleStateType));
		}

		// Token: 0x0602FA0C RID: 195084 RVA: 0x0067D4F4 File Offset: 0x0067B6F4
		public static IDetectBattleStateType GetRootAsIDetectBattleStateType(ByteBuffer _bb, IDetectBattleStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA0D RID: 195085 RVA: 0x0067D511 File Offset: 0x0067B711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA0E RID: 195086 RVA: 0x0067D520 File Offset: 0x0067B720
		public IDetectBattleStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAD9 RID: 51929
		// (get) Token: 0x0602FA0F RID: 195087 RVA: 0x0067D530 File Offset: 0x0067B730
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

		// Token: 0x0602FA10 RID: 195088 RVA: 0x0067D56C File Offset: 0x0067B76C
		public static Offset<IDetectBattleStateType> CreateIDetectBattleStateType(FlatBufferBuilder builder, EDetectBattleConditionType Type = EDetectBattleConditionType.DetectBattleTag)
		{
			builder.StartTable(1);
			IDetectBattleStateType.AddType(builder, Type);
			return IDetectBattleStateType.EndIDetectBattleStateType(builder);
		}

		// Token: 0x0602FA11 RID: 195089 RVA: 0x0067D582 File Offset: 0x0067B782
		public static void StartIDetectBattleStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA12 RID: 195090 RVA: 0x0067D58B File Offset: 0x0067B78B
		public static void AddType(FlatBufferBuilder builder, EDetectBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA13 RID: 195091 RVA: 0x0067D596 File Offset: 0x0067B796
		public static Offset<IDetectBattleStateType> EndIDetectBattleStateType(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleStateType>(builder.EndTable());
		}

		// Token: 0x0602FA14 RID: 195092 RVA: 0x0067D5A4 File Offset: 0x0067B7A4
		public IDetectBattleStateTypeT UnPack()
		{
			IDetectBattleStateTypeT detectBattleStateTypeT = new IDetectBattleStateTypeT();
			this.UnPackTo(detectBattleStateTypeT);
			return detectBattleStateTypeT;
		}

		// Token: 0x0602FA15 RID: 195093 RVA: 0x0067D5BF File Offset: 0x0067B7BF
		public void UnPackTo(IDetectBattleStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA16 RID: 195094 RVA: 0x0067D5D0 File Offset: 0x0067B7D0
		public static Offset<IDetectBattleStateType> Pack(FlatBufferBuilder builder, IDetectBattleStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleStateType>);
			}
			return IDetectBattleStateType.CreateIDetectBattleStateType(builder, _o.Type);
		}

		// Token: 0x04011A1E RID: 72222
		private Table __p;
	}
}
