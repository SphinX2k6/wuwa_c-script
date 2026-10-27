using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200666C RID: 26220
	public struct IEnableKey4Func : IFlatbufferObject
	{
		// Token: 0x1700C2C7 RID: 49863
		// (get) Token: 0x0602D8C9 RID: 186569 RVA: 0x0063C87B File Offset: 0x0063AA7B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D8CA RID: 186570 RVA: 0x0063C888 File Offset: 0x0063AA88
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D8CB RID: 186571 RVA: 0x0063C890 File Offset: 0x0063AA90
		public static IEnableKey4Func GetRootAsIEnableKey4Func(ByteBuffer _bb)
		{
			return IEnableKey4Func.GetRootAsIEnableKey4Func(_bb, default(IEnableKey4Func));
		}

		// Token: 0x0602D8CC RID: 186572 RVA: 0x0063C8AC File Offset: 0x0063AAAC
		public static IEnableKey4Func GetRootAsIEnableKey4Func(ByteBuffer _bb, IEnableKey4Func obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D8CD RID: 186573 RVA: 0x0063C8C9 File Offset: 0x0063AAC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D8CE RID: 186574 RVA: 0x0063C8D8 File Offset: 0x0063AAD8
		public IEnableKey4Func __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2C8 RID: 49864
		// (get) Token: 0x0602D8CF RID: 186575 RVA: 0x0063C8E8 File Offset: 0x0063AAE8
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2C9 RID: 49865
		// (get) Token: 0x0602D8D0 RID: 186576 RVA: 0x0063C928 File Offset: 0x0063AB28
		public EEnableKey4FuncKey FuncKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEnableKey4FuncKey.TimeScaled;
				}
				return (EEnableKey4FuncKey)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D8D1 RID: 186577 RVA: 0x0063C964 File Offset: 0x0063AB64
		public static Offset<IEnableKey4Func> CreateIEnableKey4Func(FlatBufferBuilder builder, bool IsEnable = false, EEnableKey4FuncKey FuncKey = EEnableKey4FuncKey.TimeScaled)
		{
			builder.StartTable(2);
			IEnableKey4Func.AddFuncKey(builder, FuncKey);
			IEnableKey4Func.AddIsEnable(builder, IsEnable);
			return IEnableKey4Func.EndIEnableKey4Func(builder);
		}

		// Token: 0x0602D8D2 RID: 186578 RVA: 0x0063C981 File Offset: 0x0063AB81
		public static void StartIEnableKey4Func(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D8D3 RID: 186579 RVA: 0x0063C98A File Offset: 0x0063AB8A
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0602D8D4 RID: 186580 RVA: 0x0063C995 File Offset: 0x0063AB95
		public static void AddFuncKey(FlatBufferBuilder builder, EEnableKey4FuncKey funcKey)
		{
			builder.AddByte(1, (byte)funcKey, 0);
		}

		// Token: 0x0602D8D5 RID: 186581 RVA: 0x0063C9A0 File Offset: 0x0063ABA0
		public static Offset<IEnableKey4Func> EndIEnableKey4Func(FlatBufferBuilder builder)
		{
			return new Offset<IEnableKey4Func>(builder.EndTable());
		}

		// Token: 0x0602D8D6 RID: 186582 RVA: 0x0063C9B0 File Offset: 0x0063ABB0
		public IEnableKey4FuncT UnPack()
		{
			IEnableKey4FuncT enableKey4FuncT = new IEnableKey4FuncT();
			this.UnPackTo(enableKey4FuncT);
			return enableKey4FuncT;
		}

		// Token: 0x0602D8D7 RID: 186583 RVA: 0x0063C9CB File Offset: 0x0063ABCB
		public void UnPackTo(IEnableKey4FuncT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.FuncKey = this.FuncKey;
		}

		// Token: 0x0602D8D8 RID: 186584 RVA: 0x0063C9E8 File Offset: 0x0063ABE8
		public static Offset<IEnableKey4Func> Pack(FlatBufferBuilder builder, IEnableKey4FuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableKey4Func>);
			}
			return IEnableKey4Func.CreateIEnableKey4Func(builder, _o.IsEnable, _o.FuncKey);
		}

		// Token: 0x04010D13 RID: 68883
		private Table __p;
	}
}
