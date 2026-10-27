using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200503F RID: 20543
	public struct ICreateBulletConfig : IFlatbufferObject
	{
		// Token: 0x17009511 RID: 38161
		// (get) Token: 0x06020EA3 RID: 134819 RVA: 0x00493881 File Offset: 0x00491A81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020EA4 RID: 134820 RVA: 0x0049388E File Offset: 0x00491A8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020EA5 RID: 134821 RVA: 0x00493898 File Offset: 0x00491A98
		public static ICreateBulletConfig GetRootAsICreateBulletConfig(ByteBuffer _bb)
		{
			return ICreateBulletConfig.GetRootAsICreateBulletConfig(_bb, default(ICreateBulletConfig));
		}

		// Token: 0x06020EA6 RID: 134822 RVA: 0x004938B4 File Offset: 0x00491AB4
		public static ICreateBulletConfig GetRootAsICreateBulletConfig(ByteBuffer _bb, ICreateBulletConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020EA7 RID: 134823 RVA: 0x004938D1 File Offset: 0x00491AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020EA8 RID: 134824 RVA: 0x004938E0 File Offset: 0x00491AE0
		public ICreateBulletConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009512 RID: 38162
		// (get) Token: 0x06020EA9 RID: 134825 RVA: 0x004938F0 File Offset: 0x00491AF0
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009513 RID: 38163
		// (get) Token: 0x06020EAA RID: 134826 RVA: 0x00493930 File Offset: 0x00491B30
		public float Delay
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020EAB RID: 134827 RVA: 0x00493970 File Offset: 0x00491B70
		public static Offset<ICreateBulletConfig> CreateICreateBulletConfig(FlatBufferBuilder builder, long BulletId = 0L, float Delay = 0f)
		{
			builder.StartTable(2);
			ICreateBulletConfig.AddBulletId(builder, BulletId);
			ICreateBulletConfig.AddDelay(builder, Delay);
			return ICreateBulletConfig.EndICreateBulletConfig(builder);
		}

		// Token: 0x06020EAC RID: 134828 RVA: 0x0049398D File Offset: 0x00491B8D
		public static void StartICreateBulletConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020EAD RID: 134829 RVA: 0x00493996 File Offset: 0x00491B96
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(0, bulletId, 0L);
		}

		// Token: 0x06020EAE RID: 134830 RVA: 0x004939A2 File Offset: 0x00491BA2
		public static void AddDelay(FlatBufferBuilder builder, float delay)
		{
			builder.AddFloat(1, delay, 0.0);
		}

		// Token: 0x06020EAF RID: 134831 RVA: 0x004939B5 File Offset: 0x00491BB5
		public static Offset<ICreateBulletConfig> EndICreateBulletConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICreateBulletConfig>(builder.EndTable());
		}

		// Token: 0x06020EB0 RID: 134832 RVA: 0x004939C4 File Offset: 0x00491BC4
		public ICreateBulletConfigT UnPack()
		{
			ICreateBulletConfigT createBulletConfigT = new ICreateBulletConfigT();
			this.UnPackTo(createBulletConfigT);
			return createBulletConfigT;
		}

		// Token: 0x06020EB1 RID: 134833 RVA: 0x004939DF File Offset: 0x00491BDF
		public void UnPackTo(ICreateBulletConfigT _o)
		{
			_o.BulletId = this.BulletId;
			_o.Delay = this.Delay;
		}

		// Token: 0x06020EB2 RID: 134834 RVA: 0x004939FC File Offset: 0x00491BFC
		public static Offset<ICreateBulletConfig> Pack(FlatBufferBuilder builder, ICreateBulletConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreateBulletConfig>);
			}
			return ICreateBulletConfig.CreateICreateBulletConfig(builder, _o.BulletId, _o.Delay);
		}

		// Token: 0x0400E032 RID: 57394
		private Table __p;
	}
}
