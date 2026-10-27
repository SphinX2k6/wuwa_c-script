using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1E RID: 3870
	public struct PhysicsAssetConfig : IFlatbufferObject
	{
		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x0600ADA2 RID: 44450 RVA: 0x002BEA7A File Offset: 0x002BCC7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x002BEA87 File Offset: 0x002BCC87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x002BEA90 File Offset: 0x002BCC90
		public static PhysicsAssetConfig GetRootAsPhysicsAssetConfig(ByteBuffer _bb)
		{
			return PhysicsAssetConfig.GetRootAsPhysicsAssetConfig(_bb, default(PhysicsAssetConfig));
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x002BEAAC File Offset: 0x002BCCAC
		public static PhysicsAssetConfig GetRootAsPhysicsAssetConfig(ByteBuffer _bb, PhysicsAssetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x002BEAC9 File Offset: 0x002BCCC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x002BEAD8 File Offset: 0x002BCCD8
		public PhysicsAssetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x0600ADA8 RID: 44456 RVA: 0x002BEAE8 File Offset: 0x002BCCE8
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

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x002BEB1F File Offset: 0x002BCD1F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x002BEB2E File Offset: 0x002BCD2E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x002BEB48 File Offset: 0x002BCD48
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

		// Token: 0x0600ADAC RID: 44460 RVA: 0x002BEB7F File Offset: 0x002BCD7F
		public Span<byte> GetPhysicsAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x002BEB8E File Offset: 0x002BCD8E
		public byte[] GetPhysicsAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ADAE RID: 44462 RVA: 0x002BEBA8 File Offset: 0x002BCDA8
		public string BoneNames(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x0600ADAF RID: 44463 RVA: 0x002BEBE4 File Offset: 0x002BCDE4
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

		// Token: 0x0600ADB0 RID: 44464 RVA: 0x002BEC0F File Offset: 0x002BCE0F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BoneNamesIter()或GetBoneNamesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BoneNames()
		{
			return this.BoneNamesIter().ToArray<string>();
		}

		// Token: 0x0600ADB1 RID: 44465 RVA: 0x002BEC1C File Offset: 0x002BCE1C
		[NullableContext(1)]
		public readonly IEnumerable<string> BoneNamesIter()
		{
			PhysicsAssetConfig.<BoneNamesIter>d__20 <BoneNamesIter>d__ = new PhysicsAssetConfig.<BoneNamesIter>d__20(-2);
			<BoneNamesIter>d__.<>3__<>4__this = this;
			return <BoneNamesIter>d__;
		}

		// Token: 0x04004FE7 RID: 20455
		private Table __p;
	}
}
