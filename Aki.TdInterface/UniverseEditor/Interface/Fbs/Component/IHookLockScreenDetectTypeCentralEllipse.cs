using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005957 RID: 22871
	public struct IHookLockScreenDetectTypeCentralEllipse : IFlatbufferObject
	{
		// Token: 0x1700A618 RID: 42520
		// (get) Token: 0x0602541F RID: 152607 RVA: 0x0051D720 File Offset: 0x0051B920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025420 RID: 152608 RVA: 0x0051D72D File Offset: 0x0051B92D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025421 RID: 152609 RVA: 0x0051D734 File Offset: 0x0051B934
		public static IHookLockScreenDetectTypeCentralEllipse GetRootAsIHookLockScreenDetectTypeCentralEllipse(ByteBuffer _bb)
		{
			return IHookLockScreenDetectTypeCentralEllipse.GetRootAsIHookLockScreenDetectTypeCentralEllipse(_bb, default(IHookLockScreenDetectTypeCentralEllipse));
		}

		// Token: 0x06025422 RID: 152610 RVA: 0x0051D750 File Offset: 0x0051B950
		public static IHookLockScreenDetectTypeCentralEllipse GetRootAsIHookLockScreenDetectTypeCentralEllipse(ByteBuffer _bb, IHookLockScreenDetectTypeCentralEllipse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025423 RID: 152611 RVA: 0x0051D76D File Offset: 0x0051B96D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025424 RID: 152612 RVA: 0x0051D77C File Offset: 0x0051B97C
		public IHookLockScreenDetectTypeCentralEllipse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A619 RID: 42521
		// (get) Token: 0x06025425 RID: 152613 RVA: 0x0051D78C File Offset: 0x0051B98C
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

		// Token: 0x06025426 RID: 152614 RVA: 0x0051D7C8 File Offset: 0x0051B9C8
		public static Offset<IHookLockScreenDetectTypeCentralEllipse> CreateIHookLockScreenDetectTypeCentralEllipse(FlatBufferBuilder builder, EHookLockScreenDetectType Type = EHookLockScreenDetectType.CentralEllipse)
		{
			builder.StartTable(1);
			IHookLockScreenDetectTypeCentralEllipse.AddType(builder, Type);
			return IHookLockScreenDetectTypeCentralEllipse.EndIHookLockScreenDetectTypeCentralEllipse(builder);
		}

		// Token: 0x06025427 RID: 152615 RVA: 0x0051D7DE File Offset: 0x0051B9DE
		public static void StartIHookLockScreenDetectTypeCentralEllipse(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025428 RID: 152616 RVA: 0x0051D7E7 File Offset: 0x0051B9E7
		public static void AddType(FlatBufferBuilder builder, EHookLockScreenDetectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025429 RID: 152617 RVA: 0x0051D7F2 File Offset: 0x0051B9F2
		public static Offset<IHookLockScreenDetectTypeCentralEllipse> EndIHookLockScreenDetectTypeCentralEllipse(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockScreenDetectTypeCentralEllipse>(builder.EndTable());
		}

		// Token: 0x0602542A RID: 152618 RVA: 0x0051D800 File Offset: 0x0051BA00
		public IHookLockScreenDetectTypeCentralEllipseT UnPack()
		{
			IHookLockScreenDetectTypeCentralEllipseT hookLockScreenDetectTypeCentralEllipseT = new IHookLockScreenDetectTypeCentralEllipseT();
			this.UnPackTo(hookLockScreenDetectTypeCentralEllipseT);
			return hookLockScreenDetectTypeCentralEllipseT;
		}

		// Token: 0x0602542B RID: 152619 RVA: 0x0051D81B File Offset: 0x0051BA1B
		public void UnPackTo(IHookLockScreenDetectTypeCentralEllipseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602542C RID: 152620 RVA: 0x0051D82C File Offset: 0x0051BA2C
		public static Offset<IHookLockScreenDetectTypeCentralEllipse> Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeCentralEllipseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockScreenDetectTypeCentralEllipse>);
			}
			return IHookLockScreenDetectTypeCentralEllipse.CreateIHookLockScreenDetectTypeCentralEllipse(builder, _o.Type);
		}

		// Token: 0x0400F239 RID: 62009
		private Table __p;
	}
}
