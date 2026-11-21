using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EDB RID: 20187
	public struct ICheckEntityType : IFlatbufferObject
	{
		// Token: 0x17009029 RID: 36905
		// (get) Token: 0x0601F568 RID: 128360 RVA: 0x0045DF23 File Offset: 0x0045C123
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F569 RID: 128361 RVA: 0x0045DF30 File Offset: 0x0045C130
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F56A RID: 128362 RVA: 0x0045DF38 File Offset: 0x0045C138
		public static ICheckEntityType GetRootAsICheckEntityType(ByteBuffer _bb)
		{
			return ICheckEntityType.GetRootAsICheckEntityType(_bb, default(ICheckEntityType));
		}

		// Token: 0x0601F56B RID: 128363 RVA: 0x0045DF54 File Offset: 0x0045C154
		public static ICheckEntityType GetRootAsICheckEntityType(ByteBuffer _bb, ICheckEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F56C RID: 128364 RVA: 0x0045DF71 File Offset: 0x0045C171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F56D RID: 128365 RVA: 0x0045DF80 File Offset: 0x0045C180
		public ICheckEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700902A RID: 36906
		// (get) Token: 0x0601F56E RID: 128366 RVA: 0x0045DF90 File Offset: 0x0045C190
		public ECheckEntity Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEntity.OnlinePlayer;
				}
				return (ECheckEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F56F RID: 128367 RVA: 0x0045DFCC File Offset: 0x0045C1CC
		public static Offset<ICheckEntityType> CreateICheckEntityType(FlatBufferBuilder builder, ECheckEntity Type = ECheckEntity.OnlinePlayer)
		{
			builder.StartTable(1);
			ICheckEntityType.AddType(builder, Type);
			return ICheckEntityType.EndICheckEntityType(builder);
		}

		// Token: 0x0601F570 RID: 128368 RVA: 0x0045DFE2 File Offset: 0x0045C1E2
		public static void StartICheckEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F571 RID: 128369 RVA: 0x0045DFEB File Offset: 0x0045C1EB
		public static void AddType(FlatBufferBuilder builder, ECheckEntity type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F572 RID: 128370 RVA: 0x0045DFF6 File Offset: 0x0045C1F6
		public static Offset<ICheckEntityType> EndICheckEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityType>(builder.EndTable());
		}

		// Token: 0x0601F573 RID: 128371 RVA: 0x0045E004 File Offset: 0x0045C204
		public ICheckEntityTypeT UnPack()
		{
			ICheckEntityTypeT checkEntityTypeT = new ICheckEntityTypeT();
			this.UnPackTo(checkEntityTypeT);
			return checkEntityTypeT;
		}

		// Token: 0x0601F574 RID: 128372 RVA: 0x0045E01F File Offset: 0x0045C21F
		public void UnPackTo(ICheckEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F575 RID: 128373 RVA: 0x0045E030 File Offset: 0x0045C230
		public static Offset<ICheckEntityType> Pack(FlatBufferBuilder builder, ICheckEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityType>);
			}
			return ICheckEntityType.CreateICheckEntityType(builder, _o.Type);
		}

		// Token: 0x0400DD3D RID: 56637
		private Table __p;
	}
}
