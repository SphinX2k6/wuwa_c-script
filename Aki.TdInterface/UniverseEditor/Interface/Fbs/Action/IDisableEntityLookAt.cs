using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065DF RID: 26079
	public struct IDisableEntityLookAt : IFlatbufferObject
	{
		// Token: 0x1700C19F RID: 49567
		// (get) Token: 0x0602D3DA RID: 185306 RVA: 0x0063354E File Offset: 0x0063174E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D3DB RID: 185307 RVA: 0x0063355B File Offset: 0x0063175B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D3DC RID: 185308 RVA: 0x00633564 File Offset: 0x00631764
		public static IDisableEntityLookAt GetRootAsIDisableEntityLookAt(ByteBuffer _bb)
		{
			return IDisableEntityLookAt.GetRootAsIDisableEntityLookAt(_bb, default(IDisableEntityLookAt));
		}

		// Token: 0x0602D3DD RID: 185309 RVA: 0x00633580 File Offset: 0x00631780
		public static IDisableEntityLookAt GetRootAsIDisableEntityLookAt(ByteBuffer _bb, IDisableEntityLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D3DE RID: 185310 RVA: 0x0063359D File Offset: 0x0063179D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D3DF RID: 185311 RVA: 0x006335AC File Offset: 0x006317AC
		public IDisableEntityLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1A0 RID: 49568
		// (get) Token: 0x0602D3E0 RID: 185312 RVA: 0x006335BC File Offset: 0x006317BC
		public string Key
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

		// Token: 0x0602D3E1 RID: 185313 RVA: 0x006335F3 File Offset: 0x006317F3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602D3E2 RID: 185314 RVA: 0x00633602 File Offset: 0x00631802
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602D3E3 RID: 185315 RVA: 0x00633610 File Offset: 0x00631810
		public static Offset<IDisableEntityLookAt> CreateIDisableEntityLookAt(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IDisableEntityLookAt.AddKey(builder, KeyOffset);
			return IDisableEntityLookAt.EndIDisableEntityLookAt(builder);
		}

		// Token: 0x0602D3E4 RID: 185316 RVA: 0x00633626 File Offset: 0x00631826
		public static void StartIDisableEntityLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D3E5 RID: 185317 RVA: 0x0063362F File Offset: 0x0063182F
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602D3E6 RID: 185318 RVA: 0x0063363F File Offset: 0x0063183F
		public static Offset<IDisableEntityLookAt> EndIDisableEntityLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IDisableEntityLookAt>(builder.EndTable());
		}

		// Token: 0x0602D3E7 RID: 185319 RVA: 0x0063364C File Offset: 0x0063184C
		public IDisableEntityLookAtT UnPack()
		{
			IDisableEntityLookAtT disableEntityLookAtT = new IDisableEntityLookAtT();
			this.UnPackTo(disableEntityLookAtT);
			return disableEntityLookAtT;
		}

		// Token: 0x0602D3E8 RID: 185320 RVA: 0x00633667 File Offset: 0x00631867
		public void UnPackTo(IDisableEntityLookAtT _o)
		{
			_o.Key = this.Key;
		}

		// Token: 0x0602D3E9 RID: 185321 RVA: 0x00633678 File Offset: 0x00631878
		public static Offset<IDisableEntityLookAt> Pack(FlatBufferBuilder builder, IDisableEntityLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableEntityLookAt>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IDisableEntityLookAt.CreateIDisableEntityLookAt(builder, keyOffset);
		}

		// Token: 0x04010C4D RID: 68685
		private Table __p;
	}
}
