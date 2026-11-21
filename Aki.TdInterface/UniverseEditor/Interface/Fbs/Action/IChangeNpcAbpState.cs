using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697C RID: 27004
	public struct IChangeNpcAbpState : IFlatbufferObject
	{
		// Token: 0x1700C6D2 RID: 50898
		// (get) Token: 0x0602E4FE RID: 189694 RVA: 0x00652C9B File Offset: 0x00650E9B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4FF RID: 189695 RVA: 0x00652CA8 File Offset: 0x00650EA8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E500 RID: 189696 RVA: 0x00652CB0 File Offset: 0x00650EB0
		public static IChangeNpcAbpState GetRootAsIChangeNpcAbpState(ByteBuffer _bb)
		{
			return IChangeNpcAbpState.GetRootAsIChangeNpcAbpState(_bb, default(IChangeNpcAbpState));
		}

		// Token: 0x0602E501 RID: 189697 RVA: 0x00652CCC File Offset: 0x00650ECC
		public static IChangeNpcAbpState GetRootAsIChangeNpcAbpState(ByteBuffer _bb, IChangeNpcAbpState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E502 RID: 189698 RVA: 0x00652CE9 File Offset: 0x00650EE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E503 RID: 189699 RVA: 0x00652CF8 File Offset: 0x00650EF8
		public IChangeNpcAbpState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6D3 RID: 50899
		// (get) Token: 0x0602E504 RID: 189700 RVA: 0x00652D08 File Offset: 0x00650F08
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

		// Token: 0x1700C6D4 RID: 50900
		// (get) Token: 0x0602E505 RID: 189701 RVA: 0x00652D44 File Offset: 0x00650F44
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

		// Token: 0x0602E506 RID: 189702 RVA: 0x00652D7B File Offset: 0x00650F7B
		public Span<byte> GetAbpStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E507 RID: 189703 RVA: 0x00652D8A File Offset: 0x00650F8A
		public byte[] GetAbpStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E508 RID: 189704 RVA: 0x00652D98 File Offset: 0x00650F98
		public static Offset<IChangeNpcAbpState> CreateIChangeNpcAbpState(FlatBufferBuilder builder, int EntityId = 0, StringOffset AbpStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeNpcAbpState.AddAbpState(builder, AbpStateOffset);
			IChangeNpcAbpState.AddEntityId(builder, EntityId);
			return IChangeNpcAbpState.EndIChangeNpcAbpState(builder);
		}

		// Token: 0x0602E509 RID: 189705 RVA: 0x00652DB5 File Offset: 0x00650FB5
		public static void StartIChangeNpcAbpState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E50A RID: 189706 RVA: 0x00652DBE File Offset: 0x00650FBE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602E50B RID: 189707 RVA: 0x00652DC9 File Offset: 0x00650FC9
		public static void AddAbpState(FlatBufferBuilder builder, StringOffset abpStateOffset)
		{
			builder.AddOffset(1, abpStateOffset.Value, 0);
		}

		// Token: 0x0602E50C RID: 189708 RVA: 0x00652DD9 File Offset: 0x00650FD9
		public static Offset<IChangeNpcAbpState> EndIChangeNpcAbpState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeNpcAbpState>(builder.EndTable());
		}

		// Token: 0x0602E50D RID: 189709 RVA: 0x00652DE8 File Offset: 0x00650FE8
		public IChangeNpcAbpStateT UnPack()
		{
			IChangeNpcAbpStateT changeNpcAbpStateT = new IChangeNpcAbpStateT();
			this.UnPackTo(changeNpcAbpStateT);
			return changeNpcAbpStateT;
		}

		// Token: 0x0602E50E RID: 189710 RVA: 0x00652E03 File Offset: 0x00651003
		public void UnPackTo(IChangeNpcAbpStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.AbpState = this.AbpState;
		}

		// Token: 0x0602E50F RID: 189711 RVA: 0x00652E20 File Offset: 0x00651020
		public static Offset<IChangeNpcAbpState> Pack(FlatBufferBuilder builder, IChangeNpcAbpStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeNpcAbpState>);
			}
			StringOffset abpStateOffset = (_o.AbpState == null) ? default(StringOffset) : builder.CreateString(_o.AbpState);
			return IChangeNpcAbpState.CreateIChangeNpcAbpState(builder, _o.EntityId, abpStateOffset);
		}

		// Token: 0x040116E3 RID: 71395
		private Table __p;
	}
}
