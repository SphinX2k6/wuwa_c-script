using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C7 RID: 28871
	public struct ILimitPlayerCamera : IFlatbufferObject
	{
		// Token: 0x1700D37A RID: 54138
		// (get) Token: 0x06032221 RID: 205345 RVA: 0x006C8A7D File Offset: 0x006C6C7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032222 RID: 205346 RVA: 0x006C8A8A File Offset: 0x006C6C8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032223 RID: 205347 RVA: 0x006C8A94 File Offset: 0x006C6C94
		public static ILimitPlayerCamera GetRootAsILimitPlayerCamera(ByteBuffer _bb)
		{
			return ILimitPlayerCamera.GetRootAsILimitPlayerCamera(_bb, default(ILimitPlayerCamera));
		}

		// Token: 0x06032224 RID: 205348 RVA: 0x006C8AB0 File Offset: 0x006C6CB0
		public static ILimitPlayerCamera GetRootAsILimitPlayerCamera(ByteBuffer _bb, ILimitPlayerCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032225 RID: 205349 RVA: 0x006C8ACD File Offset: 0x006C6CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032226 RID: 205350 RVA: 0x006C8ADC File Offset: 0x006C6CDC
		public ILimitPlayerCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D37B RID: 54139
		// (get) Token: 0x06032227 RID: 205351 RVA: 0x006C8AEC File Offset: 0x006C6CEC
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032228 RID: 205352 RVA: 0x006C8B28 File Offset: 0x006C6D28
		public static Offset<ILimitPlayerCamera> CreateILimitPlayerCamera(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerCamera.AddType(builder, Type);
			return ILimitPlayerCamera.EndILimitPlayerCamera(builder);
		}

		// Token: 0x06032229 RID: 205353 RVA: 0x006C8B3E File Offset: 0x006C6D3E
		public static void StartILimitPlayerCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603222A RID: 205354 RVA: 0x006C8B47 File Offset: 0x006C6D47
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603222B RID: 205355 RVA: 0x006C8B52 File Offset: 0x006C6D52
		public static Offset<ILimitPlayerCamera> EndILimitPlayerCamera(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerCamera>(builder.EndTable());
		}

		// Token: 0x0603222C RID: 205356 RVA: 0x006C8B60 File Offset: 0x006C6D60
		public ILimitPlayerCameraT UnPack()
		{
			ILimitPlayerCameraT limitPlayerCameraT = new ILimitPlayerCameraT();
			this.UnPackTo(limitPlayerCameraT);
			return limitPlayerCameraT;
		}

		// Token: 0x0603222D RID: 205357 RVA: 0x006C8B7B File Offset: 0x006C6D7B
		public void UnPackTo(ILimitPlayerCameraT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603222E RID: 205358 RVA: 0x006C8B8C File Offset: 0x006C6D8C
		public static Offset<ILimitPlayerCamera> Pack(FlatBufferBuilder builder, ILimitPlayerCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerCamera>);
			}
			return ILimitPlayerCamera.CreateILimitPlayerCamera(builder, _o.Type);
		}

		// Token: 0x04012087 RID: 73863
		private Table __p;
	}
}
