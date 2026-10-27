using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D6 RID: 5078
	[NetMessage(EMessageId.TraceQuestRequest)]
	public sealed class TraceQuestRequest : IMessage<TraceQuestRequest>, IMessage, IEquatable<TraceQuestRequest>, IDeepCloneable<TraceQuestRequest>, IBufferMessage
	{
		// Token: 0x0601AED5 RID: 110293 RVA: 0x003E7009 File Offset: 0x003E5209
		[NullableContext(1)]
		public static TraceQuestRequest Create()
		{
			return new TraceQuestRequest();
		}

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x0601AED6 RID: 110294 RVA: 0x003E7010 File Offset: 0x003E5210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ACC RID: 23244
		// (get) Token: 0x0601AED7 RID: 110295 RVA: 0x003E7013 File Offset: 0x003E5213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceQuestRequest.Descriptor;
			}
		}

		// Token: 0x0601AED8 RID: 110296 RVA: 0x003E701A File Offset: 0x003E521A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestRequest()
		{
		}

		// Token: 0x0601AED9 RID: 110297 RVA: 0x003E7022 File Offset: 0x003E5222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestRequest(TraceQuestRequest other) : this()
		{
			this.traceType_ = other.traceType_;
			this.questId_ = other.questId_;
			this.operate_ = other.operate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEDA RID: 110298 RVA: 0x003E705F File Offset: 0x003E525F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestRequest Clone()
		{
			return new TraceQuestRequest(this);
		}

		// Token: 0x17005ACD RID: 23245
		// (get) Token: 0x0601AEDB RID: 110299 RVA: 0x003E7067 File Offset: 0x003E5267
		// (set) Token: 0x0601AEDC RID: 110300 RVA: 0x003E706F File Offset: 0x003E526F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TraceType
		{
			get
			{
				return this.traceType_;
			}
			set
			{
				this.traceType_ = value;
			}
		}

		// Token: 0x17005ACE RID: 23246
		// (get) Token: 0x0601AEDD RID: 110301 RVA: 0x003E7078 File Offset: 0x003E5278
		// (set) Token: 0x0601AEDE RID: 110302 RVA: 0x003E7080 File Offset: 0x003E5280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x17005ACF RID: 23247
		// (get) Token: 0x0601AEDF RID: 110303 RVA: 0x003E7089 File Offset: 0x003E5289
		// (set) Token: 0x0601AEE0 RID: 110304 RVA: 0x003E7091 File Offset: 0x003E5291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Operate
		{
			get
			{
				return this.operate_;
			}
			set
			{
				this.operate_ = value;
			}
		}

		// Token: 0x0601AEE1 RID: 110305 RVA: 0x003E709A File Offset: 0x003E529A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceQuestRequest);
		}

		// Token: 0x0601AEE2 RID: 110306 RVA: 0x003E70A8 File Offset: 0x003E52A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceQuestRequest other)
		{
			return other != null && (other == this || (this.TraceType == other.TraceType && this.QuestId == other.QuestId && this.Operate == other.Operate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEE3 RID: 110307 RVA: 0x003E7104 File Offset: 0x003E5304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TraceType != 0)
			{
				num ^= this.TraceType.GetHashCode();
			}
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Operate != 0)
			{
				num ^= this.Operate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AEE4 RID: 110308 RVA: 0x003E7175 File Offset: 0x003E5375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEE5 RID: 110309 RVA: 0x003E7182 File Offset: 0x003E5382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEE6 RID: 110310 RVA: 0x003E718C File Offset: 0x003E538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Operate != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Operate);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuestId);
			}
			if (this.TraceType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TraceType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AEE7 RID: 110311 RVA: 0x003E7200 File Offset: 0x003E5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TraceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceType);
			}
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Operate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AEE8 RID: 110312 RVA: 0x003E7270 File Offset: 0x003E5470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceQuestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TraceType != 0)
			{
				this.TraceType = other.TraceType;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Operate != 0)
			{
				this.Operate = other.Operate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AEE9 RID: 110313 RVA: 0x003E72D4 File Offset: 0x003E54D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEEA RID: 110314 RVA: 0x003E72E0 File Offset: 0x003E54E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TraceType = input.ReadInt32();
						}
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Operate = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C19 RID: 39961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C1A RID: 39962
		public const int TraceTypeFieldNumber = 9;

		// Token: 0x04009C1B RID: 39963
		private int traceType_;

		// Token: 0x04009C1C RID: 39964
		public const int QuestIdFieldNumber = 3;

		// Token: 0x04009C1D RID: 39965
		private int questId_;

		// Token: 0x04009C1E RID: 39966
		public const int OperateFieldNumber = 1;

		// Token: 0x04009C1F RID: 39967
		private int operate_;
	}
}
