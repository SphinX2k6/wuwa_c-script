using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7F RID: 3967
	[NetMessage(EMessageId.RogueArchiveSaveResponse)]
	public sealed class RogueArchiveSaveResponse : IMessage<RogueArchiveSaveResponse>, IMessage, IEquatable<RogueArchiveSaveResponse>, IDeepCloneable<RogueArchiveSaveResponse>, IBufferMessage
	{
		// Token: 0x06015350 RID: 86864 RVA: 0x003131ED File Offset: 0x003113ED
		[NullableContext(1)]
		public static RogueArchiveSaveResponse Create()
		{
			return new RogueArchiveSaveResponse();
		}

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x06015351 RID: 86865 RVA: 0x003131F4 File Offset: 0x003113F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x06015352 RID: 86866 RVA: 0x003131F7 File Offset: 0x003113F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveSaveResponse.Descriptor;
			}
		}

		// Token: 0x06015353 RID: 86867 RVA: 0x003131FE File Offset: 0x003113FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveResponse()
		{
		}

		// Token: 0x06015354 RID: 86868 RVA: 0x00313206 File Offset: 0x00311406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveResponse(RogueArchiveSaveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.saveTime_ = other.saveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x00313237 File Offset: 0x00311437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveResponse Clone()
		{
			return new RogueArchiveSaveResponse(this);
		}

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x06015356 RID: 86870 RVA: 0x0031323F File Offset: 0x0031143F
		// (set) Token: 0x06015357 RID: 86871 RVA: 0x00313247 File Offset: 0x00311447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x06015358 RID: 86872 RVA: 0x00313250 File Offset: 0x00311450
		// (set) Token: 0x06015359 RID: 86873 RVA: 0x00313258 File Offset: 0x00311458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SaveTime
		{
			get
			{
				return this.saveTime_;
			}
			set
			{
				this.saveTime_ = value;
			}
		}

		// Token: 0x0601535A RID: 86874 RVA: 0x00313261 File Offset: 0x00311461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveSaveResponse);
		}

		// Token: 0x0601535B RID: 86875 RVA: 0x0031326F File Offset: 0x0031146F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveSaveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SaveTime == other.SaveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601535C RID: 86876 RVA: 0x003132B0 File Offset: 0x003114B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SaveTime != 0L)
			{
				num ^= this.SaveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601535D RID: 86877 RVA: 0x0031330E File Offset: 0x0031150E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601535E RID: 86878 RVA: 0x0031331B File Offset: 0x0031151B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601535F RID: 86879 RVA: 0x00313324 File Offset: 0x00311524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SaveTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SaveTime);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015360 RID: 86880 RVA: 0x00313380 File Offset: 0x00311580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SaveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SaveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015361 RID: 86881 RVA: 0x003133D8 File Offset: 0x003115D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveSaveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SaveTime != 0L)
			{
				this.SaveTime = other.SaveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015362 RID: 86882 RVA: 0x00313428 File Offset: 0x00311628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015363 RID: 86883 RVA: 0x00313434 File Offset: 0x00311634
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SaveTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007F84 RID: 32644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F85 RID: 32645
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007F86 RID: 32646
		private ErrorCode errorCode_;

		// Token: 0x04007F87 RID: 32647
		public const int SaveTimeFieldNumber = 4;

		// Token: 0x04007F88 RID: 32648
		private long saveTime_;
	}
}
