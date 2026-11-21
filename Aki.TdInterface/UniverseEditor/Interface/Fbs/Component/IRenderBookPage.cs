using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E48 RID: 24136
	public struct IRenderBookPage : IFlatbufferObject
	{
		// Token: 0x1700B1EB RID: 45547
		// (get) Token: 0x06028542 RID: 165186 RVA: 0x00583783 File Offset: 0x00581983
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028543 RID: 165187 RVA: 0x00583790 File Offset: 0x00581990
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028544 RID: 165188 RVA: 0x00583798 File Offset: 0x00581998
		public static IRenderBookPage GetRootAsIRenderBookPage(ByteBuffer _bb)
		{
			return IRenderBookPage.GetRootAsIRenderBookPage(_bb, default(IRenderBookPage));
		}

		// Token: 0x06028545 RID: 165189 RVA: 0x005837B4 File Offset: 0x005819B4
		public static IRenderBookPage GetRootAsIRenderBookPage(ByteBuffer _bb, IRenderBookPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028546 RID: 165190 RVA: 0x005837D1 File Offset: 0x005819D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028547 RID: 165191 RVA: 0x005837E0 File Offset: 0x005819E0
		public IRenderBookPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1EC RID: 45548
		// (get) Token: 0x06028548 RID: 165192 RVA: 0x005837F0 File Offset: 0x005819F0
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B1ED RID: 45549
		// (get) Token: 0x06028549 RID: 165193 RVA: 0x0058382C File Offset: 0x00581A2C
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

		// Token: 0x1700B1EE RID: 45550
		// (get) Token: 0x0602854A RID: 165194 RVA: 0x00583868 File Offset: 0x00581A68
		public TTargetEntity CenterTargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602854B RID: 165195 RVA: 0x005838A4 File Offset: 0x00581AA4
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602854C RID: 165196 RVA: 0x005838EC File Offset: 0x00581AEC
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602854D RID: 165197 RVA: 0x00583908 File Offset: 0x00581B08
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602854E RID: 165198 RVA: 0x00583924 File Offset: 0x00581B24
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602854F RID: 165199 RVA: 0x00583940 File Offset: 0x00581B40
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x06028550 RID: 165200 RVA: 0x0058395C File Offset: 0x00581B5C
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700B1EF RID: 45551
		// (get) Token: 0x06028551 RID: 165201 RVA: 0x00583978 File Offset: 0x00581B78
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028552 RID: 165202 RVA: 0x005839B0 File Offset: 0x00581BB0
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06028553 RID: 165203 RVA: 0x005839C0 File Offset: 0x00581BC0
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06028554 RID: 165204 RVA: 0x005839CF File Offset: 0x00581BCF
		public static Offset<IRenderBookPage> CreateIRenderBookPage(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, int Radius = 0, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IRenderBookPage.AddAkEvent(builder, AkEventOffset);
			IRenderBookPage.AddCenterTarget(builder, CenterTargetOffset);
			IRenderBookPage.AddRadius(builder, Radius);
			IRenderBookPage.AddCenterTargetType(builder, CenterTarget_type);
			IRenderBookPage.AddType(builder, Type);
			return IRenderBookPage.EndIRenderBookPage(builder);
		}

		// Token: 0x06028555 RID: 165205 RVA: 0x00583A03 File Offset: 0x00581C03
		public static void StartIRenderBookPage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028556 RID: 165206 RVA: 0x00583A0C File Offset: 0x00581C0C
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028557 RID: 165207 RVA: 0x00583A17 File Offset: 0x00581C17
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06028558 RID: 165208 RVA: 0x00583A22 File Offset: 0x00581C22
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(2, (byte)centerTargetType, 0);
		}

		// Token: 0x06028559 RID: 165209 RVA: 0x00583A2D File Offset: 0x00581C2D
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(3, centerTargetOffset, 0);
		}

		// Token: 0x0602855A RID: 165210 RVA: 0x00583A38 File Offset: 0x00581C38
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(4, akEventOffset.Value, 0);
		}

		// Token: 0x0602855B RID: 165211 RVA: 0x00583A48 File Offset: 0x00581C48
		public static Offset<IRenderBookPage> EndIRenderBookPage(FlatBufferBuilder builder)
		{
			return new Offset<IRenderBookPage>(builder.EndTable());
		}

		// Token: 0x0602855C RID: 165212 RVA: 0x00583A58 File Offset: 0x00581C58
		public IRenderBookPageT UnPack()
		{
			IRenderBookPageT renderBookPageT = new IRenderBookPageT();
			this.UnPackTo(renderBookPageT);
			return renderBookPageT;
		}

		// Token: 0x0602855D RID: 165213 RVA: 0x00583A74 File Offset: 0x00581C74
		public void UnPackTo(IRenderBookPageT _o)
		{
			_o.Type = this.Type;
			_o.Radius = this.Radius;
			_o.CenterTarget = new TTargetEntityUnion();
			_o.CenterTarget.Type = this.CenterTargetType;
			switch (this.CenterTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IPlayerEntity>() != null) ? this.CenterTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ISelfEntity>() != null) ? this.CenterTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITargetEntity>() != null) ? this.CenterTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITriggeredEntity>() != null) ? this.CenterTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IVehicleEntity>() != null) ? this.CenterTarget<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x0602855E RID: 165214 RVA: 0x00583C08 File Offset: 0x00581E08
		public static Offset<IRenderBookPage> Pack(FlatBufferBuilder builder, IRenderBookPageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderBookPage>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IRenderBookPage.CreateIRenderBookPage(builder, _o.Type, _o.Radius, centerTarget_type, centerTargetOffset, akEventOffset);
		}

		// Token: 0x0400FA47 RID: 64071
		private Table __p;
	}
}
