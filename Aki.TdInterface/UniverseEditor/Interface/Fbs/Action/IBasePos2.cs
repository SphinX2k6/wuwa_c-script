using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E2 RID: 25058
	public struct IBasePos2 : IFlatbufferObject
	{
		// Token: 0x1700BAD6 RID: 47830
		// (get) Token: 0x0602B30F RID: 176911 RVA: 0x005F3E92 File Offset: 0x005F2092
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B310 RID: 176912 RVA: 0x005F3E9F File Offset: 0x005F209F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B311 RID: 176913 RVA: 0x005F3EA8 File Offset: 0x005F20A8
		public static IBasePos2 GetRootAsIBasePos2(ByteBuffer _bb)
		{
			return IBasePos2.GetRootAsIBasePos2(_bb, default(IBasePos2));
		}

		// Token: 0x0602B312 RID: 176914 RVA: 0x005F3EC4 File Offset: 0x005F20C4
		public static IBasePos2 GetRootAsIBasePos2(ByteBuffer _bb, IBasePos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B313 RID: 176915 RVA: 0x005F3EE1 File Offset: 0x005F20E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B314 RID: 176916 RVA: 0x005F3EF0 File Offset: 0x005F20F0
		public IBasePos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAD7 RID: 47831
		// (get) Token: 0x0602B315 RID: 176917 RVA: 0x005F3F00 File Offset: 0x005F2100
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B316 RID: 176918 RVA: 0x005F3F3C File Offset: 0x005F213C
		public static Offset<IBasePos2> CreateIBasePos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player)
		{
			builder.StartTable(1);
			IBasePos2.AddType(builder, Type);
			return IBasePos2.EndIBasePos2(builder);
		}

		// Token: 0x0602B317 RID: 176919 RVA: 0x005F3F52 File Offset: 0x005F2152
		public static void StartIBasePos2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B318 RID: 176920 RVA: 0x005F3F5B File Offset: 0x005F215B
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B319 RID: 176921 RVA: 0x005F3F66 File Offset: 0x005F2166
		public static Offset<IBasePos2> EndIBasePos2(FlatBufferBuilder builder)
		{
			return new Offset<IBasePos2>(builder.EndTable());
		}

		// Token: 0x0602B31A RID: 176922 RVA: 0x005F3F74 File Offset: 0x005F2174
		public IBasePos2T UnPack()
		{
			IBasePos2T basePos2T = new IBasePos2T();
			this.UnPackTo(basePos2T);
			return basePos2T;
		}

		// Token: 0x0602B31B RID: 176923 RVA: 0x005F3F8F File Offset: 0x005F218F
		public void UnPackTo(IBasePos2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B31C RID: 176924 RVA: 0x005F3FA0 File Offset: 0x005F21A0
		public static Offset<IBasePos2> Pack(FlatBufferBuilder builder, IBasePos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IBasePos2>);
			}
			return IBasePos2.CreateIBasePos2(builder, _o.Type);
		}

		// Token: 0x0401070F RID: 67343
		private Table __p;
	}
}
