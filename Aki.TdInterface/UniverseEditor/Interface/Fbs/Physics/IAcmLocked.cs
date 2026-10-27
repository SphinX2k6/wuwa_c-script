using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004342 RID: 17218
	public struct IAcmLocked : IFlatbufferObject
	{
		// Token: 0x17007992 RID: 31122
		// (get) Token: 0x0601986F RID: 104559 RVA: 0x003A7B7A File Offset: 0x003A5D7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019870 RID: 104560 RVA: 0x003A7B87 File Offset: 0x003A5D87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019871 RID: 104561 RVA: 0x003A7B90 File Offset: 0x003A5D90
		public static IAcmLocked GetRootAsIAcmLocked(ByteBuffer _bb)
		{
			return IAcmLocked.GetRootAsIAcmLocked(_bb, default(IAcmLocked));
		}

		// Token: 0x06019872 RID: 104562 RVA: 0x003A7BAC File Offset: 0x003A5DAC
		public static IAcmLocked GetRootAsIAcmLocked(ByteBuffer _bb, IAcmLocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019873 RID: 104563 RVA: 0x003A7BC9 File Offset: 0x003A5DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019874 RID: 104564 RVA: 0x003A7BD8 File Offset: 0x003A5DD8
		public IAcmLocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007993 RID: 31123
		// (get) Token: 0x06019875 RID: 104565 RVA: 0x003A7BE8 File Offset: 0x003A5DE8
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

		// Token: 0x06019876 RID: 104566 RVA: 0x003A7C24 File Offset: 0x003A5E24
		public static Offset<IAcmLocked> CreateIAcmLocked(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free)
		{
			builder.StartTable(1);
			IAcmLocked.AddType(builder, Type);
			return IAcmLocked.EndIAcmLocked(builder);
		}

		// Token: 0x06019877 RID: 104567 RVA: 0x003A7C3A File Offset: 0x003A5E3A
		public static void StartIAcmLocked(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019878 RID: 104568 RVA: 0x003A7C43 File Offset: 0x003A5E43
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019879 RID: 104569 RVA: 0x003A7C4E File Offset: 0x003A5E4E
		public static Offset<IAcmLocked> EndIAcmLocked(FlatBufferBuilder builder)
		{
			return new Offset<IAcmLocked>(builder.EndTable());
		}

		// Token: 0x0601987A RID: 104570 RVA: 0x003A7C5C File Offset: 0x003A5E5C
		public IAcmLockedT UnPack()
		{
			IAcmLockedT acmLockedT = new IAcmLockedT();
			this.UnPackTo(acmLockedT);
			return acmLockedT;
		}

		// Token: 0x0601987B RID: 104571 RVA: 0x003A7C77 File Offset: 0x003A5E77
		public void UnPackTo(IAcmLockedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601987C RID: 104572 RVA: 0x003A7C88 File Offset: 0x003A5E88
		public static Offset<IAcmLocked> Pack(FlatBufferBuilder builder, IAcmLockedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcmLocked>);
			}
			return IAcmLocked.CreateIAcmLocked(builder, _o.Type);
		}

		// Token: 0x0400C11C RID: 49436
		private Table __p;
	}
}
