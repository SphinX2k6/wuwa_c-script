using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001366 RID: 4966
	[NetMessage(EMessageId.ThroughTrainResponse)]
	public sealed class ThroughTrainResponse : IMessage<ThroughTrainResponse>, IMessage, IEquatable<ThroughTrainResponse>, IDeepCloneable<ThroughTrainResponse>, IBufferMessage
	{
		// Token: 0x0601A5F3 RID: 108019 RVA: 0x003D4459 File Offset: 0x003D2659
		[NullableContext(1)]
		public static ThroughTrainResponse Create()
		{
			return new ThroughTrainResponse();
		}

		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x0601A5F4 RID: 108020 RVA: 0x003D4460 File Offset: 0x003D2660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x0601A5F5 RID: 108021 RVA: 0x003D4463 File Offset: 0x003D2663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainResponse.Descriptor;
			}
		}

		// Token: 0x0601A5F6 RID: 108022 RVA: 0x003D446A File Offset: 0x003D266A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainResponse()
		{
		}

		// Token: 0x0601A5F7 RID: 108023 RVA: 0x003D4472 File Offset: 0x003D2672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainResponse(ThroughTrainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5F8 RID: 108024 RVA: 0x003D4497 File Offset: 0x003D2697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainResponse Clone()
		{
			return new ThroughTrainResponse(this);
		}

		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x0601A5F9 RID: 108025 RVA: 0x003D449F File Offset: 0x003D269F
		// (set) Token: 0x0601A5FA RID: 108026 RVA: 0x003D44A7 File Offset: 0x003D26A7
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

		// Token: 0x0601A5FB RID: 108027 RVA: 0x003D44B0 File Offset: 0x003D26B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainResponse);
		}

		// Token: 0x0601A5FC RID: 108028 RVA: 0x003D44BE File Offset: 0x003D26BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5FD RID: 108029 RVA: 0x003D44EC File Offset: 0x003D26EC
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

		// Token: 0x0601A5FE RID: 108030 RVA: 0x003D4531 File Offset: 0x003D2731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5FF RID: 108031 RVA: 0x003D453E File Offset: 0x003D273E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A600 RID: 108032 RVA: 0x003D4547 File Offset: 0x003D2747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A601 RID: 108033 RVA: 0x003D4578 File Offset: 0x003D2778
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

		// Token: 0x0601A602 RID: 108034 RVA: 0x003D45B6 File Offset: 0x003D27B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainResponse other)
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

		// Token: 0x0601A603 RID: 108035 RVA: 0x003D45E7 File Offset: 0x003D27E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A604 RID: 108036 RVA: 0x003D45F0 File Offset: 0x003D27F0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400999E RID: 39326
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400999F RID: 39327
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040099A0 RID: 39328
		private ErrorCode errorCode_;
	}
}
