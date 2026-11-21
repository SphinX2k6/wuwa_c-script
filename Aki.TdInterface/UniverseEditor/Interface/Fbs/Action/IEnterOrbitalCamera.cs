using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3A RID: 27962
	public struct IEnterOrbitalCamera : IFlatbufferObject
	{
		// Token: 0x1700CD1D RID: 52509
		// (get) Token: 0x060303AB RID: 197547 RVA: 0x0068E80E File Offset: 0x0068CA0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060303AC RID: 197548 RVA: 0x0068E81B File Offset: 0x0068CA1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060303AD RID: 197549 RVA: 0x0068E824 File Offset: 0x0068CA24
		public static IEnterOrbitalCamera GetRootAsIEnterOrbitalCamera(ByteBuffer _bb)
		{
			return IEnterOrbitalCamera.GetRootAsIEnterOrbitalCamera(_bb, default(IEnterOrbitalCamera));
		}

		// Token: 0x060303AE RID: 197550 RVA: 0x0068E840 File Offset: 0x0068CA40
		public static IEnterOrbitalCamera GetRootAsIEnterOrbitalCamera(ByteBuffer _bb, IEnterOrbitalCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060303AF RID: 197551 RVA: 0x0068E85D File Offset: 0x0068CA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060303B0 RID: 197552 RVA: 0x0068E86C File Offset: 0x0068CA6C
		public IEnterOrbitalCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD1E RID: 52510
		// (get) Token: 0x060303B1 RID: 197553 RVA: 0x0068E87C File Offset: 0x0068CA7C
		public IEnterOrbitalCameraControlByMove? Option
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEnterOrbitalCameraControlByMove?(default(IEnterOrbitalCameraControlByMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CD1F RID: 52511
		// (get) Token: 0x060303B2 RID: 197554 RVA: 0x0068E8DC File Offset: 0x0068CADC
		public bool IsDisableControlCamera
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD20 RID: 52512
		// (get) Token: 0x060303B3 RID: 197555 RVA: 0x0068E91C File Offset: 0x0068CB1C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060303B4 RID: 197556 RVA: 0x0068E958 File Offset: 0x0068CB58
		public static Offset<IEnterOrbitalCamera> CreateIEnterOrbitalCamera(FlatBufferBuilder builder, Offset<IEnterOrbitalCameraControlByMove> OptionOffset = default(Offset<IEnterOrbitalCameraControlByMove>), bool IsDisableControlCamera = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEnterOrbitalCamera.AddOption(builder, OptionOffset);
			IEnterOrbitalCamera.AddNullMask(builder, NullMask);
			IEnterOrbitalCamera.AddIsDisableControlCamera(builder, IsDisableControlCamera);
			return IEnterOrbitalCamera.EndIEnterOrbitalCamera(builder);
		}

		// Token: 0x060303B5 RID: 197557 RVA: 0x0068E97C File Offset: 0x0068CB7C
		public static void StartIEnterOrbitalCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060303B6 RID: 197558 RVA: 0x0068E985 File Offset: 0x0068CB85
		public static void AddOption(FlatBufferBuilder builder, Offset<IEnterOrbitalCameraControlByMove> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x060303B7 RID: 197559 RVA: 0x0068E995 File Offset: 0x0068CB95
		public static void AddIsDisableControlCamera(FlatBufferBuilder builder, bool isDisableControlCamera)
		{
			builder.AddBool(1, isDisableControlCamera, false);
		}

		// Token: 0x060303B8 RID: 197560 RVA: 0x0068E9A0 File Offset: 0x0068CBA0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060303B9 RID: 197561 RVA: 0x0068E9AB File Offset: 0x0068CBAB
		public static Offset<IEnterOrbitalCamera> EndIEnterOrbitalCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterOrbitalCamera>(builder.EndTable());
		}

		// Token: 0x060303BA RID: 197562 RVA: 0x0068E9B8 File Offset: 0x0068CBB8
		public IEnterOrbitalCameraT UnPack()
		{
			IEnterOrbitalCameraT enterOrbitalCameraT = new IEnterOrbitalCameraT();
			this.UnPackTo(enterOrbitalCameraT);
			return enterOrbitalCameraT;
		}

		// Token: 0x060303BB RID: 197563 RVA: 0x0068E9D4 File Offset: 0x0068CBD4
		public void UnPackTo(IEnterOrbitalCameraT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.IsDisableControlCamera = this.IsDisableControlCamera;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060303BC RID: 197564 RVA: 0x0068EA28 File Offset: 0x0068CC28
		public static Offset<IEnterOrbitalCamera> Pack(FlatBufferBuilder builder, IEnterOrbitalCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterOrbitalCamera>);
			}
			Offset<IEnterOrbitalCameraControlByMove> optionOffset = (_o.Option == null) ? default(Offset<IEnterOrbitalCameraControlByMove>) : IEnterOrbitalCameraControlByMove.Pack(builder, _o.Option);
			return IEnterOrbitalCamera.CreateIEnterOrbitalCamera(builder, optionOffset, _o.IsDisableControlCamera, _o.NullMask);
		}

		// Token: 0x04011BAA RID: 72618
		private Table __p;
	}
}
