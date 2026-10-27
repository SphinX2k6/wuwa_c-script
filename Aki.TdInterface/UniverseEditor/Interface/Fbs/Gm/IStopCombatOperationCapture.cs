using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046AE RID: 18094
	public struct IStopCombatOperationCapture : IFlatbufferObject
	{
		// Token: 0x17008085 RID: 32901
		// (get) Token: 0x0601B7DF RID: 112607 RVA: 0x003E7225 File Offset: 0x003E5425
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7E0 RID: 112608 RVA: 0x003E7232 File Offset: 0x003E5432
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7E1 RID: 112609 RVA: 0x003E723C File Offset: 0x003E543C
		public static IStopCombatOperationCapture GetRootAsIStopCombatOperationCapture(ByteBuffer _bb)
		{
			return IStopCombatOperationCapture.GetRootAsIStopCombatOperationCapture(_bb, default(IStopCombatOperationCapture));
		}

		// Token: 0x0601B7E2 RID: 112610 RVA: 0x003E7258 File Offset: 0x003E5458
		public static IStopCombatOperationCapture GetRootAsIStopCombatOperationCapture(ByteBuffer _bb, IStopCombatOperationCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7E3 RID: 112611 RVA: 0x003E7275 File Offset: 0x003E5475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7E4 RID: 112612 RVA: 0x003E7284 File Offset: 0x003E5484
		public IStopCombatOperationCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008086 RID: 32902
		// (get) Token: 0x0601B7E5 RID: 112613 RVA: 0x003E7294 File Offset: 0x003E5494
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

		// Token: 0x0601B7E6 RID: 112614 RVA: 0x003E72D0 File Offset: 0x003E54D0
		public static Offset<IStopCombatOperationCapture> CreateIStopCombatOperationCapture(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IStopCombatOperationCapture.AddType(builder, Type);
			return IStopCombatOperationCapture.EndIStopCombatOperationCapture(builder);
		}

		// Token: 0x0601B7E7 RID: 112615 RVA: 0x003E72E6 File Offset: 0x003E54E6
		public static void StartIStopCombatOperationCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B7E8 RID: 112616 RVA: 0x003E72EF File Offset: 0x003E54EF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7E9 RID: 112617 RVA: 0x003E72FA File Offset: 0x003E54FA
		public static Offset<IStopCombatOperationCapture> EndIStopCombatOperationCapture(FlatBufferBuilder builder)
		{
			return new Offset<IStopCombatOperationCapture>(builder.EndTable());
		}

		// Token: 0x0601B7EA RID: 112618 RVA: 0x003E7308 File Offset: 0x003E5508
		public IStopCombatOperationCaptureT UnPack()
		{
			IStopCombatOperationCaptureT stopCombatOperationCaptureT = new IStopCombatOperationCaptureT();
			this.UnPackTo(stopCombatOperationCaptureT);
			return stopCombatOperationCaptureT;
		}

		// Token: 0x0601B7EB RID: 112619 RVA: 0x003E7323 File Offset: 0x003E5523
		public void UnPackTo(IStopCombatOperationCaptureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B7EC RID: 112620 RVA: 0x003E7334 File Offset: 0x003E5534
		public static Offset<IStopCombatOperationCapture> Pack(FlatBufferBuilder builder, IStopCombatOperationCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopCombatOperationCapture>);
			}
			return IStopCombatOperationCapture.CreateIStopCombatOperationCapture(builder, _o.Type);
		}

		// Token: 0x0400C879 RID: 51321
		private Table __p;
	}
}
