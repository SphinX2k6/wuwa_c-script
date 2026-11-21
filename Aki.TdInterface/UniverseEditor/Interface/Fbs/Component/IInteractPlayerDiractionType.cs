using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E7 RID: 23015
	public struct IInteractPlayerDiractionType : IFlatbufferObject
	{
		// Token: 0x1700A747 RID: 42823
		// (get) Token: 0x0602594D RID: 153933 RVA: 0x00527761 File Offset: 0x00525961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602594E RID: 153934 RVA: 0x0052776E File Offset: 0x0052596E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602594F RID: 153935 RVA: 0x00527778 File Offset: 0x00525978
		public static IInteractPlayerDiractionType GetRootAsIInteractPlayerDiractionType(ByteBuffer _bb)
		{
			return IInteractPlayerDiractionType.GetRootAsIInteractPlayerDiractionType(_bb, default(IInteractPlayerDiractionType));
		}

		// Token: 0x06025950 RID: 153936 RVA: 0x00527794 File Offset: 0x00525994
		public static IInteractPlayerDiractionType GetRootAsIInteractPlayerDiractionType(ByteBuffer _bb, IInteractPlayerDiractionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025951 RID: 153937 RVA: 0x005277B1 File Offset: 0x005259B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025952 RID: 153938 RVA: 0x005277C0 File Offset: 0x005259C0
		public IInteractPlayerDiractionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A748 RID: 42824
		// (get) Token: 0x06025953 RID: 153939 RVA: 0x005277D0 File Offset: 0x005259D0
		public EInteractPlayerDiractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractPlayerDiractionType.Npc;
				}
				return (EInteractPlayerDiractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025954 RID: 153940 RVA: 0x0052780C File Offset: 0x00525A0C
		public static Offset<IInteractPlayerDiractionType> CreateIInteractPlayerDiractionType(FlatBufferBuilder builder, EInteractPlayerDiractionType Type = EInteractPlayerDiractionType.Npc)
		{
			builder.StartTable(1);
			IInteractPlayerDiractionType.AddType(builder, Type);
			return IInteractPlayerDiractionType.EndIInteractPlayerDiractionType(builder);
		}

		// Token: 0x06025955 RID: 153941 RVA: 0x00527822 File Offset: 0x00525A22
		public static void StartIInteractPlayerDiractionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025956 RID: 153942 RVA: 0x0052782B File Offset: 0x00525A2B
		public static void AddType(FlatBufferBuilder builder, EInteractPlayerDiractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025957 RID: 153943 RVA: 0x00527836 File Offset: 0x00525A36
		public static Offset<IInteractPlayerDiractionType> EndIInteractPlayerDiractionType(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPlayerDiractionType>(builder.EndTable());
		}

		// Token: 0x06025958 RID: 153944 RVA: 0x00527844 File Offset: 0x00525A44
		public IInteractPlayerDiractionTypeT UnPack()
		{
			IInteractPlayerDiractionTypeT interactPlayerDiractionTypeT = new IInteractPlayerDiractionTypeT();
			this.UnPackTo(interactPlayerDiractionTypeT);
			return interactPlayerDiractionTypeT;
		}

		// Token: 0x06025959 RID: 153945 RVA: 0x0052785F File Offset: 0x00525A5F
		public void UnPackTo(IInteractPlayerDiractionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602595A RID: 153946 RVA: 0x00527870 File Offset: 0x00525A70
		public static Offset<IInteractPlayerDiractionType> Pack(FlatBufferBuilder builder, IInteractPlayerDiractionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPlayerDiractionType>);
			}
			return IInteractPlayerDiractionType.CreateIInteractPlayerDiractionType(builder, _o.Type);
		}

		// Token: 0x0400F30B RID: 62219
		private Table __p;
	}
}
