using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049DC RID: 18908
	public struct ICheckDungeonHasSaveConfig : IFlatbufferObject
	{
		// Token: 0x170088BD RID: 35005
		// (get) Token: 0x0601D884 RID: 120964 RVA: 0x004286FC File Offset: 0x004268FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D885 RID: 120965 RVA: 0x00428709 File Offset: 0x00426909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D886 RID: 120966 RVA: 0x00428710 File Offset: 0x00426910
		public static ICheckDungeonHasSaveConfig GetRootAsICheckDungeonHasSaveConfig(ByteBuffer _bb)
		{
			return ICheckDungeonHasSaveConfig.GetRootAsICheckDungeonHasSaveConfig(_bb, default(ICheckDungeonHasSaveConfig));
		}

		// Token: 0x0601D887 RID: 120967 RVA: 0x0042872C File Offset: 0x0042692C
		public static ICheckDungeonHasSaveConfig GetRootAsICheckDungeonHasSaveConfig(ByteBuffer _bb, ICheckDungeonHasSaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D888 RID: 120968 RVA: 0x00428749 File Offset: 0x00426949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D889 RID: 120969 RVA: 0x00428758 File Offset: 0x00426958
		public ICheckDungeonHasSaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088BE RID: 35006
		// (get) Token: 0x0601D88A RID: 120970 RVA: 0x00428768 File Offset: 0x00426968
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088BF RID: 35007
		// (get) Token: 0x0601D88B RID: 120971 RVA: 0x004287A4 File Offset: 0x004269A4
		public int DungeonId
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

		// Token: 0x170088C0 RID: 35008
		// (get) Token: 0x0601D88C RID: 120972 RVA: 0x004287E0 File Offset: 0x004269E0
		public bool IsHasSaveConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D88D RID: 120973 RVA: 0x0042881F File Offset: 0x00426A1F
		public static Offset<ICheckDungeonHasSaveConfig> CreateICheckDungeonHasSaveConfig(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, bool IsHasSaveConfig = false)
		{
			builder.StartTable(3);
			ICheckDungeonHasSaveConfig.AddDungeonId(builder, DungeonId);
			ICheckDungeonHasSaveConfig.AddIsHasSaveConfig(builder, IsHasSaveConfig);
			ICheckDungeonHasSaveConfig.AddType(builder, Type);
			return ICheckDungeonHasSaveConfig.EndICheckDungeonHasSaveConfig(builder);
		}

		// Token: 0x0601D88E RID: 120974 RVA: 0x00428843 File Offset: 0x00426A43
		public static void StartICheckDungeonHasSaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D88F RID: 120975 RVA: 0x0042884C File Offset: 0x00426A4C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D890 RID: 120976 RVA: 0x00428857 File Offset: 0x00426A57
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601D891 RID: 120977 RVA: 0x00428862 File Offset: 0x00426A62
		public static void AddIsHasSaveConfig(FlatBufferBuilder builder, bool isHasSaveConfig)
		{
			builder.AddBool(2, isHasSaveConfig, false);
		}

		// Token: 0x0601D892 RID: 120978 RVA: 0x0042886D File Offset: 0x00426A6D
		public static Offset<ICheckDungeonHasSaveConfig> EndICheckDungeonHasSaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDungeonHasSaveConfig>(builder.EndTable());
		}

		// Token: 0x0601D893 RID: 120979 RVA: 0x0042887C File Offset: 0x00426A7C
		public ICheckDungeonHasSaveConfigT UnPack()
		{
			ICheckDungeonHasSaveConfigT checkDungeonHasSaveConfigT = new ICheckDungeonHasSaveConfigT();
			this.UnPackTo(checkDungeonHasSaveConfigT);
			return checkDungeonHasSaveConfigT;
		}

		// Token: 0x0601D894 RID: 120980 RVA: 0x00428897 File Offset: 0x00426A97
		public void UnPackTo(ICheckDungeonHasSaveConfigT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.IsHasSaveConfig = this.IsHasSaveConfig;
		}

		// Token: 0x0601D895 RID: 120981 RVA: 0x004288C0 File Offset: 0x00426AC0
		public static Offset<ICheckDungeonHasSaveConfig> Pack(FlatBufferBuilder builder, ICheckDungeonHasSaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDungeonHasSaveConfig>);
			}
			return ICheckDungeonHasSaveConfig.CreateICheckDungeonHasSaveConfig(builder, _o.Type, _o.DungeonId, _o.IsHasSaveConfig);
		}

		// Token: 0x0400D20B RID: 53771
		private Table __p;
	}
}
