using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D7 RID: 5079
	[NetMessage(EMessageId.TraceQuestResponse)]
	public sealed class TraceQuestResponse : IMessage<TraceQuestResponse>, IMessage, IEquatable<TraceQuestResponse>, IDeepCloneable<TraceQuestResponse>, IBufferMessage
	{
		// Token: 0x0601AEEB RID: 110315 RVA: 0x003E734A File Offset: 0x003E554A
		[NullableContext(1)]
		public static TraceQuestResponse Create()
		{
			return new TraceQuestResponse();
		}

		// Token: 0x17005AD0 RID: 23248
		// (get) Token: 0x0601AEEC RID: 110316 RVA: 0x003E7351 File Offset: 0x003E5551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x0601AEED RID: 110317 RVA: 0x003E7354 File Offset: 0x003E5554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceQuestResponse.Descriptor;
			}
		}

		// Token: 0x0601AEEE RID: 110318 RVA: 0x003E735B File Offset: 0x003E555B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestResponse()
		{
		}

		// Token: 0x0601AEEF RID: 110319 RVA: 0x003E7363 File Offset: 0x003E5563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestResponse(TraceQuestResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEF0 RID: 110320 RVA: 0x003E7388 File Offset: 0x003E5588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestResponse Clone()
		{
			return new TraceQuestResponse(this);
		}

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x0601AEF1 RID: 110321 RVA: 0x003E7390 File Offset: 0x003E5590
		// (set) Token: 0x0601AEF2 RID: 110322 RVA: 0x003E7398 File Offset: 0x003E5598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601AEF3 RID: 110323 RVA: 0x003E73A1 File Offset: 0x003E55A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceQuestResponse);
		}

		// Token: 0x0601AEF4 RID: 110324 RVA: 0x003E73AF File Offset: 0x003E55AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceQuestResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEF5 RID: 110325 RVA: 0x003E73E0 File Offset: 0x003E55E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AEF6 RID: 110326 RVA: 0x003E7425 File Offset: 0x003E5625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEF7 RID: 110327 RVA: 0x003E7432 File Offset: 0x003E5632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEF8 RID: 110328 RVA: 0x003E743B File Offset: 0x003E563B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AEF9 RID: 110329 RVA: 0x003E746C File Offset: 0x003E566C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AEFA RID: 110330 RVA: 0x003E74AA File Offset: 0x003E56AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceQuestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AEFB RID: 110331 RVA: 0x003E74DB File Offset: 0x003E56DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEFC RID: 110332 RVA: 0x003E74E4 File Offset: 0x003E56E4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C20 RID: 39968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C21 RID: 39969
		public const int ErrorIdFieldNumber = 1;

		// Token: 0x04009C22 RID: 39970
		private ErrorCode errorId_;
	}
}
