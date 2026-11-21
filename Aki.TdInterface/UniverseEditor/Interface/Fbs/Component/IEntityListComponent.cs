using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F1 RID: 22257
	public struct IEntityListComponent : IFlatbufferObject
	{
		// Token: 0x1700A071 RID: 41073
		// (get) Token: 0x06023B7B RID: 146299 RVA: 0x004E90F7 File Offset: 0x004E72F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B7C RID: 146300 RVA: 0x004E9104 File Offset: 0x004E7304
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B7D RID: 146301 RVA: 0x004E910C File Offset: 0x004E730C
		public static IEntityListComponent GetRootAsIEntityListComponent(ByteBuffer _bb)
		{
			return IEntityListComponent.GetRootAsIEntityListComponent(_bb, default(IEntityListComponent));
		}

		// Token: 0x06023B7E RID: 146302 RVA: 0x004E9128 File Offset: 0x004E7328
		public static IEntityListComponent GetRootAsIEntityListComponent(ByteBuffer _bb, IEntityListComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B7F RID: 146303 RVA: 0x004E9145 File Offset: 0x004E7345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B80 RID: 146304 RVA: 0x004E9154 File Offset: 0x004E7354
		public IEntityListComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A072 RID: 41074
		// (get) Token: 0x06023B81 RID: 146305 RVA: 0x004E9164 File Offset: 0x004E7364
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A073 RID: 41075
		// (get) Token: 0x06023B82 RID: 146306 RVA: 0x004E91A4 File Offset: 0x004E73A4
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

		// Token: 0x06023B83 RID: 146307 RVA: 0x004E91E0 File Offset: 0x004E73E0
		public static Offset<IEntityListComponent> CreateIEntityListComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IEntityListComponent.AddNullMask(builder, NullMask);
			IEntityListComponent.AddDisabled(builder, Disabled);
			return IEntityListComponent.EndIEntityListComponent(builder);
		}

		// Token: 0x06023B84 RID: 146308 RVA: 0x004E91FD File Offset: 0x004E73FD
		public static void StartIEntityListComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023B85 RID: 146309 RVA: 0x004E9206 File Offset: 0x004E7406
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023B86 RID: 146310 RVA: 0x004E9211 File Offset: 0x004E7411
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06023B87 RID: 146311 RVA: 0x004E921C File Offset: 0x004E741C
		public static Offset<IEntityListComponent> EndIEntityListComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityListComponent>(builder.EndTable());
		}

		// Token: 0x06023B88 RID: 146312 RVA: 0x004E922C File Offset: 0x004E742C
		public IEntityListComponentT UnPack()
		{
			IEntityListComponentT entityListComponentT = new IEntityListComponentT();
			this.UnPackTo(entityListComponentT);
			return entityListComponentT;
		}

		// Token: 0x06023B89 RID: 146313 RVA: 0x004E9247 File Offset: 0x004E7447
		public void UnPackTo(IEntityListComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023B8A RID: 146314 RVA: 0x004E9264 File Offset: 0x004E7464
		public static Offset<IEntityListComponent> Pack(FlatBufferBuilder builder, IEntityListComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityListComponent>);
			}
			return IEntityListComponent.CreateIEntityListComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400EE5D RID: 61021
		private Table __p;
	}
}
