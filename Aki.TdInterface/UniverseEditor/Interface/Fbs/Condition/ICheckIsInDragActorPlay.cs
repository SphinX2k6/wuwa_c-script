using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A93 RID: 19091
	public struct ICheckIsInDragActorPlay : IFlatbufferObject
	{
		// Token: 0x17008A51 RID: 35409
		// (get) Token: 0x0601DF16 RID: 122646 RVA: 0x0043466C File Offset: 0x0043286C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF17 RID: 122647 RVA: 0x00434679 File Offset: 0x00432879
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF18 RID: 122648 RVA: 0x00434680 File Offset: 0x00432880
		public static ICheckIsInDragActorPlay GetRootAsICheckIsInDragActorPlay(ByteBuffer _bb)
		{
			return ICheckIsInDragActorPlay.GetRootAsICheckIsInDragActorPlay(_bb, default(ICheckIsInDragActorPlay));
		}

		// Token: 0x0601DF19 RID: 122649 RVA: 0x0043469C File Offset: 0x0043289C
		public static ICheckIsInDragActorPlay GetRootAsICheckIsInDragActorPlay(ByteBuffer _bb, ICheckIsInDragActorPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF1A RID: 122650 RVA: 0x004346B9 File Offset: 0x004328B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF1B RID: 122651 RVA: 0x004346C8 File Offset: 0x004328C8
		public ICheckIsInDragActorPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A52 RID: 35410
		// (get) Token: 0x0601DF1C RID: 122652 RVA: 0x004346D8 File Offset: 0x004328D8
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

		// Token: 0x17008A53 RID: 35411
		// (get) Token: 0x0601DF1D RID: 122653 RVA: 0x00434714 File Offset: 0x00432914
		public bool IsIn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DF1E RID: 122654 RVA: 0x00434753 File Offset: 0x00432953
		public static Offset<ICheckIsInDragActorPlay> CreateICheckIsInDragActorPlay(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsIn = false)
		{
			builder.StartTable(2);
			ICheckIsInDragActorPlay.AddIsIn(builder, IsIn);
			ICheckIsInDragActorPlay.AddType(builder, Type);
			return ICheckIsInDragActorPlay.EndICheckIsInDragActorPlay(builder);
		}

		// Token: 0x0601DF1F RID: 122655 RVA: 0x00434770 File Offset: 0x00432970
		public static void StartICheckIsInDragActorPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF20 RID: 122656 RVA: 0x00434779 File Offset: 0x00432979
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DF21 RID: 122657 RVA: 0x00434784 File Offset: 0x00432984
		public static void AddIsIn(FlatBufferBuilder builder, bool isIn)
		{
			builder.AddBool(1, isIn, false);
		}

		// Token: 0x0601DF22 RID: 122658 RVA: 0x0043478F File Offset: 0x0043298F
		public static Offset<ICheckIsInDragActorPlay> EndICheckIsInDragActorPlay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsInDragActorPlay>(builder.EndTable());
		}

		// Token: 0x0601DF23 RID: 122659 RVA: 0x0043479C File Offset: 0x0043299C
		public ICheckIsInDragActorPlayT UnPack()
		{
			ICheckIsInDragActorPlayT checkIsInDragActorPlayT = new ICheckIsInDragActorPlayT();
			this.UnPackTo(checkIsInDragActorPlayT);
			return checkIsInDragActorPlayT;
		}

		// Token: 0x0601DF24 RID: 122660 RVA: 0x004347B7 File Offset: 0x004329B7
		public void UnPackTo(ICheckIsInDragActorPlayT _o)
		{
			_o.Type = this.Type;
			_o.IsIn = this.IsIn;
		}

		// Token: 0x0601DF25 RID: 122661 RVA: 0x004347D4 File Offset: 0x004329D4
		public static Offset<ICheckIsInDragActorPlay> Pack(FlatBufferBuilder builder, ICheckIsInDragActorPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsInDragActorPlay>);
			}
			return ICheckIsInDragActorPlay.CreateICheckIsInDragActorPlay(builder, _o.Type, _o.IsIn);
		}

		// Token: 0x0400D304 RID: 54020
		private Table __p;
	}
}
