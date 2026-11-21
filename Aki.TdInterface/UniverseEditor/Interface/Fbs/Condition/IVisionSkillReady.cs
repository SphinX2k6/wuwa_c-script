using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005214 RID: 21012
	public struct IVisionSkillReady : IFlatbufferObject
	{
		// Token: 0x17009656 RID: 38486
		// (get) Token: 0x0602117D RID: 135549 RVA: 0x00492450 File Offset: 0x00490650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602117E RID: 135550 RVA: 0x0049245D File Offset: 0x0049065D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602117F RID: 135551 RVA: 0x00492464 File Offset: 0x00490664
		public static IVisionSkillReady GetRootAsIVisionSkillReady(ByteBuffer _bb)
		{
			return IVisionSkillReady.GetRootAsIVisionSkillReady(_bb, default(IVisionSkillReady));
		}

		// Token: 0x06021180 RID: 135552 RVA: 0x00492480 File Offset: 0x00490680
		public static IVisionSkillReady GetRootAsIVisionSkillReady(ByteBuffer _bb, IVisionSkillReady obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021181 RID: 135553 RVA: 0x0049249D File Offset: 0x0049069D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021182 RID: 135554 RVA: 0x004924AC File Offset: 0x004906AC
		public IVisionSkillReady __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009657 RID: 38487
		// (get) Token: 0x06021183 RID: 135555 RVA: 0x004924BC File Offset: 0x004906BC
		public ESkillReadyType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillReadyType.UltimateSkill;
				}
				return (ESkillReadyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021184 RID: 135556 RVA: 0x004924F8 File Offset: 0x004906F8
		public static Offset<IVisionSkillReady> CreateIVisionSkillReady(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			IVisionSkillReady.AddType(builder, Type);
			return IVisionSkillReady.EndIVisionSkillReady(builder);
		}

		// Token: 0x06021185 RID: 135557 RVA: 0x0049250E File Offset: 0x0049070E
		public static void StartIVisionSkillReady(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021186 RID: 135558 RVA: 0x00492517 File Offset: 0x00490717
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021187 RID: 135559 RVA: 0x00492522 File Offset: 0x00490722
		public static Offset<IVisionSkillReady> EndIVisionSkillReady(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSkillReady>(builder.EndTable());
		}

		// Token: 0x06021188 RID: 135560 RVA: 0x00492530 File Offset: 0x00490730
		public IVisionSkillReadyT UnPack()
		{
			IVisionSkillReadyT visionSkillReadyT = new IVisionSkillReadyT();
			this.UnPackTo(visionSkillReadyT);
			return visionSkillReadyT;
		}

		// Token: 0x06021189 RID: 135561 RVA: 0x0049254B File Offset: 0x0049074B
		public void UnPackTo(IVisionSkillReadyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602118A RID: 135562 RVA: 0x0049255C File Offset: 0x0049075C
		public static Offset<IVisionSkillReady> Pack(FlatBufferBuilder builder, IVisionSkillReadyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSkillReady>);
			}
			return IVisionSkillReady.CreateIVisionSkillReady(builder, _o.Type);
		}

		// Token: 0x0400E230 RID: 57904
		private Table __p;
	}
}
