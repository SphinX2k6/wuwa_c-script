using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D9 RID: 21209
	public struct IFurnitureCamera : IFlatbufferObject
	{
		// Token: 0x17009B9D RID: 39837
		// (get) Token: 0x060229BF RID: 141759 RVA: 0x004CC14B File Offset: 0x004CA34B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060229C0 RID: 141760 RVA: 0x004CC158 File Offset: 0x004CA358
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060229C1 RID: 141761 RVA: 0x004CC160 File Offset: 0x004CA360
		public static IFurnitureCamera GetRootAsIFurnitureCamera(ByteBuffer _bb)
		{
			return IFurnitureCamera.GetRootAsIFurnitureCamera(_bb, default(IFurnitureCamera));
		}

		// Token: 0x060229C2 RID: 141762 RVA: 0x004CC17C File Offset: 0x004CA37C
		public static IFurnitureCamera GetRootAsIFurnitureCamera(ByteBuffer _bb, IFurnitureCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060229C3 RID: 141763 RVA: 0x004CC199 File Offset: 0x004CA399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060229C4 RID: 141764 RVA: 0x004CC1A8 File Offset: 0x004CA3A8
		public IFurnitureCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B9E RID: 39838
		// (get) Token: 0x060229C5 RID: 141765 RVA: 0x004CC1B8 File Offset: 0x004CA3B8
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

		// Token: 0x17009B9F RID: 39839
		// (get) Token: 0x060229C6 RID: 141766 RVA: 0x004CC218 File Offset: 0x004CA418
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

		// Token: 0x17009BA0 RID: 39840
		// (get) Token: 0x060229C7 RID: 141767 RVA: 0x004CC278 File Offset: 0x004CA478
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

		// Token: 0x17009BA1 RID: 39841
		// (get) Token: 0x060229C8 RID: 141768 RVA: 0x004CC2B4 File Offset: 0x004CA4B4
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

		// Token: 0x17009BA2 RID: 39842
		// (get) Token: 0x060229C9 RID: 141769 RVA: 0x004CC314 File Offset: 0x004CA514
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

		// Token: 0x17009BA3 RID: 39843
		// (get) Token: 0x060229CA RID: 141770 RVA: 0x004CC358 File Offset: 0x004CA558
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

		// Token: 0x060229CB RID: 141771 RVA: 0x004CC395 File Offset: 0x004CA595
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

		// Token: 0x060229CC RID: 141772 RVA: 0x004CC3D1 File Offset: 0x004CA5D1
		public static void StartIFurnitureCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060229CD RID: 141773 RVA: 0x004CC3DA File Offset: 0x004CA5DA
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060229CE RID: 141774 RVA: 0x004CC3EA File Offset: 0x004CA5EA
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x060229CF RID: 141775 RVA: 0x004CC3FA File Offset: 0x004CA5FA
		public static void AddFov(FlatBufferBuilder builder, int fov)
		{
			builder.AddInt(2, fov, 0);
		}

		// Token: 0x060229D0 RID: 141776 RVA: 0x004CC405 File Offset: 0x004CA605
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBlendFunction> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x060229D1 RID: 141777 RVA: 0x004CC415 File Offset: 0x004CA615
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(4, fadeInTime, 0.0);
		}

		// Token: 0x060229D2 RID: 141778 RVA: 0x004CC428 File Offset: 0x004CA628
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060229D3 RID: 141779 RVA: 0x004CC433 File Offset: 0x004CA633
		public static Offset<IFurnitureCamera> EndIFurnitureCamera(FlatBufferBuilder builder)
		{
			return new Offset<IFurnitureCamera>(builder.EndTable());
		}

		// Token: 0x060229D4 RID: 141780 RVA: 0x004CC440 File Offset: 0x004CA640
		public IFurnitureCameraT UnPack()
		{
			IFurnitureCameraT furnitureCameraT = new IFurnitureCameraT();
			this.UnPackTo(furnitureCameraT);
			return furnitureCameraT;
		}

		// Token: 0x060229D5 RID: 141781 RVA: 0x004CC45C File Offset: 0x004CA65C
		public void UnPackTo(IFurnitureCameraT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Fov = this.Fov;
			_o.FadeInCurve = ((this.FadeInCurve != null) ? this.FadeInCurve.Value.UnPack() : null);
			_o.FadeInTime = this.FadeInTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060229D6 RID: 141782 RVA: 0x004CC51C File Offset: 0x004CA71C
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

		// Token: 0x0400E46F RID: 58479
		private Table __p;
	}
}
