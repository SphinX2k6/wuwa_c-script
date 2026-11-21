using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B16 RID: 19222
	public struct IStopCombatOperationCapture : IFlatbufferObject
	{
		// Token: 0x170086C6 RID: 34502
		// (get) Token: 0x0601CFB4 RID: 118708 RVA: 0x004134C1 File Offset: 0x004116C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFB5 RID: 118709 RVA: 0x004134CE File Offset: 0x004116CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFB6 RID: 118710 RVA: 0x004134D8 File Offset: 0x004116D8
		public static IStopCombatOperationCapture GetRootAsIStopCombatOperationCapture(ByteBuffer _bb)
		{
			return IStopCombatOperationCapture.GetRootAsIStopCombatOperationCapture(_bb, default(IStopCombatOperationCapture));
		}

		// Token: 0x0601CFB7 RID: 118711 RVA: 0x004134F4 File Offset: 0x004116F4
		public static IStopCombatOperationCapture GetRootAsIStopCombatOperationCapture(ByteBuffer _bb, IStopCombatOperationCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFB8 RID: 118712 RVA: 0x00413511 File Offset: 0x00411711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFB9 RID: 118713 RVA: 0x00413520 File Offset: 0x00411720
		public IStopCombatOperationCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086C7 RID: 34503
		// (get) Token: 0x0601CFBA RID: 118714 RVA: 0x00413530 File Offset: 0x00411730
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CFBB RID: 118715 RVA: 0x0041356C File Offset: 0x0041176C
		public static Offset<IStopCombatOperationCapture> CreateIStopCombatOperationCapture(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IStopCombatOperationCapture.AddType(builder, Type);
			return IStopCombatOperationCapture.EndIStopCombatOperationCapture(builder);
		}

		// Token: 0x0601CFBC RID: 118716 RVA: 0x00413582 File Offset: 0x00411782
		public static void StartIStopCombatOperationCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CFBD RID: 118717 RVA: 0x0041358B File Offset: 0x0041178B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CFBE RID: 118718 RVA: 0x00413596 File Offset: 0x00411796
		public static Offset<IStopCombatOperationCapture> EndIStopCombatOperationCapture(FlatBufferBuilder builder)
		{
			return new Offset<IStopCombatOperationCapture>(builder.EndTable());
		}

		// Token: 0x0601CFBF RID: 118719 RVA: 0x004135A4 File Offset: 0x004117A4
		public IStopCombatOperationCaptureT UnPack()
		{
			IStopCombatOperationCaptureT stopCombatOperationCaptureT = new IStopCombatOperationCaptureT();
			this.UnPackTo(stopCombatOperationCaptureT);
			return stopCombatOperationCaptureT;
		}

		// Token: 0x0601CFC0 RID: 118720 RVA: 0x004135BF File Offset: 0x004117BF
		public void UnPackTo(IStopCombatOperationCaptureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CFC1 RID: 118721 RVA: 0x004135D0 File Offset: 0x004117D0
		public static Offset<IStopCombatOperationCapture> Pack(FlatBufferBuilder builder, IStopCombatOperationCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopCombatOperationCapture>);
			}
			return IStopCombatOperationCapture.CreateIStopCombatOperationCapture(builder, _o.Type);
		}

		// Token: 0x0400D2A8 RID: 53928
		private Table __p;
	}
}
