using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200783F RID: 30783
	public struct ISetSpineAnimationType : IFlatbufferObject
	{
		// Token: 0x1700E1D8 RID: 57816
		// (get) Token: 0x06036227 RID: 221735 RVA: 0x00740837 File Offset: 0x0073EA37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036228 RID: 221736 RVA: 0x00740844 File Offset: 0x0073EA44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036229 RID: 221737 RVA: 0x0074084C File Offset: 0x0073EA4C
		public static ISetSpineAnimationType GetRootAsISetSpineAnimationType(ByteBuffer _bb)
		{
			return ISetSpineAnimationType.GetRootAsISetSpineAnimationType(_bb, default(ISetSpineAnimationType));
		}

		// Token: 0x0603622A RID: 221738 RVA: 0x00740868 File Offset: 0x0073EA68
		public static ISetSpineAnimationType GetRootAsISetSpineAnimationType(ByteBuffer _bb, ISetSpineAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603622B RID: 221739 RVA: 0x00740885 File Offset: 0x0073EA85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603622C RID: 221740 RVA: 0x00740894 File Offset: 0x0073EA94
		public ISetSpineAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1D9 RID: 57817
		// (get) Token: 0x0603622D RID: 221741 RVA: 0x007408A4 File Offset: 0x0073EAA4
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

		// Token: 0x0603622E RID: 221742 RVA: 0x007408E0 File Offset: 0x0073EAE0
		public static Offset<ISetSpineAnimationType> CreateISetSpineAnimationType(FlatBufferBuilder builder, ESetSpineAnimation Type = ESetSpineAnimation.Play)
		{
			builder.StartTable(1);
			ISetSpineAnimationType.AddType(builder, Type);
			return ISetSpineAnimationType.EndISetSpineAnimationType(builder);
		}

		// Token: 0x0603622F RID: 221743 RVA: 0x007408F6 File Offset: 0x0073EAF6
		public static void StartISetSpineAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036230 RID: 221744 RVA: 0x007408FF File Offset: 0x0073EAFF
		public static void AddType(FlatBufferBuilder builder, ESetSpineAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036231 RID: 221745 RVA: 0x0074090A File Offset: 0x0073EB0A
		public static Offset<ISetSpineAnimationType> EndISetSpineAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<ISetSpineAnimationType>(builder.EndTable());
		}

		// Token: 0x06036232 RID: 221746 RVA: 0x00740918 File Offset: 0x0073EB18
		public ISetSpineAnimationTypeT UnPack()
		{
			ISetSpineAnimationTypeT setSpineAnimationTypeT = new ISetSpineAnimationTypeT();
			this.UnPackTo(setSpineAnimationTypeT);
			return setSpineAnimationTypeT;
		}

		// Token: 0x06036233 RID: 221747 RVA: 0x00740933 File Offset: 0x0073EB33
		public void UnPackTo(ISetSpineAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036234 RID: 221748 RVA: 0x00740944 File Offset: 0x0073EB44
		public static Offset<ISetSpineAnimationType> Pack(FlatBufferBuilder builder, ISetSpineAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSpineAnimationType>);
			}
			return ISetSpineAnimationType.CreateISetSpineAnimationType(builder, _o.Type);
		}

		// Token: 0x04012AC5 RID: 76485
		private Table __p;
	}
}
