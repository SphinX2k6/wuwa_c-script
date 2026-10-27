using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FA RID: 21754
	public struct ILifeStageConfig : IFlatbufferObject
	{
		// Token: 0x1700A088 RID: 41096
		// (get) Token: 0x06023E91 RID: 147089 RVA: 0x004F6F86 File Offset: 0x004F5186
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E92 RID: 147090 RVA: 0x004F6F93 File Offset: 0x004F5193
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E93 RID: 147091 RVA: 0x004F6F9C File Offset: 0x004F519C
		public static ILifeStageConfig GetRootAsILifeStageConfig(ByteBuffer _bb)
		{
			return ILifeStageConfig.GetRootAsILifeStageConfig(_bb, default(ILifeStageConfig));
		}

		// Token: 0x06023E94 RID: 147092 RVA: 0x004F6FB8 File Offset: 0x004F51B8
		public static ILifeStageConfig GetRootAsILifeStageConfig(ByteBuffer _bb, ILifeStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E95 RID: 147093 RVA: 0x004F6FD5 File Offset: 0x004F51D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E96 RID: 147094 RVA: 0x004F6FE4 File Offset: 0x004F51E4
		public ILifeStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A089 RID: 41097
		// (get) Token: 0x06023E97 RID: 147095 RVA: 0x004F6FF4 File Offset: 0x004F51F4
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

		// Token: 0x1700A08A RID: 41098
		// (get) Token: 0x06023E98 RID: 147096 RVA: 0x004F7034 File Offset: 0x004F5234
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

		// Token: 0x06023E99 RID: 147097 RVA: 0x004F7070 File Offset: 0x004F5270
		public static Offset<ILifeStageConfig> CreateILifeStageConfig(FlatBufferBuilder builder, float PerformDuration = 0f, byte NullMask = 0)
		{
			builder.StartTable(2);
			ILifeStageConfig.AddPerformDuration(builder, PerformDuration);
			ILifeStageConfig.AddNullMask(builder, NullMask);
			return ILifeStageConfig.EndILifeStageConfig(builder);
		}

		// Token: 0x06023E9A RID: 147098 RVA: 0x004F708D File Offset: 0x004F528D
		public static void StartILifeStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023E9B RID: 147099 RVA: 0x004F7096 File Offset: 0x004F5296
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(0, performDuration, 0.0);
		}

		// Token: 0x06023E9C RID: 147100 RVA: 0x004F70A9 File Offset: 0x004F52A9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06023E9D RID: 147101 RVA: 0x004F70B4 File Offset: 0x004F52B4
		public static Offset<ILifeStageConfig> EndILifeStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILifeStageConfig>(builder.EndTable());
		}

		// Token: 0x06023E9E RID: 147102 RVA: 0x004F70C4 File Offset: 0x004F52C4
		public ILifeStageConfigT UnPack()
		{
			ILifeStageConfigT lifeStageConfigT = new ILifeStageConfigT();
			this.UnPackTo(lifeStageConfigT);
			return lifeStageConfigT;
		}

		// Token: 0x06023E9F RID: 147103 RVA: 0x004F70DF File Offset: 0x004F52DF
		public void UnPackTo(ILifeStageConfigT _o)
		{
			_o.PerformDuration = this.PerformDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023EA0 RID: 147104 RVA: 0x004F70FC File Offset: 0x004F52FC
		public static Offset<ILifeStageConfig> Pack(FlatBufferBuilder builder, ILifeStageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifeStageConfig>);
			}
			return ILifeStageConfig.CreateILifeStageConfig(builder, _o.PerformDuration, _o.NullMask);
		}

		// Token: 0x0400E7DE RID: 59358
		private Table __p;
	}
}
