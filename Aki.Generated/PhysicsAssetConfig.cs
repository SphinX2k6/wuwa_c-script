using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001003 RID: 4099
	public struct PhysicsAssetConfig : IFlatbufferObject
	{
		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600B3C3 RID: 46019 RVA: 0x002DB656 File Offset: 0x002D9856
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x002DB663 File Offset: 0x002D9863
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x002DB66C File Offset: 0x002D986C
		public static PhysicsAssetConfig GetRootAsPhysicsAssetConfig(ByteBuffer _bb)
		{
			return PhysicsAssetConfig.GetRootAsPhysicsAssetConfig(_bb, default(PhysicsAssetConfig));
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x002DB688 File Offset: 0x002D9888
		public static PhysicsAssetConfig GetRootAsPhysicsAssetConfig(ByteBuffer _bb, PhysicsAssetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x002DB6A5 File Offset: 0x002D98A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x002DB6B4 File Offset: 0x002D98B4
		public PhysicsAssetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600B3C9 RID: 46025 RVA: 0x002DB6C4 File Offset: 0x002D98C4
		public string Id
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

		// Token: 0x0600B3CA RID: 46026 RVA: 0x002DB6FB File Offset: 0x002D98FB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B3CB RID: 46027 RVA: 0x002DB70A File Offset: 0x002D990A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600B3CC RID: 46028 RVA: 0x002DB724 File Offset: 0x002D9924
		public string PhysicsAssetPath
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

		// Token: 0x0600B3CD RID: 46029 RVA: 0x002DB75B File Offset: 0x002D995B
		public Span<byte> GetPhysicsAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x002DB76A File Offset: 0x002D996A
		public byte[] GetPhysicsAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x002DB784 File Offset: 0x002D9984
		public string BoneNames(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600B3D0 RID: 46032 RVA: 0x002DB7C0 File Offset: 0x002D99C0
		public int BoneNamesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x002DB7EB File Offset: 0x002D99EB
		[NullableContext(1)]
		public string[] BoneNames()
		{
			return this.BoneNamesIter().ToArray<string>();
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x002DB7F8 File Offset: 0x002D99F8
		[NullableContext(1)]
		public IEnumerable<string> BoneNamesIter()
		{
			PhysicsAssetConfig.<BoneNamesIter>d__20 <BoneNamesIter>d__ = new PhysicsAssetConfig.<BoneNamesIter>d__20(-2);
			<BoneNamesIter>d__.<>3__<>4__this = this;
			return <BoneNamesIter>d__;
		}

		// Token: 0x040055CC RID: 21964
		private Table __p;
	}
}
