using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D4 RID: 21460
	public struct IHookLockScreenDetectTypeFullScreen : IFlatbufferObject
	{
		// Token: 0x17009DE1 RID: 40417
		// (get) Token: 0x06023379 RID: 144249 RVA: 0x004E0869 File Offset: 0x004DEA69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602337A RID: 144250 RVA: 0x004E0876 File Offset: 0x004DEA76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602337B RID: 144251 RVA: 0x004E0880 File Offset: 0x004DEA80
		public static IHookLockScreenDetectTypeFullScreen GetRootAsIHookLockScreenDetectTypeFullScreen(ByteBuffer _bb)
		{
			return IHookLockScreenDetectTypeFullScreen.GetRootAsIHookLockScreenDetectTypeFullScreen(_bb, default(IHookLockScreenDetectTypeFullScreen));
		}

		// Token: 0x0602337C RID: 144252 RVA: 0x004E089C File Offset: 0x004DEA9C
		public static IHookLockScreenDetectTypeFullScreen GetRootAsIHookLockScreenDetectTypeFullScreen(ByteBuffer _bb, IHookLockScreenDetectTypeFullScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602337D RID: 144253 RVA: 0x004E08B9 File Offset: 0x004DEAB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602337E RID: 144254 RVA: 0x004E08C8 File Offset: 0x004DEAC8
		public IHookLockScreenDetectTypeFullScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DE2 RID: 40418
		// (get) Token: 0x0602337F RID: 144255 RVA: 0x004E08D8 File Offset: 0x004DEAD8
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

		// Token: 0x06023380 RID: 144256 RVA: 0x004E0914 File Offset: 0x004DEB14
		public static Offset<IHookLockScreenDetectTypeFullScreen> CreateIHookLockScreenDetectTypeFullScreen(FlatBufferBuilder builder, EHookLockScreenDetectType Type = EHookLockScreenDetectType.CentralEllipse)
		{
			builder.StartTable(1);
			IHookLockScreenDetectTypeFullScreen.AddType(builder, Type);
			return IHookLockScreenDetectTypeFullScreen.EndIHookLockScreenDetectTypeFullScreen(builder);
		}

		// Token: 0x06023381 RID: 144257 RVA: 0x004E092A File Offset: 0x004DEB2A
		public static void StartIHookLockScreenDetectTypeFullScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023382 RID: 144258 RVA: 0x004E0933 File Offset: 0x004DEB33
		public static void AddType(FlatBufferBuilder builder, EHookLockScreenDetectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023383 RID: 144259 RVA: 0x004E093E File Offset: 0x004DEB3E
		public static Offset<IHookLockScreenDetectTypeFullScreen> EndIHookLockScreenDetectTypeFullScreen(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockScreenDetectTypeFullScreen>(builder.EndTable());
		}

		// Token: 0x06023384 RID: 144260 RVA: 0x004E094C File Offset: 0x004DEB4C
		public IHookLockScreenDetectTypeFullScreenT UnPack()
		{
			IHookLockScreenDetectTypeFullScreenT hookLockScreenDetectTypeFullScreenT = new IHookLockScreenDetectTypeFullScreenT();
			this.UnPackTo(hookLockScreenDetectTypeFullScreenT);
			return hookLockScreenDetectTypeFullScreenT;
		}

		// Token: 0x06023385 RID: 144261 RVA: 0x004E0967 File Offset: 0x004DEB67
		public void UnPackTo(IHookLockScreenDetectTypeFullScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023386 RID: 144262 RVA: 0x004E0978 File Offset: 0x004DEB78
		public static Offset<IHookLockScreenDetectTypeFullScreen> Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeFullScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockScreenDetectTypeFullScreen>);
			}
			return IHookLockScreenDetectTypeFullScreen.CreateIHookLockScreenDetectTypeFullScreen(builder, _o.Type);
		}

		// Token: 0x0400E60A RID: 58890
		private Table __p;
	}
}
