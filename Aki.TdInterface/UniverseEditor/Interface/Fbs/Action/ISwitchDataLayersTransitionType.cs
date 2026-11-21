using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A25 RID: 31269
	public struct ISwitchDataLayersTransitionType : IFlatbufferObject
	{
		// Token: 0x1700E51F RID: 58655
		// (get) Token: 0x06037196 RID: 225686 RVA: 0x0075CCEF File Offset: 0x0075AEEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037197 RID: 225687 RVA: 0x0075CCFC File Offset: 0x0075AEFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037198 RID: 225688 RVA: 0x0075CD04 File Offset: 0x0075AF04
		public static ISwitchDataLayersTransitionType GetRootAsISwitchDataLayersTransitionType(ByteBuffer _bb)
		{
			return ISwitchDataLayersTransitionType.GetRootAsISwitchDataLayersTransitionType(_bb, default(ISwitchDataLayersTransitionType));
		}

		// Token: 0x06037199 RID: 225689 RVA: 0x0075CD20 File Offset: 0x0075AF20
		public static ISwitchDataLayersTransitionType GetRootAsISwitchDataLayersTransitionType(ByteBuffer _bb, ISwitchDataLayersTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603719A RID: 225690 RVA: 0x0075CD3D File Offset: 0x0075AF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603719B RID: 225691 RVA: 0x0075CD4C File Offset: 0x0075AF4C
		public ISwitchDataLayersTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E520 RID: 58656
		// (get) Token: 0x0603719C RID: 225692 RVA: 0x0075CD5C File Offset: 0x0075AF5C
		public ESwitchDataLayersTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchDataLayersTransitionType.Sequence;
				}
				return (ESwitchDataLayersTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603719D RID: 225693 RVA: 0x0075CD98 File Offset: 0x0075AF98
		public static Offset<ISwitchDataLayersTransitionType> CreateISwitchDataLayersTransitionType(FlatBufferBuilder builder, ESwitchDataLayersTransitionType Type = ESwitchDataLayersTransitionType.Sequence)
		{
			builder.StartTable(1);
			ISwitchDataLayersTransitionType.AddType(builder, Type);
			return ISwitchDataLayersTransitionType.EndISwitchDataLayersTransitionType(builder);
		}

		// Token: 0x0603719E RID: 225694 RVA: 0x0075CDAE File Offset: 0x0075AFAE
		public static void StartISwitchDataLayersTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603719F RID: 225695 RVA: 0x0075CDB7 File Offset: 0x0075AFB7
		public static void AddType(FlatBufferBuilder builder, ESwitchDataLayersTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060371A0 RID: 225696 RVA: 0x0075CDC2 File Offset: 0x0075AFC2
		public static Offset<ISwitchDataLayersTransitionType> EndISwitchDataLayersTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchDataLayersTransitionType>(builder.EndTable());
		}

		// Token: 0x060371A1 RID: 225697 RVA: 0x0075CDD0 File Offset: 0x0075AFD0
		public ISwitchDataLayersTransitionTypeT UnPack()
		{
			ISwitchDataLayersTransitionTypeT switchDataLayersTransitionTypeT = new ISwitchDataLayersTransitionTypeT();
			this.UnPackTo(switchDataLayersTransitionTypeT);
			return switchDataLayersTransitionTypeT;
		}

		// Token: 0x060371A2 RID: 225698 RVA: 0x0075CDEB File Offset: 0x0075AFEB
		public void UnPackTo(ISwitchDataLayersTransitionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060371A3 RID: 225699 RVA: 0x0075CDFC File Offset: 0x0075AFFC
		public static Offset<ISwitchDataLayersTransitionType> Pack(FlatBufferBuilder builder, ISwitchDataLayersTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchDataLayersTransitionType>);
			}
			return ISwitchDataLayersTransitionType.CreateISwitchDataLayersTransitionType(builder, _o.Type);
		}

		// Token: 0x04012D46 RID: 77126
		private Table __p;
	}
}
