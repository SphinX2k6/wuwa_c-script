using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E6 RID: 4326
	public struct SpringFestivalArea : IFlatbufferObject
	{
		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600D86F RID: 55407 RVA: 0x0031F1C9 File Offset: 0x0031D3C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x0031F1D6 File Offset: 0x0031D3D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x0031F1E0 File Offset: 0x0031D3E0
		public static SpringFestivalArea GetRootAsSpringFestivalArea(ByteBuffer _bb)
		{
			return SpringFestivalArea.GetRootAsSpringFestivalArea(_bb, default(SpringFestivalArea));
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x0031F1FC File Offset: 0x0031D3FC
		public static SpringFestivalArea GetRootAsSpringFestivalArea(ByteBuffer _bb, SpringFestivalArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x0031F219 File Offset: 0x0031D419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D874 RID: 55412 RVA: 0x0031F228 File Offset: 0x0031D428
		public SpringFestivalArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600D875 RID: 55413 RVA: 0x0031F238 File Offset: 0x0031D438
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

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600D876 RID: 55414 RVA: 0x0031F274 File Offset: 0x0031D474
		public int Floor
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

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0600D877 RID: 55415 RVA: 0x0031F2B0 File Offset: 0x0031D4B0
		public int ActivityId
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

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600D878 RID: 55416 RVA: 0x0031F2EC File Offset: 0x0031D4EC
		public int MaxAtmosphere
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

		// Token: 0x0600D879 RID: 55417 RVA: 0x0031F32C File Offset: 0x0031D52C
		public int SlotEntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600D87A RID: 55418 RVA: 0x0031F36C File Offset: 0x0031D56C
		public int SlotEntityIdsLength
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

		// Token: 0x0600D87B RID: 55419 RVA: 0x0031F398 File Offset: 0x0031D598
		public Span<int> GetSlotEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D87C RID: 55420 RVA: 0x0031F3A8 File Offset: 0x0031D5A8
		public int[] GetSlotEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600D87D RID: 55421 RVA: 0x0031F3C0 File Offset: 0x0031D5C0
		public int QuestId
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

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600D87E RID: 55422 RVA: 0x0031F400 File Offset: 0x0031D600
		public int NodeId
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

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600D87F RID: 55423 RVA: 0x0031F440 File Offset: 0x0031D640
		public int AtmosphereLevelId
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

		// Token: 0x0600D880 RID: 55424 RVA: 0x0031F480 File Offset: 0x0031D680
		public DicIntIntArray? DefaultFurnitures(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600D881 RID: 55425 RVA: 0x0031F4E4 File Offset: 0x0031D6E4
		public int DefaultFurnituresLength
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

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600D882 RID: 55426 RVA: 0x0031F510 File Offset: 0x0031D710
		public Vector? CameraLocation
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600D883 RID: 55427 RVA: 0x0031F570 File Offset: 0x0031D770
		public Vector? CameraRotator
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600D884 RID: 55428 RVA: 0x0031F5D0 File Offset: 0x0031D7D0
		public int CameraFov
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 90;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D885 RID: 55429 RVA: 0x0031F610 File Offset: 0x0031D810
		public int CameraList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600D886 RID: 55430 RVA: 0x0031F650 File Offset: 0x0031D850
		public int CameraListLength
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

		// Token: 0x0600D887 RID: 55431 RVA: 0x0031F67C File Offset: 0x0031D87C
		public Span<int> GetCameraListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600D888 RID: 55432 RVA: 0x0031F68C File Offset: 0x0031D88C
		public int[] GetCameraListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600D889 RID: 55433 RVA: 0x0031F6A4 File Offset: 0x0031D8A4
		public string AreaName
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

		// Token: 0x0600D88A RID: 55434 RVA: 0x0031F6DC File Offset: 0x0031D8DC
		public Span<byte> GetAreaNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D88B RID: 55435 RVA: 0x0031F6EC File Offset: 0x0031D8EC
		public byte[] GetAreaNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600D88C RID: 55436 RVA: 0x0031F704 File Offset: 0x0031D904
		public string AreaDescription
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

		// Token: 0x0600D88D RID: 55437 RVA: 0x0031F73C File Offset: 0x0031D93C
		public Span<byte> GetAreaDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x0031F74C File Offset: 0x0031D94C
		public byte[] GetAreaDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600D88F RID: 55439 RVA: 0x0031F764 File Offset: 0x0031D964
		public string AreaFinishedSmallIcon
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

		// Token: 0x0600D890 RID: 55440 RVA: 0x0031F79C File Offset: 0x0031D99C
		public Span<byte> GetAreaFinishedSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D891 RID: 55441 RVA: 0x0031F7AC File Offset: 0x0031D9AC
		public byte[] GetAreaFinishedSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600D892 RID: 55442 RVA: 0x0031F7C4 File Offset: 0x0031D9C4
		public string AreaUnFinishedSmallIcon
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

		// Token: 0x0600D893 RID: 55443 RVA: 0x0031F7FC File Offset: 0x0031D9FC
		public Span<byte> GetAreaUnFinishedSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600D894 RID: 55444 RVA: 0x0031F80C File Offset: 0x0031DA0C
		public byte[] GetAreaUnFinishedSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600D895 RID: 55445 RVA: 0x0031F824 File Offset: 0x0031DA24
		public string AreaFinishedBigIcon
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

		// Token: 0x0600D896 RID: 55446 RVA: 0x0031F85C File Offset: 0x0031DA5C
		public Span<byte> GetAreaFinishedBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600D897 RID: 55447 RVA: 0x0031F86C File Offset: 0x0031DA6C
		public byte[] GetAreaFinishedBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600D898 RID: 55448 RVA: 0x0031F884 File Offset: 0x0031DA84
		public string AreaUnFinishedBigIcon
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

		// Token: 0x0600D899 RID: 55449 RVA: 0x0031F8BC File Offset: 0x0031DABC
		public Span<byte> GetAreaUnFinishedBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600D89A RID: 55450 RVA: 0x0031F8CC File Offset: 0x0031DACC
		public byte[] GetAreaUnFinishedBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600D89B RID: 55451 RVA: 0x0031F8E4 File Offset: 0x0031DAE4
		public int MaxSlotCount
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D89C RID: 55452 RVA: 0x0031F924 File Offset: 0x0031DB24
		public int RangeEntityList(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600D89D RID: 55453 RVA: 0x0031F964 File Offset: 0x0031DB64
		public int RangeEntityListLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D89E RID: 55454 RVA: 0x0031F990 File Offset: 0x0031DB90
		public Span<int> GetRangeEntityListBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600D89F RID: 55455 RVA: 0x0031F9A0 File Offset: 0x0031DBA0
		public int[] GetRangeEntityListArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600D8A0 RID: 55456 RVA: 0x0031F9B8 File Offset: 0x0031DBB8
		public Vector? TeleportLocation
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

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600D8A1 RID: 55457 RVA: 0x0031FA18 File Offset: 0x0031DC18
		public Vector? TeleportRotator
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0600D8A2 RID: 55458 RVA: 0x0031FA78 File Offset: 0x0031DC78
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CameraListIter()或GetCameraListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CameraList()
		{
			SpringFestivalArea springFestivalArea = this;
			return springFestivalArea.GetCameraListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D8A3 RID: 55459 RVA: 0x0031FA9C File Offset: 0x0031DC9C
		[NullableContext(1)]
		public readonly IEnumerable<int> CameraListIter()
		{
			SpringFestivalArea.<CameraListIter>d__77 <CameraListIter>d__ = new SpringFestivalArea.<CameraListIter>d__77(-2);
			<CameraListIter>d__.<>3__<>4__this = this;
			return <CameraListIter>d__;
		}

		// Token: 0x0600D8A4 RID: 55460 RVA: 0x0031FAB4 File Offset: 0x0031DCB4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DefaultFurnituresFrozenDict()缓存字典，遍历请使用DefaultFurnituresIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DefaultFurnitures()
		{
			return this.DefaultFurnituresIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D8A5 RID: 55461 RVA: 0x0031FB0A File Offset: 0x0031DD0A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DefaultFurnituresIter()
		{
			SpringFestivalArea.<DefaultFurnituresIter>d__79 <DefaultFurnituresIter>d__ = new SpringFestivalArea.<DefaultFurnituresIter>d__79(-2);
			<DefaultFurnituresIter>d__.<>3__<>4__this = this;
			return <DefaultFurnituresIter>d__;
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x0031FB20 File Offset: 0x0031DD20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RangeEntityListIter()或GetRangeEntityListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RangeEntityList()
		{
			SpringFestivalArea springFestivalArea = this;
			return springFestivalArea.GetRangeEntityListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D8A7 RID: 55463 RVA: 0x0031FB44 File Offset: 0x0031DD44
		[NullableContext(1)]
		public readonly IEnumerable<int> RangeEntityListIter()
		{
			SpringFestivalArea.<RangeEntityListIter>d__81 <RangeEntityListIter>d__ = new SpringFestivalArea.<RangeEntityListIter>d__81(-2);
			<RangeEntityListIter>d__.<>3__<>4__this = this;
			return <RangeEntityListIter>d__;
		}

		// Token: 0x0600D8A8 RID: 55464 RVA: 0x0031FB5C File Offset: 0x0031DD5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SlotEntityIdsIter()或GetSlotEntityIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SlotEntityIds()
		{
			SpringFestivalArea springFestivalArea = this;
			return springFestivalArea.GetSlotEntityIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x0031FB80 File Offset: 0x0031DD80
		[NullableContext(1)]
		public readonly IEnumerable<int> SlotEntityIdsIter()
		{
			SpringFestivalArea.<SlotEntityIdsIter>d__83 <SlotEntityIdsIter>d__ = new SpringFestivalArea.<SlotEntityIdsIter>d__83(-2);
			<SlotEntityIdsIter>d__.<>3__<>4__this = this;
			return <SlotEntityIdsIter>d__;
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x0031FB98 File Offset: 0x0031DD98
		public IntArray? GetDefaultFurnitures(int key)
		{
			this.EnsureDefaultFurnituresCacheIfNeeded();
			IntArray value;
			if (!this.DefaultFurnituresCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D8AB RID: 55467 RVA: 0x0031FBCC File Offset: 0x0031DDCC
		private void EnsureDefaultFurnituresCacheIfNeeded()
		{
			if (this.DefaultFurnituresCache != null)
			{
				return;
			}
			this.DefaultFurnituresCache = this.DefaultFurnituresIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D8AC RID: 55468 RVA: 0x0031FC32 File Offset: 0x0031DE32
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDefaultFurnituresFrozenDict(int key)
		{
			this.EnsureDefaultFurnituresCacheIfNeeded();
			return this.DefaultFurnituresCache;
		}

		// Token: 0x04005219 RID: 21017
		private Table __p;

		// Token: 0x0400521A RID: 21018
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DefaultFurnituresCache;
	}
}
