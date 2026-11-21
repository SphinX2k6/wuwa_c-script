using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005574 RID: 21876
	public struct IConnectorPathAdvanceVisual : IFlatbufferObject
	{
		// Token: 0x17009C85 RID: 40069
		// (get) Token: 0x06022C07 RID: 142343 RVA: 0x004C94B0 File Offset: 0x004C76B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C08 RID: 142344 RVA: 0x004C94BD File Offset: 0x004C76BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C09 RID: 142345 RVA: 0x004C94C4 File Offset: 0x004C76C4
		public static IConnectorPathAdvanceVisual GetRootAsIConnectorPathAdvanceVisual(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceVisual.GetRootAsIConnectorPathAdvanceVisual(_bb, default(IConnectorPathAdvanceVisual));
		}

		// Token: 0x06022C0A RID: 142346 RVA: 0x004C94E0 File Offset: 0x004C76E0
		public static IConnectorPathAdvanceVisual GetRootAsIConnectorPathAdvanceVisual(ByteBuffer _bb, IConnectorPathAdvanceVisual obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C0B RID: 142347 RVA: 0x004C94FD File Offset: 0x004C76FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C0C RID: 142348 RVA: 0x004C950C File Offset: 0x004C770C
		public IConnectorPathAdvanceVisual __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C86 RID: 40070
		// (get) Token: 0x06022C0D RID: 142349 RVA: 0x004C951C File Offset: 0x004C771C
		public EConnectorPathAdvanceVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return (EConnectorPathAdvanceVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022C0E RID: 142350 RVA: 0x004C9558 File Offset: 0x004C7758
		public static Offset<IConnectorPathAdvanceVisual> CreateIConnectorPathAdvanceVisual(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType Type = EConnectorPathAdvanceVisualType.VasePlant)
		{
			builder.StartTable(1);
			IConnectorPathAdvanceVisual.AddType(builder, Type);
			return IConnectorPathAdvanceVisual.EndIConnectorPathAdvanceVisual(builder);
		}

		// Token: 0x06022C0F RID: 142351 RVA: 0x004C956E File Offset: 0x004C776E
		public static void StartIConnectorPathAdvanceVisual(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022C10 RID: 142352 RVA: 0x004C9577 File Offset: 0x004C7777
		public static void AddType(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022C11 RID: 142353 RVA: 0x004C9582 File Offset: 0x004C7782
		public static Offset<IConnectorPathAdvanceVisual> EndIConnectorPathAdvanceVisual(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceVisual>(builder.EndTable());
		}

		// Token: 0x06022C12 RID: 142354 RVA: 0x004C9590 File Offset: 0x004C7790
		public IConnectorPathAdvanceVisualT UnPack()
		{
			IConnectorPathAdvanceVisualT connectorPathAdvanceVisualT = new IConnectorPathAdvanceVisualT();
			this.UnPackTo(connectorPathAdvanceVisualT);
			return connectorPathAdvanceVisualT;
		}

		// Token: 0x06022C13 RID: 142355 RVA: 0x004C95AB File Offset: 0x004C77AB
		public void UnPackTo(IConnectorPathAdvanceVisualT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022C14 RID: 142356 RVA: 0x004C95BC File Offset: 0x004C77BC
		public static Offset<IConnectorPathAdvanceVisual> Pack(FlatBufferBuilder builder, IConnectorPathAdvanceVisualT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorPathAdvanceVisual>);
			}
			return IConnectorPathAdvanceVisual.CreateIConnectorPathAdvanceVisual(builder, _o.Type);
		}

		// Token: 0x0400EBDC RID: 60380
		private Table __p;
	}
}
