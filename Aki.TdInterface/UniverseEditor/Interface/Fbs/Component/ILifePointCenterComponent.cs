using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F7 RID: 21751
	public struct ILifePointCenterComponent : IFlatbufferObject
	{
		// Token: 0x1700A083 RID: 41091
		// (get) Token: 0x06023E7B RID: 147067 RVA: 0x004F6D84 File Offset: 0x004F4F84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E7C RID: 147068 RVA: 0x004F6D91 File Offset: 0x004F4F91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E7D RID: 147069 RVA: 0x004F6D98 File Offset: 0x004F4F98
		public static ILifePointCenterComponent GetRootAsILifePointCenterComponent(ByteBuffer _bb)
		{
			return ILifePointCenterComponent.GetRootAsILifePointCenterComponent(_bb, default(ILifePointCenterComponent));
		}

		// Token: 0x06023E7E RID: 147070 RVA: 0x004F6DB4 File Offset: 0x004F4FB4
		public static ILifePointCenterComponent GetRootAsILifePointCenterComponent(ByteBuffer _bb, ILifePointCenterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E7F RID: 147071 RVA: 0x004F6DD1 File Offset: 0x004F4FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E80 RID: 147072 RVA: 0x004F6DE0 File Offset: 0x004F4FE0
		public ILifePointCenterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A084 RID: 41092
		// (get) Token: 0x06023E81 RID: 147073 RVA: 0x004F6DF0 File Offset: 0x004F4FF0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A085 RID: 41093
		// (get) Token: 0x06023E82 RID: 147074 RVA: 0x004F6E30 File Offset: 0x004F5030
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

		// Token: 0x06023E83 RID: 147075 RVA: 0x004F6E6C File Offset: 0x004F506C
		public static Offset<ILifePointCenterComponent> CreateILifePointCenterComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			ILifePointCenterComponent.AddNullMask(builder, NullMask);
			ILifePointCenterComponent.AddDisabled(builder, Disabled);
			return ILifePointCenterComponent.EndILifePointCenterComponent(builder);
		}

		// Token: 0x06023E84 RID: 147076 RVA: 0x004F6E89 File Offset: 0x004F5089
		public static void StartILifePointCenterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023E85 RID: 147077 RVA: 0x004F6E92 File Offset: 0x004F5092
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023E86 RID: 147078 RVA: 0x004F6E9D File Offset: 0x004F509D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06023E87 RID: 147079 RVA: 0x004F6EA8 File Offset: 0x004F50A8
		public static Offset<ILifePointCenterComponent> EndILifePointCenterComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILifePointCenterComponent>(builder.EndTable());
		}

		// Token: 0x06023E88 RID: 147080 RVA: 0x004F6EB8 File Offset: 0x004F50B8
		public ILifePointCenterComponentT UnPack()
		{
			ILifePointCenterComponentT lifePointCenterComponentT = new ILifePointCenterComponentT();
			this.UnPackTo(lifePointCenterComponentT);
			return lifePointCenterComponentT;
		}

		// Token: 0x06023E89 RID: 147081 RVA: 0x004F6ED3 File Offset: 0x004F50D3
		public void UnPackTo(ILifePointCenterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023E8A RID: 147082 RVA: 0x004F6EF0 File Offset: 0x004F50F0
		public static Offset<ILifePointCenterComponent> Pack(FlatBufferBuilder builder, ILifePointCenterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePointCenterComponent>);
			}
			return ILifePointCenterComponent.CreateILifePointCenterComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400E7DB RID: 59355
		private Table __p;
	}
}
