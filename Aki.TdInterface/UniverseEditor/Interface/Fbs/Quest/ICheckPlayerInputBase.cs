using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416F RID: 16751
	public struct ICheckPlayerInputBase : IFlatbufferObject
	{
		// Token: 0x17007183 RID: 29059
		// (get) Token: 0x060170D1 RID: 94417 RVA: 0x00349744 File Offset: 0x00347944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170D2 RID: 94418 RVA: 0x00349751 File Offset: 0x00347951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170D3 RID: 94419 RVA: 0x00349758 File Offset: 0x00347958
		public static ICheckPlayerInputBase GetRootAsICheckPlayerInputBase(ByteBuffer _bb)
		{
			return ICheckPlayerInputBase.GetRootAsICheckPlayerInputBase(_bb, default(ICheckPlayerInputBase));
		}

		// Token: 0x060170D4 RID: 94420 RVA: 0x00349774 File Offset: 0x00347974
		public static ICheckPlayerInputBase GetRootAsICheckPlayerInputBase(ByteBuffer _bb, ICheckPlayerInputBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170D5 RID: 94421 RVA: 0x00349791 File Offset: 0x00347991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170D6 RID: 94422 RVA: 0x003497A0 File Offset: 0x003479A0
		public ICheckPlayerInputBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007184 RID: 29060
		// (get) Token: 0x060170D7 RID: 94423 RVA: 0x003497B0 File Offset: 0x003479B0
		public ECheckPlayerInputType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckPlayerInputType.PressButton;
				}
				return (ECheckPlayerInputType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060170D8 RID: 94424 RVA: 0x003497EC File Offset: 0x003479EC
		public static Offset<ICheckPlayerInputBase> CreateICheckPlayerInputBase(FlatBufferBuilder builder, ECheckPlayerInputType Type = ECheckPlayerInputType.PressButton)
		{
			builder.StartTable(1);
			ICheckPlayerInputBase.AddType(builder, Type);
			return ICheckPlayerInputBase.EndICheckPlayerInputBase(builder);
		}

		// Token: 0x060170D9 RID: 94425 RVA: 0x00349802 File Offset: 0x00347A02
		public static void StartICheckPlayerInputBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060170DA RID: 94426 RVA: 0x0034980B File Offset: 0x00347A0B
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerInputType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170DB RID: 94427 RVA: 0x00349816 File Offset: 0x00347A16
		public static Offset<ICheckPlayerInputBase> EndICheckPlayerInputBase(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerInputBase>(builder.EndTable());
		}

		// Token: 0x060170DC RID: 94428 RVA: 0x00349824 File Offset: 0x00347A24
		public ICheckPlayerInputBaseT UnPack()
		{
			ICheckPlayerInputBaseT checkPlayerInputBaseT = new ICheckPlayerInputBaseT();
			this.UnPackTo(checkPlayerInputBaseT);
			return checkPlayerInputBaseT;
		}

		// Token: 0x060170DD RID: 94429 RVA: 0x0034983F File Offset: 0x00347A3F
		public void UnPackTo(ICheckPlayerInputBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060170DE RID: 94430 RVA: 0x00349850 File Offset: 0x00347A50
		public static Offset<ICheckPlayerInputBase> Pack(FlatBufferBuilder builder, ICheckPlayerInputBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerInputBase>);
			}
			return ICheckPlayerInputBase.CreateICheckPlayerInputBase(builder, _o.Type);
		}

		// Token: 0x0400BFE3 RID: 49123
		private Table __p;
	}
}
