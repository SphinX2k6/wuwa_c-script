using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007255 RID: 29269
	public struct IMotorParamsChangeConfig : IFlatbufferObject
	{
		// Token: 0x1700D6A2 RID: 54946
		// (get) Token: 0x06032FF0 RID: 208880 RVA: 0x006E2588 File Offset: 0x006E0788
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032FF1 RID: 208881 RVA: 0x006E2595 File Offset: 0x006E0795
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032FF2 RID: 208882 RVA: 0x006E259C File Offset: 0x006E079C
		public static IMotorParamsChangeConfig GetRootAsIMotorParamsChangeConfig(ByteBuffer _bb)
		{
			return IMotorParamsChangeConfig.GetRootAsIMotorParamsChangeConfig(_bb, default(IMotorParamsChangeConfig));
		}

		// Token: 0x06032FF3 RID: 208883 RVA: 0x006E25B8 File Offset: 0x006E07B8
		public static IMotorParamsChangeConfig GetRootAsIMotorParamsChangeConfig(ByteBuffer _bb, IMotorParamsChangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032FF4 RID: 208884 RVA: 0x006E25D5 File Offset: 0x006E07D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032FF5 RID: 208885 RVA: 0x006E25E4 File Offset: 0x006E07E4
		public IMotorParamsChangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6A3 RID: 54947
		// (get) Token: 0x06032FF6 RID: 208886 RVA: 0x006E25F4 File Offset: 0x006E07F4
		public EMotorParamsChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorParamsChangeType.SpeedUp;
				}
				return (EMotorParamsChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032FF7 RID: 208887 RVA: 0x006E2630 File Offset: 0x006E0830
		public static Offset<IMotorParamsChangeConfig> CreateIMotorParamsChangeConfig(FlatBufferBuilder builder, EMotorParamsChangeType Type = EMotorParamsChangeType.SpeedUp)
		{
			builder.StartTable(1);
			IMotorParamsChangeConfig.AddType(builder, Type);
			return IMotorParamsChangeConfig.EndIMotorParamsChangeConfig(builder);
		}

		// Token: 0x06032FF8 RID: 208888 RVA: 0x006E2646 File Offset: 0x006E0846
		public static void StartIMotorParamsChangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032FF9 RID: 208889 RVA: 0x006E264F File Offset: 0x006E084F
		public static void AddType(FlatBufferBuilder builder, EMotorParamsChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032FFA RID: 208890 RVA: 0x006E265A File Offset: 0x006E085A
		public static Offset<IMotorParamsChangeConfig> EndIMotorParamsChangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorParamsChangeConfig>(builder.EndTable());
		}

		// Token: 0x06032FFB RID: 208891 RVA: 0x006E2668 File Offset: 0x006E0868
		public IMotorParamsChangeConfigT UnPack()
		{
			IMotorParamsChangeConfigT motorParamsChangeConfigT = new IMotorParamsChangeConfigT();
			this.UnPackTo(motorParamsChangeConfigT);
			return motorParamsChangeConfigT;
		}

		// Token: 0x06032FFC RID: 208892 RVA: 0x006E2683 File Offset: 0x006E0883
		public void UnPackTo(IMotorParamsChangeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032FFD RID: 208893 RVA: 0x006E2694 File Offset: 0x006E0894
		public static Offset<IMotorParamsChangeConfig> Pack(FlatBufferBuilder builder, IMotorParamsChangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorParamsChangeConfig>);
			}
			return IMotorParamsChangeConfig.CreateIMotorParamsChangeConfig(builder, _o.Type);
		}

		// Token: 0x040122C3 RID: 74435
		private Table __p;
	}
}
