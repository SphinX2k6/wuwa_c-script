using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006504 RID: 25860
	public struct ICustomScreenLoadingTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C052 RID: 49234
		// (get) Token: 0x0602CDC3 RID: 183747 RVA: 0x00629905 File Offset: 0x00627B05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDC4 RID: 183748 RVA: 0x00629912 File Offset: 0x00627B12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDC5 RID: 183749 RVA: 0x0062991C File Offset: 0x00627B1C
		public static ICustomScreenLoadingTypeBase GetRootAsICustomScreenLoadingTypeBase(ByteBuffer _bb)
		{
			return ICustomScreenLoadingTypeBase.GetRootAsICustomScreenLoadingTypeBase(_bb, default(ICustomScreenLoadingTypeBase));
		}

		// Token: 0x0602CDC6 RID: 183750 RVA: 0x00629938 File Offset: 0x00627B38
		public static ICustomScreenLoadingTypeBase GetRootAsICustomScreenLoadingTypeBase(ByteBuffer _bb, ICustomScreenLoadingTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDC7 RID: 183751 RVA: 0x00629955 File Offset: 0x00627B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDC8 RID: 183752 RVA: 0x00629964 File Offset: 0x00627B64
		public ICustomScreenLoadingTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C053 RID: 49235
		// (get) Token: 0x0602CDC9 RID: 183753 RVA: 0x00629974 File Offset: 0x00627B74
		public ECustomScreenLoading Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return (ECustomScreenLoading)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CDCA RID: 183754 RVA: 0x006299B0 File Offset: 0x00627BB0
		public static Offset<ICustomScreenLoadingTypeBase> CreateICustomScreenLoadingTypeBase(FlatBufferBuilder builder, ECustomScreenLoading Type = ECustomScreenLoading.Cyberpunk)
		{
			builder.StartTable(1);
			ICustomScreenLoadingTypeBase.AddType(builder, Type);
			return ICustomScreenLoadingTypeBase.EndICustomScreenLoadingTypeBase(builder);
		}

		// Token: 0x0602CDCB RID: 183755 RVA: 0x006299C6 File Offset: 0x00627BC6
		public static void StartICustomScreenLoadingTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CDCC RID: 183756 RVA: 0x006299CF File Offset: 0x00627BCF
		public static void AddType(FlatBufferBuilder builder, ECustomScreenLoading type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDCD RID: 183757 RVA: 0x006299DA File Offset: 0x00627BDA
		public static Offset<ICustomScreenLoadingTypeBase> EndICustomScreenLoadingTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenLoadingTypeBase>(builder.EndTable());
		}

		// Token: 0x0602CDCE RID: 183758 RVA: 0x006299E8 File Offset: 0x00627BE8
		public ICustomScreenLoadingTypeBaseT UnPack()
		{
			ICustomScreenLoadingTypeBaseT customScreenLoadingTypeBaseT = new ICustomScreenLoadingTypeBaseT();
			this.UnPackTo(customScreenLoadingTypeBaseT);
			return customScreenLoadingTypeBaseT;
		}

		// Token: 0x0602CDCF RID: 183759 RVA: 0x00629A03 File Offset: 0x00627C03
		public void UnPackTo(ICustomScreenLoadingTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CDD0 RID: 183760 RVA: 0x00629A14 File Offset: 0x00627C14
		public static Offset<ICustomScreenLoadingTypeBase> Pack(FlatBufferBuilder builder, ICustomScreenLoadingTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenLoadingTypeBase>);
			}
			return ICustomScreenLoadingTypeBase.CreateICustomScreenLoadingTypeBase(builder, _o.Type);
		}

		// Token: 0x04010B46 RID: 68422
		private Table __p;
	}
}
