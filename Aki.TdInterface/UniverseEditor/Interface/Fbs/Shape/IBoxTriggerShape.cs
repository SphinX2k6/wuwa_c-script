using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004001 RID: 16385
	public struct IBoxTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006F07 RID: 28423
		// (get) Token: 0x060166D9 RID: 91865 RVA: 0x00335FD8 File Offset: 0x003341D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060166DA RID: 91866 RVA: 0x00335FE5 File Offset: 0x003341E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060166DB RID: 91867 RVA: 0x00335FEC File Offset: 0x003341EC
		public static IBoxTriggerShape GetRootAsIBoxTriggerShape(ByteBuffer _bb)
		{
			return IBoxTriggerShape.GetRootAsIBoxTriggerShape(_bb, default(IBoxTriggerShape));
		}

		// Token: 0x060166DC RID: 91868 RVA: 0x00336008 File Offset: 0x00334208
		public static IBoxTriggerShape GetRootAsIBoxTriggerShape(ByteBuffer _bb, IBoxTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060166DD RID: 91869 RVA: 0x00336025 File Offset: 0x00334225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060166DE RID: 91870 RVA: 0x00336034 File Offset: 0x00334234
		public IBoxTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F08 RID: 28424
		// (get) Token: 0x060166DF RID: 91871 RVA: 0x00336044 File Offset: 0x00334244
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

		// Token: 0x17006F09 RID: 28425
		// (get) Token: 0x060166E0 RID: 91872 RVA: 0x00336080 File Offset: 0x00334280
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

		// Token: 0x17006F0A RID: 28426
		// (get) Token: 0x060166E1 RID: 91873 RVA: 0x003360E0 File Offset: 0x003342E0
		public IVectorInfo? Size
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

		// Token: 0x17006F0B RID: 28427
		// (get) Token: 0x060166E2 RID: 91874 RVA: 0x00336140 File Offset: 0x00334340
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060166E3 RID: 91875 RVA: 0x0033619E File Offset: 0x0033439E
		public static Offset<IBoxTriggerShape> CreateIBoxTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IBoxTriggerShape.AddRotator(builder, RotatorOffset);
			IBoxTriggerShape.AddSize(builder, SizeOffset);
			IBoxTriggerShape.AddCenter(builder, CenterOffset);
			IBoxTriggerShape.AddType(builder, Type);
			return IBoxTriggerShape.EndIBoxTriggerShape(builder);
		}

		// Token: 0x060166E4 RID: 91876 RVA: 0x003361CA File Offset: 0x003343CA
		public static void StartIBoxTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060166E5 RID: 91877 RVA: 0x003361D3 File Offset: 0x003343D3
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060166E6 RID: 91878 RVA: 0x003361DE File Offset: 0x003343DE
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060166E7 RID: 91879 RVA: 0x003361EE File Offset: 0x003343EE
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(2, sizeOffset.Value, 0);
		}

		// Token: 0x060166E8 RID: 91880 RVA: 0x003361FE File Offset: 0x003343FE
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x060166E9 RID: 91881 RVA: 0x0033620E File Offset: 0x0033440E
		public static Offset<IBoxTriggerShape> EndIBoxTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IBoxTriggerShape>(builder.EndTable());
		}

		// Token: 0x060166EA RID: 91882 RVA: 0x0033621C File Offset: 0x0033441C
		public IBoxTriggerShapeT UnPack()
		{
			IBoxTriggerShapeT boxTriggerShapeT = new IBoxTriggerShapeT();
			this.UnPackTo(boxTriggerShapeT);
			return boxTriggerShapeT;
		}

		// Token: 0x060166EB RID: 91883 RVA: 0x00336238 File Offset: 0x00334438
		public void UnPackTo(IBoxTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x060166EC RID: 91884 RVA: 0x003362E0 File Offset: 0x003344E0
		public static Offset<IBoxTriggerShape> Pack(FlatBufferBuilder builder, IBoxTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IBoxTriggerShape.CreateIBoxTriggerShape(builder, _o.Type, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400BB4D RID: 47949
		private Table __p;
	}
}
