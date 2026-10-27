using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000643 RID: 1603
	[NetMessage(EMessageId.FragileChangeResponse)]
	public sealed class FragileChangeResponse : IMessage<FragileChangeResponse>, IMessage, IEquatable<FragileChangeResponse>, IDeepCloneable<FragileChangeResponse>, IBufferMessage
	{
		// Token: 0x0600939B RID: 37787 RVA: 0x00165034 File Offset: 0x00163234
		[NullableContext(1)]
		public static FragileChangeResponse Create()
		{
			return new FragileChangeResponse();
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600939C RID: 37788 RVA: 0x0016503B File Offset: 0x0016323B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x0016503E File Offset: 0x0016323E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FragileChangeResponse.Descriptor;
			}
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x00165045 File Offset: 0x00163245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse()
		{
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x0016504D File Offset: 0x0016324D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse(FragileChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x00165072 File Offset: 0x00163272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse Clone()
		{
			return new FragileChangeResponse(this);
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x060093A1 RID: 37793 RVA: 0x0016507A File Offset: 0x0016327A
		// (set) Token: 0x060093A2 RID: 37794 RVA: 0x00165082 File Offset: 0x00163282
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

		// Token: 0x060093A3 RID: 37795 RVA: 0x0016508B File Offset: 0x0016328B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FragileChangeResponse);
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x00165099 File Offset: 0x00163299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FragileChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x001650C8 File Offset: 0x001632C8
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

		// Token: 0x060093A6 RID: 37798 RVA: 0x0016510D File Offset: 0x0016330D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x0016511A File Offset: 0x0016331A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x00165123 File Offset: 0x00163323
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

		// Token: 0x060093A9 RID: 37801 RVA: 0x00165158 File Offset: 0x00163358
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

		// Token: 0x060093AA RID: 37802 RVA: 0x00165196 File Offset: 0x00163396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FragileChangeResponse other)
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

		// Token: 0x060093AB RID: 37803 RVA: 0x001651C7 File Offset: 0x001633C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x001651D0 File Offset: 0x001633D0
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

		// Token: 0x040046F1 RID: 18161
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046F2 RID: 18162
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040046F3 RID: 18163
		private ErrorCode errorCode_;
	}
}
