using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701C RID: 28700
	public struct ISetMonsterMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700D51E RID: 54558
		// (get) Token: 0x06032C39 RID: 207929 RVA: 0x006D92FA File Offset: 0x006D74FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C3A RID: 207930 RVA: 0x006D9307 File Offset: 0x006D7507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C3B RID: 207931 RVA: 0x006D9310 File Offset: 0x006D7510
		public static ISetMonsterMoveWithSpline GetRootAsISetMonsterMoveWithSpline(ByteBuffer _bb)
		{
			return ISetMonsterMoveWithSpline.GetRootAsISetMonsterMoveWithSpline(_bb, default(ISetMonsterMoveWithSpline));
		}

		// Token: 0x06032C3C RID: 207932 RVA: 0x006D932C File Offset: 0x006D752C
		public static ISetMonsterMoveWithSpline GetRootAsISetMonsterMoveWithSpline(ByteBuffer _bb, ISetMonsterMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C3D RID: 207933 RVA: 0x006D9349 File Offset: 0x006D7549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C3E RID: 207934 RVA: 0x006D9358 File Offset: 0x006D7558
		public ISetMonsterMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D51F RID: 54559
		// (get) Token: 0x06032C3F RID: 207935 RVA: 0x006D9368 File Offset: 0x006D7568
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

		// Token: 0x06032C40 RID: 207936 RVA: 0x006D93A4 File Offset: 0x006D75A4
		public IMonsterMoveSplineConfig? MoveSplineConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterMoveSplineConfig?(default(IMonsterMoveSplineConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D520 RID: 54560
		// (get) Token: 0x06032C41 RID: 207937 RVA: 0x006D9404 File Offset: 0x006D7604
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

		// Token: 0x06032C42 RID: 207938 RVA: 0x006D942F File Offset: 0x006D762F
		public static Offset<ISetMonsterMoveWithSpline> CreateISetMonsterMoveWithSpline(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset MoveSplineConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetMonsterMoveWithSpline.AddMoveSplineConfigs(builder, MoveSplineConfigsOffset);
			ISetMonsterMoveWithSpline.AddType(builder, Type);
			return ISetMonsterMoveWithSpline.EndISetMonsterMoveWithSpline(builder);
		}

		// Token: 0x06032C43 RID: 207939 RVA: 0x006D944C File Offset: 0x006D764C
		public static void StartISetMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032C44 RID: 207940 RVA: 0x006D9455 File Offset: 0x006D7655
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C45 RID: 207941 RVA: 0x006D9460 File Offset: 0x006D7660
		public static void AddMoveSplineConfigs(FlatBufferBuilder builder, VectorOffset moveSplineConfigsOffset)
		{
			builder.AddOffset(1, moveSplineConfigsOffset.Value, 0);
		}

		// Token: 0x06032C46 RID: 207942 RVA: 0x006D9470 File Offset: 0x006D7670
		public static VectorOffset CreateMoveSplineConfigsVector(FlatBufferBuilder builder, Offset<IMonsterMoveSplineConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032C47 RID: 207943 RVA: 0x006D94B0 File Offset: 0x006D76B0
		public static VectorOffset CreateMoveSplineConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterMoveSplineConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterMoveSplineConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C48 RID: 207944 RVA: 0x006D94CA File Offset: 0x006D76CA
		public static VectorOffset CreateMoveSplineConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterMoveSplineConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterMoveSplineConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C49 RID: 207945 RVA: 0x006D94E8 File Offset: 0x006D76E8
		public static VectorOffset CreateMoveSplineConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterMoveSplineConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032C4A RID: 207946 RVA: 0x006D9501 File Offset: 0x006D7701
		public static void StartMoveSplineConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032C4B RID: 207947 RVA: 0x006D950C File Offset: 0x006D770C
		public static Offset<ISetMonsterMoveWithSpline> EndISetMonsterMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<ISetMonsterMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x06032C4C RID: 207948 RVA: 0x006D951C File Offset: 0x006D771C
		public ISetMonsterMoveWithSplineT UnPack()
		{
			ISetMonsterMoveWithSplineT setMonsterMoveWithSplineT = new ISetMonsterMoveWithSplineT();
			this.UnPackTo(setMonsterMoveWithSplineT);
			return setMonsterMoveWithSplineT;
		}

		// Token: 0x06032C4D RID: 207949 RVA: 0x006D9538 File Offset: 0x006D7738
		public void UnPackTo(ISetMonsterMoveWithSplineT _o)
		{
			_o.Type = this.Type;
			_o.MoveSplineConfigs = new List<IMonsterMoveSplineConfigT>();
			for (int i = 0; i < this.MoveSplineConfigsLength; i++)
			{
				_o.MoveSplineConfigs.Add((this.MoveSplineConfigs(i) != null) ? this.MoveSplineConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032C4E RID: 207950 RVA: 0x006D95A4 File Offset: 0x006D77A4
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

		// Token: 0x04011A45 RID: 72261
		private Table __p;
	}
}
