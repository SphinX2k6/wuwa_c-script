using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FE RID: 29950
	public struct IPostProcessVolumeCenterPosition : IFlatbufferObject
	{
		// Token: 0x1700DC72 RID: 56434
		// (get) Token: 0x06034856 RID: 215126 RVA: 0x00711ED0 File Offset: 0x007100D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034857 RID: 215127 RVA: 0x00711EDD File Offset: 0x007100DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034858 RID: 215128 RVA: 0x00711EE4 File Offset: 0x007100E4
		public static IPostProcessVolumeCenterPosition GetRootAsIPostProcessVolumeCenterPosition(ByteBuffer _bb)
		{
			return IPostProcessVolumeCenterPosition.GetRootAsIPostProcessVolumeCenterPosition(_bb, default(IPostProcessVolumeCenterPosition));
		}

		// Token: 0x06034859 RID: 215129 RVA: 0x00711F00 File Offset: 0x00710100
		public static IPostProcessVolumeCenterPosition GetRootAsIPostProcessVolumeCenterPosition(ByteBuffer _bb, IPostProcessVolumeCenterPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603485A RID: 215130 RVA: 0x00711F1D File Offset: 0x0071011D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603485B RID: 215131 RVA: 0x00711F2C File Offset: 0x0071012C
		public IPostProcessVolumeCenterPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC73 RID: 56435
		// (get) Token: 0x0603485C RID: 215132 RVA: 0x00711F3C File Offset: 0x0071013C
		public EMpcEffectParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMpcEffectParamType.PostProcessVolumeCenterPosition;
				}
				return (EMpcEffectParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC74 RID: 56436
		// (get) Token: 0x0603485D RID: 215133 RVA: 0x00711F78 File Offset: 0x00710178
		public IVectorInfo? Position
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

		// Token: 0x0603485E RID: 215134 RVA: 0x00711FD5 File Offset: 0x007101D5
		public static Offset<IPostProcessVolumeCenterPosition> CreateIPostProcessVolumeCenterPosition(FlatBufferBuilder builder, EMpcEffectParamType Type = EMpcEffectParamType.PostProcessVolumeCenterPosition, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPostProcessVolumeCenterPosition.AddPosition(builder, PositionOffset);
			IPostProcessVolumeCenterPosition.AddType(builder, Type);
			return IPostProcessVolumeCenterPosition.EndIPostProcessVolumeCenterPosition(builder);
		}

		// Token: 0x0603485F RID: 215135 RVA: 0x00711FF2 File Offset: 0x007101F2
		public static void StartIPostProcessVolumeCenterPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034860 RID: 215136 RVA: 0x00711FFB File Offset: 0x007101FB
		public static void AddType(FlatBufferBuilder builder, EMpcEffectParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034861 RID: 215137 RVA: 0x00712006 File Offset: 0x00710206
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06034862 RID: 215138 RVA: 0x00712016 File Offset: 0x00710216
		public static Offset<IPostProcessVolumeCenterPosition> EndIPostProcessVolumeCenterPosition(FlatBufferBuilder builder)
		{
			return new Offset<IPostProcessVolumeCenterPosition>(builder.EndTable());
		}

		// Token: 0x06034863 RID: 215139 RVA: 0x00712024 File Offset: 0x00710224
		public IPostProcessVolumeCenterPositionT UnPack()
		{
			IPostProcessVolumeCenterPositionT postProcessVolumeCenterPositionT = new IPostProcessVolumeCenterPositionT();
			this.UnPackTo(postProcessVolumeCenterPositionT);
			return postProcessVolumeCenterPositionT;
		}

		// Token: 0x06034864 RID: 215140 RVA: 0x00712040 File Offset: 0x00710240
		public void UnPackTo(IPostProcessVolumeCenterPositionT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06034865 RID: 215141 RVA: 0x00712088 File Offset: 0x00710288
		public static Offset<IPostProcessVolumeCenterPosition> Pack(FlatBufferBuilder builder, IPostProcessVolumeCenterPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostProcessVolumeCenterPosition>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IPostProcessVolumeCenterPosition.CreateIPostProcessVolumeCenterPosition(builder, _o.Type, positionOffset);
		}

		// Token: 0x040126CD RID: 75469
		private Table __p;
	}
}
