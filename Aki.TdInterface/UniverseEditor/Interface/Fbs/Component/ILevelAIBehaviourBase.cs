using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BE RID: 21694
	public struct ILevelAIBehaviourBase : IFlatbufferObject
	{
		// Token: 0x17009FDE RID: 40926
		// (get) Token: 0x06023BF8 RID: 146424 RVA: 0x004F1611 File Offset: 0x004EF811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023BF9 RID: 146425 RVA: 0x004F161E File Offset: 0x004EF81E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023BFA RID: 146426 RVA: 0x004F1628 File Offset: 0x004EF828
		public static ILevelAIBehaviourBase GetRootAsILevelAIBehaviourBase(ByteBuffer _bb)
		{
			return ILevelAIBehaviourBase.GetRootAsILevelAIBehaviourBase(_bb, default(ILevelAIBehaviourBase));
		}

		// Token: 0x06023BFB RID: 146427 RVA: 0x004F1644 File Offset: 0x004EF844
		public static ILevelAIBehaviourBase GetRootAsILevelAIBehaviourBase(ByteBuffer _bb, ILevelAIBehaviourBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023BFC RID: 146428 RVA: 0x004F1661 File Offset: 0x004EF861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023BFD RID: 146429 RVA: 0x004F1670 File Offset: 0x004EF870
		public ILevelAIBehaviourBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FDF RID: 40927
		// (get) Token: 0x06023BFE RID: 146430 RVA: 0x004F1680 File Offset: 0x004EF880
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

		// Token: 0x06023BFF RID: 146431 RVA: 0x004F16BC File Offset: 0x004EF8BC
		public static Offset<ILevelAIBehaviourBase> CreateILevelAIBehaviourBase(FlatBufferBuilder builder, ELevelAIBehaviourType Type = ELevelAIBehaviourType.Spline)
		{
			builder.StartTable(1);
			ILevelAIBehaviourBase.AddType(builder, Type);
			return ILevelAIBehaviourBase.EndILevelAIBehaviourBase(builder);
		}

		// Token: 0x06023C00 RID: 146432 RVA: 0x004F16D2 File Offset: 0x004EF8D2
		public static void StartILevelAIBehaviourBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023C01 RID: 146433 RVA: 0x004F16DB File Offset: 0x004EF8DB
		public static void AddType(FlatBufferBuilder builder, ELevelAIBehaviourType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C02 RID: 146434 RVA: 0x004F16E6 File Offset: 0x004EF8E6
		public static Offset<ILevelAIBehaviourBase> EndILevelAIBehaviourBase(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIBehaviourBase>(builder.EndTable());
		}

		// Token: 0x06023C03 RID: 146435 RVA: 0x004F16F4 File Offset: 0x004EF8F4
		public ILevelAIBehaviourBaseT UnPack()
		{
			ILevelAIBehaviourBaseT levelAIBehaviourBaseT = new ILevelAIBehaviourBaseT();
			this.UnPackTo(levelAIBehaviourBaseT);
			return levelAIBehaviourBaseT;
		}

		// Token: 0x06023C04 RID: 146436 RVA: 0x004F170F File Offset: 0x004EF90F
		public void UnPackTo(ILevelAIBehaviourBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023C05 RID: 146437 RVA: 0x004F1720 File Offset: 0x004EF920
		public static Offset<ILevelAIBehaviourBase> Pack(FlatBufferBuilder builder, ILevelAIBehaviourBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIBehaviourBase>);
			}
			return ILevelAIBehaviourBase.CreateILevelAIBehaviourBase(builder, _o.Type);
		}

		// Token: 0x0400E775 RID: 59253
		private Table __p;
	}
}
