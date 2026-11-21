using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200464F RID: 17999
	public struct ITrackEffectType : IFlatbufferObject
	{
		// Token: 0x17007E09 RID: 32265
		// (get) Token: 0x0601A5F6 RID: 108022 RVA: 0x003C10E0 File Offset: 0x003BF2E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A5F7 RID: 108023 RVA: 0x003C10ED File Offset: 0x003BF2ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A5F8 RID: 108024 RVA: 0x003C10F4 File Offset: 0x003BF2F4
		public static ITrackEffectType GetRootAsITrackEffectType(ByteBuffer _bb)
		{
			return ITrackEffectType.GetRootAsITrackEffectType(_bb, default(ITrackEffectType));
		}

		// Token: 0x0601A5F9 RID: 108025 RVA: 0x003C1110 File Offset: 0x003BF310
		public static ITrackEffectType GetRootAsITrackEffectType(ByteBuffer _bb, ITrackEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A5FA RID: 108026 RVA: 0x003C112D File Offset: 0x003BF32D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A5FB RID: 108027 RVA: 0x003C113C File Offset: 0x003BF33C
		public ITrackEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E0A RID: 32266
		// (get) Token: 0x0601A5FC RID: 108028 RVA: 0x003C114C File Offset: 0x003BF34C
		public ETrackEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackEffectType.AutoChange;
				}
				return (ETrackEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A5FD RID: 108029 RVA: 0x003C1188 File Offset: 0x003BF388
		public static Offset<ITrackEffectType> CreateITrackEffectType(FlatBufferBuilder builder, ETrackEffectType Type = ETrackEffectType.AutoChange)
		{
			builder.StartTable(1);
			ITrackEffectType.AddType(builder, Type);
			return ITrackEffectType.EndITrackEffectType(builder);
		}

		// Token: 0x0601A5FE RID: 108030 RVA: 0x003C119E File Offset: 0x003BF39E
		public static void StartITrackEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A5FF RID: 108031 RVA: 0x003C11A7 File Offset: 0x003BF3A7
		public static void AddType(FlatBufferBuilder builder, ETrackEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A600 RID: 108032 RVA: 0x003C11B2 File Offset: 0x003BF3B2
		public static Offset<ITrackEffectType> EndITrackEffectType(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEffectType>(builder.EndTable());
		}

		// Token: 0x0601A601 RID: 108033 RVA: 0x003C11C0 File Offset: 0x003BF3C0
		public ITrackEffectTypeT UnPack()
		{
			ITrackEffectTypeT trackEffectTypeT = new ITrackEffectTypeT();
			this.UnPackTo(trackEffectTypeT);
			return trackEffectTypeT;
		}

		// Token: 0x0601A602 RID: 108034 RVA: 0x003C11DB File Offset: 0x003BF3DB
		public void UnPackTo(ITrackEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A603 RID: 108035 RVA: 0x003C11EC File Offset: 0x003BF3EC
		public static Offset<ITrackEffectType> Pack(FlatBufferBuilder builder, ITrackEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackEffectType>);
			}
			return ITrackEffectType.CreateITrackEffectType(builder, _o.Type);
		}

		// Token: 0x0400C85F RID: 51295
		private Table __p;
	}
}
