using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB7 RID: 27831
	public struct IPhotographCameraTransformAbsolute : IFlatbufferObject
	{
		// Token: 0x1700CF33 RID: 53043
		// (get) Token: 0x060310B9 RID: 200889 RVA: 0x006A811F File Offset: 0x006A631F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310BA RID: 200890 RVA: 0x006A812C File Offset: 0x006A632C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310BB RID: 200891 RVA: 0x006A8134 File Offset: 0x006A6334
		public static IPhotographCameraTransformAbsolute GetRootAsIPhotographCameraTransformAbsolute(ByteBuffer _bb)
		{
			return IPhotographCameraTransformAbsolute.GetRootAsIPhotographCameraTransformAbsolute(_bb, default(IPhotographCameraTransformAbsolute));
		}

		// Token: 0x060310BC RID: 200892 RVA: 0x006A8150 File Offset: 0x006A6350
		public static IPhotographCameraTransformAbsolute GetRootAsIPhotographCameraTransformAbsolute(ByteBuffer _bb, IPhotographCameraTransformAbsolute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310BD RID: 200893 RVA: 0x006A816D File Offset: 0x006A636D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310BE RID: 200894 RVA: 0x006A817C File Offset: 0x006A637C
		public IPhotographCameraTransformAbsolute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF34 RID: 53044
		// (get) Token: 0x060310BF RID: 200895 RVA: 0x006A818C File Offset: 0x006A638C
		public EPhotographCameraTransform Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraTransform.Absolute;
				}
				return (EPhotographCameraTransform)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF35 RID: 53045
		// (get) Token: 0x060310C0 RID: 200896 RVA: 0x006A81C8 File Offset: 0x006A63C8
		public IVectorInfo? CameraPos
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

		// Token: 0x1700CF36 RID: 53046
		// (get) Token: 0x060310C1 RID: 200897 RVA: 0x006A8228 File Offset: 0x006A6428
		public IVectorInfo? CameraRot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060310C2 RID: 200898 RVA: 0x006A8285 File Offset: 0x006A6485
		public static Offset<IPhotographCameraTransformAbsolute> CreateIPhotographCameraTransformAbsolute(FlatBufferBuilder builder, EPhotographCameraTransform Type = EPhotographCameraTransform.Absolute, Offset<IVectorInfo> CameraPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CameraRotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IPhotographCameraTransformAbsolute.AddCameraRot(builder, CameraRotOffset);
			IPhotographCameraTransformAbsolute.AddCameraPos(builder, CameraPosOffset);
			IPhotographCameraTransformAbsolute.AddType(builder, Type);
			return IPhotographCameraTransformAbsolute.EndIPhotographCameraTransformAbsolute(builder);
		}

		// Token: 0x060310C3 RID: 200899 RVA: 0x006A82A9 File Offset: 0x006A64A9
		public static void StartIPhotographCameraTransformAbsolute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060310C4 RID: 200900 RVA: 0x006A82B2 File Offset: 0x006A64B2
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraTransform type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060310C5 RID: 200901 RVA: 0x006A82BD File Offset: 0x006A64BD
		public static void AddCameraPos(FlatBufferBuilder builder, Offset<IVectorInfo> cameraPosOffset)
		{
			builder.AddOffset(1, cameraPosOffset.Value, 0);
		}

		// Token: 0x060310C6 RID: 200902 RVA: 0x006A82CD File Offset: 0x006A64CD
		public static void AddCameraRot(FlatBufferBuilder builder, Offset<IVectorInfo> cameraRotOffset)
		{
			builder.AddOffset(2, cameraRotOffset.Value, 0);
		}

		// Token: 0x060310C7 RID: 200903 RVA: 0x006A82DD File Offset: 0x006A64DD
		public static Offset<IPhotographCameraTransformAbsolute> EndIPhotographCameraTransformAbsolute(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraTransformAbsolute>(builder.EndTable());
		}

		// Token: 0x060310C8 RID: 200904 RVA: 0x006A82EC File Offset: 0x006A64EC
		public IPhotographCameraTransformAbsoluteT UnPack()
		{
			IPhotographCameraTransformAbsoluteT photographCameraTransformAbsoluteT = new IPhotographCameraTransformAbsoluteT();
			this.UnPackTo(photographCameraTransformAbsoluteT);
			return photographCameraTransformAbsoluteT;
		}

		// Token: 0x060310C9 RID: 200905 RVA: 0x006A8308 File Offset: 0x006A6508
		public void UnPackTo(IPhotographCameraTransformAbsoluteT _o)
		{
			_o.Type = this.Type;
			_o.CameraPos = ((this.CameraPos != null) ? this.CameraPos.Value.UnPack() : null);
			_o.CameraRot = ((this.CameraRot != null) ? this.CameraRot.Value.UnPack() : null);
		}

		// Token: 0x060310CA RID: 200906 RVA: 0x006A8380 File Offset: 0x006A6580
		public static Offset<IPhotographCameraTransformAbsolute> Pack(FlatBufferBuilder builder, IPhotographCameraTransformAbsoluteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraTransformAbsolute>);
			}
			Offset<IVectorInfo> cameraPosOffset = (_o.CameraPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraPos);
			Offset<IVectorInfo> cameraRotOffset = (_o.CameraRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraRot);
			return IPhotographCameraTransformAbsolute.CreateIPhotographCameraTransformAbsolute(builder, _o.Type, cameraPosOffset, cameraRotOffset);
		}

		// Token: 0x04011616 RID: 71190
		private Table __p;
	}
}
