using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005608 RID: 22024
	public struct INoiseRemovalNode : IFlatbufferObject
	{
		// Token: 0x1700A2FB RID: 41723
		// (get) Token: 0x060248CB RID: 149707 RVA: 0x0050B426 File Offset: 0x00509626
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060248CC RID: 149708 RVA: 0x0050B433 File Offset: 0x00509633
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060248CD RID: 149709 RVA: 0x0050B43C File Offset: 0x0050963C
		public static INoiseRemovalNode GetRootAsINoiseRemovalNode(ByteBuffer _bb)
		{
			return INoiseRemovalNode.GetRootAsINoiseRemovalNode(_bb, default(INoiseRemovalNode));
		}

		// Token: 0x060248CE RID: 149710 RVA: 0x0050B458 File Offset: 0x00509658
		public static INoiseRemovalNode GetRootAsINoiseRemovalNode(ByteBuffer _bb, INoiseRemovalNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060248CF RID: 149711 RVA: 0x0050B475 File Offset: 0x00509675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060248D0 RID: 149712 RVA: 0x0050B484 File Offset: 0x00509684
		public INoiseRemovalNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2FC RID: 41724
		// (get) Token: 0x060248D1 RID: 149713 RVA: 0x0050B494 File Offset: 0x00509694
		public ENoiseRemovalColor Color
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalColor.Red;
				}
				return (ENoiseRemovalColor)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2FD RID: 41725
		// (get) Token: 0x060248D2 RID: 149714 RVA: 0x0050B4D0 File Offset: 0x005096D0
		public IVectorInfo? Position
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

		// Token: 0x060248D3 RID: 149715 RVA: 0x0050B52D File Offset: 0x0050972D
		public static Offset<INoiseRemovalNode> CreateINoiseRemovalNode(FlatBufferBuilder builder, ENoiseRemovalColor Color = ENoiseRemovalColor.Red, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			INoiseRemovalNode.AddPosition(builder, PositionOffset);
			INoiseRemovalNode.AddColor(builder, Color);
			return INoiseRemovalNode.EndINoiseRemovalNode(builder);
		}

		// Token: 0x060248D4 RID: 149716 RVA: 0x0050B54A File Offset: 0x0050974A
		public static void StartINoiseRemovalNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060248D5 RID: 149717 RVA: 0x0050B553 File Offset: 0x00509753
		public static void AddColor(FlatBufferBuilder builder, ENoiseRemovalColor color)
		{
			builder.AddByte(0, (byte)color, 0);
		}

		// Token: 0x060248D6 RID: 149718 RVA: 0x0050B55E File Offset: 0x0050975E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x060248D7 RID: 149719 RVA: 0x0050B56E File Offset: 0x0050976E
		public static Offset<INoiseRemovalNode> EndINoiseRemovalNode(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalNode>(builder.EndTable());
		}

		// Token: 0x060248D8 RID: 149720 RVA: 0x0050B57C File Offset: 0x0050977C
		public INoiseRemovalNodeT UnPack()
		{
			INoiseRemovalNodeT noiseRemovalNodeT = new INoiseRemovalNodeT();
			this.UnPackTo(noiseRemovalNodeT);
			return noiseRemovalNodeT;
		}

		// Token: 0x060248D9 RID: 149721 RVA: 0x0050B598 File Offset: 0x00509798
		public void UnPackTo(INoiseRemovalNodeT _o)
		{
			_o.Color = this.Color;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x060248DA RID: 149722 RVA: 0x0050B5E0 File Offset: 0x005097E0
		public static Offset<INoiseRemovalNode> Pack(FlatBufferBuilder builder, INoiseRemovalNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalNode>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return INoiseRemovalNode.CreateINoiseRemovalNode(builder, _o.Color, positionOffset);
		}

		// Token: 0x0400E988 RID: 59784
		private Table __p;
	}
}
