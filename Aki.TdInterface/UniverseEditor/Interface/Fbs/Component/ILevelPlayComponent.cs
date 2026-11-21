using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A65 RID: 23141
	public struct ILevelPlayComponent : IFlatbufferObject
	{
		// Token: 0x1700A86F RID: 43119
		// (get) Token: 0x06025DF6 RID: 155126 RVA: 0x00531133 File Offset: 0x0052F333
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025DF7 RID: 155127 RVA: 0x00531140 File Offset: 0x0052F340
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025DF8 RID: 155128 RVA: 0x00531148 File Offset: 0x0052F348
		public static ILevelPlayComponent GetRootAsILevelPlayComponent(ByteBuffer _bb)
		{
			return ILevelPlayComponent.GetRootAsILevelPlayComponent(_bb, default(ILevelPlayComponent));
		}

		// Token: 0x06025DF9 RID: 155129 RVA: 0x00531164 File Offset: 0x0052F364
		public static ILevelPlayComponent GetRootAsILevelPlayComponent(ByteBuffer _bb, ILevelPlayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025DFA RID: 155130 RVA: 0x00531181 File Offset: 0x0052F381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025DFB RID: 155131 RVA: 0x00531190 File Offset: 0x0052F390
		public ILevelPlayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A870 RID: 43120
		// (get) Token: 0x06025DFC RID: 155132 RVA: 0x005311A0 File Offset: 0x0052F3A0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A871 RID: 43121
		// (get) Token: 0x06025DFD RID: 155133 RVA: 0x005311E0 File Offset: 0x0052F3E0
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A872 RID: 43122
		// (get) Token: 0x06025DFE RID: 155134 RVA: 0x0053121C File Offset: 0x0052F41C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DFF RID: 155135 RVA: 0x00531258 File Offset: 0x0052F458
		public static Offset<ILevelPlayComponent> CreateILevelPlayComponent(FlatBufferBuilder builder, bool Disabled = false, int LevelPlayId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelPlayComponent.AddLevelPlayId(builder, LevelPlayId);
			ILevelPlayComponent.AddNullMask(builder, NullMask);
			ILevelPlayComponent.AddDisabled(builder, Disabled);
			return ILevelPlayComponent.EndILevelPlayComponent(builder);
		}

		// Token: 0x06025E00 RID: 155136 RVA: 0x0053127C File Offset: 0x0052F47C
		public static void StartILevelPlayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025E01 RID: 155137 RVA: 0x00531285 File Offset: 0x0052F485
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025E02 RID: 155138 RVA: 0x00531290 File Offset: 0x0052F490
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x06025E03 RID: 155139 RVA: 0x0053129B File Offset: 0x0052F49B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025E04 RID: 155140 RVA: 0x005312A6 File Offset: 0x0052F4A6
		public static Offset<ILevelPlayComponent> EndILevelPlayComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayComponent>(builder.EndTable());
		}

		// Token: 0x06025E05 RID: 155141 RVA: 0x005312B4 File Offset: 0x0052F4B4
		public ILevelPlayComponentT UnPack()
		{
			ILevelPlayComponentT levelPlayComponentT = new ILevelPlayComponentT();
			this.UnPackTo(levelPlayComponentT);
			return levelPlayComponentT;
		}

		// Token: 0x06025E06 RID: 155142 RVA: 0x005312CF File Offset: 0x0052F4CF
		public void UnPackTo(ILevelPlayComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LevelPlayId = this.LevelPlayId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025E07 RID: 155143 RVA: 0x005312F8 File Offset: 0x0052F4F8
		public static Offset<ILevelPlayComponent> Pack(FlatBufferBuilder builder, ILevelPlayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayComponent>);
			}
			return ILevelPlayComponent.CreateILevelPlayComponent(builder, _o.Disabled, _o.LevelPlayId, _o.NullMask);
		}

		// Token: 0x0400F3E1 RID: 62433
		private Table __p;
	}
}
