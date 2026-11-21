using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE3 RID: 27875
	public struct IEnableLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700CC6F RID: 52335
		// (get) Token: 0x060300C8 RID: 196808 RVA: 0x0068981A File Offset: 0x00687A1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300C9 RID: 196809 RVA: 0x00689827 File Offset: 0x00687A27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060300CA RID: 196810 RVA: 0x00689830 File Offset: 0x00687A30
		public static IEnableLevelPlay GetRootAsIEnableLevelPlay(ByteBuffer _bb)
		{
			return IEnableLevelPlay.GetRootAsIEnableLevelPlay(_bb, default(IEnableLevelPlay));
		}

		// Token: 0x060300CB RID: 196811 RVA: 0x0068984C File Offset: 0x00687A4C
		public static IEnableLevelPlay GetRootAsIEnableLevelPlay(ByteBuffer _bb, IEnableLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060300CC RID: 196812 RVA: 0x00689869 File Offset: 0x00687A69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060300CD RID: 196813 RVA: 0x00689878 File Offset: 0x00687A78
		public IEnableLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060300CE RID: 196814 RVA: 0x00689888 File Offset: 0x00687A88
		public IEnableLevelPlayConfig? Configs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEnableLevelPlayConfig?(default(IEnableLevelPlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CC70 RID: 52336
		// (get) Token: 0x060300CF RID: 196815 RVA: 0x006898E8 File Offset: 0x00687AE8
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

		// Token: 0x1700CC71 RID: 52337
		// (get) Token: 0x060300D0 RID: 196816 RVA: 0x00689914 File Offset: 0x00687B14
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

		// Token: 0x1700CC72 RID: 52338
		// (get) Token: 0x060300D1 RID: 196817 RVA: 0x00689950 File Offset: 0x00687B50
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

		// Token: 0x060300D2 RID: 196818 RVA: 0x0068998C File Offset: 0x00687B8C
		public static Offset<IEnableLevelPlay> CreateIEnableLevelPlay(FlatBufferBuilder builder, VectorOffset ConfigsOffset = default(VectorOffset), EPlayerType TargetPlayer = EPlayerType.P1, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEnableLevelPlay.AddConfigs(builder, ConfigsOffset);
			IEnableLevelPlay.AddNullMask(builder, NullMask);
			IEnableLevelPlay.AddTargetPlayer(builder, TargetPlayer);
			return IEnableLevelPlay.EndIEnableLevelPlay(builder);
		}

		// Token: 0x060300D3 RID: 196819 RVA: 0x006899B0 File Offset: 0x00687BB0
		public static void StartIEnableLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060300D4 RID: 196820 RVA: 0x006899B9 File Offset: 0x00687BB9
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(0, configsOffset.Value, 0);
		}

		// Token: 0x060300D5 RID: 196821 RVA: 0x006899CC File Offset: 0x00687BCC
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060300D6 RID: 196822 RVA: 0x00689A0C File Offset: 0x00687C0C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060300D7 RID: 196823 RVA: 0x00689A26 File Offset: 0x00687C26
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEnableLevelPlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060300D8 RID: 196824 RVA: 0x00689A44 File Offset: 0x00687C44
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEnableLevelPlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060300D9 RID: 196825 RVA: 0x00689A5D File Offset: 0x00687C5D
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060300DA RID: 196826 RVA: 0x00689A68 File Offset: 0x00687C68
		public static void AddTargetPlayer(FlatBufferBuilder builder, EPlayerType targetPlayer)
		{
			builder.AddByte(1, (byte)targetPlayer, 0);
		}

		// Token: 0x060300DB RID: 196827 RVA: 0x00689A73 File Offset: 0x00687C73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060300DC RID: 196828 RVA: 0x00689A7E File Offset: 0x00687C7E
		public static Offset<IEnableLevelPlay> EndIEnableLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IEnableLevelPlay>(builder.EndTable());
		}

		// Token: 0x060300DD RID: 196829 RVA: 0x00689A8C File Offset: 0x00687C8C
		public IEnableLevelPlayT UnPack()
		{
			IEnableLevelPlayT enableLevelPlayT = new IEnableLevelPlayT();
			this.UnPackTo(enableLevelPlayT);
			return enableLevelPlayT;
		}

		// Token: 0x060300DE RID: 196830 RVA: 0x00689AA8 File Offset: 0x00687CA8
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

		// Token: 0x060300DF RID: 196831 RVA: 0x00689B20 File Offset: 0x00687D20
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

		// Token: 0x04011B34 RID: 72500
		private Table __p;
	}
}
