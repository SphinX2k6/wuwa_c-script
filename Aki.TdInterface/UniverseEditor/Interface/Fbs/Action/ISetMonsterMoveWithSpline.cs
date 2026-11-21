using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E5 RID: 30693
	public struct ISetMonsterMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700E0F2 RID: 57586
		// (get) Token: 0x06035E9F RID: 220831 RVA: 0x00738F3E File Offset: 0x0073713E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035EA0 RID: 220832 RVA: 0x00738F4B File Offset: 0x0073714B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035EA1 RID: 220833 RVA: 0x00738F54 File Offset: 0x00737154
		public static ISetMonsterMoveWithSpline GetRootAsISetMonsterMoveWithSpline(ByteBuffer _bb)
		{
			return ISetMonsterMoveWithSpline.GetRootAsISetMonsterMoveWithSpline(_bb, default(ISetMonsterMoveWithSpline));
		}

		// Token: 0x06035EA2 RID: 220834 RVA: 0x00738F70 File Offset: 0x00737170
		public static ISetMonsterMoveWithSpline GetRootAsISetMonsterMoveWithSpline(ByteBuffer _bb, ISetMonsterMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035EA3 RID: 220835 RVA: 0x00738F8D File Offset: 0x0073718D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035EA4 RID: 220836 RVA: 0x00738F9C File Offset: 0x0073719C
		public ISetMonsterMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0F3 RID: 57587
		// (get) Token: 0x06035EA5 RID: 220837 RVA: 0x00738FAC File Offset: 0x007371AC
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035EA6 RID: 220838 RVA: 0x00738FE8 File Offset: 0x007371E8
		public IMonsterMoveSplineConfig? MoveSplineConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterMoveSplineConfig?(default(IMonsterMoveSplineConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E0F4 RID: 57588
		// (get) Token: 0x06035EA7 RID: 220839 RVA: 0x00739048 File Offset: 0x00737248
		public int MoveSplineConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06035EA8 RID: 220840 RVA: 0x00739073 File Offset: 0x00737273
		public static Offset<ISetMonsterMoveWithSpline> CreateISetMonsterMoveWithSpline(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset MoveSplineConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetMonsterMoveWithSpline.AddMoveSplineConfigs(builder, MoveSplineConfigsOffset);
			ISetMonsterMoveWithSpline.AddType(builder, Type);
			return ISetMonsterMoveWithSpline.EndISetMonsterMoveWithSpline(builder);
		}

		// Token: 0x06035EA9 RID: 220841 RVA: 0x00739090 File Offset: 0x00737290
		public static void StartISetMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035EAA RID: 220842 RVA: 0x00739099 File Offset: 0x00737299
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035EAB RID: 220843 RVA: 0x007390A4 File Offset: 0x007372A4
		public static void AddMoveSplineConfigs(FlatBufferBuilder builder, VectorOffset moveSplineConfigsOffset)
		{
			builder.AddOffset(1, moveSplineConfigsOffset.Value, 0);
		}

		// Token: 0x06035EAC RID: 220844 RVA: 0x007390B4 File Offset: 0x007372B4
		public static VectorOffset CreateMoveSplineConfigsVector(FlatBufferBuilder builder, Offset<IMonsterMoveSplineConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035EAD RID: 220845 RVA: 0x007390F4 File Offset: 0x007372F4
		public static VectorOffset CreateMoveSplineConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterMoveSplineConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterMoveSplineConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035EAE RID: 220846 RVA: 0x0073910E File Offset: 0x0073730E
		public static VectorOffset CreateMoveSplineConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterMoveSplineConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterMoveSplineConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035EAF RID: 220847 RVA: 0x0073912C File Offset: 0x0073732C
		public static VectorOffset CreateMoveSplineConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterMoveSplineConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035EB0 RID: 220848 RVA: 0x00739145 File Offset: 0x00737345
		public static void StartMoveSplineConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035EB1 RID: 220849 RVA: 0x00739150 File Offset: 0x00737350
		public static Offset<ISetMonsterMoveWithSpline> EndISetMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<ISetMonsterMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x06035EB2 RID: 220850 RVA: 0x00739160 File Offset: 0x00737360
		public ISetMonsterMoveWithSplineT UnPack()
		{
			ISetMonsterMoveWithSplineT setMonsterMoveWithSplineT = new ISetMonsterMoveWithSplineT();
			this.UnPackTo(setMonsterMoveWithSplineT);
			return setMonsterMoveWithSplineT;
		}

		// Token: 0x06035EB3 RID: 220851 RVA: 0x0073917C File Offset: 0x0073737C
		public void UnPackTo(ISetMonsterMoveWithSplineT _o)
		{
			_o.Type = this.Type;
			_o.MoveSplineConfigs = new List<IMonsterMoveSplineConfigT>();
			for (int i = 0; i < this.MoveSplineConfigsLength; i++)
			{
				_o.MoveSplineConfigs.Add((this.MoveSplineConfigs(i) != null) ? this.MoveSplineConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035EB4 RID: 220852 RVA: 0x007391E8 File Offset: 0x007373E8
		public static Offset<ISetMonsterMoveWithSpline> Pack(FlatBufferBuilder builder, ISetMonsterMoveWithSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMonsterMoveWithSpline>);
			}
			VectorOffset moveSplineConfigsOffset = default(VectorOffset);
			if (_o.MoveSplineConfigs != null)
			{
				Offset<IMonsterMoveSplineConfig>[] array = new Offset<IMonsterMoveSplineConfig>[_o.MoveSplineConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterMoveSplineConfig.Pack(builder, _o.MoveSplineConfigs[i]);
				}
				moveSplineConfigsOffset = ISetMonsterMoveWithSpline.CreateMoveSplineConfigsVector(builder, array);
			}
			return ISetMonsterMoveWithSpline.CreateISetMonsterMoveWithSpline(builder, _o.Type, moveSplineConfigsOffset);
		}

		// Token: 0x04012A2A RID: 76330
		private Table __p;
	}
}
