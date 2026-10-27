using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCA RID: 23498
	public struct IWuWaGoMovableGridStatePos : IFlatbufferObject
	{
		// Token: 0x1700B18C RID: 45452
		// (get) Token: 0x0602840D RID: 164877 RVA: 0x00587D9F File Offset: 0x00585F9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602840E RID: 164878 RVA: 0x00587DAC File Offset: 0x00585FAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602840F RID: 164879 RVA: 0x00587DB4 File Offset: 0x00585FB4
		public static IWuWaGoMovableGridStatePos GetRootAsIWuWaGoMovableGridStatePos(ByteBuffer _bb)
		{
			return IWuWaGoMovableGridStatePos.GetRootAsIWuWaGoMovableGridStatePos(_bb, default(IWuWaGoMovableGridStatePos));
		}

		// Token: 0x06028410 RID: 164880 RVA: 0x00587DD0 File Offset: 0x00585FD0
		public static IWuWaGoMovableGridStatePos GetRootAsIWuWaGoMovableGridStatePos(ByteBuffer _bb, IWuWaGoMovableGridStatePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028411 RID: 164881 RVA: 0x00587DED File Offset: 0x00585FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028412 RID: 164882 RVA: 0x00587DFC File Offset: 0x00585FFC
		public IWuWaGoMovableGridStatePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B18D RID: 45453
		// (get) Token: 0x06028413 RID: 164883 RVA: 0x00587E0C File Offset: 0x0058600C
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

		// Token: 0x06028414 RID: 164884 RVA: 0x00587E43 File Offset: 0x00586043
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028415 RID: 164885 RVA: 0x00587E52 File Offset: 0x00586052
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B18E RID: 45454
		// (get) Token: 0x06028416 RID: 164886 RVA: 0x00587E60 File Offset: 0x00586060
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

		// Token: 0x06028417 RID: 164887 RVA: 0x00587EBD File Offset: 0x005860BD
		public static Offset<IWuWaGoMovableGridStatePos> CreateIWuWaGoMovableGridStatePos(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), Offset<IVectorInfo> GridPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IWuWaGoMovableGridStatePos.AddGridPos(builder, GridPosOffset);
			IWuWaGoMovableGridStatePos.AddEntityState(builder, EntityStateOffset);
			return IWuWaGoMovableGridStatePos.EndIWuWaGoMovableGridStatePos(builder);
		}

		// Token: 0x06028418 RID: 164888 RVA: 0x00587EDA File Offset: 0x005860DA
		public static void StartIWuWaGoMovableGridStatePos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028419 RID: 164889 RVA: 0x00587EE3 File Offset: 0x005860E3
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602841A RID: 164890 RVA: 0x00587EF3 File Offset: 0x005860F3
		public static void AddGridPos(FlatBufferBuilder builder, Offset<IVectorInfo> gridPosOffset)
		{
			builder.AddOffset(1, gridPosOffset.Value, 0);
		}

		// Token: 0x0602841B RID: 164891 RVA: 0x00587F03 File Offset: 0x00586103
		public static Offset<IWuWaGoMovableGridStatePos> EndIWuWaGoMovableGridStatePos(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoMovableGridStatePos>(builder.EndTable());
		}

		// Token: 0x0602841C RID: 164892 RVA: 0x00587F10 File Offset: 0x00586110
		public IWuWaGoMovableGridStatePosT UnPack()
		{
			IWuWaGoMovableGridStatePosT wuWaGoMovableGridStatePosT = new IWuWaGoMovableGridStatePosT();
			this.UnPackTo(wuWaGoMovableGridStatePosT);
			return wuWaGoMovableGridStatePosT;
		}

		// Token: 0x0602841D RID: 164893 RVA: 0x00587F2C File Offset: 0x0058612C
		public void UnPackTo(IWuWaGoMovableGridStatePosT _o)
		{
			_o.EntityState = this.EntityState;
			_o.GridPos = ((this.GridPos != null) ? this.GridPos.Value.UnPack() : null);
		}

		// Token: 0x0602841E RID: 164894 RVA: 0x00587F74 File Offset: 0x00586174
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

		// Token: 0x0400F346 RID: 62278
		private Table __p;
	}
}
