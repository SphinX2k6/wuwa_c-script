using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005778 RID: 22392
	public struct IExtraAiAlert : IFlatbufferObject
	{
		// Token: 0x1700A1D9 RID: 41433
		// (get) Token: 0x060241BC RID: 147900 RVA: 0x004F7272 File Offset: 0x004F5472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060241BD RID: 147901 RVA: 0x004F727F File Offset: 0x004F547F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060241BE RID: 147902 RVA: 0x004F7288 File Offset: 0x004F5488
		public static IExtraAiAlert GetRootAsIExtraAiAlert(ByteBuffer _bb)
		{
			return IExtraAiAlert.GetRootAsIExtraAiAlert(_bb, default(IExtraAiAlert));
		}

		// Token: 0x060241BF RID: 147903 RVA: 0x004F72A4 File Offset: 0x004F54A4
		public static IExtraAiAlert GetRootAsIExtraAiAlert(ByteBuffer _bb, IExtraAiAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241C0 RID: 147904 RVA: 0x004F72C1 File Offset: 0x004F54C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241C1 RID: 147905 RVA: 0x004F72D0 File Offset: 0x004F54D0
		public IExtraAiAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1DA RID: 41434
		// (get) Token: 0x060241C2 RID: 147906 RVA: 0x004F72E0 File Offset: 0x004F54E0
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

		// Token: 0x1700A1DB RID: 41435
		// (get) Token: 0x060241C3 RID: 147907 RVA: 0x004F731C File Offset: 0x004F551C
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

		// Token: 0x060241C4 RID: 147908 RVA: 0x004F7358 File Offset: 0x004F5558
		public IStateAlert? SelfStateAlert(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IStateAlert?(default(IStateAlert).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1DC RID: 41436
		// (get) Token: 0x060241C5 RID: 147909 RVA: 0x004F73B8 File Offset: 0x004F55B8
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

		// Token: 0x1700A1DD RID: 41437
		// (get) Token: 0x060241C6 RID: 147910 RVA: 0x004F73E4 File Offset: 0x004F55E4
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

		// Token: 0x060241C7 RID: 147911 RVA: 0x004F7421 File Offset: 0x004F5621
		public static Offset<IExtraAiAlert> CreateIExtraAiAlert(FlatBufferBuilder builder, int MoveAlert = 0, int StopAlert = 0, VectorOffset SelfStateAlertOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExtraAiAlert.AddSelfStateAlert(builder, SelfStateAlertOffset);
			IExtraAiAlert.AddStopAlert(builder, StopAlert);
			IExtraAiAlert.AddMoveAlert(builder, MoveAlert);
			IExtraAiAlert.AddNullMask(builder, NullMask);
			return IExtraAiAlert.EndIExtraAiAlert(builder);
		}

		// Token: 0x060241C8 RID: 147912 RVA: 0x004F744D File Offset: 0x004F564D
		public static void StartIExtraAiAlert(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060241C9 RID: 147913 RVA: 0x004F7456 File Offset: 0x004F5656
		public static void AddMoveAlert(FlatBufferBuilder builder, int moveAlert)
		{
			builder.AddInt(0, moveAlert, 0);
		}

		// Token: 0x060241CA RID: 147914 RVA: 0x004F7461 File Offset: 0x004F5661
		public static void AddStopAlert(FlatBufferBuilder builder, int stopAlert)
		{
			builder.AddInt(1, stopAlert, 0);
		}

		// Token: 0x060241CB RID: 147915 RVA: 0x004F746C File Offset: 0x004F566C
		public static void AddSelfStateAlert(FlatBufferBuilder builder, VectorOffset selfStateAlertOffset)
		{
			builder.AddOffset(2, selfStateAlertOffset.Value, 0);
		}

		// Token: 0x060241CC RID: 147916 RVA: 0x004F747C File Offset: 0x004F567C
		public static VectorOffset CreateSelfStateAlertVector(FlatBufferBuilder builder, Offset<IStateAlert>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060241CD RID: 147917 RVA: 0x004F74BC File Offset: 0x004F56BC
		public static VectorOffset CreateSelfStateAlertVectorBlock(FlatBufferBuilder builder, Offset<IStateAlert>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateAlert>>(data);
			return builder.EndVector();
		}

		// Token: 0x060241CE RID: 147918 RVA: 0x004F74D6 File Offset: 0x004F56D6
		public static VectorOffset CreateSelfStateAlertVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateAlert>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateAlert>>(data);
			return builder.EndVector();
		}

		// Token: 0x060241CF RID: 147919 RVA: 0x004F74F4 File Offset: 0x004F56F4
		public static VectorOffset CreateSelfStateAlertVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateAlert>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060241D0 RID: 147920 RVA: 0x004F750D File Offset: 0x004F570D
		public static void StartSelfStateAlertVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060241D1 RID: 147921 RVA: 0x004F7518 File Offset: 0x004F5718
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060241D2 RID: 147922 RVA: 0x004F7523 File Offset: 0x004F5723
		public static Offset<IExtraAiAlert> EndIExtraAiAlert(FlatBufferBuilder builder)
		{
			return new Offset<IExtraAiAlert>(builder.EndTable());
		}

		// Token: 0x060241D3 RID: 147923 RVA: 0x004F7530 File Offset: 0x004F5730
		public IExtraAiAlertT UnPack()
		{
			IExtraAiAlertT extraAiAlertT = new IExtraAiAlertT();
			this.UnPackTo(extraAiAlertT);
			return extraAiAlertT;
		}

		// Token: 0x060241D4 RID: 147924 RVA: 0x004F754C File Offset: 0x004F574C
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

		// Token: 0x060241D5 RID: 147925 RVA: 0x004F75D0 File Offset: 0x004F57D0
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

		// Token: 0x0400EF4B RID: 61259
		private Table __p;
	}
}
