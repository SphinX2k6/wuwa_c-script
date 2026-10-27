using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004277 RID: 17015
	public struct IVisionSystemQuestDoIdentify : IFlatbufferObject
	{
		// Token: 0x170078C5 RID: 30917
		// (get) Token: 0x060192F4 RID: 103156 RVA: 0x0039E74F File Offset: 0x0039C94F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192F5 RID: 103157 RVA: 0x0039E75C File Offset: 0x0039C95C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192F6 RID: 103158 RVA: 0x0039E764 File Offset: 0x0039C964
		public static IVisionSystemQuestDoIdentify GetRootAsIVisionSystemQuestDoIdentify(ByteBuffer _bb)
		{
			return IVisionSystemQuestDoIdentify.GetRootAsIVisionSystemQuestDoIdentify(_bb, default(IVisionSystemQuestDoIdentify));
		}

		// Token: 0x060192F7 RID: 103159 RVA: 0x0039E780 File Offset: 0x0039C980
		public static IVisionSystemQuestDoIdentify GetRootAsIVisionSystemQuestDoIdentify(ByteBuffer _bb, IVisionSystemQuestDoIdentify obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192F8 RID: 103160 RVA: 0x0039E79D File Offset: 0x0039C99D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192F9 RID: 103161 RVA: 0x0039E7AC File Offset: 0x0039C9AC
		public IVisionSystemQuestDoIdentify __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078C6 RID: 30918
		// (get) Token: 0x060192FA RID: 103162 RVA: 0x0039E7BC File Offset: 0x0039C9BC
		public EVisionSystemQuestType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisionSystemQuestType.HasVisionGetTargetLevel;
				}
				return (EVisionSystemQuestType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060192FB RID: 103163 RVA: 0x0039E7F8 File Offset: 0x0039C9F8
		public static Offset<IVisionSystemQuestDoIdentify> CreateIVisionSystemQuestDoIdentify(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel)
		{
			builder.StartTable(1);
			IVisionSystemQuestDoIdentify.AddType(builder, Type);
			return IVisionSystemQuestDoIdentify.EndIVisionSystemQuestDoIdentify(builder);
		}

		// Token: 0x060192FC RID: 103164 RVA: 0x0039E80E File Offset: 0x0039CA0E
		public static void StartIVisionSystemQuestDoIdentify(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060192FD RID: 103165 RVA: 0x0039E817 File Offset: 0x0039CA17
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192FE RID: 103166 RVA: 0x0039E822 File Offset: 0x0039CA22
		public static Offset<IVisionSystemQuestDoIdentify> EndIVisionSystemQuestDoIdentify(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestDoIdentify>(builder.EndTable());
		}

		// Token: 0x060192FF RID: 103167 RVA: 0x0039E830 File Offset: 0x0039CA30
		public IVisionSystemQuestDoIdentifyT UnPack()
		{
			IVisionSystemQuestDoIdentifyT visionSystemQuestDoIdentifyT = new IVisionSystemQuestDoIdentifyT();
			this.UnPackTo(visionSystemQuestDoIdentifyT);
			return visionSystemQuestDoIdentifyT;
		}

		// Token: 0x06019300 RID: 103168 RVA: 0x0039E84B File Offset: 0x0039CA4B
		public void UnPackTo(IVisionSystemQuestDoIdentifyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019301 RID: 103169 RVA: 0x0039E85C File Offset: 0x0039CA5C
		public static Offset<IVisionSystemQuestDoIdentify> Pack(FlatBufferBuilder builder, IVisionSystemQuestDoIdentifyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestDoIdentify>);
			}
			return IVisionSystemQuestDoIdentify.CreateIVisionSystemQuestDoIdentify(builder, _o.Type);
		}

		// Token: 0x0400BF0E RID: 48910
		private Table __p;
	}
}
