using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584A RID: 22602
	public struct IFrequencyPaintConnectLine : IFlatbufferObject
	{
		// Token: 0x1700A3B9 RID: 41913
		// (get) Token: 0x060249E3 RID: 149987 RVA: 0x00508217 File Offset: 0x00506417
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060249E4 RID: 149988 RVA: 0x00508224 File Offset: 0x00506424
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060249E5 RID: 149989 RVA: 0x0050822C File Offset: 0x0050642C
		public static IFrequencyPaintConnectLine GetRootAsIFrequencyPaintConnectLine(ByteBuffer _bb)
		{
			return IFrequencyPaintConnectLine.GetRootAsIFrequencyPaintConnectLine(_bb, default(IFrequencyPaintConnectLine));
		}

		// Token: 0x060249E6 RID: 149990 RVA: 0x00508248 File Offset: 0x00506448
		public static IFrequencyPaintConnectLine GetRootAsIFrequencyPaintConnectLine(ByteBuffer _bb, IFrequencyPaintConnectLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060249E7 RID: 149991 RVA: 0x00508265 File Offset: 0x00506465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060249E8 RID: 149992 RVA: 0x00508274 File Offset: 0x00506474
		public IFrequencyPaintConnectLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3BA RID: 41914
		// (get) Token: 0x060249E9 RID: 149993 RVA: 0x00508284 File Offset: 0x00506484
		public EFrequencyPaintLineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFrequencyPaintLineType.Straight;
				}
				return (EFrequencyPaintLineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A3BB RID: 41915
		// (get) Token: 0x060249EA RID: 149994 RVA: 0x005082C0 File Offset: 0x005064C0
		public int EntityTarget
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

		// Token: 0x1700A3BC RID: 41916
		// (get) Token: 0x060249EB RID: 149995 RVA: 0x005082FC File Offset: 0x005064FC
		public string EntityState
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

		// Token: 0x060249EC RID: 149996 RVA: 0x00508333 File Offset: 0x00506533
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060249ED RID: 149997 RVA: 0x00508342 File Offset: 0x00506542
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060249EE RID: 149998 RVA: 0x00508350 File Offset: 0x00506550
		public static Offset<IFrequencyPaintConnectLine> CreateIFrequencyPaintConnectLine(FlatBufferBuilder builder, EFrequencyPaintLineType Type = EFrequencyPaintLineType.Straight, int EntityTarget = 0, StringOffset EntityStateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFrequencyPaintConnectLine.AddEntityState(builder, EntityStateOffset);
			IFrequencyPaintConnectLine.AddEntityTarget(builder, EntityTarget);
			IFrequencyPaintConnectLine.AddType(builder, Type);
			return IFrequencyPaintConnectLine.EndIFrequencyPaintConnectLine(builder);
		}

		// Token: 0x060249EF RID: 149999 RVA: 0x00508374 File Offset: 0x00506574
		public static void StartIFrequencyPaintConnectLine(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060249F0 RID: 150000 RVA: 0x0050837D File Offset: 0x0050657D
		public static void AddType(FlatBufferBuilder builder, EFrequencyPaintLineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060249F1 RID: 150001 RVA: 0x00508388 File Offset: 0x00506588
		public static void AddEntityTarget(FlatBufferBuilder builder, int entityTarget)
		{
			builder.AddInt(1, entityTarget, 0);
		}

		// Token: 0x060249F2 RID: 150002 RVA: 0x00508393 File Offset: 0x00506593
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(2, entityStateOffset.Value, 0);
		}

		// Token: 0x060249F3 RID: 150003 RVA: 0x005083A3 File Offset: 0x005065A3
		public static Offset<IFrequencyPaintConnectLine> EndIFrequencyPaintConnectLine(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintConnectLine>(builder.EndTable());
		}

		// Token: 0x060249F4 RID: 150004 RVA: 0x005083B0 File Offset: 0x005065B0
		public IFrequencyPaintConnectLineT UnPack()
		{
			IFrequencyPaintConnectLineT frequencyPaintConnectLineT = new IFrequencyPaintConnectLineT();
			this.UnPackTo(frequencyPaintConnectLineT);
			return frequencyPaintConnectLineT;
		}

		// Token: 0x060249F5 RID: 150005 RVA: 0x005083CB File Offset: 0x005065CB
		public void UnPackTo(IFrequencyPaintConnectLineT _o)
		{
			_o.Type = this.Type;
			_o.EntityTarget = this.EntityTarget;
			_o.EntityState = this.EntityState;
		}

		// Token: 0x060249F6 RID: 150006 RVA: 0x005083F4 File Offset: 0x005065F4
		public static Offset<IFrequencyPaintConnectLine> Pack(FlatBufferBuilder builder, IFrequencyPaintConnectLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintConnectLine>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			return IFrequencyPaintConnectLine.CreateIFrequencyPaintConnectLine(builder, _o.Type, _o.EntityTarget, entityStateOffset);
		}

		// Token: 0x0400F086 RID: 61574
		private Table __p;
	}
}
