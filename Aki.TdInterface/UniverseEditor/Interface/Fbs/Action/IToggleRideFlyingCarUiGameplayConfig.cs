using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C02 RID: 31746
	public struct IToggleRideFlyingCarUiGameplayConfig : IFlatbufferObject
	{
		// Token: 0x1700EDC3 RID: 60867
		// (get) Token: 0x06039386 RID: 234374 RVA: 0x007BADB1 File Offset: 0x007B8FB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039387 RID: 234375 RVA: 0x007BADBE File Offset: 0x007B8FBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039388 RID: 234376 RVA: 0x007BADC8 File Offset: 0x007B8FC8
		public static IToggleRideFlyingCarUiGameplayConfig GetRootAsIToggleRideFlyingCarUiGameplayConfig(ByteBuffer _bb)
		{
			return IToggleRideFlyingCarUiGameplayConfig.GetRootAsIToggleRideFlyingCarUiGameplayConfig(_bb, default(IToggleRideFlyingCarUiGameplayConfig));
		}

		// Token: 0x06039389 RID: 234377 RVA: 0x007BADE4 File Offset: 0x007B8FE4
		public static IToggleRideFlyingCarUiGameplayConfig GetRootAsIToggleRideFlyingCarUiGameplayConfig(ByteBuffer _bb, IToggleRideFlyingCarUiGameplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603938A RID: 234378 RVA: 0x007BAE01 File Offset: 0x007B9001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603938B RID: 234379 RVA: 0x007BAE10 File Offset: 0x007B9010
		public IToggleRideFlyingCarUiGameplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDC4 RID: 60868
		// (get) Token: 0x0603938C RID: 234380 RVA: 0x007BAE20 File Offset: 0x007B9020
		public EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleRideFlyingCarUiGameplayType.Enable;
				}
				return (EToggleRideFlyingCarUiGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603938D RID: 234381 RVA: 0x007BAE5C File Offset: 0x007B905C
		public static Offset<IToggleRideFlyingCarUiGameplayConfig> CreateIToggleRideFlyingCarUiGameplayConfig(FlatBufferBuilder builder, EToggleRideFlyingCarUiGameplayType Type = EToggleRideFlyingCarUiGameplayType.Enable)
		{
			builder.StartTable(1);
			IToggleRideFlyingCarUiGameplayConfig.AddType(builder, Type);
			return IToggleRideFlyingCarUiGameplayConfig.EndIToggleRideFlyingCarUiGameplayConfig(builder);
		}

		// Token: 0x0603938E RID: 234382 RVA: 0x007BAE72 File Offset: 0x007B9072
		public static void StartIToggleRideFlyingCarUiGameplayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603938F RID: 234383 RVA: 0x007BAE7B File Offset: 0x007B907B
		public static void AddType(FlatBufferBuilder builder, EToggleRideFlyingCarUiGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039390 RID: 234384 RVA: 0x007BAE86 File Offset: 0x007B9086
		public static Offset<IToggleRideFlyingCarUiGameplayConfig> EndIToggleRideFlyingCarUiGameplayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IToggleRideFlyingCarUiGameplayConfig>(builder.EndTable());
		}

		// Token: 0x06039391 RID: 234385 RVA: 0x007BAE94 File Offset: 0x007B9094
		public IToggleRideFlyingCarUiGameplayConfigT UnPack()
		{
			IToggleRideFlyingCarUiGameplayConfigT toggleRideFlyingCarUiGameplayConfigT = new IToggleRideFlyingCarUiGameplayConfigT();
			this.UnPackTo(toggleRideFlyingCarUiGameplayConfigT);
			return toggleRideFlyingCarUiGameplayConfigT;
		}

		// Token: 0x06039392 RID: 234386 RVA: 0x007BAEAF File Offset: 0x007B90AF
		public void UnPackTo(IToggleRideFlyingCarUiGameplayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039393 RID: 234387 RVA: 0x007BAEC0 File Offset: 0x007B90C0
		public static Offset<IToggleRideFlyingCarUiGameplayConfig> Pack(FlatBufferBuilder builder, IToggleRideFlyingCarUiGameplayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleRideFlyingCarUiGameplayConfig>);
			}
			return IToggleRideFlyingCarUiGameplayConfig.CreateIToggleRideFlyingCarUiGameplayConfig(builder, _o.Type);
		}

		// Token: 0x040132A6 RID: 78502
		private Table __p;
	}
}
