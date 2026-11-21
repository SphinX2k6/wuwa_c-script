using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCE RID: 3534
	public struct GameplayCue : IFlatbufferObject
	{
		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06007F0B RID: 32523 RVA: 0x00266718 File Offset: 0x00264918
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x00266725 File Offset: 0x00264925
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x0026672C File Offset: 0x0026492C
		public static GameplayCue GetRootAsGameplayCue(ByteBuffer _bb)
		{
			return GameplayCue.GetRootAsGameplayCue(_bb, default(GameplayCue));
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x00266748 File Offset: 0x00264948
		public static GameplayCue GetRootAsGameplayCue(ByteBuffer _bb, GameplayCue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x00266765 File Offset: 0x00264965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x00266774 File Offset: 0x00264974
		public GameplayCue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06007F11 RID: 32529 RVA: 0x00266784 File Offset: 0x00264984
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06007F12 RID: 32530 RVA: 0x002667CC File Offset: 0x002649CC
		public string Path
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

		// Token: 0x06007F13 RID: 32531 RVA: 0x00266803 File Offset: 0x00264A03
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007F14 RID: 32532 RVA: 0x00266812 File Offset: 0x00264A12
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06007F15 RID: 32533 RVA: 0x0026682C File Offset: 0x00264A2C
		public int CueType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06007F16 RID: 32534 RVA: 0x00266868 File Offset: 0x00264A68
		public int Comp
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

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06007F17 RID: 32535 RVA: 0x002668A8 File Offset: 0x00264AA8
		public string CompName
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

		// Token: 0x06007F18 RID: 32536 RVA: 0x002668E0 File Offset: 0x00264AE0
		public Span<byte> GetCompNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x002668F0 File Offset: 0x00264AF0
		public byte[] GetCompNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x00266908 File Offset: 0x00264B08
		public string Socket
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

		// Token: 0x06007F1B RID: 32539 RVA: 0x00266940 File Offset: 0x00264B40
		public Span<byte> GetSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x00266950 File Offset: 0x00264B50
		public byte[] GetSocketArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06007F1D RID: 32541 RVA: 0x00266968 File Offset: 0x00264B68
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06007F1E RID: 32542 RVA: 0x002669C8 File Offset: 0x00264BC8
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06007F1F RID: 32543 RVA: 0x00266A28 File Offset: 0x00264C28
		public Vector? Scale
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06007F20 RID: 32544 RVA: 0x00266A88 File Offset: 0x00264C88
		public int LocRule
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

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06007F21 RID: 32545 RVA: 0x00266AC8 File Offset: 0x00264CC8
		public int RotaRule
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06007F22 RID: 32546 RVA: 0x00266B08 File Offset: 0x00264D08
		public int SclRule
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

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x00266B48 File Offset: 0x00264D48
		public int EndRule
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

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06007F24 RID: 32548 RVA: 0x00266B88 File Offset: 0x00264D88
		public int Magni
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06007F25 RID: 32549 RVA: 0x00266BC8 File Offset: 0x00264DC8
		public int AttrId
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

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06007F26 RID: 32550 RVA: 0x00266C08 File Offset: 0x00264E08
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x00266C40 File Offset: 0x00264E40
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x00266C50 File Offset: 0x00264E50
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06007F29 RID: 32553 RVA: 0x00266C68 File Offset: 0x00264E68
		public int Max
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06007F2A RID: 32554 RVA: 0x00266CAC File Offset: 0x00264EAC
		public int Min
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

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06007F2B RID: 32555 RVA: 0x00266CEC File Offset: 0x00264EEC
		public bool BListenAttr
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x00266D2C File Offset: 0x00264F2C
		public bool BSoftFollow
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x00266D6C File Offset: 0x00264F6C
		public bool BLockRevolution
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x00266DAC File Offset: 0x00264FAC
		public Vector? LockRotation
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06007F2F RID: 32559 RVA: 0x00266E0C File Offset: 0x0026500C
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06007F30 RID: 32560 RVA: 0x00266E4C File Offset: 0x0026504C
		public int InterpSpeed
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06007F31 RID: 32561 RVA: 0x00266E8C File Offset: 0x0026508C
		public int FarthestDistance
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06007F32 RID: 32562 RVA: 0x00266ECC File Offset: 0x002650CC
		public Vector? FaultTolerance
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x00266F2C File Offset: 0x0026512C
		public float TargetScaleUp(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06007F34 RID: 32564 RVA: 0x00266F70 File Offset: 0x00265170
		public int TargetScaleUpLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x00266F9C File Offset: 0x0026519C
		public Span<float> GetTargetScaleUpBytes()
		{
			return this.__p.__vector_as_span<float>(56, 4);
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x00266FAC File Offset: 0x002651AC
		public float[] GetTargetScaleUpArray()
		{
			return this.__p.__vector_as_array<float>(56) ?? Array.Empty<float>();
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x00266FC4 File Offset: 0x002651C4
		public string Resources(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06007F38 RID: 32568 RVA: 0x00267000 File Offset: 0x00265200
		public int ResourcesLength
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

		// Token: 0x06007F39 RID: 32569 RVA: 0x0026702C File Offset: 0x0026522C
		public string Parameters(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06007F3A RID: 32570 RVA: 0x00267068 File Offset: 0x00265268
		public int ParametersLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06007F3B RID: 32571 RVA: 0x00267094 File Offset: 0x00265294
		public int Group
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06007F3C RID: 32572 RVA: 0x002670D4 File Offset: 0x002652D4
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06007F3D RID: 32573 RVA: 0x00267114 File Offset: 0x00265314
		public int HideRule
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x00267151 File Offset: 0x00265351
		[NullableContext(1)]
		public string[] Parameters()
		{
			return this.ParametersIter().ToArray<string>();
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x0026715E File Offset: 0x0026535E
		[NullableContext(1)]
		public IEnumerable<string> ParametersIter()
		{
			GameplayCue.<ParametersIter>d__86 <ParametersIter>d__ = new GameplayCue.<ParametersIter>d__86(-2);
			<ParametersIter>d__.<>3__<>4__this = this;
			return <ParametersIter>d__;
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x00267173 File Offset: 0x00265373
		[NullableContext(1)]
		public string[] Resources()
		{
			return this.ResourcesIter().ToArray<string>();
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x00267180 File Offset: 0x00265380
		[NullableContext(1)]
		public IEnumerable<string> ResourcesIter()
		{
			GameplayCue.<ResourcesIter>d__88 <ResourcesIter>d__ = new GameplayCue.<ResourcesIter>d__88(-2);
			<ResourcesIter>d__.<>3__<>4__this = this;
			return <ResourcesIter>d__;
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00267195 File Offset: 0x00265395
		[NullableContext(1)]
		public float[] TargetScaleUp()
		{
			return this.GetTargetScaleUpArray();
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x0026719D File Offset: 0x0026539D
		[NullableContext(1)]
		public IEnumerable<float> TargetScaleUpIter()
		{
			GameplayCue.<TargetScaleUpIter>d__90 <TargetScaleUpIter>d__ = new GameplayCue.<TargetScaleUpIter>d__90(-2);
			<TargetScaleUpIter>d__.<>3__<>4__this = this;
			return <TargetScaleUpIter>d__;
		}

		// Token: 0x0400533F RID: 21311
		private Table __p;
	}
}
