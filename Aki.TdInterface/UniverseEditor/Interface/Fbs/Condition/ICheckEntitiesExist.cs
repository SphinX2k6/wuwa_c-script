using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F7 RID: 18935
	public struct ICheckEntitiesExist : IFlatbufferObject
	{
		// Token: 0x170088ED RID: 35053
		// (get) Token: 0x0601D958 RID: 121176 RVA: 0x00429DB8 File Offset: 0x00427FB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D959 RID: 121177 RVA: 0x00429DC5 File Offset: 0x00427FC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D95A RID: 121178 RVA: 0x00429DCC File Offset: 0x00427FCC
		public static ICheckEntitiesExist GetRootAsICheckEntitiesExist(ByteBuffer _bb)
		{
			return ICheckEntitiesExist.GetRootAsICheckEntitiesExist(_bb, default(ICheckEntitiesExist));
		}

		// Token: 0x0601D95B RID: 121179 RVA: 0x00429DE8 File Offset: 0x00427FE8
		public static ICheckEntitiesExist GetRootAsICheckEntitiesExist(ByteBuffer _bb, ICheckEntitiesExist obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D95C RID: 121180 RVA: 0x00429E05 File Offset: 0x00428005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D95D RID: 121181 RVA: 0x00429E14 File Offset: 0x00428014
		public ICheckEntitiesExist __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088EE RID: 35054
		// (get) Token: 0x0601D95E RID: 121182 RVA: 0x00429E24 File Offset: 0x00428024
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

		// Token: 0x0601D95F RID: 121183 RVA: 0x00429E60 File Offset: 0x00428060
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170088EF RID: 35055
		// (get) Token: 0x0601D960 RID: 121184 RVA: 0x00429EA0 File Offset: 0x004280A0
		public int EntityIdsLength
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

		// Token: 0x0601D961 RID: 121185 RVA: 0x00429ECB File Offset: 0x004280CB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601D962 RID: 121186 RVA: 0x00429EDA File Offset: 0x004280DA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170088F0 RID: 35056
		// (get) Token: 0x0601D963 RID: 121187 RVA: 0x00429EE8 File Offset: 0x004280E8
		public bool IsExist
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170088F1 RID: 35057
		// (get) Token: 0x0601D964 RID: 121188 RVA: 0x00429F28 File Offset: 0x00428128
		public bool IsFinishLoading
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170088F2 RID: 35058
		// (get) Token: 0x0601D965 RID: 121189 RVA: 0x00429F68 File Offset: 0x00428168
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D966 RID: 121190 RVA: 0x00429FA5 File Offset: 0x004281A5
		public static Offset<ICheckEntitiesExist> CreateICheckEntitiesExist(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset EntityIdsOffset = default(VectorOffset), bool IsExist = false, bool IsFinishLoading = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckEntitiesExist.AddEntityIds(builder, EntityIdsOffset);
			ICheckEntitiesExist.AddNullMask(builder, NullMask);
			ICheckEntitiesExist.AddIsFinishLoading(builder, IsFinishLoading);
			ICheckEntitiesExist.AddIsExist(builder, IsExist);
			ICheckEntitiesExist.AddType(builder, Type);
			return ICheckEntitiesExist.EndICheckEntitiesExist(builder);
		}

		// Token: 0x0601D967 RID: 121191 RVA: 0x00429FD9 File Offset: 0x004281D9
		public static void StartICheckEntitiesExist(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D968 RID: 121192 RVA: 0x00429FE2 File Offset: 0x004281E2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D969 RID: 121193 RVA: 0x00429FED File Offset: 0x004281ED
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601D96A RID: 121194 RVA: 0x0042A000 File Offset: 0x00428200
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D96B RID: 121195 RVA: 0x0042A037 File Offset: 0x00428237
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D96C RID: 121196 RVA: 0x0042A051 File Offset: 0x00428251
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D96D RID: 121197 RVA: 0x0042A06F File Offset: 0x0042826F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D96E RID: 121198 RVA: 0x0042A088 File Offset: 0x00428288
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D96F RID: 121199 RVA: 0x0042A093 File Offset: 0x00428293
		public static void AddIsExist(FlatBufferBuilder builder, bool isExist)
		{
			builder.AddBool(2, isExist, false);
		}

		// Token: 0x0601D970 RID: 121200 RVA: 0x0042A09E File Offset: 0x0042829E
		public static void AddIsFinishLoading(FlatBufferBuilder builder, bool isFinishLoading)
		{
			builder.AddBool(3, isFinishLoading, false);
		}

		// Token: 0x0601D971 RID: 121201 RVA: 0x0042A0A9 File Offset: 0x004282A9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601D972 RID: 121202 RVA: 0x0042A0B4 File Offset: 0x004282B4
		public static Offset<ICheckEntitiesExist> EndICheckEntitiesExist(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntitiesExist>(builder.EndTable());
		}

		// Token: 0x0601D973 RID: 121203 RVA: 0x0042A0C4 File Offset: 0x004282C4
		public ICheckEntitiesExistT UnPack()
		{
			ICheckEntitiesExistT checkEntitiesExistT = new ICheckEntitiesExistT();
			this.UnPackTo(checkEntitiesExistT);
			return checkEntitiesExistT;
		}

		// Token: 0x0601D974 RID: 121204 RVA: 0x0042A0E0 File Offset: 0x004282E0
		public void UnPackTo(ICheckEntitiesExistT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsExist = this.IsExist;
			_o.IsFinishLoading = this.IsFinishLoading;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D975 RID: 121205 RVA: 0x0042A14C File Offset: 0x0042834C
		public static Offset<ICheckEntitiesExist> Pack(FlatBufferBuilder builder, ICheckEntitiesExistT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntitiesExist>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ICheckEntitiesExist.CreateEntityIdsVector(builder, data);
			}
			return ICheckEntitiesExist.CreateICheckEntitiesExist(builder, _o.Type, entityIdsOffset, _o.IsExist, _o.IsFinishLoading, _o.NullMask);
		}

		// Token: 0x0400D22D RID: 53805
		private Table __p;
	}
}
