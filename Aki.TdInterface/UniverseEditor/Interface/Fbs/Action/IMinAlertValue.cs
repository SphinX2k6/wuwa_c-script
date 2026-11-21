using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C8 RID: 29128
	public struct IMinAlertValue : IFlatbufferObject
	{
		// Token: 0x1700D54A RID: 54602
		// (get) Token: 0x06032AA0 RID: 207520 RVA: 0x006D8360 File Offset: 0x006D6560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032AA1 RID: 207521 RVA: 0x006D836D File Offset: 0x006D656D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032AA2 RID: 207522 RVA: 0x006D8374 File Offset: 0x006D6574
		public static IMinAlertValue GetRootAsIMinAlertValue(ByteBuffer _bb)
		{
			return IMinAlertValue.GetRootAsIMinAlertValue(_bb, default(IMinAlertValue));
		}

		// Token: 0x06032AA3 RID: 207523 RVA: 0x006D8390 File Offset: 0x006D6590
		public static IMinAlertValue GetRootAsIMinAlertValue(ByteBuffer _bb, IMinAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AA4 RID: 207524 RVA: 0x006D83AD File Offset: 0x006D65AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AA5 RID: 207525 RVA: 0x006D83BC File Offset: 0x006D65BC
		public IMinAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D54B RID: 54603
		// (get) Token: 0x06032AA6 RID: 207526 RVA: 0x006D83CC File Offset: 0x006D65CC
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032AA7 RID: 207527 RVA: 0x006D8408 File Offset: 0x006D6608
		public static Offset<IMinAlertValue> CreateIMinAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			IMinAlertValue.AddType(builder, Type);
			return IMinAlertValue.EndIMinAlertValue(builder);
		}

		// Token: 0x06032AA8 RID: 207528 RVA: 0x006D841E File Offset: 0x006D661E
		public static void StartIMinAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032AA9 RID: 207529 RVA: 0x006D8427 File Offset: 0x006D6627
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032AAA RID: 207530 RVA: 0x006D8432 File Offset: 0x006D6632
		public static Offset<IMinAlertValue> EndIMinAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IMinAlertValue>(builder.EndTable());
		}

		// Token: 0x06032AAB RID: 207531 RVA: 0x006D8440 File Offset: 0x006D6640
		public IMinAlertValueT UnPack()
		{
			IMinAlertValueT minAlertValueT = new IMinAlertValueT();
			this.UnPackTo(minAlertValueT);
			return minAlertValueT;
		}

		// Token: 0x06032AAC RID: 207532 RVA: 0x006D845B File Offset: 0x006D665B
		public void UnPackTo(IMinAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032AAD RID: 207533 RVA: 0x006D846C File Offset: 0x006D666C
		public static Offset<IMinAlertValue> Pack(FlatBufferBuilder builder, IMinAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMinAlertValue>);
			}
			return IMinAlertValue.CreateIMinAlertValue(builder, _o.Type);
		}

		// Token: 0x040121DB RID: 74203
		private Table __p;
	}
}
