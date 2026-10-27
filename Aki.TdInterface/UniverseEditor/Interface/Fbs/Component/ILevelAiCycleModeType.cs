using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CD RID: 21709
	public struct ILevelAiCycleModeType : IFlatbufferObject
	{
		// Token: 0x17009FFA RID: 40954
		// (get) Token: 0x06023C72 RID: 146546 RVA: 0x004F236E File Offset: 0x004F056E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C73 RID: 146547 RVA: 0x004F237B File Offset: 0x004F057B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C74 RID: 146548 RVA: 0x004F2384 File Offset: 0x004F0584
		public static ILevelAiCycleModeType GetRootAsILevelAiCycleModeType(ByteBuffer _bb)
		{
			return ILevelAiCycleModeType.GetRootAsILevelAiCycleModeType(_bb, default(ILevelAiCycleModeType));
		}

		// Token: 0x06023C75 RID: 146549 RVA: 0x004F23A0 File Offset: 0x004F05A0
		public static ILevelAiCycleModeType GetRootAsILevelAiCycleModeType(ByteBuffer _bb, ILevelAiCycleModeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C76 RID: 146550 RVA: 0x004F23BD File Offset: 0x004F05BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C77 RID: 146551 RVA: 0x004F23CC File Offset: 0x004F05CC
		public ILevelAiCycleModeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FFB RID: 40955
		// (get) Token: 0x06023C78 RID: 146552 RVA: 0x004F23DC File Offset: 0x004F05DC
		public ELevelAiCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelAiCycleMode.Loop;
				}
				return (ELevelAiCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023C79 RID: 146553 RVA: 0x004F2418 File Offset: 0x004F0618
		public static Offset<ILevelAiCycleModeType> CreateILevelAiCycleModeType(FlatBufferBuilder builder, ELevelAiCycleMode Type = ELevelAiCycleMode.Loop)
		{
			builder.StartTable(1);
			ILevelAiCycleModeType.AddType(builder, Type);
			return ILevelAiCycleModeType.EndILevelAiCycleModeType(builder);
		}

		// Token: 0x06023C7A RID: 146554 RVA: 0x004F242E File Offset: 0x004F062E
		public static void StartILevelAiCycleModeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023C7B RID: 146555 RVA: 0x004F2437 File Offset: 0x004F0637
		public static void AddType(FlatBufferBuilder builder, ELevelAiCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C7C RID: 146556 RVA: 0x004F2442 File Offset: 0x004F0642
		public static Offset<ILevelAiCycleModeType> EndILevelAiCycleModeType(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAiCycleModeType>(builder.EndTable());
		}

		// Token: 0x06023C7D RID: 146557 RVA: 0x004F2450 File Offset: 0x004F0650
		public ILevelAiCycleModeTypeT UnPack()
		{
			ILevelAiCycleModeTypeT levelAiCycleModeTypeT = new ILevelAiCycleModeTypeT();
			this.UnPackTo(levelAiCycleModeTypeT);
			return levelAiCycleModeTypeT;
		}

		// Token: 0x06023C7E RID: 146558 RVA: 0x004F246B File Offset: 0x004F066B
		public void UnPackTo(ILevelAiCycleModeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023C7F RID: 146559 RVA: 0x004F247C File Offset: 0x004F067C
		public static Offset<ILevelAiCycleModeType> Pack(FlatBufferBuilder builder, ILevelAiCycleModeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAiCycleModeType>);
			}
			return ILevelAiCycleModeType.CreateILevelAiCycleModeType(builder, _o.Type);
		}

		// Token: 0x0400E78B RID: 59275
		private Table __p;
	}
}
