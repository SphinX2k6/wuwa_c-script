using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007851 RID: 30801
	public struct ISetTargetElementalAbility : IFlatbufferObject
	{
		// Token: 0x1700E1EF RID: 57839
		// (get) Token: 0x060362A8 RID: 221864 RVA: 0x007418C5 File Offset: 0x0073FAC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060362A9 RID: 221865 RVA: 0x007418D2 File Offset: 0x0073FAD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060362AA RID: 221866 RVA: 0x007418DC File Offset: 0x0073FADC
		public static ISetTargetElementalAbility GetRootAsISetTargetElementalAbility(ByteBuffer _bb)
		{
			return ISetTargetElementalAbility.GetRootAsISetTargetElementalAbility(_bb, default(ISetTargetElementalAbility));
		}

		// Token: 0x060362AB RID: 221867 RVA: 0x007418F8 File Offset: 0x0073FAF8
		public static ISetTargetElementalAbility GetRootAsISetTargetElementalAbility(ByteBuffer _bb, ISetTargetElementalAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060362AC RID: 221868 RVA: 0x00741915 File Offset: 0x0073FB15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060362AD RID: 221869 RVA: 0x00741924 File Offset: 0x0073FB24
		public ISetTargetElementalAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1F0 RID: 57840
		// (get) Token: 0x060362AE RID: 221870 RVA: 0x00741934 File Offset: 0x0073FB34
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060362AF RID: 221871 RVA: 0x00741970 File Offset: 0x0073FB70
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060362B0 RID: 221872 RVA: 0x007419B4 File Offset: 0x0073FBB4
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x060362B1 RID: 221873 RVA: 0x007419D0 File Offset: 0x0073FBD0
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x060362B2 RID: 221874 RVA: 0x007419EC File Offset: 0x0073FBEC
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x060362B3 RID: 221875 RVA: 0x00741A08 File Offset: 0x0073FC08
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x060362B4 RID: 221876 RVA: 0x00741A24 File Offset: 0x0073FC24
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700E1F1 RID: 57841
		// (get) Token: 0x060362B5 RID: 221877 RVA: 0x00741A40 File Offset: 0x0073FC40
		public EElementalType ElementalType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1F2 RID: 57842
		// (get) Token: 0x060362B6 RID: 221878 RVA: 0x00741A7C File Offset: 0x0073FC7C
		public EElementalOpType OpType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EElementalOpType.Grant;
				}
				return (EElementalOpType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1F3 RID: 57843
		// (get) Token: 0x060362B7 RID: 221879 RVA: 0x00741ABC File Offset: 0x0073FCBC
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060362B8 RID: 221880 RVA: 0x00741AF9 File Offset: 0x0073FCF9
		public static Offset<ISetTargetElementalAbility> CreateISetTargetElementalAbility(FlatBufferBuilder builder, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, EElementalType ElementalType = EElementalType.Fire, EElementalOpType OpType = EElementalOpType.Grant, int Priority = 0)
		{
			builder.StartTable(5);
			ISetTargetElementalAbility.AddPriority(builder, Priority);
			ISetTargetElementalAbility.AddTarget(builder, TargetOffset);
			ISetTargetElementalAbility.AddOpType(builder, OpType);
			ISetTargetElementalAbility.AddElementalType(builder, ElementalType);
			ISetTargetElementalAbility.AddTargetType(builder, Target_type);
			return ISetTargetElementalAbility.EndISetTargetElementalAbility(builder);
		}

		// Token: 0x060362B9 RID: 221881 RVA: 0x00741B2D File Offset: 0x0073FD2D
		public static void StartISetTargetElementalAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060362BA RID: 221882 RVA: 0x00741B36 File Offset: 0x0073FD36
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x060362BB RID: 221883 RVA: 0x00741B41 File Offset: 0x0073FD41
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x060362BC RID: 221884 RVA: 0x00741B4C File Offset: 0x0073FD4C
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(2, (byte)elementalType, 0);
		}

		// Token: 0x060362BD RID: 221885 RVA: 0x00741B57 File Offset: 0x0073FD57
		public static void AddOpType(FlatBufferBuilder builder, EElementalOpType opType)
		{
			builder.AddByte(3, (byte)opType, 0);
		}

		// Token: 0x060362BE RID: 221886 RVA: 0x00741B62 File Offset: 0x0073FD62
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(4, priority, 0);
		}

		// Token: 0x060362BF RID: 221887 RVA: 0x00741B6D File Offset: 0x0073FD6D
		public static Offset<ISetTargetElementalAbility> EndISetTargetElementalAbility(FlatBufferBuilder builder)
		{
			return new Offset<ISetTargetElementalAbility>(builder.EndTable());
		}

		// Token: 0x060362C0 RID: 221888 RVA: 0x00741B7C File Offset: 0x0073FD7C
		public ISetTargetElementalAbilityT UnPack()
		{
			ISetTargetElementalAbilityT setTargetElementalAbilityT = new ISetTargetElementalAbilityT();
			this.UnPackTo(setTargetElementalAbilityT);
			return setTargetElementalAbilityT;
		}

		// Token: 0x060362C1 RID: 221889 RVA: 0x00741B98 File Offset: 0x0073FD98
		public void UnPackTo(ISetTargetElementalAbilityT _o)
		{
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
			_o.ElementalType = this.ElementalType;
			_o.OpType = this.OpType;
			_o.Priority = this.Priority;
		}

		// Token: 0x060362C2 RID: 221890 RVA: 0x00741D2C File Offset: 0x0073FF2C
		public static Offset<ISetTargetElementalAbility> Pack(FlatBufferBuilder builder, ISetTargetElementalAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTargetElementalAbility>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISetTargetElementalAbility.CreateISetTargetElementalAbility(builder, target_type, targetOffset, _o.ElementalType, _o.OpType, _o.Priority);
		}

		// Token: 0x04012AD8 RID: 76504
		private Table __p;
	}
}
