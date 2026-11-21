using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B73 RID: 23411
	public struct IMoveComponent : IFlatbufferObject
	{
		// Token: 0x1700AB13 RID: 43795
		// (get) Token: 0x060268F8 RID: 157944 RVA: 0x00547D90 File Offset: 0x00545F90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060268F9 RID: 157945 RVA: 0x00547D9D File Offset: 0x00545F9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060268FA RID: 157946 RVA: 0x00547DA4 File Offset: 0x00545FA4
		public static IMoveComponent GetRootAsIMoveComponent(ByteBuffer _bb)
		{
			return IMoveComponent.GetRootAsIMoveComponent(_bb, default(IMoveComponent));
		}

		// Token: 0x060268FB RID: 157947 RVA: 0x00547DC0 File Offset: 0x00545FC0
		public static IMoveComponent GetRootAsIMoveComponent(ByteBuffer _bb, IMoveComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060268FC RID: 157948 RVA: 0x00547DDD File Offset: 0x00545FDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060268FD RID: 157949 RVA: 0x00547DEC File Offset: 0x00545FEC
		public IMoveComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB14 RID: 43796
		// (get) Token: 0x060268FE RID: 157950 RVA: 0x00547DFC File Offset: 0x00545FFC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB15 RID: 43797
		// (get) Token: 0x060268FF RID: 157951 RVA: 0x00547E3C File Offset: 0x0054603C
		public float InitSpeed
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

		// Token: 0x1700AB16 RID: 43798
		// (get) Token: 0x06026900 RID: 157952 RVA: 0x00547E7C File Offset: 0x0054607C
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

		// Token: 0x06026901 RID: 157953 RVA: 0x00547EB8 File Offset: 0x005460B8
		public static Offset<IMoveComponent> CreateIMoveComponent(FlatBufferBuilder builder, bool Disabled = false, float InitSpeed = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMoveComponent.AddInitSpeed(builder, InitSpeed);
			IMoveComponent.AddNullMask(builder, NullMask);
			IMoveComponent.AddDisabled(builder, Disabled);
			return IMoveComponent.EndIMoveComponent(builder);
		}

		// Token: 0x06026902 RID: 157954 RVA: 0x00547EDC File Offset: 0x005460DC
		public static void StartIMoveComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026903 RID: 157955 RVA: 0x00547EE5 File Offset: 0x005460E5
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026904 RID: 157956 RVA: 0x00547EF0 File Offset: 0x005460F0
		public static void AddInitSpeed(FlatBufferBuilder builder, float initSpeed)
		{
			builder.AddFloat(1, initSpeed, 0.0);
		}

		// Token: 0x06026905 RID: 157957 RVA: 0x00547F03 File Offset: 0x00546103
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026906 RID: 157958 RVA: 0x00547F0E File Offset: 0x0054610E
		public static Offset<IMoveComponent> EndIMoveComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMoveComponent>(builder.EndTable());
		}

		// Token: 0x06026907 RID: 157959 RVA: 0x00547F1C File Offset: 0x0054611C
		public IMoveComponentT UnPack()
		{
			IMoveComponentT moveComponentT = new IMoveComponentT();
			this.UnPackTo(moveComponentT);
			return moveComponentT;
		}

		// Token: 0x06026908 RID: 157960 RVA: 0x00547F37 File Offset: 0x00546137
		public void UnPackTo(IMoveComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitSpeed = this.InitSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026909 RID: 157961 RVA: 0x00547F60 File Offset: 0x00546160
		public static Offset<IMoveComponent> Pack(FlatBufferBuilder builder, IMoveComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveComponent>);
			}
			return IMoveComponent.CreateIMoveComponent(builder, _o.Disabled, _o.InitSpeed, _o.NullMask);
		}

		// Token: 0x0400F598 RID: 62872
		private Table __p;
	}
}
