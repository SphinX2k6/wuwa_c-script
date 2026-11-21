using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585C RID: 22620
	public struct IFurnitureCamera : IFlatbufferObject
	{
		// Token: 0x1700A3CE RID: 41934
		// (get) Token: 0x06024A59 RID: 150105 RVA: 0x00508C75 File Offset: 0x00506E75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A5A RID: 150106 RVA: 0x00508C82 File Offset: 0x00506E82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A5B RID: 150107 RVA: 0x00508C8C File Offset: 0x00506E8C
		public static IFurnitureCamera GetRootAsIFurnitureCamera(ByteBuffer _bb)
		{
			return IFurnitureCamera.GetRootAsIFurnitureCamera(_bb, default(IFurnitureCamera));
		}

		// Token: 0x06024A5C RID: 150108 RVA: 0x00508CA8 File Offset: 0x00506EA8
		public static IFurnitureCamera GetRootAsIFurnitureCamera(ByteBuffer _bb, IFurnitureCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A5D RID: 150109 RVA: 0x00508CC5 File Offset: 0x00506EC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A5E RID: 150110 RVA: 0x00508CD4 File Offset: 0x00506ED4
		public IFurnitureCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3CF RID: 41935
		// (get) Token: 0x06024A5F RID: 150111 RVA: 0x00508CE4 File Offset: 0x00506EE4
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A3D0 RID: 41936
		// (get) Token: 0x06024A60 RID: 150112 RVA: 0x00508D44 File Offset: 0x00506F44
		public IVectorInfo? Rot
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

		// Token: 0x1700A3D1 RID: 41937
		// (get) Token: 0x06024A61 RID: 150113 RVA: 0x00508DA4 File Offset: 0x00506FA4
		public int Fov
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A3D2 RID: 41938
		// (get) Token: 0x06024A62 RID: 150114 RVA: 0x00508DE0 File Offset: 0x00506FE0
		public IBlendFunction? FadeInCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IBlendFunction?(default(IBlendFunction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A3D3 RID: 41939
		// (get) Token: 0x06024A63 RID: 150115 RVA: 0x00508E40 File Offset: 0x00507040
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A3D4 RID: 41940
		// (get) Token: 0x06024A64 RID: 150116 RVA: 0x00508E84 File Offset: 0x00507084
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A65 RID: 150117 RVA: 0x00508EC1 File Offset: 0x005070C1
		public static Offset<IFurnitureCamera> CreateIFurnitureCamera(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), int Fov = 0, Offset<IBlendFunction> FadeInCurveOffset = default(Offset<IBlendFunction>), float FadeInTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IFurnitureCamera.AddFadeInTime(builder, FadeInTime);
			IFurnitureCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IFurnitureCamera.AddFov(builder, Fov);
			IFurnitureCamera.AddRot(builder, RotOffset);
			IFurnitureCamera.AddPos(builder, PosOffset);
			IFurnitureCamera.AddNullMask(builder, NullMask);
			return IFurnitureCamera.EndIFurnitureCamera(builder);
		}

		// Token: 0x06024A66 RID: 150118 RVA: 0x00508EFD File Offset: 0x005070FD
		public static void StartIFurnitureCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024A67 RID: 150119 RVA: 0x00508F06 File Offset: 0x00507106
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x06024A68 RID: 150120 RVA: 0x00508F16 File Offset: 0x00507116
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x06024A69 RID: 150121 RVA: 0x00508F26 File Offset: 0x00507126
		public static void AddFov(FlatBufferBuilder builder, int fov)
		{
			builder.AddInt(2, fov, 0);
		}

		// Token: 0x06024A6A RID: 150122 RVA: 0x00508F31 File Offset: 0x00507131
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBlendFunction> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x06024A6B RID: 150123 RVA: 0x00508F41 File Offset: 0x00507141
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(4, fadeInTime, 0.0);
		}

		// Token: 0x06024A6C RID: 150124 RVA: 0x00508F54 File Offset: 0x00507154
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06024A6D RID: 150125 RVA: 0x00508F5F File Offset: 0x0050715F
		public static Offset<IFurnitureCamera> EndIFurnitureCamera(FlatBufferBuilder builder)
		{
			return new Offset<IFurnitureCamera>(builder.EndTable());
		}

		// Token: 0x06024A6E RID: 150126 RVA: 0x00508F6C File Offset: 0x0050716C
		public IFurnitureCameraT UnPack()
		{
			IFurnitureCameraT furnitureCameraT = new IFurnitureCameraT();
			this.UnPackTo(furnitureCameraT);
			return furnitureCameraT;
		}

		// Token: 0x06024A6F RID: 150127 RVA: 0x00508F88 File Offset: 0x00507188
		public void UnPackTo(IFurnitureCameraT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Fov = this.Fov;
			_o.FadeInCurve = ((this.FadeInCurve != null) ? this.FadeInCurve.Value.UnPack() : null);
			_o.FadeInTime = this.FadeInTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024A70 RID: 150128 RVA: 0x00509048 File Offset: 0x00507248
		public static Offset<IFurnitureCamera> Pack(FlatBufferBuilder builder, IFurnitureCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFurnitureCamera>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			Offset<IBlendFunction> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBlendFunction>) : IBlendFunction.Pack(builder, _o.FadeInCurve);
			return IFurnitureCamera.CreateIFurnitureCamera(builder, posOffset, rotOffset, _o.Fov, fadeInCurveOffset, _o.FadeInTime, _o.NullMask);
		}

		// Token: 0x0400F09B RID: 61595
		private Table __p;
	}
}
