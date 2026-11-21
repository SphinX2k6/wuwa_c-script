using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F9F RID: 24479
	public struct ISpwanMonsterMode : IFlatbufferObject
	{
		// Token: 0x1700B54D RID: 46413
		// (get) Token: 0x060292CA RID: 168650 RVA: 0x0059F2C7 File Offset: 0x0059D4C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292CB RID: 168651 RVA: 0x0059F2D4 File Offset: 0x0059D4D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060292CC RID: 168652 RVA: 0x0059F2DC File Offset: 0x0059D4DC
		public static ISpwanMonsterMode GetRootAsISpwanMonsterMode(ByteBuffer _bb)
		{
			return ISpwanMonsterMode.GetRootAsISpwanMonsterMode(_bb, default(ISpwanMonsterMode));
		}

		// Token: 0x060292CD RID: 168653 RVA: 0x0059F2F8 File Offset: 0x0059D4F8
		public static ISpwanMonsterMode GetRootAsISpwanMonsterMode(ByteBuffer _bb, ISpwanMonsterMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060292CE RID: 168654 RVA: 0x0059F315 File Offset: 0x0059D515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060292CF RID: 168655 RVA: 0x0059F324 File Offset: 0x0059D524
		public ISpwanMonsterMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B54E RID: 46414
		// (get) Token: 0x060292D0 RID: 168656 RVA: 0x0059F334 File Offset: 0x0059D534
		public ESpawnMonsterConstraint Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				}
				return (ESpawnMonsterConstraint)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060292D1 RID: 168657 RVA: 0x0059F370 File Offset: 0x0059D570
		public static Offset<ISpwanMonsterMode> CreateISpwanMonsterMode(FlatBufferBuilder builder, ESpawnMonsterConstraint Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector)
		{
			builder.StartTable(1);
			ISpwanMonsterMode.AddType(builder, Type);
			return ISpwanMonsterMode.EndISpwanMonsterMode(builder);
		}

		// Token: 0x060292D2 RID: 168658 RVA: 0x0059F386 File Offset: 0x0059D586
		public static void StartISpwanMonsterMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060292D3 RID: 168659 RVA: 0x0059F38F File Offset: 0x0059D58F
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060292D4 RID: 168660 RVA: 0x0059F39A File Offset: 0x0059D59A
		public static Offset<ISpwanMonsterMode> EndISpwanMonsterMode(FlatBufferBuilder builder)
		{
			return new Offset<ISpwanMonsterMode>(builder.EndTable());
		}

		// Token: 0x060292D5 RID: 168661 RVA: 0x0059F3A8 File Offset: 0x0059D5A8
		public ISpwanMonsterModeT UnPack()
		{
			ISpwanMonsterModeT spwanMonsterModeT = new ISpwanMonsterModeT();
			this.UnPackTo(spwanMonsterModeT);
			return spwanMonsterModeT;
		}

		// Token: 0x060292D6 RID: 168662 RVA: 0x0059F3C3 File Offset: 0x0059D5C3
		public void UnPackTo(ISpwanMonsterModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060292D7 RID: 168663 RVA: 0x0059F3D4 File Offset: 0x0059D5D4
		public static Offset<ISpwanMonsterMode> Pack(FlatBufferBuilder builder, ISpwanMonsterModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpwanMonsterMode>);
			}
			return ISpwanMonsterMode.CreateISpwanMonsterMode(builder, _o.Type);
		}

		// Token: 0x0400FC8F RID: 64655
		private Table __p;
	}
}
