using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200521C RID: 21020
	public struct IFaceToTargetMotorInteractConstraint : IFlatbufferObject
	{
		// Token: 0x170099F2 RID: 39410
		// (get) Token: 0x06022288 RID: 139912 RVA: 0x004BD316 File Offset: 0x004BB516
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022289 RID: 139913 RVA: 0x004BD323 File Offset: 0x004BB523
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602228A RID: 139914 RVA: 0x004BD32C File Offset: 0x004BB52C
		public static IFaceToTargetMotorInteractConstraint GetRootAsIFaceToTargetMotorInteractConstraint(ByteBuffer _bb)
		{
			return IFaceToTargetMotorInteractConstraint.GetRootAsIFaceToTargetMotorInteractConstraint(_bb, default(IFaceToTargetMotorInteractConstraint));
		}

		// Token: 0x0602228B RID: 139915 RVA: 0x004BD348 File Offset: 0x004BB548
		public static IFaceToTargetMotorInteractConstraint GetRootAsIFaceToTargetMotorInteractConstraint(ByteBuffer _bb, IFaceToTargetMotorInteractConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602228C RID: 139916 RVA: 0x004BD365 File Offset: 0x004BB565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602228D RID: 139917 RVA: 0x004BD374 File Offset: 0x004BB574
		public IFaceToTargetMotorInteractConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099F3 RID: 39411
		// (get) Token: 0x0602228E RID: 139918 RVA: 0x004BD384 File Offset: 0x004BB584
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

		// Token: 0x170099F4 RID: 39412
		// (get) Token: 0x0602228F RID: 139919 RVA: 0x004BD3C0 File Offset: 0x004BB5C0
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

		// Token: 0x06022290 RID: 139920 RVA: 0x004BD3FC File Offset: 0x004BB5FC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022291 RID: 139921 RVA: 0x004BD440 File Offset: 0x004BB640
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06022292 RID: 139922 RVA: 0x004BD45C File Offset: 0x004BB65C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06022293 RID: 139923 RVA: 0x004BD478 File Offset: 0x004BB678
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06022294 RID: 139924 RVA: 0x004BD494 File Offset: 0x004BB694
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06022295 RID: 139925 RVA: 0x004BD4B0 File Offset: 0x004BB6B0
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x170099F5 RID: 39413
		// (get) Token: 0x06022296 RID: 139926 RVA: 0x004BD4CC File Offset: 0x004BB6CC
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

		// Token: 0x06022297 RID: 139927 RVA: 0x004BD50D File Offset: 0x004BB70D
		public static Offset<IFaceToTargetMotorInteractConstraint> CreateIFaceToTargetMotorInteractConstraint(FlatBufferBuilder builder, EMotorInteractConstraintType Type = EMotorInteractConstraintType.FaceToTarget, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, float Angle = 0f)
		{
			builder.StartTable(4);
			IFaceToTargetMotorInteractConstraint.AddAngle(builder, Angle);
			IFaceToTargetMotorInteractConstraint.AddTarget(builder, TargetOffset);
			IFaceToTargetMotorInteractConstraint.AddTargetType(builder, Target_type);
			IFaceToTargetMotorInteractConstraint.AddType(builder, Type);
			return IFaceToTargetMotorInteractConstraint.EndIFaceToTargetMotorInteractConstraint(builder);
		}

		// Token: 0x06022298 RID: 139928 RVA: 0x004BD539 File Offset: 0x004BB739
		public static void StartIFaceToTargetMotorInteractConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022299 RID: 139929 RVA: 0x004BD542 File Offset: 0x004BB742
		public static void AddType(FlatBufferBuilder builder, EMotorInteractConstraintType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602229A RID: 139930 RVA: 0x004BD54D File Offset: 0x004BB74D
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602229B RID: 139931 RVA: 0x004BD558 File Offset: 0x004BB758
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602229C RID: 139932 RVA: 0x004BD563 File Offset: 0x004BB763
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x0602229D RID: 139933 RVA: 0x004BD576 File Offset: 0x004BB776
		public static Offset<IFaceToTargetMotorInteractConstraint> EndIFaceToTargetMotorInteractConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IFaceToTargetMotorInteractConstraint>(builder.EndTable());
		}

		// Token: 0x0602229E RID: 139934 RVA: 0x004BD584 File Offset: 0x004BB784
		public IFaceToTargetMotorInteractConstraintT UnPack()
		{
			IFaceToTargetMotorInteractConstraintT faceToTargetMotorInteractConstraintT = new IFaceToTargetMotorInteractConstraintT();
			this.UnPackTo(faceToTargetMotorInteractConstraintT);
			return faceToTargetMotorInteractConstraintT;
		}

		// Token: 0x0602229F RID: 139935 RVA: 0x004BD5A0 File Offset: 0x004BB7A0
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

		// Token: 0x060222A0 RID: 139936 RVA: 0x004BD728 File Offset: 0x004BB928
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

		// Token: 0x0400E356 RID: 58198
		private Table __p;
	}
}
