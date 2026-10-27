using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200518C RID: 20876
	public struct IEntityListComponent : IFlatbufferObject
	{
		// Token: 0x17009882 RID: 39042
		// (get) Token: 0x06021C23 RID: 138275 RVA: 0x004AF0D7 File Offset: 0x004AD2D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C24 RID: 138276 RVA: 0x004AF0E4 File Offset: 0x004AD2E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C25 RID: 138277 RVA: 0x004AF0EC File Offset: 0x004AD2EC
		public static IEntityListComponent GetRootAsIEntityListComponent(ByteBuffer _bb)
		{
			return IEntityListComponent.GetRootAsIEntityListComponent(_bb, default(IEntityListComponent));
		}

		// Token: 0x06021C26 RID: 138278 RVA: 0x004AF108 File Offset: 0x004AD308
		public static IEntityListComponent GetRootAsIEntityListComponent(ByteBuffer _bb, IEntityListComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C27 RID: 138279 RVA: 0x004AF125 File Offset: 0x004AD325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C28 RID: 138280 RVA: 0x004AF134 File Offset: 0x004AD334
		public IEntityListComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009883 RID: 39043
		// (get) Token: 0x06021C29 RID: 138281 RVA: 0x004AF144 File Offset: 0x004AD344
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009884 RID: 39044
		// (get) Token: 0x06021C2A RID: 138282 RVA: 0x004AF184 File Offset: 0x004AD384
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

		// Token: 0x06021C2B RID: 138283 RVA: 0x004AF1C0 File Offset: 0x004AD3C0
		public static Offset<IEntityListComponent> CreateIEntityListComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IEntityListComponent.AddNullMask(builder, NullMask);
			IEntityListComponent.AddDisabled(builder, Disabled);
			return IEntityListComponent.EndIEntityListComponent(builder);
		}

		// Token: 0x06021C2C RID: 138284 RVA: 0x004AF1DD File Offset: 0x004AD3DD
		public static void StartIEntityListComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021C2D RID: 138285 RVA: 0x004AF1E6 File Offset: 0x004AD3E6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021C2E RID: 138286 RVA: 0x004AF1F1 File Offset: 0x004AD3F1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06021C2F RID: 138287 RVA: 0x004AF1FC File Offset: 0x004AD3FC
		public static Offset<IEntityListComponent> EndIEntityListComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityListComponent>(builder.EndTable());
		}

		// Token: 0x06021C30 RID: 138288 RVA: 0x004AF20C File Offset: 0x004AD40C
		public IEntityListComponentT UnPack()
		{
			IEntityListComponentT entityListComponentT = new IEntityListComponentT();
			this.UnPackTo(entityListComponentT);
			return entityListComponentT;
		}

		// Token: 0x06021C31 RID: 138289 RVA: 0x004AF227 File Offset: 0x004AD427
		public void UnPackTo(IEntityListComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021C32 RID: 138290 RVA: 0x004AF244 File Offset: 0x004AD444
		public static Offset<IEntityListComponent> Pack(FlatBufferBuilder builder, IEntityListComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityListComponent>);
			}
			return IEntityListComponent.CreateIEntityListComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400E25F RID: 57951
		private Table __p;
	}
}
