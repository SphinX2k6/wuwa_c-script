using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005205 RID: 20997
	public struct IUltimateSkillReady : IFlatbufferObject
	{
		// Token: 0x17009647 RID: 38471
		// (get) Token: 0x06021117 RID: 135447 RVA: 0x00491AC5 File Offset: 0x0048FCC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021118 RID: 135448 RVA: 0x00491AD2 File Offset: 0x0048FCD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021119 RID: 135449 RVA: 0x00491ADC File Offset: 0x0048FCDC
		public static IUltimateSkillReady GetRootAsIUltimateSkillReady(ByteBuffer _bb)
		{
			return IUltimateSkillReady.GetRootAsIUltimateSkillReady(_bb, default(IUltimateSkillReady));
		}

		// Token: 0x0602111A RID: 135450 RVA: 0x00491AF8 File Offset: 0x0048FCF8
		public static IUltimateSkillReady GetRootAsIUltimateSkillReady(ByteBuffer _bb, IUltimateSkillReady obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602111B RID: 135451 RVA: 0x00491B15 File Offset: 0x0048FD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602111C RID: 135452 RVA: 0x00491B24 File Offset: 0x0048FD24
		public IUltimateSkillReady __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009648 RID: 38472
		// (get) Token: 0x0602111D RID: 135453 RVA: 0x00491B34 File Offset: 0x0048FD34
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

		// Token: 0x0602111E RID: 135454 RVA: 0x00491B70 File Offset: 0x0048FD70
		public static Offset<IUltimateSkillReady> CreateIUltimateSkillReady(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			IUltimateSkillReady.AddType(builder, Type);
			return IUltimateSkillReady.EndIUltimateSkillReady(builder);
		}

		// Token: 0x0602111F RID: 135455 RVA: 0x00491B86 File Offset: 0x0048FD86
		public static void StartIUltimateSkillReady(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021120 RID: 135456 RVA: 0x00491B8F File Offset: 0x0048FD8F
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021121 RID: 135457 RVA: 0x00491B9A File Offset: 0x0048FD9A
		public static Offset<IUltimateSkillReady> EndIUltimateSkillReady(FlatBufferBuilder builder)
		{
			return new Offset<IUltimateSkillReady>(builder.EndTable());
		}

		// Token: 0x06021122 RID: 135458 RVA: 0x00491BA8 File Offset: 0x0048FDA8
		public IUltimateSkillReadyT UnPack()
		{
			IUltimateSkillReadyT ultimateSkillReadyT = new IUltimateSkillReadyT();
			this.UnPackTo(ultimateSkillReadyT);
			return ultimateSkillReadyT;
		}

		// Token: 0x06021123 RID: 135459 RVA: 0x00491BC3 File Offset: 0x0048FDC3
		public void UnPackTo(IUltimateSkillReadyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021124 RID: 135460 RVA: 0x00491BD4 File Offset: 0x0048FDD4
		public static Offset<IUltimateSkillReady> Pack(FlatBufferBuilder builder, IUltimateSkillReadyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUltimateSkillReady>);
			}
			return IUltimateSkillReady.CreateIUltimateSkillReady(builder, _o.Type);
		}

		// Token: 0x0400E213 RID: 57875
		private Table __p;
	}
}
