using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200534A RID: 21322
	public struct IGroupDestroyListenConfig : IFlatbufferObject
	{
		// Token: 0x17009CAB RID: 40107
		// (get) Token: 0x06022E06 RID: 142854 RVA: 0x004D4D0F File Offset: 0x004D2F0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E07 RID: 142855 RVA: 0x004D4D1C File Offset: 0x004D2F1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E08 RID: 142856 RVA: 0x004D4D24 File Offset: 0x004D2F24
		public static IGroupDestroyListenConfig GetRootAsIGroupDestroyListenConfig(ByteBuffer _bb)
		{
			return IGroupDestroyListenConfig.GetRootAsIGroupDestroyListenConfig(_bb, default(IGroupDestroyListenConfig));
		}

		// Token: 0x06022E09 RID: 142857 RVA: 0x004D4D40 File Offset: 0x004D2F40
		public static IGroupDestroyListenConfig GetRootAsIGroupDestroyListenConfig(ByteBuffer _bb, IGroupDestroyListenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E0A RID: 142858 RVA: 0x004D4D5D File Offset: 0x004D2F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E0B RID: 142859 RVA: 0x004D4D6C File Offset: 0x004D2F6C
		public IGroupDestroyListenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CAC RID: 40108
		// (get) Token: 0x06022E0C RID: 142860 RVA: 0x004D4D7C File Offset: 0x004D2F7C
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

		// Token: 0x06022E0D RID: 142861 RVA: 0x004D4DB8 File Offset: 0x004D2FB8
		public IActionInfo? OnTriggerActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CAD RID: 40109
		// (get) Token: 0x06022E0E RID: 142862 RVA: 0x004D4E18 File Offset: 0x004D3018
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

		// Token: 0x17009CAE RID: 40110
		// (get) Token: 0x06022E0F RID: 142863 RVA: 0x004D4E44 File Offset: 0x004D3044
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

		// Token: 0x06022E10 RID: 142864 RVA: 0x004D4EA1 File Offset: 0x004D30A1
		public static Offset<IGroupDestroyListenConfig> CreateIGroupDestroyListenConfig(FlatBufferBuilder builder, ETemplateEntityGroupType GroupType = ETemplateEntityGroupType.None, VectorOffset OnTriggerActionsOffset = default(VectorOffset), Offset<IChangeTemplateInstanceStateConfig> ChangeInstanceStateConfigOffset = default(Offset<IChangeTemplateInstanceStateConfig>))
		{
			builder.StartTable(3);
			IGroupDestroyListenConfig.AddChangeInstanceStateConfig(builder, ChangeInstanceStateConfigOffset);
			IGroupDestroyListenConfig.AddOnTriggerActions(builder, OnTriggerActionsOffset);
			IGroupDestroyListenConfig.AddGroupType(builder, GroupType);
			return IGroupDestroyListenConfig.EndIGroupDestroyListenConfig(builder);
		}

		// Token: 0x06022E11 RID: 142865 RVA: 0x004D4EC5 File Offset: 0x004D30C5
		public static void StartIGroupDestroyListenConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022E12 RID: 142866 RVA: 0x004D4ECE File Offset: 0x004D30CE
		public static void AddGroupType(FlatBufferBuilder builder, ETemplateEntityGroupType groupType)
		{
			builder.AddByte(0, (byte)groupType, 0);
		}

		// Token: 0x06022E13 RID: 142867 RVA: 0x004D4ED9 File Offset: 0x004D30D9
		public static void AddOnTriggerActions(FlatBufferBuilder builder, VectorOffset onTriggerActionsOffset)
		{
			builder.AddOffset(1, onTriggerActionsOffset.Value, 0);
		}

		// Token: 0x06022E14 RID: 142868 RVA: 0x004D4EEC File Offset: 0x004D30EC
		public static VectorOffset CreateOnTriggerActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022E15 RID: 142869 RVA: 0x004D4F2C File Offset: 0x004D312C
		public static VectorOffset CreateOnTriggerActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022E16 RID: 142870 RVA: 0x004D4F46 File Offset: 0x004D3146
		public static VectorOffset CreateOnTriggerActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022E17 RID: 142871 RVA: 0x004D4F64 File Offset: 0x004D3164
		public static VectorOffset CreateOnTriggerActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022E18 RID: 142872 RVA: 0x004D4F7D File Offset: 0x004D317D
		public static void StartOnTriggerActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022E19 RID: 142873 RVA: 0x004D4F88 File Offset: 0x004D3188
		public static void AddChangeInstanceStateConfig(FlatBufferBuilder builder, Offset<IChangeTemplateInstanceStateConfig> changeInstanceStateConfigOffset)
		{
			builder.AddOffset(2, changeInstanceStateConfigOffset.Value, 0);
		}

		// Token: 0x06022E1A RID: 142874 RVA: 0x004D4F98 File Offset: 0x004D3198
		public static Offset<IGroupDestroyListenConfig> EndIGroupDestroyListenConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGroupDestroyListenConfig>(builder.EndTable());
		}

		// Token: 0x06022E1B RID: 142875 RVA: 0x004D4FA8 File Offset: 0x004D31A8
		public IGroupDestroyListenConfigT UnPack()
		{
			IGroupDestroyListenConfigT groupDestroyListenConfigT = new IGroupDestroyListenConfigT();
			this.UnPackTo(groupDestroyListenConfigT);
			return groupDestroyListenConfigT;
		}

		// Token: 0x06022E1C RID: 142876 RVA: 0x004D4FC4 File Offset: 0x004D31C4
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

		// Token: 0x06022E1D RID: 142877 RVA: 0x004D5060 File Offset: 0x004D3260
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

		// Token: 0x0400E51D RID: 58653
		private Table __p;
	}
}
