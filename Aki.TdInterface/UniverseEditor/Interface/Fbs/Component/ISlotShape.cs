using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F48 RID: 24392
	public struct ISlotShape : IFlatbufferObject
	{
		// Token: 0x1700B4AB RID: 46251
		// (get) Token: 0x06028FDE RID: 167902 RVA: 0x0059998C File Offset: 0x00597B8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028FDF RID: 167903 RVA: 0x00599999 File Offset: 0x00597B99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028FE0 RID: 167904 RVA: 0x005999A0 File Offset: 0x00597BA0
		public static ISlotShape GetRootAsISlotShape(ByteBuffer _bb)
		{
			return ISlotShape.GetRootAsISlotShape(_bb, default(ISlotShape));
		}

		// Token: 0x06028FE1 RID: 167905 RVA: 0x005999BC File Offset: 0x00597BBC
		public static ISlotShape GetRootAsISlotShape(ByteBuffer _bb, ISlotShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028FE2 RID: 167906 RVA: 0x005999D9 File Offset: 0x00597BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028FE3 RID: 167907 RVA: 0x005999E8 File Offset: 0x00597BE8
		public ISlotShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4AC RID: 46252
		// (get) Token: 0x06028FE4 RID: 167908 RVA: 0x005999F8 File Offset: 0x00597BF8
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B4AD RID: 46253
		// (get) Token: 0x06028FE5 RID: 167909 RVA: 0x00599A58 File Offset: 0x00597C58
		public IVectorInfo? Size
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

		// Token: 0x1700B4AE RID: 46254
		// (get) Token: 0x06028FE6 RID: 167910 RVA: 0x00599AB8 File Offset: 0x00597CB8
		public IVectorInfo? Rotator
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

		// Token: 0x06028FE7 RID: 167911 RVA: 0x00599B15 File Offset: 0x00597D15
		public static Offset<ISlotShape> CreateISlotShape(FlatBufferBuilder builder, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISlotShape.AddRotator(builder, RotatorOffset);
			ISlotShape.AddSize(builder, SizeOffset);
			ISlotShape.AddCenter(builder, CenterOffset);
			return ISlotShape.EndISlotShape(builder);
		}

		// Token: 0x06028FE8 RID: 167912 RVA: 0x00599B39 File Offset: 0x00597D39
		public static void StartISlotShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028FE9 RID: 167913 RVA: 0x00599B42 File Offset: 0x00597D42
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(0, centerOffset.Value, 0);
		}

		// Token: 0x06028FEA RID: 167914 RVA: 0x00599B52 File Offset: 0x00597D52
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(1, sizeOffset.Value, 0);
		}

		// Token: 0x06028FEB RID: 167915 RVA: 0x00599B62 File Offset: 0x00597D62
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(2, rotatorOffset.Value, 0);
		}

		// Token: 0x06028FEC RID: 167916 RVA: 0x00599B72 File Offset: 0x00597D72
		public static Offset<ISlotShape> EndISlotShape(FlatBufferBuilder builder)
		{
			return new Offset<ISlotShape>(builder.EndTable());
		}

		// Token: 0x06028FED RID: 167917 RVA: 0x00599B80 File Offset: 0x00597D80
		public ISlotShapeT UnPack()
		{
			ISlotShapeT slotShapeT = new ISlotShapeT();
			this.UnPackTo(slotShapeT);
			return slotShapeT;
		}

		// Token: 0x06028FEE RID: 167918 RVA: 0x00599B9C File Offset: 0x00597D9C
		public void UnPackTo(ISlotShapeT _o)
		{
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x06028FEF RID: 167919 RVA: 0x00599C38 File Offset: 0x00597E38
		public static Offset<ISlotShape> Pack(FlatBufferBuilder builder, ISlotShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlotShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return ISlotShape.CreateISlotShape(builder, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400FC01 RID: 64513
		private Table __p;
	}
}
