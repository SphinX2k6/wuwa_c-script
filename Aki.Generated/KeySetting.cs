using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6F RID: 3695
	public struct KeySetting : IFlatbufferObject
	{
		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x0028627D File Offset: 0x0028447D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0028628A File Offset: 0x0028448A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x00286294 File Offset: 0x00284494
		public static KeySetting GetRootAsKeySetting(ByteBuffer _bb)
		{
			return KeySetting.GetRootAsKeySetting(_bb, default(KeySetting));
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x002862B0 File Offset: 0x002844B0
		public static KeySetting GetRootAsKeySetting(ByteBuffer _bb, KeySetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D69 RID: 36201 RVA: 0x002862CD File Offset: 0x002844CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x002862DC File Offset: 0x002844DC
		public KeySetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06008D6B RID: 36203 RVA: 0x002862EC File Offset: 0x002844EC
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

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06008D6C RID: 36204 RVA: 0x00286328 File Offset: 0x00284528
		public int TypeId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06008D6D RID: 36205 RVA: 0x00286364 File Offset: 0x00284564
		public int ExclusiveType
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

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06008D6E RID: 36206 RVA: 0x002863A0 File Offset: 0x002845A0
		public int InputControllerType
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06008D6F RID: 36207 RVA: 0x002863E0 File Offset: 0x002845E0
		public int SortId
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

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06008D70 RID: 36208 RVA: 0x00286420 File Offset: 0x00284620
		public string Name
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

		// Token: 0x06008D71 RID: 36209 RVA: 0x00286458 File Offset: 0x00284658
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x00286468 File Offset: 0x00284668
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06008D73 RID: 36211 RVA: 0x00286480 File Offset: 0x00284680
		public int OpenViewType
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

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06008D74 RID: 36212 RVA: 0x002864C0 File Offset: 0x002846C0
		public string ButtonTextId
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

		// Token: 0x06008D75 RID: 36213 RVA: 0x002864F8 File Offset: 0x002846F8
		public Span<byte> GetButtonTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x00286508 File Offset: 0x00284708
		public byte[] GetButtonTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06008D77 RID: 36215 RVA: 0x00286520 File Offset: 0x00284720
		public int ActionOrAxis
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

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06008D78 RID: 36216 RVA: 0x00286560 File Offset: 0x00284760
		public string ActionOrAxisName
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

		// Token: 0x06008D79 RID: 36217 RVA: 0x00286598 File Offset: 0x00284798
		public Span<byte> GetActionOrAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x002865A8 File Offset: 0x002847A8
		public byte[] GetActionOrAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06008D7B RID: 36219 RVA: 0x002865C0 File Offset: 0x002847C0
		public bool CanCombination
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06008D7C RID: 36220 RVA: 0x00286600 File Offset: 0x00284800
		public int PcKeyIndex
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

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06008D7D RID: 36221 RVA: 0x00286640 File Offset: 0x00284840
		public int XBoxKeyIndex
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

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x00286680 File Offset: 0x00284880
		public int ConnectedKeySettingId
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

		// Token: 0x06008D7F RID: 36223 RVA: 0x002866C0 File Offset: 0x002848C0
		public int ConnectedKeySettingIdList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06008D80 RID: 36224 RVA: 0x00286700 File Offset: 0x00284900
		public int ConnectedKeySettingIdListLength
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

		// Token: 0x06008D81 RID: 36225 RVA: 0x0028672C File Offset: 0x0028492C
		public Span<int> GetConnectedKeySettingIdListBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x0028673C File Offset: 0x0028493C
		public int[] GetConnectedKeySettingIdListArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06008D83 RID: 36227 RVA: 0x00286754 File Offset: 0x00284954
		public float PcAxisValue
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x00286798 File Offset: 0x00284998
		public float XBoxAxisValue
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06008D85 RID: 36229 RVA: 0x002867DC File Offset: 0x002849DC
		public bool IsLock
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x0028681C File Offset: 0x00284A1C
		public string BothActionName(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06008D87 RID: 36231 RVA: 0x00286858 File Offset: 0x00284A58
		public int BothActionNameLength
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

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x00286884 File Offset: 0x00284A84
		public bool BothActionSyncAllExclusive
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06008D89 RID: 36233 RVA: 0x002868C4 File Offset: 0x00284AC4
		public bool IsCheckSameKey
		{
			get
			{
				int num = this.__p.__offset(44);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x00286904 File Offset: 0x00284B04
		public bool CanDisable
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x00286944 File Offset: 0x00284B44
		public string AllowKeys(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06008D8C RID: 36236 RVA: 0x00286980 File Offset: 0x00284B80
		public int AllowKeysLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x002869AC File Offset: 0x00284BAC
		public string AllowMainKeys(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06008D8E RID: 36238 RVA: 0x002869E8 File Offset: 0x00284BE8
		public int AllowMainKeysLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x00286A14 File Offset: 0x00284C14
		public string AllowSecondKeys(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06008D90 RID: 36240 RVA: 0x00286A50 File Offset: 0x00284C50
		public int AllowSecondKeysLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06008D91 RID: 36241 RVA: 0x00286A7C File Offset: 0x00284C7C
		public string AllowKeysPool
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

		// Token: 0x06008D92 RID: 36242 RVA: 0x00286AB4 File Offset: 0x00284CB4
		public Span<byte> GetAllowKeysPoolBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x00286AC4 File Offset: 0x00284CC4
		public byte[] GetAllowKeysPoolArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06008D94 RID: 36244 RVA: 0x00286ADC File Offset: 0x00284CDC
		public string AllowMainKeysPool
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

		// Token: 0x06008D95 RID: 36245 RVA: 0x00286B14 File Offset: 0x00284D14
		public Span<byte> GetAllowMainKeysPoolBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x00286B24 File Offset: 0x00284D24
		public byte[] GetAllowMainKeysPoolArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06008D97 RID: 36247 RVA: 0x00286B3C File Offset: 0x00284D3C
		public string AllowSecondKeysPool
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x00286B74 File Offset: 0x00284D74
		public Span<byte> GetAllowSecondKeysPoolBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00286B84 File Offset: 0x00284D84
		public byte[] GetAllowSecondKeysPoolArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06008D9A RID: 36250 RVA: 0x00286B9C File Offset: 0x00284D9C
		public string DetailTextId
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

		// Token: 0x06008D9B RID: 36251 RVA: 0x00286BD4 File Offset: 0x00284DD4
		public Span<byte> GetDetailTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x00286BE4 File Offset: 0x00284DE4
		public byte[] GetDetailTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06008D9D RID: 36253 RVA: 0x00286BFC File Offset: 0x00284DFC
		public bool OnlyWorkNotShow
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x00286C3C File Offset: 0x00284E3C
		[NullableContext(1)]
		public string[] AllowKeys()
		{
			return this.AllowKeysIter().ToArray<string>();
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x00286C49 File Offset: 0x00284E49
		[NullableContext(1)]
		public IEnumerable<string> AllowKeysIter()
		{
			KeySetting.<AllowKeysIter>d__90 <AllowKeysIter>d__ = new KeySetting.<AllowKeysIter>d__90(-2);
			<AllowKeysIter>d__.<>3__<>4__this = this;
			return <AllowKeysIter>d__;
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x00286C5E File Offset: 0x00284E5E
		[NullableContext(1)]
		public string[] AllowMainKeys()
		{
			return this.AllowMainKeysIter().ToArray<string>();
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x00286C6B File Offset: 0x00284E6B
		[NullableContext(1)]
		public IEnumerable<string> AllowMainKeysIter()
		{
			KeySetting.<AllowMainKeysIter>d__92 <AllowMainKeysIter>d__ = new KeySetting.<AllowMainKeysIter>d__92(-2);
			<AllowMainKeysIter>d__.<>3__<>4__this = this;
			return <AllowMainKeysIter>d__;
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x00286C80 File Offset: 0x00284E80
		[NullableContext(1)]
		public string[] AllowSecondKeys()
		{
			return this.AllowSecondKeysIter().ToArray<string>();
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x00286C8D File Offset: 0x00284E8D
		[NullableContext(1)]
		public IEnumerable<string> AllowSecondKeysIter()
		{
			KeySetting.<AllowSecondKeysIter>d__94 <AllowSecondKeysIter>d__ = new KeySetting.<AllowSecondKeysIter>d__94(-2);
			<AllowSecondKeysIter>d__.<>3__<>4__this = this;
			return <AllowSecondKeysIter>d__;
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x00286CA2 File Offset: 0x00284EA2
		[NullableContext(1)]
		public string[] BothActionName()
		{
			return this.BothActionNameIter().ToArray<string>();
		}

		// Token: 0x06008DA5 RID: 36261 RVA: 0x00286CAF File Offset: 0x00284EAF
		[NullableContext(1)]
		public IEnumerable<string> BothActionNameIter()
		{
			KeySetting.<BothActionNameIter>d__96 <BothActionNameIter>d__ = new KeySetting.<BothActionNameIter>d__96(-2);
			<BothActionNameIter>d__.<>3__<>4__this = this;
			return <BothActionNameIter>d__;
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x00286CC4 File Offset: 0x00284EC4
		[NullableContext(1)]
		public int[] ConnectedKeySettingIdList()
		{
			return this.GetConnectedKeySettingIdListArray();
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x00286CCC File Offset: 0x00284ECC
		[NullableContext(1)]
		public IEnumerable<int> ConnectedKeySettingIdListIter()
		{
			KeySetting.<ConnectedKeySettingIdListIter>d__98 <ConnectedKeySettingIdListIter>d__ = new KeySetting.<ConnectedKeySettingIdListIter>d__98(-2);
			<ConnectedKeySettingIdListIter>d__.<>3__<>4__this = this;
			return <ConnectedKeySettingIdListIter>d__;
		}

		// Token: 0x040053FB RID: 21499
		private Table __p;
	}
}
