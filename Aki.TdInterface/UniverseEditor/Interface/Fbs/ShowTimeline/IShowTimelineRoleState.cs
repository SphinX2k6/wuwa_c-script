using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD3 RID: 16339
	public struct IShowTimelineRoleState : IFlatbufferObject
	{
		// Token: 0x17006EA8 RID: 28328
		// (get) Token: 0x06016553 RID: 91475 RVA: 0x00332FB7 File Offset: 0x003311B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016554 RID: 91476 RVA: 0x00332FC4 File Offset: 0x003311C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016555 RID: 91477 RVA: 0x00332FCC File Offset: 0x003311CC
		public static IShowTimelineRoleState GetRootAsIShowTimelineRoleState(ByteBuffer _bb)
		{
			return IShowTimelineRoleState.GetRootAsIShowTimelineRoleState(_bb, default(IShowTimelineRoleState));
		}

		// Token: 0x06016556 RID: 91478 RVA: 0x00332FE8 File Offset: 0x003311E8
		public static IShowTimelineRoleState GetRootAsIShowTimelineRoleState(ByteBuffer _bb, IShowTimelineRoleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016557 RID: 91479 RVA: 0x00333005 File Offset: 0x00331205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016558 RID: 91480 RVA: 0x00333014 File Offset: 0x00331214
		public IShowTimelineRoleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EA9 RID: 28329
		// (get) Token: 0x06016559 RID: 91481 RVA: 0x00333024 File Offset: 0x00331224
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006EAA RID: 28330
		// (get) Token: 0x0601655A RID: 91482 RVA: 0x00333060 File Offset: 0x00331260
		public ITransform? Transform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransform?(default(ITransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601655B RID: 91483 RVA: 0x003330C0 File Offset: 0x003312C0
		public int Attributes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006EAB RID: 28331
		// (get) Token: 0x0601655C RID: 91484 RVA: 0x00333100 File Offset: 0x00331300
		public int AttributesLength
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

		// Token: 0x0601655D RID: 91485 RVA: 0x0033312B File Offset: 0x0033132B
		public Span<int> GetAttributesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601655E RID: 91486 RVA: 0x0033313A File Offset: 0x0033133A
		public int[] GetAttributesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601655F RID: 91487 RVA: 0x00333148 File Offset: 0x00331348
		public int Buffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006EAC RID: 28332
		// (get) Token: 0x06016560 RID: 91488 RVA: 0x00333188 File Offset: 0x00331388
		public int BuffsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016561 RID: 91489 RVA: 0x003331B4 File Offset: 0x003313B4
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06016562 RID: 91490 RVA: 0x003331C4 File Offset: 0x003313C4
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06016563 RID: 91491 RVA: 0x003331D4 File Offset: 0x003313D4
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17006EAD RID: 28333
		// (get) Token: 0x06016564 RID: 91492 RVA: 0x00333218 File Offset: 0x00331418
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016565 RID: 91493 RVA: 0x00333244 File Offset: 0x00331444
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(12, 8);
		}

		// Token: 0x06016566 RID: 91494 RVA: 0x00333254 File Offset: 0x00331454
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(12);
		}

		// Token: 0x06016567 RID: 91495 RVA: 0x00333264 File Offset: 0x00331464
		public string BuffDebugNames(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006EAE RID: 28334
		// (get) Token: 0x06016568 RID: 91496 RVA: 0x003332A0 File Offset: 0x003314A0
		public int BuffDebugNamesLength
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

		// Token: 0x06016569 RID: 91497 RVA: 0x003332CC File Offset: 0x003314CC
		public string Tags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006EAF RID: 28335
		// (get) Token: 0x0601656A RID: 91498 RVA: 0x00333308 File Offset: 0x00331508
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601656B RID: 91499 RVA: 0x00333334 File Offset: 0x00331534
		public static Offset<IShowTimelineRoleState> CreateIShowTimelineRoleState(FlatBufferBuilder builder, int RoleId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), VectorOffset AttributesOffset = default(VectorOffset), VectorOffset BuffsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset BuffDebugNamesOffset = default(VectorOffset), VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(7);
			IShowTimelineRoleState.AddTags(builder, TagsOffset);
			IShowTimelineRoleState.AddBuffDebugNames(builder, BuffDebugNamesOffset);
			IShowTimelineRoleState.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineRoleState.AddBuffs(builder, BuffsOffset);
			IShowTimelineRoleState.AddAttributes(builder, AttributesOffset);
			IShowTimelineRoleState.AddTransform(builder, TransformOffset);
			IShowTimelineRoleState.AddRoleId(builder, RoleId);
			return IShowTimelineRoleState.EndIShowTimelineRoleState(builder);
		}

		// Token: 0x0601656C RID: 91500 RVA: 0x00333383 File Offset: 0x00331583
		public static void StartIShowTimelineRoleState(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601656D RID: 91501 RVA: 0x0033338C File Offset: 0x0033158C
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x0601656E RID: 91502 RVA: 0x00333397 File Offset: 0x00331597
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x0601656F RID: 91503 RVA: 0x003333A7 File Offset: 0x003315A7
		public static void AddAttributes(FlatBufferBuilder builder, VectorOffset attributesOffset)
		{
			builder.AddOffset(2, attributesOffset.Value, 0);
		}

		// Token: 0x06016570 RID: 91504 RVA: 0x003333B8 File Offset: 0x003315B8
		public static VectorOffset CreateAttributesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016571 RID: 91505 RVA: 0x003333EF File Offset: 0x003315EF
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016572 RID: 91506 RVA: 0x00333409 File Offset: 0x00331609
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016573 RID: 91507 RVA: 0x00333427 File Offset: 0x00331627
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016574 RID: 91508 RVA: 0x00333440 File Offset: 0x00331640
		public static void StartAttributesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016575 RID: 91509 RVA: 0x0033344B File Offset: 0x0033164B
		public static void AddBuffs(FlatBufferBuilder builder, VectorOffset buffsOffset)
		{
			builder.AddOffset(3, buffsOffset.Value, 0);
		}

		// Token: 0x06016576 RID: 91510 RVA: 0x0033345C File Offset: 0x0033165C
		public static VectorOffset CreateBuffsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016577 RID: 91511 RVA: 0x00333493 File Offset: 0x00331693
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016578 RID: 91512 RVA: 0x003334AD File Offset: 0x003316AD
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016579 RID: 91513 RVA: 0x003334CB File Offset: 0x003316CB
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601657A RID: 91514 RVA: 0x003334E4 File Offset: 0x003316E4
		public static void StartBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601657B RID: 91515 RVA: 0x003334EF File Offset: 0x003316EF
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(4, buffIdsOffset.Value, 0);
		}

		// Token: 0x0601657C RID: 91516 RVA: 0x00333500 File Offset: 0x00331700
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601657D RID: 91517 RVA: 0x00333537 File Offset: 0x00331737
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601657E RID: 91518 RVA: 0x00333551 File Offset: 0x00331751
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601657F RID: 91519 RVA: 0x0033356F File Offset: 0x0033176F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016580 RID: 91520 RVA: 0x00333588 File Offset: 0x00331788
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06016581 RID: 91521 RVA: 0x00333593 File Offset: 0x00331793
		public static void AddBuffDebugNames(FlatBufferBuilder builder, VectorOffset buffDebugNamesOffset)
		{
			builder.AddOffset(5, buffDebugNamesOffset.Value, 0);
		}

		// Token: 0x06016582 RID: 91522 RVA: 0x003335A4 File Offset: 0x003317A4
		public static VectorOffset CreateBuffDebugNamesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016583 RID: 91523 RVA: 0x003335E4 File Offset: 0x003317E4
		public static VectorOffset CreateBuffDebugNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016584 RID: 91524 RVA: 0x003335FE File Offset: 0x003317FE
		public static VectorOffset CreateBuffDebugNamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016585 RID: 91525 RVA: 0x0033361C File Offset: 0x0033181C
		public static VectorOffset CreateBuffDebugNamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016586 RID: 91526 RVA: 0x00333635 File Offset: 0x00331835
		public static void StartBuffDebugNamesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016587 RID: 91527 RVA: 0x00333640 File Offset: 0x00331840
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(6, tagsOffset.Value, 0);
		}

		// Token: 0x06016588 RID: 91528 RVA: 0x00333650 File Offset: 0x00331850
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016589 RID: 91529 RVA: 0x00333690 File Offset: 0x00331890
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601658A RID: 91530 RVA: 0x003336AA File Offset: 0x003318AA
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601658B RID: 91531 RVA: 0x003336C8 File Offset: 0x003318C8
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601658C RID: 91532 RVA: 0x003336E1 File Offset: 0x003318E1
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601658D RID: 91533 RVA: 0x003336EC File Offset: 0x003318EC
		public static Offset<IShowTimelineRoleState> EndIShowTimelineRoleState(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineRoleState>(builder.EndTable());
		}

		// Token: 0x0601658E RID: 91534 RVA: 0x003336FC File Offset: 0x003318FC
		public IShowTimelineRoleStateT UnPack()
		{
			IShowTimelineRoleStateT showTimelineRoleStateT = new IShowTimelineRoleStateT();
			this.UnPackTo(showTimelineRoleStateT);
			return showTimelineRoleStateT;
		}

		// Token: 0x0601658F RID: 91535 RVA: 0x00333718 File Offset: 0x00331918
		public void UnPackTo(IShowTimelineRoleStateT _o)
		{
			_o.RoleId = this.RoleId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.Attributes = new List<int>();
			for (int i = 0; i < this.AttributesLength; i++)
			{
				_o.Attributes.Add(this.Attributes(i));
			}
			_o.Buffs = new List<int>();
			for (int j = 0; j < this.BuffsLength; j++)
			{
				_o.Buffs.Add(this.Buffs(j));
			}
			_o.BuffIds = new List<long>();
			for (int k = 0; k < this.BuffIdsLength; k++)
			{
				_o.BuffIds.Add(this.BuffIds(k));
			}
			_o.BuffDebugNames = new List<string>();
			for (int l = 0; l < this.BuffDebugNamesLength; l++)
			{
				_o.BuffDebugNames.Add(this.BuffDebugNames(l));
			}
			_o.Tags = new List<string>();
			for (int m = 0; m < this.TagsLength; m++)
			{
				_o.Tags.Add(this.Tags(m));
			}
		}

		// Token: 0x06016590 RID: 91536 RVA: 0x00333858 File Offset: 0x00331A58
		public static Offset<IShowTimelineRoleState> Pack(FlatBufferBuilder builder, IShowTimelineRoleStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineRoleState>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			VectorOffset attributesOffset = default(VectorOffset);
			if (_o.Attributes != null)
			{
				int[] data = _o.Attributes.ToArray();
				attributesOffset = IShowTimelineRoleState.CreateAttributesVector(builder, data);
			}
			VectorOffset buffsOffset = default(VectorOffset);
			if (_o.Buffs != null)
			{
				int[] data2 = _o.Buffs.ToArray();
				buffsOffset = IShowTimelineRoleState.CreateBuffsVector(builder, data2);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data3 = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineRoleState.CreateBuffIdsVector(builder, data3);
			}
			VectorOffset buffDebugNamesOffset = default(VectorOffset);
			if (_o.BuffDebugNames != null)
			{
				StringOffset[] array = new StringOffset[_o.BuffDebugNames.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.BuffDebugNames[i]);
				}
				buffDebugNamesOffset = IShowTimelineRoleState.CreateBuffDebugNamesVector(builder, array);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Tags.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Tags[j]);
				}
				tagsOffset = IShowTimelineRoleState.CreateTagsVector(builder, array2);
			}
			return IShowTimelineRoleState.CreateIShowTimelineRoleState(builder, _o.RoleId, transformOffset, attributesOffset, buffsOffset, buffIdsOffset, buffDebugNamesOffset, tagsOffset);
		}

		// Token: 0x0400BAD6 RID: 47830
		private Table __p;
	}
}
