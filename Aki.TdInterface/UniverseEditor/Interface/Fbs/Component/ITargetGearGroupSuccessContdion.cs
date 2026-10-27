using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A34 RID: 23092
	public struct ITargetGearGroupSuccessContdion : IFlatbufferObject
	{
		// Token: 0x1700ADAE RID: 44462
		// (get) Token: 0x06027410 RID: 160784 RVA: 0x00566C8E File Offset: 0x00564E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027411 RID: 160785 RVA: 0x00566C9B File Offset: 0x00564E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027412 RID: 160786 RVA: 0x00566CA4 File Offset: 0x00564EA4
		public static ITargetGearGroupSuccessContdion GetRootAsITargetGearGroupSuccessContdion(ByteBuffer _bb)
		{
			return ITargetGearGroupSuccessContdion.GetRootAsITargetGearGroupSuccessContdion(_bb, default(ITargetGearGroupSuccessContdion));
		}

		// Token: 0x06027413 RID: 160787 RVA: 0x00566CC0 File Offset: 0x00564EC0
		public static ITargetGearGroupSuccessContdion GetRootAsITargetGearGroupSuccessContdion(ByteBuffer _bb, ITargetGearGroupSuccessContdion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027414 RID: 160788 RVA: 0x00566CDD File Offset: 0x00564EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027415 RID: 160789 RVA: 0x00566CEC File Offset: 0x00564EEC
		public ITargetGearGroupSuccessContdion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADAF RID: 44463
		// (get) Token: 0x06027416 RID: 160790 RVA: 0x00566CFC File Offset: 0x00564EFC
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

		// Token: 0x06027417 RID: 160791 RVA: 0x00566D38 File Offset: 0x00564F38
		public static Offset<ITargetGearGroupSuccessContdion> CreateITargetGearGroupSuccessContdion(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState)
		{
			builder.StartTable(1);
			ITargetGearGroupSuccessContdion.AddType(builder, Type);
			return ITargetGearGroupSuccessContdion.EndITargetGearGroupSuccessContdion(builder);
		}

		// Token: 0x06027418 RID: 160792 RVA: 0x00566D4E File Offset: 0x00564F4E
		public static void StartITargetGearGroupSuccessContdion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027419 RID: 160793 RVA: 0x00566D57 File Offset: 0x00564F57
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602741A RID: 160794 RVA: 0x00566D62 File Offset: 0x00564F62
		public static Offset<ITargetGearGroupSuccessContdion> EndITargetGearGroupSuccessContdion(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupSuccessContdion>(builder.EndTable());
		}

		// Token: 0x0602741B RID: 160795 RVA: 0x00566D70 File Offset: 0x00564F70
		public ITargetGearGroupSuccessContdionT UnPack()
		{
			ITargetGearGroupSuccessContdionT targetGearGroupSuccessContdionT = new ITargetGearGroupSuccessContdionT();
			this.UnPackTo(targetGearGroupSuccessContdionT);
			return targetGearGroupSuccessContdionT;
		}

		// Token: 0x0602741C RID: 160796 RVA: 0x00566D8B File Offset: 0x00564F8B
		public void UnPackTo(ITargetGearGroupSuccessContdionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602741D RID: 160797 RVA: 0x00566D9C File Offset: 0x00564F9C
		public static Offset<ITargetGearGroupSuccessContdion> Pack(FlatBufferBuilder builder, ITargetGearGroupSuccessContdionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupSuccessContdion>);
			}
			return ITargetGearGroupSuccessContdion.CreateITargetGearGroupSuccessContdion(builder, _o.Type);
		}

		// Token: 0x0400F0A0 RID: 61600
		private Table __p;
	}
}
