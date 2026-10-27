using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F7 RID: 21239
	public struct IGodKingFrequencyControllerComponent : IFlatbufferObject
	{
		// Token: 0x17009BE6 RID: 39910
		// (get) Token: 0x06022ADA RID: 142042 RVA: 0x004CE65C File Offset: 0x004CC85C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022ADB RID: 142043 RVA: 0x004CE669 File Offset: 0x004CC869
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022ADC RID: 142044 RVA: 0x004CE670 File Offset: 0x004CC870
		public static IGodKingFrequencyControllerComponent GetRootAsIGodKingFrequencyControllerComponent(ByteBuffer _bb)
		{
			return IGodKingFrequencyControllerComponent.GetRootAsIGodKingFrequencyControllerComponent(_bb, default(IGodKingFrequencyControllerComponent));
		}

		// Token: 0x06022ADD RID: 142045 RVA: 0x004CE68C File Offset: 0x004CC88C
		public static IGodKingFrequencyControllerComponent GetRootAsIGodKingFrequencyControllerComponent(ByteBuffer _bb, IGodKingFrequencyControllerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022ADE RID: 142046 RVA: 0x004CE6A9 File Offset: 0x004CC8A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022ADF RID: 142047 RVA: 0x004CE6B8 File Offset: 0x004CC8B8
		public IGodKingFrequencyControllerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BE7 RID: 39911
		// (get) Token: 0x06022AE0 RID: 142048 RVA: 0x004CE6C8 File Offset: 0x004CC8C8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022AE1 RID: 142049 RVA: 0x004CE708 File Offset: 0x004CC908
		public int StatueEntityIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009BE8 RID: 39912
		// (get) Token: 0x06022AE2 RID: 142050 RVA: 0x004CE748 File Offset: 0x004CC948
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

		// Token: 0x06022AE3 RID: 142051 RVA: 0x004CE773 File Offset: 0x004CC973
		public Span<int> GetStatueEntityIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06022AE4 RID: 142052 RVA: 0x004CE782 File Offset: 0x004CC982
		public int[] GetStatueEntityIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009BE9 RID: 39913
		// (get) Token: 0x06022AE5 RID: 142053 RVA: 0x004CE790 File Offset: 0x004CC990
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

		// Token: 0x17009BEA RID: 39914
		// (get) Token: 0x06022AE6 RID: 142054 RVA: 0x004CE7CC File Offset: 0x004CC9CC
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

		// Token: 0x17009BEB RID: 39915
		// (get) Token: 0x06022AE7 RID: 142055 RVA: 0x004CE80C File Offset: 0x004CCA0C
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

		// Token: 0x06022AE8 RID: 142056 RVA: 0x004CE844 File Offset: 0x004CCA44
		public Span<byte> GetAttachSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06022AE9 RID: 142057 RVA: 0x004CE854 File Offset: 0x004CCA54
		public byte[] GetAttachSocketArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009BEC RID: 39916
		// (get) Token: 0x06022AEA RID: 142058 RVA: 0x004CE864 File Offset: 0x004CCA64
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

		// Token: 0x17009BED RID: 39917
		// (get) Token: 0x06022AEB RID: 142059 RVA: 0x004CE8A8 File Offset: 0x004CCAA8
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

		// Token: 0x17009BEE RID: 39918
		// (get) Token: 0x06022AEC RID: 142060 RVA: 0x004CE8EC File Offset: 0x004CCAEC
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

		// Token: 0x06022AED RID: 142061 RVA: 0x004CE92C File Offset: 0x004CCB2C
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

		// Token: 0x06022AEE RID: 142062 RVA: 0x004CE983 File Offset: 0x004CCB83
		public static void StartIGodKingFrequencyControllerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06022AEF RID: 142063 RVA: 0x004CE98C File Offset: 0x004CCB8C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022AF0 RID: 142064 RVA: 0x004CE997 File Offset: 0x004CCB97
		public static void AddStatueEntityIdList(FlatBufferBuilder builder, VectorOffset statueEntityIdListOffset)
		{
			builder.AddOffset(1, statueEntityIdListOffset.Value, 0);
		}

		// Token: 0x06022AF1 RID: 142065 RVA: 0x004CE9A8 File Offset: 0x004CCBA8
		public static VectorOffset CreateStatueEntityIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022AF2 RID: 142066 RVA: 0x004CE9DF File Offset: 0x004CCBDF
		public static VectorOffset CreateStatueEntityIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022AF3 RID: 142067 RVA: 0x004CE9F9 File Offset: 0x004CCBF9
		public static VectorOffset CreateStatueEntityIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022AF4 RID: 142068 RVA: 0x004CEA17 File Offset: 0x004CCC17
		public static VectorOffset CreateStatueEntityIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022AF5 RID: 142069 RVA: 0x004CEA30 File Offset: 0x004CCC30
		public static void StartStatueEntityIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022AF6 RID: 142070 RVA: 0x004CEA3B File Offset: 0x004CCC3B
		public static void AddInitialAttachStatue(FlatBufferBuilder builder, int initialAttachStatue)
		{
			builder.AddInt(2, initialAttachStatue, 0);
		}

		// Token: 0x06022AF7 RID: 142071 RVA: 0x004CEA46 File Offset: 0x004CCC46
		public static void AddGodKingFrequencyEntity(FlatBufferBuilder builder, int godKingFrequencyEntity)
		{
			builder.AddInt(3, godKingFrequencyEntity, 0);
		}

		// Token: 0x06022AF8 RID: 142072 RVA: 0x004CEA51 File Offset: 0x004CCC51
		public static void AddAttachSocket(FlatBufferBuilder builder, StringOffset attachSocketOffset)
		{
			builder.AddOffset(4, attachSocketOffset.Value, 0);
		}

		// Token: 0x06022AF9 RID: 142073 RVA: 0x004CEA61 File Offset: 0x004CCC61
		public static void AddFlySpeed(FlatBufferBuilder builder, float flySpeed)
		{
			builder.AddFloat(5, flySpeed, 0.0);
		}

		// Token: 0x06022AFA RID: 142074 RVA: 0x004CEA74 File Offset: 0x004CCC74
		public static void AddMaxFlyTime(FlatBufferBuilder builder, float maxFlyTime)
		{
			builder.AddFloat(6, maxFlyTime, 0.0);
		}

		// Token: 0x06022AFB RID: 142075 RVA: 0x004CEA87 File Offset: 0x004CCC87
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06022AFC RID: 142076 RVA: 0x004CEA92 File Offset: 0x004CCC92
		public static Offset<IGodKingFrequencyControllerComponent> EndIGodKingFrequencyControllerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGodKingFrequencyControllerComponent>(builder.EndTable());
		}

		// Token: 0x06022AFD RID: 142077 RVA: 0x004CEAA0 File Offset: 0x004CCCA0
		public IGodKingFrequencyControllerComponentT UnPack()
		{
			IGodKingFrequencyControllerComponentT godKingFrequencyControllerComponentT = new IGodKingFrequencyControllerComponentT();
			this.UnPackTo(godKingFrequencyControllerComponentT);
			return godKingFrequencyControllerComponentT;
		}

		// Token: 0x06022AFE RID: 142078 RVA: 0x004CEABC File Offset: 0x004CCCBC
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

		// Token: 0x06022AFF RID: 142079 RVA: 0x004CEB4C File Offset: 0x004CCD4C
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

		// Token: 0x0400E49D RID: 58525
		private Table __p;
	}
}
