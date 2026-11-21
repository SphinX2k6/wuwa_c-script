using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007412 RID: 29714
	public struct IPhoneBoardTypeBase : IFlatbufferObject
	{
		// Token: 0x1700DA4B RID: 55883
		// (get) Token: 0x06033FD6 RID: 212950 RVA: 0x00702032 File Offset: 0x00700232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033FD7 RID: 212951 RVA: 0x0070203F File Offset: 0x0070023F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FD8 RID: 212952 RVA: 0x00702048 File Offset: 0x00700248
		public static IPhoneBoardTypeBase GetRootAsIPhoneBoardTypeBase(ByteBuffer _bb)
		{
			return IPhoneBoardTypeBase.GetRootAsIPhoneBoardTypeBase(_bb, default(IPhoneBoardTypeBase));
		}

		// Token: 0x06033FD9 RID: 212953 RVA: 0x00702064 File Offset: 0x00700264
		public static IPhoneBoardTypeBase GetRootAsIPhoneBoardTypeBase(ByteBuffer _bb, IPhoneBoardTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FDA RID: 212954 RVA: 0x00702081 File Offset: 0x00700281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FDB RID: 212955 RVA: 0x00702090 File Offset: 0x00700290
		public IPhoneBoardTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA4C RID: 55884
		// (get) Token: 0x06033FDC RID: 212956 RVA: 0x007020A0 File Offset: 0x007002A0
		public EPhoneBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneBoardType.MessageBoard;
				}
				return (EPhoneBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033FDD RID: 212957 RVA: 0x007020DC File Offset: 0x007002DC
		public static Offset<IPhoneBoardTypeBase> CreateIPhoneBoardTypeBase(FlatBufferBuilder builder, EPhoneBoardType Type = EPhoneBoardType.MessageBoard)
		{
			builder.StartTable(1);
			IPhoneBoardTypeBase.AddType(builder, Type);
			return IPhoneBoardTypeBase.EndIPhoneBoardTypeBase(builder);
		}

		// Token: 0x06033FDE RID: 212958 RVA: 0x007020F2 File Offset: 0x007002F2
		public static void StartIPhoneBoardTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033FDF RID: 212959 RVA: 0x007020FB File Offset: 0x007002FB
		public static void AddType(FlatBufferBuilder builder, EPhoneBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033FE0 RID: 212960 RVA: 0x00702106 File Offset: 0x00700306
		public static Offset<IPhoneBoardTypeBase> EndIPhoneBoardTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneBoardTypeBase>(builder.EndTable());
		}

		// Token: 0x06033FE1 RID: 212961 RVA: 0x00702114 File Offset: 0x00700314
		public IPhoneBoardTypeBaseT UnPack()
		{
			IPhoneBoardTypeBaseT phoneBoardTypeBaseT = new IPhoneBoardTypeBaseT();
			this.UnPackTo(phoneBoardTypeBaseT);
			return phoneBoardTypeBaseT;
		}

		// Token: 0x06033FE2 RID: 212962 RVA: 0x0070212F File Offset: 0x0070032F
		public void UnPackTo(IPhoneBoardTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033FE3 RID: 212963 RVA: 0x00702140 File Offset: 0x00700340
		public static Offset<IPhoneBoardTypeBase> Pack(FlatBufferBuilder builder, IPhoneBoardTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneBoardTypeBase>);
			}
			return IPhoneBoardTypeBase.CreateIPhoneBoardTypeBase(builder, _o.Type);
		}

		// Token: 0x04012563 RID: 75107
		private Table __p;
	}
}
