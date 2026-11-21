using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595A RID: 22874
	public struct IHookLockScreenDetectTypeFullScreen : IFlatbufferObject
	{
		// Token: 0x1700A61B RID: 42523
		// (get) Token: 0x06025431 RID: 152625 RVA: 0x0051D895 File Offset: 0x0051BA95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025432 RID: 152626 RVA: 0x0051D8A2 File Offset: 0x0051BAA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025433 RID: 152627 RVA: 0x0051D8AC File Offset: 0x0051BAAC
		public static IHookLockScreenDetectTypeFullScreen GetRootAsIHookLockScreenDetectTypeFullScreen(ByteBuffer _bb)
		{
			return IHookLockScreenDetectTypeFullScreen.GetRootAsIHookLockScreenDetectTypeFullScreen(_bb, default(IHookLockScreenDetectTypeFullScreen));
		}

		// Token: 0x06025434 RID: 152628 RVA: 0x0051D8C8 File Offset: 0x0051BAC8
		public static IHookLockScreenDetectTypeFullScreen GetRootAsIHookLockScreenDetectTypeFullScreen(ByteBuffer _bb, IHookLockScreenDetectTypeFullScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025435 RID: 152629 RVA: 0x0051D8E5 File Offset: 0x0051BAE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025436 RID: 152630 RVA: 0x0051D8F4 File Offset: 0x0051BAF4
		public IHookLockScreenDetectTypeFullScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A61C RID: 42524
		// (get) Token: 0x06025437 RID: 152631 RVA: 0x0051D904 File Offset: 0x0051BB04
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

		// Token: 0x06025438 RID: 152632 RVA: 0x0051D940 File Offset: 0x0051BB40
		public static Offset<IHookLockScreenDetectTypeFullScreen> CreateIHookLockScreenDetectTypeFullScreen(FlatBufferBuilder builder, EHookLockScreenDetectType Type = EHookLockScreenDetectType.CentralEllipse)
		{
			builder.StartTable(1);
			IHookLockScreenDetectTypeFullScreen.AddType(builder, Type);
			return IHookLockScreenDetectTypeFullScreen.EndIHookLockScreenDetectTypeFullScreen(builder);
		}

		// Token: 0x06025439 RID: 152633 RVA: 0x0051D956 File Offset: 0x0051BB56
		public static void StartIHookLockScreenDetectTypeFullScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602543A RID: 152634 RVA: 0x0051D95F File Offset: 0x0051BB5F
		public static void AddType(FlatBufferBuilder builder, EHookLockScreenDetectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602543B RID: 152635 RVA: 0x0051D96A File Offset: 0x0051BB6A
		public static Offset<IHookLockScreenDetectTypeFullScreen> EndIHookLockScreenDetectTypeFullScreen(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockScreenDetectTypeFullScreen>(builder.EndTable());
		}

		// Token: 0x0602543C RID: 152636 RVA: 0x0051D978 File Offset: 0x0051BB78
		public IHookLockScreenDetectTypeFullScreenT UnPack()
		{
			IHookLockScreenDetectTypeFullScreenT hookLockScreenDetectTypeFullScreenT = new IHookLockScreenDetectTypeFullScreenT();
			this.UnPackTo(hookLockScreenDetectTypeFullScreenT);
			return hookLockScreenDetectTypeFullScreenT;
		}

		// Token: 0x0602543D RID: 152637 RVA: 0x0051D993 File Offset: 0x0051BB93
		public void UnPackTo(IHookLockScreenDetectTypeFullScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602543E RID: 152638 RVA: 0x0051D9A4 File Offset: 0x0051BBA4
		public static Offset<IHookLockScreenDetectTypeFullScreen> Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeFullScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockScreenDetectTypeFullScreen>);
			}
			return IHookLockScreenDetectTypeFullScreen.CreateIHookLockScreenDetectTypeFullScreen(builder, _o.Type);
		}

		// Token: 0x0400F23B RID: 62011
		private Table __p;
	}
}
