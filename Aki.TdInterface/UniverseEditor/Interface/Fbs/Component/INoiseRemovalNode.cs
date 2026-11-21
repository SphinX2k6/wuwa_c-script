using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA6 RID: 23462
	public struct INoiseRemovalNode : IFlatbufferObject
	{
		// Token: 0x1700AB83 RID: 43907
		// (get) Token: 0x06026ADB RID: 158427 RVA: 0x0054BA3E File Offset: 0x00549C3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026ADC RID: 158428 RVA: 0x0054BA4B File Offset: 0x00549C4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026ADD RID: 158429 RVA: 0x0054BA54 File Offset: 0x00549C54
		public static INoiseRemovalNode GetRootAsINoiseRemovalNode(ByteBuffer _bb)
		{
			return INoiseRemovalNode.GetRootAsINoiseRemovalNode(_bb, default(INoiseRemovalNode));
		}

		// Token: 0x06026ADE RID: 158430 RVA: 0x0054BA70 File Offset: 0x00549C70
		public static INoiseRemovalNode GetRootAsINoiseRemovalNode(ByteBuffer _bb, INoiseRemovalNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026ADF RID: 158431 RVA: 0x0054BA8D File Offset: 0x00549C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026AE0 RID: 158432 RVA: 0x0054BA9C File Offset: 0x00549C9C
		public INoiseRemovalNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB84 RID: 43908
		// (get) Token: 0x06026AE1 RID: 158433 RVA: 0x0054BAAC File Offset: 0x00549CAC
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

		// Token: 0x1700AB85 RID: 43909
		// (get) Token: 0x06026AE2 RID: 158434 RVA: 0x0054BAE8 File Offset: 0x00549CE8
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

		// Token: 0x06026AE3 RID: 158435 RVA: 0x0054BB45 File Offset: 0x00549D45
		public static Offset<INoiseRemovalNode> CreateINoiseRemovalNode(FlatBufferBuilder builder, ENoiseRemovalColor Color = ENoiseRemovalColor.Red, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			INoiseRemovalNode.AddPosition(builder, PositionOffset);
			INoiseRemovalNode.AddColor(builder, Color);
			return INoiseRemovalNode.EndINoiseRemovalNode(builder);
		}

		// Token: 0x06026AE4 RID: 158436 RVA: 0x0054BB62 File Offset: 0x00549D62
		public static void StartINoiseRemovalNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026AE5 RID: 158437 RVA: 0x0054BB6B File Offset: 0x00549D6B
		public static void AddColor(FlatBufferBuilder builder, ENoiseRemovalColor color)
		{
			builder.AddByte(0, (byte)color, 0);
		}

		// Token: 0x06026AE6 RID: 158438 RVA: 0x0054BB76 File Offset: 0x00549D76
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06026AE7 RID: 158439 RVA: 0x0054BB86 File Offset: 0x00549D86
		public static Offset<INoiseRemovalNode> EndINoiseRemovalNode(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalNode>(builder.EndTable());
		}

		// Token: 0x06026AE8 RID: 158440 RVA: 0x0054BB94 File Offset: 0x00549D94
		public INoiseRemovalNodeT UnPack()
		{
			INoiseRemovalNodeT noiseRemovalNodeT = new INoiseRemovalNodeT();
			this.UnPackTo(noiseRemovalNodeT);
			return noiseRemovalNodeT;
		}

		// Token: 0x06026AE9 RID: 158441 RVA: 0x0054BBB0 File Offset: 0x00549DB0
		public void UnPackTo(INoiseRemovalNodeT _o)
		{
			_o.Color = this.Color;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06026AEA RID: 158442 RVA: 0x0054BBF8 File Offset: 0x00549DF8
		public static Offset<INoiseRemovalNode> Pack(FlatBufferBuilder builder, INoiseRemovalNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalNode>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return INoiseRemovalNode.CreateINoiseRemovalNode(builder, _o.Color, positionOffset);
		}

		// Token: 0x0400F5EB RID: 62955
		private Table __p;
	}
}
