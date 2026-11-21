using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E0 RID: 25056
	public struct IWuWaGoMovableGridStatePos : IFlatbufferObject
	{
		// Token: 0x1700BAD4 RID: 47828
		// (get) Token: 0x0602A9D1 RID: 174545 RVA: 0x005CF82F File Offset: 0x005CDA2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A9D2 RID: 174546 RVA: 0x005CF83C File Offset: 0x005CDA3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A9D3 RID: 174547 RVA: 0x005CF844 File Offset: 0x005CDA44
		public static IWuWaGoMovableGridStatePos GetRootAsIWuWaGoMovableGridStatePos(ByteBuffer _bb)
		{
			return IWuWaGoMovableGridStatePos.GetRootAsIWuWaGoMovableGridStatePos(_bb, default(IWuWaGoMovableGridStatePos));
		}

		// Token: 0x0602A9D4 RID: 174548 RVA: 0x005CF860 File Offset: 0x005CDA60
		public static IWuWaGoMovableGridStatePos GetRootAsIWuWaGoMovableGridStatePos(ByteBuffer _bb, IWuWaGoMovableGridStatePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A9D5 RID: 174549 RVA: 0x005CF87D File Offset: 0x005CDA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A9D6 RID: 174550 RVA: 0x005CF88C File Offset: 0x005CDA8C
		public IWuWaGoMovableGridStatePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAD5 RID: 47829
		// (get) Token: 0x0602A9D7 RID: 174551 RVA: 0x005CF89C File Offset: 0x005CDA9C
		public string EntityState
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

		// Token: 0x0602A9D8 RID: 174552 RVA: 0x005CF8D3 File Offset: 0x005CDAD3
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602A9D9 RID: 174553 RVA: 0x005CF8E2 File Offset: 0x005CDAE2
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BAD6 RID: 47830
		// (get) Token: 0x0602A9DA RID: 174554 RVA: 0x005CF8F0 File Offset: 0x005CDAF0
		public IVectorInfo? GridPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A9DB RID: 174555 RVA: 0x005CF94D File Offset: 0x005CDB4D
		public static Offset<IWuWaGoMovableGridStatePos> CreateIWuWaGoMovableGridStatePos(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), Offset<IVectorInfo> GridPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IWuWaGoMovableGridStatePos.AddGridPos(builder, GridPosOffset);
			IWuWaGoMovableGridStatePos.AddEntityState(builder, EntityStateOffset);
			return IWuWaGoMovableGridStatePos.EndIWuWaGoMovableGridStatePos(builder);
		}

		// Token: 0x0602A9DC RID: 174556 RVA: 0x005CF96A File Offset: 0x005CDB6A
		public static void StartIWuWaGoMovableGridStatePos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A9DD RID: 174557 RVA: 0x005CF973 File Offset: 0x005CDB73
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602A9DE RID: 174558 RVA: 0x005CF983 File Offset: 0x005CDB83
		public static void AddGridPos(FlatBufferBuilder builder, Offset<IVectorInfo> gridPosOffset)
		{
			builder.AddOffset(1, gridPosOffset.Value, 0);
		}

		// Token: 0x0602A9DF RID: 174559 RVA: 0x005CF993 File Offset: 0x005CDB93
		public static Offset<IWuWaGoMovableGridStatePos> EndIWuWaGoMovableGridStatePos(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoMovableGridStatePos>(builder.EndTable());
		}

		// Token: 0x0602A9E0 RID: 174560 RVA: 0x005CF9A0 File Offset: 0x005CDBA0
		public IWuWaGoMovableGridStatePosT UnPack()
		{
			IWuWaGoMovableGridStatePosT wuWaGoMovableGridStatePosT = new IWuWaGoMovableGridStatePosT();
			this.UnPackTo(wuWaGoMovableGridStatePosT);
			return wuWaGoMovableGridStatePosT;
		}

		// Token: 0x0602A9E1 RID: 174561 RVA: 0x005CF9BC File Offset: 0x005CDBBC
		public void UnPackTo(IWuWaGoMovableGridStatePosT _o)
		{
			_o.EntityState = this.EntityState;
			_o.GridPos = ((this.GridPos != null) ? this.GridPos.Value.UnPack() : null);
		}

		// Token: 0x0602A9E2 RID: 174562 RVA: 0x005CFA04 File Offset: 0x005CDC04
		public static Offset<IWuWaGoMovableGridStatePos> Pack(FlatBufferBuilder builder, IWuWaGoMovableGridStatePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoMovableGridStatePos>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			Offset<IVectorInfo> gridPosOffset = (_o.GridPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.GridPos);
			return IWuWaGoMovableGridStatePos.CreateIWuWaGoMovableGridStatePos(builder, entityStateOffset, gridPosOffset);
		}

		// Token: 0x0401004C RID: 65612
		private Table __p;
	}
}
