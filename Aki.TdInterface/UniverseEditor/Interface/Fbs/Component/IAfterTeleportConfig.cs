using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E6E RID: 20078
	public struct IAfterTeleportConfig : IFlatbufferObject
	{
		// Token: 0x17008FB9 RID: 36793
		// (get) Token: 0x0601F87E RID: 129150 RVA: 0x0046427A File Offset: 0x0046247A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F87F RID: 129151 RVA: 0x00464287 File Offset: 0x00462487
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F880 RID: 129152 RVA: 0x00464290 File Offset: 0x00462490
		public static IAfterTeleportConfig GetRootAsIAfterTeleportConfig(ByteBuffer _bb)
		{
			return IAfterTeleportConfig.GetRootAsIAfterTeleportConfig(_bb, default(IAfterTeleportConfig));
		}

		// Token: 0x0601F881 RID: 129153 RVA: 0x004642AC File Offset: 0x004624AC
		public static IAfterTeleportConfig GetRootAsIAfterTeleportConfig(ByteBuffer _bb, IAfterTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F882 RID: 129154 RVA: 0x004642C9 File Offset: 0x004624C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F883 RID: 129155 RVA: 0x004642D8 File Offset: 0x004624D8
		public IAfterTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FBA RID: 36794
		// (get) Token: 0x0601F884 RID: 129156 RVA: 0x004642E8 File Offset: 0x004624E8
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F885 RID: 129157 RVA: 0x00464348 File Offset: 0x00462548
		public int BuffEffectIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008FBB RID: 36795
		// (get) Token: 0x0601F886 RID: 129158 RVA: 0x00464388 File Offset: 0x00462588
		public int BuffEffectIdsLength
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

		// Token: 0x0601F887 RID: 129159 RVA: 0x004643B3 File Offset: 0x004625B3
		public Span<int> GetBuffEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F888 RID: 129160 RVA: 0x004643C2 File Offset: 0x004625C2
		public int[] GetBuffEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17008FBC RID: 36796
		// (get) Token: 0x0601F889 RID: 129161 RVA: 0x004643D0 File Offset: 0x004625D0
		public IVectorInfo? TeleportToSelfPos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008FBD RID: 36797
		// (get) Token: 0x0601F88A RID: 129162 RVA: 0x00464430 File Offset: 0x00462630
		public int RailEntityId
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

		// Token: 0x17008FBE RID: 36798
		// (get) Token: 0x0601F88B RID: 129163 RVA: 0x00464470 File Offset: 0x00462670
		public string SlidePerformDaPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F88C RID: 129164 RVA: 0x004644A8 File Offset: 0x004626A8
		public Span<byte> GetSlidePerformDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601F88D RID: 129165 RVA: 0x004644B8 File Offset: 0x004626B8
		public byte[] GetSlidePerformDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008FBF RID: 36799
		// (get) Token: 0x0601F88E RID: 129166 RVA: 0x004644C8 File Offset: 0x004626C8
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

		// Token: 0x0601F88F RID: 129167 RVA: 0x00464505 File Offset: 0x00462705
		public static Offset<IAfterTeleportConfig> CreateIAfterTeleportConfig(FlatBufferBuilder builder, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), VectorOffset BuffEffectIdsOffset = default(VectorOffset), Offset<IVectorInfo> TeleportToSelfPosOffset = default(Offset<IVectorInfo>), int RailEntityId = 0, StringOffset SlidePerformDaPathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IAfterTeleportConfig.AddSlidePerformDaPath(builder, SlidePerformDaPathOffset);
			IAfterTeleportConfig.AddRailEntityId(builder, RailEntityId);
			IAfterTeleportConfig.AddTeleportToSelfPos(builder, TeleportToSelfPosOffset);
			IAfterTeleportConfig.AddBuffEffectIds(builder, BuffEffectIdsOffset);
			IAfterTeleportConfig.AddDirection(builder, DirectionOffset);
			IAfterTeleportConfig.AddNullMask(builder, NullMask);
			return IAfterTeleportConfig.EndIAfterTeleportConfig(builder);
		}

		// Token: 0x0601F890 RID: 129168 RVA: 0x00464541 File Offset: 0x00462741
		public static void StartIAfterTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601F891 RID: 129169 RVA: 0x0046454A File Offset: 0x0046274A
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(0, directionOffset.Value, 0);
		}

		// Token: 0x0601F892 RID: 129170 RVA: 0x0046455A File Offset: 0x0046275A
		public static void AddBuffEffectIds(FlatBufferBuilder builder, VectorOffset buffEffectIdsOffset)
		{
			builder.AddOffset(1, buffEffectIdsOffset.Value, 0);
		}

		// Token: 0x0601F893 RID: 129171 RVA: 0x0046456C File Offset: 0x0046276C
		public static VectorOffset CreateBuffEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F894 RID: 129172 RVA: 0x004645A3 File Offset: 0x004627A3
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F895 RID: 129173 RVA: 0x004645BD File Offset: 0x004627BD
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F896 RID: 129174 RVA: 0x004645DB File Offset: 0x004627DB
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F897 RID: 129175 RVA: 0x004645F4 File Offset: 0x004627F4
		public static void StartBuffEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F898 RID: 129176 RVA: 0x004645FF File Offset: 0x004627FF
		public static void AddTeleportToSelfPos(FlatBufferBuilder builder, Offset<IVectorInfo> teleportToSelfPosOffset)
		{
			builder.AddOffset(2, teleportToSelfPosOffset.Value, 0);
		}

		// Token: 0x0601F899 RID: 129177 RVA: 0x0046460F File Offset: 0x0046280F
		public static void AddRailEntityId(FlatBufferBuilder builder, int railEntityId)
		{
			builder.AddInt(3, railEntityId, 0);
		}

		// Token: 0x0601F89A RID: 129178 RVA: 0x0046461A File Offset: 0x0046281A
		public static void AddSlidePerformDaPath(FlatBufferBuilder builder, StringOffset slidePerformDaPathOffset)
		{
			builder.AddOffset(4, slidePerformDaPathOffset.Value, 0);
		}

		// Token: 0x0601F89B RID: 129179 RVA: 0x0046462A File Offset: 0x0046282A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601F89C RID: 129180 RVA: 0x00464635 File Offset: 0x00462835
		public static Offset<IAfterTeleportConfig> EndIAfterTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAfterTeleportConfig>(builder.EndTable());
		}

		// Token: 0x0601F89D RID: 129181 RVA: 0x00464644 File Offset: 0x00462844
		public IAfterTeleportConfigT UnPack()
		{
			IAfterTeleportConfigT afterTeleportConfigT = new IAfterTeleportConfigT();
			this.UnPackTo(afterTeleportConfigT);
			return afterTeleportConfigT;
		}

		// Token: 0x0601F89E RID: 129182 RVA: 0x00464660 File Offset: 0x00462860
		public void UnPackTo(IAfterTeleportConfigT _o)
		{
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.BuffEffectIds = new List<int>();
			for (int i = 0; i < this.BuffEffectIdsLength; i++)
			{
				_o.BuffEffectIds.Add(this.BuffEffectIds(i));
			}
			_o.TeleportToSelfPos = ((this.TeleportToSelfPos != null) ? this.TeleportToSelfPos.Value.UnPack() : null);
			_o.RailEntityId = this.RailEntityId;
			_o.SlidePerformDaPath = this.SlidePerformDaPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F89F RID: 129183 RVA: 0x00464720 File Offset: 0x00462920
		public static Offset<IAfterTeleportConfig> Pack(FlatBufferBuilder builder, IAfterTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAfterTeleportConfig>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			VectorOffset buffEffectIdsOffset = default(VectorOffset);
			if (_o.BuffEffectIds != null)
			{
				int[] data = _o.BuffEffectIds.ToArray();
				buffEffectIdsOffset = IAfterTeleportConfig.CreateBuffEffectIdsVector(builder, data);
			}
			Offset<IVectorInfo> teleportToSelfPosOffset = (_o.TeleportToSelfPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TeleportToSelfPos);
			StringOffset slidePerformDaPathOffset = (_o.SlidePerformDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SlidePerformDaPath);
			return IAfterTeleportConfig.CreateIAfterTeleportConfig(builder, directionOffset, buffEffectIdsOffset, teleportToSelfPosOffset, _o.RailEntityId, slidePerformDaPathOffset, _o.NullMask);
		}

		// Token: 0x0400DC17 RID: 56343
		private Table __p;
	}
}
