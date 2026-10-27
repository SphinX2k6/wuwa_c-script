using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001188 RID: 4488
	public struct UiShow : IFlatbufferObject
	{
		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x0033F29E File Offset: 0x0033D49E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E682 RID: 59010 RVA: 0x0033F2AB File Offset: 0x0033D4AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E683 RID: 59011 RVA: 0x0033F2B4 File Offset: 0x0033D4B4
		public static UiShow GetRootAsUiShow(ByteBuffer _bb)
		{
			return UiShow.GetRootAsUiShow(_bb, default(UiShow));
		}

		// Token: 0x0600E684 RID: 59012 RVA: 0x0033F2D0 File Offset: 0x0033D4D0
		public static UiShow GetRootAsUiShow(ByteBuffer _bb, UiShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E685 RID: 59013 RVA: 0x0033F2ED File Offset: 0x0033D4ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x0033F2FC File Offset: 0x0033D4FC
		public UiShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600E687 RID: 59015 RVA: 0x0033F30C File Offset: 0x0033D50C
		public string ViewName
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

		// Token: 0x0600E688 RID: 59016 RVA: 0x0033F343 File Offset: 0x0033D543
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E689 RID: 59017 RVA: 0x0033F352 File Offset: 0x0033D552
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600E68A RID: 59018 RVA: 0x0033F36C File Offset: 0x0033D56C
		public string MemoryModuleTag
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

		// Token: 0x0600E68B RID: 59019 RVA: 0x0033F3A3 File Offset: 0x0033D5A3
		public Span<byte> GetMemoryModuleTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E68C RID: 59020 RVA: 0x0033F3B2 File Offset: 0x0033D5B2
		public byte[] GetMemoryModuleTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600E68D RID: 59021 RVA: 0x0033F3CC File Offset: 0x0033D5CC
		public string Type
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

		// Token: 0x0600E68E RID: 59022 RVA: 0x0033F403 File Offset: 0x0033D603
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x0033F412 File Offset: 0x0033D612
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600E690 RID: 59024 RVA: 0x0033F42C File Offset: 0x0033D62C
		public bool LoadAsync
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600E691 RID: 59025 RVA: 0x0033F46C File Offset: 0x0033D66C
		public int ShowCursorType
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

		// Token: 0x0600E692 RID: 59026 RVA: 0x0033F4AC File Offset: 0x0033D6AC
		public string ObstructUi(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600E693 RID: 59027 RVA: 0x0033F4E8 File Offset: 0x0033D6E8
		public int ObstructUiLength
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

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600E694 RID: 59028 RVA: 0x0033F514 File Offset: 0x0033D714
		public string EffectStart
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

		// Token: 0x0600E695 RID: 59029 RVA: 0x0033F54C File Offset: 0x0033D74C
		public Span<byte> GetEffectStartBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x0033F55C File Offset: 0x0033D75C
		public byte[] GetEffectStartArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600E697 RID: 59031 RVA: 0x0033F574 File Offset: 0x0033D774
		public string EffectBone
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

		// Token: 0x0600E698 RID: 59032 RVA: 0x0033F5AC File Offset: 0x0033D7AC
		public Span<byte> GetEffectBoneBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x0033F5BC File Offset: 0x0033D7BC
		public byte[] GetEffectBoneArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600E69A RID: 59034 RVA: 0x0033F5D4 File Offset: 0x0033D7D4
		public string MontageStart
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

		// Token: 0x0600E69B RID: 59035 RVA: 0x0033F60C File Offset: 0x0033D80C
		public Span<byte> GetMontageStartBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x0033F61C File Offset: 0x0033D81C
		public byte[] GetMontageStartArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600E69D RID: 59037 RVA: 0x0033F634 File Offset: 0x0033D834
		public string AudioEvent
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

		// Token: 0x0600E69E RID: 59038 RVA: 0x0033F66C File Offset: 0x0033D86C
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E69F RID: 59039 RVA: 0x0033F67C File Offset: 0x0033D87C
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x0033F694 File Offset: 0x0033D894
		public string OpenAudioEvent
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

		// Token: 0x0600E6A1 RID: 59041 RVA: 0x0033F6CC File Offset: 0x0033D8CC
		public Span<byte> GetOpenAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E6A2 RID: 59042 RVA: 0x0033F6DC File Offset: 0x0033D8DC
		public byte[] GetOpenAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600E6A3 RID: 59043 RVA: 0x0033F6F4 File Offset: 0x0033D8F4
		public string LoopAudioEvent
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

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x0033F72C File Offset: 0x0033D92C
		public Span<byte> GetLoopAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x0033F73C File Offset: 0x0033D93C
		public byte[] GetLoopAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600E6A6 RID: 59046 RVA: 0x0033F754 File Offset: 0x0033D954
		public string CloseAudioEvent
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

		// Token: 0x0600E6A7 RID: 59047 RVA: 0x0033F78C File Offset: 0x0033D98C
		public Span<byte> GetCloseAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x0033F79C File Offset: 0x0033D99C
		public byte[] GetCloseAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600E6A9 RID: 59049 RVA: 0x0033F7B4 File Offset: 0x0033D9B4
		public bool KeepLoopEvent
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600E6AA RID: 59050 RVA: 0x0033F7F4 File Offset: 0x0033D9F4
		public int DelayTime
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

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x0033F834 File Offset: 0x0033DA34
		public int EffectDelayTime
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

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x0033F874 File Offset: 0x0033DA74
		public bool SetMaskActive
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600E6AD RID: 59053 RVA: 0x0033F8B4 File Offset: 0x0033DAB4
		public float TimeDilation
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0033F8F8 File Offset: 0x0033DAF8
		public bool IsAllowFightInput
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x0600E6AF RID: 59055 RVA: 0x0033F938 File Offset: 0x0033DB38
		public bool CanOpenViewByShortcutKey
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x0033F978 File Offset: 0x0033DB78
		public bool IsShortKeysExitView
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x0033F9B8 File Offset: 0x0033DBB8
		public string ScenePointTag
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x0033F9F0 File Offset: 0x0033DBF0
		public Span<byte> GetScenePointTagBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600E6B3 RID: 59059 RVA: 0x0033FA00 File Offset: 0x0033DC00
		public byte[] GetScenePointTagArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x0033FA18 File Offset: 0x0033DC18
		public bool NeedGC
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600E6B5 RID: 59061 RVA: 0x0033FA58 File Offset: 0x0033DC58
		public bool IsFullScreen
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x0033FA98 File Offset: 0x0033DC98
		public int CommonPopBg
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x0033FAD8 File Offset: 0x0033DCD8
		public string CommonPopBgKey
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E6B8 RID: 59064 RVA: 0x0033FB10 File Offset: 0x0033DD10
		public Span<byte> GetCommonPopBgKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x0033FB20 File Offset: 0x0033DD20
		public byte[] GetCommonPopBgKeyArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x0033FB38 File Offset: 0x0033DD38
		public string ScenePath
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x0033FB70 File Offset: 0x0033DD70
		public Span<byte> GetScenePathBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x0033FB80 File Offset: 0x0033DD80
		public byte[] GetScenePathArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E6BD RID: 59069 RVA: 0x0033FB98 File Offset: 0x0033DD98
		public string ExtraScenePath(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x0033FBD4 File Offset: 0x0033DDD4
		public int ExtraScenePathLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600E6BF RID: 59071 RVA: 0x0033FC00 File Offset: 0x0033DE00
		public string SceneId
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E6C0 RID: 59072 RVA: 0x0033FC38 File Offset: 0x0033DE38
		public Span<byte> GetSceneIdBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600E6C1 RID: 59073 RVA: 0x0033FC48 File Offset: 0x0033DE48
		public byte[] GetSceneIdArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x0600E6C2 RID: 59074 RVA: 0x0033FC60 File Offset: 0x0033DE60
		public bool IsPermanent
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600E6C3 RID: 59075 RVA: 0x0033FCA0 File Offset: 0x0033DEA0
		public BlackScreen? StartBlackScreen
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new BlackScreen?(default(BlackScreen).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x0033FD00 File Offset: 0x0033DF00
		public BlackScreen? CloseBlackScreen
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new BlackScreen?(default(BlackScreen).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x0600E6C5 RID: 59077 RVA: 0x0033FD60 File Offset: 0x0033DF60
		public bool SkipAnim
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x0033FDA0 File Offset: 0x0033DFA0
		public bool PartialBlur
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600E6C7 RID: 59079 RVA: 0x0033FDE0 File Offset: 0x0033DFE0
		public string AudioFilter
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x0033FE18 File Offset: 0x0033E018
		public Span<byte> GetAudioFilterBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600E6C9 RID: 59081 RVA: 0x0033FE28 File Offset: 0x0033E028
		public byte[] GetAudioFilterArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x0033FE40 File Offset: 0x0033E040
		public bool AllowAutoMoving
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600E6CB RID: 59083 RVA: 0x0033FE80 File Offset: 0x0033E080
		public int FunctionCondition
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x0033FEC0 File Offset: 0x0033E0C0
		public int HomeBtnShowType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0600E6CD RID: 59085 RVA: 0x0033FF00 File Offset: 0x0033E100
		public int HomeBtnStyle
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0033FF40 File Offset: 0x0033E140
		public bool AllowAutoMotor
		{
			get
			{
				int num = this.__p.__offset(82);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600E6CF RID: 59087 RVA: 0x0033FF80 File Offset: 0x0033E180
		public int LockWorldRender
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600E6D0 RID: 59088 RVA: 0x0033FFC0 File Offset: 0x0033E1C0
		public bool LockFrameRate
		{
			get
			{
				int num = this.__p.__offset(86);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x00340000 File Offset: 0x0033E200
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraScenePathIter()或GetExtraScenePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraScenePath()
		{
			return this.ExtraScenePathIter().ToArray<string>();
		}

		// Token: 0x0600E6D2 RID: 59090 RVA: 0x0034000D File Offset: 0x0033E20D
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraScenePathIter()
		{
			UiShow.<ExtraScenePathIter>d__125 <ExtraScenePathIter>d__ = new UiShow.<ExtraScenePathIter>d__125(-2);
			<ExtraScenePathIter>d__.<>3__<>4__this = this;
			return <ExtraScenePathIter>d__;
		}

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x00340022 File Offset: 0x0033E222
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ObstructUiIter()或GetObstructUiBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ObstructUi()
		{
			return this.ObstructUiIter().ToArray<string>();
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x0034002F File Offset: 0x0033E22F
		[NullableContext(1)]
		public readonly IEnumerable<string> ObstructUiIter()
		{
			UiShow.<ObstructUiIter>d__127 <ObstructUiIter>d__ = new UiShow.<ObstructUiIter>d__127(-2);
			<ObstructUiIter>d__.<>3__<>4__this = this;
			return <ObstructUiIter>d__;
		}

		// Token: 0x040052D1 RID: 21201
		private Table __p;
	}
}
