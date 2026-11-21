using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006035 RID: 24629
	public struct ITargetGearGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700B6CA RID: 46794
		// (get) Token: 0x060298F2 RID: 170226 RVA: 0x005AC556 File Offset: 0x005AA756
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060298F3 RID: 170227 RVA: 0x005AC563 File Offset: 0x005AA763
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060298F4 RID: 170228 RVA: 0x005AC56C File Offset: 0x005AA76C
		public static ITargetGearGroupComponent GetRootAsITargetGearGroupComponent(ByteBuffer _bb)
		{
			return ITargetGearGroupComponent.GetRootAsITargetGearGroupComponent(_bb, default(ITargetGearGroupComponent));
		}

		// Token: 0x060298F5 RID: 170229 RVA: 0x005AC588 File Offset: 0x005AA788
		public static ITargetGearGroupComponent GetRootAsITargetGearGroupComponent(ByteBuffer _bb, ITargetGearGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060298F6 RID: 170230 RVA: 0x005AC5A5 File Offset: 0x005AA7A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060298F7 RID: 170231 RVA: 0x005AC5B4 File Offset: 0x005AA7B4
		public ITargetGearGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6CB RID: 46795
		// (get) Token: 0x060298F8 RID: 170232 RVA: 0x005AC5C4 File Offset: 0x005AA7C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6CC RID: 46796
		// (get) Token: 0x060298F9 RID: 170233 RVA: 0x005AC604 File Offset: 0x005AA804
		public string Type
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

		// Token: 0x060298FA RID: 170234 RVA: 0x005AC63B File Offset: 0x005AA83B
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060298FB RID: 170235 RVA: 0x005AC64A File Offset: 0x005AA84A
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060298FC RID: 170236 RVA: 0x005AC658 File Offset: 0x005AA858
		public ITargetGearGroupConfig? GroupConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITargetGearGroupConfig?(default(ITargetGearGroupConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B6CD RID: 46797
		// (get) Token: 0x060298FD RID: 170237 RVA: 0x005AC6B8 File Offset: 0x005AA8B8
		public int GroupConfigsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B6CE RID: 46798
		// (get) Token: 0x060298FE RID: 170238 RVA: 0x005AC6E4 File Offset: 0x005AA8E4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060298FF RID: 170239 RVA: 0x005AC721 File Offset: 0x005AA921
		public static Offset<ITargetGearGroupComponent> CreateITargetGearGroupComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset TypeOffset = default(StringOffset), VectorOffset GroupConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITargetGearGroupComponent.AddGroupConfigs(builder, GroupConfigsOffset);
			ITargetGearGroupComponent.AddType(builder, TypeOffset);
			ITargetGearGroupComponent.AddNullMask(builder, NullMask);
			ITargetGearGroupComponent.AddDisabled(builder, Disabled);
			return ITargetGearGroupComponent.EndITargetGearGroupComponent(builder);
		}

		// Token: 0x06029900 RID: 170240 RVA: 0x005AC74D File Offset: 0x005AA94D
		public static void StartITargetGearGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06029901 RID: 170241 RVA: 0x005AC756 File Offset: 0x005AA956
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029902 RID: 170242 RVA: 0x005AC761 File Offset: 0x005AA961
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(1, typeOffset.Value, 0);
		}

		// Token: 0x06029903 RID: 170243 RVA: 0x005AC771 File Offset: 0x005AA971
		public static void AddGroupConfigs(FlatBufferBuilder builder, VectorOffset groupConfigsOffset)
		{
			builder.AddOffset(2, groupConfigsOffset.Value, 0);
		}

		// Token: 0x06029904 RID: 170244 RVA: 0x005AC784 File Offset: 0x005AA984
		public static VectorOffset CreateGroupConfigsVector(FlatBufferBuilder builder, Offset<ITargetGearGroupConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029905 RID: 170245 RVA: 0x005AC7C4 File Offset: 0x005AA9C4
		public static VectorOffset CreateGroupConfigsVectorBlock(FlatBufferBuilder builder, Offset<ITargetGearGroupConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITargetGearGroupConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029906 RID: 170246 RVA: 0x005AC7DE File Offset: 0x005AA9DE
		public static VectorOffset CreateGroupConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITargetGearGroupConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITargetGearGroupConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029907 RID: 170247 RVA: 0x005AC7FC File Offset: 0x005AA9FC
		public static VectorOffset CreateGroupConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITargetGearGroupConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029908 RID: 170248 RVA: 0x005AC815 File Offset: 0x005AAA15
		public static void StartGroupConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029909 RID: 170249 RVA: 0x005AC820 File Offset: 0x005AAA20
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602990A RID: 170250 RVA: 0x005AC82B File Offset: 0x005AAA2B
		public static Offset<ITargetGearGroupComponent> EndITargetGearGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupComponent>(builder.EndTable());
		}

		// Token: 0x0602990B RID: 170251 RVA: 0x005AC838 File Offset: 0x005AAA38
		public ITargetGearGroupComponentT UnPack()
		{
			ITargetGearGroupComponentT targetGearGroupComponentT = new ITargetGearGroupComponentT();
			this.UnPackTo(targetGearGroupComponentT);
			return targetGearGroupComponentT;
		}

		// Token: 0x0602990C RID: 170252 RVA: 0x005AC854 File Offset: 0x005AAA54
		public void UnPackTo(ITargetGearGroupComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Type = this.Type;
			_o.GroupConfigs = new List<ITargetGearGroupConfigT>();
			for (int i = 0; i < this.GroupConfigsLength; i++)
			{
				_o.GroupConfigs.Add((this.GroupConfigs(i) != null) ? this.GroupConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602990D RID: 170253 RVA: 0x005AC8D8 File Offset: 0x005AAAD8
		public static Offset<ITargetGearGroupComponent> Pack(FlatBufferBuilder builder, ITargetGearGroupComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupComponent>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			VectorOffset groupConfigsOffset = default(VectorOffset);
			if (_o.GroupConfigs != null)
			{
				Offset<ITargetGearGroupConfig>[] array = new Offset<ITargetGearGroupConfig>[_o.GroupConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITargetGearGroupConfig.Pack(builder, _o.GroupConfigs[i]);
				}
				groupConfigsOffset = ITargetGearGroupComponent.CreateGroupConfigsVector(builder, array);
			}
			return ITargetGearGroupComponent.CreateITargetGearGroupComponent(builder, _o.Disabled, typeOffset, groupConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400FD81 RID: 64897
		private Table __p;
	}
}
