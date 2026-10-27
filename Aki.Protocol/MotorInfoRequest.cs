using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A71 RID: 2673
	[NetMessage(EMessageId.MotorInfoRequest)]
	public sealed class MotorInfoRequest : IMessage<MotorInfoRequest>, IMessage, IEquatable<MotorInfoRequest>, IDeepCloneable<MotorInfoRequest>, IBufferMessage
	{
		// Token: 0x0600E915 RID: 59669 RVA: 0x00220AE6 File Offset: 0x0021ECE6
		[NullableContext(1)]
		public static MotorInfoRequest Create()
		{
			return new MotorInfoRequest();
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x00220AED File Offset: 0x0021ECED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x0600E917 RID: 59671 RVA: 0x00220AF0 File Offset: 0x0021ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x00220AF7 File Offset: 0x0021ECF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoRequest()
		{
		}

		// Token: 0x0600E919 RID: 59673 RVA: 0x00220AFF File Offset: 0x0021ECFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoRequest(MotorInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E91A RID: 59674 RVA: 0x00220B18 File Offset: 0x0021ED18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoRequest Clone()
		{
			return new MotorInfoRequest(this);
		}

		// Token: 0x0600E91B RID: 59675 RVA: 0x00220B20 File Offset: 0x0021ED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorInfoRequest);
		}

		// Token: 0x0600E91C RID: 59676 RVA: 0x00220B2E File Offset: 0x0021ED2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E91D RID: 59677 RVA: 0x00220B4C File Offset: 0x0021ED4C
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

		// Token: 0x0600E91E RID: 59678 RVA: 0x00220B72 File Offset: 0x0021ED72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E91F RID: 59679 RVA: 0x00220B7F File Offset: 0x0021ED7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E920 RID: 59680 RVA: 0x00220B88 File Offset: 0x0021ED88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E921 RID: 59681 RVA: 0x00220BA0 File Offset: 0x0021EDA0
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

		// Token: 0x0600E922 RID: 59682 RVA: 0x00220BC6 File Offset: 0x0021EDC6
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

		// Token: 0x0600E923 RID: 59683 RVA: 0x00220BE3 File Offset: 0x0021EDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E924 RID: 59684 RVA: 0x00220BEC File Offset: 0x0021EDEC
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

		// Token: 0x04005ED8 RID: 24280
		private UnknownFieldSet _unknownFields;
	}
}
