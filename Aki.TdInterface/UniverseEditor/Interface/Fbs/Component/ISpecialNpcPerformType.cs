using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F7E RID: 24446
	public struct ISpecialNpcPerformType : IFlatbufferObject
	{
		// Token: 0x1700B508 RID: 46344
		// (get) Token: 0x0602918B RID: 168331 RVA: 0x0059CC2E File Offset: 0x0059AE2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602918C RID: 168332 RVA: 0x0059CC3B File Offset: 0x0059AE3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602918D RID: 168333 RVA: 0x0059CC44 File Offset: 0x0059AE44
		public static ISpecialNpcPerformType GetRootAsISpecialNpcPerformType(ByteBuffer _bb)
		{
			return ISpecialNpcPerformType.GetRootAsISpecialNpcPerformType(_bb, default(ISpecialNpcPerformType));
		}

		// Token: 0x0602918E RID: 168334 RVA: 0x0059CC60 File Offset: 0x0059AE60
		public static ISpecialNpcPerformType GetRootAsISpecialNpcPerformType(ByteBuffer _bb, ISpecialNpcPerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602918F RID: 168335 RVA: 0x0059CC7D File Offset: 0x0059AE7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029190 RID: 168336 RVA: 0x0059CC8C File Offset: 0x0059AE8C
		public ISpecialNpcPerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B509 RID: 46345
		// (get) Token: 0x06029191 RID: 168337 RVA: 0x0059CC9C File Offset: 0x0059AE9C
		public ESpecialNpcType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcType.BaseRoleNpc;
				}
				return (ESpecialNpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029192 RID: 168338 RVA: 0x0059CCD8 File Offset: 0x0059AED8
		public static Offset<ISpecialNpcPerformType> CreateISpecialNpcPerformType(FlatBufferBuilder builder, ESpecialNpcType Type = ESpecialNpcType.BaseRoleNpc)
		{
			builder.StartTable(1);
			ISpecialNpcPerformType.AddType(builder, Type);
			return ISpecialNpcPerformType.EndISpecialNpcPerformType(builder);
		}

		// Token: 0x06029193 RID: 168339 RVA: 0x0059CCEE File Offset: 0x0059AEEE
		public static void StartISpecialNpcPerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029194 RID: 168340 RVA: 0x0059CCF7 File Offset: 0x0059AEF7
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029195 RID: 168341 RVA: 0x0059CD02 File Offset: 0x0059AF02
		public static Offset<ISpecialNpcPerformType> EndISpecialNpcPerformType(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialNpcPerformType>(builder.EndTable());
		}

		// Token: 0x06029196 RID: 168342 RVA: 0x0059CD10 File Offset: 0x0059AF10
		public ISpecialNpcPerformTypeT UnPack()
		{
			ISpecialNpcPerformTypeT specialNpcPerformTypeT = new ISpecialNpcPerformTypeT();
			this.UnPackTo(specialNpcPerformTypeT);
			return specialNpcPerformTypeT;
		}

		// Token: 0x06029197 RID: 168343 RVA: 0x0059CD2B File Offset: 0x0059AF2B
		public void UnPackTo(ISpecialNpcPerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029198 RID: 168344 RVA: 0x0059CD3C File Offset: 0x0059AF3C
		public static Offset<ISpecialNpcPerformType> Pack(FlatBufferBuilder builder, ISpecialNpcPerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialNpcPerformType>);
			}
			return ISpecialNpcPerformType.CreateISpecialNpcPerformType(builder, _o.Type);
		}

		// Token: 0x0400FC52 RID: 64594
		private Table __p;
	}
}
