using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C4 RID: 30148
	public struct IRemoveEffectBase : IFlatbufferObject
	{
		// Token: 0x1700DDA4 RID: 56740
		// (get) Token: 0x06034E3E RID: 216638 RVA: 0x0071BBEF File Offset: 0x00719DEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E3F RID: 216639 RVA: 0x0071BBFC File Offset: 0x00719DFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E40 RID: 216640 RVA: 0x0071BC04 File Offset: 0x00719E04
		public static IRemoveEffectBase GetRootAsIRemoveEffectBase(ByteBuffer _bb)
		{
			return IRemoveEffectBase.GetRootAsIRemoveEffectBase(_bb, default(IRemoveEffectBase));
		}

		// Token: 0x06034E41 RID: 216641 RVA: 0x0071BC20 File Offset: 0x00719E20
		public static IRemoveEffectBase GetRootAsIRemoveEffectBase(ByteBuffer _bb, IRemoveEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E42 RID: 216642 RVA: 0x0071BC3D File Offset: 0x00719E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E43 RID: 216643 RVA: 0x0071BC4C File Offset: 0x00719E4C
		public IRemoveEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDA5 RID: 56741
		// (get) Token: 0x06034E44 RID: 216644 RVA: 0x0071BC5C File Offset: 0x00719E5C
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DDA6 RID: 56742
		// (get) Token: 0x06034E45 RID: 216645 RVA: 0x0071BC98 File Offset: 0x00719E98
		public string Path
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

		// Token: 0x06034E46 RID: 216646 RVA: 0x0071BCCF File Offset: 0x00719ECF
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034E47 RID: 216647 RVA: 0x0071BCDE File Offset: 0x00719EDE
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06034E48 RID: 216648 RVA: 0x0071BCEC File Offset: 0x00719EEC
		public static Offset<IRemoveEffectBase> CreateIRemoveEffectBase(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemoveEffectBase.AddPath(builder, PathOffset);
			IRemoveEffectBase.AddType(builder, Type);
			return IRemoveEffectBase.EndIRemoveEffectBase(builder);
		}

		// Token: 0x06034E49 RID: 216649 RVA: 0x0071BD09 File Offset: 0x00719F09
		public static void StartIRemoveEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034E4A RID: 216650 RVA: 0x0071BD12 File Offset: 0x00719F12
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034E4B RID: 216651 RVA: 0x0071BD1D File Offset: 0x00719F1D
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06034E4C RID: 216652 RVA: 0x0071BD2D File Offset: 0x00719F2D
		public static Offset<IRemoveEffectBase> EndIRemoveEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveEffectBase>(builder.EndTable());
		}

		// Token: 0x06034E4D RID: 216653 RVA: 0x0071BD3C File Offset: 0x00719F3C
		public IRemoveEffectBaseT UnPack()
		{
			IRemoveEffectBaseT removeEffectBaseT = new IRemoveEffectBaseT();
			this.UnPackTo(removeEffectBaseT);
			return removeEffectBaseT;
		}

		// Token: 0x06034E4E RID: 216654 RVA: 0x0071BD57 File Offset: 0x00719F57
		public void UnPackTo(IRemoveEffectBaseT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06034E4F RID: 216655 RVA: 0x0071BD74 File Offset: 0x00719F74
		public static Offset<IRemoveEffectBase> Pack(FlatBufferBuilder builder, IRemoveEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveEffectBase>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IRemoveEffectBase.CreateIRemoveEffectBase(builder, _o.Type, pathOffset);
		}

		// Token: 0x040127A9 RID: 75689
		private Table __p;
	}
}
