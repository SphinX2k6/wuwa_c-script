using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C4 RID: 28868
	public struct ILimitPlayerBlockAll : IFlatbufferObject
	{
		// Token: 0x1700D377 RID: 54135
		// (get) Token: 0x0603220F RID: 205327 RVA: 0x006C8905 File Offset: 0x006C6B05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032210 RID: 205328 RVA: 0x006C8912 File Offset: 0x006C6B12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032211 RID: 205329 RVA: 0x006C891C File Offset: 0x006C6B1C
		public static ILimitPlayerBlockAll GetRootAsILimitPlayerBlockAll(ByteBuffer _bb)
		{
			return ILimitPlayerBlockAll.GetRootAsILimitPlayerBlockAll(_bb, default(ILimitPlayerBlockAll));
		}

		// Token: 0x06032212 RID: 205330 RVA: 0x006C8938 File Offset: 0x006C6B38
		public static ILimitPlayerBlockAll GetRootAsILimitPlayerBlockAll(ByteBuffer _bb, ILimitPlayerBlockAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032213 RID: 205331 RVA: 0x006C8955 File Offset: 0x006C6B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032214 RID: 205332 RVA: 0x006C8964 File Offset: 0x006C6B64
		public ILimitPlayerBlockAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D378 RID: 54136
		// (get) Token: 0x06032215 RID: 205333 RVA: 0x006C8974 File Offset: 0x006C6B74
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032216 RID: 205334 RVA: 0x006C89B0 File Offset: 0x006C6BB0
		public static Offset<ILimitPlayerBlockAll> CreateILimitPlayerBlockAll(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerBlockAll.AddType(builder, Type);
			return ILimitPlayerBlockAll.EndILimitPlayerBlockAll(builder);
		}

		// Token: 0x06032217 RID: 205335 RVA: 0x006C89C6 File Offset: 0x006C6BC6
		public static void StartILimitPlayerBlockAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032218 RID: 205336 RVA: 0x006C89CF File Offset: 0x006C6BCF
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032219 RID: 205337 RVA: 0x006C89DA File Offset: 0x006C6BDA
		public static Offset<ILimitPlayerBlockAll> EndILimitPlayerBlockAll(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerBlockAll>(builder.EndTable());
		}

		// Token: 0x0603221A RID: 205338 RVA: 0x006C89E8 File Offset: 0x006C6BE8
		public ILimitPlayerBlockAllT UnPack()
		{
			ILimitPlayerBlockAllT limitPlayerBlockAllT = new ILimitPlayerBlockAllT();
			this.UnPackTo(limitPlayerBlockAllT);
			return limitPlayerBlockAllT;
		}

		// Token: 0x0603221B RID: 205339 RVA: 0x006C8A03 File Offset: 0x006C6C03
		public void UnPackTo(ILimitPlayerBlockAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603221C RID: 205340 RVA: 0x006C8A14 File Offset: 0x006C6C14
		public static Offset<ILimitPlayerBlockAll> Pack(FlatBufferBuilder builder, ILimitPlayerBlockAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerBlockAll>);
			}
			return ILimitPlayerBlockAll.CreateILimitPlayerBlockAll(builder, _o.Type);
		}

		// Token: 0x04012085 RID: 73861
		private Table __p;
	}
}
