using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A2 RID: 21922
	public struct IMonsterSummonInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700A1E8 RID: 41448
		// (get) Token: 0x06024499 RID: 148633 RVA: 0x005026CE File Offset: 0x005008CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602449A RID: 148634 RVA: 0x005026DB File Offset: 0x005008DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602449B RID: 148635 RVA: 0x005026E4 File Offset: 0x005008E4
		public static IMonsterSummonInteractPoint GetRootAsIMonsterSummonInteractPoint(ByteBuffer _bb)
		{
			return IMonsterSummonInteractPoint.GetRootAsIMonsterSummonInteractPoint(_bb, default(IMonsterSummonInteractPoint));
		}

		// Token: 0x0602449C RID: 148636 RVA: 0x00502700 File Offset: 0x00500900
		public static IMonsterSummonInteractPoint GetRootAsIMonsterSummonInteractPoint(ByteBuffer _bb, IMonsterSummonInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602449D RID: 148637 RVA: 0x0050271D File Offset: 0x0050091D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602449E RID: 148638 RVA: 0x0050272C File Offset: 0x0050092C
		public IMonsterSummonInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1E9 RID: 41449
		// (get) Token: 0x0602449F RID: 148639 RVA: 0x0050273C File Offset: 0x0050093C
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

		// Token: 0x1700A1EA RID: 41450
		// (get) Token: 0x060244A0 RID: 148640 RVA: 0x00502778 File Offset: 0x00500978
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

		// Token: 0x060244A1 RID: 148641 RVA: 0x005027B8 File Offset: 0x005009B8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1EB RID: 41451
		// (get) Token: 0x060244A2 RID: 148642 RVA: 0x00502818 File Offset: 0x00500A18
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

		// Token: 0x1700A1EC RID: 41452
		// (get) Token: 0x060244A3 RID: 148643 RVA: 0x00502844 File Offset: 0x00500A44
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

		// Token: 0x060244A4 RID: 148644 RVA: 0x00502881 File Offset: 0x00500A81
		public static Offset<IMonsterSummonInteractPoint> CreateIMonsterSummonInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float Range = 0f, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IMonsterSummonInteractPoint.AddActions(builder, ActionsOffset);
			IMonsterSummonInteractPoint.AddRange(builder, Range);
			IMonsterSummonInteractPoint.AddNullMask(builder, NullMask);
			IMonsterSummonInteractPoint.AddType(builder, Type);
			return IMonsterSummonInteractPoint.EndIMonsterSummonInteractPoint(builder);
		}

		// Token: 0x060244A5 RID: 148645 RVA: 0x005028AD File Offset: 0x00500AAD
		public static void StartIMonsterSummonInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060244A6 RID: 148646 RVA: 0x005028B6 File Offset: 0x00500AB6
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060244A7 RID: 148647 RVA: 0x005028C1 File Offset: 0x00500AC1
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x060244A8 RID: 148648 RVA: 0x005028D4 File Offset: 0x00500AD4
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x060244A9 RID: 148649 RVA: 0x005028E4 File Offset: 0x00500AE4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060244AA RID: 148650 RVA: 0x00502924 File Offset: 0x00500B24
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060244AB RID: 148651 RVA: 0x0050293E File Offset: 0x00500B3E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060244AC RID: 148652 RVA: 0x0050295C File Offset: 0x00500B5C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060244AD RID: 148653 RVA: 0x00502975 File Offset: 0x00500B75
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060244AE RID: 148654 RVA: 0x00502980 File Offset: 0x00500B80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060244AF RID: 148655 RVA: 0x0050298B File Offset: 0x00500B8B
		public static Offset<IMonsterSummonInteractPoint> EndIMonsterSummonInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterSummonInteractPoint>(builder.EndTable());
		}

		// Token: 0x060244B0 RID: 148656 RVA: 0x00502998 File Offset: 0x00500B98
		public IMonsterSummonInteractPointT UnPack()
		{
			IMonsterSummonInteractPointT monsterSummonInteractPointT = new IMonsterSummonInteractPointT();
			this.UnPackTo(monsterSummonInteractPointT);
			return monsterSummonInteractPointT;
		}

		// Token: 0x060244B1 RID: 148657 RVA: 0x005029B4 File Offset: 0x00500BB4
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

		// Token: 0x060244B2 RID: 148658 RVA: 0x00502A38 File Offset: 0x00500C38
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

		// Token: 0x0400E8D2 RID: 59602
		private Table __p;
	}
}
