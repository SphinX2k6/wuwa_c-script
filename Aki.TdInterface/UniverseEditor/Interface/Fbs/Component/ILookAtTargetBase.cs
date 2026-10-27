using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550F RID: 21775
	public struct ILookAtTargetBase : IFlatbufferObject
	{
		// Token: 0x1700A0C7 RID: 41159
		// (get) Token: 0x06023F75 RID: 147317 RVA: 0x004F8B38 File Offset: 0x004F6D38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F76 RID: 147318 RVA: 0x004F8B45 File Offset: 0x004F6D45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F77 RID: 147319 RVA: 0x004F8B4C File Offset: 0x004F6D4C
		public static ILookAtTargetBase GetRootAsILookAtTargetBase(ByteBuffer _bb)
		{
			return ILookAtTargetBase.GetRootAsILookAtTargetBase(_bb, default(ILookAtTargetBase));
		}

		// Token: 0x06023F78 RID: 147320 RVA: 0x004F8B68 File Offset: 0x004F6D68
		public static ILookAtTargetBase GetRootAsILookAtTargetBase(ByteBuffer _bb, ILookAtTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F79 RID: 147321 RVA: 0x004F8B85 File Offset: 0x004F6D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F7A RID: 147322 RVA: 0x004F8B94 File Offset: 0x004F6D94
		public ILookAtTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0C8 RID: 41160
		// (get) Token: 0x06023F7B RID: 147323 RVA: 0x004F8BA4 File Offset: 0x004F6DA4
		public ELookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELookAtTargetType.Entity;
				}
				return (ELookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F7C RID: 147324 RVA: 0x004F8BE0 File Offset: 0x004F6DE0
		public static Offset<ILookAtTargetBase> CreateILookAtTargetBase(FlatBufferBuilder builder, ELookAtTargetType Type = ELookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ILookAtTargetBase.AddType(builder, Type);
			return ILookAtTargetBase.EndILookAtTargetBase(builder);
		}

		// Token: 0x06023F7D RID: 147325 RVA: 0x004F8BF6 File Offset: 0x004F6DF6
		public static void StartILookAtTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023F7E RID: 147326 RVA: 0x004F8BFF File Offset: 0x004F6DFF
		public static void AddType(FlatBufferBuilder builder, ELookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023F7F RID: 147327 RVA: 0x004F8C0A File Offset: 0x004F6E0A
		public static Offset<ILookAtTargetBase> EndILookAtTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTargetBase>(builder.EndTable());
		}

		// Token: 0x06023F80 RID: 147328 RVA: 0x004F8C18 File Offset: 0x004F6E18
		public ILookAtTargetBaseT UnPack()
		{
			ILookAtTargetBaseT lookAtTargetBaseT = new ILookAtTargetBaseT();
			this.UnPackTo(lookAtTargetBaseT);
			return lookAtTargetBaseT;
		}

		// Token: 0x06023F81 RID: 147329 RVA: 0x004F8C33 File Offset: 0x004F6E33
		public void UnPackTo(ILookAtTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023F82 RID: 147330 RVA: 0x004F8C44 File Offset: 0x004F6E44
		public static Offset<ILookAtTargetBase> Pack(FlatBufferBuilder builder, ILookAtTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTargetBase>);
			}
			return ILookAtTargetBase.CreateILookAtTargetBase(builder, _o.Type);
		}

		// Token: 0x0400E801 RID: 59393
		private Table __p;
	}
}
