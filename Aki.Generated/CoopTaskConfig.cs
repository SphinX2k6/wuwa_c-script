using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C88 RID: 3208
	public struct CoopTaskConfig : IFlatbufferObject
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06005FEE RID: 24558 RVA: 0x00221061 File Offset: 0x0021F261
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x0022106E File Offset: 0x0021F26E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x00221078 File Offset: 0x0021F278
		public static CoopTaskConfig GetRootAsCoopTaskConfig(ByteBuffer _bb)
		{
			return CoopTaskConfig.GetRootAsCoopTaskConfig(_bb, default(CoopTaskConfig));
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x00221094 File Offset: 0x0021F294
		public static CoopTaskConfig GetRootAsCoopTaskConfig(ByteBuffer _bb, CoopTaskConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x002210B1 File Offset: 0x0021F2B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x002210C0 File Offset: 0x0021F2C0
		public CoopTaskConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06005FF4 RID: 24564 RVA: 0x002210D0 File Offset: 0x0021F2D0
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

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x0022110C File Offset: 0x0021F30C
		public int CoopRoleId
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

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x00221148 File Offset: 0x0021F348
		public int CoopLevelId
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x00221184 File Offset: 0x0021F384
		public int CoopPreQuest
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x002211C4 File Offset: 0x0021F3C4
		public int ConditionGroup
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x00221204 File Offset: 0x0021F404
		public string TaskTitle2
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x0022123C File Offset: 0x0021F43C
		public Span<byte> GetTaskTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x0022124C File Offset: 0x0021F44C
		public byte[] GetTaskTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x00221264 File Offset: 0x0021F464
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x002212A4 File Offset: 0x0021F4A4
		public int Condition2MapId
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

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06005FFE RID: 24574 RVA: 0x002212E4 File Offset: 0x0021F4E4
		public int Condition2MarkId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x00221324 File Offset: 0x0021F524
		public int LevelId1
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x00221364 File Offset: 0x0021F564
		public string TaskTitle3
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

		// Token: 0x06006001 RID: 24577 RVA: 0x0022139C File Offset: 0x0021F59C
		public Span<byte> GetTaskTitle3Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x002213AC File Offset: 0x0021F5AC
		public byte[] GetTaskTitle3Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06006003 RID: 24579 RVA: 0x002213C4 File Offset: 0x0021F5C4
		public int TraceMarkId3
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x00221404 File Offset: 0x0021F604
		public int LevelId2
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x00221444 File Offset: 0x0021F644
		public string TaskTitle4
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x0022147C File Offset: 0x0021F67C
		public Span<byte> GetTaskTitle4Bytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x0022148C File Offset: 0x0021F68C
		public byte[] GetTaskTitle4Array()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x002214A4 File Offset: 0x0021F6A4
		public int TraceMarkId4
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x002214E4 File Offset: 0x0021F6E4
		public int OpenTimeId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x00221524 File Offset: 0x0021F724
		public string TaskTitle5
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x0022155C File Offset: 0x0021F75C
		public Span<byte> GetTaskTitle5Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x0022156C File Offset: 0x0021F76C
		public byte[] GetTaskTitle5Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x040051AB RID: 20907
		private Table __p;
	}
}
