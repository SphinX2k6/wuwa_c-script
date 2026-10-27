using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF1 RID: 15857
	public struct IEnableSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006D9C RID: 28060
		// (get) Token: 0x060162B9 RID: 90809 RVA: 0x00333E16 File Offset: 0x00332016
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162BA RID: 90810 RVA: 0x00333E23 File Offset: 0x00332023
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060162BB RID: 90811 RVA: 0x00333E2C File Offset: 0x0033202C
		public static IEnableSystemConfig GetRootAsIEnableSystemConfig(ByteBuffer _bb)
		{
			return IEnableSystemConfig.GetRootAsIEnableSystemConfig(_bb, default(IEnableSystemConfig));
		}

		// Token: 0x060162BC RID: 90812 RVA: 0x00333E48 File Offset: 0x00332048
		public static IEnableSystemConfig GetRootAsIEnableSystemConfig(ByteBuffer _bb, IEnableSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060162BD RID: 90813 RVA: 0x00333E65 File Offset: 0x00332065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060162BE RID: 90814 RVA: 0x00333E74 File Offset: 0x00332074
		public IEnableSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D9D RID: 28061
		// (get) Token: 0x060162BF RID: 90815 RVA: 0x00333E84 File Offset: 0x00332084
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

		// Token: 0x060162C0 RID: 90816 RVA: 0x00333EC0 File Offset: 0x003320C0
		public static Offset<IEnableSystemConfig> CreateIEnableSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem)
		{
			builder.StartTable(1);
			IEnableSystemConfig.AddType(builder, Type);
			return IEnableSystemConfig.EndIEnableSystemConfig(builder);
		}

		// Token: 0x060162C1 RID: 90817 RVA: 0x00333ED6 File Offset: 0x003320D6
		public static void StartIEnableSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060162C2 RID: 90818 RVA: 0x00333EDF File Offset: 0x003320DF
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060162C3 RID: 90819 RVA: 0x00333EEA File Offset: 0x003320EA
		public static Offset<IEnableSystemConfig> EndIEnableSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSystemConfig>(builder.EndTable());
		}

		// Token: 0x060162C4 RID: 90820 RVA: 0x00333EF8 File Offset: 0x003320F8
		public IEnableSystemConfigT UnPack()
		{
			IEnableSystemConfigT enableSystemConfigT = new IEnableSystemConfigT();
			this.UnPackTo(enableSystemConfigT);
			return enableSystemConfigT;
		}

		// Token: 0x060162C5 RID: 90821 RVA: 0x00333F13 File Offset: 0x00332113
		public void UnPackTo(IEnableSystemConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060162C6 RID: 90822 RVA: 0x00333F24 File Offset: 0x00332124
		public static Offset<IEnableSystemConfig> Pack(FlatBufferBuilder builder, IEnableSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSystemConfig>);
			}
			return IEnableSystemConfig.CreateIEnableSystemConfig(builder, _o.Type);
		}

		// Token: 0x0400B74D RID: 46925
		private Table __p;
	}
}
