using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200630B RID: 25355
	public struct IChangeNpcAbpState : IFlatbufferObject
	{
		// Token: 0x1700BD48 RID: 48456
		// (get) Token: 0x0602BD95 RID: 179605 RVA: 0x00607C8F File Offset: 0x00605E8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD96 RID: 179606 RVA: 0x00607C9C File Offset: 0x00605E9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD97 RID: 179607 RVA: 0x00607CA4 File Offset: 0x00605EA4
		public static IChangeNpcAbpState GetRootAsIChangeNpcAbpState(ByteBuffer _bb)
		{
			return IChangeNpcAbpState.GetRootAsIChangeNpcAbpState(_bb, default(IChangeNpcAbpState));
		}

		// Token: 0x0602BD98 RID: 179608 RVA: 0x00607CC0 File Offset: 0x00605EC0
		public static IChangeNpcAbpState GetRootAsIChangeNpcAbpState(ByteBuffer _bb, IChangeNpcAbpState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD99 RID: 179609 RVA: 0x00607CDD File Offset: 0x00605EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD9A RID: 179610 RVA: 0x00607CEC File Offset: 0x00605EEC
		public IChangeNpcAbpState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD49 RID: 48457
		// (get) Token: 0x0602BD9B RID: 179611 RVA: 0x00607CFC File Offset: 0x00605EFC
		public int EntityId
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

		// Token: 0x1700BD4A RID: 48458
		// (get) Token: 0x0602BD9C RID: 179612 RVA: 0x00607D38 File Offset: 0x00605F38
		public string AbpState
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

		// Token: 0x0602BD9D RID: 179613 RVA: 0x00607D6F File Offset: 0x00605F6F
		public Span<byte> GetAbpStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602BD9E RID: 179614 RVA: 0x00607D7E File Offset: 0x00605F7E
		public byte[] GetAbpStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602BD9F RID: 179615 RVA: 0x00607D8C File Offset: 0x00605F8C
		public static Offset<IChangeNpcAbpState> CreateIChangeNpcAbpState(FlatBufferBuilder builder, int EntityId = 0, StringOffset AbpStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeNpcAbpState.AddAbpState(builder, AbpStateOffset);
			IChangeNpcAbpState.AddEntityId(builder, EntityId);
			return IChangeNpcAbpState.EndIChangeNpcAbpState(builder);
		}

		// Token: 0x0602BDA0 RID: 179616 RVA: 0x00607DA9 File Offset: 0x00605FA9
		public static void StartIChangeNpcAbpState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BDA1 RID: 179617 RVA: 0x00607DB2 File Offset: 0x00605FB2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602BDA2 RID: 179618 RVA: 0x00607DBD File Offset: 0x00605FBD
		public static void AddAbpState(FlatBufferBuilder builder, StringOffset abpStateOffset)
		{
			builder.AddOffset(1, abpStateOffset.Value, 0);
		}

		// Token: 0x0602BDA3 RID: 179619 RVA: 0x00607DCD File Offset: 0x00605FCD
		public static Offset<IChangeNpcAbpState> EndIChangeNpcAbpState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeNpcAbpState>(builder.EndTable());
		}

		// Token: 0x0602BDA4 RID: 179620 RVA: 0x00607DDC File Offset: 0x00605FDC
		public IChangeNpcAbpStateT UnPack()
		{
			IChangeNpcAbpStateT changeNpcAbpStateT = new IChangeNpcAbpStateT();
			this.UnPackTo(changeNpcAbpStateT);
			return changeNpcAbpStateT;
		}

		// Token: 0x0602BDA5 RID: 179621 RVA: 0x00607DF7 File Offset: 0x00605FF7
		public void UnPackTo(IChangeNpcAbpStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.AbpState = this.AbpState;
		}

		// Token: 0x0602BDA6 RID: 179622 RVA: 0x00607E14 File Offset: 0x00606014
		public static Offset<IChangeNpcAbpState> Pack(FlatBufferBuilder builder, IChangeNpcAbpStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeNpcAbpState>);
			}
			StringOffset abpStateOffset = (_o.AbpState == null) ? default(StringOffset) : builder.CreateString(_o.AbpState);
			return IChangeNpcAbpState.CreateIChangeNpcAbpState(builder, _o.EntityId, abpStateOffset);
		}

		// Token: 0x040108CD RID: 67789
		private Table __p;
	}
}
