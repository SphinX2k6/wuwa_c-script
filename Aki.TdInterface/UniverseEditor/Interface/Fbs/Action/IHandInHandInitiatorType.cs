using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F71 RID: 28529
	public struct IHandInHandInitiatorType : IFlatbufferObject
	{
		// Token: 0x1700D0FF RID: 53503
		// (get) Token: 0x06031618 RID: 202264 RVA: 0x006B2708 File Offset: 0x006B0908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031619 RID: 202265 RVA: 0x006B2715 File Offset: 0x006B0915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603161A RID: 202266 RVA: 0x006B271C File Offset: 0x006B091C
		public static IHandInHandInitiatorType GetRootAsIHandInHandInitiatorType(ByteBuffer _bb)
		{
			return IHandInHandInitiatorType.GetRootAsIHandInHandInitiatorType(_bb, default(IHandInHandInitiatorType));
		}

		// Token: 0x0603161B RID: 202267 RVA: 0x006B2738 File Offset: 0x006B0938
		public static IHandInHandInitiatorType GetRootAsIHandInHandInitiatorType(ByteBuffer _bb, IHandInHandInitiatorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603161C RID: 202268 RVA: 0x006B2755 File Offset: 0x006B0955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603161D RID: 202269 RVA: 0x006B2764 File Offset: 0x006B0964
		public IHandInHandInitiatorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D100 RID: 53504
		// (get) Token: 0x0603161E RID: 202270 RVA: 0x006B2774 File Offset: 0x006B0974
		public EHandInHandInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInHandInitiatorType.Player;
				}
				return (EHandInHandInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603161F RID: 202271 RVA: 0x006B27B0 File Offset: 0x006B09B0
		public static Offset<IHandInHandInitiatorType> CreateIHandInHandInitiatorType(FlatBufferBuilder builder, EHandInHandInitiatorType Type = EHandInHandInitiatorType.Player)
		{
			builder.StartTable(1);
			IHandInHandInitiatorType.AddType(builder, Type);
			return IHandInHandInitiatorType.EndIHandInHandInitiatorType(builder);
		}

		// Token: 0x06031620 RID: 202272 RVA: 0x006B27C6 File Offset: 0x006B09C6
		public static void StartIHandInHandInitiatorType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031621 RID: 202273 RVA: 0x006B27CF File Offset: 0x006B09CF
		public static void AddType(FlatBufferBuilder builder, EHandInHandInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031622 RID: 202274 RVA: 0x006B27DA File Offset: 0x006B09DA
		public static Offset<IHandInHandInitiatorType> EndIHandInHandInitiatorType(FlatBufferBuilder builder)
		{
			return new Offset<IHandInHandInitiatorType>(builder.EndTable());
		}

		// Token: 0x06031623 RID: 202275 RVA: 0x006B27E8 File Offset: 0x006B09E8
		public IHandInHandInitiatorTypeT UnPack()
		{
			IHandInHandInitiatorTypeT handInHandInitiatorTypeT = new IHandInHandInitiatorTypeT();
			this.UnPackTo(handInHandInitiatorTypeT);
			return handInHandInitiatorTypeT;
		}

		// Token: 0x06031624 RID: 202276 RVA: 0x006B2803 File Offset: 0x006B0A03
		public void UnPackTo(IHandInHandInitiatorTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031625 RID: 202277 RVA: 0x006B2814 File Offset: 0x006B0A14
		public static Offset<IHandInHandInitiatorType> Pack(FlatBufferBuilder builder, IHandInHandInitiatorTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInHandInitiatorType>);
			}
			return IHandInHandInitiatorType.CreateIHandInHandInitiatorType(builder, _o.Type);
		}

		// Token: 0x04011E82 RID: 73346
		private Table __p;
	}
}
