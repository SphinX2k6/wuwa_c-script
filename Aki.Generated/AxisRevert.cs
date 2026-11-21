using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF9 RID: 3065
	public struct AxisRevert : IFlatbufferObject
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x001FC4A2 File Offset: 0x001FA6A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x001FC4AF File Offset: 0x001FA6AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x001FC4B8 File Offset: 0x001FA6B8
		public static AxisRevert GetRootAsAxisRevert(ByteBuffer _bb)
		{
			return AxisRevert.GetRootAsAxisRevert(_bb, default(AxisRevert));
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x001FC4D4 File Offset: 0x001FA6D4
		public static AxisRevert GetRootAsAxisRevert(ByteBuffer _bb, AxisRevert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x001FC4F1 File Offset: 0x001FA6F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x001FC500 File Offset: 0x001FA700
		public AxisRevert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x001FC510 File Offset: 0x001FA710
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x001FC54C File Offset: 0x001FA74C
		public int RevertType
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x001FC588 File Offset: 0x001FA788
		public string AxisName
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

		// Token: 0x06005025 RID: 20517 RVA: 0x001FC5BF File Offset: 0x001FA7BF
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x001FC5CE File Offset: 0x001FA7CE
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x001FC5E8 File Offset: 0x001FA7E8
		public DicStringInt? RevertInfo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x001FC64C File Offset: 0x001FA84C
		public int RevertInfoLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x001FC678 File Offset: 0x001FA878
		[NullableContext(1)]
		public Dictionary<string, int> RevertInfo()
		{
			return this.RevertInfoIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x001FC6CE File Offset: 0x001FA8CE
		[NullableContext(1)]
		public IEnumerable<DicStringInt> RevertInfoIter()
		{
			AxisRevert.<RevertInfoIter>d__20 <RevertInfoIter>d__ = new AxisRevert.<RevertInfoIter>d__20(-2);
			<RevertInfoIter>d__.<>3__<>4__this = this;
			return <RevertInfoIter>d__;
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x001FC6E4 File Offset: 0x001FA8E4
		[NullableContext(1)]
		public int? GetRevertInfo(string key)
		{
			this.EnsureRevertInfoCacheIfNeeded();
			int value;
			if (!this.RevertInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x001FC718 File Offset: 0x001FA918
		private void EnsureRevertInfoCacheIfNeeded()
		{
			if (this.RevertInfoCache != null)
			{
				return;
			}
			this.RevertInfoCache = this.RevertInfoIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x001FC77E File Offset: 0x001FA97E
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetRevertInfoFrozenDict()
		{
			this.EnsureRevertInfoCacheIfNeeded();
			return this.RevertInfoCache;
		}

		// Token: 0x040050E7 RID: 20711
		private Table __p;

		// Token: 0x040050E8 RID: 20712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> RevertInfoCache;
	}
}
