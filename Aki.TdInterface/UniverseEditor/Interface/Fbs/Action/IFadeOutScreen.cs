using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E15 RID: 28181
	public struct IFadeOutScreen : IFlatbufferObject
	{
		// Token: 0x1700CE8D RID: 52877
		// (get) Token: 0x06030A82 RID: 199298 RVA: 0x0069ADAC File Offset: 0x00698FAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A83 RID: 199299 RVA: 0x0069ADB9 File Offset: 0x00698FB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A84 RID: 199300 RVA: 0x0069ADC0 File Offset: 0x00698FC0
		public static IFadeOutScreen GetRootAsIFadeOutScreen(ByteBuffer _bb)
		{
			return IFadeOutScreen.GetRootAsIFadeOutScreen(_bb, default(IFadeOutScreen));
		}

		// Token: 0x06030A85 RID: 199301 RVA: 0x0069ADDC File Offset: 0x00698FDC
		public static IFadeOutScreen GetRootAsIFadeOutScreen(ByteBuffer _bb, IFadeOutScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A86 RID: 199302 RVA: 0x0069ADF9 File Offset: 0x00698FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A87 RID: 199303 RVA: 0x0069AE08 File Offset: 0x00699008
		public IFadeOutScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE8E RID: 52878
		// (get) Token: 0x06030A88 RID: 199304 RVA: 0x0069AE18 File Offset: 0x00699018
		public IEaseData? Ease
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEaseData?(default(IEaseData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CE8F RID: 52879
		// (get) Token: 0x06030A89 RID: 199305 RVA: 0x0069AE78 File Offset: 0x00699078
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE90 RID: 52880
		// (get) Token: 0x06030A8A RID: 199306 RVA: 0x0069AEB8 File Offset: 0x006990B8
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

		// Token: 0x06030A8B RID: 199307 RVA: 0x0069AEF4 File Offset: 0x006990F4
		public static Offset<IFadeOutScreen> CreateIFadeOutScreen(FlatBufferBuilder builder, Offset<IEaseData> EaseOffset = default(Offset<IEaseData>), bool OnlyLowMemoryDeviceExecute = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFadeOutScreen.AddEase(builder, EaseOffset);
			IFadeOutScreen.AddNullMask(builder, NullMask);
			IFadeOutScreen.AddOnlyLowMemoryDeviceExecute(builder, OnlyLowMemoryDeviceExecute);
			return IFadeOutScreen.EndIFadeOutScreen(builder);
		}

		// Token: 0x06030A8C RID: 199308 RVA: 0x0069AF18 File Offset: 0x00699118
		public static void StartIFadeOutScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030A8D RID: 199309 RVA: 0x0069AF21 File Offset: 0x00699121
		public static void AddEase(FlatBufferBuilder builder, Offset<IEaseData> easeOffset)
		{
			builder.AddOffset(0, easeOffset.Value, 0);
		}

		// Token: 0x06030A8E RID: 199310 RVA: 0x0069AF31 File Offset: 0x00699131
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(1, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x06030A8F RID: 199311 RVA: 0x0069AF3C File Offset: 0x0069913C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06030A90 RID: 199312 RVA: 0x0069AF47 File Offset: 0x00699147
		public static Offset<IFadeOutScreen> EndIFadeOutScreen(FlatBufferBuilder builder)
		{
			return new Offset<IFadeOutScreen>(builder.EndTable());
		}

		// Token: 0x06030A91 RID: 199313 RVA: 0x0069AF54 File Offset: 0x00699154
		public IFadeOutScreenT UnPack()
		{
			IFadeOutScreenT fadeOutScreenT = new IFadeOutScreenT();
			this.UnPackTo(fadeOutScreenT);
			return fadeOutScreenT;
		}

		// Token: 0x06030A92 RID: 199314 RVA: 0x0069AF70 File Offset: 0x00699170
		public void UnPackTo(IFadeOutScreenT _o)
		{
			_o.Ease = ((this.Ease != null) ? this.Ease.Value.UnPack() : null);
			_o.OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030A93 RID: 199315 RVA: 0x0069AFC4 File Offset: 0x006991C4
		public static Offset<IFadeOutScreen> Pack(FlatBufferBuilder builder, IFadeOutScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeOutScreen>);
			}
			Offset<IEaseData> easeOffset = (_o.Ease == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.Ease);
			return IFadeOutScreen.CreateIFadeOutScreen(builder, easeOffset, _o.OnlyLowMemoryDeviceExecute, _o.NullMask);
		}

		// Token: 0x04011CD5 RID: 72917
		private Table __p;
	}
}
