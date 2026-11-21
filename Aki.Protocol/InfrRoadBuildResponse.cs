using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DA RID: 2010
	[NetMessage(EMessageId.InfrRoadBuildResponse)]
	public sealed class InfrRoadBuildResponse : IMessage<InfrRoadBuildResponse>, IMessage, IEquatable<InfrRoadBuildResponse>, IDeepCloneable<InfrRoadBuildResponse>, IBufferMessage
	{
		// Token: 0x0600B4B5 RID: 46261 RVA: 0x001AFFAD File Offset: 0x001AE1AD
		[NullableContext(1)]
		public static InfrRoadBuildResponse Create()
		{
			return new InfrRoadBuildResponse();
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x0600B4B6 RID: 46262 RVA: 0x001AFFB4 File Offset: 0x001AE1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x0600B4B7 RID: 46263 RVA: 0x001AFFB7 File Offset: 0x001AE1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadBuildResponse.Descriptor;
			}
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x001AFFBE File Offset: 0x001AE1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildResponse()
		{
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x001AFFC6 File Offset: 0x001AE1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildResponse(InfrRoadBuildResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x001AFFEB File Offset: 0x001AE1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildResponse Clone()
		{
			return new InfrRoadBuildResponse(this);
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600B4BB RID: 46267 RVA: 0x001AFFF3 File Offset: 0x001AE1F3
		// (set) Token: 0x0600B4BC RID: 46268 RVA: 0x001AFFFB File Offset: 0x001AE1FB
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

		// Token: 0x0600B4BD RID: 46269 RVA: 0x001B0004 File Offset: 0x001AE204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadBuildResponse);
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x001B0012 File Offset: 0x001AE212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadBuildResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x001B0040 File Offset: 0x001AE240
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

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x001B0085 File Offset: 0x001AE285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x001B0092 File Offset: 0x001AE292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x001B009B File Offset: 0x001AE29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x001B00D0 File Offset: 0x001AE2D0
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

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x001B010E File Offset: 0x001AE30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrRoadBuildResponse other)
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

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x001B013F File Offset: 0x001AE33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x001B0148 File Offset: 0x001AE348
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050A8 RID: 20648
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050A9 RID: 20649
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040050AA RID: 20650
		private ErrorCode errorCode_;
	}
}
