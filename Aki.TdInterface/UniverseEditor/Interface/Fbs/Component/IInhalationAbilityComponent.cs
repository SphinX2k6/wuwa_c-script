using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F8 RID: 21496
	public struct IInhalationAbilityComponent : IFlatbufferObject
	{
		// Token: 0x17009E2E RID: 40494
		// (get) Token: 0x060234C7 RID: 144583 RVA: 0x004E306E File Offset: 0x004E126E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060234C8 RID: 144584 RVA: 0x004E307B File Offset: 0x004E127B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060234C9 RID: 144585 RVA: 0x004E3084 File Offset: 0x004E1284
		public static IInhalationAbilityComponent GetRootAsIInhalationAbilityComponent(ByteBuffer _bb)
		{
			return IInhalationAbilityComponent.GetRootAsIInhalationAbilityComponent(_bb, default(IInhalationAbilityComponent));
		}

		// Token: 0x060234CA RID: 144586 RVA: 0x004E30A0 File Offset: 0x004E12A0
		public static IInhalationAbilityComponent GetRootAsIInhalationAbilityComponent(ByteBuffer _bb, IInhalationAbilityComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060234CB RID: 144587 RVA: 0x004E30BD File Offset: 0x004E12BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060234CC RID: 144588 RVA: 0x004E30CC File Offset: 0x004E12CC
		public IInhalationAbilityComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E2F RID: 40495
		// (get) Token: 0x060234CD RID: 144589 RVA: 0x004E30DC File Offset: 0x004E12DC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060234CE RID: 144590 RVA: 0x004E311C File Offset: 0x004E131C
		public IInhalationConfig? InhalationConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInhalationConfig?(default(IInhalationConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E30 RID: 40496
		// (get) Token: 0x060234CF RID: 144591 RVA: 0x004E317C File Offset: 0x004E137C
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

		// Token: 0x17009E31 RID: 40497
		// (get) Token: 0x060234D0 RID: 144592 RVA: 0x004E31A8 File Offset: 0x004E13A8
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

		// Token: 0x060234D1 RID: 144593 RVA: 0x004E31E4 File Offset: 0x004E13E4
		public static Offset<IInhalationAbilityComponent> CreateIInhalationAbilityComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset InhalationConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IInhalationAbilityComponent.AddInhalationConfigs(builder, InhalationConfigsOffset);
			IInhalationAbilityComponent.AddNullMask(builder, NullMask);
			IInhalationAbilityComponent.AddDisabled(builder, Disabled);
			return IInhalationAbilityComponent.EndIInhalationAbilityComponent(builder);
		}

		// Token: 0x060234D2 RID: 144594 RVA: 0x004E3208 File Offset: 0x004E1408
		public static void StartIInhalationAbilityComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060234D3 RID: 144595 RVA: 0x004E3211 File Offset: 0x004E1411
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060234D4 RID: 144596 RVA: 0x004E321C File Offset: 0x004E141C
		public static void AddInhalationConfigs(FlatBufferBuilder builder, VectorOffset inhalationConfigsOffset)
		{
			builder.AddOffset(1, inhalationConfigsOffset.Value, 0);
		}

		// Token: 0x060234D5 RID: 144597 RVA: 0x004E322C File Offset: 0x004E142C
		public static VectorOffset CreateInhalationConfigsVector(FlatBufferBuilder builder, Offset<IInhalationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060234D6 RID: 144598 RVA: 0x004E326C File Offset: 0x004E146C
		public static VectorOffset CreateInhalationConfigsVectorBlock(FlatBufferBuilder builder, Offset<IInhalationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInhalationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060234D7 RID: 144599 RVA: 0x004E3286 File Offset: 0x004E1486
		public static VectorOffset CreateInhalationConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInhalationConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInhalationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060234D8 RID: 144600 RVA: 0x004E32A4 File Offset: 0x004E14A4
		public static VectorOffset CreateInhalationConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInhalationConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060234D9 RID: 144601 RVA: 0x004E32BD File Offset: 0x004E14BD
		public static void StartInhalationConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060234DA RID: 144602 RVA: 0x004E32C8 File Offset: 0x004E14C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060234DB RID: 144603 RVA: 0x004E32D3 File Offset: 0x004E14D3
		public static Offset<IInhalationAbilityComponent> EndIInhalationAbilityComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationAbilityComponent>(builder.EndTable());
		}

		// Token: 0x060234DC RID: 144604 RVA: 0x004E32E0 File Offset: 0x004E14E0
		public IInhalationAbilityComponentT UnPack()
		{
			IInhalationAbilityComponentT inhalationAbilityComponentT = new IInhalationAbilityComponentT();
			this.UnPackTo(inhalationAbilityComponentT);
			return inhalationAbilityComponentT;
		}

		// Token: 0x060234DD RID: 144605 RVA: 0x004E32FC File Offset: 0x004E14FC
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

		// Token: 0x060234DE RID: 144606 RVA: 0x004E3374 File Offset: 0x004E1574
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

		// Token: 0x0400E63B RID: 58939
		private Table __p;
	}
}
