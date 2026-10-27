using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583B RID: 22587
	public struct IRefreshSingleComponent : IFlatbufferObject
	{
		// Token: 0x1700A8B5 RID: 43189
		// (get) Token: 0x06025FD7 RID: 155607 RVA: 0x0053CB3B File Offset: 0x0053AD3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FD8 RID: 155608 RVA: 0x0053CB48 File Offset: 0x0053AD48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FD9 RID: 155609 RVA: 0x0053CB50 File Offset: 0x0053AD50
		public static IRefreshSingleComponent GetRootAsIRefreshSingleComponent(ByteBuffer _bb)
		{
			return IRefreshSingleComponent.GetRootAsIRefreshSingleComponent(_bb, default(IRefreshSingleComponent));
		}

		// Token: 0x06025FDA RID: 155610 RVA: 0x0053CB6C File Offset: 0x0053AD6C
		public static IRefreshSingleComponent GetRootAsIRefreshSingleComponent(ByteBuffer _bb, IRefreshSingleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FDB RID: 155611 RVA: 0x0053CB89 File Offset: 0x0053AD89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025FDC RID: 155612 RVA: 0x0053CB98 File Offset: 0x0053AD98
		public IRefreshSingleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8B6 RID: 43190
		// (get) Token: 0x06025FDD RID: 155613 RVA: 0x0053CBA8 File Offset: 0x0053ADA8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8B7 RID: 43191
		// (get) Token: 0x06025FDE RID: 155614 RVA: 0x0053CBE8 File Offset: 0x0053ADE8
		public int RefreshInterval
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

		// Token: 0x1700A8B8 RID: 43192
		// (get) Token: 0x06025FDF RID: 155615 RVA: 0x0053CC24 File Offset: 0x0053AE24
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8B9 RID: 43193
		// (get) Token: 0x06025FE0 RID: 155616 RVA: 0x0053CC64 File Offset: 0x0053AE64
		public string TemplateGuid
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

		// Token: 0x06025FE1 RID: 155617 RVA: 0x0053CC9C File Offset: 0x0053AE9C
		public Span<byte> GetTemplateGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06025FE2 RID: 155618 RVA: 0x0053CCAC File Offset: 0x0053AEAC
		public byte[] GetTemplateGuidArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A8BA RID: 43194
		// (get) Token: 0x06025FE3 RID: 155619 RVA: 0x0053CCBC File Offset: 0x0053AEBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025FE4 RID: 155620 RVA: 0x0053CCF9 File Offset: 0x0053AEF9
		public static Offset<IRefreshSingleComponent> CreateIRefreshSingleComponent(FlatBufferBuilder builder, bool Disabled = false, int RefreshInterval = 0, bool DelayRefresh = false, StringOffset TemplateGuidOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IRefreshSingleComponent.AddTemplateGuid(builder, TemplateGuidOffset);
			IRefreshSingleComponent.AddRefreshInterval(builder, RefreshInterval);
			IRefreshSingleComponent.AddNullMask(builder, NullMask);
			IRefreshSingleComponent.AddDelayRefresh(builder, DelayRefresh);
			IRefreshSingleComponent.AddDisabled(builder, Disabled);
			return IRefreshSingleComponent.EndIRefreshSingleComponent(builder);
		}

		// Token: 0x06025FE5 RID: 155621 RVA: 0x0053CD2D File Offset: 0x0053AF2D
		public static void StartIRefreshSingleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025FE6 RID: 155622 RVA: 0x0053CD36 File Offset: 0x0053AF36
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025FE7 RID: 155623 RVA: 0x0053CD41 File Offset: 0x0053AF41
		public static void AddRefreshInterval(FlatBufferBuilder builder, int refreshInterval)
		{
			builder.AddInt(1, refreshInterval, 0);
		}

		// Token: 0x06025FE8 RID: 155624 RVA: 0x0053CD4C File Offset: 0x0053AF4C
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(2, delayRefresh, false);
		}

		// Token: 0x06025FE9 RID: 155625 RVA: 0x0053CD57 File Offset: 0x0053AF57
		public static void AddTemplateGuid(FlatBufferBuilder builder, StringOffset templateGuidOffset)
		{
			builder.AddOffset(3, templateGuidOffset.Value, 0);
		}

		// Token: 0x06025FEA RID: 155626 RVA: 0x0053CD67 File Offset: 0x0053AF67
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06025FEB RID: 155627 RVA: 0x0053CD72 File Offset: 0x0053AF72
		public static Offset<IRefreshSingleComponent> EndIRefreshSingleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshSingleComponent>(builder.EndTable());
		}

		// Token: 0x06025FEC RID: 155628 RVA: 0x0053CD80 File Offset: 0x0053AF80
		public IRefreshSingleComponentT UnPack()
		{
			IRefreshSingleComponentT refreshSingleComponentT = new IRefreshSingleComponentT();
			this.UnPackTo(refreshSingleComponentT);
			return refreshSingleComponentT;
		}

		// Token: 0x06025FED RID: 155629 RVA: 0x0053CD9B File Offset: 0x0053AF9B
		public void UnPackTo(IRefreshSingleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RefreshInterval = this.RefreshInterval;
			_o.DelayRefresh = this.DelayRefresh;
			_o.TemplateGuid = this.TemplateGuid;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025FEE RID: 155630 RVA: 0x0053CDDC File Offset: 0x0053AFDC
		public static Offset<IRefreshSingleComponent> Pack(FlatBufferBuilder builder, IRefreshSingleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshSingleComponent>);
			}
			StringOffset templateGuidOffset = (_o.TemplateGuid == null) ? default(StringOffset) : builder.CreateString(_o.TemplateGuid);
			return IRefreshSingleComponent.CreateIRefreshSingleComponent(builder, _o.Disabled, _o.RefreshInterval, _o.DelayRefresh, templateGuidOffset, _o.NullMask);
		}

		// Token: 0x0400ED52 RID: 60754
		private Table __p;
	}
}
