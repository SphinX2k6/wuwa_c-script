using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005335 RID: 21301
	public struct IGroupAiMode : IFlatbufferObject
	{
		// Token: 0x17009C7D RID: 40061
		// (get) Token: 0x06022D4E RID: 142670 RVA: 0x004D3852 File Offset: 0x004D1A52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D4F RID: 142671 RVA: 0x004D385F File Offset: 0x004D1A5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D50 RID: 142672 RVA: 0x004D3868 File Offset: 0x004D1A68
		public static IGroupAiMode GetRootAsIGroupAiMode(ByteBuffer _bb)
		{
			return IGroupAiMode.GetRootAsIGroupAiMode(_bb, default(IGroupAiMode));
		}

		// Token: 0x06022D51 RID: 142673 RVA: 0x004D3884 File Offset: 0x004D1A84
		public static IGroupAiMode GetRootAsIGroupAiMode(ByteBuffer _bb, IGroupAiMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D52 RID: 142674 RVA: 0x004D38A1 File Offset: 0x004D1AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D53 RID: 142675 RVA: 0x004D38B0 File Offset: 0x004D1AB0
		public IGroupAiMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C7E RID: 40062
		// (get) Token: 0x06022D54 RID: 142676 RVA: 0x004D38C0 File Offset: 0x004D1AC0
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

		// Token: 0x06022D55 RID: 142677 RVA: 0x004D38FC File Offset: 0x004D1AFC
		public static Offset<IGroupAiMode> CreateIGroupAiMode(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default)
		{
			builder.StartTable(1);
			IGroupAiMode.AddType(builder, Type);
			return IGroupAiMode.EndIGroupAiMode(builder);
		}

		// Token: 0x06022D56 RID: 142678 RVA: 0x004D3912 File Offset: 0x004D1B12
		public static void StartIGroupAiMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022D57 RID: 142679 RVA: 0x004D391B File Offset: 0x004D1B1B
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022D58 RID: 142680 RVA: 0x004D3926 File Offset: 0x004D1B26
		public static Offset<IGroupAiMode> EndIGroupAiMode(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMode>(builder.EndTable());
		}

		// Token: 0x06022D59 RID: 142681 RVA: 0x004D3934 File Offset: 0x004D1B34
		public IGroupAiModeT UnPack()
		{
			IGroupAiModeT groupAiModeT = new IGroupAiModeT();
			this.UnPackTo(groupAiModeT);
			return groupAiModeT;
		}

		// Token: 0x06022D5A RID: 142682 RVA: 0x004D394F File Offset: 0x004D1B4F
		public void UnPackTo(IGroupAiModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022D5B RID: 142683 RVA: 0x004D3960 File Offset: 0x004D1B60
		public static Offset<IGroupAiMode> Pack(FlatBufferBuilder builder, IGroupAiModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiMode>);
			}
			return IGroupAiMode.CreateIGroupAiMode(builder, _o.Type);
		}

		// Token: 0x0400E4FC RID: 58620
		private Table __p;
	}
}
