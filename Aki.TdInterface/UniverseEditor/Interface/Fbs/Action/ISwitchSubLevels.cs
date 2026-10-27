using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726B RID: 29291
	public struct ISwitchSubLevels : IFlatbufferObject
	{
		// Token: 0x1700D953 RID: 55635
		// (get) Token: 0x06033F66 RID: 212838 RVA: 0x006FCF20 File Offset: 0x006FB120
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F67 RID: 212839 RVA: 0x006FCF2D File Offset: 0x006FB12D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F68 RID: 212840 RVA: 0x006FCF34 File Offset: 0x006FB134
		public static ISwitchSubLevels GetRootAsISwitchSubLevels(ByteBuffer _bb)
		{
			return ISwitchSubLevels.GetRootAsISwitchSubLevels(_bb, default(ISwitchSubLevels));
		}

		// Token: 0x06033F69 RID: 212841 RVA: 0x006FCF50 File Offset: 0x006FB150
		public static ISwitchSubLevels GetRootAsISwitchSubLevels(ByteBuffer _bb, ISwitchSubLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F6A RID: 212842 RVA: 0x006FCF6D File Offset: 0x006FB16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F6B RID: 212843 RVA: 0x006FCF7C File Offset: 0x006FB17C
		public ISwitchSubLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D954 RID: 55636
		// (get) Token: 0x06033F6C RID: 212844 RVA: 0x006FCF8C File Offset: 0x006FB18C
		public ESwitchSubLevelsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return (ESwitchSubLevelsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F6D RID: 212845 RVA: 0x006FCFC8 File Offset: 0x006FB1C8
		public static Offset<ISwitchSubLevels> CreateISwitchSubLevels(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly)
		{
			builder.StartTable(1);
			ISwitchSubLevels.AddType(builder, Type);
			return ISwitchSubLevels.EndISwitchSubLevels(builder);
		}

		// Token: 0x06033F6E RID: 212846 RVA: 0x006FCFDE File Offset: 0x006FB1DE
		public static void StartISwitchSubLevels(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033F6F RID: 212847 RVA: 0x006FCFE7 File Offset: 0x006FB1E7
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F70 RID: 212848 RVA: 0x006FCFF2 File Offset: 0x006FB1F2
		public static Offset<ISwitchSubLevels> EndISwitchSubLevels(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchSubLevels>(builder.EndTable());
		}

		// Token: 0x06033F71 RID: 212849 RVA: 0x006FD000 File Offset: 0x006FB200
		public ISwitchSubLevelsT UnPack()
		{
			ISwitchSubLevelsT switchSubLevelsT = new ISwitchSubLevelsT();
			this.UnPackTo(switchSubLevelsT);
			return switchSubLevelsT;
		}

		// Token: 0x06033F72 RID: 212850 RVA: 0x006FD01B File Offset: 0x006FB21B
		public void UnPackTo(ISwitchSubLevelsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033F73 RID: 212851 RVA: 0x006FD02C File Offset: 0x006FB22C
		public static Offset<ISwitchSubLevels> Pack(FlatBufferBuilder builder, ISwitchSubLevelsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchSubLevels>);
			}
			return ISwitchSubLevels.CreateISwitchSubLevels(builder, _o.Type);
		}

		// Token: 0x04011D69 RID: 73065
		private Table __p;
	}
}
