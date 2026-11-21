using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063FB RID: 25595
	public struct IGiantIdleAnimData : IFlatbufferObject
	{
		// Token: 0x1700BD13 RID: 48403
		// (get) Token: 0x0602B7B8 RID: 178104 RVA: 0x005EC5A6 File Offset: 0x005EA7A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B7B9 RID: 178105 RVA: 0x005EC5B3 File Offset: 0x005EA7B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B7BA RID: 178106 RVA: 0x005EC5BC File Offset: 0x005EA7BC
		public static IGiantIdleAnimData GetRootAsIGiantIdleAnimData(ByteBuffer _bb)
		{
			return IGiantIdleAnimData.GetRootAsIGiantIdleAnimData(_bb, default(IGiantIdleAnimData));
		}

		// Token: 0x0602B7BB RID: 178107 RVA: 0x005EC5D8 File Offset: 0x005EA7D8
		public static IGiantIdleAnimData GetRootAsIGiantIdleAnimData(ByteBuffer _bb, IGiantIdleAnimData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7BC RID: 178108 RVA: 0x005EC5F5 File Offset: 0x005EA7F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7BD RID: 178109 RVA: 0x005EC604 File Offset: 0x005EA804
		public IGiantIdleAnimData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD14 RID: 48404
		// (get) Token: 0x0602B7BE RID: 178110 RVA: 0x005EC614 File Offset: 0x005EA814
		public EGiantAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantAnimationType.Idle;
				}
				return (EGiantAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD15 RID: 48405
		// (get) Token: 0x0602B7BF RID: 178111 RVA: 0x005EC650 File Offset: 0x005EA850
		public EGiantIdleType IdleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantIdleType.Common;
				}
				return (EGiantIdleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B7C0 RID: 178112 RVA: 0x005EC68C File Offset: 0x005EA88C
		public static Offset<IGiantIdleAnimData> CreateIGiantIdleAnimData(FlatBufferBuilder builder, EGiantAnimationType Type = EGiantAnimationType.Idle, EGiantIdleType IdleType = EGiantIdleType.Common)
		{
			builder.StartTable(2);
			IGiantIdleAnimData.AddIdleType(builder, IdleType);
			IGiantIdleAnimData.AddType(builder, Type);
			return IGiantIdleAnimData.EndIGiantIdleAnimData(builder);
		}

		// Token: 0x0602B7C1 RID: 178113 RVA: 0x005EC6A9 File Offset: 0x005EA8A9
		public static void StartIGiantIdleAnimData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B7C2 RID: 178114 RVA: 0x005EC6B2 File Offset: 0x005EA8B2
		public static void AddType(FlatBufferBuilder builder, EGiantAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B7C3 RID: 178115 RVA: 0x005EC6BD File Offset: 0x005EA8BD
		public static void AddIdleType(FlatBufferBuilder builder, EGiantIdleType idleType)
		{
			builder.AddByte(1, (byte)idleType, 0);
		}

		// Token: 0x0602B7C4 RID: 178116 RVA: 0x005EC6C8 File Offset: 0x005EA8C8
		public static Offset<IGiantIdleAnimData> EndIGiantIdleAnimData(FlatBufferBuilder builder)
		{
			return new Offset<IGiantIdleAnimData>(builder.EndTable());
		}

		// Token: 0x0602B7C5 RID: 178117 RVA: 0x005EC6D8 File Offset: 0x005EA8D8
		public IGiantIdleAnimDataT UnPack()
		{
			IGiantIdleAnimDataT giantIdleAnimDataT = new IGiantIdleAnimDataT();
			this.UnPackTo(giantIdleAnimDataT);
			return giantIdleAnimDataT;
		}

		// Token: 0x0602B7C6 RID: 178118 RVA: 0x005EC6F3 File Offset: 0x005EA8F3
		public void UnPackTo(IGiantIdleAnimDataT _o)
		{
			_o.Type = this.Type;
			_o.IdleType = this.IdleType;
		}

		// Token: 0x0602B7C7 RID: 178119 RVA: 0x005EC710 File Offset: 0x005EA910
		public static Offset<IGiantIdleAnimData> Pack(FlatBufferBuilder builder, IGiantIdleAnimDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantIdleAnimData>);
			}
			return IGiantIdleAnimData.CreateIGiantIdleAnimData(builder, _o.Type, _o.IdleType);
		}

		// Token: 0x040104FA RID: 66810
		private Table __p;
	}
}
