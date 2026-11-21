using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC9 RID: 27593
	public struct IDefaultLookAtType : IFlatbufferObject
	{
		// Token: 0x1700CA72 RID: 51826
		// (get) Token: 0x0602F7FA RID: 194554 RVA: 0x0067A270 File Offset: 0x00678470
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7FB RID: 194555 RVA: 0x0067A27D File Offset: 0x0067847D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7FC RID: 194556 RVA: 0x0067A284 File Offset: 0x00678484
		public static IDefaultLookAtType GetRootAsIDefaultLookAtType(ByteBuffer _bb)
		{
			return IDefaultLookAtType.GetRootAsIDefaultLookAtType(_bb, default(IDefaultLookAtType));
		}

		// Token: 0x0602F7FD RID: 194557 RVA: 0x0067A2A0 File Offset: 0x006784A0
		public static IDefaultLookAtType GetRootAsIDefaultLookAtType(ByteBuffer _bb, IDefaultLookAtType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7FE RID: 194558 RVA: 0x0067A2BD File Offset: 0x006784BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7FF RID: 194559 RVA: 0x0067A2CC File Offset: 0x006784CC
		public IDefaultLookAtType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA73 RID: 51827
		// (get) Token: 0x0602F800 RID: 194560 RVA: 0x0067A2DC File Offset: 0x006784DC
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

		// Token: 0x0602F801 RID: 194561 RVA: 0x0067A318 File Offset: 0x00678518
		public static Offset<IDefaultLookAtType> CreateIDefaultLookAtType(FlatBufferBuilder builder, EDefaultLookAtType Type = EDefaultLookAtType.LookAtBubbleEntity)
		{
			builder.StartTable(1);
			IDefaultLookAtType.AddType(builder, Type);
			return IDefaultLookAtType.EndIDefaultLookAtType(builder);
		}

		// Token: 0x0602F802 RID: 194562 RVA: 0x0067A32E File Offset: 0x0067852E
		public static void StartIDefaultLookAtType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F803 RID: 194563 RVA: 0x0067A337 File Offset: 0x00678537
		public static void AddType(FlatBufferBuilder builder, EDefaultLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F804 RID: 194564 RVA: 0x0067A342 File Offset: 0x00678542
		public static Offset<IDefaultLookAtType> EndIDefaultLookAtType(FlatBufferBuilder builder)
		{
			return new Offset<IDefaultLookAtType>(builder.EndTable());
		}

		// Token: 0x0602F805 RID: 194565 RVA: 0x0067A350 File Offset: 0x00678550
		public IDefaultLookAtTypeT UnPack()
		{
			IDefaultLookAtTypeT defaultLookAtTypeT = new IDefaultLookAtTypeT();
			this.UnPackTo(defaultLookAtTypeT);
			return defaultLookAtTypeT;
		}

		// Token: 0x0602F806 RID: 194566 RVA: 0x0067A36B File Offset: 0x0067856B
		public void UnPackTo(IDefaultLookAtTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F807 RID: 194567 RVA: 0x0067A37C File Offset: 0x0067857C
		public static Offset<IDefaultLookAtType> Pack(FlatBufferBuilder builder, IDefaultLookAtTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDefaultLookAtType>);
			}
			return IDefaultLookAtType.CreateIDefaultLookAtType(builder, _o.Type);
		}

		// Token: 0x040119C6 RID: 72134
		private Table __p;
	}
}
