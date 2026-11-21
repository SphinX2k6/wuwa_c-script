using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D0 RID: 22736
	public struct IGroupDestroyListenConfig : IFlatbufferObject
	{
		// Token: 0x1700A4E3 RID: 42211
		// (get) Token: 0x06024EBA RID: 151226 RVA: 0x00511BE3 File Offset: 0x0050FDE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024EBB RID: 151227 RVA: 0x00511BF0 File Offset: 0x0050FDF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024EBC RID: 151228 RVA: 0x00511BF8 File Offset: 0x0050FDF8
		public static IGroupDestroyListenConfig GetRootAsIGroupDestroyListenConfig(ByteBuffer _bb)
		{
			return IGroupDestroyListenConfig.GetRootAsIGroupDestroyListenConfig(_bb, default(IGroupDestroyListenConfig));
		}

		// Token: 0x06024EBD RID: 151229 RVA: 0x00511C14 File Offset: 0x0050FE14
		public static IGroupDestroyListenConfig GetRootAsIGroupDestroyListenConfig(ByteBuffer _bb, IGroupDestroyListenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024EBE RID: 151230 RVA: 0x00511C31 File Offset: 0x0050FE31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024EBF RID: 151231 RVA: 0x00511C40 File Offset: 0x0050FE40
		public IGroupDestroyListenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4E4 RID: 42212
		// (get) Token: 0x06024EC0 RID: 151232 RVA: 0x00511C50 File Offset: 0x0050FE50
		public ETemplateEntityGroupType GroupType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETemplateEntityGroupType.None;
				}
				return (ETemplateEntityGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024EC1 RID: 151233 RVA: 0x00511C8C File Offset: 0x0050FE8C
		public IActionInfo? OnTriggerActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A4E5 RID: 42213
		// (get) Token: 0x06024EC2 RID: 151234 RVA: 0x00511CEC File Offset: 0x0050FEEC
		public int OnTriggerActionsLength
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

		// Token: 0x1700A4E6 RID: 42214
		// (get) Token: 0x06024EC3 RID: 151235 RVA: 0x00511D18 File Offset: 0x0050FF18
		public IChangeTemplateInstanceStateConfig? ChangeInstanceStateConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IChangeTemplateInstanceStateConfig?(default(IChangeTemplateInstanceStateConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024EC4 RID: 151236 RVA: 0x00511D75 File Offset: 0x0050FF75
		public static Offset<IGroupDestroyListenConfig> CreateIGroupDestroyListenConfig(FlatBufferBuilder builder, ETemplateEntityGroupType GroupType = ETemplateEntityGroupType.None, VectorOffset OnTriggerActionsOffset = default(VectorOffset), Offset<IChangeTemplateInstanceStateConfig> ChangeInstanceStateConfigOffset = default(Offset<IChangeTemplateInstanceStateConfig>))
		{
			builder.StartTable(3);
			IGroupDestroyListenConfig.AddChangeInstanceStateConfig(builder, ChangeInstanceStateConfigOffset);
			IGroupDestroyListenConfig.AddOnTriggerActions(builder, OnTriggerActionsOffset);
			IGroupDestroyListenConfig.AddGroupType(builder, GroupType);
			return IGroupDestroyListenConfig.EndIGroupDestroyListenConfig(builder);
		}

		// Token: 0x06024EC5 RID: 151237 RVA: 0x00511D99 File Offset: 0x0050FF99
		public static void StartIGroupDestroyListenConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024EC6 RID: 151238 RVA: 0x00511DA2 File Offset: 0x0050FFA2
		public static void AddGroupType(FlatBufferBuilder builder, ETemplateEntityGroupType groupType)
		{
			builder.AddByte(0, (byte)groupType, 0);
		}

		// Token: 0x06024EC7 RID: 151239 RVA: 0x00511DAD File Offset: 0x0050FFAD
		public static void AddOnTriggerActions(FlatBufferBuilder builder, VectorOffset onTriggerActionsOffset)
		{
			builder.AddOffset(1, onTriggerActionsOffset.Value, 0);
		}

		// Token: 0x06024EC8 RID: 151240 RVA: 0x00511DC0 File Offset: 0x0050FFC0
		public static VectorOffset CreateOnTriggerActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024EC9 RID: 151241 RVA: 0x00511E00 File Offset: 0x00510000
		public static VectorOffset CreateOnTriggerActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024ECA RID: 151242 RVA: 0x00511E1A File Offset: 0x0051001A
		public static VectorOffset CreateOnTriggerActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024ECB RID: 151243 RVA: 0x00511E38 File Offset: 0x00510038
		public static VectorOffset CreateOnTriggerActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024ECC RID: 151244 RVA: 0x00511E51 File Offset: 0x00510051
		public static void StartOnTriggerActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024ECD RID: 151245 RVA: 0x00511E5C File Offset: 0x0051005C
		public static void AddChangeInstanceStateConfig(FlatBufferBuilder builder, Offset<IChangeTemplateInstanceStateConfig> changeInstanceStateConfigOffset)
		{
			builder.AddOffset(2, changeInstanceStateConfigOffset.Value, 0);
		}

		// Token: 0x06024ECE RID: 151246 RVA: 0x00511E6C File Offset: 0x0051006C
		public static Offset<IGroupDestroyListenConfig> EndIGroupDestroyListenConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGroupDestroyListenConfig>(builder.EndTable());
		}

		// Token: 0x06024ECF RID: 151247 RVA: 0x00511E7C File Offset: 0x0051007C
		public IGroupDestroyListenConfigT UnPack()
		{
			IGroupDestroyListenConfigT groupDestroyListenConfigT = new IGroupDestroyListenConfigT();
			this.UnPackTo(groupDestroyListenConfigT);
			return groupDestroyListenConfigT;
		}

		// Token: 0x06024ED0 RID: 151248 RVA: 0x00511E98 File Offset: 0x00510098
		public void UnPackTo(IGroupDestroyListenConfigT _o)
		{
			_o.GroupType = this.GroupType;
			_o.OnTriggerActions = new List<IActionInfoT>();
			for (int i = 0; i < this.OnTriggerActionsLength; i++)
			{
				_o.OnTriggerActions.Add((this.OnTriggerActions(i) != null) ? this.OnTriggerActions(i).Value.UnPack() : null);
			}
			_o.ChangeInstanceStateConfig = ((this.ChangeInstanceStateConfig != null) ? this.ChangeInstanceStateConfig.Value.UnPack() : null);
		}

		// Token: 0x06024ED1 RID: 151249 RVA: 0x00511F34 File Offset: 0x00510134
		public static Offset<IGroupDestroyListenConfig> Pack(FlatBufferBuilder builder, IGroupDestroyListenConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupDestroyListenConfig>);
			}
			VectorOffset onTriggerActionsOffset = default(VectorOffset);
			if (_o.OnTriggerActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.OnTriggerActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.OnTriggerActions[i]);
				}
				onTriggerActionsOffset = IGroupDestroyListenConfig.CreateOnTriggerActionsVector(builder, array);
			}
			Offset<IChangeTemplateInstanceStateConfig> changeInstanceStateConfigOffset = (_o.ChangeInstanceStateConfig == null) ? default(Offset<IChangeTemplateInstanceStateConfig>) : IChangeTemplateInstanceStateConfig.Pack(builder, _o.ChangeInstanceStateConfig);
			return IGroupDestroyListenConfig.CreateIGroupDestroyListenConfig(builder, _o.GroupType, onTriggerActionsOffset, changeInstanceStateConfigOffset);
		}

		// Token: 0x0400F14D RID: 61773
		private Table __p;
	}
}
