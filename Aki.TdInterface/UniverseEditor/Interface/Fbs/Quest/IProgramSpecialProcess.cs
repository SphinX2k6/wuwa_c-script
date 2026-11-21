using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F7 RID: 17399
	public struct IProgramSpecialProcess : IFlatbufferObject
	{
		// Token: 0x170077E5 RID: 30693
		// (get) Token: 0x06018BA7 RID: 101287 RVA: 0x00386484 File Offset: 0x00384684
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BA8 RID: 101288 RVA: 0x00386491 File Offset: 0x00384691
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BA9 RID: 101289 RVA: 0x00386498 File Offset: 0x00384698
		public static IProgramSpecialProcess GetRootAsIProgramSpecialProcess(ByteBuffer _bb)
		{
			return IProgramSpecialProcess.GetRootAsIProgramSpecialProcess(_bb, default(IProgramSpecialProcess));
		}

		// Token: 0x06018BAA RID: 101290 RVA: 0x003864B4 File Offset: 0x003846B4
		public static IProgramSpecialProcess GetRootAsIProgramSpecialProcess(ByteBuffer _bb, IProgramSpecialProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BAB RID: 101291 RVA: 0x003864D1 File Offset: 0x003846D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BAC RID: 101292 RVA: 0x003864E0 File Offset: 0x003846E0
		public IProgramSpecialProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077E6 RID: 30694
		// (get) Token: 0x06018BAD RID: 101293 RVA: 0x003864F0 File Offset: 0x003846F0
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

		// Token: 0x170077E7 RID: 30695
		// (get) Token: 0x06018BAE RID: 101294 RVA: 0x0038652C File Offset: 0x0038472C
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

		// Token: 0x170077E8 RID: 30696
		// (get) Token: 0x06018BAF RID: 101295 RVA: 0x0038658C File Offset: 0x0038478C
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

		// Token: 0x06018BB0 RID: 101296 RVA: 0x003865E9 File Offset: 0x003847E9
		public static Offset<IProgramSpecialProcess> CreateIProgramSpecialProcess(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<ILowMemorySceneSwitch> SpecialProcessOffset = default(Offset<ILowMemorySceneSwitch>))
		{
			builder.StartTable(3);
			IProgramSpecialProcess.AddSpecialProcess(builder, SpecialProcessOffset);
			IProgramSpecialProcess.AddPreConditions(builder, PreConditionsOffset);
			IProgramSpecialProcess.AddType(builder, Type);
			return IProgramSpecialProcess.EndIProgramSpecialProcess(builder);
		}

		// Token: 0x06018BB1 RID: 101297 RVA: 0x0038660D File Offset: 0x0038480D
		public static void StartIProgramSpecialProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018BB2 RID: 101298 RVA: 0x00386616 File Offset: 0x00384816
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018BB3 RID: 101299 RVA: 0x00386621 File Offset: 0x00384821
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018BB4 RID: 101300 RVA: 0x00386631 File Offset: 0x00384831
		public static void AddSpecialProcess(FlatBufferBuilder builder, Offset<ILowMemorySceneSwitch> specialProcessOffset)
		{
			builder.AddOffset(2, specialProcessOffset.Value, 0);
		}

		// Token: 0x06018BB5 RID: 101301 RVA: 0x00386641 File Offset: 0x00384841
		public static Offset<IProgramSpecialProcess> EndIProgramSpecialProcess(FlatBufferBuilder builder)
		{
			return new Offset<IProgramSpecialProcess>(builder.EndTable());
		}

		// Token: 0x06018BB6 RID: 101302 RVA: 0x00386650 File Offset: 0x00384850
		public IProgramSpecialProcessT UnPack()
		{
			IProgramSpecialProcessT programSpecialProcessT = new IProgramSpecialProcessT();
			this.UnPackTo(programSpecialProcessT);
			return programSpecialProcessT;
		}

		// Token: 0x06018BB7 RID: 101303 RVA: 0x0038666C File Offset: 0x0038486C
		public void UnPackTo(IProgramSpecialProcessT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SpecialProcess = ((this.SpecialProcess != null) ? this.SpecialProcess.Value.UnPack() : null);
		}

		// Token: 0x06018BB8 RID: 101304 RVA: 0x003866E4 File Offset: 0x003848E4
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

		// Token: 0x0400C407 RID: 50183
		private Table __p;
	}
}
