using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006227 RID: 25127
	public struct IBrokenRock : IFlatbufferObject
	{
		// Token: 0x1700BB3A RID: 47930
		// (get) Token: 0x0602B4F8 RID: 177400 RVA: 0x005F6DC8 File Offset: 0x005F4FC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4F9 RID: 177401 RVA: 0x005F6DD5 File Offset: 0x005F4FD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4FA RID: 177402 RVA: 0x005F6DDC File Offset: 0x005F4FDC
		public static IBrokenRock GetRootAsIBrokenRock(ByteBuffer _bb)
		{
			return IBrokenRock.GetRootAsIBrokenRock(_bb, default(IBrokenRock));
		}

		// Token: 0x0602B4FB RID: 177403 RVA: 0x005F6DF8 File Offset: 0x005F4FF8
		public static IBrokenRock GetRootAsIBrokenRock(ByteBuffer _bb, IBrokenRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4FC RID: 177404 RVA: 0x005F6E15 File Offset: 0x005F5015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4FD RID: 177405 RVA: 0x005F6E24 File Offset: 0x005F5024
		public IBrokenRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB3B RID: 47931
		// (get) Token: 0x0602B4FE RID: 177406 RVA: 0x005F6E34 File Offset: 0x005F5034
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BB3C RID: 47932
		// (get) Token: 0x0602B4FF RID: 177407 RVA: 0x005F6E70 File Offset: 0x005F5070
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B500 RID: 177408 RVA: 0x005F6EAC File Offset: 0x005F50AC
		public static Offset<IBrokenRock> CreateIBrokenRock(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			IBrokenRock.AddId(builder, Id);
			IBrokenRock.AddType(builder, Type);
			return IBrokenRock.EndIBrokenRock(builder);
		}

		// Token: 0x0602B501 RID: 177409 RVA: 0x005F6EC9 File Offset: 0x005F50C9
		public static void StartIBrokenRock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B502 RID: 177410 RVA: 0x005F6ED2 File Offset: 0x005F50D2
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B503 RID: 177411 RVA: 0x005F6EDD File Offset: 0x005F50DD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602B504 RID: 177412 RVA: 0x005F6EE8 File Offset: 0x005F50E8
		public static Offset<IBrokenRock> EndIBrokenRock(FlatBufferBuilder builder)
		{
			return new Offset<IBrokenRock>(builder.EndTable());
		}

		// Token: 0x0602B505 RID: 177413 RVA: 0x005F6EF8 File Offset: 0x005F50F8
		public IBrokenRockT UnPack()
		{
			IBrokenRockT brokenRockT = new IBrokenRockT();
			this.UnPackTo(brokenRockT);
			return brokenRockT;
		}

		// Token: 0x0602B506 RID: 177414 RVA: 0x005F6F13 File Offset: 0x005F5113
		public void UnPackTo(IBrokenRockT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602B507 RID: 177415 RVA: 0x005F6F30 File Offset: 0x005F5130
		public static Offset<IBrokenRock> Pack(FlatBufferBuilder builder, IBrokenRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrokenRock>);
			}
			return IBrokenRock.CreateIBrokenRock(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401076A RID: 67434
		private Table __p;
	}
}
