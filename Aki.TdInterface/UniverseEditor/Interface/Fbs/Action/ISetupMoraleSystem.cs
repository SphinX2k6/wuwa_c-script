using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A0 RID: 28832
	public struct ISetupMoraleSystem : IFlatbufferObject
	{
		// Token: 0x1700D634 RID: 54836
		// (get) Token: 0x060330D5 RID: 209109 RVA: 0x006E2C3C File Offset: 0x006E0E3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330D6 RID: 209110 RVA: 0x006E2C49 File Offset: 0x006E0E49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330D7 RID: 209111 RVA: 0x006E2C50 File Offset: 0x006E0E50
		public static ISetupMoraleSystem GetRootAsISetupMoraleSystem(ByteBuffer _bb)
		{
			return ISetupMoraleSystem.GetRootAsISetupMoraleSystem(_bb, default(ISetupMoraleSystem));
		}

		// Token: 0x060330D8 RID: 209112 RVA: 0x006E2C6C File Offset: 0x006E0E6C
		public static ISetupMoraleSystem GetRootAsISetupMoraleSystem(ByteBuffer _bb, ISetupMoraleSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330D9 RID: 209113 RVA: 0x006E2C89 File Offset: 0x006E0E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330DA RID: 209114 RVA: 0x006E2C98 File Offset: 0x006E0E98
		public ISetupMoraleSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D635 RID: 54837
		// (get) Token: 0x060330DB RID: 209115 RVA: 0x006E2CA8 File Offset: 0x006E0EA8
		public int MoralePlayId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D636 RID: 54838
		// (get) Token: 0x060330DC RID: 209116 RVA: 0x006E2CE4 File Offset: 0x006E0EE4
		public bool IsOn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060330DD RID: 209117 RVA: 0x006E2D23 File Offset: 0x006E0F23
		public static Offset<ISetupMoraleSystem> CreateISetupMoraleSystem(FlatBufferBuilder builder, int MoralePlayId = 0, bool IsOn = false)
		{
			builder.StartTable(2);
			ISetupMoraleSystem.AddMoralePlayId(builder, MoralePlayId);
			ISetupMoraleSystem.AddIsOn(builder, IsOn);
			return ISetupMoraleSystem.EndISetupMoraleSystem(builder);
		}

		// Token: 0x060330DE RID: 209118 RVA: 0x006E2D40 File Offset: 0x006E0F40
		public static void StartISetupMoraleSystem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060330DF RID: 209119 RVA: 0x006E2D49 File Offset: 0x006E0F49
		public static void AddMoralePlayId(FlatBufferBuilder builder, int moralePlayId)
		{
			builder.AddInt(0, moralePlayId, 0);
		}

		// Token: 0x060330E0 RID: 209120 RVA: 0x006E2D54 File Offset: 0x006E0F54
		public static void AddIsOn(FlatBufferBuilder builder, bool isOn)
		{
			builder.AddBool(1, isOn, false);
		}

		// Token: 0x060330E1 RID: 209121 RVA: 0x006E2D5F File Offset: 0x006E0F5F
		public static Offset<ISetupMoraleSystem> EndISetupMoraleSystem(FlatBufferBuilder builder)
		{
			return new Offset<ISetupMoraleSystem>(builder.EndTable());
		}

		// Token: 0x060330E2 RID: 209122 RVA: 0x006E2D6C File Offset: 0x006E0F6C
		public ISetupMoraleSystemT UnPack()
		{
			ISetupMoraleSystemT setupMoraleSystemT = new ISetupMoraleSystemT();
			this.UnPackTo(setupMoraleSystemT);
			return setupMoraleSystemT;
		}

		// Token: 0x060330E3 RID: 209123 RVA: 0x006E2D87 File Offset: 0x006E0F87
		public void UnPackTo(ISetupMoraleSystemT _o)
		{
			_o.MoralePlayId = this.MoralePlayId;
			_o.IsOn = this.IsOn;
		}

		// Token: 0x060330E4 RID: 209124 RVA: 0x006E2DA4 File Offset: 0x006E0FA4
		public static Offset<ISetupMoraleSystem> Pack(FlatBufferBuilder builder, ISetupMoraleSystemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetupMoraleSystem>);
			}
			return ISetupMoraleSystem.CreateISetupMoraleSystem(builder, _o.MoralePlayId, _o.IsOn);
		}

		// Token: 0x04011B08 RID: 72456
		private Table __p;
	}
}
