using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE4 RID: 20196
	public struct ICheckFinishLoading : IFlatbufferObject
	{
		// Token: 0x17009033 RID: 36915
		// (get) Token: 0x0601F59E RID: 128414 RVA: 0x0045E470 File Offset: 0x0045C670
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F59F RID: 128415 RVA: 0x0045E47D File Offset: 0x0045C67D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F5A0 RID: 128416 RVA: 0x0045E484 File Offset: 0x0045C684
		public static ICheckFinishLoading GetRootAsICheckFinishLoading(ByteBuffer _bb)
		{
			return ICheckFinishLoading.GetRootAsICheckFinishLoading(_bb, default(ICheckFinishLoading));
		}

		// Token: 0x0601F5A1 RID: 128417 RVA: 0x0045E4A0 File Offset: 0x0045C6A0
		public static ICheckFinishLoading GetRootAsICheckFinishLoading(ByteBuffer _bb, ICheckFinishLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F5A2 RID: 128418 RVA: 0x0045E4BD File Offset: 0x0045C6BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F5A3 RID: 128419 RVA: 0x0045E4CC File Offset: 0x0045C6CC
		public ICheckFinishLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009034 RID: 36916
		// (get) Token: 0x0601F5A4 RID: 128420 RVA: 0x0045E4DC File Offset: 0x0045C6DC
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

		// Token: 0x17009035 RID: 36917
		// (get) Token: 0x0601F5A5 RID: 128421 RVA: 0x0045E518 File Offset: 0x0045C718
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

		// Token: 0x0601F5A6 RID: 128422 RVA: 0x0045E575 File Offset: 0x0045C775
		public static Offset<ICheckFinishLoading> CreateICheckFinishLoading(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IAllPlayerType> CheckTargetOffset = default(Offset<IAllPlayerType>))
		{
			builder.StartTable(2);
			ICheckFinishLoading.AddCheckTarget(builder, CheckTargetOffset);
			ICheckFinishLoading.AddType(builder, Type);
			return ICheckFinishLoading.EndICheckFinishLoading(builder);
		}

		// Token: 0x0601F5A7 RID: 128423 RVA: 0x0045E592 File Offset: 0x0045C792
		public static void StartICheckFinishLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F5A8 RID: 128424 RVA: 0x0045E59B File Offset: 0x0045C79B
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F5A9 RID: 128425 RVA: 0x0045E5A6 File Offset: 0x0045C7A6
		public static void AddCheckTarget(FlatBufferBuilder builder, Offset<IAllPlayerType> checkTargetOffset)
		{
			builder.AddOffset(1, checkTargetOffset.Value, 0);
		}

		// Token: 0x0601F5AA RID: 128426 RVA: 0x0045E5B6 File Offset: 0x0045C7B6
		public static Offset<ICheckFinishLoading> EndICheckFinishLoading(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFinishLoading>(builder.EndTable());
		}

		// Token: 0x0601F5AB RID: 128427 RVA: 0x0045E5C4 File Offset: 0x0045C7C4
		public ICheckFinishLoadingT UnPack()
		{
			ICheckFinishLoadingT checkFinishLoadingT = new ICheckFinishLoadingT();
			this.UnPackTo(checkFinishLoadingT);
			return checkFinishLoadingT;
		}

		// Token: 0x0601F5AC RID: 128428 RVA: 0x0045E5E0 File Offset: 0x0045C7E0
		public void UnPackTo(ICheckFinishLoadingT _o)
		{
			_o.Type = this.Type;
			_o.CheckTarget = ((this.CheckTarget != null) ? this.CheckTarget.Value.UnPack() : null);
		}

		// Token: 0x0601F5AD RID: 128429 RVA: 0x0045E628 File Offset: 0x0045C828
		public static Offset<ICheckFinishLoading> Pack(FlatBufferBuilder builder, ICheckFinishLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFinishLoading>);
			}
			Offset<IAllPlayerType> checkTargetOffset = (_o.CheckTarget == null) ? default(Offset<IAllPlayerType>) : IAllPlayerType.Pack(builder, _o.CheckTarget);
			return ICheckFinishLoading.CreateICheckFinishLoading(builder, _o.Type, checkTargetOffset);
		}

		// Token: 0x0400DD49 RID: 56649
		private Table __p;
	}
}
