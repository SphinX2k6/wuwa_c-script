using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F4 RID: 21748
	public struct ILevitateMagnetComponent : IFlatbufferObject
	{
		// Token: 0x1700A07A RID: 41082
		// (get) Token: 0x06023E5D RID: 147037 RVA: 0x004F6A66 File Offset: 0x004F4C66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E5E RID: 147038 RVA: 0x004F6A73 File Offset: 0x004F4C73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E5F RID: 147039 RVA: 0x004F6A7C File Offset: 0x004F4C7C
		public static ILevitateMagnetComponent GetRootAsILevitateMagnetComponent(ByteBuffer _bb)
		{
			return ILevitateMagnetComponent.GetRootAsILevitateMagnetComponent(_bb, default(ILevitateMagnetComponent));
		}

		// Token: 0x06023E60 RID: 147040 RVA: 0x004F6A98 File Offset: 0x004F4C98
		public static ILevitateMagnetComponent GetRootAsILevitateMagnetComponent(ByteBuffer _bb, ILevitateMagnetComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E61 RID: 147041 RVA: 0x004F6AB5 File Offset: 0x004F4CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E62 RID: 147042 RVA: 0x004F6AC4 File Offset: 0x004F4CC4
		public ILevitateMagnetComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A07B RID: 41083
		// (get) Token: 0x06023E63 RID: 147043 RVA: 0x004F6AD4 File Offset: 0x004F4CD4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A07C RID: 41084
		// (get) Token: 0x06023E64 RID: 147044 RVA: 0x004F6B14 File Offset: 0x004F4D14
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

		// Token: 0x1700A07D RID: 41085
		// (get) Token: 0x06023E65 RID: 147045 RVA: 0x004F6B50 File Offset: 0x004F4D50
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

		// Token: 0x1700A07E RID: 41086
		// (get) Token: 0x06023E66 RID: 147046 RVA: 0x004F6B8C File Offset: 0x004F4D8C
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

		// Token: 0x06023E67 RID: 147047 RVA: 0x004F6BC9 File Offset: 0x004F4DC9
		public static Offset<ILevitateMagnetComponent> CreateILevitateMagnetComponent(FlatBufferBuilder builder, bool Disabled = false, int MoveSpeed = 0, int Test = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevitateMagnetComponent.AddTest(builder, Test);
			ILevitateMagnetComponent.AddMoveSpeed(builder, MoveSpeed);
			ILevitateMagnetComponent.AddNullMask(builder, NullMask);
			ILevitateMagnetComponent.AddDisabled(builder, Disabled);
			return ILevitateMagnetComponent.EndILevitateMagnetComponent(builder);
		}

		// Token: 0x06023E68 RID: 147048 RVA: 0x004F6BF5 File Offset: 0x004F4DF5
		public static void StartILevitateMagnetComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023E69 RID: 147049 RVA: 0x004F6BFE File Offset: 0x004F4DFE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023E6A RID: 147050 RVA: 0x004F6C09 File Offset: 0x004F4E09
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(1, moveSpeed, 0);
		}

		// Token: 0x06023E6B RID: 147051 RVA: 0x004F6C14 File Offset: 0x004F4E14
		public static void AddTest(FlatBufferBuilder builder, int test)
		{
			builder.AddInt(2, test, 0);
		}

		// Token: 0x06023E6C RID: 147052 RVA: 0x004F6C1F File Offset: 0x004F4E1F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023E6D RID: 147053 RVA: 0x004F6C2A File Offset: 0x004F4E2A
		public static Offset<ILevitateMagnetComponent> EndILevitateMagnetComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevitateMagnetComponent>(builder.EndTable());
		}

		// Token: 0x06023E6E RID: 147054 RVA: 0x004F6C38 File Offset: 0x004F4E38
		public ILevitateMagnetComponentT UnPack()
		{
			ILevitateMagnetComponentT levitateMagnetComponentT = new ILevitateMagnetComponentT();
			this.UnPackTo(levitateMagnetComponentT);
			return levitateMagnetComponentT;
		}

		// Token: 0x06023E6F RID: 147055 RVA: 0x004F6C53 File Offset: 0x004F4E53
		public void UnPackTo(ILevitateMagnetComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MoveSpeed = this.MoveSpeed;
			_o.Test = this.Test;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023E70 RID: 147056 RVA: 0x004F6C88 File Offset: 0x004F4E88
		public static Offset<ILevitateMagnetComponent> Pack(FlatBufferBuilder builder, ILevitateMagnetComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevitateMagnetComponent>);
			}
			return ILevitateMagnetComponent.CreateILevitateMagnetComponent(builder, _o.Disabled, _o.MoveSpeed, _o.Test, _o.NullMask);
		}

		// Token: 0x0400E7D6 RID: 59350
		private Table __p;
	}
}
