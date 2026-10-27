using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D0 RID: 25552
	public struct IClientModifyPlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700BE5F RID: 48735
		// (get) Token: 0x0602C331 RID: 181041 RVA: 0x006116B8 File Offset: 0x0060F8B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C332 RID: 181042 RVA: 0x006116C5 File Offset: 0x0060F8C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C333 RID: 181043 RVA: 0x006116CC File Offset: 0x0060F8CC
		public static IClientModifyPlayerTarget GetRootAsIClientModifyPlayerTarget(ByteBuffer _bb)
		{
			return IClientModifyPlayerTarget.GetRootAsIClientModifyPlayerTarget(_bb, default(IClientModifyPlayerTarget));
		}

		// Token: 0x0602C334 RID: 181044 RVA: 0x006116E8 File Offset: 0x0060F8E8
		public static IClientModifyPlayerTarget GetRootAsIClientModifyPlayerTarget(ByteBuffer _bb, IClientModifyPlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C335 RID: 181045 RVA: 0x00611705 File Offset: 0x0060F905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C336 RID: 181046 RVA: 0x00611714 File Offset: 0x0060F914
		public IClientModifyPlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE60 RID: 48736
		// (get) Token: 0x0602C337 RID: 181047 RVA: 0x00611724 File Offset: 0x0060F924
		public EClientModifyTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientModifyTargetType.Self;
				}
				return (EClientModifyTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C338 RID: 181048 RVA: 0x00611760 File Offset: 0x0060F960
		public static Offset<IClientModifyPlayerTarget> CreateIClientModifyPlayerTarget(FlatBufferBuilder builder, EClientModifyTargetType Type = EClientModifyTargetType.Self)
		{
			builder.StartTable(1);
			IClientModifyPlayerTarget.AddType(builder, Type);
			return IClientModifyPlayerTarget.EndIClientModifyPlayerTarget(builder);
		}

		// Token: 0x0602C339 RID: 181049 RVA: 0x00611776 File Offset: 0x0060F976
		public static void StartIClientModifyPlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C33A RID: 181050 RVA: 0x0061177F File Offset: 0x0060F97F
		public static void AddType(FlatBufferBuilder builder, EClientModifyTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C33B RID: 181051 RVA: 0x0061178A File Offset: 0x0060F98A
		public static Offset<IClientModifyPlayerTarget> EndIClientModifyPlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyPlayerTarget>(builder.EndTable());
		}

		// Token: 0x0602C33C RID: 181052 RVA: 0x00611798 File Offset: 0x0060F998
		public IClientModifyPlayerTargetT UnPack()
		{
			IClientModifyPlayerTargetT clientModifyPlayerTargetT = new IClientModifyPlayerTargetT();
			this.UnPackTo(clientModifyPlayerTargetT);
			return clientModifyPlayerTargetT;
		}

		// Token: 0x0602C33D RID: 181053 RVA: 0x006117B3 File Offset: 0x0060F9B3
		public void UnPackTo(IClientModifyPlayerTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C33E RID: 181054 RVA: 0x006117C4 File Offset: 0x0060F9C4
		public static Offset<IClientModifyPlayerTarget> Pack(FlatBufferBuilder builder, IClientModifyPlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyPlayerTarget>);
			}
			return IClientModifyPlayerTarget.CreateIClientModifyPlayerTarget(builder, _o.Type);
		}

		// Token: 0x040109AD RID: 68013
		private Table __p;
	}
}
