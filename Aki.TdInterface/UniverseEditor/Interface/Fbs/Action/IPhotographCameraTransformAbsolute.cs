using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742D RID: 29741
	public struct IPhotographCameraTransformAbsolute : IFlatbufferObject
	{
		// Token: 0x1700DA70 RID: 55920
		// (get) Token: 0x06034090 RID: 213136 RVA: 0x00703353 File Offset: 0x00701553
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034091 RID: 213137 RVA: 0x00703360 File Offset: 0x00701560
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034092 RID: 213138 RVA: 0x00703368 File Offset: 0x00701568
		public static IPhotographCameraTransformAbsolute GetRootAsIPhotographCameraTransformAbsolute(ByteBuffer _bb)
		{
			return IPhotographCameraTransformAbsolute.GetRootAsIPhotographCameraTransformAbsolute(_bb, default(IPhotographCameraTransformAbsolute));
		}

		// Token: 0x06034093 RID: 213139 RVA: 0x00703384 File Offset: 0x00701584
		public static IPhotographCameraTransformAbsolute GetRootAsIPhotographCameraTransformAbsolute(ByteBuffer _bb, IPhotographCameraTransformAbsolute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034094 RID: 213140 RVA: 0x007033A1 File Offset: 0x007015A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034095 RID: 213141 RVA: 0x007033B0 File Offset: 0x007015B0
		public IPhotographCameraTransformAbsolute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA71 RID: 55921
		// (get) Token: 0x06034096 RID: 213142 RVA: 0x007033C0 File Offset: 0x007015C0
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

		// Token: 0x1700DA72 RID: 55922
		// (get) Token: 0x06034097 RID: 213143 RVA: 0x007033FC File Offset: 0x007015FC
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

		// Token: 0x1700DA73 RID: 55923
		// (get) Token: 0x06034098 RID: 213144 RVA: 0x0070345C File Offset: 0x0070165C
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

		// Token: 0x06034099 RID: 213145 RVA: 0x007034B9 File Offset: 0x007016B9
		public static Offset<IPhotographCameraTransformAbsolute> CreateIPhotographCameraTransformAbsolute(FlatBufferBuilder builder, EPhotographCameraTransform Type = EPhotographCameraTransform.Absolute, Offset<IVectorInfo> CameraPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CameraRotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IPhotographCameraTransformAbsolute.AddCameraRot(builder, CameraRotOffset);
			IPhotographCameraTransformAbsolute.AddCameraPos(builder, CameraPosOffset);
			IPhotographCameraTransformAbsolute.AddType(builder, Type);
			return IPhotographCameraTransformAbsolute.EndIPhotographCameraTransformAbsolute(builder);
		}

		// Token: 0x0603409A RID: 213146 RVA: 0x007034DD File Offset: 0x007016DD
		public static void StartIPhotographCameraTransformAbsolute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603409B RID: 213147 RVA: 0x007034E6 File Offset: 0x007016E6
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraTransform type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603409C RID: 213148 RVA: 0x007034F1 File Offset: 0x007016F1
		public static void AddCameraPos(FlatBufferBuilder builder, Offset<IVectorInfo> cameraPosOffset)
		{
			builder.AddOffset(1, cameraPosOffset.Value, 0);
		}

		// Token: 0x0603409D RID: 213149 RVA: 0x00703501 File Offset: 0x00701701
		public static void AddCameraRot(FlatBufferBuilder builder, Offset<IVectorInfo> cameraRotOffset)
		{
			builder.AddOffset(2, cameraRotOffset.Value, 0);
		}

		// Token: 0x0603409E RID: 213150 RVA: 0x00703511 File Offset: 0x00701711
		public static Offset<IPhotographCameraTransformAbsolute> EndIPhotographCameraTransformAbsolute(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraTransformAbsolute>(builder.EndTable());
		}

		// Token: 0x0603409F RID: 213151 RVA: 0x00703520 File Offset: 0x00701720
		public IPhotographCameraTransformAbsoluteT UnPack()
		{
			IPhotographCameraTransformAbsoluteT photographCameraTransformAbsoluteT = new IPhotographCameraTransformAbsoluteT();
			this.UnPackTo(photographCameraTransformAbsoluteT);
			return photographCameraTransformAbsoluteT;
		}

		// Token: 0x060340A0 RID: 213152 RVA: 0x0070353C File Offset: 0x0070173C
		public void UnPackTo(IPhotographCameraTransformAbsoluteT _o)
		{
			_o.Type = this.Type;
			_o.CameraPos = ((this.CameraPos != null) ? this.CameraPos.Value.UnPack() : null);
			_o.CameraRot = ((this.CameraRot != null) ? this.CameraRot.Value.UnPack() : null);
		}

		// Token: 0x060340A1 RID: 213153 RVA: 0x007035B4 File Offset: 0x007017B4
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

		// Token: 0x04012586 RID: 75142
		private Table __p;
	}
}
