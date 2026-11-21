using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A8 RID: 21672
	public struct IChantConfig : IFlatbufferObject
	{
		// Token: 0x17009A80 RID: 39552
		// (get) Token: 0x06022203 RID: 139779 RVA: 0x004B4448 File Offset: 0x004B2648
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022204 RID: 139780 RVA: 0x004B4455 File Offset: 0x004B2655
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022205 RID: 139781 RVA: 0x004B445C File Offset: 0x004B265C
		public static IChantConfig GetRootAsIChantConfig(ByteBuffer _bb)
		{
			return IChantConfig.GetRootAsIChantConfig(_bb, default(IChantConfig));
		}

		// Token: 0x06022206 RID: 139782 RVA: 0x004B4478 File Offset: 0x004B2678
		public static IChantConfig GetRootAsIChantConfig(ByteBuffer _bb, IChantConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022207 RID: 139783 RVA: 0x004B4495 File Offset: 0x004B2695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022208 RID: 139784 RVA: 0x004B44A4 File Offset: 0x004B26A4
		public IChantConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A81 RID: 39553
		// (get) Token: 0x06022209 RID: 139785 RVA: 0x004B44B4 File Offset: 0x004B26B4
		public int ChantTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A82 RID: 39554
		// (get) Token: 0x0602220A RID: 139786 RVA: 0x004B44F0 File Offset: 0x004B26F0
		public string ChantCameraShake
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602220B RID: 139787 RVA: 0x004B4527 File Offset: 0x004B2727
		public Span<byte> GetChantCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602220C RID: 139788 RVA: 0x004B4536 File Offset: 0x004B2736
		public byte[] GetChantCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009A83 RID: 39555
		// (get) Token: 0x0602220D RID: 139789 RVA: 0x004B4544 File Offset: 0x004B2744
		public string ChantCameraStateTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602220E RID: 139790 RVA: 0x004B457B File Offset: 0x004B277B
		public Span<byte> GetChantCameraStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602220F RID: 139791 RVA: 0x004B458A File Offset: 0x004B278A
		public byte[] GetChantCameraStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06022210 RID: 139792 RVA: 0x004B4598 File Offset: 0x004B2798
		public static Offset<IChantConfig> CreateIChantConfig(FlatBufferBuilder builder, int ChantTime = 0, StringOffset ChantCameraShakeOffset = default(StringOffset), StringOffset ChantCameraStateTagOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChantConfig.AddChantCameraStateTag(builder, ChantCameraStateTagOffset);
			IChantConfig.AddChantCameraShake(builder, ChantCameraShakeOffset);
			IChantConfig.AddChantTime(builder, ChantTime);
			return IChantConfig.EndIChantConfig(builder);
		}

		// Token: 0x06022211 RID: 139793 RVA: 0x004B45BC File Offset: 0x004B27BC
		public static void StartIChantConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022212 RID: 139794 RVA: 0x004B45C5 File Offset: 0x004B27C5
		public static void AddChantTime(FlatBufferBuilder builder, int chantTime)
		{
			builder.AddInt(0, chantTime, 0);
		}

		// Token: 0x06022213 RID: 139795 RVA: 0x004B45D0 File Offset: 0x004B27D0
		public static void AddChantCameraShake(FlatBufferBuilder builder, StringOffset chantCameraShakeOffset)
		{
			builder.AddOffset(1, chantCameraShakeOffset.Value, 0);
		}

		// Token: 0x06022214 RID: 139796 RVA: 0x004B45E0 File Offset: 0x004B27E0
		public static void AddChantCameraStateTag(FlatBufferBuilder builder, StringOffset chantCameraStateTagOffset)
		{
			builder.AddOffset(2, chantCameraStateTagOffset.Value, 0);
		}

		// Token: 0x06022215 RID: 139797 RVA: 0x004B45F0 File Offset: 0x004B27F0
		public static Offset<IChantConfig> EndIChantConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChantConfig>(builder.EndTable());
		}

		// Token: 0x06022216 RID: 139798 RVA: 0x004B4600 File Offset: 0x004B2800
		public IChantConfigT UnPack()
		{
			IChantConfigT chantConfigT = new IChantConfigT();
			this.UnPackTo(chantConfigT);
			return chantConfigT;
		}

		// Token: 0x06022217 RID: 139799 RVA: 0x004B461B File Offset: 0x004B281B
		public void UnPackTo(IChantConfigT _o)
		{
			_o.ChantTime = this.ChantTime;
			_o.ChantCameraShake = this.ChantCameraShake;
			_o.ChantCameraStateTag = this.ChantCameraStateTag;
		}

		// Token: 0x06022218 RID: 139800 RVA: 0x004B4644 File Offset: 0x004B2844
		public static Offset<IChantConfig> Pack(FlatBufferBuilder builder, IChantConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChantConfig>);
			}
			StringOffset chantCameraShakeOffset = (_o.ChantCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.ChantCameraShake);
			StringOffset chantCameraStateTagOffset = (_o.ChantCameraStateTag == null) ? default(StringOffset) : builder.CreateString(_o.ChantCameraStateTag);
			return IChantConfig.CreateIChantConfig(builder, _o.ChantTime, chantCameraShakeOffset, chantCameraStateTagOffset);
		}

		// Token: 0x0400E9C9 RID: 59849
		private Table __p;
	}
}
