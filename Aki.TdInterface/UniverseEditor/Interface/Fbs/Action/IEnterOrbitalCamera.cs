using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C0 RID: 26304
	public struct IEnterOrbitalCamera : IFlatbufferObject
	{
		// Token: 0x1700C36C RID: 50028
		// (get) Token: 0x0602DB8E RID: 187278 RVA: 0x0064155A File Offset: 0x0063F75A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB8F RID: 187279 RVA: 0x00641567 File Offset: 0x0063F767
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB90 RID: 187280 RVA: 0x00641570 File Offset: 0x0063F770
		public static IEnterOrbitalCamera GetRootAsIEnterOrbitalCamera(ByteBuffer _bb)
		{
			return IEnterOrbitalCamera.GetRootAsIEnterOrbitalCamera(_bb, default(IEnterOrbitalCamera));
		}

		// Token: 0x0602DB91 RID: 187281 RVA: 0x0064158C File Offset: 0x0063F78C
		public static IEnterOrbitalCamera GetRootAsIEnterOrbitalCamera(ByteBuffer _bb, IEnterOrbitalCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB92 RID: 187282 RVA: 0x006415A9 File Offset: 0x0063F7A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB93 RID: 187283 RVA: 0x006415B8 File Offset: 0x0063F7B8
		public IEnterOrbitalCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C36D RID: 50029
		// (get) Token: 0x0602DB94 RID: 187284 RVA: 0x006415C8 File Offset: 0x0063F7C8
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

		// Token: 0x1700C36E RID: 50030
		// (get) Token: 0x0602DB95 RID: 187285 RVA: 0x00641628 File Offset: 0x0063F828
		public bool IsDisableControlCamera
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C36F RID: 50031
		// (get) Token: 0x0602DB96 RID: 187286 RVA: 0x00641668 File Offset: 0x0063F868
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

		// Token: 0x0602DB97 RID: 187287 RVA: 0x006416A4 File Offset: 0x0063F8A4
		public static Offset<IEnterOrbitalCamera> CreateIEnterOrbitalCamera(FlatBufferBuilder builder, Offset<IEnterOrbitalCameraControlByMove> OptionOffset = default(Offset<IEnterOrbitalCameraControlByMove>), bool IsDisableControlCamera = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEnterOrbitalCamera.AddOption(builder, OptionOffset);
			IEnterOrbitalCamera.AddNullMask(builder, NullMask);
			IEnterOrbitalCamera.AddIsDisableControlCamera(builder, IsDisableControlCamera);
			return IEnterOrbitalCamera.EndIEnterOrbitalCamera(builder);
		}

		// Token: 0x0602DB98 RID: 187288 RVA: 0x006416C8 File Offset: 0x0063F8C8
		public static void StartIEnterOrbitalCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DB99 RID: 187289 RVA: 0x006416D1 File Offset: 0x0063F8D1
		public static void AddOption(FlatBufferBuilder builder, Offset<IEnterOrbitalCameraControlByMove> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x0602DB9A RID: 187290 RVA: 0x006416E1 File Offset: 0x0063F8E1
		public static void AddIsDisableControlCamera(FlatBufferBuilder builder, bool isDisableControlCamera)
		{
			builder.AddBool(1, isDisableControlCamera, false);
		}

		// Token: 0x0602DB9B RID: 187291 RVA: 0x006416EC File Offset: 0x0063F8EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602DB9C RID: 187292 RVA: 0x006416F7 File Offset: 0x0063F8F7
		public static Offset<IEnterOrbitalCamera> EndIEnterOrbitalCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterOrbitalCamera>(builder.EndTable());
		}

		// Token: 0x0602DB9D RID: 187293 RVA: 0x00641704 File Offset: 0x0063F904
		public IEnterOrbitalCameraT UnPack()
		{
			IEnterOrbitalCameraT enterOrbitalCameraT = new IEnterOrbitalCameraT();
			this.UnPackTo(enterOrbitalCameraT);
			return enterOrbitalCameraT;
		}

		// Token: 0x0602DB9E RID: 187294 RVA: 0x00641720 File Offset: 0x0063F920
		public void UnPackTo(IEnterOrbitalCameraT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.IsDisableControlCamera = this.IsDisableControlCamera;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DB9F RID: 187295 RVA: 0x00641774 File Offset: 0x0063F974
		public static Offset<IEnterOrbitalCamera> Pack(FlatBufferBuilder builder, IEnterOrbitalCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterOrbitalCamera>);
			}
			Offset<IEnterOrbitalCameraControlByMove> optionOffset = (_o.Option == null) ? default(Offset<IEnterOrbitalCameraControlByMove>) : IEnterOrbitalCameraControlByMove.Pack(builder, _o.Option);
			return IEnterOrbitalCamera.CreateIEnterOrbitalCamera(builder, optionOffset, _o.IsDisableControlCamera, _o.NullMask);
		}

		// Token: 0x04010D84 RID: 68996
		private Table __p;
	}
}
