using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE6 RID: 16102
	public struct ITargetPlay : IFlatbufferObject
	{
		// Token: 0x17006D08 RID: 27912
		// (get) Token: 0x06015D4C RID: 89420 RVA: 0x0032403E File Offset: 0x0032223E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D4D RID: 89421 RVA: 0x0032404B File Offset: 0x0032224B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D4E RID: 89422 RVA: 0x00324054 File Offset: 0x00322254
		public static ITargetPlay GetRootAsITargetPlay(ByteBuffer _bb)
		{
			return ITargetPlay.GetRootAsITargetPlay(_bb, default(ITargetPlay));
		}

		// Token: 0x06015D4F RID: 89423 RVA: 0x00324070 File Offset: 0x00322270
		public static ITargetPlay GetRootAsITargetPlay(ByteBuffer _bb, ITargetPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D50 RID: 89424 RVA: 0x0032408D File Offset: 0x0032228D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D51 RID: 89425 RVA: 0x0032409C File Offset: 0x0032229C
		public ITargetPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D09 RID: 27913
		// (get) Token: 0x06015D52 RID: 89426 RVA: 0x003240AC File Offset: 0x003222AC
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015D53 RID: 89427 RVA: 0x003240E8 File Offset: 0x003222E8
		public static Offset<ITargetPlay> CreateITargetPlay(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player)
		{
			builder.StartTable(1);
			ITargetPlay.AddType(builder, Type);
			return ITargetPlay.EndITargetPlay(builder);
		}

		// Token: 0x06015D54 RID: 89428 RVA: 0x003240FE File Offset: 0x003222FE
		public static void StartITargetPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015D55 RID: 89429 RVA: 0x00324107 File Offset: 0x00322307
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015D56 RID: 89430 RVA: 0x00324112 File Offset: 0x00322312
		public static Offset<ITargetPlay> EndITargetPlay(FlatBufferBuilder builder)
		{
			return new Offset<ITargetPlay>(builder.EndTable());
		}

		// Token: 0x06015D57 RID: 89431 RVA: 0x00324120 File Offset: 0x00322320
		public ITargetPlayT UnPack()
		{
			ITargetPlayT targetPlayT = new ITargetPlayT();
			this.UnPackTo(targetPlayT);
			return targetPlayT;
		}

		// Token: 0x06015D58 RID: 89432 RVA: 0x0032413B File Offset: 0x0032233B
		public void UnPackTo(ITargetPlayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015D59 RID: 89433 RVA: 0x0032414C File Offset: 0x0032234C
		public static Offset<ITargetPlay> Pack(FlatBufferBuilder builder, ITargetPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetPlay>);
			}
			return ITargetPlay.CreateITargetPlay(builder, _o.Type);
		}

		// Token: 0x0400B912 RID: 47378
		private Table __p;
	}
}
