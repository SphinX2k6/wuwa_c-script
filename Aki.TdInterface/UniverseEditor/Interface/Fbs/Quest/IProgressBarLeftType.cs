using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FBC RID: 16316
	public struct IProgressBarLeftType : IFlatbufferObject
	{
		// Token: 0x170071F3 RID: 29171
		// (get) Token: 0x06017548 RID: 95560 RVA: 0x0035CE90 File Offset: 0x0035B090
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017549 RID: 95561 RVA: 0x0035CE9D File Offset: 0x0035B09D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601754A RID: 95562 RVA: 0x0035CEA4 File Offset: 0x0035B0A4
		public static IProgressBarLeftType GetRootAsIProgressBarLeftType(ByteBuffer _bb)
		{
			return IProgressBarLeftType.GetRootAsIProgressBarLeftType(_bb, default(IProgressBarLeftType));
		}

		// Token: 0x0601754B RID: 95563 RVA: 0x0035CEC0 File Offset: 0x0035B0C0
		public static IProgressBarLeftType GetRootAsIProgressBarLeftType(ByteBuffer _bb, IProgressBarLeftType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601754C RID: 95564 RVA: 0x0035CEDD File Offset: 0x0035B0DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601754D RID: 95565 RVA: 0x0035CEEC File Offset: 0x0035B0EC
		public IProgressBarLeftType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071F4 RID: 29172
		// (get) Token: 0x0601754E RID: 95566 RVA: 0x0035CEFC File Offset: 0x0035B0FC
		public EProgressBarLeftType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarLeftType.UseCount;
				}
				return (EProgressBarLeftType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601754F RID: 95567 RVA: 0x0035CF38 File Offset: 0x0035B138
		public static Offset<IProgressBarLeftType> CreateIProgressBarLeftType(FlatBufferBuilder builder, EProgressBarLeftType Type = EProgressBarLeftType.UseCount)
		{
			builder.StartTable(1);
			IProgressBarLeftType.AddType(builder, Type);
			return IProgressBarLeftType.EndIProgressBarLeftType(builder);
		}

		// Token: 0x06017550 RID: 95568 RVA: 0x0035CF4E File Offset: 0x0035B14E
		public static void StartIProgressBarLeftType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017551 RID: 95569 RVA: 0x0035CF57 File Offset: 0x0035B157
		public static void AddType(FlatBufferBuilder builder, EProgressBarLeftType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017552 RID: 95570 RVA: 0x0035CF62 File Offset: 0x0035B162
		public static Offset<IProgressBarLeftType> EndIProgressBarLeftType(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBarLeftType>(builder.EndTable());
		}

		// Token: 0x06017553 RID: 95571 RVA: 0x0035CF70 File Offset: 0x0035B170
		public IProgressBarLeftTypeT UnPack()
		{
			IProgressBarLeftTypeT progressBarLeftTypeT = new IProgressBarLeftTypeT();
			this.UnPackTo(progressBarLeftTypeT);
			return progressBarLeftTypeT;
		}

		// Token: 0x06017554 RID: 95572 RVA: 0x0035CF8B File Offset: 0x0035B18B
		public void UnPackTo(IProgressBarLeftTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017555 RID: 95573 RVA: 0x0035CF9C File Offset: 0x0035B19C
		public static Offset<IProgressBarLeftType> Pack(FlatBufferBuilder builder, IProgressBarLeftTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBarLeftType>);
			}
			return IProgressBarLeftType.CreateIProgressBarLeftType(builder, _o.Type);
		}

		// Token: 0x0400BA29 RID: 47657
		private Table __p;
	}
}
