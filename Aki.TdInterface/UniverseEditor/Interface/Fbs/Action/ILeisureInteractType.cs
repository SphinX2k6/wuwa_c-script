using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007094 RID: 28820
	public struct ILeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700D322 RID: 54050
		// (get) Token: 0x06032029 RID: 204841 RVA: 0x006C533C File Offset: 0x006C353C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603202A RID: 204842 RVA: 0x006C5349 File Offset: 0x006C3549
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603202B RID: 204843 RVA: 0x006C5350 File Offset: 0x006C3550
		public static ILeisureInteractType GetRootAsILeisureInteractType(ByteBuffer _bb)
		{
			return ILeisureInteractType.GetRootAsILeisureInteractType(_bb, default(ILeisureInteractType));
		}

		// Token: 0x0603202C RID: 204844 RVA: 0x006C536C File Offset: 0x006C356C
		public static ILeisureInteractType GetRootAsILeisureInteractType(ByteBuffer _bb, ILeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603202D RID: 204845 RVA: 0x006C5389 File Offset: 0x006C3589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603202E RID: 204846 RVA: 0x006C5398 File Offset: 0x006C3598
		public ILeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D323 RID: 54051
		// (get) Token: 0x0603202F RID: 204847 RVA: 0x006C53A8 File Offset: 0x006C35A8
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032030 RID: 204848 RVA: 0x006C53E4 File Offset: 0x006C35E4
		public static Offset<ILeisureInteractType> CreateILeisureInteractType(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ILeisureInteractType.AddType(builder, Type);
			return ILeisureInteractType.EndILeisureInteractType(builder);
		}

		// Token: 0x06032031 RID: 204849 RVA: 0x006C53FA File Offset: 0x006C35FA
		public static void StartILeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032032 RID: 204850 RVA: 0x006C5403 File Offset: 0x006C3603
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032033 RID: 204851 RVA: 0x006C540E File Offset: 0x006C360E
		public static Offset<ILeisureInteractType> EndILeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<ILeisureInteractType>(builder.EndTable());
		}

		// Token: 0x06032034 RID: 204852 RVA: 0x006C541C File Offset: 0x006C361C
		public ILeisureInteractTypeT UnPack()
		{
			ILeisureInteractTypeT leisureInteractTypeT = new ILeisureInteractTypeT();
			this.UnPackTo(leisureInteractTypeT);
			return leisureInteractTypeT;
		}

		// Token: 0x06032035 RID: 204853 RVA: 0x006C5437 File Offset: 0x006C3637
		public void UnPackTo(ILeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032036 RID: 204854 RVA: 0x006C5448 File Offset: 0x006C3648
		public static Offset<ILeisureInteractType> Pack(FlatBufferBuilder builder, ILeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILeisureInteractType>);
			}
			return ILeisureInteractType.CreateILeisureInteractType(builder, _o.Type);
		}

		// Token: 0x0401200C RID: 73740
		private Table __p;
	}
}
