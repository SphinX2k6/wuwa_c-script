using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004693 RID: 18067
	public struct ISetUnopenedAreaPullback : IFlatbufferObject
	{
		// Token: 0x17008042 RID: 32834
		// (get) Token: 0x0601B6E5 RID: 112357 RVA: 0x003E589C File Offset: 0x003E3A9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6E6 RID: 112358 RVA: 0x003E58A9 File Offset: 0x003E3AA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6E7 RID: 112359 RVA: 0x003E58B0 File Offset: 0x003E3AB0
		public static ISetUnopenedAreaPullback GetRootAsISetUnopenedAreaPullback(ByteBuffer _bb)
		{
			return ISetUnopenedAreaPullback.GetRootAsISetUnopenedAreaPullback(_bb, default(ISetUnopenedAreaPullback));
		}

		// Token: 0x0601B6E8 RID: 112360 RVA: 0x003E58CC File Offset: 0x003E3ACC
		public static ISetUnopenedAreaPullback GetRootAsISetUnopenedAreaPullback(ByteBuffer _bb, ISetUnopenedAreaPullback obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6E9 RID: 112361 RVA: 0x003E58E9 File Offset: 0x003E3AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6EA RID: 112362 RVA: 0x003E58F8 File Offset: 0x003E3AF8
		public ISetUnopenedAreaPullback __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008043 RID: 32835
		// (get) Token: 0x0601B6EB RID: 112363 RVA: 0x003E5908 File Offset: 0x003E3B08
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008044 RID: 32836
		// (get) Token: 0x0601B6EC RID: 112364 RVA: 0x003E5944 File Offset: 0x003E3B44
		public bool IsOpen
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B6ED RID: 112365 RVA: 0x003E5983 File Offset: 0x003E3B83
		public static Offset<ISetUnopenedAreaPullback> CreateISetUnopenedAreaPullback(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, bool IsOpen = false)
		{
			builder.StartTable(2);
			ISetUnopenedAreaPullback.AddIsOpen(builder, IsOpen);
			ISetUnopenedAreaPullback.AddType(builder, Type);
			return ISetUnopenedAreaPullback.EndISetUnopenedAreaPullback(builder);
		}

		// Token: 0x0601B6EE RID: 112366 RVA: 0x003E59A0 File Offset: 0x003E3BA0
		public static void StartISetUnopenedAreaPullback(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B6EF RID: 112367 RVA: 0x003E59A9 File Offset: 0x003E3BA9
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B6F0 RID: 112368 RVA: 0x003E59B4 File Offset: 0x003E3BB4
		public static void AddIsOpen(FlatBufferBuilder builder, bool isOpen)
		{
			builder.AddBool(1, isOpen, false);
		}

		// Token: 0x0601B6F1 RID: 112369 RVA: 0x003E59BF File Offset: 0x003E3BBF
		public static Offset<ISetUnopenedAreaPullback> EndISetUnopenedAreaPullback(FlatBufferBuilder builder)
		{
			return new Offset<ISetUnopenedAreaPullback>(builder.EndTable());
		}

		// Token: 0x0601B6F2 RID: 112370 RVA: 0x003E59CC File Offset: 0x003E3BCC
		public ISetUnopenedAreaPullbackT UnPack()
		{
			ISetUnopenedAreaPullbackT setUnopenedAreaPullbackT = new ISetUnopenedAreaPullbackT();
			this.UnPackTo(setUnopenedAreaPullbackT);
			return setUnopenedAreaPullbackT;
		}

		// Token: 0x0601B6F3 RID: 112371 RVA: 0x003E59E7 File Offset: 0x003E3BE7
		public void UnPackTo(ISetUnopenedAreaPullbackT _o)
		{
			_o.Type = this.Type;
			_o.IsOpen = this.IsOpen;
		}

		// Token: 0x0601B6F4 RID: 112372 RVA: 0x003E5A04 File Offset: 0x003E3C04
		public static Offset<ISetUnopenedAreaPullback> Pack(FlatBufferBuilder builder, ISetUnopenedAreaPullbackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetUnopenedAreaPullback>);
			}
			return ISetUnopenedAreaPullback.CreateISetUnopenedAreaPullback(builder, _o.Type, _o.IsOpen);
		}

		// Token: 0x0400C853 RID: 51283
		private Table __p;
	}
}
