using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553E RID: 21822
	public struct IComponentConfig : IFlatbufferObject
	{
		// Token: 0x17009C04 RID: 39940
		// (get) Token: 0x060229D1 RID: 141777 RVA: 0x004C4820 File Offset: 0x004C2A20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060229D2 RID: 141778 RVA: 0x004C482D File Offset: 0x004C2A2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060229D3 RID: 141779 RVA: 0x004C4834 File Offset: 0x004C2A34
		public static IComponentConfig GetRootAsIComponentConfig(ByteBuffer _bb)
		{
			return IComponentConfig.GetRootAsIComponentConfig(_bb, default(IComponentConfig));
		}

		// Token: 0x060229D4 RID: 141780 RVA: 0x004C4850 File Offset: 0x004C2A50
		public static IComponentConfig GetRootAsIComponentConfig(ByteBuffer _bb, IComponentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060229D5 RID: 141781 RVA: 0x004C486D File Offset: 0x004C2A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060229D6 RID: 141782 RVA: 0x004C487C File Offset: 0x004C2A7C
		public IComponentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060229D7 RID: 141783 RVA: 0x004C488C File Offset: 0x004C2A8C
		public EAction BaseActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EAction.Undefined;
			}
			return (EAction)this.__p.bb.GetUshort(this.__p.__vector(num) + j * 2);
		}

		// Token: 0x17009C05 RID: 39941
		// (get) Token: 0x060229D8 RID: 141784 RVA: 0x004C48CC File Offset: 0x004C2ACC
		public int BaseActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060229D9 RID: 141785 RVA: 0x004C48F7 File Offset: 0x004C2AF7
		public Span<EAction> GetBaseActionsBytes()
		{
			return this.__p.__vector_as_span<EAction>(4, 2);
		}

		// Token: 0x060229DA RID: 141786 RVA: 0x004C4908 File Offset: 0x004C2B08
		public EAction[] GetBaseActionsArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EAction[] array = new EAction[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EAction)this.__p.bb.GetUshort(num2 + i * 2);
			}
			return array;
		}

		// Token: 0x17009C06 RID: 39942
		// (get) Token: 0x060229DB RID: 141787 RVA: 0x004C4974 File Offset: 0x004C2B74
		public string ActionsByComponent
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

		// Token: 0x060229DC RID: 141788 RVA: 0x004C49AB File Offset: 0x004C2BAB
		public Span<byte> GetActionsByComponentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060229DD RID: 141789 RVA: 0x004C49BA File Offset: 0x004C2BBA
		public byte[] GetActionsByComponentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060229DE RID: 141790 RVA: 0x004C49C8 File Offset: 0x004C2BC8
		public static Offset<IComponentConfig> CreateIComponentConfig(FlatBufferBuilder builder, VectorOffset BaseActionsOffset = default(VectorOffset), StringOffset ActionsByComponentOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IComponentConfig.AddActionsByComponent(builder, ActionsByComponentOffset);
			IComponentConfig.AddBaseActions(builder, BaseActionsOffset);
			return IComponentConfig.EndIComponentConfig(builder);
		}

		// Token: 0x060229DF RID: 141791 RVA: 0x004C49E5 File Offset: 0x004C2BE5
		public static void StartIComponentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060229E0 RID: 141792 RVA: 0x004C49EE File Offset: 0x004C2BEE
		public static void AddBaseActions(FlatBufferBuilder builder, VectorOffset baseActionsOffset)
		{
			builder.AddOffset(0, baseActionsOffset.Value, 0);
		}

		// Token: 0x060229E1 RID: 141793 RVA: 0x004C4A00 File Offset: 0x004C2C00
		public static VectorOffset CreateBaseActionsVector(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddUshort((ushort)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060229E2 RID: 141794 RVA: 0x004C4A37 File Offset: 0x004C2C37
		public static VectorOffset CreateBaseActionsVectorBlock(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060229E3 RID: 141795 RVA: 0x004C4A51 File Offset: 0x004C2C51
		public static VectorOffset CreateBaseActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EAction> data)
		{
			builder.StartVector(2, data.Count, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060229E4 RID: 141796 RVA: 0x004C4A6F File Offset: 0x004C2C6F
		public static VectorOffset CreateBaseActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060229E5 RID: 141797 RVA: 0x004C4A88 File Offset: 0x004C2C88
		public static void StartBaseActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		// Token: 0x060229E6 RID: 141798 RVA: 0x004C4A93 File Offset: 0x004C2C93
		public static void AddActionsByComponent(FlatBufferBuilder builder, StringOffset actionsByComponentOffset)
		{
			builder.AddOffset(1, actionsByComponentOffset.Value, 0);
		}

		// Token: 0x060229E7 RID: 141799 RVA: 0x004C4AA3 File Offset: 0x004C2CA3
		public static Offset<IComponentConfig> EndIComponentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IComponentConfig>(builder.EndTable());
		}

		// Token: 0x060229E8 RID: 141800 RVA: 0x004C4AB0 File Offset: 0x004C2CB0
		public IComponentConfigT UnPack()
		{
			IComponentConfigT componentConfigT = new IComponentConfigT();
			this.UnPackTo(componentConfigT);
			return componentConfigT;
		}

		// Token: 0x060229E9 RID: 141801 RVA: 0x004C4ACC File Offset: 0x004C2CCC
		public void UnPackTo(IComponentConfigT _o)
		{
			_o.BaseActions = new List<EAction>();
			for (int i = 0; i < this.BaseActionsLength; i++)
			{
				_o.BaseActions.Add(this.BaseActions(i));
			}
			_o.ActionsByComponent = this.ActionsByComponent;
		}

		// Token: 0x060229EA RID: 141802 RVA: 0x004C4B14 File Offset: 0x004C2D14
		public static Offset<IComponentConfig> Pack(FlatBufferBuilder builder, IComponentConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComponentConfig>);
			}
			VectorOffset baseActionsOffset = default(VectorOffset);
			if (_o.BaseActions != null)
			{
				EAction[] data = _o.BaseActions.ToArray();
				baseActionsOffset = IComponentConfig.CreateBaseActionsVector(builder, data);
			}
			StringOffset actionsByComponentOffset = (_o.ActionsByComponent == null) ? default(StringOffset) : builder.CreateString(_o.ActionsByComponent);
			return IComponentConfig.CreateIComponentConfig(builder, baseActionsOffset, actionsByComponentOffset);
		}

		// Token: 0x0400EB8D RID: 60301
		private Table __p;
	}
}
