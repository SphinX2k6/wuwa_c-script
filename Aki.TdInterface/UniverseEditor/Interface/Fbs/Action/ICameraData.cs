using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E6 RID: 26854
	public struct ICameraData : IFlatbufferObject
	{
		// Token: 0x1700C55D RID: 50525
		// (get) Token: 0x0602DF6E RID: 188270 RVA: 0x006484CC File Offset: 0x006466CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF6F RID: 188271 RVA: 0x006484D9 File Offset: 0x006466D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF70 RID: 188272 RVA: 0x006484E0 File Offset: 0x006466E0
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb)
		{
			return ICameraData.GetRootAsICameraData(_bb, default(ICameraData));
		}

		// Token: 0x0602DF71 RID: 188273 RVA: 0x006484FC File Offset: 0x006466FC
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb, ICameraData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF72 RID: 188274 RVA: 0x00648519 File Offset: 0x00646719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF73 RID: 188275 RVA: 0x00648528 File Offset: 0x00646728
		public ICameraData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C55E RID: 50526
		// (get) Token: 0x0602DF74 RID: 188276 RVA: 0x00648538 File Offset: 0x00646738
		public IFlowTemplateMode? Camera
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFlowTemplateMode?(default(IFlowTemplateMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C55F RID: 50527
		// (get) Token: 0x0602DF75 RID: 188277 RVA: 0x00648598 File Offset: 0x00646798
		public ISetCameraAnim? CameraAnim
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISetCameraAnim?(default(ISetCameraAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602DF76 RID: 188278 RVA: 0x006485F5 File Offset: 0x006467F5
		public static Offset<ICameraData> CreateICameraData(FlatBufferBuilder builder, Offset<IFlowTemplateMode> CameraOffset = default(Offset<IFlowTemplateMode>), Offset<ISetCameraAnim> CameraAnimOffset = default(Offset<ISetCameraAnim>))
		{
			builder.StartTable(2);
			ICameraData.AddCameraAnim(builder, CameraAnimOffset);
			ICameraData.AddCamera(builder, CameraOffset);
			return ICameraData.EndICameraData(builder);
		}

		// Token: 0x0602DF77 RID: 188279 RVA: 0x00648612 File Offset: 0x00646812
		public static void StartICameraData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DF78 RID: 188280 RVA: 0x0064861B File Offset: 0x0064681B
		public static void AddCamera(FlatBufferBuilder builder, Offset<IFlowTemplateMode> cameraOffset)
		{
			builder.AddOffset(0, cameraOffset.Value, 0);
		}

		// Token: 0x0602DF79 RID: 188281 RVA: 0x0064862B File Offset: 0x0064682B
		public static void AddCameraAnim(FlatBufferBuilder builder, Offset<ISetCameraAnim> cameraAnimOffset)
		{
			builder.AddOffset(1, cameraAnimOffset.Value, 0);
		}

		// Token: 0x0602DF7A RID: 188282 RVA: 0x0064863B File Offset: 0x0064683B
		public static Offset<ICameraData> EndICameraData(FlatBufferBuilder builder)
		{
			return new Offset<ICameraData>(builder.EndTable());
		}

		// Token: 0x0602DF7B RID: 188283 RVA: 0x00648648 File Offset: 0x00646848
		public ICameraDataT UnPack()
		{
			ICameraDataT cameraDataT = new ICameraDataT();
			this.UnPackTo(cameraDataT);
			return cameraDataT;
		}

		// Token: 0x0602DF7C RID: 188284 RVA: 0x00648664 File Offset: 0x00646864
		public void UnPackTo(ICameraDataT _o)
		{
			_o.Camera = ((this.Camera != null) ? this.Camera.Value.UnPack() : null);
			_o.CameraAnim = ((this.CameraAnim != null) ? this.CameraAnim.Value.UnPack() : null);
		}

		// Token: 0x0602DF7D RID: 188285 RVA: 0x006486D0 File Offset: 0x006468D0
		public static Offset<ICameraData> Pack(FlatBufferBuilder builder, ICameraDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraData>);
			}
			Offset<IFlowTemplateMode> cameraOffset = (_o.Camera == null) ? default(Offset<IFlowTemplateMode>) : IFlowTemplateMode.Pack(builder, _o.Camera);
			Offset<ISetCameraAnim> cameraAnimOffset = (_o.CameraAnim == null) ? default(Offset<ISetCameraAnim>) : ISetCameraAnim.Pack(builder, _o.CameraAnim);
			return ICameraData.CreateICameraData(builder, cameraOffset, cameraAnimOffset);
		}

		// Token: 0x040115E7 RID: 71143
		private Table __p;
	}
}
