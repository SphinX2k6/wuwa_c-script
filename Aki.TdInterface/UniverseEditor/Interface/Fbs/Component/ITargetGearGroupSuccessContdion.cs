using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006041 RID: 24641
	public struct ITargetGearGroupSuccessContdion : IFlatbufferObject
	{
		// Token: 0x1700B6E6 RID: 46822
		// (get) Token: 0x06029988 RID: 170376 RVA: 0x005ADC52 File Offset: 0x005ABE52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029989 RID: 170377 RVA: 0x005ADC5F File Offset: 0x005ABE5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602998A RID: 170378 RVA: 0x005ADC68 File Offset: 0x005ABE68
		public static ITargetGearGroupSuccessContdion GetRootAsITargetGearGroupSuccessContdion(ByteBuffer _bb)
		{
			return ITargetGearGroupSuccessContdion.GetRootAsITargetGearGroupSuccessContdion(_bb, default(ITargetGearGroupSuccessContdion));
		}

		// Token: 0x0602998B RID: 170379 RVA: 0x005ADC84 File Offset: 0x005ABE84
		public static ITargetGearGroupSuccessContdion GetRootAsITargetGearGroupSuccessContdion(ByteBuffer _bb, ITargetGearGroupSuccessContdion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602998C RID: 170380 RVA: 0x005ADCA1 File Offset: 0x005ABEA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602998D RID: 170381 RVA: 0x005ADCB0 File Offset: 0x005ABEB0
		public ITargetGearGroupSuccessContdion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6E7 RID: 46823
		// (get) Token: 0x0602998E RID: 170382 RVA: 0x005ADCC0 File Offset: 0x005ABEC0
		public ETargetGearGroupSuccessCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return (ETargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602998F RID: 170383 RVA: 0x005ADCFC File Offset: 0x005ABEFC
		public static Offset<ITargetGearGroupSuccessContdion> CreateITargetGearGroupSuccessContdion(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState)
		{
			builder.StartTable(1);
			ITargetGearGroupSuccessContdion.AddType(builder, Type);
			return ITargetGearGroupSuccessContdion.EndITargetGearGroupSuccessContdion(builder);
		}

		// Token: 0x06029990 RID: 170384 RVA: 0x005ADD12 File Offset: 0x005ABF12
		public static void StartITargetGearGroupSuccessContdion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029991 RID: 170385 RVA: 0x005ADD1B File Offset: 0x005ABF1B
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029992 RID: 170386 RVA: 0x005ADD26 File Offset: 0x005ABF26
		public static Offset<ITargetGearGroupSuccessContdion> EndITargetGearGroupSuccessContdion(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupSuccessContdion>(builder.EndTable());
		}

		// Token: 0x06029993 RID: 170387 RVA: 0x005ADD34 File Offset: 0x005ABF34
		public ITargetGearGroupSuccessContdionT UnPack()
		{
			ITargetGearGroupSuccessContdionT targetGearGroupSuccessContdionT = new ITargetGearGroupSuccessContdionT();
			this.UnPackTo(targetGearGroupSuccessContdionT);
			return targetGearGroupSuccessContdionT;
		}

		// Token: 0x06029994 RID: 170388 RVA: 0x005ADD4F File Offset: 0x005ABF4F
		public void UnPackTo(ITargetGearGroupSuccessContdionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029995 RID: 170389 RVA: 0x005ADD60 File Offset: 0x005ABF60
		public static Offset<ITargetGearGroupSuccessContdion> Pack(FlatBufferBuilder builder, ITargetGearGroupSuccessContdionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupSuccessContdion>);
			}
			return ITargetGearGroupSuccessContdion.CreateITargetGearGroupSuccessContdion(builder, _o.Type);
		}

		// Token: 0x0400FD97 RID: 64919
		private Table __p;
	}
}
