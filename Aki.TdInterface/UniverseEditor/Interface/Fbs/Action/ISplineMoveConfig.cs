using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717E RID: 29054
	public struct ISplineMoveConfig : IFlatbufferObject
	{
		// Token: 0x1700D7D1 RID: 55249
		// (get) Token: 0x06033825 RID: 210981 RVA: 0x006F0428 File Offset: 0x006EE628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033826 RID: 210982 RVA: 0x006F0435 File Offset: 0x006EE635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033827 RID: 210983 RVA: 0x006F043C File Offset: 0x006EE63C
		public static ISplineMoveConfig GetRootAsISplineMoveConfig(ByteBuffer _bb)
		{
			return ISplineMoveConfig.GetRootAsISplineMoveConfig(_bb, default(ISplineMoveConfig));
		}

		// Token: 0x06033828 RID: 210984 RVA: 0x006F0458 File Offset: 0x006EE658
		public static ISplineMoveConfig GetRootAsISplineMoveConfig(ByteBuffer _bb, ISplineMoveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033829 RID: 210985 RVA: 0x006F0475 File Offset: 0x006EE675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603382A RID: 210986 RVA: 0x006F0484 File Offset: 0x006EE684
		public ISplineMoveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7D2 RID: 55250
		// (get) Token: 0x0603382B RID: 210987 RVA: 0x006F0494 File Offset: 0x006EE694
		public ESplineMoveConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveConfigType.Open;
				}
				return (ESplineMoveConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7D3 RID: 55251
		// (get) Token: 0x0603382C RID: 210988 RVA: 0x006F04D0 File Offset: 0x006EE6D0
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603382D RID: 210989 RVA: 0x006F050C File Offset: 0x006EE70C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603382E RID: 210990 RVA: 0x006F0550 File Offset: 0x006EE750
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0603382F RID: 210991 RVA: 0x006F056C File Offset: 0x006EE76C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06033830 RID: 210992 RVA: 0x006F0588 File Offset: 0x006EE788
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06033831 RID: 210993 RVA: 0x006F05A4 File Offset: 0x006EE7A4
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06033832 RID: 210994 RVA: 0x006F05C0 File Offset: 0x006EE7C0
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700D7D4 RID: 55252
		// (get) Token: 0x06033833 RID: 210995 RVA: 0x006F05DC File Offset: 0x006EE7DC
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033834 RID: 210996 RVA: 0x006F0619 File Offset: 0x006EE819
		public static Offset<ISplineMoveConfig> CreateISplineMoveConfig(FlatBufferBuilder builder, ESplineMoveConfigType Type = ESplineMoveConfigType.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, int SplineEntityId = 0)
		{
			builder.StartTable(4);
			ISplineMoveConfig.AddSplineEntityId(builder, SplineEntityId);
			ISplineMoveConfig.AddTarget(builder, TargetOffset);
			ISplineMoveConfig.AddTargetType(builder, Target_type);
			ISplineMoveConfig.AddType(builder, Type);
			return ISplineMoveConfig.EndISplineMoveConfig(builder);
		}

		// Token: 0x06033835 RID: 210997 RVA: 0x006F0645 File Offset: 0x006EE845
		public static void StartISplineMoveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033836 RID: 210998 RVA: 0x006F064E File Offset: 0x006EE84E
		public static void AddType(FlatBufferBuilder builder, ESplineMoveConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033837 RID: 210999 RVA: 0x006F0659 File Offset: 0x006EE859
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06033838 RID: 211000 RVA: 0x006F0664 File Offset: 0x006EE864
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06033839 RID: 211001 RVA: 0x006F066F File Offset: 0x006EE86F
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x0603383A RID: 211002 RVA: 0x006F067A File Offset: 0x006EE87A
		public static Offset<ISplineMoveConfig> EndISplineMoveConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveConfig>(builder.EndTable());
		}

		// Token: 0x0603383B RID: 211003 RVA: 0x006F0688 File Offset: 0x006EE888
		public ISplineMoveConfigT UnPack()
		{
			ISplineMoveConfigT splineMoveConfigT = new ISplineMoveConfigT();
			this.UnPackTo(splineMoveConfigT);
			return splineMoveConfigT;
		}

		// Token: 0x0603383C RID: 211004 RVA: 0x006F06A4 File Offset: 0x006EE8A4
		public void UnPackTo(ISplineMoveConfigT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0603383D RID: 211005 RVA: 0x006F082C File Offset: 0x006EEA2C
		public static Offset<ISplineMoveConfig> Pack(FlatBufferBuilder builder, ISplineMoveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveConfig>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISplineMoveConfig.CreateISplineMoveConfig(builder, _o.Type, target_type, targetOffset, _o.SplineEntityId);
		}

		// Token: 0x04011C27 RID: 72743
		private Table __p;
	}
}
