using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBA RID: 27834
	public struct IPhotographCameraTransformBase : IFlatbufferObject
	{
		// Token: 0x1700CF3A RID: 53050
		// (get) Token: 0x060310D3 RID: 200915 RVA: 0x006A84B2 File Offset: 0x006A66B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310D4 RID: 200916 RVA: 0x006A84BF File Offset: 0x006A66BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310D5 RID: 200917 RVA: 0x006A84C8 File Offset: 0x006A66C8
		public static IPhotographCameraTransformBase GetRootAsIPhotographCameraTransformBase(ByteBuffer _bb)
		{
			return IPhotographCameraTransformBase.GetRootAsIPhotographCameraTransformBase(_bb, default(IPhotographCameraTransformBase));
		}

		// Token: 0x060310D6 RID: 200918 RVA: 0x006A84E4 File Offset: 0x006A66E4
		public static IPhotographCameraTransformBase GetRootAsIPhotographCameraTransformBase(ByteBuffer _bb, IPhotographCameraTransformBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310D7 RID: 200919 RVA: 0x006A8501 File Offset: 0x006A6701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310D8 RID: 200920 RVA: 0x006A8510 File Offset: 0x006A6710
		public IPhotographCameraTransformBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF3B RID: 53051
		// (get) Token: 0x060310D9 RID: 200921 RVA: 0x006A8520 File Offset: 0x006A6720
		public EPhotographCameraTransform Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraTransform.Absolute;
				}
				return (EPhotographCameraTransform)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060310DA RID: 200922 RVA: 0x006A855C File Offset: 0x006A675C
		public static Offset<IPhotographCameraTransformBase> CreateIPhotographCameraTransformBase(FlatBufferBuilder builder, EPhotographCameraTransform Type = EPhotographCameraTransform.Absolute)
		{
			builder.StartTable(1);
			IPhotographCameraTransformBase.AddType(builder, Type);
			return IPhotographCameraTransformBase.EndIPhotographCameraTransformBase(builder);
		}

		// Token: 0x060310DB RID: 200923 RVA: 0x006A8572 File Offset: 0x006A6772
		public static void StartIPhotographCameraTransformBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060310DC RID: 200924 RVA: 0x006A857B File Offset: 0x006A677B
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraTransform type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060310DD RID: 200925 RVA: 0x006A8586 File Offset: 0x006A6786
		public static Offset<IPhotographCameraTransformBase> EndIPhotographCameraTransformBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraTransformBase>(builder.EndTable());
		}

		// Token: 0x060310DE RID: 200926 RVA: 0x006A8594 File Offset: 0x006A6794
		public IPhotographCameraTransformBaseT UnPack()
		{
			IPhotographCameraTransformBaseT photographCameraTransformBaseT = new IPhotographCameraTransformBaseT();
			this.UnPackTo(photographCameraTransformBaseT);
			return photographCameraTransformBaseT;
		}

		// Token: 0x060310DF RID: 200927 RVA: 0x006A85AF File Offset: 0x006A67AF
		public void UnPackTo(IPhotographCameraTransformBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060310E0 RID: 200928 RVA: 0x006A85C0 File Offset: 0x006A67C0
		public static Offset<IPhotographCameraTransformBase> Pack(FlatBufferBuilder builder, IPhotographCameraTransformBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraTransformBase>);
			}
			return IPhotographCameraTransformBase.CreateIPhotographCameraTransformBase(builder, _o.Type);
		}

		// Token: 0x0401161A RID: 71194
		private Table __p;
	}
}
