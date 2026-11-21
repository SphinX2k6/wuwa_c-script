using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012BC RID: 4796
	public struct UiResource : IFlatbufferObject
	{
		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x0600F3C8 RID: 62408 RVA: 0x00369C05 File Offset: 0x00367E05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F3C9 RID: 62409 RVA: 0x00369C12 File Offset: 0x00367E12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F3CA RID: 62410 RVA: 0x00369C1C File Offset: 0x00367E1C
		public static UiResource GetRootAsUiResource(ByteBuffer _bb)
		{
			return UiResource.GetRootAsUiResource(_bb, default(UiResource));
		}

		// Token: 0x0600F3CB RID: 62411 RVA: 0x00369C38 File Offset: 0x00367E38
		public static UiResource GetRootAsUiResource(ByteBuffer _bb, UiResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x00369C55 File Offset: 0x00367E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F3CD RID: 62413 RVA: 0x00369C64 File Offset: 0x00367E64
		public UiResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x0600F3CE RID: 62414 RVA: 0x00369C74 File Offset: 0x00367E74
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

		// Token: 0x0600F3CF RID: 62415 RVA: 0x00369CAB File Offset: 0x00367EAB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F3D0 RID: 62416 RVA: 0x00369CBA File Offset: 0x00367EBA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x0600F3D1 RID: 62417 RVA: 0x00369CD4 File Offset: 0x00367ED4
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

		// Token: 0x0600F3D2 RID: 62418 RVA: 0x00369D0B File Offset: 0x00367F0B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F3D3 RID: 62419 RVA: 0x00369D1A File Offset: 0x00367F1A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x0600F3D4 RID: 62420 RVA: 0x00369D34 File Offset: 0x00367F34
		public string PcPath
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

		// Token: 0x0600F3D5 RID: 62421 RVA: 0x00369D6B File Offset: 0x00367F6B
		public Span<byte> GetPcPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F3D6 RID: 62422 RVA: 0x00369D7A File Offset: 0x00367F7A
		public byte[] GetPcPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0600F3D7 RID: 62423 RVA: 0x00369D94 File Offset: 0x00367F94
		public string ResourceType
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

		// Token: 0x0600F3D8 RID: 62424 RVA: 0x00369DCC File Offset: 0x00367FCC
		public Span<byte> GetResourceTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F3D9 RID: 62425 RVA: 0x00369DDC File Offset: 0x00367FDC
		public byte[] GetResourceTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F3DA RID: 62426 RVA: 0x00369DF4 File Offset: 0x00367FF4
		public string ActivityType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x0600F3DB RID: 62427 RVA: 0x00369E30 File Offset: 0x00368030
		public int ActivityTypeLength
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

		// Token: 0x0600F3DC RID: 62428 RVA: 0x00369E5C File Offset: 0x0036805C
		[NullableContext(1)]
		public string[] ActivityType()
		{
			return this.ActivityTypeIter().ToArray<string>();
		}

		// Token: 0x0600F3DD RID: 62429 RVA: 0x00369E69 File Offset: 0x00368069
		[NullableContext(1)]
		public IEnumerable<string> ActivityTypeIter()
		{
			UiResource.<ActivityTypeIter>d__28 <ActivityTypeIter>d__ = new UiResource.<ActivityTypeIter>d__28(-2);
			<ActivityTypeIter>d__.<>3__<>4__this = this;
			return <ActivityTypeIter>d__;
		}

		// Token: 0x04005912 RID: 22802
		private Table __p;
	}
}
