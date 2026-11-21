using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEA RID: 3306
	public struct DrinksRoleInvite : IFlatbufferObject
	{
		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x00238CB2 File Offset: 0x00236EB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x00238CBF File Offset: 0x00236EBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00238CC8 File Offset: 0x00236EC8
		public static DrinksRoleInvite GetRootAsDrinksRoleInvite(ByteBuffer _bb)
		{
			return DrinksRoleInvite.GetRootAsDrinksRoleInvite(_bb, default(DrinksRoleInvite));
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00238CE4 File Offset: 0x00236EE4
		public static DrinksRoleInvite GetRootAsDrinksRoleInvite(ByteBuffer _bb, DrinksRoleInvite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00238D01 File Offset: 0x00236F01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00238D10 File Offset: 0x00236F10
		public DrinksRoleInvite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06006AA8 RID: 27304 RVA: 0x00238D20 File Offset: 0x00236F20
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

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x00238D5C File Offset: 0x00236F5C
		public int RoleId
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x00238D98 File Offset: 0x00236F98
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

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x00238DD4 File Offset: 0x00236FD4
		public int UnlockLevelConfigId
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

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x00238E14 File Offset: 0x00237014
		public string LockTxt
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

		// Token: 0x06006AAD RID: 27309 RVA: 0x00238E4C File Offset: 0x0023704C
		public Span<byte> GetLockTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x00238E5C File Offset: 0x0023705C
		public byte[] GetLockTxtArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06006AAF RID: 27311 RVA: 0x00238E74 File Offset: 0x00237074
		public int FirstAward
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x00238EB4 File Offset: 0x002370B4
		public int DrinksFavor
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

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00238EF4 File Offset: 0x002370F4
		public int DrinksFavorBatching(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x00238F34 File Offset: 0x00237134
		public int DrinksFavorBatchingLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x00238F60 File Offset: 0x00237160
		public Span<int> GetDrinksFavorBatchingBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x00238F70 File Offset: 0x00237170
		public int[] GetDrinksFavorBatchingArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x00238F88 File Offset: 0x00237188
		public int DrinksFavorOrnament
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

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x00238FC8 File Offset: 0x002371C8
		public string DrinksLock
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

		// Token: 0x06006AB7 RID: 27319 RVA: 0x00239000 File Offset: 0x00237200
		public Span<byte> GetDrinksLockBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00239010 File Offset: 0x00237210
		public byte[] GetDrinksLockArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06006AB9 RID: 27321 RVA: 0x00239028 File Offset: 0x00237228
		public string DrinksUnlock
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

		// Token: 0x06006ABA RID: 27322 RVA: 0x00239060 File Offset: 0x00237260
		public Span<byte> GetDrinksUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x00239070 File Offset: 0x00237270
		public byte[] GetDrinksUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x00239088 File Offset: 0x00237288
		public int CameraId
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

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06006ABD RID: 27325 RVA: 0x002390C8 File Offset: 0x002372C8
		public string DrinkSequence
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

		// Token: 0x06006ABE RID: 27326 RVA: 0x00239100 File Offset: 0x00237300
		public Span<byte> GetDrinkSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x00239110 File Offset: 0x00237310
		public byte[] GetDrinkSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x00239128 File Offset: 0x00237328
		public string AfterTalk
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

		// Token: 0x06006AC1 RID: 27329 RVA: 0x00239160 File Offset: 0x00237360
		public Span<byte> GetAfterTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x00239170 File Offset: 0x00237370
		public byte[] GetAfterTalkArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x00239188 File Offset: 0x00237388
		public int AfterTalkStateId(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06006AC4 RID: 27332 RVA: 0x002391C8 File Offset: 0x002373C8
		public int AfterTalkStateIdLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x002391F4 File Offset: 0x002373F4
		public Span<int> GetAfterTalkStateIdBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x00239204 File Offset: 0x00237404
		public int[] GetAfterTalkStateIdArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x0023921C File Offset: 0x0023741C
		public string CupMesh
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

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00239254 File Offset: 0x00237454
		public Span<byte> GetCupMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x00239264 File Offset: 0x00237464
		public byte[] GetCupMeshArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06006ACA RID: 27338 RVA: 0x0023927C File Offset: 0x0023747C
		public int CupZOffset
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

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x002392BC File Offset: 0x002374BC
		public string OrnamentCamera
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x002392F4 File Offset: 0x002374F4
		public Span<byte> GetOrnamentCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00239304 File Offset: 0x00237504
		public byte[] GetOrnamentCameraArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x0023931C File Offset: 0x0023751C
		public int FlowRotation(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x0023935C File Offset: 0x0023755C
		public int FlowRotationLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00239388 File Offset: 0x00237588
		public Span<int> GetFlowRotationBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00239398 File Offset: 0x00237598
		public int[] GetFlowRotationArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x002393B0 File Offset: 0x002375B0
		[NullableContext(1)]
		public int[] AfterTalkStateId()
		{
			return this.GetAfterTalkStateIdArray();
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x002393B8 File Offset: 0x002375B8
		[NullableContext(1)]
		public IEnumerable<int> AfterTalkStateIdIter()
		{
			DrinksRoleInvite.<AfterTalkStateIdIter>d__70 <AfterTalkStateIdIter>d__ = new DrinksRoleInvite.<AfterTalkStateIdIter>d__70(-2);
			<AfterTalkStateIdIter>d__.<>3__<>4__this = this;
			return <AfterTalkStateIdIter>d__;
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x002393CD File Offset: 0x002375CD
		[NullableContext(1)]
		public int[] DrinksFavorBatching()
		{
			return this.GetDrinksFavorBatchingArray();
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x002393D5 File Offset: 0x002375D5
		[NullableContext(1)]
		public IEnumerable<int> DrinksFavorBatchingIter()
		{
			DrinksRoleInvite.<DrinksFavorBatchingIter>d__72 <DrinksFavorBatchingIter>d__ = new DrinksRoleInvite.<DrinksFavorBatchingIter>d__72(-2);
			<DrinksFavorBatchingIter>d__.<>3__<>4__this = this;
			return <DrinksFavorBatchingIter>d__;
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x002393EA File Offset: 0x002375EA
		[NullableContext(1)]
		public int[] FlowRotation()
		{
			return this.GetFlowRotationArray();
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x002393F2 File Offset: 0x002375F2
		[NullableContext(1)]
		public IEnumerable<int> FlowRotationIter()
		{
			DrinksRoleInvite.<FlowRotationIter>d__74 <FlowRotationIter>d__ = new DrinksRoleInvite.<FlowRotationIter>d__74(-2);
			<FlowRotationIter>d__.<>3__<>4__this = this;
			return <FlowRotationIter>d__;
		}

		// Token: 0x04005226 RID: 21030
		private Table __p;
	}
}
