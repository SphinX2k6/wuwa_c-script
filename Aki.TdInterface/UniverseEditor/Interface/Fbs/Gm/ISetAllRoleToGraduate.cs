using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200468A RID: 18058
	public struct ISetAllRoleToGraduate : IFlatbufferObject
	{
		// Token: 0x17008033 RID: 32819
		// (get) Token: 0x0601B6A3 RID: 112291 RVA: 0x003E528D File Offset: 0x003E348D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6A4 RID: 112292 RVA: 0x003E529A File Offset: 0x003E349A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6A5 RID: 112293 RVA: 0x003E52A4 File Offset: 0x003E34A4
		public static ISetAllRoleToGraduate GetRootAsISetAllRoleToGraduate(ByteBuffer _bb)
		{
			return ISetAllRoleToGraduate.GetRootAsISetAllRoleToGraduate(_bb, default(ISetAllRoleToGraduate));
		}

		// Token: 0x0601B6A6 RID: 112294 RVA: 0x003E52C0 File Offset: 0x003E34C0
		public static ISetAllRoleToGraduate GetRootAsISetAllRoleToGraduate(ByteBuffer _bb, ISetAllRoleToGraduate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6A7 RID: 112295 RVA: 0x003E52DD File Offset: 0x003E34DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6A8 RID: 112296 RVA: 0x003E52EC File Offset: 0x003E34EC
		public ISetAllRoleToGraduate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008034 RID: 32820
		// (get) Token: 0x0601B6A9 RID: 112297 RVA: 0x003E52FC File Offset: 0x003E34FC
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B6AA RID: 112298 RVA: 0x003E5338 File Offset: 0x003E3538
		public static Offset<ISetAllRoleToGraduate> CreateISetAllRoleToGraduate(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			ISetAllRoleToGraduate.AddType(builder, Type);
			return ISetAllRoleToGraduate.EndISetAllRoleToGraduate(builder);
		}

		// Token: 0x0601B6AB RID: 112299 RVA: 0x003E534E File Offset: 0x003E354E
		public static void StartISetAllRoleToGraduate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B6AC RID: 112300 RVA: 0x003E5357 File Offset: 0x003E3557
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B6AD RID: 112301 RVA: 0x003E5362 File Offset: 0x003E3562
		public static Offset<ISetAllRoleToGraduate> EndISetAllRoleToGraduate(FlatBufferBuilder builder)
		{
			return new Offset<ISetAllRoleToGraduate>(builder.EndTable());
		}

		// Token: 0x0601B6AE RID: 112302 RVA: 0x003E5370 File Offset: 0x003E3570
		public ISetAllRoleToGraduateT UnPack()
		{
			ISetAllRoleToGraduateT setAllRoleToGraduateT = new ISetAllRoleToGraduateT();
			this.UnPackTo(setAllRoleToGraduateT);
			return setAllRoleToGraduateT;
		}

		// Token: 0x0601B6AF RID: 112303 RVA: 0x003E538B File Offset: 0x003E358B
		public void UnPackTo(ISetAllRoleToGraduateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B6B0 RID: 112304 RVA: 0x003E539C File Offset: 0x003E359C
		public static Offset<ISetAllRoleToGraduate> Pack(FlatBufferBuilder builder, ISetAllRoleToGraduateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAllRoleToGraduate>);
			}
			return ISetAllRoleToGraduate.CreateISetAllRoleToGraduate(builder, _o.Type);
		}

		// Token: 0x0400C84A RID: 51274
		private Table __p;
	}
}
