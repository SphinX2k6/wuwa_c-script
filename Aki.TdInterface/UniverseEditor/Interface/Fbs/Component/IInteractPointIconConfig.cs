using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059ED RID: 23021
	public struct IInteractPointIconConfig : IFlatbufferObject
	{
		// Token: 0x1700A74C RID: 42828
		// (get) Token: 0x0602596D RID: 153965 RVA: 0x00527A24 File Offset: 0x00525C24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602596E RID: 153966 RVA: 0x00527A31 File Offset: 0x00525C31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602596F RID: 153967 RVA: 0x00527A38 File Offset: 0x00525C38
		public static IInteractPointIconConfig GetRootAsIInteractPointIconConfig(ByteBuffer _bb)
		{
			return IInteractPointIconConfig.GetRootAsIInteractPointIconConfig(_bb, default(IInteractPointIconConfig));
		}

		// Token: 0x06025970 RID: 153968 RVA: 0x00527A54 File Offset: 0x00525C54
		public static IInteractPointIconConfig GetRootAsIInteractPointIconConfig(ByteBuffer _bb, IInteractPointIconConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025971 RID: 153969 RVA: 0x00527A71 File Offset: 0x00525C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025972 RID: 153970 RVA: 0x00527A80 File Offset: 0x00525C80
		public IInteractPointIconConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A74D RID: 42829
		// (get) Token: 0x06025973 RID: 153971 RVA: 0x00527A90 File Offset: 0x00525C90
		public float MaxShowDistance
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A74E RID: 42830
		// (get) Token: 0x06025974 RID: 153972 RVA: 0x00527AD0 File Offset: 0x00525CD0
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025975 RID: 153973 RVA: 0x00527B2D File Offset: 0x00525D2D
		public static Offset<IInteractPointIconConfig> CreateIInteractPointIconConfig(FlatBufferBuilder builder, float MaxShowDistance = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IInteractPointIconConfig.AddOffset(builder, OffsetOffset);
			IInteractPointIconConfig.AddMaxShowDistance(builder, MaxShowDistance);
			return IInteractPointIconConfig.EndIInteractPointIconConfig(builder);
		}

		// Token: 0x06025976 RID: 153974 RVA: 0x00527B4A File Offset: 0x00525D4A
		public static void StartIInteractPointIconConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025977 RID: 153975 RVA: 0x00527B53 File Offset: 0x00525D53
		public static void AddMaxShowDistance(FlatBufferBuilder builder, float maxShowDistance)
		{
			builder.AddFloat(0, maxShowDistance, 0.0);
		}

		// Token: 0x06025978 RID: 153976 RVA: 0x00527B66 File Offset: 0x00525D66
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x06025979 RID: 153977 RVA: 0x00527B76 File Offset: 0x00525D76
		public static Offset<IInteractPointIconConfig> EndIInteractPointIconConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPointIconConfig>(builder.EndTable());
		}

		// Token: 0x0602597A RID: 153978 RVA: 0x00527B84 File Offset: 0x00525D84
		public IInteractPointIconConfigT UnPack()
		{
			IInteractPointIconConfigT interactPointIconConfigT = new IInteractPointIconConfigT();
			this.UnPackTo(interactPointIconConfigT);
			return interactPointIconConfigT;
		}

		// Token: 0x0602597B RID: 153979 RVA: 0x00527BA0 File Offset: 0x00525DA0
		public void UnPackTo(IInteractPointIconConfigT _o)
		{
			_o.MaxShowDistance = this.MaxShowDistance;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x0602597C RID: 153980 RVA: 0x00527BE8 File Offset: 0x00525DE8
		public static Offset<IInteractPointIconConfig> Pack(FlatBufferBuilder builder, IInteractPointIconConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPointIconConfig>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IInteractPointIconConfig.CreateIInteractPointIconConfig(builder, _o.MaxShowDistance, offsetOffset);
		}

		// Token: 0x0400F314 RID: 62228
		private Table __p;
	}
}
