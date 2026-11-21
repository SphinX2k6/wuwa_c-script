using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A4C RID: 19020
	public struct ITwoDimensionTransform : IFlatbufferObject
	{
		// Token: 0x17008575 RID: 34165
		// (get) Token: 0x0601C940 RID: 117056 RVA: 0x00408698 File Offset: 0x00406898
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C941 RID: 117057 RVA: 0x004086A5 File Offset: 0x004068A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C942 RID: 117058 RVA: 0x004086AC File Offset: 0x004068AC
		public static ITwoDimensionTransform GetRootAsITwoDimensionTransform(ByteBuffer _bb)
		{
			return ITwoDimensionTransform.GetRootAsITwoDimensionTransform(_bb, default(ITwoDimensionTransform));
		}

		// Token: 0x0601C943 RID: 117059 RVA: 0x004086C8 File Offset: 0x004068C8
		public static ITwoDimensionTransform GetRootAsITwoDimensionTransform(ByteBuffer _bb, ITwoDimensionTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C944 RID: 117060 RVA: 0x004086E5 File Offset: 0x004068E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C945 RID: 117061 RVA: 0x004086F4 File Offset: 0x004068F4
		public ITwoDimensionTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008576 RID: 34166
		// (get) Token: 0x0601C946 RID: 117062 RVA: 0x00408704 File Offset: 0x00406904
		public IVector2? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008577 RID: 34167
		// (get) Token: 0x0601C947 RID: 117063 RVA: 0x00408764 File Offset: 0x00406964
		public float Rotation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C948 RID: 117064 RVA: 0x004087A4 File Offset: 0x004069A4
		public static Offset<ITwoDimensionTransform> CreateITwoDimensionTransform(FlatBufferBuilder builder, Offset<IVector2> PositionOffset = default(Offset<IVector2>), float Rotation = 0f)
		{
			builder.StartTable(2);
			ITwoDimensionTransform.AddRotation(builder, Rotation);
			ITwoDimensionTransform.AddPosition(builder, PositionOffset);
			return ITwoDimensionTransform.EndITwoDimensionTransform(builder);
		}

		// Token: 0x0601C949 RID: 117065 RVA: 0x004087C1 File Offset: 0x004069C1
		public static void StartITwoDimensionTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C94A RID: 117066 RVA: 0x004087CA File Offset: 0x004069CA
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVector2> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0601C94B RID: 117067 RVA: 0x004087DA File Offset: 0x004069DA
		public static void AddRotation(FlatBufferBuilder builder, float rotation)
		{
			builder.AddFloat(1, rotation, 0.0);
		}

		// Token: 0x0601C94C RID: 117068 RVA: 0x004087ED File Offset: 0x004069ED
		public static Offset<ITwoDimensionTransform> EndITwoDimensionTransform(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionTransform>(builder.EndTable());
		}

		// Token: 0x0601C94D RID: 117069 RVA: 0x004087FC File Offset: 0x004069FC
		public ITwoDimensionTransformT UnPack()
		{
			ITwoDimensionTransformT twoDimensionTransformT = new ITwoDimensionTransformT();
			this.UnPackTo(twoDimensionTransformT);
			return twoDimensionTransformT;
		}

		// Token: 0x0601C94E RID: 117070 RVA: 0x00408818 File Offset: 0x00406A18
		public void UnPackTo(ITwoDimensionTransformT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = this.Rotation;
		}

		// Token: 0x0601C94F RID: 117071 RVA: 0x00408860 File Offset: 0x00406A60
		public static Offset<ITwoDimensionTransform> Pack(FlatBufferBuilder builder, ITwoDimensionTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionTransform>);
			}
			Offset<IVector2> positionOffset = (_o.Position == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Position);
			return ITwoDimensionTransform.CreateITwoDimensionTransform(builder, positionOffset, _o.Rotation);
		}

		// Token: 0x0400D0F3 RID: 53491
		private Table __p;
	}
}
