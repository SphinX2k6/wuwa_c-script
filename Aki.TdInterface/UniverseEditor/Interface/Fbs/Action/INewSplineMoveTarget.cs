using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9A RID: 27546
	public struct INewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700CCC5 RID: 52421
		// (get) Token: 0x0603061F RID: 198175 RVA: 0x006927C2 File Offset: 0x006909C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030620 RID: 198176 RVA: 0x006927CF File Offset: 0x006909CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030621 RID: 198177 RVA: 0x006927D8 File Offset: 0x006909D8
		public static INewSplineMoveTarget GetRootAsINewSplineMoveTarget(ByteBuffer _bb)
		{
			return INewSplineMoveTarget.GetRootAsINewSplineMoveTarget(_bb, default(INewSplineMoveTarget));
		}

		// Token: 0x06030622 RID: 198178 RVA: 0x006927F4 File Offset: 0x006909F4
		public static INewSplineMoveTarget GetRootAsINewSplineMoveTarget(ByteBuffer _bb, INewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030623 RID: 198179 RVA: 0x00692811 File Offset: 0x00690A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030624 RID: 198180 RVA: 0x00692820 File Offset: 0x00690A20
		public INewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCC6 RID: 52422
		// (get) Token: 0x06030625 RID: 198181 RVA: 0x00692830 File Offset: 0x00690A30
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030626 RID: 198182 RVA: 0x0069286C File Offset: 0x00690A6C
		public static Offset<INewSplineMoveTarget> CreateINewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			INewSplineMoveTarget.AddType(builder, Type);
			return INewSplineMoveTarget.EndINewSplineMoveTarget(builder);
		}

		// Token: 0x06030627 RID: 198183 RVA: 0x00692882 File Offset: 0x00690A82
		public static void StartINewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030628 RID: 198184 RVA: 0x0069288B File Offset: 0x00690A8B
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030629 RID: 198185 RVA: 0x00692896 File Offset: 0x00690A96
		public static Offset<INewSplineMoveTarget> EndINewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<INewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x0603062A RID: 198186 RVA: 0x006928A4 File Offset: 0x00690AA4
		public INewSplineMoveTargetT UnPack()
		{
			INewSplineMoveTargetT newSplineMoveTargetT = new INewSplineMoveTargetT();
			this.UnPackTo(newSplineMoveTargetT);
			return newSplineMoveTargetT;
		}

		// Token: 0x0603062B RID: 198187 RVA: 0x006928BF File Offset: 0x00690ABF
		public void UnPackTo(INewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603062C RID: 198188 RVA: 0x006928D0 File Offset: 0x00690AD0
		public static Offset<INewSplineMoveTarget> Pack(FlatBufferBuilder builder, INewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewSplineMoveTarget>);
			}
			return INewSplineMoveTarget.CreateINewSplineMoveTarget(builder, _o.Type);
		}

		// Token: 0x04011460 RID: 70752
		private Table __p;
	}
}
