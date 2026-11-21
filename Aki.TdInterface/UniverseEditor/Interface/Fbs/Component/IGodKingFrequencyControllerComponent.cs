using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587A RID: 22650
	public struct IGodKingFrequencyControllerComponent : IFlatbufferObject
	{
		// Token: 0x1700A417 RID: 42007
		// (get) Token: 0x06024B74 RID: 150388 RVA: 0x0050B188 File Offset: 0x00509388
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B75 RID: 150389 RVA: 0x0050B195 File Offset: 0x00509395
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B76 RID: 150390 RVA: 0x0050B19C File Offset: 0x0050939C
		public static IGodKingFrequencyControllerComponent GetRootAsIGodKingFrequencyControllerComponent(ByteBuffer _bb)
		{
			return IGodKingFrequencyControllerComponent.GetRootAsIGodKingFrequencyControllerComponent(_bb, default(IGodKingFrequencyControllerComponent));
		}

		// Token: 0x06024B77 RID: 150391 RVA: 0x0050B1B8 File Offset: 0x005093B8
		public static IGodKingFrequencyControllerComponent GetRootAsIGodKingFrequencyControllerComponent(ByteBuffer _bb, IGodKingFrequencyControllerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B78 RID: 150392 RVA: 0x0050B1D5 File Offset: 0x005093D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B79 RID: 150393 RVA: 0x0050B1E4 File Offset: 0x005093E4
		public IGodKingFrequencyControllerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A418 RID: 42008
		// (get) Token: 0x06024B7A RID: 150394 RVA: 0x0050B1F4 File Offset: 0x005093F4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024B7B RID: 150395 RVA: 0x0050B234 File Offset: 0x00509434
		public int StatueEntityIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A419 RID: 42009
		// (get) Token: 0x06024B7C RID: 150396 RVA: 0x0050B274 File Offset: 0x00509474
		public int StatueEntityIdListLength
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

		// Token: 0x06024B7D RID: 150397 RVA: 0x0050B29F File Offset: 0x0050949F
		public Span<int> GetStatueEntityIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06024B7E RID: 150398 RVA: 0x0050B2AE File Offset: 0x005094AE
		public int[] GetStatueEntityIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A41A RID: 42010
		// (get) Token: 0x06024B7F RID: 150399 RVA: 0x0050B2BC File Offset: 0x005094BC
		public int InitialAttachStatue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A41B RID: 42011
		// (get) Token: 0x06024B80 RID: 150400 RVA: 0x0050B2F8 File Offset: 0x005094F8
		public int GodKingFrequencyEntity
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

		// Token: 0x1700A41C RID: 42012
		// (get) Token: 0x06024B81 RID: 150401 RVA: 0x0050B338 File Offset: 0x00509538
		public string AttachSocket
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

		// Token: 0x06024B82 RID: 150402 RVA: 0x0050B370 File Offset: 0x00509570
		public Span<byte> GetAttachSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06024B83 RID: 150403 RVA: 0x0050B380 File Offset: 0x00509580
		public byte[] GetAttachSocketArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A41D RID: 42013
		// (get) Token: 0x06024B84 RID: 150404 RVA: 0x0050B390 File Offset: 0x00509590
		public float FlySpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A41E RID: 42014
		// (get) Token: 0x06024B85 RID: 150405 RVA: 0x0050B3D4 File Offset: 0x005095D4
		public float MaxFlyTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A41F RID: 42015
		// (get) Token: 0x06024B86 RID: 150406 RVA: 0x0050B418 File Offset: 0x00509618
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024B87 RID: 150407 RVA: 0x0050B458 File Offset: 0x00509658
		public static Offset<IGodKingFrequencyControllerComponent> CreateIGodKingFrequencyControllerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StatueEntityIdListOffset = default(VectorOffset), int InitialAttachStatue = 0, int GodKingFrequencyEntity = 0, StringOffset AttachSocketOffset = default(StringOffset), float FlySpeed = 0f, float MaxFlyTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IGodKingFrequencyControllerComponent.AddMaxFlyTime(builder, MaxFlyTime);
			IGodKingFrequencyControllerComponent.AddFlySpeed(builder, FlySpeed);
			IGodKingFrequencyControllerComponent.AddAttachSocket(builder, AttachSocketOffset);
			IGodKingFrequencyControllerComponent.AddGodKingFrequencyEntity(builder, GodKingFrequencyEntity);
			IGodKingFrequencyControllerComponent.AddInitialAttachStatue(builder, InitialAttachStatue);
			IGodKingFrequencyControllerComponent.AddStatueEntityIdList(builder, StatueEntityIdListOffset);
			IGodKingFrequencyControllerComponent.AddNullMask(builder, NullMask);
			IGodKingFrequencyControllerComponent.AddDisabled(builder, Disabled);
			return IGodKingFrequencyControllerComponent.EndIGodKingFrequencyControllerComponent(builder);
		}

		// Token: 0x06024B88 RID: 150408 RVA: 0x0050B4AF File Offset: 0x005096AF
		public static void StartIGodKingFrequencyControllerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06024B89 RID: 150409 RVA: 0x0050B4B8 File Offset: 0x005096B8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024B8A RID: 150410 RVA: 0x0050B4C3 File Offset: 0x005096C3
		public static void AddStatueEntityIdList(FlatBufferBuilder builder, VectorOffset statueEntityIdListOffset)
		{
			builder.AddOffset(1, statueEntityIdListOffset.Value, 0);
		}

		// Token: 0x06024B8B RID: 150411 RVA: 0x0050B4D4 File Offset: 0x005096D4
		public static VectorOffset CreateStatueEntityIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024B8C RID: 150412 RVA: 0x0050B50B File Offset: 0x0050970B
		public static VectorOffset CreateStatueEntityIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024B8D RID: 150413 RVA: 0x0050B525 File Offset: 0x00509725
		public static VectorOffset CreateStatueEntityIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024B8E RID: 150414 RVA: 0x0050B543 File Offset: 0x00509743
		public static VectorOffset CreateStatueEntityIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024B8F RID: 150415 RVA: 0x0050B55C File Offset: 0x0050975C
		public static void StartStatueEntityIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024B90 RID: 150416 RVA: 0x0050B567 File Offset: 0x00509767
		public static void AddInitialAttachStatue(FlatBufferBuilder builder, int initialAttachStatue)
		{
			builder.AddInt(2, initialAttachStatue, 0);
		}

		// Token: 0x06024B91 RID: 150417 RVA: 0x0050B572 File Offset: 0x00509772
		public static void AddGodKingFrequencyEntity(FlatBufferBuilder builder, int godKingFrequencyEntity)
		{
			builder.AddInt(3, godKingFrequencyEntity, 0);
		}

		// Token: 0x06024B92 RID: 150418 RVA: 0x0050B57D File Offset: 0x0050977D
		public static void AddAttachSocket(FlatBufferBuilder builder, StringOffset attachSocketOffset)
		{
			builder.AddOffset(4, attachSocketOffset.Value, 0);
		}

		// Token: 0x06024B93 RID: 150419 RVA: 0x0050B58D File Offset: 0x0050978D
		public static void AddFlySpeed(FlatBufferBuilder builder, float flySpeed)
		{
			builder.AddFloat(5, flySpeed, 0.0);
		}

		// Token: 0x06024B94 RID: 150420 RVA: 0x0050B5A0 File Offset: 0x005097A0
		public static void AddMaxFlyTime(FlatBufferBuilder builder, float maxFlyTime)
		{
			builder.AddFloat(6, maxFlyTime, 0.0);
		}

		// Token: 0x06024B95 RID: 150421 RVA: 0x0050B5B3 File Offset: 0x005097B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06024B96 RID: 150422 RVA: 0x0050B5BE File Offset: 0x005097BE
		public static Offset<IGodKingFrequencyControllerComponent> EndIGodKingFrequencyControllerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGodKingFrequencyControllerComponent>(builder.EndTable());
		}

		// Token: 0x06024B97 RID: 150423 RVA: 0x0050B5CC File Offset: 0x005097CC
		public IGodKingFrequencyControllerComponentT UnPack()
		{
			IGodKingFrequencyControllerComponentT godKingFrequencyControllerComponentT = new IGodKingFrequencyControllerComponentT();
			this.UnPackTo(godKingFrequencyControllerComponentT);
			return godKingFrequencyControllerComponentT;
		}

		// Token: 0x06024B98 RID: 150424 RVA: 0x0050B5E8 File Offset: 0x005097E8
		public void UnPackTo(IGodKingFrequencyControllerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.StatueEntityIdList = new List<int>();
			for (int i = 0; i < this.StatueEntityIdListLength; i++)
			{
				_o.StatueEntityIdList.Add(this.StatueEntityIdList(i));
			}
			_o.InitialAttachStatue = this.InitialAttachStatue;
			_o.GodKingFrequencyEntity = this.GodKingFrequencyEntity;
			_o.AttachSocket = this.AttachSocket;
			_o.FlySpeed = this.FlySpeed;
			_o.MaxFlyTime = this.MaxFlyTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024B99 RID: 150425 RVA: 0x0050B678 File Offset: 0x00509878
		public static Offset<IGodKingFrequencyControllerComponent> Pack(FlatBufferBuilder builder, IGodKingFrequencyControllerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGodKingFrequencyControllerComponent>);
			}
			VectorOffset statueEntityIdListOffset = default(VectorOffset);
			if (_o.StatueEntityIdList != null)
			{
				int[] data = _o.StatueEntityIdList.ToArray();
				statueEntityIdListOffset = IGodKingFrequencyControllerComponent.CreateStatueEntityIdListVector(builder, data);
			}
			StringOffset attachSocketOffset = (_o.AttachSocket == null) ? default(StringOffset) : builder.CreateString(_o.AttachSocket);
			return IGodKingFrequencyControllerComponent.CreateIGodKingFrequencyControllerComponent(builder, _o.Disabled, statueEntityIdListOffset, _o.InitialAttachStatue, _o.GodKingFrequencyEntity, attachSocketOffset, _o.FlySpeed, _o.MaxFlyTime, _o.NullMask);
		}

		// Token: 0x0400F0C9 RID: 61641
		private Table __p;
	}
}
