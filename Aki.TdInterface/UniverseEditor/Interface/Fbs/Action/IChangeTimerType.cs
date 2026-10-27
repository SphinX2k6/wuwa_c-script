using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200632F RID: 25391
	public struct IChangeTimerType : IFlatbufferObject
	{
		// Token: 0x1700BD86 RID: 48518
		// (get) Token: 0x0602BEC0 RID: 179904 RVA: 0x00609AFC File Offset: 0x00607CFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEC1 RID: 179905 RVA: 0x00609B09 File Offset: 0x00607D09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BEC2 RID: 179906 RVA: 0x00609B10 File Offset: 0x00607D10
		public static IChangeTimerType GetRootAsIChangeTimerType(ByteBuffer _bb)
		{
			return IChangeTimerType.GetRootAsIChangeTimerType(_bb, default(IChangeTimerType));
		}

		// Token: 0x0602BEC3 RID: 179907 RVA: 0x00609B2C File Offset: 0x00607D2C
		public static IChangeTimerType GetRootAsIChangeTimerType(ByteBuffer _bb, IChangeTimerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BEC4 RID: 179908 RVA: 0x00609B49 File Offset: 0x00607D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BEC5 RID: 179909 RVA: 0x00609B58 File Offset: 0x00607D58
		public IChangeTimerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD87 RID: 48519
		// (get) Token: 0x0602BEC6 RID: 179910 RVA: 0x00609B68 File Offset: 0x00607D68
		public EChangeTimerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeTimerType.Add;
				}
				return (EChangeTimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BEC7 RID: 179911 RVA: 0x00609BA4 File Offset: 0x00607DA4
		public static Offset<IChangeTimerType> CreateIChangeTimerType(FlatBufferBuilder builder, EChangeTimerType Type = EChangeTimerType.Add)
		{
			builder.StartTable(1);
			IChangeTimerType.AddType(builder, Type);
			return IChangeTimerType.EndIChangeTimerType(builder);
		}

		// Token: 0x0602BEC8 RID: 179912 RVA: 0x00609BBA File Offset: 0x00607DBA
		public static void StartIChangeTimerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BEC9 RID: 179913 RVA: 0x00609BC3 File Offset: 0x00607DC3
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BECA RID: 179914 RVA: 0x00609BCE File Offset: 0x00607DCE
		public static Offset<IChangeTimerType> EndIChangeTimerType(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTimerType>(builder.EndTable());
		}

		// Token: 0x0602BECB RID: 179915 RVA: 0x00609BDC File Offset: 0x00607DDC
		public IChangeTimerTypeT UnPack()
		{
			IChangeTimerTypeT changeTimerTypeT = new IChangeTimerTypeT();
			this.UnPackTo(changeTimerTypeT);
			return changeTimerTypeT;
		}

		// Token: 0x0602BECC RID: 179916 RVA: 0x00609BF7 File Offset: 0x00607DF7
		public void UnPackTo(IChangeTimerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BECD RID: 179917 RVA: 0x00609C08 File Offset: 0x00607E08
		public static Offset<IChangeTimerType> Pack(FlatBufferBuilder builder, IChangeTimerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTimerType>);
			}
			return IChangeTimerType.CreateIChangeTimerType(builder, _o.Type);
		}

		// Token: 0x040108F2 RID: 67826
		private Table __p;
	}
}
