using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D58 RID: 15704
	public struct ICheckPlayerInputBase : IFlatbufferObject
	{
		// Token: 0x17006BC9 RID: 27593
		// (get) Token: 0x06015B99 RID: 88985 RVA: 0x003224CC File Offset: 0x003206CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B9A RID: 88986 RVA: 0x003224D9 File Offset: 0x003206D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B9B RID: 88987 RVA: 0x003224E0 File Offset: 0x003206E0
		public static ICheckPlayerInputBase GetRootAsICheckPlayerInputBase(ByteBuffer _bb)
		{
			return ICheckPlayerInputBase.GetRootAsICheckPlayerInputBase(_bb, default(ICheckPlayerInputBase));
		}

		// Token: 0x06015B9C RID: 88988 RVA: 0x003224FC File Offset: 0x003206FC
		public static ICheckPlayerInputBase GetRootAsICheckPlayerInputBase(ByteBuffer _bb, ICheckPlayerInputBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B9D RID: 88989 RVA: 0x00322519 File Offset: 0x00320719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B9E RID: 88990 RVA: 0x00322528 File Offset: 0x00320728
		public ICheckPlayerInputBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BCA RID: 27594
		// (get) Token: 0x06015B9F RID: 88991 RVA: 0x00322538 File Offset: 0x00320738
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

		// Token: 0x06015BA0 RID: 88992 RVA: 0x00322574 File Offset: 0x00320774
		public static Offset<ICheckPlayerInputBase> CreateICheckPlayerInputBase(FlatBufferBuilder builder, ECheckPlayerInputType Type = ECheckPlayerInputType.PressButton)
		{
			builder.StartTable(1);
			ICheckPlayerInputBase.AddType(builder, Type);
			return ICheckPlayerInputBase.EndICheckPlayerInputBase(builder);
		}

		// Token: 0x06015BA1 RID: 88993 RVA: 0x0032258A File Offset: 0x0032078A
		public static void StartICheckPlayerInputBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015BA2 RID: 88994 RVA: 0x00322593 File Offset: 0x00320793
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerInputType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015BA3 RID: 88995 RVA: 0x0032259E File Offset: 0x0032079E
		public static Offset<ICheckPlayerInputBase> EndICheckPlayerInputBase(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerInputBase>(builder.EndTable());
		}

		// Token: 0x06015BA4 RID: 88996 RVA: 0x003225AC File Offset: 0x003207AC
		public ICheckPlayerInputBaseT UnPack()
		{
			ICheckPlayerInputBaseT checkPlayerInputBaseT = new ICheckPlayerInputBaseT();
			this.UnPackTo(checkPlayerInputBaseT);
			return checkPlayerInputBaseT;
		}

		// Token: 0x06015BA5 RID: 88997 RVA: 0x003225C7 File Offset: 0x003207C7
		public void UnPackTo(ICheckPlayerInputBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015BA6 RID: 88998 RVA: 0x003225D8 File Offset: 0x003207D8
		public static Offset<ICheckPlayerInputBase> Pack(FlatBufferBuilder builder, ICheckPlayerInputBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerInputBase>);
			}
			return ICheckPlayerInputBase.CreateICheckPlayerInputBase(builder, _o.Type);
		}

		// Token: 0x0400B636 RID: 46646
		private Table __p;
	}
}
