using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FC RID: 16892
	public struct IDarkTideSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007303 RID: 29443
		// (get) Token: 0x06017712 RID: 96018 RVA: 0x0035947E File Offset: 0x0035767E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017713 RID: 96019 RVA: 0x0035948B File Offset: 0x0035768B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017714 RID: 96020 RVA: 0x00359494 File Offset: 0x00357694
		public static IDarkTideSystemConfig GetRootAsIDarkTideSystemConfig(ByteBuffer _bb)
		{
			return IDarkTideSystemConfig.GetRootAsIDarkTideSystemConfig(_bb, default(IDarkTideSystemConfig));
		}

		// Token: 0x06017715 RID: 96021 RVA: 0x003594B0 File Offset: 0x003576B0
		public static IDarkTideSystemConfig GetRootAsIDarkTideSystemConfig(ByteBuffer _bb, IDarkTideSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017716 RID: 96022 RVA: 0x003594CD File Offset: 0x003576CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017717 RID: 96023 RVA: 0x003594DC File Offset: 0x003576DC
		public IDarkTideSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007304 RID: 29444
		// (get) Token: 0x06017718 RID: 96024 RVA: 0x003594EC File Offset: 0x003576EC
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007305 RID: 29445
		// (get) Token: 0x06017719 RID: 96025 RVA: 0x00359528 File Offset: 0x00357728
		public IDarkTideBossEventModule? Module
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDarkTideBossEventModule?(default(IDarkTideBossEventModule).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601771A RID: 96026 RVA: 0x00359585 File Offset: 0x00357785
		public static Offset<IDarkTideSystemConfig> CreateIDarkTideSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, Offset<IDarkTideBossEventModule> ModuleOffset = default(Offset<IDarkTideBossEventModule>))
		{
			builder.StartTable(2);
			IDarkTideSystemConfig.AddModule(builder, ModuleOffset);
			IDarkTideSystemConfig.AddType(builder, Type);
			return IDarkTideSystemConfig.EndIDarkTideSystemConfig(builder);
		}

		// Token: 0x0601771B RID: 96027 RVA: 0x003595A2 File Offset: 0x003577A2
		public static void StartIDarkTideSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601771C RID: 96028 RVA: 0x003595AB File Offset: 0x003577AB
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x003595B6 File Offset: 0x003577B6
		public static void AddModule(FlatBufferBuilder builder, Offset<IDarkTideBossEventModule> moduleOffset)
		{
			builder.AddOffset(1, moduleOffset.Value, 0);
		}

		// Token: 0x0601771E RID: 96030 RVA: 0x003595C6 File Offset: 0x003577C6
		public static Offset<IDarkTideSystemConfig> EndIDarkTideSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideSystemConfig>(builder.EndTable());
		}

		// Token: 0x0601771F RID: 96031 RVA: 0x003595D4 File Offset: 0x003577D4
		public IDarkTideSystemConfigT UnPack()
		{
			IDarkTideSystemConfigT darkTideSystemConfigT = new IDarkTideSystemConfigT();
			this.UnPackTo(darkTideSystemConfigT);
			return darkTideSystemConfigT;
		}

		// Token: 0x06017720 RID: 96032 RVA: 0x003595F0 File Offset: 0x003577F0
		public void UnPackTo(IDarkTideSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Module = ((this.Module != null) ? this.Module.Value.UnPack() : null);
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x00359638 File Offset: 0x00357838
		public static Offset<IDarkTideSystemConfig> Pack(FlatBufferBuilder builder, IDarkTideSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideSystemConfig>);
			}
			Offset<IDarkTideBossEventModule> moduleOffset = (_o.Module == null) ? default(Offset<IDarkTideBossEventModule>) : IDarkTideBossEventModule.Pack(builder, _o.Module);
			return IDarkTideSystemConfig.CreateIDarkTideSystemConfig(builder, _o.Type, moduleOffset);
		}

		// Token: 0x0400C0D7 RID: 49367
		private Table __p;
	}
}
