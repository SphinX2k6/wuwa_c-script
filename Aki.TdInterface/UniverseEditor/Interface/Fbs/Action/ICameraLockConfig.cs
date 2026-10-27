using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200627E RID: 25214
	public struct ICameraLockConfig : IFlatbufferObject
	{
		// Token: 0x1700BBF4 RID: 48116
		// (get) Token: 0x0602B86F RID: 178287 RVA: 0x005FE2D0 File Offset: 0x005FC4D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B870 RID: 178288 RVA: 0x005FE2DD File Offset: 0x005FC4DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B871 RID: 178289 RVA: 0x005FE2E4 File Offset: 0x005FC4E4
		public static ICameraLockConfig GetRootAsICameraLockConfig(ByteBuffer _bb)
		{
			return ICameraLockConfig.GetRootAsICameraLockConfig(_bb, default(ICameraLockConfig));
		}

		// Token: 0x0602B872 RID: 178290 RVA: 0x005FE300 File Offset: 0x005FC500
		public static ICameraLockConfig GetRootAsICameraLockConfig(ByteBuffer _bb, ICameraLockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B873 RID: 178291 RVA: 0x005FE31D File Offset: 0x005FC51D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B874 RID: 178292 RVA: 0x005FE32C File Offset: 0x005FC52C
		public ICameraLockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBF5 RID: 48117
		// (get) Token: 0x0602B875 RID: 178293 RVA: 0x005FE33C File Offset: 0x005FC53C
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

		// Token: 0x1700BBF6 RID: 48118
		// (get) Token: 0x0602B876 RID: 178294 RVA: 0x005FE39C File Offset: 0x005FC59C
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

		// Token: 0x0602B877 RID: 178295 RVA: 0x005FE3F9 File Offset: 0x005FC5F9
		public static Offset<ICameraLockConfig> CreateICameraLockConfig(FlatBufferBuilder builder, Offset<ICameraLockTargetPosition> LockTargetOffset = default(Offset<ICameraLockTargetPosition>), Offset<ICameraLockParams> CameraParamsOffset = default(Offset<ICameraLockParams>))
		{
			builder.StartTable(2);
			ICameraLockConfig.AddCameraParams(builder, CameraParamsOffset);
			ICameraLockConfig.AddLockTarget(builder, LockTargetOffset);
			return ICameraLockConfig.EndICameraLockConfig(builder);
		}

		// Token: 0x0602B878 RID: 178296 RVA: 0x005FE416 File Offset: 0x005FC616
		public static void StartICameraLockConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B879 RID: 178297 RVA: 0x005FE41F File Offset: 0x005FC61F
		public static void AddLockTarget(FlatBufferBuilder builder, Offset<ICameraLockTargetPosition> lockTargetOffset)
		{
			builder.AddOffset(0, lockTargetOffset.Value, 0);
		}

		// Token: 0x0602B87A RID: 178298 RVA: 0x005FE42F File Offset: 0x005FC62F
		public static void AddCameraParams(FlatBufferBuilder builder, Offset<ICameraLockParams> cameraParamsOffset)
		{
			builder.AddOffset(1, cameraParamsOffset.Value, 0);
		}

		// Token: 0x0602B87B RID: 178299 RVA: 0x005FE43F File Offset: 0x005FC63F
		public static Offset<ICameraLockConfig> EndICameraLockConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockConfig>(builder.EndTable());
		}

		// Token: 0x0602B87C RID: 178300 RVA: 0x005FE44C File Offset: 0x005FC64C
		public ICameraLockConfigT UnPack()
		{
			ICameraLockConfigT cameraLockConfigT = new ICameraLockConfigT();
			this.UnPackTo(cameraLockConfigT);
			return cameraLockConfigT;
		}

		// Token: 0x0602B87D RID: 178301 RVA: 0x005FE468 File Offset: 0x005FC668
		public void UnPackTo(ICameraLockConfigT _o)
		{
			_o.LockTarget = ((this.LockTarget != null) ? this.LockTarget.Value.UnPack() : null);
			_o.CameraParams = ((this.CameraParams != null) ? this.CameraParams.Value.UnPack() : null);
		}

		// Token: 0x0602B87E RID: 178302 RVA: 0x005FE4D4 File Offset: 0x005FC6D4
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

		// Token: 0x040107E3 RID: 67555
		private Table __p;
	}
}
