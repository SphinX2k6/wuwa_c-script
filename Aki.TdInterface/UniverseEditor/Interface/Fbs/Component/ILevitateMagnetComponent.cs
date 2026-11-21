using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7A RID: 23162
	public struct ILevitateMagnetComponent : IFlatbufferObject
	{
		// Token: 0x1700A8B4 RID: 43188
		// (get) Token: 0x06025F17 RID: 155415 RVA: 0x00533B8A File Offset: 0x00531D8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F18 RID: 155416 RVA: 0x00533B97 File Offset: 0x00531D97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F19 RID: 155417 RVA: 0x00533BA0 File Offset: 0x00531DA0
		public static ILevitateMagnetComponent GetRootAsILevitateMagnetComponent(ByteBuffer _bb)
		{
			return ILevitateMagnetComponent.GetRootAsILevitateMagnetComponent(_bb, default(ILevitateMagnetComponent));
		}

		// Token: 0x06025F1A RID: 155418 RVA: 0x00533BBC File Offset: 0x00531DBC
		public static ILevitateMagnetComponent GetRootAsILevitateMagnetComponent(ByteBuffer _bb, ILevitateMagnetComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F1B RID: 155419 RVA: 0x00533BD9 File Offset: 0x00531DD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F1C RID: 155420 RVA: 0x00533BE8 File Offset: 0x00531DE8
		public ILevitateMagnetComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8B5 RID: 43189
		// (get) Token: 0x06025F1D RID: 155421 RVA: 0x00533BF8 File Offset: 0x00531DF8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8B6 RID: 43190
		// (get) Token: 0x06025F1E RID: 155422 RVA: 0x00533C38 File Offset: 0x00531E38
		public int MoveSpeed
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

		// Token: 0x1700A8B7 RID: 43191
		// (get) Token: 0x06025F1F RID: 155423 RVA: 0x00533C74 File Offset: 0x00531E74
		public int Test
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8B8 RID: 43192
		// (get) Token: 0x06025F20 RID: 155424 RVA: 0x00533CB0 File Offset: 0x00531EB0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025F21 RID: 155425 RVA: 0x00533CED File Offset: 0x00531EED
		public static Offset<ILevitateMagnetComponent> CreateILevitateMagnetComponent(FlatBufferBuilder builder, bool Disabled = false, int MoveSpeed = 0, int Test = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevitateMagnetComponent.AddTest(builder, Test);
			ILevitateMagnetComponent.AddMoveSpeed(builder, MoveSpeed);
			ILevitateMagnetComponent.AddNullMask(builder, NullMask);
			ILevitateMagnetComponent.AddDisabled(builder, Disabled);
			return ILevitateMagnetComponent.EndILevitateMagnetComponent(builder);
		}

		// Token: 0x06025F22 RID: 155426 RVA: 0x00533D19 File Offset: 0x00531F19
		public static void StartILevitateMagnetComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025F23 RID: 155427 RVA: 0x00533D22 File Offset: 0x00531F22
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025F24 RID: 155428 RVA: 0x00533D2D File Offset: 0x00531F2D
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(1, moveSpeed, 0);
		}

		// Token: 0x06025F25 RID: 155429 RVA: 0x00533D38 File Offset: 0x00531F38
		public static void AddTest(FlatBufferBuilder builder, int test)
		{
			builder.AddInt(2, test, 0);
		}

		// Token: 0x06025F26 RID: 155430 RVA: 0x00533D43 File Offset: 0x00531F43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025F27 RID: 155431 RVA: 0x00533D4E File Offset: 0x00531F4E
		public static Offset<ILevitateMagnetComponent> EndILevitateMagnetComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevitateMagnetComponent>(builder.EndTable());
		}

		// Token: 0x06025F28 RID: 155432 RVA: 0x00533D5C File Offset: 0x00531F5C
		public ILevitateMagnetComponentT UnPack()
		{
			ILevitateMagnetComponentT levitateMagnetComponentT = new ILevitateMagnetComponentT();
			this.UnPackTo(levitateMagnetComponentT);
			return levitateMagnetComponentT;
		}

		// Token: 0x06025F29 RID: 155433 RVA: 0x00533D77 File Offset: 0x00531F77
		public void UnPackTo(ILevitateMagnetComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MoveSpeed = this.MoveSpeed;
			_o.Test = this.Test;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025F2A RID: 155434 RVA: 0x00533DAC File Offset: 0x00531FAC
		public static Offset<ILevitateMagnetComponent> Pack(FlatBufferBuilder builder, ILevitateMagnetComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevitateMagnetComponent>);
			}
			return ILevitateMagnetComponent.CreateILevitateMagnetComponent(builder, _o.Disabled, _o.MoveSpeed, _o.Test, _o.NullMask);
		}

		// Token: 0x0400F407 RID: 62471
		private Table __p;
	}
}
