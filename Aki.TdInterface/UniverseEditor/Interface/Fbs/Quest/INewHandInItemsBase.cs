using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200438E RID: 17294
	public struct INewHandInItemsBase : IFlatbufferObject
	{
		// Token: 0x170076A8 RID: 30376
		// (get) Token: 0x06018722 RID: 100130 RVA: 0x0037BFE2 File Offset: 0x0037A1E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018723 RID: 100131 RVA: 0x0037BFEF File Offset: 0x0037A1EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018724 RID: 100132 RVA: 0x0037BFF8 File Offset: 0x0037A1F8
		public static INewHandInItemsBase GetRootAsINewHandInItemsBase(ByteBuffer _bb)
		{
			return INewHandInItemsBase.GetRootAsINewHandInItemsBase(_bb, default(INewHandInItemsBase));
		}

		// Token: 0x06018725 RID: 100133 RVA: 0x0037C014 File Offset: 0x0037A214
		public static INewHandInItemsBase GetRootAsINewHandInItemsBase(ByteBuffer _bb, INewHandInItemsBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018726 RID: 100134 RVA: 0x0037C031 File Offset: 0x0037A231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018727 RID: 100135 RVA: 0x0037C040 File Offset: 0x0037A240
		public INewHandInItemsBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076A9 RID: 30377
		// (get) Token: 0x06018728 RID: 100136 RVA: 0x0037C050 File Offset: 0x0037A250
		public ENewHandInItemsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewHandInItemsType.ProjectionMachine;
				}
				return (ENewHandInItemsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018729 RID: 100137 RVA: 0x0037C08C File Offset: 0x0037A28C
		public static Offset<INewHandInItemsBase> CreateINewHandInItemsBase(FlatBufferBuilder builder, ENewHandInItemsType Type = ENewHandInItemsType.ProjectionMachine)
		{
			builder.StartTable(1);
			INewHandInItemsBase.AddType(builder, Type);
			return INewHandInItemsBase.EndINewHandInItemsBase(builder);
		}

		// Token: 0x0601872A RID: 100138 RVA: 0x0037C0A2 File Offset: 0x0037A2A2
		public static void StartINewHandInItemsBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601872B RID: 100139 RVA: 0x0037C0AB File Offset: 0x0037A2AB
		public static void AddType(FlatBufferBuilder builder, ENewHandInItemsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601872C RID: 100140 RVA: 0x0037C0B6 File Offset: 0x0037A2B6
		public static Offset<INewHandInItemsBase> EndINewHandInItemsBase(FlatBufferBuilder builder)
		{
			return new Offset<INewHandInItemsBase>(builder.EndTable());
		}

		// Token: 0x0601872D RID: 100141 RVA: 0x0037C0C4 File Offset: 0x0037A2C4
		public INewHandInItemsBaseT UnPack()
		{
			INewHandInItemsBaseT newHandInItemsBaseT = new INewHandInItemsBaseT();
			this.UnPackTo(newHandInItemsBaseT);
			return newHandInItemsBaseT;
		}

		// Token: 0x0601872E RID: 100142 RVA: 0x0037C0DF File Offset: 0x0037A2DF
		public void UnPackTo(INewHandInItemsBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601872F RID: 100143 RVA: 0x0037C0F0 File Offset: 0x0037A2F0
		public static Offset<INewHandInItemsBase> Pack(FlatBufferBuilder builder, INewHandInItemsBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewHandInItemsBase>);
			}
			return INewHandInItemsBase.CreateINewHandInItemsBase(builder, _o.Type);
		}

		// Token: 0x0400C33F RID: 49983
		private Table __p;
	}
}
