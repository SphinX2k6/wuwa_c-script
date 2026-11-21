using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537F RID: 21375
	public struct IAfterTeleportConfig : IFlatbufferObject
	{
		// Token: 0x170096F2 RID: 38642
		// (get) Token: 0x060214C9 RID: 136393 RVA: 0x00498292 File Offset: 0x00496492
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060214CA RID: 136394 RVA: 0x0049829F File Offset: 0x0049649F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060214CB RID: 136395 RVA: 0x004982A8 File Offset: 0x004964A8
		public static IAfterTeleportConfig GetRootAsIAfterTeleportConfig(ByteBuffer _bb)
		{
			return IAfterTeleportConfig.GetRootAsIAfterTeleportConfig(_bb, default(IAfterTeleportConfig));
		}

		// Token: 0x060214CC RID: 136396 RVA: 0x004982C4 File Offset: 0x004964C4
		public static IAfterTeleportConfig GetRootAsIAfterTeleportConfig(ByteBuffer _bb, IAfterTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060214CD RID: 136397 RVA: 0x004982E1 File Offset: 0x004964E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060214CE RID: 136398 RVA: 0x004982F0 File Offset: 0x004964F0
		public IAfterTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096F3 RID: 38643
		// (get) Token: 0x060214CF RID: 136399 RVA: 0x00498300 File Offset: 0x00496500
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

		// Token: 0x060214D0 RID: 136400 RVA: 0x00498360 File Offset: 0x00496560
		public int BuffEffectIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170096F4 RID: 38644
		// (get) Token: 0x060214D1 RID: 136401 RVA: 0x004983A0 File Offset: 0x004965A0
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

		// Token: 0x060214D2 RID: 136402 RVA: 0x004983CB File Offset: 0x004965CB
		public Span<int> GetBuffEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060214D3 RID: 136403 RVA: 0x004983DA File Offset: 0x004965DA
		public int[] GetBuffEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170096F5 RID: 38645
		// (get) Token: 0x060214D4 RID: 136404 RVA: 0x004983E8 File Offset: 0x004965E8
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

		// Token: 0x170096F6 RID: 38646
		// (get) Token: 0x060214D5 RID: 136405 RVA: 0x00498448 File Offset: 0x00496648
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

		// Token: 0x170096F7 RID: 38647
		// (get) Token: 0x060214D6 RID: 136406 RVA: 0x00498488 File Offset: 0x00496688
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

		// Token: 0x060214D7 RID: 136407 RVA: 0x004984C0 File Offset: 0x004966C0
		public Span<byte> GetSlidePerformDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060214D8 RID: 136408 RVA: 0x004984D0 File Offset: 0x004966D0
		public byte[] GetSlidePerformDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170096F8 RID: 38648
		// (get) Token: 0x060214D9 RID: 136409 RVA: 0x004984E0 File Offset: 0x004966E0
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

		// Token: 0x060214DA RID: 136410 RVA: 0x0049851D File Offset: 0x0049671D
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

		// Token: 0x060214DB RID: 136411 RVA: 0x00498559 File Offset: 0x00496759
		public static void StartIAfterTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060214DC RID: 136412 RVA: 0x00498562 File Offset: 0x00496762
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(0, directionOffset.Value, 0);
		}

		// Token: 0x060214DD RID: 136413 RVA: 0x00498572 File Offset: 0x00496772
		public static void AddBuffEffectIds(FlatBufferBuilder builder, VectorOffset buffEffectIdsOffset)
		{
			builder.AddOffset(1, buffEffectIdsOffset.Value, 0);
		}

		// Token: 0x060214DE RID: 136414 RVA: 0x00498584 File Offset: 0x00496784
		public static VectorOffset CreateBuffEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060214DF RID: 136415 RVA: 0x004985BB File Offset: 0x004967BB
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060214E0 RID: 136416 RVA: 0x004985D5 File Offset: 0x004967D5
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060214E1 RID: 136417 RVA: 0x004985F3 File Offset: 0x004967F3
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060214E2 RID: 136418 RVA: 0x0049860C File Offset: 0x0049680C
		public static void StartBuffEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060214E3 RID: 136419 RVA: 0x00498617 File Offset: 0x00496817
		public static void AddTeleportToSelfPos(FlatBufferBuilder builder, Offset<IVectorInfo> teleportToSelfPosOffset)
		{
			builder.AddOffset(2, teleportToSelfPosOffset.Value, 0);
		}

		// Token: 0x060214E4 RID: 136420 RVA: 0x00498627 File Offset: 0x00496827
		public static void AddRailEntityId(FlatBufferBuilder builder, int railEntityId)
		{
			builder.AddInt(3, railEntityId, 0);
		}

		// Token: 0x060214E5 RID: 136421 RVA: 0x00498632 File Offset: 0x00496832
		public static void AddSlidePerformDaPath(FlatBufferBuilder builder, StringOffset slidePerformDaPathOffset)
		{
			builder.AddOffset(4, slidePerformDaPathOffset.Value, 0);
		}

		// Token: 0x060214E6 RID: 136422 RVA: 0x00498642 File Offset: 0x00496842
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060214E7 RID: 136423 RVA: 0x0049864D File Offset: 0x0049684D
		public static Offset<IAfterTeleportConfig> EndIAfterTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAfterTeleportConfig>(builder.EndTable());
		}

		// Token: 0x060214E8 RID: 136424 RVA: 0x0049865C File Offset: 0x0049685C
		public IAfterTeleportConfigT UnPack()
		{
			IAfterTeleportConfigT afterTeleportConfigT = new IAfterTeleportConfigT();
			this.UnPackTo(afterTeleportConfigT);
			return afterTeleportConfigT;
		}

		// Token: 0x060214E9 RID: 136425 RVA: 0x00498678 File Offset: 0x00496878
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

		// Token: 0x060214EA RID: 136426 RVA: 0x00498738 File Offset: 0x00496938
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

		// Token: 0x0400E791 RID: 59281
		private Table __p;
	}
}
