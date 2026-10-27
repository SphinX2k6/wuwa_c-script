using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E86 RID: 20102
	public struct IAirPassageComponent : IFlatbufferObject
	{
		// Token: 0x1700900D RID: 36877
		// (get) Token: 0x0601F9BC RID: 129468 RVA: 0x00467112 File Offset: 0x00465312
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9BD RID: 129469 RVA: 0x0046711F File Offset: 0x0046531F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9BE RID: 129470 RVA: 0x00467128 File Offset: 0x00465328
		public static IAirPassageComponent GetRootAsIAirPassageComponent(ByteBuffer _bb)
		{
			return IAirPassageComponent.GetRootAsIAirPassageComponent(_bb, default(IAirPassageComponent));
		}

		// Token: 0x0601F9BF RID: 129471 RVA: 0x00467144 File Offset: 0x00465344
		public static IAirPassageComponent GetRootAsIAirPassageComponent(ByteBuffer _bb, IAirPassageComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9C0 RID: 129472 RVA: 0x00467161 File Offset: 0x00465361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F9C1 RID: 129473 RVA: 0x00467170 File Offset: 0x00465370
		public IAirPassageComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700900E RID: 36878
		// (get) Token: 0x0601F9C2 RID: 129474 RVA: 0x00467180 File Offset: 0x00465380
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700900F RID: 36879
		// (get) Token: 0x0601F9C3 RID: 129475 RVA: 0x004671C0 File Offset: 0x004653C0
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

		// Token: 0x0601F9C4 RID: 129476 RVA: 0x004671FC File Offset: 0x004653FC
		public static Offset<IAirPassageComponent> CreateIAirPassageComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IAirPassageComponent.AddNullMask(builder, NullMask);
			IAirPassageComponent.AddDisabled(builder, Disabled);
			return IAirPassageComponent.EndIAirPassageComponent(builder);
		}

		// Token: 0x0601F9C5 RID: 129477 RVA: 0x00467219 File Offset: 0x00465419
		public static void StartIAirPassageComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F9C6 RID: 129478 RVA: 0x00467222 File Offset: 0x00465422
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F9C7 RID: 129479 RVA: 0x0046722D File Offset: 0x0046542D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0601F9C8 RID: 129480 RVA: 0x00467238 File Offset: 0x00465438
		public static Offset<IAirPassageComponent> EndIAirPassageComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageComponent>(builder.EndTable());
		}

		// Token: 0x0601F9C9 RID: 129481 RVA: 0x00467248 File Offset: 0x00465448
		public IAirPassageComponentT UnPack()
		{
			IAirPassageComponentT airPassageComponentT = new IAirPassageComponentT();
			this.UnPackTo(airPassageComponentT);
			return airPassageComponentT;
		}

		// Token: 0x0601F9CA RID: 129482 RVA: 0x00467263 File Offset: 0x00465463
		public void UnPackTo(IAirPassageComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F9CB RID: 129483 RVA: 0x00467280 File Offset: 0x00465480
		public static Offset<IAirPassageComponent> Pack(FlatBufferBuilder builder, IAirPassageComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageComponent>);
			}
			return IAirPassageComponent.CreateIAirPassageComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400DC4A RID: 56394
		private Table __p;
	}
}
