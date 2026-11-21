using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FB RID: 26875
	public struct ICameraLockTargetPosition : IFlatbufferObject
	{
		// Token: 0x1700C5A5 RID: 50597
		// (get) Token: 0x0602E04E RID: 188494 RVA: 0x0064A0B6 File Offset: 0x006482B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E04F RID: 188495 RVA: 0x0064A0C3 File Offset: 0x006482C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E050 RID: 188496 RVA: 0x0064A0CC File Offset: 0x006482CC
		public static ICameraLockTargetPosition GetRootAsICameraLockTargetPosition(ByteBuffer _bb)
		{
			return ICameraLockTargetPosition.GetRootAsICameraLockTargetPosition(_bb, default(ICameraLockTargetPosition));
		}

		// Token: 0x0602E051 RID: 188497 RVA: 0x0064A0E8 File Offset: 0x006482E8
		public static ICameraLockTargetPosition GetRootAsICameraLockTargetPosition(ByteBuffer _bb, ICameraLockTargetPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E052 RID: 188498 RVA: 0x0064A105 File Offset: 0x00648305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E053 RID: 188499 RVA: 0x0064A114 File Offset: 0x00648314
		public ICameraLockTargetPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5A6 RID: 50598
		// (get) Token: 0x0602E054 RID: 188500 RVA: 0x0064A124 File Offset: 0x00648324
		public ECameraLockTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraLockTargetType.TargetPosition;
				}
				return (ECameraLockTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C5A7 RID: 50599
		// (get) Token: 0x0602E055 RID: 188501 RVA: 0x0064A160 File Offset: 0x00648360
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E056 RID: 188502 RVA: 0x0064A1BD File Offset: 0x006483BD
		public static Offset<ICameraLockTargetPosition> CreateICameraLockTargetPosition(FlatBufferBuilder builder, ECameraLockTargetType Type = ECameraLockTargetType.TargetPosition, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICameraLockTargetPosition.AddPos(builder, PosOffset);
			ICameraLockTargetPosition.AddType(builder, Type);
			return ICameraLockTargetPosition.EndICameraLockTargetPosition(builder);
		}

		// Token: 0x0602E057 RID: 188503 RVA: 0x0064A1DA File Offset: 0x006483DA
		public static void StartICameraLockTargetPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E058 RID: 188504 RVA: 0x0064A1E3 File Offset: 0x006483E3
		public static void AddType(FlatBufferBuilder builder, ECameraLockTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E059 RID: 188505 RVA: 0x0064A1EE File Offset: 0x006483EE
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602E05A RID: 188506 RVA: 0x0064A1FE File Offset: 0x006483FE
		public static Offset<ICameraLockTargetPosition> EndICameraLockTargetPosition(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockTargetPosition>(builder.EndTable());
		}

		// Token: 0x0602E05B RID: 188507 RVA: 0x0064A20C File Offset: 0x0064840C
		public ICameraLockTargetPositionT UnPack()
		{
			ICameraLockTargetPositionT cameraLockTargetPositionT = new ICameraLockTargetPositionT();
			this.UnPackTo(cameraLockTargetPositionT);
			return cameraLockTargetPositionT;
		}

		// Token: 0x0602E05C RID: 188508 RVA: 0x0064A228 File Offset: 0x00648428
		public void UnPackTo(ICameraLockTargetPositionT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602E05D RID: 188509 RVA: 0x0064A270 File Offset: 0x00648470
		public static Offset<ICameraLockTargetPosition> Pack(FlatBufferBuilder builder, ICameraLockTargetPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockTargetPosition>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICameraLockTargetPosition.CreateICameraLockTargetPosition(builder, _o.Type, posOffset);
		}

		// Token: 0x04011613 RID: 71187
		private Table __p;
	}
}
