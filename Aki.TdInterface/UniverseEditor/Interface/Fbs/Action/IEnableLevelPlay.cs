using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200666F RID: 26223
	public struct IEnableLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700C2CC RID: 49868
		// (get) Token: 0x0602D8DF RID: 186591 RVA: 0x0063CA7E File Offset: 0x0063AC7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D8E0 RID: 186592 RVA: 0x0063CA8B File Offset: 0x0063AC8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D8E1 RID: 186593 RVA: 0x0063CA94 File Offset: 0x0063AC94
		public static IEnableLevelPlay GetRootAsIEnableLevelPlay(ByteBuffer _bb)
		{
			return IEnableLevelPlay.GetRootAsIEnableLevelPlay(_bb, default(IEnableLevelPlay));
		}

		// Token: 0x0602D8E2 RID: 186594 RVA: 0x0063CAB0 File Offset: 0x0063ACB0
		public static IEnableLevelPlay GetRootAsIEnableLevelPlay(ByteBuffer _bb, IEnableLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D8E3 RID: 186595 RVA: 0x0063CACD File Offset: 0x0063ACCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D8E4 RID: 186596 RVA: 0x0063CADC File Offset: 0x0063ACDC
		public IEnableLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D8E5 RID: 186597 RVA: 0x0063CAEC File Offset: 0x0063ACEC
		public IEnableLevelPlayConfig? Configs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEnableLevelPlayConfig?(default(IEnableLevelPlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C2CD RID: 49869
		// (get) Token: 0x0602D8E6 RID: 186598 RVA: 0x0063CB4C File Offset: 0x0063AD4C
		public int ConfigsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C2CE RID: 49870
		// (get) Token: 0x0602D8E7 RID: 186599 RVA: 0x0063CB78 File Offset: 0x0063AD78
		public EPlayerType TargetPlayer
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPlayerType.P1;
				}
				return (EPlayerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2CF RID: 49871
		// (get) Token: 0x0602D8E8 RID: 186600 RVA: 0x0063CBB4 File Offset: 0x0063ADB4
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

		// Token: 0x0602D8E9 RID: 186601 RVA: 0x0063CBF0 File Offset: 0x0063ADF0
		public static Offset<IEnableLevelPlay> CreateIEnableLevelPlay(FlatBufferBuilder builder, VectorOffset ConfigsOffset = default(VectorOffset), EPlayerType TargetPlayer = EPlayerType.P1, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEnableLevelPlay.AddConfigs(builder, ConfigsOffset);
			IEnableLevelPlay.AddNullMask(builder, NullMask);
			IEnableLevelPlay.AddTargetPlayer(builder, TargetPlayer);
			return IEnableLevelPlay.EndIEnableLevelPlay(builder);
		}

		// Token: 0x0602D8EA RID: 186602 RVA: 0x0063CC14 File Offset: 0x0063AE14
		public static void StartIEnableLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D8EB RID: 186603 RVA: 0x0063CC1D File Offset: 0x0063AE1D
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(0, configsOffset.Value, 0);
		}

		// Token: 0x0602D8EC RID: 186604 RVA: 0x0063CC30 File Offset: 0x0063AE30
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D8ED RID: 186605 RVA: 0x0063CC70 File Offset: 0x0063AE70
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D8EE RID: 186606 RVA: 0x0063CC8A File Offset: 0x0063AE8A
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEnableLevelPlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D8EF RID: 186607 RVA: 0x0063CCA8 File Offset: 0x0063AEA8
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEnableLevelPlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D8F0 RID: 186608 RVA: 0x0063CCC1 File Offset: 0x0063AEC1
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D8F1 RID: 186609 RVA: 0x0063CCCC File Offset: 0x0063AECC
		public static void AddTargetPlayer(FlatBufferBuilder builder, EPlayerType targetPlayer)
		{
			builder.AddByte(1, (byte)targetPlayer, 0);
		}

		// Token: 0x0602D8F2 RID: 186610 RVA: 0x0063CCD7 File Offset: 0x0063AED7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602D8F3 RID: 186611 RVA: 0x0063CCE2 File Offset: 0x0063AEE2
		public static Offset<IEnableLevelPlay> EndIEnableLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IEnableLevelPlay>(builder.EndTable());
		}

		// Token: 0x0602D8F4 RID: 186612 RVA: 0x0063CCF0 File Offset: 0x0063AEF0
		public IEnableLevelPlayT UnPack()
		{
			IEnableLevelPlayT enableLevelPlayT = new IEnableLevelPlayT();
			this.UnPackTo(enableLevelPlayT);
			return enableLevelPlayT;
		}

		// Token: 0x0602D8F5 RID: 186613 RVA: 0x0063CD0C File Offset: 0x0063AF0C
		public void UnPackTo(IEnableLevelPlayT _o)
		{
			_o.Configs = new List<IEnableLevelPlayConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
			_o.TargetPlayer = this.TargetPlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D8F6 RID: 186614 RVA: 0x0063CD84 File Offset: 0x0063AF84
		public static Offset<IEnableLevelPlay> Pack(FlatBufferBuilder builder, IEnableLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableLevelPlay>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<IEnableLevelPlayConfig>[] array = new Offset<IEnableLevelPlayConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEnableLevelPlayConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = IEnableLevelPlay.CreateConfigsVector(builder, array);
			}
			return IEnableLevelPlay.CreateIEnableLevelPlay(builder, configsOffset, _o.TargetPlayer, _o.NullMask);
		}

		// Token: 0x04010D16 RID: 68886
		private Table __p;
	}
}
