using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A21 RID: 18977
	public struct ICheckFinishLoading : IFlatbufferObject
	{
		// Token: 0x1700895E RID: 35166
		// (get) Token: 0x0601DB15 RID: 121621 RVA: 0x0042D578 File Offset: 0x0042B778
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB16 RID: 121622 RVA: 0x0042D585 File Offset: 0x0042B785
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB17 RID: 121623 RVA: 0x0042D58C File Offset: 0x0042B78C
		public static ICheckFinishLoading GetRootAsICheckFinishLoading(ByteBuffer _bb)
		{
			return ICheckFinishLoading.GetRootAsICheckFinishLoading(_bb, default(ICheckFinishLoading));
		}

		// Token: 0x0601DB18 RID: 121624 RVA: 0x0042D5A8 File Offset: 0x0042B7A8
		public static ICheckFinishLoading GetRootAsICheckFinishLoading(ByteBuffer _bb, ICheckFinishLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB19 RID: 121625 RVA: 0x0042D5C5 File Offset: 0x0042B7C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB1A RID: 121626 RVA: 0x0042D5D4 File Offset: 0x0042B7D4
		public ICheckFinishLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700895F RID: 35167
		// (get) Token: 0x0601DB1B RID: 121627 RVA: 0x0042D5E4 File Offset: 0x0042B7E4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008960 RID: 35168
		// (get) Token: 0x0601DB1C RID: 121628 RVA: 0x0042D620 File Offset: 0x0042B820
		public IAllPlayerType? CheckTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IAllPlayerType?(default(IAllPlayerType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601DB1D RID: 121629 RVA: 0x0042D67D File Offset: 0x0042B87D
		public static Offset<ICheckFinishLoading> CreateICheckFinishLoading(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IAllPlayerType> CheckTargetOffset = default(Offset<IAllPlayerType>))
		{
			builder.StartTable(2);
			ICheckFinishLoading.AddCheckTarget(builder, CheckTargetOffset);
			ICheckFinishLoading.AddType(builder, Type);
			return ICheckFinishLoading.EndICheckFinishLoading(builder);
		}

		// Token: 0x0601DB1E RID: 121630 RVA: 0x0042D69A File Offset: 0x0042B89A
		public static void StartICheckFinishLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DB1F RID: 121631 RVA: 0x0042D6A3 File Offset: 0x0042B8A3
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB20 RID: 121632 RVA: 0x0042D6AE File Offset: 0x0042B8AE
		public static void AddCheckTarget(FlatBufferBuilder builder, Offset<IAllPlayerType> checkTargetOffset)
		{
			builder.AddOffset(1, checkTargetOffset.Value, 0);
		}

		// Token: 0x0601DB21 RID: 121633 RVA: 0x0042D6BE File Offset: 0x0042B8BE
		public static Offset<ICheckFinishLoading> EndICheckFinishLoading(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFinishLoading>(builder.EndTable());
		}

		// Token: 0x0601DB22 RID: 121634 RVA: 0x0042D6CC File Offset: 0x0042B8CC
		public ICheckFinishLoadingT UnPack()
		{
			ICheckFinishLoadingT checkFinishLoadingT = new ICheckFinishLoadingT();
			this.UnPackTo(checkFinishLoadingT);
			return checkFinishLoadingT;
		}

		// Token: 0x0601DB23 RID: 121635 RVA: 0x0042D6E8 File Offset: 0x0042B8E8
		public void UnPackTo(ICheckFinishLoadingT _o)
		{
			_o.Type = this.Type;
			_o.CheckTarget = ((this.CheckTarget != null) ? this.CheckTarget.Value.UnPack() : null);
		}

		// Token: 0x0601DB24 RID: 121636 RVA: 0x0042D730 File Offset: 0x0042B930
		public static Offset<ICheckFinishLoading> Pack(FlatBufferBuilder builder, ICheckFinishLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFinishLoading>);
			}
			Offset<IAllPlayerType> checkTargetOffset = (_o.CheckTarget == null) ? default(Offset<IAllPlayerType>) : IAllPlayerType.Pack(builder, _o.CheckTarget);
			return ICheckFinishLoading.CreateICheckFinishLoading(builder, _o.Type, checkTargetOffset);
		}

		// Token: 0x0400D272 RID: 53874
		private Table __p;
	}
}
