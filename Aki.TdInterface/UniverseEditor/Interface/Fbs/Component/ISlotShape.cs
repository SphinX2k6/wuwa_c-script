using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593B RID: 22843
	public struct ISlotShape : IFlatbufferObject
	{
		// Token: 0x1700AB77 RID: 43895
		// (get) Token: 0x06026A74 RID: 158324 RVA: 0x00552D20 File Offset: 0x00550F20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A75 RID: 158325 RVA: 0x00552D2D File Offset: 0x00550F2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A76 RID: 158326 RVA: 0x00552D34 File Offset: 0x00550F34
		public static ISlotShape GetRootAsISlotShape(ByteBuffer _bb)
		{
			return ISlotShape.GetRootAsISlotShape(_bb, default(ISlotShape));
		}

		// Token: 0x06026A77 RID: 158327 RVA: 0x00552D50 File Offset: 0x00550F50
		public static ISlotShape GetRootAsISlotShape(ByteBuffer _bb, ISlotShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A78 RID: 158328 RVA: 0x00552D6D File Offset: 0x00550F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A79 RID: 158329 RVA: 0x00552D7C File Offset: 0x00550F7C
		public ISlotShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB78 RID: 43896
		// (get) Token: 0x06026A7A RID: 158330 RVA: 0x00552D8C File Offset: 0x00550F8C
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

		// Token: 0x1700AB79 RID: 43897
		// (get) Token: 0x06026A7B RID: 158331 RVA: 0x00552DEC File Offset: 0x00550FEC
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

		// Token: 0x1700AB7A RID: 43898
		// (get) Token: 0x06026A7C RID: 158332 RVA: 0x00552E4C File Offset: 0x0055104C
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

		// Token: 0x06026A7D RID: 158333 RVA: 0x00552EA9 File Offset: 0x005510A9
		public static Offset<ISlotShape> CreateISlotShape(FlatBufferBuilder builder, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISlotShape.AddRotator(builder, RotatorOffset);
			ISlotShape.AddSize(builder, SizeOffset);
			ISlotShape.AddCenter(builder, CenterOffset);
			return ISlotShape.EndISlotShape(builder);
		}

		// Token: 0x06026A7E RID: 158334 RVA: 0x00552ECD File Offset: 0x005510CD
		public static void StartISlotShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026A7F RID: 158335 RVA: 0x00552ED6 File Offset: 0x005510D6
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(0, centerOffset.Value, 0);
		}

		// Token: 0x06026A80 RID: 158336 RVA: 0x00552EE6 File Offset: 0x005510E6
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(1, sizeOffset.Value, 0);
		}

		// Token: 0x06026A81 RID: 158337 RVA: 0x00552EF6 File Offset: 0x005510F6
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(2, rotatorOffset.Value, 0);
		}

		// Token: 0x06026A82 RID: 158338 RVA: 0x00552F06 File Offset: 0x00551106
		public static Offset<ISlotShape> EndISlotShape(FlatBufferBuilder builder)
		{
			return new Offset<ISlotShape>(builder.EndTable());
		}

		// Token: 0x06026A83 RID: 158339 RVA: 0x00552F14 File Offset: 0x00551114
		public ISlotShapeT UnPack()
		{
			ISlotShapeT slotShapeT = new ISlotShapeT();
			this.UnPackTo(slotShapeT);
			return slotShapeT;
		}

		// Token: 0x06026A84 RID: 158340 RVA: 0x00552F30 File Offset: 0x00551130
		public void UnPackTo(ISlotShapeT _o)
		{
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x06026A85 RID: 158341 RVA: 0x00552FCC File Offset: 0x005511CC
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

		// Token: 0x0400EF0C RID: 61196
		private Table __p;
	}
}
