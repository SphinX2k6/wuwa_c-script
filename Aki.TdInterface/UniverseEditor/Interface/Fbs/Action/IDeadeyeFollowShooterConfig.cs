using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006555 RID: 25941
	public struct IDeadeyeFollowShooterConfig : IFlatbufferObject
	{
		// Token: 0x1700C0D4 RID: 49364
		// (get) Token: 0x0602D02A RID: 184362 RVA: 0x0062D901 File Offset: 0x0062BB01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D02B RID: 184363 RVA: 0x0062D90E File Offset: 0x0062BB0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D02C RID: 184364 RVA: 0x0062D918 File Offset: 0x0062BB18
		public static IDeadeyeFollowShooterConfig GetRootAsIDeadeyeFollowShooterConfig(ByteBuffer _bb)
		{
			return IDeadeyeFollowShooterConfig.GetRootAsIDeadeyeFollowShooterConfig(_bb, default(IDeadeyeFollowShooterConfig));
		}

		// Token: 0x0602D02D RID: 184365 RVA: 0x0062D934 File Offset: 0x0062BB34
		public static IDeadeyeFollowShooterConfig GetRootAsIDeadeyeFollowShooterConfig(ByteBuffer _bb, IDeadeyeFollowShooterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D02E RID: 184366 RVA: 0x0062D951 File Offset: 0x0062BB51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D02F RID: 184367 RVA: 0x0062D960 File Offset: 0x0062BB60
		public IDeadeyeFollowShooterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0D5 RID: 49365
		// (get) Token: 0x0602D030 RID: 184368 RVA: 0x0062D970 File Offset: 0x0062BB70
		public string DeadeyeShooterDa
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D031 RID: 184369 RVA: 0x0062D9A7 File Offset: 0x0062BBA7
		public Span<byte> GetDeadeyeShooterDaBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602D032 RID: 184370 RVA: 0x0062D9B6 File Offset: 0x0062BBB6
		public byte[] GetDeadeyeShooterDaArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602D033 RID: 184371 RVA: 0x0062D9C4 File Offset: 0x0062BBC4
		public static Offset<IDeadeyeFollowShooterConfig> CreateIDeadeyeFollowShooterConfig(FlatBufferBuilder builder, StringOffset DeadeyeShooterDaOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IDeadeyeFollowShooterConfig.AddDeadeyeShooterDa(builder, DeadeyeShooterDaOffset);
			return IDeadeyeFollowShooterConfig.EndIDeadeyeFollowShooterConfig(builder);
		}

		// Token: 0x0602D034 RID: 184372 RVA: 0x0062D9DA File Offset: 0x0062BBDA
		public static void StartIDeadeyeFollowShooterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D035 RID: 184373 RVA: 0x0062D9E3 File Offset: 0x0062BBE3
		public static void AddDeadeyeShooterDa(FlatBufferBuilder builder, StringOffset deadeyeShooterDaOffset)
		{
			builder.AddOffset(0, deadeyeShooterDaOffset.Value, 0);
		}

		// Token: 0x0602D036 RID: 184374 RVA: 0x0062D9F3 File Offset: 0x0062BBF3
		public static Offset<IDeadeyeFollowShooterConfig> EndIDeadeyeFollowShooterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeFollowShooterConfig>(builder.EndTable());
		}

		// Token: 0x0602D037 RID: 184375 RVA: 0x0062DA00 File Offset: 0x0062BC00
		public IDeadeyeFollowShooterConfigT UnPack()
		{
			IDeadeyeFollowShooterConfigT deadeyeFollowShooterConfigT = new IDeadeyeFollowShooterConfigT();
			this.UnPackTo(deadeyeFollowShooterConfigT);
			return deadeyeFollowShooterConfigT;
		}

		// Token: 0x0602D038 RID: 184376 RVA: 0x0062DA1B File Offset: 0x0062BC1B
		public void UnPackTo(IDeadeyeFollowShooterConfigT _o)
		{
			_o.DeadeyeShooterDa = this.DeadeyeShooterDa;
		}

		// Token: 0x0602D039 RID: 184377 RVA: 0x0062DA2C File Offset: 0x0062BC2C
		public static Offset<IDeadeyeFollowShooterConfig> Pack(FlatBufferBuilder builder, IDeadeyeFollowShooterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeFollowShooterConfig>);
			}
			StringOffset deadeyeShooterDaOffset = (_o.DeadeyeShooterDa == null) ? default(StringOffset) : builder.CreateString(_o.DeadeyeShooterDa);
			return IDeadeyeFollowShooterConfig.CreateIDeadeyeFollowShooterConfig(builder, deadeyeShooterDaOffset);
		}

		// Token: 0x04010BA6 RID: 68518
		private Table __p;
	}
}
