using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004832 RID: 18482
	public struct IBuffDurationPermanent : IFlatbufferObject
	{
		// Token: 0x170084A2 RID: 33954
		// (get) Token: 0x0601C915 RID: 117013 RVA: 0x0040A231 File Offset: 0x00408431
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C916 RID: 117014 RVA: 0x0040A23E File Offset: 0x0040843E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C917 RID: 117015 RVA: 0x0040A248 File Offset: 0x00408448
		public static IBuffDurationPermanent GetRootAsIBuffDurationPermanent(ByteBuffer _bb)
		{
			return IBuffDurationPermanent.GetRootAsIBuffDurationPermanent(_bb, default(IBuffDurationPermanent));
		}

		// Token: 0x0601C918 RID: 117016 RVA: 0x0040A264 File Offset: 0x00408464
		public static IBuffDurationPermanent GetRootAsIBuffDurationPermanent(ByteBuffer _bb, IBuffDurationPermanent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C919 RID: 117017 RVA: 0x0040A281 File Offset: 0x00408481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C91A RID: 117018 RVA: 0x0040A290 File Offset: 0x00408490
		public IBuffDurationPermanent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084A3 RID: 33955
		// (get) Token: 0x0601C91B RID: 117019 RVA: 0x0040A2A0 File Offset: 0x004084A0
		public EBuffDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffDurationType.Instant;
				}
				return (EBuffDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C91C RID: 117020 RVA: 0x0040A2DC File Offset: 0x004084DC
		public static Offset<IBuffDurationPermanent> CreateIBuffDurationPermanent(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant)
		{
			builder.StartTable(1);
			IBuffDurationPermanent.AddType(builder, Type);
			return IBuffDurationPermanent.EndIBuffDurationPermanent(builder);
		}

		// Token: 0x0601C91D RID: 117021 RVA: 0x0040A2F2 File Offset: 0x004084F2
		public static void StartIBuffDurationPermanent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C91E RID: 117022 RVA: 0x0040A2FB File Offset: 0x004084FB
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C91F RID: 117023 RVA: 0x0040A306 File Offset: 0x00408506
		public static Offset<IBuffDurationPermanent> EndIBuffDurationPermanent(FlatBufferBuilder builder)
		{
			return new Offset<IBuffDurationPermanent>(builder.EndTable());
		}

		// Token: 0x0601C920 RID: 117024 RVA: 0x0040A314 File Offset: 0x00408514
		public IBuffDurationPermanentT UnPack()
		{
			IBuffDurationPermanentT buffDurationPermanentT = new IBuffDurationPermanentT();
			this.UnPackTo(buffDurationPermanentT);
			return buffDurationPermanentT;
		}

		// Token: 0x0601C921 RID: 117025 RVA: 0x0040A32F File Offset: 0x0040852F
		public void UnPackTo(IBuffDurationPermanentT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C922 RID: 117026 RVA: 0x0040A340 File Offset: 0x00408540
		public static Offset<IBuffDurationPermanent> Pack(FlatBufferBuilder builder, IBuffDurationPermanentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffDurationPermanent>);
			}
			return IBuffDurationPermanent.CreateIBuffDurationPermanent(builder, _o.Type);
		}

		// Token: 0x0400CD5E RID: 52574
		private Table __p;
	}
}
