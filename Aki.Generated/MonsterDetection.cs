using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF6 RID: 3830
	public struct MonsterDetection : IFlatbufferObject
	{
		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06009AC0 RID: 39616 RVA: 0x002A47DD File Offset: 0x002A29DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x002A47EA File Offset: 0x002A29EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x002A47F4 File Offset: 0x002A29F4
		public static MonsterDetection GetRootAsMonsterDetection(ByteBuffer _bb)
		{
			return MonsterDetection.GetRootAsMonsterDetection(_bb, default(MonsterDetection));
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x002A4810 File Offset: 0x002A2A10
		public static MonsterDetection GetRootAsMonsterDetection(ByteBuffer _bb, MonsterDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x002A482D File Offset: 0x002A2A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x002A483C File Offset: 0x002A2A3C
		public MonsterDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06009AC6 RID: 39622 RVA: 0x002A484C File Offset: 0x002A2A4C
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

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06009AC7 RID: 39623 RVA: 0x002A4888 File Offset: 0x002A2A88
		public string BlueprintType
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

		// Token: 0x06009AC8 RID: 39624 RVA: 0x002A48BF File Offset: 0x002A2ABF
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x002A48CE File Offset: 0x002A2ACE
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06009ACA RID: 39626 RVA: 0x002A48E8 File Offset: 0x002A2AE8
		public int MarkId
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

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06009ACB RID: 39627 RVA: 0x002A4924 File Offset: 0x002A2B24
		public string Name
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

		// Token: 0x06009ACC RID: 39628 RVA: 0x002A495C File Offset: 0x002A2B5C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x002A496C File Offset: 0x002A2B6C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06009ACE RID: 39630 RVA: 0x002A4984 File Offset: 0x002A2B84
		public int ShowReward
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

		// Token: 0x06009ACF RID: 39631 RVA: 0x002A49C4 File Offset: 0x002A2BC4
		public string BlueprintTypeList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06009AD0 RID: 39632 RVA: 0x002A4A00 File Offset: 0x002A2C00
		public int BlueprintTypeListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06009AD1 RID: 39633 RVA: 0x002A4A2C File Offset: 0x002A2C2C
		public int EntityConfigId
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

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06009AD2 RID: 39634 RVA: 0x002A4A6C File Offset: 0x002A2C6C
		public int DangerType
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

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x002A4AAC File Offset: 0x002A2CAC
		public int TypeDescription2
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

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06009AD4 RID: 39636 RVA: 0x002A4AEC File Offset: 0x002A2CEC
		public string AttributesDescriptionLock
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

		// Token: 0x06009AD5 RID: 39637 RVA: 0x002A4B24 File Offset: 0x002A2D24
		public Span<byte> GetAttributesDescriptionLockBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x002A4B34 File Offset: 0x002A2D34
		public byte[] GetAttributesDescriptionLockArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x002A4B4C File Offset: 0x002A2D4C
		public string AttributesDescriptionUnlock
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

		// Token: 0x06009AD8 RID: 39640 RVA: 0x002A4B84 File Offset: 0x002A2D84
		public Span<byte> GetAttributesDescriptionUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x002A4B94 File Offset: 0x002A2D94
		public byte[] GetAttributesDescriptionUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06009ADA RID: 39642 RVA: 0x002A4BAC File Offset: 0x002A2DAC
		public string BigIcon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x002A4BE4 File Offset: 0x002A2DE4
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x002A4BF4 File Offset: 0x002A2DF4
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06009ADD RID: 39645 RVA: 0x002A4C0C File Offset: 0x002A2E0C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009ADE RID: 39646 RVA: 0x002A4C44 File Offset: 0x002A2E44
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009ADF RID: 39647 RVA: 0x002A4C54 File Offset: 0x002A2E54
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06009AE0 RID: 39648 RVA: 0x002A4C6C File Offset: 0x002A2E6C
		public string TemporaryIconUnLock
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

		// Token: 0x06009AE1 RID: 39649 RVA: 0x002A4CA4 File Offset: 0x002A2EA4
		public Span<byte> GetTemporaryIconUnLockBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x002A4CB4 File Offset: 0x002A2EB4
		public byte[] GetTemporaryIconUnLockArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x002A4CCC File Offset: 0x002A2ECC
		public string TemporaryIconlock
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x002A4D04 File Offset: 0x002A2F04
		public Span<byte> GetTemporaryIconlockBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x002A4D14 File Offset: 0x002A2F14
		public byte[] GetTemporaryIconlockArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06009AE6 RID: 39654 RVA: 0x002A4D2C File Offset: 0x002A2F2C
		public int BeginTimeStamp
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

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06009AE7 RID: 39655 RVA: 0x002A4D6C File Offset: 0x002A2F6C
		public int LockCon
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06009AE8 RID: 39656 RVA: 0x002A4DAC File Offset: 0x002A2FAC
		public int MonsterInfoId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06009AE9 RID: 39657 RVA: 0x002A4DEC File Offset: 0x002A2FEC
		public int NightMareDetectionId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x002A4E29 File Offset: 0x002A3029
		[NullableContext(1)]
		public string[] BlueprintTypeList()
		{
			return this.BlueprintTypeListIter().ToArray<string>();
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x002A4E36 File Offset: 0x002A3036
		[NullableContext(1)]
		public IEnumerable<string> BlueprintTypeListIter()
		{
			MonsterDetection.<BlueprintTypeListIter>d__64 <BlueprintTypeListIter>d__ = new MonsterDetection.<BlueprintTypeListIter>d__64(-2);
			<BlueprintTypeListIter>d__.<>3__<>4__this = this;
			return <BlueprintTypeListIter>d__;
		}

		// Token: 0x0400549B RID: 21659
		private Table __p;
	}
}
