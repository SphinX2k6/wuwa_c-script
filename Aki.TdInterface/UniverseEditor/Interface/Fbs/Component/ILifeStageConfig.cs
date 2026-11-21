using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A80 RID: 23168
	public struct ILifeStageConfig : IFlatbufferObject
	{
		// Token: 0x1700A8C2 RID: 43202
		// (get) Token: 0x06025F4B RID: 155467 RVA: 0x005340AA File Offset: 0x005322AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F4C RID: 155468 RVA: 0x005340B7 File Offset: 0x005322B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F4D RID: 155469 RVA: 0x005340C0 File Offset: 0x005322C0
		public static ILifeStageConfig GetRootAsILifeStageConfig(ByteBuffer _bb)
		{
			return ILifeStageConfig.GetRootAsILifeStageConfig(_bb, default(ILifeStageConfig));
		}

		// Token: 0x06025F4E RID: 155470 RVA: 0x005340DC File Offset: 0x005322DC
		public static ILifeStageConfig GetRootAsILifeStageConfig(ByteBuffer _bb, ILifeStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F4F RID: 155471 RVA: 0x005340F9 File Offset: 0x005322F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F50 RID: 155472 RVA: 0x00534108 File Offset: 0x00532308
		public ILifeStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8C3 RID: 43203
		// (get) Token: 0x06025F51 RID: 155473 RVA: 0x00534118 File Offset: 0x00532318
		public float PerformDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8C4 RID: 43204
		// (get) Token: 0x06025F52 RID: 155474 RVA: 0x00534158 File Offset: 0x00532358
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025F53 RID: 155475 RVA: 0x00534194 File Offset: 0x00532394
		public static Offset<ILifeStageConfig> CreateILifeStageConfig(FlatBufferBuilder builder, float PerformDuration = 0f, byte NullMask = 0)
		{
			builder.StartTable(2);
			ILifeStageConfig.AddPerformDuration(builder, PerformDuration);
			ILifeStageConfig.AddNullMask(builder, NullMask);
			return ILifeStageConfig.EndILifeStageConfig(builder);
		}

		// Token: 0x06025F54 RID: 155476 RVA: 0x005341B1 File Offset: 0x005323B1
		public static void StartILifeStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025F55 RID: 155477 RVA: 0x005341BA File Offset: 0x005323BA
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(0, performDuration, 0.0);
		}

		// Token: 0x06025F56 RID: 155478 RVA: 0x005341CD File Offset: 0x005323CD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06025F57 RID: 155479 RVA: 0x005341D8 File Offset: 0x005323D8
		public static Offset<ILifeStageConfig> EndILifeStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILifeStageConfig>(builder.EndTable());
		}

		// Token: 0x06025F58 RID: 155480 RVA: 0x005341E8 File Offset: 0x005323E8
		public ILifeStageConfigT UnPack()
		{
			ILifeStageConfigT lifeStageConfigT = new ILifeStageConfigT();
			this.UnPackTo(lifeStageConfigT);
			return lifeStageConfigT;
		}

		// Token: 0x06025F59 RID: 155481 RVA: 0x00534203 File Offset: 0x00532403
		public void UnPackTo(ILifeStageConfigT _o)
		{
			_o.PerformDuration = this.PerformDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025F5A RID: 155482 RVA: 0x00534220 File Offset: 0x00532420
		public static Offset<ILifeStageConfig> Pack(FlatBufferBuilder builder, ILifeStageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifeStageConfig>);
			}
			return ILifeStageConfig.CreateILifeStageConfig(builder, _o.PerformDuration, _o.NullMask);
		}

		// Token: 0x0400F40F RID: 62479
		private Table __p;
	}
}
