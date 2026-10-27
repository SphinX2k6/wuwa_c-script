using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004392 RID: 17298
	public struct IAwakeEntityRefSource : IFlatbufferObject
	{
		// Token: 0x17007A46 RID: 31302
		// (get) Token: 0x06019BCB RID: 105419 RVA: 0x003AF790 File Offset: 0x003AD990
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019BCC RID: 105420 RVA: 0x003AF79D File Offset: 0x003AD99D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019BCD RID: 105421 RVA: 0x003AF7A4 File Offset: 0x003AD9A4
		public static IAwakeEntityRefSource GetRootAsIAwakeEntityRefSource(ByteBuffer _bb)
		{
			return IAwakeEntityRefSource.GetRootAsIAwakeEntityRefSource(_bb, default(IAwakeEntityRefSource));
		}

		// Token: 0x06019BCE RID: 105422 RVA: 0x003AF7C0 File Offset: 0x003AD9C0
		public static IAwakeEntityRefSource GetRootAsIAwakeEntityRefSource(ByteBuffer _bb, IAwakeEntityRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019BCF RID: 105423 RVA: 0x003AF7DD File Offset: 0x003AD9DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019BD0 RID: 105424 RVA: 0x003AF7EC File Offset: 0x003AD9EC
		public IAwakeEntityRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A47 RID: 31303
		// (get) Token: 0x06019BD1 RID: 105425 RVA: 0x003AF7FC File Offset: 0x003AD9FC
		public ERefSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefSourceType.AwakeEntity;
				}
				return (ERefSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A48 RID: 31304
		// (get) Token: 0x06019BD2 RID: 105426 RVA: 0x003AF838 File Offset: 0x003ADA38
		public int EntityId
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

		// Token: 0x06019BD3 RID: 105427 RVA: 0x003AF874 File Offset: 0x003ADA74
		public static Offset<IAwakeEntityRefSource> CreateIAwakeEntityRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity, int EntityId = 0)
		{
			builder.StartTable(2);
			IAwakeEntityRefSource.AddEntityId(builder, EntityId);
			IAwakeEntityRefSource.AddType(builder, Type);
			return IAwakeEntityRefSource.EndIAwakeEntityRefSource(builder);
		}

		// Token: 0x06019BD4 RID: 105428 RVA: 0x003AF891 File Offset: 0x003ADA91
		public static void StartIAwakeEntityRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019BD5 RID: 105429 RVA: 0x003AF89A File Offset: 0x003ADA9A
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019BD6 RID: 105430 RVA: 0x003AF8A5 File Offset: 0x003ADAA5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06019BD7 RID: 105431 RVA: 0x003AF8B0 File Offset: 0x003ADAB0
		public static Offset<IAwakeEntityRefSource> EndIAwakeEntityRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeEntityRefSource>(builder.EndTable());
		}

		// Token: 0x06019BD8 RID: 105432 RVA: 0x003AF8C0 File Offset: 0x003ADAC0
		public IAwakeEntityRefSourceT UnPack()
		{
			IAwakeEntityRefSourceT awakeEntityRefSourceT = new IAwakeEntityRefSourceT();
			this.UnPackTo(awakeEntityRefSourceT);
			return awakeEntityRefSourceT;
		}

		// Token: 0x06019BD9 RID: 105433 RVA: 0x003AF8DB File Offset: 0x003ADADB
		public void UnPackTo(IAwakeEntityRefSourceT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06019BDA RID: 105434 RVA: 0x003AF8F8 File Offset: 0x003ADAF8
		public static Offset<IAwakeEntityRefSource> Pack(FlatBufferBuilder builder, IAwakeEntityRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeEntityRefSource>);
			}
			return IAwakeEntityRefSource.CreateIAwakeEntityRefSource(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400C1C6 RID: 49606
		private Table __p;
	}
}
