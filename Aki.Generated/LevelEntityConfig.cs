using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA5 RID: 3749
	public struct LevelEntityConfig : IFlatbufferObject
	{
		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06009379 RID: 37753 RVA: 0x00294969 File Offset: 0x00292B69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600937A RID: 37754 RVA: 0x00294976 File Offset: 0x00292B76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x00294980 File Offset: 0x00292B80
		public static LevelEntityConfig GetRootAsLevelEntityConfig(ByteBuffer _bb)
		{
			return LevelEntityConfig.GetRootAsLevelEntityConfig(_bb, default(LevelEntityConfig));
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x0029499C File Offset: 0x00292B9C
		public static LevelEntityConfig GetRootAsLevelEntityConfig(ByteBuffer _bb, LevelEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x002949B9 File Offset: 0x00292BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x002949C8 File Offset: 0x00292BC8
		public LevelEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x0600937F RID: 37759 RVA: 0x002949D8 File Offset: 0x00292BD8
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

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x00294A14 File Offset: 0x00292C14
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06009381 RID: 37761 RVA: 0x00294A50 File Offset: 0x00292C50
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06009382 RID: 37762 RVA: 0x00294A8C File Offset: 0x00292C8C
		public string BlueprintType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x00294AC4 File Offset: 0x00292CC4
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x00294AD4 File Offset: 0x00292CD4
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06009385 RID: 37765 RVA: 0x00294AEC File Offset: 0x00292CEC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00294B24 File Offset: 0x00292D24
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x00294B34 File Offset: 0x00292D34
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06009388 RID: 37768 RVA: 0x00294B4C File Offset: 0x00292D4C
		public bool InSleep
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06009389 RID: 37769 RVA: 0x00294B8C File Offset: 0x00292D8C
		public bool IsHidden
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x0600938A RID: 37770 RVA: 0x00294BCC File Offset: 0x00292DCC
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x0600938B RID: 37771 RVA: 0x00294C0C File Offset: 0x00292E0C
		public bool IsScaleEnabled
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x00294C4C File Offset: 0x00292E4C
		public IntVector? Transform(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IntVector?(default(IntVector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600938D RID: 37773 RVA: 0x00294CB0 File Offset: 0x00292EB0
		public int TransformLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x00294CDC File Offset: 0x00292EDC
		public string ComponentsData
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x00294D14 File Offset: 0x00292F14
		public Span<byte> GetComponentsDataBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x00294D24 File Offset: 0x00292F24
		public byte[] GetComponentsDataArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x00294D3C File Offset: 0x00292F3C
		[NullableContext(1)]
		public IntVector[] Transform()
		{
			return this.TransformIter().ToArray<IntVector>();
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x00294D49 File Offset: 0x00292F49
		[NullableContext(1)]
		public IEnumerable<IntVector> TransformIter()
		{
			LevelEntityConfig.<TransformIter>d__38 <TransformIter>d__ = new LevelEntityConfig.<TransformIter>d__38(-2);
			<TransformIter>d__.<>3__<>4__this = this;
			return <TransformIter>d__;
		}

		// Token: 0x0400543B RID: 21563
		private Table __p;
	}
}
