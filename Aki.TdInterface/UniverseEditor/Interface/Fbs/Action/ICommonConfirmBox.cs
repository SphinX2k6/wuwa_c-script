using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200647A RID: 25722
	public struct ICommonConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700BF6A RID: 49002
		// (get) Token: 0x0602C900 RID: 182528 RVA: 0x0061E813 File Offset: 0x0061CA13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C901 RID: 182529 RVA: 0x0061E820 File Offset: 0x0061CA20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C902 RID: 182530 RVA: 0x0061E828 File Offset: 0x0061CA28
		public static ICommonConfirmBox GetRootAsICommonConfirmBox(ByteBuffer _bb)
		{
			return ICommonConfirmBox.GetRootAsICommonConfirmBox(_bb, default(ICommonConfirmBox));
		}

		// Token: 0x0602C903 RID: 182531 RVA: 0x0061E844 File Offset: 0x0061CA44
		public static ICommonConfirmBox GetRootAsICommonConfirmBox(ByteBuffer _bb, ICommonConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C904 RID: 182532 RVA: 0x0061E861 File Offset: 0x0061CA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C905 RID: 182533 RVA: 0x0061E870 File Offset: 0x0061CA70
		public ICommonConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF6B RID: 49003
		// (get) Token: 0x0602C906 RID: 182534 RVA: 0x0061E880 File Offset: 0x0061CA80
		public EInteractionConfirmBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return (EInteractionConfirmBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF6C RID: 49004
		// (get) Token: 0x0602C907 RID: 182535 RVA: 0x0061E8BC File Offset: 0x0061CABC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C908 RID: 182536 RVA: 0x0061E8F8 File Offset: 0x0061CAF8
		public static Offset<ICommonConfirmBox> CreateICommonConfirmBox(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common, int Id = 0)
		{
			builder.StartTable(2);
			ICommonConfirmBox.AddId(builder, Id);
			ICommonConfirmBox.AddType(builder, Type);
			return ICommonConfirmBox.EndICommonConfirmBox(builder);
		}

		// Token: 0x0602C909 RID: 182537 RVA: 0x0061E915 File Offset: 0x0061CB15
		public static void StartICommonConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C90A RID: 182538 RVA: 0x0061E91E File Offset: 0x0061CB1E
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C90B RID: 182539 RVA: 0x0061E929 File Offset: 0x0061CB29
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C90C RID: 182540 RVA: 0x0061E934 File Offset: 0x0061CB34
		public static Offset<ICommonConfirmBox> EndICommonConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<ICommonConfirmBox>(builder.EndTable());
		}

		// Token: 0x0602C90D RID: 182541 RVA: 0x0061E944 File Offset: 0x0061CB44
		public ICommonConfirmBoxT UnPack()
		{
			ICommonConfirmBoxT commonConfirmBoxT = new ICommonConfirmBoxT();
			this.UnPackTo(commonConfirmBoxT);
			return commonConfirmBoxT;
		}

		// Token: 0x0602C90E RID: 182542 RVA: 0x0061E95F File Offset: 0x0061CB5F
		public void UnPackTo(ICommonConfirmBoxT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602C90F RID: 182543 RVA: 0x0061E97C File Offset: 0x0061CB7C
		public static Offset<ICommonConfirmBox> Pack(FlatBufferBuilder builder, ICommonConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonConfirmBox>);
			}
			return ICommonConfirmBox.CreateICommonConfirmBox(builder, _o.Type, _o.Id);
		}

		// Token: 0x04010A7F RID: 68223
		private Table __p;
	}
}
