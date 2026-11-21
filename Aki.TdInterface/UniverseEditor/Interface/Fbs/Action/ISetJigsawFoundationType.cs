using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D3 RID: 30675
	public struct ISetJigsawFoundationType : IFlatbufferObject
	{
		// Token: 0x1700E0DA RID: 57562
		// (get) Token: 0x06035E27 RID: 220711 RVA: 0x00738383 File Offset: 0x00736583
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E28 RID: 220712 RVA: 0x00738390 File Offset: 0x00736590
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E29 RID: 220713 RVA: 0x00738398 File Offset: 0x00736598
		public static ISetJigsawFoundationType GetRootAsISetJigsawFoundationType(ByteBuffer _bb)
		{
			return ISetJigsawFoundationType.GetRootAsISetJigsawFoundationType(_bb, default(ISetJigsawFoundationType));
		}

		// Token: 0x06035E2A RID: 220714 RVA: 0x007383B4 File Offset: 0x007365B4
		public static ISetJigsawFoundationType GetRootAsISetJigsawFoundationType(ByteBuffer _bb, ISetJigsawFoundationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E2B RID: 220715 RVA: 0x007383D1 File Offset: 0x007365D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E2C RID: 220716 RVA: 0x007383E0 File Offset: 0x007365E0
		public ISetJigsawFoundationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0DB RID: 57563
		// (get) Token: 0x06035E2D RID: 220717 RVA: 0x007383F0 File Offset: 0x007365F0
		public ESetJigsawFoundationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return (ESetJigsawFoundationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035E2E RID: 220718 RVA: 0x0073842C File Offset: 0x0073662C
		public static Offset<ISetJigsawFoundationType> CreateISetJigsawFoundationType(FlatBufferBuilder builder, ESetJigsawFoundationType Type = ESetJigsawFoundationType.SetPieceState)
		{
			builder.StartTable(1);
			ISetJigsawFoundationType.AddType(builder, Type);
			return ISetJigsawFoundationType.EndISetJigsawFoundationType(builder);
		}

		// Token: 0x06035E2F RID: 220719 RVA: 0x00738442 File Offset: 0x00736642
		public static void StartISetJigsawFoundationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E30 RID: 220720 RVA: 0x0073844B File Offset: 0x0073664B
		public static void AddType(FlatBufferBuilder builder, ESetJigsawFoundationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E31 RID: 220721 RVA: 0x00738456 File Offset: 0x00736656
		public static Offset<ISetJigsawFoundationType> EndISetJigsawFoundationType(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawFoundationType>(builder.EndTable());
		}

		// Token: 0x06035E32 RID: 220722 RVA: 0x00738464 File Offset: 0x00736664
		public ISetJigsawFoundationTypeT UnPack()
		{
			ISetJigsawFoundationTypeT setJigsawFoundationTypeT = new ISetJigsawFoundationTypeT();
			this.UnPackTo(setJigsawFoundationTypeT);
			return setJigsawFoundationTypeT;
		}

		// Token: 0x06035E33 RID: 220723 RVA: 0x0073847F File Offset: 0x0073667F
		public void UnPackTo(ISetJigsawFoundationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035E34 RID: 220724 RVA: 0x00738490 File Offset: 0x00736690
		public static Offset<ISetJigsawFoundationType> Pack(FlatBufferBuilder builder, ISetJigsawFoundationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawFoundationType>);
			}
			return ISetJigsawFoundationType.CreateISetJigsawFoundationType(builder, _o.Type);
		}

		// Token: 0x04012A12 RID: 76306
		private Table __p;
	}
}
