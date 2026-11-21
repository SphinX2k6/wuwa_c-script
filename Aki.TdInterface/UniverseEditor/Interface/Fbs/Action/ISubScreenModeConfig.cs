using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E6 RID: 31206
	public struct ISubScreenModeConfig : IFlatbufferObject
	{
		// Token: 0x1700E4C4 RID: 58564
		// (get) Token: 0x06036FBA RID: 225210 RVA: 0x00759C20 File Offset: 0x00757E20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036FBB RID: 225211 RVA: 0x00759C2D File Offset: 0x00757E2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FBC RID: 225212 RVA: 0x00759C34 File Offset: 0x00757E34
		public static ISubScreenModeConfig GetRootAsISubScreenModeConfig(ByteBuffer _bb)
		{
			return ISubScreenModeConfig.GetRootAsISubScreenModeConfig(_bb, default(ISubScreenModeConfig));
		}

		// Token: 0x06036FBD RID: 225213 RVA: 0x00759C50 File Offset: 0x00757E50
		public static ISubScreenModeConfig GetRootAsISubScreenModeConfig(ByteBuffer _bb, ISubScreenModeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FBE RID: 225214 RVA: 0x00759C6D File Offset: 0x00757E6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FBF RID: 225215 RVA: 0x00759C7C File Offset: 0x00757E7C
		public ISubScreenModeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4C5 RID: 58565
		// (get) Token: 0x06036FC0 RID: 225216 RVA: 0x00759C8C File Offset: 0x00757E8C
		public ESubScreenOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubScreenOperationType.Init;
				}
				return (ESubScreenOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036FC1 RID: 225217 RVA: 0x00759CC8 File Offset: 0x00757EC8
		public static Offset<ISubScreenModeConfig> CreateISubScreenModeConfig(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init)
		{
			builder.StartTable(1);
			ISubScreenModeConfig.AddType(builder, Type);
			return ISubScreenModeConfig.EndISubScreenModeConfig(builder);
		}

		// Token: 0x06036FC2 RID: 225218 RVA: 0x00759CDE File Offset: 0x00757EDE
		public static void StartISubScreenModeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036FC3 RID: 225219 RVA: 0x00759CE7 File Offset: 0x00757EE7
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036FC4 RID: 225220 RVA: 0x00759CF2 File Offset: 0x00757EF2
		public static Offset<ISubScreenModeConfig> EndISubScreenModeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeConfig>(builder.EndTable());
		}

		// Token: 0x06036FC5 RID: 225221 RVA: 0x00759D00 File Offset: 0x00757F00
		public ISubScreenModeConfigT UnPack()
		{
			ISubScreenModeConfigT subScreenModeConfigT = new ISubScreenModeConfigT();
			this.UnPackTo(subScreenModeConfigT);
			return subScreenModeConfigT;
		}

		// Token: 0x06036FC6 RID: 225222 RVA: 0x00759D1B File Offset: 0x00757F1B
		public void UnPackTo(ISubScreenModeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036FC7 RID: 225223 RVA: 0x00759D2C File Offset: 0x00757F2C
		public static Offset<ISubScreenModeConfig> Pack(FlatBufferBuilder builder, ISubScreenModeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenModeConfig>);
			}
			return ISubScreenModeConfig.CreateISubScreenModeConfig(builder, _o.Type);
		}

		// Token: 0x04012CFE RID: 77054
		private Table __p;
	}
}
