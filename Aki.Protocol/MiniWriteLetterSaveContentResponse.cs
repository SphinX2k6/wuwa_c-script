using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C8 RID: 2504
	[NetMessage(EMessageId.MiniWriteLetterSaveContentResponse)]
	public sealed class MiniWriteLetterSaveContentResponse : IMessage<MiniWriteLetterSaveContentResponse>, IMessage, IEquatable<MiniWriteLetterSaveContentResponse>, IDeepCloneable<MiniWriteLetterSaveContentResponse>, IBufferMessage
	{
		// Token: 0x0600DBEA RID: 56298 RVA: 0x00204DB5 File Offset: 0x00202FB5
		[NullableContext(1)]
		public static MiniWriteLetterSaveContentResponse Create()
		{
			return new MiniWriteLetterSaveContentResponse();
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x0600DBEB RID: 56299 RVA: 0x00204DBC File Offset: 0x00202FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x00204DBF File Offset: 0x00202FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniWriteLetterSaveContentResponse.Descriptor;
			}
		}

		// Token: 0x0600DBED RID: 56301 RVA: 0x00204DC6 File Offset: 0x00202FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentResponse()
		{
		}

		// Token: 0x0600DBEE RID: 56302 RVA: 0x00204DCE File Offset: 0x00202FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentResponse(MiniWriteLetterSaveContentResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x00204DF3 File Offset: 0x00202FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentResponse Clone()
		{
			return new MiniWriteLetterSaveContentResponse(this);
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0600DBF0 RID: 56304 RVA: 0x00204DFB File Offset: 0x00202FFB
		// (set) Token: 0x0600DBF1 RID: 56305 RVA: 0x00204E03 File Offset: 0x00203003
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

		// Token: 0x0600DBF2 RID: 56306 RVA: 0x00204E0C File Offset: 0x0020300C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniWriteLetterSaveContentResponse);
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x00204E1A File Offset: 0x0020301A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniWriteLetterSaveContentResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x00204E48 File Offset: 0x00203048
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

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00204E8D File Offset: 0x0020308D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBF6 RID: 56310 RVA: 0x00204E9A File Offset: 0x0020309A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBF7 RID: 56311 RVA: 0x00204EA3 File Offset: 0x002030A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBF8 RID: 56312 RVA: 0x00204ED8 File Offset: 0x002030D8
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

		// Token: 0x0600DBF9 RID: 56313 RVA: 0x00204F16 File Offset: 0x00203116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniWriteLetterSaveContentResponse other)
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

		// Token: 0x0600DBFA RID: 56314 RVA: 0x00204F47 File Offset: 0x00203147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBFB RID: 56315 RVA: 0x00204F50 File Offset: 0x00203150
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B82 RID: 23426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B83 RID: 23427
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x04005B84 RID: 23428
		private ErrorCode errorId_;
	}
}
