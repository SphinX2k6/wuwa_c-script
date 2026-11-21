using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB0 RID: 23216
	public struct IMechascoutDragInstant : IFlatbufferObject
	{
		// Token: 0x1700A93B RID: 43323
		// (get) Token: 0x0602611B RID: 155931 RVA: 0x00537659 File Offset: 0x00535859
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602611C RID: 155932 RVA: 0x00537666 File Offset: 0x00535866
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602611D RID: 155933 RVA: 0x00537670 File Offset: 0x00535870
		public static IMechascoutDragInstant GetRootAsIMechascoutDragInstant(ByteBuffer _bb)
		{
			return IMechascoutDragInstant.GetRootAsIMechascoutDragInstant(_bb, default(IMechascoutDragInstant));
		}

		// Token: 0x0602611E RID: 155934 RVA: 0x0053768C File Offset: 0x0053588C
		public static IMechascoutDragInstant GetRootAsIMechascoutDragInstant(ByteBuffer _bb, IMechascoutDragInstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602611F RID: 155935 RVA: 0x005376A9 File Offset: 0x005358A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026120 RID: 155936 RVA: 0x005376B8 File Offset: 0x005358B8
		public IMechascoutDragInstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A93C RID: 43324
		// (get) Token: 0x06026121 RID: 155937 RVA: 0x005376C8 File Offset: 0x005358C8
		public EMechascoutDragType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechascoutDragType.Instant;
				}
				return (EMechascoutDragType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026122 RID: 155938 RVA: 0x00537704 File Offset: 0x00535904
		public static Offset<IMechascoutDragInstant> CreateIMechascoutDragInstant(FlatBufferBuilder builder, EMechascoutDragType Type = EMechascoutDragType.Instant)
		{
			builder.StartTable(1);
			IMechascoutDragInstant.AddType(builder, Type);
			return IMechascoutDragInstant.EndIMechascoutDragInstant(builder);
		}

		// Token: 0x06026123 RID: 155939 RVA: 0x0053771A File Offset: 0x0053591A
		public static void StartIMechascoutDragInstant(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026124 RID: 155940 RVA: 0x00537723 File Offset: 0x00535923
		public static void AddType(FlatBufferBuilder builder, EMechascoutDragType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026125 RID: 155941 RVA: 0x0053772E File Offset: 0x0053592E
		public static Offset<IMechascoutDragInstant> EndIMechascoutDragInstant(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutDragInstant>(builder.EndTable());
		}

		// Token: 0x06026126 RID: 155942 RVA: 0x0053773C File Offset: 0x0053593C
		public IMechascoutDragInstantT UnPack()
		{
			IMechascoutDragInstantT mechascoutDragInstantT = new IMechascoutDragInstantT();
			this.UnPackTo(mechascoutDragInstantT);
			return mechascoutDragInstantT;
		}

		// Token: 0x06026127 RID: 155943 RVA: 0x00537757 File Offset: 0x00535957
		public void UnPackTo(IMechascoutDragInstantT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026128 RID: 155944 RVA: 0x00537768 File Offset: 0x00535968
		public static Offset<IMechascoutDragInstant> Pack(FlatBufferBuilder builder, IMechascoutDragInstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutDragInstant>);
			}
			return IMechascoutDragInstant.CreateIMechascoutDragInstant(builder, _o.Type);
		}

		// Token: 0x0400F459 RID: 62553
		private Table __p;
	}
}
