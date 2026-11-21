using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012BE RID: 4798
	public struct UiShow : IFlatbufferObject
	{
		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x0600F3EF RID: 62447 RVA: 0x0036A096 File Offset: 0x00368296
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F3F0 RID: 62448 RVA: 0x0036A0A3 File Offset: 0x003682A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F3F1 RID: 62449 RVA: 0x0036A0AC File Offset: 0x003682AC
		public static UiShow GetRootAsUiShow(ByteBuffer _bb)
		{
			return UiShow.GetRootAsUiShow(_bb, default(UiShow));
		}

		// Token: 0x0600F3F2 RID: 62450 RVA: 0x0036A0C8 File Offset: 0x003682C8
		public static UiShow GetRootAsUiShow(ByteBuffer _bb, UiShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F3F3 RID: 62451 RVA: 0x0036A0E5 File Offset: 0x003682E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F3F4 RID: 62452 RVA: 0x0036A0F4 File Offset: 0x003682F4
		public UiShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x0600F3F5 RID: 62453 RVA: 0x0036A104 File Offset: 0x00368304
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

		// Token: 0x0600F3F6 RID: 62454 RVA: 0x0036A13B File Offset: 0x0036833B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F3F7 RID: 62455 RVA: 0x0036A14A File Offset: 0x0036834A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x0600F3F8 RID: 62456 RVA: 0x0036A164 File Offset: 0x00368364
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

		// Token: 0x0600F3F9 RID: 62457 RVA: 0x0036A19B File Offset: 0x0036839B
		public Span<byte> GetMemoryModuleTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F3FA RID: 62458 RVA: 0x0036A1AA File Offset: 0x003683AA
		public byte[] GetMemoryModuleTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x0600F3FB RID: 62459 RVA: 0x0036A1C4 File Offset: 0x003683C4
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

		// Token: 0x0600F3FC RID: 62460 RVA: 0x0036A1FB File Offset: 0x003683FB
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F3FD RID: 62461 RVA: 0x0036A20A File Offset: 0x0036840A
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x0600F3FE RID: 62462 RVA: 0x0036A224 File Offset: 0x00368424
		public bool LoadAsync
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x0600F3FF RID: 62463 RVA: 0x0036A264 File Offset: 0x00368464
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

		// Token: 0x0600F400 RID: 62464 RVA: 0x0036A2A4 File Offset: 0x003684A4
		public string ObstructUi(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x0600F401 RID: 62465 RVA: 0x0036A2E0 File Offset: 0x003684E0
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

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x0600F402 RID: 62466 RVA: 0x0036A30C File Offset: 0x0036850C
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

		// Token: 0x0600F403 RID: 62467 RVA: 0x0036A344 File Offset: 0x00368544
		public Span<byte> GetEffectStartBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F404 RID: 62468 RVA: 0x0036A354 File Offset: 0x00368554
		public byte[] GetEffectStartArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x0600F405 RID: 62469 RVA: 0x0036A36C File Offset: 0x0036856C
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

		// Token: 0x0600F406 RID: 62470 RVA: 0x0036A3A4 File Offset: 0x003685A4
		public Span<byte> GetEffectBoneBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F407 RID: 62471 RVA: 0x0036A3B4 File Offset: 0x003685B4
		public byte[] GetEffectBoneArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x0600F408 RID: 62472 RVA: 0x0036A3CC File Offset: 0x003685CC
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

		// Token: 0x0600F409 RID: 62473 RVA: 0x0036A404 File Offset: 0x00368604
		public Span<byte> GetMontageStartBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600F40A RID: 62474 RVA: 0x0036A414 File Offset: 0x00368614
		public byte[] GetMontageStartArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x0600F40B RID: 62475 RVA: 0x0036A42C File Offset: 0x0036862C
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

		// Token: 0x0600F40C RID: 62476 RVA: 0x0036A464 File Offset: 0x00368664
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600F40D RID: 62477 RVA: 0x0036A474 File Offset: 0x00368674
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0600F40E RID: 62478 RVA: 0x0036A48C File Offset: 0x0036868C
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

		// Token: 0x0600F40F RID: 62479 RVA: 0x0036A4C4 File Offset: 0x003686C4
		public Span<byte> GetOpenAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600F410 RID: 62480 RVA: 0x0036A4D4 File Offset: 0x003686D4
		public byte[] GetOpenAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0600F411 RID: 62481 RVA: 0x0036A4EC File Offset: 0x003686EC
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

		// Token: 0x0600F412 RID: 62482 RVA: 0x0036A524 File Offset: 0x00368724
		public Span<byte> GetLoopAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600F413 RID: 62483 RVA: 0x0036A534 File Offset: 0x00368734
		public byte[] GetLoopAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x0600F414 RID: 62484 RVA: 0x0036A54C File Offset: 0x0036874C
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

		// Token: 0x0600F415 RID: 62485 RVA: 0x0036A584 File Offset: 0x00368784
		public Span<byte> GetCloseAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600F416 RID: 62486 RVA: 0x0036A594 File Offset: 0x00368794
		public byte[] GetCloseAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x0600F417 RID: 62487 RVA: 0x0036A5AC File Offset: 0x003687AC
		public bool KeepLoopEvent
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x0600F418 RID: 62488 RVA: 0x0036A5EC File Offset: 0x003687EC
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

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x0600F419 RID: 62489 RVA: 0x0036A62C File Offset: 0x0036882C
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

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x0600F41A RID: 62490 RVA: 0x0036A66C File Offset: 0x0036886C
		public bool SetMaskActive
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0600F41B RID: 62491 RVA: 0x0036A6AC File Offset: 0x003688AC
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

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x0600F41C RID: 62492 RVA: 0x0036A6F0 File Offset: 0x003688F0
		public bool IsAllowFightInput
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x0600F41D RID: 62493 RVA: 0x0036A730 File Offset: 0x00368930
		public bool CanOpenViewByShortcutKey
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x0600F41E RID: 62494 RVA: 0x0036A770 File Offset: 0x00368970
		public bool IsShortKeysExitView
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x0600F41F RID: 62495 RVA: 0x0036A7B0 File Offset: 0x003689B0
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

		// Token: 0x0600F420 RID: 62496 RVA: 0x0036A7E8 File Offset: 0x003689E8
		public Span<byte> GetScenePointTagBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600F421 RID: 62497 RVA: 0x0036A7F8 File Offset: 0x003689F8
		public byte[] GetScenePointTagArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x0600F422 RID: 62498 RVA: 0x0036A810 File Offset: 0x00368A10
		public bool NeedGC
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x0600F423 RID: 62499 RVA: 0x0036A850 File Offset: 0x00368A50
		public bool IsFullScreen
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x0600F424 RID: 62500 RVA: 0x0036A890 File Offset: 0x00368A90
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

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x0600F425 RID: 62501 RVA: 0x0036A8D0 File Offset: 0x00368AD0
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

		// Token: 0x0600F426 RID: 62502 RVA: 0x0036A908 File Offset: 0x00368B08
		public Span<byte> GetCommonPopBgKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600F427 RID: 62503 RVA: 0x0036A918 File Offset: 0x00368B18
		public byte[] GetCommonPopBgKeyArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x0600F428 RID: 62504 RVA: 0x0036A930 File Offset: 0x00368B30
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

		// Token: 0x0600F429 RID: 62505 RVA: 0x0036A968 File Offset: 0x00368B68
		public Span<byte> GetScenePathBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600F42A RID: 62506 RVA: 0x0036A978 File Offset: 0x00368B78
		public byte[] GetScenePathArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F42B RID: 62507 RVA: 0x0036A990 File Offset: 0x00368B90
		public string ExtraScenePath(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x0600F42C RID: 62508 RVA: 0x0036A9CC File Offset: 0x00368BCC
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

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x0600F42D RID: 62509 RVA: 0x0036A9F8 File Offset: 0x00368BF8
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

		// Token: 0x0600F42E RID: 62510 RVA: 0x0036AA30 File Offset: 0x00368C30
		public Span<byte> GetSceneIdBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600F42F RID: 62511 RVA: 0x0036AA40 File Offset: 0x00368C40
		public byte[] GetSceneIdArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x0600F430 RID: 62512 RVA: 0x0036AA58 File Offset: 0x00368C58
		public bool IsPermanent
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x0600F431 RID: 62513 RVA: 0x0036AA98 File Offset: 0x00368C98
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

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x0600F432 RID: 62514 RVA: 0x0036AAF8 File Offset: 0x00368CF8
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

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x0600F433 RID: 62515 RVA: 0x0036AB58 File Offset: 0x00368D58
		public bool SkipAnim
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x0600F434 RID: 62516 RVA: 0x0036AB98 File Offset: 0x00368D98
		public bool PartialBlur
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x0600F435 RID: 62517 RVA: 0x0036ABD8 File Offset: 0x00368DD8
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

		// Token: 0x0600F436 RID: 62518 RVA: 0x0036AC10 File Offset: 0x00368E10
		public Span<byte> GetAudioFilterBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600F437 RID: 62519 RVA: 0x0036AC20 File Offset: 0x00368E20
		public byte[] GetAudioFilterArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x0600F438 RID: 62520 RVA: 0x0036AC38 File Offset: 0x00368E38
		public bool AllowAutoMoving
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x0600F439 RID: 62521 RVA: 0x0036AC78 File Offset: 0x00368E78
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

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x0600F43A RID: 62522 RVA: 0x0036ACB8 File Offset: 0x00368EB8
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

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x0600F43B RID: 62523 RVA: 0x0036ACF8 File Offset: 0x00368EF8
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

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x0600F43C RID: 62524 RVA: 0x0036AD38 File Offset: 0x00368F38
		public bool AllowAutoMotor
		{
			get
			{
				int num = this.__p.__offset(82);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x0600F43D RID: 62525 RVA: 0x0036AD78 File Offset: 0x00368F78
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

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x0600F43E RID: 62526 RVA: 0x0036ADB8 File Offset: 0x00368FB8
		public bool LockFrameRate
		{
			get
			{
				int num = this.__p.__offset(86);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600F43F RID: 62527 RVA: 0x0036ADF8 File Offset: 0x00368FF8
		[NullableContext(1)]
		public string[] ExtraScenePath()
		{
			return this.ExtraScenePathIter().ToArray<string>();
		}

		// Token: 0x0600F440 RID: 62528 RVA: 0x0036AE05 File Offset: 0x00369005
		[NullableContext(1)]
		public IEnumerable<string> ExtraScenePathIter()
		{
			UiShow.<ExtraScenePathIter>d__125 <ExtraScenePathIter>d__ = new UiShow.<ExtraScenePathIter>d__125(-2);
			<ExtraScenePathIter>d__.<>3__<>4__this = this;
			return <ExtraScenePathIter>d__;
		}

		// Token: 0x0600F441 RID: 62529 RVA: 0x0036AE1A File Offset: 0x0036901A
		[NullableContext(1)]
		public string[] ObstructUi()
		{
			return this.ObstructUiIter().ToArray<string>();
		}

		// Token: 0x0600F442 RID: 62530 RVA: 0x0036AE27 File Offset: 0x00369027
		[NullableContext(1)]
		public IEnumerable<string> ObstructUiIter()
		{
			UiShow.<ObstructUiIter>d__127 <ObstructUiIter>d__ = new UiShow.<ObstructUiIter>d__127(-2);
			<ObstructUiIter>d__.<>3__<>4__this = this;
			return <ObstructUiIter>d__;
		}

		// Token: 0x04005914 RID: 22804
		private Table __p;
	}
}
