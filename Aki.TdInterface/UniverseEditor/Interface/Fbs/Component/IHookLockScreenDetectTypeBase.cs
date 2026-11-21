using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005951 RID: 22865
	public struct IHookLockScreenDetectTypeBase : IFlatbufferObject
	{
		// Token: 0x1700A613 RID: 42515
		// (get) Token: 0x060253FF RID: 152575 RVA: 0x0051D45E File Offset: 0x0051B65E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025400 RID: 152576 RVA: 0x0051D46B File Offset: 0x0051B66B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025401 RID: 152577 RVA: 0x0051D474 File Offset: 0x0051B674
		public static IHookLockScreenDetectTypeBase GetRootAsIHookLockScreenDetectTypeBase(ByteBuffer _bb)
		{
			return IHookLockScreenDetectTypeBase.GetRootAsIHookLockScreenDetectTypeBase(_bb, default(IHookLockScreenDetectTypeBase));
		}

		// Token: 0x06025402 RID: 152578 RVA: 0x0051D490 File Offset: 0x0051B690
		public static IHookLockScreenDetectTypeBase GetRootAsIHookLockScreenDetectTypeBase(ByteBuffer _bb, IHookLockScreenDetectTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025403 RID: 152579 RVA: 0x0051D4AD File Offset: 0x0051B6AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025404 RID: 152580 RVA: 0x0051D4BC File Offset: 0x0051B6BC
		public IHookLockScreenDetectTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A614 RID: 42516
		// (get) Token: 0x06025405 RID: 152581 RVA: 0x0051D4CC File Offset: 0x0051B6CC
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

		// Token: 0x06025406 RID: 152582 RVA: 0x0051D508 File Offset: 0x0051B708
		public static Offset<IHookLockScreenDetectTypeBase> CreateIHookLockScreenDetectTypeBase(FlatBufferBuilder builder, EHookLockScreenDetectType Type = EHookLockScreenDetectType.CentralEllipse)
		{
			builder.StartTable(1);
			IHookLockScreenDetectTypeBase.AddType(builder, Type);
			return IHookLockScreenDetectTypeBase.EndIHookLockScreenDetectTypeBase(builder);
		}

		// Token: 0x06025407 RID: 152583 RVA: 0x0051D51E File Offset: 0x0051B71E
		public static void StartIHookLockScreenDetectTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025408 RID: 152584 RVA: 0x0051D527 File Offset: 0x0051B727
		public static void AddType(FlatBufferBuilder builder, EHookLockScreenDetectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025409 RID: 152585 RVA: 0x0051D532 File Offset: 0x0051B732
		public static Offset<IHookLockScreenDetectTypeBase> EndIHookLockScreenDetectTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockScreenDetectTypeBase>(builder.EndTable());
		}

		// Token: 0x0602540A RID: 152586 RVA: 0x0051D540 File Offset: 0x0051B740
		public IHookLockScreenDetectTypeBaseT UnPack()
		{
			IHookLockScreenDetectTypeBaseT hookLockScreenDetectTypeBaseT = new IHookLockScreenDetectTypeBaseT();
			this.UnPackTo(hookLockScreenDetectTypeBaseT);
			return hookLockScreenDetectTypeBaseT;
		}

		// Token: 0x0602540B RID: 152587 RVA: 0x0051D55B File Offset: 0x0051B75B
		public void UnPackTo(IHookLockScreenDetectTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602540C RID: 152588 RVA: 0x0051D56C File Offset: 0x0051B76C
		public static Offset<IHookLockScreenDetectTypeBase> Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockScreenDetectTypeBase>);
			}
			return IHookLockScreenDetectTypeBase.CreateIHookLockScreenDetectTypeBase(builder, _o.Type);
		}

		// Token: 0x0400F230 RID: 62000
		private Table __p;
	}
}
