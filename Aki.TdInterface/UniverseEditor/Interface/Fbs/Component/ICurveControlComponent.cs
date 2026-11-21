using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AA RID: 21930
	public struct ICurveControlComponent : IFlatbufferObject
	{
		// Token: 0x17009D08 RID: 40200
		// (get) Token: 0x06022E29 RID: 142889 RVA: 0x004CDE1C File Offset: 0x004CC01C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E2A RID: 142890 RVA: 0x004CDE29 File Offset: 0x004CC029
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E2B RID: 142891 RVA: 0x004CDE30 File Offset: 0x004CC030
		public static ICurveControlComponent GetRootAsICurveControlComponent(ByteBuffer _bb)
		{
			return ICurveControlComponent.GetRootAsICurveControlComponent(_bb, default(ICurveControlComponent));
		}

		// Token: 0x06022E2C RID: 142892 RVA: 0x004CDE4C File Offset: 0x004CC04C
		public static ICurveControlComponent GetRootAsICurveControlComponent(ByteBuffer _bb, ICurveControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E2D RID: 142893 RVA: 0x004CDE69 File Offset: 0x004CC069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E2E RID: 142894 RVA: 0x004CDE78 File Offset: 0x004CC078
		public ICurveControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D09 RID: 40201
		// (get) Token: 0x06022E2F RID: 142895 RVA: 0x004CDE88 File Offset: 0x004CC088
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D0A RID: 40202
		// (get) Token: 0x06022E30 RID: 142896 RVA: 0x004CDEC8 File Offset: 0x004CC0C8
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

		// Token: 0x17009D0B RID: 40203
		// (get) Token: 0x06022E31 RID: 142897 RVA: 0x004CDF28 File Offset: 0x004CC128
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

		// Token: 0x06022E32 RID: 142898 RVA: 0x004CDF64 File Offset: 0x004CC164
		public static Offset<ICurveControlComponent> CreateICurveControlComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IChargeSlashControl> CurveControlConfigOffset = default(Offset<IChargeSlashControl>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICurveControlComponent.AddCurveControlConfig(builder, CurveControlConfigOffset);
			ICurveControlComponent.AddNullMask(builder, NullMask);
			ICurveControlComponent.AddDisabled(builder, Disabled);
			return ICurveControlComponent.EndICurveControlComponent(builder);
		}

		// Token: 0x06022E33 RID: 142899 RVA: 0x004CDF88 File Offset: 0x004CC188
		public static void StartICurveControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022E34 RID: 142900 RVA: 0x004CDF91 File Offset: 0x004CC191
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022E35 RID: 142901 RVA: 0x004CDF9C File Offset: 0x004CC19C
		public static void AddCurveControlConfig(FlatBufferBuilder builder, Offset<IChargeSlashControl> curveControlConfigOffset)
		{
			builder.AddOffset(1, curveControlConfigOffset.Value, 0);
		}

		// Token: 0x06022E36 RID: 142902 RVA: 0x004CDFAC File Offset: 0x004CC1AC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022E37 RID: 142903 RVA: 0x004CDFB7 File Offset: 0x004CC1B7
		public static Offset<ICurveControlComponent> EndICurveControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICurveControlComponent>(builder.EndTable());
		}

		// Token: 0x06022E38 RID: 142904 RVA: 0x004CDFC4 File Offset: 0x004CC1C4
		public ICurveControlComponentT UnPack()
		{
			ICurveControlComponentT curveControlComponentT = new ICurveControlComponentT();
			this.UnPackTo(curveControlComponentT);
			return curveControlComponentT;
		}

		// Token: 0x06022E39 RID: 142905 RVA: 0x004CDFE0 File Offset: 0x004CC1E0
		public void UnPackTo(ICurveControlComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CurveControlConfig = ((this.CurveControlConfig != null) ? this.CurveControlConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022E3A RID: 142906 RVA: 0x004CE034 File Offset: 0x004CC234
		public static Offset<ICurveControlComponent> Pack(FlatBufferBuilder builder, ICurveControlComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurveControlComponent>);
			}
			Offset<IChargeSlashControl> curveControlConfigOffset = (_o.CurveControlConfig == null) ? default(Offset<IChargeSlashControl>) : IChargeSlashControl.Pack(builder, _o.CurveControlConfig);
			return ICurveControlComponent.CreateICurveControlComponent(builder, _o.Disabled, curveControlConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EC35 RID: 60469
		private Table __p;
	}
}
