using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A7 RID: 18343
	public struct IAngularConstraintMotion : IFlatbufferObject
	{
		// Token: 0x17007FCA RID: 32714
		// (get) Token: 0x0601B00F RID: 110607 RVA: 0x003D3719 File Offset: 0x003D1919
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B010 RID: 110608 RVA: 0x003D3726 File Offset: 0x003D1926
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B011 RID: 110609 RVA: 0x003D3730 File Offset: 0x003D1930
		public static IAngularConstraintMotion GetRootAsIAngularConstraintMotion(ByteBuffer _bb)
		{
			return IAngularConstraintMotion.GetRootAsIAngularConstraintMotion(_bb, default(IAngularConstraintMotion));
		}

		// Token: 0x0601B012 RID: 110610 RVA: 0x003D374C File Offset: 0x003D194C
		public static IAngularConstraintMotion GetRootAsIAngularConstraintMotion(ByteBuffer _bb, IAngularConstraintMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B013 RID: 110611 RVA: 0x003D3769 File Offset: 0x003D1969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B014 RID: 110612 RVA: 0x003D3778 File Offset: 0x003D1978
		public IAngularConstraintMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FCB RID: 32715
		// (get) Token: 0x0601B015 RID: 110613 RVA: 0x003D3788 File Offset: 0x003D1988
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

		// Token: 0x0601B016 RID: 110614 RVA: 0x003D37C4 File Offset: 0x003D19C4
		public static Offset<IAngularConstraintMotion> CreateIAngularConstraintMotion(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free)
		{
			builder.StartTable(1);
			IAngularConstraintMotion.AddType(builder, Type);
			return IAngularConstraintMotion.EndIAngularConstraintMotion(builder);
		}

		// Token: 0x0601B017 RID: 110615 RVA: 0x003D37DA File Offset: 0x003D19DA
		public static void StartIAngularConstraintMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B018 RID: 110616 RVA: 0x003D37E3 File Offset: 0x003D19E3
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B019 RID: 110617 RVA: 0x003D37EE File Offset: 0x003D19EE
		public static Offset<IAngularConstraintMotion> EndIAngularConstraintMotion(FlatBufferBuilder builder)
		{
			return new Offset<IAngularConstraintMotion>(builder.EndTable());
		}

		// Token: 0x0601B01A RID: 110618 RVA: 0x003D37FC File Offset: 0x003D19FC
		public IAngularConstraintMotionT UnPack()
		{
			IAngularConstraintMotionT angularConstraintMotionT = new IAngularConstraintMotionT();
			this.UnPackTo(angularConstraintMotionT);
			return angularConstraintMotionT;
		}

		// Token: 0x0601B01B RID: 110619 RVA: 0x003D3817 File Offset: 0x003D1A17
		public void UnPackTo(IAngularConstraintMotionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B01C RID: 110620 RVA: 0x003D3828 File Offset: 0x003D1A28
		public static Offset<IAngularConstraintMotion> Pack(FlatBufferBuilder builder, IAngularConstraintMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAngularConstraintMotion>);
			}
			return IAngularConstraintMotion.CreateIAngularConstraintMotion(builder, _o.Type);
		}

		// Token: 0x0400CB3C RID: 52028
		private Table __p;
	}
}
