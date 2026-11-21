using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F53 RID: 28499
	public struct IGuestOperateUiAnimationType : IFlatbufferObject
	{
		// Token: 0x1700D0D7 RID: 53463
		// (get) Token: 0x06031532 RID: 202034 RVA: 0x006AE4F5 File Offset: 0x006AC6F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031533 RID: 202035 RVA: 0x006AE502 File Offset: 0x006AC702
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031534 RID: 202036 RVA: 0x006AE50C File Offset: 0x006AC70C
		public static IGuestOperateUiAnimationType GetRootAsIGuestOperateUiAnimationType(ByteBuffer _bb)
		{
			return IGuestOperateUiAnimationType.GetRootAsIGuestOperateUiAnimationType(_bb, default(IGuestOperateUiAnimationType));
		}

		// Token: 0x06031535 RID: 202037 RVA: 0x006AE528 File Offset: 0x006AC728
		public static IGuestOperateUiAnimationType GetRootAsIGuestOperateUiAnimationType(ByteBuffer _bb, IGuestOperateUiAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031536 RID: 202038 RVA: 0x006AE545 File Offset: 0x006AC745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031537 RID: 202039 RVA: 0x006AE554 File Offset: 0x006AC754
		public IGuestOperateUiAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0D8 RID: 53464
		// (get) Token: 0x06031538 RID: 202040 RVA: 0x006AE564 File Offset: 0x006AC764
		public EGuestOperateUiAnimation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuestOperateUiAnimation.Play;
				}
				return (EGuestOperateUiAnimation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031539 RID: 202041 RVA: 0x006AE5A0 File Offset: 0x006AC7A0
		public static Offset<IGuestOperateUiAnimationType> CreateIGuestOperateUiAnimationType(FlatBufferBuilder builder, EGuestOperateUiAnimation Type = EGuestOperateUiAnimation.Play)
		{
			builder.StartTable(1);
			IGuestOperateUiAnimationType.AddType(builder, Type);
			return IGuestOperateUiAnimationType.EndIGuestOperateUiAnimationType(builder);
		}

		// Token: 0x0603153A RID: 202042 RVA: 0x006AE5B6 File Offset: 0x006AC7B6
		public static void StartIGuestOperateUiAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603153B RID: 202043 RVA: 0x006AE5BF File Offset: 0x006AC7BF
		public static void AddType(FlatBufferBuilder builder, EGuestOperateUiAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603153C RID: 202044 RVA: 0x006AE5CA File Offset: 0x006AC7CA
		public static Offset<IGuestOperateUiAnimationType> EndIGuestOperateUiAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<IGuestOperateUiAnimationType>(builder.EndTable());
		}

		// Token: 0x0603153D RID: 202045 RVA: 0x006AE5D8 File Offset: 0x006AC7D8
		public IGuestOperateUiAnimationTypeT UnPack()
		{
			IGuestOperateUiAnimationTypeT guestOperateUiAnimationTypeT = new IGuestOperateUiAnimationTypeT();
			this.UnPackTo(guestOperateUiAnimationTypeT);
			return guestOperateUiAnimationTypeT;
		}

		// Token: 0x0603153E RID: 202046 RVA: 0x006AE5F3 File Offset: 0x006AC7F3
		public void UnPackTo(IGuestOperateUiAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603153F RID: 202047 RVA: 0x006AE604 File Offset: 0x006AC804
		public static Offset<IGuestOperateUiAnimationType> Pack(FlatBufferBuilder builder, IGuestOperateUiAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuestOperateUiAnimationType>);
			}
			return IGuestOperateUiAnimationType.CreateIGuestOperateUiAnimationType(builder, _o.Type);
		}

		// Token: 0x04011E5A RID: 73306
		private Table __p;
	}
}
