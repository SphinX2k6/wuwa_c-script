using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A41 RID: 23105
	public struct ILetGoDestroyCondition : IFlatbufferObject
	{
		// Token: 0x1700A815 RID: 43029
		// (get) Token: 0x06025C9E RID: 154782 RVA: 0x0052E510 File Offset: 0x0052C710
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C9F RID: 154783 RVA: 0x0052E51D File Offset: 0x0052C71D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CA0 RID: 154784 RVA: 0x0052E524 File Offset: 0x0052C724
		public static ILetGoDestroyCondition GetRootAsILetGoDestroyCondition(ByteBuffer _bb)
		{
			return ILetGoDestroyCondition.GetRootAsILetGoDestroyCondition(_bb, default(ILetGoDestroyCondition));
		}

		// Token: 0x06025CA1 RID: 154785 RVA: 0x0052E540 File Offset: 0x0052C740
		public static ILetGoDestroyCondition GetRootAsILetGoDestroyCondition(ByteBuffer _bb, ILetGoDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CA2 RID: 154786 RVA: 0x0052E55D File Offset: 0x0052C75D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CA3 RID: 154787 RVA: 0x0052E56C File Offset: 0x0052C76C
		public ILetGoDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A816 RID: 43030
		// (get) Token: 0x06025CA4 RID: 154788 RVA: 0x0052E57C File Offset: 0x0052C77C
		public ETeleControlDestroyCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return (ETeleControlDestroyCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025CA5 RID: 154789 RVA: 0x0052E5B8 File Offset: 0x0052C7B8
		public static Offset<ILetGoDestroyCondition> CreateILetGoDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo)
		{
			builder.StartTable(1);
			ILetGoDestroyCondition.AddType(builder, Type);
			return ILetGoDestroyCondition.EndILetGoDestroyCondition(builder);
		}

		// Token: 0x06025CA6 RID: 154790 RVA: 0x0052E5CE File Offset: 0x0052C7CE
		public static void StartILetGoDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025CA7 RID: 154791 RVA: 0x0052E5D7 File Offset: 0x0052C7D7
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025CA8 RID: 154792 RVA: 0x0052E5E2 File Offset: 0x0052C7E2
		public static Offset<ILetGoDestroyCondition> EndILetGoDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ILetGoDestroyCondition>(builder.EndTable());
		}

		// Token: 0x06025CA9 RID: 154793 RVA: 0x0052E5F0 File Offset: 0x0052C7F0
		public ILetGoDestroyConditionT UnPack()
		{
			ILetGoDestroyConditionT letGoDestroyConditionT = new ILetGoDestroyConditionT();
			this.UnPackTo(letGoDestroyConditionT);
			return letGoDestroyConditionT;
		}

		// Token: 0x06025CAA RID: 154794 RVA: 0x0052E60B File Offset: 0x0052C80B
		public void UnPackTo(ILetGoDestroyConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025CAB RID: 154795 RVA: 0x0052E61C File Offset: 0x0052C81C
		public static Offset<ILetGoDestroyCondition> Pack(FlatBufferBuilder builder, ILetGoDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILetGoDestroyCondition>);
			}
			return ILetGoDestroyCondition.CreateILetGoDestroyCondition(builder, _o.Type);
		}

		// Token: 0x0400F3A4 RID: 62372
		private Table __p;
	}
}
