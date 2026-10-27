using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F1 RID: 25585
	public struct IClientSetSeasonStateConfig : IFlatbufferObject
	{
		// Token: 0x1700BE8E RID: 48782
		// (get) Token: 0x0602C435 RID: 181301 RVA: 0x00613528 File Offset: 0x00611728
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C436 RID: 181302 RVA: 0x00613535 File Offset: 0x00611735
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C437 RID: 181303 RVA: 0x0061353C File Offset: 0x0061173C
		public static IClientSetSeasonStateConfig GetRootAsIClientSetSeasonStateConfig(ByteBuffer _bb)
		{
			return IClientSetSeasonStateConfig.GetRootAsIClientSetSeasonStateConfig(_bb, default(IClientSetSeasonStateConfig));
		}

		// Token: 0x0602C438 RID: 181304 RVA: 0x00613558 File Offset: 0x00611758
		public static IClientSetSeasonStateConfig GetRootAsIClientSetSeasonStateConfig(ByteBuffer _bb, IClientSetSeasonStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C439 RID: 181305 RVA: 0x00613575 File Offset: 0x00611775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C43A RID: 181306 RVA: 0x00613584 File Offset: 0x00611784
		public IClientSetSeasonStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE8F RID: 48783
		// (get) Token: 0x0602C43B RID: 181307 RVA: 0x00613594 File Offset: 0x00611794
		public EClientSetSeasonStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return (EClientSetSeasonStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C43C RID: 181308 RVA: 0x006135D0 File Offset: 0x006117D0
		public static Offset<IClientSetSeasonStateConfig> CreateIClientSetSeasonStateConfig(FlatBufferBuilder builder, EClientSetSeasonStateType Type = EClientSetSeasonStateType.SwitchSeason)
		{
			builder.StartTable(1);
			IClientSetSeasonStateConfig.AddType(builder, Type);
			return IClientSetSeasonStateConfig.EndIClientSetSeasonStateConfig(builder);
		}

		// Token: 0x0602C43D RID: 181309 RVA: 0x006135E6 File Offset: 0x006117E6
		public static void StartIClientSetSeasonStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C43E RID: 181310 RVA: 0x006135EF File Offset: 0x006117EF
		public static void AddType(FlatBufferBuilder builder, EClientSetSeasonStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C43F RID: 181311 RVA: 0x006135FA File Offset: 0x006117FA
		public static Offset<IClientSetSeasonStateConfig> EndIClientSetSeasonStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetSeasonStateConfig>(builder.EndTable());
		}

		// Token: 0x0602C440 RID: 181312 RVA: 0x00613608 File Offset: 0x00611808
		public IClientSetSeasonStateConfigT UnPack()
		{
			IClientSetSeasonStateConfigT clientSetSeasonStateConfigT = new IClientSetSeasonStateConfigT();
			this.UnPackTo(clientSetSeasonStateConfigT);
			return clientSetSeasonStateConfigT;
		}

		// Token: 0x0602C441 RID: 181313 RVA: 0x00613623 File Offset: 0x00611823
		public void UnPackTo(IClientSetSeasonStateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C442 RID: 181314 RVA: 0x00613634 File Offset: 0x00611834
		public static Offset<IClientSetSeasonStateConfig> Pack(FlatBufferBuilder builder, IClientSetSeasonStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSetSeasonStateConfig>);
			}
			return IClientSetSeasonStateConfig.CreateIClientSetSeasonStateConfig(builder, _o.Type);
		}

		// Token: 0x040109D6 RID: 68054
		private Table __p;
	}
}
