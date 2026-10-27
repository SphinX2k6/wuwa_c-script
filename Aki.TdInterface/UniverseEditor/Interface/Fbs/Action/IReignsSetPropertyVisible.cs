using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2E RID: 28206
	public struct IReignsSetPropertyVisible : IFlatbufferObject
	{
		// Token: 0x1700D231 RID: 53809
		// (get) Token: 0x06031D5C RID: 204124 RVA: 0x006BEDCE File Offset: 0x006BCFCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D5D RID: 204125 RVA: 0x006BEDDB File Offset: 0x006BCFDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D5E RID: 204126 RVA: 0x006BEDE4 File Offset: 0x006BCFE4
		public static IReignsSetPropertyVisible GetRootAsIReignsSetPropertyVisible(ByteBuffer _bb)
		{
			return IReignsSetPropertyVisible.GetRootAsIReignsSetPropertyVisible(_bb, default(IReignsSetPropertyVisible));
		}

		// Token: 0x06031D5F RID: 204127 RVA: 0x006BEE00 File Offset: 0x006BD000
		public static IReignsSetPropertyVisible GetRootAsIReignsSetPropertyVisible(ByteBuffer _bb, IReignsSetPropertyVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D60 RID: 204128 RVA: 0x006BEE1D File Offset: 0x006BD01D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D61 RID: 204129 RVA: 0x006BEE2C File Offset: 0x006BD02C
		public IReignsSetPropertyVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D232 RID: 53810
		// (get) Token: 0x06031D62 RID: 204130 RVA: 0x006BEE3C File Offset: 0x006BD03C
		public int PropertyId
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

		// Token: 0x1700D233 RID: 53811
		// (get) Token: 0x06031D63 RID: 204131 RVA: 0x006BEE78 File Offset: 0x006BD078
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06031D64 RID: 204132 RVA: 0x006BEEB7 File Offset: 0x006BD0B7
		public static Offset<IReignsSetPropertyVisible> CreateIReignsSetPropertyVisible(FlatBufferBuilder builder, int PropertyId = 0, bool IsVisible = false)
		{
			builder.StartTable(2);
			IReignsSetPropertyVisible.AddPropertyId(builder, PropertyId);
			IReignsSetPropertyVisible.AddIsVisible(builder, IsVisible);
			return IReignsSetPropertyVisible.EndIReignsSetPropertyVisible(builder);
		}

		// Token: 0x06031D65 RID: 204133 RVA: 0x006BEED4 File Offset: 0x006BD0D4
		public static void StartIReignsSetPropertyVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031D66 RID: 204134 RVA: 0x006BEEDD File Offset: 0x006BD0DD
		public static void AddPropertyId(FlatBufferBuilder builder, int propertyId)
		{
			builder.AddInt(0, propertyId, 0);
		}

		// Token: 0x06031D67 RID: 204135 RVA: 0x006BEEE8 File Offset: 0x006BD0E8
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(1, isVisible, false);
		}

		// Token: 0x06031D68 RID: 204136 RVA: 0x006BEEF3 File Offset: 0x006BD0F3
		public static Offset<IReignsSetPropertyVisible> EndIReignsSetPropertyVisible(FlatBufferBuilder builder)
		{
			return new Offset<IReignsSetPropertyVisible>(builder.EndTable());
		}

		// Token: 0x06031D69 RID: 204137 RVA: 0x006BEF00 File Offset: 0x006BD100
		public IReignsSetPropertyVisibleT UnPack()
		{
			IReignsSetPropertyVisibleT reignsSetPropertyVisibleT = new IReignsSetPropertyVisibleT();
			this.UnPackTo(reignsSetPropertyVisibleT);
			return reignsSetPropertyVisibleT;
		}

		// Token: 0x06031D6A RID: 204138 RVA: 0x006BEF1B File Offset: 0x006BD11B
		public void UnPackTo(IReignsSetPropertyVisibleT _o)
		{
			_o.PropertyId = this.PropertyId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x06031D6B RID: 204139 RVA: 0x006BEF38 File Offset: 0x006BD138
		public static Offset<IReignsSetPropertyVisible> Pack(FlatBufferBuilder builder, IReignsSetPropertyVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsSetPropertyVisible>);
			}
			return IReignsSetPropertyVisible.CreateIReignsSetPropertyVisible(builder, _o.PropertyId, _o.IsVisible);
		}

		// Token: 0x04011813 RID: 71699
		private Table __p;
	}
}
