using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007980 RID: 31104
	public struct IStandControl2 : IFlatbufferObject
	{
		// Token: 0x1700E410 RID: 58384
		// (get) Token: 0x06036C76 RID: 224374 RVA: 0x00753C81 File Offset: 0x00751E81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C77 RID: 224375 RVA: 0x00753C8E File Offset: 0x00751E8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C78 RID: 224376 RVA: 0x00753C98 File Offset: 0x00751E98
		public static IStandControl2 GetRootAsIStandControl2(ByteBuffer _bb)
		{
			return IStandControl2.GetRootAsIStandControl2(_bb, default(IStandControl2));
		}

		// Token: 0x06036C79 RID: 224377 RVA: 0x00753CB4 File Offset: 0x00751EB4
		public static IStandControl2 GetRootAsIStandControl2(ByteBuffer _bb, IStandControl2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C7A RID: 224378 RVA: 0x00753CD1 File Offset: 0x00751ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C7B RID: 224379 RVA: 0x00753CE0 File Offset: 0x00751EE0
		public IStandControl2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E411 RID: 58385
		// (get) Token: 0x06036C7C RID: 224380 RVA: 0x00753CF0 File Offset: 0x00751EF0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036C7D RID: 224381 RVA: 0x00753D2C File Offset: 0x00751F2C
		public static Offset<IStandControl2> CreateIStandControl2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IStandControl2.AddType(builder, Type);
			return IStandControl2.EndIStandControl2(builder);
		}

		// Token: 0x06036C7E RID: 224382 RVA: 0x00753D42 File Offset: 0x00751F42
		public static void StartIStandControl2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036C7F RID: 224383 RVA: 0x00753D4B File Offset: 0x00751F4B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C80 RID: 224384 RVA: 0x00753D56 File Offset: 0x00751F56
		public static Offset<IStandControl2> EndIStandControl2(FlatBufferBuilder builder)
		{
			return new Offset<IStandControl2>(builder.EndTable());
		}

		// Token: 0x06036C81 RID: 224385 RVA: 0x00753D64 File Offset: 0x00751F64
		public IStandControl2T UnPack()
		{
			IStandControl2T standControl2T = new IStandControl2T();
			this.UnPackTo(standControl2T);
			return standControl2T;
		}

		// Token: 0x06036C82 RID: 224386 RVA: 0x00753D7F File Offset: 0x00751F7F
		public void UnPackTo(IStandControl2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036C83 RID: 224387 RVA: 0x00753D90 File Offset: 0x00751F90
		public static Offset<IStandControl2> Pack(FlatBufferBuilder builder, IStandControl2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IStandControl2>);
			}
			return IStandControl2.CreateIStandControl2(builder, _o.Type);
		}

		// Token: 0x04012C74 RID: 76916
		private Table __p;
	}
}
