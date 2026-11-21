using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F7 RID: 18167
	public struct IWaveConfig : IFlatbufferObject
	{
		// Token: 0x17007F3E RID: 32574
		// (get) Token: 0x0601ABA1 RID: 109473 RVA: 0x003CC4F4 File Offset: 0x003CA6F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ABA2 RID: 109474 RVA: 0x003CC501 File Offset: 0x003CA701
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ABA3 RID: 109475 RVA: 0x003CC508 File Offset: 0x003CA708
		public static IWaveConfig GetRootAsIWaveConfig(ByteBuffer _bb)
		{
			return IWaveConfig.GetRootAsIWaveConfig(_bb, default(IWaveConfig));
		}

		// Token: 0x0601ABA4 RID: 109476 RVA: 0x003CC524 File Offset: 0x003CA724
		public static IWaveConfig GetRootAsIWaveConfig(ByteBuffer _bb, IWaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ABA5 RID: 109477 RVA: 0x003CC541 File Offset: 0x003CA741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ABA6 RID: 109478 RVA: 0x003CC550 File Offset: 0x003CA750
		public IWaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F3F RID: 32575
		// (get) Token: 0x0601ABA7 RID: 109479 RVA: 0x003CC560 File Offset: 0x003CA760
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ABA8 RID: 109480 RVA: 0x003CC59C File Offset: 0x003CA79C
		public static Offset<IWaveConfig> CreateIWaveConfig(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IWaveConfig.AddId(builder, Id);
			return IWaveConfig.EndIWaveConfig(builder);
		}

		// Token: 0x0601ABA9 RID: 109481 RVA: 0x003CC5B2 File Offset: 0x003CA7B2
		public static void StartIWaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601ABAA RID: 109482 RVA: 0x003CC5BB File Offset: 0x003CA7BB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601ABAB RID: 109483 RVA: 0x003CC5C6 File Offset: 0x003CA7C6
		public static Offset<IWaveConfig> EndIWaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWaveConfig>(builder.EndTable());
		}

		// Token: 0x0601ABAC RID: 109484 RVA: 0x003CC5D4 File Offset: 0x003CA7D4
		public IWaveConfigT UnPack()
		{
			IWaveConfigT waveConfigT = new IWaveConfigT();
			this.UnPackTo(waveConfigT);
			return waveConfigT;
		}

		// Token: 0x0601ABAD RID: 109485 RVA: 0x003CC5EF File Offset: 0x003CA7EF
		public void UnPackTo(IWaveConfigT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0601ABAE RID: 109486 RVA: 0x003CC600 File Offset: 0x003CA800
		public static Offset<IWaveConfig> Pack(FlatBufferBuilder builder, IWaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaveConfig>);
			}
			return IWaveConfig.CreateIWaveConfig(builder, _o.Id);
		}

		// Token: 0x0400C94A RID: 51530
		private Table __p;
	}
}
