using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A44 RID: 23108
	public struct ILevelAIBehaviourBase : IFlatbufferObject
	{
		// Token: 0x1700A818 RID: 43032
		// (get) Token: 0x06025CB0 RID: 154800 RVA: 0x0052E685 File Offset: 0x0052C885
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CB1 RID: 154801 RVA: 0x0052E692 File Offset: 0x0052C892
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CB2 RID: 154802 RVA: 0x0052E69C File Offset: 0x0052C89C
		public static ILevelAIBehaviourBase GetRootAsILevelAIBehaviourBase(ByteBuffer _bb)
		{
			return ILevelAIBehaviourBase.GetRootAsILevelAIBehaviourBase(_bb, default(ILevelAIBehaviourBase));
		}

		// Token: 0x06025CB3 RID: 154803 RVA: 0x0052E6B8 File Offset: 0x0052C8B8
		public static ILevelAIBehaviourBase GetRootAsILevelAIBehaviourBase(ByteBuffer _bb, ILevelAIBehaviourBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CB4 RID: 154804 RVA: 0x0052E6D5 File Offset: 0x0052C8D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CB5 RID: 154805 RVA: 0x0052E6E4 File Offset: 0x0052C8E4
		public ILevelAIBehaviourBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A819 RID: 43033
		// (get) Token: 0x06025CB6 RID: 154806 RVA: 0x0052E6F4 File Offset: 0x0052C8F4
		public ELevelAIBehaviourType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelAIBehaviourType.Spline;
				}
				return (ELevelAIBehaviourType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025CB7 RID: 154807 RVA: 0x0052E730 File Offset: 0x0052C930
		public static Offset<ILevelAIBehaviourBase> CreateILevelAIBehaviourBase(FlatBufferBuilder builder, ELevelAIBehaviourType Type = ELevelAIBehaviourType.Spline)
		{
			builder.StartTable(1);
			ILevelAIBehaviourBase.AddType(builder, Type);
			return ILevelAIBehaviourBase.EndILevelAIBehaviourBase(builder);
		}

		// Token: 0x06025CB8 RID: 154808 RVA: 0x0052E746 File Offset: 0x0052C946
		public static void StartILevelAIBehaviourBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025CB9 RID: 154809 RVA: 0x0052E74F File Offset: 0x0052C94F
		public static void AddType(FlatBufferBuilder builder, ELevelAIBehaviourType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025CBA RID: 154810 RVA: 0x0052E75A File Offset: 0x0052C95A
		public static Offset<ILevelAIBehaviourBase> EndILevelAIBehaviourBase(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIBehaviourBase>(builder.EndTable());
		}

		// Token: 0x06025CBB RID: 154811 RVA: 0x0052E768 File Offset: 0x0052C968
		public ILevelAIBehaviourBaseT UnPack()
		{
			ILevelAIBehaviourBaseT levelAIBehaviourBaseT = new ILevelAIBehaviourBaseT();
			this.UnPackTo(levelAIBehaviourBaseT);
			return levelAIBehaviourBaseT;
		}

		// Token: 0x06025CBC RID: 154812 RVA: 0x0052E783 File Offset: 0x0052C983
		public void UnPackTo(ILevelAIBehaviourBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025CBD RID: 154813 RVA: 0x0052E794 File Offset: 0x0052C994
		public static Offset<ILevelAIBehaviourBase> Pack(FlatBufferBuilder builder, ILevelAIBehaviourBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIBehaviourBase>);
			}
			return ILevelAIBehaviourBase.CreateILevelAIBehaviourBase(builder, _o.Type);
		}

		// Token: 0x0400F3A6 RID: 62374
		private Table __p;
	}
}
