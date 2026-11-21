using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F9 RID: 20985
	public struct ITrafficMatchTargetByEntityLogic : IFlatbufferObject
	{
		// Token: 0x1700963A RID: 38458
		// (get) Token: 0x060210C9 RID: 135369 RVA: 0x00491354 File Offset: 0x0048F554
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060210CA RID: 135370 RVA: 0x00491361 File Offset: 0x0048F561
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060210CB RID: 135371 RVA: 0x00491368 File Offset: 0x0048F568
		public static ITrafficMatchTargetByEntityLogic GetRootAsITrafficMatchTargetByEntityLogic(ByteBuffer _bb)
		{
			return ITrafficMatchTargetByEntityLogic.GetRootAsITrafficMatchTargetByEntityLogic(_bb, default(ITrafficMatchTargetByEntityLogic));
		}

		// Token: 0x060210CC RID: 135372 RVA: 0x00491384 File Offset: 0x0048F584
		public static ITrafficMatchTargetByEntityLogic GetRootAsITrafficMatchTargetByEntityLogic(ByteBuffer _bb, ITrafficMatchTargetByEntityLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060210CD RID: 135373 RVA: 0x004913A1 File Offset: 0x0048F5A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060210CE RID: 135374 RVA: 0x004913B0 File Offset: 0x0048F5B0
		public ITrafficMatchTargetByEntityLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700963B RID: 38459
		// (get) Token: 0x060210CF RID: 135375 RVA: 0x004913C0 File Offset: 0x0048F5C0
		public ETrafficMatchTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrafficMatchTargetType.MatchByEntityLogic;
				}
				return (ETrafficMatchTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060210D0 RID: 135376 RVA: 0x004913FC File Offset: 0x0048F5FC
		public EEntityLogic EntityLogicTypes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return EEntityLogic.Item;
			}
			return (EEntityLogic)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700963C RID: 38460
		// (get) Token: 0x060210D1 RID: 135377 RVA: 0x0049143C File Offset: 0x0048F63C
		public int EntityLogicTypesLength
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

		// Token: 0x060210D2 RID: 135378 RVA: 0x00491467 File Offset: 0x0048F667
		public Span<EEntityLogic> GetEntityLogicTypesBytes()
		{
			return this.__p.__vector_as_span<EEntityLogic>(6, 1);
		}

		// Token: 0x060210D3 RID: 135379 RVA: 0x00491478 File Offset: 0x0048F678
		public EEntityLogic[] GetEntityLogicTypesArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EEntityLogic[] array = new EEntityLogic[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EEntityLogic)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060210D4 RID: 135380 RVA: 0x004914E1 File Offset: 0x0048F6E1
		public static Offset<ITrafficMatchTargetByEntityLogic> CreateITrafficMatchTargetByEntityLogic(FlatBufferBuilder builder, ETrafficMatchTargetType Type = ETrafficMatchTargetType.MatchByEntityLogic, VectorOffset EntityLogicTypesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITrafficMatchTargetByEntityLogic.AddEntityLogicTypes(builder, EntityLogicTypesOffset);
			ITrafficMatchTargetByEntityLogic.AddType(builder, Type);
			return ITrafficMatchTargetByEntityLogic.EndITrafficMatchTargetByEntityLogic(builder);
		}

		// Token: 0x060210D5 RID: 135381 RVA: 0x004914FE File Offset: 0x0048F6FE
		public static void StartITrafficMatchTargetByEntityLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060210D6 RID: 135382 RVA: 0x00491507 File Offset: 0x0048F707
		public static void AddType(FlatBufferBuilder builder, ETrafficMatchTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060210D7 RID: 135383 RVA: 0x00491512 File Offset: 0x0048F712
		public static void AddEntityLogicTypes(FlatBufferBuilder builder, VectorOffset entityLogicTypesOffset)
		{
			builder.AddOffset(1, entityLogicTypesOffset.Value, 0);
		}

		// Token: 0x060210D8 RID: 135384 RVA: 0x00491524 File Offset: 0x0048F724
		public static VectorOffset CreateEntityLogicTypesVector(FlatBufferBuilder builder, EEntityLogic[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060210D9 RID: 135385 RVA: 0x0049155B File Offset: 0x0048F75B
		public static VectorOffset CreateEntityLogicTypesVectorBlock(FlatBufferBuilder builder, EEntityLogic[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EEntityLogic>(data);
			return builder.EndVector();
		}

		// Token: 0x060210DA RID: 135386 RVA: 0x00491575 File Offset: 0x0048F775
		public static VectorOffset CreateEntityLogicTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<EEntityLogic> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EEntityLogic>(data);
			return builder.EndVector();
		}

		// Token: 0x060210DB RID: 135387 RVA: 0x00491593 File Offset: 0x0048F793
		public static VectorOffset CreateEntityLogicTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EEntityLogic>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060210DC RID: 135388 RVA: 0x004915AC File Offset: 0x0048F7AC
		public static void StartEntityLogicTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060210DD RID: 135389 RVA: 0x004915B7 File Offset: 0x0048F7B7
		public static Offset<ITrafficMatchTargetByEntityLogic> EndITrafficMatchTargetByEntityLogic(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficMatchTargetByEntityLogic>(builder.EndTable());
		}

		// Token: 0x060210DE RID: 135390 RVA: 0x004915C4 File Offset: 0x0048F7C4
		public ITrafficMatchTargetByEntityLogicT UnPack()
		{
			ITrafficMatchTargetByEntityLogicT trafficMatchTargetByEntityLogicT = new ITrafficMatchTargetByEntityLogicT();
			this.UnPackTo(trafficMatchTargetByEntityLogicT);
			return trafficMatchTargetByEntityLogicT;
		}

		// Token: 0x060210DF RID: 135391 RVA: 0x004915E0 File Offset: 0x0048F7E0
		public void UnPackTo(ITrafficMatchTargetByEntityLogicT _o)
		{
			_o.Type = this.Type;
			_o.EntityLogicTypes = new List<EEntityLogic>();
			for (int i = 0; i < this.EntityLogicTypesLength; i++)
			{
				_o.EntityLogicTypes.Add(this.EntityLogicTypes(i));
			}
		}

		// Token: 0x060210E0 RID: 135392 RVA: 0x00491628 File Offset: 0x0048F828
		public static Offset<ITrafficMatchTargetByEntityLogic> Pack(FlatBufferBuilder builder, ITrafficMatchTargetByEntityLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficMatchTargetByEntityLogic>);
			}
			VectorOffset entityLogicTypesOffset = default(VectorOffset);
			if (_o.EntityLogicTypes != null)
			{
				EEntityLogic[] data = _o.EntityLogicTypes.ToArray();
				entityLogicTypesOffset = ITrafficMatchTargetByEntityLogic.CreateEntityLogicTypesVector(builder, data);
			}
			return ITrafficMatchTargetByEntityLogic.CreateITrafficMatchTargetByEntityLogic(builder, _o.Type, entityLogicTypesOffset);
		}

		// Token: 0x0400E206 RID: 57862
		private Table __p;
	}
}
