using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006479 RID: 25721
	public struct IPhotoTargetCaptureUiRequiredPointsCenter : IFlatbufferObject
	{
		// Token: 0x1700BDCA RID: 48586
		// (get) Token: 0x0602BB48 RID: 179016 RVA: 0x005F2731 File Offset: 0x005F0931
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB49 RID: 179017 RVA: 0x005F273E File Offset: 0x005F093E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB4A RID: 179018 RVA: 0x005F2748 File Offset: 0x005F0948
		public static IPhotoTargetCaptureUiRequiredPointsCenter GetRootAsIPhotoTargetCaptureUiRequiredPointsCenter(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiRequiredPointsCenter.GetRootAsIPhotoTargetCaptureUiRequiredPointsCenter(_bb, default(IPhotoTargetCaptureUiRequiredPointsCenter));
		}

		// Token: 0x0602BB4B RID: 179019 RVA: 0x005F2764 File Offset: 0x005F0964
		public static IPhotoTargetCaptureUiRequiredPointsCenter GetRootAsIPhotoTargetCaptureUiRequiredPointsCenter(ByteBuffer _bb, IPhotoTargetCaptureUiRequiredPointsCenter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB4C RID: 179020 RVA: 0x005F2781 File Offset: 0x005F0981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB4D RID: 179021 RVA: 0x005F2790 File Offset: 0x005F0990
		public IPhotoTargetCaptureUiRequiredPointsCenter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDCB RID: 48587
		// (get) Token: 0x0602BB4E RID: 179022 RVA: 0x005F27A0 File Offset: 0x005F09A0
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

		// Token: 0x0602BB4F RID: 179023 RVA: 0x005F27DC File Offset: 0x005F09DC
		public static Offset<IPhotoTargetCaptureUiRequiredPointsCenter> CreateIPhotoTargetCaptureUiRequiredPointsCenter(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiRequiredPointsCenter.AddType(builder, Type);
			return IPhotoTargetCaptureUiRequiredPointsCenter.EndIPhotoTargetCaptureUiRequiredPointsCenter(builder);
		}

		// Token: 0x0602BB50 RID: 179024 RVA: 0x005F27F2 File Offset: 0x005F09F2
		public static void StartIPhotoTargetCaptureUiRequiredPointsCenter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BB51 RID: 179025 RVA: 0x005F27FB File Offset: 0x005F09FB
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB52 RID: 179026 RVA: 0x005F2806 File Offset: 0x005F0A06
		public static Offset<IPhotoTargetCaptureUiRequiredPointsCenter> EndIPhotoTargetCaptureUiRequiredPointsCenter(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiRequiredPointsCenter>(builder.EndTable());
		}

		// Token: 0x0602BB53 RID: 179027 RVA: 0x005F2814 File Offset: 0x005F0A14
		public IPhotoTargetCaptureUiRequiredPointsCenterT UnPack()
		{
			IPhotoTargetCaptureUiRequiredPointsCenterT photoTargetCaptureUiRequiredPointsCenterT = new IPhotoTargetCaptureUiRequiredPointsCenterT();
			this.UnPackTo(photoTargetCaptureUiRequiredPointsCenterT);
			return photoTargetCaptureUiRequiredPointsCenterT;
		}

		// Token: 0x0602BB54 RID: 179028 RVA: 0x005F282F File Offset: 0x005F0A2F
		public void UnPackTo(IPhotoTargetCaptureUiRequiredPointsCenterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BB55 RID: 179029 RVA: 0x005F2840 File Offset: 0x005F0A40
		public static Offset<IPhotoTargetCaptureUiRequiredPointsCenter> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiRequiredPointsCenterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiRequiredPointsCenter>);
			}
			return IPhotoTargetCaptureUiRequiredPointsCenter.CreateIPhotoTargetCaptureUiRequiredPointsCenter(builder, _o.Type);
		}

		// Token: 0x04010598 RID: 66968
		private Table __p;
	}
}
