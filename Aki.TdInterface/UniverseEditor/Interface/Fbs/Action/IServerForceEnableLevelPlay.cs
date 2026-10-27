using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8A RID: 28554
	public struct IServerForceEnableLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700D417 RID: 54295
		// (get) Token: 0x06032758 RID: 206680 RVA: 0x006CFAF8 File Offset: 0x006CDCF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032759 RID: 206681 RVA: 0x006CFB05 File Offset: 0x006CDD05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603275A RID: 206682 RVA: 0x006CFB0C File Offset: 0x006CDD0C
		public static IServerForceEnableLevelPlay GetRootAsIServerForceEnableLevelPlay(ByteBuffer _bb)
		{
			return IServerForceEnableLevelPlay.GetRootAsIServerForceEnableLevelPlay(_bb, default(IServerForceEnableLevelPlay));
		}

		// Token: 0x0603275B RID: 206683 RVA: 0x006CFB28 File Offset: 0x006CDD28
		public static IServerForceEnableLevelPlay GetRootAsIServerForceEnableLevelPlay(ByteBuffer _bb, IServerForceEnableLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603275C RID: 206684 RVA: 0x006CFB45 File Offset: 0x006CDD45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603275D RID: 206685 RVA: 0x006CFB54 File Offset: 0x006CDD54
		public IServerForceEnableLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603275E RID: 206686 RVA: 0x006CFB64 File Offset: 0x006CDD64
		public IEnableLevelPlayConfig? Configs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEnableLevelPlayConfig?(default(IEnableLevelPlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D418 RID: 54296
		// (get) Token: 0x0603275F RID: 206687 RVA: 0x006CFBC4 File Offset: 0x006CDDC4
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

		// Token: 0x06032760 RID: 206688 RVA: 0x006CFBEF File Offset: 0x006CDDEF
		public static Offset<IServerForceEnableLevelPlay> CreateIServerForceEnableLevelPlay(FlatBufferBuilder builder, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IServerForceEnableLevelPlay.AddConfigs(builder, ConfigsOffset);
			return IServerForceEnableLevelPlay.EndIServerForceEnableLevelPlay(builder);
		}

		// Token: 0x06032761 RID: 206689 RVA: 0x006CFC05 File Offset: 0x006CDE05
		public static void StartIServerForceEnableLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032762 RID: 206690 RVA: 0x006CFC0E File Offset: 0x006CDE0E
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(0, configsOffset.Value, 0);
		}

		// Token: 0x06032763 RID: 206691 RVA: 0x006CFC20 File Offset: 0x006CDE20
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032764 RID: 206692 RVA: 0x006CFC60 File Offset: 0x006CDE60
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032765 RID: 206693 RVA: 0x006CFC7A File Offset: 0x006CDE7A
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEnableLevelPlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032766 RID: 206694 RVA: 0x006CFC98 File Offset: 0x006CDE98
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEnableLevelPlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032767 RID: 206695 RVA: 0x006CFCB1 File Offset: 0x006CDEB1
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032768 RID: 206696 RVA: 0x006CFCBC File Offset: 0x006CDEBC
		public static Offset<IServerForceEnableLevelPlay> EndIServerForceEnableLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IServerForceEnableLevelPlay>(builder.EndTable());
		}

		// Token: 0x06032769 RID: 206697 RVA: 0x006CFCCC File Offset: 0x006CDECC
		public IServerForceEnableLevelPlayT UnPack()
		{
			IServerForceEnableLevelPlayT serverForceEnableLevelPlayT = new IServerForceEnableLevelPlayT();
			this.UnPackTo(serverForceEnableLevelPlayT);
			return serverForceEnableLevelPlayT;
		}

		// Token: 0x0603276A RID: 206698 RVA: 0x006CFCE8 File Offset: 0x006CDEE8
		public void UnPackTo(IServerForceEnableLevelPlayT _o)
		{
			_o.Configs = new List<IEnableLevelPlayConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603276B RID: 206699 RVA: 0x006CFD48 File Offset: 0x006CDF48
		public static Offset<IServerForceEnableLevelPlay> Pack(FlatBufferBuilder builder, IServerForceEnableLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IServerForceEnableLevelPlay>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<IEnableLevelPlayConfig>[] array = new Offset<IEnableLevelPlayConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEnableLevelPlayConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = IServerForceEnableLevelPlay.CreateConfigsVector(builder, array);
			}
			return IServerForceEnableLevelPlay.CreateIServerForceEnableLevelPlay(builder, configsOffset);
		}

		// Token: 0x04011987 RID: 72071
		private Table __p;
	}
}
