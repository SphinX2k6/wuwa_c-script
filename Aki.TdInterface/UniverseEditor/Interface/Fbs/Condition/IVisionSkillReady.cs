using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D18 RID: 19736
	public struct IVisionSkillReady : IFlatbufferObject
	{
		// Token: 0x17008F1D RID: 36637
		// (get) Token: 0x0601F536 RID: 128310 RVA: 0x0045E4BE File Offset: 0x0045C6BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F537 RID: 128311 RVA: 0x0045E4CB File Offset: 0x0045C6CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F538 RID: 128312 RVA: 0x0045E4D4 File Offset: 0x0045C6D4
		public static IVisionSkillReady GetRootAsIVisionSkillReady(ByteBuffer _bb)
		{
			return IVisionSkillReady.GetRootAsIVisionSkillReady(_bb, default(IVisionSkillReady));
		}

		// Token: 0x0601F539 RID: 128313 RVA: 0x0045E4F0 File Offset: 0x0045C6F0
		public static IVisionSkillReady GetRootAsIVisionSkillReady(ByteBuffer _bb, IVisionSkillReady obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F53A RID: 128314 RVA: 0x0045E50D File Offset: 0x0045C70D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F53B RID: 128315 RVA: 0x0045E51C File Offset: 0x0045C71C
		public IVisionSkillReady __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F1E RID: 36638
		// (get) Token: 0x0601F53C RID: 128316 RVA: 0x0045E52C File Offset: 0x0045C72C
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

		// Token: 0x0601F53D RID: 128317 RVA: 0x0045E568 File Offset: 0x0045C768
		public static Offset<IVisionSkillReady> CreateIVisionSkillReady(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			IVisionSkillReady.AddType(builder, Type);
			return IVisionSkillReady.EndIVisionSkillReady(builder);
		}

		// Token: 0x0601F53E RID: 128318 RVA: 0x0045E57E File Offset: 0x0045C77E
		public static void StartIVisionSkillReady(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F53F RID: 128319 RVA: 0x0045E587 File Offset: 0x0045C787
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F540 RID: 128320 RVA: 0x0045E592 File Offset: 0x0045C792
		public static Offset<IVisionSkillReady> EndIVisionSkillReady(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSkillReady>(builder.EndTable());
		}

		// Token: 0x0601F541 RID: 128321 RVA: 0x0045E5A0 File Offset: 0x0045C7A0
		public IVisionSkillReadyT UnPack()
		{
			IVisionSkillReadyT visionSkillReadyT = new IVisionSkillReadyT();
			this.UnPackTo(visionSkillReadyT);
			return visionSkillReadyT;
		}

		// Token: 0x0601F542 RID: 128322 RVA: 0x0045E5BB File Offset: 0x0045C7BB
		public void UnPackTo(IVisionSkillReadyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F543 RID: 128323 RVA: 0x0045E5CC File Offset: 0x0045C7CC
		public static Offset<IVisionSkillReady> Pack(FlatBufferBuilder builder, IVisionSkillReadyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSkillReady>);
			}
			return IVisionSkillReady.CreateIVisionSkillReady(builder, _o.Type);
		}

		// Token: 0x0400D702 RID: 55042
		private Table __p;
	}
}
