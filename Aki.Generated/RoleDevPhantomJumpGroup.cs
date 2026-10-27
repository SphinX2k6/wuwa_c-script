using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001045 RID: 4165
	public struct RoleDevPhantomJumpGroup : IFlatbufferObject
	{
		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600C81A RID: 51226 RVA: 0x002F96C1 File Offset: 0x002F78C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x002F96CE File Offset: 0x002F78CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x002F96D8 File Offset: 0x002F78D8
		public static RoleDevPhantomJumpGroup GetRootAsRoleDevPhantomJumpGroup(ByteBuffer _bb)
		{
			return RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(_bb, default(RoleDevPhantomJumpGroup));
		}

		// Token: 0x0600C81D RID: 51229 RVA: 0x002F96F4 File Offset: 0x002F78F4
		public static RoleDevPhantomJumpGroup GetRootAsRoleDevPhantomJumpGroup(ByteBuffer _bb, RoleDevPhantomJumpGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x002F9711 File Offset: 0x002F7911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x002F9720 File Offset: 0x002F7920
		public RoleDevPhantomJumpGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600C820 RID: 51232 RVA: 0x002F9730 File Offset: 0x002F7930
		public int PhantomId
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

		// Token: 0x0600C821 RID: 51233 RVA: 0x002F976C File Offset: 0x002F796C
		public int PhantomJumpId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600C822 RID: 51234 RVA: 0x002F97AC File Offset: 0x002F79AC
		public int PhantomJumpIdLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x002F97D7 File Offset: 0x002F79D7
		public Span<int> GetPhantomJumpIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C824 RID: 51236 RVA: 0x002F97E6 File Offset: 0x002F79E6
		public int[] GetPhantomJumpIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600C825 RID: 51237 RVA: 0x002F9800 File Offset: 0x002F7A00
		public int PriorityLevel
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

		// Token: 0x0600C826 RID: 51238 RVA: 0x002F983C File Offset: 0x002F7A3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomJumpIdIter()或GetPhantomJumpIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomJumpId()
		{
			RoleDevPhantomJumpGroup roleDevPhantomJumpGroup = this;
			return roleDevPhantomJumpGroup.GetPhantomJumpIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x002F9860 File Offset: 0x002F7A60
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomJumpIdIter()
		{
			RoleDevPhantomJumpGroup.<PhantomJumpIdIter>d__18 <PhantomJumpIdIter>d__ = new RoleDevPhantomJumpGroup.<PhantomJumpIdIter>d__18(-2);
			<PhantomJumpIdIter>d__.<>3__<>4__this = this;
			return <PhantomJumpIdIter>d__;
		}

		// Token: 0x04005143 RID: 20803
		private Table __p;
	}
}
