using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA0 RID: 19872
	public struct ILoopTeleportClientMpcEffect : IFlatbufferObject
	{
		// Token: 0x17008E2D RID: 36397
		// (get) Token: 0x0601ED1D RID: 126237 RVA: 0x0044ED3A File Offset: 0x0044CF3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED1E RID: 126238 RVA: 0x0044ED47 File Offset: 0x0044CF47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED1F RID: 126239 RVA: 0x0044ED50 File Offset: 0x0044CF50
		public static ILoopTeleportClientMpcEffect GetRootAsILoopTeleportClientMpcEffect(ByteBuffer _bb)
		{
			return ILoopTeleportClientMpcEffect.GetRootAsILoopTeleportClientMpcEffect(_bb, default(ILoopTeleportClientMpcEffect));
		}

		// Token: 0x0601ED20 RID: 126240 RVA: 0x0044ED6C File Offset: 0x0044CF6C
		public static ILoopTeleportClientMpcEffect GetRootAsILoopTeleportClientMpcEffect(ByteBuffer _bb, ILoopTeleportClientMpcEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED21 RID: 126241 RVA: 0x0044ED89 File Offset: 0x0044CF89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED22 RID: 126242 RVA: 0x0044ED98 File Offset: 0x0044CF98
		public ILoopTeleportClientMpcEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E2E RID: 36398
		// (get) Token: 0x0601ED23 RID: 126243 RVA: 0x0044EDA8 File Offset: 0x0044CFA8
		public ELoopTeleportClientEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELoopTeleportClientEffectType.ScreenEffect;
				}
				return (ELoopTeleportClientEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E2F RID: 36399
		// (get) Token: 0x0601ED24 RID: 126244 RVA: 0x0044EDE4 File Offset: 0x0044CFE4
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED25 RID: 126245 RVA: 0x0044EE1B File Offset: 0x0044D01B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ED26 RID: 126246 RVA: 0x0044EE2A File Offset: 0x0044D02A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ED27 RID: 126247 RVA: 0x0044EE38 File Offset: 0x0044D038
		public static Offset<ILoopTeleportClientMpcEffect> CreateILoopTeleportClientMpcEffect(FlatBufferBuilder builder, ELoopTeleportClientEffectType Type = ELoopTeleportClientEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopTeleportClientMpcEffect.AddPath(builder, PathOffset);
			ILoopTeleportClientMpcEffect.AddType(builder, Type);
			return ILoopTeleportClientMpcEffect.EndILoopTeleportClientMpcEffect(builder);
		}

		// Token: 0x0601ED28 RID: 126248 RVA: 0x0044EE55 File Offset: 0x0044D055
		public static void StartILoopTeleportClientMpcEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ED29 RID: 126249 RVA: 0x0044EE5E File Offset: 0x0044D05E
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED2A RID: 126250 RVA: 0x0044EE69 File Offset: 0x0044D069
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601ED2B RID: 126251 RVA: 0x0044EE79 File Offset: 0x0044D079
		public static Offset<ILoopTeleportClientMpcEffect> EndILoopTeleportClientMpcEffect(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientMpcEffect>(builder.EndTable());
		}

		// Token: 0x0601ED2C RID: 126252 RVA: 0x0044EE88 File Offset: 0x0044D088
		public ILoopTeleportClientMpcEffectT UnPack()
		{
			ILoopTeleportClientMpcEffectT loopTeleportClientMpcEffectT = new ILoopTeleportClientMpcEffectT();
			this.UnPackTo(loopTeleportClientMpcEffectT);
			return loopTeleportClientMpcEffectT;
		}

		// Token: 0x0601ED2D RID: 126253 RVA: 0x0044EEA3 File Offset: 0x0044D0A3
		public void UnPackTo(ILoopTeleportClientMpcEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0601ED2E RID: 126254 RVA: 0x0044EEC0 File Offset: 0x0044D0C0
		public static Offset<ILoopTeleportClientMpcEffect> Pack(FlatBufferBuilder builder, ILoopTeleportClientMpcEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientMpcEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ILoopTeleportClientMpcEffect.CreateILoopTeleportClientMpcEffect(builder, _o.Type, pathOffset);
		}

		// Token: 0x0400DA00 RID: 55808
		private Table __p;
	}
}
