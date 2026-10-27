using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FDF RID: 20447
	public struct IComponentConfig : IFlatbufferObject
	{
		// Token: 0x17009423 RID: 37923
		// (get) Token: 0x06020AB1 RID: 133809 RVA: 0x0048ADCE File Offset: 0x00488FCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AB2 RID: 133810 RVA: 0x0048ADDB File Offset: 0x00488FDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AB3 RID: 133811 RVA: 0x0048ADE4 File Offset: 0x00488FE4
		public static IComponentConfig GetRootAsIComponentConfig(ByteBuffer _bb)
		{
			return IComponentConfig.GetRootAsIComponentConfig(_bb, default(IComponentConfig));
		}

		// Token: 0x06020AB4 RID: 133812 RVA: 0x0048AE00 File Offset: 0x00489000
		public static IComponentConfig GetRootAsIComponentConfig(ByteBuffer _bb, IComponentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020AB5 RID: 133813 RVA: 0x0048AE1D File Offset: 0x0048901D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020AB6 RID: 133814 RVA: 0x0048AE2C File Offset: 0x0048902C
		public IComponentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06020AB7 RID: 133815 RVA: 0x0048AE3C File Offset: 0x0048903C
		public EAction BaseActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EAction.Undefined;
			}
			return (EAction)this.__p.bb.GetUshort(this.__p.__vector(num) + j * 2);
		}

		// Token: 0x17009424 RID: 37924
		// (get) Token: 0x06020AB8 RID: 133816 RVA: 0x0048AE7C File Offset: 0x0048907C
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

		// Token: 0x06020AB9 RID: 133817 RVA: 0x0048AEA7 File Offset: 0x004890A7
		public Span<EAction> GetBaseActionsBytes()
		{
			return this.__p.__vector_as_span<EAction>(4, 2);
		}

		// Token: 0x06020ABA RID: 133818 RVA: 0x0048AEB8 File Offset: 0x004890B8
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

		// Token: 0x17009425 RID: 37925
		// (get) Token: 0x06020ABB RID: 133819 RVA: 0x0048AF24 File Offset: 0x00489124
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

		// Token: 0x06020ABC RID: 133820 RVA: 0x0048AF5B File Offset: 0x0048915B
		public Span<byte> GetActionsByComponentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020ABD RID: 133821 RVA: 0x0048AF6A File Offset: 0x0048916A
		public byte[] GetActionsByComponentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06020ABE RID: 133822 RVA: 0x0048AF78 File Offset: 0x00489178
		public static Offset<IComponentConfig> CreateIComponentConfig(FlatBufferBuilder builder, VectorOffset BaseActionsOffset = default(VectorOffset), StringOffset ActionsByComponentOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IComponentConfig.AddActionsByComponent(builder, ActionsByComponentOffset);
			IComponentConfig.AddBaseActions(builder, BaseActionsOffset);
			return IComponentConfig.EndIComponentConfig(builder);
		}

		// Token: 0x06020ABF RID: 133823 RVA: 0x0048AF95 File Offset: 0x00489195
		public static void StartIComponentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020AC0 RID: 133824 RVA: 0x0048AF9E File Offset: 0x0048919E
		public static void AddBaseActions(FlatBufferBuilder builder, VectorOffset baseActionsOffset)
		{
			builder.AddOffset(0, baseActionsOffset.Value, 0);
		}

		// Token: 0x06020AC1 RID: 133825 RVA: 0x0048AFB0 File Offset: 0x004891B0
		public static VectorOffset CreateBaseActionsVector(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddUshort((ushort)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020AC2 RID: 133826 RVA: 0x0048AFE7 File Offset: 0x004891E7
		public static VectorOffset CreateBaseActionsVectorBlock(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06020AC3 RID: 133827 RVA: 0x0048B001 File Offset: 0x00489201
		public static VectorOffset CreateBaseActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EAction> data)
		{
			builder.StartVector(2, data.Count, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06020AC4 RID: 133828 RVA: 0x0048B01F File Offset: 0x0048921F
		public static VectorOffset CreateBaseActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020AC5 RID: 133829 RVA: 0x0048B038 File Offset: 0x00489238
		public static void StartBaseActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		// Token: 0x06020AC6 RID: 133830 RVA: 0x0048B043 File Offset: 0x00489243
		public static void AddActionsByComponent(FlatBufferBuilder builder, StringOffset actionsByComponentOffset)
		{
			builder.AddOffset(1, actionsByComponentOffset.Value, 0);
		}

		// Token: 0x06020AC7 RID: 133831 RVA: 0x0048B053 File Offset: 0x00489253
		public static Offset<IComponentConfig> EndIComponentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IComponentConfig>(builder.EndTable());
		}

		// Token: 0x06020AC8 RID: 133832 RVA: 0x0048B060 File Offset: 0x00489260
		public IComponentConfigT UnPack()
		{
			IComponentConfigT componentConfigT = new IComponentConfigT();
			this.UnPackTo(componentConfigT);
			return componentConfigT;
		}

		// Token: 0x06020AC9 RID: 133833 RVA: 0x0048B07C File Offset: 0x0048927C
		public void UnPackTo(IComponentConfigT _o)
		{
			_o.BaseActions = new List<EAction>();
			for (int i = 0; i < this.BaseActionsLength; i++)
			{
				_o.BaseActions.Add(this.BaseActions(i));
			}
			_o.ActionsByComponent = this.ActionsByComponent;
		}

		// Token: 0x06020ACA RID: 133834 RVA: 0x0048B0C4 File Offset: 0x004892C4
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

		// Token: 0x0400DF97 RID: 57239
		private Table __p;
	}
}
