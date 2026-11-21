using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422C RID: 16940
	public struct IEnableSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007382 RID: 29570
		// (get) Token: 0x060178E4 RID: 96484 RVA: 0x0035C9CB File Offset: 0x0035ABCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060178E5 RID: 96485 RVA: 0x0035C9D8 File Offset: 0x0035ABD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060178E6 RID: 96486 RVA: 0x0035C9E0 File Offset: 0x0035ABE0
		public static IEnableSystemConfig GetRootAsIEnableSystemConfig(ByteBuffer _bb)
		{
			return IEnableSystemConfig.GetRootAsIEnableSystemConfig(_bb, default(IEnableSystemConfig));
		}

		// Token: 0x060178E7 RID: 96487 RVA: 0x0035C9FC File Offset: 0x0035ABFC
		public static IEnableSystemConfig GetRootAsIEnableSystemConfig(ByteBuffer _bb, IEnableSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060178E8 RID: 96488 RVA: 0x0035CA19 File Offset: 0x0035AC19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060178E9 RID: 96489 RVA: 0x0035CA28 File Offset: 0x0035AC28
		public IEnableSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007383 RID: 29571
		// (get) Token: 0x060178EA RID: 96490 RVA: 0x0035CA38 File Offset: 0x0035AC38
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

		// Token: 0x060178EB RID: 96491 RVA: 0x0035CA74 File Offset: 0x0035AC74
		public static Offset<IEnableSystemConfig> CreateIEnableSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem)
		{
			builder.StartTable(1);
			IEnableSystemConfig.AddType(builder, Type);
			return IEnableSystemConfig.EndIEnableSystemConfig(builder);
		}

		// Token: 0x060178EC RID: 96492 RVA: 0x0035CA8A File Offset: 0x0035AC8A
		public static void StartIEnableSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060178ED RID: 96493 RVA: 0x0035CA93 File Offset: 0x0035AC93
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060178EE RID: 96494 RVA: 0x0035CA9E File Offset: 0x0035AC9E
		public static Offset<IEnableSystemConfig> EndIEnableSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSystemConfig>(builder.EndTable());
		}

		// Token: 0x060178EF RID: 96495 RVA: 0x0035CAAC File Offset: 0x0035ACAC
		public IEnableSystemConfigT UnPack()
		{
			IEnableSystemConfigT enableSystemConfigT = new IEnableSystemConfigT();
			this.UnPackTo(enableSystemConfigT);
			return enableSystemConfigT;
		}

		// Token: 0x060178F0 RID: 96496 RVA: 0x0035CAC7 File Offset: 0x0035ACC7
		public void UnPackTo(IEnableSystemConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060178F1 RID: 96497 RVA: 0x0035CAD8 File Offset: 0x0035ACD8
		public static Offset<IEnableSystemConfig> Pack(FlatBufferBuilder builder, IEnableSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSystemConfig>);
			}
			return IEnableSystemConfig.CreateIEnableSystemConfig(builder, _o.Type);
		}

		// Token: 0x0400C124 RID: 49444
		private Table __p;
	}
}
