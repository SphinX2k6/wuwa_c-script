using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429B RID: 17051
	public struct IWaveConfig : IFlatbufferObject
	{
		// Token: 0x1700790D RID: 30989
		// (get) Token: 0x06019435 RID: 103477 RVA: 0x003A0E1C File Offset: 0x0039F01C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019436 RID: 103478 RVA: 0x003A0E29 File Offset: 0x0039F029
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019437 RID: 103479 RVA: 0x003A0E30 File Offset: 0x0039F030
		public static IWaveConfig GetRootAsIWaveConfig(ByteBuffer _bb)
		{
			return IWaveConfig.GetRootAsIWaveConfig(_bb, default(IWaveConfig));
		}

		// Token: 0x06019438 RID: 103480 RVA: 0x003A0E4C File Offset: 0x0039F04C
		public static IWaveConfig GetRootAsIWaveConfig(ByteBuffer _bb, IWaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019439 RID: 103481 RVA: 0x003A0E69 File Offset: 0x0039F069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601943A RID: 103482 RVA: 0x003A0E78 File Offset: 0x0039F078
		public IWaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700790E RID: 30990
		// (get) Token: 0x0601943B RID: 103483 RVA: 0x003A0E88 File Offset: 0x0039F088
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

		// Token: 0x0601943C RID: 103484 RVA: 0x003A0EC4 File Offset: 0x0039F0C4
		public static Offset<IWaveConfig> CreateIWaveConfig(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IWaveConfig.AddId(builder, Id);
			return IWaveConfig.EndIWaveConfig(builder);
		}

		// Token: 0x0601943D RID: 103485 RVA: 0x003A0EDA File Offset: 0x0039F0DA
		public static void StartIWaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601943E RID: 103486 RVA: 0x003A0EE3 File Offset: 0x0039F0E3
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601943F RID: 103487 RVA: 0x003A0EEE File Offset: 0x0039F0EE
		public static Offset<IWaveConfig> EndIWaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWaveConfig>(builder.EndTable());
		}

		// Token: 0x06019440 RID: 103488 RVA: 0x003A0EFC File Offset: 0x0039F0FC
		public IWaveConfigT UnPack()
		{
			IWaveConfigT waveConfigT = new IWaveConfigT();
			this.UnPackTo(waveConfigT);
			return waveConfigT;
		}

		// Token: 0x06019441 RID: 103489 RVA: 0x003A0F17 File Offset: 0x0039F117
		public void UnPackTo(IWaveConfigT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x06019442 RID: 103490 RVA: 0x003A0F28 File Offset: 0x0039F128
		public static Offset<IWaveConfig> Pack(FlatBufferBuilder builder, IWaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaveConfig>);
			}
			return IWaveConfig.CreateIWaveConfig(builder, _o.Id);
		}

		// Token: 0x0400BF3D RID: 48957
		private Table __p;
	}
}
