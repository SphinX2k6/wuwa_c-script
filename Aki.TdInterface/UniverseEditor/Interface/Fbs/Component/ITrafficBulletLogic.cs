using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC3 RID: 23235
	public struct ITrafficBulletLogic : IFlatbufferObject
	{
		// Token: 0x1700AF00 RID: 44800
		// (get) Token: 0x0602798A RID: 162186 RVA: 0x005720BC File Offset: 0x005702BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602798B RID: 162187 RVA: 0x005720C9 File Offset: 0x005702C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602798C RID: 162188 RVA: 0x005720D0 File Offset: 0x005702D0
		public static ITrafficBulletLogic GetRootAsITrafficBulletLogic(ByteBuffer _bb)
		{
			return ITrafficBulletLogic.GetRootAsITrafficBulletLogic(_bb, default(ITrafficBulletLogic));
		}

		// Token: 0x0602798D RID: 162189 RVA: 0x005720EC File Offset: 0x005702EC
		public static ITrafficBulletLogic GetRootAsITrafficBulletLogic(ByteBuffer _bb, ITrafficBulletLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602798E RID: 162190 RVA: 0x00572109 File Offset: 0x00570309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602798F RID: 162191 RVA: 0x00572118 File Offset: 0x00570318
		public ITrafficBulletLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF01 RID: 44801
		// (get) Token: 0x06027990 RID: 162192 RVA: 0x00572128 File Offset: 0x00570328
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

		// Token: 0x1700AF02 RID: 44802
		// (get) Token: 0x06027991 RID: 162193 RVA: 0x00572164 File Offset: 0x00570364
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

		// Token: 0x06027992 RID: 162194 RVA: 0x005721A4 File Offset: 0x005703A4
		public static Offset<ITrafficBulletLogic> CreateITrafficBulletLogic(FlatBufferBuilder builder, ECustomBulletLogic Type = ECustomBulletLogic.TrafficBullet, float MinSpeed = 0f)
		{
			builder.StartTable(2);
			ITrafficBulletLogic.AddMinSpeed(builder, MinSpeed);
			ITrafficBulletLogic.AddType(builder, Type);
			return ITrafficBulletLogic.EndITrafficBulletLogic(builder);
		}

		// Token: 0x06027993 RID: 162195 RVA: 0x005721C1 File Offset: 0x005703C1
		public static void StartITrafficBulletLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027994 RID: 162196 RVA: 0x005721CA File Offset: 0x005703CA
		public static void AddType(FlatBufferBuilder builder, ECustomBulletLogic type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027995 RID: 162197 RVA: 0x005721D5 File Offset: 0x005703D5
		public static void AddMinSpeed(FlatBufferBuilder builder, float minSpeed)
		{
			builder.AddFloat(1, minSpeed, 0.0);
		}

		// Token: 0x06027996 RID: 162198 RVA: 0x005721E8 File Offset: 0x005703E8
		public static Offset<ITrafficBulletLogic> EndITrafficBulletLogic(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficBulletLogic>(builder.EndTable());
		}

		// Token: 0x06027997 RID: 162199 RVA: 0x005721F8 File Offset: 0x005703F8
		public ITrafficBulletLogicT UnPack()
		{
			ITrafficBulletLogicT trafficBulletLogicT = new ITrafficBulletLogicT();
			this.UnPackTo(trafficBulletLogicT);
			return trafficBulletLogicT;
		}

		// Token: 0x06027998 RID: 162200 RVA: 0x00572213 File Offset: 0x00570413
		public void UnPackTo(ITrafficBulletLogicT _o)
		{
			_o.Type = this.Type;
			_o.MinSpeed = this.MinSpeed;
		}

		// Token: 0x06027999 RID: 162201 RVA: 0x00572230 File Offset: 0x00570430
		public static Offset<ITrafficBulletLogic> Pack(FlatBufferBuilder builder, ITrafficBulletLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficBulletLogic>);
			}
			return ITrafficBulletLogic.CreateITrafficBulletLogic(builder, _o.Type, _o.MinSpeed);
		}

		// Token: 0x0400F18F RID: 61839
		private Table __p;
	}
}
