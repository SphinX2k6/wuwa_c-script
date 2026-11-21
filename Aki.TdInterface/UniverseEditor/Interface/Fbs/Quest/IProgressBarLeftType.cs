using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043FD RID: 17405
	public struct IProgressBarLeftType : IFlatbufferObject
	{
		// Token: 0x170077F1 RID: 30705
		// (get) Token: 0x06018BD7 RID: 101335 RVA: 0x00386AA8 File Offset: 0x00384CA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BD8 RID: 101336 RVA: 0x00386AB5 File Offset: 0x00384CB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BD9 RID: 101337 RVA: 0x00386ABC File Offset: 0x00384CBC
		public static IProgressBarLeftType GetRootAsIProgressBarLeftType(ByteBuffer _bb)
		{
			return IProgressBarLeftType.GetRootAsIProgressBarLeftType(_bb, default(IProgressBarLeftType));
		}

		// Token: 0x06018BDA RID: 101338 RVA: 0x00386AD8 File Offset: 0x00384CD8
		public static IProgressBarLeftType GetRootAsIProgressBarLeftType(ByteBuffer _bb, IProgressBarLeftType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BDB RID: 101339 RVA: 0x00386AF5 File Offset: 0x00384CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BDC RID: 101340 RVA: 0x00386B04 File Offset: 0x00384D04
		public IProgressBarLeftType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077F2 RID: 30706
		// (get) Token: 0x06018BDD RID: 101341 RVA: 0x00386B14 File Offset: 0x00384D14
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

		// Token: 0x06018BDE RID: 101342 RVA: 0x00386B50 File Offset: 0x00384D50
		public static Offset<IProgressBarLeftType> CreateIProgressBarLeftType(FlatBufferBuilder builder, EProgressBarLeftType Type = EProgressBarLeftType.UseCount)
		{
			builder.StartTable(1);
			IProgressBarLeftType.AddType(builder, Type);
			return IProgressBarLeftType.EndIProgressBarLeftType(builder);
		}

		// Token: 0x06018BDF RID: 101343 RVA: 0x00386B66 File Offset: 0x00384D66
		public static void StartIProgressBarLeftType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018BE0 RID: 101344 RVA: 0x00386B6F File Offset: 0x00384D6F
		public static void AddType(FlatBufferBuilder builder, EProgressBarLeftType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018BE1 RID: 101345 RVA: 0x00386B7A File Offset: 0x00384D7A
		public static Offset<IProgressBarLeftType> EndIProgressBarLeftType(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBarLeftType>(builder.EndTable());
		}

		// Token: 0x06018BE2 RID: 101346 RVA: 0x00386B88 File Offset: 0x00384D88
		public IProgressBarLeftTypeT UnPack()
		{
			IProgressBarLeftTypeT progressBarLeftTypeT = new IProgressBarLeftTypeT();
			this.UnPackTo(progressBarLeftTypeT);
			return progressBarLeftTypeT;
		}

		// Token: 0x06018BE3 RID: 101347 RVA: 0x00386BA3 File Offset: 0x00384DA3
		public void UnPackTo(IProgressBarLeftTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018BE4 RID: 101348 RVA: 0x00386BB4 File Offset: 0x00384DB4
		public static Offset<IProgressBarLeftType> Pack(FlatBufferBuilder builder, IProgressBarLeftTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBarLeftType>);
			}
			return IProgressBarLeftType.CreateIProgressBarLeftType(builder, _o.Type);
		}

		// Token: 0x0400C40E RID: 50190
		private Table __p;
	}
}
