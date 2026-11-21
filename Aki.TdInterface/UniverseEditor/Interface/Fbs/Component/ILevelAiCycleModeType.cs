using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A53 RID: 23123
	public struct ILevelAiCycleModeType : IFlatbufferObject
	{
		// Token: 0x1700A834 RID: 43060
		// (get) Token: 0x06025D2A RID: 154922 RVA: 0x0052F3E2 File Offset: 0x0052D5E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D2B RID: 154923 RVA: 0x0052F3EF File Offset: 0x0052D5EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D2C RID: 154924 RVA: 0x0052F3F8 File Offset: 0x0052D5F8
		public static ILevelAiCycleModeType GetRootAsILevelAiCycleModeType(ByteBuffer _bb)
		{
			return ILevelAiCycleModeType.GetRootAsILevelAiCycleModeType(_bb, default(ILevelAiCycleModeType));
		}

		// Token: 0x06025D2D RID: 154925 RVA: 0x0052F414 File Offset: 0x0052D614
		public static ILevelAiCycleModeType GetRootAsILevelAiCycleModeType(ByteBuffer _bb, ILevelAiCycleModeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D2E RID: 154926 RVA: 0x0052F431 File Offset: 0x0052D631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D2F RID: 154927 RVA: 0x0052F440 File Offset: 0x0052D640
		public ILevelAiCycleModeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A835 RID: 43061
		// (get) Token: 0x06025D30 RID: 154928 RVA: 0x0052F450 File Offset: 0x0052D650
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

		// Token: 0x06025D31 RID: 154929 RVA: 0x0052F48C File Offset: 0x0052D68C
		public static Offset<ILevelAiCycleModeType> CreateILevelAiCycleModeType(FlatBufferBuilder builder, ELevelAiCycleMode Type = ELevelAiCycleMode.Loop)
		{
			builder.StartTable(1);
			ILevelAiCycleModeType.AddType(builder, Type);
			return ILevelAiCycleModeType.EndILevelAiCycleModeType(builder);
		}

		// Token: 0x06025D32 RID: 154930 RVA: 0x0052F4A2 File Offset: 0x0052D6A2
		public static void StartILevelAiCycleModeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025D33 RID: 154931 RVA: 0x0052F4AB File Offset: 0x0052D6AB
		public static void AddType(FlatBufferBuilder builder, ELevelAiCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025D34 RID: 154932 RVA: 0x0052F4B6 File Offset: 0x0052D6B6
		public static Offset<ILevelAiCycleModeType> EndILevelAiCycleModeType(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAiCycleModeType>(builder.EndTable());
		}

		// Token: 0x06025D35 RID: 154933 RVA: 0x0052F4C4 File Offset: 0x0052D6C4
		public ILevelAiCycleModeTypeT UnPack()
		{
			ILevelAiCycleModeTypeT levelAiCycleModeTypeT = new ILevelAiCycleModeTypeT();
			this.UnPackTo(levelAiCycleModeTypeT);
			return levelAiCycleModeTypeT;
		}

		// Token: 0x06025D36 RID: 154934 RVA: 0x0052F4DF File Offset: 0x0052D6DF
		public void UnPackTo(ILevelAiCycleModeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025D37 RID: 154935 RVA: 0x0052F4F0 File Offset: 0x0052D6F0
		public static Offset<ILevelAiCycleModeType> Pack(FlatBufferBuilder builder, ILevelAiCycleModeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAiCycleModeType>);
			}
			return ILevelAiCycleModeType.CreateILevelAiCycleModeType(builder, _o.Type);
		}

		// Token: 0x0400F3BC RID: 62396
		private Table __p;
	}
}
