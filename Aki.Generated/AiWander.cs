using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF7 RID: 2807
	public struct AiWander : IFlatbufferObject
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x001D4D79 File Offset: 0x001D2F79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x001D4D86 File Offset: 0x001D2F86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x001D4D90 File Offset: 0x001D2F90
		public static AiWander GetRootAsAiWander(ByteBuffer _bb)
		{
			return AiWander.GetRootAsAiWander(_bb, default(AiWander));
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x001D4DAC File Offset: 0x001D2FAC
		public static AiWander GetRootAsAiWander(ByteBuffer _bb, AiWander obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x001D4DC9 File Offset: 0x001D2FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x001D4DD8 File Offset: 0x001D2FD8
		public AiWander __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x001D4DE8 File Offset: 0x001D2FE8
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x001D4E24 File Offset: 0x001D3024
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x001D4E64 File Offset: 0x001D3064
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x001D4EA0 File Offset: 0x001D30A0
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x001D4EE0 File Offset: 0x001D30E0
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x001D4F20 File Offset: 0x001D3120
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x001D4F64 File Offset: 0x001D3164
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

		// Token: 0x0600475F RID: 18271 RVA: 0x001D4F9C File Offset: 0x001D319C
		public Span<byte> GetShowEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x001D4FAC File Offset: 0x001D31AC
		public byte[] GetShowEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x001D4FC4 File Offset: 0x001D31C4
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

		// Token: 0x06004762 RID: 18274 RVA: 0x001D4FFC File Offset: 0x001D31FC
		public Span<byte> GetHideEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x001D500C File Offset: 0x001D320C
		public byte[] GetHideEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x001D5024 File Offset: 0x001D3224
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

		// Token: 0x06004765 RID: 18277 RVA: 0x001D505C File Offset: 0x001D325C
		public Span<byte> GetShowMaterialDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x001D506C File Offset: 0x001D326C
		public byte[] GetShowMaterialDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x001D5084 File Offset: 0x001D3284
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

		// Token: 0x06004768 RID: 18280 RVA: 0x001D50BC File Offset: 0x001D32BC
		public Span<byte> GetHideMaterialDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x001D50CC File Offset: 0x001D32CC
		public byte[] GetHideMaterialDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AD8 RID: 19160
		private Table __p;
	}
}
