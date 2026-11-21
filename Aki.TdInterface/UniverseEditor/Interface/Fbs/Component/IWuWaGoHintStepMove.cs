using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D1 RID: 25041
	public struct IWuWaGoHintStepMove : IFlatbufferObject
	{
		// Token: 0x1700BAB3 RID: 47795
		// (get) Token: 0x0602A92D RID: 174381 RVA: 0x005CE25D File Offset: 0x005CC45D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A92E RID: 174382 RVA: 0x005CE26A File Offset: 0x005CC46A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A92F RID: 174383 RVA: 0x005CE274 File Offset: 0x005CC474
		public static IWuWaGoHintStepMove GetRootAsIWuWaGoHintStepMove(ByteBuffer _bb)
		{
			return IWuWaGoHintStepMove.GetRootAsIWuWaGoHintStepMove(_bb, default(IWuWaGoHintStepMove));
		}

		// Token: 0x0602A930 RID: 174384 RVA: 0x005CE290 File Offset: 0x005CC490
		public static IWuWaGoHintStepMove GetRootAsIWuWaGoHintStepMove(ByteBuffer _bb, IWuWaGoHintStepMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A931 RID: 174385 RVA: 0x005CE2AD File Offset: 0x005CC4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A932 RID: 174386 RVA: 0x005CE2BC File Offset: 0x005CC4BC
		public IWuWaGoHintStepMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAB4 RID: 47796
		// (get) Token: 0x0602A933 RID: 174387 RVA: 0x005CE2CC File Offset: 0x005CC4CC
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

		// Token: 0x1700BAB5 RID: 47797
		// (get) Token: 0x0602A934 RID: 174388 RVA: 0x005CE308 File Offset: 0x005CC508
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

		// Token: 0x0602A935 RID: 174389 RVA: 0x005CE365 File Offset: 0x005CC565
		public static Offset<IWuWaGoHintStepMove> CreateIWuWaGoHintStepMove(FlatBufferBuilder builder, EWuWaGoHintStepType Type = EWuWaGoHintStepType.Move, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IWuWaGoHintStepMove.AddPosition(builder, PositionOffset);
			IWuWaGoHintStepMove.AddType(builder, Type);
			return IWuWaGoHintStepMove.EndIWuWaGoHintStepMove(builder);
		}

		// Token: 0x0602A936 RID: 174390 RVA: 0x005CE382 File Offset: 0x005CC582
		public static void StartIWuWaGoHintStepMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A937 RID: 174391 RVA: 0x005CE38B File Offset: 0x005CC58B
		public static void AddType(FlatBufferBuilder builder, EWuWaGoHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A938 RID: 174392 RVA: 0x005CE396 File Offset: 0x005CC596
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x0602A939 RID: 174393 RVA: 0x005CE3A6 File Offset: 0x005CC5A6
		public static Offset<IWuWaGoHintStepMove> EndIWuWaGoHintStepMove(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoHintStepMove>(builder.EndTable());
		}

		// Token: 0x0602A93A RID: 174394 RVA: 0x005CE3B4 File Offset: 0x005CC5B4
		public IWuWaGoHintStepMoveT UnPack()
		{
			IWuWaGoHintStepMoveT wuWaGoHintStepMoveT = new IWuWaGoHintStepMoveT();
			this.UnPackTo(wuWaGoHintStepMoveT);
			return wuWaGoHintStepMoveT;
		}

		// Token: 0x0602A93B RID: 174395 RVA: 0x005CE3D0 File Offset: 0x005CC5D0
		public void UnPackTo(IWuWaGoHintStepMoveT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x0602A93C RID: 174396 RVA: 0x005CE418 File Offset: 0x005CC618
		public static Offset<IWuWaGoHintStepMove> Pack(FlatBufferBuilder builder, IWuWaGoHintStepMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoHintStepMove>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IWuWaGoHintStepMove.CreateIWuWaGoHintStepMove(builder, _o.Type, positionOffset);
		}

		// Token: 0x04010039 RID: 65593
		private Table __p;
	}
}
