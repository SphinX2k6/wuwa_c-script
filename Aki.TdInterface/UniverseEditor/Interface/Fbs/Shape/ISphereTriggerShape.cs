using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004052 RID: 16466
	public struct ISphereTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006FFC RID: 28668
		// (get) Token: 0x06016A19 RID: 92697 RVA: 0x0033C868 File Offset: 0x0033AA68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A1A RID: 92698 RVA: 0x0033C875 File Offset: 0x0033AA75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A1B RID: 92699 RVA: 0x0033C87C File Offset: 0x0033AA7C
		public static ISphereTriggerShape GetRootAsISphereTriggerShape(ByteBuffer _bb)
		{
			return ISphereTriggerShape.GetRootAsISphereTriggerShape(_bb, default(ISphereTriggerShape));
		}

		// Token: 0x06016A1C RID: 92700 RVA: 0x0033C898 File Offset: 0x0033AA98
		public static ISphereTriggerShape GetRootAsISphereTriggerShape(ByteBuffer _bb, ISphereTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A1D RID: 92701 RVA: 0x0033C8B5 File Offset: 0x0033AAB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A1E RID: 92702 RVA: 0x0033C8C4 File Offset: 0x0033AAC4
		public ISphereTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FFD RID: 28669
		// (get) Token: 0x06016A1F RID: 92703 RVA: 0x0033C8D4 File Offset: 0x0033AAD4
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

		// Token: 0x17006FFE RID: 28670
		// (get) Token: 0x06016A20 RID: 92704 RVA: 0x0033C910 File Offset: 0x0033AB10
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

		// Token: 0x17006FFF RID: 28671
		// (get) Token: 0x06016A21 RID: 92705 RVA: 0x0033C970 File Offset: 0x0033AB70
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

		// Token: 0x06016A22 RID: 92706 RVA: 0x0033C9AC File Offset: 0x0033ABAC
		public static Offset<ISphereTriggerShape> CreateISphereTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(3);
			ISphereTriggerShape.AddRadius(builder, Radius);
			ISphereTriggerShape.AddCenter(builder, CenterOffset);
			ISphereTriggerShape.AddType(builder, Type);
			return ISphereTriggerShape.EndISphereTriggerShape(builder);
		}

		// Token: 0x06016A23 RID: 92707 RVA: 0x0033C9D0 File Offset: 0x0033ABD0
		public static void StartISphereTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016A24 RID: 92708 RVA: 0x0033C9D9 File Offset: 0x0033ABD9
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A25 RID: 92709 RVA: 0x0033C9E4 File Offset: 0x0033ABE4
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016A26 RID: 92710 RVA: 0x0033C9F4 File Offset: 0x0033ABF4
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06016A27 RID: 92711 RVA: 0x0033C9FF File Offset: 0x0033ABFF
		public static Offset<ISphereTriggerShape> EndISphereTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ISphereTriggerShape>(builder.EndTable());
		}

		// Token: 0x06016A28 RID: 92712 RVA: 0x0033CA0C File Offset: 0x0033AC0C
		public ISphereTriggerShapeT UnPack()
		{
			ISphereTriggerShapeT sphereTriggerShapeT = new ISphereTriggerShapeT();
			this.UnPackTo(sphereTriggerShapeT);
			return sphereTriggerShapeT;
		}

		// Token: 0x06016A29 RID: 92713 RVA: 0x0033CA28 File Offset: 0x0033AC28
		public void UnPackTo(ISphereTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06016A2A RID: 92714 RVA: 0x0033CA7C File Offset: 0x0033AC7C
		public static Offset<ISphereTriggerShape> Pack(FlatBufferBuilder builder, ISphereTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ISphereTriggerShape.CreateISphereTriggerShape(builder, _o.Type, centerOffset, _o.Radius);
		}

		// Token: 0x0400BBDB RID: 48091
		private Table __p;
	}
}
