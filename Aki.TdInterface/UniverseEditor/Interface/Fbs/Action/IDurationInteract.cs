using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200661B RID: 26139
	public struct IDurationInteract : IFlatbufferObject
	{
		// Token: 0x1700C23A RID: 49722
		// (get) Token: 0x0602D645 RID: 185925 RVA: 0x00638432 File Offset: 0x00636632
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D646 RID: 185926 RVA: 0x0063843F File Offset: 0x0063663F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D647 RID: 185927 RVA: 0x00638448 File Offset: 0x00636648
		public static IDurationInteract GetRootAsIDurationInteract(ByteBuffer _bb)
		{
			return IDurationInteract.GetRootAsIDurationInteract(_bb, default(IDurationInteract));
		}

		// Token: 0x0602D648 RID: 185928 RVA: 0x00638464 File Offset: 0x00636664
		public static IDurationInteract GetRootAsIDurationInteract(ByteBuffer _bb, IDurationInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D649 RID: 185929 RVA: 0x00638481 File Offset: 0x00636681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D64A RID: 185930 RVA: 0x00638490 File Offset: 0x00636690
		public IDurationInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C23B RID: 49723
		// (get) Token: 0x0602D64B RID: 185931 RVA: 0x006384A0 File Offset: 0x006366A0
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D64C RID: 185932 RVA: 0x006384E0 File Offset: 0x006366E0
		public static Offset<IDurationInteract> CreateIDurationInteract(FlatBufferBuilder builder, float Duration = 0f)
		{
			builder.StartTable(1);
			IDurationInteract.AddDuration(builder, Duration);
			return IDurationInteract.EndIDurationInteract(builder);
		}

		// Token: 0x0602D64D RID: 185933 RVA: 0x006384F6 File Offset: 0x006366F6
		public static void StartIDurationInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D64E RID: 185934 RVA: 0x006384FF File Offset: 0x006366FF
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(0, duration, 0.0);
		}

		// Token: 0x0602D64F RID: 185935 RVA: 0x00638512 File Offset: 0x00636712
		public static Offset<IDurationInteract> EndIDurationInteract(FlatBufferBuilder builder)
		{
			return new Offset<IDurationInteract>(builder.EndTable());
		}

		// Token: 0x0602D650 RID: 185936 RVA: 0x00638520 File Offset: 0x00636720
		public IDurationInteractT UnPack()
		{
			IDurationInteractT durationInteractT = new IDurationInteractT();
			this.UnPackTo(durationInteractT);
			return durationInteractT;
		}

		// Token: 0x0602D651 RID: 185937 RVA: 0x0063853B File Offset: 0x0063673B
		public void UnPackTo(IDurationInteractT _o)
		{
			_o.Duration = this.Duration;
		}

		// Token: 0x0602D652 RID: 185938 RVA: 0x0063854C File Offset: 0x0063674C
		public static Offset<IDurationInteract> Pack(FlatBufferBuilder builder, IDurationInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurationInteract>);
			}
			return IDurationInteract.CreateIDurationInteract(builder, _o.Duration);
		}

		// Token: 0x04010CA9 RID: 68777
		private Table __p;
	}
}
