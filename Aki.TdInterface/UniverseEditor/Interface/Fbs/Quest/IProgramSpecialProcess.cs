using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB6 RID: 16310
	public struct IProgramSpecialProcess : IFlatbufferObject
	{
		// Token: 0x170071E7 RID: 29159
		// (get) Token: 0x06017518 RID: 95512 RVA: 0x0035C86C File Offset: 0x0035AA6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017519 RID: 95513 RVA: 0x0035C879 File Offset: 0x0035AA79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601751A RID: 95514 RVA: 0x0035C880 File Offset: 0x0035AA80
		public static IProgramSpecialProcess GetRootAsIProgramSpecialProcess(ByteBuffer _bb)
		{
			return IProgramSpecialProcess.GetRootAsIProgramSpecialProcess(_bb, default(IProgramSpecialProcess));
		}

		// Token: 0x0601751B RID: 95515 RVA: 0x0035C89C File Offset: 0x0035AA9C
		public static IProgramSpecialProcess GetRootAsIProgramSpecialProcess(ByteBuffer _bb, IProgramSpecialProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601751C RID: 95516 RVA: 0x0035C8B9 File Offset: 0x0035AAB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601751D RID: 95517 RVA: 0x0035C8C8 File Offset: 0x0035AAC8
		public IProgramSpecialProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071E8 RID: 29160
		// (get) Token: 0x0601751E RID: 95518 RVA: 0x0035C8D8 File Offset: 0x0035AAD8
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071E9 RID: 29161
		// (get) Token: 0x0601751F RID: 95519 RVA: 0x0035C914 File Offset: 0x0035AB14
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170071EA RID: 29162
		// (get) Token: 0x06017520 RID: 95520 RVA: 0x0035C974 File Offset: 0x0035AB74
		public ILowMemorySceneSwitch? SpecialProcess
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ILowMemorySceneSwitch?(default(ILowMemorySceneSwitch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017521 RID: 95521 RVA: 0x0035C9D1 File Offset: 0x0035ABD1
		public static Offset<IProgramSpecialProcess> CreateIProgramSpecialProcess(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<ILowMemorySceneSwitch> SpecialProcessOffset = default(Offset<ILowMemorySceneSwitch>))
		{
			builder.StartTable(3);
			IProgramSpecialProcess.AddSpecialProcess(builder, SpecialProcessOffset);
			IProgramSpecialProcess.AddPreConditions(builder, PreConditionsOffset);
			IProgramSpecialProcess.AddType(builder, Type);
			return IProgramSpecialProcess.EndIProgramSpecialProcess(builder);
		}

		// Token: 0x06017522 RID: 95522 RVA: 0x0035C9F5 File Offset: 0x0035ABF5
		public static void StartIProgramSpecialProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017523 RID: 95523 RVA: 0x0035C9FE File Offset: 0x0035ABFE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017524 RID: 95524 RVA: 0x0035CA09 File Offset: 0x0035AC09
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017525 RID: 95525 RVA: 0x0035CA19 File Offset: 0x0035AC19
		public static void AddSpecialProcess(FlatBufferBuilder builder, Offset<ILowMemorySceneSwitch> specialProcessOffset)
		{
			builder.AddOffset(2, specialProcessOffset.Value, 0);
		}

		// Token: 0x06017526 RID: 95526 RVA: 0x0035CA29 File Offset: 0x0035AC29
		public static Offset<IProgramSpecialProcess> EndIProgramSpecialProcess(FlatBufferBuilder builder)
		{
			return new Offset<IProgramSpecialProcess>(builder.EndTable());
		}

		// Token: 0x06017527 RID: 95527 RVA: 0x0035CA38 File Offset: 0x0035AC38
		public IProgramSpecialProcessT UnPack()
		{
			IProgramSpecialProcessT programSpecialProcessT = new IProgramSpecialProcessT();
			this.UnPackTo(programSpecialProcessT);
			return programSpecialProcessT;
		}

		// Token: 0x06017528 RID: 95528 RVA: 0x0035CA54 File Offset: 0x0035AC54
		public void UnPackTo(IProgramSpecialProcessT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SpecialProcess = ((this.SpecialProcess != null) ? this.SpecialProcess.Value.UnPack() : null);
		}

		// Token: 0x06017529 RID: 95529 RVA: 0x0035CACC File Offset: 0x0035ACCC
		public static Offset<IProgramSpecialProcess> Pack(FlatBufferBuilder builder, IProgramSpecialProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgramSpecialProcess>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<ILowMemorySceneSwitch> specialProcessOffset = (_o.SpecialProcess == null) ? default(Offset<ILowMemorySceneSwitch>) : ILowMemorySceneSwitch.Pack(builder, _o.SpecialProcess);
			return IProgramSpecialProcess.CreateIProgramSpecialProcess(builder, _o.Type, preConditionsOffset, specialProcessOffset);
		}

		// Token: 0x0400BA22 RID: 47650
		private Table __p;
	}
}
