using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007771 RID: 30577
	public struct ISetAreaTimeState : IFlatbufferObject
	{
		// Token: 0x1700E019 RID: 57369
		// (get) Token: 0x06035AAB RID: 219819 RVA: 0x007311C9 File Offset: 0x0072F3C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AAC RID: 219820 RVA: 0x007311D6 File Offset: 0x0072F3D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AAD RID: 219821 RVA: 0x007311E0 File Offset: 0x0072F3E0
		public static ISetAreaTimeState GetRootAsISetAreaTimeState(ByteBuffer _bb)
		{
			return ISetAreaTimeState.GetRootAsISetAreaTimeState(_bb, default(ISetAreaTimeState));
		}

		// Token: 0x06035AAE RID: 219822 RVA: 0x007311FC File Offset: 0x0072F3FC
		public static ISetAreaTimeState GetRootAsISetAreaTimeState(ByteBuffer _bb, ISetAreaTimeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AAF RID: 219823 RVA: 0x00731219 File Offset: 0x0072F419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AB0 RID: 219824 RVA: 0x00731228 File Offset: 0x0072F428
		public ISetAreaTimeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E01A RID: 57370
		// (get) Token: 0x06035AB1 RID: 219825 RVA: 0x00731238 File Offset: 0x0072F438
		public TSetAreaTimeType SetAreaTimeConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSetAreaTimeType.NONE;
				}
				return (TSetAreaTimeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035AB2 RID: 219826 RVA: 0x00731274 File Offset: 0x0072F474
		public TTable? SetAreaTimeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035AB3 RID: 219827 RVA: 0x007312B8 File Offset: 0x0072F4B8
		public ISetAreaTimeLock SetAreaTimeConfigAsISetAreaTimeLock()
		{
			return this.SetAreaTimeConfig<ISetAreaTimeLock>().Value;
		}

		// Token: 0x06035AB4 RID: 219828 RVA: 0x007312D4 File Offset: 0x0072F4D4
		public ISetAreaTimeUnLock SetAreaTimeConfigAsISetAreaTimeUnLock()
		{
			return this.SetAreaTimeConfig<ISetAreaTimeUnLock>().Value;
		}

		// Token: 0x06035AB5 RID: 219829 RVA: 0x007312EF File Offset: 0x0072F4EF
		public static Offset<ISetAreaTimeState> CreateISetAreaTimeState(FlatBufferBuilder builder, TSetAreaTimeType SetAreaTimeConfig_type = TSetAreaTimeType.NONE, int SetAreaTimeConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetAreaTimeState.AddSetAreaTimeConfig(builder, SetAreaTimeConfigOffset);
			ISetAreaTimeState.AddSetAreaTimeConfigType(builder, SetAreaTimeConfig_type);
			return ISetAreaTimeState.EndISetAreaTimeState(builder);
		}

		// Token: 0x06035AB6 RID: 219830 RVA: 0x0073130C File Offset: 0x0072F50C
		public static void StartISetAreaTimeState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035AB7 RID: 219831 RVA: 0x00731315 File Offset: 0x0072F515
		public static void AddSetAreaTimeConfigType(FlatBufferBuilder builder, TSetAreaTimeType setAreaTimeConfigType)
		{
			builder.AddByte(0, (byte)setAreaTimeConfigType, 0);
		}

		// Token: 0x06035AB8 RID: 219832 RVA: 0x00731320 File Offset: 0x0072F520
		public static void AddSetAreaTimeConfig(FlatBufferBuilder builder, int setAreaTimeConfigOffset)
		{
			builder.AddOffset(1, setAreaTimeConfigOffset, 0);
		}

		// Token: 0x06035AB9 RID: 219833 RVA: 0x0073132B File Offset: 0x0072F52B
		public static Offset<ISetAreaTimeState> EndISetAreaTimeState(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeState>(builder.EndTable());
		}

		// Token: 0x06035ABA RID: 219834 RVA: 0x00731338 File Offset: 0x0072F538
		public ISetAreaTimeStateT UnPack()
		{
			ISetAreaTimeStateT setAreaTimeStateT = new ISetAreaTimeStateT();
			this.UnPackTo(setAreaTimeStateT);
			return setAreaTimeStateT;
		}

		// Token: 0x06035ABB RID: 219835 RVA: 0x00731354 File Offset: 0x0072F554
		public void UnPackTo(ISetAreaTimeStateT _o)
		{
			_o.SetAreaTimeConfig = new TSetAreaTimeTypeUnion();
			_o.SetAreaTimeConfig.Type = this.SetAreaTimeConfigType;
			TSetAreaTimeType setAreaTimeConfigType = this.SetAreaTimeConfigType;
			if (setAreaTimeConfigType == TSetAreaTimeType.ISetAreaTimeLock)
			{
				_o.SetAreaTimeConfig.Value = ((this.SetAreaTimeConfig<ISetAreaTimeLock>() != null) ? this.SetAreaTimeConfig<ISetAreaTimeLock>().Value.UnPack() : null);
				return;
			}
			if (setAreaTimeConfigType != TSetAreaTimeType.ISetAreaTimeUnLock)
			{
				return;
			}
			_o.SetAreaTimeConfig.Value = ((this.SetAreaTimeConfig<ISetAreaTimeUnLock>() != null) ? this.SetAreaTimeConfig<ISetAreaTimeUnLock>().Value.UnPack() : null);
		}

		// Token: 0x06035ABC RID: 219836 RVA: 0x007313F8 File Offset: 0x0072F5F8
		public static Offset<ISetAreaTimeState> Pack(FlatBufferBuilder builder, ISetAreaTimeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaTimeState>);
			}
			TSetAreaTimeType setAreaTimeConfig_type = (_o.SetAreaTimeConfig == null) ? TSetAreaTimeType.NONE : _o.SetAreaTimeConfig.Type;
			int setAreaTimeConfigOffset = (_o.SetAreaTimeConfig == null) ? 0 : TSetAreaTimeTypeUnion.Pack(builder, _o.SetAreaTimeConfig);
			return ISetAreaTimeState.CreateISetAreaTimeState(builder, setAreaTimeConfig_type, setAreaTimeConfigOffset);
		}

		// Token: 0x04012995 RID: 76181
		private Table __p;
	}
}
