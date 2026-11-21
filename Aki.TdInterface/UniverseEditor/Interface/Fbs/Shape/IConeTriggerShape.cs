using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004010 RID: 16400
	public struct IConeTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006F31 RID: 28465
		// (get) Token: 0x06016777 RID: 92023 RVA: 0x003377E0 File Offset: 0x003359E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016778 RID: 92024 RVA: 0x003377ED File Offset: 0x003359ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016779 RID: 92025 RVA: 0x003377F4 File Offset: 0x003359F4
		public static IConeTriggerShape GetRootAsIConeTriggerShape(ByteBuffer _bb)
		{
			return IConeTriggerShape.GetRootAsIConeTriggerShape(_bb, default(IConeTriggerShape));
		}

		// Token: 0x0601677A RID: 92026 RVA: 0x00337810 File Offset: 0x00335A10
		public static IConeTriggerShape GetRootAsIConeTriggerShape(ByteBuffer _bb, IConeTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601677B RID: 92027 RVA: 0x0033782D File Offset: 0x00335A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601677C RID: 92028 RVA: 0x0033783C File Offset: 0x00335A3C
		public IConeTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F32 RID: 28466
		// (get) Token: 0x0601677D RID: 92029 RVA: 0x0033784C File Offset: 0x00335A4C
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F33 RID: 28467
		// (get) Token: 0x0601677E RID: 92030 RVA: 0x00337888 File Offset: 0x00335A88
		public IVectorInfo? Center
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

		// Token: 0x17006F34 RID: 28468
		// (get) Token: 0x0601677F RID: 92031 RVA: 0x003378E8 File Offset: 0x00335AE8
		public int Radius
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

		// Token: 0x17006F35 RID: 28469
		// (get) Token: 0x06016780 RID: 92032 RVA: 0x00337924 File Offset: 0x00335B24
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016781 RID: 92033 RVA: 0x00337961 File Offset: 0x00335B61
		public static Offset<IConeTriggerShape> CreateIConeTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0)
		{
			builder.StartTable(4);
			IConeTriggerShape.AddHeight(builder, Height);
			IConeTriggerShape.AddRadius(builder, Radius);
			IConeTriggerShape.AddCenter(builder, CenterOffset);
			IConeTriggerShape.AddType(builder, Type);
			return IConeTriggerShape.EndIConeTriggerShape(builder);
		}

		// Token: 0x06016782 RID: 92034 RVA: 0x0033798D File Offset: 0x00335B8D
		public static void StartIConeTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016783 RID: 92035 RVA: 0x00337996 File Offset: 0x00335B96
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016784 RID: 92036 RVA: 0x003379A1 File Offset: 0x00335BA1
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016785 RID: 92037 RVA: 0x003379B1 File Offset: 0x00335BB1
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06016786 RID: 92038 RVA: 0x003379BC File Offset: 0x00335BBC
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x06016787 RID: 92039 RVA: 0x003379C7 File Offset: 0x00335BC7
		public static Offset<IConeTriggerShape> EndIConeTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IConeTriggerShape>(builder.EndTable());
		}

		// Token: 0x06016788 RID: 92040 RVA: 0x003379D4 File Offset: 0x00335BD4
		public IConeTriggerShapeT UnPack()
		{
			IConeTriggerShapeT coneTriggerShapeT = new IConeTriggerShapeT();
			this.UnPackTo(coneTriggerShapeT);
			return coneTriggerShapeT;
		}

		// Token: 0x06016789 RID: 92041 RVA: 0x003379F0 File Offset: 0x00335BF0
		public void UnPackTo(IConeTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x0601678A RID: 92042 RVA: 0x00337A50 File Offset: 0x00335C50
		public static Offset<IConeTriggerShape> Pack(FlatBufferBuilder builder, IConeTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConeTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IConeTriggerShape.CreateIConeTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0400BB64 RID: 47972
		private Table __p;
	}
}
