using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EF RID: 26863
	public struct ICameraLockConfig : IFlatbufferObject
	{
		// Token: 0x1700C57C RID: 50556
		// (get) Token: 0x0602DFD0 RID: 188368 RVA: 0x006490D8 File Offset: 0x006472D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DFD1 RID: 188369 RVA: 0x006490E5 File Offset: 0x006472E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DFD2 RID: 188370 RVA: 0x006490EC File Offset: 0x006472EC
		public static ICameraLockConfig GetRootAsICameraLockConfig(ByteBuffer _bb)
		{
			return ICameraLockConfig.GetRootAsICameraLockConfig(_bb, default(ICameraLockConfig));
		}

		// Token: 0x0602DFD3 RID: 188371 RVA: 0x00649108 File Offset: 0x00647308
		public static ICameraLockConfig GetRootAsICameraLockConfig(ByteBuffer _bb, ICameraLockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DFD4 RID: 188372 RVA: 0x00649125 File Offset: 0x00647325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DFD5 RID: 188373 RVA: 0x00649134 File Offset: 0x00647334
		public ICameraLockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C57D RID: 50557
		// (get) Token: 0x0602DFD6 RID: 188374 RVA: 0x00649144 File Offset: 0x00647344
		public ICameraLockTargetPosition? LockTarget
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICameraLockTargetPosition?(default(ICameraLockTargetPosition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C57E RID: 50558
		// (get) Token: 0x0602DFD7 RID: 188375 RVA: 0x006491A4 File Offset: 0x006473A4
		public ICameraLockParams? CameraParams
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICameraLockParams?(default(ICameraLockParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602DFD8 RID: 188376 RVA: 0x00649201 File Offset: 0x00647401
		public static Offset<ICameraLockConfig> CreateICameraLockConfig(FlatBufferBuilder builder, Offset<ICameraLockTargetPosition> LockTargetOffset = default(Offset<ICameraLockTargetPosition>), Offset<ICameraLockParams> CameraParamsOffset = default(Offset<ICameraLockParams>))
		{
			builder.StartTable(2);
			ICameraLockConfig.AddCameraParams(builder, CameraParamsOffset);
			ICameraLockConfig.AddLockTarget(builder, LockTargetOffset);
			return ICameraLockConfig.EndICameraLockConfig(builder);
		}

		// Token: 0x0602DFD9 RID: 188377 RVA: 0x0064921E File Offset: 0x0064741E
		public static void StartICameraLockConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DFDA RID: 188378 RVA: 0x00649227 File Offset: 0x00647427
		public static void AddLockTarget(FlatBufferBuilder builder, Offset<ICameraLockTargetPosition> lockTargetOffset)
		{
			builder.AddOffset(0, lockTargetOffset.Value, 0);
		}

		// Token: 0x0602DFDB RID: 188379 RVA: 0x00649237 File Offset: 0x00647437
		public static void AddCameraParams(FlatBufferBuilder builder, Offset<ICameraLockParams> cameraParamsOffset)
		{
			builder.AddOffset(1, cameraParamsOffset.Value, 0);
		}

		// Token: 0x0602DFDC RID: 188380 RVA: 0x00649247 File Offset: 0x00647447
		public static Offset<ICameraLockConfig> EndICameraLockConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockConfig>(builder.EndTable());
		}

		// Token: 0x0602DFDD RID: 188381 RVA: 0x00649254 File Offset: 0x00647454
		public ICameraLockConfigT UnPack()
		{
			ICameraLockConfigT cameraLockConfigT = new ICameraLockConfigT();
			this.UnPackTo(cameraLockConfigT);
			return cameraLockConfigT;
		}

		// Token: 0x0602DFDE RID: 188382 RVA: 0x00649270 File Offset: 0x00647470
		public void UnPackTo(ICameraLockConfigT _o)
		{
			_o.LockTarget = ((this.LockTarget != null) ? this.LockTarget.Value.UnPack() : null);
			_o.CameraParams = ((this.CameraParams != null) ? this.CameraParams.Value.UnPack() : null);
		}

		// Token: 0x0602DFDF RID: 188383 RVA: 0x006492DC File Offset: 0x006474DC
		public static Offset<ICameraLockConfig> Pack(FlatBufferBuilder builder, ICameraLockConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockConfig>);
			}
			Offset<ICameraLockTargetPosition> lockTargetOffset = (_o.LockTarget == null) ? default(Offset<ICameraLockTargetPosition>) : ICameraLockTargetPosition.Pack(builder, _o.LockTarget);
			Offset<ICameraLockParams> cameraParamsOffset = (_o.CameraParams == null) ? default(Offset<ICameraLockParams>) : ICameraLockParams.Pack(builder, _o.CameraParams);
			return ICameraLockConfig.CreateICameraLockConfig(builder, lockTargetOffset, cameraParamsOffset);
		}

		// Token: 0x040115F8 RID: 71160
		private Table __p;
	}
}
