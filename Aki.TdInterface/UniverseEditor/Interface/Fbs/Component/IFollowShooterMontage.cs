using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005811 RID: 22545
	public struct IFollowShooterMontage : IFlatbufferObject
	{
		// Token: 0x1700A32F RID: 41775
		// (get) Token: 0x0602479A RID: 149402 RVA: 0x005031B7 File Offset: 0x005013B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602479B RID: 149403 RVA: 0x005031C4 File Offset: 0x005013C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602479C RID: 149404 RVA: 0x005031CC File Offset: 0x005013CC
		public static IFollowShooterMontage GetRootAsIFollowShooterMontage(ByteBuffer _bb)
		{
			return IFollowShooterMontage.GetRootAsIFollowShooterMontage(_bb, default(IFollowShooterMontage));
		}

		// Token: 0x0602479D RID: 149405 RVA: 0x005031E8 File Offset: 0x005013E8
		public static IFollowShooterMontage GetRootAsIFollowShooterMontage(ByteBuffer _bb, IFollowShooterMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602479E RID: 149406 RVA: 0x00503205 File Offset: 0x00501405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602479F RID: 149407 RVA: 0x00503214 File Offset: 0x00501414
		public IFollowShooterMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A330 RID: 41776
		// (get) Token: 0x060247A0 RID: 149408 RVA: 0x00503224 File Offset: 0x00501424
		public EFollowShooterMontageType Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterMontageType.Born;
				}
				return (EFollowShooterMontageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A331 RID: 41777
		// (get) Token: 0x060247A1 RID: 149409 RVA: 0x00503260 File Offset: 0x00501460
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247A2 RID: 149410 RVA: 0x00503297 File Offset: 0x00501497
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060247A3 RID: 149411 RVA: 0x005032A6 File Offset: 0x005014A6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060247A4 RID: 149412 RVA: 0x005032B4 File Offset: 0x005014B4
		public static Offset<IFollowShooterMontage> CreateIFollowShooterMontage(FlatBufferBuilder builder, EFollowShooterMontageType Name = EFollowShooterMontageType.Born, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFollowShooterMontage.AddPath(builder, PathOffset);
			IFollowShooterMontage.AddName(builder, Name);
			return IFollowShooterMontage.EndIFollowShooterMontage(builder);
		}

		// Token: 0x060247A5 RID: 149413 RVA: 0x005032D1 File Offset: 0x005014D1
		public static void StartIFollowShooterMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060247A6 RID: 149414 RVA: 0x005032DA File Offset: 0x005014DA
		public static void AddName(FlatBufferBuilder builder, EFollowShooterMontageType name)
		{
			builder.AddByte(0, (byte)name, 0);
		}

		// Token: 0x060247A7 RID: 149415 RVA: 0x005032E5 File Offset: 0x005014E5
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x060247A8 RID: 149416 RVA: 0x005032F5 File Offset: 0x005014F5
		public static Offset<IFollowShooterMontage> EndIFollowShooterMontage(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterMontage>(builder.EndTable());
		}

		// Token: 0x060247A9 RID: 149417 RVA: 0x00503304 File Offset: 0x00501504
		public IFollowShooterMontageT UnPack()
		{
			IFollowShooterMontageT followShooterMontageT = new IFollowShooterMontageT();
			this.UnPackTo(followShooterMontageT);
			return followShooterMontageT;
		}

		// Token: 0x060247AA RID: 149418 RVA: 0x0050331F File Offset: 0x0050151F
		public void UnPackTo(IFollowShooterMontageT _o)
		{
			_o.Name = this.Name;
			_o.Path = this.Path;
		}

		// Token: 0x060247AB RID: 149419 RVA: 0x0050333C File Offset: 0x0050153C
		public static Offset<IFollowShooterMontage> Pack(FlatBufferBuilder builder, IFollowShooterMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterMontage>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IFollowShooterMontage.CreateIFollowShooterMontage(builder, _o.Name, pathOffset);
		}

		// Token: 0x0400F02C RID: 61484
		private Table __p;
	}
}
