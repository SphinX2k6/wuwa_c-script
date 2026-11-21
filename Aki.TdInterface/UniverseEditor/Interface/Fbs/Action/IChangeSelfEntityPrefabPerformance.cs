using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698E RID: 27022
	public struct IChangeSelfEntityPrefabPerformance : IFlatbufferObject
	{
		// Token: 0x1700C6F2 RID: 50930
		// (get) Token: 0x0602E59A RID: 189850 RVA: 0x00653C8A File Offset: 0x00651E8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E59B RID: 189851 RVA: 0x00653C97 File Offset: 0x00651E97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E59C RID: 189852 RVA: 0x00653CA0 File Offset: 0x00651EA0
		public static IChangeSelfEntityPrefabPerformance GetRootAsIChangeSelfEntityPrefabPerformance(ByteBuffer _bb)
		{
			return IChangeSelfEntityPrefabPerformance.GetRootAsIChangeSelfEntityPrefabPerformance(_bb, default(IChangeSelfEntityPrefabPerformance));
		}

		// Token: 0x0602E59D RID: 189853 RVA: 0x00653CBC File Offset: 0x00651EBC
		public static IChangeSelfEntityPrefabPerformance GetRootAsIChangeSelfEntityPrefabPerformance(ByteBuffer _bb, IChangeSelfEntityPrefabPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E59E RID: 189854 RVA: 0x00653CD9 File Offset: 0x00651ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E59F RID: 189855 RVA: 0x00653CE8 File Offset: 0x00651EE8
		public IChangeSelfEntityPrefabPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6F3 RID: 50931
		// (get) Token: 0x0602E5A0 RID: 189856 RVA: 0x00653CF8 File Offset: 0x00651EF8
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

		// Token: 0x1700C6F4 RID: 50932
		// (get) Token: 0x0602E5A1 RID: 189857 RVA: 0x00653D34 File Offset: 0x00651F34
		public string PerformanceTag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E5A2 RID: 189858 RVA: 0x00653D6B File Offset: 0x00651F6B
		public Span<byte> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E5A3 RID: 189859 RVA: 0x00653D7A File Offset: 0x00651F7A
		public byte[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E5A4 RID: 189860 RVA: 0x00653D88 File Offset: 0x00651F88
		public static Offset<IChangeSelfEntityPrefabPerformance> CreateIChangeSelfEntityPrefabPerformance(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, StringOffset PerformanceTagOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeSelfEntityPrefabPerformance.AddPerformanceTag(builder, PerformanceTagOffset);
			IChangeSelfEntityPrefabPerformance.AddType(builder, Type);
			return IChangeSelfEntityPrefabPerformance.EndIChangeSelfEntityPrefabPerformance(builder);
		}

		// Token: 0x0602E5A5 RID: 189861 RVA: 0x00653DA5 File Offset: 0x00651FA5
		public static void StartIChangeSelfEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E5A6 RID: 189862 RVA: 0x00653DAE File Offset: 0x00651FAE
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E5A7 RID: 189863 RVA: 0x00653DB9 File Offset: 0x00651FB9
		public static void AddPerformanceTag(FlatBufferBuilder builder, StringOffset performanceTagOffset)
		{
			builder.AddOffset(1, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602E5A8 RID: 189864 RVA: 0x00653DC9 File Offset: 0x00651FC9
		public static Offset<IChangeSelfEntityPrefabPerformance> EndIChangeSelfEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IChangeSelfEntityPrefabPerformance>(builder.EndTable());
		}

		// Token: 0x0602E5A9 RID: 189865 RVA: 0x00653DD8 File Offset: 0x00651FD8
		public IChangeSelfEntityPrefabPerformanceT UnPack()
		{
			IChangeSelfEntityPrefabPerformanceT changeSelfEntityPrefabPerformanceT = new IChangeSelfEntityPrefabPerformanceT();
			this.UnPackTo(changeSelfEntityPrefabPerformanceT);
			return changeSelfEntityPrefabPerformanceT;
		}

		// Token: 0x0602E5AA RID: 189866 RVA: 0x00653DF3 File Offset: 0x00651FF3
		public void UnPackTo(IChangeSelfEntityPrefabPerformanceT _o)
		{
			_o.Type = this.Type;
			_o.PerformanceTag = this.PerformanceTag;
		}

		// Token: 0x0602E5AB RID: 189867 RVA: 0x00653E10 File Offset: 0x00652010
		public static Offset<IChangeSelfEntityPrefabPerformance> Pack(FlatBufferBuilder builder, IChangeSelfEntityPrefabPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeSelfEntityPrefabPerformance>);
			}
			StringOffset performanceTagOffset = (_o.PerformanceTag == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceTag);
			return IChangeSelfEntityPrefabPerformance.CreateIChangeSelfEntityPrefabPerformance(builder, _o.Type, performanceTagOffset);
		}

		// Token: 0x040116F6 RID: 71414
		private Table __p;
	}
}
