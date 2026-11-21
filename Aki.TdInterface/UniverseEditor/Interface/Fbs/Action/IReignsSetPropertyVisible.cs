using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AC RID: 30124
	public struct IReignsSetPropertyVisible : IFlatbufferObject
	{
		// Token: 0x1700DD80 RID: 56704
		// (get) Token: 0x06034D72 RID: 216434 RVA: 0x0071A756 File Offset: 0x00718956
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D73 RID: 216435 RVA: 0x0071A763 File Offset: 0x00718963
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D74 RID: 216436 RVA: 0x0071A76C File Offset: 0x0071896C
		public static IReignsSetPropertyVisible GetRootAsIReignsSetPropertyVisible(ByteBuffer _bb)
		{
			return IReignsSetPropertyVisible.GetRootAsIReignsSetPropertyVisible(_bb, default(IReignsSetPropertyVisible));
		}

		// Token: 0x06034D75 RID: 216437 RVA: 0x0071A788 File Offset: 0x00718988
		public static IReignsSetPropertyVisible GetRootAsIReignsSetPropertyVisible(ByteBuffer _bb, IReignsSetPropertyVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D76 RID: 216438 RVA: 0x0071A7A5 File Offset: 0x007189A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D77 RID: 216439 RVA: 0x0071A7B4 File Offset: 0x007189B4
		public IReignsSetPropertyVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD81 RID: 56705
		// (get) Token: 0x06034D78 RID: 216440 RVA: 0x0071A7C4 File Offset: 0x007189C4
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

		// Token: 0x1700DD82 RID: 56706
		// (get) Token: 0x06034D79 RID: 216441 RVA: 0x0071A800 File Offset: 0x00718A00
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06034D7A RID: 216442 RVA: 0x0071A83F File Offset: 0x00718A3F
		public static Offset<IReignsSetPropertyVisible> CreateIReignsSetPropertyVisible(FlatBufferBuilder builder, int PropertyId = 0, bool IsVisible = false)
		{
			builder.StartTable(2);
			IReignsSetPropertyVisible.AddPropertyId(builder, PropertyId);
			IReignsSetPropertyVisible.AddIsVisible(builder, IsVisible);
			return IReignsSetPropertyVisible.EndIReignsSetPropertyVisible(builder);
		}

		// Token: 0x06034D7B RID: 216443 RVA: 0x0071A85C File Offset: 0x00718A5C
		public static void StartIReignsSetPropertyVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034D7C RID: 216444 RVA: 0x0071A865 File Offset: 0x00718A65
		public static void AddPropertyId(FlatBufferBuilder builder, int propertyId)
		{
			builder.AddInt(0, propertyId, 0);
		}

		// Token: 0x06034D7D RID: 216445 RVA: 0x0071A870 File Offset: 0x00718A70
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(1, isVisible, false);
		}

		// Token: 0x06034D7E RID: 216446 RVA: 0x0071A87B File Offset: 0x00718A7B
		public static Offset<IReignsSetPropertyVisible> EndIReignsSetPropertyVisible(FlatBufferBuilder builder)
		{
			return new Offset<IReignsSetPropertyVisible>(builder.EndTable());
		}

		// Token: 0x06034D7F RID: 216447 RVA: 0x0071A888 File Offset: 0x00718A88
		public IReignsSetPropertyVisibleT UnPack()
		{
			IReignsSetPropertyVisibleT reignsSetPropertyVisibleT = new IReignsSetPropertyVisibleT();
			this.UnPackTo(reignsSetPropertyVisibleT);
			return reignsSetPropertyVisibleT;
		}

		// Token: 0x06034D80 RID: 216448 RVA: 0x0071A8A3 File Offset: 0x00718AA3
		public void UnPackTo(IReignsSetPropertyVisibleT _o)
		{
			_o.PropertyId = this.PropertyId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x06034D81 RID: 216449 RVA: 0x0071A8C0 File Offset: 0x00718AC0
		public static Offset<IReignsSetPropertyVisible> Pack(FlatBufferBuilder builder, IReignsSetPropertyVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsSetPropertyVisible>);
			}
			return IReignsSetPropertyVisible.CreateIReignsSetPropertyVisible(builder, _o.PropertyId, _o.IsVisible);
		}

		// Token: 0x04012793 RID: 75667
		private Table __p;
	}
}
