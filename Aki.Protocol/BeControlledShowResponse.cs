using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000190 RID: 400
	[NetMessage(EMessageId.BeControlledShowResponse)]
	public sealed class BeControlledShowResponse : IMessage<BeControlledShowResponse>, IMessage, IEquatable<BeControlledShowResponse>, IDeepCloneable<BeControlledShowResponse>, IBufferMessage
	{
		// Token: 0x06002FC1 RID: 12225 RVA: 0x0007A364 File Offset: 0x00078564
		[NullableContext(1)]
		public static BeControlledShowResponse Create()
		{
			return new BeControlledShowResponse();
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x0007A36B File Offset: 0x0007856B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x0007A36E File Offset: 0x0007856E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledShowResponse.Descriptor;
			}
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x0007A375 File Offset: 0x00078575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowResponse()
		{
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x0007A37D File Offset: 0x0007857D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowResponse(BeControlledShowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x0007A3A2 File Offset: 0x000785A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowResponse Clone()
		{
			return new BeControlledShowResponse(this);
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x0007A3AA File Offset: 0x000785AA
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x0007A3B2 File Offset: 0x000785B2
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

		// Token: 0x06002FC9 RID: 12233 RVA: 0x0007A3BB File Offset: 0x000785BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledShowResponse);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x0007A3C9 File Offset: 0x000785C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledShowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0007A3F8 File Offset: 0x000785F8
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

		// Token: 0x06002FCC RID: 12236 RVA: 0x0007A43D File Offset: 0x0007863D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0007A44A File Offset: 0x0007864A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0007A453 File Offset: 0x00078653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x0007A488 File Offset: 0x00078688
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

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0007A4C6 File Offset: 0x000786C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledShowResponse other)
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

		// Token: 0x06002FD1 RID: 12241 RVA: 0x0007A4F7 File Offset: 0x000786F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x0007A500 File Offset: 0x00078700
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040028C6 RID: 10438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C7 RID: 10439
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040028C8 RID: 10440
		private ErrorCode errorCode_;
	}
}
