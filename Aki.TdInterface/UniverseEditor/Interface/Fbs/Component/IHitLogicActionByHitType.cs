using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538C RID: 21388
	public struct IHitLogicActionByHitType : IFlatbufferObject
	{
		// Token: 0x17009D2E RID: 40238
		// (get) Token: 0x0602305E RID: 143454 RVA: 0x004D9965 File Offset: 0x004D7B65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602305F RID: 143455 RVA: 0x004D9972 File Offset: 0x004D7B72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023060 RID: 143456 RVA: 0x004D997C File Offset: 0x004D7B7C
		public static IHitLogicActionByHitType GetRootAsIHitLogicActionByHitType(ByteBuffer _bb)
		{
			return IHitLogicActionByHitType.GetRootAsIHitLogicActionByHitType(_bb, default(IHitLogicActionByHitType));
		}

		// Token: 0x06023061 RID: 143457 RVA: 0x004D9998 File Offset: 0x004D7B98
		public static IHitLogicActionByHitType GetRootAsIHitLogicActionByHitType(ByteBuffer _bb, IHitLogicActionByHitType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023062 RID: 143458 RVA: 0x004D99B5 File Offset: 0x004D7BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023063 RID: 143459 RVA: 0x004D99C4 File Offset: 0x004D7BC4
		public IHitLogicActionByHitType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D2F RID: 40239
		// (get) Token: 0x06023064 RID: 143460 RVA: 0x004D99D4 File Offset: 0x004D7BD4
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023065 RID: 143461 RVA: 0x004D9A10 File Offset: 0x004D7C10
		public IActionByHitTypeConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionByHitTypeConfig?(default(IActionByHitTypeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D30 RID: 40240
		// (get) Token: 0x06023066 RID: 143462 RVA: 0x004D9A70 File Offset: 0x004D7C70
		public int ConfigsLength
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

		// Token: 0x06023067 RID: 143463 RVA: 0x004D9A9B File Offset: 0x004D7C9B
		public static Offset<IHitLogicActionByHitType> CreateIHitLogicActionByHitType(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHitLogicActionByHitType.AddConfigs(builder, ConfigsOffset);
			IHitLogicActionByHitType.AddType(builder, Type);
			return IHitLogicActionByHitType.EndIHitLogicActionByHitType(builder);
		}

		// Token: 0x06023068 RID: 143464 RVA: 0x004D9AB8 File Offset: 0x004D7CB8
		public static void StartIHitLogicActionByHitType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023069 RID: 143465 RVA: 0x004D9AC1 File Offset: 0x004D7CC1
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602306A RID: 143466 RVA: 0x004D9ACC File Offset: 0x004D7CCC
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x0602306B RID: 143467 RVA: 0x004D9ADC File Offset: 0x004D7CDC
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IActionByHitTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602306C RID: 143468 RVA: 0x004D9B1C File Offset: 0x004D7D1C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IActionByHitTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionByHitTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602306D RID: 143469 RVA: 0x004D9B36 File Offset: 0x004D7D36
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionByHitTypeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionByHitTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602306E RID: 143470 RVA: 0x004D9B54 File Offset: 0x004D7D54
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionByHitTypeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602306F RID: 143471 RVA: 0x004D9B6D File Offset: 0x004D7D6D
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023070 RID: 143472 RVA: 0x004D9B78 File Offset: 0x004D7D78
		public static Offset<IHitLogicActionByHitType> EndIHitLogicActionByHitType(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicActionByHitType>(builder.EndTable());
		}

		// Token: 0x06023071 RID: 143473 RVA: 0x004D9B88 File Offset: 0x004D7D88
		public IHitLogicActionByHitTypeT UnPack()
		{
			IHitLogicActionByHitTypeT hitLogicActionByHitTypeT = new IHitLogicActionByHitTypeT();
			this.UnPackTo(hitLogicActionByHitTypeT);
			return hitLogicActionByHitTypeT;
		}

		// Token: 0x06023072 RID: 143474 RVA: 0x004D9BA4 File Offset: 0x004D7DA4
		public void UnPackTo(IHitLogicActionByHitTypeT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<IActionByHitTypeConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023073 RID: 143475 RVA: 0x004D9C10 File Offset: 0x004D7E10
		public static Offset<IHitLogicActionByHitType> Pack(FlatBufferBuilder builder, IHitLogicActionByHitTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicActionByHitType>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<IActionByHitTypeConfig>[] array = new Offset<IActionByHitTypeConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionByHitTypeConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = IHitLogicActionByHitType.CreateConfigsVector(builder, array);
			}
			return IHitLogicActionByHitType.CreateIHitLogicActionByHitType(builder, _o.Type, configsOffset);
		}

		// Token: 0x0400E578 RID: 58744
		private Table __p;
	}
}
