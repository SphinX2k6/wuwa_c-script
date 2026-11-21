using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD2 RID: 3538
	public struct GamePlayScanComposite : IFlatbufferObject
	{
		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x002676F5 File Offset: 0x002658F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F70 RID: 32624 RVA: 0x00267702 File Offset: 0x00265902
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F71 RID: 32625 RVA: 0x0026770C File Offset: 0x0026590C
		public static GamePlayScanComposite GetRootAsGamePlayScanComposite(ByteBuffer _bb)
		{
			return GamePlayScanComposite.GetRootAsGamePlayScanComposite(_bb, default(GamePlayScanComposite));
		}

		// Token: 0x06007F72 RID: 32626 RVA: 0x00267728 File Offset: 0x00265928
		public static GamePlayScanComposite GetRootAsGamePlayScanComposite(ByteBuffer _bb, GamePlayScanComposite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F73 RID: 32627 RVA: 0x00267745 File Offset: 0x00265945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x00267754 File Offset: 0x00265954
		public GamePlayScanComposite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06007F75 RID: 32629 RVA: 0x00267764 File Offset: 0x00265964
		public int UId
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

		// Token: 0x06007F76 RID: 32630 RVA: 0x002677A0 File Offset: 0x002659A0
		public int ScanInfos(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x002677E0 File Offset: 0x002659E0
		public int ScanInfosLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x0026780B File Offset: 0x00265A0B
		public Span<int> GetScanInfosBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007F79 RID: 32633 RVA: 0x0026781A File Offset: 0x00265A1A
		public int[] GetScanInfosArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06007F7A RID: 32634 RVA: 0x00267834 File Offset: 0x00265A34
		public string ItemMaterialDataPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F7B RID: 32635 RVA: 0x0026786B File Offset: 0x00265A6B
		public Span<byte> GetItemMaterialDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007F7C RID: 32636 RVA: 0x0026787A File Offset: 0x00265A7A
		public byte[] GetItemMaterialDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06007F7D RID: 32637 RVA: 0x00267894 File Offset: 0x00265A94
		public string NearVoiceEffectPath
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

		// Token: 0x06007F7E RID: 32638 RVA: 0x002678CC File Offset: 0x00265ACC
		public Span<byte> GetNearVoiceEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x002678DC File Offset: 0x00265ADC
		public byte[] GetNearVoiceEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06007F80 RID: 32640 RVA: 0x002678F4 File Offset: 0x00265AF4
		public string FarVoiceEffectPath
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

		// Token: 0x06007F81 RID: 32641 RVA: 0x0026792C File Offset: 0x00265B2C
		public Span<byte> GetFarVoiceEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x0026793C File Offset: 0x00265B3C
		public byte[] GetFarVoiceEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06007F83 RID: 32643 RVA: 0x00267954 File Offset: 0x00265B54
		public string ScanConcealEffectPath
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

		// Token: 0x06007F84 RID: 32644 RVA: 0x0026798C File Offset: 0x00265B8C
		public Span<byte> GetScanConcealEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x0026799C File Offset: 0x00265B9C
		public byte[] GetScanConcealEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06007F86 RID: 32646 RVA: 0x002679B4 File Offset: 0x00265BB4
		public float InteractionEffectInterval
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 8f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06007F87 RID: 32647 RVA: 0x002679F8 File Offset: 0x00265BF8
		public bool ShowDistance
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06007F88 RID: 32648 RVA: 0x00267A38 File Offset: 0x00265C38
		public bool ShowInteractionEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06007F89 RID: 32649 RVA: 0x00267A78 File Offset: 0x00265C78
		public bool ClampToEllipse
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06007F8A RID: 32650 RVA: 0x00267AB8 File Offset: 0x00265CB8
		public string ScanAudioEvent
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

		// Token: 0x06007F8B RID: 32651 RVA: 0x00267AF0 File Offset: 0x00265CF0
		public Span<byte> GetScanAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x00267B00 File Offset: 0x00265D00
		public byte[] GetScanAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06007F8D RID: 32653 RVA: 0x00267B18 File Offset: 0x00265D18
		public bool TriggerRoleAudio
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00267B58 File Offset: 0x00265D58
		[NullableContext(1)]
		public int[] ScanInfos()
		{
			return this.GetScanInfosArray();
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x00267B60 File Offset: 0x00265D60
		[NullableContext(1)]
		public IEnumerable<int> ScanInfosIter()
		{
			GamePlayScanComposite.<ScanInfosIter>d__46 <ScanInfosIter>d__ = new GamePlayScanComposite.<ScanInfosIter>d__46(-2);
			<ScanInfosIter>d__.<>3__<>4__this = this;
			return <ScanInfosIter>d__;
		}

		// Token: 0x04005343 RID: 21315
		private Table __p;
	}
}
