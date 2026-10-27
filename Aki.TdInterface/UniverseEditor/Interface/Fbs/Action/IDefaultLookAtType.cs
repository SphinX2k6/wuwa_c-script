using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006558 RID: 25944
	public struct IDefaultLookAtType : IFlatbufferObject
	{
		// Token: 0x1700C0D7 RID: 49367
		// (get) Token: 0x0602D03E RID: 184382 RVA: 0x0062DAAC File Offset: 0x0062BCAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D03F RID: 184383 RVA: 0x0062DAB9 File Offset: 0x0062BCB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D040 RID: 184384 RVA: 0x0062DAC0 File Offset: 0x0062BCC0
		public static IDefaultLookAtType GetRootAsIDefaultLookAtType(ByteBuffer _bb)
		{
			return IDefaultLookAtType.GetRootAsIDefaultLookAtType(_bb, default(IDefaultLookAtType));
		}

		// Token: 0x0602D041 RID: 184385 RVA: 0x0062DADC File Offset: 0x0062BCDC
		public static IDefaultLookAtType GetRootAsIDefaultLookAtType(ByteBuffer _bb, IDefaultLookAtType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D042 RID: 184386 RVA: 0x0062DAF9 File Offset: 0x0062BCF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D043 RID: 184387 RVA: 0x0062DB08 File Offset: 0x0062BD08
		public IDefaultLookAtType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0D8 RID: 49368
		// (get) Token: 0x0602D044 RID: 184388 RVA: 0x0062DB18 File Offset: 0x0062BD18
		public EDefaultLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return (EDefaultLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D045 RID: 184389 RVA: 0x0062DB54 File Offset: 0x0062BD54
		public static Offset<IDefaultLookAtType> CreateIDefaultLookAtType(FlatBufferBuilder builder, EDefaultLookAtType Type = EDefaultLookAtType.LookAtBubbleEntity)
		{
			builder.StartTable(1);
			IDefaultLookAtType.AddType(builder, Type);
			return IDefaultLookAtType.EndIDefaultLookAtType(builder);
		}

		// Token: 0x0602D046 RID: 184390 RVA: 0x0062DB6A File Offset: 0x0062BD6A
		public static void StartIDefaultLookAtType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D047 RID: 184391 RVA: 0x0062DB73 File Offset: 0x0062BD73
		public static void AddType(FlatBufferBuilder builder, EDefaultLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D048 RID: 184392 RVA: 0x0062DB7E File Offset: 0x0062BD7E
		public static Offset<IDefaultLookAtType> EndIDefaultLookAtType(FlatBufferBuilder builder)
		{
			return new Offset<IDefaultLookAtType>(builder.EndTable());
		}

		// Token: 0x0602D049 RID: 184393 RVA: 0x0062DB8C File Offset: 0x0062BD8C
		public IDefaultLookAtTypeT UnPack()
		{
			IDefaultLookAtTypeT defaultLookAtTypeT = new IDefaultLookAtTypeT();
			this.UnPackTo(defaultLookAtTypeT);
			return defaultLookAtTypeT;
		}

		// Token: 0x0602D04A RID: 184394 RVA: 0x0062DBA7 File Offset: 0x0062BDA7
		public void UnPackTo(IDefaultLookAtTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D04B RID: 184395 RVA: 0x0062DBB8 File Offset: 0x0062BDB8
		public static Offset<IDefaultLookAtType> Pack(FlatBufferBuilder builder, IDefaultLookAtTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDefaultLookAtType>);
			}
			return IDefaultLookAtType.CreateIDefaultLookAtType(builder, _o.Type);
		}

		// Token: 0x04010BA8 RID: 68520
		private Table __p;
	}
}
