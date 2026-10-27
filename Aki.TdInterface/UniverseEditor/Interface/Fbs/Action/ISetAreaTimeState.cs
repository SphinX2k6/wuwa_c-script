using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAB RID: 28587
	public struct ISetAreaTimeState : IFlatbufferObject
	{
		// Token: 0x1700D44A RID: 54346
		// (get) Token: 0x0603285B RID: 206939 RVA: 0x006D1811 File Offset: 0x006CFA11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603285C RID: 206940 RVA: 0x006D181E File Offset: 0x006CFA1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603285D RID: 206941 RVA: 0x006D1828 File Offset: 0x006CFA28
		public static ISetAreaTimeState GetRootAsISetAreaTimeState(ByteBuffer _bb)
		{
			return ISetAreaTimeState.GetRootAsISetAreaTimeState(_bb, default(ISetAreaTimeState));
		}

		// Token: 0x0603285E RID: 206942 RVA: 0x006D1844 File Offset: 0x006CFA44
		public static ISetAreaTimeState GetRootAsISetAreaTimeState(ByteBuffer _bb, ISetAreaTimeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603285F RID: 206943 RVA: 0x006D1861 File Offset: 0x006CFA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032860 RID: 206944 RVA: 0x006D1870 File Offset: 0x006CFA70
		public ISetAreaTimeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D44B RID: 54347
		// (get) Token: 0x06032861 RID: 206945 RVA: 0x006D1880 File Offset: 0x006CFA80
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

		// Token: 0x06032862 RID: 206946 RVA: 0x006D18BC File Offset: 0x006CFABC
		public TTable? SetAreaTimeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032863 RID: 206947 RVA: 0x006D1900 File Offset: 0x006CFB00
		public ISetAreaTimeLock SetAreaTimeConfigAsISetAreaTimeLock()
		{
			return this.SetAreaTimeConfig<ISetAreaTimeLock>().Value;
		}

		// Token: 0x06032864 RID: 206948 RVA: 0x006D191C File Offset: 0x006CFB1C
		public ISetAreaTimeUnLock SetAreaTimeConfigAsISetAreaTimeUnLock()
		{
			return this.SetAreaTimeConfig<ISetAreaTimeUnLock>().Value;
		}

		// Token: 0x06032865 RID: 206949 RVA: 0x006D1937 File Offset: 0x006CFB37
		public static Offset<ISetAreaTimeState> CreateISetAreaTimeState(FlatBufferBuilder builder, TSetAreaTimeType SetAreaTimeConfig_type = TSetAreaTimeType.NONE, int SetAreaTimeConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetAreaTimeState.AddSetAreaTimeConfig(builder, SetAreaTimeConfigOffset);
			ISetAreaTimeState.AddSetAreaTimeConfigType(builder, SetAreaTimeConfig_type);
			return ISetAreaTimeState.EndISetAreaTimeState(builder);
		}

		// Token: 0x06032866 RID: 206950 RVA: 0x006D1954 File Offset: 0x006CFB54
		public static void StartISetAreaTimeState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032867 RID: 206951 RVA: 0x006D195D File Offset: 0x006CFB5D
		public static void AddSetAreaTimeConfigType(FlatBufferBuilder builder, TSetAreaTimeType setAreaTimeConfigType)
		{
			builder.AddByte(0, (byte)setAreaTimeConfigType, 0);
		}

		// Token: 0x06032868 RID: 206952 RVA: 0x006D1968 File Offset: 0x006CFB68
		public static void AddSetAreaTimeConfig(FlatBufferBuilder builder, int setAreaTimeConfigOffset)
		{
			builder.AddOffset(1, setAreaTimeConfigOffset, 0);
		}

		// Token: 0x06032869 RID: 206953 RVA: 0x006D1973 File Offset: 0x006CFB73
		public static Offset<ISetAreaTimeState> EndISetAreaTimeState(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeState>(builder.EndTable());
		}

		// Token: 0x0603286A RID: 206954 RVA: 0x006D1980 File Offset: 0x006CFB80
		public ISetAreaTimeStateT UnPack()
		{
			ISetAreaTimeStateT setAreaTimeStateT = new ISetAreaTimeStateT();
			this.UnPackTo(setAreaTimeStateT);
			return setAreaTimeStateT;
		}

		// Token: 0x0603286B RID: 206955 RVA: 0x006D199C File Offset: 0x006CFB9C
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

		// Token: 0x0603286C RID: 206956 RVA: 0x006D1A40 File Offset: 0x006CFC40
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

		// Token: 0x040119B3 RID: 72115
		private Table __p;
	}
}
