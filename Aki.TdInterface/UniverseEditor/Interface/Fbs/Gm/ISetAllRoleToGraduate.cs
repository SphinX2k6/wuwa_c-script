using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF2 RID: 19186
	public struct ISetAllRoleToGraduate : IFlatbufferObject
	{
		// Token: 0x17008674 RID: 34420
		// (get) Token: 0x0601CE78 RID: 118392 RVA: 0x00411529 File Offset: 0x0040F729
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE79 RID: 118393 RVA: 0x00411536 File Offset: 0x0040F736
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE7A RID: 118394 RVA: 0x00411540 File Offset: 0x0040F740
		public static ISetAllRoleToGraduate GetRootAsISetAllRoleToGraduate(ByteBuffer _bb)
		{
			return ISetAllRoleToGraduate.GetRootAsISetAllRoleToGraduate(_bb, default(ISetAllRoleToGraduate));
		}

		// Token: 0x0601CE7B RID: 118395 RVA: 0x0041155C File Offset: 0x0040F75C
		public static ISetAllRoleToGraduate GetRootAsISetAllRoleToGraduate(ByteBuffer _bb, ISetAllRoleToGraduate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE7C RID: 118396 RVA: 0x00411579 File Offset: 0x0040F779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE7D RID: 118397 RVA: 0x00411588 File Offset: 0x0040F788
		public ISetAllRoleToGraduate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008675 RID: 34421
		// (get) Token: 0x0601CE7E RID: 118398 RVA: 0x00411598 File Offset: 0x0040F798
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

		// Token: 0x0601CE7F RID: 118399 RVA: 0x004115D4 File Offset: 0x0040F7D4
		public static Offset<ISetAllRoleToGraduate> CreateISetAllRoleToGraduate(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			ISetAllRoleToGraduate.AddType(builder, Type);
			return ISetAllRoleToGraduate.EndISetAllRoleToGraduate(builder);
		}

		// Token: 0x0601CE80 RID: 118400 RVA: 0x004115EA File Offset: 0x0040F7EA
		public static void StartISetAllRoleToGraduate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CE81 RID: 118401 RVA: 0x004115F3 File Offset: 0x0040F7F3
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE82 RID: 118402 RVA: 0x004115FE File Offset: 0x0040F7FE
		public static Offset<ISetAllRoleToGraduate> EndISetAllRoleToGraduate(FlatBufferBuilder builder)
		{
			return new Offset<ISetAllRoleToGraduate>(builder.EndTable());
		}

		// Token: 0x0601CE83 RID: 118403 RVA: 0x0041160C File Offset: 0x0040F80C
		public ISetAllRoleToGraduateT UnPack()
		{
			ISetAllRoleToGraduateT setAllRoleToGraduateT = new ISetAllRoleToGraduateT();
			this.UnPackTo(setAllRoleToGraduateT);
			return setAllRoleToGraduateT;
		}

		// Token: 0x0601CE84 RID: 118404 RVA: 0x00411627 File Offset: 0x0040F827
		public void UnPackTo(ISetAllRoleToGraduateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CE85 RID: 118405 RVA: 0x00411638 File Offset: 0x0040F838
		public static Offset<ISetAllRoleToGraduate> Pack(FlatBufferBuilder builder, ISetAllRoleToGraduateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAllRoleToGraduate>);
			}
			return ISetAllRoleToGraduate.CreateISetAllRoleToGraduate(builder, _o.Type);
		}

		// Token: 0x0400D279 RID: 53881
		private Table __p;
	}
}
