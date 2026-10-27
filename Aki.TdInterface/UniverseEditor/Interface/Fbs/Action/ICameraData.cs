using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006275 RID: 25205
	public struct ICameraData : IFlatbufferObject
	{
		// Token: 0x1700BBD5 RID: 48085
		// (get) Token: 0x0602B80D RID: 178189 RVA: 0x005FD6C4 File Offset: 0x005FB8C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B80E RID: 178190 RVA: 0x005FD6D1 File Offset: 0x005FB8D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B80F RID: 178191 RVA: 0x005FD6D8 File Offset: 0x005FB8D8
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb)
		{
			return ICameraData.GetRootAsICameraData(_bb, default(ICameraData));
		}

		// Token: 0x0602B810 RID: 178192 RVA: 0x005FD6F4 File Offset: 0x005FB8F4
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb, ICameraData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B811 RID: 178193 RVA: 0x005FD711 File Offset: 0x005FB911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B812 RID: 178194 RVA: 0x005FD720 File Offset: 0x005FB920
		public ICameraData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBD6 RID: 48086
		// (get) Token: 0x0602B813 RID: 178195 RVA: 0x005FD730 File Offset: 0x005FB930
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

		// Token: 0x1700BBD7 RID: 48087
		// (get) Token: 0x0602B814 RID: 178196 RVA: 0x005FD790 File Offset: 0x005FB990
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

		// Token: 0x0602B815 RID: 178197 RVA: 0x005FD7ED File Offset: 0x005FB9ED
		public static Offset<ICameraData> CreateICameraData(FlatBufferBuilder builder, Offset<IFlowTemplateMode> CameraOffset = default(Offset<IFlowTemplateMode>), Offset<ISetCameraAnim> CameraAnimOffset = default(Offset<ISetCameraAnim>))
		{
			builder.StartTable(2);
			ICameraData.AddCameraAnim(builder, CameraAnimOffset);
			ICameraData.AddCamera(builder, CameraOffset);
			return ICameraData.EndICameraData(builder);
		}

		// Token: 0x0602B816 RID: 178198 RVA: 0x005FD80A File Offset: 0x005FBA0A
		public static void StartICameraData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B817 RID: 178199 RVA: 0x005FD813 File Offset: 0x005FBA13
		public static void AddCamera(FlatBufferBuilder builder, Offset<IFlowTemplateMode> cameraOffset)
		{
			builder.AddOffset(0, cameraOffset.Value, 0);
		}

		// Token: 0x0602B818 RID: 178200 RVA: 0x005FD823 File Offset: 0x005FBA23
		public static void AddCameraAnim(FlatBufferBuilder builder, Offset<ISetCameraAnim> cameraAnimOffset)
		{
			builder.AddOffset(1, cameraAnimOffset.Value, 0);
		}

		// Token: 0x0602B819 RID: 178201 RVA: 0x005FD833 File Offset: 0x005FBA33
		public static Offset<ICameraData> EndICameraData(FlatBufferBuilder builder)
		{
			return new Offset<ICameraData>(builder.EndTable());
		}

		// Token: 0x0602B81A RID: 178202 RVA: 0x005FD840 File Offset: 0x005FBA40
		public ICameraDataT UnPack()
		{
			ICameraDataT cameraDataT = new ICameraDataT();
			this.UnPackTo(cameraDataT);
			return cameraDataT;
		}

		// Token: 0x0602B81B RID: 178203 RVA: 0x005FD85C File Offset: 0x005FBA5C
		public void UnPackTo(ICameraDataT _o)
		{
			_o.Camera = ((this.Camera != null) ? this.Camera.Value.UnPack() : null);
			_o.CameraAnim = ((this.CameraAnim != null) ? this.CameraAnim.Value.UnPack() : null);
		}

		// Token: 0x0602B81C RID: 178204 RVA: 0x005FD8C8 File Offset: 0x005FBAC8
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

		// Token: 0x040107D2 RID: 67538
		private Table __p;
	}
}
