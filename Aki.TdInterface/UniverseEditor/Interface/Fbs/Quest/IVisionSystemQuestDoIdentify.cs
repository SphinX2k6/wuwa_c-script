using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D3 RID: 18131
	public struct IVisionSystemQuestDoIdentify : IFlatbufferObject
	{
		// Token: 0x17007EF6 RID: 32502
		// (get) Token: 0x0601AA60 RID: 109152 RVA: 0x003C9E27 File Offset: 0x003C8027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA61 RID: 109153 RVA: 0x003C9E34 File Offset: 0x003C8034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA62 RID: 109154 RVA: 0x003C9E3C File Offset: 0x003C803C
		public static IVisionSystemQuestDoIdentify GetRootAsIVisionSystemQuestDoIdentify(ByteBuffer _bb)
		{
			return IVisionSystemQuestDoIdentify.GetRootAsIVisionSystemQuestDoIdentify(_bb, default(IVisionSystemQuestDoIdentify));
		}

		// Token: 0x0601AA63 RID: 109155 RVA: 0x003C9E58 File Offset: 0x003C8058
		public static IVisionSystemQuestDoIdentify GetRootAsIVisionSystemQuestDoIdentify(ByteBuffer _bb, IVisionSystemQuestDoIdentify obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA64 RID: 109156 RVA: 0x003C9E75 File Offset: 0x003C8075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA65 RID: 109157 RVA: 0x003C9E84 File Offset: 0x003C8084
		public IVisionSystemQuestDoIdentify __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EF7 RID: 32503
		// (get) Token: 0x0601AA66 RID: 109158 RVA: 0x003C9E94 File Offset: 0x003C8094
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

		// Token: 0x0601AA67 RID: 109159 RVA: 0x003C9ED0 File Offset: 0x003C80D0
		public static Offset<IVisionSystemQuestDoIdentify> CreateIVisionSystemQuestDoIdentify(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel)
		{
			builder.StartTable(1);
			IVisionSystemQuestDoIdentify.AddType(builder, Type);
			return IVisionSystemQuestDoIdentify.EndIVisionSystemQuestDoIdentify(builder);
		}

		// Token: 0x0601AA68 RID: 109160 RVA: 0x003C9EE6 File Offset: 0x003C80E6
		public static void StartIVisionSystemQuestDoIdentify(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AA69 RID: 109161 RVA: 0x003C9EEF File Offset: 0x003C80EF
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA6A RID: 109162 RVA: 0x003C9EFA File Offset: 0x003C80FA
		public static Offset<IVisionSystemQuestDoIdentify> EndIVisionSystemQuestDoIdentify(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestDoIdentify>(builder.EndTable());
		}

		// Token: 0x0601AA6B RID: 109163 RVA: 0x003C9F08 File Offset: 0x003C8108
		public IVisionSystemQuestDoIdentifyT UnPack()
		{
			IVisionSystemQuestDoIdentifyT visionSystemQuestDoIdentifyT = new IVisionSystemQuestDoIdentifyT();
			this.UnPackTo(visionSystemQuestDoIdentifyT);
			return visionSystemQuestDoIdentifyT;
		}

		// Token: 0x0601AA6C RID: 109164 RVA: 0x003C9F23 File Offset: 0x003C8123
		public void UnPackTo(IVisionSystemQuestDoIdentifyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AA6D RID: 109165 RVA: 0x003C9F34 File Offset: 0x003C8134
		public static Offset<IVisionSystemQuestDoIdentify> Pack(FlatBufferBuilder builder, IVisionSystemQuestDoIdentifyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestDoIdentify>);
			}
			return IVisionSystemQuestDoIdentify.CreateIVisionSystemQuestDoIdentify(builder, _o.Type);
		}

		// Token: 0x0400C91B RID: 51483
		private Table __p;
	}
}
