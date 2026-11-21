using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EBC RID: 24252
	public struct ISceneItemAiPatrolType : IFlatbufferObject
	{
		// Token: 0x1700B32F RID: 45871
		// (get) Token: 0x06028A40 RID: 166464 RVA: 0x0058E60A File Offset: 0x0058C80A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028A41 RID: 166465 RVA: 0x0058E617 File Offset: 0x0058C817
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028A42 RID: 166466 RVA: 0x0058E620 File Offset: 0x0058C820
		public static ISceneItemAiPatrolType GetRootAsISceneItemAiPatrolType(ByteBuffer _bb)
		{
			return ISceneItemAiPatrolType.GetRootAsISceneItemAiPatrolType(_bb, default(ISceneItemAiPatrolType));
		}

		// Token: 0x06028A43 RID: 166467 RVA: 0x0058E63C File Offset: 0x0058C83C
		public static ISceneItemAiPatrolType GetRootAsISceneItemAiPatrolType(ByteBuffer _bb, ISceneItemAiPatrolType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028A44 RID: 166468 RVA: 0x0058E659 File Offset: 0x0058C859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028A45 RID: 166469 RVA: 0x0058E668 File Offset: 0x0058C868
		public ISceneItemAiPatrolType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B330 RID: 45872
		// (get) Token: 0x06028A46 RID: 166470 RVA: 0x0058E678 File Offset: 0x0058C878
		public ESceneItemAiPatrolType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemAiPatrolType.ByGameTime;
				}
				return (ESceneItemAiPatrolType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028A47 RID: 166471 RVA: 0x0058E6B4 File Offset: 0x0058C8B4
		public static Offset<ISceneItemAiPatrolType> CreateISceneItemAiPatrolType(FlatBufferBuilder builder, ESceneItemAiPatrolType Type = ESceneItemAiPatrolType.ByGameTime)
		{
			builder.StartTable(1);
			ISceneItemAiPatrolType.AddType(builder, Type);
			return ISceneItemAiPatrolType.EndISceneItemAiPatrolType(builder);
		}

		// Token: 0x06028A48 RID: 166472 RVA: 0x0058E6CA File Offset: 0x0058C8CA
		public static void StartISceneItemAiPatrolType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028A49 RID: 166473 RVA: 0x0058E6D3 File Offset: 0x0058C8D3
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiPatrolType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028A4A RID: 166474 RVA: 0x0058E6DE File Offset: 0x0058C8DE
		public static Offset<ISceneItemAiPatrolType> EndISceneItemAiPatrolType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiPatrolType>(builder.EndTable());
		}

		// Token: 0x06028A4B RID: 166475 RVA: 0x0058E6EC File Offset: 0x0058C8EC
		public ISceneItemAiPatrolTypeT UnPack()
		{
			ISceneItemAiPatrolTypeT sceneItemAiPatrolTypeT = new ISceneItemAiPatrolTypeT();
			this.UnPackTo(sceneItemAiPatrolTypeT);
			return sceneItemAiPatrolTypeT;
		}

		// Token: 0x06028A4C RID: 166476 RVA: 0x0058E707 File Offset: 0x0058C907
		public void UnPackTo(ISceneItemAiPatrolTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028A4D RID: 166477 RVA: 0x0058E718 File Offset: 0x0058C918
		public static Offset<ISceneItemAiPatrolType> Pack(FlatBufferBuilder builder, ISceneItemAiPatrolTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiPatrolType>);
			}
			return ISceneItemAiPatrolType.CreateISceneItemAiPatrolType(builder, _o.Type);
		}

		// Token: 0x0400FB0E RID: 64270
		private Table __p;
	}
}
