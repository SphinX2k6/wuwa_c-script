using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B40 RID: 23360
	public struct IMonsterSummonInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700AA70 RID: 43632
		// (get) Token: 0x060266A6 RID: 157350 RVA: 0x00542C46 File Offset: 0x00540E46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060266A7 RID: 157351 RVA: 0x00542C53 File Offset: 0x00540E53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060266A8 RID: 157352 RVA: 0x00542C5C File Offset: 0x00540E5C
		public static IMonsterSummonInteractPoint GetRootAsIMonsterSummonInteractPoint(ByteBuffer _bb)
		{
			return IMonsterSummonInteractPoint.GetRootAsIMonsterSummonInteractPoint(_bb, default(IMonsterSummonInteractPoint));
		}

		// Token: 0x060266A9 RID: 157353 RVA: 0x00542C78 File Offset: 0x00540E78
		public static IMonsterSummonInteractPoint GetRootAsIMonsterSummonInteractPoint(ByteBuffer _bb, IMonsterSummonInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060266AA RID: 157354 RVA: 0x00542C95 File Offset: 0x00540E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060266AB RID: 157355 RVA: 0x00542CA4 File Offset: 0x00540EA4
		public IMonsterSummonInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA71 RID: 43633
		// (get) Token: 0x060266AC RID: 157356 RVA: 0x00542CB4 File Offset: 0x00540EB4
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA72 RID: 43634
		// (get) Token: 0x060266AD RID: 157357 RVA: 0x00542CF0 File Offset: 0x00540EF0
		public float Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060266AE RID: 157358 RVA: 0x00542D30 File Offset: 0x00540F30
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA73 RID: 43635
		// (get) Token: 0x060266AF RID: 157359 RVA: 0x00542D90 File Offset: 0x00540F90
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AA74 RID: 43636
		// (get) Token: 0x060266B0 RID: 157360 RVA: 0x00542DBC File Offset: 0x00540FBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060266B1 RID: 157361 RVA: 0x00542DF9 File Offset: 0x00540FF9
		public static Offset<IMonsterSummonInteractPoint> CreateIMonsterSummonInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float Range = 0f, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IMonsterSummonInteractPoint.AddActions(builder, ActionsOffset);
			IMonsterSummonInteractPoint.AddRange(builder, Range);
			IMonsterSummonInteractPoint.AddNullMask(builder, NullMask);
			IMonsterSummonInteractPoint.AddType(builder, Type);
			return IMonsterSummonInteractPoint.EndIMonsterSummonInteractPoint(builder);
		}

		// Token: 0x060266B2 RID: 157362 RVA: 0x00542E25 File Offset: 0x00541025
		public static void StartIMonsterSummonInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060266B3 RID: 157363 RVA: 0x00542E2E File Offset: 0x0054102E
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060266B4 RID: 157364 RVA: 0x00542E39 File Offset: 0x00541039
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x060266B5 RID: 157365 RVA: 0x00542E4C File Offset: 0x0054104C
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x060266B6 RID: 157366 RVA: 0x00542E5C File Offset: 0x0054105C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060266B7 RID: 157367 RVA: 0x00542E9C File Offset: 0x0054109C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060266B8 RID: 157368 RVA: 0x00542EB6 File Offset: 0x005410B6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060266B9 RID: 157369 RVA: 0x00542ED4 File Offset: 0x005410D4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060266BA RID: 157370 RVA: 0x00542EED File Offset: 0x005410ED
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060266BB RID: 157371 RVA: 0x00542EF8 File Offset: 0x005410F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060266BC RID: 157372 RVA: 0x00542F03 File Offset: 0x00541103
		public static Offset<IMonsterSummonInteractPoint> EndIMonsterSummonInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterSummonInteractPoint>(builder.EndTable());
		}

		// Token: 0x060266BD RID: 157373 RVA: 0x00542F10 File Offset: 0x00541110
		public IMonsterSummonInteractPointT UnPack()
		{
			IMonsterSummonInteractPointT monsterSummonInteractPointT = new IMonsterSummonInteractPointT();
			this.UnPackTo(monsterSummonInteractPointT);
			return monsterSummonInteractPointT;
		}

		// Token: 0x060266BE RID: 157374 RVA: 0x00542F2C File Offset: 0x0054112C
		public void UnPackTo(IMonsterSummonInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.Range = this.Range;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060266BF RID: 157375 RVA: 0x00542FB0 File Offset: 0x005411B0
		public static Offset<IMonsterSummonInteractPoint> Pack(FlatBufferBuilder builder, IMonsterSummonInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterSummonInteractPoint>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IMonsterSummonInteractPoint.CreateActionsVector(builder, array);
			}
			return IMonsterSummonInteractPoint.CreateIMonsterSummonInteractPoint(builder, _o.Type, _o.Range, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400F534 RID: 62772
		private Table __p;
	}
}
