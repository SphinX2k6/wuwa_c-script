using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200628A RID: 25226
	public struct ICameraLockTargetPosition : IFlatbufferObject
	{
		// Token: 0x1700BC1D RID: 48157
		// (get) Token: 0x0602B8ED RID: 178413 RVA: 0x005FF2AE File Offset: 0x005FD4AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B8EE RID: 178414 RVA: 0x005FF2BB File Offset: 0x005FD4BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B8EF RID: 178415 RVA: 0x005FF2C4 File Offset: 0x005FD4C4
		public static ICameraLockTargetPosition GetRootAsICameraLockTargetPosition(ByteBuffer _bb)
		{
			return ICameraLockTargetPosition.GetRootAsICameraLockTargetPosition(_bb, default(ICameraLockTargetPosition));
		}

		// Token: 0x0602B8F0 RID: 178416 RVA: 0x005FF2E0 File Offset: 0x005FD4E0
		public static ICameraLockTargetPosition GetRootAsICameraLockTargetPosition(ByteBuffer _bb, ICameraLockTargetPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B8F1 RID: 178417 RVA: 0x005FF2FD File Offset: 0x005FD4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B8F2 RID: 178418 RVA: 0x005FF30C File Offset: 0x005FD50C
		public ICameraLockTargetPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC1E RID: 48158
		// (get) Token: 0x0602B8F3 RID: 178419 RVA: 0x005FF31C File Offset: 0x005FD51C
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

		// Token: 0x1700BC1F RID: 48159
		// (get) Token: 0x0602B8F4 RID: 178420 RVA: 0x005FF358 File Offset: 0x005FD558
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

		// Token: 0x0602B8F5 RID: 178421 RVA: 0x005FF3B5 File Offset: 0x005FD5B5
		public static Offset<ICameraLockTargetPosition> CreateICameraLockTargetPosition(FlatBufferBuilder builder, ECameraLockTargetType Type = ECameraLockTargetType.TargetPosition, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICameraLockTargetPosition.AddPos(builder, PosOffset);
			ICameraLockTargetPosition.AddType(builder, Type);
			return ICameraLockTargetPosition.EndICameraLockTargetPosition(builder);
		}

		// Token: 0x0602B8F6 RID: 178422 RVA: 0x005FF3D2 File Offset: 0x005FD5D2
		public static void StartICameraLockTargetPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B8F7 RID: 178423 RVA: 0x005FF3DB File Offset: 0x005FD5DB
		public static void AddType(FlatBufferBuilder builder, ECameraLockTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B8F8 RID: 178424 RVA: 0x005FF3E6 File Offset: 0x005FD5E6
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602B8F9 RID: 178425 RVA: 0x005FF3F6 File Offset: 0x005FD5F6
		public static Offset<ICameraLockTargetPosition> EndICameraLockTargetPosition(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockTargetPosition>(builder.EndTable());
		}

		// Token: 0x0602B8FA RID: 178426 RVA: 0x005FF404 File Offset: 0x005FD604
		public ICameraLockTargetPositionT UnPack()
		{
			ICameraLockTargetPositionT cameraLockTargetPositionT = new ICameraLockTargetPositionT();
			this.UnPackTo(cameraLockTargetPositionT);
			return cameraLockTargetPositionT;
		}

		// Token: 0x0602B8FB RID: 178427 RVA: 0x005FF420 File Offset: 0x005FD620
		public void UnPackTo(ICameraLockTargetPositionT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602B8FC RID: 178428 RVA: 0x005FF468 File Offset: 0x005FD668
		public static Offset<ICameraLockTargetPosition> Pack(FlatBufferBuilder builder, ICameraLockTargetPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockTargetPosition>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICameraLockTargetPosition.CreateICameraLockTargetPosition(builder, _o.Type, posOffset);
		}

		// Token: 0x040107FE RID: 67582
		private Table __p;
	}
}
