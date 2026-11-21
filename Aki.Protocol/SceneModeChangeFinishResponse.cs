using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BB RID: 4539
	[NetMessage(EMessageId.SceneModeChangeFinishResponse)]
	public sealed class SceneModeChangeFinishResponse : IMessage<SceneModeChangeFinishResponse>, IMessage, IEquatable<SceneModeChangeFinishResponse>, IDeepCloneable<SceneModeChangeFinishResponse>, IBufferMessage
	{
		// Token: 0x060183B0 RID: 99248 RVA: 0x00386B7A File Offset: 0x00384D7A
		[NullableContext(1)]
		public static SceneModeChangeFinishResponse Create()
		{
			return new SceneModeChangeFinishResponse();
		}

		// Token: 0x1700519C RID: 20892
		// (get) Token: 0x060183B1 RID: 99249 RVA: 0x00386B81 File Offset: 0x00384D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x060183B2 RID: 99250 RVA: 0x00386B84 File Offset: 0x00384D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneModeChangeFinishResponse.Descriptor;
			}
		}

		// Token: 0x060183B3 RID: 99251 RVA: 0x00386B8B File Offset: 0x00384D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishResponse()
		{
		}

		// Token: 0x060183B4 RID: 99252 RVA: 0x00386B93 File Offset: 0x00384D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishResponse(SceneModeChangeFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183B5 RID: 99253 RVA: 0x00386BB8 File Offset: 0x00384DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishResponse Clone()
		{
			return new SceneModeChangeFinishResponse(this);
		}

		// Token: 0x1700519E RID: 20894
		// (get) Token: 0x060183B6 RID: 99254 RVA: 0x00386BC0 File Offset: 0x00384DC0
		// (set) Token: 0x060183B7 RID: 99255 RVA: 0x00386BC8 File Offset: 0x00384DC8
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

		// Token: 0x060183B8 RID: 99256 RVA: 0x00386BD1 File Offset: 0x00384DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneModeChangeFinishResponse);
		}

		// Token: 0x060183B9 RID: 99257 RVA: 0x00386BDF File Offset: 0x00384DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneModeChangeFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183BA RID: 99258 RVA: 0x00386C10 File Offset: 0x00384E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060183BB RID: 99259 RVA: 0x00386C55 File Offset: 0x00384E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183BC RID: 99260 RVA: 0x00386C62 File Offset: 0x00384E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183BD RID: 99261 RVA: 0x00386C6B File Offset: 0x00384E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183BE RID: 99262 RVA: 0x00386CA0 File Offset: 0x00384EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060183BF RID: 99263 RVA: 0x00386CDE File Offset: 0x00384EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneModeChangeFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060183C0 RID: 99264 RVA: 0x00386D0F File Offset: 0x00384F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183C1 RID: 99265 RVA: 0x00386D18 File Offset: 0x00384F18
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009005 RID: 36869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009006 RID: 36870
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009007 RID: 36871
		private ErrorCode errorCode_;
	}
}
