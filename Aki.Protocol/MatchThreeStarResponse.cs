using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C8 RID: 2504
	[NetMessage(EMessageId.MatchThreeStarResponse)]
	public sealed class MatchThreeStarResponse : IMessage<MatchThreeStarResponse>, IMessage, IEquatable<MatchThreeStarResponse>, IDeepCloneable<MatchThreeStarResponse>, IBufferMessage
	{
		// Token: 0x0600DBB3 RID: 56243 RVA: 0x00204344 File Offset: 0x00202544
		[NullableContext(1)]
		public static MatchThreeStarResponse Create()
		{
			return new MatchThreeStarResponse();
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600DBB4 RID: 56244 RVA: 0x0020434B File Offset: 0x0020254B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600DBB5 RID: 56245 RVA: 0x0020434E File Offset: 0x0020254E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeStarResponse.Descriptor;
			}
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x00204355 File Offset: 0x00202555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarResponse()
		{
		}

		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00204368 File Offset: 0x00202568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarResponse(MatchThreeStarResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBB8 RID: 56248 RVA: 0x00204399 File Offset: 0x00202599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarResponse Clone()
		{
			return new MatchThreeStarResponse(this);
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600DBB9 RID: 56249 RVA: 0x002043A1 File Offset: 0x002025A1
		// (set) Token: 0x0600DBBA RID: 56250 RVA: 0x002043A9 File Offset: 0x002025A9
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

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0600DBBB RID: 56251 RVA: 0x002043B2 File Offset: 0x002025B2
		// (set) Token: 0x0600DBBC RID: 56252 RVA: 0x002043BA File Offset: 0x002025BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x002043CD File Offset: 0x002025CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeStarResponse);
		}

		// Token: 0x0600DBBE RID: 56254 RVA: 0x002043DC File Offset: 0x002025DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeStarResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.TraceId != other.TraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBBF RID: 56255 RVA: 0x0020442C File Offset: 0x0020262C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TraceId.Length != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x0020448C File Offset: 0x0020268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x00204499 File Offset: 0x00202699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x002044A4 File Offset: 0x002026A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00204504 File Offset: 0x00202704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x00204560 File Offset: 0x00202760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeStarResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TraceId.Length != 0)
			{
				this.TraceId = other.TraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x002045B5 File Offset: 0x002027B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x002045C0 File Offset: 0x002027C0
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
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TraceId = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B25 RID: 23333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B26 RID: 23334
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005B27 RID: 23335
		private ErrorCode errorCode_;

		// Token: 0x04005B28 RID: 23336
		public const int TraceIdFieldNumber = 5;

		// Token: 0x04005B29 RID: 23337
		private string traceId_ = "";
	}
}
