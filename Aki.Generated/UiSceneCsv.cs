using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012BD RID: 4797
	public struct UiSceneCsv : IFlatbufferObject
	{
		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x0600F3DE RID: 62430 RVA: 0x00369E7E File Offset: 0x0036807E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F3DF RID: 62431 RVA: 0x00369E8B File Offset: 0x0036808B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F3E0 RID: 62432 RVA: 0x00369E94 File Offset: 0x00368094
		public static UiSceneCsv GetRootAsUiSceneCsv(ByteBuffer _bb)
		{
			return UiSceneCsv.GetRootAsUiSceneCsv(_bb, default(UiSceneCsv));
		}

		// Token: 0x0600F3E1 RID: 62433 RVA: 0x00369EB0 File Offset: 0x003680B0
		public static UiSceneCsv GetRootAsUiSceneCsv(ByteBuffer _bb, UiSceneCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F3E2 RID: 62434 RVA: 0x00369ECD File Offset: 0x003680CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F3E3 RID: 62435 RVA: 0x00369EDC File Offset: 0x003680DC
		public UiSceneCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x0600F3E4 RID: 62436 RVA: 0x00369EEC File Offset: 0x003680EC
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

		// Token: 0x0600F3E5 RID: 62437 RVA: 0x00369F23 File Offset: 0x00368123
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F3E6 RID: 62438 RVA: 0x00369F32 File Offset: 0x00368132
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F3E7 RID: 62439 RVA: 0x00369F4C File Offset: 0x0036814C
		public string SceneList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x0600F3E8 RID: 62440 RVA: 0x00369F88 File Offset: 0x00368188
		public int SceneListLength
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

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x0600F3E9 RID: 62441 RVA: 0x00369FB4 File Offset: 0x003681B4
		public IntVector? WorldOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x0600F3EA RID: 62442 RVA: 0x0036A014 File Offset: 0x00368214
		public string MainScene
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

		// Token: 0x0600F3EB RID: 62443 RVA: 0x0036A04C File Offset: 0x0036824C
		public Span<byte> GetMainSceneBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F3EC RID: 62444 RVA: 0x0036A05C File Offset: 0x0036825C
		public byte[] GetMainSceneArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F3ED RID: 62445 RVA: 0x0036A074 File Offset: 0x00368274
		[NullableContext(1)]
		public string[] SceneList()
		{
			return this.SceneListIter().ToArray<string>();
		}

		// Token: 0x0600F3EE RID: 62446 RVA: 0x0036A081 File Offset: 0x00368281
		[NullableContext(1)]
		public IEnumerable<string> SceneListIter()
		{
			UiSceneCsv.<SceneListIter>d__22 <SceneListIter>d__ = new UiSceneCsv.<SceneListIter>d__22(-2);
			<SceneListIter>d__.<>3__<>4__this = this;
			return <SceneListIter>d__;
		}

		// Token: 0x04005913 RID: 22803
		private Table __p;
	}
}
