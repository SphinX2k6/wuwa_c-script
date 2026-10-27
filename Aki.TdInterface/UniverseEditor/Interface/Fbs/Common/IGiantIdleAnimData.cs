using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DBE RID: 23998
	public struct IGiantIdleAnimData : IFlatbufferObject
	{
		// Token: 0x1700B3AD RID: 45997
		// (get) Token: 0x0602912E RID: 168238 RVA: 0x005A3876 File Offset: 0x005A1A76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602912F RID: 168239 RVA: 0x005A3883 File Offset: 0x005A1A83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029130 RID: 168240 RVA: 0x005A388C File Offset: 0x005A1A8C
		public static IGiantIdleAnimData GetRootAsIGiantIdleAnimData(ByteBuffer _bb)
		{
			return IGiantIdleAnimData.GetRootAsIGiantIdleAnimData(_bb, default(IGiantIdleAnimData));
		}

		// Token: 0x06029131 RID: 168241 RVA: 0x005A38A8 File Offset: 0x005A1AA8
		public static IGiantIdleAnimData GetRootAsIGiantIdleAnimData(ByteBuffer _bb, IGiantIdleAnimData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029132 RID: 168242 RVA: 0x005A38C5 File Offset: 0x005A1AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029133 RID: 168243 RVA: 0x005A38D4 File Offset: 0x005A1AD4
		public IGiantIdleAnimData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3AE RID: 45998
		// (get) Token: 0x06029134 RID: 168244 RVA: 0x005A38E4 File Offset: 0x005A1AE4
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

		// Token: 0x1700B3AF RID: 45999
		// (get) Token: 0x06029135 RID: 168245 RVA: 0x005A3920 File Offset: 0x005A1B20
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

		// Token: 0x06029136 RID: 168246 RVA: 0x005A395C File Offset: 0x005A1B5C
		public static Offset<IGiantIdleAnimData> CreateIGiantIdleAnimData(FlatBufferBuilder builder, EGiantAnimationType Type = EGiantAnimationType.Idle, EGiantIdleType IdleType = EGiantIdleType.Common)
		{
			builder.StartTable(2);
			IGiantIdleAnimData.AddIdleType(builder, IdleType);
			IGiantIdleAnimData.AddType(builder, Type);
			return IGiantIdleAnimData.EndIGiantIdleAnimData(builder);
		}

		// Token: 0x06029137 RID: 168247 RVA: 0x005A3979 File Offset: 0x005A1B79
		public static void StartIGiantIdleAnimData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029138 RID: 168248 RVA: 0x005A3982 File Offset: 0x005A1B82
		public static void AddType(FlatBufferBuilder builder, EGiantAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029139 RID: 168249 RVA: 0x005A398D File Offset: 0x005A1B8D
		public static void AddIdleType(FlatBufferBuilder builder, EGiantIdleType idleType)
		{
			builder.AddByte(1, (byte)idleType, 0);
		}

		// Token: 0x0602913A RID: 168250 RVA: 0x005A3998 File Offset: 0x005A1B98
		public static Offset<IGiantIdleAnimData> EndIGiantIdleAnimData(FlatBufferBuilder builder)
		{
			return new Offset<IGiantIdleAnimData>(builder.EndTable());
		}

		// Token: 0x0602913B RID: 168251 RVA: 0x005A39A8 File Offset: 0x005A1BA8
		public IGiantIdleAnimDataT UnPack()
		{
			IGiantIdleAnimDataT giantIdleAnimDataT = new IGiantIdleAnimDataT();
			this.UnPackTo(giantIdleAnimDataT);
			return giantIdleAnimDataT;
		}

		// Token: 0x0602913C RID: 168252 RVA: 0x005A39C3 File Offset: 0x005A1BC3
		public void UnPackTo(IGiantIdleAnimDataT _o)
		{
			_o.Type = this.Type;
			_o.IdleType = this.IdleType;
		}

		// Token: 0x0602913D RID: 168253 RVA: 0x005A39E0 File Offset: 0x005A1BE0
		public static Offset<IGiantIdleAnimData> Pack(FlatBufferBuilder builder, IGiantIdleAnimDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantIdleAnimData>);
			}
			return IGiantIdleAnimData.CreateIGiantIdleAnimData(builder, _o.Type, _o.IdleType);
		}

		// Token: 0x0400F79F RID: 63391
		private Table __p;
	}
}
