using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200433C RID: 17212
	public struct IAcmFree : IFlatbufferObject
	{
		// Token: 0x1700798A RID: 31114
		// (get) Token: 0x06019847 RID: 104519 RVA: 0x003A7802 File Offset: 0x003A5A02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019848 RID: 104520 RVA: 0x003A780F File Offset: 0x003A5A0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019849 RID: 104521 RVA: 0x003A7818 File Offset: 0x003A5A18
		public static IAcmFree GetRootAsIAcmFree(ByteBuffer _bb)
		{
			return IAcmFree.GetRootAsIAcmFree(_bb, default(IAcmFree));
		}

		// Token: 0x0601984A RID: 104522 RVA: 0x003A7834 File Offset: 0x003A5A34
		public static IAcmFree GetRootAsIAcmFree(ByteBuffer _bb, IAcmFree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601984B RID: 104523 RVA: 0x003A7851 File Offset: 0x003A5A51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601984C RID: 104524 RVA: 0x003A7860 File Offset: 0x003A5A60
		public IAcmFree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700798B RID: 31115
		// (get) Token: 0x0601984D RID: 104525 RVA: 0x003A7870 File Offset: 0x003A5A70
		public EAngularConstraintMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAngularConstraintMotion.ACM_Free;
				}
				return (EAngularConstraintMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601984E RID: 104526 RVA: 0x003A78AC File Offset: 0x003A5AAC
		public static Offset<IAcmFree> CreateIAcmFree(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free)
		{
			builder.StartTable(1);
			IAcmFree.AddType(builder, Type);
			return IAcmFree.EndIAcmFree(builder);
		}

		// Token: 0x0601984F RID: 104527 RVA: 0x003A78C2 File Offset: 0x003A5AC2
		public static void StartIAcmFree(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019850 RID: 104528 RVA: 0x003A78CB File Offset: 0x003A5ACB
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019851 RID: 104529 RVA: 0x003A78D6 File Offset: 0x003A5AD6
		public static Offset<IAcmFree> EndIAcmFree(FlatBufferBuilder builder)
		{
			return new Offset<IAcmFree>(builder.EndTable());
		}

		// Token: 0x06019852 RID: 104530 RVA: 0x003A78E4 File Offset: 0x003A5AE4
		public IAcmFreeT UnPack()
		{
			IAcmFreeT acmFreeT = new IAcmFreeT();
			this.UnPackTo(acmFreeT);
			return acmFreeT;
		}

		// Token: 0x06019853 RID: 104531 RVA: 0x003A78FF File Offset: 0x003A5AFF
		public void UnPackTo(IAcmFreeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019854 RID: 104532 RVA: 0x003A7910 File Offset: 0x003A5B10
		public static Offset<IAcmFree> Pack(FlatBufferBuilder builder, IAcmFreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcmFree>);
			}
			return IAcmFree.CreateIAcmFree(builder, _o.Type);
		}

		// Token: 0x0400C117 RID: 49431
		private Table __p;
	}
}
