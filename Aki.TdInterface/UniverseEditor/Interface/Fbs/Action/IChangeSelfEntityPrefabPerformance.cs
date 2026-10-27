using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200631D RID: 25373
	public struct IChangeSelfEntityPrefabPerformance : IFlatbufferObject
	{
		// Token: 0x1700BD68 RID: 48488
		// (get) Token: 0x0602BE31 RID: 179761 RVA: 0x00608C7E File Offset: 0x00606E7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE32 RID: 179762 RVA: 0x00608C8B File Offset: 0x00606E8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE33 RID: 179763 RVA: 0x00608C94 File Offset: 0x00606E94
		public static IChangeSelfEntityPrefabPerformance GetRootAsIChangeSelfEntityPrefabPerformance(ByteBuffer _bb)
		{
			return IChangeSelfEntityPrefabPerformance.GetRootAsIChangeSelfEntityPrefabPerformance(_bb, default(IChangeSelfEntityPrefabPerformance));
		}

		// Token: 0x0602BE34 RID: 179764 RVA: 0x00608CB0 File Offset: 0x00606EB0
		public static IChangeSelfEntityPrefabPerformance GetRootAsIChangeSelfEntityPrefabPerformance(ByteBuffer _bb, IChangeSelfEntityPrefabPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE35 RID: 179765 RVA: 0x00608CCD File Offset: 0x00606ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE36 RID: 179766 RVA: 0x00608CDC File Offset: 0x00606EDC
		public IChangeSelfEntityPrefabPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD69 RID: 48489
		// (get) Token: 0x0602BE37 RID: 179767 RVA: 0x00608CEC File Offset: 0x00606EEC
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

		// Token: 0x1700BD6A RID: 48490
		// (get) Token: 0x0602BE38 RID: 179768 RVA: 0x00608D28 File Offset: 0x00606F28
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

		// Token: 0x0602BE39 RID: 179769 RVA: 0x00608D5F File Offset: 0x00606F5F
		public Span<byte> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602BE3A RID: 179770 RVA: 0x00608D6E File Offset: 0x00606F6E
		public byte[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602BE3B RID: 179771 RVA: 0x00608D7C File Offset: 0x00606F7C
		public static Offset<IChangeSelfEntityPrefabPerformance> CreateIChangeSelfEntityPrefabPerformance(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, StringOffset PerformanceTagOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeSelfEntityPrefabPerformance.AddPerformanceTag(builder, PerformanceTagOffset);
			IChangeSelfEntityPrefabPerformance.AddType(builder, Type);
			return IChangeSelfEntityPrefabPerformance.EndIChangeSelfEntityPrefabPerformance(builder);
		}

		// Token: 0x0602BE3C RID: 179772 RVA: 0x00608D99 File Offset: 0x00606F99
		public static void StartIChangeSelfEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BE3D RID: 179773 RVA: 0x00608DA2 File Offset: 0x00606FA2
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BE3E RID: 179774 RVA: 0x00608DAD File Offset: 0x00606FAD
		public static void AddPerformanceTag(FlatBufferBuilder builder, StringOffset performanceTagOffset)
		{
			builder.AddOffset(1, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602BE3F RID: 179775 RVA: 0x00608DBD File Offset: 0x00606FBD
		public static Offset<IChangeSelfEntityPrefabPerformance> EndIChangeSelfEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IChangeSelfEntityPrefabPerformance>(builder.EndTable());
		}

		// Token: 0x0602BE40 RID: 179776 RVA: 0x00608DCC File Offset: 0x00606FCC
		public IChangeSelfEntityPrefabPerformanceT UnPack()
		{
			IChangeSelfEntityPrefabPerformanceT changeSelfEntityPrefabPerformanceT = new IChangeSelfEntityPrefabPerformanceT();
			this.UnPackTo(changeSelfEntityPrefabPerformanceT);
			return changeSelfEntityPrefabPerformanceT;
		}

		// Token: 0x0602BE41 RID: 179777 RVA: 0x00608DE7 File Offset: 0x00606FE7
		public void UnPackTo(IChangeSelfEntityPrefabPerformanceT _o)
		{
			_o.Type = this.Type;
			_o.PerformanceTag = this.PerformanceTag;
		}

		// Token: 0x0602BE42 RID: 179778 RVA: 0x00608E04 File Offset: 0x00607004
		public static Offset<IChangeSelfEntityPrefabPerformance> Pack(FlatBufferBuilder builder, IChangeSelfEntityPrefabPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeSelfEntityPrefabPerformance>);
			}
			StringOffset performanceTagOffset = (_o.PerformanceTag == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceTag);
			return IChangeSelfEntityPrefabPerformance.CreateIChangeSelfEntityPrefabPerformance(builder, _o.Type, performanceTagOffset);
		}

		// Token: 0x040108E0 RID: 67808
		private Table __p;
	}
}
