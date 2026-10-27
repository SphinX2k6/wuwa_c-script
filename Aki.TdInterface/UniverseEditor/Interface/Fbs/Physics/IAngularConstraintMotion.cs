using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004345 RID: 17221
	public struct IAngularConstraintMotion : IFlatbufferObject
	{
		// Token: 0x17007995 RID: 31125
		// (get) Token: 0x06019881 RID: 104577 RVA: 0x003A7CF1 File Offset: 0x003A5EF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019882 RID: 104578 RVA: 0x003A7CFE File Offset: 0x003A5EFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019883 RID: 104579 RVA: 0x003A7D08 File Offset: 0x003A5F08
		public static IAngularConstraintMotion GetRootAsIAngularConstraintMotion(ByteBuffer _bb)
		{
			return IAngularConstraintMotion.GetRootAsIAngularConstraintMotion(_bb, default(IAngularConstraintMotion));
		}

		// Token: 0x06019884 RID: 104580 RVA: 0x003A7D24 File Offset: 0x003A5F24
		public static IAngularConstraintMotion GetRootAsIAngularConstraintMotion(ByteBuffer _bb, IAngularConstraintMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019885 RID: 104581 RVA: 0x003A7D41 File Offset: 0x003A5F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019886 RID: 104582 RVA: 0x003A7D50 File Offset: 0x003A5F50
		public IAngularConstraintMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007996 RID: 31126
		// (get) Token: 0x06019887 RID: 104583 RVA: 0x003A7D60 File Offset: 0x003A5F60
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

		// Token: 0x06019888 RID: 104584 RVA: 0x003A7D9C File Offset: 0x003A5F9C
		public static Offset<IAngularConstraintMotion> CreateIAngularConstraintMotion(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free)
		{
			builder.StartTable(1);
			IAngularConstraintMotion.AddType(builder, Type);
			return IAngularConstraintMotion.EndIAngularConstraintMotion(builder);
		}

		// Token: 0x06019889 RID: 104585 RVA: 0x003A7DB2 File Offset: 0x003A5FB2
		public static void StartIAngularConstraintMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601988A RID: 104586 RVA: 0x003A7DBB File Offset: 0x003A5FBB
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601988B RID: 104587 RVA: 0x003A7DC6 File Offset: 0x003A5FC6
		public static Offset<IAngularConstraintMotion> EndIAngularConstraintMotion(FlatBufferBuilder builder)
		{
			return new Offset<IAngularConstraintMotion>(builder.EndTable());
		}

		// Token: 0x0601988C RID: 104588 RVA: 0x003A7DD4 File Offset: 0x003A5FD4
		public IAngularConstraintMotionT UnPack()
		{
			IAngularConstraintMotionT angularConstraintMotionT = new IAngularConstraintMotionT();
			this.UnPackTo(angularConstraintMotionT);
			return angularConstraintMotionT;
		}

		// Token: 0x0601988D RID: 104589 RVA: 0x003A7DEF File Offset: 0x003A5FEF
		public void UnPackTo(IAngularConstraintMotionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601988E RID: 104590 RVA: 0x003A7E00 File Offset: 0x003A6000
		public static Offset<IAngularConstraintMotion> Pack(FlatBufferBuilder builder, IAngularConstraintMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAngularConstraintMotion>);
			}
			return IAngularConstraintMotion.CreateIAngularConstraintMotion(builder, _o.Type);
		}

		// Token: 0x0400C11E RID: 49438
		private Table __p;
	}
}
