using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF2 RID: 27890
	public struct IEnableRideFlyingCarUiGameplay : IFlatbufferObject
	{
		// Token: 0x1700CC88 RID: 52360
		// (get) Token: 0x06030140 RID: 196928 RVA: 0x0068A54A File Offset: 0x0068874A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030141 RID: 196929 RVA: 0x0068A557 File Offset: 0x00688757
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030142 RID: 196930 RVA: 0x0068A560 File Offset: 0x00688760
		public static IEnableRideFlyingCarUiGameplay GetRootAsIEnableRideFlyingCarUiGameplay(ByteBuffer _bb)
		{
			return IEnableRideFlyingCarUiGameplay.GetRootAsIEnableRideFlyingCarUiGameplay(_bb, default(IEnableRideFlyingCarUiGameplay));
		}

		// Token: 0x06030143 RID: 196931 RVA: 0x0068A57C File Offset: 0x0068877C
		public static IEnableRideFlyingCarUiGameplay GetRootAsIEnableRideFlyingCarUiGameplay(ByteBuffer _bb, IEnableRideFlyingCarUiGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030144 RID: 196932 RVA: 0x0068A599 File Offset: 0x00688799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030145 RID: 196933 RVA: 0x0068A5A8 File Offset: 0x006887A8
		public IEnableRideFlyingCarUiGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC89 RID: 52361
		// (get) Token: 0x06030146 RID: 196934 RVA: 0x0068A5B8 File Offset: 0x006887B8
		public EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleRideFlyingCarUiGameplayType.Enable;
				}
				return (EToggleRideFlyingCarUiGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC8A RID: 52362
		// (get) Token: 0x06030147 RID: 196935 RVA: 0x0068A5F4 File Offset: 0x006887F4
		public int FirstPersonCameraTag
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

		// Token: 0x1700CC8B RID: 52363
		// (get) Token: 0x06030148 RID: 196936 RVA: 0x0068A630 File Offset: 0x00688830
		public int ThirdPersonCameraTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC8C RID: 52364
		// (get) Token: 0x06030149 RID: 196937 RVA: 0x0068A66C File Offset: 0x0068886C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603014A RID: 196938 RVA: 0x0068A6A9 File Offset: 0x006888A9
		public static Offset<IEnableRideFlyingCarUiGameplay> CreateIEnableRideFlyingCarUiGameplay(FlatBufferBuilder builder, EToggleRideFlyingCarUiGameplayType Type = EToggleRideFlyingCarUiGameplayType.Enable, int FirstPersonCameraTag = 0, int ThirdPersonCameraTag = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnableRideFlyingCarUiGameplay.AddThirdPersonCameraTag(builder, ThirdPersonCameraTag);
			IEnableRideFlyingCarUiGameplay.AddFirstPersonCameraTag(builder, FirstPersonCameraTag);
			IEnableRideFlyingCarUiGameplay.AddNullMask(builder, NullMask);
			IEnableRideFlyingCarUiGameplay.AddType(builder, Type);
			return IEnableRideFlyingCarUiGameplay.EndIEnableRideFlyingCarUiGameplay(builder);
		}

		// Token: 0x0603014B RID: 196939 RVA: 0x0068A6D5 File Offset: 0x006888D5
		public static void StartIEnableRideFlyingCarUiGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603014C RID: 196940 RVA: 0x0068A6DE File Offset: 0x006888DE
		public static void AddType(FlatBufferBuilder builder, EToggleRideFlyingCarUiGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603014D RID: 196941 RVA: 0x0068A6E9 File Offset: 0x006888E9
		public static void AddFirstPersonCameraTag(FlatBufferBuilder builder, int firstPersonCameraTag)
		{
			builder.AddInt(1, firstPersonCameraTag, 0);
		}

		// Token: 0x0603014E RID: 196942 RVA: 0x0068A6F4 File Offset: 0x006888F4
		public static void AddThirdPersonCameraTag(FlatBufferBuilder builder, int thirdPersonCameraTag)
		{
			builder.AddInt(2, thirdPersonCameraTag, 0);
		}

		// Token: 0x0603014F RID: 196943 RVA: 0x0068A6FF File Offset: 0x006888FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030150 RID: 196944 RVA: 0x0068A70A File Offset: 0x0068890A
		public static Offset<IEnableRideFlyingCarUiGameplay> EndIEnableRideFlyingCarUiGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IEnableRideFlyingCarUiGameplay>(builder.EndTable());
		}

		// Token: 0x06030151 RID: 196945 RVA: 0x0068A718 File Offset: 0x00688918
		public IEnableRideFlyingCarUiGameplayT UnPack()
		{
			IEnableRideFlyingCarUiGameplayT enableRideFlyingCarUiGameplayT = new IEnableRideFlyingCarUiGameplayT();
			this.UnPackTo(enableRideFlyingCarUiGameplayT);
			return enableRideFlyingCarUiGameplayT;
		}

		// Token: 0x06030152 RID: 196946 RVA: 0x0068A733 File Offset: 0x00688933
		public void UnPackTo(IEnableRideFlyingCarUiGameplayT _o)
		{
			_o.Type = this.Type;
			_o.FirstPersonCameraTag = this.FirstPersonCameraTag;
			_o.ThirdPersonCameraTag = this.ThirdPersonCameraTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030153 RID: 196947 RVA: 0x0068A768 File Offset: 0x00688968
		public static Offset<IEnableRideFlyingCarUiGameplay> Pack(FlatBufferBuilder builder, IEnableRideFlyingCarUiGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableRideFlyingCarUiGameplay>);
			}
			return IEnableRideFlyingCarUiGameplay.CreateIEnableRideFlyingCarUiGameplay(builder, _o.Type, _o.FirstPersonCameraTag, _o.ThirdPersonCameraTag, _o.NullMask);
		}

		// Token: 0x04011B43 RID: 72515
		private Table __p;
	}
}
