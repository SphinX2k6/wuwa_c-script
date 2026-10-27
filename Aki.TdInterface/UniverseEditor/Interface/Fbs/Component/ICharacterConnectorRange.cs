using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F85 RID: 20357
	public struct ICharacterConnectorRange : IFlatbufferObject
	{
		// Token: 0x1700931C RID: 37660
		// (get) Token: 0x0602050B RID: 132363 RVA: 0x0047EDEA File Offset: 0x0047CFEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602050C RID: 132364 RVA: 0x0047EDF7 File Offset: 0x0047CFF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602050D RID: 132365 RVA: 0x0047EE00 File Offset: 0x0047D000
		public static ICharacterConnectorRange GetRootAsICharacterConnectorRange(ByteBuffer _bb)
		{
			return ICharacterConnectorRange.GetRootAsICharacterConnectorRange(_bb, default(ICharacterConnectorRange));
		}

		// Token: 0x0602050E RID: 132366 RVA: 0x0047EE1C File Offset: 0x0047D01C
		public static ICharacterConnectorRange GetRootAsICharacterConnectorRange(ByteBuffer _bb, ICharacterConnectorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602050F RID: 132367 RVA: 0x0047EE39 File Offset: 0x0047D039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020510 RID: 132368 RVA: 0x0047EE48 File Offset: 0x0047D048
		public ICharacterConnectorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700931D RID: 37661
		// (get) Token: 0x06020511 RID: 132369 RVA: 0x0047EE58 File Offset: 0x0047D058
		public ECharacterConnectorLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterConnectorLogicType.Range;
				}
				return (ECharacterConnectorLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700931E RID: 37662
		// (get) Token: 0x06020512 RID: 132370 RVA: 0x0047EE94 File Offset: 0x0047D094
		public IConnectorEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorEffectConfig?(default(IConnectorEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700931F RID: 37663
		// (get) Token: 0x06020513 RID: 132371 RVA: 0x0047EEF4 File Offset: 0x0047D0F4
		public int EnterRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009320 RID: 37664
		// (get) Token: 0x06020514 RID: 132372 RVA: 0x0047EF30 File Offset: 0x0047D130
		public int LeaveRange
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

		// Token: 0x06020515 RID: 132373 RVA: 0x0047EF70 File Offset: 0x0047D170
		public int TagConditions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009321 RID: 37665
		// (get) Token: 0x06020516 RID: 132374 RVA: 0x0047EFB0 File Offset: 0x0047D1B0
		public int TagConditionsLength
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

		// Token: 0x06020517 RID: 132375 RVA: 0x0047EFDC File Offset: 0x0047D1DC
		public Span<int> GetTagConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06020518 RID: 132376 RVA: 0x0047EFEC File Offset: 0x0047D1EC
		public int[] GetTagConditionsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x06020519 RID: 132377 RVA: 0x0047EFFC File Offset: 0x0047D1FC
		public IDynamicEntityMatch? MatchConditions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009322 RID: 37666
		// (get) Token: 0x0602051A RID: 132378 RVA: 0x0047F060 File Offset: 0x0047D260
		public int MatchConditionsLength
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

		// Token: 0x0602051B RID: 132379 RVA: 0x0047F08C File Offset: 0x0047D28C
		public IDynamicEntityMatch? KeepConditions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009323 RID: 37667
		// (get) Token: 0x0602051C RID: 132380 RVA: 0x0047F0F0 File Offset: 0x0047D2F0
		public int KeepConditionsLength
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

		// Token: 0x17009324 RID: 37668
		// (get) Token: 0x0602051D RID: 132381 RVA: 0x0047F11C File Offset: 0x0047D31C
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

		// Token: 0x0602051E RID: 132382 RVA: 0x0047F15C File Offset: 0x0047D35C
		public static Offset<ICharacterConnectorRange> CreateICharacterConnectorRange(FlatBufferBuilder builder, ECharacterConnectorLogicType Type = ECharacterConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>), int EnterRange = 0, int LeaveRange = 0, VectorOffset TagConditionsOffset = default(VectorOffset), VectorOffset MatchConditionsOffset = default(VectorOffset), VectorOffset KeepConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			ICharacterConnectorRange.AddKeepConditions(builder, KeepConditionsOffset);
			ICharacterConnectorRange.AddMatchConditions(builder, MatchConditionsOffset);
			ICharacterConnectorRange.AddTagConditions(builder, TagConditionsOffset);
			ICharacterConnectorRange.AddLeaveRange(builder, LeaveRange);
			ICharacterConnectorRange.AddEnterRange(builder, EnterRange);
			ICharacterConnectorRange.AddEffectConfig(builder, EffectConfigOffset);
			ICharacterConnectorRange.AddNullMask(builder, NullMask);
			ICharacterConnectorRange.AddType(builder, Type);
			return ICharacterConnectorRange.EndICharacterConnectorRange(builder);
		}

		// Token: 0x0602051F RID: 132383 RVA: 0x0047F1B3 File Offset: 0x0047D3B3
		public static void StartICharacterConnectorRange(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06020520 RID: 132384 RVA: 0x0047F1BC File Offset: 0x0047D3BC
		public static void AddType(FlatBufferBuilder builder, ECharacterConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020521 RID: 132385 RVA: 0x0047F1C7 File Offset: 0x0047D3C7
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06020522 RID: 132386 RVA: 0x0047F1D7 File Offset: 0x0047D3D7
		public static void AddEnterRange(FlatBufferBuilder builder, int enterRange)
		{
			builder.AddInt(2, enterRange, 0);
		}

		// Token: 0x06020523 RID: 132387 RVA: 0x0047F1E2 File Offset: 0x0047D3E2
		public static void AddLeaveRange(FlatBufferBuilder builder, int leaveRange)
		{
			builder.AddInt(3, leaveRange, 0);
		}

		// Token: 0x06020524 RID: 132388 RVA: 0x0047F1ED File Offset: 0x0047D3ED
		public static void AddTagConditions(FlatBufferBuilder builder, VectorOffset tagConditionsOffset)
		{
			builder.AddOffset(4, tagConditionsOffset.Value, 0);
		}

		// Token: 0x06020525 RID: 132389 RVA: 0x0047F200 File Offset: 0x0047D400
		public static VectorOffset CreateTagConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020526 RID: 132390 RVA: 0x0047F237 File Offset: 0x0047D437
		public static VectorOffset CreateTagConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020527 RID: 132391 RVA: 0x0047F251 File Offset: 0x0047D451
		public static VectorOffset CreateTagConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020528 RID: 132392 RVA: 0x0047F26F File Offset: 0x0047D46F
		public static VectorOffset CreateTagConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020529 RID: 132393 RVA: 0x0047F288 File Offset: 0x0047D488
		public static void StartTagConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602052A RID: 132394 RVA: 0x0047F293 File Offset: 0x0047D493
		public static void AddMatchConditions(FlatBufferBuilder builder, VectorOffset matchConditionsOffset)
		{
			builder.AddOffset(5, matchConditionsOffset.Value, 0);
		}

		// Token: 0x0602052B RID: 132395 RVA: 0x0047F2A4 File Offset: 0x0047D4A4
		public static VectorOffset CreateMatchConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602052C RID: 132396 RVA: 0x0047F2E4 File Offset: 0x0047D4E4
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602052D RID: 132397 RVA: 0x0047F2FE File Offset: 0x0047D4FE
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602052E RID: 132398 RVA: 0x0047F31C File Offset: 0x0047D51C
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602052F RID: 132399 RVA: 0x0047F335 File Offset: 0x0047D535
		public static void StartMatchConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020530 RID: 132400 RVA: 0x0047F340 File Offset: 0x0047D540
		public static void AddKeepConditions(FlatBufferBuilder builder, VectorOffset keepConditionsOffset)
		{
			builder.AddOffset(6, keepConditionsOffset.Value, 0);
		}

		// Token: 0x06020531 RID: 132401 RVA: 0x0047F350 File Offset: 0x0047D550
		public static VectorOffset CreateKeepConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020532 RID: 132402 RVA: 0x0047F390 File Offset: 0x0047D590
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020533 RID: 132403 RVA: 0x0047F3AA File Offset: 0x0047D5AA
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020534 RID: 132404 RVA: 0x0047F3C8 File Offset: 0x0047D5C8
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020535 RID: 132405 RVA: 0x0047F3E1 File Offset: 0x0047D5E1
		public static void StartKeepConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020536 RID: 132406 RVA: 0x0047F3EC File Offset: 0x0047D5EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06020537 RID: 132407 RVA: 0x0047F3F7 File Offset: 0x0047D5F7
		public static Offset<ICharacterConnectorRange> EndICharacterConnectorRange(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterConnectorRange>(builder.EndTable());
		}

		// Token: 0x06020538 RID: 132408 RVA: 0x0047F404 File Offset: 0x0047D604
		public ICharacterConnectorRangeT UnPack()
		{
			ICharacterConnectorRangeT characterConnectorRangeT = new ICharacterConnectorRangeT();
			this.UnPackTo(characterConnectorRangeT);
			return characterConnectorRangeT;
		}

		// Token: 0x06020539 RID: 132409 RVA: 0x0047F420 File Offset: 0x0047D620
		public void UnPackTo(ICharacterConnectorRangeT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.EnterRange = this.EnterRange;
			_o.LeaveRange = this.LeaveRange;
			_o.TagConditions = new List<int>();
			for (int i = 0; i < this.TagConditionsLength; i++)
			{
				_o.TagConditions.Add(this.TagConditions(i));
			}
			_o.MatchConditions = new List<IDynamicEntityMatchT>();
			for (int j = 0; j < this.MatchConditionsLength; j++)
			{
				_o.MatchConditions.Add((this.MatchConditions(j) != null) ? this.MatchConditions(j).Value.UnPack() : null);
			}
			_o.KeepConditions = new List<IDynamicEntityMatchT>();
			for (int k = 0; k < this.KeepConditionsLength; k++)
			{
				_o.KeepConditions.Add((this.KeepConditions(k) != null) ? this.KeepConditions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602053A RID: 132410 RVA: 0x0047F56C File Offset: 0x0047D76C
		public static Offset<ICharacterConnectorRange> Pack(FlatBufferBuilder builder, ICharacterConnectorRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterConnectorRange>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			VectorOffset tagConditionsOffset = default(VectorOffset);
			if (_o.TagConditions != null)
			{
				int[] data = _o.TagConditions.ToArray();
				tagConditionsOffset = ICharacterConnectorRange.CreateTagConditionsVector(builder, data);
			}
			VectorOffset matchConditionsOffset = default(VectorOffset);
			if (_o.MatchConditions != null)
			{
				Offset<IDynamicEntityMatch>[] array = new Offset<IDynamicEntityMatch>[_o.MatchConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicEntityMatch.Pack(builder, _o.MatchConditions[i]);
				}
				matchConditionsOffset = ICharacterConnectorRange.CreateMatchConditionsVector(builder, array);
			}
			VectorOffset keepConditionsOffset = default(VectorOffset);
			if (_o.KeepConditions != null)
			{
				Offset<IDynamicEntityMatch>[] array2 = new Offset<IDynamicEntityMatch>[_o.KeepConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IDynamicEntityMatch.Pack(builder, _o.KeepConditions[j]);
				}
				keepConditionsOffset = ICharacterConnectorRange.CreateKeepConditionsVector(builder, array2);
			}
			return ICharacterConnectorRange.CreateICharacterConnectorRange(builder, _o.Type, effectConfigOffset, _o.EnterRange, _o.LeaveRange, tagConditionsOffset, matchConditionsOffset, keepConditionsOffset, _o.NullMask);
		}

		// Token: 0x0400DE30 RID: 56880
		private Table __p;
	}
}
