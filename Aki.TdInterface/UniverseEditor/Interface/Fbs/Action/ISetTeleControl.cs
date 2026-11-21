using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007854 RID: 30804
	public struct ISetTeleControl : IFlatbufferObject
	{
		// Token: 0x1700E1F8 RID: 57848
		// (get) Token: 0x060362CD RID: 221901 RVA: 0x00741E7C File Offset: 0x0074007C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060362CE RID: 221902 RVA: 0x00741E89 File Offset: 0x00740089
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060362CF RID: 221903 RVA: 0x00741E90 File Offset: 0x00740090
		public static ISetTeleControl GetRootAsISetTeleControl(ByteBuffer _bb)
		{
			return ISetTeleControl.GetRootAsISetTeleControl(_bb, default(ISetTeleControl));
		}

		// Token: 0x060362D0 RID: 221904 RVA: 0x00741EAC File Offset: 0x007400AC
		public static ISetTeleControl GetRootAsISetTeleControl(ByteBuffer _bb, ISetTeleControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060362D1 RID: 221905 RVA: 0x00741EC9 File Offset: 0x007400C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060362D2 RID: 221906 RVA: 0x00741ED8 File Offset: 0x007400D8
		public ISetTeleControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1F9 RID: 57849
		// (get) Token: 0x060362D3 RID: 221907 RVA: 0x00741EE8 File Offset: 0x007400E8
		public TSetTeleControlConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSetTeleControlConfig.NONE;
				}
				return (TSetTeleControlConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060362D4 RID: 221908 RVA: 0x00741F24 File Offset: 0x00740124
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060362D5 RID: 221909 RVA: 0x00741F68 File Offset: 0x00740168
		public IOpenGravity ConfigAsIOpenGravity()
		{
			return this.Config<IOpenGravity>().Value;
		}

		// Token: 0x060362D6 RID: 221910 RVA: 0x00741F84 File Offset: 0x00740184
		public ISetResetPosition ConfigAsISetResetPosition()
		{
			return this.Config<ISetResetPosition>().Value;
		}

		// Token: 0x060362D7 RID: 221911 RVA: 0x00741F9F File Offset: 0x0074019F
		public static Offset<ISetTeleControl> CreateISetTeleControl(FlatBufferBuilder builder, TSetTeleControlConfig Config_type = TSetTeleControlConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetTeleControl.AddConfig(builder, ConfigOffset);
			ISetTeleControl.AddConfigType(builder, Config_type);
			return ISetTeleControl.EndISetTeleControl(builder);
		}

		// Token: 0x060362D8 RID: 221912 RVA: 0x00741FBC File Offset: 0x007401BC
		public static void StartISetTeleControl(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060362D9 RID: 221913 RVA: 0x00741FC5 File Offset: 0x007401C5
		public static void AddConfigType(FlatBufferBuilder builder, TSetTeleControlConfig configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x060362DA RID: 221914 RVA: 0x00741FD0 File Offset: 0x007401D0
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x060362DB RID: 221915 RVA: 0x00741FDB File Offset: 0x007401DB
		public static Offset<ISetTeleControl> EndISetTeleControl(FlatBufferBuilder builder)
		{
			return new Offset<ISetTeleControl>(builder.EndTable());
		}

		// Token: 0x060362DC RID: 221916 RVA: 0x00741FE8 File Offset: 0x007401E8
		public ISetTeleControlT UnPack()
		{
			ISetTeleControlT setTeleControlT = new ISetTeleControlT();
			this.UnPackTo(setTeleControlT);
			return setTeleControlT;
		}

		// Token: 0x060362DD RID: 221917 RVA: 0x00742004 File Offset: 0x00740204
		public void UnPackTo(ISetTeleControlT _o)
		{
			_o.Config = new TSetTeleControlConfigUnion();
			_o.Config.Type = this.ConfigType;
			TSetTeleControlConfig configType = this.ConfigType;
			if (configType == TSetTeleControlConfig.IOpenGravity)
			{
				_o.Config.Value = ((this.Config<IOpenGravity>() != null) ? this.Config<IOpenGravity>().Value.UnPack() : null);
				return;
			}
			if (configType != TSetTeleControlConfig.ISetResetPosition)
			{
				return;
			}
			_o.Config.Value = ((this.Config<ISetResetPosition>() != null) ? this.Config<ISetResetPosition>().Value.UnPack() : null);
		}

		// Token: 0x060362DE RID: 221918 RVA: 0x007420A8 File Offset: 0x007402A8
		public static Offset<ISetTeleControl> Pack(FlatBufferBuilder builder, ISetTeleControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTeleControl>);
			}
			TSetTeleControlConfig config_type = (_o.Config == null) ? TSetTeleControlConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSetTeleControlConfigUnion.Pack(builder, _o.Config);
			return ISetTeleControl.CreateISetTeleControl(builder, config_type, configOffset);
		}

		// Token: 0x04012ADD RID: 76509
		private Table __p;
	}
}
