using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004214 RID: 16916
	public struct IDisableUro : IFlatbufferObject
	{
		// Token: 0x17007335 RID: 29493
		// (get) Token: 0x060177DE RID: 96222 RVA: 0x0035AB4B File Offset: 0x00358D4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060177DF RID: 96223 RVA: 0x0035AB58 File Offset: 0x00358D58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060177E0 RID: 96224 RVA: 0x0035AB60 File Offset: 0x00358D60
		public static IDisableUro GetRootAsIDisableUro(ByteBuffer _bb)
		{
			return IDisableUro.GetRootAsIDisableUro(_bb, default(IDisableUro));
		}

		// Token: 0x060177E1 RID: 96225 RVA: 0x0035AB7C File Offset: 0x00358D7C
		public static IDisableUro GetRootAsIDisableUro(ByteBuffer _bb, IDisableUro obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060177E2 RID: 96226 RVA: 0x0035AB99 File Offset: 0x00358D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060177E3 RID: 96227 RVA: 0x0035ABA8 File Offset: 0x00358DA8
		public IDisableUro __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007336 RID: 29494
		// (get) Token: 0x060177E4 RID: 96228 RVA: 0x0035ABB8 File Offset: 0x00358DB8
		public ELogicProgramSpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELogicProgramSpecialProcess.DisableURO;
				}
				return (ELogicProgramSpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060177E5 RID: 96229 RVA: 0x0035ABF4 File Offset: 0x00358DF4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007337 RID: 29495
		// (get) Token: 0x060177E6 RID: 96230 RVA: 0x0035AC34 File Offset: 0x00358E34
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

		// Token: 0x060177E7 RID: 96231 RVA: 0x0035AC5F File Offset: 0x00358E5F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060177E8 RID: 96232 RVA: 0x0035AC6E File Offset: 0x00358E6E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060177E9 RID: 96233 RVA: 0x0035AC7C File Offset: 0x00358E7C
		public static Offset<IDisableUro> CreateIDisableUro(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.DisableURO, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDisableUro.AddEntityIds(builder, EntityIdsOffset);
			IDisableUro.AddType(builder, Type);
			return IDisableUro.EndIDisableUro(builder);
		}

		// Token: 0x060177EA RID: 96234 RVA: 0x0035AC99 File Offset: 0x00358E99
		public static void StartIDisableUro(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060177EB RID: 96235 RVA: 0x0035ACA2 File Offset: 0x00358EA2
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060177EC RID: 96236 RVA: 0x0035ACAD File Offset: 0x00358EAD
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060177ED RID: 96237 RVA: 0x0035ACC0 File Offset: 0x00358EC0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060177EE RID: 96238 RVA: 0x0035ACF7 File Offset: 0x00358EF7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060177EF RID: 96239 RVA: 0x0035AD11 File Offset: 0x00358F11
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060177F0 RID: 96240 RVA: 0x0035AD2F File Offset: 0x00358F2F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060177F1 RID: 96241 RVA: 0x0035AD48 File Offset: 0x00358F48
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060177F2 RID: 96242 RVA: 0x0035AD53 File Offset: 0x00358F53
		public static Offset<IDisableUro> EndIDisableUro(FlatBufferBuilder builder)
		{
			return new Offset<IDisableUro>(builder.EndTable());
		}

		// Token: 0x060177F3 RID: 96243 RVA: 0x0035AD60 File Offset: 0x00358F60
		public IDisableUroT UnPack()
		{
			IDisableUroT disableUroT = new IDisableUroT();
			this.UnPackTo(disableUroT);
			return disableUroT;
		}

		// Token: 0x060177F4 RID: 96244 RVA: 0x0035AD7C File Offset: 0x00358F7C
		public void UnPackTo(IDisableUroT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060177F5 RID: 96245 RVA: 0x0035ADC4 File Offset: 0x00358FC4
		public static Offset<IDisableUro> Pack(FlatBufferBuilder builder, IDisableUroT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableUro>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IDisableUro.CreateEntityIdsVector(builder, data);
			}
			return IDisableUro.CreateIDisableUro(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400C0F4 RID: 49396
		private Table __p;
	}
}
