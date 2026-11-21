using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007750 RID: 30544
	public struct IServerForceEnableLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700DFE6 RID: 57318
		// (get) Token: 0x060359A8 RID: 219560 RVA: 0x0072F4B0 File Offset: 0x0072D6B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060359A9 RID: 219561 RVA: 0x0072F4BD File Offset: 0x0072D6BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060359AA RID: 219562 RVA: 0x0072F4C4 File Offset: 0x0072D6C4
		public static IServerForceEnableLevelPlay GetRootAsIServerForceEnableLevelPlay(ByteBuffer _bb)
		{
			return IServerForceEnableLevelPlay.GetRootAsIServerForceEnableLevelPlay(_bb, default(IServerForceEnableLevelPlay));
		}

		// Token: 0x060359AB RID: 219563 RVA: 0x0072F4E0 File Offset: 0x0072D6E0
		public static IServerForceEnableLevelPlay GetRootAsIServerForceEnableLevelPlay(ByteBuffer _bb, IServerForceEnableLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060359AC RID: 219564 RVA: 0x0072F4FD File Offset: 0x0072D6FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060359AD RID: 219565 RVA: 0x0072F50C File Offset: 0x0072D70C
		public IServerForceEnableLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060359AE RID: 219566 RVA: 0x0072F51C File Offset: 0x0072D71C
		public IEnableLevelPlayConfig? Configs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEnableLevelPlayConfig?(default(IEnableLevelPlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFE7 RID: 57319
		// (get) Token: 0x060359AF RID: 219567 RVA: 0x0072F57C File Offset: 0x0072D77C
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

		// Token: 0x060359B0 RID: 219568 RVA: 0x0072F5A7 File Offset: 0x0072D7A7
		public static Offset<IServerForceEnableLevelPlay> CreateIServerForceEnableLevelPlay(FlatBufferBuilder builder, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IServerForceEnableLevelPlay.AddConfigs(builder, ConfigsOffset);
			return IServerForceEnableLevelPlay.EndIServerForceEnableLevelPlay(builder);
		}

		// Token: 0x060359B1 RID: 219569 RVA: 0x0072F5BD File Offset: 0x0072D7BD
		public static void StartIServerForceEnableLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060359B2 RID: 219570 RVA: 0x0072F5C6 File Offset: 0x0072D7C6
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(0, configsOffset.Value, 0);
		}

		// Token: 0x060359B3 RID: 219571 RVA: 0x0072F5D8 File Offset: 0x0072D7D8
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060359B4 RID: 219572 RVA: 0x0072F618 File Offset: 0x0072D818
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IEnableLevelPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060359B5 RID: 219573 RVA: 0x0072F632 File Offset: 0x0072D832
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEnableLevelPlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEnableLevelPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060359B6 RID: 219574 RVA: 0x0072F650 File Offset: 0x0072D850
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEnableLevelPlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060359B7 RID: 219575 RVA: 0x0072F669 File Offset: 0x0072D869
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060359B8 RID: 219576 RVA: 0x0072F674 File Offset: 0x0072D874
		public static Offset<IServerForceEnableLevelPlay> EndIServerForceEnableLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IServerForceEnableLevelPlay>(builder.EndTable());
		}

		// Token: 0x060359B9 RID: 219577 RVA: 0x0072F684 File Offset: 0x0072D884
		public IServerForceEnableLevelPlayT UnPack()
		{
			IServerForceEnableLevelPlayT serverForceEnableLevelPlayT = new IServerForceEnableLevelPlayT();
			this.UnPackTo(serverForceEnableLevelPlayT);
			return serverForceEnableLevelPlayT;
		}

		// Token: 0x060359BA RID: 219578 RVA: 0x0072F6A0 File Offset: 0x0072D8A0
		public void UnPackTo(IServerForceEnableLevelPlayT _o)
		{
			_o.Configs = new List<IEnableLevelPlayConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060359BB RID: 219579 RVA: 0x0072F700 File Offset: 0x0072D900
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

		// Token: 0x04012969 RID: 76137
		private Table __p;
	}
}
