using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A50 RID: 27216
	public struct IClientModifyPlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700C7F9 RID: 51193
		// (get) Token: 0x0602EB07 RID: 191239 RVA: 0x0065D541 File Offset: 0x0065B741
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB08 RID: 191240 RVA: 0x0065D54E File Offset: 0x0065B74E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB09 RID: 191241 RVA: 0x0065D558 File Offset: 0x0065B758
		public static IClientModifyPlayerTarget GetRootAsIClientModifyPlayerTarget(ByteBuffer _bb)
		{
			return IClientModifyPlayerTarget.GetRootAsIClientModifyPlayerTarget(_bb, default(IClientModifyPlayerTarget));
		}

		// Token: 0x0602EB0A RID: 191242 RVA: 0x0065D574 File Offset: 0x0065B774
		public static IClientModifyPlayerTarget GetRootAsIClientModifyPlayerTarget(ByteBuffer _bb, IClientModifyPlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB0B RID: 191243 RVA: 0x0065D591 File Offset: 0x0065B791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB0C RID: 191244 RVA: 0x0065D5A0 File Offset: 0x0065B7A0
		public IClientModifyPlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7FA RID: 51194
		// (get) Token: 0x0602EB0D RID: 191245 RVA: 0x0065D5B0 File Offset: 0x0065B7B0
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

		// Token: 0x0602EB0E RID: 191246 RVA: 0x0065D5EC File Offset: 0x0065B7EC
		public static Offset<IClientModifyPlayerTarget> CreateIClientModifyPlayerTarget(FlatBufferBuilder builder, EClientModifyTargetType Type = EClientModifyTargetType.Self)
		{
			builder.StartTable(1);
			IClientModifyPlayerTarget.AddType(builder, Type);
			return IClientModifyPlayerTarget.EndIClientModifyPlayerTarget(builder);
		}

		// Token: 0x0602EB0F RID: 191247 RVA: 0x0065D602 File Offset: 0x0065B802
		public static void StartIClientModifyPlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EB10 RID: 191248 RVA: 0x0065D60B File Offset: 0x0065B80B
		public static void AddType(FlatBufferBuilder builder, EClientModifyTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB11 RID: 191249 RVA: 0x0065D616 File Offset: 0x0065B816
		public static Offset<IClientModifyPlayerTarget> EndIClientModifyPlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyPlayerTarget>(builder.EndTable());
		}

		// Token: 0x0602EB12 RID: 191250 RVA: 0x0065D624 File Offset: 0x0065B824
		public IClientModifyPlayerTargetT UnPack()
		{
			IClientModifyPlayerTargetT clientModifyPlayerTargetT = new IClientModifyPlayerTargetT();
			this.UnPackTo(clientModifyPlayerTargetT);
			return clientModifyPlayerTargetT;
		}

		// Token: 0x0602EB13 RID: 191251 RVA: 0x0065D63F File Offset: 0x0065B83F
		public void UnPackTo(IClientModifyPlayerTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EB14 RID: 191252 RVA: 0x0065D650 File Offset: 0x0065B850
		public static Offset<IClientModifyPlayerTarget> Pack(FlatBufferBuilder builder, IClientModifyPlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyPlayerTarget>);
			}
			return IClientModifyPlayerTarget.CreateIClientModifyPlayerTarget(builder, _o.Type);
		}

		// Token: 0x040117D3 RID: 71635
		private Table __p;
	}
}
