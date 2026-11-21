using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC6 RID: 27590
	public struct IDeadeyeFollowShooterConfig : IFlatbufferObject
	{
		// Token: 0x1700CA6F RID: 51823
		// (get) Token: 0x0602F7E6 RID: 194534 RVA: 0x0067A0C5 File Offset: 0x006782C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7E7 RID: 194535 RVA: 0x0067A0D2 File Offset: 0x006782D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7E8 RID: 194536 RVA: 0x0067A0DC File Offset: 0x006782DC
		public static IDeadeyeFollowShooterConfig GetRootAsIDeadeyeFollowShooterConfig(ByteBuffer _bb)
		{
			return IDeadeyeFollowShooterConfig.GetRootAsIDeadeyeFollowShooterConfig(_bb, default(IDeadeyeFollowShooterConfig));
		}

		// Token: 0x0602F7E9 RID: 194537 RVA: 0x0067A0F8 File Offset: 0x006782F8
		public static IDeadeyeFollowShooterConfig GetRootAsIDeadeyeFollowShooterConfig(ByteBuffer _bb, IDeadeyeFollowShooterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7EA RID: 194538 RVA: 0x0067A115 File Offset: 0x00678315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7EB RID: 194539 RVA: 0x0067A124 File Offset: 0x00678324
		public IDeadeyeFollowShooterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA70 RID: 51824
		// (get) Token: 0x0602F7EC RID: 194540 RVA: 0x0067A134 File Offset: 0x00678334
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

		// Token: 0x0602F7ED RID: 194541 RVA: 0x0067A16B File Offset: 0x0067836B
		public Span<byte> GetDeadeyeShooterDaBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F7EE RID: 194542 RVA: 0x0067A17A File Offset: 0x0067837A
		public byte[] GetDeadeyeShooterDaArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602F7EF RID: 194543 RVA: 0x0067A188 File Offset: 0x00678388
		public static Offset<IDeadeyeFollowShooterConfig> CreateIDeadeyeFollowShooterConfig(FlatBufferBuilder builder, StringOffset DeadeyeShooterDaOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IDeadeyeFollowShooterConfig.AddDeadeyeShooterDa(builder, DeadeyeShooterDaOffset);
			return IDeadeyeFollowShooterConfig.EndIDeadeyeFollowShooterConfig(builder);
		}

		// Token: 0x0602F7F0 RID: 194544 RVA: 0x0067A19E File Offset: 0x0067839E
		public static void StartIDeadeyeFollowShooterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F7F1 RID: 194545 RVA: 0x0067A1A7 File Offset: 0x006783A7
		public static void AddDeadeyeShooterDa(FlatBufferBuilder builder, StringOffset deadeyeShooterDaOffset)
		{
			builder.AddOffset(0, deadeyeShooterDaOffset.Value, 0);
		}

		// Token: 0x0602F7F2 RID: 194546 RVA: 0x0067A1B7 File Offset: 0x006783B7
		public static Offset<IDeadeyeFollowShooterConfig> EndIDeadeyeFollowShooterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeFollowShooterConfig>(builder.EndTable());
		}

		// Token: 0x0602F7F3 RID: 194547 RVA: 0x0067A1C4 File Offset: 0x006783C4
		public IDeadeyeFollowShooterConfigT UnPack()
		{
			IDeadeyeFollowShooterConfigT deadeyeFollowShooterConfigT = new IDeadeyeFollowShooterConfigT();
			this.UnPackTo(deadeyeFollowShooterConfigT);
			return deadeyeFollowShooterConfigT;
		}

		// Token: 0x0602F7F4 RID: 194548 RVA: 0x0067A1DF File Offset: 0x006783DF
		public void UnPackTo(IDeadeyeFollowShooterConfigT _o)
		{
			_o.DeadeyeShooterDa = this.DeadeyeShooterDa;
		}

		// Token: 0x0602F7F5 RID: 194549 RVA: 0x0067A1F0 File Offset: 0x006783F0
		public static Offset<IDeadeyeFollowShooterConfig> Pack(FlatBufferBuilder builder, IDeadeyeFollowShooterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeFollowShooterConfig>);
			}
			StringOffset deadeyeShooterDaOffset = (_o.DeadeyeShooterDa == null) ? default(StringOffset) : builder.CreateString(_o.DeadeyeShooterDa);
			return IDeadeyeFollowShooterConfig.CreateIDeadeyeFollowShooterConfig(builder, deadeyeShooterDaOffset);
		}

		// Token: 0x040119C4 RID: 72132
		private Table __p;
	}
}
