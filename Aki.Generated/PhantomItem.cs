using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EED RID: 3821
	public struct PhantomItem : IFlatbufferObject
	{
		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x002B42D5 File Offset: 0x002B24D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x002B42E2 File Offset: 0x002B24E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x002B42EC File Offset: 0x002B24EC
		public static PhantomItem GetRootAsPhantomItem(ByteBuffer _bb)
		{
			return PhantomItem.GetRootAsPhantomItem(_bb, default(PhantomItem));
		}

		// Token: 0x0600A916 RID: 43286 RVA: 0x002B4308 File Offset: 0x002B2508
		public static PhantomItem GetRootAsPhantomItem(ByteBuffer _bb, PhantomItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x002B4325 File Offset: 0x002B2525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x002B4334 File Offset: 0x002B2534
		public PhantomItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x0600A919 RID: 43289 RVA: 0x002B4344 File Offset: 0x002B2544
		public int ItemId
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

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x0600A91A RID: 43290 RVA: 0x002B4380 File Offset: 0x002B2580
		public int MonsterId
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

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x0600A91B RID: 43291 RVA: 0x002B43BC File Offset: 0x002B25BC
		public int ParentMonsterId
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

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x002B43F8 File Offset: 0x002B25F8
		public string MonsterName
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

		// Token: 0x0600A91D RID: 43293 RVA: 0x002B4430 File Offset: 0x002B2630
		public Span<byte> GetMonsterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x002B4440 File Offset: 0x002B2640
		public byte[] GetMonsterNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x002B4458 File Offset: 0x002B2658
		public int ElementType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x0600A920 RID: 43296 RVA: 0x002B4498 File Offset: 0x002B2698
		public int ElementTypeLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x002B44C4 File Offset: 0x002B26C4
		public Span<int> GetElementTypeBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x002B44D4 File Offset: 0x002B26D4
		public int[] GetElementTypeArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x0600A923 RID: 43299 RVA: 0x002B44EC File Offset: 0x002B26EC
		public PhantomPropRandom? MainProp
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new PhantomPropRandom?(default(PhantomPropRandom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x0600A924 RID: 43300 RVA: 0x002B454C File Offset: 0x002B274C
		public int LevelUpGroupId
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

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x0600A925 RID: 43301 RVA: 0x002B458C File Offset: 0x002B278C
		public int SkillId
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

		// Token: 0x0600A926 RID: 43302 RVA: 0x002B45CC File Offset: 0x002B27CC
		public long CalabashBuffs(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x0600A927 RID: 43303 RVA: 0x002B4618 File Offset: 0x002B2818
		public int CalabashBuffsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x002B4644 File Offset: 0x002B2844
		public Span<long> GetCalabashBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x002B4659 File Offset: 0x002B2859
		public long[] GetCalabashBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x0600A92A RID: 43306 RVA: 0x002B4698 File Offset: 0x002B2898
		public int Rarity
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

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x0600A92B RID: 43307 RVA: 0x002B46D8 File Offset: 0x002B28D8
		public int MeshId
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

		// Token: 0x0600A92C RID: 43308 RVA: 0x002B4718 File Offset: 0x002B2918
		public float Zoom(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x0600A92D RID: 43309 RVA: 0x002B475C File Offset: 0x002B295C
		public int ZoomLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A92E RID: 43310 RVA: 0x002B4788 File Offset: 0x002B2988
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(26, 4);
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x002B4798 File Offset: 0x002B2998
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(26) ?? Array.Empty<float>();
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x002B47B0 File Offset: 0x002B29B0
		public float Location(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x0600A931 RID: 43313 RVA: 0x002B47F4 File Offset: 0x002B29F4
		public int LocationLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x002B4820 File Offset: 0x002B2A20
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(28, 4);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x002B4830 File Offset: 0x002B2A30
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(28) ?? Array.Empty<float>();
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x002B4848 File Offset: 0x002B2A48
		public float Rotator(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600A935 RID: 43317 RVA: 0x002B488C File Offset: 0x002B2A8C
		public int RotatorLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x002B48B8 File Offset: 0x002B2AB8
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x002B48C8 File Offset: 0x002B2AC8
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x0600A938 RID: 43320 RVA: 0x002B48E0 File Offset: 0x002B2AE0
		public string StandAnim
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

		// Token: 0x0600A939 RID: 43321 RVA: 0x002B4918 File Offset: 0x002B2B18
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x002B4928 File Offset: 0x002B2B28
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x0600A93B RID: 43323 RVA: 0x002B4940 File Offset: 0x002B2B40
		public string TypeDescription
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

		// Token: 0x0600A93C RID: 43324 RVA: 0x002B4978 File Offset: 0x002B2B78
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x002B4988 File Offset: 0x002B2B88
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600A93E RID: 43326 RVA: 0x002B49A0 File Offset: 0x002B2BA0
		public string AttributesDescription
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

		// Token: 0x0600A93F RID: 43327 RVA: 0x002B49D8 File Offset: 0x002B2BD8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x002B49E8 File Offset: 0x002B2BE8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600A941 RID: 43329 RVA: 0x002B4A00 File Offset: 0x002B2C00
		public string Icon
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

		// Token: 0x0600A942 RID: 43330 RVA: 0x002B4A38 File Offset: 0x002B2C38
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x002B4A48 File Offset: 0x002B2C48
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x0600A944 RID: 43332 RVA: 0x002B4A60 File Offset: 0x002B2C60
		public string IconBig
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A945 RID: 43333 RVA: 0x002B4A98 File Offset: 0x002B2C98
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x002B4AA8 File Offset: 0x002B2CA8
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600A947 RID: 43335 RVA: 0x002B4AC0 File Offset: 0x002B2CC0
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x002B4AF8 File Offset: 0x002B2CF8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x002B4B08 File Offset: 0x002B2D08
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600A94A RID: 43338 RVA: 0x002B4B20 File Offset: 0x002B2D20
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A94B RID: 43339 RVA: 0x002B4B58 File Offset: 0x002B2D58
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600A94C RID: 43340 RVA: 0x002B4B68 File Offset: 0x002B2D68
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600A94D RID: 43341 RVA: 0x002B4B80 File Offset: 0x002B2D80
		public string Mesh
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

		// Token: 0x0600A94E RID: 43342 RVA: 0x002B4BB8 File Offset: 0x002B2DB8
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x002B4BC8 File Offset: 0x002B2DC8
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600A950 RID: 43344 RVA: 0x002B4BE0 File Offset: 0x002B2DE0
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600A951 RID: 43345 RVA: 0x002B4C20 File Offset: 0x002B2E20
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 999999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A952 RID: 43346 RVA: 0x002B4C64 File Offset: 0x002B2E64
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600A953 RID: 43347 RVA: 0x002B4CA4 File Offset: 0x002B2EA4
		public int ItemAccessLength
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

		// Token: 0x0600A954 RID: 43348 RVA: 0x002B4CD0 File Offset: 0x002B2ED0
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x002B4CE0 File Offset: 0x002B2EE0
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x0600A956 RID: 43350 RVA: 0x002B4CF8 File Offset: 0x002B2EF8
		public int ObtainedShow
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x0600A957 RID: 43351 RVA: 0x002B4D38 File Offset: 0x002B2F38
		public string ObtainedShowDescription
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

		// Token: 0x0600A958 RID: 43352 RVA: 0x002B4D70 File Offset: 0x002B2F70
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x002B4D80 File Offset: 0x002B2F80
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600A95A RID: 43354 RVA: 0x002B4D98 File Offset: 0x002B2F98
		public int NumLimit
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600A95B RID: 43355 RVA: 0x002B4DD8 File Offset: 0x002B2FD8
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(60);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600A95C RID: 43356 RVA: 0x002B4E18 File Offset: 0x002B3018
		public int SortIndex
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

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x0600A95D RID: 43357 RVA: 0x002B4E58 File Offset: 0x002B3058
		public string SkillIcon
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x002B4E90 File Offset: 0x002B3090
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600A95F RID: 43359 RVA: 0x002B4EA0 File Offset: 0x002B30A0
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x0600A960 RID: 43360 RVA: 0x002B4EB8 File Offset: 0x002B30B8
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(66);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x0600A961 RID: 43361 RVA: 0x002B4EF8 File Offset: 0x002B30F8
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x002B4F38 File Offset: 0x002B3138
		public int FetterGroup(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600A963 RID: 43363 RVA: 0x002B4F78 File Offset: 0x002B3178
		public int FetterGroupLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x002B4FA4 File Offset: 0x002B31A4
		public Span<int> GetFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x002B4FB4 File Offset: 0x002B31B4
		public int[] GetFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(70) ?? Array.Empty<int>();
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x002B4FCC File Offset: 0x002B31CC
		public int PhantomType
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x002B500C File Offset: 0x002B320C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CalabashBuffsIter()或GetCalabashBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] CalabashBuffs()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetCalabashBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x002B5030 File Offset: 0x002B3230
		[NullableContext(1)]
		public readonly IEnumerable<long> CalabashBuffsIter()
		{
			PhantomItem.<CalabashBuffsIter>d__122 <CalabashBuffsIter>d__ = new PhantomItem.<CalabashBuffsIter>d__122(-2);
			<CalabashBuffsIter>d__.<>3__<>4__this = this;
			return <CalabashBuffsIter>d__;
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x002B5048 File Offset: 0x002B3248
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ElementTypeIter()或GetElementTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ElementType()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetElementTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x002B506C File Offset: 0x002B326C
		[NullableContext(1)]
		public readonly IEnumerable<int> ElementTypeIter()
		{
			PhantomItem.<ElementTypeIter>d__124 <ElementTypeIter>d__ = new PhantomItem.<ElementTypeIter>d__124(-2);
			<ElementTypeIter>d__.<>3__<>4__this = this;
			return <ElementTypeIter>d__;
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x002B5084 File Offset: 0x002B3284
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FetterGroupIter()或GetFetterGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FetterGroup()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetFetterGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x002B50A8 File Offset: 0x002B32A8
		[NullableContext(1)]
		public readonly IEnumerable<int> FetterGroupIter()
		{
			PhantomItem.<FetterGroupIter>d__126 <FetterGroupIter>d__ = new PhantomItem.<FetterGroupIter>d__126(-2);
			<FetterGroupIter>d__.<>3__<>4__this = this;
			return <FetterGroupIter>d__;
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x002B50C0 File Offset: 0x002B32C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A96E RID: 43374 RVA: 0x002B50E4 File Offset: 0x002B32E4
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			PhantomItem.<ItemAccessIter>d__128 <ItemAccessIter>d__ = new PhantomItem.<ItemAccessIter>d__128(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x002B50FC File Offset: 0x002B32FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LocationIter()或GetLocationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Location()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetLocationArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A970 RID: 43376 RVA: 0x002B5120 File Offset: 0x002B3320
		[NullableContext(1)]
		public readonly IEnumerable<float> LocationIter()
		{
			PhantomItem.<LocationIter>d__130 <LocationIter>d__ = new PhantomItem.<LocationIter>d__130(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x002B5138 File Offset: 0x002B3338
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotatorIter()或GetRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotator()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetRotatorArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A972 RID: 43378 RVA: 0x002B515C File Offset: 0x002B335C
		[NullableContext(1)]
		public readonly IEnumerable<float> RotatorIter()
		{
			PhantomItem.<RotatorIter>d__132 <RotatorIter>d__ = new PhantomItem.<RotatorIter>d__132(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x002B5174 File Offset: 0x002B3374
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ZoomIter()或GetZoomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Zoom()
		{
			PhantomItem phantomItem = this;
			return phantomItem.GetZoomArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A974 RID: 43380 RVA: 0x002B5198 File Offset: 0x002B3398
		[NullableContext(1)]
		public readonly IEnumerable<float> ZoomIter()
		{
			PhantomItem.<ZoomIter>d__134 <ZoomIter>d__ = new PhantomItem.<ZoomIter>d__134(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x04004FAF RID: 20399
		private Table __p;
	}
}
