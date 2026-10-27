using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004295 RID: 17045
	public struct IWarningPreformType : IFlatbufferObject
	{
		// Token: 0x17007908 RID: 30984
		// (get) Token: 0x06019415 RID: 103445 RVA: 0x003A0B59 File Offset: 0x0039ED59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019416 RID: 103446 RVA: 0x003A0B66 File Offset: 0x0039ED66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019417 RID: 103447 RVA: 0x003A0B70 File Offset: 0x0039ED70
		public static IWarningPreformType GetRootAsIWarningPreformType(ByteBuffer _bb)
		{
			return IWarningPreformType.GetRootAsIWarningPreformType(_bb, default(IWarningPreformType));
		}

		// Token: 0x06019418 RID: 103448 RVA: 0x003A0B8C File Offset: 0x0039ED8C
		public static IWarningPreformType GetRootAsIWarningPreformType(ByteBuffer _bb, IWarningPreformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019419 RID: 103449 RVA: 0x003A0BA9 File Offset: 0x0039EDA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601941A RID: 103450 RVA: 0x003A0BB8 File Offset: 0x0039EDB8
		public IWarningPreformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007909 RID: 30985
		// (get) Token: 0x0601941B RID: 103451 RVA: 0x003A0BC8 File Offset: 0x0039EDC8
		public EWarningPreformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return (EWarningPreformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601941C RID: 103452 RVA: 0x003A0C04 File Offset: 0x0039EE04
		public static Offset<IWarningPreformType> CreateIWarningPreformType(FlatBufferBuilder builder, EWarningPreformType Type = EWarningPreformType.FadeInScreen)
		{
			builder.StartTable(1);
			IWarningPreformType.AddType(builder, Type);
			return IWarningPreformType.EndIWarningPreformType(builder);
		}

		// Token: 0x0601941D RID: 103453 RVA: 0x003A0C1A File Offset: 0x0039EE1A
		public static void StartIWarningPreformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601941E RID: 103454 RVA: 0x003A0C23 File Offset: 0x0039EE23
		public static void AddType(FlatBufferBuilder builder, EWarningPreformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601941F RID: 103455 RVA: 0x003A0C2E File Offset: 0x0039EE2E
		public static Offset<IWarningPreformType> EndIWarningPreformType(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreformType>(builder.EndTable());
		}

		// Token: 0x06019420 RID: 103456 RVA: 0x003A0C3C File Offset: 0x0039EE3C
		public IWarningPreformTypeT UnPack()
		{
			IWarningPreformTypeT warningPreformTypeT = new IWarningPreformTypeT();
			this.UnPackTo(warningPreformTypeT);
			return warningPreformTypeT;
		}

		// Token: 0x06019421 RID: 103457 RVA: 0x003A0C57 File Offset: 0x0039EE57
		public void UnPackTo(IWarningPreformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019422 RID: 103458 RVA: 0x003A0C68 File Offset: 0x0039EE68
		public static Offset<IWarningPreformType> Pack(FlatBufferBuilder builder, IWarningPreformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreformType>);
			}
			return IWarningPreformType.CreateIWarningPreformType(builder, _o.Type);
		}

		// Token: 0x0400BF34 RID: 48948
		private Table __p;
	}
}
