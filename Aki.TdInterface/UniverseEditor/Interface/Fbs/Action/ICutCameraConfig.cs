using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8A RID: 27530
	public struct ICutCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700CA06 RID: 51718
		// (get) Token: 0x0602F603 RID: 194051 RVA: 0x00676D04 File Offset: 0x00674F04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F604 RID: 194052 RVA: 0x00676D11 File Offset: 0x00674F11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F605 RID: 194053 RVA: 0x00676D18 File Offset: 0x00674F18
		public static ICutCameraConfig GetRootAsICutCameraConfig(ByteBuffer _bb)
		{
			return ICutCameraConfig.GetRootAsICutCameraConfig(_bb, default(ICutCameraConfig));
		}

		// Token: 0x0602F606 RID: 194054 RVA: 0x00676D34 File Offset: 0x00674F34
		public static ICutCameraConfig GetRootAsICutCameraConfig(ByteBuffer _bb, ICutCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F607 RID: 194055 RVA: 0x00676D51 File Offset: 0x00674F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F608 RID: 194056 RVA: 0x00676D60 File Offset: 0x00674F60
		public ICutCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA07 RID: 51719
		// (get) Token: 0x0602F609 RID: 194057 RVA: 0x00676D70 File Offset: 0x00674F70
		public ICameraParams? CameraParams
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICameraParams?(default(ICameraParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA08 RID: 51720
		// (get) Token: 0x0602F60A RID: 194058 RVA: 0x00676DD0 File Offset: 0x00674FD0
		public IPlayFlow? CutFlow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA09 RID: 51721
		// (get) Token: 0x0602F60B RID: 194059 RVA: 0x00676E30 File Offset: 0x00675030
		public ICutCameraTimeParams? CutTimeParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ICutCameraTimeParams?(default(ICutCameraTimeParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F60C RID: 194060 RVA: 0x00676E8D File Offset: 0x0067508D
		public static Offset<ICutCameraConfig> CreateICutCameraConfig(FlatBufferBuilder builder, Offset<ICameraParams> CameraParamsOffset = default(Offset<ICameraParams>), Offset<IPlayFlow> CutFlowOffset = default(Offset<IPlayFlow>), Offset<ICutCameraTimeParams> CutTimeParamsOffset = default(Offset<ICutCameraTimeParams>))
		{
			builder.StartTable(3);
			ICutCameraConfig.AddCutTimeParams(builder, CutTimeParamsOffset);
			ICutCameraConfig.AddCutFlow(builder, CutFlowOffset);
			ICutCameraConfig.AddCameraParams(builder, CameraParamsOffset);
			return ICutCameraConfig.EndICutCameraConfig(builder);
		}

		// Token: 0x0602F60D RID: 194061 RVA: 0x00676EB1 File Offset: 0x006750B1
		public static void StartICutCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F60E RID: 194062 RVA: 0x00676EBA File Offset: 0x006750BA
		public static void AddCameraParams(FlatBufferBuilder builder, Offset<ICameraParams> cameraParamsOffset)
		{
			builder.AddOffset(0, cameraParamsOffset.Value, 0);
		}

		// Token: 0x0602F60F RID: 194063 RVA: 0x00676ECA File Offset: 0x006750CA
		public static void AddCutFlow(FlatBufferBuilder builder, Offset<IPlayFlow> cutFlowOffset)
		{
			builder.AddOffset(1, cutFlowOffset.Value, 0);
		}

		// Token: 0x0602F610 RID: 194064 RVA: 0x00676EDA File Offset: 0x006750DA
		public static void AddCutTimeParams(FlatBufferBuilder builder, Offset<ICutCameraTimeParams> cutTimeParamsOffset)
		{
			builder.AddOffset(2, cutTimeParamsOffset.Value, 0);
		}

		// Token: 0x0602F611 RID: 194065 RVA: 0x00676EEA File Offset: 0x006750EA
		public static Offset<ICutCameraConfig> EndICutCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICutCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602F612 RID: 194066 RVA: 0x00676EF8 File Offset: 0x006750F8
		public ICutCameraConfigT UnPack()
		{
			ICutCameraConfigT cutCameraConfigT = new ICutCameraConfigT();
			this.UnPackTo(cutCameraConfigT);
			return cutCameraConfigT;
		}

		// Token: 0x0602F613 RID: 194067 RVA: 0x00676F14 File Offset: 0x00675114
		public void UnPackTo(ICutCameraConfigT _o)
		{
			_o.CameraParams = ((this.CameraParams != null) ? this.CameraParams.Value.UnPack() : null);
			_o.CutFlow = ((this.CutFlow != null) ? this.CutFlow.Value.UnPack() : null);
			_o.CutTimeParams = ((this.CutTimeParams != null) ? this.CutTimeParams.Value.UnPack() : null);
		}

		// Token: 0x0602F614 RID: 194068 RVA: 0x00676FB4 File Offset: 0x006751B4
		public static Offset<ICutCameraConfig> Pack(FlatBufferBuilder builder, ICutCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICutCameraConfig>);
			}
			Offset<ICameraParams> cameraParamsOffset = (_o.CameraParams == null) ? default(Offset<ICameraParams>) : ICameraParams.Pack(builder, _o.CameraParams);
			Offset<IPlayFlow> cutFlowOffset = (_o.CutFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.CutFlow);
			Offset<ICutCameraTimeParams> cutTimeParamsOffset = (_o.CutTimeParams == null) ? default(Offset<ICutCameraTimeParams>) : ICutCameraTimeParams.Pack(builder, _o.CutTimeParams);
			return ICutCameraConfig.CreateICutCameraConfig(builder, cameraParamsOffset, cutFlowOffset, cutTimeParamsOffset);
		}

		// Token: 0x0401197F RID: 72063
		private Table __p;
	}
}
