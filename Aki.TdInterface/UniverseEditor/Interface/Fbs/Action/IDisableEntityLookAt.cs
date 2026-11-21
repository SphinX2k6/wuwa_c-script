using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C47 RID: 27719
	public struct IDisableEntityLookAt : IFlatbufferObject
	{
		// Token: 0x1700CB2E RID: 52014
		// (get) Token: 0x0602FB5E RID: 195422 RVA: 0x0067F712 File Offset: 0x0067D912
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB5F RID: 195423 RVA: 0x0067F71F File Offset: 0x0067D91F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB60 RID: 195424 RVA: 0x0067F728 File Offset: 0x0067D928
		public static IDisableEntityLookAt GetRootAsIDisableEntityLookAt(ByteBuffer _bb)
		{
			return IDisableEntityLookAt.GetRootAsIDisableEntityLookAt(_bb, default(IDisableEntityLookAt));
		}

		// Token: 0x0602FB61 RID: 195425 RVA: 0x0067F744 File Offset: 0x0067D944
		public static IDisableEntityLookAt GetRootAsIDisableEntityLookAt(ByteBuffer _bb, IDisableEntityLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB62 RID: 195426 RVA: 0x0067F761 File Offset: 0x0067D961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB63 RID: 195427 RVA: 0x0067F770 File Offset: 0x0067D970
		public IDisableEntityLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB2F RID: 52015
		// (get) Token: 0x0602FB64 RID: 195428 RVA: 0x0067F780 File Offset: 0x0067D980
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

		// Token: 0x0602FB65 RID: 195429 RVA: 0x0067F7B7 File Offset: 0x0067D9B7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602FB66 RID: 195430 RVA: 0x0067F7C6 File Offset: 0x0067D9C6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602FB67 RID: 195431 RVA: 0x0067F7D4 File Offset: 0x0067D9D4
		public static Offset<IDisableEntityLookAt> CreateIDisableEntityLookAt(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IDisableEntityLookAt.AddKey(builder, KeyOffset);
			return IDisableEntityLookAt.EndIDisableEntityLookAt(builder);
		}

		// Token: 0x0602FB68 RID: 195432 RVA: 0x0067F7EA File Offset: 0x0067D9EA
		public static void StartIDisableEntityLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FB69 RID: 195433 RVA: 0x0067F7F3 File Offset: 0x0067D9F3
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602FB6A RID: 195434 RVA: 0x0067F803 File Offset: 0x0067DA03
		public static Offset<IDisableEntityLookAt> EndIDisableEntityLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IDisableEntityLookAt>(builder.EndTable());
		}

		// Token: 0x0602FB6B RID: 195435 RVA: 0x0067F810 File Offset: 0x0067DA10
		public IDisableEntityLookAtT UnPack()
		{
			IDisableEntityLookAtT disableEntityLookAtT = new IDisableEntityLookAtT();
			this.UnPackTo(disableEntityLookAtT);
			return disableEntityLookAtT;
		}

		// Token: 0x0602FB6C RID: 195436 RVA: 0x0067F82B File Offset: 0x0067DA2B
		public void UnPackTo(IDisableEntityLookAtT _o)
		{
			_o.Key = this.Key;
		}

		// Token: 0x0602FB6D RID: 195437 RVA: 0x0067F83C File Offset: 0x0067DA3C
		public static Offset<IDisableEntityLookAt> Pack(FlatBufferBuilder builder, IDisableEntityLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableEntityLookAt>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IDisableEntityLookAt.CreateIDisableEntityLookAt(builder, keyOffset);
		}

		// Token: 0x04011A5F RID: 72287
		private Table __p;
	}
}
