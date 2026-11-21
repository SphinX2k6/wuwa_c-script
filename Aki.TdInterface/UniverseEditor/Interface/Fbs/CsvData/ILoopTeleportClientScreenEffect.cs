using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DAC RID: 19884
	public struct ILoopTeleportClientScreenEffect : IFlatbufferObject
	{
		// Token: 0x17008E3E RID: 36414
		// (get) Token: 0x0601ED75 RID: 126325 RVA: 0x0044F668 File Offset: 0x0044D868
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED76 RID: 126326 RVA: 0x0044F675 File Offset: 0x0044D875
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED77 RID: 126327 RVA: 0x0044F67C File Offset: 0x0044D87C
		public static ILoopTeleportClientScreenEffect GetRootAsILoopTeleportClientScreenEffect(ByteBuffer _bb)
		{
			return ILoopTeleportClientScreenEffect.GetRootAsILoopTeleportClientScreenEffect(_bb, default(ILoopTeleportClientScreenEffect));
		}

		// Token: 0x0601ED78 RID: 126328 RVA: 0x0044F698 File Offset: 0x0044D898
		public static ILoopTeleportClientScreenEffect GetRootAsILoopTeleportClientScreenEffect(ByteBuffer _bb, ILoopTeleportClientScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED79 RID: 126329 RVA: 0x0044F6B5 File Offset: 0x0044D8B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED7A RID: 126330 RVA: 0x0044F6C4 File Offset: 0x0044D8C4
		public ILoopTeleportClientScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E3F RID: 36415
		// (get) Token: 0x0601ED7B RID: 126331 RVA: 0x0044F6D4 File Offset: 0x0044D8D4
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

		// Token: 0x17008E40 RID: 36416
		// (get) Token: 0x0601ED7C RID: 126332 RVA: 0x0044F710 File Offset: 0x0044D910
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

		// Token: 0x0601ED7D RID: 126333 RVA: 0x0044F747 File Offset: 0x0044D947
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ED7E RID: 126334 RVA: 0x0044F756 File Offset: 0x0044D956
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ED7F RID: 126335 RVA: 0x0044F764 File Offset: 0x0044D964
		public static Offset<ILoopTeleportClientScreenEffect> CreateILoopTeleportClientScreenEffect(FlatBufferBuilder builder, ELoopTeleportClientEffectType Type = ELoopTeleportClientEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopTeleportClientScreenEffect.AddPath(builder, PathOffset);
			ILoopTeleportClientScreenEffect.AddType(builder, Type);
			return ILoopTeleportClientScreenEffect.EndILoopTeleportClientScreenEffect(builder);
		}

		// Token: 0x0601ED80 RID: 126336 RVA: 0x0044F781 File Offset: 0x0044D981
		public static void StartILoopTeleportClientScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ED81 RID: 126337 RVA: 0x0044F78A File Offset: 0x0044D98A
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED82 RID: 126338 RVA: 0x0044F795 File Offset: 0x0044D995
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601ED83 RID: 126339 RVA: 0x0044F7A5 File Offset: 0x0044D9A5
		public static Offset<ILoopTeleportClientScreenEffect> EndILoopTeleportClientScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientScreenEffect>(builder.EndTable());
		}

		// Token: 0x0601ED84 RID: 126340 RVA: 0x0044F7B4 File Offset: 0x0044D9B4
		public ILoopTeleportClientScreenEffectT UnPack()
		{
			ILoopTeleportClientScreenEffectT loopTeleportClientScreenEffectT = new ILoopTeleportClientScreenEffectT();
			this.UnPackTo(loopTeleportClientScreenEffectT);
			return loopTeleportClientScreenEffectT;
		}

		// Token: 0x0601ED85 RID: 126341 RVA: 0x0044F7CF File Offset: 0x0044D9CF
		public void UnPackTo(ILoopTeleportClientScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0601ED86 RID: 126342 RVA: 0x0044F7EC File Offset: 0x0044D9EC
		public static Offset<ILoopTeleportClientScreenEffect> Pack(FlatBufferBuilder builder, ILoopTeleportClientScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientScreenEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ILoopTeleportClientScreenEffect.CreateILoopTeleportClientScreenEffect(builder, _o.Type, pathOffset);
		}

		// Token: 0x0400DA10 RID: 55824
		private Table __p;
	}
}
