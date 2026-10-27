using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CF RID: 2511
	[NetMessage(EMessageId.MaterialResponse)]
	public sealed class MaterialResponse : IMessage<MaterialResponse>, IMessage, IEquatable<MaterialResponse>, IDeepCloneable<MaterialResponse>, IBufferMessage
	{
		// Token: 0x0600DC41 RID: 56385 RVA: 0x0020581E File Offset: 0x00203A1E
		[NullableContext(1)]
		public static MaterialResponse Create()
		{
			return new MaterialResponse();
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x0600DC42 RID: 56386 RVA: 0x00205825 File Offset: 0x00203A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x0600DC43 RID: 56387 RVA: 0x00205828 File Offset: 0x00203A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialResponse.Descriptor;
			}
		}

		// Token: 0x0600DC44 RID: 56388 RVA: 0x0020582F File Offset: 0x00203A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse()
		{
		}

		// Token: 0x0600DC45 RID: 56389 RVA: 0x00205837 File Offset: 0x00203A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse(MaterialResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC46 RID: 56390 RVA: 0x0020585C File Offset: 0x00203A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialResponse Clone()
		{
			return new MaterialResponse(this);
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0600DC47 RID: 56391 RVA: 0x00205864 File Offset: 0x00203A64
		// (set) Token: 0x0600DC48 RID: 56392 RVA: 0x0020586C File Offset: 0x00203A6C
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

		// Token: 0x0600DC49 RID: 56393 RVA: 0x00205875 File Offset: 0x00203A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialResponse);
		}

		// Token: 0x0600DC4A RID: 56394 RVA: 0x00205883 File Offset: 0x00203A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC4B RID: 56395 RVA: 0x002058B4 File Offset: 0x00203AB4
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

		// Token: 0x0600DC4C RID: 56396 RVA: 0x002058F9 File Offset: 0x00203AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC4D RID: 56397 RVA: 0x00205906 File Offset: 0x00203B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC4E RID: 56398 RVA: 0x0020590F File Offset: 0x00203B0F
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

		// Token: 0x0600DC4F RID: 56399 RVA: 0x00205940 File Offset: 0x00203B40
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

		// Token: 0x0600DC50 RID: 56400 RVA: 0x0020597E File Offset: 0x00203B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialResponse other)
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

		// Token: 0x0600DC51 RID: 56401 RVA: 0x002059AF File Offset: 0x00203BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC52 RID: 56402 RVA: 0x002059B8 File Offset: 0x00203BB8
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

		// Token: 0x04005B4A RID: 23370
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B4B RID: 23371
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04005B4C RID: 23372
		private ErrorCode errorCode_;
	}
}
