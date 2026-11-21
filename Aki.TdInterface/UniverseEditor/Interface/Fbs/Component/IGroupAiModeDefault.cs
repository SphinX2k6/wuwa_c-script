using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BE RID: 22718
	public struct IGroupAiModeDefault : IFlatbufferObject
	{
		// Token: 0x1700A4B8 RID: 42168
		// (get) Token: 0x06024E14 RID: 151060 RVA: 0x0051089D File Offset: 0x0050EA9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E15 RID: 151061 RVA: 0x005108AA File Offset: 0x0050EAAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E16 RID: 151062 RVA: 0x005108B4 File Offset: 0x0050EAB4
		public static IGroupAiModeDefault GetRootAsIGroupAiModeDefault(ByteBuffer _bb)
		{
			return IGroupAiModeDefault.GetRootAsIGroupAiModeDefault(_bb, default(IGroupAiModeDefault));
		}

		// Token: 0x06024E17 RID: 151063 RVA: 0x005108D0 File Offset: 0x0050EAD0
		public static IGroupAiModeDefault GetRootAsIGroupAiModeDefault(ByteBuffer _bb, IGroupAiModeDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E18 RID: 151064 RVA: 0x005108ED File Offset: 0x0050EAED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E19 RID: 151065 RVA: 0x005108FC File Offset: 0x0050EAFC
		public IGroupAiModeDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4B9 RID: 42169
		// (get) Token: 0x06024E1A RID: 151066 RVA: 0x0051090C File Offset: 0x0050EB0C
		public EGroupAiMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiMode.Default;
				}
				return (EGroupAiMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024E1B RID: 151067 RVA: 0x00510948 File Offset: 0x0050EB48
		public static Offset<IGroupAiModeDefault> CreateIGroupAiModeDefault(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default)
		{
			builder.StartTable(1);
			IGroupAiModeDefault.AddType(builder, Type);
			return IGroupAiModeDefault.EndIGroupAiModeDefault(builder);
		}

		// Token: 0x06024E1C RID: 151068 RVA: 0x0051095E File Offset: 0x0050EB5E
		public static void StartIGroupAiModeDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024E1D RID: 151069 RVA: 0x00510967 File Offset: 0x0050EB67
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024E1E RID: 151070 RVA: 0x00510972 File Offset: 0x0050EB72
		public static Offset<IGroupAiModeDefault> EndIGroupAiModeDefault(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiModeDefault>(builder.EndTable());
		}

		// Token: 0x06024E1F RID: 151071 RVA: 0x00510980 File Offset: 0x0050EB80
		public IGroupAiModeDefaultT UnPack()
		{
			IGroupAiModeDefaultT groupAiModeDefaultT = new IGroupAiModeDefaultT();
			this.UnPackTo(groupAiModeDefaultT);
			return groupAiModeDefaultT;
		}

		// Token: 0x06024E20 RID: 151072 RVA: 0x0051099B File Offset: 0x0050EB9B
		public void UnPackTo(IGroupAiModeDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024E21 RID: 151073 RVA: 0x005109AC File Offset: 0x0050EBAC
		public static Offset<IGroupAiModeDefault> Pack(FlatBufferBuilder builder, IGroupAiModeDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiModeDefault>);
			}
			return IGroupAiModeDefault.CreateIGroupAiModeDefault(builder, _o.Type);
		}

		// Token: 0x0400F12E RID: 61742
		private Table __p;
	}
}
