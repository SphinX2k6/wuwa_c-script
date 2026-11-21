using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F98 RID: 20376
	public struct ICheckMechState : IFlatbufferObject
	{
		// Token: 0x170091B9 RID: 37305
		// (get) Token: 0x0601FBDF RID: 130015 RVA: 0x0046935A File Offset: 0x0046755A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBE0 RID: 130016 RVA: 0x00469367 File Offset: 0x00467567
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBE1 RID: 130017 RVA: 0x00469370 File Offset: 0x00467570
		public static ICheckMechState GetRootAsICheckMechState(ByteBuffer _bb)
		{
			return ICheckMechState.GetRootAsICheckMechState(_bb, default(ICheckMechState));
		}

		// Token: 0x0601FBE2 RID: 130018 RVA: 0x0046938C File Offset: 0x0046758C
		public static ICheckMechState GetRootAsICheckMechState(ByteBuffer _bb, ICheckMechState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBE3 RID: 130019 RVA: 0x004693A9 File Offset: 0x004675A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBE4 RID: 130020 RVA: 0x004693B8 File Offset: 0x004675B8
		public ICheckMechState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091BA RID: 37306
		// (get) Token: 0x0601FBE5 RID: 130021 RVA: 0x004693C8 File Offset: 0x004675C8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091BB RID: 37307
		// (get) Token: 0x0601FBE6 RID: 130022 RVA: 0x00469404 File Offset: 0x00467604
		public ICheckPlayerInMech? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICheckPlayerInMech?(default(ICheckPlayerInMech).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FBE7 RID: 130023 RVA: 0x00469461 File Offset: 0x00467661
		public static Offset<ICheckMechState> CreateICheckMechState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICheckPlayerInMech> ConditionOffset = default(Offset<ICheckPlayerInMech>))
		{
			builder.StartTable(2);
			ICheckMechState.AddCondition(builder, ConditionOffset);
			ICheckMechState.AddType(builder, Type);
			return ICheckMechState.EndICheckMechState(builder);
		}

		// Token: 0x0601FBE8 RID: 130024 RVA: 0x0046947E File Offset: 0x0046767E
		public static void StartICheckMechState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FBE9 RID: 130025 RVA: 0x00469487 File Offset: 0x00467687
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FBEA RID: 130026 RVA: 0x00469492 File Offset: 0x00467692
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICheckPlayerInMech> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601FBEB RID: 130027 RVA: 0x004694A2 File Offset: 0x004676A2
		public static Offset<ICheckMechState> EndICheckMechState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMechState>(builder.EndTable());
		}

		// Token: 0x0601FBEC RID: 130028 RVA: 0x004694B0 File Offset: 0x004676B0
		public ICheckMechStateT UnPack()
		{
			ICheckMechStateT checkMechStateT = new ICheckMechStateT();
			this.UnPackTo(checkMechStateT);
			return checkMechStateT;
		}

		// Token: 0x0601FBED RID: 130029 RVA: 0x004694CC File Offset: 0x004676CC
		public void UnPackTo(ICheckMechStateT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x0601FBEE RID: 130030 RVA: 0x00469514 File Offset: 0x00467714
		public static Offset<ICheckMechState> Pack(FlatBufferBuilder builder, ICheckMechStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckMechState>);
			}
			Offset<ICheckPlayerInMech> conditionOffset = (_o.Condition == null) ? default(Offset<ICheckPlayerInMech>) : ICheckPlayerInMech.Pack(builder, _o.Condition);
			return ICheckMechState.CreateICheckMechState(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400DE35 RID: 56885
		private Table __p;
	}
}
