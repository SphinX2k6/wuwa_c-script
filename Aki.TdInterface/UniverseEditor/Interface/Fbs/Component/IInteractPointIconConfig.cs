using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005467 RID: 21607
	public struct IInteractPointIconConfig : IFlatbufferObject
	{
		// Token: 0x17009F12 RID: 40722
		// (get) Token: 0x060238B5 RID: 145589 RVA: 0x004EA9B0 File Offset: 0x004E8BB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238B6 RID: 145590 RVA: 0x004EA9BD File Offset: 0x004E8BBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238B7 RID: 145591 RVA: 0x004EA9C4 File Offset: 0x004E8BC4
		public static IInteractPointIconConfig GetRootAsIInteractPointIconConfig(ByteBuffer _bb)
		{
			return IInteractPointIconConfig.GetRootAsIInteractPointIconConfig(_bb, default(IInteractPointIconConfig));
		}

		// Token: 0x060238B8 RID: 145592 RVA: 0x004EA9E0 File Offset: 0x004E8BE0
		public static IInteractPointIconConfig GetRootAsIInteractPointIconConfig(ByteBuffer _bb, IInteractPointIconConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238B9 RID: 145593 RVA: 0x004EA9FD File Offset: 0x004E8BFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238BA RID: 145594 RVA: 0x004EAA0C File Offset: 0x004E8C0C
		public IInteractPointIconConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F13 RID: 40723
		// (get) Token: 0x060238BB RID: 145595 RVA: 0x004EAA1C File Offset: 0x004E8C1C
		public float MaxShowDistance
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F14 RID: 40724
		// (get) Token: 0x060238BC RID: 145596 RVA: 0x004EAA5C File Offset: 0x004E8C5C
		public IVectorInfo? Offset
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

		// Token: 0x060238BD RID: 145597 RVA: 0x004EAAB9 File Offset: 0x004E8CB9
		public static Offset<IInteractPointIconConfig> CreateIInteractPointIconConfig(FlatBufferBuilder builder, float MaxShowDistance = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IInteractPointIconConfig.AddOffset(builder, OffsetOffset);
			IInteractPointIconConfig.AddMaxShowDistance(builder, MaxShowDistance);
			return IInteractPointIconConfig.EndIInteractPointIconConfig(builder);
		}

		// Token: 0x060238BE RID: 145598 RVA: 0x004EAAD6 File Offset: 0x004E8CD6
		public static void StartIInteractPointIconConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060238BF RID: 145599 RVA: 0x004EAADF File Offset: 0x004E8CDF
		public static void AddMaxShowDistance(FlatBufferBuilder builder, float maxShowDistance)
		{
			builder.AddFloat(0, maxShowDistance, 0.0);
		}

		// Token: 0x060238C0 RID: 145600 RVA: 0x004EAAF2 File Offset: 0x004E8CF2
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060238C1 RID: 145601 RVA: 0x004EAB02 File Offset: 0x004E8D02
		public static Offset<IInteractPointIconConfig> EndIInteractPointIconConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPointIconConfig>(builder.EndTable());
		}

		// Token: 0x060238C2 RID: 145602 RVA: 0x004EAB10 File Offset: 0x004E8D10
		public IInteractPointIconConfigT UnPack()
		{
			IInteractPointIconConfigT interactPointIconConfigT = new IInteractPointIconConfigT();
			this.UnPackTo(interactPointIconConfigT);
			return interactPointIconConfigT;
		}

		// Token: 0x060238C3 RID: 145603 RVA: 0x004EAB2C File Offset: 0x004E8D2C
		public void UnPackTo(IInteractPointIconConfigT _o)
		{
			_o.MaxShowDistance = this.MaxShowDistance;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x060238C4 RID: 145604 RVA: 0x004EAB74 File Offset: 0x004E8D74
		public static Offset<IInteractPointIconConfig> Pack(FlatBufferBuilder builder, IInteractPointIconConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPointIconConfig>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IInteractPointIconConfig.CreateIInteractPointIconConfig(builder, _o.MaxShowDistance, offsetOffset);
		}

		// Token: 0x0400E6E3 RID: 59107
		private Table __p;
	}
}
