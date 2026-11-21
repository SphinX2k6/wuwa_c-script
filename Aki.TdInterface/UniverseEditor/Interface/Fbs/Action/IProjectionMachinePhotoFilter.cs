using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007534 RID: 30004
	public struct IProjectionMachinePhotoFilter : IFlatbufferObject
	{
		// Token: 0x1700DCBE RID: 56510
		// (get) Token: 0x060349D9 RID: 215513 RVA: 0x007147EB File Offset: 0x007129EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060349DA RID: 215514 RVA: 0x007147F8 File Offset: 0x007129F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060349DB RID: 215515 RVA: 0x00714800 File Offset: 0x00712A00
		public static IProjectionMachinePhotoFilter GetRootAsIProjectionMachinePhotoFilter(ByteBuffer _bb)
		{
			return IProjectionMachinePhotoFilter.GetRootAsIProjectionMachinePhotoFilter(_bb, default(IProjectionMachinePhotoFilter));
		}

		// Token: 0x060349DC RID: 215516 RVA: 0x0071481C File Offset: 0x00712A1C
		public static IProjectionMachinePhotoFilter GetRootAsIProjectionMachinePhotoFilter(ByteBuffer _bb, IProjectionMachinePhotoFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060349DD RID: 215517 RVA: 0x00714839 File Offset: 0x00712A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060349DE RID: 215518 RVA: 0x00714848 File Offset: 0x00712A48
		public IProjectionMachinePhotoFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCBF RID: 56511
		// (get) Token: 0x060349DF RID: 215519 RVA: 0x00714858 File Offset: 0x00712A58
		public float DefaultParam1
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

		// Token: 0x1700DCC0 RID: 56512
		// (get) Token: 0x060349E0 RID: 215520 RVA: 0x00714898 File Offset: 0x00712A98
		public float DefaultParam2
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DCC1 RID: 56513
		// (get) Token: 0x060349E1 RID: 215521 RVA: 0x007148D8 File Offset: 0x00712AD8
		public float TargetParam1
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DCC2 RID: 56514
		// (get) Token: 0x060349E2 RID: 215522 RVA: 0x00714918 File Offset: 0x00712B18
		public float TargetParam2
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060349E3 RID: 215523 RVA: 0x00714959 File Offset: 0x00712B59
		public static Offset<IProjectionMachinePhotoFilter> CreateIProjectionMachinePhotoFilter(FlatBufferBuilder builder, float DefaultParam1 = 0f, float DefaultParam2 = 0f, float TargetParam1 = 0f, float TargetParam2 = 0f)
		{
			builder.StartTable(4);
			IProjectionMachinePhotoFilter.AddTargetParam2(builder, TargetParam2);
			IProjectionMachinePhotoFilter.AddTargetParam1(builder, TargetParam1);
			IProjectionMachinePhotoFilter.AddDefaultParam2(builder, DefaultParam2);
			IProjectionMachinePhotoFilter.AddDefaultParam1(builder, DefaultParam1);
			return IProjectionMachinePhotoFilter.EndIProjectionMachinePhotoFilter(builder);
		}

		// Token: 0x060349E4 RID: 215524 RVA: 0x00714985 File Offset: 0x00712B85
		public static void StartIProjectionMachinePhotoFilter(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060349E5 RID: 215525 RVA: 0x0071498E File Offset: 0x00712B8E
		public static void AddDefaultParam1(FlatBufferBuilder builder, float defaultParam1)
		{
			builder.AddFloat(0, defaultParam1, 0.0);
		}

		// Token: 0x060349E6 RID: 215526 RVA: 0x007149A1 File Offset: 0x00712BA1
		public static void AddDefaultParam2(FlatBufferBuilder builder, float defaultParam2)
		{
			builder.AddFloat(1, defaultParam2, 0.0);
		}

		// Token: 0x060349E7 RID: 215527 RVA: 0x007149B4 File Offset: 0x00712BB4
		public static void AddTargetParam1(FlatBufferBuilder builder, float targetParam1)
		{
			builder.AddFloat(2, targetParam1, 0.0);
		}

		// Token: 0x060349E8 RID: 215528 RVA: 0x007149C7 File Offset: 0x00712BC7
		public static void AddTargetParam2(FlatBufferBuilder builder, float targetParam2)
		{
			builder.AddFloat(3, targetParam2, 0.0);
		}

		// Token: 0x060349E9 RID: 215529 RVA: 0x007149DA File Offset: 0x00712BDA
		public static Offset<IProjectionMachinePhotoFilter> EndIProjectionMachinePhotoFilter(FlatBufferBuilder builder)
		{
			return new Offset<IProjectionMachinePhotoFilter>(builder.EndTable());
		}

		// Token: 0x060349EA RID: 215530 RVA: 0x007149E8 File Offset: 0x00712BE8
		public IProjectionMachinePhotoFilterT UnPack()
		{
			IProjectionMachinePhotoFilterT projectionMachinePhotoFilterT = new IProjectionMachinePhotoFilterT();
			this.UnPackTo(projectionMachinePhotoFilterT);
			return projectionMachinePhotoFilterT;
		}

		// Token: 0x060349EB RID: 215531 RVA: 0x00714A03 File Offset: 0x00712C03
		public void UnPackTo(IProjectionMachinePhotoFilterT _o)
		{
			_o.DefaultParam1 = this.DefaultParam1;
			_o.DefaultParam2 = this.DefaultParam2;
			_o.TargetParam1 = this.TargetParam1;
			_o.TargetParam2 = this.TargetParam2;
		}

		// Token: 0x060349EC RID: 215532 RVA: 0x00714A38 File Offset: 0x00712C38
		public static Offset<IProjectionMachinePhotoFilter> Pack(FlatBufferBuilder builder, IProjectionMachinePhotoFilterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectionMachinePhotoFilter>);
			}
			return IProjectionMachinePhotoFilter.CreateIProjectionMachinePhotoFilter(builder, _o.DefaultParam1, _o.DefaultParam2, _o.TargetParam1, _o.TargetParam2);
		}

		// Token: 0x04012712 RID: 75538
		private Table __p;
	}
}
