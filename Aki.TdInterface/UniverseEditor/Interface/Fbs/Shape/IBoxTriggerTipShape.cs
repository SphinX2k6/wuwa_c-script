using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF8 RID: 15352
	public struct IBoxTriggerTipShape : IFlatbufferObject
	{
		// Token: 0x17006968 RID: 26984
		// (get) Token: 0x06015201 RID: 86529 RVA: 0x0030F8F0 File Offset: 0x0030DAF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015202 RID: 86530 RVA: 0x0030F8FD File Offset: 0x0030DAFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015203 RID: 86531 RVA: 0x0030F904 File Offset: 0x0030DB04
		public static IBoxTriggerTipShape GetRootAsIBoxTriggerTipShape(ByteBuffer _bb)
		{
			return IBoxTriggerTipShape.GetRootAsIBoxTriggerTipShape(_bb, default(IBoxTriggerTipShape));
		}

		// Token: 0x06015204 RID: 86532 RVA: 0x0030F920 File Offset: 0x0030DB20
		public static IBoxTriggerTipShape GetRootAsIBoxTriggerTipShape(ByteBuffer _bb, IBoxTriggerTipShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015205 RID: 86533 RVA: 0x0030F93D File Offset: 0x0030DB3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015206 RID: 86534 RVA: 0x0030F94C File Offset: 0x0030DB4C
		public IBoxTriggerTipShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006969 RID: 26985
		// (get) Token: 0x06015207 RID: 86535 RVA: 0x0030F95C File Offset: 0x0030DB5C
		public ETriggerTipShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerTipShape.Box;
				}
				return (ETriggerTipShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700696A RID: 26986
		// (get) Token: 0x06015208 RID: 86536 RVA: 0x0030F998 File Offset: 0x0030DB98
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

		// Token: 0x1700696B RID: 26987
		// (get) Token: 0x06015209 RID: 86537 RVA: 0x0030F9F8 File Offset: 0x0030DBF8
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

		// Token: 0x1700696C RID: 26988
		// (get) Token: 0x0601520A RID: 86538 RVA: 0x0030FA58 File Offset: 0x0030DC58
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

		// Token: 0x0601520B RID: 86539 RVA: 0x0030FAB6 File Offset: 0x0030DCB6
		public static Offset<IBoxTriggerTipShape> CreateIBoxTriggerTipShape(FlatBufferBuilder builder, ETriggerTipShape Type = ETriggerTipShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IBoxTriggerTipShape.AddRotator(builder, RotatorOffset);
			IBoxTriggerTipShape.AddSize(builder, SizeOffset);
			IBoxTriggerTipShape.AddCenter(builder, CenterOffset);
			IBoxTriggerTipShape.AddType(builder, Type);
			return IBoxTriggerTipShape.EndIBoxTriggerTipShape(builder);
		}

		// Token: 0x0601520C RID: 86540 RVA: 0x0030FAE2 File Offset: 0x0030DCE2
		public static void StartIBoxTriggerTipShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601520D RID: 86541 RVA: 0x0030FAEB File Offset: 0x0030DCEB
		public static void AddType(FlatBufferBuilder builder, ETriggerTipShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601520E RID: 86542 RVA: 0x0030FAF6 File Offset: 0x0030DCF6
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0601520F RID: 86543 RVA: 0x0030FB06 File Offset: 0x0030DD06
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(2, sizeOffset.Value, 0);
		}

		// Token: 0x06015210 RID: 86544 RVA: 0x0030FB16 File Offset: 0x0030DD16
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x06015211 RID: 86545 RVA: 0x0030FB26 File Offset: 0x0030DD26
		public static Offset<IBoxTriggerTipShape> EndIBoxTriggerTipShape(FlatBufferBuilder builder)
		{
			return new Offset<IBoxTriggerTipShape>(builder.EndTable());
		}

		// Token: 0x06015212 RID: 86546 RVA: 0x0030FB34 File Offset: 0x0030DD34
		public IBoxTriggerTipShapeT UnPack()
		{
			IBoxTriggerTipShapeT boxTriggerTipShapeT = new IBoxTriggerTipShapeT();
			this.UnPackTo(boxTriggerTipShapeT);
			return boxTriggerTipShapeT;
		}

		// Token: 0x06015213 RID: 86547 RVA: 0x0030FB50 File Offset: 0x0030DD50
		public void UnPackTo(IBoxTriggerTipShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x06015214 RID: 86548 RVA: 0x0030FBF8 File Offset: 0x0030DDF8
		public static Offset<IBoxTriggerTipShape> Pack(FlatBufferBuilder builder, IBoxTriggerTipShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxTriggerTipShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IBoxTriggerTipShape.CreateIBoxTriggerTipShape(builder, _o.Type, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400B1C7 RID: 45511
		private Table __p;
	}
}
