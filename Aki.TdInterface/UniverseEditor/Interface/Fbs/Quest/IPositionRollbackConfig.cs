using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FAD RID: 16301
	public struct IPositionRollbackConfig : IFlatbufferObject
	{
		// Token: 0x170071D2 RID: 29138
		// (get) Token: 0x060174C8 RID: 95432 RVA: 0x0035BEF3 File Offset: 0x0035A0F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060174C9 RID: 95433 RVA: 0x0035BF00 File Offset: 0x0035A100
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060174CA RID: 95434 RVA: 0x0035BF08 File Offset: 0x0035A108
		public static IPositionRollbackConfig GetRootAsIPositionRollbackConfig(ByteBuffer _bb)
		{
			return IPositionRollbackConfig.GetRootAsIPositionRollbackConfig(_bb, default(IPositionRollbackConfig));
		}

		// Token: 0x060174CB RID: 95435 RVA: 0x0035BF24 File Offset: 0x0035A124
		public static IPositionRollbackConfig GetRootAsIPositionRollbackConfig(ByteBuffer _bb, IPositionRollbackConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060174CC RID: 95436 RVA: 0x0035BF41 File Offset: 0x0035A141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060174CD RID: 95437 RVA: 0x0035BF50 File Offset: 0x0035A150
		public IPositionRollbackConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071D3 RID: 29139
		// (get) Token: 0x060174CE RID: 95438 RVA: 0x0035BF60 File Offset: 0x0035A160
		public IVectorInfo? CheckPoint
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

		// Token: 0x170071D4 RID: 29140
		// (get) Token: 0x060174CF RID: 95439 RVA: 0x0035BFC0 File Offset: 0x0035A1C0
		public int CheckRange
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

		// Token: 0x170071D5 RID: 29141
		// (get) Token: 0x060174D0 RID: 95440 RVA: 0x0035BFFC File Offset: 0x0035A1FC
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosA? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Aki.UniverseEditor.Interface.Fbs.Action.IPosA?(default(Aki.UniverseEditor.Interface.Fbs.Action.IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060174D1 RID: 95441 RVA: 0x0035C059 File Offset: 0x0035A259
		public static Offset<IPositionRollbackConfig> CreateIPositionRollbackConfig(FlatBufferBuilder builder, Offset<IVectorInfo> CheckPointOffset = default(Offset<IVectorInfo>), int CheckRange = 0, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> PositionOffset = default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>))
		{
			builder.StartTable(3);
			IPositionRollbackConfig.AddPosition(builder, PositionOffset);
			IPositionRollbackConfig.AddCheckRange(builder, CheckRange);
			IPositionRollbackConfig.AddCheckPoint(builder, CheckPointOffset);
			return IPositionRollbackConfig.EndIPositionRollbackConfig(builder);
		}

		// Token: 0x060174D2 RID: 95442 RVA: 0x0035C07D File Offset: 0x0035A27D
		public static void StartIPositionRollbackConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060174D3 RID: 95443 RVA: 0x0035C086 File Offset: 0x0035A286
		public static void AddCheckPoint(FlatBufferBuilder builder, Offset<IVectorInfo> checkPointOffset)
		{
			builder.AddOffset(0, checkPointOffset.Value, 0);
		}

		// Token: 0x060174D4 RID: 95444 RVA: 0x0035C096 File Offset: 0x0035A296
		public static void AddCheckRange(FlatBufferBuilder builder, int checkRange)
		{
			builder.AddInt(1, checkRange, 0);
		}

		// Token: 0x060174D5 RID: 95445 RVA: 0x0035C0A1 File Offset: 0x0035A2A1
		public static void AddPosition(FlatBufferBuilder builder, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x060174D6 RID: 95446 RVA: 0x0035C0B1 File Offset: 0x0035A2B1
		public static Offset<IPositionRollbackConfig> EndIPositionRollbackConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPositionRollbackConfig>(builder.EndTable());
		}

		// Token: 0x060174D7 RID: 95447 RVA: 0x0035C0C0 File Offset: 0x0035A2C0
		public IPositionRollbackConfigT UnPack()
		{
			IPositionRollbackConfigT positionRollbackConfigT = new IPositionRollbackConfigT();
			this.UnPackTo(positionRollbackConfigT);
			return positionRollbackConfigT;
		}

		// Token: 0x060174D8 RID: 95448 RVA: 0x0035C0DC File Offset: 0x0035A2DC
		public void UnPackTo(IPositionRollbackConfigT _o)
		{
			_o.CheckPoint = ((this.CheckPoint != null) ? this.CheckPoint.Value.UnPack() : null);
			_o.CheckRange = this.CheckRange;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x060174D9 RID: 95449 RVA: 0x0035C154 File Offset: 0x0035A354
		public static Offset<IPositionRollbackConfig> Pack(FlatBufferBuilder builder, IPositionRollbackConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPositionRollbackConfig>);
			}
			Offset<IVectorInfo> checkPointOffset = (_o.CheckPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CheckPoint);
			Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> positionOffset = (_o.Position == null) ? default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>) : Aki.UniverseEditor.Interface.Fbs.Action.IPosA.Pack(builder, _o.Position);
			return IPositionRollbackConfig.CreateIPositionRollbackConfig(builder, checkPointOffset, _o.CheckRange, positionOffset);
		}

		// Token: 0x0400BA16 RID: 47638
		private Table __p;
	}
}
