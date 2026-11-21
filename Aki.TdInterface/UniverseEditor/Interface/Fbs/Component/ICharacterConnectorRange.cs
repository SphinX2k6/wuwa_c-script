using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B4 RID: 21684
	public struct ICharacterConnectorRange : IFlatbufferObject
	{
		// Token: 0x17009A95 RID: 39573
		// (get) Token: 0x0602225D RID: 139869 RVA: 0x004B4DDA File Offset: 0x004B2FDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602225E RID: 139870 RVA: 0x004B4DE7 File Offset: 0x004B2FE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602225F RID: 139871 RVA: 0x004B4DF0 File Offset: 0x004B2FF0
		public static ICharacterConnectorRange GetRootAsICharacterConnectorRange(ByteBuffer _bb)
		{
			return ICharacterConnectorRange.GetRootAsICharacterConnectorRange(_bb, default(ICharacterConnectorRange));
		}

		// Token: 0x06022260 RID: 139872 RVA: 0x004B4E0C File Offset: 0x004B300C
		public static ICharacterConnectorRange GetRootAsICharacterConnectorRange(ByteBuffer _bb, ICharacterConnectorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022261 RID: 139873 RVA: 0x004B4E29 File Offset: 0x004B3029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022262 RID: 139874 RVA: 0x004B4E38 File Offset: 0x004B3038
		public ICharacterConnectorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A96 RID: 39574
		// (get) Token: 0x06022263 RID: 139875 RVA: 0x004B4E48 File Offset: 0x004B3048
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

		// Token: 0x17009A97 RID: 39575
		// (get) Token: 0x06022264 RID: 139876 RVA: 0x004B4E84 File Offset: 0x004B3084
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

		// Token: 0x17009A98 RID: 39576
		// (get) Token: 0x06022265 RID: 139877 RVA: 0x004B4EE4 File Offset: 0x004B30E4
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

		// Token: 0x17009A99 RID: 39577
		// (get) Token: 0x06022266 RID: 139878 RVA: 0x004B4F20 File Offset: 0x004B3120
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

		// Token: 0x06022267 RID: 139879 RVA: 0x004B4F60 File Offset: 0x004B3160
		public int TagConditions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009A9A RID: 39578
		// (get) Token: 0x06022268 RID: 139880 RVA: 0x004B4FA0 File Offset: 0x004B31A0
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

		// Token: 0x06022269 RID: 139881 RVA: 0x004B4FCC File Offset: 0x004B31CC
		public Span<int> GetTagConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602226A RID: 139882 RVA: 0x004B4FDC File Offset: 0x004B31DC
		public int[] GetTagConditionsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602226B RID: 139883 RVA: 0x004B4FEC File Offset: 0x004B31EC
		public IDynamicEntityMatch? MatchConditions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009A9B RID: 39579
		// (get) Token: 0x0602226C RID: 139884 RVA: 0x004B5050 File Offset: 0x004B3250
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

		// Token: 0x0602226D RID: 139885 RVA: 0x004B507C File Offset: 0x004B327C
		public IDynamicEntityMatch? KeepConditions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009A9C RID: 39580
		// (get) Token: 0x0602226E RID: 139886 RVA: 0x004B50E0 File Offset: 0x004B32E0
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

		// Token: 0x17009A9D RID: 39581
		// (get) Token: 0x0602226F RID: 139887 RVA: 0x004B510C File Offset: 0x004B330C
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

		// Token: 0x06022270 RID: 139888 RVA: 0x004B514C File Offset: 0x004B334C
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

		// Token: 0x06022271 RID: 139889 RVA: 0x004B51A3 File Offset: 0x004B33A3
		public static void StartICharacterConnectorRange(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06022272 RID: 139890 RVA: 0x004B51AC File Offset: 0x004B33AC
		public static void AddType(FlatBufferBuilder builder, ECharacterConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022273 RID: 139891 RVA: 0x004B51B7 File Offset: 0x004B33B7
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06022274 RID: 139892 RVA: 0x004B51C7 File Offset: 0x004B33C7
		public static void AddEnterRange(FlatBufferBuilder builder, int enterRange)
		{
			builder.AddInt(2, enterRange, 0);
		}

		// Token: 0x06022275 RID: 139893 RVA: 0x004B51D2 File Offset: 0x004B33D2
		public static void AddLeaveRange(FlatBufferBuilder builder, int leaveRange)
		{
			builder.AddInt(3, leaveRange, 0);
		}

		// Token: 0x06022276 RID: 139894 RVA: 0x004B51DD File Offset: 0x004B33DD
		public static void AddTagConditions(FlatBufferBuilder builder, VectorOffset tagConditionsOffset)
		{
			builder.AddOffset(4, tagConditionsOffset.Value, 0);
		}

		// Token: 0x06022277 RID: 139895 RVA: 0x004B51F0 File Offset: 0x004B33F0
		public static VectorOffset CreateTagConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022278 RID: 139896 RVA: 0x004B5227 File Offset: 0x004B3427
		public static VectorOffset CreateTagConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022279 RID: 139897 RVA: 0x004B5241 File Offset: 0x004B3441
		public static VectorOffset CreateTagConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602227A RID: 139898 RVA: 0x004B525F File Offset: 0x004B345F
		public static VectorOffset CreateTagConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602227B RID: 139899 RVA: 0x004B5278 File Offset: 0x004B3478
		public static void StartTagConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602227C RID: 139900 RVA: 0x004B5283 File Offset: 0x004B3483
		public static void AddMatchConditions(FlatBufferBuilder builder, VectorOffset matchConditionsOffset)
		{
			builder.AddOffset(5, matchConditionsOffset.Value, 0);
		}

		// Token: 0x0602227D RID: 139901 RVA: 0x004B5294 File Offset: 0x004B3494
		public static VectorOffset CreateMatchConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602227E RID: 139902 RVA: 0x004B52D4 File Offset: 0x004B34D4
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602227F RID: 139903 RVA: 0x004B52EE File Offset: 0x004B34EE
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022280 RID: 139904 RVA: 0x004B530C File Offset: 0x004B350C
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022281 RID: 139905 RVA: 0x004B5325 File Offset: 0x004B3525
		public static void StartMatchConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022282 RID: 139906 RVA: 0x004B5330 File Offset: 0x004B3530
		public static void AddKeepConditions(FlatBufferBuilder builder, VectorOffset keepConditionsOffset)
		{
			builder.AddOffset(6, keepConditionsOffset.Value, 0);
		}

		// Token: 0x06022283 RID: 139907 RVA: 0x004B5340 File Offset: 0x004B3540
		public static VectorOffset CreateKeepConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022284 RID: 139908 RVA: 0x004B5380 File Offset: 0x004B3580
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022285 RID: 139909 RVA: 0x004B539A File Offset: 0x004B359A
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022286 RID: 139910 RVA: 0x004B53B8 File Offset: 0x004B35B8
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022287 RID: 139911 RVA: 0x004B53D1 File Offset: 0x004B35D1
		public static void StartKeepConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022288 RID: 139912 RVA: 0x004B53DC File Offset: 0x004B35DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06022289 RID: 139913 RVA: 0x004B53E7 File Offset: 0x004B35E7
		public static Offset<ICharacterConnectorRange> EndICharacterConnectorRange(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterConnectorRange>(builder.EndTable());
		}

		// Token: 0x0602228A RID: 139914 RVA: 0x004B53F4 File Offset: 0x004B35F4
		public ICharacterConnectorRangeT UnPack()
		{
			ICharacterConnectorRangeT characterConnectorRangeT = new ICharacterConnectorRangeT();
			this.UnPackTo(characterConnectorRangeT);
			return characterConnectorRangeT;
		}

		// Token: 0x0602228B RID: 139915 RVA: 0x004B5410 File Offset: 0x004B3610
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

		// Token: 0x0602228C RID: 139916 RVA: 0x004B555C File Offset: 0x004B375C
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

		// Token: 0x0400E9DA RID: 59866
		private Table __p;
	}
}
