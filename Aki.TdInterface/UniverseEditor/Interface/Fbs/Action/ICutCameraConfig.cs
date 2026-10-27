using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200651C RID: 25884
	public struct ICutCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700C074 RID: 49268
		// (get) Token: 0x0602CE65 RID: 183909 RVA: 0x0062A856 File Offset: 0x00628A56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE66 RID: 183910 RVA: 0x0062A863 File Offset: 0x00628A63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE67 RID: 183911 RVA: 0x0062A86C File Offset: 0x00628A6C
		public static ICutCameraConfig GetRootAsICutCameraConfig(ByteBuffer _bb)
		{
			return ICutCameraConfig.GetRootAsICutCameraConfig(_bb, default(ICutCameraConfig));
		}

		// Token: 0x0602CE68 RID: 183912 RVA: 0x0062A888 File Offset: 0x00628A88
		public static ICutCameraConfig GetRootAsICutCameraConfig(ByteBuffer _bb, ICutCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE69 RID: 183913 RVA: 0x0062A8A5 File Offset: 0x00628AA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE6A RID: 183914 RVA: 0x0062A8B4 File Offset: 0x00628AB4
		public ICutCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C075 RID: 49269
		// (get) Token: 0x0602CE6B RID: 183915 RVA: 0x0062A8C4 File Offset: 0x00628AC4
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

		// Token: 0x1700C076 RID: 49270
		// (get) Token: 0x0602CE6C RID: 183916 RVA: 0x0062A924 File Offset: 0x00628B24
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

		// Token: 0x1700C077 RID: 49271
		// (get) Token: 0x0602CE6D RID: 183917 RVA: 0x0062A984 File Offset: 0x00628B84
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

		// Token: 0x0602CE6E RID: 183918 RVA: 0x0062A9E1 File Offset: 0x00628BE1
		public static Offset<ICutCameraConfig> CreateICutCameraConfig(FlatBufferBuilder builder, Offset<ICameraParams> CameraParamsOffset = default(Offset<ICameraParams>), Offset<IPlayFlow> CutFlowOffset = default(Offset<IPlayFlow>), Offset<ICutCameraTimeParams> CutTimeParamsOffset = default(Offset<ICutCameraTimeParams>))
		{
			builder.StartTable(3);
			ICutCameraConfig.AddCutTimeParams(builder, CutTimeParamsOffset);
			ICutCameraConfig.AddCutFlow(builder, CutFlowOffset);
			ICutCameraConfig.AddCameraParams(builder, CameraParamsOffset);
			return ICutCameraConfig.EndICutCameraConfig(builder);
		}

		// Token: 0x0602CE6F RID: 183919 RVA: 0x0062AA05 File Offset: 0x00628C05
		public static void StartICutCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CE70 RID: 183920 RVA: 0x0062AA0E File Offset: 0x00628C0E
		public static void AddCameraParams(FlatBufferBuilder builder, Offset<ICameraParams> cameraParamsOffset)
		{
			builder.AddOffset(0, cameraParamsOffset.Value, 0);
		}

		// Token: 0x0602CE71 RID: 183921 RVA: 0x0062AA1E File Offset: 0x00628C1E
		public static void AddCutFlow(FlatBufferBuilder builder, Offset<IPlayFlow> cutFlowOffset)
		{
			builder.AddOffset(1, cutFlowOffset.Value, 0);
		}

		// Token: 0x0602CE72 RID: 183922 RVA: 0x0062AA2E File Offset: 0x00628C2E
		public static void AddCutTimeParams(FlatBufferBuilder builder, Offset<ICutCameraTimeParams> cutTimeParamsOffset)
		{
			builder.AddOffset(2, cutTimeParamsOffset.Value, 0);
		}

		// Token: 0x0602CE73 RID: 183923 RVA: 0x0062AA3E File Offset: 0x00628C3E
		public static Offset<ICutCameraConfig> EndICutCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICutCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602CE74 RID: 183924 RVA: 0x0062AA4C File Offset: 0x00628C4C
		public ICutCameraConfigT UnPack()
		{
			ICutCameraConfigT cutCameraConfigT = new ICutCameraConfigT();
			this.UnPackTo(cutCameraConfigT);
			return cutCameraConfigT;
		}

		// Token: 0x0602CE75 RID: 183925 RVA: 0x0062AA68 File Offset: 0x00628C68
		public void UnPackTo(ICutCameraConfigT _o)
		{
			_o.CameraParams = ((this.CameraParams != null) ? this.CameraParams.Value.UnPack() : null);
			_o.CutFlow = ((this.CutFlow != null) ? this.CutFlow.Value.UnPack() : null);
			_o.CutTimeParams = ((this.CutTimeParams != null) ? this.CutTimeParams.Value.UnPack() : null);
		}

		// Token: 0x0602CE76 RID: 183926 RVA: 0x0062AB08 File Offset: 0x00628D08
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

		// Token: 0x04010B66 RID: 68454
		private Table __p;
	}
}
