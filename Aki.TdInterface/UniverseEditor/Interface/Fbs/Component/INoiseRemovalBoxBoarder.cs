using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA0 RID: 23456
	public struct INoiseRemovalBoxBoarder : IFlatbufferObject
	{
		// Token: 0x1700AB6F RID: 43887
		// (get) Token: 0x06026A8F RID: 158351 RVA: 0x0054AF00 File Offset: 0x00549100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A90 RID: 158352 RVA: 0x0054AF0D File Offset: 0x0054910D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A91 RID: 158353 RVA: 0x0054AF14 File Offset: 0x00549114
		public static INoiseRemovalBoxBoarder GetRootAsINoiseRemovalBoxBoarder(ByteBuffer _bb)
		{
			return INoiseRemovalBoxBoarder.GetRootAsINoiseRemovalBoxBoarder(_bb, default(INoiseRemovalBoxBoarder));
		}

		// Token: 0x06026A92 RID: 158354 RVA: 0x0054AF30 File Offset: 0x00549130
		public static INoiseRemovalBoxBoarder GetRootAsINoiseRemovalBoxBoarder(ByteBuffer _bb, INoiseRemovalBoxBoarder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A93 RID: 158355 RVA: 0x0054AF4D File Offset: 0x0054914D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A94 RID: 158356 RVA: 0x0054AF5C File Offset: 0x0054915C
		public INoiseRemovalBoxBoarder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB70 RID: 43888
		// (get) Token: 0x06026A95 RID: 158357 RVA: 0x0054AF6C File Offset: 0x0054916C
		public ENoiseRemovalBoarderShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return (ENoiseRemovalBoarderShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB71 RID: 43889
		// (get) Token: 0x06026A96 RID: 158358 RVA: 0x0054AFA8 File Offset: 0x005491A8
		public IVectorInfo? BoxExtendPositive
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

		// Token: 0x1700AB72 RID: 43890
		// (get) Token: 0x06026A97 RID: 158359 RVA: 0x0054B008 File Offset: 0x00549208
		public IVectorInfo? BoxExtendNegative
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

		// Token: 0x06026A98 RID: 158360 RVA: 0x0054B065 File Offset: 0x00549265
		public static Offset<INoiseRemovalBoxBoarder> CreateINoiseRemovalBoxBoarder(FlatBufferBuilder builder, ENoiseRemovalBoarderShape Type = ENoiseRemovalBoarderShape.Box, Offset<IVectorInfo> BoxExtendPositiveOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> BoxExtendNegativeOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			INoiseRemovalBoxBoarder.AddBoxExtendNegative(builder, BoxExtendNegativeOffset);
			INoiseRemovalBoxBoarder.AddBoxExtendPositive(builder, BoxExtendPositiveOffset);
			INoiseRemovalBoxBoarder.AddType(builder, Type);
			return INoiseRemovalBoxBoarder.EndINoiseRemovalBoxBoarder(builder);
		}

		// Token: 0x06026A99 RID: 158361 RVA: 0x0054B089 File Offset: 0x00549289
		public static void StartINoiseRemovalBoxBoarder(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026A9A RID: 158362 RVA: 0x0054B092 File Offset: 0x00549292
		public static void AddType(FlatBufferBuilder builder, ENoiseRemovalBoarderShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026A9B RID: 158363 RVA: 0x0054B09D File Offset: 0x0054929D
		public static void AddBoxExtendPositive(FlatBufferBuilder builder, Offset<IVectorInfo> boxExtendPositiveOffset)
		{
			builder.AddOffset(1, boxExtendPositiveOffset.Value, 0);
		}

		// Token: 0x06026A9C RID: 158364 RVA: 0x0054B0AD File Offset: 0x005492AD
		public static void AddBoxExtendNegative(FlatBufferBuilder builder, Offset<IVectorInfo> boxExtendNegativeOffset)
		{
			builder.AddOffset(2, boxExtendNegativeOffset.Value, 0);
		}

		// Token: 0x06026A9D RID: 158365 RVA: 0x0054B0BD File Offset: 0x005492BD
		public static Offset<INoiseRemovalBoxBoarder> EndINoiseRemovalBoxBoarder(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalBoxBoarder>(builder.EndTable());
		}

		// Token: 0x06026A9E RID: 158366 RVA: 0x0054B0CC File Offset: 0x005492CC
		public INoiseRemovalBoxBoarderT UnPack()
		{
			INoiseRemovalBoxBoarderT noiseRemovalBoxBoarderT = new INoiseRemovalBoxBoarderT();
			this.UnPackTo(noiseRemovalBoxBoarderT);
			return noiseRemovalBoxBoarderT;
		}

		// Token: 0x06026A9F RID: 158367 RVA: 0x0054B0E8 File Offset: 0x005492E8
		public void UnPackTo(INoiseRemovalBoxBoarderT _o)
		{
			_o.Type = this.Type;
			_o.BoxExtendPositive = ((this.BoxExtendPositive != null) ? this.BoxExtendPositive.Value.UnPack() : null);
			_o.BoxExtendNegative = ((this.BoxExtendNegative != null) ? this.BoxExtendNegative.Value.UnPack() : null);
		}

		// Token: 0x06026AA0 RID: 158368 RVA: 0x0054B160 File Offset: 0x00549360
		public static Offset<INoiseRemovalBoxBoarder> Pack(FlatBufferBuilder builder, INoiseRemovalBoxBoarderT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalBoxBoarder>);
			}
			Offset<IVectorInfo> boxExtendPositiveOffset = (_o.BoxExtendPositive == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BoxExtendPositive);
			Offset<IVectorInfo> boxExtendNegativeOffset = (_o.BoxExtendNegative == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BoxExtendNegative);
			return INoiseRemovalBoxBoarder.CreateINoiseRemovalBoxBoarder(builder, _o.Type, boxExtendPositiveOffset, boxExtendNegativeOffset);
		}

		// Token: 0x0400F5E0 RID: 62944
		private Table __p;
	}
}
