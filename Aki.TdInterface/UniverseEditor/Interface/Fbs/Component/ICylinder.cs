using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200506C RID: 20588
	public struct ICylinder : IFlatbufferObject
	{
		// Token: 0x17009557 RID: 38231
		// (get) Token: 0x06020FE9 RID: 135145 RVA: 0x004959E8 File Offset: 0x00493BE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020FEA RID: 135146 RVA: 0x004959F5 File Offset: 0x00493BF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020FEB RID: 135147 RVA: 0x004959FC File Offset: 0x00493BFC
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb)
		{
			return ICylinder.GetRootAsICylinder(_bb, default(ICylinder));
		}

		// Token: 0x06020FEC RID: 135148 RVA: 0x00495A18 File Offset: 0x00493C18
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb, ICylinder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020FED RID: 135149 RVA: 0x00495A35 File Offset: 0x00493C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FEE RID: 135150 RVA: 0x00495A44 File Offset: 0x00493C44
		public ICylinder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009558 RID: 38232
		// (get) Token: 0x06020FEF RID: 135151 RVA: 0x00495A54 File Offset: 0x00493C54
		public bool IsUse
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009559 RID: 38233
		// (get) Token: 0x06020FF0 RID: 135152 RVA: 0x00495A94 File Offset: 0x00493C94
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

		// Token: 0x1700955A RID: 38234
		// (get) Token: 0x06020FF1 RID: 135153 RVA: 0x00495AD0 File Offset: 0x00493CD0
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

		// Token: 0x1700955B RID: 38235
		// (get) Token: 0x06020FF2 RID: 135154 RVA: 0x00495B0C File Offset: 0x00493D0C
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

		// Token: 0x06020FF3 RID: 135155 RVA: 0x00495B6A File Offset: 0x00493D6A
		public static Offset<ICylinder> CreateICylinder(FlatBufferBuilder builder, bool IsUse = false, int Radius = 0, int Height = 0, Offset<IPosA> CylinderPosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(4);
			ICylinder.AddCylinderPos(builder, CylinderPosOffset);
			ICylinder.AddHeight(builder, Height);
			ICylinder.AddRadius(builder, Radius);
			ICylinder.AddIsUse(builder, IsUse);
			return ICylinder.EndICylinder(builder);
		}

		// Token: 0x06020FF4 RID: 135156 RVA: 0x00495B96 File Offset: 0x00493D96
		public static void StartICylinder(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020FF5 RID: 135157 RVA: 0x00495B9F File Offset: 0x00493D9F
		public static void AddIsUse(FlatBufferBuilder builder, bool isUse)
		{
			builder.AddBool(0, isUse, false);
		}

		// Token: 0x06020FF6 RID: 135158 RVA: 0x00495BAA File Offset: 0x00493DAA
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06020FF7 RID: 135159 RVA: 0x00495BB5 File Offset: 0x00493DB5
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(2, height, 0);
		}

		// Token: 0x06020FF8 RID: 135160 RVA: 0x00495BC0 File Offset: 0x00493DC0
		public static void AddCylinderPos(FlatBufferBuilder builder, Offset<IPosA> cylinderPosOffset)
		{
			builder.AddOffset(3, cylinderPosOffset.Value, 0);
		}

		// Token: 0x06020FF9 RID: 135161 RVA: 0x00495BD0 File Offset: 0x00493DD0
		public static Offset<ICylinder> EndICylinder(FlatBufferBuilder builder)
		{
			return new Offset<ICylinder>(builder.EndTable());
		}

		// Token: 0x06020FFA RID: 135162 RVA: 0x00495BE0 File Offset: 0x00493DE0
		public ICylinderT UnPack()
		{
			ICylinderT cylinderT = new ICylinderT();
			this.UnPackTo(cylinderT);
			return cylinderT;
		}

		// Token: 0x06020FFB RID: 135163 RVA: 0x00495BFC File Offset: 0x00493DFC
		public void UnPackTo(ICylinderT _o)
		{
			_o.IsUse = this.IsUse;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.CylinderPos = ((this.CylinderPos != null) ? this.CylinderPos.Value.UnPack() : null);
		}

		// Token: 0x06020FFC RID: 135164 RVA: 0x00495C5C File Offset: 0x00493E5C
		public static Offset<ICylinder> Pack(FlatBufferBuilder builder, ICylinderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinder>);
			}
			Offset<IPosA> cylinderPosOffset = (_o.CylinderPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.CylinderPos);
			return ICylinder.CreateICylinder(builder, _o.IsUse, _o.Radius, _o.Height, cylinderPosOffset);
		}

		// Token: 0x0400E06B RID: 57451
		private Table __p;
	}
}
