using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701F RID: 28703
	public struct ISetMotorSpeed : IFlatbufferObject
	{
		// Token: 0x1700D523 RID: 54563
		// (get) Token: 0x06032C55 RID: 207957 RVA: 0x006D96A8 File Offset: 0x006D78A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C56 RID: 207958 RVA: 0x006D96B5 File Offset: 0x006D78B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C57 RID: 207959 RVA: 0x006D96BC File Offset: 0x006D78BC
		public static ISetMotorSpeed GetRootAsISetMotorSpeed(ByteBuffer _bb)
		{
			return ISetMotorSpeed.GetRootAsISetMotorSpeed(_bb, default(ISetMotorSpeed));
		}

		// Token: 0x06032C58 RID: 207960 RVA: 0x006D96D8 File Offset: 0x006D78D8
		public static ISetMotorSpeed GetRootAsISetMotorSpeed(ByteBuffer _bb, ISetMotorSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C59 RID: 207961 RVA: 0x006D96F5 File Offset: 0x006D78F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C5A RID: 207962 RVA: 0x006D9704 File Offset: 0x006D7904
		public ISetMotorSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D524 RID: 54564
		// (get) Token: 0x06032C5B RID: 207963 RVA: 0x006D9714 File Offset: 0x006D7914
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

		// Token: 0x1700D525 RID: 54565
		// (get) Token: 0x06032C5C RID: 207964 RVA: 0x006D9774 File Offset: 0x006D7974
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

		// Token: 0x06032C5D RID: 207965 RVA: 0x006D97D1 File Offset: 0x006D79D1
		public static Offset<ISetMotorSpeed> CreateISetMotorSpeed(FlatBufferBuilder builder, Offset<IMotorConstraintConfig> MotorConstraintOffset = default(Offset<IMotorConstraintConfig>), Offset<ISetMotorSpeedTargetSpeed> SpeedConfigOffset = default(Offset<ISetMotorSpeedTargetSpeed>))
		{
			builder.StartTable(2);
			ISetMotorSpeed.AddSpeedConfig(builder, SpeedConfigOffset);
			ISetMotorSpeed.AddMotorConstraint(builder, MotorConstraintOffset);
			return ISetMotorSpeed.EndISetMotorSpeed(builder);
		}

		// Token: 0x06032C5E RID: 207966 RVA: 0x006D97EE File Offset: 0x006D79EE
		public static void StartISetMotorSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032C5F RID: 207967 RVA: 0x006D97F7 File Offset: 0x006D79F7
		public static void AddMotorConstraint(FlatBufferBuilder builder, Offset<IMotorConstraintConfig> motorConstraintOffset)
		{
			builder.AddOffset(0, motorConstraintOffset.Value, 0);
		}

		// Token: 0x06032C60 RID: 207968 RVA: 0x006D9807 File Offset: 0x006D7A07
		public static void AddSpeedConfig(FlatBufferBuilder builder, Offset<ISetMotorSpeedTargetSpeed> speedConfigOffset)
		{
			builder.AddOffset(1, speedConfigOffset.Value, 0);
		}

		// Token: 0x06032C61 RID: 207969 RVA: 0x006D9817 File Offset: 0x006D7A17
		public static Offset<ISetMotorSpeed> EndISetMotorSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ISetMotorSpeed>(builder.EndTable());
		}

		// Token: 0x06032C62 RID: 207970 RVA: 0x006D9824 File Offset: 0x006D7A24
		public ISetMotorSpeedT UnPack()
		{
			ISetMotorSpeedT setMotorSpeedT = new ISetMotorSpeedT();
			this.UnPackTo(setMotorSpeedT);
			return setMotorSpeedT;
		}

		// Token: 0x06032C63 RID: 207971 RVA: 0x006D9840 File Offset: 0x006D7A40
		public void UnPackTo(ISetMotorSpeedT _o)
		{
			_o.MotorConstraint = ((this.MotorConstraint != null) ? this.MotorConstraint.Value.UnPack() : null);
			_o.SpeedConfig = ((this.SpeedConfig != null) ? this.SpeedConfig.Value.UnPack() : null);
		}

		// Token: 0x06032C64 RID: 207972 RVA: 0x006D98AC File Offset: 0x006D7AAC
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

		// Token: 0x04011A48 RID: 72264
		private Table __p;
	}
}
