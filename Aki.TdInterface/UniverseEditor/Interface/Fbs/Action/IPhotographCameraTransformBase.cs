using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007430 RID: 29744
	public struct IPhotographCameraTransformBase : IFlatbufferObject
	{
		// Token: 0x1700DA77 RID: 55927
		// (get) Token: 0x060340AA RID: 213162 RVA: 0x007036E6 File Offset: 0x007018E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340AB RID: 213163 RVA: 0x007036F3 File Offset: 0x007018F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340AC RID: 213164 RVA: 0x007036FC File Offset: 0x007018FC
		public static IPhotographCameraTransformBase GetRootAsIPhotographCameraTransformBase(ByteBuffer _bb)
		{
			return IPhotographCameraTransformBase.GetRootAsIPhotographCameraTransformBase(_bb, default(IPhotographCameraTransformBase));
		}

		// Token: 0x060340AD RID: 213165 RVA: 0x00703718 File Offset: 0x00701918
		public static IPhotographCameraTransformBase GetRootAsIPhotographCameraTransformBase(ByteBuffer _bb, IPhotographCameraTransformBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340AE RID: 213166 RVA: 0x00703735 File Offset: 0x00701935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340AF RID: 213167 RVA: 0x00703744 File Offset: 0x00701944
		public IPhotographCameraTransformBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA78 RID: 55928
		// (get) Token: 0x060340B0 RID: 213168 RVA: 0x00703754 File Offset: 0x00701954
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

		// Token: 0x060340B1 RID: 213169 RVA: 0x00703790 File Offset: 0x00701990
		public static Offset<IPhotographCameraTransformBase> CreateIPhotographCameraTransformBase(FlatBufferBuilder builder, EPhotographCameraTransform Type = EPhotographCameraTransform.Absolute)
		{
			builder.StartTable(1);
			IPhotographCameraTransformBase.AddType(builder, Type);
			return IPhotographCameraTransformBase.EndIPhotographCameraTransformBase(builder);
		}

		// Token: 0x060340B2 RID: 213170 RVA: 0x007037A6 File Offset: 0x007019A6
		public static void StartIPhotographCameraTransformBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060340B3 RID: 213171 RVA: 0x007037AF File Offset: 0x007019AF
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraTransform type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060340B4 RID: 213172 RVA: 0x007037BA File Offset: 0x007019BA
		public static Offset<IPhotographCameraTransformBase> EndIPhotographCameraTransformBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraTransformBase>(builder.EndTable());
		}

		// Token: 0x060340B5 RID: 213173 RVA: 0x007037C8 File Offset: 0x007019C8
		public IPhotographCameraTransformBaseT UnPack()
		{
			IPhotographCameraTransformBaseT photographCameraTransformBaseT = new IPhotographCameraTransformBaseT();
			this.UnPackTo(photographCameraTransformBaseT);
			return photographCameraTransformBaseT;
		}

		// Token: 0x060340B6 RID: 213174 RVA: 0x007037E3 File Offset: 0x007019E3
		public void UnPackTo(IPhotographCameraTransformBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060340B7 RID: 213175 RVA: 0x007037F4 File Offset: 0x007019F4
		public static Offset<IPhotographCameraTransformBase> Pack(FlatBufferBuilder builder, IPhotographCameraTransformBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraTransformBase>);
			}
			return IPhotographCameraTransformBase.CreateIPhotographCameraTransformBase(builder, _o.Type);
		}

		// Token: 0x0401258A RID: 75146
		private Table __p;
	}
}
