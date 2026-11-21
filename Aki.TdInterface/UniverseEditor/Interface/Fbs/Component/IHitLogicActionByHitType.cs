using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005912 RID: 22802
	public struct IHitLogicActionByHitType : IFlatbufferObject
	{
		// Token: 0x1700A566 RID: 42342
		// (get) Token: 0x06025112 RID: 151826 RVA: 0x00516839 File Offset: 0x00514A39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025113 RID: 151827 RVA: 0x00516846 File Offset: 0x00514A46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025114 RID: 151828 RVA: 0x00516850 File Offset: 0x00514A50
		public static IHitLogicActionByHitType GetRootAsIHitLogicActionByHitType(ByteBuffer _bb)
		{
			return IHitLogicActionByHitType.GetRootAsIHitLogicActionByHitType(_bb, default(IHitLogicActionByHitType));
		}

		// Token: 0x06025115 RID: 151829 RVA: 0x0051686C File Offset: 0x00514A6C
		public static IHitLogicActionByHitType GetRootAsIHitLogicActionByHitType(ByteBuffer _bb, IHitLogicActionByHitType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025116 RID: 151830 RVA: 0x00516889 File Offset: 0x00514A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025117 RID: 151831 RVA: 0x00516898 File Offset: 0x00514A98
		public IHitLogicActionByHitType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A567 RID: 42343
		// (get) Token: 0x06025118 RID: 151832 RVA: 0x005168A8 File Offset: 0x00514AA8
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

		// Token: 0x06025119 RID: 151833 RVA: 0x005168E4 File Offset: 0x00514AE4
		public IActionByHitTypeConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionByHitTypeConfig?(default(IActionByHitTypeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A568 RID: 42344
		// (get) Token: 0x0602511A RID: 151834 RVA: 0x00516944 File Offset: 0x00514B44
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

		// Token: 0x0602511B RID: 151835 RVA: 0x0051696F File Offset: 0x00514B6F
		public static Offset<IHitLogicActionByHitType> CreateIHitLogicActionByHitType(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHitLogicActionByHitType.AddConfigs(builder, ConfigsOffset);
			IHitLogicActionByHitType.AddType(builder, Type);
			return IHitLogicActionByHitType.EndIHitLogicActionByHitType(builder);
		}

		// Token: 0x0602511C RID: 151836 RVA: 0x0051698C File Offset: 0x00514B8C
		public static void StartIHitLogicActionByHitType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602511D RID: 151837 RVA: 0x00516995 File Offset: 0x00514B95
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602511E RID: 151838 RVA: 0x005169A0 File Offset: 0x00514BA0
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x0602511F RID: 151839 RVA: 0x005169B0 File Offset: 0x00514BB0
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IActionByHitTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025120 RID: 151840 RVA: 0x005169F0 File Offset: 0x00514BF0
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IActionByHitTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionByHitTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025121 RID: 151841 RVA: 0x00516A0A File Offset: 0x00514C0A
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionByHitTypeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionByHitTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025122 RID: 151842 RVA: 0x00516A28 File Offset: 0x00514C28
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionByHitTypeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025123 RID: 151843 RVA: 0x00516A41 File Offset: 0x00514C41
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025124 RID: 151844 RVA: 0x00516A4C File Offset: 0x00514C4C
		public static Offset<IHitLogicActionByHitType> EndIHitLogicActionByHitType(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicActionByHitType>(builder.EndTable());
		}

		// Token: 0x06025125 RID: 151845 RVA: 0x00516A5C File Offset: 0x00514C5C
		public IHitLogicActionByHitTypeT UnPack()
		{
			IHitLogicActionByHitTypeT hitLogicActionByHitTypeT = new IHitLogicActionByHitTypeT();
			this.UnPackTo(hitLogicActionByHitTypeT);
			return hitLogicActionByHitTypeT;
		}

		// Token: 0x06025126 RID: 151846 RVA: 0x00516A78 File Offset: 0x00514C78
		public void UnPackTo(IHitLogicActionByHitTypeT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<IActionByHitTypeConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025127 RID: 151847 RVA: 0x00516AE4 File Offset: 0x00514CE4
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

		// Token: 0x0400F1A8 RID: 61864
		private Table __p;
	}
}
