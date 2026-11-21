using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DD RID: 21981
	public struct IDefaultAkEvent : IFlatbufferObject
	{
		// Token: 0x17009D62 RID: 40290
		// (get) Token: 0x06022FB3 RID: 143283 RVA: 0x004D05E0 File Offset: 0x004CE7E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FB4 RID: 143284 RVA: 0x004D05ED File Offset: 0x004CE7ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FB5 RID: 143285 RVA: 0x004D05F4 File Offset: 0x004CE7F4
		public static IDefaultAkEvent GetRootAsIDefaultAkEvent(ByteBuffer _bb)
		{
			return IDefaultAkEvent.GetRootAsIDefaultAkEvent(_bb, default(IDefaultAkEvent));
		}

		// Token: 0x06022FB6 RID: 143286 RVA: 0x004D0610 File Offset: 0x004CE810
		public static IDefaultAkEvent GetRootAsIDefaultAkEvent(ByteBuffer _bb, IDefaultAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FB7 RID: 143287 RVA: 0x004D062D File Offset: 0x004CE82D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FB8 RID: 143288 RVA: 0x004D063C File Offset: 0x004CE83C
		public IDefaultAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D63 RID: 40291
		// (get) Token: 0x06022FB9 RID: 143289 RVA: 0x004D064C File Offset: 0x004CE84C
		public EAkEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventType.Point;
				}
				return (EAkEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022FBA RID: 143290 RVA: 0x004D0688 File Offset: 0x004CE888
		public static Offset<IDefaultAkEvent> CreateIDefaultAkEvent(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point)
		{
			builder.StartTable(1);
			IDefaultAkEvent.AddType(builder, Type);
			return IDefaultAkEvent.EndIDefaultAkEvent(builder);
		}

		// Token: 0x06022FBB RID: 143291 RVA: 0x004D069E File Offset: 0x004CE89E
		public static void StartIDefaultAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022FBC RID: 143292 RVA: 0x004D06A7 File Offset: 0x004CE8A7
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022FBD RID: 143293 RVA: 0x004D06B2 File Offset: 0x004CE8B2
		public static Offset<IDefaultAkEvent> EndIDefaultAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDefaultAkEvent>(builder.EndTable());
		}

		// Token: 0x06022FBE RID: 143294 RVA: 0x004D06C0 File Offset: 0x004CE8C0
		public IDefaultAkEventT UnPack()
		{
			IDefaultAkEventT defaultAkEventT = new IDefaultAkEventT();
			this.UnPackTo(defaultAkEventT);
			return defaultAkEventT;
		}

		// Token: 0x06022FBF RID: 143295 RVA: 0x004D06DB File Offset: 0x004CE8DB
		public void UnPackTo(IDefaultAkEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022FC0 RID: 143296 RVA: 0x004D06EC File Offset: 0x004CE8EC
		public static Offset<IDefaultAkEvent> Pack(FlatBufferBuilder builder, IDefaultAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDefaultAkEvent>);
			}
			return IDefaultAkEvent.CreateIDefaultAkEvent(builder, _o.Type);
		}

		// Token: 0x0400EC79 RID: 60537
		private Table __p;
	}
}
