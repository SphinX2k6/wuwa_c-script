using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007768 RID: 30568
	public struct ISetAreaTimeBase : IFlatbufferObject
	{
		// Token: 0x1700E00D RID: 57357
		// (get) Token: 0x06035A69 RID: 219753 RVA: 0x00730ACA File Offset: 0x0072ECCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A6A RID: 219754 RVA: 0x00730AD7 File Offset: 0x0072ECD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A6B RID: 219755 RVA: 0x00730AE0 File Offset: 0x0072ECE0
		public static ISetAreaTimeBase GetRootAsISetAreaTimeBase(ByteBuffer _bb)
		{
			return ISetAreaTimeBase.GetRootAsISetAreaTimeBase(_bb, default(ISetAreaTimeBase));
		}

		// Token: 0x06035A6C RID: 219756 RVA: 0x00730AFC File Offset: 0x0072ECFC
		public static ISetAreaTimeBase GetRootAsISetAreaTimeBase(ByteBuffer _bb, ISetAreaTimeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A6D RID: 219757 RVA: 0x00730B19 File Offset: 0x0072ED19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A6E RID: 219758 RVA: 0x00730B28 File Offset: 0x0072ED28
		public ISetAreaTimeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E00E RID: 57358
		// (get) Token: 0x06035A6F RID: 219759 RVA: 0x00730B38 File Offset: 0x0072ED38
		public ESetAreaTime Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetAreaTime.Lock;
				}
				return (ESetAreaTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A70 RID: 219760 RVA: 0x00730B74 File Offset: 0x0072ED74
		public static Offset<ISetAreaTimeBase> CreateISetAreaTimeBase(FlatBufferBuilder builder, ESetAreaTime Type = ESetAreaTime.Lock)
		{
			builder.StartTable(1);
			ISetAreaTimeBase.AddType(builder, Type);
			return ISetAreaTimeBase.EndISetAreaTimeBase(builder);
		}

		// Token: 0x06035A71 RID: 219761 RVA: 0x00730B8A File Offset: 0x0072ED8A
		public static void StartISetAreaTimeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035A72 RID: 219762 RVA: 0x00730B93 File Offset: 0x0072ED93
		public static void AddType(FlatBufferBuilder builder, ESetAreaTime type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A73 RID: 219763 RVA: 0x00730B9E File Offset: 0x0072ED9E
		public static Offset<ISetAreaTimeBase> EndISetAreaTimeBase(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeBase>(builder.EndTable());
		}

		// Token: 0x06035A74 RID: 219764 RVA: 0x00730BAC File Offset: 0x0072EDAC
		public ISetAreaTimeBaseT UnPack()
		{
			ISetAreaTimeBaseT setAreaTimeBaseT = new ISetAreaTimeBaseT();
			this.UnPackTo(setAreaTimeBaseT);
			return setAreaTimeBaseT;
		}

		// Token: 0x06035A75 RID: 219765 RVA: 0x00730BC7 File Offset: 0x0072EDC7
		public void UnPackTo(ISetAreaTimeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035A76 RID: 219766 RVA: 0x00730BD8 File Offset: 0x0072EDD8
		public static Offset<ISetAreaTimeBase> Pack(FlatBufferBuilder builder, ISetAreaTimeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaTimeBase>);
			}
			return ISetAreaTimeBase.CreateISetAreaTimeBase(builder, _o.Type);
		}

		// Token: 0x04012988 RID: 76168
		private Table __p;
	}
}
