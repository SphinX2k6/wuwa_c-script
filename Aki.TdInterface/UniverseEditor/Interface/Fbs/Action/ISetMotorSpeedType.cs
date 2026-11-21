using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EE RID: 30702
	public struct ISetMotorSpeedType : IFlatbufferObject
	{
		// Token: 0x1700E10B RID: 57611
		// (get) Token: 0x06035EFF RID: 220927 RVA: 0x00739C7A File Offset: 0x00737E7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F00 RID: 220928 RVA: 0x00739C87 File Offset: 0x00737E87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F01 RID: 220929 RVA: 0x00739C90 File Offset: 0x00737E90
		public static ISetMotorSpeedType GetRootAsISetMotorSpeedType(ByteBuffer _bb)
		{
			return ISetMotorSpeedType.GetRootAsISetMotorSpeedType(_bb, default(ISetMotorSpeedType));
		}

		// Token: 0x06035F02 RID: 220930 RVA: 0x00739CAC File Offset: 0x00737EAC
		public static ISetMotorSpeedType GetRootAsISetMotorSpeedType(ByteBuffer _bb, ISetMotorSpeedType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F03 RID: 220931 RVA: 0x00739CC9 File Offset: 0x00737EC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F04 RID: 220932 RVA: 0x00739CD8 File Offset: 0x00737ED8
		public ISetMotorSpeedType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E10C RID: 57612
		// (get) Token: 0x06035F05 RID: 220933 RVA: 0x00739CE8 File Offset: 0x00737EE8
		public EMotorSpeedType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorSpeedType.TargetSpeed;
				}
				return (EMotorSpeedType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F06 RID: 220934 RVA: 0x00739D24 File Offset: 0x00737F24
		public static Offset<ISetMotorSpeedType> CreateISetMotorSpeedType(FlatBufferBuilder builder, EMotorSpeedType Type = EMotorSpeedType.TargetSpeed)
		{
			builder.StartTable(1);
			ISetMotorSpeedType.AddType(builder, Type);
			return ISetMotorSpeedType.EndISetMotorSpeedType(builder);
		}

		// Token: 0x06035F07 RID: 220935 RVA: 0x00739D3A File Offset: 0x00737F3A
		public static void StartISetMotorSpeedType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035F08 RID: 220936 RVA: 0x00739D43 File Offset: 0x00737F43
		public static void AddType(FlatBufferBuilder builder, EMotorSpeedType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035F09 RID: 220937 RVA: 0x00739D4E File Offset: 0x00737F4E
		public static Offset<ISetMotorSpeedType> EndISetMotorSpeedType(FlatBufferBuilder builder)
		{
			return new Offset<ISetMotorSpeedType>(builder.EndTable());
		}

		// Token: 0x06035F0A RID: 220938 RVA: 0x00739D5C File Offset: 0x00737F5C
		public ISetMotorSpeedTypeT UnPack()
		{
			ISetMotorSpeedTypeT setMotorSpeedTypeT = new ISetMotorSpeedTypeT();
			this.UnPackTo(setMotorSpeedTypeT);
			return setMotorSpeedTypeT;
		}

		// Token: 0x06035F0B RID: 220939 RVA: 0x00739D77 File Offset: 0x00737F77
		public void UnPackTo(ISetMotorSpeedTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035F0C RID: 220940 RVA: 0x00739D88 File Offset: 0x00737F88
		public static Offset<ISetMotorSpeedType> Pack(FlatBufferBuilder builder, ISetMotorSpeedTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMotorSpeedType>);
			}
			return ISetMotorSpeedType.CreateISetMotorSpeedType(builder, _o.Type);
		}

		// Token: 0x04012A38 RID: 76344
		private Table __p;
	}
}
