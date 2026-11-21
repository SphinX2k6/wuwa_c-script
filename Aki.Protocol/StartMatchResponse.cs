using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FC RID: 4860
	[NetMessage(EMessageId.StartMatchResponse)]
	public sealed class StartMatchResponse : IMessage<StartMatchResponse>, IMessage, IEquatable<StartMatchResponse>, IDeepCloneable<StartMatchResponse>, IBufferMessage
	{
		// Token: 0x06019ED0 RID: 106192 RVA: 0x003C7E1E File Offset: 0x003C601E
		[NullableContext(1)]
		public static StartMatchResponse Create()
		{
			return new StartMatchResponse();
		}

		// Token: 0x170057CE RID: 22478
		// (get) Token: 0x06019ED1 RID: 106193 RVA: 0x003C7E25 File Offset: 0x003C6025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x06019ED2 RID: 106194 RVA: 0x003C7E28 File Offset: 0x003C6028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchResponse.Descriptor;
			}
		}

		// Token: 0x06019ED3 RID: 106195 RVA: 0x003C7E2F File Offset: 0x003C602F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchResponse()
		{
		}

		// Token: 0x06019ED4 RID: 106196 RVA: 0x003C7E37 File Offset: 0x003C6037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchResponse(StartMatchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019ED5 RID: 106197 RVA: 0x003C7E5C File Offset: 0x003C605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchResponse Clone()
		{
			return new StartMatchResponse(this);
		}

		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x06019ED6 RID: 106198 RVA: 0x003C7E64 File Offset: 0x003C6064
		// (set) Token: 0x06019ED7 RID: 106199 RVA: 0x003C7E6C File Offset: 0x003C606C
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

		// Token: 0x06019ED8 RID: 106200 RVA: 0x003C7E75 File Offset: 0x003C6075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchResponse);
		}

		// Token: 0x06019ED9 RID: 106201 RVA: 0x003C7E83 File Offset: 0x003C6083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019EDA RID: 106202 RVA: 0x003C7EB4 File Offset: 0x003C60B4
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

		// Token: 0x06019EDB RID: 106203 RVA: 0x003C7EF9 File Offset: 0x003C60F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EDC RID: 106204 RVA: 0x003C7F06 File Offset: 0x003C6106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EDD RID: 106205 RVA: 0x003C7F0F File Offset: 0x003C610F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EDE RID: 106206 RVA: 0x003C7F44 File Offset: 0x003C6144
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

		// Token: 0x06019EDF RID: 106207 RVA: 0x003C7F82 File Offset: 0x003C6182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchResponse other)
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

		// Token: 0x06019EE0 RID: 106208 RVA: 0x003C7FB3 File Offset: 0x003C61B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EE1 RID: 106209 RVA: 0x003C7FBC File Offset: 0x003C61BC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040098DA RID: 39130
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098DB RID: 39131
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040098DC RID: 39132
		private ErrorCode errorCode_;
	}
}
