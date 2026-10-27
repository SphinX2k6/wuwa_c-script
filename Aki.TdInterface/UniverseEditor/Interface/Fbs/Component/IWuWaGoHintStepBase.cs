using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB2 RID: 23474
	public struct IWuWaGoHintStepBase : IFlatbufferObject
	{
		// Token: 0x1700B163 RID: 45411
		// (get) Token: 0x06028337 RID: 164663 RVA: 0x00586398 File Offset: 0x00584598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028338 RID: 164664 RVA: 0x005863A5 File Offset: 0x005845A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028339 RID: 164665 RVA: 0x005863AC File Offset: 0x005845AC
		public static IWuWaGoHintStepBase GetRootAsIWuWaGoHintStepBase(ByteBuffer _bb)
		{
			return IWuWaGoHintStepBase.GetRootAsIWuWaGoHintStepBase(_bb, default(IWuWaGoHintStepBase));
		}

		// Token: 0x0602833A RID: 164666 RVA: 0x005863C8 File Offset: 0x005845C8
		public static IWuWaGoHintStepBase GetRootAsIWuWaGoHintStepBase(ByteBuffer _bb, IWuWaGoHintStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602833B RID: 164667 RVA: 0x005863E5 File Offset: 0x005845E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602833C RID: 164668 RVA: 0x005863F4 File Offset: 0x005845F4
		public IWuWaGoHintStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B164 RID: 45412
		// (get) Token: 0x0602833D RID: 164669 RVA: 0x00586404 File Offset: 0x00584604
		public EWuWaGoHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoHintStepType.Move;
				}
				return (EWuWaGoHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602833E RID: 164670 RVA: 0x00586440 File Offset: 0x00584640
		public static Offset<IWuWaGoHintStepBase> CreateIWuWaGoHintStepBase(FlatBufferBuilder builder, EWuWaGoHintStepType Type = EWuWaGoHintStepType.Move)
		{
			builder.StartTable(1);
			IWuWaGoHintStepBase.AddType(builder, Type);
			return IWuWaGoHintStepBase.EndIWuWaGoHintStepBase(builder);
		}

		// Token: 0x0602833F RID: 164671 RVA: 0x00586456 File Offset: 0x00584656
		public static void StartIWuWaGoHintStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028340 RID: 164672 RVA: 0x0058645F File Offset: 0x0058465F
		public static void AddType(FlatBufferBuilder builder, EWuWaGoHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028341 RID: 164673 RVA: 0x0058646A File Offset: 0x0058466A
		public static Offset<IWuWaGoHintStepBase> EndIWuWaGoHintStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoHintStepBase>(builder.EndTable());
		}

		// Token: 0x06028342 RID: 164674 RVA: 0x00586478 File Offset: 0x00584678
		public IWuWaGoHintStepBaseT UnPack()
		{
			IWuWaGoHintStepBaseT wuWaGoHintStepBaseT = new IWuWaGoHintStepBaseT();
			this.UnPackTo(wuWaGoHintStepBaseT);
			return wuWaGoHintStepBaseT;
		}

		// Token: 0x06028343 RID: 164675 RVA: 0x00586493 File Offset: 0x00584693
		public void UnPackTo(IWuWaGoHintStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028344 RID: 164676 RVA: 0x005864A4 File Offset: 0x005846A4
		public static Offset<IWuWaGoHintStepBase> Pack(FlatBufferBuilder builder, IWuWaGoHintStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoHintStepBase>);
			}
			return IWuWaGoHintStepBase.CreateIWuWaGoHintStepBase(builder, _o.Type);
		}

		// Token: 0x0400F328 RID: 62248
		private Table __p;
	}
}
