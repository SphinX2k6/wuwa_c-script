using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AA RID: 17066
	public struct IForceClosedRestriction : IFlatbufferObject
	{
		// Token: 0x170074B6 RID: 29878
		// (get) Token: 0x06017E4C RID: 97868 RVA: 0x003698C0 File Offset: 0x00367AC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E4D RID: 97869 RVA: 0x003698CD File Offset: 0x00367ACD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E4E RID: 97870 RVA: 0x003698D4 File Offset: 0x00367AD4
		public static IForceClosedRestriction GetRootAsIForceClosedRestriction(ByteBuffer _bb)
		{
			return IForceClosedRestriction.GetRootAsIForceClosedRestriction(_bb, default(IForceClosedRestriction));
		}

		// Token: 0x06017E4F RID: 97871 RVA: 0x003698F0 File Offset: 0x00367AF0
		public static IForceClosedRestriction GetRootAsIForceClosedRestriction(ByteBuffer _bb, IForceClosedRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E50 RID: 97872 RVA: 0x0036990D File Offset: 0x00367B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E51 RID: 97873 RVA: 0x0036991C File Offset: 0x00367B1C
		public IForceClosedRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074B7 RID: 29879
		// (get) Token: 0x06017E52 RID: 97874 RVA: 0x0036992C File Offset: 0x00367B2C
		public IVectorInfo? RangeCenter
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

		// Token: 0x170074B8 RID: 29880
		// (get) Token: 0x06017E53 RID: 97875 RVA: 0x0036998C File Offset: 0x00367B8C
		public int RangeRadius
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

		// Token: 0x06017E54 RID: 97876 RVA: 0x003699C8 File Offset: 0x00367BC8
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074B9 RID: 29881
		// (get) Token: 0x06017E55 RID: 97877 RVA: 0x00369A08 File Offset: 0x00367C08
		public int RangeEntitiesLength
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

		// Token: 0x06017E56 RID: 97878 RVA: 0x00369A33 File Offset: 0x00367C33
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06017E57 RID: 97879 RVA: 0x00369A42 File Offset: 0x00367C42
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x170074BA RID: 29882
		// (get) Token: 0x06017E58 RID: 97880 RVA: 0x00369A50 File Offset: 0x00367C50
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosA? FailedReturnPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Aki.UniverseEditor.Interface.Fbs.Action.IPosA?(default(Aki.UniverseEditor.Interface.Fbs.Action.IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170074BB RID: 29883
		// (get) Token: 0x06017E59 RID: 97881 RVA: 0x00369AB0 File Offset: 0x00367CB0
		public int FailedReturnPosEntityId
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

		// Token: 0x06017E5A RID: 97882 RVA: 0x00369AF0 File Offset: 0x00367CF0
		public int AllowDungeonList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074BC RID: 29884
		// (get) Token: 0x06017E5B RID: 97883 RVA: 0x00369B30 File Offset: 0x00367D30
		public int AllowDungeonListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017E5C RID: 97884 RVA: 0x00369B5C File Offset: 0x00367D5C
		public Span<int> GetAllowDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06017E5D RID: 97885 RVA: 0x00369B6C File Offset: 0x00367D6C
		public int[] GetAllowDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x170074BD RID: 29885
		// (get) Token: 0x06017E5E RID: 97886 RVA: 0x00369B7C File Offset: 0x00367D7C
		public bool OnlyFailOnceOutsideDungeon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074BE RID: 29886
		// (get) Token: 0x06017E5F RID: 97887 RVA: 0x00369BBC File Offset: 0x00367DBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017E60 RID: 97888 RVA: 0x00369BFC File Offset: 0x00367DFC
		public static Offset<IForceClosedRestriction> CreateIForceClosedRestriction(FlatBufferBuilder builder, Offset<IVectorInfo> RangeCenterOffset = default(Offset<IVectorInfo>), int RangeRadius = 0, VectorOffset RangeEntitiesOffset = default(VectorOffset), Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> FailedReturnPosOffset = default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>), int FailedReturnPosEntityId = 0, VectorOffset AllowDungeonListOffset = default(VectorOffset), bool OnlyFailOnceOutsideDungeon = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IForceClosedRestriction.AddAllowDungeonList(builder, AllowDungeonListOffset);
			IForceClosedRestriction.AddFailedReturnPosEntityId(builder, FailedReturnPosEntityId);
			IForceClosedRestriction.AddFailedReturnPos(builder, FailedReturnPosOffset);
			IForceClosedRestriction.AddRangeEntities(builder, RangeEntitiesOffset);
			IForceClosedRestriction.AddRangeRadius(builder, RangeRadius);
			IForceClosedRestriction.AddRangeCenter(builder, RangeCenterOffset);
			IForceClosedRestriction.AddNullMask(builder, NullMask);
			IForceClosedRestriction.AddOnlyFailOnceOutsideDungeon(builder, OnlyFailOnceOutsideDungeon);
			return IForceClosedRestriction.EndIForceClosedRestriction(builder);
		}

		// Token: 0x06017E61 RID: 97889 RVA: 0x00369C53 File Offset: 0x00367E53
		public static void StartIForceClosedRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06017E62 RID: 97890 RVA: 0x00369C5C File Offset: 0x00367E5C
		public static void AddRangeCenter(FlatBufferBuilder builder, Offset<IVectorInfo> rangeCenterOffset)
		{
			builder.AddOffset(0, rangeCenterOffset.Value, 0);
		}

		// Token: 0x06017E63 RID: 97891 RVA: 0x00369C6C File Offset: 0x00367E6C
		public static void AddRangeRadius(FlatBufferBuilder builder, int rangeRadius)
		{
			builder.AddInt(1, rangeRadius, 0);
		}

		// Token: 0x06017E64 RID: 97892 RVA: 0x00369C77 File Offset: 0x00367E77
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(2, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06017E65 RID: 97893 RVA: 0x00369C88 File Offset: 0x00367E88
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017E66 RID: 97894 RVA: 0x00369CBF File Offset: 0x00367EBF
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E67 RID: 97895 RVA: 0x00369CD9 File Offset: 0x00367ED9
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E68 RID: 97896 RVA: 0x00369CF7 File Offset: 0x00367EF7
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017E69 RID: 97897 RVA: 0x00369D10 File Offset: 0x00367F10
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017E6A RID: 97898 RVA: 0x00369D1B File Offset: 0x00367F1B
		public static void AddFailedReturnPos(FlatBufferBuilder builder, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> failedReturnPosOffset)
		{
			builder.AddOffset(3, failedReturnPosOffset.Value, 0);
		}

		// Token: 0x06017E6B RID: 97899 RVA: 0x00369D2B File Offset: 0x00367F2B
		public static void AddFailedReturnPosEntityId(FlatBufferBuilder builder, int failedReturnPosEntityId)
		{
			builder.AddInt(4, failedReturnPosEntityId, 0);
		}

		// Token: 0x06017E6C RID: 97900 RVA: 0x00369D36 File Offset: 0x00367F36
		public static void AddAllowDungeonList(FlatBufferBuilder builder, VectorOffset allowDungeonListOffset)
		{
			builder.AddOffset(5, allowDungeonListOffset.Value, 0);
		}

		// Token: 0x06017E6D RID: 97901 RVA: 0x00369D48 File Offset: 0x00367F48
		public static VectorOffset CreateAllowDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017E6E RID: 97902 RVA: 0x00369D7F File Offset: 0x00367F7F
		public static VectorOffset CreateAllowDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E6F RID: 97903 RVA: 0x00369D99 File Offset: 0x00367F99
		public static VectorOffset CreateAllowDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E70 RID: 97904 RVA: 0x00369DB7 File Offset: 0x00367FB7
		public static VectorOffset CreateAllowDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017E71 RID: 97905 RVA: 0x00369DD0 File Offset: 0x00367FD0
		public static void StartAllowDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017E72 RID: 97906 RVA: 0x00369DDB File Offset: 0x00367FDB
		public static void AddOnlyFailOnceOutsideDungeon(FlatBufferBuilder builder, bool onlyFailOnceOutsideDungeon)
		{
			builder.AddBool(6, onlyFailOnceOutsideDungeon, false);
		}

		// Token: 0x06017E73 RID: 97907 RVA: 0x00369DE6 File Offset: 0x00367FE6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06017E74 RID: 97908 RVA: 0x00369DF1 File Offset: 0x00367FF1
		public static Offset<IForceClosedRestriction> EndIForceClosedRestriction(FlatBufferBuilder builder)
		{
			return new Offset<IForceClosedRestriction>(builder.EndTable());
		}

		// Token: 0x06017E75 RID: 97909 RVA: 0x00369E00 File Offset: 0x00368000
		public IForceClosedRestrictionT UnPack()
		{
			IForceClosedRestrictionT forceClosedRestrictionT = new IForceClosedRestrictionT();
			this.UnPackTo(forceClosedRestrictionT);
			return forceClosedRestrictionT;
		}

		// Token: 0x06017E76 RID: 97910 RVA: 0x00369E1C File Offset: 0x0036801C
		public void UnPackTo(IForceClosedRestrictionT _o)
		{
			_o.RangeCenter = ((this.RangeCenter != null) ? this.RangeCenter.Value.UnPack() : null);
			_o.RangeRadius = this.RangeRadius;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.FailedReturnPos = ((this.FailedReturnPos != null) ? this.FailedReturnPos.Value.UnPack() : null);
			_o.FailedReturnPosEntityId = this.FailedReturnPosEntityId;
			_o.AllowDungeonList = new List<int>();
			for (int j = 0; j < this.AllowDungeonListLength; j++)
			{
				_o.AllowDungeonList.Add(this.AllowDungeonList(j));
			}
			_o.OnlyFailOnceOutsideDungeon = this.OnlyFailOnceOutsideDungeon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017E77 RID: 97911 RVA: 0x00369F1C File Offset: 0x0036811C
		public static Offset<IForceClosedRestriction> Pack(FlatBufferBuilder builder, IForceClosedRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IForceClosedRestriction>);
			}
			Offset<IVectorInfo> rangeCenterOffset = (_o.RangeCenter == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RangeCenter);
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IForceClosedRestriction.CreateRangeEntitiesVector(builder, data);
			}
			Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> failedReturnPosOffset = (_o.FailedReturnPos == null) ? default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>) : Aki.UniverseEditor.Interface.Fbs.Action.IPosA.Pack(builder, _o.FailedReturnPos);
			VectorOffset allowDungeonListOffset = default(VectorOffset);
			if (_o.AllowDungeonList != null)
			{
				int[] data2 = _o.AllowDungeonList.ToArray();
				allowDungeonListOffset = IForceClosedRestriction.CreateAllowDungeonListVector(builder, data2);
			}
			return IForceClosedRestriction.CreateIForceClosedRestriction(builder, rangeCenterOffset, _o.RangeRadius, rangeEntitiesOffset, failedReturnPosOffset, _o.FailedReturnPosEntityId, allowDungeonListOffset, _o.OnlyFailOnceOutsideDungeon, _o.NullMask);
		}

		// Token: 0x0400C1FA RID: 49658
		private Table __p;
	}
}
