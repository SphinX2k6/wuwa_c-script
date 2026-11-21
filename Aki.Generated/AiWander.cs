using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD1 RID: 3025
	public struct AiWander : IFlatbufferObject
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x001F46BF File Offset: 0x001F28BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x001F46CC File Offset: 0x001F28CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x001F46D4 File Offset: 0x001F28D4
		public static AiWander GetRootAsAiWander(ByteBuffer _bb)
		{
			return AiWander.GetRootAsAiWander(_bb, default(AiWander));
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x001F46F0 File Offset: 0x001F28F0
		public static AiWander GetRootAsAiWander(ByteBuffer _bb, AiWander obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x001F470D File Offset: 0x001F290D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x001F471C File Offset: 0x001F291C
		public AiWander __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x001F472C File Offset: 0x001F292C
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06004CA0 RID: 19616 RVA: 0x001F4768 File Offset: 0x001F2968
		public float TurnSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 180f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x001F47A8 File Offset: 0x001F29A8
		public int WanderMoveState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06004CA2 RID: 19618 RVA: 0x001F47E4 File Offset: 0x001F29E4
		public int ResetMoveState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x001F4824 File Offset: 0x001F2A24
		public int MoveStateGA
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06004CA4 RID: 19620 RVA: 0x001F4864 File Offset: 0x001F2A64
		public float CompleteDistance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 10f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x001F48A8 File Offset: 0x001F2AA8
		public string ShowEffectDaPath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x001F48E0 File Offset: 0x001F2AE0
		public Span<byte> GetShowEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x001F48F0 File Offset: 0x001F2AF0
		public byte[] GetShowEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x001F4908 File Offset: 0x001F2B08
		public string HideEffectDaPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x001F4940 File Offset: 0x001F2B40
		public Span<byte> GetHideEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x001F4950 File Offset: 0x001F2B50
		public byte[] GetHideEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x001F4968 File Offset: 0x001F2B68
		public string ShowMaterialDaPath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x001F49A0 File Offset: 0x001F2BA0
		public Span<byte> GetShowMaterialDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x001F49B0 File Offset: 0x001F2BB0
		public byte[] GetShowMaterialDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x001F49C8 File Offset: 0x001F2BC8
		public string HideMaterialDaPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x001F4A00 File Offset: 0x001F2C00
		public Span<byte> GetHideMaterialDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x001F4A10 File Offset: 0x001F2C10
		public byte[] GetHideMaterialDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x040050B2 RID: 20658
		private Table __p;
	}
}
