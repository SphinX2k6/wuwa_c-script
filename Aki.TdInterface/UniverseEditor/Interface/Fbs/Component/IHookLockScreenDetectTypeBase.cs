using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CB RID: 21451
	public struct IHookLockScreenDetectTypeBase : IFlatbufferObject
	{
		// Token: 0x17009DD9 RID: 40409
		// (get) Token: 0x06023347 RID: 144199 RVA: 0x004E0434 File Offset: 0x004DE634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023348 RID: 144200 RVA: 0x004E0441 File Offset: 0x004DE641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023349 RID: 144201 RVA: 0x004E0448 File Offset: 0x004DE648
		public static IHookLockScreenDetectTypeBase GetRootAsIHookLockScreenDetectTypeBase(ByteBuffer _bb)
		{
			return IHookLockScreenDetectTypeBase.GetRootAsIHookLockScreenDetectTypeBase(_bb, default(IHookLockScreenDetectTypeBase));
		}

		// Token: 0x0602334A RID: 144202 RVA: 0x004E0464 File Offset: 0x004DE664
		public static IHookLockScreenDetectTypeBase GetRootAsIHookLockScreenDetectTypeBase(ByteBuffer _bb, IHookLockScreenDetectTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602334B RID: 144203 RVA: 0x004E0481 File Offset: 0x004DE681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602334C RID: 144204 RVA: 0x004E0490 File Offset: 0x004DE690
		public IHookLockScreenDetectTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DDA RID: 40410
		// (get) Token: 0x0602334D RID: 144205 RVA: 0x004E04A0 File Offset: 0x004DE6A0
		public EHookLockScreenDetectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookLockScreenDetectType.CentralEllipse;
				}
				return (EHookLockScreenDetectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602334E RID: 144206 RVA: 0x004E04DC File Offset: 0x004DE6DC
		public static Offset<IHookLockScreenDetectTypeBase> CreateIHookLockScreenDetectTypeBase(FlatBufferBuilder builder, EHookLockScreenDetectType Type = EHookLockScreenDetectType.CentralEllipse)
		{
			builder.StartTable(1);
			IHookLockScreenDetectTypeBase.AddType(builder, Type);
			return IHookLockScreenDetectTypeBase.EndIHookLockScreenDetectTypeBase(builder);
		}

		// Token: 0x0602334F RID: 144207 RVA: 0x004E04F2 File Offset: 0x004DE6F2
		public static void StartIHookLockScreenDetectTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023350 RID: 144208 RVA: 0x004E04FB File Offset: 0x004DE6FB
		public static void AddType(FlatBufferBuilder builder, EHookLockScreenDetectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023351 RID: 144209 RVA: 0x004E0506 File Offset: 0x004DE706
		public static Offset<IHookLockScreenDetectTypeBase> EndIHookLockScreenDetectTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockScreenDetectTypeBase>(builder.EndTable());
		}

		// Token: 0x06023352 RID: 144210 RVA: 0x004E0514 File Offset: 0x004DE714
		public IHookLockScreenDetectTypeBaseT UnPack()
		{
			IHookLockScreenDetectTypeBaseT hookLockScreenDetectTypeBaseT = new IHookLockScreenDetectTypeBaseT();
			this.UnPackTo(hookLockScreenDetectTypeBaseT);
			return hookLockScreenDetectTypeBaseT;
		}

		// Token: 0x06023353 RID: 144211 RVA: 0x004E052F File Offset: 0x004DE72F
		public void UnPackTo(IHookLockScreenDetectTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023354 RID: 144212 RVA: 0x004E0540 File Offset: 0x004DE740
		public static Offset<IHookLockScreenDetectTypeBase> Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockScreenDetectTypeBase>);
			}
			return IHookLockScreenDetectTypeBase.CreateIHookLockScreenDetectTypeBase(builder, _o.Type);
		}

		// Token: 0x0400E5FF RID: 58879
		private Table __p;
	}
}
