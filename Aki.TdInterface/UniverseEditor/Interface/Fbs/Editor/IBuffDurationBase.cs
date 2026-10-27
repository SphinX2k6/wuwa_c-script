using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004829 RID: 18473
	public struct IBuffDurationBase : IFlatbufferObject
	{
		// Token: 0x1700849A RID: 33946
		// (get) Token: 0x0601C8E1 RID: 116961 RVA: 0x00409DB8 File Offset: 0x00407FB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C8E2 RID: 116962 RVA: 0x00409DC5 File Offset: 0x00407FC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C8E3 RID: 116963 RVA: 0x00409DCC File Offset: 0x00407FCC
		public static IBuffDurationBase GetRootAsIBuffDurationBase(ByteBuffer _bb)
		{
			return IBuffDurationBase.GetRootAsIBuffDurationBase(_bb, default(IBuffDurationBase));
		}

		// Token: 0x0601C8E4 RID: 116964 RVA: 0x00409DE8 File Offset: 0x00407FE8
		public static IBuffDurationBase GetRootAsIBuffDurationBase(ByteBuffer _bb, IBuffDurationBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C8E5 RID: 116965 RVA: 0x00409E05 File Offset: 0x00408005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C8E6 RID: 116966 RVA: 0x00409E14 File Offset: 0x00408014
		public IBuffDurationBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700849B RID: 33947
		// (get) Token: 0x0601C8E7 RID: 116967 RVA: 0x00409E24 File Offset: 0x00408024
		public EBuffDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffDurationType.Instant;
				}
				return (EBuffDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C8E8 RID: 116968 RVA: 0x00409E60 File Offset: 0x00408060
		public static Offset<IBuffDurationBase> CreateIBuffDurationBase(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant)
		{
			builder.StartTable(1);
			IBuffDurationBase.AddType(builder, Type);
			return IBuffDurationBase.EndIBuffDurationBase(builder);
		}

		// Token: 0x0601C8E9 RID: 116969 RVA: 0x00409E76 File Offset: 0x00408076
		public static void StartIBuffDurationBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C8EA RID: 116970 RVA: 0x00409E7F File Offset: 0x0040807F
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C8EB RID: 116971 RVA: 0x00409E8A File Offset: 0x0040808A
		public static Offset<IBuffDurationBase> EndIBuffDurationBase(FlatBufferBuilder builder)
		{
			return new Offset<IBuffDurationBase>(builder.EndTable());
		}

		// Token: 0x0601C8EC RID: 116972 RVA: 0x00409E98 File Offset: 0x00408098
		public IBuffDurationBaseT UnPack()
		{
			IBuffDurationBaseT buffDurationBaseT = new IBuffDurationBaseT();
			this.UnPackTo(buffDurationBaseT);
			return buffDurationBaseT;
		}

		// Token: 0x0601C8ED RID: 116973 RVA: 0x00409EB3 File Offset: 0x004080B3
		public void UnPackTo(IBuffDurationBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C8EE RID: 116974 RVA: 0x00409EC4 File Offset: 0x004080C4
		public static Offset<IBuffDurationBase> Pack(FlatBufferBuilder builder, IBuffDurationBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffDurationBase>);
			}
			return IBuffDurationBase.CreateIBuffDurationBase(builder, _o.Type);
		}

		// Token: 0x0400CD52 RID: 52562
		private Table __p;
	}
}
