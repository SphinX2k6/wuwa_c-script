using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B8 RID: 4792
	public struct UiDynamicTab : IFlatbufferObject
	{
		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x0600F37E RID: 62334 RVA: 0x003692C6 File Offset: 0x003674C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F37F RID: 62335 RVA: 0x003692D3 File Offset: 0x003674D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F380 RID: 62336 RVA: 0x003692DC File Offset: 0x003674DC
		public static UiDynamicTab GetRootAsUiDynamicTab(ByteBuffer _bb)
		{
			return UiDynamicTab.GetRootAsUiDynamicTab(_bb, default(UiDynamicTab));
		}

		// Token: 0x0600F381 RID: 62337 RVA: 0x003692F8 File Offset: 0x003674F8
		public static UiDynamicTab GetRootAsUiDynamicTab(ByteBuffer _bb, UiDynamicTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F382 RID: 62338 RVA: 0x00369315 File Offset: 0x00367515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F383 RID: 62339 RVA: 0x00369324 File Offset: 0x00367524
		public UiDynamicTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x0600F384 RID: 62340 RVA: 0x00369334 File Offset: 0x00367534
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

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x0600F385 RID: 62341 RVA: 0x00369370 File Offset: 0x00367570
		public string ParentViewName
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

		// Token: 0x0600F386 RID: 62342 RVA: 0x003693A7 File Offset: 0x003675A7
		public Span<byte> GetParentViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F387 RID: 62343 RVA: 0x003693B6 File Offset: 0x003675B6
		public byte[] GetParentViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x0600F388 RID: 62344 RVA: 0x003693D0 File Offset: 0x003675D0
		public string ChildViewName
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

		// Token: 0x0600F389 RID: 62345 RVA: 0x00369407 File Offset: 0x00367607
		public Span<byte> GetChildViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F38A RID: 62346 RVA: 0x00369416 File Offset: 0x00367616
		public byte[] GetChildViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x0600F38B RID: 62347 RVA: 0x00369430 File Offset: 0x00367630
		public string TabName
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

		// Token: 0x0600F38C RID: 62348 RVA: 0x00369468 File Offset: 0x00367668
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F38D RID: 62349 RVA: 0x00369478 File Offset: 0x00367678
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x0600F38E RID: 62350 RVA: 0x00369490 File Offset: 0x00367690
		public int TabIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x0600F38F RID: 62351 RVA: 0x003694D0 File Offset: 0x003676D0
		public int FunctionId
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

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x0600F390 RID: 62352 RVA: 0x00369510 File Offset: 0x00367710
		public string UiCameraSettingsName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F391 RID: 62353 RVA: 0x00369548 File Offset: 0x00367748
		public Span<byte> GetUiCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F392 RID: 62354 RVA: 0x00369558 File Offset: 0x00367758
		public byte[] GetUiCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0600F393 RID: 62355 RVA: 0x00369570 File Offset: 0x00367770
		public string UiCameraBlendName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F394 RID: 62356 RVA: 0x003695A8 File Offset: 0x003677A8
		public Span<byte> GetUiCameraBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F395 RID: 62357 RVA: 0x003695B8 File Offset: 0x003677B8
		public byte[] GetUiCameraBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x0600F396 RID: 62358 RVA: 0x003695D0 File Offset: 0x003677D0
		public string BackViewBlendName
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F397 RID: 62359 RVA: 0x00369608 File Offset: 0x00367808
		public Span<byte> GetBackViewBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600F398 RID: 62360 RVA: 0x00369618 File Offset: 0x00367818
		public byte[] GetBackViewBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x0600F399 RID: 62361 RVA: 0x00369630 File Offset: 0x00367830
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F39A RID: 62362 RVA: 0x00369668 File Offset: 0x00367868
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600F39B RID: 62363 RVA: 0x00369678 File Offset: 0x00367878
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x0600F39C RID: 62364 RVA: 0x00369690 File Offset: 0x00367890
		public string LightSequence
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F39D RID: 62365 RVA: 0x003696C8 File Offset: 0x003678C8
		public Span<byte> GetLightSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600F39E RID: 62366 RVA: 0x003696D8 File Offset: 0x003678D8
		public byte[] GetLightSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0400590E RID: 22798
		private Table __p;
	}
}
