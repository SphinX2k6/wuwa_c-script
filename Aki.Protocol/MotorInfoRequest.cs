using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A60 RID: 2656
	[NetMessage(EMessageId.MotorInfoRequest)]
	public sealed class MotorInfoRequest : IMessage<MotorInfoRequest>, IMessage, IEquatable<MotorInfoRequest>, IDeepCloneable<MotorInfoRequest>, IBufferMessage
	{
		// Token: 0x0600E7FB RID: 59387 RVA: 0x0021E8F2 File Offset: 0x0021CAF2
		[NullableContext(1)]
		public static MotorInfoRequest Create()
		{
			return new MotorInfoRequest();
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600E7FC RID: 59388 RVA: 0x0021E8F9 File Offset: 0x0021CAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600E7FD RID: 59389 RVA: 0x0021E8FC File Offset: 0x0021CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600E7FE RID: 59390 RVA: 0x0021E903 File Offset: 0x0021CB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoRequest()
		{
		}

		// Token: 0x0600E7FF RID: 59391 RVA: 0x0021E90B File Offset: 0x0021CB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoRequest(MotorInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E800 RID: 59392 RVA: 0x0021E924 File Offset: 0x0021CB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoRequest Clone()
		{
			return new MotorInfoRequest(this);
		}

		// Token: 0x0600E801 RID: 59393 RVA: 0x0021E92C File Offset: 0x0021CB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorInfoRequest);
		}

		// Token: 0x0600E802 RID: 59394 RVA: 0x0021E93A File Offset: 0x0021CB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E803 RID: 59395 RVA: 0x0021E958 File Offset: 0x0021CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E804 RID: 59396 RVA: 0x0021E97E File Offset: 0x0021CB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E805 RID: 59397 RVA: 0x0021E98B File Offset: 0x0021CB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x0021E994 File Offset: 0x0021CB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E807 RID: 59399 RVA: 0x0021E9AC File Offset: 0x0021CBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E808 RID: 59400 RVA: 0x0021E9D2 File Offset: 0x0021CBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E809 RID: 59401 RVA: 0x0021E9EF File Offset: 0x0021CBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E80A RID: 59402 RVA: 0x0021E9F8 File Offset: 0x0021CBF8
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005EE1 RID: 24289
		private UnknownFieldSet _unknownFields;
	}
}
