using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726E RID: 29294
	public struct ISwitchSubLevelsDirectly : IFlatbufferObject
	{
		// Token: 0x1700D956 RID: 55638
		// (get) Token: 0x06033F78 RID: 212856 RVA: 0x006FD095 File Offset: 0x006FB295
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F79 RID: 212857 RVA: 0x006FD0A2 File Offset: 0x006FB2A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F7A RID: 212858 RVA: 0x006FD0AC File Offset: 0x006FB2AC
		public static ISwitchSubLevelsDirectly GetRootAsISwitchSubLevelsDirectly(ByteBuffer _bb)
		{
			return ISwitchSubLevelsDirectly.GetRootAsISwitchSubLevelsDirectly(_bb, default(ISwitchSubLevelsDirectly));
		}

		// Token: 0x06033F7B RID: 212859 RVA: 0x006FD0C8 File Offset: 0x006FB2C8
		public static ISwitchSubLevelsDirectly GetRootAsISwitchSubLevelsDirectly(ByteBuffer _bb, ISwitchSubLevelsDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F7C RID: 212860 RVA: 0x006FD0E5 File Offset: 0x006FB2E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F7D RID: 212861 RVA: 0x006FD0F4 File Offset: 0x006FB2F4
		public ISwitchSubLevelsDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D957 RID: 55639
		// (get) Token: 0x06033F7E RID: 212862 RVA: 0x006FD104 File Offset: 0x006FB304
		public ESwitchSubLevelsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return (ESwitchSubLevelsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F7F RID: 212863 RVA: 0x006FD140 File Offset: 0x006FB340
		public string LoadLevels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D958 RID: 55640
		// (get) Token: 0x06033F80 RID: 212864 RVA: 0x006FD17C File Offset: 0x006FB37C
		public int LoadLevelsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033F81 RID: 212865 RVA: 0x006FD1A8 File Offset: 0x006FB3A8
		public string UnloadLevels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D959 RID: 55641
		// (get) Token: 0x06033F82 RID: 212866 RVA: 0x006FD1E4 File Offset: 0x006FB3E4
		public int UnloadLevelsLength
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

		// Token: 0x1700D95A RID: 55642
		// (get) Token: 0x06033F83 RID: 212867 RVA: 0x006FD210 File Offset: 0x006FB410
		public int TeleportEntityId
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

		// Token: 0x1700D95B RID: 55643
		// (get) Token: 0x06033F84 RID: 212868 RVA: 0x006FD250 File Offset: 0x006FB450
		public bool IsWaitForSwitchComplete
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D95C RID: 55644
		// (get) Token: 0x06033F85 RID: 212869 RVA: 0x006FD290 File Offset: 0x006FB490
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

		// Token: 0x06033F86 RID: 212870 RVA: 0x006FD2CD File Offset: 0x006FB4CD
		public static Offset<ISwitchSubLevelsDirectly> CreateISwitchSubLevelsDirectly(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly, VectorOffset LoadLevelsOffset = default(VectorOffset), VectorOffset UnloadLevelsOffset = default(VectorOffset), int TeleportEntityId = 0, bool IsWaitForSwitchComplete = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISwitchSubLevelsDirectly.AddTeleportEntityId(builder, TeleportEntityId);
			ISwitchSubLevelsDirectly.AddUnloadLevels(builder, UnloadLevelsOffset);
			ISwitchSubLevelsDirectly.AddLoadLevels(builder, LoadLevelsOffset);
			ISwitchSubLevelsDirectly.AddNullMask(builder, NullMask);
			ISwitchSubLevelsDirectly.AddIsWaitForSwitchComplete(builder, IsWaitForSwitchComplete);
			ISwitchSubLevelsDirectly.AddType(builder, Type);
			return ISwitchSubLevelsDirectly.EndISwitchSubLevelsDirectly(builder);
		}

		// Token: 0x06033F87 RID: 212871 RVA: 0x006FD309 File Offset: 0x006FB509
		public static void StartISwitchSubLevelsDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06033F88 RID: 212872 RVA: 0x006FD312 File Offset: 0x006FB512
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F89 RID: 212873 RVA: 0x006FD31D File Offset: 0x006FB51D
		public static void AddLoadLevels(FlatBufferBuilder builder, VectorOffset loadLevelsOffset)
		{
			builder.AddOffset(1, loadLevelsOffset.Value, 0);
		}

		// Token: 0x06033F8A RID: 212874 RVA: 0x006FD330 File Offset: 0x006FB530
		public static VectorOffset CreateLoadLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033F8B RID: 212875 RVA: 0x006FD370 File Offset: 0x006FB570
		public static VectorOffset CreateLoadLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F8C RID: 212876 RVA: 0x006FD38A File Offset: 0x006FB58A
		public static VectorOffset CreateLoadLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F8D RID: 212877 RVA: 0x006FD3A8 File Offset: 0x006FB5A8
		public static VectorOffset CreateLoadLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033F8E RID: 212878 RVA: 0x006FD3C1 File Offset: 0x006FB5C1
		public static void StartLoadLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033F8F RID: 212879 RVA: 0x006FD3CC File Offset: 0x006FB5CC
		public static void AddUnloadLevels(FlatBufferBuilder builder, VectorOffset unloadLevelsOffset)
		{
			builder.AddOffset(2, unloadLevelsOffset.Value, 0);
		}

		// Token: 0x06033F90 RID: 212880 RVA: 0x006FD3DC File Offset: 0x006FB5DC
		public static VectorOffset CreateUnloadLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033F91 RID: 212881 RVA: 0x006FD41C File Offset: 0x006FB61C
		public static VectorOffset CreateUnloadLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F92 RID: 212882 RVA: 0x006FD436 File Offset: 0x006FB636
		public static VectorOffset CreateUnloadLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F93 RID: 212883 RVA: 0x006FD454 File Offset: 0x006FB654
		public static VectorOffset CreateUnloadLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033F94 RID: 212884 RVA: 0x006FD46D File Offset: 0x006FB66D
		public static void StartUnloadLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033F95 RID: 212885 RVA: 0x006FD478 File Offset: 0x006FB678
		public static void AddTeleportEntityId(FlatBufferBuilder builder, int teleportEntityId)
		{
			builder.AddInt(3, teleportEntityId, 0);
		}

		// Token: 0x06033F96 RID: 212886 RVA: 0x006FD483 File Offset: 0x006FB683
		public static void AddIsWaitForSwitchComplete(FlatBufferBuilder builder, bool isWaitForSwitchComplete)
		{
			builder.AddBool(4, isWaitForSwitchComplete, false);
		}

		// Token: 0x06033F97 RID: 212887 RVA: 0x006FD48E File Offset: 0x006FB68E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06033F98 RID: 212888 RVA: 0x006FD499 File Offset: 0x006FB699
		public static Offset<ISwitchSubLevelsDirectly> EndISwitchSubLevelsDirectly(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchSubLevelsDirectly>(builder.EndTable());
		}

		// Token: 0x06033F99 RID: 212889 RVA: 0x006FD4A8 File Offset: 0x006FB6A8
		public ISwitchSubLevelsDirectlyT UnPack()
		{
			ISwitchSubLevelsDirectlyT switchSubLevelsDirectlyT = new ISwitchSubLevelsDirectlyT();
			this.UnPackTo(switchSubLevelsDirectlyT);
			return switchSubLevelsDirectlyT;
		}

		// Token: 0x06033F9A RID: 212890 RVA: 0x006FD4C4 File Offset: 0x006FB6C4
		public void UnPackTo(ISwitchSubLevelsDirectlyT _o)
		{
			_o.Type = this.Type;
			_o.LoadLevels = new List<string>();
			for (int i = 0; i < this.LoadLevelsLength; i++)
			{
				_o.LoadLevels.Add(this.LoadLevels(i));
			}
			_o.UnloadLevels = new List<string>();
			for (int j = 0; j < this.UnloadLevelsLength; j++)
			{
				_o.UnloadLevels.Add(this.UnloadLevels(j));
			}
			_o.TeleportEntityId = this.TeleportEntityId;
			_o.IsWaitForSwitchComplete = this.IsWaitForSwitchComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033F9B RID: 212891 RVA: 0x006FD560 File Offset: 0x006FB760
		public static Offset<ISwitchSubLevelsDirectly> Pack(FlatBufferBuilder builder, ISwitchSubLevelsDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchSubLevelsDirectly>);
			}
			VectorOffset loadLevelsOffset = default(VectorOffset);
			if (_o.LoadLevels != null)
			{
				StringOffset[] array = new StringOffset[_o.LoadLevels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.LoadLevels[i]);
				}
				loadLevelsOffset = ISwitchSubLevelsDirectly.CreateLoadLevelsVector(builder, array);
			}
			VectorOffset unloadLevelsOffset = default(VectorOffset);
			if (_o.UnloadLevels != null)
			{
				StringOffset[] array2 = new StringOffset[_o.UnloadLevels.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.UnloadLevels[j]);
				}
				unloadLevelsOffset = ISwitchSubLevelsDirectly.CreateUnloadLevelsVector(builder, array2);
			}
			return ISwitchSubLevelsDirectly.CreateISwitchSubLevelsDirectly(builder, _o.Type, loadLevelsOffset, unloadLevelsOffset, _o.TeleportEntityId, _o.IsWaitForSwitchComplete, _o.NullMask);
		}

		// Token: 0x04011D6B RID: 73067
		private Table __p;
	}
}
