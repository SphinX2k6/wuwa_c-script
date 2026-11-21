using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E8 RID: 30696
	public struct ISetMotorSpeed : IFlatbufferObject
	{
		// Token: 0x1700E0F7 RID: 57591
		// (get) Token: 0x06035EBB RID: 220859 RVA: 0x007392EC File Offset: 0x007374EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035EBC RID: 220860 RVA: 0x007392F9 File Offset: 0x007374F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035EBD RID: 220861 RVA: 0x00739300 File Offset: 0x00737500
		public static ISetMotorSpeed GetRootAsISetMotorSpeed(ByteBuffer _bb)
		{
			return ISetMotorSpeed.GetRootAsISetMotorSpeed(_bb, default(ISetMotorSpeed));
		}

		// Token: 0x06035EBE RID: 220862 RVA: 0x0073931C File Offset: 0x0073751C
		public static ISetMotorSpeed GetRootAsISetMotorSpeed(ByteBuffer _bb, ISetMotorSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035EBF RID: 220863 RVA: 0x00739339 File Offset: 0x00737539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035EC0 RID: 220864 RVA: 0x00739348 File Offset: 0x00737548
		public ISetMotorSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0F8 RID: 57592
		// (get) Token: 0x06035EC1 RID: 220865 RVA: 0x00739358 File Offset: 0x00737558
		public IMotorConstraintConfig? MotorConstraint
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMotorConstraintConfig?(default(IMotorConstraintConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E0F9 RID: 57593
		// (get) Token: 0x06035EC2 RID: 220866 RVA: 0x007393B8 File Offset: 0x007375B8
		public ISetMotorSpeedTargetSpeed? SpeedConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISetMotorSpeedTargetSpeed?(default(ISetMotorSpeedTargetSpeed).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035EC3 RID: 220867 RVA: 0x00739415 File Offset: 0x00737615
		public static Offset<ISetMotorSpeed> CreateISetMotorSpeed(FlatBufferBuilder builder, Offset<IMotorConstraintConfig> MotorConstraintOffset = default(Offset<IMotorConstraintConfig>), Offset<ISetMotorSpeedTargetSpeed> SpeedConfigOffset = default(Offset<ISetMotorSpeedTargetSpeed>))
		{
			builder.StartTable(2);
			ISetMotorSpeed.AddSpeedConfig(builder, SpeedConfigOffset);
			ISetMotorSpeed.AddMotorConstraint(builder, MotorConstraintOffset);
			return ISetMotorSpeed.EndISetMotorSpeed(builder);
		}

		// Token: 0x06035EC4 RID: 220868 RVA: 0x00739432 File Offset: 0x00737632
		public static void StartISetMotorSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035EC5 RID: 220869 RVA: 0x0073943B File Offset: 0x0073763B
		public static void AddMotorConstraint(FlatBufferBuilder builder, Offset<IMotorConstraintConfig> motorConstraintOffset)
		{
			builder.AddOffset(0, motorConstraintOffset.Value, 0);
		}

		// Token: 0x06035EC6 RID: 220870 RVA: 0x0073944B File Offset: 0x0073764B
		public static void AddSpeedConfig(FlatBufferBuilder builder, Offset<ISetMotorSpeedTargetSpeed> speedConfigOffset)
		{
			builder.AddOffset(1, speedConfigOffset.Value, 0);
		}

		// Token: 0x06035EC7 RID: 220871 RVA: 0x0073945B File Offset: 0x0073765B
		public static Offset<ISetMotorSpeed> EndISetMotorSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ISetMotorSpeed>(builder.EndTable());
		}

		// Token: 0x06035EC8 RID: 220872 RVA: 0x00739468 File Offset: 0x00737668
		public ISetMotorSpeedT UnPack()
		{
			ISetMotorSpeedT setMotorSpeedT = new ISetMotorSpeedT();
			this.UnPackTo(setMotorSpeedT);
			return setMotorSpeedT;
		}

		// Token: 0x06035EC9 RID: 220873 RVA: 0x00739484 File Offset: 0x00737684
		public void UnPackTo(ISetMotorSpeedT _o)
		{
			_o.MotorConstraint = ((this.MotorConstraint != null) ? this.MotorConstraint.Value.UnPack() : null);
			_o.SpeedConfig = ((this.SpeedConfig != null) ? this.SpeedConfig.Value.UnPack() : null);
		}

		// Token: 0x06035ECA RID: 220874 RVA: 0x007394F0 File Offset: 0x007376F0
		public static Offset<ISetMotorSpeed> Pack(FlatBufferBuilder builder, ISetMotorSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMotorSpeed>);
			}
			Offset<IMotorConstraintConfig> motorConstraintOffset = (_o.MotorConstraint == null) ? default(Offset<IMotorConstraintConfig>) : IMotorConstraintConfig.Pack(builder, _o.MotorConstraint);
			Offset<ISetMotorSpeedTargetSpeed> speedConfigOffset = (_o.SpeedConfig == null) ? default(Offset<ISetMotorSpeedTargetSpeed>) : ISetMotorSpeedTargetSpeed.Pack(builder, _o.SpeedConfig);
			return ISetMotorSpeed.CreateISetMotorSpeed(builder, motorConstraintOffset, speedConfigOffset);
		}

		// Token: 0x04012A2D RID: 76333
		private Table __p;
	}
}
