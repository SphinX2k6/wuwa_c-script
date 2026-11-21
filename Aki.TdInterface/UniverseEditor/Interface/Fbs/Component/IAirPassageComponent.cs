using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005397 RID: 21399
	public struct IAirPassageComponent : IFlatbufferObject
	{
		// Token: 0x17009746 RID: 38726
		// (get) Token: 0x06021607 RID: 136711 RVA: 0x0049B12A File Offset: 0x0049932A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021608 RID: 136712 RVA: 0x0049B137 File Offset: 0x00499337
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021609 RID: 136713 RVA: 0x0049B140 File Offset: 0x00499340
		public static IAirPassageComponent GetRootAsIAirPassageComponent(ByteBuffer _bb)
		{
			return IAirPassageComponent.GetRootAsIAirPassageComponent(_bb, default(IAirPassageComponent));
		}

		// Token: 0x0602160A RID: 136714 RVA: 0x0049B15C File Offset: 0x0049935C
		public static IAirPassageComponent GetRootAsIAirPassageComponent(ByteBuffer _bb, IAirPassageComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602160B RID: 136715 RVA: 0x0049B179 File Offset: 0x00499379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602160C RID: 136716 RVA: 0x0049B188 File Offset: 0x00499388
		public IAirPassageComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009747 RID: 38727
		// (get) Token: 0x0602160D RID: 136717 RVA: 0x0049B198 File Offset: 0x00499398
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009748 RID: 38728
		// (get) Token: 0x0602160E RID: 136718 RVA: 0x0049B1D8 File Offset: 0x004993D8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602160F RID: 136719 RVA: 0x0049B214 File Offset: 0x00499414
		public static Offset<IAirPassageComponent> CreateIAirPassageComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IAirPassageComponent.AddNullMask(builder, NullMask);
			IAirPassageComponent.AddDisabled(builder, Disabled);
			return IAirPassageComponent.EndIAirPassageComponent(builder);
		}

		// Token: 0x06021610 RID: 136720 RVA: 0x0049B231 File Offset: 0x00499431
		public static void StartIAirPassageComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021611 RID: 136721 RVA: 0x0049B23A File Offset: 0x0049943A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021612 RID: 136722 RVA: 0x0049B245 File Offset: 0x00499445
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06021613 RID: 136723 RVA: 0x0049B250 File Offset: 0x00499450
		public static Offset<IAirPassageComponent> EndIAirPassageComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageComponent>(builder.EndTable());
		}

		// Token: 0x06021614 RID: 136724 RVA: 0x0049B260 File Offset: 0x00499460
		public IAirPassageComponentT UnPack()
		{
			IAirPassageComponentT airPassageComponentT = new IAirPassageComponentT();
			this.UnPackTo(airPassageComponentT);
			return airPassageComponentT;
		}

		// Token: 0x06021615 RID: 136725 RVA: 0x0049B27B File Offset: 0x0049947B
		public void UnPackTo(IAirPassageComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021616 RID: 136726 RVA: 0x0049B298 File Offset: 0x00499498
		public static Offset<IAirPassageComponent> Pack(FlatBufferBuilder builder, IAirPassageComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageComponent>);
			}
			return IAirPassageComponent.CreateIAirPassageComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400E7C4 RID: 59332
		private Table __p;
	}
}
