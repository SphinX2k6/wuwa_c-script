using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597E RID: 22910
	public struct IInhalationAbilityComponent : IFlatbufferObject
	{
		// Token: 0x1700A668 RID: 42600
		// (get) Token: 0x0602557F RID: 152959 RVA: 0x0052009A File Offset: 0x0051E29A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025580 RID: 152960 RVA: 0x005200A7 File Offset: 0x0051E2A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025581 RID: 152961 RVA: 0x005200B0 File Offset: 0x0051E2B0
		public static IInhalationAbilityComponent GetRootAsIInhalationAbilityComponent(ByteBuffer _bb)
		{
			return IInhalationAbilityComponent.GetRootAsIInhalationAbilityComponent(_bb, default(IInhalationAbilityComponent));
		}

		// Token: 0x06025582 RID: 152962 RVA: 0x005200CC File Offset: 0x0051E2CC
		public static IInhalationAbilityComponent GetRootAsIInhalationAbilityComponent(ByteBuffer _bb, IInhalationAbilityComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025583 RID: 152963 RVA: 0x005200E9 File Offset: 0x0051E2E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025584 RID: 152964 RVA: 0x005200F8 File Offset: 0x0051E2F8
		public IInhalationAbilityComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A669 RID: 42601
		// (get) Token: 0x06025585 RID: 152965 RVA: 0x00520108 File Offset: 0x0051E308
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025586 RID: 152966 RVA: 0x00520148 File Offset: 0x0051E348
		public IInhalationConfig? InhalationConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInhalationConfig?(default(IInhalationConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A66A RID: 42602
		// (get) Token: 0x06025587 RID: 152967 RVA: 0x005201A8 File Offset: 0x0051E3A8
		public int InhalationConfigsLength
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

		// Token: 0x1700A66B RID: 42603
		// (get) Token: 0x06025588 RID: 152968 RVA: 0x005201D4 File Offset: 0x0051E3D4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025589 RID: 152969 RVA: 0x00520210 File Offset: 0x0051E410
		public static Offset<IInhalationAbilityComponent> CreateIInhalationAbilityComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset InhalationConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IInhalationAbilityComponent.AddInhalationConfigs(builder, InhalationConfigsOffset);
			IInhalationAbilityComponent.AddNullMask(builder, NullMask);
			IInhalationAbilityComponent.AddDisabled(builder, Disabled);
			return IInhalationAbilityComponent.EndIInhalationAbilityComponent(builder);
		}

		// Token: 0x0602558A RID: 152970 RVA: 0x00520234 File Offset: 0x0051E434
		public static void StartIInhalationAbilityComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602558B RID: 152971 RVA: 0x0052023D File Offset: 0x0051E43D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602558C RID: 152972 RVA: 0x00520248 File Offset: 0x0051E448
		public static void AddInhalationConfigs(FlatBufferBuilder builder, VectorOffset inhalationConfigsOffset)
		{
			builder.AddOffset(1, inhalationConfigsOffset.Value, 0);
		}

		// Token: 0x0602558D RID: 152973 RVA: 0x00520258 File Offset: 0x0051E458
		public static VectorOffset CreateInhalationConfigsVector(FlatBufferBuilder builder, Offset<IInhalationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602558E RID: 152974 RVA: 0x00520298 File Offset: 0x0051E498
		public static VectorOffset CreateInhalationConfigsVectorBlock(FlatBufferBuilder builder, Offset<IInhalationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInhalationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602558F RID: 152975 RVA: 0x005202B2 File Offset: 0x0051E4B2
		public static VectorOffset CreateInhalationConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInhalationConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInhalationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025590 RID: 152976 RVA: 0x005202D0 File Offset: 0x0051E4D0
		public static VectorOffset CreateInhalationConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInhalationConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025591 RID: 152977 RVA: 0x005202E9 File Offset: 0x0051E4E9
		public static void StartInhalationConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025592 RID: 152978 RVA: 0x005202F4 File Offset: 0x0051E4F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025593 RID: 152979 RVA: 0x005202FF File Offset: 0x0051E4FF
		public static Offset<IInhalationAbilityComponent> EndIInhalationAbilityComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationAbilityComponent>(builder.EndTable());
		}

		// Token: 0x06025594 RID: 152980 RVA: 0x0052030C File Offset: 0x0051E50C
		public IInhalationAbilityComponentT UnPack()
		{
			IInhalationAbilityComponentT inhalationAbilityComponentT = new IInhalationAbilityComponentT();
			this.UnPackTo(inhalationAbilityComponentT);
			return inhalationAbilityComponentT;
		}

		// Token: 0x06025595 RID: 152981 RVA: 0x00520328 File Offset: 0x0051E528
		public void UnPackTo(IInhalationAbilityComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InhalationConfigs = new List<IInhalationConfigT>();
			for (int i = 0; i < this.InhalationConfigsLength; i++)
			{
				_o.InhalationConfigs.Add((this.InhalationConfigs(i) != null) ? this.InhalationConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025596 RID: 152982 RVA: 0x005203A0 File Offset: 0x0051E5A0
		public static Offset<IInhalationAbilityComponent> Pack(FlatBufferBuilder builder, IInhalationAbilityComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationAbilityComponent>);
			}
			VectorOffset inhalationConfigsOffset = default(VectorOffset);
			if (_o.InhalationConfigs != null)
			{
				Offset<IInhalationConfig>[] array = new Offset<IInhalationConfig>[_o.InhalationConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInhalationConfig.Pack(builder, _o.InhalationConfigs[i]);
				}
				inhalationConfigsOffset = IInhalationAbilityComponent.CreateInhalationConfigsVector(builder, array);
			}
			return IInhalationAbilityComponent.CreateIInhalationAbilityComponent(builder, _o.Disabled, inhalationConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F26C RID: 62060
		private Table __p;
	}
}
