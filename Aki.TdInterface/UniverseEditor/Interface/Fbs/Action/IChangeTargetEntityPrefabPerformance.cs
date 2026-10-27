using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006326 RID: 25382
	public struct IChangeTargetEntityPrefabPerformance : IFlatbufferObject
	{
		// Token: 0x1700BD73 RID: 48499
		// (get) Token: 0x0602BE6F RID: 179823 RVA: 0x006091D1 File Offset: 0x006073D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE70 RID: 179824 RVA: 0x006091DE File Offset: 0x006073DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE71 RID: 179825 RVA: 0x006091E8 File Offset: 0x006073E8
		public static IChangeTargetEntityPrefabPerformance GetRootAsIChangeTargetEntityPrefabPerformance(ByteBuffer _bb)
		{
			return IChangeTargetEntityPrefabPerformance.GetRootAsIChangeTargetEntityPrefabPerformance(_bb, default(IChangeTargetEntityPrefabPerformance));
		}

		// Token: 0x0602BE72 RID: 179826 RVA: 0x00609204 File Offset: 0x00607404
		public static IChangeTargetEntityPrefabPerformance GetRootAsIChangeTargetEntityPrefabPerformance(ByteBuffer _bb, IChangeTargetEntityPrefabPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE73 RID: 179827 RVA: 0x00609221 File Offset: 0x00607421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE74 RID: 179828 RVA: 0x00609230 File Offset: 0x00607430
		public IChangeTargetEntityPrefabPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD74 RID: 48500
		// (get) Token: 0x0602BE75 RID: 179829 RVA: 0x00609240 File Offset: 0x00607440
		public EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return (EChangeEntityPrefabPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD75 RID: 48501
		// (get) Token: 0x0602BE76 RID: 179830 RVA: 0x0060927C File Offset: 0x0060747C
		public int EntityId
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

		// Token: 0x1700BD76 RID: 48502
		// (get) Token: 0x0602BE77 RID: 179831 RVA: 0x006092B8 File Offset: 0x006074B8
		public string PerformanceTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE78 RID: 179832 RVA: 0x006092EF File Offset: 0x006074EF
		public Span<byte> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602BE79 RID: 179833 RVA: 0x006092FE File Offset: 0x006074FE
		public byte[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602BE7A RID: 179834 RVA: 0x0060930C File Offset: 0x0060750C
		public static Offset<IChangeTargetEntityPrefabPerformance> CreateIChangeTargetEntityPrefabPerformance(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, int EntityId = 0, StringOffset PerformanceTagOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChangeTargetEntityPrefabPerformance.AddPerformanceTag(builder, PerformanceTagOffset);
			IChangeTargetEntityPrefabPerformance.AddEntityId(builder, EntityId);
			IChangeTargetEntityPrefabPerformance.AddType(builder, Type);
			return IChangeTargetEntityPrefabPerformance.EndIChangeTargetEntityPrefabPerformance(builder);
		}

		// Token: 0x0602BE7B RID: 179835 RVA: 0x00609330 File Offset: 0x00607530
		public static void StartIChangeTargetEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BE7C RID: 179836 RVA: 0x00609339 File Offset: 0x00607539
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BE7D RID: 179837 RVA: 0x00609344 File Offset: 0x00607544
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602BE7E RID: 179838 RVA: 0x0060934F File Offset: 0x0060754F
		public static void AddPerformanceTag(FlatBufferBuilder builder, StringOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602BE7F RID: 179839 RVA: 0x0060935F File Offset: 0x0060755F
		public static Offset<IChangeTargetEntityPrefabPerformance> EndIChangeTargetEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTargetEntityPrefabPerformance>(builder.EndTable());
		}

		// Token: 0x0602BE80 RID: 179840 RVA: 0x0060936C File Offset: 0x0060756C
		public IChangeTargetEntityPrefabPerformanceT UnPack()
		{
			IChangeTargetEntityPrefabPerformanceT changeTargetEntityPrefabPerformanceT = new IChangeTargetEntityPrefabPerformanceT();
			this.UnPackTo(changeTargetEntityPrefabPerformanceT);
			return changeTargetEntityPrefabPerformanceT;
		}

		// Token: 0x0602BE81 RID: 179841 RVA: 0x00609387 File Offset: 0x00607587
		public void UnPackTo(IChangeTargetEntityPrefabPerformanceT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PerformanceTag = this.PerformanceTag;
		}

		// Token: 0x0602BE82 RID: 179842 RVA: 0x006093B0 File Offset: 0x006075B0
		public static Offset<IChangeTargetEntityPrefabPerformance> Pack(FlatBufferBuilder builder, IChangeTargetEntityPrefabPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTargetEntityPrefabPerformance>);
			}
			StringOffset performanceTagOffset = (_o.PerformanceTag == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceTag);
			return IChangeTargetEntityPrefabPerformance.CreateIChangeTargetEntityPrefabPerformance(builder, _o.Type, _o.EntityId, performanceTagOffset);
		}

		// Token: 0x040108E7 RID: 67815
		private Table __p;
	}
}
