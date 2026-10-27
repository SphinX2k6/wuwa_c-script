using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006795 RID: 26517
	public struct IFadeOutScreen : IFlatbufferObject
	{
		// Token: 0x1700C4D7 RID: 50391
		// (get) Token: 0x0602E23C RID: 188988 RVA: 0x0064D668 File Offset: 0x0064B868
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E23D RID: 188989 RVA: 0x0064D675 File Offset: 0x0064B875
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E23E RID: 188990 RVA: 0x0064D67C File Offset: 0x0064B87C
		public static IFadeOutScreen GetRootAsIFadeOutScreen(ByteBuffer _bb)
		{
			return IFadeOutScreen.GetRootAsIFadeOutScreen(_bb, default(IFadeOutScreen));
		}

		// Token: 0x0602E23F RID: 188991 RVA: 0x0064D698 File Offset: 0x0064B898
		public static IFadeOutScreen GetRootAsIFadeOutScreen(ByteBuffer _bb, IFadeOutScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E240 RID: 188992 RVA: 0x0064D6B5 File Offset: 0x0064B8B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E241 RID: 188993 RVA: 0x0064D6C4 File Offset: 0x0064B8C4
		public IFadeOutScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4D8 RID: 50392
		// (get) Token: 0x0602E242 RID: 188994 RVA: 0x0064D6D4 File Offset: 0x0064B8D4
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

		// Token: 0x1700C4D9 RID: 50393
		// (get) Token: 0x0602E243 RID: 188995 RVA: 0x0064D734 File Offset: 0x0064B934
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C4DA RID: 50394
		// (get) Token: 0x0602E244 RID: 188996 RVA: 0x0064D774 File Offset: 0x0064B974
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

		// Token: 0x0602E245 RID: 188997 RVA: 0x0064D7B0 File Offset: 0x0064B9B0
		public static Offset<IFadeOutScreen> CreateIFadeOutScreen(FlatBufferBuilder builder, Offset<IEaseData> EaseOffset = default(Offset<IEaseData>), bool OnlyLowMemoryDeviceExecute = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFadeOutScreen.AddEase(builder, EaseOffset);
			IFadeOutScreen.AddNullMask(builder, NullMask);
			IFadeOutScreen.AddOnlyLowMemoryDeviceExecute(builder, OnlyLowMemoryDeviceExecute);
			return IFadeOutScreen.EndIFadeOutScreen(builder);
		}

		// Token: 0x0602E246 RID: 188998 RVA: 0x0064D7D4 File Offset: 0x0064B9D4
		public static void StartIFadeOutScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E247 RID: 188999 RVA: 0x0064D7DD File Offset: 0x0064B9DD
		public static void AddEase(FlatBufferBuilder builder, Offset<IEaseData> easeOffset)
		{
			builder.AddOffset(0, easeOffset.Value, 0);
		}

		// Token: 0x0602E248 RID: 189000 RVA: 0x0064D7ED File Offset: 0x0064B9ED
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(1, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x0602E249 RID: 189001 RVA: 0x0064D7F8 File Offset: 0x0064B9F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602E24A RID: 189002 RVA: 0x0064D803 File Offset: 0x0064BA03
		public static Offset<IFadeOutScreen> EndIFadeOutScreen(FlatBufferBuilder builder)
		{
			return new Offset<IFadeOutScreen>(builder.EndTable());
		}

		// Token: 0x0602E24B RID: 189003 RVA: 0x0064D810 File Offset: 0x0064BA10
		public IFadeOutScreenT UnPack()
		{
			IFadeOutScreenT fadeOutScreenT = new IFadeOutScreenT();
			this.UnPackTo(fadeOutScreenT);
			return fadeOutScreenT;
		}

		// Token: 0x0602E24C RID: 189004 RVA: 0x0064D82C File Offset: 0x0064BA2C
		public void UnPackTo(IFadeOutScreenT _o)
		{
			_o.Ease = ((this.Ease != null) ? this.Ease.Value.UnPack() : null);
			_o.OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E24D RID: 189005 RVA: 0x0064D880 File Offset: 0x0064BA80
		public static Offset<IFadeOutScreen> Pack(FlatBufferBuilder builder, IFadeOutScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeOutScreen>);
			}
			Offset<IEaseData> easeOffset = (_o.Ease == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.Ease);
			return IFadeOutScreen.CreateIFadeOutScreen(builder, easeOffset, _o.OnlyLowMemoryDeviceExecute, _o.NullMask);
		}

		// Token: 0x04010EA3 RID: 69283
		private Table __p;
	}
}
