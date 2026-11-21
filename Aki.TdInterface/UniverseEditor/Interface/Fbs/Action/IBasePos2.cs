using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006850 RID: 26704
	public struct IBasePos2 : IFlatbufferObject
	{
		// Token: 0x1700C459 RID: 50265
		// (get) Token: 0x0602DA56 RID: 186966 RVA: 0x0063E906 File Offset: 0x0063CB06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA57 RID: 186967 RVA: 0x0063E913 File Offset: 0x0063CB13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA58 RID: 186968 RVA: 0x0063E91C File Offset: 0x0063CB1C
		public static IBasePos2 GetRootAsIBasePos2(ByteBuffer _bb)
		{
			return IBasePos2.GetRootAsIBasePos2(_bb, default(IBasePos2));
		}

		// Token: 0x0602DA59 RID: 186969 RVA: 0x0063E938 File Offset: 0x0063CB38
		public static IBasePos2 GetRootAsIBasePos2(ByteBuffer _bb, IBasePos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA5A RID: 186970 RVA: 0x0063E955 File Offset: 0x0063CB55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA5B RID: 186971 RVA: 0x0063E964 File Offset: 0x0063CB64
		public IBasePos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C45A RID: 50266
		// (get) Token: 0x0602DA5C RID: 186972 RVA: 0x0063E974 File Offset: 0x0063CB74
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

		// Token: 0x0602DA5D RID: 186973 RVA: 0x0063E9B0 File Offset: 0x0063CBB0
		public static Offset<IBasePos2> CreateIBasePos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player)
		{
			builder.StartTable(1);
			IBasePos2.AddType(builder, Type);
			return IBasePos2.EndIBasePos2(builder);
		}

		// Token: 0x0602DA5E RID: 186974 RVA: 0x0063E9C6 File Offset: 0x0063CBC6
		public static void StartIBasePos2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DA5F RID: 186975 RVA: 0x0063E9CF File Offset: 0x0063CBCF
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DA60 RID: 186976 RVA: 0x0063E9DA File Offset: 0x0063CBDA
		public static Offset<IBasePos2> EndIBasePos2(FlatBufferBuilder builder)
		{
			return new Offset<IBasePos2>(builder.EndTable());
		}

		// Token: 0x0602DA61 RID: 186977 RVA: 0x0063E9E8 File Offset: 0x0063CBE8
		public IBasePos2T UnPack()
		{
			IBasePos2T basePos2T = new IBasePos2T();
			this.UnPackTo(basePos2T);
			return basePos2T;
		}

		// Token: 0x0602DA62 RID: 186978 RVA: 0x0063EA03 File Offset: 0x0063CC03
		public void UnPackTo(IBasePos2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DA63 RID: 186979 RVA: 0x0063EA14 File Offset: 0x0063CC14
		public static Offset<IBasePos2> Pack(FlatBufferBuilder builder, IBasePos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IBasePos2>);
			}
			return IBasePos2.CreateIBasePos2(builder, _o.Type);
		}

		// Token: 0x04011521 RID: 70945
		private Table __p;
	}
}
