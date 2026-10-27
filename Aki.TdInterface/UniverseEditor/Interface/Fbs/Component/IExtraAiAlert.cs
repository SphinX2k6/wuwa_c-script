using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005210 RID: 21008
	public struct IExtraAiAlert : IFlatbufferObject
	{
		// Token: 0x170099DD RID: 39389
		// (get) Token: 0x06022226 RID: 139814 RVA: 0x004BC7AE File Offset: 0x004BA9AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022227 RID: 139815 RVA: 0x004BC7BB File Offset: 0x004BA9BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022228 RID: 139816 RVA: 0x004BC7C4 File Offset: 0x004BA9C4
		public static IExtraAiAlert GetRootAsIExtraAiAlert(ByteBuffer _bb)
		{
			return IExtraAiAlert.GetRootAsIExtraAiAlert(_bb, default(IExtraAiAlert));
		}

		// Token: 0x06022229 RID: 139817 RVA: 0x004BC7E0 File Offset: 0x004BA9E0
		public static IExtraAiAlert GetRootAsIExtraAiAlert(ByteBuffer _bb, IExtraAiAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602222A RID: 139818 RVA: 0x004BC7FD File Offset: 0x004BA9FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602222B RID: 139819 RVA: 0x004BC80C File Offset: 0x004BAA0C
		public IExtraAiAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099DE RID: 39390
		// (get) Token: 0x0602222C RID: 139820 RVA: 0x004BC81C File Offset: 0x004BAA1C
		public int MoveAlert
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170099DF RID: 39391
		// (get) Token: 0x0602222D RID: 139821 RVA: 0x004BC858 File Offset: 0x004BAA58
		public int StopAlert
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

		// Token: 0x0602222E RID: 139822 RVA: 0x004BC894 File Offset: 0x004BAA94
		public IStateAlert? SelfStateAlert(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IStateAlert?(default(IStateAlert).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099E0 RID: 39392
		// (get) Token: 0x0602222F RID: 139823 RVA: 0x004BC8F4 File Offset: 0x004BAAF4
		public int SelfStateAlertLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170099E1 RID: 39393
		// (get) Token: 0x06022230 RID: 139824 RVA: 0x004BC920 File Offset: 0x004BAB20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022231 RID: 139825 RVA: 0x004BC95D File Offset: 0x004BAB5D
		public static Offset<IExtraAiAlert> CreateIExtraAiAlert(FlatBufferBuilder builder, int MoveAlert = 0, int StopAlert = 0, VectorOffset SelfStateAlertOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExtraAiAlert.AddSelfStateAlert(builder, SelfStateAlertOffset);
			IExtraAiAlert.AddStopAlert(builder, StopAlert);
			IExtraAiAlert.AddMoveAlert(builder, MoveAlert);
			IExtraAiAlert.AddNullMask(builder, NullMask);
			return IExtraAiAlert.EndIExtraAiAlert(builder);
		}

		// Token: 0x06022232 RID: 139826 RVA: 0x004BC989 File Offset: 0x004BAB89
		public static void StartIExtraAiAlert(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022233 RID: 139827 RVA: 0x004BC992 File Offset: 0x004BAB92
		public static void AddMoveAlert(FlatBufferBuilder builder, int moveAlert)
		{
			builder.AddInt(0, moveAlert, 0);
		}

		// Token: 0x06022234 RID: 139828 RVA: 0x004BC99D File Offset: 0x004BAB9D
		public static void AddStopAlert(FlatBufferBuilder builder, int stopAlert)
		{
			builder.AddInt(1, stopAlert, 0);
		}

		// Token: 0x06022235 RID: 139829 RVA: 0x004BC9A8 File Offset: 0x004BABA8
		public static void AddSelfStateAlert(FlatBufferBuilder builder, VectorOffset selfStateAlertOffset)
		{
			builder.AddOffset(2, selfStateAlertOffset.Value, 0);
		}

		// Token: 0x06022236 RID: 139830 RVA: 0x004BC9B8 File Offset: 0x004BABB8
		public static VectorOffset CreateSelfStateAlertVector(FlatBufferBuilder builder, Offset<IStateAlert>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022237 RID: 139831 RVA: 0x004BC9F8 File Offset: 0x004BABF8
		public static VectorOffset CreateSelfStateAlertVectorBlock(FlatBufferBuilder builder, Offset<IStateAlert>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateAlert>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022238 RID: 139832 RVA: 0x004BCA12 File Offset: 0x004BAC12
		public static VectorOffset CreateSelfStateAlertVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateAlert>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateAlert>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022239 RID: 139833 RVA: 0x004BCA30 File Offset: 0x004BAC30
		public static VectorOffset CreateSelfStateAlertVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateAlert>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602223A RID: 139834 RVA: 0x004BCA49 File Offset: 0x004BAC49
		public static void StartSelfStateAlertVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602223B RID: 139835 RVA: 0x004BCA54 File Offset: 0x004BAC54
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602223C RID: 139836 RVA: 0x004BCA5F File Offset: 0x004BAC5F
		public static Offset<IExtraAiAlert> EndIExtraAiAlert(FlatBufferBuilder builder)
		{
			return new Offset<IExtraAiAlert>(builder.EndTable());
		}

		// Token: 0x0602223D RID: 139837 RVA: 0x004BCA6C File Offset: 0x004BAC6C
		public IExtraAiAlertT UnPack()
		{
			IExtraAiAlertT extraAiAlertT = new IExtraAiAlertT();
			this.UnPackTo(extraAiAlertT);
			return extraAiAlertT;
		}

		// Token: 0x0602223E RID: 139838 RVA: 0x004BCA88 File Offset: 0x004BAC88
		public void UnPackTo(IExtraAiAlertT _o)
		{
			_o.MoveAlert = this.MoveAlert;
			_o.StopAlert = this.StopAlert;
			_o.SelfStateAlert = new List<IStateAlertT>();
			for (int i = 0; i < this.SelfStateAlertLength; i++)
			{
				_o.SelfStateAlert.Add((this.SelfStateAlert(i) != null) ? this.SelfStateAlert(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602223F RID: 139839 RVA: 0x004BCB0C File Offset: 0x004BAD0C
		public static Offset<IExtraAiAlert> Pack(FlatBufferBuilder builder, IExtraAiAlertT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExtraAiAlert>);
			}
			VectorOffset selfStateAlertOffset = default(VectorOffset);
			if (_o.SelfStateAlert != null)
			{
				Offset<IStateAlert>[] array = new Offset<IStateAlert>[_o.SelfStateAlert.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IStateAlert.Pack(builder, _o.SelfStateAlert[i]);
				}
				selfStateAlertOffset = IExtraAiAlert.CreateSelfStateAlertVector(builder, array);
			}
			return IExtraAiAlert.CreateIExtraAiAlert(builder, _o.MoveAlert, _o.StopAlert, selfStateAlertOffset, _o.NullMask);
		}

		// Token: 0x0400E345 RID: 58181
		private Table __p;
	}
}
