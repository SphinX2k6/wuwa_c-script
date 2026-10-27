using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB8 RID: 3512
	public struct KurotatoWaypoints : IFlatbufferObject
	{
		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06008C17 RID: 35863 RVA: 0x00273709 File Offset: 0x00271909
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C18 RID: 35864 RVA: 0x00273716 File Offset: 0x00271916
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x00273720 File Offset: 0x00271920
		public static KurotatoWaypoints GetRootAsKurotatoWaypoints(ByteBuffer _bb)
		{
			return KurotatoWaypoints.GetRootAsKurotatoWaypoints(_bb, default(KurotatoWaypoints));
		}

		// Token: 0x06008C1A RID: 35866 RVA: 0x0027373C File Offset: 0x0027193C
		public static KurotatoWaypoints GetRootAsKurotatoWaypoints(ByteBuffer _bb, KurotatoWaypoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x00273759 File Offset: 0x00271959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x00273768 File Offset: 0x00271968
		public KurotatoWaypoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06008C1D RID: 35869 RVA: 0x00273778 File Offset: 0x00271978
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

		// Token: 0x06008C1E RID: 35870 RVA: 0x002737B4 File Offset: 0x002719B4
		public int WaypointsEntityId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06008C1F RID: 35871 RVA: 0x002737F4 File Offset: 0x002719F4
		public int WaypointsEntityIdLength
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

		// Token: 0x06008C20 RID: 35872 RVA: 0x0027381F File Offset: 0x00271A1F
		public Span<int> GetWaypointsEntityIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x0027382E File Offset: 0x00271A2E
		public int[] GetWaypointsEntityIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x00273848 File Offset: 0x00271A48
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaypointsEntityIdIter()或GetWaypointsEntityIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaypointsEntityId()
		{
			KurotatoWaypoints kurotatoWaypoints = this;
			return kurotatoWaypoints.GetWaypointsEntityIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x0027386C File Offset: 0x00271A6C
		[NullableContext(1)]
		public readonly IEnumerable<int> WaypointsEntityIdIter()
		{
			KurotatoWaypoints.<WaypointsEntityIdIter>d__16 <WaypointsEntityIdIter>d__ = new KurotatoWaypoints.<WaypointsEntityIdIter>d__16(-2);
			<WaypointsEntityIdIter>d__.<>3__<>4__this = this;
			return <WaypointsEntityIdIter>d__;
		}

		// Token: 0x04004E4C RID: 20044
		private Table __p;
	}
}
