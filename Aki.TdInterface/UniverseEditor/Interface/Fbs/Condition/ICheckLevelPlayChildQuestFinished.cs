using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F8C RID: 20364
	public struct ICheckLevelPlayChildQuestFinished : IFlatbufferObject
	{
		// Token: 0x1700919B RID: 37275
		// (get) Token: 0x0601FB73 RID: 129907 RVA: 0x0046889C File Offset: 0x00466A9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB74 RID: 129908 RVA: 0x004688A9 File Offset: 0x00466AA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB75 RID: 129909 RVA: 0x004688B0 File Offset: 0x00466AB0
		public static ICheckLevelPlayChildQuestFinished GetRootAsICheckLevelPlayChildQuestFinished(ByteBuffer _bb)
		{
			return ICheckLevelPlayChildQuestFinished.GetRootAsICheckLevelPlayChildQuestFinished(_bb, default(ICheckLevelPlayChildQuestFinished));
		}

		// Token: 0x0601FB76 RID: 129910 RVA: 0x004688CC File Offset: 0x00466ACC
		public static ICheckLevelPlayChildQuestFinished GetRootAsICheckLevelPlayChildQuestFinished(ByteBuffer _bb, ICheckLevelPlayChildQuestFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB77 RID: 129911 RVA: 0x004688E9 File Offset: 0x00466AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB78 RID: 129912 RVA: 0x004688F8 File Offset: 0x00466AF8
		public ICheckLevelPlayChildQuestFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700919C RID: 37276
		// (get) Token: 0x0601FB79 RID: 129913 RVA: 0x00468908 File Offset: 0x00466B08
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700919D RID: 37277
		// (get) Token: 0x0601FB7A RID: 129914 RVA: 0x00468944 File Offset: 0x00466B44
		public int ChildQuestId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700919E RID: 37278
		// (get) Token: 0x0601FB7B RID: 129915 RVA: 0x00468980 File Offset: 0x00466B80
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB7C RID: 129916 RVA: 0x004689BC File Offset: 0x00466BBC
		public static Offset<ICheckLevelPlayChildQuestFinished> CreateICheckLevelPlayChildQuestFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChildQuestId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICheckLevelPlayChildQuestFinished.AddChildQuestId(builder, ChildQuestId);
			ICheckLevelPlayChildQuestFinished.AddCompare(builder, Compare);
			ICheckLevelPlayChildQuestFinished.AddType(builder, Type);
			return ICheckLevelPlayChildQuestFinished.EndICheckLevelPlayChildQuestFinished(builder);
		}

		// Token: 0x0601FB7D RID: 129917 RVA: 0x004689E0 File Offset: 0x00466BE0
		public static void StartICheckLevelPlayChildQuestFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FB7E RID: 129918 RVA: 0x004689E9 File Offset: 0x00466BE9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB7F RID: 129919 RVA: 0x004689F4 File Offset: 0x00466BF4
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x0601FB80 RID: 129920 RVA: 0x004689FF File Offset: 0x00466BFF
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601FB81 RID: 129921 RVA: 0x00468A0A File Offset: 0x00466C0A
		public static Offset<ICheckLevelPlayChildQuestFinished> EndICheckLevelPlayChildQuestFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayChildQuestFinished>(builder.EndTable());
		}

		// Token: 0x0601FB82 RID: 129922 RVA: 0x00468A18 File Offset: 0x00466C18
		public ICheckLevelPlayChildQuestFinishedT UnPack()
		{
			ICheckLevelPlayChildQuestFinishedT checkLevelPlayChildQuestFinishedT = new ICheckLevelPlayChildQuestFinishedT();
			this.UnPackTo(checkLevelPlayChildQuestFinishedT);
			return checkLevelPlayChildQuestFinishedT;
		}

		// Token: 0x0601FB83 RID: 129923 RVA: 0x00468A33 File Offset: 0x00466C33
		public void UnPackTo(ICheckLevelPlayChildQuestFinishedT _o)
		{
			_o.Type = this.Type;
			_o.ChildQuestId = this.ChildQuestId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601FB84 RID: 129924 RVA: 0x00468A5C File Offset: 0x00466C5C
		public static Offset<ICheckLevelPlayChildQuestFinished> Pack(FlatBufferBuilder builder, ICheckLevelPlayChildQuestFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayChildQuestFinished>);
			}
			return ICheckLevelPlayChildQuestFinished.CreateICheckLevelPlayChildQuestFinished(builder, _o.Type, _o.ChildQuestId, _o.Compare);
		}

		// Token: 0x0400DE24 RID: 56868
		private Table __p;
	}
}
