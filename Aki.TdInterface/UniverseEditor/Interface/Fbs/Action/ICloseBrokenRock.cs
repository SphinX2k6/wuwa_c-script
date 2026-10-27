using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006415 RID: 25621
	public struct ICloseBrokenRock : IFlatbufferObject
	{
		// Token: 0x1700BEC6 RID: 48838
		// (get) Token: 0x0602C54D RID: 181581 RVA: 0x006158C5 File Offset: 0x00613AC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C54E RID: 181582 RVA: 0x006158D2 File Offset: 0x00613AD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C54F RID: 181583 RVA: 0x006158DC File Offset: 0x00613ADC
		public static ICloseBrokenRock GetRootAsICloseBrokenRock(ByteBuffer _bb)
		{
			return ICloseBrokenRock.GetRootAsICloseBrokenRock(_bb, default(ICloseBrokenRock));
		}

		// Token: 0x0602C550 RID: 181584 RVA: 0x006158F8 File Offset: 0x00613AF8
		public static ICloseBrokenRock GetRootAsICloseBrokenRock(ByteBuffer _bb, ICloseBrokenRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C551 RID: 181585 RVA: 0x00615915 File Offset: 0x00613B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C552 RID: 181586 RVA: 0x00615924 File Offset: 0x00613B24
		public ICloseBrokenRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEC7 RID: 48839
		// (get) Token: 0x0602C553 RID: 181587 RVA: 0x00615934 File Offset: 0x00613B34
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C554 RID: 181588 RVA: 0x00615970 File Offset: 0x00613B70
		public static Offset<ICloseBrokenRock> CreateICloseBrokenRock(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			ICloseBrokenRock.AddType(builder, Type);
			return ICloseBrokenRock.EndICloseBrokenRock(builder);
		}

		// Token: 0x0602C555 RID: 181589 RVA: 0x00615986 File Offset: 0x00613B86
		public static void StartICloseBrokenRock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C556 RID: 181590 RVA: 0x0061598F File Offset: 0x00613B8F
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C557 RID: 181591 RVA: 0x0061599A File Offset: 0x00613B9A
		public static Offset<ICloseBrokenRock> EndICloseBrokenRock(FlatBufferBuilder builder)
		{
			return new Offset<ICloseBrokenRock>(builder.EndTable());
		}

		// Token: 0x0602C558 RID: 181592 RVA: 0x006159A8 File Offset: 0x00613BA8
		public ICloseBrokenRockT UnPack()
		{
			ICloseBrokenRockT closeBrokenRockT = new ICloseBrokenRockT();
			this.UnPackTo(closeBrokenRockT);
			return closeBrokenRockT;
		}

		// Token: 0x0602C559 RID: 181593 RVA: 0x006159C3 File Offset: 0x00613BC3
		public void UnPackTo(ICloseBrokenRockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C55A RID: 181594 RVA: 0x006159D4 File Offset: 0x00613BD4
		public static Offset<ICloseBrokenRock> Pack(FlatBufferBuilder builder, ICloseBrokenRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseBrokenRock>);
			}
			return ICloseBrokenRock.CreateICloseBrokenRock(builder, _o.Type);
		}

		// Token: 0x04010A03 RID: 68099
		private Table __p;
	}
}
