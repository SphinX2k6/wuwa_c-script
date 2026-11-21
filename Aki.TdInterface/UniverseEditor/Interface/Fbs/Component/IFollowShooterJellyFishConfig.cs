using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580E RID: 22542
	public struct IFollowShooterJellyFishConfig : IFlatbufferObject
	{
		// Token: 0x1700A322 RID: 41762
		// (get) Token: 0x0602476E RID: 149358 RVA: 0x00502BC0 File Offset: 0x00500DC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602476F RID: 149359 RVA: 0x00502BCD File Offset: 0x00500DCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024770 RID: 149360 RVA: 0x00502BD4 File Offset: 0x00500DD4
		public static IFollowShooterJellyFishConfig GetRootAsIFollowShooterJellyFishConfig(ByteBuffer _bb)
		{
			return IFollowShooterJellyFishConfig.GetRootAsIFollowShooterJellyFishConfig(_bb, default(IFollowShooterJellyFishConfig));
		}

		// Token: 0x06024771 RID: 149361 RVA: 0x00502BF0 File Offset: 0x00500DF0
		public static IFollowShooterJellyFishConfig GetRootAsIFollowShooterJellyFishConfig(ByteBuffer _bb, IFollowShooterJellyFishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024772 RID: 149362 RVA: 0x00502C0D File Offset: 0x00500E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024773 RID: 149363 RVA: 0x00502C1C File Offset: 0x00500E1C
		public IFollowShooterJellyFishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A323 RID: 41763
		// (get) Token: 0x06024774 RID: 149364 RVA: 0x00502C2C File Offset: 0x00500E2C
		public EFollowShooterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterType.JellyFish;
				}
				return (EFollowShooterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A324 RID: 41764
		// (get) Token: 0x06024775 RID: 149365 RVA: 0x00502C68 File Offset: 0x00500E68
		public float ResetRange
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

		// Token: 0x1700A325 RID: 41765
		// (get) Token: 0x06024776 RID: 149366 RVA: 0x00502CA8 File Offset: 0x00500EA8
		public float ShineRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A326 RID: 41766
		// (get) Token: 0x06024777 RID: 149367 RVA: 0x00502CE8 File Offset: 0x00500EE8
		public int ShineEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024778 RID: 149368 RVA: 0x00502D28 File Offset: 0x00500F28
		public IFollowShooterMontage? MontageList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IFollowShooterMontage?(default(IFollowShooterMontage).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A327 RID: 41767
		// (get) Token: 0x06024779 RID: 149369 RVA: 0x00502D8C File Offset: 0x00500F8C
		public int MontageListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A328 RID: 41768
		// (get) Token: 0x0602477A RID: 149370 RVA: 0x00502DB8 File Offset: 0x00500FB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602477B RID: 149371 RVA: 0x00502DF5 File Offset: 0x00500FF5
		public static Offset<IFollowShooterJellyFishConfig> CreateIFollowShooterJellyFishConfig(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish, float ResetRange = 0f, float ShineRadius = 0f, int ShineEffect = 0, VectorOffset MontageListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFollowShooterJellyFishConfig.AddMontageList(builder, MontageListOffset);
			IFollowShooterJellyFishConfig.AddShineEffect(builder, ShineEffect);
			IFollowShooterJellyFishConfig.AddShineRadius(builder, ShineRadius);
			IFollowShooterJellyFishConfig.AddResetRange(builder, ResetRange);
			IFollowShooterJellyFishConfig.AddNullMask(builder, NullMask);
			IFollowShooterJellyFishConfig.AddType(builder, Type);
			return IFollowShooterJellyFishConfig.EndIFollowShooterJellyFishConfig(builder);
		}

		// Token: 0x0602477C RID: 149372 RVA: 0x00502E31 File Offset: 0x00501031
		public static void StartIFollowShooterJellyFishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602477D RID: 149373 RVA: 0x00502E3A File Offset: 0x0050103A
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602477E RID: 149374 RVA: 0x00502E45 File Offset: 0x00501045
		public static void AddResetRange(FlatBufferBuilder builder, float resetRange)
		{
			builder.AddFloat(1, resetRange, 0.0);
		}

		// Token: 0x0602477F RID: 149375 RVA: 0x00502E58 File Offset: 0x00501058
		public static void AddShineRadius(FlatBufferBuilder builder, float shineRadius)
		{
			builder.AddFloat(2, shineRadius, 0.0);
		}

		// Token: 0x06024780 RID: 149376 RVA: 0x00502E6B File Offset: 0x0050106B
		public static void AddShineEffect(FlatBufferBuilder builder, int shineEffect)
		{
			builder.AddInt(3, shineEffect, 0);
		}

		// Token: 0x06024781 RID: 149377 RVA: 0x00502E76 File Offset: 0x00501076
		public static void AddMontageList(FlatBufferBuilder builder, VectorOffset montageListOffset)
		{
			builder.AddOffset(4, montageListOffset.Value, 0);
		}

		// Token: 0x06024782 RID: 149378 RVA: 0x00502E88 File Offset: 0x00501088
		public static VectorOffset CreateMontageListVector(FlatBufferBuilder builder, Offset<IFollowShooterMontage>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024783 RID: 149379 RVA: 0x00502EC8 File Offset: 0x005010C8
		public static VectorOffset CreateMontageListVectorBlock(FlatBufferBuilder builder, Offset<IFollowShooterMontage>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFollowShooterMontage>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024784 RID: 149380 RVA: 0x00502EE2 File Offset: 0x005010E2
		public static VectorOffset CreateMontageListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFollowShooterMontage>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFollowShooterMontage>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024785 RID: 149381 RVA: 0x00502F00 File Offset: 0x00501100
		public static VectorOffset CreateMontageListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFollowShooterMontage>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024786 RID: 149382 RVA: 0x00502F19 File Offset: 0x00501119
		public static void StartMontageListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024787 RID: 149383 RVA: 0x00502F24 File Offset: 0x00501124
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06024788 RID: 149384 RVA: 0x00502F2F File Offset: 0x0050112F
		public static Offset<IFollowShooterJellyFishConfig> EndIFollowShooterJellyFishConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterJellyFishConfig>(builder.EndTable());
		}

		// Token: 0x06024789 RID: 149385 RVA: 0x00502F3C File Offset: 0x0050113C
		public IFollowShooterJellyFishConfigT UnPack()
		{
			IFollowShooterJellyFishConfigT followShooterJellyFishConfigT = new IFollowShooterJellyFishConfigT();
			this.UnPackTo(followShooterJellyFishConfigT);
			return followShooterJellyFishConfigT;
		}

		// Token: 0x0602478A RID: 149386 RVA: 0x00502F58 File Offset: 0x00501158
		public void UnPackTo(IFollowShooterJellyFishConfigT _o)
		{
			_o.Type = this.Type;
			_o.ResetRange = this.ResetRange;
			_o.ShineRadius = this.ShineRadius;
			_o.ShineEffect = this.ShineEffect;
			_o.MontageList = new List<IFollowShooterMontageT>();
			for (int i = 0; i < this.MontageListLength; i++)
			{
				_o.MontageList.Add((this.MontageList(i) != null) ? this.MontageList(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602478B RID: 149387 RVA: 0x00502FF4 File Offset: 0x005011F4
		public static Offset<IFollowShooterJellyFishConfig> Pack(FlatBufferBuilder builder, IFollowShooterJellyFishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterJellyFishConfig>);
			}
			VectorOffset montageListOffset = default(VectorOffset);
			if (_o.MontageList != null)
			{
				Offset<IFollowShooterMontage>[] array = new Offset<IFollowShooterMontage>[_o.MontageList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFollowShooterMontage.Pack(builder, _o.MontageList[i]);
				}
				montageListOffset = IFollowShooterJellyFishConfig.CreateMontageListVector(builder, array);
			}
			return IFollowShooterJellyFishConfig.CreateIFollowShooterJellyFishConfig(builder, _o.Type, _o.ResetRange, _o.ShineRadius, _o.ShineEffect, montageListOffset, _o.NullMask);
		}

		// Token: 0x0400F025 RID: 61477
		private Table __p;
	}
}
