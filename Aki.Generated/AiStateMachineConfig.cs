using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF3 RID: 2803
	public struct AiStateMachineConfig : IFlatbufferObject
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x001D4308 File Offset: 0x001D2508
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x001D4315 File Offset: 0x001D2515
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x001D431C File Offset: 0x001D251C
		public static AiStateMachineConfig GetRootAsAiStateMachineConfig(ByteBuffer _bb)
		{
			return AiStateMachineConfig.GetRootAsAiStateMachineConfig(_bb, default(AiStateMachineConfig));
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x001D4338 File Offset: 0x001D2538
		public static AiStateMachineConfig GetRootAsAiStateMachineConfig(ByteBuffer _bb, AiStateMachineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x001D4355 File Offset: 0x001D2555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x001D4364 File Offset: 0x001D2564
		public AiStateMachineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x001D4374 File Offset: 0x001D2574
		public string Id
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

		// Token: 0x06004713 RID: 18195 RVA: 0x001D43AB File Offset: 0x001D25AB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x001D43BA File Offset: 0x001D25BA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x001D43D4 File Offset: 0x001D25D4
		public string StateMachineJson
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

		// Token: 0x06004716 RID: 18198 RVA: 0x001D440B File Offset: 0x001D260B
		public Span<byte> GetStateMachineJsonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x001D441A File Offset: 0x001D261A
		public byte[] GetStateMachineJsonArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AD4 RID: 19156
		private Table __p;
	}
}
