using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE9 RID: 15337
	public struct IActorRefVolume : IFlatbufferObject
	{
		// Token: 0x17006939 RID: 26937
		// (get) Token: 0x06015167 RID: 86375 RVA: 0x0030E558 File Offset: 0x0030C758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015168 RID: 86376 RVA: 0x0030E565 File Offset: 0x0030C765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015169 RID: 86377 RVA: 0x0030E56C File Offset: 0x0030C76C
		public static IActorRefVolume GetRootAsIActorRefVolume(ByteBuffer _bb)
		{
			return IActorRefVolume.GetRootAsIActorRefVolume(_bb, default(IActorRefVolume));
		}

		// Token: 0x0601516A RID: 86378 RVA: 0x0030E588 File Offset: 0x0030C788
		public static IActorRefVolume GetRootAsIActorRefVolume(ByteBuffer _bb, IActorRefVolume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601516B RID: 86379 RVA: 0x0030E5A5 File Offset: 0x0030C7A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601516C RID: 86380 RVA: 0x0030E5B4 File Offset: 0x0030C7B4
		public IActorRefVolume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700693A RID: 26938
		// (get) Token: 0x0601516D RID: 86381 RVA: 0x0030E5C4 File Offset: 0x0030C7C4
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601516E RID: 86382 RVA: 0x0030E600 File Offset: 0x0030C800
		public static Offset<IActorRefVolume> CreateIActorRefVolume(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box)
		{
			builder.StartTable(1);
			IActorRefVolume.AddType(builder, Type);
			return IActorRefVolume.EndIActorRefVolume(builder);
		}

		// Token: 0x0601516F RID: 86383 RVA: 0x0030E616 File Offset: 0x0030C816
		public static void StartIActorRefVolume(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015170 RID: 86384 RVA: 0x0030E61F File Offset: 0x0030C81F
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015171 RID: 86385 RVA: 0x0030E62A File Offset: 0x0030C82A
		public static Offset<IActorRefVolume> EndIActorRefVolume(FlatBufferBuilder builder)
		{
			return new Offset<IActorRefVolume>(builder.EndTable());
		}

		// Token: 0x06015172 RID: 86386 RVA: 0x0030E638 File Offset: 0x0030C838
		public IActorRefVolumeT UnPack()
		{
			IActorRefVolumeT actorRefVolumeT = new IActorRefVolumeT();
			this.UnPackTo(actorRefVolumeT);
			return actorRefVolumeT;
		}

		// Token: 0x06015173 RID: 86387 RVA: 0x0030E653 File Offset: 0x0030C853
		public void UnPackTo(IActorRefVolumeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015174 RID: 86388 RVA: 0x0030E664 File Offset: 0x0030C864
		public static Offset<IActorRefVolume> Pack(FlatBufferBuilder builder, IActorRefVolumeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorRefVolume>);
			}
			return IActorRefVolume.CreateIActorRefVolume(builder, _o.Type);
		}

		// Token: 0x0400B1AD RID: 45485
		private Table __p;
	}
}
