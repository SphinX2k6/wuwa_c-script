using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B9 RID: 4793
	public struct UiFloatConfig : IFlatbufferObject
	{
		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x0600F39F RID: 62367 RVA: 0x003696F0 File Offset: 0x003678F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F3A0 RID: 62368 RVA: 0x003696FD File Offset: 0x003678FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F3A1 RID: 62369 RVA: 0x00369704 File Offset: 0x00367904
		public static UiFloatConfig GetRootAsUiFloatConfig(ByteBuffer _bb)
		{
			return UiFloatConfig.GetRootAsUiFloatConfig(_bb, default(UiFloatConfig));
		}

		// Token: 0x0600F3A2 RID: 62370 RVA: 0x00369720 File Offset: 0x00367920
		public static UiFloatConfig GetRootAsUiFloatConfig(ByteBuffer _bb, UiFloatConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F3A3 RID: 62371 RVA: 0x0036973D File Offset: 0x0036793D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F3A4 RID: 62372 RVA: 0x0036974C File Offset: 0x0036794C
		public UiFloatConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x0600F3A5 RID: 62373 RVA: 0x0036975C File Offset: 0x0036795C
		public string ViewName
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

		// Token: 0x0600F3A6 RID: 62374 RVA: 0x00369793 File Offset: 0x00367993
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F3A7 RID: 62375 RVA: 0x003697A2 File Offset: 0x003679A2
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x0600F3A8 RID: 62376 RVA: 0x003697BC File Offset: 0x003679BC
		public string Area
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

		// Token: 0x0600F3A9 RID: 62377 RVA: 0x003697F3 File Offset: 0x003679F3
		public Span<byte> GetAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F3AA RID: 62378 RVA: 0x00369802 File Offset: 0x00367A02
		public byte[] GetAreaArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x0600F3AB RID: 62379 RVA: 0x0036981C File Offset: 0x00367A1C
		public int Priority
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

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x0600F3AC RID: 62380 RVA: 0x00369858 File Offset: 0x00367A58
		public bool OnlyShowInMain
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x0600F3AD RID: 62381 RVA: 0x00369898 File Offset: 0x00367A98
		public int RootItemIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x0600F3AE RID: 62382 RVA: 0x003698D8 File Offset: 0x00367AD8
		public bool IsWaitNormal
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x0600F3AF RID: 62383 RVA: 0x00369918 File Offset: 0x00367B18
		public bool HideInPureMode
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400590F RID: 22799
		private Table __p;
	}
}
