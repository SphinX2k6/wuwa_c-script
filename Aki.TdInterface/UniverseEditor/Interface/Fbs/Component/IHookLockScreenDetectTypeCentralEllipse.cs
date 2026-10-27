using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D1 RID: 21457
	public struct IHookLockScreenDetectTypeCentralEllipse : IFlatbufferObject
	{
		// Token: 0x17009DDE RID: 40414
		// (get) Token: 0x06023367 RID: 144231 RVA: 0x004E06F4 File Offset: 0x004DE8F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023368 RID: 144232 RVA: 0x004E0701 File Offset: 0x004DE901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023369 RID: 144233 RVA: 0x004E0708 File Offset: 0x004DE908
		public static IHookLockScreenDetectTypeCentralEllipse GetRootAsIHookLockScreenDetectTypeCentralEllipse(ByteBuffer _bb)
		{
			return IHookLockScreenDetectTypeCentralEllipse.GetRootAsIHookLockScreenDetectTypeCentralEllipse(_bb, default(IHookLockScreenDetectTypeCentralEllipse));
		}

		// Token: 0x0602336A RID: 144234 RVA: 0x004E0724 File Offset: 0x004DE924
		public static IHookLockScreenDetectTypeCentralEllipse GetRootAsIHookLockScreenDetectTypeCentralEllipse(ByteBuffer _bb, IHookLockScreenDetectTypeCentralEllipse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602336B RID: 144235 RVA: 0x004E0741 File Offset: 0x004DE941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602336C RID: 144236 RVA: 0x004E0750 File Offset: 0x004DE950
		public IHookLockScreenDetectTypeCentralEllipse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DDF RID: 40415
		// (get) Token: 0x0602336D RID: 144237 RVA: 0x004E0760 File Offset: 0x004DE960
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

		// Token: 0x0602336E RID: 144238 RVA: 0x004E079C File Offset: 0x004DE99C
		public static Offset<IHookLockScreenDetectTypeCentralEllipse> CreateIHookLockScreenDetectTypeCentralEllipse(FlatBufferBuilder builder, EHookLockScreenDetectType Type = EHookLockScreenDetectType.CentralEllipse)
		{
			builder.StartTable(1);
			IHookLockScreenDetectTypeCentralEllipse.AddType(builder, Type);
			return IHookLockScreenDetectTypeCentralEllipse.EndIHookLockScreenDetectTypeCentralEllipse(builder);
		}

		// Token: 0x0602336F RID: 144239 RVA: 0x004E07B2 File Offset: 0x004DE9B2
		public static void StartIHookLockScreenDetectTypeCentralEllipse(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023370 RID: 144240 RVA: 0x004E07BB File Offset: 0x004DE9BB
		public static void AddType(FlatBufferBuilder builder, EHookLockScreenDetectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023371 RID: 144241 RVA: 0x004E07C6 File Offset: 0x004DE9C6
		public static Offset<IHookLockScreenDetectTypeCentralEllipse> EndIHookLockScreenDetectTypeCentralEllipse(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockScreenDetectTypeCentralEllipse>(builder.EndTable());
		}

		// Token: 0x06023372 RID: 144242 RVA: 0x004E07D4 File Offset: 0x004DE9D4
		public IHookLockScreenDetectTypeCentralEllipseT UnPack()
		{
			IHookLockScreenDetectTypeCentralEllipseT hookLockScreenDetectTypeCentralEllipseT = new IHookLockScreenDetectTypeCentralEllipseT();
			this.UnPackTo(hookLockScreenDetectTypeCentralEllipseT);
			return hookLockScreenDetectTypeCentralEllipseT;
		}

		// Token: 0x06023373 RID: 144243 RVA: 0x004E07EF File Offset: 0x004DE9EF
		public void UnPackTo(IHookLockScreenDetectTypeCentralEllipseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023374 RID: 144244 RVA: 0x004E0800 File Offset: 0x004DEA00
		public static Offset<IHookLockScreenDetectTypeCentralEllipse> Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeCentralEllipseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockScreenDetectTypeCentralEllipse>);
			}
			return IHookLockScreenDetectTypeCentralEllipse.CreateIHookLockScreenDetectTypeCentralEllipse(builder, _o.Type);
		}

		// Token: 0x0400E608 RID: 58888
		private Table __p;
	}
}
