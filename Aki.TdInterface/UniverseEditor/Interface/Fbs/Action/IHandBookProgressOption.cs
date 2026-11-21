using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F65 RID: 28517
	public struct IHandBookProgressOption : IFlatbufferObject
	{
		// Token: 0x1700D0F0 RID: 53488
		// (get) Token: 0x060315C0 RID: 202176 RVA: 0x006B1D99 File Offset: 0x006AFF99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060315C1 RID: 202177 RVA: 0x006B1DA6 File Offset: 0x006AFFA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060315C2 RID: 202178 RVA: 0x006B1DB0 File Offset: 0x006AFFB0
		public static IHandBookProgressOption GetRootAsIHandBookProgressOption(ByteBuffer _bb)
		{
			return IHandBookProgressOption.GetRootAsIHandBookProgressOption(_bb, default(IHandBookProgressOption));
		}

		// Token: 0x060315C3 RID: 202179 RVA: 0x006B1DCC File Offset: 0x006AFFCC
		public static IHandBookProgressOption GetRootAsIHandBookProgressOption(ByteBuffer _bb, IHandBookProgressOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060315C4 RID: 202180 RVA: 0x006B1DE9 File Offset: 0x006AFFE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060315C5 RID: 202181 RVA: 0x006B1DF8 File Offset: 0x006AFFF8
		public IHandBookProgressOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0F1 RID: 53489
		// (get) Token: 0x060315C6 RID: 202182 RVA: 0x006B1E08 File Offset: 0x006B0008
		public EHandBookProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandBookProgressType.GrantEmoji;
				}
				return (EHandBookProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060315C7 RID: 202183 RVA: 0x006B1E44 File Offset: 0x006B0044
		public static Offset<IHandBookProgressOption> CreateIHandBookProgressOption(FlatBufferBuilder builder, EHandBookProgressType Type = EHandBookProgressType.GrantEmoji)
		{
			builder.StartTable(1);
			IHandBookProgressOption.AddType(builder, Type);
			return IHandBookProgressOption.EndIHandBookProgressOption(builder);
		}

		// Token: 0x060315C8 RID: 202184 RVA: 0x006B1E5A File Offset: 0x006B005A
		public static void StartIHandBookProgressOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060315C9 RID: 202185 RVA: 0x006B1E63 File Offset: 0x006B0063
		public static void AddType(FlatBufferBuilder builder, EHandBookProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060315CA RID: 202186 RVA: 0x006B1E6E File Offset: 0x006B006E
		public static Offset<IHandBookProgressOption> EndIHandBookProgressOption(FlatBufferBuilder builder)
		{
			return new Offset<IHandBookProgressOption>(builder.EndTable());
		}

		// Token: 0x060315CB RID: 202187 RVA: 0x006B1E7C File Offset: 0x006B007C
		public IHandBookProgressOptionT UnPack()
		{
			IHandBookProgressOptionT handBookProgressOptionT = new IHandBookProgressOptionT();
			this.UnPackTo(handBookProgressOptionT);
			return handBookProgressOptionT;
		}

		// Token: 0x060315CC RID: 202188 RVA: 0x006B1E97 File Offset: 0x006B0097
		public void UnPackTo(IHandBookProgressOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060315CD RID: 202189 RVA: 0x006B1EA8 File Offset: 0x006B00A8
		public static Offset<IHandBookProgressOption> Pack(FlatBufferBuilder builder, IHandBookProgressOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandBookProgressOption>);
			}
			return IHandBookProgressOption.CreateIHandBookProgressOption(builder, _o.Type);
		}

		// Token: 0x04011E73 RID: 73331
		private Table __p;
	}
}
