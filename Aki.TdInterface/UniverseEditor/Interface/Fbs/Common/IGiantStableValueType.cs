using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DDC RID: 24028
	public struct IGiantStableValueType : IFlatbufferObject
	{
		// Token: 0x1700B3E0 RID: 46048
		// (get) Token: 0x0602920C RID: 168460 RVA: 0x005A4FC4 File Offset: 0x005A31C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602920D RID: 168461 RVA: 0x005A4FD1 File Offset: 0x005A31D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602920E RID: 168462 RVA: 0x005A4FD8 File Offset: 0x005A31D8
		public static IGiantStableValueType GetRootAsIGiantStableValueType(ByteBuffer _bb)
		{
			return IGiantStableValueType.GetRootAsIGiantStableValueType(_bb, default(IGiantStableValueType));
		}

		// Token: 0x0602920F RID: 168463 RVA: 0x005A4FF4 File Offset: 0x005A31F4
		public static IGiantStableValueType GetRootAsIGiantStableValueType(ByteBuffer _bb, IGiantStableValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029210 RID: 168464 RVA: 0x005A5011 File Offset: 0x005A3211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029211 RID: 168465 RVA: 0x005A5020 File Offset: 0x005A3220
		public IGiantStableValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3E1 RID: 46049
		// (get) Token: 0x06029212 RID: 168466 RVA: 0x005A5030 File Offset: 0x005A3230
		public EGiantStableValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueType.Region;
				}
				return (EGiantStableValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029213 RID: 168467 RVA: 0x005A506C File Offset: 0x005A326C
		public static Offset<IGiantStableValueType> CreateIGiantStableValueType(FlatBufferBuilder builder, EGiantStableValueType Type = EGiantStableValueType.Region)
		{
			builder.StartTable(1);
			IGiantStableValueType.AddType(builder, Type);
			return IGiantStableValueType.EndIGiantStableValueType(builder);
		}

		// Token: 0x06029214 RID: 168468 RVA: 0x005A5082 File Offset: 0x005A3282
		public static void StartIGiantStableValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029215 RID: 168469 RVA: 0x005A508B File Offset: 0x005A328B
		public static void AddType(FlatBufferBuilder builder, EGiantStableValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029216 RID: 168470 RVA: 0x005A5096 File Offset: 0x005A3296
		public static Offset<IGiantStableValueType> EndIGiantStableValueType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueType>(builder.EndTable());
		}

		// Token: 0x06029217 RID: 168471 RVA: 0x005A50A4 File Offset: 0x005A32A4
		public IGiantStableValueTypeT UnPack()
		{
			IGiantStableValueTypeT giantStableValueTypeT = new IGiantStableValueTypeT();
			this.UnPackTo(giantStableValueTypeT);
			return giantStableValueTypeT;
		}

		// Token: 0x06029218 RID: 168472 RVA: 0x005A50BF File Offset: 0x005A32BF
		public void UnPackTo(IGiantStableValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029219 RID: 168473 RVA: 0x005A50D0 File Offset: 0x005A32D0
		public static Offset<IGiantStableValueType> Pack(FlatBufferBuilder builder, IGiantStableValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueType>);
			}
			return IGiantStableValueType.CreateIGiantStableValueType(builder, _o.Type);
		}

		// Token: 0x0400F7C3 RID: 63427
		private Table __p;
	}
}
