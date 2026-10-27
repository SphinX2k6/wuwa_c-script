using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702B RID: 28715
	public struct ISetMoveSpeed : IFlatbufferObject
	{
		// Token: 0x1700D53C RID: 54588
		// (get) Token: 0x06032CB7 RID: 208055 RVA: 0x006DA2AA File Offset: 0x006D84AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032CB8 RID: 208056 RVA: 0x006DA2B7 File Offset: 0x006D84B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032CB9 RID: 208057 RVA: 0x006DA2C0 File Offset: 0x006D84C0
		public static ISetMoveSpeed GetRootAsISetMoveSpeed(ByteBuffer _bb)
		{
			return ISetMoveSpeed.GetRootAsISetMoveSpeed(_bb, default(ISetMoveSpeed));
		}

		// Token: 0x06032CBA RID: 208058 RVA: 0x006DA2DC File Offset: 0x006D84DC
		public static ISetMoveSpeed GetRootAsISetMoveSpeed(ByteBuffer _bb, ISetMoveSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032CBB RID: 208059 RVA: 0x006DA2F9 File Offset: 0x006D84F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032CBC RID: 208060 RVA: 0x006DA308 File Offset: 0x006D8508
		public ISetMoveSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D53D RID: 54589
		// (get) Token: 0x06032CBD RID: 208061 RVA: 0x006DA318 File Offset: 0x006D8518
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032CBE RID: 208062 RVA: 0x006DA358 File Offset: 0x006D8558
		public static Offset<ISetMoveSpeed> CreateISetMoveSpeed(FlatBufferBuilder builder, float Speed = 0f)
		{
			builder.StartTable(1);
			ISetMoveSpeed.AddSpeed(builder, Speed);
			return ISetMoveSpeed.EndISetMoveSpeed(builder);
		}

		// Token: 0x06032CBF RID: 208063 RVA: 0x006DA36E File Offset: 0x006D856E
		public static void StartISetMoveSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032CC0 RID: 208064 RVA: 0x006DA377 File Offset: 0x006D8577
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(0, speed, 0.0);
		}

		// Token: 0x06032CC1 RID: 208065 RVA: 0x006DA38A File Offset: 0x006D858A
		public static Offset<ISetMoveSpeed> EndISetMoveSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ISetMoveSpeed>(builder.EndTable());
		}

		// Token: 0x06032CC2 RID: 208066 RVA: 0x006DA398 File Offset: 0x006D8598
		public ISetMoveSpeedT UnPack()
		{
			ISetMoveSpeedT setMoveSpeedT = new ISetMoveSpeedT();
			this.UnPackTo(setMoveSpeedT);
			return setMoveSpeedT;
		}

		// Token: 0x06032CC3 RID: 208067 RVA: 0x006DA3B3 File Offset: 0x006D85B3
		public void UnPackTo(ISetMoveSpeedT _o)
		{
			_o.Speed = this.Speed;
		}

		// Token: 0x06032CC4 RID: 208068 RVA: 0x006DA3C4 File Offset: 0x006D85C4
		public static Offset<ISetMoveSpeed> Pack(FlatBufferBuilder builder, ISetMoveSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMoveSpeed>);
			}
			return ISetMoveSpeed.CreateISetMoveSpeed(builder, _o.Speed);
		}

		// Token: 0x04011A5B RID: 72283
		private Table __p;
	}
}
