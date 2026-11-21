using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7D RID: 23165
	public struct ILifePointCenterComponent : IFlatbufferObject
	{
		// Token: 0x1700A8BD RID: 43197
		// (get) Token: 0x06025F35 RID: 155445 RVA: 0x00533EA8 File Offset: 0x005320A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F36 RID: 155446 RVA: 0x00533EB5 File Offset: 0x005320B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F37 RID: 155447 RVA: 0x00533EBC File Offset: 0x005320BC
		public static ILifePointCenterComponent GetRootAsILifePointCenterComponent(ByteBuffer _bb)
		{
			return ILifePointCenterComponent.GetRootAsILifePointCenterComponent(_bb, default(ILifePointCenterComponent));
		}

		// Token: 0x06025F38 RID: 155448 RVA: 0x00533ED8 File Offset: 0x005320D8
		public static ILifePointCenterComponent GetRootAsILifePointCenterComponent(ByteBuffer _bb, ILifePointCenterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F39 RID: 155449 RVA: 0x00533EF5 File Offset: 0x005320F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F3A RID: 155450 RVA: 0x00533F04 File Offset: 0x00532104
		public ILifePointCenterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8BE RID: 43198
		// (get) Token: 0x06025F3B RID: 155451 RVA: 0x00533F14 File Offset: 0x00532114
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8BF RID: 43199
		// (get) Token: 0x06025F3C RID: 155452 RVA: 0x00533F54 File Offset: 0x00532154
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

		// Token: 0x06025F3D RID: 155453 RVA: 0x00533F90 File Offset: 0x00532190
		public static Offset<ILifePointCenterComponent> CreateILifePointCenterComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			ILifePointCenterComponent.AddNullMask(builder, NullMask);
			ILifePointCenterComponent.AddDisabled(builder, Disabled);
			return ILifePointCenterComponent.EndILifePointCenterComponent(builder);
		}

		// Token: 0x06025F3E RID: 155454 RVA: 0x00533FAD File Offset: 0x005321AD
		public static void StartILifePointCenterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025F3F RID: 155455 RVA: 0x00533FB6 File Offset: 0x005321B6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025F40 RID: 155456 RVA: 0x00533FC1 File Offset: 0x005321C1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06025F41 RID: 155457 RVA: 0x00533FCC File Offset: 0x005321CC
		public static Offset<ILifePointCenterComponent> EndILifePointCenterComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILifePointCenterComponent>(builder.EndTable());
		}

		// Token: 0x06025F42 RID: 155458 RVA: 0x00533FDC File Offset: 0x005321DC
		public ILifePointCenterComponentT UnPack()
		{
			ILifePointCenterComponentT lifePointCenterComponentT = new ILifePointCenterComponentT();
			this.UnPackTo(lifePointCenterComponentT);
			return lifePointCenterComponentT;
		}

		// Token: 0x06025F43 RID: 155459 RVA: 0x00533FF7 File Offset: 0x005321F7
		public void UnPackTo(ILifePointCenterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025F44 RID: 155460 RVA: 0x00534014 File Offset: 0x00532214
		public static Offset<ILifePointCenterComponent> Pack(FlatBufferBuilder builder, ILifePointCenterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePointCenterComponent>);
			}
			return ILifePointCenterComponent.CreateILifePointCenterComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400F40C RID: 62476
		private Table __p;
	}
}
