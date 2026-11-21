using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D0 RID: 24784
	public struct ITrafficBulletLogic : IFlatbufferObject
	{
		// Token: 0x1700B83C RID: 47164
		// (get) Token: 0x06029F10 RID: 171792 RVA: 0x005B93A4 File Offset: 0x005B75A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029F11 RID: 171793 RVA: 0x005B93B1 File Offset: 0x005B75B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029F12 RID: 171794 RVA: 0x005B93B8 File Offset: 0x005B75B8
		public static ITrafficBulletLogic GetRootAsITrafficBulletLogic(ByteBuffer _bb)
		{
			return ITrafficBulletLogic.GetRootAsITrafficBulletLogic(_bb, default(ITrafficBulletLogic));
		}

		// Token: 0x06029F13 RID: 171795 RVA: 0x005B93D4 File Offset: 0x005B75D4
		public static ITrafficBulletLogic GetRootAsITrafficBulletLogic(ByteBuffer _bb, ITrafficBulletLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029F14 RID: 171796 RVA: 0x005B93F1 File Offset: 0x005B75F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029F15 RID: 171797 RVA: 0x005B9400 File Offset: 0x005B7600
		public ITrafficBulletLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B83D RID: 47165
		// (get) Token: 0x06029F16 RID: 171798 RVA: 0x005B9410 File Offset: 0x005B7610
		public ECustomBulletLogic Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomBulletLogic.TrafficBullet;
				}
				return (ECustomBulletLogic)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B83E RID: 47166
		// (get) Token: 0x06029F17 RID: 171799 RVA: 0x005B944C File Offset: 0x005B764C
		public float MinSpeed
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

		// Token: 0x06029F18 RID: 171800 RVA: 0x005B948C File Offset: 0x005B768C
		public static Offset<ITrafficBulletLogic> CreateITrafficBulletLogic(FlatBufferBuilder builder, ECustomBulletLogic Type = ECustomBulletLogic.TrafficBullet, float MinSpeed = 0f)
		{
			builder.StartTable(2);
			ITrafficBulletLogic.AddMinSpeed(builder, MinSpeed);
			ITrafficBulletLogic.AddType(builder, Type);
			return ITrafficBulletLogic.EndITrafficBulletLogic(builder);
		}

		// Token: 0x06029F19 RID: 171801 RVA: 0x005B94A9 File Offset: 0x005B76A9
		public static void StartITrafficBulletLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029F1A RID: 171802 RVA: 0x005B94B2 File Offset: 0x005B76B2
		public static void AddType(FlatBufferBuilder builder, ECustomBulletLogic type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029F1B RID: 171803 RVA: 0x005B94BD File Offset: 0x005B76BD
		public static void AddMinSpeed(FlatBufferBuilder builder, float minSpeed)
		{
			builder.AddFloat(1, minSpeed, 0.0);
		}

		// Token: 0x06029F1C RID: 171804 RVA: 0x005B94D0 File Offset: 0x005B76D0
		public static Offset<ITrafficBulletLogic> EndITrafficBulletLogic(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficBulletLogic>(builder.EndTable());
		}

		// Token: 0x06029F1D RID: 171805 RVA: 0x005B94E0 File Offset: 0x005B76E0
		public ITrafficBulletLogicT UnPack()
		{
			ITrafficBulletLogicT trafficBulletLogicT = new ITrafficBulletLogicT();
			this.UnPackTo(trafficBulletLogicT);
			return trafficBulletLogicT;
		}

		// Token: 0x06029F1E RID: 171806 RVA: 0x005B94FB File Offset: 0x005B76FB
		public void UnPackTo(ITrafficBulletLogicT _o)
		{
			_o.Type = this.Type;
			_o.MinSpeed = this.MinSpeed;
		}

		// Token: 0x06029F1F RID: 171807 RVA: 0x005B9518 File Offset: 0x005B7718
		public static Offset<ITrafficBulletLogic> Pack(FlatBufferBuilder builder, ITrafficBulletLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficBulletLogic>);
			}
			return ITrafficBulletLogic.CreateITrafficBulletLogic(builder, _o.Type, _o.MinSpeed);
		}

		// Token: 0x0400FE88 RID: 65160
		private Table __p;
	}
}
