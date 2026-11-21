using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CE RID: 21966
	public struct ICylinder : IFlatbufferObject
	{
		// Token: 0x17009D3D RID: 40253
		// (get) Token: 0x06022F23 RID: 143139 RVA: 0x004CF69C File Offset: 0x004CD89C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F24 RID: 143140 RVA: 0x004CF6A9 File Offset: 0x004CD8A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F25 RID: 143141 RVA: 0x004CF6B0 File Offset: 0x004CD8B0
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb)
		{
			return ICylinder.GetRootAsICylinder(_bb, default(ICylinder));
		}

		// Token: 0x06022F26 RID: 143142 RVA: 0x004CF6CC File Offset: 0x004CD8CC
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb, ICylinder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F27 RID: 143143 RVA: 0x004CF6E9 File Offset: 0x004CD8E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F28 RID: 143144 RVA: 0x004CF6F8 File Offset: 0x004CD8F8
		public ICylinder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D3E RID: 40254
		// (get) Token: 0x06022F29 RID: 143145 RVA: 0x004CF708 File Offset: 0x004CD908
		public bool IsUse
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D3F RID: 40255
		// (get) Token: 0x06022F2A RID: 143146 RVA: 0x004CF748 File Offset: 0x004CD948
		public int Radius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D40 RID: 40256
		// (get) Token: 0x06022F2B RID: 143147 RVA: 0x004CF784 File Offset: 0x004CD984
		public int Height
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

		// Token: 0x17009D41 RID: 40257
		// (get) Token: 0x06022F2C RID: 143148 RVA: 0x004CF7C0 File Offset: 0x004CD9C0
		public IPosA? CylinderPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022F2D RID: 143149 RVA: 0x004CF81E File Offset: 0x004CDA1E
		public static Offset<ICylinder> CreateICylinder(FlatBufferBuilder builder, bool IsUse = false, int Radius = 0, int Height = 0, Offset<IPosA> CylinderPosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(4);
			ICylinder.AddCylinderPos(builder, CylinderPosOffset);
			ICylinder.AddHeight(builder, Height);
			ICylinder.AddRadius(builder, Radius);
			ICylinder.AddIsUse(builder, IsUse);
			return ICylinder.EndICylinder(builder);
		}

		// Token: 0x06022F2E RID: 143150 RVA: 0x004CF84A File Offset: 0x004CDA4A
		public static void StartICylinder(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022F2F RID: 143151 RVA: 0x004CF853 File Offset: 0x004CDA53
		public static void AddIsUse(FlatBufferBuilder builder, bool isUse)
		{
			builder.AddBool(0, isUse, false);
		}

		// Token: 0x06022F30 RID: 143152 RVA: 0x004CF85E File Offset: 0x004CDA5E
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06022F31 RID: 143153 RVA: 0x004CF869 File Offset: 0x004CDA69
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(2, height, 0);
		}

		// Token: 0x06022F32 RID: 143154 RVA: 0x004CF874 File Offset: 0x004CDA74
		public static void AddCylinderPos(FlatBufferBuilder builder, Offset<IPosA> cylinderPosOffset)
		{
			builder.AddOffset(3, cylinderPosOffset.Value, 0);
		}

		// Token: 0x06022F33 RID: 143155 RVA: 0x004CF884 File Offset: 0x004CDA84
		public static Offset<ICylinder> EndICylinder(FlatBufferBuilder builder)
		{
			return new Offset<ICylinder>(builder.EndTable());
		}

		// Token: 0x06022F34 RID: 143156 RVA: 0x004CF894 File Offset: 0x004CDA94
		public ICylinderT UnPack()
		{
			ICylinderT cylinderT = new ICylinderT();
			this.UnPackTo(cylinderT);
			return cylinderT;
		}

		// Token: 0x06022F35 RID: 143157 RVA: 0x004CF8B0 File Offset: 0x004CDAB0
		public void UnPackTo(ICylinderT _o)
		{
			_o.IsUse = this.IsUse;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.CylinderPos = ((this.CylinderPos != null) ? this.CylinderPos.Value.UnPack() : null);
		}

		// Token: 0x06022F36 RID: 143158 RVA: 0x004CF910 File Offset: 0x004CDB10
		public static Offset<ICylinder> Pack(FlatBufferBuilder builder, ICylinderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinder>);
			}
			Offset<IPosA> cylinderPosOffset = (_o.CylinderPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.CylinderPos);
			return ICylinder.CreateICylinder(builder, _o.IsUse, _o.Radius, _o.Height, cylinderPosOffset);
		}

		// Token: 0x0400EC64 RID: 60516
		private Table __p;
	}
}
