using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005048 RID: 20552
	public struct ICurveControlComponent : IFlatbufferObject
	{
		// Token: 0x17009522 RID: 38178
		// (get) Token: 0x06020EEF RID: 134895 RVA: 0x00494166 File Offset: 0x00492366
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020EF0 RID: 134896 RVA: 0x00494173 File Offset: 0x00492373
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020EF1 RID: 134897 RVA: 0x0049417C File Offset: 0x0049237C
		public static ICurveControlComponent GetRootAsICurveControlComponent(ByteBuffer _bb)
		{
			return ICurveControlComponent.GetRootAsICurveControlComponent(_bb, default(ICurveControlComponent));
		}

		// Token: 0x06020EF2 RID: 134898 RVA: 0x00494198 File Offset: 0x00492398
		public static ICurveControlComponent GetRootAsICurveControlComponent(ByteBuffer _bb, ICurveControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020EF3 RID: 134899 RVA: 0x004941B5 File Offset: 0x004923B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020EF4 RID: 134900 RVA: 0x004941C4 File Offset: 0x004923C4
		public ICurveControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009523 RID: 38179
		// (get) Token: 0x06020EF5 RID: 134901 RVA: 0x004941D4 File Offset: 0x004923D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009524 RID: 38180
		// (get) Token: 0x06020EF6 RID: 134902 RVA: 0x00494214 File Offset: 0x00492414
		public IChargeSlashControl? CurveControlConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IChargeSlashControl?(default(IChargeSlashControl).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009525 RID: 38181
		// (get) Token: 0x06020EF7 RID: 134903 RVA: 0x00494274 File Offset: 0x00492474
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020EF8 RID: 134904 RVA: 0x004942B0 File Offset: 0x004924B0
		public static Offset<ICurveControlComponent> CreateICurveControlComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IChargeSlashControl> CurveControlConfigOffset = default(Offset<IChargeSlashControl>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICurveControlComponent.AddCurveControlConfig(builder, CurveControlConfigOffset);
			ICurveControlComponent.AddNullMask(builder, NullMask);
			ICurveControlComponent.AddDisabled(builder, Disabled);
			return ICurveControlComponent.EndICurveControlComponent(builder);
		}

		// Token: 0x06020EF9 RID: 134905 RVA: 0x004942D4 File Offset: 0x004924D4
		public static void StartICurveControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020EFA RID: 134906 RVA: 0x004942DD File Offset: 0x004924DD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020EFB RID: 134907 RVA: 0x004942E8 File Offset: 0x004924E8
		public static void AddCurveControlConfig(FlatBufferBuilder builder, Offset<IChargeSlashControl> curveControlConfigOffset)
		{
			builder.AddOffset(1, curveControlConfigOffset.Value, 0);
		}

		// Token: 0x06020EFC RID: 134908 RVA: 0x004942F8 File Offset: 0x004924F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06020EFD RID: 134909 RVA: 0x00494303 File Offset: 0x00492503
		public static Offset<ICurveControlComponent> EndICurveControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICurveControlComponent>(builder.EndTable());
		}

		// Token: 0x06020EFE RID: 134910 RVA: 0x00494310 File Offset: 0x00492510
		public ICurveControlComponentT UnPack()
		{
			ICurveControlComponentT curveControlComponentT = new ICurveControlComponentT();
			this.UnPackTo(curveControlComponentT);
			return curveControlComponentT;
		}

		// Token: 0x06020EFF RID: 134911 RVA: 0x0049432C File Offset: 0x0049252C
		public void UnPackTo(ICurveControlComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CurveControlConfig = ((this.CurveControlConfig != null) ? this.CurveControlConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020F00 RID: 134912 RVA: 0x00494380 File Offset: 0x00492580
		public static Offset<ICurveControlComponent> Pack(FlatBufferBuilder builder, ICurveControlComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurveControlComponent>);
			}
			Offset<IChargeSlashControl> curveControlConfigOffset = (_o.CurveControlConfig == null) ? default(Offset<IChargeSlashControl>) : IChargeSlashControl.Pack(builder, _o.CurveControlConfig);
			return ICurveControlComponent.CreateICurveControlComponent(builder, _o.Disabled, curveControlConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E03C RID: 57404
		private Table __p;
	}
}
