using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A40 RID: 31296
	public struct ISwitchSubLevels : IFlatbufferObject
	{
		// Token: 0x1700E54C RID: 58700
		// (get) Token: 0x06037268 RID: 225896 RVA: 0x0075E280 File Offset: 0x0075C480
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037269 RID: 225897 RVA: 0x0075E28D File Offset: 0x0075C48D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603726A RID: 225898 RVA: 0x0075E294 File Offset: 0x0075C494
		public static ISwitchSubLevels GetRootAsISwitchSubLevels(ByteBuffer _bb)
		{
			return ISwitchSubLevels.GetRootAsISwitchSubLevels(_bb, default(ISwitchSubLevels));
		}

		// Token: 0x0603726B RID: 225899 RVA: 0x0075E2B0 File Offset: 0x0075C4B0
		public static ISwitchSubLevels GetRootAsISwitchSubLevels(ByteBuffer _bb, ISwitchSubLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603726C RID: 225900 RVA: 0x0075E2CD File Offset: 0x0075C4CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603726D RID: 225901 RVA: 0x0075E2DC File Offset: 0x0075C4DC
		public ISwitchSubLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E54D RID: 58701
		// (get) Token: 0x0603726E RID: 225902 RVA: 0x0075E2EC File Offset: 0x0075C4EC
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

		// Token: 0x0603726F RID: 225903 RVA: 0x0075E328 File Offset: 0x0075C528
		public static Offset<ISwitchSubLevels> CreateISwitchSubLevels(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly)
		{
			builder.StartTable(1);
			ISwitchSubLevels.AddType(builder, Type);
			return ISwitchSubLevels.EndISwitchSubLevels(builder);
		}

		// Token: 0x06037270 RID: 225904 RVA: 0x0075E33E File Offset: 0x0075C53E
		public static void StartISwitchSubLevels(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06037271 RID: 225905 RVA: 0x0075E347 File Offset: 0x0075C547
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037272 RID: 225906 RVA: 0x0075E352 File Offset: 0x0075C552
		public static Offset<ISwitchSubLevels> EndISwitchSubLevels(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchSubLevels>(builder.EndTable());
		}

		// Token: 0x06037273 RID: 225907 RVA: 0x0075E360 File Offset: 0x0075C560
		public ISwitchSubLevelsT UnPack()
		{
			ISwitchSubLevelsT switchSubLevelsT = new ISwitchSubLevelsT();
			this.UnPackTo(switchSubLevelsT);
			return switchSubLevelsT;
		}

		// Token: 0x06037274 RID: 225908 RVA: 0x0075E37B File Offset: 0x0075C57B
		public void UnPackTo(ISwitchSubLevelsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06037275 RID: 225909 RVA: 0x0075E38C File Offset: 0x0075C58C
		public static Offset<ISwitchSubLevels> Pack(FlatBufferBuilder builder, ISwitchSubLevelsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchSubLevels>);
			}
			return ISwitchSubLevels.CreateISwitchSubLevels(builder, _o.Type);
		}

		// Token: 0x04012D6B RID: 77163
		private Table __p;
	}
}
