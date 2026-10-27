using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000133 RID: 307
	[NetMessage(EMessageId.AvoidBlockClientInitDoneResponse)]
	public sealed class AvoidBlockClientInitDoneResponse : IMessage<AvoidBlockClientInitDoneResponse>, IMessage, IEquatable<AvoidBlockClientInitDoneResponse>, IDeepCloneable<AvoidBlockClientInitDoneResponse>, IBufferMessage
	{
		// Token: 0x06002867 RID: 10343 RVA: 0x0006A647 File Offset: 0x00068847
		[NullableContext(1)]
		public static AvoidBlockClientInitDoneResponse Create()
		{
			return new AvoidBlockClientInitDoneResponse();
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x0006A64E File Offset: 0x0006884E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x0006A651 File Offset: 0x00068851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockClientInitDoneResponse.Descriptor;
			}
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0006A658 File Offset: 0x00068858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneResponse()
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0006A660 File Offset: 0x00068860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneResponse(AvoidBlockClientInitDoneResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0006A685 File Offset: 0x00068885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneResponse Clone()
		{
			return new AvoidBlockClientInitDoneResponse(this);
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0006A68D File Offset: 0x0006888D
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x0006A695 File Offset: 0x00068895
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

		// Token: 0x0600286F RID: 10351 RVA: 0x0006A69E File Offset: 0x0006889E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockClientInitDoneResponse);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0006A6AC File Offset: 0x000688AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockClientInitDoneResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0006A6DC File Offset: 0x000688DC
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

		// Token: 0x06002872 RID: 10354 RVA: 0x0006A721 File Offset: 0x00068921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x0006A72E File Offset: 0x0006892E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0006A737 File Offset: 0x00068937
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

		// Token: 0x06002875 RID: 10357 RVA: 0x0006A768 File Offset: 0x00068968
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

		// Token: 0x06002876 RID: 10358 RVA: 0x0006A7A6 File Offset: 0x000689A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockClientInitDoneResponse other)
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

		// Token: 0x06002877 RID: 10359 RVA: 0x0006A7D7 File Offset: 0x000689D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0006A7E0 File Offset: 0x000689E0
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

		// Token: 0x040026A1 RID: 9889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026A2 RID: 9890
		public const int ErrorIdFieldNumber = 1;

		// Token: 0x040026A3 RID: 9891
		private ErrorCode errorId_;
	}
}
