using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007073 RID: 28787
	public struct ISetSpineAnimationType : IFlatbufferObject
	{
		// Token: 0x1700D5F5 RID: 54773
		// (get) Token: 0x06032F86 RID: 208774 RVA: 0x006E0283 File Offset: 0x006DE483
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F87 RID: 208775 RVA: 0x006E0290 File Offset: 0x006DE490
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F88 RID: 208776 RVA: 0x006E0298 File Offset: 0x006DE498
		public static ISetSpineAnimationType GetRootAsISetSpineAnimationType(ByteBuffer _bb)
		{
			return ISetSpineAnimationType.GetRootAsISetSpineAnimationType(_bb, default(ISetSpineAnimationType));
		}

		// Token: 0x06032F89 RID: 208777 RVA: 0x006E02B4 File Offset: 0x006DE4B4
		public static ISetSpineAnimationType GetRootAsISetSpineAnimationType(ByteBuffer _bb, ISetSpineAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F8A RID: 208778 RVA: 0x006E02D1 File Offset: 0x006DE4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F8B RID: 208779 RVA: 0x006E02E0 File Offset: 0x006DE4E0
		public ISetSpineAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5F6 RID: 54774
		// (get) Token: 0x06032F8C RID: 208780 RVA: 0x006E02F0 File Offset: 0x006DE4F0
		public ESetSpineAnimation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetSpineAnimation.Play;
				}
				return (ESetSpineAnimation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F8D RID: 208781 RVA: 0x006E032C File Offset: 0x006DE52C
		public static Offset<ISetSpineAnimationType> CreateISetSpineAnimationType(FlatBufferBuilder builder, ESetSpineAnimation Type = ESetSpineAnimation.Play)
		{
			builder.StartTable(1);
			ISetSpineAnimationType.AddType(builder, Type);
			return ISetSpineAnimationType.EndISetSpineAnimationType(builder);
		}

		// Token: 0x06032F8E RID: 208782 RVA: 0x006E0342 File Offset: 0x006DE542
		public static void StartISetSpineAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032F8F RID: 208783 RVA: 0x006E034B File Offset: 0x006DE54B
		public static void AddType(FlatBufferBuilder builder, ESetSpineAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032F90 RID: 208784 RVA: 0x006E0356 File Offset: 0x006DE556
		public static Offset<ISetSpineAnimationType> EndISetSpineAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<ISetSpineAnimationType>(builder.EndTable());
		}

		// Token: 0x06032F91 RID: 208785 RVA: 0x006E0364 File Offset: 0x006DE564
		public ISetSpineAnimationTypeT UnPack()
		{
			ISetSpineAnimationTypeT setSpineAnimationTypeT = new ISetSpineAnimationTypeT();
			this.UnPackTo(setSpineAnimationTypeT);
			return setSpineAnimationTypeT;
		}

		// Token: 0x06032F92 RID: 208786 RVA: 0x006E037F File Offset: 0x006DE57F
		public void UnPackTo(ISetSpineAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032F93 RID: 208787 RVA: 0x006E0390 File Offset: 0x006DE590
		public static Offset<ISetSpineAnimationType> Pack(FlatBufferBuilder builder, ISetSpineAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSpineAnimationType>);
			}
			return ISetSpineAnimationType.CreateISetSpineAnimationType(builder, _o.Type);
		}

		// Token: 0x04011AD7 RID: 72407
		private Table __p;
	}
}
