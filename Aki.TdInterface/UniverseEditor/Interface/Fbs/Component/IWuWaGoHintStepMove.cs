using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBB RID: 23483
	public struct IWuWaGoHintStepMove : IFlatbufferObject
	{
		// Token: 0x1700B16B RID: 45419
		// (get) Token: 0x06028369 RID: 164713 RVA: 0x005867CD File Offset: 0x005849CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602836A RID: 164714 RVA: 0x005867DA File Offset: 0x005849DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602836B RID: 164715 RVA: 0x005867E4 File Offset: 0x005849E4
		public static IWuWaGoHintStepMove GetRootAsIWuWaGoHintStepMove(ByteBuffer _bb)
		{
			return IWuWaGoHintStepMove.GetRootAsIWuWaGoHintStepMove(_bb, default(IWuWaGoHintStepMove));
		}

		// Token: 0x0602836C RID: 164716 RVA: 0x00586800 File Offset: 0x00584A00
		public static IWuWaGoHintStepMove GetRootAsIWuWaGoHintStepMove(ByteBuffer _bb, IWuWaGoHintStepMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602836D RID: 164717 RVA: 0x0058681D File Offset: 0x00584A1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602836E RID: 164718 RVA: 0x0058682C File Offset: 0x00584A2C
		public IWuWaGoHintStepMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B16C RID: 45420
		// (get) Token: 0x0602836F RID: 164719 RVA: 0x0058683C File Offset: 0x00584A3C
		public EWuWaGoHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoHintStepType.Move;
				}
				return (EWuWaGoHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B16D RID: 45421
		// (get) Token: 0x06028370 RID: 164720 RVA: 0x00586878 File Offset: 0x00584A78
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

		// Token: 0x06028371 RID: 164721 RVA: 0x005868D5 File Offset: 0x00584AD5
		public static Offset<IWuWaGoHintStepMove> CreateIWuWaGoHintStepMove(FlatBufferBuilder builder, EWuWaGoHintStepType Type = EWuWaGoHintStepType.Move, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IWuWaGoHintStepMove.AddPosition(builder, PositionOffset);
			IWuWaGoHintStepMove.AddType(builder, Type);
			return IWuWaGoHintStepMove.EndIWuWaGoHintStepMove(builder);
		}

		// Token: 0x06028372 RID: 164722 RVA: 0x005868F2 File Offset: 0x00584AF2
		public static void StartIWuWaGoHintStepMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028373 RID: 164723 RVA: 0x005868FB File Offset: 0x00584AFB
		public static void AddType(FlatBufferBuilder builder, EWuWaGoHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028374 RID: 164724 RVA: 0x00586906 File Offset: 0x00584B06
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06028375 RID: 164725 RVA: 0x00586916 File Offset: 0x00584B16
		public static Offset<IWuWaGoHintStepMove> EndIWuWaGoHintStepMove(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoHintStepMove>(builder.EndTable());
		}

		// Token: 0x06028376 RID: 164726 RVA: 0x00586924 File Offset: 0x00584B24
		public IWuWaGoHintStepMoveT UnPack()
		{
			IWuWaGoHintStepMoveT wuWaGoHintStepMoveT = new IWuWaGoHintStepMoveT();
			this.UnPackTo(wuWaGoHintStepMoveT);
			return wuWaGoHintStepMoveT;
		}

		// Token: 0x06028377 RID: 164727 RVA: 0x00586940 File Offset: 0x00584B40
		public void UnPackTo(IWuWaGoHintStepMoveT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06028378 RID: 164728 RVA: 0x00586988 File Offset: 0x00584B88
		public static Offset<IWuWaGoHintStepMove> Pack(FlatBufferBuilder builder, IWuWaGoHintStepMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoHintStepMove>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IWuWaGoHintStepMove.CreateIWuWaGoHintStepMove(builder, _o.Type, positionOffset);
		}

		// Token: 0x0400F333 RID: 62259
		private Table __p;
	}
}
