using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200646A RID: 25706
	public struct IPhotoTargetCaptureUiBase : IFlatbufferObject
	{
		// Token: 0x1700BDBA RID: 48570
		// (get) Token: 0x0602BAE4 RID: 178916 RVA: 0x005F1D56 File Offset: 0x005EFF56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BAE5 RID: 178917 RVA: 0x005F1D63 File Offset: 0x005EFF63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BAE6 RID: 178918 RVA: 0x005F1D6C File Offset: 0x005EFF6C
		public static IPhotoTargetCaptureUiBase GetRootAsIPhotoTargetCaptureUiBase(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiBase.GetRootAsIPhotoTargetCaptureUiBase(_bb, default(IPhotoTargetCaptureUiBase));
		}

		// Token: 0x0602BAE7 RID: 178919 RVA: 0x005F1D88 File Offset: 0x005EFF88
		public static IPhotoTargetCaptureUiBase GetRootAsIPhotoTargetCaptureUiBase(ByteBuffer _bb, IPhotoTargetCaptureUiBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BAE8 RID: 178920 RVA: 0x005F1DA5 File Offset: 0x005EFFA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BAE9 RID: 178921 RVA: 0x005F1DB4 File Offset: 0x005EFFB4
		public IPhotoTargetCaptureUiBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDBB RID: 48571
		// (get) Token: 0x0602BAEA RID: 178922 RVA: 0x005F1DC4 File Offset: 0x005EFFC4
		public EPhotoTargetCaptureUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotoTargetCaptureUiType.RequiredPointsCenter;
				}
				return (EPhotoTargetCaptureUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BAEB RID: 178923 RVA: 0x005F1E00 File Offset: 0x005F0000
		public static Offset<IPhotoTargetCaptureUiBase> CreateIPhotoTargetCaptureUiBase(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiBase.AddType(builder, Type);
			return IPhotoTargetCaptureUiBase.EndIPhotoTargetCaptureUiBase(builder);
		}

		// Token: 0x0602BAEC RID: 178924 RVA: 0x005F1E16 File Offset: 0x005F0016
		public static void StartIPhotoTargetCaptureUiBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BAED RID: 178925 RVA: 0x005F1E1F File Offset: 0x005F001F
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BAEE RID: 178926 RVA: 0x005F1E2A File Offset: 0x005F002A
		public static Offset<IPhotoTargetCaptureUiBase> EndIPhotoTargetCaptureUiBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiBase>(builder.EndTable());
		}

		// Token: 0x0602BAEF RID: 178927 RVA: 0x005F1E38 File Offset: 0x005F0038
		public IPhotoTargetCaptureUiBaseT UnPack()
		{
			IPhotoTargetCaptureUiBaseT photoTargetCaptureUiBaseT = new IPhotoTargetCaptureUiBaseT();
			this.UnPackTo(photoTargetCaptureUiBaseT);
			return photoTargetCaptureUiBaseT;
		}

		// Token: 0x0602BAF0 RID: 178928 RVA: 0x005F1E53 File Offset: 0x005F0053
		public void UnPackTo(IPhotoTargetCaptureUiBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BAF1 RID: 178929 RVA: 0x005F1E64 File Offset: 0x005F0064
		public static Offset<IPhotoTargetCaptureUiBase> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiBase>);
			}
			return IPhotoTargetCaptureUiBase.CreateIPhotoTargetCaptureUiBase(builder, _o.Type);
		}

		// Token: 0x04010586 RID: 66950
		private Table __p;
	}
}
