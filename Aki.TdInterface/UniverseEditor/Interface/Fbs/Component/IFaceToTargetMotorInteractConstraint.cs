using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005784 RID: 22404
	public struct IFaceToTargetMotorInteractConstraint : IFlatbufferObject
	{
		// Token: 0x1700A1EE RID: 41454
		// (get) Token: 0x0602421E RID: 147998 RVA: 0x004F7DDA File Offset: 0x004F5FDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602421F RID: 147999 RVA: 0x004F7DE7 File Offset: 0x004F5FE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024220 RID: 148000 RVA: 0x004F7DF0 File Offset: 0x004F5FF0
		public static IFaceToTargetMotorInteractConstraint GetRootAsIFaceToTargetMotorInteractConstraint(ByteBuffer _bb)
		{
			return IFaceToTargetMotorInteractConstraint.GetRootAsIFaceToTargetMotorInteractConstraint(_bb, default(IFaceToTargetMotorInteractConstraint));
		}

		// Token: 0x06024221 RID: 148001 RVA: 0x004F7E0C File Offset: 0x004F600C
		public static IFaceToTargetMotorInteractConstraint GetRootAsIFaceToTargetMotorInteractConstraint(ByteBuffer _bb, IFaceToTargetMotorInteractConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024222 RID: 148002 RVA: 0x004F7E29 File Offset: 0x004F6029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024223 RID: 148003 RVA: 0x004F7E38 File Offset: 0x004F6038
		public IFaceToTargetMotorInteractConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1EF RID: 41455
		// (get) Token: 0x06024224 RID: 148004 RVA: 0x004F7E48 File Offset: 0x004F6048
		public EMotorInteractConstraintType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorInteractConstraintType.FaceToTarget;
				}
				return (EMotorInteractConstraintType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A1F0 RID: 41456
		// (get) Token: 0x06024225 RID: 148005 RVA: 0x004F7E84 File Offset: 0x004F6084
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024226 RID: 148006 RVA: 0x004F7EC0 File Offset: 0x004F60C0
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024227 RID: 148007 RVA: 0x004F7F04 File Offset: 0x004F6104
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06024228 RID: 148008 RVA: 0x004F7F20 File Offset: 0x004F6120
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06024229 RID: 148009 RVA: 0x004F7F3C File Offset: 0x004F613C
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602422A RID: 148010 RVA: 0x004F7F58 File Offset: 0x004F6158
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602422B RID: 148011 RVA: 0x004F7F74 File Offset: 0x004F6174
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700A1F1 RID: 41457
		// (get) Token: 0x0602422C RID: 148012 RVA: 0x004F7F90 File Offset: 0x004F6190
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602422D RID: 148013 RVA: 0x004F7FD1 File Offset: 0x004F61D1
		public static Offset<IFaceToTargetMotorInteractConstraint> CreateIFaceToTargetMotorInteractConstraint(FlatBufferBuilder builder, EMotorInteractConstraintType Type = EMotorInteractConstraintType.FaceToTarget, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, float Angle = 0f)
		{
			builder.StartTable(4);
			IFaceToTargetMotorInteractConstraint.AddAngle(builder, Angle);
			IFaceToTargetMotorInteractConstraint.AddTarget(builder, TargetOffset);
			IFaceToTargetMotorInteractConstraint.AddTargetType(builder, Target_type);
			IFaceToTargetMotorInteractConstraint.AddType(builder, Type);
			return IFaceToTargetMotorInteractConstraint.EndIFaceToTargetMotorInteractConstraint(builder);
		}

		// Token: 0x0602422E RID: 148014 RVA: 0x004F7FFD File Offset: 0x004F61FD
		public static void StartIFaceToTargetMotorInteractConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602422F RID: 148015 RVA: 0x004F8006 File Offset: 0x004F6206
		public static void AddType(FlatBufferBuilder builder, EMotorInteractConstraintType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024230 RID: 148016 RVA: 0x004F8011 File Offset: 0x004F6211
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06024231 RID: 148017 RVA: 0x004F801C File Offset: 0x004F621C
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06024232 RID: 148018 RVA: 0x004F8027 File Offset: 0x004F6227
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x06024233 RID: 148019 RVA: 0x004F803A File Offset: 0x004F623A
		public static Offset<IFaceToTargetMotorInteractConstraint> EndIFaceToTargetMotorInteractConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IFaceToTargetMotorInteractConstraint>(builder.EndTable());
		}

		// Token: 0x06024234 RID: 148020 RVA: 0x004F8048 File Offset: 0x004F6248
		public IFaceToTargetMotorInteractConstraintT UnPack()
		{
			IFaceToTargetMotorInteractConstraintT faceToTargetMotorInteractConstraintT = new IFaceToTargetMotorInteractConstraintT();
			this.UnPackTo(faceToTargetMotorInteractConstraintT);
			return faceToTargetMotorInteractConstraintT;
		}

		// Token: 0x06024235 RID: 148021 RVA: 0x004F8064 File Offset: 0x004F6264
		public void UnPackTo(IFaceToTargetMotorInteractConstraintT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.Angle = this.Angle;
		}

		// Token: 0x06024236 RID: 148022 RVA: 0x004F81EC File Offset: 0x004F63EC
		public static Offset<IFaceToTargetMotorInteractConstraint> Pack(FlatBufferBuilder builder, IFaceToTargetMotorInteractConstraintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceToTargetMotorInteractConstraint>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return IFaceToTargetMotorInteractConstraint.CreateIFaceToTargetMotorInteractConstraint(builder, _o.Type, target_type, targetOffset, _o.Angle);
		}

		// Token: 0x0400EF5C RID: 61276
		private Table __p;
	}
}
