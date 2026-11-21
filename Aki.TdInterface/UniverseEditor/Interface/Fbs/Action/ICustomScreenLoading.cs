using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6C RID: 27500
	public struct ICustomScreenLoading : IFlatbufferObject
	{
		// Token: 0x1700C9DA RID: 51674
		// (get) Token: 0x0602F531 RID: 193841 RVA: 0x006757A1 File Offset: 0x006739A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F532 RID: 193842 RVA: 0x006757AE File Offset: 0x006739AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F533 RID: 193843 RVA: 0x006757B8 File Offset: 0x006739B8
		public static ICustomScreenLoading GetRootAsICustomScreenLoading(ByteBuffer _bb)
		{
			return ICustomScreenLoading.GetRootAsICustomScreenLoading(_bb, default(ICustomScreenLoading));
		}

		// Token: 0x0602F534 RID: 193844 RVA: 0x006757D4 File Offset: 0x006739D4
		public static ICustomScreenLoading GetRootAsICustomScreenLoading(ByteBuffer _bb, ICustomScreenLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F535 RID: 193845 RVA: 0x006757F1 File Offset: 0x006739F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F536 RID: 193846 RVA: 0x00675800 File Offset: 0x00673A00
		public ICustomScreenLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9DB RID: 51675
		// (get) Token: 0x0602F537 RID: 193847 RVA: 0x00675810 File Offset: 0x00673A10
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C9DC RID: 51676
		// (get) Token: 0x0602F538 RID: 193848 RVA: 0x0067584C File Offset: 0x00673A4C
		public ICustomScreenLoadingCyberpunk? LoadingType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICustomScreenLoadingCyberpunk?(default(ICustomScreenLoadingCyberpunk).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F539 RID: 193849 RVA: 0x006758A9 File Offset: 0x00673AA9
		public static Offset<ICustomScreenLoading> CreateICustomScreenLoading(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine, Offset<ICustomScreenLoadingCyberpunk> LoadingTypeOffset = default(Offset<ICustomScreenLoadingCyberpunk>))
		{
			builder.StartTable(2);
			ICustomScreenLoading.AddLoadingType(builder, LoadingTypeOffset);
			ICustomScreenLoading.AddType(builder, Type);
			return ICustomScreenLoading.EndICustomScreenLoading(builder);
		}

		// Token: 0x0602F53A RID: 193850 RVA: 0x006758C6 File Offset: 0x00673AC6
		public static void StartICustomScreenLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F53B RID: 193851 RVA: 0x006758CF File Offset: 0x00673ACF
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F53C RID: 193852 RVA: 0x006758DA File Offset: 0x00673ADA
		public static void AddLoadingType(FlatBufferBuilder builder, Offset<ICustomScreenLoadingCyberpunk> loadingTypeOffset)
		{
			builder.AddOffset(1, loadingTypeOffset.Value, 0);
		}

		// Token: 0x0602F53D RID: 193853 RVA: 0x006758EA File Offset: 0x00673AEA
		public static Offset<ICustomScreenLoading> EndICustomScreenLoading(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenLoading>(builder.EndTable());
		}

		// Token: 0x0602F53E RID: 193854 RVA: 0x006758F8 File Offset: 0x00673AF8
		public ICustomScreenLoadingT UnPack()
		{
			ICustomScreenLoadingT customScreenLoadingT = new ICustomScreenLoadingT();
			this.UnPackTo(customScreenLoadingT);
			return customScreenLoadingT;
		}

		// Token: 0x0602F53F RID: 193855 RVA: 0x00675914 File Offset: 0x00673B14
		public void UnPackTo(ICustomScreenLoadingT _o)
		{
			_o.Type = this.Type;
			_o.LoadingType = ((this.LoadingType != null) ? this.LoadingType.Value.UnPack() : null);
		}

		// Token: 0x0602F540 RID: 193856 RVA: 0x0067595C File Offset: 0x00673B5C
		public static Offset<ICustomScreenLoading> Pack(FlatBufferBuilder builder, ICustomScreenLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenLoading>);
			}
			Offset<ICustomScreenLoadingCyberpunk> loadingTypeOffset = (_o.LoadingType == null) ? default(Offset<ICustomScreenLoadingCyberpunk>) : ICustomScreenLoadingCyberpunk.Pack(builder, _o.LoadingType);
			return ICustomScreenLoading.CreateICustomScreenLoading(builder, _o.Type, loadingTypeOffset);
		}

		// Token: 0x04011959 RID: 72025
		private Table __p;
	}
}
