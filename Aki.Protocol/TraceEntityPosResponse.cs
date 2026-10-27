using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D1 RID: 5073
	[NetMessage(EMessageId.TraceEntityPosResponse)]
	public sealed class TraceEntityPosResponse : IMessage<TraceEntityPosResponse>, IMessage, IEquatable<TraceEntityPosResponse>, IDeepCloneable<TraceEntityPosResponse>, IBufferMessage
	{
		// Token: 0x0601AE79 RID: 110201 RVA: 0x003E65B4 File Offset: 0x003E47B4
		[NullableContext(1)]
		public static TraceEntityPosResponse Create()
		{
			return new TraceEntityPosResponse();
		}

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x0601AE7A RID: 110202 RVA: 0x003E65BB File Offset: 0x003E47BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ABC RID: 23228
		// (get) Token: 0x0601AE7B RID: 110203 RVA: 0x003E65BE File Offset: 0x003E47BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceEntityPosResponse.Descriptor;
			}
		}

		// Token: 0x0601AE7C RID: 110204 RVA: 0x003E65C5 File Offset: 0x003E47C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosResponse()
		{
		}

		// Token: 0x0601AE7D RID: 110205 RVA: 0x003E65D0 File Offset: 0x003E47D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosResponse(TraceEntityPosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE7E RID: 110206 RVA: 0x003E661C File Offset: 0x003E481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosResponse Clone()
		{
			return new TraceEntityPosResponse(this);
		}

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x0601AE7F RID: 110207 RVA: 0x003E6624 File Offset: 0x003E4824
		// (set) Token: 0x0601AE80 RID: 110208 RVA: 0x003E662C File Offset: 0x003E482C
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

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x0601AE81 RID: 110209 RVA: 0x003E6635 File Offset: 0x003E4835
		// (set) Token: 0x0601AE82 RID: 110210 RVA: 0x003E663D File Offset: 0x003E483D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0601AE83 RID: 110211 RVA: 0x003E6646 File Offset: 0x003E4846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceEntityPosResponse);
		}

		// Token: 0x0601AE84 RID: 110212 RVA: 0x003E6654 File Offset: 0x003E4854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceEntityPosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE85 RID: 110213 RVA: 0x003E66A4 File Offset: 0x003E48A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE86 RID: 110214 RVA: 0x003E66FF File Offset: 0x003E48FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE87 RID: 110215 RVA: 0x003E670C File Offset: 0x003E490C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE88 RID: 110216 RVA: 0x003E6718 File Offset: 0x003E4918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Pos);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE89 RID: 110217 RVA: 0x003E6774 File Offset: 0x003E4974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE8A RID: 110218 RVA: 0x003E67CC File Offset: 0x003E49CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceEntityPosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE8B RID: 110219 RVA: 0x003E6834 File Offset: 0x003E4A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE8C RID: 110220 RVA: 0x003E6840 File Offset: 0x003E4A40
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
				if (num != 26U)
				{
					if (num != 120U)
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
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x04009C08 RID: 39944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C09 RID: 39945
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009C0A RID: 39946
		private ErrorCode errorCode_;

		// Token: 0x04009C0B RID: 39947
		public const int PosFieldNumber = 3;

		// Token: 0x04009C0C RID: 39948
		private Vector pos_;
	}
}
