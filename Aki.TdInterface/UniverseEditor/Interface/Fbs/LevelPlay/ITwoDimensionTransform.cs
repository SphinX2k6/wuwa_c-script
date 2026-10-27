using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E4 RID: 17892
	public struct ITwoDimensionTransform : IFlatbufferObject
	{
		// Token: 0x17007F34 RID: 32564
		// (get) Token: 0x0601B16B RID: 110955 RVA: 0x003DC3FC File Offset: 0x003DA5FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B16C RID: 110956 RVA: 0x003DC409 File Offset: 0x003DA609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B16D RID: 110957 RVA: 0x003DC410 File Offset: 0x003DA610
		public static ITwoDimensionTransform GetRootAsITwoDimensionTransform(ByteBuffer _bb)
		{
			return ITwoDimensionTransform.GetRootAsITwoDimensionTransform(_bb, default(ITwoDimensionTransform));
		}

		// Token: 0x0601B16E RID: 110958 RVA: 0x003DC42C File Offset: 0x003DA62C
		public static ITwoDimensionTransform GetRootAsITwoDimensionTransform(ByteBuffer _bb, ITwoDimensionTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B16F RID: 110959 RVA: 0x003DC449 File Offset: 0x003DA649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B170 RID: 110960 RVA: 0x003DC458 File Offset: 0x003DA658
		public ITwoDimensionTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F35 RID: 32565
		// (get) Token: 0x0601B171 RID: 110961 RVA: 0x003DC468 File Offset: 0x003DA668
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

		// Token: 0x17007F36 RID: 32566
		// (get) Token: 0x0601B172 RID: 110962 RVA: 0x003DC4C8 File Offset: 0x003DA6C8
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

		// Token: 0x0601B173 RID: 110963 RVA: 0x003DC508 File Offset: 0x003DA708
		public static Offset<ITwoDimensionTransform> CreateITwoDimensionTransform(FlatBufferBuilder builder, Offset<IVector2> PositionOffset = default(Offset<IVector2>), float Rotation = 0f)
		{
			builder.StartTable(2);
			ITwoDimensionTransform.AddRotation(builder, Rotation);
			ITwoDimensionTransform.AddPosition(builder, PositionOffset);
			return ITwoDimensionTransform.EndITwoDimensionTransform(builder);
		}

		// Token: 0x0601B174 RID: 110964 RVA: 0x003DC525 File Offset: 0x003DA725
		public static void StartITwoDimensionTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B175 RID: 110965 RVA: 0x003DC52E File Offset: 0x003DA72E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVector2> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0601B176 RID: 110966 RVA: 0x003DC53E File Offset: 0x003DA73E
		public static void AddRotation(FlatBufferBuilder builder, float rotation)
		{
			builder.AddFloat(1, rotation, 0.0);
		}

		// Token: 0x0601B177 RID: 110967 RVA: 0x003DC551 File Offset: 0x003DA751
		public static Offset<ITwoDimensionTransform> EndITwoDimensionTransform(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionTransform>(builder.EndTable());
		}

		// Token: 0x0601B178 RID: 110968 RVA: 0x003DC560 File Offset: 0x003DA760
		public ITwoDimensionTransformT UnPack()
		{
			ITwoDimensionTransformT twoDimensionTransformT = new ITwoDimensionTransformT();
			this.UnPackTo(twoDimensionTransformT);
			return twoDimensionTransformT;
		}

		// Token: 0x0601B179 RID: 110969 RVA: 0x003DC57C File Offset: 0x003DA77C
		public void UnPackTo(ITwoDimensionTransformT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = this.Rotation;
		}

		// Token: 0x0601B17A RID: 110970 RVA: 0x003DC5C4 File Offset: 0x003DA7C4
		public static Offset<ITwoDimensionTransform> Pack(FlatBufferBuilder builder, ITwoDimensionTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionTransform>);
			}
			Offset<IVector2> positionOffset = (_o.Position == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Position);
			return ITwoDimensionTransform.CreateITwoDimensionTransform(builder, positionOffset, _o.Rotation);
		}

		// Token: 0x0400C6C4 RID: 50884
		private Table __p;
	}
}
