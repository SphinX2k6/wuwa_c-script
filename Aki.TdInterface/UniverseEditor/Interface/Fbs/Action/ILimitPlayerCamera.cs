using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A17 RID: 27159
	public struct ILimitPlayerCamera : IFlatbufferObject
	{
		// Token: 0x1700C97A RID: 51578
		// (get) Token: 0x0602F861 RID: 194657 RVA: 0x00678725 File Offset: 0x00676925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F862 RID: 194658 RVA: 0x00678732 File Offset: 0x00676932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F863 RID: 194659 RVA: 0x0067873C File Offset: 0x0067693C
		public static ILimitPlayerCamera GetRootAsILimitPlayerCamera(ByteBuffer _bb)
		{
			return ILimitPlayerCamera.GetRootAsILimitPlayerCamera(_bb, default(ILimitPlayerCamera));
		}

		// Token: 0x0602F864 RID: 194660 RVA: 0x00678758 File Offset: 0x00676958
		public static ILimitPlayerCamera GetRootAsILimitPlayerCamera(ByteBuffer _bb, ILimitPlayerCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F865 RID: 194661 RVA: 0x00678775 File Offset: 0x00676975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F866 RID: 194662 RVA: 0x00678784 File Offset: 0x00676984
		public ILimitPlayerCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C97B RID: 51579
		// (get) Token: 0x0602F867 RID: 194663 RVA: 0x00678794 File Offset: 0x00676994
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

		// Token: 0x0602F868 RID: 194664 RVA: 0x006787D0 File Offset: 0x006769D0
		public static Offset<ILimitPlayerCamera> CreateILimitPlayerCamera(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerCamera.AddType(builder, Type);
			return ILimitPlayerCamera.EndILimitPlayerCamera(builder);
		}

		// Token: 0x0602F869 RID: 194665 RVA: 0x006787E6 File Offset: 0x006769E6
		public static void StartILimitPlayerCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F86A RID: 194666 RVA: 0x006787EF File Offset: 0x006769EF
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F86B RID: 194667 RVA: 0x006787FA File Offset: 0x006769FA
		public static Offset<ILimitPlayerCamera> EndILimitPlayerCamera(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerCamera>(builder.EndTable());
		}

		// Token: 0x0602F86C RID: 194668 RVA: 0x00678808 File Offset: 0x00676A08
		public ILimitPlayerCameraT UnPack()
		{
			ILimitPlayerCameraT limitPlayerCameraT = new ILimitPlayerCameraT();
			this.UnPackTo(limitPlayerCameraT);
			return limitPlayerCameraT;
		}

		// Token: 0x0602F86D RID: 194669 RVA: 0x00678823 File Offset: 0x00676A23
		public void UnPackTo(ILimitPlayerCameraT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F86E RID: 194670 RVA: 0x00678834 File Offset: 0x00676A34
		public static Offset<ILimitPlayerCamera> Pack(FlatBufferBuilder builder, ILimitPlayerCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerCamera>);
			}
			return ILimitPlayerCamera.CreateILimitPlayerCamera(builder, _o.Type);
		}

		// Token: 0x0401121D RID: 70173
		private Table __p;
	}
}
