using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005045 RID: 20549
	public struct ICreateStageConfig : IFlatbufferObject
	{
		// Token: 0x17009519 RID: 38169
		// (get) Token: 0x06020ECB RID: 134859 RVA: 0x00493C0D File Offset: 0x00491E0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020ECC RID: 134860 RVA: 0x00493C1A File Offset: 0x00491E1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020ECD RID: 134861 RVA: 0x00493C24 File Offset: 0x00491E24
		public static ICreateStageConfig GetRootAsICreateStageConfig(ByteBuffer _bb)
		{
			return ICreateStageConfig.GetRootAsICreateStageConfig(_bb, default(ICreateStageConfig));
		}

		// Token: 0x06020ECE RID: 134862 RVA: 0x00493C40 File Offset: 0x00491E40
		public static ICreateStageConfig GetRootAsICreateStageConfig(ByteBuffer _bb, ICreateStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020ECF RID: 134863 RVA: 0x00493C5D File Offset: 0x00491E5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020ED0 RID: 134864 RVA: 0x00493C6C File Offset: 0x00491E6C
		public ICreateStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700951A RID: 38170
		// (get) Token: 0x06020ED1 RID: 134865 RVA: 0x00493C7C File Offset: 0x00491E7C
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

		// Token: 0x1700951B RID: 38171
		// (get) Token: 0x06020ED2 RID: 134866 RVA: 0x00493CBC File Offset: 0x00491EBC
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

		// Token: 0x06020ED3 RID: 134867 RVA: 0x00493D1C File Offset: 0x00491F1C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700951C RID: 38172
		// (get) Token: 0x06020ED4 RID: 134868 RVA: 0x00493D7C File Offset: 0x00491F7C
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

		// Token: 0x1700951D RID: 38173
		// (get) Token: 0x06020ED5 RID: 134869 RVA: 0x00493DA8 File Offset: 0x00491FA8
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

		// Token: 0x06020ED6 RID: 134870 RVA: 0x00493DE5 File Offset: 0x00491FE5
		public static Offset<ICreateStageConfig> CreateICreateStageConfig(FlatBufferBuilder builder, float PerformDuration = 0f, Offset<ICreateBulletConfig> BulletConfigOffset = default(Offset<ICreateBulletConfig>), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICreateStageConfig.AddActions(builder, ActionsOffset);
			ICreateStageConfig.AddBulletConfig(builder, BulletConfigOffset);
			ICreateStageConfig.AddPerformDuration(builder, PerformDuration);
			ICreateStageConfig.AddNullMask(builder, NullMask);
			return ICreateStageConfig.EndICreateStageConfig(builder);
		}

		// Token: 0x06020ED7 RID: 134871 RVA: 0x00493E11 File Offset: 0x00492011
		public static void StartICreateStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020ED8 RID: 134872 RVA: 0x00493E1A File Offset: 0x0049201A
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(0, performDuration, 0.0);
		}

		// Token: 0x06020ED9 RID: 134873 RVA: 0x00493E2D File Offset: 0x0049202D
		public static void AddBulletConfig(FlatBufferBuilder builder, Offset<ICreateBulletConfig> bulletConfigOffset)
		{
			builder.AddOffset(1, bulletConfigOffset.Value, 0);
		}

		// Token: 0x06020EDA RID: 134874 RVA: 0x00493E3D File Offset: 0x0049203D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06020EDB RID: 134875 RVA: 0x00493E50 File Offset: 0x00492050
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020EDC RID: 134876 RVA: 0x00493E90 File Offset: 0x00492090
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020EDD RID: 134877 RVA: 0x00493EAA File Offset: 0x004920AA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020EDE RID: 134878 RVA: 0x00493EC8 File Offset: 0x004920C8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020EDF RID: 134879 RVA: 0x00493EE1 File Offset: 0x004920E1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020EE0 RID: 134880 RVA: 0x00493EEC File Offset: 0x004920EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020EE1 RID: 134881 RVA: 0x00493EF7 File Offset: 0x004920F7
		public static Offset<ICreateStageConfig> EndICreateStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICreateStageConfig>(builder.EndTable());
		}

		// Token: 0x06020EE2 RID: 134882 RVA: 0x00493F04 File Offset: 0x00492104
		public ICreateStageConfigT UnPack()
		{
			ICreateStageConfigT createStageConfigT = new ICreateStageConfigT();
			this.UnPackTo(createStageConfigT);
			return createStageConfigT;
		}

		// Token: 0x06020EE3 RID: 134883 RVA: 0x00493F20 File Offset: 0x00492120
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

		// Token: 0x06020EE4 RID: 134884 RVA: 0x00493FC8 File Offset: 0x004921C8
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

		// Token: 0x0400E037 RID: 57399
		private Table __p;
	}
}
