using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A4 RID: 21924
	public struct ICreateStageConfig : IFlatbufferObject
	{
		// Token: 0x17009CFA RID: 40186
		// (get) Token: 0x06022DEB RID: 142827 RVA: 0x004CD65D File Offset: 0x004CB85D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DEC RID: 142828 RVA: 0x004CD66A File Offset: 0x004CB86A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DED RID: 142829 RVA: 0x004CD674 File Offset: 0x004CB874
		public static ICreateStageConfig GetRootAsICreateStageConfig(ByteBuffer _bb)
		{
			return ICreateStageConfig.GetRootAsICreateStageConfig(_bb, default(ICreateStageConfig));
		}

		// Token: 0x06022DEE RID: 142830 RVA: 0x004CD690 File Offset: 0x004CB890
		public static ICreateStageConfig GetRootAsICreateStageConfig(ByteBuffer _bb, ICreateStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DEF RID: 142831 RVA: 0x004CD6AD File Offset: 0x004CB8AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DF0 RID: 142832 RVA: 0x004CD6BC File Offset: 0x004CB8BC
		public ICreateStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CFB RID: 40187
		// (get) Token: 0x06022DF1 RID: 142833 RVA: 0x004CD6CC File Offset: 0x004CB8CC
		public float PerformDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CFC RID: 40188
		// (get) Token: 0x06022DF2 RID: 142834 RVA: 0x004CD70C File Offset: 0x004CB90C
		public ICreateBulletConfig? BulletConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICreateBulletConfig?(default(ICreateBulletConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022DF3 RID: 142835 RVA: 0x004CD76C File Offset: 0x004CB96C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CFD RID: 40189
		// (get) Token: 0x06022DF4 RID: 142836 RVA: 0x004CD7CC File Offset: 0x004CB9CC
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009CFE RID: 40190
		// (get) Token: 0x06022DF5 RID: 142837 RVA: 0x004CD7F8 File Offset: 0x004CB9F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022DF6 RID: 142838 RVA: 0x004CD835 File Offset: 0x004CBA35
		public static Offset<ICreateStageConfig> CreateICreateStageConfig(FlatBufferBuilder builder, float PerformDuration = 0f, Offset<ICreateBulletConfig> BulletConfigOffset = default(Offset<ICreateBulletConfig>), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICreateStageConfig.AddActions(builder, ActionsOffset);
			ICreateStageConfig.AddBulletConfig(builder, BulletConfigOffset);
			ICreateStageConfig.AddPerformDuration(builder, PerformDuration);
			ICreateStageConfig.AddNullMask(builder, NullMask);
			return ICreateStageConfig.EndICreateStageConfig(builder);
		}

		// Token: 0x06022DF7 RID: 142839 RVA: 0x004CD861 File Offset: 0x004CBA61
		public static void StartICreateStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022DF8 RID: 142840 RVA: 0x004CD86A File Offset: 0x004CBA6A
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(0, performDuration, 0.0);
		}

		// Token: 0x06022DF9 RID: 142841 RVA: 0x004CD87D File Offset: 0x004CBA7D
		public static void AddBulletConfig(FlatBufferBuilder builder, Offset<ICreateBulletConfig> bulletConfigOffset)
		{
			builder.AddOffset(1, bulletConfigOffset.Value, 0);
		}

		// Token: 0x06022DFA RID: 142842 RVA: 0x004CD88D File Offset: 0x004CBA8D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06022DFB RID: 142843 RVA: 0x004CD8A0 File Offset: 0x004CBAA0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022DFC RID: 142844 RVA: 0x004CD8E0 File Offset: 0x004CBAE0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022DFD RID: 142845 RVA: 0x004CD8FA File Offset: 0x004CBAFA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022DFE RID: 142846 RVA: 0x004CD918 File Offset: 0x004CBB18
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022DFF RID: 142847 RVA: 0x004CD931 File Offset: 0x004CBB31
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022E00 RID: 142848 RVA: 0x004CD93C File Offset: 0x004CBB3C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022E01 RID: 142849 RVA: 0x004CD947 File Offset: 0x004CBB47
		public static Offset<ICreateStageConfig> EndICreateStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICreateStageConfig>(builder.EndTable());
		}

		// Token: 0x06022E02 RID: 142850 RVA: 0x004CD954 File Offset: 0x004CBB54
		public ICreateStageConfigT UnPack()
		{
			ICreateStageConfigT createStageConfigT = new ICreateStageConfigT();
			this.UnPackTo(createStageConfigT);
			return createStageConfigT;
		}

		// Token: 0x06022E03 RID: 142851 RVA: 0x004CD970 File Offset: 0x004CBB70
		public void UnPackTo(ICreateStageConfigT _o)
		{
			_o.PerformDuration = this.PerformDuration;
			_o.BulletConfig = ((this.BulletConfig != null) ? this.BulletConfig.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022E04 RID: 142852 RVA: 0x004CDA18 File Offset: 0x004CBC18
		public static Offset<ICreateStageConfig> Pack(FlatBufferBuilder builder, ICreateStageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreateStageConfig>);
			}
			Offset<ICreateBulletConfig> bulletConfigOffset = (_o.BulletConfig == null) ? default(Offset<ICreateBulletConfig>) : ICreateBulletConfig.Pack(builder, _o.BulletConfig);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ICreateStageConfig.CreateActionsVector(builder, array);
			}
			return ICreateStageConfig.CreateICreateStageConfig(builder, _o.PerformDuration, bulletConfigOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400EC2D RID: 60461
		private Table __p;
	}
}
