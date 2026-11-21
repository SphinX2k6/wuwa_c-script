using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007666 RID: 30310
	public struct IRoguePrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700DE83 RID: 56963
		// (get) Token: 0x060352C7 RID: 217799 RVA: 0x0072344E File Offset: 0x0072164E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060352C8 RID: 217800 RVA: 0x0072345B File Offset: 0x0072165B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060352C9 RID: 217801 RVA: 0x00723464 File Offset: 0x00721664
		public static IRoguePrefabConfig GetRootAsIRoguePrefabConfig(ByteBuffer _bb)
		{
			return IRoguePrefabConfig.GetRootAsIRoguePrefabConfig(_bb, default(IRoguePrefabConfig));
		}

		// Token: 0x060352CA RID: 217802 RVA: 0x00723480 File Offset: 0x00721680
		public static IRoguePrefabConfig GetRootAsIRoguePrefabConfig(ByteBuffer _bb, IRoguePrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060352CB RID: 217803 RVA: 0x0072349D File Offset: 0x0072169D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060352CC RID: 217804 RVA: 0x007234AC File Offset: 0x007216AC
		public IRoguePrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE84 RID: 56964
		// (get) Token: 0x060352CD RID: 217805 RVA: 0x007234BC File Offset: 0x007216BC
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DE85 RID: 56965
		// (get) Token: 0x060352CE RID: 217806 RVA: 0x007234F8 File Offset: 0x007216F8
		public int Index
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060352CF RID: 217807 RVA: 0x00723534 File Offset: 0x00721734
		public static Offset<IRoguePrefabConfig> CreateIRoguePrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int Index = 0)
		{
			builder.StartTable(2);
			IRoguePrefabConfig.AddIndex(builder, Index);
			IRoguePrefabConfig.AddType(builder, Type);
			return IRoguePrefabConfig.EndIRoguePrefabConfig(builder);
		}

		// Token: 0x060352D0 RID: 217808 RVA: 0x00723551 File Offset: 0x00721751
		public static void StartIRoguePrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060352D1 RID: 217809 RVA: 0x0072355A File Offset: 0x0072175A
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060352D2 RID: 217810 RVA: 0x00723565 File Offset: 0x00721765
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x060352D3 RID: 217811 RVA: 0x00723570 File Offset: 0x00721770
		public static Offset<IRoguePrefabConfig> EndIRoguePrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoguePrefabConfig>(builder.EndTable());
		}

		// Token: 0x060352D4 RID: 217812 RVA: 0x00723580 File Offset: 0x00721780
		public IRoguePrefabConfigT UnPack()
		{
			IRoguePrefabConfigT roguePrefabConfigT = new IRoguePrefabConfigT();
			this.UnPackTo(roguePrefabConfigT);
			return roguePrefabConfigT;
		}

		// Token: 0x060352D5 RID: 217813 RVA: 0x0072359B File Offset: 0x0072179B
		public void UnPackTo(IRoguePrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
		}

		// Token: 0x060352D6 RID: 217814 RVA: 0x007235B8 File Offset: 0x007217B8
		public static Offset<IRoguePrefabConfig> Pack(FlatBufferBuilder builder, IRoguePrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoguePrefabConfig>);
			}
			return IRoguePrefabConfig.CreateIRoguePrefabConfig(builder, _o.Type, _o.Index);
		}

		// Token: 0x04012859 RID: 75865
		private Table __p;
	}
}
